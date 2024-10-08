using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Demo.WebApi.Models;

namespace Demo.WebApi.IoC
{
    public static class ServiceCollectionExtension
    {
        public static void AddDemoApiClientService(this IServiceCollection services,
           Action<ApiClientOptions> options)
        {
            services.Configure(options);
            services.AddSingleton(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ApiClientOptions>>().Value;
                return new DemoApiClientService(options);
            });

        }
    }
}
