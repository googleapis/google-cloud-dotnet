// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Google.Cloud.Diagnostics.AspNet.Snippets
{
    public class AspNetSnippets
    {
        // Sample: RegisterExceptionLoggerWebApi
        public static void Register(HttpConfiguration config)
        {
            string projectId = "[Google Cloud Platform project ID]";
            string serviceName = "[Name of service]";
            string version = "[Version of service]";
            // Add a catch all for the uncaught exceptions.
            config.Services.Add(typeof(System.Web.Http.ExceptionHandling.IExceptionLogger),
                ErrorReportingExceptionLogger.Create(projectId, serviceName, version));
        }
        // End sample

        // Sample: RegisterExceptionLoggerMvc
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            string projectId = "[Google Cloud Platform project ID]";
            string serviceName = "[Name of service]";
            string version = "[Version of service]";
            // Add a catch all for the uncaught exceptions.
            filters.Add(ErrorReportingExceptionFilter.Create(projectId, serviceName, version));
        }
        // End sample

        
        public void ReadFile()
        {
            // Sample: LogExceptions
            string projectId = "[Google Cloud Platform project ID]";
            string serviceName = "[Name of service]";
            string version = "[Version of service]";
            var exceptionLogger = GoogleExceptionLogger.Create(projectId, serviceName, version);

            try
            {
                string scores = File.ReadAllText(@"C:\Scores.txt");
                Console.WriteLine(scores);
            }
            catch (IOException e)
            {
                exceptionLogger.Log(e);
            }
            // End sample
        }

        // Sample: InitializeTrace
        public class Global : HttpApplication
        {
            public override void Init()
            {
                base.Init();
                string projectId = "[Google Cloud Platform project ID]";
                // Trace a sampling of incoming Http requests.
                CloudTrace.Initialize(this, projectId);
            }
        }
        // End sample

        public void TraceHelloWorld()
        {
            // Sample: UseTracer
            // Manually trace a specific operation.
            using (CloudTrace.Tracer.StartSpan("hello-world"))
            {
                Console.Out.WriteLine("Hello, World!");
            }
            // End sample


            // Sample: UseTracerRunIn
            // Manually trace a specific Action or Func<T>.
            CloudTrace.Tracer.RunInSpan(
                () => Console.Out.WriteLine("Hello, World!"),
                "hello-world");
            // End sample
        }
        
        public async Task<HttpResponseMessage> TraceOutgoing()
        {
            // Sample: TraceOutgoing
            // Add a handler to trace outgoing requests and to propagate the trace header.
            var traceHeaderHandler = CloudTrace.CreateTracingHttpMessageHandler();
            using (var httpClient = new HttpClient(traceHeaderHandler))
            {
                return await httpClient.GetAsync("https://weather.com/");
            }
            // End sample
        }

    }
}