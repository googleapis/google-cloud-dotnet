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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBigtableServiceApiClientTest
    {
        [xunit::FactAttribute]
        public void MutateRowRequestObject()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
                AppProfileId = "app_profile_id57fb0442",
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = client.MutateRow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateRowRequestObjectAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
                AppProfileId = "app_profile_id57fb0442",
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse responseCallSettings = await client.MutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateRowResponse responseCancellationToken = await client.MutateRowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateRow1()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = client.MutateRow(request.TableName, request.RowKey, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateRow1Async()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse responseCallSettings = await client.MutateRowAsync(request.TableName, request.RowKey, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateRowResponse responseCancellationToken = await client.MutateRowAsync(request.TableName, request.RowKey, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateRow1ResourceNames()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = client.MutateRow(request.TableNameAsTableName, request.RowKey, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateRow1ResourceNamesAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse responseCallSettings = await client.MutateRowAsync(request.TableNameAsTableName, request.RowKey, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateRowResponse responseCancellationToken = await client.MutateRowAsync(request.TableNameAsTableName, request.RowKey, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateRow2()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
                AppProfileId = "app_profile_id57fb0442",
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = client.MutateRow(request.TableName, request.RowKey, request.Mutations, request.AppProfileId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateRow2Async()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
                AppProfileId = "app_profile_id57fb0442",
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse responseCallSettings = await client.MutateRowAsync(request.TableName, request.RowKey, request.Mutations, request.AppProfileId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateRowResponse responseCancellationToken = await client.MutateRowAsync(request.TableName, request.RowKey, request.Mutations, request.AppProfileId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MutateRow2ResourceNames()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
                AppProfileId = "app_profile_id57fb0442",
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = client.MutateRow(request.TableNameAsTableName, request.RowKey, request.Mutations, request.AppProfileId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MutateRow2ResourceNamesAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Mutations = { new Mutation(), },
                AppProfileId = "app_profile_id57fb0442",
            };
            MutateRowResponse expectedResponse = new MutateRowResponse { };
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse responseCallSettings = await client.MutateRowAsync(request.TableNameAsTableName, request.RowKey, request.Mutations, request.AppProfileId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MutateRowResponse responseCancellationToken = await client.MutateRowAsync(request.TableNameAsTableName, request.RowKey, request.Mutations, request.AppProfileId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckAndMutateRowRequestObject()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "app_profile_id57fb0442",
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckAndMutateRowRequestObjectAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "app_profile_id57fb0442",
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckAndMutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse responseCallSettings = await client.CheckAndMutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckAndMutateRowResponse responseCancellationToken = await client.CheckAndMutateRowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckAndMutateRow1()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(request.TableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckAndMutateRow1Async()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckAndMutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse responseCallSettings = await client.CheckAndMutateRowAsync(request.TableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckAndMutateRowResponse responseCancellationToken = await client.CheckAndMutateRowAsync(request.TableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckAndMutateRow1ResourceNames()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(request.TableNameAsTableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckAndMutateRow1ResourceNamesAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckAndMutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse responseCallSettings = await client.CheckAndMutateRowAsync(request.TableNameAsTableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckAndMutateRowResponse responseCancellationToken = await client.CheckAndMutateRowAsync(request.TableNameAsTableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckAndMutateRow2()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "app_profile_id57fb0442",
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(request.TableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, request.AppProfileId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckAndMutateRow2Async()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "app_profile_id57fb0442",
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckAndMutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse responseCallSettings = await client.CheckAndMutateRowAsync(request.TableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, request.AppProfileId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckAndMutateRowResponse responseCancellationToken = await client.CheckAndMutateRowAsync(request.TableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, request.AppProfileId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckAndMutateRow2ResourceNames()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "app_profile_id57fb0442",
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(request.TableNameAsTableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, request.AppProfileId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckAndMutateRow2ResourceNamesAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "app_profile_id57fb0442",
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckAndMutateRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse responseCallSettings = await client.CheckAndMutateRowAsync(request.TableNameAsTableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, request.AppProfileId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckAndMutateRowResponse responseCancellationToken = await client.CheckAndMutateRowAsync(request.TableNameAsTableName, request.RowKey, request.PredicateFilter, request.TrueMutations, request.FalseMutations, request.AppProfileId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadModifyWriteRowRequestObject()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "app_profile_id57fb0442",
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadModifyWriteRowRequestObjectAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "app_profile_id57fb0442",
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadModifyWriteRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse responseCallSettings = await client.ReadModifyWriteRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadModifyWriteRowResponse responseCancellationToken = await client.ReadModifyWriteRowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadModifyWriteRow1()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(request.TableName, request.RowKey, request.Rules);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadModifyWriteRow1Async()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadModifyWriteRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse responseCallSettings = await client.ReadModifyWriteRowAsync(request.TableName, request.RowKey, request.Rules, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadModifyWriteRowResponse responseCancellationToken = await client.ReadModifyWriteRowAsync(request.TableName, request.RowKey, request.Rules, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadModifyWriteRow1ResourceNames()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(request.TableNameAsTableName, request.RowKey, request.Rules);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadModifyWriteRow1ResourceNamesAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadModifyWriteRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse responseCallSettings = await client.ReadModifyWriteRowAsync(request.TableNameAsTableName, request.RowKey, request.Rules, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadModifyWriteRowResponse responseCancellationToken = await client.ReadModifyWriteRowAsync(request.TableNameAsTableName, request.RowKey, request.Rules, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadModifyWriteRow2()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "app_profile_id57fb0442",
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(request.TableName, request.RowKey, request.Rules, request.AppProfileId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadModifyWriteRow2Async()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "app_profile_id57fb0442",
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadModifyWriteRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse responseCallSettings = await client.ReadModifyWriteRowAsync(request.TableName, request.RowKey, request.Rules, request.AppProfileId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadModifyWriteRowResponse responseCancellationToken = await client.ReadModifyWriteRowAsync(request.TableName, request.RowKey, request.Rules, request.AppProfileId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReadModifyWriteRow2ResourceNames()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "app_profile_id57fb0442",
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(request.TableNameAsTableName, request.RowKey, request.Rules, request.AppProfileId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReadModifyWriteRow2ResourceNamesAsync()
        {
            moq::Mock<Bigtable.BigtableClient> mockGrpcClient = new moq::Mock<Bigtable.BigtableClient>(moq::MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = proto::ByteString.CopyFromUtf8("row_key7adfb7cb"),
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "app_profile_id57fb0442",
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse { Row = new Row(), };
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReadModifyWriteRowResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse responseCallSettings = await client.ReadModifyWriteRowAsync(request.TableNameAsTableName, request.RowKey, request.Rules, request.AppProfileId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReadModifyWriteRowResponse responseCancellationToken = await client.ReadModifyWriteRowAsync(request.TableNameAsTableName, request.RowKey, request.Rules, request.AppProfileId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
