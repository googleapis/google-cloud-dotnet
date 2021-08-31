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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Monitoring.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedServiceMonitoringServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateServiceRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
                ServiceId = "service_id291edcb0",
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
                ServiceId = "service_id291edcb0",
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateService()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.Parent, request.Service);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.Parent, request.Service, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.Parent, request.Service, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceResourceNames1()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.ParentAsProjectName, request.Service);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceResourceNames1Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.ParentAsProjectName, request.Service, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.ParentAsProjectName, request.Service, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceResourceNames2()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.ParentAsOrganizationName, request.Service);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceResourceNames2Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.ParentAsOrganizationName, request.Service, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.ParentAsOrganizationName, request.Service, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceResourceNames3()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.ParentAsFolderName, request.Service);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceResourceNames3Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.ParentAsFolderName, request.Service, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.ParentAsFolderName, request.Service, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceResourceNames4()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request.ParentAsResourceName, request.Service);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceResourceNames4Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.CreateServiceAsync(request.ParentAsResourceName, request.Service, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.CreateServiceAsync(request.ParentAsResourceName, request.Service, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetService()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceResourceNames1()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request.ServiceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceResourceNames1Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.ServiceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceResourceNames2()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceResourceNames2Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.GetServiceAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServiceRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new wkt::FieldMask(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.UpdateService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new wkt::FieldMask(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.UpdateServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateService()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.UpdateService(request.Service);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                DisplayName = "display_name137f65c2",
                Custom = new Service.Types.Custom(),
                AppEngine = new Service.Types.AppEngine(),
                CloudEndpoints = new Service.Types.CloudEndpoints(),
                ClusterIstio = new Service.Types.ClusterIstio(),
                MeshIstio = new Service.Types.MeshIstio(),
                IstioCanonicalService = new Service.Types.IstioCanonicalService(),
                Telemetry = new Service.Types.Telemetry(),
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service responseCallSettings = await client.UpdateServiceAsync(request.Service, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.UpdateServiceAsync(request.Service, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteService()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceResourceNames1()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request.ServiceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceResourceNames1Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request.ServiceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request.ServiceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceResourceNames2()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceResourceNames2Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceLevelObjectiveRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
                ServiceLevelObjectiveId = "service_level_objective_ideb3a3c26",
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.CreateServiceLevelObjective(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceLevelObjectiveRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
                ServiceLevelObjectiveId = "service_level_objective_ideb3a3c26",
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.CreateServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.CreateServiceLevelObjectiveAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceLevelObjective()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.CreateServiceLevelObjective(request.Parent, request.ServiceLevelObjective);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceLevelObjectiveAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.CreateServiceLevelObjectiveAsync(request.Parent, request.ServiceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.CreateServiceLevelObjectiveAsync(request.Parent, request.ServiceLevelObjective, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceLevelObjectiveResourceNames1()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.CreateServiceLevelObjective(request.ParentAsServiceName, request.ServiceLevelObjective);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceLevelObjectiveResourceNames1Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.CreateServiceLevelObjectiveAsync(request.ParentAsServiceName, request.ServiceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.CreateServiceLevelObjectiveAsync(request.ParentAsServiceName, request.ServiceLevelObjective, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateServiceLevelObjectiveResourceNames2()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.CreateServiceLevelObjective(request.ParentAsResourceName, request.ServiceLevelObjective);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateServiceLevelObjectiveResourceNames2Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.CreateServiceLevelObjectiveAsync(request.ParentAsResourceName, request.ServiceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.CreateServiceLevelObjectiveAsync(request.ParentAsResourceName, request.ServiceLevelObjective, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceLevelObjectiveRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                View = ServiceLevelObjective.Types.View.Full,
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.GetServiceLevelObjective(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceLevelObjectiveRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                View = ServiceLevelObjective.Types.View.Full,
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.GetServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.GetServiceLevelObjectiveAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceLevelObjective()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.GetServiceLevelObjective(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceLevelObjectiveAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.GetServiceLevelObjectiveAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.GetServiceLevelObjectiveAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceLevelObjectiveResourceNames1()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.GetServiceLevelObjective(request.ServiceLevelObjectiveName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceLevelObjectiveResourceNames1Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.GetServiceLevelObjectiveAsync(request.ServiceLevelObjectiveName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.GetServiceLevelObjectiveAsync(request.ServiceLevelObjectiveName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetServiceLevelObjectiveResourceNames2()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.GetServiceLevelObjective(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceLevelObjectiveResourceNames2Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.GetServiceLevelObjectiveAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.GetServiceLevelObjectiveAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServiceLevelObjectiveRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.UpdateServiceLevelObjective(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceLevelObjectiveRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
                UpdateMask = new wkt::FieldMask(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.UpdateServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.UpdateServiceLevelObjectiveAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateServiceLevelObjective()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.UpdateServiceLevelObjective(request.ServiceLevelObjective);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateServiceLevelObjectiveAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                ServiceLevelIndicator = new ServiceLevelIndicator(),
                Goal = 9.545268003330255E+17,
                RollingPeriod = new wkt::Duration(),
                CalendarPeriod = gt::CalendarPeriod.Month,
                DisplayName = "display_name137f65c2",
                UserLabels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ServiceLevelObjective>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective responseCallSettings = await client.UpdateServiceLevelObjectiveAsync(request.ServiceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ServiceLevelObjective responseCancellationToken = await client.UpdateServiceLevelObjectiveAsync(request.ServiceLevelObjective, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceLevelObjectiveRequestObject()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceLevelObjective(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceLevelObjectiveRequestObjectAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceLevelObjectiveAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceLevelObjective()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceLevelObjective(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceLevelObjectiveAsync()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceLevelObjectiveAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceLevelObjectiveAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceLevelObjectiveResourceNames1()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceLevelObjective(request.ServiceLevelObjectiveName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceLevelObjectiveResourceNames1Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceLevelObjectiveAsync(request.ServiceLevelObjectiveName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceLevelObjectiveAsync(request.ServiceLevelObjectiveName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteServiceLevelObjectiveResourceNames2()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjective(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceLevelObjective(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteServiceLevelObjectiveResourceNames2Async()
        {
            moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new moq::Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(moq::MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjectiveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceLevelObjectiveAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteServiceLevelObjectiveAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
