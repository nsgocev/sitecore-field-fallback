
using System;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.DependencyInjection;

namespace FieldFallback.Data
{
    public static class FallbackValuesManager
    {

        private static readonly
            ProviderHelper<StandardValuesProvider, StandardValuesProviderCollection>
            ProviderHelper;

        public static FallbackValuesProvider Provider
        {
            get
            {
                return ProviderHelper.Provider as FallbackValuesProvider;
            }
        }

        static FallbackValuesManager()
        {
            if (ProviderHelper == null)
            {
                ProviderHelper = ServiceLocator.ServiceProvider
                    .GetRequiredService<ProviderHelper<StandardValuesProvider, StandardValuesProviderCollection>>();
            }
        }
    }
}
