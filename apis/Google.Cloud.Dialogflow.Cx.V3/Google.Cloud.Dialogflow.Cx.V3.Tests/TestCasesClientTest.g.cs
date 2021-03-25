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

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTestCasesClientTest
    {
        [xunit::FactAttribute]
        public void BatchDeleteTestCasesRequestObject()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteTestCases(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteTestCases(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteTestCasesRequestObjectAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCaseNames =
                {
                    TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteTestCasesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteTestCasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteTestCasesAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteTestCases()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteTestCases(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteTestCases(request.Parent);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteTestCasesAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteTestCasesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteTestCasesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteTestCasesAsync(request.Parent, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteTestCasesResourceNames()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteTestCases(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteTestCases(request.ParentAsAgentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteTestCasesResourceNamesAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteTestCasesRequest request = new BatchDeleteTestCasesRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteTestCasesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteTestCasesAsync(request.ParentAsAgentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteTestCasesAsync(request.ParentAsAgentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTestCaseRequestObject()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.GetTestCase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTestCaseRequestObjectAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.GetTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.GetTestCaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTestCase()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.GetTestCase(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTestCaseAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.GetTestCaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.GetTestCaseAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTestCaseResourceNames()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.GetTestCase(request.TestCaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTestCaseResourceNamesAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseRequest request = new GetTestCaseRequest
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.GetTestCaseAsync(request.TestCaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.GetTestCaseAsync(request.TestCaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTestCaseRequestObject()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.CreateTestCase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTestCaseRequestObjectAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.CreateTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.CreateTestCaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTestCase()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.CreateTestCase(request.Parent, request.TestCase);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTestCaseAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.CreateTestCaseAsync(request.Parent, request.TestCase, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.CreateTestCaseAsync(request.Parent, request.TestCase, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTestCaseResourceNames()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.CreateTestCase(request.ParentAsAgentName, request.TestCase);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTestCaseResourceNamesAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTestCaseRequest request = new CreateTestCaseRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                TestCase = new TestCase(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.CreateTestCaseAsync(request.ParentAsAgentName, request.TestCase, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.CreateTestCaseAsync(request.ParentAsAgentName, request.TestCase, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTestCaseRequestObject()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTestCaseRequest request = new UpdateTestCaseRequest
            {
                TestCase = new TestCase(),
                UpdateMask = new wkt::FieldMask(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.UpdateTestCase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTestCaseRequestObjectAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTestCaseRequest request = new UpdateTestCaseRequest
            {
                TestCase = new TestCase(),
                UpdateMask = new wkt::FieldMask(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.UpdateTestCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.UpdateTestCaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTestCase()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTestCaseRequest request = new UpdateTestCaseRequest
            {
                TestCase = new TestCase(),
                UpdateMask = new wkt::FieldMask(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTestCase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase response = client.UpdateTestCase(request.TestCase, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTestCaseAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateTestCaseRequest request = new UpdateTestCaseRequest
            {
                TestCase = new TestCase(),
                UpdateMask = new wkt::FieldMask(),
            };
            TestCase expectedResponse = new TestCase
            {
                TestCaseName = TestCaseName.FromProjectLocationAgentTestCase("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]"),
                Tags = { "tags52c47ad5", },
                DisplayName = "display_name137f65c2",
                Notes = "notes00b55843",
                TestCaseConversationTurns =
                {
                    new ConversationTurn(),
                },
                CreationTime = new wkt::Timestamp(),
                LastTestResult = new TestCaseResult(),
                TestConfig = new TestConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateTestCaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCase responseCallSettings = await client.UpdateTestCaseAsync(request.TestCase, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCase responseCancellationToken = await client.UpdateTestCaseAsync(request.TestCase, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateCoverageRequestObject()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateCoverageRequest request = new CalculateCoverageRequest
            {
                Type = CalculateCoverageRequest.Types.CoverageType.TransitionRouteGroup,
                AgentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            CalculateCoverageResponse expectedResponse = new CalculateCoverageResponse
            {
                IntentCoverage = new IntentCoverage(),
                TransitionCoverage = new TransitionCoverage(),
                AgentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                RouteGroupCoverage = new TransitionRouteGroupCoverage(),
            };
            mockGrpcClient.Setup(x => x.CalculateCoverage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            CalculateCoverageResponse response = client.CalculateCoverage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateCoverageRequestObjectAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateCoverageRequest request = new CalculateCoverageRequest
            {
                Type = CalculateCoverageRequest.Types.CoverageType.TransitionRouteGroup,
                AgentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            CalculateCoverageResponse expectedResponse = new CalculateCoverageResponse
            {
                IntentCoverage = new IntentCoverage(),
                TransitionCoverage = new TransitionCoverage(),
                AgentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                RouteGroupCoverage = new TransitionRouteGroupCoverage(),
            };
            mockGrpcClient.Setup(x => x.CalculateCoverageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateCoverageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            CalculateCoverageResponse responseCallSettings = await client.CalculateCoverageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateCoverageResponse responseCancellationToken = await client.CalculateCoverageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTestCaseResultRequestObject()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            TestCaseResult expectedResponse = new TestCaseResult
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                ConversationTurns =
                {
                    new ConversationTurn(),
                },
                TestResult = TestResult.Failed,
                TestTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCaseResult response = client.GetTestCaseResult(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTestCaseResultRequestObjectAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            TestCaseResult expectedResponse = new TestCaseResult
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                ConversationTurns =
                {
                    new ConversationTurn(),
                },
                TestResult = TestResult.Failed,
                TestTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCaseResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCaseResult responseCallSettings = await client.GetTestCaseResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCaseResult responseCancellationToken = await client.GetTestCaseResultAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTestCaseResult()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            TestCaseResult expectedResponse = new TestCaseResult
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                ConversationTurns =
                {
                    new ConversationTurn(),
                },
                TestResult = TestResult.Failed,
                TestTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCaseResult response = client.GetTestCaseResult(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTestCaseResultAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            TestCaseResult expectedResponse = new TestCaseResult
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                ConversationTurns =
                {
                    new ConversationTurn(),
                },
                TestResult = TestResult.Failed,
                TestTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCaseResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCaseResult responseCallSettings = await client.GetTestCaseResultAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCaseResult responseCancellationToken = await client.GetTestCaseResultAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTestCaseResultResourceNames()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            TestCaseResult expectedResponse = new TestCaseResult
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                ConversationTurns =
                {
                    new ConversationTurn(),
                },
                TestResult = TestResult.Failed,
                TestTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCaseResult response = client.GetTestCaseResult(request.TestCaseResultName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTestCaseResultResourceNamesAsync()
        {
            moq::Mock<TestCases.TestCasesClient> mockGrpcClient = new moq::Mock<TestCases.TestCasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTestCaseResultRequest request = new GetTestCaseResultRequest
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
            };
            TestCaseResult expectedResponse = new TestCaseResult
            {
                TestCaseResultName = TestCaseResultName.FromProjectLocationAgentTestCaseResult("[PROJECT]", "[LOCATION]", "[AGENT]", "[TEST_CASE]", "[RESULT]"),
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                ConversationTurns =
                {
                    new ConversationTurn(),
                },
                TestResult = TestResult.Failed,
                TestTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTestCaseResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestCaseResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TestCasesClient client = new TestCasesClientImpl(mockGrpcClient.Object, null);
            TestCaseResult responseCallSettings = await client.GetTestCaseResultAsync(request.TestCaseResultName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestCaseResult responseCancellationToken = await client.GetTestCaseResultAsync(request.TestCaseResultName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
