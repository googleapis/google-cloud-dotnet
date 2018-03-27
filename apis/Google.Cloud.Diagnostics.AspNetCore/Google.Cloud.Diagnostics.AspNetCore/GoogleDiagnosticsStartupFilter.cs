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

using System;
using Google.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// A startup filter to configure Google Diagnostics services.
    /// </summary>
    internal class GoogleDiagnosticsStartupFilter : IStartupFilter
    {
        private readonly string _projectId;
        private readonly MonitoredResource _monitoredResource;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDiagnosticsStartupFilter"/> class to configure Google Diagnostics services.
        /// </summary>
        /// <param name="projectId">
        /// The Google Cloud Platform project ID. If unspecified and running on GAE or GCE
        /// the project ID will be detected from the platform.
        /// </param>
        /// <param name="monitoredResource">
        /// Optional, the monitored resource.  The monitored resource will be automatically detected
        /// if it is not set and will default to the global resource if the detection fails.
        /// </param>
        public GoogleDiagnosticsStartupFilter(string projectId, MonitoredResource monitoredResource = null)
        {
            _projectId = projectId;
            _monitoredResource = monitoredResource;
        }

        /// <summary>
        /// Registers the startup filter configuration action.
        /// </summary>
        /// <param name="next">A callback to the next startup filter configuration.</param>
        /// <returns>A callback of the startup filter configuration.</returns>
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                var loggerFactory = app.ApplicationServices.GetServiceCheckNotNull<ILoggerFactory>();
                loggerFactory.AddGoogle(app.ApplicationServices, _projectId, LoggerOptions.Create(monitoredResource: _monitoredResource));
                app.UseGoogleExceptionLogging();
                app.UseGoogleTrace();

                next(app);
            };
        }
    }
}
