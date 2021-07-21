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
    public sealed class GeneratedLicenseCodesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            GetLicenseCodeRequest request = new GetLicenseCodeRequest
            {
                LicenseCode = "license_code196a50c0",
                Project = "projectaa6ff846",
            };
            LicenseCode expectedResponse = new LicenseCode
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Transferable = false,
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseAlias =
                {
                    new LicenseCodeLicenseAlias(),
                },
                State = LicenseCode.Types.State.UndefinedState,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            LicenseCode response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            GetLicenseCodeRequest request = new GetLicenseCodeRequest
            {
                LicenseCode = "license_code196a50c0",
                Project = "projectaa6ff846",
            };
            LicenseCode expectedResponse = new LicenseCode
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Transferable = false,
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseAlias =
                {
                    new LicenseCodeLicenseAlias(),
                },
                State = LicenseCode.Types.State.UndefinedState,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LicenseCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            LicenseCode responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LicenseCode responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            GetLicenseCodeRequest request = new GetLicenseCodeRequest
            {
                LicenseCode = "license_code196a50c0",
                Project = "projectaa6ff846",
            };
            LicenseCode expectedResponse = new LicenseCode
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Transferable = false,
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseAlias =
                {
                    new LicenseCodeLicenseAlias(),
                },
                State = LicenseCode.Types.State.UndefinedState,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            LicenseCode response = client.Get(request.Project, request.LicenseCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            GetLicenseCodeRequest request = new GetLicenseCodeRequest
            {
                LicenseCode = "license_code196a50c0",
                Project = "projectaa6ff846",
            };
            LicenseCode expectedResponse = new LicenseCode
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Transferable = false,
                CreationTimestamp = "creation_timestamp235e59a1",
                LicenseAlias =
                {
                    new LicenseCodeLicenseAlias(),
                },
                State = LicenseCode.Types.State.UndefinedState,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LicenseCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            LicenseCode responseCallSettings = await client.GetAsync(request.Project, request.LicenseCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LicenseCode responseCancellationToken = await client.GetAsync(request.Project, request.LicenseCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsLicenseCodeRequest request = new TestIamPermissionsLicenseCodeRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsLicenseCodeRequest request = new TestIamPermissionsLicenseCodeRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsLicenseCodeRequest request = new TestIamPermissionsLicenseCodeRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<LicenseCodes.LicenseCodesClient> mockGrpcClient = new moq::Mock<LicenseCodes.LicenseCodesClient>(moq::MockBehavior.Strict);
            TestIamPermissionsLicenseCodeRequest request = new TestIamPermissionsLicenseCodeRequest
            {
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LicenseCodesClient client = new LicenseCodesClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
