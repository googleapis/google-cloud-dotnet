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

using Google.Api.Gax;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

using LabelsCommon = Google.Cloud.Diagnostics.Common.TraceLabels;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// A helper class to handle span labels.
    /// </summary>
    internal static class Labels
    {
        ///<summary>The label to denote the ASP.NET Core request trace identifier.</summary> 
        public const string CoreTraceId = "/aspnetcore/trace_identifier";

        /// <summary>
        /// Gets a map with the label for the agent which contains the agent's name and version.
        /// </summary>
        internal static Dictionary<string, string> AgentLabel { get; } = LabelsCommon.GetAgentLabel();

        /// <summary>
        /// Gets a map of labels for a span from an <see cref="HttpContext"/>, such as request size,
        /// method, status code, etc.
        /// </summary>
        internal static Dictionary<string, string> FromHttpContext(HttpContext httpContext)
        {
            GaxPreconditions.CheckNotNull(httpContext, nameof(httpContext));
            var requestHeaders = FromHttpRequest(httpContext.Request);
            var responseHeader = FromHttpResponse(httpContext.Response);
            return requestHeaders.Union(responseHeader).ToDictionary(k => k.Key, v => v.Value);
        }

        internal static Dictionary<string, string> FromHttpRequest(HttpRequest request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            var labels = new Dictionary<string, string>
            {
                { LabelsCommon.HttpRequestSize, request.ContentLength.ToString() },
                { LabelsCommon.HttpHost, request.Host.ToString() },
                { LabelsCommon.HttpMethod, request.Method }
            };

            if (!string.IsNullOrEmpty(request.HttpContext.TraceIdentifier))
            {
                labels[CoreTraceId] = request.HttpContext.TraceIdentifier;
            }

            return labels;
        }

        internal static Dictionary<string, string> FromHttpResponse(HttpResponse response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            return new Dictionary<string, string>
            {
                { LabelsCommon.HttpStatusCode, response.StatusCode.ToString() }
            };
        }
    }
}
