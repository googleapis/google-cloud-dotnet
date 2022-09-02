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

namespace Google.Cloud.AssuredWorkloads.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssuredWorkloadsServiceClientTest
    {
        [xunit::FactAttribute]
        public void UpdateWorkloadRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new wkt::FieldMask(),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload response = client.UpdateWorkload(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkloadRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new wkt::FieldMask(),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workload>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload responseCallSettings = await client.UpdateWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workload responseCancellationToken = await client.UpdateWorkloadAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWorkload()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new wkt::FieldMask(),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload response = client.UpdateWorkload(request.Workload, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWorkloadAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new wkt::FieldMask(),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workload>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload responseCallSettings = await client.UpdateWorkloadAsync(request.Workload, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workload responseCancellationToken = await client.UpdateWorkloadAsync(request.Workload, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RestrictAllowedResourcesRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RestrictAllowedResourcesRequest request = new RestrictAllowedResourcesRequest
            {
                Name = "name1c9368b0",
                RestrictionType = RestrictAllowedResourcesRequest.Types.RestrictionType.Unspecified,
            };
            RestrictAllowedResourcesResponse expectedResponse = new RestrictAllowedResourcesResponse { };
            mockGrpcClient.Setup(x => x.RestrictAllowedResources(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            RestrictAllowedResourcesResponse response = client.RestrictAllowedResources(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RestrictAllowedResourcesRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RestrictAllowedResourcesRequest request = new RestrictAllowedResourcesRequest
            {
                Name = "name1c9368b0",
                RestrictionType = RestrictAllowedResourcesRequest.Types.RestrictionType.Unspecified,
            };
            RestrictAllowedResourcesResponse expectedResponse = new RestrictAllowedResourcesResponse { };
            mockGrpcClient.Setup(x => x.RestrictAllowedResourcesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RestrictAllowedResourcesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            RestrictAllowedResourcesResponse responseCallSettings = await client.RestrictAllowedResourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RestrictAllowedResourcesResponse responseCancellationToken = await client.RestrictAllowedResourcesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkloadRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkload(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkloadRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                Etag = "etage8ad7218",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkloadAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkload()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkload(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkloadAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkloadAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkloadAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWorkloadResourceNames()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteWorkload(request.WorkloadName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWorkloadResourceNamesAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteWorkloadAsync(request.WorkloadName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWorkloadAsync(request.WorkloadName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload response = client.GetWorkload(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workload>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload responseCallSettings = await client.GetWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workload responseCancellationToken = await client.GetWorkloadAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkload()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload response = client.GetWorkload(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workload>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload responseCallSettings = await client.GetWorkloadAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workload responseCancellationToken = await client.GetWorkloadAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkloadResourceNames()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkload(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload response = client.GetWorkload(request.WorkloadName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkloadResourceNamesAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            Workload expectedResponse = new Workload
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                DisplayName = "display_name137f65c2",
                Resources =
                {
                    new Workload.Types.ResourceInfo(),
                },
                ComplianceRegime = Workload.Types.ComplianceRegime.UsRegionalAccess,
                CreateTime = new wkt::Timestamp(),
                BillingAccount = "billing_account2062abb6",
#pragma warning disable CS0612
                Il4Settings = new Workload.Types.IL4Settings(),
                CjisSettings = new Workload.Types.CJISSettings(),
#pragma warning restore CS0612
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
#pragma warning disable CS0612
                FedrampHighSettings = new Workload.Types.FedrampHighSettings(),
                FedrampModerateSettings = new Workload.Types.FedrampModerateSettings(),
#pragma warning restore CS0612
                ProvisionedResourcesParent = "provisioned_resources_parent4d000dc9",
#pragma warning disable CS0612
                KmsSettings = new Workload.Types.KMSSettings(),
#pragma warning restore CS0612
                ResourceSettings =
                {
                    new Workload.Types.ResourceSettings(),
                },
                KajEnrollmentState = Workload.Types.KajEnrollmentState.Unspecified,
                EnableSovereignControls = true,
                SaaEnrollmentResponse = new Workload.Types.SaaEnrollmentResponse(),
                CompliantButDisallowedServices =
                {
                    "compliant_but_disallowed_services603cb12f",
                },
            };
            mockGrpcClient.Setup(x => x.GetWorkloadAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workload>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Workload responseCallSettings = await client.GetWorkloadAsync(request.WorkloadName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workload responseCancellationToken = await client.GetWorkloadAsync(request.WorkloadName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeWorkloadMoveRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeWorkloadMoveRequest request = new AnalyzeWorkloadMoveRequest
            {
                Source = "sourcef438cd36",
                Target = "targetaefbae42",
                Project = "projectaa6ff846",
            };
            AnalyzeWorkloadMoveResponse expectedResponse = new AnalyzeWorkloadMoveResponse
            {
                Blockers =
                {
                    "blockersd0e49d21",
                },
            };
            mockGrpcClient.Setup(x => x.AnalyzeWorkloadMove(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeWorkloadMoveResponse response = client.AnalyzeWorkloadMove(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeWorkloadMoveRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeWorkloadMoveRequest request = new AnalyzeWorkloadMoveRequest
            {
                Source = "sourcef438cd36",
                Target = "targetaefbae42",
                Project = "projectaa6ff846",
            };
            AnalyzeWorkloadMoveResponse expectedResponse = new AnalyzeWorkloadMoveResponse
            {
                Blockers =
                {
                    "blockersd0e49d21",
                },
            };
            mockGrpcClient.Setup(x => x.AnalyzeWorkloadMoveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeWorkloadMoveResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeWorkloadMoveResponse responseCallSettings = await client.AnalyzeWorkloadMoveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeWorkloadMoveResponse responseCancellationToken = await client.AnalyzeWorkloadMoveAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeWorkloadMove()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeWorkloadMoveRequest request = new AnalyzeWorkloadMoveRequest
            {
                Target = "targetaefbae42",
                Project = "projectaa6ff846",
            };
            AnalyzeWorkloadMoveResponse expectedResponse = new AnalyzeWorkloadMoveResponse
            {
                Blockers =
                {
                    "blockersd0e49d21",
                },
            };
            mockGrpcClient.Setup(x => x.AnalyzeWorkloadMove(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeWorkloadMoveResponse response = client.AnalyzeWorkloadMove(request.Project, request.Target);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeWorkloadMoveAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeWorkloadMoveRequest request = new AnalyzeWorkloadMoveRequest
            {
                Target = "targetaefbae42",
                Project = "projectaa6ff846",
            };
            AnalyzeWorkloadMoveResponse expectedResponse = new AnalyzeWorkloadMoveResponse
            {
                Blockers =
                {
                    "blockersd0e49d21",
                },
            };
            mockGrpcClient.Setup(x => x.AnalyzeWorkloadMoveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeWorkloadMoveResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeWorkloadMoveResponse responseCallSettings = await client.AnalyzeWorkloadMoveAsync(request.Project, request.Target, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeWorkloadMoveResponse responseCancellationToken = await client.AnalyzeWorkloadMoveAsync(request.Project, request.Target, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
