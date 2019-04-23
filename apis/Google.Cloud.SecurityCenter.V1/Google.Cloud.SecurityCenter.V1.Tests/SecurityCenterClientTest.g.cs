// Copyright 2019 Google LLC
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

namespace Google.Cloud.SecurityCenter.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.SecurityCenter.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedSecurityCenterClientTest
    {
        [Fact]
        public void CreateSource()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateSourceRequest expectedRequest = new CreateSourceRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateSource(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationName parent = new OrganizationName("[ORGANIZATION]");
            Source source = new Source();
            Source response = client.CreateSource(parent, source);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSourceAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateSourceRequest expectedRequest = new CreateSourceRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateSourceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Source>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationName parent = new OrganizationName("[ORGANIZATION]");
            Source source = new Source();
            Source response = await client.CreateSourceAsync(parent, source);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSource2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateSource(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.CreateSource(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSourceAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = new OrganizationName("[ORGANIZATION]"),
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.CreateSourceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Source>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = await client.CreateSourceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateFinding()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFindingRequest expectedRequest = new CreateFindingRequest
            {
                ParentAsSourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "findingId728776081",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent21175163357",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.CreateFinding(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName parent = new SourceName("[ORGANIZATION]", "[SOURCE]");
            string findingId = "findingId728776081";
            Finding finding = new Finding();
            Finding response = client.CreateFinding(parent, findingId, finding);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateFindingAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFindingRequest expectedRequest = new CreateFindingRequest
            {
                ParentAsSourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "findingId728776081",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent21175163357",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.CreateFindingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Finding>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName parent = new SourceName("[ORGANIZATION]", "[SOURCE]");
            string findingId = "findingId728776081";
            Finding finding = new Finding();
            Finding response = await client.CreateFindingAsync(parent, findingId, finding);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateFinding2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "findingId728776081",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent21175163357",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.CreateFinding(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.CreateFinding(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateFindingAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "findingId728776081",
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent21175163357",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.CreateFindingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Finding>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = await client.CreateFindingAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName resource = new SourceName("[ORGANIZATION]", "[SOURCE]");
            Policy response = client.GetIamPolicy(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName resource = new SourceName("[ORGANIZATION]", "[SOURCE]");
            Policy response = await client.GetIamPolicyAsync(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOrganizationSettings()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest expectedRequest = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = new OrganizationSettingsName("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name2-1052831874",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettingsName name = new OrganizationSettingsName("[ORGANIZATION]");
            OrganizationSettings response = client.GetOrganizationSettings(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOrganizationSettingsAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest expectedRequest = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = new OrganizationSettingsName("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name2-1052831874",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OrganizationSettings>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettingsName name = new OrganizationSettingsName("[ORGANIZATION]");
            OrganizationSettings response = await client.GetOrganizationSettingsAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOrganizationSettings2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = new OrganizationSettingsName("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name2-1052831874",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.GetOrganizationSettings(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOrganizationSettingsAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = new OrganizationSettingsName("[ORGANIZATION]"),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name2-1052831874",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.GetOrganizationSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OrganizationSettings>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = await client.GetOrganizationSettingsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSource()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSourceRequest expectedRequest = new GetSourceRequest
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSource(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName name = new SourceName("[ORGANIZATION]", "[SOURCE]");
            Source response = client.GetSource(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSourceAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSourceRequest expectedRequest = new GetSourceRequest
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Source>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName name = new SourceName("[ORGANIZATION]", "[SOURCE]");
            Source response = await client.GetSourceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSource2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSource(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSourceAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Source>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = await client.GetSourceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetFindingState()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetFindingStateRequest expectedRequest = new SetFindingStateRequest
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.SetFindingState(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            FindingName name = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            Finding response = client.SetFindingState(name, state, startTime);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetFindingStateAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetFindingStateRequest expectedRequest = new SetFindingStateRequest
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.SetFindingStateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Finding>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            FindingName name = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            Finding response = await client.SetFindingStateAsync(name, state, startTime);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetFindingState2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.SetFindingState(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.SetFindingState(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetFindingStateAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new Timestamp(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.SetFindingStateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Finding>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = await client.SetFindingStateAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName resource = new SourceName("[ORGANIZATION]", "[SOURCE]");
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName resource = new SourceName("[ORGANIZATION]", "[SOURCE]");
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName resource = new SourceName("[ORGANIZATION]", "[SOURCE]");
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SourceName resource = new SourceName("[ORGANIZATION]", "[SOURCE]");
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateFinding()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFindingRequest expectedRequest = new UpdateFindingRequest
            {
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.UpdateFinding(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding finding = new Finding();
            Finding response = client.UpdateFinding(finding);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateFindingAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFindingRequest expectedRequest = new UpdateFindingRequest
            {
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.UpdateFindingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Finding>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding finding = new Finding();
            Finding response = await client.UpdateFindingAsync(finding);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateFinding2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.UpdateFinding(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = client.UpdateFinding(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateFindingAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
            };
            Finding expectedResponse = new Finding
            {
                FindingName = new FindingName("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                Parent = "parent-995424086",
                ResourceName = "resourceName979421212",
                Category = "category50511102",
                ExternalUri = "externalUri-1385596168",
            };
            mockGrpcClient.Setup(x => x.UpdateFindingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Finding>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Finding response = await client.UpdateFindingAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateOrganizationSettings()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest expectedRequest = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name3373707",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings organizationSettings = new OrganizationSettings();
            OrganizationSettings response = client.UpdateOrganizationSettings(organizationSettings);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateOrganizationSettingsAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest expectedRequest = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name3373707",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OrganizationSettings>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings organizationSettings = new OrganizationSettings();
            OrganizationSettings response = await client.UpdateOrganizationSettingsAsync(organizationSettings);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateOrganizationSettings2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name3373707",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = client.UpdateOrganizationSettings(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateOrganizationSettingsAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
            };
            OrganizationSettings expectedResponse = new OrganizationSettings
            {
                Name = "name3373707",
                EnableAssetDiscovery = false,
            };
            mockGrpcClient.Setup(x => x.UpdateOrganizationSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OrganizationSettings>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            OrganizationSettings response = await client.UpdateOrganizationSettingsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSource()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSourceRequest expectedRequest = new UpdateSourceRequest
            {
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateSource(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source source = new Source();
            Source response = client.UpdateSource(source);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSourceAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSourceRequest expectedRequest = new UpdateSourceRequest
            {
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateSourceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Source>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source source = new Source();
            Source response = await client.UpdateSourceAsync(source);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSource2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateSource(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = client.UpdateSource(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSourceAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
            };
            Source expectedResponse = new Source
            {
                SourceName = new SourceName("[ORGANIZATION]", "[SOURCE]"),
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.UpdateSourceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Source>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            Source response = await client.UpdateSourceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSecurityMarks()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest expectedRequest = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarks(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks securityMarks = new SecurityMarks();
            SecurityMarks response = client.UpdateSecurityMarks(securityMarks);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSecurityMarksAsync()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest expectedRequest = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarksAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SecurityMarks>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks securityMarks = new SecurityMarks();
            SecurityMarks response = await client.UpdateSecurityMarksAsync(securityMarks);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSecurityMarks2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarks(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks response = client.UpdateSecurityMarks(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSecurityMarksAsync2()
        {
            Mock<SecurityCenter.SecurityCenterClient> mockGrpcClient = new Mock<SecurityCenter.SecurityCenterClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
            };
            SecurityMarks expectedResponse = new SecurityMarks
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateSecurityMarksAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SecurityMarks>(Task.FromResult(expectedResponse), null, null, null, null));
            SecurityCenterClient client = new SecurityCenterClientImpl(mockGrpcClient.Object, null);
            SecurityMarks response = await client.UpdateSecurityMarksAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
