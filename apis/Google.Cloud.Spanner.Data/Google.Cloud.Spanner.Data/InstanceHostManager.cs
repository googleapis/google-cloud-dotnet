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
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// host manager for spanner data client to get and cache the endpointUris for an instance.
    /// </summary>
    public sealed class InstanceHostManager
    {
        private static ConcurrentDictionary<string, RepeatedField<string>> _instanceEndpointMapping =
            new ConcurrentDictionary<string, RepeatedField<string>>();
        Random random = new Random();
        private bool IsResourceBasedRoutingEnabled
        {
            get
            {
                string resourceBaseRoutingFlagValue = Environment.GetEnvironmentVariable("GOOGLE_CLOUD_ENABLE_RESOURCE_BASED_ROUTING");
                return StringComparer.InvariantCultureIgnoreCase.Equals(resourceBaseRoutingFlagValue, "true");
            }
        }

        static InstanceHostManager() { }

        /// <summary>
        /// The default instance host manager
        /// </summary>
        public static InstanceHostManager Default => new InstanceHostManager();

        /// <summary>
        /// get host for specific instance
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="instanceId"></param>
        /// <returns>host</returns>
        public string GetHost(string projectId, string instanceId)
        {
            if (IsResourceBasedRoutingEnabled)
            {
                string cacheKey = $"{projectId}-{instanceId}";
                if (!_instanceEndpointMapping.ContainsKey(cacheKey))
                {
                    RepeatedField<string> instanceEndpointUris = GetInstanceEndpointUriAsync(projectId, instanceId).Result;
                    _instanceEndpointMapping.GetOrAdd(cacheKey, instanceEndpointUris);
                }
                return _instanceEndpointMapping[cacheKey].ElementAtOrDefault(random.Next(_instanceEndpointMapping[cacheKey].Count));
            }
            return null;
        }



        private async Task<RepeatedField<string>> GetInstanceEndpointUriAsync(string projectId, string instanceId)
        {
            InstanceAdminClient instanceAdminClient =
                    await InstanceAdminClient.CreateAsync().ConfigureAwait(false);
            // Create request for instance with endpoints.
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName(projectId, instanceId),
                FieldMask = new FieldMask { Paths = { "endpoint_uris" } }
            };
            try
            {
                // Get list of available endpointUris from GetInstance.
                Instance instance = instanceAdminClient.GetInstance(request);
                return instance.EndpointUris;
            }
            catch (RpcException gRpcException) when (gRpcException.StatusCode == StatusCode.PermissionDenied)
            {
                Logger.DefaultLogger.Warn("spanner.instances.get permisssion must be added to use resource based routing.");
                return new RepeatedField<string>();
            }
        }
    }
}
