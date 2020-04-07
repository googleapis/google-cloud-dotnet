// Copyright 2020 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common.IntegrationTests;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Google.Cloud.Diagnostics.AspNet.ClientApp.Controllers
{
    public class TraceController : ApiController
    {
        /// <summary>Traces a 10ms sleep.</summary>
        [HttpGet]
        public string Trace(string id)
        {
            string message = EntryData.GetMessage(nameof(Trace), id);
            using (CloudTrace.Tracer.StartSpan(message))
            {
                Thread.Sleep(10);
            }
            return message;
        }

        /// <summary>Traces a 10ms sleep and adds an annotation.</summary>
        [HttpGet]
        public string TraceLabels(string id)
        {
            string message = EntryData.GetMessage(nameof(TraceLabels), id);
            using (CloudTrace.Tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                CloudTrace.Tracer.AnnotateSpan(
                    new Dictionary<string, string> 
                    { 
                        { TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue } 
                    });
                return message;
            }
        }

        /// <summary>Traces a 10ms sleep and adds a stacktrace.</summary>
        [HttpGet]
        public string TraceStackTrace(string id)
        {
            string message = EntryData.GetMessage(nameof(TraceStackTrace), id);
            using (CloudTrace.Tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                CloudTrace.Tracer.SetStackTrace(TraceEntryData.CreateStackTrace());
            }
            return message;
        }

        /// <summary>Traces an outgoing request.</summary>
        [HttpGet]
        public async Task<string> TraceOutgoing(string id)
        {
            string message = EntryData.GetMessage(nameof(TraceOutgoing), id);
            using (CloudTrace.Tracer.StartSpan(message))
            using (HttpClient httpClient = new HttpClient(CloudTrace.CreateTracingHttpMessageHandler()))
            {
                await httpClient.GetAsync("https://google.com/");
            }
            return message;
        }

        /// <summary>
        /// Sleeps 100ms, creates a parent trace, sleeps another 100ms,
        /// creates a child trace and traces the return of a value.
        /// This is used to check that the trace manager is the correct
        /// one for each concurrent call. Tests using this method will
        /// probably send several concurrent requests and then check
        /// that parent and child spans are correct for each request, i.e.
        /// no overlapping from one request to the other.
        /// </summary>
        [HttpGet]
        public string ParentChild(string id)
        {
            Thread.Sleep(100);
            using (CloudTrace.Tracer.StartSpan($"parent-{id}"))
            {
                Thread.Sleep(100);
                using (CloudTrace.Tracer.StartSpan($"child-{id}"))
                {
                    return $"value-{id}";
                }
            }
        }
    }
}
