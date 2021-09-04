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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.OsConfig.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOsConfigZonalServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetInventoryRequestObject()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            Inventory response = client.GetInventory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInventoryRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            Inventory response = client.GetInventory(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInventoryAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            Inventory response = client.GetInventory(request.InventoryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInventoryResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            VulnerabilityReport response = client.GetVulnerabilityReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityReportRequestObjectAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            VulnerabilityReport response = client.GetVulnerabilityReport(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityReportAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            VulnerabilityReport response = client.GetVulnerabilityReport(request.VulnerabilityReportName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetVulnerabilityReportResourceNamesAsync()
        {
            moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient> mockGrpcClient = new moq::Mock<OsConfigZonalService.OsConfigZonalServiceClient>(moq::MockBehavior.Strict);
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
            OsConfigZonalServiceClient client = new OsConfigZonalServiceClientImpl(mockGrpcClient.Object, null);
            VulnerabilityReport responseCallSettings = await client.GetVulnerabilityReportAsync(request.VulnerabilityReportName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VulnerabilityReport responseCancellationToken = await client.GetVulnerabilityReportAsync(request.VulnerabilityReportName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
