// Copyright 2020 Google Inc. All Rights Reserved.
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

using Google.Cloud.Spanner.Admin.Instance.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Host manager for Spanner data client to get and cache the endpointUris for an instance.
    /// </summary>
    public sealed class InstanceHostManager
    {
        private ConcurrentDictionary<string, IList<string>> _instanceEndpointMapping =
            new ConcurrentDictionary<string, IList<string>>();

        /// <summary>
        /// The default instance host manager.
        /// </summary>
        public static InstanceHostManager Default => new InstanceHostManager();

        /// <summary>
        /// Gets a host for the given instance.
        /// If resource based routing is enabled (environment variable "GOOGLE_CLOUD_SPANNER_ENABLE_RESOURCE_BASED_ROUTING"),
        /// this method will attempt to get the given instance endpointUris and return the first one.
        /// The returning endpointUri will be cached to be used in future inquiries.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <returns>The host for the given instance if found else null.</returns>
        public async Task<string> GetHostAsync(string projectId, string instanceId)
        {
            if (SpannerConstants.IsResourceBasedRoutingEnabled)
            {
                if (!_instanceEndpointMapping.ContainsKey(instanceId))
                {
                    var instanceEndpointUris = await GetInstanceEndpointUrisAsync(projectId, instanceId).ConfigureAwait(false);
                    _instanceEndpointMapping[instanceId] = instanceEndpointUris;
                }
                return _instanceEndpointMapping[instanceId].FirstOrDefault();
            }
            return null;
        }

        private async Task<List<string>> GetInstanceEndpointUrisAsync(string projectId, string instanceId)
        {
            InstanceAdminClient instanceAdminClient =
                    await InstanceAdminClient.CreateAsync().ConfigureAwait(false);
            // Create request for instance with endpointUris.
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName(projectId, instanceId),
                FieldMask = new FieldMask { Paths = { "endpoint_uris" } }
            };
            // Get list of available endpointUris from GetInstance.
            Instance instance = instanceAdminClient.GetInstance(request);
            return instance.EndpointUris.ToList();
        }
    }
}
