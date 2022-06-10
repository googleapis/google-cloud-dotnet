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
using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ApigeeRegistry.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegistryClientTest
    {
        [xunit::FactAttribute]
        public void GetApiRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.GetApi(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.GetApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.GetApiAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApi()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.GetApi(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.GetApiAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.GetApiAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.GetApi(request.ApiName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiRequest request = new GetApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.GetApiAsync(request.ApiName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.GetApiAsync(request.ApiName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new Api(),
                ApiId = "api_id5dff3ad3",
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.CreateApi(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new Api(),
                ApiId = "api_id5dff3ad3",
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.CreateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.CreateApiAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApi()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new Api(),
                ApiId = "api_id5dff3ad3",
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.CreateApi(request.Parent, request.Api, request.ApiId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new Api(),
                ApiId = "api_id5dff3ad3",
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.CreateApiAsync(request.Parent, request.Api, request.ApiId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.CreateApiAsync(request.Parent, request.Api, request.ApiId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new Api(),
                ApiId = "api_id5dff3ad3",
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.CreateApi(request.ParentAsLocationName, request.Api, request.ApiId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiRequest request = new CreateApiRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Api = new Api(),
                ApiId = "api_id5dff3ad3",
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.CreateApiAsync(request.ParentAsLocationName, request.Api, request.ApiId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.CreateApiAsync(request.ParentAsLocationName, request.Api, request.ApiId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiRequest request = new UpdateApiRequest
            {
                Api = new Api(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.UpdateApi(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiRequest request = new UpdateApiRequest
            {
                Api = new Api(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.UpdateApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.UpdateApiAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApi()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiRequest request = new UpdateApiRequest
            {
                Api = new Api(),
                UpdateMask = new wkt::FieldMask(),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api response = client.UpdateApi(request.Api, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiRequest request = new UpdateApiRequest
            {
                Api = new Api(),
                UpdateMask = new wkt::FieldMask(),
            };
            Api expectedResponse = new Api
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Availability = "availabilityce3144f2",
                RecommendedVersionAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                RecommendedDeploymentAsApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Api>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Api responseCallSettings = await client.UpdateApiAsync(request.Api, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Api responseCancellationToken = await client.UpdateApiAsync(request.Api, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApi(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApi()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApi(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApi(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApi(request.ApiName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiRequest request = new DeleteApiRequest
            {
                ApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiAsync(request.ApiName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiAsync(request.ApiName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiVersionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.GetApiVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiVersionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.GetApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.GetApiVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiVersion()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.GetApiVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiVersionAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.GetApiVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.GetApiVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiVersionResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.GetApiVersion(request.ApiVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiVersionResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiVersionRequest request = new GetApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.GetApiVersionAsync(request.ApiVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.GetApiVersionAsync(request.ApiVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiVersionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "api_version_id0a9fdf00",
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.CreateApiVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiVersionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "api_version_id0a9fdf00",
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.CreateApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.CreateApiVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiVersion()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "api_version_id0a9fdf00",
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.CreateApiVersion(request.Parent, request.ApiVersion, request.ApiVersionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiVersionAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "api_version_id0a9fdf00",
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.CreateApiVersionAsync(request.Parent, request.ApiVersion, request.ApiVersionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.CreateApiVersionAsync(request.Parent, request.ApiVersion, request.ApiVersionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiVersionResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "api_version_id0a9fdf00",
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.CreateApiVersion(request.ParentAsApiName, request.ApiVersion, request.ApiVersionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiVersionResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiVersionRequest request = new CreateApiVersionRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiVersion = new ApiVersion(),
                ApiVersionId = "api_version_id0a9fdf00",
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.CreateApiVersionAsync(request.ParentAsApiName, request.ApiVersion, request.ApiVersionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.CreateApiVersionAsync(request.ParentAsApiName, request.ApiVersion, request.ApiVersionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiVersionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiVersionRequest request = new UpdateApiVersionRequest
            {
                ApiVersion = new ApiVersion(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.UpdateApiVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiVersionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiVersionRequest request = new UpdateApiVersionRequest
            {
                ApiVersion = new ApiVersion(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.UpdateApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.UpdateApiVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiVersion()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiVersionRequest request = new UpdateApiVersionRequest
            {
                ApiVersion = new ApiVersion(),
                UpdateMask = new wkt::FieldMask(),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion response = client.UpdateApiVersion(request.ApiVersion, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiVersionAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiVersionRequest request = new UpdateApiVersionRequest
            {
                ApiVersion = new ApiVersion(),
                UpdateMask = new wkt::FieldMask(),
            };
            ApiVersion expectedResponse = new ApiVersion
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = "state2e9ed39e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiVersion responseCallSettings = await client.UpdateApiVersionAsync(request.ApiVersion, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiVersion responseCancellationToken = await client.UpdateApiVersionAsync(request.ApiVersion, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiVersionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiVersion(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiVersionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiVersionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiVersion()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiVersion(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiVersionAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiVersionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiVersionResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiVersion(request.ApiVersionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiVersionResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiVersionRequest request = new DeleteApiVersionRequest
            {
                ApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiVersionAsync(request.ApiVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiVersionAsync(request.ApiVersionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiSpecRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.GetApiSpec(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiSpecRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.GetApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.GetApiSpecAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiSpec()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.GetApiSpec(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiSpecAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.GetApiSpecAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.GetApiSpecAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiSpecResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.GetApiSpec(request.ApiSpecName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiSpecResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecRequest request = new GetApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.GetApiSpecAsync(request.ApiSpecName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.GetApiSpecAsync(request.ApiSpecName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiSpecContentsRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecContents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetApiSpecContents(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiSpecContentsRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecContentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetApiSpecContentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetApiSpecContentsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiSpecContents()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecContents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetApiSpecContents(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiSpecContentsAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecContentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetApiSpecContentsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetApiSpecContentsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiSpecContentsResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecContents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetApiSpecContents(request.ApiSpecName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiSpecContentsResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiSpecContentsRequest request = new GetApiSpecContentsRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetApiSpecContentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetApiSpecContentsAsync(request.ApiSpecName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetApiSpecContentsAsync(request.ApiSpecName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiSpecRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "api_spec_id75282f1a",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.CreateApiSpec(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiSpecRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "api_spec_id75282f1a",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.CreateApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.CreateApiSpecAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiSpec()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "api_spec_id75282f1a",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.CreateApiSpec(request.Parent, request.ApiSpec, request.ApiSpecId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiSpecAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "api_spec_id75282f1a",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.CreateApiSpecAsync(request.Parent, request.ApiSpec, request.ApiSpecId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.CreateApiSpecAsync(request.Parent, request.ApiSpec, request.ApiSpecId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiSpecResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "api_spec_id75282f1a",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.CreateApiSpec(request.ParentAsApiVersionName, request.ApiSpec, request.ApiSpecId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiSpecResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiSpecRequest request = new CreateApiSpecRequest
            {
                ParentAsApiVersionName = ApiVersionName.FromProjectLocationApiVersion("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]"),
                ApiSpec = new ApiSpec(),
                ApiSpecId = "api_spec_id75282f1a",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.CreateApiSpecAsync(request.ParentAsApiVersionName, request.ApiSpec, request.ApiSpecId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.CreateApiSpecAsync(request.ParentAsApiVersionName, request.ApiSpec, request.ApiSpecId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiSpecRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiSpecRequest request = new UpdateApiSpecRequest
            {
                ApiSpec = new ApiSpec(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.UpdateApiSpec(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiSpecRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiSpecRequest request = new UpdateApiSpecRequest
            {
                ApiSpec = new ApiSpec(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.UpdateApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.UpdateApiSpecAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiSpec()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiSpecRequest request = new UpdateApiSpecRequest
            {
                ApiSpec = new ApiSpec(),
                UpdateMask = new wkt::FieldMask(),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.UpdateApiSpec(request.ApiSpec, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiSpecAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiSpecRequest request = new UpdateApiSpecRequest
            {
                ApiSpec = new ApiSpec(),
                UpdateMask = new wkt::FieldMask(),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.UpdateApiSpecAsync(request.ApiSpec, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.UpdateApiSpecAsync(request.ApiSpec, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiSpecRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiSpec(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiSpecRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiSpecAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiSpec()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiSpec(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiSpecAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiSpecAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiSpecAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiSpecResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiSpec(request.ApiSpecName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiSpecResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRequest request = new DeleteApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiSpecAsync(request.ApiSpecName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiSpecAsync(request.ApiSpecName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TagApiSpecRevisionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            TagApiSpecRevisionRequest request = new TagApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Tag = "tag843ed2e4",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.TagApiSpecRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.TagApiSpecRevision(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TagApiSpecRevisionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            TagApiSpecRevisionRequest request = new TagApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Tag = "tag843ed2e4",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.TagApiSpecRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.TagApiSpecRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.TagApiSpecRevisionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackApiSpecRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RollbackApiSpecRequest request = new RollbackApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                RevisionId = "revision_id8d9ae05d",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RollbackApiSpec(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.RollbackApiSpec(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackApiSpecRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RollbackApiSpecRequest request = new RollbackApiSpecRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                RevisionId = "revision_id8d9ae05d",
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RollbackApiSpecAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.RollbackApiSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.RollbackApiSpecAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiSpecRevisionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiSpecRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.DeleteApiSpecRevision(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiSpecRevisionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiSpecRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.DeleteApiSpecRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.DeleteApiSpecRevisionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiSpecRevision()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiSpecRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.DeleteApiSpecRevision(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiSpecRevisionAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiSpecRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.DeleteApiSpecRevisionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.DeleteApiSpecRevisionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiSpecRevisionResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiSpecRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec response = client.DeleteApiSpecRevision(request.ApiSpecName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiSpecRevisionResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiSpecRevisionRequest request = new DeleteApiSpecRevisionRequest
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
            };
            ApiSpec expectedResponse = new ApiSpec
            {
                ApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                Filename = "filenamee9d75e43",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                SourceUri = "source_uri0c257c61",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiSpecRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiSpec>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiSpec responseCallSettings = await client.DeleteApiSpecRevisionAsync(request.ApiSpecName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiSpec responseCancellationToken = await client.DeleteApiSpecRevisionAsync(request.ApiSpecName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiDeploymentRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.GetApiDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiDeploymentRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.GetApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.GetApiDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiDeployment()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.GetApiDeployment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiDeploymentAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.GetApiDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.GetApiDeploymentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApiDeploymentResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.GetApiDeployment(request.ApiDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApiDeploymentResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetApiDeploymentRequest request = new GetApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.GetApiDeploymentAsync(request.ApiDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.GetApiDeploymentAsync(request.ApiDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiDeploymentRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "api_deployment_id77c897d8",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.CreateApiDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiDeploymentRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "api_deployment_id77c897d8",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.CreateApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.CreateApiDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiDeployment()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "api_deployment_id77c897d8",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.CreateApiDeployment(request.Parent, request.ApiDeployment, request.ApiDeploymentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiDeploymentAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "api_deployment_id77c897d8",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.CreateApiDeploymentAsync(request.Parent, request.ApiDeployment, request.ApiDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.CreateApiDeploymentAsync(request.Parent, request.ApiDeployment, request.ApiDeploymentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateApiDeploymentResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "api_deployment_id77c897d8",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.CreateApiDeployment(request.ParentAsApiName, request.ApiDeployment, request.ApiDeploymentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateApiDeploymentResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateApiDeploymentRequest request = new CreateApiDeploymentRequest
            {
                ParentAsApiName = ApiName.FromProjectLocationApi("[PROJECT]", "[LOCATION]", "[API]"),
                ApiDeployment = new ApiDeployment(),
                ApiDeploymentId = "api_deployment_id77c897d8",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.CreateApiDeploymentAsync(request.ParentAsApiName, request.ApiDeployment, request.ApiDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.CreateApiDeploymentAsync(request.ParentAsApiName, request.ApiDeployment, request.ApiDeploymentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiDeploymentRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiDeploymentRequest request = new UpdateApiDeploymentRequest
            {
                ApiDeployment = new ApiDeployment(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.UpdateApiDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiDeploymentRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiDeploymentRequest request = new UpdateApiDeploymentRequest
            {
                ApiDeployment = new ApiDeployment(),
                UpdateMask = new wkt::FieldMask(),
                AllowMissing = true,
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.UpdateApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.UpdateApiDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateApiDeployment()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiDeploymentRequest request = new UpdateApiDeploymentRequest
            {
                ApiDeployment = new ApiDeployment(),
                UpdateMask = new wkt::FieldMask(),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.UpdateApiDeployment(request.ApiDeployment, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateApiDeploymentAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateApiDeploymentRequest request = new UpdateApiDeploymentRequest
            {
                ApiDeployment = new ApiDeployment(),
                UpdateMask = new wkt::FieldMask(),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.UpdateApiDeploymentAsync(request.ApiDeployment, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.UpdateApiDeploymentAsync(request.ApiDeployment, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiDeploymentRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiDeployment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiDeploymentRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiDeploymentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiDeployment()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiDeployment(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiDeploymentAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiDeploymentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiDeploymentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiDeploymentResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteApiDeployment(request.ApiDeploymentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiDeploymentResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRequest request = new DeleteApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteApiDeploymentAsync(request.ApiDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteApiDeploymentAsync(request.ApiDeploymentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TagApiDeploymentRevisionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            TagApiDeploymentRevisionRequest request = new TagApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Tag = "tag843ed2e4",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.TagApiDeploymentRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.TagApiDeploymentRevision(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TagApiDeploymentRevisionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            TagApiDeploymentRevisionRequest request = new TagApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                Tag = "tag843ed2e4",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.TagApiDeploymentRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.TagApiDeploymentRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.TagApiDeploymentRevisionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackApiDeploymentRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RollbackApiDeploymentRequest request = new RollbackApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                RevisionId = "revision_id8d9ae05d",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RollbackApiDeployment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.RollbackApiDeployment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackApiDeploymentRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            RollbackApiDeploymentRequest request = new RollbackApiDeploymentRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                RevisionId = "revision_id8d9ae05d",
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.RollbackApiDeploymentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.RollbackApiDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.RollbackApiDeploymentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiDeploymentRevisionRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.DeleteApiDeploymentRevision(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiDeploymentRevisionRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.DeleteApiDeploymentRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.DeleteApiDeploymentRevisionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiDeploymentRevision()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.DeleteApiDeploymentRevision(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiDeploymentRevisionAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.DeleteApiDeploymentRevisionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.DeleteApiDeploymentRevisionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteApiDeploymentRevisionResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment response = client.DeleteApiDeploymentRevision(request.ApiDeploymentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteApiDeploymentRevisionResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteApiDeploymentRevisionRequest request = new DeleteApiDeploymentRevisionRequest
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
            };
            ApiDeployment expectedResponse = new ApiDeployment
            {
                ApiDeploymentName = ApiDeploymentName.FromProjectLocationApiDeployment("[PROJECT]", "[LOCATION]", "[API]", "[DEPLOYMENT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                RevisionId = "revision_id8d9ae05d",
                CreateTime = new wkt::Timestamp(),
                RevisionCreateTime = new wkt::Timestamp(),
                RevisionUpdateTime = new wkt::Timestamp(),
                ApiSpecRevisionAsApiSpecName = ApiSpecName.FromProjectLocationApiVersionSpec("[PROJECT]", "[LOCATION]", "[API]", "[VERSION]", "[SPEC]"),
                EndpointUri = "endpoint_uri59c03c94",
                ExternalChannelUri = "external_channel_uri34dd8fbf",
                IntendedAudience = "intended_audienced5720a03",
                AccessGuidance = "access_guidance4e709295",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.DeleteApiDeploymentRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApiDeployment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ApiDeployment responseCallSettings = await client.DeleteApiDeploymentRevisionAsync(request.ApiDeploymentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApiDeployment responseCancellationToken = await client.DeleteApiDeploymentRevisionAsync(request.ApiDeploymentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.GetArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.GetArtifact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.GetArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.GetArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.GetArtifactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifact()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.GetArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.GetArtifact(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.GetArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.GetArtifactAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.GetArtifactAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.GetArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.GetArtifact(request.ArtifactName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactRequest request = new GetArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.GetArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.GetArtifactAsync(request.ArtifactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.GetArtifactAsync(request.ArtifactName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactContentsRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetArtifactContents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetArtifactContents(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactContentsRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetArtifactContentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetArtifactContentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetArtifactContentsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactContents()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetArtifactContents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetArtifactContents(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactContentsAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetArtifactContentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetArtifactContentsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetArtifactContentsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetArtifactContentsResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetArtifactContents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.GetArtifactContents(request.ArtifactName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetArtifactContentsResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetArtifactContentsRequest request = new GetArtifactContentsRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.GetArtifactContentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.GetArtifactContentsAsync(request.ArtifactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.GetArtifactContentsAsync(request.ArtifactName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifact()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.Parent, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.Parent, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.Parent, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactResourceNames1()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.ParentAsLocationName, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactResourceNames1Async()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.ParentAsLocationName, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.ParentAsLocationName, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactResourceNames2()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.ParentAsApiName, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactResourceNames2Async()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.ParentAsApiName, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.ParentAsApiName, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactResourceNames3()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.ParentAsApiVersionName, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactResourceNames3Async()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.ParentAsApiVersionName, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.ParentAsApiVersionName, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactResourceNames4()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.ParentAsApiSpecName, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactResourceNames4Async()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.ParentAsApiSpecName, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.ParentAsApiSpecName, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateArtifactResourceNames5()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.CreateArtifact(request.ParentAsApiDeploymentName, request.Artifact, request.ArtifactId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateArtifactResourceNames5Async()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Artifact = new Artifact(),
                ArtifactId = "artifact_ida6761d54",
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.CreateArtifactAsync(request.ParentAsApiDeploymentName, request.Artifact, request.ArtifactId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.CreateArtifactAsync(request.ParentAsApiDeploymentName, request.Artifact, request.ArtifactId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReplaceArtifactRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ReplaceArtifactRequest request = new ReplaceArtifactRequest
            {
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.ReplaceArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.ReplaceArtifact(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReplaceArtifactRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ReplaceArtifactRequest request = new ReplaceArtifactRequest
            {
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.ReplaceArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.ReplaceArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.ReplaceArtifactAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReplaceArtifact()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ReplaceArtifactRequest request = new ReplaceArtifactRequest
            {
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.ReplaceArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact response = client.ReplaceArtifact(request.Artifact);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReplaceArtifactAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ReplaceArtifactRequest request = new ReplaceArtifactRequest
            {
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                MimeType = "mime_type606a0ffc",
                SizeBytes = 244526526,
                Hash = "hash57fc0008",
                Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
            };
            mockGrpcClient.Setup(x => x.ReplaceArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Artifact>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            Artifact responseCallSettings = await client.ReplaceArtifactAsync(request.Artifact, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Artifact responseCancellationToken = await client.ReplaceArtifactAsync(request.Artifact, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteArtifactRequestObject()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteArtifact(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteArtifactRequestObjectAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteArtifactAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteArtifact()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteArtifact(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteArtifactAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteArtifactAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteArtifactAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteArtifactResourceNames()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteArtifact(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteArtifact(request.ArtifactName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteArtifactResourceNamesAsync()
        {
            moq::Mock<Registry.RegistryClient> mockGrpcClient = new moq::Mock<Registry.RegistryClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = ArtifactName.FromProjectLocationArtifact("[PROJECT]", "[LOCATION]", "[ARTIFACT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegistryClient client = new RegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteArtifactAsync(request.ArtifactName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteArtifactAsync(request.ArtifactName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
