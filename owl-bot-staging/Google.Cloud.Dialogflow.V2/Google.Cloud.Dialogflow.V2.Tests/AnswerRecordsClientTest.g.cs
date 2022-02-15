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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAnswerRecordsClientTest
    {
        [xunit::FactAttribute]
        public void UpdateAnswerRecordRequestObject()
        {
            moq::Mock<AnswerRecords.AnswerRecordsClient> mockGrpcClient = new moq::Mock<AnswerRecords.AnswerRecordsClient>(moq::MockBehavior.Strict);
            UpdateAnswerRecordRequest request = new UpdateAnswerRecordRequest
            {
                AnswerRecord = new AnswerRecord(),
                UpdateMask = new wkt::FieldMask(),
            };
            AnswerRecord expectedResponse = new AnswerRecord
            {
                AnswerRecordName = AnswerRecordName.FromProjectAnswerRecord("[PROJECT]", "[ANSWER_RECORD]"),
                AnswerFeedback = new AnswerFeedback(),
                AgentAssistantRecord = new AgentAssistantRecord(),
            };
            mockGrpcClient.Setup(x => x.UpdateAnswerRecord(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnswerRecordsClient client = new AnswerRecordsClientImpl(mockGrpcClient.Object, null);
            AnswerRecord response = client.UpdateAnswerRecord(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAnswerRecordRequestObjectAsync()
        {
            moq::Mock<AnswerRecords.AnswerRecordsClient> mockGrpcClient = new moq::Mock<AnswerRecords.AnswerRecordsClient>(moq::MockBehavior.Strict);
            UpdateAnswerRecordRequest request = new UpdateAnswerRecordRequest
            {
                AnswerRecord = new AnswerRecord(),
                UpdateMask = new wkt::FieldMask(),
            };
            AnswerRecord expectedResponse = new AnswerRecord
            {
                AnswerRecordName = AnswerRecordName.FromProjectAnswerRecord("[PROJECT]", "[ANSWER_RECORD]"),
                AnswerFeedback = new AnswerFeedback(),
                AgentAssistantRecord = new AgentAssistantRecord(),
            };
            mockGrpcClient.Setup(x => x.UpdateAnswerRecordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnswerRecord>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnswerRecordsClient client = new AnswerRecordsClientImpl(mockGrpcClient.Object, null);
            AnswerRecord responseCallSettings = await client.UpdateAnswerRecordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnswerRecord responseCancellationToken = await client.UpdateAnswerRecordAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAnswerRecord()
        {
            moq::Mock<AnswerRecords.AnswerRecordsClient> mockGrpcClient = new moq::Mock<AnswerRecords.AnswerRecordsClient>(moq::MockBehavior.Strict);
            UpdateAnswerRecordRequest request = new UpdateAnswerRecordRequest
            {
                AnswerRecord = new AnswerRecord(),
                UpdateMask = new wkt::FieldMask(),
            };
            AnswerRecord expectedResponse = new AnswerRecord
            {
                AnswerRecordName = AnswerRecordName.FromProjectAnswerRecord("[PROJECT]", "[ANSWER_RECORD]"),
                AnswerFeedback = new AnswerFeedback(),
                AgentAssistantRecord = new AgentAssistantRecord(),
            };
            mockGrpcClient.Setup(x => x.UpdateAnswerRecord(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AnswerRecordsClient client = new AnswerRecordsClientImpl(mockGrpcClient.Object, null);
            AnswerRecord response = client.UpdateAnswerRecord(request.AnswerRecord, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAnswerRecordAsync()
        {
            moq::Mock<AnswerRecords.AnswerRecordsClient> mockGrpcClient = new moq::Mock<AnswerRecords.AnswerRecordsClient>(moq::MockBehavior.Strict);
            UpdateAnswerRecordRequest request = new UpdateAnswerRecordRequest
            {
                AnswerRecord = new AnswerRecord(),
                UpdateMask = new wkt::FieldMask(),
            };
            AnswerRecord expectedResponse = new AnswerRecord
            {
                AnswerRecordName = AnswerRecordName.FromProjectAnswerRecord("[PROJECT]", "[ANSWER_RECORD]"),
                AnswerFeedback = new AnswerFeedback(),
                AgentAssistantRecord = new AgentAssistantRecord(),
            };
            mockGrpcClient.Setup(x => x.UpdateAnswerRecordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnswerRecord>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AnswerRecordsClient client = new AnswerRecordsClientImpl(mockGrpcClient.Object, null);
            AnswerRecord responseCallSettings = await client.UpdateAnswerRecordAsync(request.AnswerRecord, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnswerRecord responseCancellationToken = await client.UpdateAnswerRecordAsync(request.AnswerRecord, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
