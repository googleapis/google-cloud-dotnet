// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
#if NETCOREAPP3_1
using Microsoft.Extensions.Hosting;
#elif NETCOREAPP2_1 || NET461
#else
#error unknown target framework
#endif

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Helper class containing methods to obtain the appropiate host builder
    /// depenging on the target platform.
    /// </summary>
    public static class TestServerHelpers
    {
#if NETCOREAPP3_1
        public static IHostBuilder GetHostBuilder(Action<IWebHostBuilder> configure = null) => GetHostBuilder<BaseStartup>(configure);

        public static IHostBuilder GetHostBuilder<TStartup>(Action<IWebHostBuilder> configure = null) where TStartup : class =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => 
                {
                    webBuilder.UseTestServer().UseStartup<TStartup>();
                    configure?.Invoke(webBuilder);
                });


        public static TestServer GetTestServer(IHostBuilder hostBuilder)
        {
            var host = hostBuilder.Build();
            host.Start();
            return host.GetTestServer();
        }

        public static TestServer GetTestServer<TStartup>(Action<IWebHostBuilder> configure = null) where TStartup : class =>
            GetTestServer(GetHostBuilder<TStartup>(configure));

        public static IServiceProvider GetServices(TestServer server) => server.Services;

        /// <summary>
        /// Allows us to add the target framework specific configuration here,
        /// so the code in tests is not framework dependent.
        /// Note: This is needed because if there are several Configure calls,
        /// only the last one is used so we cannot chain them. Instead we need
        /// to "compose" the Configure call by ovewriting the virtual method
        /// and calling base.
        /// </summary>
        public class BaseStartup
        {
            public virtual void ConfigureServices(IServiceCollection services) => services.AddControllers();

            public virtual void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) => app
                .UseRouting()
                .UseEndpoints(endpoints => endpoints
                    .MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"));
        }
#elif NETCOREAPP2_1 || NET461
        public static IWebHostBuilder GetHostBuilder(Action<IWebHostBuilder> configure = null) => GetHostBuilder<BaseStartup>(configure);

        public static IWebHostBuilder GetHostBuilder<TStartup>(Action<IWebHostBuilder> configure = null) where TStartup: class
        {
            var hostBuilder = new WebHostBuilder().UseStartup<TStartup>();
            configure?.Invoke(hostBuilder);
            return hostBuilder;
        }

        public static TestServer GetTestServer(IWebHostBuilder hostBuilder) => new TestServer(hostBuilder);

        public static TestServer GetTestServer<TStartup>(Action<IWebHostBuilder> configure = null) where TStartup : class =>
            GetTestServer(GetHostBuilder<TStartup>(configure));

        public static IServiceProvider GetServices(TestServer server) => server.Host.Services;

        /// <summary>
        /// Allows us to add the target framework specific configuration here,
        /// so the code in tests is not framework dependent.
        /// Note: This is needed because if there are several Configure calls,
        /// only the last one is used so we cannot chain them. Instead we need
        /// to "compose" the Configure call by ovewriting the virtual method
        /// and calling base.
        /// </summary>
        public class BaseStartup
        {
            public virtual void ConfigureServices(IServiceCollection services) => services.AddMvc();

            public virtual void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) => 
                app.UseMvcWithDefaultRoute();
        }
#else
#error unknown target framework
#endif
    }
}
