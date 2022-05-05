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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AppEngine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedApplicationsClientTest
    {
        [xunit::FactAttribute]
        public void GetApplicationRequestObject()
        {
            moq::Mock<Applications.ApplicationsClient> mockGrpcClient = new moq::Mock<Applications.ApplicationsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApplicationRequest request = new GetApplicationRequest
            {
                Name = "name1c9368b0",
            };
            Application expectedResponse = new Application
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DispatchRules =
                {
                    new UrlDispatchRule(),
                },
                AuthDomain = "auth_domaine14f1cb8",
                LocationId = "location_iddaa574e2",
                CodeBucket = "code_bucket58835a33",
                DefaultCookieExpiration = new wkt::Duration(),
                ServingStatus = Application.Types.ServingStatus.UserDisabled,
                DefaultHostname = "default_hostname0ebd0627",
                DefaultBucket = "default_bucket8b7bc47d",
                ServiceAccount = "service_accounta3c1b923",
                Iap = new Application.Types.IdentityAwareProxy(),
                GcrDomain = "gcr_domain3f5bd835",
                DatabaseType = Application.Types.DatabaseType.CloudDatastoreCompatibility,
                FeatureSettings = new Application.Types.FeatureSettings(),
            };
            mockGrpcClient.Setup(x => x.GetApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationsClient client = new ApplicationsClientImpl(mockGrpcClient.Object, null);
            Application response = client.GetApplication(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApplicationRequestObjectAsync()
        {
            moq::Mock<Applications.ApplicationsClient> mockGrpcClient = new moq::Mock<Applications.ApplicationsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApplicationRequest request = new GetApplicationRequest
            {
                Name = "name1c9368b0",
            };
            Application expectedResponse = new Application
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DispatchRules =
                {
                    new UrlDispatchRule(),
                },
                AuthDomain = "auth_domaine14f1cb8",
                LocationId = "location_iddaa574e2",
                CodeBucket = "code_bucket58835a33",
                DefaultCookieExpiration = new wkt::Duration(),
                ServingStatus = Application.Types.ServingStatus.UserDisabled,
                DefaultHostname = "default_hostname0ebd0627",
                DefaultBucket = "default_bucket8b7bc47d",
                ServiceAccount = "service_accounta3c1b923",
                Iap = new Application.Types.IdentityAwareProxy(),
                GcrDomain = "gcr_domain3f5bd835",
                DatabaseType = Application.Types.DatabaseType.CloudDatastoreCompatibility,
                FeatureSettings = new Application.Types.FeatureSettings(),
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationsClient client = new ApplicationsClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.GetApplicationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApplication()
        {
            moq::Mock<Applications.ApplicationsClient> mockGrpcClient = new moq::Mock<Applications.ApplicationsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApplicationRequest request = new GetApplicationRequest
            {
                Name = "name1c9368b0",
            };
            Application expectedResponse = new Application
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DispatchRules =
                {
                    new UrlDispatchRule(),
                },
                AuthDomain = "auth_domaine14f1cb8",
                LocationId = "location_iddaa574e2",
                CodeBucket = "code_bucket58835a33",
                DefaultCookieExpiration = new wkt::Duration(),
                ServingStatus = Application.Types.ServingStatus.UserDisabled,
                DefaultHostname = "default_hostname0ebd0627",
                DefaultBucket = "default_bucket8b7bc47d",
                ServiceAccount = "service_accounta3c1b923",
                Iap = new Application.Types.IdentityAwareProxy(),
                GcrDomain = "gcr_domain3f5bd835",
                DatabaseType = Application.Types.DatabaseType.CloudDatastoreCompatibility,
                FeatureSettings = new Application.Types.FeatureSettings(),
            };
            mockGrpcClient.Setup(x => x.GetApplication(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApplicationsClient client = new ApplicationsClientImpl(mockGrpcClient.Object, null);
            Application response = client.GetApplication(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApplicationAsync()
        {
            moq::Mock<Applications.ApplicationsClient> mockGrpcClient = new moq::Mock<Applications.ApplicationsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetApplicationRequest request = new GetApplicationRequest
            {
                Name = "name1c9368b0",
            };
            Application expectedResponse = new Application
            {
                Name = "name1c9368b0",
                Id = "id74b70bb8",
                DispatchRules =
                {
                    new UrlDispatchRule(),
                },
                AuthDomain = "auth_domaine14f1cb8",
                LocationId = "location_iddaa574e2",
                CodeBucket = "code_bucket58835a33",
                DefaultCookieExpiration = new wkt::Duration(),
                ServingStatus = Application.Types.ServingStatus.UserDisabled,
                DefaultHostname = "default_hostname0ebd0627",
                DefaultBucket = "default_bucket8b7bc47d",
                ServiceAccount = "service_accounta3c1b923",
                Iap = new Application.Types.IdentityAwareProxy(),
                GcrDomain = "gcr_domain3f5bd835",
                DatabaseType = Application.Types.DatabaseType.CloudDatastoreCompatibility,
                FeatureSettings = new Application.Types.FeatureSettings(),
            };
            mockGrpcClient.Setup(x => x.GetApplicationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Application>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApplicationsClient client = new ApplicationsClientImpl(mockGrpcClient.Object, null);
            Application responseCallSettings = await client.GetApplicationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Application responseCancellationToken = await client.GetApplicationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
