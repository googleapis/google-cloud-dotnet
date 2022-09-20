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
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Maps.AddressValidation.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAddressValidationClientTest
    {
        [xunit::FactAttribute]
        public void ValidateAddressRequestObject()
        {
            moq::Mock<AddressValidation.AddressValidationClient> mockGrpcClient = new moq::Mock<AddressValidation.AddressValidationClient>(moq::MockBehavior.Strict);
            ValidateAddressRequest request = new ValidateAddressRequest
            {
                Address = new gt::PostalAddress(),
                PreviousResponseId = "previous_response_id7c2f1b3a",
                EnableUspsCass = true,
            };
            ValidateAddressResponse expectedResponse = new ValidateAddressResponse
            {
                Result = new ValidationResult(),
                ResponseId = "response_id17f822e1",
            };
            mockGrpcClient.Setup(x => x.ValidateAddress(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AddressValidationClient client = new AddressValidationClientImpl(mockGrpcClient.Object, null, null);
            ValidateAddressResponse response = client.ValidateAddress(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateAddressRequestObjectAsync()
        {
            moq::Mock<AddressValidation.AddressValidationClient> mockGrpcClient = new moq::Mock<AddressValidation.AddressValidationClient>(moq::MockBehavior.Strict);
            ValidateAddressRequest request = new ValidateAddressRequest
            {
                Address = new gt::PostalAddress(),
                PreviousResponseId = "previous_response_id7c2f1b3a",
                EnableUspsCass = true,
            };
            ValidateAddressResponse expectedResponse = new ValidateAddressResponse
            {
                Result = new ValidationResult(),
                ResponseId = "response_id17f822e1",
            };
            mockGrpcClient.Setup(x => x.ValidateAddressAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateAddressResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AddressValidationClient client = new AddressValidationClientImpl(mockGrpcClient.Object, null, null);
            ValidateAddressResponse responseCallSettings = await client.ValidateAddressAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateAddressResponse responseCancellationToken = await client.ValidateAddressAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ProvideValidationFeedbackRequestObject()
        {
            moq::Mock<AddressValidation.AddressValidationClient> mockGrpcClient = new moq::Mock<AddressValidation.AddressValidationClient>(moq::MockBehavior.Strict);
            ProvideValidationFeedbackRequest request = new ProvideValidationFeedbackRequest
            {
                Conclusion = ProvideValidationFeedbackRequest.Types.ValidationConclusion.UnvalidatedVersionUsed,
                ResponseId = "response_id17f822e1",
            };
            ProvideValidationFeedbackResponse expectedResponse = new ProvideValidationFeedbackResponse { };
            mockGrpcClient.Setup(x => x.ProvideValidationFeedback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AddressValidationClient client = new AddressValidationClientImpl(mockGrpcClient.Object, null, null);
            ProvideValidationFeedbackResponse response = client.ProvideValidationFeedback(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProvideValidationFeedbackRequestObjectAsync()
        {
            moq::Mock<AddressValidation.AddressValidationClient> mockGrpcClient = new moq::Mock<AddressValidation.AddressValidationClient>(moq::MockBehavior.Strict);
            ProvideValidationFeedbackRequest request = new ProvideValidationFeedbackRequest
            {
                Conclusion = ProvideValidationFeedbackRequest.Types.ValidationConclusion.UnvalidatedVersionUsed,
                ResponseId = "response_id17f822e1",
            };
            ProvideValidationFeedbackResponse expectedResponse = new ProvideValidationFeedbackResponse { };
            mockGrpcClient.Setup(x => x.ProvideValidationFeedbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ProvideValidationFeedbackResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AddressValidationClient client = new AddressValidationClientImpl(mockGrpcClient.Object, null, null);
            ProvideValidationFeedbackResponse responseCallSettings = await client.ProvideValidationFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ProvideValidationFeedbackResponse responseCancellationToken = await client.ProvideValidationFeedbackAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
