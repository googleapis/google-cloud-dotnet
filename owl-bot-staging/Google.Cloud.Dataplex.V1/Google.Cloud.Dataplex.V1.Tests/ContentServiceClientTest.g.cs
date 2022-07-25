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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataplex.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedContentServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateContentRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateContentRequest request = new CreateContentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new Content(),
                ValidateOnly = true,
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.CreateContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.CreateContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContentRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateContentRequest request = new CreateContentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new Content(),
                ValidateOnly = true,
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.CreateContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.CreateContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.CreateContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContent()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateContentRequest request = new CreateContentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new Content(),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.CreateContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.CreateContent(request.Parent, request.Content);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContentAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateContentRequest request = new CreateContentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new Content(),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.CreateContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.CreateContentAsync(request.Parent, request.Content, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.CreateContentAsync(request.Parent, request.Content, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContentResourceNames()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateContentRequest request = new CreateContentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new Content(),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.CreateContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.CreateContent(request.ParentAsLakeName, request.Content);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContentResourceNamesAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateContentRequest request = new CreateContentRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Content = new Content(),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.CreateContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.CreateContentAsync(request.ParentAsLakeName, request.Content, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.CreateContentAsync(request.ParentAsLakeName, request.Content, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContentRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateContentRequest request = new UpdateContentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Content = new Content(),
                ValidateOnly = true,
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.UpdateContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.UpdateContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContentRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateContentRequest request = new UpdateContentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Content = new Content(),
                ValidateOnly = true,
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.UpdateContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.UpdateContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.UpdateContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContent()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateContentRequest request = new UpdateContentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Content = new Content(),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.UpdateContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.UpdateContent(request.Content, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContentAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateContentRequest request = new UpdateContentRequest
            {
                UpdateMask = new wkt::FieldMask(),
                Content = new Content(),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.UpdateContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.UpdateContentAsync(request.Content, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.UpdateContentAsync(request.Content, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContentRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteContentRequest request = new DeleteContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteContent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContentRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteContentRequest request = new DeleteContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContent()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteContentRequest request = new DeleteContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteContent(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContentAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteContentRequest request = new DeleteContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteContentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContentResourceNames()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteContentRequest request = new DeleteContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteContent(request.ContentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContentResourceNamesAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteContentRequest request = new DeleteContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteContentAsync(request.ContentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContentAsync(request.ContentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContentRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                View = GetContentRequest.Types.ContentView.Basic,
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.GetContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.GetContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContentRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                View = GetContentRequest.Types.ContentView.Basic,
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.GetContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.GetContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.GetContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContent()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.GetContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.GetContent(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContentAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.GetContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.GetContentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.GetContentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContentResourceNames()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.GetContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content response = client.GetContent(request.ContentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContentResourceNamesAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
            };
            Content expectedResponse = new Content
            {
                ContentName = ContentName.FromProjectLocationLakeContent("[PROJECT]", "[LOCATION]", "[LAKE]", "[CONTENT]"),
                Uid = "uida2d37198",
                Path = "path0b1dfed6",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                DataText = "data_text00b857da",
                SqlScript = new Content.Types.SqlScript(),
                Notebook = new Content.Types.Notebook(),
            };
            mockGrpcClient.Setup(x => x.GetContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Content>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            Content responseCallSettings = await client.GetContentAsync(request.ContentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Content responseCancellationToken = await client.GetContentAsync(request.ContentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<ContentService.ContentServiceClient> mockGrpcClient = new moq::Mock<ContentService.ContentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
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
            ContentServiceClient client = new ContentServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
