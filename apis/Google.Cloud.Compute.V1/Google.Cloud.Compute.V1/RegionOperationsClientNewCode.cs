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

using Grpc.Core;
using lro = Google.LongRunning;
using Google.Api.Gax;

namespace Google.Cloud.Compute.V1
{
    partial class RegionOperations
    {
        partial class RegionOperationsClient
        {
            /// <summary>
            /// Creates a Google.LongRunning.OperationsClient using the specified CallInvoker, but
            /// redirecting Google.LongRunning RPCs to RegionOperations RPCs. (Currently just Get, but
            /// could be others in the future.)
            /// </summary>
            internal static lro::Operations.OperationsClient CreateOperationsClient(CallInvoker callInvoker)
            {
                var newCallInvoker = ForwardingCallInvoker<lro::GetOperationRequest>.Create(
                    callInvoker,
                    "/google.longrunning.Operations/GetOperation", // Hard-coded in the generator?
                    __Method_Get,
                    GetRegionOperationRequest.ParseLroRequest,
                    (request, response) => response.ToLroResponse(request.Name));
                return new lro::Operations.OperationsClient(newCallInvoker);
            }
        }
    }

    partial class GetRegionOperationRequest
    {
        // These are the required fields of the proto, in numeric order, with the field name before each value.
        // It's not ideal, but it's portable, consistent, and doesn't need any more annotations.
        private static readonly PathTemplate s_operationNameTemplate = new PathTemplate("operation/{operation}/region/{region}/project/{project}");

        internal static GetRegionOperationRequest ParseLroRequest(lro::GetOperationRequest request)
        {
            // TODO: TryParseName?
            var parsedName = s_operationNameTemplate.ParseName(request.Name);
            return new GetRegionOperationRequest
            {
                // Populate properties using the same order as we generated for s_operationNameTemplate
                Operation = parsedName[0],
                Region = parsedName[1],
                Project = parsedName[2],
            };
        }

        // Populates the poll request fields from an initial response.
        internal static GetRegionOperationRequest FromInitialResponse(Operation response)
        {
            return new GetRegionOperationRequest
            {
                // From (google.cloud.operation_response_field) = "name"
                Operation = response.Name
            };
        }

        // List the properties in the same way that we used them for s_operationNameTemplate
        internal string ToLroOperationName() => s_operationNameTemplate.Expand(Operation, Region, Project);
    }
}
