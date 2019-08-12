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

using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableInstanceAdminSettings
    {
        /// <summary>
        /// The version of IAM policies that the client will indicate that it supports in RPCs.
        /// This defaults to a null value, meaning that requests will not be modified at all.
        /// If a value is already present in a request, it is not overwritten.
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
            if (supportedIamPolicyVersion == null)
            {
                return;
            }
            // TODO: Set the appropriate field            
        }
    }
}
