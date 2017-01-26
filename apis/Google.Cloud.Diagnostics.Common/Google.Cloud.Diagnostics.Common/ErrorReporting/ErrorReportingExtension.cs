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


using Google.Cloud.ErrorReporting.V1Beta1;
using Newtonsoft.Json;
using System.IO;

namespace Google.Cloud.Diagnostics.Common
{
    public static class ErrorReportingExtension
    {
        public static string ToJsonString(this ReportedErrorEvent errorEvent)
        {

            
            using (var sw = new StringWriter())
            using (var writer = new JsonTextWriter(sw))
            {
                writer.WriteStartObject();
                writer.WritePropertyName("serviceContext");
                writer.WriteStartObject();
                writer.WritePropertyName("service");
                writer.WriteValue(errorEvent.ServiceContext.Service);
                writer.WritePropertyName("version");
                writer.WriteValue(errorEvent.ServiceContext.Version);
                writer.WriteEndObject();

                writer.WritePropertyName("message");
                writer.WriteValue(errorEvent.Message);

                writer.WritePropertyName("context");
                writer.WriteStartObject();


                writer.WritePropertyName("httpRequest");
                writer.WriteStartObject();
                writer.WritePropertyName("method");
                writer.WriteValue(errorEvent.Context.HttpRequest.Method);
                writer.WritePropertyName("url");
                writer.WriteValue(errorEvent.Context.HttpRequest.Url);
                writer.WritePropertyName("userAgent");
                writer.WriteValue(errorEvent.Context.HttpRequest.UserAgent);
                writer.WritePropertyName("responseStatusCode");
                writer.WriteValue(errorEvent.Context.HttpRequest.ResponseStatusCode);
                writer.WriteEndObject();

                writer.WritePropertyName("reportLocation");
                writer.WriteStartObject();
                writer.WritePropertyName("filePath");
                writer.WriteValue(errorEvent.Context.ReportLocation.FilePath);
                writer.WritePropertyName("lineNumber");
                writer.WriteValue(errorEvent.Context.ReportLocation.LineNumber);
                writer.WritePropertyName("functionName");
                writer.WriteValue(errorEvent.Context.ReportLocation.FunctionName);
                writer.WriteEndObject();


                writer.WriteEndObject();



                writer.WriteEndObject();
                writer.Close();
                return sw.ToString();
            }
        }
    }
}
