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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Speech.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSpeechClientTest
    {
        [xunit::FactAttribute]
        public void GetRecognizerRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            Recognizer expectedResponse = new Recognizer
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Model = "model635ef320",
                DefaultRecognitionConfig = new RecognitionConfig(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Recognizer.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Reconciling = false,
                ExpireTime = new wkt::Timestamp(),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
            };
            mockGrpcClient.Setup(x => x.GetRecognizer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Recognizer response = client.GetRecognizer(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecognizerRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            Recognizer expectedResponse = new Recognizer
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Model = "model635ef320",
                DefaultRecognitionConfig = new RecognitionConfig(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Recognizer.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Reconciling = false,
                ExpireTime = new wkt::Timestamp(),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
            };
            mockGrpcClient.Setup(x => x.GetRecognizerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recognizer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Recognizer responseCallSettings = await client.GetRecognizerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recognizer responseCancellationToken = await client.GetRecognizerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecognizer()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            Recognizer expectedResponse = new Recognizer
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Model = "model635ef320",
                DefaultRecognitionConfig = new RecognitionConfig(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Recognizer.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Reconciling = false,
                ExpireTime = new wkt::Timestamp(),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
            };
            mockGrpcClient.Setup(x => x.GetRecognizer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Recognizer response = client.GetRecognizer(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecognizerAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            Recognizer expectedResponse = new Recognizer
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Model = "model635ef320",
                DefaultRecognitionConfig = new RecognitionConfig(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Recognizer.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Reconciling = false,
                ExpireTime = new wkt::Timestamp(),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
            };
            mockGrpcClient.Setup(x => x.GetRecognizerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recognizer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Recognizer responseCallSettings = await client.GetRecognizerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recognizer responseCancellationToken = await client.GetRecognizerAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRecognizerResourceNames()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            Recognizer expectedResponse = new Recognizer
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Model = "model635ef320",
                DefaultRecognitionConfig = new RecognitionConfig(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Recognizer.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Reconciling = false,
                ExpireTime = new wkt::Timestamp(),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
            };
            mockGrpcClient.Setup(x => x.GetRecognizer(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Recognizer response = client.GetRecognizer(request.RecognizerName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRecognizerResourceNamesAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRecognizerRequest request = new GetRecognizerRequest
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
            };
            Recognizer expectedResponse = new Recognizer
            {
                RecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Model = "model635ef320",
                DefaultRecognitionConfig = new RecognitionConfig(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                State = Recognizer.Types.State.Unspecified,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                Reconciling = false,
                ExpireTime = new wkt::Timestamp(),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                LanguageCodes =
                {
                    "language_codes1de1a181",
                },
            };
            mockGrpcClient.Setup(x => x.GetRecognizerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Recognizer>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Recognizer responseCallSettings = await client.GetRecognizerAsync(request.RecognizerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Recognizer responseCancellationToken = await client.GetRecognizerAsync(request.RecognizerName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RecognizeRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                Uri = "uri3db70593",
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse response = client.Recognize(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecognizeRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                Uri = "uri3db70593",
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Recognize1()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse response = client.Recognize(request.Recognizer, request.Config, request.ConfigMask, request.Content);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Recognize1Async()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request.Recognizer, request.Config, request.ConfigMask, request.Content, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request.Recognizer, request.Config, request.ConfigMask, request.Content, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Recognize1ResourceNames()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse response = client.Recognize(request.RecognizerAsRecognizerName, request.Config, request.ConfigMask, request.Content);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Recognize1ResourceNamesAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request.RecognizerAsRecognizerName, request.Config, request.ConfigMask, request.Content, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request.RecognizerAsRecognizerName, request.Config, request.ConfigMask, request.Content, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Recognize2()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uri = "uri3db70593",
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse response = client.Recognize(request.Recognizer, request.Config, request.ConfigMask, request.Uri);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Recognize2Async()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uri = "uri3db70593",
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request.Recognizer, request.Config, request.ConfigMask, request.Uri, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request.Recognizer, request.Config, request.ConfigMask, request.Uri, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Recognize2ResourceNames()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uri = "uri3db70593",
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse response = client.Recognize(request.RecognizerAsRecognizerName, request.Config, request.ConfigMask, request.Uri);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Recognize2ResourceNamesAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                RecognizerAsRecognizerName = RecognizerName.FromProjectLocationRecognizer("[PROJECT]", "[LOCATION]", "[RECOGNIZER]"),
                Uri = "uri3db70593",
                ConfigMask = new wkt::FieldMask(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Metadata = new RecognitionResponseMetadata(),
                Results =
                {
                    new SpeechRecognitionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request.RecognizerAsRecognizerName, request.Config, request.ConfigMask, request.Uri, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request.RecognizerAsRecognizerName, request.Config, request.ConfigMask, request.Uri, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConfigRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config response = client.GetConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConfigRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config responseCallSettings = await client.GetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.GetConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConfig()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config response = client.GetConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConfigAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config responseCallSettings = await client.GetConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.GetConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConfigResourceNames()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config response = client.GetConfig(request.ConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConfigResourceNamesAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config responseCallSettings = await client.GetConfigAsync(request.ConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.GetConfigAsync(request.ConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConfigRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
                UpdateMask = new wkt::FieldMask(),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config response = client.UpdateConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConfigRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
                UpdateMask = new wkt::FieldMask(),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config responseCallSettings = await client.UpdateConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.UpdateConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConfig()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
                UpdateMask = new wkt::FieldMask(),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config response = client.UpdateConfig(request.Config, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConfigAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConfigRequest request = new UpdateConfigRequest
            {
                Config = new Config(),
                UpdateMask = new wkt::FieldMask(),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            Config responseCallSettings = await client.UpdateConfigAsync(request.Config, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.UpdateConfigAsync(request.Config, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomClassRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CustomClass.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            CustomClass response = client.GetCustomClass(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomClassRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CustomClass.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            CustomClass responseCallSettings = await client.GetCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.GetCustomClassAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomClass()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CustomClass.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            CustomClass response = client.GetCustomClass(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomClassAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CustomClass.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            CustomClass responseCallSettings = await client.GetCustomClassAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.GetCustomClassAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomClassResourceNames()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CustomClass.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            CustomClass response = client.GetCustomClass(request.CustomClassName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomClassResourceNamesAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                Uid = "uida2d37198",
                DisplayName = "display_name137f65c2",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CustomClass.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            CustomClass responseCallSettings = await client.GetCustomClassAsync(request.CustomClassName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.GetCustomClassAsync(request.CustomClassName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseSetRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Uid = "uida2d37198",
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = PhraseSet.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            PhraseSet response = client.GetPhraseSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseSetRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Uid = "uida2d37198",
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = PhraseSet.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            PhraseSet responseCallSettings = await client.GetPhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.GetPhraseSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseSet()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Uid = "uida2d37198",
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = PhraseSet.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            PhraseSet response = client.GetPhraseSet(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseSetAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Uid = "uida2d37198",
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = PhraseSet.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            PhraseSet responseCallSettings = await client.GetPhraseSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.GetPhraseSetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseSetResourceNames()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Uid = "uida2d37198",
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = PhraseSet.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            PhraseSet response = client.GetPhraseSet(request.PhraseSetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseSetResourceNamesAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Uid = "uida2d37198",
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                Reconciling = false,
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                KmsKeyVersionNameAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = PhraseSet.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null, null);
            PhraseSet responseCallSettings = await client.GetPhraseSetAsync(request.PhraseSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.GetPhraseSetAsync(request.PhraseSetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
