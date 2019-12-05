using System;
using System.Globalization;
using System.IO;
using EVEStandard;
using EVEStandard.Enumerations;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Navigator.Cache;
using Navigator.DAL;
using Navigator.Interfaces;
using Navigator.MiddleWare;
using Navigator.Repositories;
using Navigator.Services;
using Newtonsoft.Json;

namespace Navigator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<EveScoutService>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Add cookie authentication and set the login url
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => { options.LoginPath = "/Auth/Login"; });

            if (File.Exists(SecretsFileName) == false)
            {
                throw new InvalidOperationException("You need to have a secrets file setup");
            }
            var secrets = JsonConvert.DeserializeObject<Secrets>(File.ReadAllText(SecretsFileName));
            // Register your application at: https://developers.eveonline.com/applications to obtain client ID and secret key and add them to user secrets
            // by right-clicking the solution and selecting Manage User Secrets.
            // Also, modify the callback URL in appsettings.json to match with your environment.

            // Initialize the client
            var esiClient = new EVEStandardAPI(
                "EVEAsset.Navigator", // User agent
                DataSource.Tranquility, // Server [Tranquility/Singularity]
                TimeSpan.FromSeconds(30), // Timeout
                Configuration["SSOCallbackUrl"],
                secrets.ClientId,
                secrets.SecretKey);

            // Register with DI container
            services.AddSingleton(esiClient);

            // Session is required 
            services.AddSession();

            services.AddMemoryCache();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var tranquilityContext = new TranquilityContext(new DbContextOptions<TranquilityContext>());
            tranquilityContext.ConfigureServices(services, secrets.SdeConnectionString);

            var navigatorContext = new NavigatorContext(new DbContextOptions<NavigatorContext>());
            navigatorContext.ConfigureServices(services, secrets.NavigatorConnectionString);

            services.AddSingleton(typeof(TranquilityContext), tranquilityContext);
            services.AddSingleton(typeof(NavigatorContext), navigatorContext);
            services.AddSingleton<IUniverseCache, UniverseCache>();
            services.AddSingleton<IStaticDataRepository, StaticDataRepository>();
            services.AddSingleton<IJumpCache, JumpCache>();
        }

        private static string SecretsFileName { get; } = "secrets.json";

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            var cultureInfo = new CultureInfo("en-GB");
            cultureInfo.NumberFormat.CurrencySymbol = "ISK";
            //pattern 3 is n $
            cultureInfo.NumberFormat.CurrencyPositivePattern = 3;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseSession();
            app.UseMiddleware<EsiTokenRefreshMiddleware>();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    public class Secrets
    {
        public string ClientId { get; set; }
        public string SecretKey { get; set; }

        public string SdeConnectionString { get; set; }
        public string NavigatorConnectionString { get; set; }
    }
}