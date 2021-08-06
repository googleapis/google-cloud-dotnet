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

using System.Linq;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Compute.V1
{
    internal static class OperationAdapter
    {
        internal static lro::Operation<Operation, Operation> CreateZonalOperation(Operation computeOperation, string project, string zone, lro::OperationsClient client) =>
            CreateOperation(computeOperation, ZonalLroClient.NameTemplate.Expand(project, zone, computeOperation.Name), client);

        internal static lro::Operation<Operation, Operation> CreateRegionalOperation(Operation computeOperation, string project, string region, lro::OperationsClient client) =>
            CreateOperation(computeOperation, $"projects/{project}/regions/{region}/operations/{computeOperation.Name}", client);

        internal static lro::Operation<Operation, Operation> CreateGlobalOperation(Operation computeOperation, string project, lro::OperationsClient client) =>
            CreateOperation(computeOperation, $"projects/{project}/operations/{computeOperation.Name}", client);

        internal static lro::Operation<Operation, Operation> CreateOperation(Operation computeOperation, string name, lro::OperationsClient client)
        {
            return new lro.Operation<Operation, Operation>(CreateRawOperation(computeOperation, name), client);
        }

        internal static lro::Operation CreateRawOperation(Operation computeOperation, string name)
        {
            // TODO: Work this out much more carefully. In particular, consider whether a Compute LRO can complete successfully with errors...
            var proto = new lro::Operation
            {
                Done = computeOperation.Status == Operation.Types.Status.Done,
                Name = name,
                Metadata = wkt::Any.Pack(computeOperation)
            };
            if (proto.Done)
            {
                proto.Response = proto.Metadata;
            }
            if (computeOperation.Error is Error error)
            {
                proto.Error = new Rpc.Status { Code = (int)Rpc.Code.Unknown, Message = string.Join(", ", error.Errors.Select(e => e.Message)) };
            }
            return proto;
        }
    }
}
