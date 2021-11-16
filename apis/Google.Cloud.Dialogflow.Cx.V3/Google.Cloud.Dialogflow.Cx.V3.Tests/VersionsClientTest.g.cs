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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVersionsClientTest
    {
        [xunit::FactAttribute]
        public void GetVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version response = client.GetVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version response = client.GetVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.GetVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVersionResourceNames()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.GetVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version response = client.GetVersion(request.VersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVersionResourceNamesAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVersionRequest request = new GetVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.GetVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.GetVersionAsync(request.VersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.GetVersionAsync(request.VersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.UpdateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version response = client.UpdateVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.UpdateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.UpdateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.UpdateVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.UpdateVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version response = client.UpdateVersion(request.Version, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Version = new Version(),
                UpdateMask = new wkt::FieldMask(),
            };
            Version expectedResponse = new Version
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                NluSettings = new NluSettings(),
                CreateTime = new wkt::Timestamp(),
                State = Version.Types.State.Succeeded,
            };
            mockGrpcClient.Setup(x => x.UpdateVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Version>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            Version responseCallSettings = await client.UpdateVersionAsync(request.Version, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Version responseCancellationToken = await client.UpdateVersionAsync(request.Version, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVersionRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            client.DeleteVersion(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVersionRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVersionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVersion()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            client.DeleteVersion(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVersionAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVersionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteVersionResourceNames()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            client.DeleteVersion(request.VersionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteVersionResourceNamesAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteVersionRequest request = new DeleteVersionRequest
            {
                VersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteVersionAsync(request.VersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteVersionAsync(request.VersionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompareVersionsRequestObject()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompareVersionsRequest request = new CompareVersionsRequest
            {
                BaseVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                TargetVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                LanguageCode = "language_code2f6c7160",
            };
            CompareVersionsResponse expectedResponse = new CompareVersionsResponse
            {
                BaseVersionContentJson = "base_version_content_json6279f098",
                TargetVersionContentJson = "target_version_content_jsonf76c0cf2",
                CompareTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CompareVersions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            CompareVersionsResponse response = client.CompareVersions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompareVersionsRequestObjectAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompareVersionsRequest request = new CompareVersionsRequest
            {
                BaseVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                TargetVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
                LanguageCode = "language_code2f6c7160",
            };
            CompareVersionsResponse expectedResponse = new CompareVersionsResponse
            {
                BaseVersionContentJson = "base_version_content_json6279f098",
                TargetVersionContentJson = "target_version_content_jsonf76c0cf2",
                CompareTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CompareVersionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompareVersionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            CompareVersionsResponse responseCallSettings = await client.CompareVersionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompareVersionsResponse responseCancellationToken = await client.CompareVersionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompareVersions()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompareVersionsRequest request = new CompareVersionsRequest
            {
                BaseVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            CompareVersionsResponse expectedResponse = new CompareVersionsResponse
            {
                BaseVersionContentJson = "base_version_content_json6279f098",
                TargetVersionContentJson = "target_version_content_jsonf76c0cf2",
                CompareTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CompareVersions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            CompareVersionsResponse response = client.CompareVersions(request.BaseVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompareVersionsAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompareVersionsRequest request = new CompareVersionsRequest
            {
                BaseVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            CompareVersionsResponse expectedResponse = new CompareVersionsResponse
            {
                BaseVersionContentJson = "base_version_content_json6279f098",
                TargetVersionContentJson = "target_version_content_jsonf76c0cf2",
                CompareTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CompareVersionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompareVersionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            CompareVersionsResponse responseCallSettings = await client.CompareVersionsAsync(request.BaseVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompareVersionsResponse responseCancellationToken = await client.CompareVersionsAsync(request.BaseVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompareVersionsResourceNames()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompareVersionsRequest request = new CompareVersionsRequest
            {
                BaseVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            CompareVersionsResponse expectedResponse = new CompareVersionsResponse
            {
                BaseVersionContentJson = "base_version_content_json6279f098",
                TargetVersionContentJson = "target_version_content_jsonf76c0cf2",
                CompareTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CompareVersions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            CompareVersionsResponse response = client.CompareVersions(request.BaseVersionAsVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompareVersionsResourceNamesAsync()
        {
            moq::Mock<Versions.VersionsClient> mockGrpcClient = new moq::Mock<Versions.VersionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompareVersionsRequest request = new CompareVersionsRequest
            {
                BaseVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            CompareVersionsResponse expectedResponse = new CompareVersionsResponse
            {
                BaseVersionContentJson = "base_version_content_json6279f098",
                TargetVersionContentJson = "target_version_content_jsonf76c0cf2",
                CompareTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CompareVersionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CompareVersionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VersionsClient client = new VersionsClientImpl(mockGrpcClient.Object, null);
            CompareVersionsResponse responseCallSettings = await client.CompareVersionsAsync(request.BaseVersionAsVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CompareVersionsResponse responseCancellationToken = await client.CompareVersionsAsync(request.BaseVersionAsVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
