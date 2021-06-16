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
    public sealed class GeneratedUrlMapsClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            UrlMapsAggregatedList expectedResponse = new UrlMapsAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new UrlMapsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            UrlMapsAggregatedList expectedResponse = new UrlMapsAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new UrlMapsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapsAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapsAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
            {
                Project = "projectaa6ff846",
            };
            UrlMapsAggregatedList expectedResponse = new UrlMapsAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new UrlMapsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
            {
                Project = "projectaa6ff846",
            };
            UrlMapsAggregatedList expectedResponse = new UrlMapsAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new UrlMapsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapsAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapsAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.UrlMap);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.UrlMap, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.UrlMap, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMap responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap response = client.Get(request.Project, request.UrlMap);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            UrlMap expectedResponse = new UrlMap
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tests = { new UrlMapTest(), },
                Region = "regionedb20d96",
                Fingerprint = "fingerprint009e6052",
                PathMatchers = { new PathMatcher(), },
                HostRules = { new HostRule(), },
                HeaderAction = new HttpHeaderAction(),
                DefaultUrlRedirect = new HttpRedirectAction(),
                DefaultService = "default_serviceb867731a",
                DefaultRouteAction = new HttpRouteAction(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMap>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMap responseCallSettings = await client.GetAsync(request.Project, request.UrlMap, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMap responseCancellationToken = await client.GetAsync(request.Project, request.UrlMap, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.UrlMapResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.UrlMapResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.UrlMapResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InvalidateCacheRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InvalidateCache(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.InvalidateCache(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InvalidateCacheRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InvalidateCacheAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InvalidateCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InvalidateCacheAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InvalidateCache()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                Project = "projectaa6ff846",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InvalidateCache(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.InvalidateCache(request.Project, request.UrlMap, request.CacheInvalidationRuleResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InvalidateCacheAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                Project = "projectaa6ff846",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InvalidateCacheAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InvalidateCacheAsync(request.Project, request.UrlMap, request.CacheInvalidationRuleResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InvalidateCacheAsync(request.Project, request.UrlMap, request.CacheInvalidationRuleResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            UrlMapList expectedResponse = new UrlMapList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new UrlMap(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            UrlMapList expectedResponse = new UrlMapList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new UrlMap(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                Project = "projectaa6ff846",
            };
            UrlMapList expectedResponse = new UrlMapList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new UrlMap(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                Project = "projectaa6ff846",
            };
            UrlMapList expectedResponse = new UrlMapList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new UrlMap(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.UrlMap, request.UrlMapResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.UrlMap, request.UrlMapResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.UrlMap, request.UrlMapResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                RequestId = "request_id362c8df6",
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Update()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request.Project, request.UrlMap, request.UrlMapResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                UrlMapResource = new UrlMap(),
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request.Project, request.UrlMap, request.UrlMapResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request.Project, request.UrlMap, request.UrlMapResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateRequestObject()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.Validate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse response = client.Validate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateRequestObjectAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.ValidateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapsValidateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse responseCallSettings = await client.ValidateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapsValidateResponse responseCancellationToken = await client.ValidateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Validate()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.Validate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse response = client.Validate(request.Project, request.UrlMap, request.UrlMapsValidateRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateAsync()
        {
            moq::Mock<UrlMaps.UrlMapsClient> mockGrpcClient = new moq::Mock<UrlMaps.UrlMapsClient>(moq::MockBehavior.Strict);
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "projectaa6ff846",
                UrlMap = "url_map3ccdbf57",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            UrlMapsValidateResponse expectedResponse = new UrlMapsValidateResponse
            {
                Result = new UrlMapValidationResult(),
            };
            mockGrpcClient.Setup(x => x.ValidateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UrlMapsValidateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UrlMapsClient client = new UrlMapsClientImpl(mockGrpcClient.Object, null);
            UrlMapsValidateResponse responseCallSettings = await client.ValidateAsync(request.Project, request.UrlMap, request.UrlMapsValidateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UrlMapsValidateResponse responseCancellationToken = await client.ValidateAsync(request.Project, request.UrlMap, request.UrlMapsValidateRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
