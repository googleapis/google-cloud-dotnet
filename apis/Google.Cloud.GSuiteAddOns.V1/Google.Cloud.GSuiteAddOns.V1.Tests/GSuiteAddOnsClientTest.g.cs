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

namespace Google.Cloud.GSuiteAddOns.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGSuiteAddOnsClientTest
    {
        [xunit::FactAttribute]
        public void GetAuthorizationRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            Authorization expectedResponse = new Authorization
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "service_account_emailb0c3703d",
                OauthClientId = "oauth_client_iddd047d42",
            };
            mockGrpcClient.Setup(x => x.GetAuthorization(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Authorization response = client.GetAuthorization(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizationRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            Authorization expectedResponse = new Authorization
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "service_account_emailb0c3703d",
                OauthClientId = "oauth_client_iddd047d42",
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Authorization>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Authorization responseCallSettings = await client.GetAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Authorization responseCancellationToken = await client.GetAuthorizationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAuthorization()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            Authorization expectedResponse = new Authorization
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "service_account_emailb0c3703d",
                OauthClientId = "oauth_client_iddd047d42",
            };
            mockGrpcClient.Setup(x => x.GetAuthorization(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Authorization response = client.GetAuthorization(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizationAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            Authorization expectedResponse = new Authorization
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "service_account_emailb0c3703d",
                OauthClientId = "oauth_client_iddd047d42",
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Authorization>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Authorization responseCallSettings = await client.GetAuthorizationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Authorization responseCancellationToken = await client.GetAuthorizationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAuthorizationResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            Authorization expectedResponse = new Authorization
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "service_account_emailb0c3703d",
                OauthClientId = "oauth_client_iddd047d42",
            };
            mockGrpcClient.Setup(x => x.GetAuthorization(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Authorization response = client.GetAuthorization(request.AuthorizationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAuthorizationResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetAuthorizationRequest request = new GetAuthorizationRequest
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
            };
            Authorization expectedResponse = new Authorization
            {
                AuthorizationName = AuthorizationName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "service_account_emailb0c3703d",
                OauthClientId = "oauth_client_iddd047d42",
            };
            mockGrpcClient.Setup(x => x.GetAuthorizationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Authorization>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Authorization responseCallSettings = await client.GetAuthorizationAsync(request.AuthorizationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Authorization responseCancellationToken = await client.GetAuthorizationAsync(request.AuthorizationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeploymentRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "deployment_id4fcd2159",
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.CreateDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeploymentRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "deployment_id4fcd2159",
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.CreateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.CreateDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeployment()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "deployment_id4fcd2159",
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.CreateDeployment(request.Parent, request.Deployment, request.DeploymentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeploymentAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "deployment_id4fcd2159",
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.CreateDeploymentAsync(request.Parent, request.Deployment, request.DeploymentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.CreateDeploymentAsync(request.Parent, request.Deployment, request.DeploymentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDeploymentResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "deployment_id4fcd2159",
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.CreateDeployment(request.ParentAsProjectName, request.Deployment, request.DeploymentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDeploymentResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DeploymentId = "deployment_id4fcd2159",
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.CreateDeploymentAsync(request.ParentAsProjectName, request.Deployment, request.DeploymentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.CreateDeploymentAsync(request.ParentAsProjectName, request.Deployment, request.DeploymentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReplaceDeploymentRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            ReplaceDeploymentRequest request = new ReplaceDeploymentRequest
            {
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.ReplaceDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.ReplaceDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReplaceDeploymentRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            ReplaceDeploymentRequest request = new ReplaceDeploymentRequest
            {
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.ReplaceDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.ReplaceDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.ReplaceDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReplaceDeployment()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            ReplaceDeploymentRequest request = new ReplaceDeploymentRequest
            {
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.ReplaceDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.ReplaceDeployment(request.Deployment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReplaceDeploymentAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            ReplaceDeploymentRequest request = new ReplaceDeploymentRequest
            {
                Deployment = new Deployment(),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.ReplaceDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.ReplaceDeploymentAsync(request.Deployment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.ReplaceDeploymentAsync(request.Deployment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeploymentRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.GetDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeploymentRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.GetDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeployment()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.GetDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeploymentAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.GetDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.GetDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeploymentResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment response = client.GetDeployment(request.DeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeploymentResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            Deployment expectedResponse = new Deployment
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                OauthScopes =
                {
                    "oauth_scopesf8e5a359",
                },
                AddOns = new AddOns(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Deployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            Deployment responseCallSettings = await client.GetDeploymentAsync(request.DeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Deployment responseCancellationToken = await client.GetDeploymentAsync(request.DeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeploymentRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDeployment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeploymentRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeploymentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeployment()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDeployment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeploymentAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeploymentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDeploymentResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDeployment(request.DeploymentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDeploymentResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            DeleteDeploymentRequest request = new DeleteDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDeploymentAsync(request.DeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDeploymentAsync(request.DeploymentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InstallDeploymentRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.InstallDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.InstallDeployment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InstallDeploymentRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.InstallDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.InstallDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.InstallDeploymentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InstallDeployment()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.InstallDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.InstallDeployment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InstallDeploymentAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.InstallDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.InstallDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.InstallDeploymentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InstallDeploymentResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.InstallDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.InstallDeployment(request.DeploymentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InstallDeploymentResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            InstallDeploymentRequest request = new InstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.InstallDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.InstallDeploymentAsync(request.DeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.InstallDeploymentAsync(request.DeploymentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UninstallDeploymentRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UninstallDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.UninstallDeployment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UninstallDeploymentRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UninstallDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.UninstallDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.UninstallDeploymentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UninstallDeployment()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UninstallDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.UninstallDeployment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UninstallDeploymentAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UninstallDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.UninstallDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.UninstallDeploymentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UninstallDeploymentResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UninstallDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            client.UninstallDeployment(request.DeploymentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UninstallDeploymentResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            UninstallDeploymentRequest request = new UninstallDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UninstallDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            await client.UninstallDeploymentAsync(request.DeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.UninstallDeploymentAsync(request.DeploymentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstallStatusRequestObject()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            InstallStatus expectedResponse = new InstallStatus
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Installed = true,
            };
            mockGrpcClient.Setup(x => x.GetInstallStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            InstallStatus response = client.GetInstallStatus(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstallStatusRequestObjectAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            InstallStatus expectedResponse = new InstallStatus
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Installed = true,
            };
            mockGrpcClient.Setup(x => x.GetInstallStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstallStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            InstallStatus responseCallSettings = await client.GetInstallStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstallStatus responseCancellationToken = await client.GetInstallStatusAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstallStatus()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            InstallStatus expectedResponse = new InstallStatus
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Installed = true,
            };
            mockGrpcClient.Setup(x => x.GetInstallStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            InstallStatus response = client.GetInstallStatus(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstallStatusAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            InstallStatus expectedResponse = new InstallStatus
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Installed = true,
            };
            mockGrpcClient.Setup(x => x.GetInstallStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstallStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            InstallStatus responseCallSettings = await client.GetInstallStatusAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstallStatus responseCancellationToken = await client.GetInstallStatusAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstallStatusResourceNames()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            InstallStatus expectedResponse = new InstallStatus
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Installed = true,
            };
            mockGrpcClient.Setup(x => x.GetInstallStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            InstallStatus response = client.GetInstallStatus(request.InstallStatusName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstallStatusResourceNamesAsync()
        {
            moq::Mock<GSuiteAddOns.GSuiteAddOnsClient> mockGrpcClient = new moq::Mock<GSuiteAddOns.GSuiteAddOnsClient>(moq::MockBehavior.Strict);
            GetInstallStatusRequest request = new GetInstallStatusRequest
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
            };
            InstallStatus expectedResponse = new InstallStatus
            {
                InstallStatusName = InstallStatusName.FromProjectDeployment("[PROJECT]", "[DEPLOYMENT]"),
                Installed = true,
            };
            mockGrpcClient.Setup(x => x.GetInstallStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstallStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GSuiteAddOnsClient client = new GSuiteAddOnsClientImpl(mockGrpcClient.Object, null, null);
            InstallStatus responseCallSettings = await client.GetInstallStatusAsync(request.InstallStatusName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstallStatus responseCancellationToken = await client.GetInstallStatusAsync(request.InstallStatusName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
