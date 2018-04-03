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
using Google.Api.Gax.Grpc;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Operations for Cloud Console Projects.
    /// </summary>
    public static class Project
    {
        /// <summary>
        /// Stores a cached instance of <see cref="MonitoredResource"/> detected from <see cref="MonitoredResourceBuilder.FromPlatform()"/>
        /// to be used in subsequent calls to <see cref="GetAndCheckProjectId(string, MonitoredResource)"/>,
        /// <see cref="GetAndCheckServiceName(string, MonitoredResource)"/> and <see cref="GetAndCheckServiceVersion(string, MonitoredResource)"/>.
        /// </summary>
        private static MonitoredResource _detectedMonitoredResource;

        /// <summary>
        /// Determines the correct project id from a string project id and a <see cref="MonitoredResource"/>.
        /// If the specified project id is not null, it is returned. Otherwise, if the project id of
        /// the MonitoredResource is not null, it is returned. It both are null,
        /// an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="projectId">The Google Cloud project ID.  Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The Google Cloud project ID.</returns>
        public static string GetAndCheckProjectId(string projectId, MonitoredResource monitoredResource = null)
            => GetAndCheckLabel(projectId, "project_id", "Google Cloud project ID", monitoredResource);

        /// <summary>
        /// Determines the correct service name from a string <paramref name="serviceName"/> and a <see cref="MonitoredResource"/>.
        /// If the specified service name is not null, it is returned. Otherwise, if the service name of
        /// the MonitoredResource is not null, it is returned. It both are null,
        /// an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="serviceName">The Google App Engine service name. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The Google App Engine service name.</returns>
        public static string GetAndCheckServiceName(string serviceName, MonitoredResource monitoredResource = null)
            => GetAndCheckLabel(serviceName, "module_id", "Google App Engine service name", monitoredResource);

        /// <summary>
        /// Determines the correct service version from a string <paramref name="serviceVersion"/> and a <see cref="MonitoredResource"/>.
        /// If the specified service name is not null, it is returned. Otherwise, if the service name of
        /// the MonitoredResource is not null, it is returned. It both are null,
        /// an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="serviceVersion">The Google App Engine service version. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The Google App Engine service version.</returns>
        public static string GetAndCheckServiceVersion(string serviceVersion, MonitoredResource monitoredResource = null)
            => GetAndCheckLabel(serviceVersion, "version_id", "Google App Engine service version", monitoredResource);

        /// <summary>
        /// Returns <paramref name="specifiedLabel"/> if specified, otherwise attempts to resolve the <paramref name="labelKey"/>
        /// from the given, detected or cached <see cref="MonitoredResource"/> instance.
        /// </summary>
        /// <param name="specifiedLabel">The label value specified by the caller.</param>
        /// <param name="labelKey">The key of the label.</param>
        /// <param name="labelName">The friendly name of the value. Used in the exception message.</param>
        /// <param name="monitoredResource">Optional, the <see cref="MonitoredResource"/> instance.</param>
        /// <returns>The resolved value of the label.</returns>
        private static string GetAndCheckLabel(string specifiedLabel, string labelKey, string labelName, MonitoredResource monitoredResource = null)
        {
            if (specifiedLabel != null)
            {
                return specifiedLabel;
            }

            monitoredResource = monitoredResource ?? _detectedMonitoredResource ?? (_detectedMonitoredResource = MonitoredResourceBuilder.FromPlatform());
            if (monitoredResource.Labels.TryGetValue(labelKey, out var resourceLabel))
            {
                return resourceLabel;
            }

            throw new InvalidOperationException($"No {labelName} was passed in or detected.");
        }
    }
}
