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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Datastore.Admin.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDatastoreAdminClientTest
    {
        [xunit::FactAttribute]
        public void GetIndexRequestObject()
        {
            moq::Mock<DatastoreAdmin.DatastoreAdminClient> mockGrpcClient = new moq::Mock<DatastoreAdmin.DatastoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                ProjectId = "project_id43ad98b0",
                IndexId = "index_id3caa18b6",
            };
            Index expectedResponse = new Index
            {
                ProjectId = "project_id43ad98b0",
                IndexId = "index_id3caa18b6",
                Kind = "kindf7aa39d9",
                Ancestor = Index.Types.AncestorMode.None,
                Properties =
                {
                    new Index.Types.IndexedProperty(),
                },
                State = Index.Types.State.Deleting,
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreAdminClient client = new DatastoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Index response = client.GetIndex(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexRequestObjectAsync()
        {
            moq::Mock<DatastoreAdmin.DatastoreAdminClient> mockGrpcClient = new moq::Mock<DatastoreAdmin.DatastoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                ProjectId = "project_id43ad98b0",
                IndexId = "index_id3caa18b6",
            };
            Index expectedResponse = new Index
            {
                ProjectId = "project_id43ad98b0",
                IndexId = "index_id3caa18b6",
                Kind = "kindf7aa39d9",
                Ancestor = Index.Types.AncestorMode.None,
                Properties =
                {
                    new Index.Types.IndexedProperty(),
                },
                State = Index.Types.State.Deleting,
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreAdminClient client = new DatastoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Index responseCallSettings = await client.GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
