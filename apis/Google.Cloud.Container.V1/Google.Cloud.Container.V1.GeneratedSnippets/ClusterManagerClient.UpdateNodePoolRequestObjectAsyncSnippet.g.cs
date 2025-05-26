// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    // [START container_v1_generated_ClusterManager_UpdateNodePool_async]
    using Google.Cloud.Container.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedClusterManagerClientSnippets
    {
        /// <summary>Snippet for UpdateNodePoolAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateNodePoolRequestObjectAsync()
        {
            // Create client
            ClusterManagerClient clusterManagerClient = await ClusterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNodePoolRequest request = new UpdateNodePoolRequest
            {
                NodeVersion = "",
                ImageType = "",
                Name = "",
                Locations = { "", },
                WorkloadMetadataConfig = new WorkloadMetadataConfig(),
                UpgradeSettings = new NodePool.Types.UpgradeSettings(),
                Tags = new NetworkTags(),
                Taints = new NodeTaints(),
                Labels = new NodeLabels(),
                LinuxNodeConfig = new LinuxNodeConfig(),
                KubeletConfig = new NodeKubeletConfig(),
                NodeNetworkConfig = new NodeNetworkConfig(),
                GcfsConfig = new GcfsConfig(),
                ConfidentialNodes = new ConfidentialNodes(),
                Gvnic = new VirtualNIC(),
                Etag = "",
                FastSocket = new FastSocket(),
                LoggingConfig = new NodePoolLoggingConfig(),
                ResourceLabels = new ResourceLabels(),
                WindowsNodeConfig = new WindowsNodeConfig(),
                Accelerators =
                {
                    new AcceleratorConfig(),
                },
                MachineType = "",
                DiskType = "",
                DiskSizeGb = 0L,
                ResourceManagerTags = new ResourceManagerTags(),
                ContainerdConfig = new ContainerdConfig(),
                QueuedProvisioning = new NodePool.Types.QueuedProvisioning(),
                StoragePools = { "", },
                MaxRunDuration = new Duration(),
                FlexStart = false,
            };
            // Make the request
            Operation response = await clusterManagerClient.UpdateNodePoolAsync(request);
        }
    }
    // [END container_v1_generated_ClusterManager_UpdateNodePool_async]
}
