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
        public static string GetAndCheckProjectId(string projectId, MonitoredResource monitoredResource = null) =>
            GetProjectId(projectId, monitoredResource) ?? throw new InvalidOperationException("Project ID was not provided and could not be autodetected");

        /// <summary>
        /// Determines the correct project ID from a string <paramref name="projectId"/> and a <see cref="MonitoredResource"/>.
        /// If the specified project ID is not null, it is returned. Otherwise, if the project ID of
        /// the MonitoredResource is not null, it is returned. It both are null, null is returned.
        /// </summary>
        /// <param name="projectId">The project ID. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The Google Cloud project ID.</returns>
        public static string GetProjectId(string projectId, MonitoredResource monitoredResource = null) =>
            projectId ?? GetProjectIdFromResource(GetMonitoredResource(monitoredResource));

        /// <summary>
        /// Determines the correct service name from a string <paramref name="serviceName"/> and a <see cref="MonitoredResource"/>.
        /// If the specified service name is not null, it is returned. Otherwise, if the service name of
        /// the MonitoredResource is not null, it is returned. It both are null,
        /// an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="serviceName">The service name. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The service name that was passed in or detected.</returns>
        public static string GetAndCheckServiceName(string serviceName, MonitoredResource monitoredResource = null) =>
            GetServiceName(serviceName, monitoredResource) ?? throw new InvalidOperationException("Service name was not provided and could not be autodetected");

        /// <summary>
        /// Determines the correct service name from a string <paramref name="serviceName"/> and a <see cref="MonitoredResource"/>.
        /// If the specified service name is not null, it is returned. Otherwise, if the service name of
        /// the MonitoredResource is not null, it is returned. It both are null, null is returned.
        /// </summary>
        /// <param name="serviceName">The service name. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The service name that was passed in or detected.</returns>
        public static string GetServiceName(string serviceName, MonitoredResource monitoredResource = null) =>
            serviceName ?? GetServiceNameFromResource(GetMonitoredResource(monitoredResource));

        /// <summary>
        /// Determines the correct service version from a string <paramref name="serviceVersion"/> and a <see cref="MonitoredResource"/>.
        /// If the specified service version is not null, it is returned. Otherwise, if the service version of
        /// the MonitoredResource provided or detected is not null, it is returned. It both are null,
        /// an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="serviceVersion">The service version. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The Google App Engine service version.</returns>
        public static string GetAndCheckServiceVersion(string serviceVersion, MonitoredResource monitoredResource = null) =>
            GetServiceVersion(serviceVersion, monitoredResource) ?? throw new InvalidOperationException("Service version was not provided and could not be autodetected");

        /// <summary>
        /// Determines the correct service version from a string <paramref name="serviceVersion"/> and a <see cref="MonitoredResource"/>.
        /// If the specified service version is not null, it is returned. Otherwise, if the service version of
        /// the MonitoredResource provided or detected is not null, it is returned. It both are null, null is resturned.
        /// </summary>
        /// <param name="serviceVersion">The service version. Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The service version that was passed in or detected.</returns>
        public static string GetServiceVersion(string serviceVersion, MonitoredResource monitoredResource = null) =>
            serviceVersion ?? GetServiceVersionFromResource(GetMonitoredResource(monitoredResource));

        private static MonitoredResource GetMonitoredResource(MonitoredResource monitoredResource) =>
            monitoredResource ?? _detectedMonitoredResource ?? (_detectedMonitoredResource = MonitoredResourceBuilder.FromPlatform());

        private static string GetProjectIdFromResource(MonitoredResource resource)
        {
            switch (resource?.Type)
            {
                case "gce_instance":
                case "gae_app":
                case "container":
                case "k8s_container":
                case "gke_container":
                case "cloud_run_revision":
                    return GetLabel(resource, "project_id");
                default: return null;
            }
        }

        private static string GetServiceNameFromResource(MonitoredResource resource)
        {
            switch (resource?.Type)
            {
                case "gae_app": return GetLabel(resource, "module_id");
                case "container":
                case "gke_container":
                case "k8s_container":
                    return GetLabel(resource, "container_name");
                case "cloud_run_revision": return GetLabel(resource, "service_name");
                default: return null;
            }
        }

        private static string GetServiceVersionFromResource(MonitoredResource resource)
        {
            switch (resource?.Type)
            {
                case "gae_app": return GetLabel(resource, "version_id");
                case "cloud_run_revision": return GetLabel(resource, "revision_name");
                default: return null;
            }
        }

        private static string GetLabel(MonitoredResource resource, string labelKey)
        {
            resource.Labels.TryGetValue(labelKey, out var resourceLabel);
            return resourceLabel;
        }
    }
}
