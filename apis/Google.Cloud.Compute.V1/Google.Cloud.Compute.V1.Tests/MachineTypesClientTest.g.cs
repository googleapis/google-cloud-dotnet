// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMachineTypesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<MachineTypes.MachineTypesClient> mockGrpcClient = new moq::Mock<MachineTypes.MachineTypesClient>(moq::MockBehavior.Strict);
            GetMachineTypeRequest request = new GetMachineTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                MachineType = "machine_type68ce40fa",
            };
            MachineType expectedResponse = new MachineType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                ImageSpaceGb = 480303298,
                MemoryMb = -1241574521,
                MaximumPersistentDisksSizeGb = -4994613391596960505L,
                Accelerators = { new Accelerators(), },
                GuestCpus = 325324266,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ScratchDisks = { new ScratchDisks(), },
                MaximumPersistentDisks = 774121303,
                Deprecated = new DeprecationStatus(),
                IsSharedCpu = true,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MachineTypesClient client = new MachineTypesClientImpl(mockGrpcClient.Object, null);
            MachineType response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<MachineTypes.MachineTypesClient> mockGrpcClient = new moq::Mock<MachineTypes.MachineTypesClient>(moq::MockBehavior.Strict);
            GetMachineTypeRequest request = new GetMachineTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                MachineType = "machine_type68ce40fa",
            };
            MachineType expectedResponse = new MachineType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                ImageSpaceGb = 480303298,
                MemoryMb = -1241574521,
                MaximumPersistentDisksSizeGb = -4994613391596960505L,
                Accelerators = { new Accelerators(), },
                GuestCpus = 325324266,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ScratchDisks = { new ScratchDisks(), },
                MaximumPersistentDisks = 774121303,
                Deprecated = new DeprecationStatus(),
                IsSharedCpu = true,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MachineType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MachineTypesClient client = new MachineTypesClientImpl(mockGrpcClient.Object, null);
            MachineType responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MachineType responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<MachineTypes.MachineTypesClient> mockGrpcClient = new moq::Mock<MachineTypes.MachineTypesClient>(moq::MockBehavior.Strict);
            GetMachineTypeRequest request = new GetMachineTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                MachineType = "machine_type68ce40fa",
            };
            MachineType expectedResponse = new MachineType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                ImageSpaceGb = 480303298,
                MemoryMb = -1241574521,
                MaximumPersistentDisksSizeGb = -4994613391596960505L,
                Accelerators = { new Accelerators(), },
                GuestCpus = 325324266,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ScratchDisks = { new ScratchDisks(), },
                MaximumPersistentDisks = 774121303,
                Deprecated = new DeprecationStatus(),
                IsSharedCpu = true,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MachineTypesClient client = new MachineTypesClientImpl(mockGrpcClient.Object, null);
            MachineType response = client.Get(request.Project, request.Zone, request.MachineType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<MachineTypes.MachineTypesClient> mockGrpcClient = new moq::Mock<MachineTypes.MachineTypesClient>(moq::MockBehavior.Strict);
            GetMachineTypeRequest request = new GetMachineTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                MachineType = "machine_type68ce40fa",
            };
            MachineType expectedResponse = new MachineType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                ImageSpaceGb = 480303298,
                MemoryMb = -1241574521,
                MaximumPersistentDisksSizeGb = -4994613391596960505L,
                Accelerators = { new Accelerators(), },
                GuestCpus = 325324266,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ScratchDisks = { new ScratchDisks(), },
                MaximumPersistentDisks = 774121303,
                Deprecated = new DeprecationStatus(),
                IsSharedCpu = true,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MachineType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MachineTypesClient client = new MachineTypesClientImpl(mockGrpcClient.Object, null);
            MachineType responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.MachineType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MachineType responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.MachineType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
