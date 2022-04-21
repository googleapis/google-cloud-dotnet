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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.OsConfig.V1Alpha.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOsConfigZonalServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetOSPolicyAssignmentRequestObject()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            OSPolicyAssignment expectedResponse = new OSPolicyAssignment
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                Description = "description2cf9da67",
                OsPolicies = { new OSPolicy(), },
                InstanceFilter = new OSPolicyAssignment.Types.InstanceFilter(),
                Rollout = new OSPolicyAssignment.Types.Rollout(),
                RevisionId = "revision_id8d9ae05d",
                RevisionCreateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RolloutState = OSPolicyAssignment.Types.RolloutState.Cancelling,
                Baseline = false,
                Deleted = true,
                Reconciling = false,
                Uid = "uida2d37198",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignment response = client.GetOSPolicyAssignment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOSPolicyAssignmentRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            OSPolicyAssignment expectedResponse = new OSPolicyAssignment
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                Description = "description2cf9da67",
                OsPolicies = { new OSPolicy(), },
                InstanceFilter = new OSPolicyAssignment.Types.InstanceFilter(),
                Rollout = new OSPolicyAssignment.Types.Rollout(),
                RevisionId = "revision_id8d9ae05d",
                RevisionCreateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RolloutState = OSPolicyAssignment.Types.RolloutState.Cancelling,
                Baseline = false,
                Deleted = true,
                Reconciling = false,
                Uid = "uida2d37198",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OSPolicyAssignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignment responseCallSettings = await client.GetOSPolicyAssignmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OSPolicyAssignment responseCancellationToken = await client.GetOSPolicyAssignmentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOSPolicyAssignment()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            OSPolicyAssignment expectedResponse = new OSPolicyAssignment
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                Description = "description2cf9da67",
                OsPolicies = { new OSPolicy(), },
                InstanceFilter = new OSPolicyAssignment.Types.InstanceFilter(),
                Rollout = new OSPolicyAssignment.Types.Rollout(),
                RevisionId = "revision_id8d9ae05d",
                RevisionCreateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RolloutState = OSPolicyAssignment.Types.RolloutState.Cancelling,
                Baseline = false,
                Deleted = true,
                Reconciling = false,
                Uid = "uida2d37198",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignment response = client.GetOSPolicyAssignment(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOSPolicyAssignmentAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            OSPolicyAssignment expectedResponse = new OSPolicyAssignment
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                Description = "description2cf9da67",
                OsPolicies = { new OSPolicy(), },
                InstanceFilter = new OSPolicyAssignment.Types.InstanceFilter(),
                Rollout = new OSPolicyAssignment.Types.Rollout(),
                RevisionId = "revision_id8d9ae05d",
                RevisionCreateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RolloutState = OSPolicyAssignment.Types.RolloutState.Cancelling,
                Baseline = false,
                Deleted = true,
                Reconciling = false,
                Uid = "uida2d37198",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OSPolicyAssignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignment responseCallSettings = await client.GetOSPolicyAssignmentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OSPolicyAssignment responseCancellationToken = await client.GetOSPolicyAssignmentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOSPolicyAssignmentResourceNames()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            OSPolicyAssignment expectedResponse = new OSPolicyAssignment
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                Description = "description2cf9da67",
                OsPolicies = { new OSPolicy(), },
                InstanceFilter = new OSPolicyAssignment.Types.InstanceFilter(),
                Rollout = new OSPolicyAssignment.Types.Rollout(),
                RevisionId = "revision_id8d9ae05d",
                RevisionCreateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RolloutState = OSPolicyAssignment.Types.RolloutState.Cancelling,
                Baseline = false,
                Deleted = true,
                Reconciling = false,
                Uid = "uida2d37198",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignment response = client.GetOSPolicyAssignment(request.OSPolicyAssignmentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOSPolicyAssignmentResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentRequest request = new GetOSPolicyAssignmentRequest
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
            };
            OSPolicyAssignment expectedResponse = new OSPolicyAssignment
            {
                OSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                Description = "description2cf9da67",
                OsPolicies = { new OSPolicy(), },
                InstanceFilter = new OSPolicyAssignment.Types.InstanceFilter(),
                Rollout = new OSPolicyAssignment.Types.Rollout(),
                RevisionId = "revision_id8d9ae05d",
                RevisionCreateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RolloutState = OSPolicyAssignment.Types.RolloutState.Cancelling,
                Baseline = false,
                Deleted = true,
                Reconciling = false,
                Uid = "uida2d37198",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OSPolicyAssignment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignment responseCallSettings = await client.GetOSPolicyAssignmentAsync(request.OSPolicyAssignmentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OSPolicyAssignment responseCancellationToken = await client.GetOSPolicyAssignmentAsync(request.OSPolicyAssignmentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceOSPoliciesComplianceRequestObject()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance expectedResponse = new InstanceOSPoliciesCompliance
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Instance = "instance99a62371",
                State = OSPolicyComplianceState.Unknown,
                DetailedState = "detailed_state6d8e814a",
                DetailedStateReason = "detailed_state_reason493b0c87",
                OsPolicyCompliances =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InstanceOSPoliciesCompliance.Types.OSPolicyCompliance(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                LastComplianceCheckTime = new wkt::Timestamp(),
                LastComplianceRunId = "last_compliance_run_id45f5c46a",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetInstanceOSPoliciesCompliance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = client.GetInstanceOSPoliciesCompliance(request);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceOSPoliciesComplianceRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance expectedResponse = new InstanceOSPoliciesCompliance
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Instance = "instance99a62371",
                State = OSPolicyComplianceState.Unknown,
                DetailedState = "detailed_state6d8e814a",
                DetailedStateReason = "detailed_state_reason493b0c87",
                OsPolicyCompliances =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InstanceOSPoliciesCompliance.Types.OSPolicyCompliance(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                LastComplianceCheckTime = new wkt::Timestamp(),
                LastComplianceRunId = "last_compliance_run_id45f5c46a",
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            mockGrpcClient.Setup(x => x.GetInstanceOSPoliciesComplianceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceOSPoliciesCompliance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
#pragma warning restore CS0612
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance responseCallSettings = await client.GetInstanceOSPoliciesComplianceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance responseCancellationToken = await client.GetInstanceOSPoliciesComplianceAsync(request, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceOSPoliciesCompliance()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance expectedResponse = new InstanceOSPoliciesCompliance
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Instance = "instance99a62371",
                State = OSPolicyComplianceState.Unknown,
                DetailedState = "detailed_state6d8e814a",
                DetailedStateReason = "detailed_state_reason493b0c87",
                OsPolicyCompliances =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InstanceOSPoliciesCompliance.Types.OSPolicyCompliance(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                LastComplianceCheckTime = new wkt::Timestamp(),
                LastComplianceRunId = "last_compliance_run_id45f5c46a",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetInstanceOSPoliciesCompliance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = client.GetInstanceOSPoliciesCompliance(request.Name);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceOSPoliciesComplianceAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance expectedResponse = new InstanceOSPoliciesCompliance
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Instance = "instance99a62371",
                State = OSPolicyComplianceState.Unknown,
                DetailedState = "detailed_state6d8e814a",
                DetailedStateReason = "detailed_state_reason493b0c87",
                OsPolicyCompliances =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InstanceOSPoliciesCompliance.Types.OSPolicyCompliance(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                LastComplianceCheckTime = new wkt::Timestamp(),
                LastComplianceRunId = "last_compliance_run_id45f5c46a",
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            mockGrpcClient.Setup(x => x.GetInstanceOSPoliciesComplianceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceOSPoliciesCompliance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
#pragma warning restore CS0612
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance responseCallSettings = await client.GetInstanceOSPoliciesComplianceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance responseCancellationToken = await client.GetInstanceOSPoliciesComplianceAsync(request.Name, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceOSPoliciesComplianceResourceNames()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance expectedResponse = new InstanceOSPoliciesCompliance
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Instance = "instance99a62371",
                State = OSPolicyComplianceState.Unknown,
                DetailedState = "detailed_state6d8e814a",
                DetailedStateReason = "detailed_state_reason493b0c87",
                OsPolicyCompliances =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InstanceOSPoliciesCompliance.Types.OSPolicyCompliance(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                LastComplianceCheckTime = new wkt::Timestamp(),
                LastComplianceRunId = "last_compliance_run_id45f5c46a",
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetInstanceOSPoliciesCompliance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance response = client.GetInstanceOSPoliciesCompliance(request.InstanceOSPoliciesComplianceName);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceOSPoliciesComplianceResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
#pragma warning disable CS0612
            GetInstanceOSPoliciesComplianceRequest request = new GetInstanceOSPoliciesComplianceRequest
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance expectedResponse = new InstanceOSPoliciesCompliance
#pragma warning restore CS0612
            {
#pragma warning disable CS0612
                InstanceOSPoliciesComplianceName = InstanceOSPoliciesComplianceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Instance = "instance99a62371",
                State = OSPolicyComplianceState.Unknown,
                DetailedState = "detailed_state6d8e814a",
                DetailedStateReason = "detailed_state_reason493b0c87",
                OsPolicyCompliances =
#pragma warning restore CS0612
                {
#pragma warning disable CS0612
                    new InstanceOSPoliciesCompliance.Types.OSPolicyCompliance(),
#pragma warning restore CS0612
                },
#pragma warning disable CS0612
                LastComplianceCheckTime = new wkt::Timestamp(),
                LastComplianceRunId = "last_compliance_run_id45f5c46a",
#pragma warning restore CS0612
            };
#pragma warning disable CS0612
            mockGrpcClient.Setup(x => x.GetInstanceOSPoliciesComplianceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceOSPoliciesCompliance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
#pragma warning restore CS0612
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance responseCallSettings = await client.GetInstanceOSPoliciesComplianceAsync(request.InstanceOSPoliciesComplianceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCallSettings);
#pragma warning disable CS0612
            InstanceOSPoliciesCompliance responseCancellationToken = await client.GetInstanceOSPoliciesComplianceAsync(request.InstanceOSPoliciesComplianceName, st::CancellationToken.None);
#pragma warning restore CS0612
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOSPolicyAssignmentReportRequestObject()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            OSPolicyAssignmentReport expectedResponse = new OSPolicyAssignmentReport
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Instance = "instance99a62371",
                OsPolicyAssignmentAsOSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                OsPolicyCompliances =
                {
                    new OSPolicyAssignmentReport.Types.OSPolicyCompliance(),
                },
                UpdateTime = new wkt::Timestamp(),
                LastRunId = "last_run_ida47e4da8",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignmentReport response = client.GetOSPolicyAssignmentReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOSPolicyAssignmentReportRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            OSPolicyAssignmentReport expectedResponse = new OSPolicyAssignmentReport
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Instance = "instance99a62371",
                OsPolicyAssignmentAsOSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                OsPolicyCompliances =
                {
                    new OSPolicyAssignmentReport.Types.OSPolicyCompliance(),
                },
                UpdateTime = new wkt::Timestamp(),
                LastRunId = "last_run_ida47e4da8",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OSPolicyAssignmentReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignmentReport responseCallSettings = await client.GetOSPolicyAssignmentReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OSPolicyAssignmentReport responseCancellationToken = await client.GetOSPolicyAssignmentReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOSPolicyAssignmentReport()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            OSPolicyAssignmentReport expectedResponse = new OSPolicyAssignmentReport
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Instance = "instance99a62371",
                OsPolicyAssignmentAsOSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                OsPolicyCompliances =
                {
                    new OSPolicyAssignmentReport.Types.OSPolicyCompliance(),
                },
                UpdateTime = new wkt::Timestamp(),
                LastRunId = "last_run_ida47e4da8",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignmentReport response = client.GetOSPolicyAssignmentReport(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOSPolicyAssignmentReportAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            OSPolicyAssignmentReport expectedResponse = new OSPolicyAssignmentReport
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Instance = "instance99a62371",
                OsPolicyAssignmentAsOSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                OsPolicyCompliances =
                {
                    new OSPolicyAssignmentReport.Types.OSPolicyCompliance(),
                },
                UpdateTime = new wkt::Timestamp(),
                LastRunId = "last_run_ida47e4da8",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OSPolicyAssignmentReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignmentReport responseCallSettings = await client.GetOSPolicyAssignmentReportAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OSPolicyAssignmentReport responseCancellationToken = await client.GetOSPolicyAssignmentReportAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetOSPolicyAssignmentReportResourceNames()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            OSPolicyAssignmentReport expectedResponse = new OSPolicyAssignmentReport
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Instance = "instance99a62371",
                OsPolicyAssignmentAsOSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                OsPolicyCompliances =
                {
                    new OSPolicyAssignmentReport.Types.OSPolicyCompliance(),
                },
                UpdateTime = new wkt::Timestamp(),
                LastRunId = "last_run_ida47e4da8",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignmentReport response = client.GetOSPolicyAssignmentReport(request.OSPolicyAssignmentReportName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetOSPolicyAssignmentReportResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOSPolicyAssignmentReportRequest request = new GetOSPolicyAssignmentReportRequest
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
            };
            OSPolicyAssignmentReport expectedResponse = new OSPolicyAssignmentReport
            {
                OSPolicyAssignmentReportName = OSPolicyAssignmentReportName.FromProjectLocationInstanceAssignment("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[ASSIGNMENT]"),
                Instance = "instance99a62371",
                OsPolicyAssignmentAsOSPolicyAssignmentName = OSPolicyAssignmentName.FromProjectLocationOsPolicyAssignment("[PROJECT]", "[LOCATION]", "[OS_POLICY_ASSIGNMENT]"),
                OsPolicyCompliances =
                {
                    new OSPolicyAssignmentReport.Types.OSPolicyCompliance(),
                },
                UpdateTime = new wkt::Timestamp(),
                LastRunId = "last_run_ida47e4da8",
            };
            mockGrpcClient.Setup(x => x.GetOSPolicyAssignmentReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OSPolicyAssignmentReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            OSPolicyAssignmentReport responseCallSettings = await client.GetOSPolicyAssignmentReportAsync(request.OSPolicyAssignmentReportName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OSPolicyAssignmentReport responseCancellationToken = await client.GetOSPolicyAssignmentReportAsync(request.OSPolicyAssignmentReportName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInventoryRequestObject()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Basic,
            };
            Inventory expectedResponse = new Inventory
            {
                OsInfo = new Inventory.Types.OsInfo(),
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new Inventory.Types.Item()
                    },
                },
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            Inventory response = client.GetInventory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInventoryRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Basic,
            };
            Inventory expectedResponse = new Inventory
            {
                OsInfo = new Inventory.Types.OsInfo(),
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new Inventory.Types.Item()
                    },
                },
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Inventory>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            Inventory responseCallSettings = await client.GetInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Inventory responseCancellationToken = await client.GetInventoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInventory()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Inventory expectedResponse = new Inventory
            {
                OsInfo = new Inventory.Types.OsInfo(),
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new Inventory.Types.Item()
                    },
                },
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            Inventory response = client.GetInventory(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInventoryAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Inventory expectedResponse = new Inventory
            {
                OsInfo = new Inventory.Types.OsInfo(),
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new Inventory.Types.Item()
                    },
                },
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Inventory>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            Inventory responseCallSettings = await client.GetInventoryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Inventory responseCancellationToken = await client.GetInventoryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInventoryResourceNames()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Inventory expectedResponse = new Inventory
            {
                OsInfo = new Inventory.Types.OsInfo(),
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new Inventory.Types.Item()
                    },
                },
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            Inventory response = client.GetInventory(request.InventoryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInventoryResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            Inventory expectedResponse = new Inventory
            {
                OsInfo = new Inventory.Types.OsInfo(),
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new Inventory.Types.Item()
                    },
                },
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Inventory>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            Inventory responseCallSettings = await client.GetInventoryAsync(request.InventoryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Inventory responseCancellationToken = await client.GetInventoryAsync(request.InventoryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVulnerabilityReportRequestObject()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            VulnerabilityReport expectedResponse = new VulnerabilityReport
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Vulnerabilities =
                {
                    new VulnerabilityReport.Types.Vulnerability(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            VulnerabilityReport response = client.GetVulnerabilityReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityReportRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            VulnerabilityReport expectedResponse = new VulnerabilityReport
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Vulnerabilities =
                {
                    new VulnerabilityReport.Types.Vulnerability(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VulnerabilityReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            VulnerabilityReport responseCallSettings = await client.GetVulnerabilityReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityReport responseCancellationToken = await client.GetVulnerabilityReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVulnerabilityReport()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            VulnerabilityReport expectedResponse = new VulnerabilityReport
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Vulnerabilities =
                {
                    new VulnerabilityReport.Types.Vulnerability(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            VulnerabilityReport response = client.GetVulnerabilityReport(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityReportAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            VulnerabilityReport expectedResponse = new VulnerabilityReport
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Vulnerabilities =
                {
                    new VulnerabilityReport.Types.Vulnerability(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VulnerabilityReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            VulnerabilityReport responseCallSettings = await client.GetVulnerabilityReportAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityReport responseCancellationToken = await client.GetVulnerabilityReportAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetVulnerabilityReportResourceNames()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            VulnerabilityReport expectedResponse = new VulnerabilityReport
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Vulnerabilities =
                {
                    new VulnerabilityReport.Types.Vulnerability(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            VulnerabilityReport response = client.GetVulnerabilityReport(request.VulnerabilityReportName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityReportResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            VulnerabilityReport expectedResponse = new VulnerabilityReport
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Vulnerabilities =
                {
                    new VulnerabilityReport.Types.Vulnerability(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetVulnerabilityReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VulnerabilityReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null, null);
            VulnerabilityReport responseCallSettings = await client.GetVulnerabilityReportAsync(request.VulnerabilityReportName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityReport responseCancellationToken = await client.GetVulnerabilityReportAsync(request.VulnerabilityReportName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
