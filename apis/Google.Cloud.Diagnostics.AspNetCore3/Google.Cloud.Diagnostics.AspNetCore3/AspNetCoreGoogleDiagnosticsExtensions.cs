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

using Google.Cloud.Diagnostics.Common;
using Microsoft.Extensions.DependencyInjection;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Extensions to configure Google.Cloud.Diagnostics for ASP.NET Core applications.
    /// </summary>
    public static class AspNetCoreGoogleDiagnosticsExtensions
    {
        /// <summary>
        /// Configures Google Diagnostics to be used in ASP.NET Core applications with
        /// default values.
        /// </summary>
        /// <remarks>
        /// Note that the Google Cloud Project ID to use is required and it can only be
        /// obtained from the environment if running on GCP. This means that this overload
        /// can only be used when running on GCP. If you are not running on GCP or need to specify
        /// the Google Cloud Project ID, you can use any of
        /// <see cref="AddGoogleDiagnosticsForAspNetCore(IServiceCollection, AspNetCoreTraceOptions, LoggingServiceOptions, Common.ErrorReportingServiceOptions)"/>
        /// or 
        /// <see cref="AddGoogleDiagnosticsForAspNetCore(IServiceCollection, string, string, string, TraceOptions, LoggingOptions, ErrorReportingOptions)"/>.
        /// </remarks>
        public static IServiceCollection AddGoogleDiagnosticsForAspNetCore(this IServiceCollection services) =>
            services.AddGoogleDiagnosticsForAspNetCore((AspNetCoreTraceOptions)null);

        /// <summary>
        /// Configures Google Diagnostics to be used in ASP.NET Core applications.
        /// </summary>
        /// <remarks>
        /// Options may be null in which case defaults will be used. Note that the
        /// Google Cloud Project ID to use is required. If not set via options, it will be
        /// obtained from the environment, but only if running on GCP.
        /// </remarks>
        public static IServiceCollection AddGoogleDiagnosticsForAspNetCore(
            this IServiceCollection services,
            AspNetCoreTraceOptions traceOptions = null,
            LoggingServiceOptions loggingOptions = null,
            Common.ErrorReportingServiceOptions errorReportingOptions = null) =>
            services
                .AddLogEntryLabelProviderSingleton<TraceIdLogEntryLabelProvider>()
                .AddGoogleTraceForAspNetCore(traceOptions)
                .AddLogging(builder => builder.AddGoogle(loggingOptions))
                .AddGoogleErrorReportingForAspNetCore(errorReportingOptions);

        /// <summary>
        /// Configures Google Diagnostics to be used in ASP.NET Core applications.
        /// </summary>
        /// <remarks>
        /// Options may be null in which case defaults will be used. Note that the
        /// Google Cloud Project ID to use is required. If not set via options, it will be
        /// obtained from the environment, but only if running on GCP.
        /// </remarks>
        public static IServiceCollection AddGoogleDiagnosticsForAspNetCore(
            this IServiceCollection services,
            string projectId = null,
            string serviceName = null,
            string serviceVersion = null,
            TraceOptions traceOptions = null,
            LoggingOptions loggingOptions = null,
            ErrorReportingOptions errorReportingOptions = null) => services.AddGoogleDiagnosticsForAspNetCore(
                new AspNetCoreTraceOptions
                {
                    ServiceOptions = new Common.TraceServiceOptions
                    {
                        Options = traceOptions,
                        ProjectId = projectId
                    }
                },
                new LoggingServiceOptions
                {
                    Options = loggingOptions,
                    ProjectId = projectId,
                    ServiceName = serviceName,
                    Version = serviceVersion
                },
                new Common.ErrorReportingServiceOptions
                {
                    Options = errorReportingOptions,
                    ProjectId = projectId,
                    ServiceName = serviceName,
                    Version = serviceVersion
                });
    }
}
