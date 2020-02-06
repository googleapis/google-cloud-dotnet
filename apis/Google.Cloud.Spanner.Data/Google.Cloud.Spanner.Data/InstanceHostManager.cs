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

using Google.Api.Gax;
using Google.Cloud.Spanner.Admin.Instance.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Protobuf.WellKnownTypes;
using System;
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
        private ConcurrentDictionary<InstanceName, IList<string>> _instanceEndpointMapping =
            new ConcurrentDictionary<InstanceName, IList<string>>();

        /// <summary>
        /// Resource based routing environment variable name.
        /// </summary>
        public static string ResourceBasedRoutingVariableName = "GOOGLE_CLOUD_SPANNER_ENABLE_RESOURCE_BASED_ROUTING";

        /// <summary>
        /// Resource based routing flag.
        /// </summary>
        public static bool IsResourceBasedRoutingEnabled
        {
            get
            {
                string resourceBaseRoutingFlagValue = Environment.GetEnvironmentVariable(ResourceBasedRoutingVariableName);
                return StringComparer.InvariantCultureIgnoreCase.Equals(resourceBaseRoutingFlagValue, "true");
            }
        }

        /// <summary>
        /// The default instance host manager.
        /// </summary>
        public static InstanceHostManager Default => new InstanceHostManager();

        /// <summary>
        /// Gets a host for the given instance.
        /// If resource based routing is enabled,
        /// this method will attempt to get the given instance endpointUris and return the first one.
        /// The returned endpointUri will be cached to be used in future requests.
        /// </summary>
        /// <param name="instanceName">Resource name for the <see cref="InstanceName"/> resource.</param>
        /// <returns>The host for the given instance if found else null.</returns>
        public string GetHost(InstanceName instanceName)
        {
            if (IsResourceBasedRoutingEnabled)
            {
                return _instanceEndpointMapping.GetOrAdd(instanceName, GetInstanceEndpointUris).FirstOrDefault();
            }
            return null;
        }

        private List<string> GetInstanceEndpointUris(InstanceName instanceName)
        {
            InstanceAdminClient instanceAdminClient = Task.Run(() => InstanceAdminClient.CreateAsync()).ResultWithUnwrappedExceptions();
            // Create request for instance with endpointUris.
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = instanceName,
                FieldMask = new FieldMask { Paths = { "endpoint_uris" } }
            };
            // Get list of available endpointUris from GetInstance.
            Instance instance = instanceAdminClient.GetInstance(request);
            return instance.EndpointUris.ToList();
        }
    }
}
