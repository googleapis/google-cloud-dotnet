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
using gcl = Google.Cloud.Location;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEnvironmentsClientTest
    {
        [xunit::FactAttribute]
        public void GetEnvironmentRequestObject()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                Description = "description2cf9da67",
                AgentVersionAsVersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                State = Environment.Types.State.Loading,
                UpdateTime = new wkt::Timestamp(),
                TextToSpeechSettings = new TextToSpeechSettings(),
                Fulfillment = new Fulfillment(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.GetEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEnvironmentRequestObjectAsync()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                Description = "description2cf9da67",
                AgentVersionAsVersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                State = Environment.Types.State.Loading,
                UpdateTime = new wkt::Timestamp(),
                TextToSpeechSettings = new TextToSpeechSettings(),
                Fulfillment = new Fulfillment(),
            };
            mockGrpcClient.Setup(x => x.GetEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.GetEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEnvironmentRequestObject()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Environment = new Environment(),
                EnvironmentId = "environment_id26e3069e",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                Description = "description2cf9da67",
                AgentVersionAsVersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                State = Environment.Types.State.Loading,
                UpdateTime = new wkt::Timestamp(),
                TextToSpeechSettings = new TextToSpeechSettings(),
                Fulfillment = new Fulfillment(),
            };
            mockGrpcClient.Setup(x => x.CreateEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.CreateEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEnvironmentRequestObjectAsync()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                ParentAsAgentName = AgentName.FromProject("[PROJECT]"),
                Environment = new Environment(),
                EnvironmentId = "environment_id26e3069e",
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                Description = "description2cf9da67",
                AgentVersionAsVersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                State = Environment.Types.State.Loading,
                UpdateTime = new wkt::Timestamp(),
                TextToSpeechSettings = new TextToSpeechSettings(),
                Fulfillment = new Fulfillment(),
            };
            mockGrpcClient.Setup(x => x.CreateEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.CreateEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEnvironmentRequestObject()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEnvironmentRequest request = new UpdateEnvironmentRequest
            {
                Environment = new Environment(),
                UpdateMask = new wkt::FieldMask(),
                AllowLoadToDraftAndDiscardChanges = true,
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                Description = "description2cf9da67",
                AgentVersionAsVersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                State = Environment.Types.State.Loading,
                UpdateTime = new wkt::Timestamp(),
                TextToSpeechSettings = new TextToSpeechSettings(),
                Fulfillment = new Fulfillment(),
            };
            mockGrpcClient.Setup(x => x.UpdateEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment response = client.UpdateEnvironment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEnvironmentRequestObjectAsync()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateEnvironmentRequest request = new UpdateEnvironmentRequest
            {
                Environment = new Environment(),
                UpdateMask = new wkt::FieldMask(),
                AllowLoadToDraftAndDiscardChanges = true,
            };
            Environment expectedResponse = new Environment
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
                Description = "description2cf9da67",
                AgentVersionAsVersionName = VersionName.FromProjectVersion("[PROJECT]", "[VERSION]"),
                State = Environment.Types.State.Loading,
                UpdateTime = new wkt::Timestamp(),
                TextToSpeechSettings = new TextToSpeechSettings(),
                Fulfillment = new Fulfillment(),
            };
            mockGrpcClient.Setup(x => x.UpdateEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Environment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            Environment responseCallSettings = await client.UpdateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Environment responseCancellationToken = await client.UpdateEnvironmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEnvironmentRequestObject()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEnvironmentRequest request = new DeleteEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEnvironment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteEnvironment(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEnvironmentRequestObjectAsync()
        {
            moq::Mock<Environments.EnvironmentsClient> mockGrpcClient = new moq::Mock<Environments.EnvironmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteEnvironmentRequest request = new DeleteEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectEnvironment("[PROJECT]", "[ENVIRONMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteEnvironmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EnvironmentsClient client = new EnvironmentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteEnvironmentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
