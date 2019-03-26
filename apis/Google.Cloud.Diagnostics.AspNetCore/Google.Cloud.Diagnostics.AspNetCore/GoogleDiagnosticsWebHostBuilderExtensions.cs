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

using Google.Api;
using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Extensions to configure Google Diagnostics on the <see cref="IWebHostBuilder"/>.
    /// </summary>
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
        /// An identifier of the service used for exception logging, such as the name of the executable or job.
        /// If unspecified and running on GAE the service name will be detected from the platform.
        /// </param>
        /// <param name="serviceVersion">
        /// A string that represents the version of the service or the source code used for exception logging.
        /// If unspecified and running on GAE the service version will be detected from the platform.
        /// </param>
        /// <returns>The <see cref="IWebHostBuilder"/> instance.</returns>
        public static IWebHostBuilder UseGoogleDiagnostics(this IWebHostBuilder builder, string projectId = null, string serviceName = null, string serviceVersion = null)
            => UseGoogleDiagnostics(builder, projectId, serviceName, serviceVersion, monitoredResource: null);

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
        /// <returns>The <see cref="IWebHostBuilder"/> instance.</returns>
        public static IWebHostBuilder UseGoogleDiagnostics(this IWebHostBuilder builder, Func<WebHostBuilderContext, string> projectIdGetter, Func<WebHostBuilderContext, string> serviceNameGetter, Func<WebHostBuilderContext, string> serviceVersionGetter)
        {
            GaxPreconditions.CheckNotNull(projectIdGetter, nameof(projectIdGetter));
            GaxPreconditions.CheckNotNull(serviceNameGetter, nameof(serviceNameGetter));
            GaxPreconditions.CheckNotNull(serviceVersionGetter, nameof(serviceVersionGetter));

            builder.ConfigureServices((context, services) =>
            {
                ConfigureGoogleDiagnosticsServices(services, projectIdGetter(context), serviceNameGetter(context), serviceVersionGetter(context), null);
            });

            return builder;
        }

        // Overload which allows passing in a MonitoredResource instance
        // Internal for testing
        internal static IWebHostBuilder UseGoogleDiagnostics(this IWebHostBuilder builder, string projectId = null, string serviceName = null, string serviceVersion = null, MonitoredResource monitoredResource = null)
        {
            builder.ConfigureServices(services =>
            {
                ConfigureGoogleDiagnosticsServices(services, projectId, serviceName, serviceVersion, monitoredResource);
            });

            return builder;
        }

        private static void ConfigureGoogleDiagnosticsServices(IServiceCollection services, string projectId, string serviceName, string serviceVersion, MonitoredResource monitoredResource)
        {
            projectId = Project.GetAndCheckProjectId(projectId, monitoredResource);

            services.AddLogEntryLabelProvider<TraceIdLogEntryLabelProvider>();
            services.AddSingleton<IStartupFilter>(new GoogleDiagnosticsStartupFilter(projectId, monitoredResource));
            services.AddGoogleTrace(options => options.ProjectId = projectId);
            services.AddGoogleExceptionLogging(options =>
            {
                options.ProjectId = projectId;
                options.ServiceName = Project.GetAndCheckServiceName(serviceName, monitoredResource);
                options.Version = Project.GetAndCheckServiceVersion(serviceVersion, monitoredResource);
            });
        }
    }
}
