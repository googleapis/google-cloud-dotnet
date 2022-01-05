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
using gv = Grafeas.V1;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BinaryAuthorization.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedValidationHelperV1ClientTest
    {
        [xunit::FactAttribute]
        public void ValidateAttestationOccurrenceRequestObject()
        {
            moq::Mock<ValidationHelperV1.ValidationHelperV1Client> mockGrpcClient = new moq::Mock<ValidationHelperV1.ValidationHelperV1Client>(moq::MockBehavior.Strict);
            ValidateAttestationOccurrenceRequest request = new ValidateAttestationOccurrenceRequest
            {
                Attestor = "attestor3698a9e9",
                Attestation = new gv::AttestationOccurrence(),
                OccurrenceNote = "occurrence_note231a6c56",
                OccurrenceResourceUri = "occurrence_resource_uri7984be53",
            };
            ValidateAttestationOccurrenceResponse expectedResponse = new ValidateAttestationOccurrenceResponse
            {
                Result = ValidateAttestationOccurrenceResponse.Types.Result.AttestationNotVerifiable,
                DenialReason = "denial_reasona43b2694",
            };
            mockGrpcClient.Setup(x => x.ValidateAttestationOccurrence(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ValidationHelperV1Client client = new ValidationHelperV1ClientImpl(mockGrpcClient.Object, null);
            ValidateAttestationOccurrenceResponse response = client.ValidateAttestationOccurrence(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateAttestationOccurrenceRequestObjectAsync()
        {
            moq::Mock<ValidationHelperV1.ValidationHelperV1Client> mockGrpcClient = new moq::Mock<ValidationHelperV1.ValidationHelperV1Client>(moq::MockBehavior.Strict);
            ValidateAttestationOccurrenceRequest request = new ValidateAttestationOccurrenceRequest
            {
                Attestor = "attestor3698a9e9",
                Attestation = new gv::AttestationOccurrence(),
                OccurrenceNote = "occurrence_note231a6c56",
                OccurrenceResourceUri = "occurrence_resource_uri7984be53",
            };
            ValidateAttestationOccurrenceResponse expectedResponse = new ValidateAttestationOccurrenceResponse
            {
                Result = ValidateAttestationOccurrenceResponse.Types.Result.AttestationNotVerifiable,
                DenialReason = "denial_reasona43b2694",
            };
            mockGrpcClient.Setup(x => x.ValidateAttestationOccurrenceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateAttestationOccurrenceResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ValidationHelperV1Client client = new ValidationHelperV1ClientImpl(mockGrpcClient.Object, null);
            ValidateAttestationOccurrenceResponse responseCallSettings = await client.ValidateAttestationOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateAttestationOccurrenceResponse responseCancellationToken = await client.ValidateAttestationOccurrenceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
