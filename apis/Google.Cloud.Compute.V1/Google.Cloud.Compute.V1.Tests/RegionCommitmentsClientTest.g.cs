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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegionCommitmentsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Commitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Commitment responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment response = client.Get(request.Project, request.Region, request.Commitment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Commitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment responseCallSettings = await client.GetAsync(request.Project, request.Region, request.Commitment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Commitment responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.Commitment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
