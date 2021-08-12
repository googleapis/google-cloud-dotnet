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

using Google.Api.Gax;
using Grpc.Core;
using System.Linq;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Compute.V1
{
    /// <summary>
    /// Methods to adapt between "standard" LROs and Compute LROs.
    /// </summary>
    internal static class OperationAdapter
    {
        private const string LroGetMethodName = "/google.longrunning.Operations/GetOperation";
        private static PathTemplate ZonalNameTemplate { get; } = new PathTemplate("projects/{project}/zones/{zone}/operations/{operation}");
        private static PathTemplate RegionalNameTemplate { get; } = new PathTemplate("projects/{project}/regions/{region}/operations/{operation}");
        private static PathTemplate GlobalNameTemplate { get; } = new PathTemplate("projects/{project}/operations/{operation}");

        // FIXME: This is almost certainly wrong.
        private static PathTemplate GlobalOrganizationNameTemplate { get; } = new PathTemplate("parents/{parent}/operations/{operation}");

        internal static lro::Operation ToZonalOperation(this Operation computeOperation, string project, string zone) =>
            CreateRawOperation(computeOperation, ZonalNameTemplate.Expand(project, zone, computeOperation.Name));

        internal static lro::Operation ToRegionalOperation(this Operation computeOperation, string project, string region) =>
            CreateRawOperation(computeOperation, RegionalNameTemplate.Expand(project, region, computeOperation.Name));

        internal static lro::Operation ToGlobalOperation(this Operation computeOperation, string project) =>
            CreateRawOperation(computeOperation, GlobalNameTemplate.Expand(project, computeOperation.Name));

        internal static lro::Operation ToGlobalOrganizationOperation(this Operation computeOperation) =>
            CreateRawOperation(computeOperation, GlobalOrganizationNameTemplate.Expand(computeOperation.Name));

        // TODO: adapt the cancel, list, wait and delete methods too.
        internal static CallInvoker CreateZonalCallInvoker(CallInvoker callInvoker) =>
            ForwardingCallInvoker<lro::GetOperationRequest>.Create(callInvoker, LroGetMethodName, ZoneOperations.GetMethod, ConvertZoneRequest, ConvertResponse);

        internal static CallInvoker CreateRegionalCallInvoker(CallInvoker callInvoker) =>
            ForwardingCallInvoker<lro::GetOperationRequest>.Create(callInvoker, LroGetMethodName, RegionOperations.GetMethod, ConvertRegionalRequest, ConvertResponse);

        internal static CallInvoker CreateGlobalCallInvoker(CallInvoker callInvoker) =>
            ForwardingCallInvoker<lro::GetOperationRequest>.Create(callInvoker, LroGetMethodName, GlobalOperations.GetMethod, ConvertGlobalRequest, ConvertResponse);

        internal static CallInvoker CreateGlobalOrganizationCallInvoker(CallInvoker callInvoker) =>
            ForwardingCallInvoker<lro::GetOperationRequest>.Create(callInvoker, LroGetMethodName, GlobalOrganizationOperations.GetMethod, ConvertGlobalOrganizationRequest, ConvertResponse);

        private static lro::Operation ConvertResponse(lro::GetOperationRequest lroRequest, Operation computeResponse) => CreateRawOperation(computeResponse, lroRequest.Name);

        private static GetZoneOperationRequest ConvertZoneRequest(lro::GetOperationRequest lroRequest)
        {
            var parsedName = ZonalNameTemplate.ParseName(lroRequest.Name);
            return new GetZoneOperationRequest
            {
                Project = parsedName[0],
                Zone = parsedName[1],
                Operation = parsedName[2]
            };
        }

        private static GetRegionOperationRequest ConvertRegionalRequest(lro::GetOperationRequest lroRequest)
        {
            var parsedName = RegionalNameTemplate.ParseName(lroRequest.Name);
            return new GetRegionOperationRequest
            {
                Project = parsedName[0],
                Region = parsedName[1],
                Operation = parsedName[2]
            };
        }

        private static GetGlobalOperationRequest ConvertGlobalRequest(lro::GetOperationRequest lroRequest)
        {
            var parsedName = GlobalNameTemplate.ParseName(lroRequest.Name);
            return new GetGlobalOperationRequest
            {
                Project = parsedName[0],
                Operation = parsedName[1]
            };
        }

        private static GetGlobalOrganizationOperationRequest ConvertGlobalOrganizationRequest(lro::GetOperationRequest lroRequest)
        {
            var parsedName = GlobalOrganizationNameTemplate.ParseName(lroRequest.Name);
            return new GetGlobalOrganizationOperationRequest
            {
                ParentId = parsedName[0],
                Operation = parsedName[1]
            };
        }

        private static lro::Operation CreateRawOperation(Operation computeOperation, string name)
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

    // Partial classes to give us access to the underlying gRPC Method abstractions.

    partial class ZoneOperations
    {
        internal static Method<GetZoneOperationRequest, Operation> GetMethod => __Method_Get;
    }

    partial class RegionOperations
    {
        internal static Method<GetRegionOperationRequest, Operation> GetMethod => __Method_Get;
    }

    partial class GlobalOperations
    {
        internal static Method<GetGlobalOperationRequest, Operation> GetMethod => __Method_Get;
    }

    partial class GlobalOrganizationOperations
    {
        internal static Method<GetGlobalOrganizationOperationRequest, Operation> GetMethod => __Method_Get;
    }
}
