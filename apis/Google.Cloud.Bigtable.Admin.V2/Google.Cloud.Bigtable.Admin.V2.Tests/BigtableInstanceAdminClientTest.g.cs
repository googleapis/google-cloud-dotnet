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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBigtableInstanceAdminClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInstancesRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PageToken = "page_tokenf09e5538",
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                Instances = { new Instance(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse response = client.ListInstances(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInstancesRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                PageToken = "page_tokenf09e5538",
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                Instances = { new Instance(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse responseCallSettings = await client.ListInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInstancesResponse responseCancellationToken = await client.ListInstancesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInstances()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                Instances = { new Instance(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse response = client.ListInstances(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInstancesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                Instances = { new Instance(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse responseCallSettings = await client.ListInstancesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInstancesResponse responseCancellationToken = await client.ListInstancesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListInstancesResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                Instances = { new Instance(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListInstances(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse response = client.ListInstances(request.ParentAsProjectName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListInstancesResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListInstancesResponse expectedResponse = new ListInstancesResponse
            {
                Instances = { new Instance(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListInstancesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListInstancesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListInstancesResponse responseCallSettings = await client.ListInstancesAsync(request.ParentAsProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListInstancesResponse responseCancellationToken = await client.ListInstancesAsync(request.ParentAsProjectName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateInstanceRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            Instance request = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.UpdateInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateInstanceRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            Instance request = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "display_name137f65c2",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.UpdateInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstanceRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstanceRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstanceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstance()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstanceAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstanceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstanceResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request.InstanceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstanceResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstanceAsync(request.InstanceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClusterRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.Resizing,
                ServeNodes = -1708916177,
                DefaultStorageType = StorageType.Ssd,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.Resizing,
                ServeNodes = -1708916177,
                DefaultStorageType = StorageType.Ssd,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCluster()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.Resizing,
                ServeNodes = -1708916177,
                DefaultStorageType = StorageType.Ssd,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.Resizing,
                ServeNodes = -1708916177,
                DefaultStorageType = StorageType.Ssd,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetClusterResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.Resizing,
                ServeNodes = -1708916177,
                DefaultStorageType = StorageType.Ssd,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request.ClusterName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetClusterResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            Cluster expectedResponse = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.Resizing,
                ServeNodes = -1708916177,
                DefaultStorageType = StorageType.Ssd,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Cluster>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            Cluster responseCallSettings = await client.GetClusterAsync(request.ClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Cluster responseCancellationToken = await client.GetClusterAsync(request.ClusterName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListClustersRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                PageToken = "page_tokenf09e5538",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListClusters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListClustersRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                PageToken = "page_tokenf09e5538",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListClustersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse responseCallSettings = await client.ListClustersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListClustersResponse responseCancellationToken = await client.ListClustersAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListClusters()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListClusters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListClustersAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListClustersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse responseCallSettings = await client.ListClustersAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListClustersResponse responseCancellationToken = await client.ListClustersAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListClustersResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListClusters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request.ParentAsInstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListClustersResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            ListClustersResponse expectedResponse = new ListClustersResponse
            {
                Clusters = { new Cluster(), },
                FailedLocations =
                {
                    "failed_locations8c4c58ba",
                },
                NextPageToken = "next_page_tokendbee0940",
            };
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListClustersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse responseCallSettings = await client.ListClustersAsync(request.ParentAsInstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListClustersResponse responseCancellationToken = await client.ListClustersAsync(request.ParentAsInstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteClusterRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteCluster(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteClusterRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteClusterAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCluster()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteCluster(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteClusterAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteClusterAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteClusterAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteClusterResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCluster(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteCluster(request.ClusterName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteClusterResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteClusterAsync(request.ClusterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteClusterAsync(request.ClusterName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAppProfileRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "app_profile_id57fb0442",
                AppProfile = new AppProfile(),
                IgnoreWarnings = true,
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.CreateAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.CreateAppProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAppProfileRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "app_profile_id57fb0442",
                AppProfile = new AppProfile(),
                IgnoreWarnings = true,
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.CreateAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile responseCallSettings = await client.CreateAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppProfile responseCancellationToken = await client.CreateAppProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAppProfile()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "app_profile_id57fb0442",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.CreateAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.CreateAppProfile(request.Parent, request.AppProfileId, request.AppProfile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAppProfileAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "app_profile_id57fb0442",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.CreateAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile responseCallSettings = await client.CreateAppProfileAsync(request.Parent, request.AppProfileId, request.AppProfile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppProfile responseCancellationToken = await client.CreateAppProfileAsync(request.Parent, request.AppProfileId, request.AppProfile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAppProfileResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "app_profile_id57fb0442",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.CreateAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.CreateAppProfile(request.ParentAsInstanceName, request.AppProfileId, request.AppProfile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAppProfileResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "app_profile_id57fb0442",
                AppProfile = new AppProfile(),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.CreateAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile responseCallSettings = await client.CreateAppProfileAsync(request.ParentAsInstanceName, request.AppProfileId, request.AppProfile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppProfile responseCancellationToken = await client.CreateAppProfileAsync(request.ParentAsInstanceName, request.AppProfileId, request.AppProfile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppProfileRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.GetAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.GetAppProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppProfileRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.GetAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile responseCallSettings = await client.GetAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppProfile responseCancellationToken = await client.GetAppProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppProfile()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.GetAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.GetAppProfile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppProfileAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.GetAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile responseCallSettings = await client.GetAppProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppProfile responseCancellationToken = await client.GetAppProfileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAppProfileResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.GetAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile response = client.GetAppProfile(request.AppProfileName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAppProfileResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            AppProfile expectedResponse = new AppProfile
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
                MultiClusterRoutingUseAny = new AppProfile.Types.MultiClusterRoutingUseAny(),
                SingleClusterRouting = new AppProfile.Types.SingleClusterRouting(),
            };
            mockGrpcClient.Setup(x => x.GetAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AppProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            AppProfile responseCallSettings = await client.GetAppProfileAsync(request.AppProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AppProfile responseCancellationToken = await client.GetAppProfileAsync(request.AppProfileName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAppProfileRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteAppProfile(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAppProfileRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAppProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAppProfileAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAppProfile()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteAppProfile(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAppProfileAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAppProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAppProfileAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAppProfileResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAppProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteAppProfile(request.AppProfileName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAppProfileResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAppProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAppProfileAsync(request.AppProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAppProfileAsync(request.AppProfileName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient> mockGrpcClient = new moq::Mock<BigtableInstanceAdmin.BigtableInstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableInstanceAdminClient client = new BigtableInstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
