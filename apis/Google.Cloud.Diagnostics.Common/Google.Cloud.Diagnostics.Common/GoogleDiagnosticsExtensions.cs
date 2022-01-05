// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extensions to configure Google.Cloud.Diagnostics for non ASP.NET Core applications.
    /// </summary>
    public static class GoogleDiagnosticsExtensions
    {
        /// <summary>
        /// Configures Google Diagnostics to be used in non ASP.NET Core applications.
        /// </summary>
        /// <remarks>
        /// Note that the Google Cloud Project ID to use is required and it can only be
        /// obtained from the environment if running on GCP. This means that this overload
        /// can only be used when running on GCP. If you are not running on GCP or need to specify
        /// the Google Cloud Project ID, you can use any of
        /// <see cref="AddGoogleDiagnostics(IServiceCollection, TraceServiceOptions, LoggingServiceOptions, ErrorReportingServiceOptions)"/>
        /// or 
        /// <see cref="AddGoogleDiagnostics(IServiceCollection, string, string, string, TraceOptions, LoggingOptions, ErrorReportingOptions)"/>.
        /// </remarks>
        public static IServiceCollection AddGoogleDiagnostics(this IServiceCollection services) =>
            services.AddGoogleDiagnostics((TraceServiceOptions)null);

        /// <summary>
        /// Configures Google Diagnostics to be used in non ASP.NET Core applications.
        /// </summary>
        /// <remarks>
        /// Options may be null in which case defaults will be used. Note that the
        /// Google Cloud Project ID to use is required. If not set via options, it will be
        /// obtained from the environment, but only if running on GCP.
        /// </remarks>
        public static IServiceCollection AddGoogleDiagnostics(
            this IServiceCollection services,
            TraceServiceOptions traceOptions = null,
            LoggingServiceOptions loggingOptions = null,
            ErrorReportingServiceOptions errorReportingOptions = null) => services
            .AddGoogleTrace(traceOptions)
            .AddLogging(builder => builder.AddGoogle(loggingOptions))
            .AddGoogleErrorReporting(errorReportingOptions);

        /// <summary>
        /// Configures Google Diagnostics to be used in non ASP.NET Core applications.
        /// </summary>
        /// <remarks>
        /// Options may be null in which case defaults will be used. Note that the
        /// Google Cloud Project ID to use is required. If not set via options, it will be
        /// obtained from the environment, but only if running on GCP.
        /// </remarks>
        public static IServiceCollection AddGoogleDiagnostics(
            this IServiceCollection services,
            string projectId = null,
            string serviceName = null,
            string serviceVersion = null,
            TraceOptions traceOptions = null,
            LoggingOptions loggingOptions = null,
            ErrorReportingOptions errorReportingOptions = null) => services.AddGoogleDiagnostics(
                new TraceServiceOptions
                {
                    Options = traceOptions,
                    ProjectId = projectId
                },
                new LoggingServiceOptions
                {
                    Options = loggingOptions,
                    ProjectId = projectId,
                    ServiceName = serviceName,
                    Version = serviceVersion
                },
                new ErrorReportingServiceOptions
                {
                    Options = errorReportingOptions,
                    ProjectId = projectId,
                    ServiceName = serviceName,
                    Version = serviceVersion
                });
    }
}
