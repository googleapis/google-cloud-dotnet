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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.VMMigration.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVmMigrationClientTest
    {
        [xunit::FactAttribute]
        public void GetSourceRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Vmware = new VmwareSourceDetails(),
            };
            mockGrpcClient.Setup(x => x.GetSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSourceRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Vmware = new VmwareSourceDetails(),
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.GetSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.GetSourceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSource()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Vmware = new VmwareSourceDetails(),
            };
            mockGrpcClient.Setup(x => x.GetSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSourceAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Vmware = new VmwareSourceDetails(),
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.GetSourceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.GetSourceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSourceResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Vmware = new VmwareSourceDetails(),
            };
            mockGrpcClient.Setup(x => x.GetSource(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Source response = client.GetSource(request.SourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSourceResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            Source expectedResponse = new Source
            {
                SourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Description = "description2cf9da67",
                Vmware = new VmwareSourceDetails(),
            };
            mockGrpcClient.Setup(x => x.GetSourceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Source>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Source responseCallSettings = await client.GetSourceAsync(request.SourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Source responseCancellationToken = await client.GetSourceAsync(request.SourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchInventoryRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                ForceRefresh = false,
            };
            FetchInventoryResponse expectedResponse = new FetchInventoryResponse
            {
                VmwareVms = new VmwareVmsDetails(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.FetchInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            FetchInventoryResponse response = client.FetchInventory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchInventoryRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
                ForceRefresh = false,
            };
            FetchInventoryResponse expectedResponse = new FetchInventoryResponse
            {
                VmwareVms = new VmwareVmsDetails(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.FetchInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchInventoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            FetchInventoryResponse responseCallSettings = await client.FetchInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchInventoryResponse responseCancellationToken = await client.FetchInventoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchInventory()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            FetchInventoryResponse expectedResponse = new FetchInventoryResponse
            {
                VmwareVms = new VmwareVmsDetails(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.FetchInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            FetchInventoryResponse response = client.FetchInventory(request.Source);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchInventoryAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            FetchInventoryResponse expectedResponse = new FetchInventoryResponse
            {
                VmwareVms = new VmwareVmsDetails(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.FetchInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchInventoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            FetchInventoryResponse responseCallSettings = await client.FetchInventoryAsync(request.Source, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchInventoryResponse responseCancellationToken = await client.FetchInventoryAsync(request.Source, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FetchInventoryResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            FetchInventoryResponse expectedResponse = new FetchInventoryResponse
            {
                VmwareVms = new VmwareVmsDetails(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.FetchInventory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            FetchInventoryResponse response = client.FetchInventory(request.SourceAsSourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FetchInventoryResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            FetchInventoryRequest request = new FetchInventoryRequest
            {
                SourceAsSourceName = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]"),
            };
            FetchInventoryResponse expectedResponse = new FetchInventoryResponse
            {
                VmwareVms = new VmwareVmsDetails(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.FetchInventoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FetchInventoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            FetchInventoryResponse responseCallSettings = await client.FetchInventoryAsync(request.SourceAsSourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FetchInventoryResponse responseCancellationToken = await client.FetchInventoryAsync(request.SourceAsSourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUtilizationReportRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                View = UtilizationReportView.Basic,
            };
            UtilizationReport expectedResponse = new UtilizationReport
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                DisplayName = "display_name137f65c2",
                State = UtilizationReport.Types.State.Succeeded,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                TimeFrame = UtilizationReport.Types.TimeFrame.Week,
                FrameEndTime = new wkt::Timestamp(),
                VmCount = -459841681,
                Vms =
                {
                    new VmUtilizationInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUtilizationReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            UtilizationReport response = client.GetUtilizationReport(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUtilizationReportRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                View = UtilizationReportView.Basic,
            };
            UtilizationReport expectedResponse = new UtilizationReport
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                DisplayName = "display_name137f65c2",
                State = UtilizationReport.Types.State.Succeeded,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                TimeFrame = UtilizationReport.Types.TimeFrame.Week,
                FrameEndTime = new wkt::Timestamp(),
                VmCount = -459841681,
                Vms =
                {
                    new VmUtilizationInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUtilizationReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UtilizationReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            UtilizationReport responseCallSettings = await client.GetUtilizationReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UtilizationReport responseCancellationToken = await client.GetUtilizationReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUtilizationReport()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
            };
            UtilizationReport expectedResponse = new UtilizationReport
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                DisplayName = "display_name137f65c2",
                State = UtilizationReport.Types.State.Succeeded,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                TimeFrame = UtilizationReport.Types.TimeFrame.Week,
                FrameEndTime = new wkt::Timestamp(),
                VmCount = -459841681,
                Vms =
                {
                    new VmUtilizationInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUtilizationReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            UtilizationReport response = client.GetUtilizationReport(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUtilizationReportAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
            };
            UtilizationReport expectedResponse = new UtilizationReport
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                DisplayName = "display_name137f65c2",
                State = UtilizationReport.Types.State.Succeeded,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                TimeFrame = UtilizationReport.Types.TimeFrame.Week,
                FrameEndTime = new wkt::Timestamp(),
                VmCount = -459841681,
                Vms =
                {
                    new VmUtilizationInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUtilizationReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UtilizationReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            UtilizationReport responseCallSettings = await client.GetUtilizationReportAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UtilizationReport responseCancellationToken = await client.GetUtilizationReportAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetUtilizationReportResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
            };
            UtilizationReport expectedResponse = new UtilizationReport
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                DisplayName = "display_name137f65c2",
                State = UtilizationReport.Types.State.Succeeded,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                TimeFrame = UtilizationReport.Types.TimeFrame.Week,
                FrameEndTime = new wkt::Timestamp(),
                VmCount = -459841681,
                Vms =
                {
                    new VmUtilizationInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUtilizationReport(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            UtilizationReport response = client.GetUtilizationReport(request.UtilizationReportName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetUtilizationReportResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetUtilizationReportRequest request = new GetUtilizationReportRequest
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
            };
            UtilizationReport expectedResponse = new UtilizationReport
            {
                UtilizationReportName = UtilizationReportName.FromProjectLocationSourceUtilizationReport("[PROJECT]", "[LOCATION]", "[SOURCE]", "[UTILIZATION_REPORT]"),
                DisplayName = "display_name137f65c2",
                State = UtilizationReport.Types.State.Succeeded,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                CreateTime = new wkt::Timestamp(),
                TimeFrame = UtilizationReport.Types.TimeFrame.Week,
                FrameEndTime = new wkt::Timestamp(),
                VmCount = -459841681,
                Vms =
                {
                    new VmUtilizationInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUtilizationReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UtilizationReport>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            UtilizationReport responseCallSettings = await client.GetUtilizationReportAsync(request.UtilizationReportName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UtilizationReport responseCancellationToken = await client.GetUtilizationReportAsync(request.UtilizationReportName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatacenterConnectorRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            DatacenterConnector expectedResponse = new DatacenterConnector
            {
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                ServiceAccount = "service_accounta3c1b923",
                Version = "version102ff72a",
                State = DatacenterConnector.Types.State.Failed,
                StateTime = new wkt::Timestamp(),
                Bucket = "bucket17d0bfc2",
                Error = new gr::Status(),
                RegistrationId = "registration_ided27f5d9",
            };
            mockGrpcClient.Setup(x => x.GetDatacenterConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            DatacenterConnector response = client.GetDatacenterConnector(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatacenterConnectorRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            DatacenterConnector expectedResponse = new DatacenterConnector
            {
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                ServiceAccount = "service_accounta3c1b923",
                Version = "version102ff72a",
                State = DatacenterConnector.Types.State.Failed,
                StateTime = new wkt::Timestamp(),
                Bucket = "bucket17d0bfc2",
                Error = new gr::Status(),
                RegistrationId = "registration_ided27f5d9",
            };
            mockGrpcClient.Setup(x => x.GetDatacenterConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DatacenterConnector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            DatacenterConnector responseCallSettings = await client.GetDatacenterConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DatacenterConnector responseCancellationToken = await client.GetDatacenterConnectorAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatacenterConnector()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            DatacenterConnector expectedResponse = new DatacenterConnector
            {
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                ServiceAccount = "service_accounta3c1b923",
                Version = "version102ff72a",
                State = DatacenterConnector.Types.State.Failed,
                StateTime = new wkt::Timestamp(),
                Bucket = "bucket17d0bfc2",
                Error = new gr::Status(),
                RegistrationId = "registration_ided27f5d9",
            };
            mockGrpcClient.Setup(x => x.GetDatacenterConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            DatacenterConnector response = client.GetDatacenterConnector(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatacenterConnectorAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            DatacenterConnector expectedResponse = new DatacenterConnector
            {
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                ServiceAccount = "service_accounta3c1b923",
                Version = "version102ff72a",
                State = DatacenterConnector.Types.State.Failed,
                StateTime = new wkt::Timestamp(),
                Bucket = "bucket17d0bfc2",
                Error = new gr::Status(),
                RegistrationId = "registration_ided27f5d9",
            };
            mockGrpcClient.Setup(x => x.GetDatacenterConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DatacenterConnector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            DatacenterConnector responseCallSettings = await client.GetDatacenterConnectorAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DatacenterConnector responseCancellationToken = await client.GetDatacenterConnectorAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatacenterConnectorResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            DatacenterConnector expectedResponse = new DatacenterConnector
            {
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                ServiceAccount = "service_accounta3c1b923",
                Version = "version102ff72a",
                State = DatacenterConnector.Types.State.Failed,
                StateTime = new wkt::Timestamp(),
                Bucket = "bucket17d0bfc2",
                Error = new gr::Status(),
                RegistrationId = "registration_ided27f5d9",
            };
            mockGrpcClient.Setup(x => x.GetDatacenterConnector(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            DatacenterConnector response = client.GetDatacenterConnector(request.DatacenterConnectorName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatacenterConnectorResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatacenterConnectorRequest request = new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
            };
            DatacenterConnector expectedResponse = new DatacenterConnector
            {
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DatacenterConnectorName = DatacenterConnectorName.FromProjectLocationSourceDatacenterConnector("[PROJECT]", "[LOCATION]", "[SOURCE]", "[DATACENTER_CONNECTOR]"),
                ServiceAccount = "service_accounta3c1b923",
                Version = "version102ff72a",
                State = DatacenterConnector.Types.State.Failed,
                StateTime = new wkt::Timestamp(),
                Bucket = "bucket17d0bfc2",
                Error = new gr::Status(),
                RegistrationId = "registration_ided27f5d9",
            };
            mockGrpcClient.Setup(x => x.GetDatacenterConnectorAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DatacenterConnector>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            DatacenterConnector responseCallSettings = await client.GetDatacenterConnectorAsync(request.DatacenterConnectorName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DatacenterConnector responseCancellationToken = await client.GetDatacenterConnectorAsync(request.DatacenterConnectorName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigratingVmRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            MigratingVm expectedResponse = new MigratingVm
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                SourceVmId = "source_vm_id1b0e68ef",
                Description = "description2cf9da67",
                Policy = new SchedulePolicy(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastSync = new ReplicationSync(),
                CurrentSyncInfo = new ReplicationCycle(),
                GroupAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                StateTime = new wkt::Timestamp(),
                State = MigratingVm.Types.State.Cutover,
                ComputeEngineTargetDefaults = new ComputeEngineTargetDefaults(),
            };
            mockGrpcClient.Setup(x => x.GetMigratingVm(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            MigratingVm response = client.GetMigratingVm(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigratingVmRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            MigratingVm expectedResponse = new MigratingVm
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                SourceVmId = "source_vm_id1b0e68ef",
                Description = "description2cf9da67",
                Policy = new SchedulePolicy(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastSync = new ReplicationSync(),
                CurrentSyncInfo = new ReplicationCycle(),
                GroupAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                StateTime = new wkt::Timestamp(),
                State = MigratingVm.Types.State.Cutover,
                ComputeEngineTargetDefaults = new ComputeEngineTargetDefaults(),
            };
            mockGrpcClient.Setup(x => x.GetMigratingVmAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigratingVm>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            MigratingVm responseCallSettings = await client.GetMigratingVmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigratingVm responseCancellationToken = await client.GetMigratingVmAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigratingVm()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            MigratingVm expectedResponse = new MigratingVm
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                SourceVmId = "source_vm_id1b0e68ef",
                Description = "description2cf9da67",
                Policy = new SchedulePolicy(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastSync = new ReplicationSync(),
                CurrentSyncInfo = new ReplicationCycle(),
                GroupAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                StateTime = new wkt::Timestamp(),
                State = MigratingVm.Types.State.Cutover,
                ComputeEngineTargetDefaults = new ComputeEngineTargetDefaults(),
            };
            mockGrpcClient.Setup(x => x.GetMigratingVm(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            MigratingVm response = client.GetMigratingVm(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigratingVmAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            MigratingVm expectedResponse = new MigratingVm
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                SourceVmId = "source_vm_id1b0e68ef",
                Description = "description2cf9da67",
                Policy = new SchedulePolicy(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastSync = new ReplicationSync(),
                CurrentSyncInfo = new ReplicationCycle(),
                GroupAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                StateTime = new wkt::Timestamp(),
                State = MigratingVm.Types.State.Cutover,
                ComputeEngineTargetDefaults = new ComputeEngineTargetDefaults(),
            };
            mockGrpcClient.Setup(x => x.GetMigratingVmAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigratingVm>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            MigratingVm responseCallSettings = await client.GetMigratingVmAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigratingVm responseCancellationToken = await client.GetMigratingVmAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetMigratingVmResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            MigratingVm expectedResponse = new MigratingVm
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                SourceVmId = "source_vm_id1b0e68ef",
                Description = "description2cf9da67",
                Policy = new SchedulePolicy(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastSync = new ReplicationSync(),
                CurrentSyncInfo = new ReplicationCycle(),
                GroupAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                StateTime = new wkt::Timestamp(),
                State = MigratingVm.Types.State.Cutover,
                ComputeEngineTargetDefaults = new ComputeEngineTargetDefaults(),
            };
            mockGrpcClient.Setup(x => x.GetMigratingVm(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            MigratingVm response = client.GetMigratingVm(request.MigratingVmName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetMigratingVmResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMigratingVmRequest request = new GetMigratingVmRequest
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
            };
            MigratingVm expectedResponse = new MigratingVm
            {
                MigratingVmName = MigratingVmName.FromProjectLocationSourceMigratingVm("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]"),
                SourceVmId = "source_vm_id1b0e68ef",
                Description = "description2cf9da67",
                Policy = new SchedulePolicy(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LastSync = new ReplicationSync(),
                CurrentSyncInfo = new ReplicationCycle(),
                GroupAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                DisplayName = "display_name137f65c2",
                Error = new gr::Status(),
                StateTime = new wkt::Timestamp(),
                State = MigratingVm.Types.State.Cutover,
                ComputeEngineTargetDefaults = new ComputeEngineTargetDefaults(),
            };
            mockGrpcClient.Setup(x => x.GetMigratingVmAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MigratingVm>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            MigratingVm responseCallSettings = await client.GetMigratingVmAsync(request.MigratingVmName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MigratingVm responseCancellationToken = await client.GetMigratingVmAsync(request.MigratingVmName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCloneJobRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            CloneJob expectedResponse = new CloneJob
            {
                CreateTime = new wkt::Timestamp(),
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
                State = CloneJob.Types.State.Cancelling,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCloneJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CloneJob response = client.GetCloneJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCloneJobRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            CloneJob expectedResponse = new CloneJob
            {
                CreateTime = new wkt::Timestamp(),
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
                State = CloneJob.Types.State.Cancelling,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCloneJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CloneJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CloneJob responseCallSettings = await client.GetCloneJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CloneJob responseCancellationToken = await client.GetCloneJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCloneJob()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            CloneJob expectedResponse = new CloneJob
            {
                CreateTime = new wkt::Timestamp(),
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
                State = CloneJob.Types.State.Cancelling,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCloneJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CloneJob response = client.GetCloneJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCloneJobAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            CloneJob expectedResponse = new CloneJob
            {
                CreateTime = new wkt::Timestamp(),
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
                State = CloneJob.Types.State.Cancelling,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCloneJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CloneJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CloneJob responseCallSettings = await client.GetCloneJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CloneJob responseCancellationToken = await client.GetCloneJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCloneJobResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            CloneJob expectedResponse = new CloneJob
            {
                CreateTime = new wkt::Timestamp(),
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
                State = CloneJob.Types.State.Cancelling,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCloneJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CloneJob response = client.GetCloneJob(request.CloneJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCloneJobResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCloneJobRequest request = new GetCloneJobRequest
            {
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
            };
            CloneJob expectedResponse = new CloneJob
            {
                CreateTime = new wkt::Timestamp(),
                CloneJobName = CloneJobName.FromProjectLocationSourceMigratingVmCloneJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CLONE_JOB]"),
                State = CloneJob.Types.State.Cancelling,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCloneJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CloneJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CloneJob responseCallSettings = await client.GetCloneJobAsync(request.CloneJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CloneJob responseCancellationToken = await client.GetCloneJobAsync(request.CloneJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCutoverJobRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            CutoverJob expectedResponse = new CutoverJob
            {
                CreateTime = new wkt::Timestamp(),
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
                State = CutoverJob.Types.State.Active,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                StateMessage = "state_message46cf28c0",
                ProgressPercent = -412774427,
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCutoverJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CutoverJob response = client.GetCutoverJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCutoverJobRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            CutoverJob expectedResponse = new CutoverJob
            {
                CreateTime = new wkt::Timestamp(),
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
                State = CutoverJob.Types.State.Active,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                StateMessage = "state_message46cf28c0",
                ProgressPercent = -412774427,
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCutoverJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CutoverJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CutoverJob responseCallSettings = await client.GetCutoverJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CutoverJob responseCancellationToken = await client.GetCutoverJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCutoverJob()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            CutoverJob expectedResponse = new CutoverJob
            {
                CreateTime = new wkt::Timestamp(),
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
                State = CutoverJob.Types.State.Active,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                StateMessage = "state_message46cf28c0",
                ProgressPercent = -412774427,
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCutoverJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CutoverJob response = client.GetCutoverJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCutoverJobAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            CutoverJob expectedResponse = new CutoverJob
            {
                CreateTime = new wkt::Timestamp(),
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
                State = CutoverJob.Types.State.Active,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                StateMessage = "state_message46cf28c0",
                ProgressPercent = -412774427,
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCutoverJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CutoverJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CutoverJob responseCallSettings = await client.GetCutoverJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CutoverJob responseCancellationToken = await client.GetCutoverJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCutoverJobResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            CutoverJob expectedResponse = new CutoverJob
            {
                CreateTime = new wkt::Timestamp(),
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
                State = CutoverJob.Types.State.Active,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                StateMessage = "state_message46cf28c0",
                ProgressPercent = -412774427,
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCutoverJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CutoverJob response = client.GetCutoverJob(request.CutoverJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCutoverJobResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCutoverJobRequest request = new GetCutoverJobRequest
            {
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
            };
            CutoverJob expectedResponse = new CutoverJob
            {
                CreateTime = new wkt::Timestamp(),
                CutoverJobName = CutoverJobName.FromProjectLocationSourceMigratingVmCutoverJob("[PROJECT]", "[LOCATION]", "[SOURCE]", "[MIGRATING_VM]", "[CUTOVER_JOB]"),
                State = CutoverJob.Types.State.Active,
                StateTime = new wkt::Timestamp(),
                Error = new gr::Status(),
                StateMessage = "state_message46cf28c0",
                ProgressPercent = -412774427,
                ComputeEngineTargetDetails = new ComputeEngineTargetDetails(),
            };
            mockGrpcClient.Setup(x => x.GetCutoverJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CutoverJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            CutoverJob responseCallSettings = await client.GetCutoverJobAsync(request.CutoverJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CutoverJob responseCancellationToken = await client.GetCutoverJobAsync(request.CutoverJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroupRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroup()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroupResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request.GroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectLocationGroup("[PROJECT]", "[LOCATION]", "[GROUP]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request.GroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request.GroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTargetProjectRequestObject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            TargetProject expectedResponse = new TargetProject
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                Project = "projectaa6ff846",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTargetProject(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            TargetProject response = client.GetTargetProject(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTargetProjectRequestObjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            TargetProject expectedResponse = new TargetProject
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                Project = "projectaa6ff846",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTargetProjectAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetProject>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            TargetProject responseCallSettings = await client.GetTargetProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetProject responseCancellationToken = await client.GetTargetProjectAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTargetProject()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            TargetProject expectedResponse = new TargetProject
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                Project = "projectaa6ff846",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTargetProject(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            TargetProject response = client.GetTargetProject(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTargetProjectAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            TargetProject expectedResponse = new TargetProject
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                Project = "projectaa6ff846",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTargetProjectAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetProject>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            TargetProject responseCallSettings = await client.GetTargetProjectAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetProject responseCancellationToken = await client.GetTargetProjectAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTargetProjectResourceNames()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            TargetProject expectedResponse = new TargetProject
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                Project = "projectaa6ff846",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTargetProject(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            TargetProject response = client.GetTargetProject(request.TargetProjectName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTargetProjectResourceNamesAsync()
        {
            moq::Mock<VmMigration.VmMigrationClient> mockGrpcClient = new moq::Mock<VmMigration.VmMigrationClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetProjectRequest request = new GetTargetProjectRequest
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
            };
            TargetProject expectedResponse = new TargetProject
            {
                TargetProjectName = TargetProjectName.FromProjectLocationTargetProject("[PROJECT]", "[LOCATION]", "[TARGET_PROJECT]"),
                Project = "projectaa6ff846",
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetTargetProjectAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetProject>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VmMigrationClient client = new VmMigrationClientImpl(mockGrpcClient.Object, null);
            TargetProject responseCallSettings = await client.GetTargetProjectAsync(request.TargetProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetProject responseCancellationToken = await client.GetTargetProjectAsync(request.TargetProjectName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
