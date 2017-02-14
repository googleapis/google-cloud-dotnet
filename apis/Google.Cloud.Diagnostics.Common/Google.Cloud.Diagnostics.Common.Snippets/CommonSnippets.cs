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

using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common.Snippets
{
    public class CommonSnippets
    {
        // Sample: TraceOutgoing
        public async Task<HttpResponseMessage> TraceOutgoing(IManagedTracer tracer)
        {
            // Add a handler to trace outgoing requests and to propagate the trace header.
            var traceHeaderHandler = TraceHeaderPropagatingHandler.Create(tracer);
            using (var httpClient = new HttpClient(traceHeaderHandler))
            {
                return await httpClient.GetAsync("https://weather.com/");
            }
        }
        // End sample
    }
}
