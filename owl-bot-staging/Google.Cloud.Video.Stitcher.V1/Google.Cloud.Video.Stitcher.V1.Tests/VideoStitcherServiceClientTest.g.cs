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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Video.Stitcher.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVideoStitcherServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateCdnKeyRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "cdn_key_id64577c0e",
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.CreateCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.CreateCdnKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCdnKeyRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "cdn_key_id64577c0e",
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.CreateCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.CreateCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.CreateCdnKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCdnKey()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "cdn_key_id64577c0e",
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.CreateCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.CreateCdnKey(request.Parent, request.CdnKey, request.CdnKeyId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCdnKeyAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "cdn_key_id64577c0e",
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.CreateCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.CreateCdnKeyAsync(request.Parent, request.CdnKey, request.CdnKeyId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.CreateCdnKeyAsync(request.Parent, request.CdnKey, request.CdnKeyId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCdnKeyResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "cdn_key_id64577c0e",
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.CreateCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.CreateCdnKey(request.ParentAsLocationName, request.CdnKey, request.CdnKeyId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCdnKeyResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateCdnKeyRequest request = new CreateCdnKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CdnKey = new CdnKey(),
                CdnKeyId = "cdn_key_id64577c0e",
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.CreateCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.CreateCdnKeyAsync(request.ParentAsLocationName, request.CdnKey, request.CdnKeyId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.CreateCdnKeyAsync(request.ParentAsLocationName, request.CdnKey, request.CdnKeyId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCdnKeyRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.GetCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.GetCdnKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCdnKeyRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.GetCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.GetCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.GetCdnKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCdnKey()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.GetCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.GetCdnKey(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCdnKeyAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.GetCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.GetCdnKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.GetCdnKeyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCdnKeyResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.GetCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.GetCdnKey(request.CdnKeyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCdnKeyResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetCdnKeyRequest request = new GetCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.GetCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.GetCdnKeyAsync(request.CdnKeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.GetCdnKeyAsync(request.CdnKeyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCdnKeyRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCdnKey(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCdnKeyRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCdnKeyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCdnKey()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCdnKey(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCdnKeyAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCdnKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCdnKeyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCdnKeyResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteCdnKey(request.CdnKeyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCdnKeyResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteCdnKeyRequest request = new DeleteCdnKeyRequest
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCdnKeyAsync(request.CdnKeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCdnKeyAsync(request.CdnKeyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCdnKeyRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateCdnKeyRequest request = new UpdateCdnKeyRequest
            {
                CdnKey = new CdnKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.UpdateCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.UpdateCdnKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCdnKeyRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateCdnKeyRequest request = new UpdateCdnKeyRequest
            {
                CdnKey = new CdnKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.UpdateCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.UpdateCdnKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.UpdateCdnKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCdnKey()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateCdnKeyRequest request = new UpdateCdnKeyRequest
            {
                CdnKey = new CdnKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.UpdateCdnKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey response = client.UpdateCdnKey(request.CdnKey, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCdnKeyAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateCdnKeyRequest request = new UpdateCdnKeyRequest
            {
                CdnKey = new CdnKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CdnKey expectedResponse = new CdnKey
            {
                CdnKeyName = CdnKeyName.FromProjectLocationCdnKey("[PROJECT]", "[LOCATION]", "[CDN_KEY]"),
                Hostname = "hostnamef4ac9708",
                GoogleCdnKey = new GoogleCdnKey(),
                AkamaiCdnKey = new AkamaiCdnKey(),
            };
            mockGrpcClient.Setup(x => x.UpdateCdnKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CdnKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            CdnKey responseCallSettings = await client.UpdateCdnKeyAsync(request.CdnKey, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CdnKey responseCancellationToken = await client.UpdateCdnKeyAsync(request.CdnKey, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVodSessionRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateVodSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession response = client.CreateVodSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVodSessionRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateVodSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession responseCallSettings = await client.CreateVodSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodSession responseCancellationToken = await client.CreateVodSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVodSession()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateVodSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession response = client.CreateVodSession(request.Parent, request.VodSession);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVodSessionAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateVodSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession responseCallSettings = await client.CreateVodSessionAsync(request.Parent, request.VodSession, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodSession responseCancellationToken = await client.CreateVodSessionAsync(request.Parent, request.VodSession, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateVodSessionResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateVodSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession response = client.CreateVodSession(request.ParentAsLocationName, request.VodSession);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateVodSessionResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateVodSessionRequest request = new CreateVodSessionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VodSession = new VodSession(),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateVodSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession responseCallSettings = await client.CreateVodSessionAsync(request.ParentAsLocationName, request.VodSession, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodSession responseCancellationToken = await client.CreateVodSessionAsync(request.ParentAsLocationName, request.VodSession, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodSessionRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetVodSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession response = client.GetVodSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodSessionRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetVodSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession responseCallSettings = await client.GetVodSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodSession responseCancellationToken = await client.GetVodSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodSession()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetVodSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession response = client.GetVodSession(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodSessionAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetVodSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession responseCallSettings = await client.GetVodSessionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodSession responseCancellationToken = await client.GetVodSessionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodSessionResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetVodSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession response = client.GetVodSession(request.VodSessionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodSessionResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodSessionRequest request = new GetVodSessionRequest
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
            };
            VodSession expectedResponse = new VodSession
            {
                VodSessionName = VodSessionName.FromProjectLocationVodSession("[PROJECT]", "[LOCATION]", "[VOD_SESSION]"),
                Interstitials = new Interstitials(),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                AdTagUri = "ad_tag_uri9c67b0d8",
                AdTagMacroMap =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetVodSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodSession responseCallSettings = await client.GetVodSessionAsync(request.VodSessionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodSession responseCancellationToken = await client.GetVodSessionAsync(request.VodSessionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodStitchDetailRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            VodStitchDetail expectedResponse = new VodStitchDetail
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
                AdStitchDetails =
                {
                    new AdStitchDetail(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVodStitchDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodStitchDetail response = client.GetVodStitchDetail(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodStitchDetailRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            VodStitchDetail expectedResponse = new VodStitchDetail
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
                AdStitchDetails =
                {
                    new AdStitchDetail(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVodStitchDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodStitchDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodStitchDetail responseCallSettings = await client.GetVodStitchDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodStitchDetail responseCancellationToken = await client.GetVodStitchDetailAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodStitchDetail()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            VodStitchDetail expectedResponse = new VodStitchDetail
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
                AdStitchDetails =
                {
                    new AdStitchDetail(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVodStitchDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodStitchDetail response = client.GetVodStitchDetail(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodStitchDetailAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            VodStitchDetail expectedResponse = new VodStitchDetail
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
                AdStitchDetails =
                {
                    new AdStitchDetail(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVodStitchDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodStitchDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodStitchDetail responseCallSettings = await client.GetVodStitchDetailAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodStitchDetail responseCancellationToken = await client.GetVodStitchDetailAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodStitchDetailResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            VodStitchDetail expectedResponse = new VodStitchDetail
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
                AdStitchDetails =
                {
                    new AdStitchDetail(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVodStitchDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodStitchDetail response = client.GetVodStitchDetail(request.VodStitchDetailName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodStitchDetailResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodStitchDetailRequest request = new GetVodStitchDetailRequest
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
            };
            VodStitchDetail expectedResponse = new VodStitchDetail
            {
                VodStitchDetailName = VodStitchDetailName.FromProjectLocationVodSessionVodStitchDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_STITCH_DETAIL]"),
                AdStitchDetails =
                {
                    new AdStitchDetail(),
                },
            };
            mockGrpcClient.Setup(x => x.GetVodStitchDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodStitchDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodStitchDetail responseCallSettings = await client.GetVodStitchDetailAsync(request.VodStitchDetailName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodStitchDetail responseCancellationToken = await client.GetVodStitchDetailAsync(request.VodStitchDetailName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodAdTagDetailRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            VodAdTagDetail expectedResponse = new VodAdTagDetail
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetVodAdTagDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodAdTagDetail response = client.GetVodAdTagDetail(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodAdTagDetailRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            VodAdTagDetail expectedResponse = new VodAdTagDetail
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetVodAdTagDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodAdTagDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodAdTagDetail responseCallSettings = await client.GetVodAdTagDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodAdTagDetail responseCancellationToken = await client.GetVodAdTagDetailAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodAdTagDetail()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            VodAdTagDetail expectedResponse = new VodAdTagDetail
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetVodAdTagDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodAdTagDetail response = client.GetVodAdTagDetail(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodAdTagDetailAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            VodAdTagDetail expectedResponse = new VodAdTagDetail
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetVodAdTagDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodAdTagDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodAdTagDetail responseCallSettings = await client.GetVodAdTagDetailAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodAdTagDetail responseCancellationToken = await client.GetVodAdTagDetailAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVodAdTagDetailResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            VodAdTagDetail expectedResponse = new VodAdTagDetail
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetVodAdTagDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodAdTagDetail response = client.GetVodAdTagDetail(request.VodAdTagDetailName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVodAdTagDetailResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetVodAdTagDetailRequest request = new GetVodAdTagDetailRequest
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
            };
            VodAdTagDetail expectedResponse = new VodAdTagDetail
            {
                VodAdTagDetailName = VodAdTagDetailName.FromProjectLocationVodSessionVodAdTagDetail("[PROJECT]", "[LOCATION]", "[VOD_SESSION]", "[VOD_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetVodAdTagDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VodAdTagDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            VodAdTagDetail responseCallSettings = await client.GetVodAdTagDetailAsync(request.VodAdTagDetailName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VodAdTagDetail responseCancellationToken = await client.GetVodAdTagDetailAsync(request.VodAdTagDetailName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLiveAdTagDetailRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            LiveAdTagDetail expectedResponse = new LiveAdTagDetail
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetLiveAdTagDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveAdTagDetail response = client.GetLiveAdTagDetail(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLiveAdTagDetailRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            LiveAdTagDetail expectedResponse = new LiveAdTagDetail
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetLiveAdTagDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveAdTagDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveAdTagDetail responseCallSettings = await client.GetLiveAdTagDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveAdTagDetail responseCancellationToken = await client.GetLiveAdTagDetailAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLiveAdTagDetail()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            LiveAdTagDetail expectedResponse = new LiveAdTagDetail
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetLiveAdTagDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveAdTagDetail response = client.GetLiveAdTagDetail(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLiveAdTagDetailAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            LiveAdTagDetail expectedResponse = new LiveAdTagDetail
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetLiveAdTagDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveAdTagDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveAdTagDetail responseCallSettings = await client.GetLiveAdTagDetailAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveAdTagDetail responseCancellationToken = await client.GetLiveAdTagDetailAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLiveAdTagDetailResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            LiveAdTagDetail expectedResponse = new LiveAdTagDetail
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetLiveAdTagDetail(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveAdTagDetail response = client.GetLiveAdTagDetail(request.LiveAdTagDetailName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLiveAdTagDetailResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveAdTagDetailRequest request = new GetLiveAdTagDetailRequest
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
            };
            LiveAdTagDetail expectedResponse = new LiveAdTagDetail
            {
                LiveAdTagDetailName = LiveAdTagDetailName.FromProjectLocationLiveSessionLiveAdTagDetail("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]", "[LIVE_AD_TAG_DETAIL]"),
                AdRequests = { new AdRequest(), },
            };
            mockGrpcClient.Setup(x => x.GetLiveAdTagDetailAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveAdTagDetail>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveAdTagDetail responseCallSettings = await client.GetLiveAdTagDetailAsync(request.LiveAdTagDetailName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveAdTagDetail responseCancellationToken = await client.GetLiveAdTagDetailAsync(request.LiveAdTagDetailName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSlateRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "slate_id0e8a1ffb",
                Slate = new Slate(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.CreateSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.CreateSlate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSlateRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "slate_id0e8a1ffb",
                Slate = new Slate(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.CreateSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.CreateSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.CreateSlateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSlate()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "slate_id0e8a1ffb",
                Slate = new Slate(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.CreateSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.CreateSlate(request.Parent, request.Slate, request.SlateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSlateAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "slate_id0e8a1ffb",
                Slate = new Slate(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.CreateSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.CreateSlateAsync(request.Parent, request.Slate, request.SlateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.CreateSlateAsync(request.Parent, request.Slate, request.SlateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSlateResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "slate_id0e8a1ffb",
                Slate = new Slate(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.CreateSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.CreateSlate(request.ParentAsLocationName, request.Slate, request.SlateId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSlateResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateSlateRequest request = new CreateSlateRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SlateId = "slate_id0e8a1ffb",
                Slate = new Slate(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.CreateSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.CreateSlateAsync(request.ParentAsLocationName, request.Slate, request.SlateId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.CreateSlateAsync(request.ParentAsLocationName, request.Slate, request.SlateId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSlateRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.GetSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.GetSlate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSlateRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.GetSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.GetSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.GetSlateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSlate()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.GetSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.GetSlate(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSlateAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.GetSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.GetSlateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.GetSlateAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSlateResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.GetSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.GetSlate(request.SlateName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSlateResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetSlateRequest request = new GetSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.GetSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.GetSlateAsync(request.SlateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.GetSlateAsync(request.SlateName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSlateRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.UpdateSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.UpdateSlate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSlateRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.UpdateSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.UpdateSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.UpdateSlateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSlate()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.UpdateSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate response = client.UpdateSlate(request.Slate, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSlateAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            UpdateSlateRequest request = new UpdateSlateRequest
            {
                Slate = new Slate(),
                UpdateMask = new wkt::FieldMask(),
            };
            Slate expectedResponse = new Slate
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
                Uri = "uri3db70593",
            };
            mockGrpcClient.Setup(x => x.UpdateSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Slate>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            Slate responseCallSettings = await client.UpdateSlateAsync(request.Slate, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Slate responseCancellationToken = await client.UpdateSlateAsync(request.Slate, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSlateRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSlate(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSlateRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSlateAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSlate()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSlate(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSlateAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSlateAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSlateAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSlateResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSlate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSlate(request.SlateName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSlateResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            DeleteSlateRequest request = new DeleteSlateRequest
            {
                SlateName = SlateName.FromProjectLocationSlate("[PROJECT]", "[LOCATION]", "[SLATE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSlateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSlateAsync(request.SlateName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSlateAsync(request.SlateName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateLiveSessionRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateLiveSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession response = client.CreateLiveSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateLiveSessionRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateLiveSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession responseCallSettings = await client.CreateLiveSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveSession responseCancellationToken = await client.CreateLiveSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateLiveSession()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateLiveSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession response = client.CreateLiveSession(request.Parent, request.LiveSession);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateLiveSessionAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateLiveSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession responseCallSettings = await client.CreateLiveSessionAsync(request.Parent, request.LiveSession, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveSession responseCancellationToken = await client.CreateLiveSessionAsync(request.Parent, request.LiveSession, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateLiveSessionResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateLiveSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession response = client.CreateLiveSession(request.ParentAsLiveSessionName, request.LiveSession);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateLiveSessionResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            CreateLiveSessionRequest request = new CreateLiveSessionRequest
            {
                ParentAsLiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                LiveSession = new LiveSession(),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateLiveSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession responseCallSettings = await client.CreateLiveSessionAsync(request.ParentAsLiveSessionName, request.LiveSession, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveSession responseCancellationToken = await client.CreateLiveSessionAsync(request.ParentAsLiveSessionName, request.LiveSession, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLiveSessionRequestObject()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetLiveSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession response = client.GetLiveSession(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLiveSessionRequestObjectAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetLiveSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession responseCallSettings = await client.GetLiveSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveSession responseCancellationToken = await client.GetLiveSessionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLiveSession()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetLiveSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession response = client.GetLiveSession(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLiveSessionAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetLiveSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession responseCallSettings = await client.GetLiveSessionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveSession responseCancellationToken = await client.GetLiveSessionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLiveSessionResourceNames()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetLiveSession(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession response = client.GetLiveSession(request.LiveSessionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLiveSessionResourceNamesAsync()
        {
            moq::Mock<VideoStitcherService.VideoStitcherServiceClient> mockGrpcClient = new moq::Mock<VideoStitcherService.VideoStitcherServiceClient>(moq::MockBehavior.Strict);
            GetLiveSessionRequest request = new GetLiveSessionRequest
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
            };
            LiveSession expectedResponse = new LiveSession
            {
                LiveSessionName = LiveSessionName.FromProjectLocationLiveSession("[PROJECT]", "[LOCATION]", "[LIVE_SESSION]"),
                PlayUri = "play_uri93a9f8f5",
                SourceUri = "source_uri0c257c61",
                DefaultAdTagId = "default_ad_tag_idf972fb49",
                AdTagMap =
                {
                    {
                        "key8a0b6e3c",
                        new AdTag()
                    },
                },
                AdTagMacros =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientAdTracking = false,
                DefaultSlateId = "default_slate_id07c41bba",
                StitchingPolicy = LiveSession.Types.StitchingPolicy.Unspecified,
                ManifestOptions = new ManifestOptions(),
            };
            mockGrpcClient.Setup(x => x.GetLiveSessionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LiveSession>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoStitcherServiceClient client = new VideoStitcherServiceClientImpl(mockGrpcClient.Object, null);
            LiveSession responseCallSettings = await client.GetLiveSessionAsync(request.LiveSessionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LiveSession responseCancellationToken = await client.GetLiveSessionAsync(request.LiveSessionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
