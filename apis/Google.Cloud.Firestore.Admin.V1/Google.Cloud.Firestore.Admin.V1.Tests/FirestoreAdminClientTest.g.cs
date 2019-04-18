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

namespace Google.Cloud.Firestore.Admin.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Firestore.Admin.V1;
    using Google.LongRunning;
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
    public class GeneratedFirestoreAdminClientTest
    {
        [Fact]
        public void CreateIndex()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            CreateIndexRequest expectedRequest = new CreateIndexRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
                Index = new Index(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CreateIndex(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            Index index = new Index();
            Operation response = client.CreateIndex(parent, index);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIndexAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            CreateIndexRequest expectedRequest = new CreateIndexRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
                Index = new Index(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CreateIndexAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            Index index = new Index();
            Operation response = await client.CreateIndexAsync(parent, index);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIndex2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
                Index = new Index(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CreateIndex(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateIndex(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIndexAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
                Index = new Index(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CreateIndexAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.CreateIndexAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIndex()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetIndexRequest expectedRequest = new GetIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Index expectedResponse = new Index
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetIndex(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            Index response = client.GetIndex(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIndexAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetIndexRequest expectedRequest = new GetIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Index expectedResponse = new Index
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Index>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            Index response = await client.GetIndexAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIndex2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Index expectedResponse = new Index
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index response = client.GetIndex(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIndexAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Index expectedResponse = new Index
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Index>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index response = await client.GetIndexAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIndex()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            DeleteIndexRequest expectedRequest = new DeleteIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIndex(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            client.DeleteIndex(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIndexAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            DeleteIndexRequest expectedRequest = new DeleteIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIndexAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            await client.DeleteIndexAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIndex2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIndex(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteIndex(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIndexAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIndexAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIndexAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportDocuments()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ImportDocumentsRequest expectedRequest = new ImportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ImportDocuments(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            Operation response = client.ImportDocuments(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ImportDocumentsAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ImportDocumentsRequest expectedRequest = new ImportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ImportDocumentsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            Operation response = await client.ImportDocumentsAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportDocuments2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ImportDocuments(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ImportDocuments(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ImportDocumentsAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ImportDocumentsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.ImportDocumentsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ExportDocuments()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ExportDocumentsRequest expectedRequest = new ExportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ExportDocuments(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            Operation response = client.ExportDocuments(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ExportDocumentsAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ExportDocumentsRequest expectedRequest = new ExportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ExportDocumentsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            Operation response = await client.ExportDocumentsAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ExportDocuments2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ExportDocumentsRequest request = new ExportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ExportDocuments(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = client.ExportDocuments(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ExportDocumentsAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            ExportDocumentsRequest request = new ExportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name2-1052831874",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.ExportDocumentsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.ExportDocumentsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetField()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetFieldRequest expectedRequest = new GetFieldRequest
            {
                FieldName = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]"),
            };
            apis::Field expectedResponse = new apis::Field
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetField(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            FieldName name = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]");
            apis::Field response = client.GetField(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetFieldAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetFieldRequest expectedRequest = new GetFieldRequest
            {
                FieldName = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]"),
            };
            apis::Field expectedResponse = new apis::Field
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetFieldAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Field>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            FieldName name = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]");
            apis::Field response = await client.GetFieldAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetField2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]"),
            };
            apis::Field expectedResponse = new apis::Field
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetField(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            apis::Field response = client.GetField(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetFieldAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]"),
            };
            apis::Field expectedResponse = new apis::Field
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetFieldAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<apis::Field>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            apis::Field response = await client.GetFieldAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateField()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            UpdateFieldRequest expectedRequest = new UpdateFieldRequest
            {
                Field = new apis::Field(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.UpdateField(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            apis::Field field = new apis::Field();
            Operation response = client.UpdateField(field);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateFieldAsync()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            UpdateFieldRequest expectedRequest = new UpdateFieldRequest
            {
                Field = new apis::Field(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.UpdateFieldAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            apis::Field field = new apis::Field();
            Operation response = await client.UpdateFieldAsync(field);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateField2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new apis::Field(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.UpdateField(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateField(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateFieldAsync2()
        {
            Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new Mock<FirestoreAdmin.FirestoreAdminClient>(MockBehavior.Strict);
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new apis::Field(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Done = true,
            };
            mockGrpcClient.Setup(x => x.UpdateFieldAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.UpdateFieldAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
