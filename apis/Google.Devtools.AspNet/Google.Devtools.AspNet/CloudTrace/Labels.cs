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
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A helper class to handle span labels.
    /// </summary>
    internal static class Labels
    {
        // The label to denote the size of a request.
        public static readonly string HttpRequestSize = "trace.cloud.google.com/http/request/size";

        // The label to denote the host.
        public static readonly string HttpHost = "trace.cloud.google.com/http/host";

        // The label to denote the request method.
        public static readonly string HttpMethod = "trace.cloud.google.com/http/method";

        // The label to denote the response status code.
        public static readonly string HttpStatusCode = "trace.cloud.google.com/http/status_code";

        // The label to denote a stack trace.
        public static readonly string StackTrace = "trace.cloud.google.com/stacktrace";

        /// <summary>
        /// Gets a map of labels for a span from an <see cref="HttpRequest"/>, such as request size, method, ect.
        /// </summary>
        public static Dictionary<string, string> FromHttpRequest(HttpRequest request)
        {
            return FromHttpRequestWrapper(new HttpRequestWrapper(request));
        }

        internal static Dictionary<string, string> FromHttpRequestWrapper(HttpRequestWrapper request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            Dictionary<string, string> labels = new Dictionary<string, string>();
            labels.Add(HttpRequestSize, request.ContentLength.ToString());
            labels.Add(HttpHost, request.UserHostName);
            labels.Add(HttpMethod, request.HttpMethod);
            return labels;
        }

        /// <summary>
        /// Gets a map of labels for a span from an <see cref="HttpResponse"/>, such as status code.
        /// </summary>
        public static Dictionary<string, string> FromHttpResponse(HttpResponse response)
        {
            return FromHttpResponseWrapper(new HttpResponseWrapper(response));
        }

        internal static Dictionary<string, string> FromHttpResponseWrapper(HttpResponseWrapper response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            Dictionary<string, string> labels = new Dictionary<string, string>();
            labels.Add(HttpStatusCode, response.StatusCode.ToString());
            return labels;
        }


        /// <summary>
        /// Creates a a map of labels to represent a <see cref="StackTrace"/> for a span.
        /// </summary>
        public static Dictionary<string, string> FromStackTrace(StackTrace stackTrace)
        {
            GaxPreconditions.CheckNotNull(stackTrace, nameof(stackTrace));
            Dictionary<string, string> labels = new Dictionary<string, string>();
            labels.Add(StackTrace, GenerateJsonStringStackTrace(stackTrace));
            return labels;
        }

        /// <summary>
        /// Creates a string JSON representation of a stack trace.
        /// </summary>
        private static string GenerateJsonStringStackTrace(StackTrace stackTrace)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            JsonWriter writer = new JsonTextWriter(sw);
            writer.WriteStartObject();
            writer.WritePropertyName("stack_frame");
            writer.WriteStartArray();

            foreach (StackFrame stackFrame in stackTrace.GetFrames())
            {
                writer.WriteStartObject();
                writer.WritePropertyName("class_name");
                writer.WriteValue(stackFrame.GetMethod().DeclaringType.Name);
                writer.WritePropertyName("method_name");
                writer.WriteValue(stackFrame.GetMethod().Name);

                if (stackFrame.GetFileName() != null)
                {
                    writer.WritePropertyName("file_name");
                    writer.WriteValue(stackFrame.GetFileName());
                }

                if (stackFrame.GetFileLineNumber() != 0)
                {
                    writer.WritePropertyName("line_number");
                    writer.WriteValue(stackFrame.GetFileLineNumber());
                }
                writer.WriteEndObject();
            }

            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();

            return sb.ToString();
        }

    }
}