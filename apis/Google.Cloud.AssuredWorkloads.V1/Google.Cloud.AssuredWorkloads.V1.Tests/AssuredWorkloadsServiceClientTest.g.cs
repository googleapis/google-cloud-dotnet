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

namespace Google.Cloud.AssuredWorkloads.V1.Tests
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
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
                Partner = Workload.Types.Partner.Unspecified,
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
        public void GetViolationRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            Violation expectedResponse = new Violation
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
                Description = "description2cf9da67",
                BeginTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ResolveTime = new wkt::Timestamp(),
                Category = "category2f35efc4",
                State = Violation.Types.State.Unresolved,
                OrgPolicyConstraint = "org_policy_constraint625da268",
                AuditLogLink = "audit_log_link4557fa87",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
                Remediation = new Violation.Types.Remediation(),
                Acknowledged = true,
                AcknowledgementTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetViolation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Violation response = client.GetViolation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViolationRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            Violation expectedResponse = new Violation
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
                Description = "description2cf9da67",
                BeginTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ResolveTime = new wkt::Timestamp(),
                Category = "category2f35efc4",
                State = Violation.Types.State.Unresolved,
                OrgPolicyConstraint = "org_policy_constraint625da268",
                AuditLogLink = "audit_log_link4557fa87",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
                Remediation = new Violation.Types.Remediation(),
                Acknowledged = true,
                AcknowledgementTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetViolationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Violation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Violation responseCallSettings = await client.GetViolationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Violation responseCancellationToken = await client.GetViolationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetViolation()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            Violation expectedResponse = new Violation
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
                Description = "description2cf9da67",
                BeginTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ResolveTime = new wkt::Timestamp(),
                Category = "category2f35efc4",
                State = Violation.Types.State.Unresolved,
                OrgPolicyConstraint = "org_policy_constraint625da268",
                AuditLogLink = "audit_log_link4557fa87",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
                Remediation = new Violation.Types.Remediation(),
                Acknowledged = true,
                AcknowledgementTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetViolation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Violation response = client.GetViolation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViolationAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            Violation expectedResponse = new Violation
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
                Description = "description2cf9da67",
                BeginTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ResolveTime = new wkt::Timestamp(),
                Category = "category2f35efc4",
                State = Violation.Types.State.Unresolved,
                OrgPolicyConstraint = "org_policy_constraint625da268",
                AuditLogLink = "audit_log_link4557fa87",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
                Remediation = new Violation.Types.Remediation(),
                Acknowledged = true,
                AcknowledgementTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetViolationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Violation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Violation responseCallSettings = await client.GetViolationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Violation responseCancellationToken = await client.GetViolationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetViolationResourceNames()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            Violation expectedResponse = new Violation
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
                Description = "description2cf9da67",
                BeginTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ResolveTime = new wkt::Timestamp(),
                Category = "category2f35efc4",
                State = Violation.Types.State.Unresolved,
                OrgPolicyConstraint = "org_policy_constraint625da268",
                AuditLogLink = "audit_log_link4557fa87",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
                Remediation = new Violation.Types.Remediation(),
                Acknowledged = true,
                AcknowledgementTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetViolation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Violation response = client.GetViolation(request.ViolationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViolationResourceNamesAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            Violation expectedResponse = new Violation
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
                Description = "description2cf9da67",
                BeginTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ResolveTime = new wkt::Timestamp(),
                Category = "category2f35efc4",
                State = Violation.Types.State.Unresolved,
                OrgPolicyConstraint = "org_policy_constraint625da268",
                AuditLogLink = "audit_log_link4557fa87",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
                Remediation = new Violation.Types.Remediation(),
                Acknowledged = true,
                AcknowledgementTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetViolationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Violation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            Violation responseCallSettings = await client.GetViolationAsync(request.ViolationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Violation responseCancellationToken = await client.GetViolationAsync(request.ViolationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AcknowledgeViolationRequestObject()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AcknowledgeViolationRequest request = new AcknowledgeViolationRequest
            {
                Name = "name1c9368b0",
                Comment = "comment63cdd406",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
            };
            AcknowledgeViolationResponse expectedResponse = new AcknowledgeViolationResponse { };
            mockGrpcClient.Setup(x => x.AcknowledgeViolation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            AcknowledgeViolationResponse response = client.AcknowledgeViolation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AcknowledgeViolationRequestObjectAsync()
        {
            moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient> mockGrpcClient = new moq::Mock<AssuredWorkloadsService.AssuredWorkloadsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AcknowledgeViolationRequest request = new AcknowledgeViolationRequest
            {
                Name = "name1c9368b0",
                Comment = "comment63cdd406",
                NonCompliantOrgPolicy = "non_compliant_org_policy7136e088",
            };
            AcknowledgeViolationResponse expectedResponse = new AcknowledgeViolationResponse { };
            mockGrpcClient.Setup(x => x.AcknowledgeViolationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcknowledgeViolationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssuredWorkloadsServiceClient client = new AssuredWorkloadsServiceClientImpl(mockGrpcClient.Object, null, null);
            AcknowledgeViolationResponse responseCallSettings = await client.AcknowledgeViolationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcknowledgeViolationResponse responseCancellationToken = await client.AcknowledgeViolationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
