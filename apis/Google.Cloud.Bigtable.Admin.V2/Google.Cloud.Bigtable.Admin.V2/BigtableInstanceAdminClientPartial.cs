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
using Google.Cloud.Iam.V1;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableInstanceAdminClientImpl
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_Instance(ref Instance request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_Cluster(ref Cluster request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_CreateAppProfileRequest(ref CreateAppProfileRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_DeleteAppProfileRequest(ref DeleteAppProfileRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_GetAppProfileRequest(ref GetAppProfileRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Name);

        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Resource);

        partial void Modify_ListAppProfilesRequest(ref ListAppProfilesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_PartialUpdateInstanceRequest(ref PartialUpdateInstanceRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Instance.Name);

        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Resource);

        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Resource);

        partial void Modify_UpdateAppProfileRequest(ref UpdateAppProfileRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.AppProfile.Name);

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, string resource)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, resource);
        }
    }
}
