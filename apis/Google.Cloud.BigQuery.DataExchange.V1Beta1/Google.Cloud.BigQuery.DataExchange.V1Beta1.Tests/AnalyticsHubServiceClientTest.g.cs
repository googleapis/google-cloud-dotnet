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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gcbdc = Google.Cloud.BigQuery.DataExchange.Common;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.DataExchange.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAnalyticsHubServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetDataExchangeRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.GetDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.GetDataExchange(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataExchangeRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.GetDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.GetDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.GetDataExchangeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataExchange()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.GetDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.GetDataExchange(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataExchangeAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.GetDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.GetDataExchangeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.GetDataExchangeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataExchangeResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.GetDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.GetDataExchange(request.DataExchangeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataExchangeResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetDataExchangeRequest request = new GetDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.GetDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.GetDataExchangeAsync(request.DataExchangeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.GetDataExchangeAsync(request.DataExchangeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataExchangeRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchangeId = "data_exchange_id94483fe4",
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.CreateDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.CreateDataExchange(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataExchangeRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchangeId = "data_exchange_id94483fe4",
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.CreateDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.CreateDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.CreateDataExchangeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataExchange()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.CreateDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.CreateDataExchange(request.Parent, request.DataExchange);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataExchangeAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.CreateDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.CreateDataExchangeAsync(request.Parent, request.DataExchange, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.CreateDataExchangeAsync(request.Parent, request.DataExchange, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataExchangeResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.CreateDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.CreateDataExchange(request.ParentAsLocationName, request.DataExchange);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataExchangeResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateDataExchangeRequest request = new CreateDataExchangeRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.CreateDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.CreateDataExchangeAsync(request.ParentAsLocationName, request.DataExchange, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.CreateDataExchangeAsync(request.ParentAsLocationName, request.DataExchange, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataExchangeRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateDataExchangeRequest request = new UpdateDataExchangeRequest
            {
                UpdateMask = new wkt::FieldMask(),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.UpdateDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.UpdateDataExchange(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataExchangeRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateDataExchangeRequest request = new UpdateDataExchangeRequest
            {
                UpdateMask = new wkt::FieldMask(),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.UpdateDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.UpdateDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.UpdateDataExchangeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataExchange()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateDataExchangeRequest request = new UpdateDataExchangeRequest
            {
                UpdateMask = new wkt::FieldMask(),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.UpdateDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange response = client.UpdateDataExchange(request.DataExchange, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataExchangeAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateDataExchangeRequest request = new UpdateDataExchangeRequest
            {
                UpdateMask = new wkt::FieldMask(),
                DataExchange = new DataExchange(),
            };
            DataExchange expectedResponse = new DataExchange
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                ListingCount = -1209513524,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
            };
            mockGrpcClient.Setup(x => x.UpdateDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataExchange>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            DataExchange responseCallSettings = await client.UpdateDataExchangeAsync(request.DataExchange, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataExchange responseCancellationToken = await client.UpdateDataExchangeAsync(request.DataExchange, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataExchangeRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataExchange(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataExchangeRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataExchangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataExchangeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataExchange()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataExchange(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataExchangeAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataExchangeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataExchangeAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataExchangeResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataExchange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataExchange(request.DataExchangeName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataExchangeResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteDataExchangeRequest request = new DeleteDataExchangeRequest
            {
                DataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataExchangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataExchangeAsync(request.DataExchangeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataExchangeAsync(request.DataExchangeName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetListingRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.GetListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.GetListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetListingRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.GetListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.GetListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.GetListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetListing()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.GetListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.GetListing(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetListingAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.GetListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.GetListingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.GetListingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetListingResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.GetListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.GetListing(request.ListingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetListingResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            GetListingRequest request = new GetListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.GetListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.GetListingAsync(request.ListingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.GetListingAsync(request.ListingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateListingRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                ListingId = "listing_id6cdbaca5",
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.CreateListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.CreateListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateListingRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                ListingId = "listing_id6cdbaca5",
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.CreateListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.CreateListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.CreateListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateListing()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.CreateListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.CreateListing(request.Parent, request.Listing);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateListingAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.CreateListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.CreateListingAsync(request.Parent, request.Listing, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.CreateListingAsync(request.Parent, request.Listing, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateListingResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.CreateListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.CreateListing(request.ParentAsDataExchangeName, request.Listing);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateListingResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            CreateListingRequest request = new CreateListingRequest
            {
                ParentAsDataExchangeName = DataExchangeName.FromProjectLocationDataExchange("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]"),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.CreateListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.CreateListingAsync(request.ParentAsDataExchangeName, request.Listing, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.CreateListingAsync(request.ParentAsDataExchangeName, request.Listing, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateListingRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateListingRequest request = new UpdateListingRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.UpdateListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.UpdateListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateListingRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateListingRequest request = new UpdateListingRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.UpdateListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.UpdateListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.UpdateListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateListing()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateListingRequest request = new UpdateListingRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.UpdateListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing response = client.UpdateListing(request.Listing, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateListingAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            UpdateListingRequest request = new UpdateListingRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Listing = new Listing(),
            };
            Listing expectedResponse = new Listing
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PrimaryContact = "primary_contact87707d5a",
                Documentation = "documentation28628755",
                BigqueryDataset = new Listing.Types.BigQueryDatasetSource(),
                State = Listing.Types.State.Unspecified,
                Icon = proto::ByteString.CopyFromUtf8("icon6164ecba"),
                DataProvider = new DataProvider(),
                Categories =
                {
                    gcbdc::Category.Unspecified,
                },
                Publisher = new Publisher(),
                RequestAccess = "request_accessb08507d9",
            };
            mockGrpcClient.Setup(x => x.UpdateListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Listing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            Listing responseCallSettings = await client.UpdateListingAsync(request.Listing, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Listing responseCancellationToken = await client.UpdateListingAsync(request.Listing, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteListingRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteListing(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteListingRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteListingAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteListing()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteListing(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteListingAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteListingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteListingAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteListingResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteListing(request.ListingName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteListingResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            DeleteListingRequest request = new DeleteListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteListingAsync(request.ListingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteListingAsync(request.ListingName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SubscribeListingRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DestinationDataset = new DestinationDataset(),
            };
            SubscribeListingResponse expectedResponse = new SubscribeListingResponse { };
            mockGrpcClient.Setup(x => x.SubscribeListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            SubscribeListingResponse response = client.SubscribeListing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SubscribeListingRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
                DestinationDataset = new DestinationDataset(),
            };
            SubscribeListingResponse expectedResponse = new SubscribeListingResponse { };
            mockGrpcClient.Setup(x => x.SubscribeListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubscribeListingResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            SubscribeListingResponse responseCallSettings = await client.SubscribeListingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubscribeListingResponse responseCancellationToken = await client.SubscribeListingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SubscribeListing()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            SubscribeListingResponse expectedResponse = new SubscribeListingResponse { };
            mockGrpcClient.Setup(x => x.SubscribeListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            SubscribeListingResponse response = client.SubscribeListing(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SubscribeListingAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            SubscribeListingResponse expectedResponse = new SubscribeListingResponse { };
            mockGrpcClient.Setup(x => x.SubscribeListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubscribeListingResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            SubscribeListingResponse responseCallSettings = await client.SubscribeListingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubscribeListingResponse responseCancellationToken = await client.SubscribeListingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SubscribeListingResourceNames()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            SubscribeListingResponse expectedResponse = new SubscribeListingResponse { };
            mockGrpcClient.Setup(x => x.SubscribeListing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            SubscribeListingResponse response = client.SubscribeListing(request.ListingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SubscribeListingResourceNamesAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            SubscribeListingRequest request = new SubscribeListingRequest
            {
                ListingName = ListingName.FromProjectLocationDataExchangeListing("[PROJECT]", "[LOCATION]", "[DATA_EXCHANGE]", "[LISTING]"),
            };
            SubscribeListingResponse expectedResponse = new SubscribeListingResponse { };
            mockGrpcClient.Setup(x => x.SubscribeListingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SubscribeListingResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            SubscribeListingResponse responseCallSettings = await client.SubscribeListingAsync(request.ListingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SubscribeListingResponse responseCancellationToken = await client.SubscribeListingAsync(request.ListingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
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
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
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
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
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
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient> mockGrpcClient = new moq::Mock<AnalyticsHubService.AnalyticsHubServiceClient>(moq::MockBehavior.Strict);
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
            AnalyticsHubServiceClient client = new AnalyticsHubServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
