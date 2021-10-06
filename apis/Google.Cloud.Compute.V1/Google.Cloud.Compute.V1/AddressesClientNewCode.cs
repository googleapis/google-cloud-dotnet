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
    public static partial class Addresses
    {
        public partial class AddressesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient()
            {
                var newCallInvoker = ForwardingCallInvoker<lro::GetOperationRequest>.Create(
                    CallInvoker,
                    "/google.longrunning.Operations/GetOperation", // Hard-coded in the generator?
                    RegionOperations.GetMethod,
                    GetRegionOperationRequest.ParseLroRequest,
                    (request, response) => response.ToLroResponse(request.Name));
                return new lro::Operations.OperationsClient(newCallInvoker);
            }
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