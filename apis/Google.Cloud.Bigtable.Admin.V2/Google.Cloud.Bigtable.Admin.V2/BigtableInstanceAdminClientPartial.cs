// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableInstanceAdminClientImpl
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderForProject(ref settings, request.Parent);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.InstanceName);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderForProject(ref settings, request.Parent);

        // TODO: Determine why this generated as Instance instead of UpdateInstanceRequest
        partial void Modify_Instance(ref Instance request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.InstanceName);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.InstanceName);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderForInstance(ref settings, request.Parent);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.ClusterName);

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeaderForInstance(ref settings, request.Parent);

        // TODO: Determine why this generated as Cluster instead of UpdateClusterRequest
        partial void Modify_Cluster(ref Cluster request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.ClusterName);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.ClusterName);

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, InstanceName instanceName)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, instanceName.ToString());
        }

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, ClusterName clusterName)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, clusterName.ToString());
        }

        private static void ApplyResourcePrefixHeaderForInstance(ref CallSettings settings, string instanceName)
        {
            ApplyResourcePrefixHeader(ref settings, InstanceName.Parse(instanceName));
        }

        private static void ApplyResourcePrefixHeaderForProject(ref CallSettings settings, string projectName)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, ProjectName.Parse(projectName).ToString());
        }
    }
}
