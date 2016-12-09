// Copyright 2016 Google Inc. All Rights Reserved.
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
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Google.Cloud.Diagnostics.AspNet.Snippets
{
    public class AspNetSnippets
    {
        // Sample: RegisterExceptionLogger
        public static void Register(HttpConfiguration config)
        {
            string projectId = "[Google Cloud Platform project ID]";
            string serviceName = "[Name of service]";
            string version = "[Version of service]";
            // Add a catch all for the uncaught exceptions.
            config.Services.Add(typeof(IExceptionLogger),
                ErrorReportingExceptionLogger.Create(projectId, serviceName, version));
        }
        // End sample

        // Sample: InitializeTrace
        public class Global : HttpApplication
        {
            void Application_Start(object sender, EventArgs e)
            {
                string projectId = "[Google Cloud Platform project ID]";
                // Trace a sampling of incoming Http requests.
                CloudTrace.Initialize(projectId, this);
            }
        }
        // End sample
        
        public void TraceHelloWorld()
        {
            // Sample: UseTracer
            // Manually trace a specific operation.
            CloudTrace.GetCurrentTracer().StartSpan("hello-world");
            Console.Out.WriteLine("Hello, World!");
            CloudTrace.GetCurrentTracer().EndSpan();
            // End sample
        }

    }
}
