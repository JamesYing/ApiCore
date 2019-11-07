using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

namespace JCSoft.ApiCore.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddApiCore();

            var provider = services.BuildServiceProvider();

            var apiClient = provider.GetService<IApiClient>();
            var response = apiClient.Request(new MyApiWhoRequest());
            Console.WriteLine(JsonConvert.SerializeObject(response));

            Console.Read();
        }
    }
}
