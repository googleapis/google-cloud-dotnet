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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Profiler.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedProfilerServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateProfileRequestObject()
        {
            moq::Mock<ProfilerService.ProfilerServiceClient> mockGrpcClient = new moq::Mock<ProfilerService.ProfilerServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                Deployment = new Deployment(),
                ProfileType =
                {
                    ProfileType.Contention,
                },
                Parent = "parent7858e4d0",
            };
            Profile expectedResponse = new Profile
            {
                Name = "name1c9368b0",
                ProfileType = ProfileType.Contention,
                Deployment = new Deployment(),
                Duration = new wkt::Duration(),
                ProfileBytes = proto::ByteString.CopyFromUtf8("profile_bytes12d9894a"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfilerServiceClient client = new ProfilerServiceClientImpl(mockGrpcClient.Object, null, null);
            Profile response = client.CreateProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateProfileRequestObjectAsync()
        {
            moq::Mock<ProfilerService.ProfilerServiceClient> mockGrpcClient = new moq::Mock<ProfilerService.ProfilerServiceClient>(moq::MockBehavior.Strict);
            CreateProfileRequest request = new CreateProfileRequest
            {
                Deployment = new Deployment(),
                ProfileType =
                {
                    ProfileType.Contention,
                },
                Parent = "parent7858e4d0",
            };
            Profile expectedResponse = new Profile
            {
                Name = "name1c9368b0",
                ProfileType = ProfileType.Contention,
                Deployment = new Deployment(),
                Duration = new wkt::Duration(),
                ProfileBytes = proto::ByteString.CopyFromUtf8("profile_bytes12d9894a"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfilerServiceClient client = new ProfilerServiceClientImpl(mockGrpcClient.Object, null, null);
            Profile responseCallSettings = await client.CreateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.CreateProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateOfflineProfileRequestObject()
        {
            moq::Mock<ProfilerService.ProfilerServiceClient> mockGrpcClient = new moq::Mock<ProfilerService.ProfilerServiceClient>(moq::MockBehavior.Strict);
            CreateOfflineProfileRequest request = new CreateOfflineProfileRequest
            {
                Parent = "parent7858e4d0",
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                Name = "name1c9368b0",
                ProfileType = ProfileType.Contention,
                Deployment = new Deployment(),
                Duration = new wkt::Duration(),
                ProfileBytes = proto::ByteString.CopyFromUtf8("profile_bytes12d9894a"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateOfflineProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfilerServiceClient client = new ProfilerServiceClientImpl(mockGrpcClient.Object, null, null);
            Profile response = client.CreateOfflineProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateOfflineProfileRequestObjectAsync()
        {
            moq::Mock<ProfilerService.ProfilerServiceClient> mockGrpcClient = new moq::Mock<ProfilerService.ProfilerServiceClient>(moq::MockBehavior.Strict);
            CreateOfflineProfileRequest request = new CreateOfflineProfileRequest
            {
                Parent = "parent7858e4d0",
                Profile = new Profile(),
            };
            Profile expectedResponse = new Profile
            {
                Name = "name1c9368b0",
                ProfileType = ProfileType.Contention,
                Deployment = new Deployment(),
                Duration = new wkt::Duration(),
                ProfileBytes = proto::ByteString.CopyFromUtf8("profile_bytes12d9894a"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateOfflineProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfilerServiceClient client = new ProfilerServiceClientImpl(mockGrpcClient.Object, null, null);
            Profile responseCallSettings = await client.CreateOfflineProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.CreateOfflineProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateProfileRequestObject()
        {
            moq::Mock<ProfilerService.ProfilerServiceClient> mockGrpcClient = new moq::Mock<ProfilerService.ProfilerServiceClient>(moq::MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new wkt::FieldMask(),
            };
            Profile expectedResponse = new Profile
            {
                Name = "name1c9368b0",
                ProfileType = ProfileType.Contention,
                Deployment = new Deployment(),
                Duration = new wkt::Duration(),
                ProfileBytes = proto::ByteString.CopyFromUtf8("profile_bytes12d9894a"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProfilerServiceClient client = new ProfilerServiceClientImpl(mockGrpcClient.Object, null, null);
            Profile response = client.UpdateProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateProfileRequestObjectAsync()
        {
            moq::Mock<ProfilerService.ProfilerServiceClient> mockGrpcClient = new moq::Mock<ProfilerService.ProfilerServiceClient>(moq::MockBehavior.Strict);
            UpdateProfileRequest request = new UpdateProfileRequest
            {
                Profile = new Profile(),
                UpdateMask = new wkt::FieldMask(),
            };
            Profile expectedResponse = new Profile
            {
                Name = "name1c9368b0",
                ProfileType = ProfileType.Contention,
                Deployment = new Deployment(),
                Duration = new wkt::Duration(),
                ProfileBytes = proto::ByteString.CopyFromUtf8("profile_bytes12d9894a"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Profile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProfilerServiceClient client = new ProfilerServiceClientImpl(mockGrpcClient.Object, null, null);
            Profile responseCallSettings = await client.UpdateProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Profile responseCancellationToken = await client.UpdateProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
