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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSchemaServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateSchemaRequestObject()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "schema_idb515cf80",
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.CreateSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema response = client.CreateSchema(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSchemaRequestObjectAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "schema_idb515cf80",
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.CreateSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema responseCallSettings = await client.CreateSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schema responseCancellationToken = await client.CreateSchemaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSchema()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "schema_idb515cf80",
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.CreateSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema response = client.CreateSchema(request.Parent, request.Schema, request.SchemaId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSchemaAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "schema_idb515cf80",
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.CreateSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema responseCallSettings = await client.CreateSchemaAsync(request.Parent, request.Schema, request.SchemaId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schema responseCancellationToken = await client.CreateSchemaAsync(request.Parent, request.Schema, request.SchemaId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSchemaResourceNames()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "schema_idb515cf80",
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.CreateSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema response = client.CreateSchema(request.ParentAsProjectName, request.Schema, request.SchemaId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSchemaResourceNamesAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateSchemaRequest request = new CreateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
                SchemaId = "schema_idb515cf80",
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.CreateSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema responseCallSettings = await client.CreateSchemaAsync(request.ParentAsProjectName, request.Schema, request.SchemaId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schema responseCancellationToken = await client.CreateSchemaAsync(request.ParentAsProjectName, request.Schema, request.SchemaId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSchemaRequestObject()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                View = SchemaView.Basic,
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.GetSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema response = client.GetSchema(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSchemaRequestObjectAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                View = SchemaView.Basic,
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.GetSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema responseCallSettings = await client.GetSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schema responseCancellationToken = await client.GetSchemaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSchema()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.GetSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema response = client.GetSchema(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSchemaAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.GetSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema responseCallSettings = await client.GetSchemaAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schema responseCancellationToken = await client.GetSchemaAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSchemaResourceNames()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.GetSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema response = client.GetSchema(request.SchemaName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSchemaResourceNamesAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetSchemaRequest request = new GetSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            Schema expectedResponse = new Schema
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Type = Schema.Types.Type.Unspecified,
                Definition = "definition3b8b6130",
            };
            mockGrpcClient.Setup(x => x.GetSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Schema>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            Schema responseCallSettings = await client.GetSchemaAsync(request.SchemaName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Schema responseCancellationToken = await client.GetSchemaAsync(request.SchemaName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSchemaRequestObject()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSchema(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSchemaRequestObjectAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSchemaAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSchema()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSchema(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSchemaAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSchemaAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSchemaAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSchemaResourceNames()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSchema(request.SchemaName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSchemaResourceNamesAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            DeleteSchemaRequest request = new DeleteSchemaRequest
            {
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSchemaAsync(request.SchemaName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSchemaAsync(request.SchemaName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateSchemaRequestObject()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            ValidateSchemaResponse expectedResponse = new ValidateSchemaResponse { };
            mockGrpcClient.Setup(x => x.ValidateSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateSchemaResponse response = client.ValidateSchema(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateSchemaRequestObjectAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            ValidateSchemaResponse expectedResponse = new ValidateSchemaResponse { };
            mockGrpcClient.Setup(x => x.ValidateSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateSchemaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateSchemaResponse responseCallSettings = await client.ValidateSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateSchemaResponse responseCancellationToken = await client.ValidateSchemaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateSchema()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            ValidateSchemaResponse expectedResponse = new ValidateSchemaResponse { };
            mockGrpcClient.Setup(x => x.ValidateSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateSchemaResponse response = client.ValidateSchema(request.Parent, request.Schema);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateSchemaAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            ValidateSchemaResponse expectedResponse = new ValidateSchemaResponse { };
            mockGrpcClient.Setup(x => x.ValidateSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateSchemaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateSchemaResponse responseCallSettings = await client.ValidateSchemaAsync(request.Parent, request.Schema, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateSchemaResponse responseCancellationToken = await client.ValidateSchemaAsync(request.Parent, request.Schema, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateSchemaResourceNames()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            ValidateSchemaResponse expectedResponse = new ValidateSchemaResponse { };
            mockGrpcClient.Setup(x => x.ValidateSchema(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateSchemaResponse response = client.ValidateSchema(request.ParentAsProjectName, request.Schema);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateSchemaResourceNamesAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateSchemaRequest request = new ValidateSchemaRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Schema = new Schema(),
            };
            ValidateSchemaResponse expectedResponse = new ValidateSchemaResponse { };
            mockGrpcClient.Setup(x => x.ValidateSchemaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateSchemaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateSchemaResponse responseCallSettings = await client.ValidateSchemaAsync(request.ParentAsProjectName, request.Schema, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateSchemaResponse responseCancellationToken = await client.ValidateSchemaAsync(request.ParentAsProjectName, request.Schema, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateMessageRequestObject()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateMessageRequest request = new ValidateMessageRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Schema = new Schema(),
                Message = proto::ByteString.CopyFromUtf8("message0231e778"),
                Encoding = Encoding.Json,
            };
            ValidateMessageResponse expectedResponse = new ValidateMessageResponse { };
            mockGrpcClient.Setup(x => x.ValidateMessage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateMessageResponse response = client.ValidateMessage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateMessageRequestObjectAsync()
        {
            moq::Mock<SchemaService.SchemaServiceClient> mockGrpcClient = new moq::Mock<SchemaService.SchemaServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            ValidateMessageRequest request = new ValidateMessageRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SchemaName = SchemaName.FromProjectSchema("[PROJECT]", "[SCHEMA]"),
                Schema = new Schema(),
                Message = proto::ByteString.CopyFromUtf8("message0231e778"),
                Encoding = Encoding.Json,
            };
            ValidateMessageResponse expectedResponse = new ValidateMessageResponse { };
            mockGrpcClient.Setup(x => x.ValidateMessageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidateMessageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SchemaServiceClient client = new SchemaServiceClientImpl(mockGrpcClient.Object, null);
            ValidateMessageResponse responseCallSettings = await client.ValidateMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidateMessageResponse responseCancellationToken = await client.ValidateMessageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
