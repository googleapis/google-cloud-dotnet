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

namespace Google.Cloud.Monitoring.V3.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Monitoring.V3;
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
    public class GeneratedServiceMonitoringServiceClientTest
    {
        [Fact]
        public void CreateService()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceRequest expectedRequest = new CreateServiceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateService(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Service service = new Service();
            Service response = client.CreateService(parent, service);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateServiceAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceRequest expectedRequest = new CreateServiceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Service>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Service service = new Service();
            Service response = await client.CreateServiceAsync(parent, service);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateService2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateService(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.CreateService(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateServiceAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateServiceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Service>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = await client.CreateServiceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetService()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceRequest expectedRequest = new GetServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetService(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            Service response = client.GetService(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetServiceAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceRequest expectedRequest = new GetServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Service>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            Service response = await client.GetServiceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetService2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetService(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.GetService(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetServiceAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Service>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = await client.GetServiceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateService()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceRequest expectedRequest = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateService(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service service = new Service();
            Service response = client.UpdateService(service);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateServiceAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceRequest expectedRequest = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Service>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service service = new Service();
            Service response = await client.UpdateServiceAsync(service);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateService2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateService(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = client.UpdateService(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateServiceAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            Service expectedResponse = new Service
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.UpdateServiceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Service>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            Service response = await client.UpdateServiceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteService()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceRequest expectedRequest = new DeleteServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteService(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            client.DeleteService(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteServiceAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceRequest expectedRequest = new DeleteServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            await client.DeleteServiceAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteService2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteService(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteService(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteServiceAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteServiceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateServiceLevelObjective()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest expectedRequest = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjective(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceName parent = new ServiceName("[PROJECT]", "[SERVICE]");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            ServiceLevelObjective response = client.CreateServiceLevelObjective(parent, serviceLevelObjective);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateServiceLevelObjectiveAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest expectedRequest = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjectiveAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServiceLevelObjective>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceName parent = new ServiceName("[PROJECT]", "[SERVICE]");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            ServiceLevelObjective response = await client.CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateServiceLevelObjective2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjective(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.CreateServiceLevelObjective(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateServiceLevelObjectiveAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.CreateServiceLevelObjectiveAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServiceLevelObjective>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = await client.CreateServiceLevelObjectiveAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetServiceLevelObjective()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceLevelObjectiveRequest expectedRequest = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjective(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            ServiceLevelObjective response = client.GetServiceLevelObjective(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetServiceLevelObjectiveAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceLevelObjectiveRequest expectedRequest = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjectiveAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServiceLevelObjective>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            ServiceLevelObjective response = await client.GetServiceLevelObjectiveAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetServiceLevelObjective2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjective(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.GetServiceLevelObjective(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetServiceLevelObjectiveAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.GetServiceLevelObjectiveAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServiceLevelObjective>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = await client.GetServiceLevelObjectiveAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateServiceLevelObjective()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest expectedRequest = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjective(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            ServiceLevelObjective response = client.UpdateServiceLevelObjective(serviceLevelObjective);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateServiceLevelObjectiveAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest expectedRequest = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjectiveAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServiceLevelObjective>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            ServiceLevelObjective response = await client.UpdateServiceLevelObjectiveAsync(serviceLevelObjective);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateServiceLevelObjective2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjective(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = client.UpdateServiceLevelObjective(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateServiceLevelObjectiveAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            ServiceLevelObjective expectedResponse = new ServiceLevelObjective
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                DisplayName = "displayName1615086568",
                Goal = 317825.0,
            };
            mockGrpcClient.Setup(x => x.UpdateServiceLevelObjectiveAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServiceLevelObjective>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjective response = await client.UpdateServiceLevelObjectiveAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteServiceLevelObjective()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest expectedRequest = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjective(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            client.DeleteServiceLevelObjective(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteServiceLevelObjectiveAsync()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest expectedRequest = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjectiveAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            await client.DeleteServiceLevelObjectiveAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteServiceLevelObjective2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjective(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteServiceLevelObjective(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteServiceLevelObjectiveAsync2()
        {
            Mock<ServiceMonitoringService.ServiceMonitoringServiceClient> mockGrpcClient = new Mock<ServiceMonitoringService.ServiceMonitoringServiceClient>(MockBehavior.Strict);
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteServiceLevelObjectiveAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ServiceMonitoringServiceClient client = new ServiceMonitoringServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteServiceLevelObjectiveAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
