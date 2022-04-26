// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// Extensions to configure Google Diagnostics on the <see cref="IWebHostBuilder"/>.
    /// </summary>
    [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreGoogleDiagnosticsExtensions instead.")]
    public static class GoogleDiagnosticsWebHostBuilderExtensions
    {
        /// <summary>
        /// Configures Google Diagnostics services for Logging, Tracing and Error Reporting middleware.
        /// </summary>
        /// <param name="builder">The <see cref="IWebHostBuilder"/> instance.</param>
        /// <param name="projectId">
        /// The Google Cloud Platform project ID. If unspecified and running on GAE/GCE/GKE
        /// the project ID will be detected from the platform.
        /// </param>
        /// <param name="serviceName">
        /// An identifier of the service used for exception logging (through Error Reporting), such as the name of the executable or job.
        /// If unspecified and running on GAE the service name will be detected from the platform.
        /// This may be different from <see cref="LoggerOptions.ServiceName"/> which is used for log entries logged with <see cref="GoogleLogger"/>.
        /// </param>
        /// <param name="serviceVersion">
        /// A string that represents the version of the service or the source code used for exception logging.
        /// If unspecified and running on GAE the service version will be detected from the platform.
        /// This may be different from <see cref="LoggerOptions.Version"/> which is used for log entries logged with <see cref="GoogleLogger"/>.
        /// </param>
        /// <param name="loggerOptions">The options for logging. May be null, in which case default options will be used.</param>
        /// <param name="traceOptions">The options for tracing. May be null, in which case default options will be used.</param>
        /// <param name="errorReportingOptions">The options for error reporting. May be null, in which case default options will be used.</param>
        /// <returns>The <see cref="IWebHostBuilder"/> instance.</returns>
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreGoogleDiagnosticsExtensions instead.")]
        public static IWebHostBuilder UseGoogleDiagnostics(
            this IWebHostBuilder builder,
            string projectId = null,
            string serviceName = null,
            string serviceVersion = null,
            LoggerOptions loggerOptions = null,
            TraceOptions traceOptions = null,
            ErrorReportingOptions errorReportingOptions = null) =>
            builder.ConfigureServices(services =>
                ConfigureGoogleDiagnosticsServices(services, projectId, serviceName, serviceVersion, loggerOptions, traceOptions, errorReportingOptions));

        // On .NET Standard 2.0 or higher the IWebHostBuilder.ConfigureServices has a new overload that takes both
        // an IServiceCollection and a WebHostBuilderContext. We can use the context for retrieving information from the
        // host builder at startup time, like reading configuration.

        /// <summary>
        /// Configures Google Diagnostics services for Logging, Tracing and Error Reporting middleware.
        /// </summary>
        /// <param name="builder">The <see cref="IWebHostBuilder"/> instance.</param>
        /// <param name="projectIdGetter">
        /// A function that takes a <see cref="WebHostBuilderContext"/> and retrieves the Google Cloud Platform project ID.
        /// Cannot be null but can return a null value for the project ID, in such a case
        /// and if running on GAE/GCE/GKE the project ID will be detected from the platform.
        /// </param>
        /// <param name="serviceNameGetter">
        /// A function that takes a <see cref="WebHostBuilderContext"/> and retrieves the identifier of the service used for exception logging, such as the name of the executable or job.
        /// Cannot be null but can return a null value for the service name, in such a case
        /// and if running on GAE the service name will be detected from the platform.
        /// </param>
        /// <param name="serviceVersionGetter">
        /// A function that takes a <see cref="WebHostBuilderContext"/> and retrieves the version of the service or the source code used for exception logging.
        /// Cannot be null but can return a null value for the service version, in such a case
        /// and if running on GAE the service version will be detected from the platform.
        /// </param>
        /// <param name="loggerOptionsGetter">
        /// A function that takes a <see cref="WebHostBuilderContext"/> and retrieves the options to use for logging.
        /// May be null or return a null value for the options; in either of these cases the default options will be used.
        /// </param>
        /// <param name="traceOptionsGetter">
        /// A function that takes a <see cref="WebHostBuilderContext"/> and retrieves the options to use for tracing.
        /// May be null or return a null value for the options; in either of these cases the default options will be used.
        /// </param>
        /// <param name="errorReportingOptionsGetter">
        /// A function that takes a <see cref="WebHostBuilderContext"/> and retrieves the options to use for errorReporting.
        /// May be null or return a null value for the options; in either of these cases the default options will be used.
        /// </param>
        /// <returns>The <see cref="IWebHostBuilder"/> instance.</returns>
        [Obsolete("Use Google.Cloud.Diagnostics.AspNetCore3.AspNetCoreGoogleDiagnosticsExtensions instead.")]
        public static IWebHostBuilder UseGoogleDiagnostics(
            this IWebHostBuilder builder,
            Func<WebHostBuilderContext, string> projectIdGetter,
            Func<WebHostBuilderContext, string> serviceNameGetter,
            Func<WebHostBuilderContext, string> serviceVersionGetter,
            Func<WebHostBuilderContext, LoggerOptions> loggerOptionsGetter = null,
            Func<WebHostBuilderContext, TraceOptions> traceOptionsGetter = null,
            Func<WebHostBuilderContext, ErrorReportingOptions> errorReportingOptionsGetter = null)
        {
            GaxPreconditions.CheckNotNull(projectIdGetter, nameof(projectIdGetter));
            GaxPreconditions.CheckNotNull(serviceNameGetter, nameof(serviceNameGetter));
            GaxPreconditions.CheckNotNull(serviceVersionGetter, nameof(serviceVersionGetter));

            return builder.ConfigureServices((context, services) =>
                ConfigureGoogleDiagnosticsServices(services, projectIdGetter(context), serviceNameGetter(context), serviceVersionGetter(context),
                    loggerOptionsGetter?.Invoke(context), traceOptionsGetter?.Invoke(context), errorReportingOptionsGetter?.Invoke(null)));
        }

        private static void ConfigureGoogleDiagnosticsServices(
            IServiceCollection services,
            string projectId,
            string serviceName,
            string serviceVersion,
            LoggerOptions loggerOptions,
            TraceOptions traceOptions,
            ErrorReportingOptions errorReportingOptions)
        {
            projectId = Project.GetAndCheckProjectId(projectId, null);

            services.AddLogEntryLabelProvider<TraceIdLogEntryLabelProvider>();
            services.AddGoogleTraceForAspNetCore(new AspNetCoreTraceOptions 
            {
                ServiceOptions = new Common.TraceServiceOptions
                {
                    ProjectId = projectId,
                    Options = traceOptions
                }
            });
            services.AddGoogleErrorReportingForAspNetCore(new Common.ErrorReportingServiceOptions
            {
                ProjectId = projectId,
                ServiceName = serviceName,
                Version = serviceVersion,
                Options = errorReportingOptions
            });

            loggerOptions = loggerOptions ?? LoggerOptions.Create();
            loggerOptions.CommonLoggerOptions.ProjectId = projectId;
            services.AddLogging(builder => builder.AddGoogle(loggerOptions.CommonLoggerOptions));
        }
    }
}
