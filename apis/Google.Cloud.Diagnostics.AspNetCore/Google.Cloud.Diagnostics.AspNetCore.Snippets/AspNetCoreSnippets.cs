// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    [SnippetOutputCollector]
    public class AspNetCoreSnippets
    {
        // Sample: ReportUnandledExceptions
        public void ConfigureServices(IServiceCollection services)
        {
            string projectId = "[Google Cloud Platform project ID]";
            string serviceName = "[Name of service]";
            string version = "[Version of service]";

            services.AddGoogleExceptionLogging(options =>
            {
                options.ProjectId = projectId;
                options.ServiceName = serviceName;
                options.Version = version;
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            // Use before handling any requests to ensure all unhandled exceptions are reported.
            app.UseGoogleExceptionLogging();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        // End sample


        // Sample: LogExceptions
        /// <summary>
        /// The <see cref="IExceptionLogger"/> is populated by dependency injection.
        /// </summary>
        public void ReadFile(IExceptionLogger exceptionLogger)
        {
            try
            {
                string scores = File.ReadAllText(@"C:\Scores.txt");
                Console.WriteLine(scores);
            }
            catch (IOException e)
            {
                exceptionLogger.Log(e);
            }
        }
        // End sample

        // Sample: RegisterGoogleLogger
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            string projectId = "[Google Cloud Platform project ID]";
            loggerFactory.AddGoogle(app.ApplicationServices, projectId);
        }
        // End sample

        private class Startup { }

#if NETCOREAPP2_0
        public void Configure()
        {
            // Sample: RegisterGoogleLogger2
            string projectId = "[Google Cloud Platform project ID]";
            var webHost = new WebHostBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<ILoggerProvider>(sp => GoogleLoggerProvider.Create(sp, projectId));
                })
                .UseStartup<Startup>()
                .Build();
            // End sample
        }
#endif

        public void Configure2()
        {
            // Sample: UseGoogleDiagnostics
            string projectId = "[Google Cloud Platform project ID]";
            var webHost = new WebHostBuilder()
                .UseGoogleDiagnostics(projectId)
                .UseStartup<Startup>()
                .Build();
            // End sample
        }

        // Sample: UseGoogleLogger
        public void LogMessage(ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger("[My Logger Name]");
            logger.LogInformation("This is a log message.");
        }
        // End sample

        private class Trace
        {
            // Sample: RegisterGoogleTracer
            public void ConfigureServices(IServiceCollection services)
            {
                // The line below is needed for trace ids to be added to logs.
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
                string projectId = "[Google Cloud Platform project ID]";
                services.AddGoogleTrace(options =>
                {
                    options.ProjectId = projectId;
                });
            }

            public void Configure(IApplicationBuilder app)
            {
                // Use at the start of the request pipeline to ensure the entire
                // request is traced.
                app.UseGoogleTrace();

                app.UseStaticFiles();

                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=Index}/{id?}");
                });
            }
            // End sample

            // Sample: UseTracer
            /// <summary>
            /// The <see cref="IManagedTracer"/> is populated by dependency injection.
            /// </summary>
            public void TraceHelloWorld(IManagedTracer tracer)
            {
                // Manually trace a specific operation.
                using (tracer.StartSpan(nameof(TraceHelloWorld)))
                {
                    Console.Out.WriteLine("Hello, World!");
                }
            }
            // End sample

            // Sample: UseTracerRunIn
            /// <summary>
            /// The <see cref="IManagedTracer"/> is populated by dependency injection.
            /// </summary>
            public void TraceHelloWorldRunIn(IManagedTracer tracer)
            {
                // Manually trace a specific Action or Func<T>.
                tracer.RunInSpan(
                    () => Console.Out.WriteLine("Hello, World!"),
                    nameof(TraceHelloWorldRunIn));
            }
            // End sample

            // Sample: TraceOutgoing
            /// <summary>
            /// The <see cref="TraceHeaderPropagatingHandler"/> is populated by dependency injection.
            /// </summary>
            public async Task<HttpResponseMessage> TraceOutgoing(TraceHeaderPropagatingHandler traceHeaderHandler)
            {
                // Add a handler to trace outgoing requests and to propagate the trace header.
                using (var httpClient = new HttpClient(traceHeaderHandler))
                {
                    return await httpClient.GetAsync("https://weather.com/");
                }
            }
            // End sample

            // Sample: TraceMVCConstructor
            public class SampleConstructorController : Controller
            {
                private readonly IManagedTracer _tracer;

                public SampleConstructorController(IManagedTracer tracer)
                {
                    _tracer = tracer;
                }

                public ActionResult Hello()
                {
                    using (_tracer.StartSpan(nameof(Hello)))
                    {
                        ViewData["text"] = "Hello, World!";
                        return View();
                    }
                }
            }
            // End sample

            // Sample: TraceMVCMethod
            public class SampleMethodController : Controller
            {
                public ActionResult Hello([FromServices] IManagedTracer tracer)
                {
                    using (tracer.StartSpan(nameof(Hello)))
                    {
                        ViewData["text"] = "Hello, World!";
                        return View();
                    }
                }
            }
            // End sample
        }
    }
}
