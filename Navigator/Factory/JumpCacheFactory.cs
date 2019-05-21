using EVEAsset.Navigator.Cache;
using EVEStandard;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace EVEAsset.Navigator.Factory
{
    public static class JumpCacheFactory
    {
        public static JumpCache Build(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            var memroryCache = provider.GetService<IMemoryCache>();
            var api = provider.GetService<EVEStandardAPI>();

            return new JumpCache(memroryCache, api);
        }
    }
}