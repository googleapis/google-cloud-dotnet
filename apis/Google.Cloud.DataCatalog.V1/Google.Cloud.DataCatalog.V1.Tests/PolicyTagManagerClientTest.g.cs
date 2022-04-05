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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataCatalog.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPolicyTagManagerClientTest
    {
        [xunit::FactAttribute]
        public void CreateTaxonomyRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.CreateTaxonomy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaxonomyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.CreateTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.CreateTaxonomyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTaxonomy()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.CreateTaxonomy(request.Parent, request.Taxonomy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaxonomyAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.CreateTaxonomyAsync(request.Parent, request.Taxonomy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.CreateTaxonomyAsync(request.Parent, request.Taxonomy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTaxonomyResourceNames()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.CreateTaxonomy(request.ParentAsLocationName, request.Taxonomy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaxonomyResourceNamesAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.CreateTaxonomyAsync(request.ParentAsLocationName, request.Taxonomy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.CreateTaxonomyAsync(request.ParentAsLocationName, request.Taxonomy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaxonomyRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteTaxonomy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaxonomyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaxonomyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaxonomy()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteTaxonomy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaxonomyAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaxonomyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaxonomyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaxonomyResourceNames()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            client.DeleteTaxonomy(request.TaxonomyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaxonomyResourceNamesAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaxonomyAsync(request.TaxonomyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaxonomyAsync(request.TaxonomyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTaxonomyRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdateTaxonomyRequest request = new UpdateTaxonomyRequest
            {
                Taxonomy = new Taxonomy(),
                UpdateMask = new wkt::FieldMask(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.UpdateTaxonomy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTaxonomyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdateTaxonomyRequest request = new UpdateTaxonomyRequest
            {
                Taxonomy = new Taxonomy(),
                UpdateMask = new wkt::FieldMask(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.UpdateTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.UpdateTaxonomyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTaxonomy()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdateTaxonomyRequest request = new UpdateTaxonomyRequest
            {
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.UpdateTaxonomy(request.Taxonomy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTaxonomyAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdateTaxonomyRequest request = new UpdateTaxonomyRequest
            {
                Taxonomy = new Taxonomy(),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.UpdateTaxonomyAsync(request.Taxonomy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.UpdateTaxonomyAsync(request.Taxonomy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaxonomyRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.GetTaxonomy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaxonomyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.GetTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.GetTaxonomyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaxonomy()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.GetTaxonomy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaxonomyAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.GetTaxonomyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.GetTaxonomyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaxonomyResourceNames()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy response = client.GetTaxonomy(request.TaxonomyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaxonomyResourceNamesAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            Taxonomy expectedResponse = new Taxonomy
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PolicyTagCount = -1730676159,
                TaxonomyTimestamps = new SystemTimestamps(),
                ActivatedPolicyTypes =
                {
                    Taxonomy.Types.PolicyType.Unspecified,
                },
            };
            mockGrpcClient.Setup(x => x.GetTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            Taxonomy responseCallSettings = await client.GetTaxonomyAsync(request.TaxonomyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.GetTaxonomyAsync(request.TaxonomyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyTagRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.CreatePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.CreatePolicyTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyTagRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.CreatePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.CreatePolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.CreatePolicyTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyTag()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.CreatePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.CreatePolicyTag(request.Parent, request.PolicyTag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyTagAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.CreatePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.CreatePolicyTagAsync(request.Parent, request.PolicyTag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.CreatePolicyTagAsync(request.Parent, request.PolicyTag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePolicyTagResourceNames()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.CreatePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.CreatePolicyTag(request.ParentAsTaxonomyName, request.PolicyTag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePolicyTagResourceNamesAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.CreatePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.CreatePolicyTagAsync(request.ParentAsTaxonomyName, request.PolicyTag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.CreatePolicyTagAsync(request.ParentAsTaxonomyName, request.PolicyTag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePolicyTagRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            client.DeletePolicyTag(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePolicyTagRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeletePolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePolicyTagAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePolicyTag()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            client.DeletePolicyTag(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePolicyTagAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeletePolicyTagAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePolicyTagAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePolicyTagResourceNames()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            client.DeletePolicyTag(request.PolicyTagName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePolicyTagResourceNamesAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            await client.DeletePolicyTagAsync(request.PolicyTagName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePolicyTagAsync(request.PolicyTagName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePolicyTagRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdatePolicyTagRequest request = new UpdatePolicyTagRequest
            {
                PolicyTag = new PolicyTag(),
                UpdateMask = new wkt::FieldMask(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.UpdatePolicyTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePolicyTagRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdatePolicyTagRequest request = new UpdatePolicyTagRequest
            {
                PolicyTag = new PolicyTag(),
                UpdateMask = new wkt::FieldMask(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.UpdatePolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.UpdatePolicyTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePolicyTag()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdatePolicyTagRequest request = new UpdatePolicyTagRequest
            {
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.UpdatePolicyTag(request.PolicyTag);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePolicyTagAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            UpdatePolicyTagRequest request = new UpdatePolicyTagRequest
            {
                PolicyTag = new PolicyTag(),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.UpdatePolicyTagAsync(request.PolicyTag, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.UpdatePolicyTagAsync(request.PolicyTag, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyTagRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.GetPolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.GetPolicyTag(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyTagRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.GetPolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.GetPolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.GetPolicyTagAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyTag()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.GetPolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.GetPolicyTag(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyTagAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.GetPolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.GetPolicyTagAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.GetPolicyTagAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicyTagResourceNames()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.GetPolicyTag(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag response = client.GetPolicyTag(request.PolicyTagName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyTagResourceNamesAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            PolicyTag expectedResponse = new PolicyTag
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                ParentPolicyTag = "parent_policy_tagbc591931",
                ChildPolicyTags =
                {
                    "child_policy_tags11be0699",
                },
            };
            mockGrpcClient.Setup(x => x.GetPolicyTagAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PolicyTag>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            PolicyTag responseCallSettings = await client.GetPolicyTagAsync(request.PolicyTagName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PolicyTag responseCancellationToken = await client.GetPolicyTagAsync(request.PolicyTagName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
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
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
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
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
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
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
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
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
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
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<PolicyTagManager.PolicyTagManagerClient> mockGrpcClient = new moq::Mock<PolicyTagManager.PolicyTagManagerClient>(moq::MockBehavior.Strict);
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
            PolicyTagManagerClient client = new PolicyTagManagerClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
