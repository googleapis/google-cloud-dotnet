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
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A helper class to handle span labels.
    /// </summary>
    internal static class TraceLabels
    {
        ///<summary>The label to denote the size of a request.</summary> 
        internal const string HttpRequestSize = "/http/request/size";

        ///<summary>The label to denote the host.</summary> 
        internal const string HttpHost = "/http/host";

        ///<summary>The label to denote the request method.</summary> 
        internal const string HttpMethod = "/http/method";

        ///<summary>The label to denote the response status code.</summary> 
        internal const string HttpStatusCode = "/http/status_code";

        ///<summary>The label to denote a stack trace.</summary> 
        internal const string StackTrace = "/stacktrace";

        ///<summary>The label to denote an agent.</summary> 
        internal const string Agent = "/agent";

        /// <summary>
        /// Creates a a map of labels to represent a <see cref="StackTrace"/> for a span.
        /// </summary>
        public static Dictionary<string, string> FromStackTrace(StackTrace stackTrace)
        {
            GaxPreconditions.CheckNotNull(stackTrace, nameof(stackTrace));
            return new Dictionary<string, string>()
            {
                { StackTrace, GenerateJsonStringStackTrace(stackTrace) }
            };
        }

        /// <summary>
        /// Gets a map with the label for the agent which contains the agent's name and version.
        /// </summary>
        internal static Dictionary<string, string> GetAgentLabel() =>
            new Dictionary<string, string> { { Agent, CommonUtils.AgentNameAndVersion } };

        /// <summary>
        /// Gets a map of labels for a span from an <see cref="HttpRequestMessage"/>.
        /// </summary>
        internal static Dictionary<string, string> FromHttpRequestMessage(HttpRequestMessage request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return new Dictionary<string, string>
            {
                { HttpMethod, request.Method.Method }
            };
        }

        /// <summary>
        /// Gets a map of labels for a span from an <see cref="HttpResponseMessage"/>.
        /// </summary>
        internal static Dictionary<string, string> FromHttpResponseMessage(HttpResponseMessage response)
        {
            GaxPreconditions.CheckNotNull(response, nameof(response));
            return new Dictionary<string, string>
            {
                { HttpStatusCode, ((int)response.StatusCode).ToString() }
            };
        }

        /// <summary>
        /// Creates a string JSON representation of a stack trace or the empty string
        /// if the stack trace has no frames.
        /// </summary>
        private static string GenerateJsonStringStackTrace(StackTrace stackTrace)
        {
            if (stackTrace.GetFrames() == null || stackTrace.GetFrames().Length == 0)
            {
                return string.Empty;
            }

            using (StringWriter sw = new StringWriter())
            {
                JsonWriter writer = new JsonTextWriter(sw);
                writer.WriteStartObject();
                writer.WritePropertyName("stack_frame");
                writer.WriteStartArray();

                foreach (StackFrame stackFrame in stackTrace.GetFrames())
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("class_name");
                    writer.WriteValue(stackFrame.GetMethod()?.DeclaringType?.Name);
                    writer.WritePropertyName("method_name");
                    writer.WriteValue(stackFrame.GetMethod()?.Name);

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

                return sw.ToString();
            }
        }

    }
}