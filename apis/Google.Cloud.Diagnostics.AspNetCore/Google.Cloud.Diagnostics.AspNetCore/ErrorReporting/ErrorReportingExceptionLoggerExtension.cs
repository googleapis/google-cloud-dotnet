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

using Google.Cloud.ErrorReporting.V1Beta1;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using System.IO;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    ///  Uses the Google Cloud Error Reporting Exception Logger Middleware.
    ///  To ensure all unhandled exceptions are reported, this should be
    ///  the first piece of middleware used.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void Configure(IApplicationBuilder app)
    /// {
    ///     // Use before handling any requests to ensure all unhandled exceptions are reported.
    ///     string projectId = "[Google Cloud Platform project ID]";
    ///     string serviceName = "[Name of service]";
    ///     string version = "[Version of service]";
    ///     app.UseGoogleExceptionLogging(projectId, serviceName, version);
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public static class ErrorReportingExceptionLoggerExtension
    {
        /// <summary>
        /// Uses middleware that will report all uncaught exceptions to the Stackdriver
        /// Error Reporting API.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static void UseGoogleExceptionLogging(
            this IApplicationBuilder app, string projectId, string serviceName, string version)
        {
            var logger = ErrorReportingExceptionLogger.Create(projectId, serviceName, version);
            app.UseMiddleware<ErrorReportingExceptionLoggerMiddleware>(logger);
        }

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
