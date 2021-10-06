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
    public sealed class GeneratedProjectsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProjectRequest request = new GetProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProjectRequest request = new GetProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Project>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Project responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProjectRequest request = new GetProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project response = client.Get(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetProjectRequest request = new GetProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Project>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project responseCallSettings = await client.GetAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Project responseCancellationToken = await client.GetAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetXpnHostRequestObject()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetXpnHostProjectRequest request = new GetXpnHostProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.GetXpnHost(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project response = client.GetXpnHost(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetXpnHostRequestObjectAsync()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetXpnHostProjectRequest request = new GetXpnHostProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.GetXpnHostAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Project>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project responseCallSettings = await client.GetXpnHostAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Project responseCancellationToken = await client.GetXpnHostAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetXpnHost()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetXpnHostProjectRequest request = new GetXpnHostProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.GetXpnHost(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project response = client.GetXpnHost(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetXpnHostAsync()
        {
            moq::Mock<Projects.ProjectsClient> mockGrpcClient = new moq::Mock<Projects.ProjectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetXpnHostProjectRequest request = new GetXpnHostProjectRequest
            {
                Project = "projectaa6ff846",
            };
            Project expectedResponse = new Project
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Quotas = { new Quota(), },
                CommonInstanceMetadata = new Metadata(),
                XpnProjectStatus = Project.Types.XpnProjectStatus.Host,
                DefaultServiceAccount = "default_service_accountdf12b0f2",
                UsageExportLocation = new UsageExportLocation(),
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                DefaultNetworkTier = Project.Types.DefaultNetworkTier.Premium,
            };
            mockGrpcClient.Setup(x => x.GetXpnHostAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Project>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProjectsClient client = new ProjectsClientImpl(mockGrpcClient.Object, null);
            Project responseCallSettings = await client.GetXpnHostAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Project responseCancellationToken = await client.GetXpnHostAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
