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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AppEngine.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedInstancesClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromAppServiceVersionInstance("[APP]", "[SERVICE]", "[VERSION]", "[INSTANCE]"),
                Id = "id74b70bb8",
                AppEngineRelease = "app_engine_release0d3b73e6",
                Availability = Instance.Types.Availability.Unspecified,
                VmName = "vm_name2b89e867",
                VmZoneName = "vm_zone_name0deb2195",
                VmId = "vm_idb8ec0c0e",
                StartTime = new wkt::Timestamp(),
                Requests = 821139506,
                Errors = 20586759,
                Qps = 1.5122795E+17F,
                AverageLatency = -1548461605,
                MemoryUsage = -2914232593404547833L,
                VmStatus = "vm_status3752e225",
                VmDebugEnabled = false,
                VmIp = "vm_ipe63c1f99",
                VmLiveness = Instance.Types.Liveness.Types.LivenessState.Draining,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<Instances.InstancesClient> mockGrpcClient = new moq::Mock<Instances.InstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = "name1c9368b0",
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = InstanceName.FromAppServiceVersionInstance("[APP]", "[SERVICE]", "[VERSION]", "[INSTANCE]"),
                Id = "id74b70bb8",
                AppEngineRelease = "app_engine_release0d3b73e6",
                Availability = Instance.Types.Availability.Unspecified,
                VmName = "vm_name2b89e867",
                VmZoneName = "vm_zone_name0deb2195",
                VmId = "vm_idb8ec0c0e",
                StartTime = new wkt::Timestamp(),
                Requests = 821139506,
                Errors = 20586759,
                Qps = 1.5122795E+17F,
                AverageLatency = -1548461605,
                MemoryUsage = -2914232593404547833L,
                VmStatus = "vm_status3752e225",
                VmDebugEnabled = false,
                VmIp = "vm_ipe63c1f99",
                VmLiveness = Instance.Types.Liveness.Types.LivenessState.Draining,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstancesClient client = new InstancesClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
