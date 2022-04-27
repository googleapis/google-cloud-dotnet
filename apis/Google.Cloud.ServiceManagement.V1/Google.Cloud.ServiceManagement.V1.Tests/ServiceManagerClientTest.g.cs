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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ServiceManagement.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedServiceManagerClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = "service_named5df05d5",
            };
            ManagedService expectedResponse = new ManagedService
            {
                ServiceName = "service_named5df05d5",
                ProducerProjectId = "producer_project_id18d0012a",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ManagedService response = client.GetService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = "service_named5df05d5",
            };
            ManagedService expectedResponse = new ManagedService
            {
                ServiceName = "service_named5df05d5",
                ProducerProjectId = "producer_project_id18d0012a",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ManagedService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ManagedService responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ManagedService responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetService()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = "service_named5df05d5",
            };
            ManagedService expectedResponse = new ManagedService
            {
                ServiceName = "service_named5df05d5",
                ProducerProjectId = "producer_project_id18d0012a",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ManagedService response = client.GetService(request.ServiceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = "service_named5df05d5",
            };
            ManagedService expectedResponse = new ManagedService
            {
                ServiceName = "service_named5df05d5",
                ProducerProjectId = "producer_project_id18d0012a",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ManagedService>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ManagedService responseCallSettings = await client.GetServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ManagedService responseCancellationToken = await client.GetServiceAsync(request.ServiceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceConfigRequestObject()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceConfigRequest request = new GetServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ConfigId = "config_id908a73d1",
                View = GetServiceConfigRequest.Types.ConfigView.Full,
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetServiceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service response = client.GetServiceConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceConfigRequestObjectAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceConfigRequest request = new GetServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ConfigId = "config_id908a73d1",
                View = GetServiceConfigRequest.Types.ConfigView.Full,
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetServiceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service responseCallSettings = await client.GetServiceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::Service responseCancellationToken = await client.GetServiceConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceConfig()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceConfigRequest request = new GetServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ConfigId = "config_id908a73d1",
                View = GetServiceConfigRequest.Types.ConfigView.Full,
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetServiceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service response = client.GetServiceConfig(request.ServiceName, request.ConfigId, request.View);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceConfigAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceConfigRequest request = new GetServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ConfigId = "config_id908a73d1",
                View = GetServiceConfigRequest.Types.ConfigView.Full,
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetServiceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service responseCallSettings = await client.GetServiceConfigAsync(request.ServiceName, request.ConfigId, request.View, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::Service responseCancellationToken = await client.GetServiceConfigAsync(request.ServiceName, request.ConfigId, request.View, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceConfigRequestObject()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateServiceConfigRequest request = new CreateServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ServiceConfig = new ga::Service(),
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service response = client.CreateServiceConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceConfigRequestObjectAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateServiceConfigRequest request = new CreateServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ServiceConfig = new ga::Service(),
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service responseCallSettings = await client.CreateServiceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::Service responseCancellationToken = await client.CreateServiceConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceConfig()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateServiceConfigRequest request = new CreateServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ServiceConfig = new ga::Service(),
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service response = client.CreateServiceConfig(request.ServiceName, request.ServiceConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceConfigAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateServiceConfigRequest request = new CreateServiceConfigRequest
            {
                ServiceName = "service_named5df05d5",
                ServiceConfig = new ga::Service(),
            };
            ga::Service expectedResponse = new ga::Service
            {
                Name = "name1c9368b0",
                Title = "title17dbd3d5",
                Apis = { new wkt::Api(), },
                Types_ = { new wkt::Type(), },
                Enums = { new wkt::Enum(), },
                Documentation = new ga::Documentation(),
                Backend = new ga::Backend(),
                Http = new ga::Http(),
                Quota = new ga::Quota(),
                Authentication = new ga::Authentication(),
                Context = new ga::Context(),
                Usage = new ga::Usage(),
                Endpoints = { new ga::Endpoint(), },
#pragma warning disable CS0612
                ConfigVersion = 2430367190U,
#pragma warning restore CS0612
                Control = new ga::Control(),
                ProducerProjectId = "producer_project_id18d0012a",
                Logs =
                {
                    new ga::LogDescriptor(),
                },
                Metrics =
                {
                    new ga::MetricDescriptor(),
                },
                MonitoredResources =
                {
                    new ga::MonitoredResourceDescriptor(),
                },
                Billing = new ga::Billing(),
                Logging = new ga::Logging(),
                Monitoring = new ga::Monitoring(),
                SystemParameters = new ga::SystemParameters(),
                Id = "id74b70bb8",
                SourceInfo = new ga::SourceInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateServiceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            ga::Service responseCallSettings = await client.CreateServiceConfigAsync(request.ServiceName, request.ServiceConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::Service responseCancellationToken = await client.CreateServiceConfigAsync(request.ServiceName, request.ServiceConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceRolloutRequestObject()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "service_named5df05d5",
                RolloutId = "rollout_id174e7821",
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutId = "rollout_id174e7821",
                CreateTime = new wkt::Timestamp(),
                CreatedBy = "created_by206bd4da",
                Status = Rollout.Types.RolloutStatus.Cancelled,
                TrafficPercentStrategy = new Rollout.Types.TrafficPercentStrategy(),
                ServiceName = "service_named5df05d5",
                DeleteServiceStrategy = new Rollout.Types.DeleteServiceStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetServiceRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            Rollout response = client.GetServiceRollout(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRolloutRequestObjectAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "service_named5df05d5",
                RolloutId = "rollout_id174e7821",
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutId = "rollout_id174e7821",
                CreateTime = new wkt::Timestamp(),
                CreatedBy = "created_by206bd4da",
                Status = Rollout.Types.RolloutStatus.Cancelled,
                TrafficPercentStrategy = new Rollout.Types.TrafficPercentStrategy(),
                ServiceName = "service_named5df05d5",
                DeleteServiceStrategy = new Rollout.Types.DeleteServiceStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetServiceRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Rollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            Rollout responseCallSettings = await client.GetServiceRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Rollout responseCancellationToken = await client.GetServiceRolloutAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceRollout()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "service_named5df05d5",
                RolloutId = "rollout_id174e7821",
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutId = "rollout_id174e7821",
                CreateTime = new wkt::Timestamp(),
                CreatedBy = "created_by206bd4da",
                Status = Rollout.Types.RolloutStatus.Cancelled,
                TrafficPercentStrategy = new Rollout.Types.TrafficPercentStrategy(),
                ServiceName = "service_named5df05d5",
                DeleteServiceStrategy = new Rollout.Types.DeleteServiceStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetServiceRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            Rollout response = client.GetServiceRollout(request.ServiceName, request.RolloutId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRolloutAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "service_named5df05d5",
                RolloutId = "rollout_id174e7821",
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutId = "rollout_id174e7821",
                CreateTime = new wkt::Timestamp(),
                CreatedBy = "created_by206bd4da",
                Status = Rollout.Types.RolloutStatus.Cancelled,
                TrafficPercentStrategy = new Rollout.Types.TrafficPercentStrategy(),
                ServiceName = "service_named5df05d5",
                DeleteServiceStrategy = new Rollout.Types.DeleteServiceStrategy(),
            };
            mockGrpcClient.Setup(x => x.GetServiceRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Rollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            Rollout responseCallSettings = await client.GetServiceRolloutAsync(request.ServiceName, request.RolloutId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Rollout responseCancellationToken = await client.GetServiceRolloutAsync(request.ServiceName, request.RolloutId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConfigReportRequestObject()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConfigReportRequest request = new GenerateConfigReportRequest
            {
                NewConfig = new wkt::Any(),
                OldConfig = new wkt::Any(),
            };
            GenerateConfigReportResponse expectedResponse = new GenerateConfigReportResponse
            {
                ServiceName = "service_named5df05d5",
                Id = "id74b70bb8",
                ChangeReports = { new ChangeReport(), },
                Diagnostics = { new Diagnostic(), },
            };
            mockGrpcClient.Setup(x => x.GenerateConfigReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            GenerateConfigReportResponse response = client.GenerateConfigReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConfigReportRequestObjectAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConfigReportRequest request = new GenerateConfigReportRequest
            {
                NewConfig = new wkt::Any(),
                OldConfig = new wkt::Any(),
            };
            GenerateConfigReportResponse expectedResponse = new GenerateConfigReportResponse
            {
                ServiceName = "service_named5df05d5",
                Id = "id74b70bb8",
                ChangeReports = { new ChangeReport(), },
                Diagnostics = { new Diagnostic(), },
            };
            mockGrpcClient.Setup(x => x.GenerateConfigReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConfigReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            GenerateConfigReportResponse responseCallSettings = await client.GenerateConfigReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConfigReportResponse responseCancellationToken = await client.GenerateConfigReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConfigReport()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConfigReportRequest request = new GenerateConfigReportRequest
            {
                NewConfig = new wkt::Any(),
                OldConfig = new wkt::Any(),
            };
            GenerateConfigReportResponse expectedResponse = new GenerateConfigReportResponse
            {
                ServiceName = "service_named5df05d5",
                Id = "id74b70bb8",
                ChangeReports = { new ChangeReport(), },
                Diagnostics = { new Diagnostic(), },
            };
            mockGrpcClient.Setup(x => x.GenerateConfigReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            GenerateConfigReportResponse response = client.GenerateConfigReport(request.NewConfig, request.OldConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConfigReportAsync()
        {
            moq::Mock<ServiceManager.ServiceManagerClient> mockGrpcClient = new moq::Mock<ServiceManager.ServiceManagerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConfigReportRequest request = new GenerateConfigReportRequest
            {
                NewConfig = new wkt::Any(),
                OldConfig = new wkt::Any(),
            };
            GenerateConfigReportResponse expectedResponse = new GenerateConfigReportResponse
            {
                ServiceName = "service_named5df05d5",
                Id = "id74b70bb8",
                ChangeReports = { new ChangeReport(), },
                Diagnostics = { new Diagnostic(), },
            };
            mockGrpcClient.Setup(x => x.GenerateConfigReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConfigReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceManagerClient client = new ServiceManagerClientImpl(mockGrpcClient.Object, null, null);
            GenerateConfigReportResponse responseCallSettings = await client.GenerateConfigReportAsync(request.NewConfig, request.OldConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConfigReportResponse responseCancellationToken = await client.GenerateConfigReportAsync(request.NewConfig, request.OldConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
