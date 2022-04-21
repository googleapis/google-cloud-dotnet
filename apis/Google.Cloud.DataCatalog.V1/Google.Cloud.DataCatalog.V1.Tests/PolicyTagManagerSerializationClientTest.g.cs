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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DataCatalog.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPolicyTagManagerSerializationClientTest
    {
        [xunit::FactAttribute]
        public void ReplaceTaxonomyRequestObject()
        {
            moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient> mockGrpcClient = new moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient>(moq::MockBehavior.Strict);
            ReplaceTaxonomyRequest request = new ReplaceTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                SerializedTaxonomy = new SerializedTaxonomy(),
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
            mockGrpcClient.Setup(x => x.ReplaceTaxonomy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerSerializationClient client = new PolicyTagManagerSerializationClientImpl(mockGrpcClient.Object, null, null);
            Taxonomy response = client.ReplaceTaxonomy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReplaceTaxonomyRequestObjectAsync()
        {
            moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient> mockGrpcClient = new moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient>(moq::MockBehavior.Strict);
            ReplaceTaxonomyRequest request = new ReplaceTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                SerializedTaxonomy = new SerializedTaxonomy(),
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
            mockGrpcClient.Setup(x => x.ReplaceTaxonomyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Taxonomy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerSerializationClient client = new PolicyTagManagerSerializationClientImpl(mockGrpcClient.Object, null, null);
            Taxonomy responseCallSettings = await client.ReplaceTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Taxonomy responseCancellationToken = await client.ReplaceTaxonomyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportTaxonomiesRequestObject()
        {
            moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient> mockGrpcClient = new moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient>(moq::MockBehavior.Strict);
            ImportTaxonomiesRequest request = new ImportTaxonomiesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InlineSource = new InlineSource(),
                CrossRegionalSource = new CrossRegionalSource(),
            };
            ImportTaxonomiesResponse expectedResponse = new ImportTaxonomiesResponse
            {
                Taxonomies = { new Taxonomy(), },
            };
            mockGrpcClient.Setup(x => x.ImportTaxonomies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerSerializationClient client = new PolicyTagManagerSerializationClientImpl(mockGrpcClient.Object, null, null);
            ImportTaxonomiesResponse response = client.ImportTaxonomies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportTaxonomiesRequestObjectAsync()
        {
            moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient> mockGrpcClient = new moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient>(moq::MockBehavior.Strict);
            ImportTaxonomiesRequest request = new ImportTaxonomiesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InlineSource = new InlineSource(),
                CrossRegionalSource = new CrossRegionalSource(),
            };
            ImportTaxonomiesResponse expectedResponse = new ImportTaxonomiesResponse
            {
                Taxonomies = { new Taxonomy(), },
            };
            mockGrpcClient.Setup(x => x.ImportTaxonomiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportTaxonomiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerSerializationClient client = new PolicyTagManagerSerializationClientImpl(mockGrpcClient.Object, null, null);
            ImportTaxonomiesResponse responseCallSettings = await client.ImportTaxonomiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportTaxonomiesResponse responseCancellationToken = await client.ImportTaxonomiesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExportTaxonomiesRequestObject()
        {
            moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient> mockGrpcClient = new moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient>(moq::MockBehavior.Strict);
            ExportTaxonomiesRequest request = new ExportTaxonomiesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TaxonomiesAsTaxonomyNames =
                {
                    TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                },
                SerializedTaxonomies = true,
            };
            ExportTaxonomiesResponse expectedResponse = new ExportTaxonomiesResponse
            {
                Taxonomies =
                {
                    new SerializedTaxonomy(),
                },
            };
            mockGrpcClient.Setup(x => x.ExportTaxonomies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PolicyTagManagerSerializationClient client = new PolicyTagManagerSerializationClientImpl(mockGrpcClient.Object, null, null);
            ExportTaxonomiesResponse response = client.ExportTaxonomies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExportTaxonomiesRequestObjectAsync()
        {
            moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient> mockGrpcClient = new moq::Mock<PolicyTagManagerSerialization.PolicyTagManagerSerializationClient>(moq::MockBehavior.Strict);
            ExportTaxonomiesRequest request = new ExportTaxonomiesRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TaxonomiesAsTaxonomyNames =
                {
                    TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                },
                SerializedTaxonomies = true,
            };
            ExportTaxonomiesResponse expectedResponse = new ExportTaxonomiesResponse
            {
                Taxonomies =
                {
                    new SerializedTaxonomy(),
                },
            };
            mockGrpcClient.Setup(x => x.ExportTaxonomiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExportTaxonomiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PolicyTagManagerSerializationClient client = new PolicyTagManagerSerializationClientImpl(mockGrpcClient.Object, null, null);
            ExportTaxonomiesResponse responseCallSettings = await client.ExportTaxonomiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExportTaxonomiesResponse responseCancellationToken = await client.ExportTaxonomiesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
