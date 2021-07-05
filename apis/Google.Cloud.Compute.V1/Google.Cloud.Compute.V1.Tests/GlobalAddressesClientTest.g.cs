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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGlobalAddressesClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Address);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            DeleteGlobalAddressRequest request = new DeleteGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Address, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Address, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Address>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Address responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address response = client.Get(request.Project, request.Address);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Address>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address responseCallSettings = await client.GetAsync(request.Project, request.Address, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Address responseCancellationToken = await client.GetAsync(request.Project, request.Address, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                AddressResource = new Address(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                AddressResource = new Address(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                AddressResource = new Address(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.AddressResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            InsertGlobalAddressRequest request = new InsertGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                AddressResource = new Address(),
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.AddressResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.AddressResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            AddressList expectedResponse = new AddressList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Address(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            AddressList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            AddressList expectedResponse = new AddressList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Address(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddressList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            AddressList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddressList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                Project = "projectaa6ff846",
            };
            AddressList expectedResponse = new AddressList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Address(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            AddressList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            ListGlobalAddressesRequest request = new ListGlobalAddressesRequest
            {
                Project = "projectaa6ff846",
            };
            AddressList expectedResponse = new AddressList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Address(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddressList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            AddressList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AddressList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
