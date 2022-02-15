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

namespace Google.Cloud.AccessApproval.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccessApprovalClientTest
    {
        [xunit::FactAttribute]
        public void GetApprovalRequestRequestObject()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetApprovalRequest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest response = client.GetApprovalRequest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApprovalRequestRequestObjectAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetApprovalRequestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApprovalRequest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest responseCallSettings = await client.GetApprovalRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApprovalRequest responseCancellationToken = await client.GetApprovalRequestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApprovalRequest()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetApprovalRequest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest response = client.GetApprovalRequest(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApprovalRequestAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetApprovalRequestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApprovalRequest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest responseCallSettings = await client.GetApprovalRequestAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApprovalRequest responseCancellationToken = await client.GetApprovalRequestAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetApprovalRequestResourceNames()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetApprovalRequest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest response = client.GetApprovalRequest(request.ApprovalRequestName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetApprovalRequestResourceNamesAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetApprovalRequestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApprovalRequest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest responseCallSettings = await client.GetApprovalRequestAsync(request.ApprovalRequestName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApprovalRequest responseCancellationToken = await client.GetApprovalRequestAsync(request.ApprovalRequestName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApproveApprovalRequestRequestObject()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            ApproveApprovalRequestMessage request = new ApproveApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                ExpireTime = new wkt::Timestamp(),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.ApproveApprovalRequest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest response = client.ApproveApprovalRequest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApproveApprovalRequestRequestObjectAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            ApproveApprovalRequestMessage request = new ApproveApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                ExpireTime = new wkt::Timestamp(),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.ApproveApprovalRequestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApprovalRequest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest responseCallSettings = await client.ApproveApprovalRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApprovalRequest responseCancellationToken = await client.ApproveApprovalRequestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DismissApprovalRequestRequestObject()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DismissApprovalRequestMessage request = new DismissApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.DismissApprovalRequest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest response = client.DismissApprovalRequest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DismissApprovalRequestRequestObjectAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DismissApprovalRequestMessage request = new DismissApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            ApprovalRequest expectedResponse = new ApprovalRequest
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                RequestedResourceName = "requested_resource_name3898f866",
                RequestedReason = new AccessReason(),
                RequestedLocations = new AccessLocations(),
                RequestTime = new wkt::Timestamp(),
                RequestedExpiration = new wkt::Timestamp(),
                Approve = new ApproveDecision(),
                Dismiss = new DismissDecision(),
                RequestedResourceProperties = new ResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.DismissApprovalRequestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApprovalRequest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            ApprovalRequest responseCallSettings = await client.DismissApprovalRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApprovalRequest responseCancellationToken = await client.DismissApprovalRequestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessApprovalSettingsRequestObject()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.GetAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings response = client.GetAccessApprovalSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessApprovalSettingsRequestObjectAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.GetAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessApprovalSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings responseCallSettings = await client.GetAccessApprovalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessApprovalSettings responseCancellationToken = await client.GetAccessApprovalSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessApprovalSettings()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.GetAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings response = client.GetAccessApprovalSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessApprovalSettingsAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.GetAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessApprovalSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings responseCallSettings = await client.GetAccessApprovalSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessApprovalSettings responseCancellationToken = await client.GetAccessApprovalSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAccessApprovalSettingsResourceNames()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.GetAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings response = client.GetAccessApprovalSettings(request.AccessApprovalSettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAccessApprovalSettingsResourceNamesAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.GetAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessApprovalSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings responseCallSettings = await client.GetAccessApprovalSettingsAsync(request.AccessApprovalSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessApprovalSettings responseCancellationToken = await client.GetAccessApprovalSettingsAsync(request.AccessApprovalSettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAccessApprovalSettingsRequestObject()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings response = client.UpdateAccessApprovalSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAccessApprovalSettingsRequestObjectAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessApprovalSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings responseCallSettings = await client.UpdateAccessApprovalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessApprovalSettings responseCancellationToken = await client.UpdateAccessApprovalSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAccessApprovalSettings()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings response = client.UpdateAccessApprovalSettings(request.Settings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAccessApprovalSettingsAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            AccessApprovalSettings expectedResponse = new AccessApprovalSettings
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
                NotificationEmails =
                {
                    "notification_emails936d0793",
                },
                EnrolledServices =
                {
                    new EnrolledService(),
                },
                EnrolledAncestor = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AccessApprovalSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            AccessApprovalSettings responseCallSettings = await client.UpdateAccessApprovalSettingsAsync(request.Settings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AccessApprovalSettings responseCancellationToken = await client.UpdateAccessApprovalSettingsAsync(request.Settings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccessApprovalSettingsRequestObject()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            client.DeleteAccessApprovalSettings(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccessApprovalSettingsRequestObjectAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAccessApprovalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAccessApprovalSettingsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccessApprovalSettings()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            client.DeleteAccessApprovalSettings(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccessApprovalSettingsAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAccessApprovalSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAccessApprovalSettingsAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAccessApprovalSettingsResourceNames()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccessApprovalSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            client.DeleteAccessApprovalSettings(request.AccessApprovalSettingsName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAccessApprovalSettingsResourceNamesAsync()
        {
            moq::Mock<AccessApproval.AccessApprovalClient> mockGrpcClient = new moq::Mock<AccessApproval.AccessApprovalClient>(moq::MockBehavior.Strict);
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAccessApprovalSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessApprovalClient client = new AccessApprovalClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAccessApprovalSettingsAsync(request.AccessApprovalSettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAccessApprovalSettingsAsync(request.AccessApprovalSettingsName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
