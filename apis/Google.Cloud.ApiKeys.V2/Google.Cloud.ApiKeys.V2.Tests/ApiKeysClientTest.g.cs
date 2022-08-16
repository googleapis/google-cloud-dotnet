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
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ApiKeys.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedApiKeysClientTest
    {
        [xunit::FactAttribute]
        public void GetKeyRequestObject()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                KeyString = "key_string999d2a47",
                CreateTime = new wkt::Timestamp(),
                Uid = "uida2d37198",
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Restrictions = new Restrictions(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            Key response = client.GetKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyRequestObjectAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                KeyString = "key_string999d2a47",
                CreateTime = new wkt::Timestamp(),
                Uid = "uida2d37198",
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Restrictions = new Restrictions(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            Key responseCallSettings = await client.GetKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.GetKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKey()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                KeyString = "key_string999d2a47",
                CreateTime = new wkt::Timestamp(),
                Uid = "uida2d37198",
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Restrictions = new Restrictions(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            Key response = client.GetKey(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                KeyString = "key_string999d2a47",
                CreateTime = new wkt::Timestamp(),
                Uid = "uida2d37198",
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Restrictions = new Restrictions(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            Key responseCallSettings = await client.GetKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.GetKeyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyResourceNames()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                KeyString = "key_string999d2a47",
                CreateTime = new wkt::Timestamp(),
                Uid = "uida2d37198",
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Restrictions = new Restrictions(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            Key response = client.GetKey(request.KeyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyResourceNamesAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            Key expectedResponse = new Key
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
                DisplayName = "display_name137f65c2",
                KeyString = "key_string999d2a47",
                CreateTime = new wkt::Timestamp(),
                Uid = "uida2d37198",
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Restrictions = new Restrictions(),
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Key>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            Key responseCallSettings = await client.GetKeyAsync(request.KeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Key responseCancellationToken = await client.GetKeyAsync(request.KeyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyStringRequestObject()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            GetKeyStringResponse expectedResponse = new GetKeyStringResponse
            {
                KeyString = "key_string999d2a47",
            };
            mockGrpcClient.Setup(x => x.GetKeyString(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            GetKeyStringResponse response = client.GetKeyString(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyStringRequestObjectAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            GetKeyStringResponse expectedResponse = new GetKeyStringResponse
            {
                KeyString = "key_string999d2a47",
            };
            mockGrpcClient.Setup(x => x.GetKeyStringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetKeyStringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            GetKeyStringResponse responseCallSettings = await client.GetKeyStringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetKeyStringResponse responseCancellationToken = await client.GetKeyStringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyString()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            GetKeyStringResponse expectedResponse = new GetKeyStringResponse
            {
                KeyString = "key_string999d2a47",
            };
            mockGrpcClient.Setup(x => x.GetKeyString(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            GetKeyStringResponse response = client.GetKeyString(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyStringAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            GetKeyStringResponse expectedResponse = new GetKeyStringResponse
            {
                KeyString = "key_string999d2a47",
            };
            mockGrpcClient.Setup(x => x.GetKeyStringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetKeyStringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            GetKeyStringResponse responseCallSettings = await client.GetKeyStringAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetKeyStringResponse responseCancellationToken = await client.GetKeyStringAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyStringResourceNames()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            GetKeyStringResponse expectedResponse = new GetKeyStringResponse
            {
                KeyString = "key_string999d2a47",
            };
            mockGrpcClient.Setup(x => x.GetKeyString(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            GetKeyStringResponse response = client.GetKeyString(request.KeyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyStringResourceNamesAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetKeyStringRequest request = new GetKeyStringRequest
            {
                KeyName = KeyName.FromProjectLocationKey("[PROJECT]", "[LOCATION]", "[KEY]"),
            };
            GetKeyStringResponse expectedResponse = new GetKeyStringResponse
            {
                KeyString = "key_string999d2a47",
            };
            mockGrpcClient.Setup(x => x.GetKeyStringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetKeyStringResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            GetKeyStringResponse responseCallSettings = await client.GetKeyStringAsync(request.KeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetKeyStringResponse responseCancellationToken = await client.GetKeyStringAsync(request.KeyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LookupKeyRequestObject()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupKeyRequest request = new LookupKeyRequest
            {
                KeyString = "key_string999d2a47",
            };
            LookupKeyResponse expectedResponse = new LookupKeyResponse
            {
                Parent = "parent7858e4d0",
                Name = "name1c9368b0",
            };
            mockGrpcClient.Setup(x => x.LookupKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            LookupKeyResponse response = client.LookupKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupKeyRequestObjectAsync()
        {
            moq::Mock<ApiKeys.ApiKeysClient> mockGrpcClient = new moq::Mock<ApiKeys.ApiKeysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupKeyRequest request = new LookupKeyRequest
            {
                KeyString = "key_string999d2a47",
            };
            LookupKeyResponse expectedResponse = new LookupKeyResponse
            {
                Parent = "parent7858e4d0",
                Name = "name1c9368b0",
            };
            mockGrpcClient.Setup(x => x.LookupKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LookupKeyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ApiKeysClient client = new ApiKeysClientImpl(mockGrpcClient.Object, null, null);
            LookupKeyResponse responseCallSettings = await client.LookupKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LookupKeyResponse responseCancellationToken = await client.LookupKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
