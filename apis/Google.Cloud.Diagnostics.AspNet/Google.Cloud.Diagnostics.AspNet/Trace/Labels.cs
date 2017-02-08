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

using Google.Api.Gax;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;

using LabelsCommon = Google.Cloud.Diagnostics.Common.TraceLabels;

namespace Google.Cloud.Diagnostics.AspNet
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
        /// Gets a map of labels for a span from an <see cref="HttpRequest"/>, such as request size, method, ect.
        /// </summary>
        public static Dictionary<string, string> FromHttpRequest(HttpRequest request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return FromHttpRequestWrapper(new HttpRequestWrapper(request));
        }

        internal static Dictionary<string, string> FromHttpRequestWrapper(HttpRequestWrapper request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return new Dictionary<string, string>
            {
                { LabelsCommon.HttpRequestSize, request.ContentLength.ToString() },
                { LabelsCommon.HttpHost, request.UserHostName },
                { LabelsCommon.HttpMethod, request.HttpMethod }
            };
        }

        /// <summary>
        /// Gets a map of labels for a span from an <see cref="HttpResponse"/>, such as status code.
        /// </summary>
        public static Dictionary<string, string> FromHttpResponse(HttpResponse response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            return FromHttpResponseWrapper(new HttpResponseWrapper(response));
        }

        internal static Dictionary<string, string> FromHttpResponseWrapper(HttpResponseWrapper response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            return new Dictionary<string, string>
            {
                { LabelsCommon.HttpStatusCode, response.StatusCode.ToString() }
            };
        }

        /// <summary>
        /// Creates a map of labels to represent a <see cref="StackTrace"/> for a span.
        /// </summary>
        public static Dictionary<string, string> FromStackTrace(StackTrace stackTrace) => 
            LabelsCommon.FromStackTrace(stackTrace);
    }
}