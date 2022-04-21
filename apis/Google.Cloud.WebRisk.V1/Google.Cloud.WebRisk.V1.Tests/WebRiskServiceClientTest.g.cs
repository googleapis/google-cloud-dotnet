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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.WebRisk.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedWebRiskServiceClientTest
    {
        [xunit::FactAttribute]
        public void ComputeThreatListDiffRequestObject()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Malware,
                VersionToken = proto::ByteString.CopyFromUtf8("version_token1850f275"),
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                RecommendedNextDiff = new wkt::Timestamp(),
                ResponseType = ComputeThreatListDiffResponse.Types.ResponseType.Diff,
                Additions = new ThreatEntryAdditions(),
                Removals = new ThreatEntryRemovals(),
                NewVersionToken = proto::ByteString.CopyFromUtf8("new_version_tokenc8bdd85d"),
                Checksum = new ComputeThreatListDiffResponse.Types.Checksum(),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiff(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            ComputeThreatListDiffResponse response = client.ComputeThreatListDiff(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ComputeThreatListDiffRequestObjectAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Malware,
                VersionToken = proto::ByteString.CopyFromUtf8("version_token1850f275"),
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                RecommendedNextDiff = new wkt::Timestamp(),
                ResponseType = ComputeThreatListDiffResponse.Types.ResponseType.Diff,
                Additions = new ThreatEntryAdditions(),
                Removals = new ThreatEntryRemovals(),
                NewVersionToken = proto::ByteString.CopyFromUtf8("new_version_tokenc8bdd85d"),
                Checksum = new ComputeThreatListDiffResponse.Types.Checksum(),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiffAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComputeThreatListDiffResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            ComputeThreatListDiffResponse responseCallSettings = await client.ComputeThreatListDiffAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComputeThreatListDiffResponse responseCancellationToken = await client.ComputeThreatListDiffAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ComputeThreatListDiff()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Malware,
                VersionToken = proto::ByteString.CopyFromUtf8("version_token1850f275"),
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                RecommendedNextDiff = new wkt::Timestamp(),
                ResponseType = ComputeThreatListDiffResponse.Types.ResponseType.Diff,
                Additions = new ThreatEntryAdditions(),
                Removals = new ThreatEntryRemovals(),
                NewVersionToken = proto::ByteString.CopyFromUtf8("new_version_tokenc8bdd85d"),
                Checksum = new ComputeThreatListDiffResponse.Types.Checksum(),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiff(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            ComputeThreatListDiffResponse response = client.ComputeThreatListDiff(request.ThreatType, request.VersionToken, request.Constraints);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ComputeThreatListDiffAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Malware,
                VersionToken = proto::ByteString.CopyFromUtf8("version_token1850f275"),
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                RecommendedNextDiff = new wkt::Timestamp(),
                ResponseType = ComputeThreatListDiffResponse.Types.ResponseType.Diff,
                Additions = new ThreatEntryAdditions(),
                Removals = new ThreatEntryRemovals(),
                NewVersionToken = proto::ByteString.CopyFromUtf8("new_version_tokenc8bdd85d"),
                Checksum = new ComputeThreatListDiffResponse.Types.Checksum(),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiffAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComputeThreatListDiffResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            ComputeThreatListDiffResponse responseCallSettings = await client.ComputeThreatListDiffAsync(request.ThreatType, request.VersionToken, request.Constraints, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComputeThreatListDiffResponse responseCancellationToken = await client.ComputeThreatListDiffAsync(request.ThreatType, request.VersionToken, request.Constraints, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchUrisRequestObject()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "uri3db70593",
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse
            {
                Threat = new SearchUrisResponse.Types.ThreatUri(),
            };
            mockGrpcClient.Setup(x => x.SearchUris(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchUrisResponse response = client.SearchUris(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchUrisRequestObjectAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "uri3db70593",
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse
            {
                Threat = new SearchUrisResponse.Types.ThreatUri(),
            };
            mockGrpcClient.Setup(x => x.SearchUrisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchUrisResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchUrisResponse responseCallSettings = await client.SearchUrisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchUrisResponse responseCancellationToken = await client.SearchUrisAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchUris()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "uri3db70593",
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse
            {
                Threat = new SearchUrisResponse.Types.ThreatUri(),
            };
            mockGrpcClient.Setup(x => x.SearchUris(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchUrisResponse response = client.SearchUris(request.Uri, request.ThreatTypes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchUrisAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "uri3db70593",
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse
            {
                Threat = new SearchUrisResponse.Types.ThreatUri(),
            };
            mockGrpcClient.Setup(x => x.SearchUrisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchUrisResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchUrisResponse responseCallSettings = await client.SearchUrisAsync(request.Uri, request.ThreatTypes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchUrisResponse responseCancellationToken = await client.SearchUrisAsync(request.Uri, request.ThreatTypes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchHashesRequestObject()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchHashesRequest request = new SearchHashesRequest
            {
                HashPrefix = proto::ByteString.CopyFromUtf8("hash_prefix0c2a6688"),
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse
            {
                Threats =
                {
                    new SearchHashesResponse.Types.ThreatHash(),
                },
                NegativeExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.SearchHashes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchHashesResponse response = client.SearchHashes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchHashesRequestObjectAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchHashesRequest request = new SearchHashesRequest
            {
                HashPrefix = proto::ByteString.CopyFromUtf8("hash_prefix0c2a6688"),
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse
            {
                Threats =
                {
                    new SearchHashesResponse.Types.ThreatHash(),
                },
                NegativeExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.SearchHashesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchHashesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchHashesResponse responseCallSettings = await client.SearchHashesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchHashesResponse responseCancellationToken = await client.SearchHashesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchHashes()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchHashesRequest request = new SearchHashesRequest
            {
                HashPrefix = proto::ByteString.CopyFromUtf8("hash_prefix0c2a6688"),
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse
            {
                Threats =
                {
                    new SearchHashesResponse.Types.ThreatHash(),
                },
                NegativeExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.SearchHashes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchHashesResponse response = client.SearchHashes(request.HashPrefix, request.ThreatTypes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchHashesAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            SearchHashesRequest request = new SearchHashesRequest
            {
                HashPrefix = proto::ByteString.CopyFromUtf8("hash_prefix0c2a6688"),
                ThreatTypes =
                {
                    ThreatType.SocialEngineering,
                },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse
            {
                Threats =
                {
                    new SearchHashesResponse.Types.ThreatHash(),
                },
                NegativeExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.SearchHashesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchHashesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            SearchHashesResponse responseCallSettings = await client.SearchHashesAsync(request.HashPrefix, request.ThreatTypes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchHashesResponse responseCancellationToken = await client.SearchHashesAsync(request.HashPrefix, request.ThreatTypes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubmissionRequestObject()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            Submission expectedResponse = new Submission { Uri = "uri3db70593", };
            mockGrpcClient.Setup(x => x.CreateSubmission(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            Submission response = client.CreateSubmission(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubmissionRequestObjectAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            Submission expectedResponse = new Submission { Uri = "uri3db70593", };
            mockGrpcClient.Setup(x => x.CreateSubmissionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Submission>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            Submission responseCallSettings = await client.CreateSubmissionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Submission responseCancellationToken = await client.CreateSubmissionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubmission()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            Submission expectedResponse = new Submission { Uri = "uri3db70593", };
            mockGrpcClient.Setup(x => x.CreateSubmission(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            Submission response = client.CreateSubmission(request.Parent, request.Submission);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubmissionAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            Submission expectedResponse = new Submission { Uri = "uri3db70593", };
            mockGrpcClient.Setup(x => x.CreateSubmissionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Submission>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            Submission responseCallSettings = await client.CreateSubmissionAsync(request.Parent, request.Submission, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Submission responseCancellationToken = await client.CreateSubmissionAsync(request.Parent, request.Submission, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSubmissionResourceNames()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            Submission expectedResponse = new Submission { Uri = "uri3db70593", };
            mockGrpcClient.Setup(x => x.CreateSubmission(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            Submission response = client.CreateSubmission(request.ParentAsProjectName, request.Submission);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSubmissionResourceNamesAsync()
        {
            moq::Mock<WebRiskService.WebRiskServiceClient> mockGrpcClient = new moq::Mock<WebRiskService.WebRiskServiceClient>(moq::MockBehavior.Strict);
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            Submission expectedResponse = new Submission { Uri = "uri3db70593", };
            mockGrpcClient.Setup(x => x.CreateSubmissionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Submission>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceClient client = new WebRiskServiceClientImpl(mockGrpcClient.Object, null, null);
            Submission responseCallSettings = await client.CreateSubmissionAsync(request.ParentAsProjectName, request.Submission, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Submission responseCancellationToken = await client.CreateSubmissionAsync(request.ParentAsProjectName, request.Submission, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
