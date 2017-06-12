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
using Microsoft.AspNetCore.Http.Internal;
using System.Collections.Generic;
using System.Linq;

using LabelsCommon = Google.Cloud.Diagnostics.Common.TraceLabels;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// A helper class to handle span labels.
    /// </summary>
    internal static class Labels
    {
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
            var requestHeaders = FromDefaultHttpRequest(new DefaultHttpRequest(httpContext));
            var responseHeader = FromDefaultHttpResponse(new DefaultHttpResponse(httpContext));
            return requestHeaders.Union(responseHeader).ToDictionary(k => k.Key, v => v.Value);
        }

        internal static Dictionary<string, string> FromDefaultHttpRequest(DefaultHttpRequest request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return new Dictionary<string, string>
            {
                { LabelsCommon.HttpRequestSize, request.ContentLength.ToString() },
                { LabelsCommon.HttpHost, request.Host.ToString() },
                { LabelsCommon.HttpMethod, request.Method }
            };
        }

        internal static Dictionary<string, string> FromDefaultHttpResponse(DefaultHttpResponse response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            return new Dictionary<string, string>
            {
                { LabelsCommon.HttpStatusCode, response.StatusCode.ToString() }
            };
        }
    }
}
