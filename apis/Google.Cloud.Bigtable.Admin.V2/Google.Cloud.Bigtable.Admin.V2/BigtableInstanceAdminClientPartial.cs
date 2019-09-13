// Copyright 2019 Google LLC
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

// Partial classes to support IAM policy versions

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableInstanceAdminSettings
    {
        /// <summary>
        /// The version of IAM policies that the client will indicate that it supports in RPCs.
        /// This defaults to a null value, meaning that requests will not be modified at all.
        /// value is already present in a GetIamPolicy request, it is not overwritten.
        /// When setting a policy, the <see cref="Policy.Version"/> is unconditionally set to this
        /// value before being sent. (A clone is made where required, so the policy object passed in
        /// is not modified.)
        /// </summary>
        public int? SupportedIamPolicyVersion { get; set; }

        partial void OnCopy(BigtableInstanceAdminSettings existing)
        {
            SupportedIamPolicyVersion = existing.SupportedIamPolicyVersion;
        }
    }

    public partial class BigtableInstanceAdminClientImpl
    {
        private int? supportedIamPolicyVersion;

        partial void OnConstruction(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings effectiveSettings, ClientHelper clientHelper)
        {
            supportedIamPolicyVersion = effectiveSettings.SupportedIamPolicyVersion;
        }

        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            // No need to modify anything if either the user hasn't specified the setting (most common case)
            // or they've already specified a particular policy version in the request.
            if (supportedIamPolicyVersion == null || (request.Options?.RequestedPolicyVersion ?? 0) != 0)
            {
                return;
            }
            // Clone the original request to avoid modifying user-provided objects.
            request = request.Clone();
            if (request.Options == null)
            {
                request.Options = new GetPolicyOptions();
            }
            request.Options.RequestedPolicyVersion = supportedIamPolicyVersion.Value;
        }

        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            if (supportedIamPolicyVersion == null || request.Policy == null || request.Policy.Version == supportedIamPolicyVersion)
            {
                return;
            }
            // We always need to clone and modify here: just because there's a policy version set doesn't mean the
            // user set it.
            request = request.Clone();
            request.Policy.Version = supportedIamPolicyVersion.Value;
        }
    }
}
