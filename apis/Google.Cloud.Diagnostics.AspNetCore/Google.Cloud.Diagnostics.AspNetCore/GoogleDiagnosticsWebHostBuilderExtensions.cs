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
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Extensions to configure Google Diagnostics on the <see cref="IWebHostBuilder"/>.
    /// </summary>
    public static class GoogleDiagnosticsWebHostBuilderExtensions
    {
        /// <summary>
        /// Configures Google Diagostics services for Logging, Tracing and Error Reporting middleware.
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

        // Overload which allows passing in a MonitoredResource instance
        // Internal for testing
        internal static IWebHostBuilder UseGoogleDiagnostics(this IWebHostBuilder builder, string projectId = null, string serviceName = null, string serviceVersion = null, MonitoredResource monitoredResource = null)
        {
            builder.ConfigureServices(services =>
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
            });

            return builder;
        }
    }
}
