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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Eventarc.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEventarcClientTest
    {
        [xunit::FactAttribute]
        public void GetTriggerRequestObject()
        {
            moq::Mock<Eventarc.EventarcClient> mockGrpcClient = new moq::Mock<Eventarc.EventarcClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            Trigger expectedResponse = new Trigger
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EventFilters = { new EventFilter(), },
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Destination = new Destination(),
                Transport = new Transport(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EventarcClient client = new EventarcClientImpl(mockGrpcClient.Object, null);
            Trigger response = client.GetTrigger(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTriggerRequestObjectAsync()
        {
            moq::Mock<Eventarc.EventarcClient> mockGrpcClient = new moq::Mock<Eventarc.EventarcClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            Trigger expectedResponse = new Trigger
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EventFilters = { new EventFilter(), },
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Destination = new Destination(),
                Transport = new Transport(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EventarcClient client = new EventarcClientImpl(mockGrpcClient.Object, null);
            Trigger responseCallSettings = await client.GetTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trigger responseCancellationToken = await client.GetTriggerAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrigger()
        {
            moq::Mock<Eventarc.EventarcClient> mockGrpcClient = new moq::Mock<Eventarc.EventarcClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            Trigger expectedResponse = new Trigger
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EventFilters = { new EventFilter(), },
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Destination = new Destination(),
                Transport = new Transport(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EventarcClient client = new EventarcClientImpl(mockGrpcClient.Object, null);
            Trigger response = client.GetTrigger(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTriggerAsync()
        {
            moq::Mock<Eventarc.EventarcClient> mockGrpcClient = new moq::Mock<Eventarc.EventarcClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            Trigger expectedResponse = new Trigger
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EventFilters = { new EventFilter(), },
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Destination = new Destination(),
                Transport = new Transport(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EventarcClient client = new EventarcClientImpl(mockGrpcClient.Object, null);
            Trigger responseCallSettings = await client.GetTriggerAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trigger responseCancellationToken = await client.GetTriggerAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTriggerResourceNames()
        {
            moq::Mock<Eventarc.EventarcClient> mockGrpcClient = new moq::Mock<Eventarc.EventarcClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            Trigger expectedResponse = new Trigger
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EventFilters = { new EventFilter(), },
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Destination = new Destination(),
                Transport = new Transport(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTrigger(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EventarcClient client = new EventarcClientImpl(mockGrpcClient.Object, null);
            Trigger response = client.GetTrigger(request.TriggerName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTriggerResourceNamesAsync()
        {
            moq::Mock<Eventarc.EventarcClient> mockGrpcClient = new moq::Mock<Eventarc.EventarcClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTriggerRequest request = new GetTriggerRequest
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
            };
            Trigger expectedResponse = new Trigger
            {
                TriggerName = TriggerName.FromProjectLocationTrigger("[PROJECT]", "[LOCATION]", "[TRIGGER]"),
                Uid = "uida2d37198",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EventFilters = { new EventFilter(), },
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Destination = new Destination(),
                Transport = new Transport(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetTriggerAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trigger>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EventarcClient client = new EventarcClientImpl(mockGrpcClient.Object, null);
            Trigger responseCallSettings = await client.GetTriggerAsync(request.TriggerName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trigger responseCancellationToken = await client.GetTriggerAsync(request.TriggerName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
