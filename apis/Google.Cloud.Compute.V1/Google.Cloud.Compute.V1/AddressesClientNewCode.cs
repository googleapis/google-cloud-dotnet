// Copyright 2021 Google LLC
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

using lro = Google.LongRunning;

namespace Google.Cloud.Compute.V1
{
    partial class Addresses
    {
        partial class AddressesClient
        {
            /// <summary>
            /// Creates an OperationsClient that delegates to RegionOperationsClient.
            /// </summary>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }

    partial class DeleteAddressRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            // From (google.cloud.operation_request_field) = "project"
            pollRequest.Project = Project;
            // From (google.cloud.operation_request_field) = "region"
            pollRequest.Region = Region;
        }
    }

    partial class InsertAddressRequest
    {
        internal void PopulatePollRequestFields(GetRegionOperationRequest pollRequest)
        {
            // From (google.cloud.operation_request_field) = "project"
            pollRequest.Project = Project;
            // From (google.cloud.operation_request_field) = "region"
            pollRequest.Region = Region;
        }
    }
}