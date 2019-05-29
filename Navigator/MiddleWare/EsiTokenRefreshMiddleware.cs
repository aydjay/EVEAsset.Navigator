using System;
using System.Threading.Tasks;
using EVEStandard;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Navigator.Consts;

namespace Navigator.MiddleWare
{
    // ReSharper disable once ClassNeverInstantiated.Global
    // It is by the extension method
    public class EsiTokenRefreshMiddleware
    {
        private readonly EVEStandardAPI _esiClient;
        private readonly RequestDelegate _next;

        public EsiTokenRefreshMiddleware(EVEStandardAPI esiClient, RequestDelegate next)
        {
            _esiClient = esiClient;
            _next = next;
        }

        // ReSharper disable once UnusedMember.Global
        // Called by magic reflection, spooky
        public async Task Invoke(HttpContext context)
        {
            if (context.User.HasClaim(x => x.Type == AppClaimTypes.AccessToken))
            {
                var auth = context.User.GetAuth();
                if (auth.AccessToken.ExpiresUtc < DateTime.UtcNow)
                {
                    await context.SignOutAsync();
                    var newAuth = await _esiClient.SSO.GetRefreshTokenAsync(auth.AccessToken.RefreshToken);
                    var charDetails = await _esiClient.SSO.GetCharacterDetailsAsync(newAuth.AccessToken);
                    await context.SignInAsync(newAuth, charDetails);
                }
            }

            await _next(context);
        }
    }
}