// Copyright 2020 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Spanner.Common.V1;
using System;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    // Partial class to set up resource-based routing.
    public partial class InstanceAdminClientImpl
    {
        /// <summary>
        /// The name of the header used for efficiently routing requests.
        /// </summary>
        /// <remarks>
        /// This should be set to the instance resource name ("projects/{projectId}/instances/{instanceId}") for some RPCs
        /// and to the project resource name for others ("projects/{projectId}").
        /// For non-streaming calls, <see cref="InstanceAdminClientImpl"/> performs this automatically. This cannot be performed
        /// automatically for streaming calls due to the separation between initializing the stream and sending requests, so
        /// client code should set the value in a <see cref="CallSettings"/>. Typically this is performed with either the
        /// <see cref="CallSettings.FromHeader(string, string)"/> factory method or the
        /// <see cref="CallSettingsExtensions.WithHeader(CallSettings, string, string)"/> extension method.
        /// </remarks>
        public const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_ListInstanceConfigsRequest(ref ListInstanceConfigsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromProject(ref settings, request.Parent);

        partial void Modify_GetInstanceConfigRequest(ref GetInstanceConfigRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstanceConfig(ref settings, request.Name);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromProject(ref settings, request.Parent);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Name);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromProject(ref settings, request.Parent);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Instance.Name);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderFromInstance(ref settings, request.Name);

        private static void ApplyResourcePrefixHeaderFromInstance(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (InstanceName.TryParse(resource, out InstanceName instance))
            {
                settings = settings.WithHeader(ResourcePrefixHeader, instance.ToString());
            }
        }

        private static void ApplyResourcePrefixHeaderFromProject(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (ProjectName.TryParse(resource, out ProjectName project))
            {
                settings = settings.WithHeader(ResourcePrefixHeader, project.ToString());
            }
        }

        private static void ApplyResourcePrefixHeaderFromInstanceConfig(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (InstanceConfigName.TryParse(resource, out InstanceConfigName instanceConfig))
            {
                var project = ProjectName.FromProject(instanceConfig.ProjectId);
                settings = settings.WithHeader(ResourcePrefixHeader, project.ToString());
            }
        }
    }
}
