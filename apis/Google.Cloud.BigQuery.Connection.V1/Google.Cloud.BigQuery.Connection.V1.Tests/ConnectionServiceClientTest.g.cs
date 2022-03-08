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

using gax = Google.Api.Gax;
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

namespace Google.Cloud.BigQuery.Connection.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConnectionServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateConnectionRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "connection_id78489b28",
                Connection = new Connection(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.CreateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.CreateConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConnectionRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "connection_id78489b28",
                Connection = new Connection(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.CreateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.CreateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.CreateConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConnection()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "connection_id78489b28",
                Connection = new Connection(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.CreateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.CreateConnection(request.Parent, request.Connection, request.ConnectionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConnectionAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "connection_id78489b28",
                Connection = new Connection(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.CreateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.CreateConnectionAsync(request.Parent, request.Connection, request.ConnectionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.CreateConnectionAsync(request.Parent, request.Connection, request.ConnectionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConnectionResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "connection_id78489b28",
                Connection = new Connection(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.CreateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.CreateConnection(request.ParentAsLocationName, request.Connection, request.ConnectionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConnectionResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "connection_id78489b28",
                Connection = new Connection(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.CreateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.CreateConnectionAsync(request.ParentAsLocationName, request.Connection, request.ConnectionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.CreateConnectionAsync(request.ParentAsLocationName, request.Connection, request.ConnectionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.GetConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.GetConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.GetConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnection()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.GetConnection(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.GetConnectionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.GetConnectionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectionResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.GetConnection(request.ConnectionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectionResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.GetConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.GetConnectionAsync(request.ConnectionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.GetConnectionAsync(request.ConnectionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConnectionRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new wkt::FieldMask(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.UpdateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.UpdateConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConnectionRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new wkt::FieldMask(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.UpdateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.UpdateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.UpdateConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConnection()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new wkt::FieldMask(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.UpdateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.UpdateConnection(request.Name, request.Connection, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConnectionAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new wkt::FieldMask(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.UpdateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.UpdateConnectionAsync(request.Name, request.Connection, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.UpdateConnectionAsync(request.Name, request.Connection, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConnectionResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new wkt::FieldMask(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.UpdateConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection response = client.UpdateConnection(request.ConnectionName, request.Connection, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConnectionResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Connection = new Connection(),
                UpdateMask = new wkt::FieldMask(),
            };
            Connection expectedResponse = new Connection
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                FriendlyName = "friendly_name6171e36b",
                Description = "description2cf9da67",
                CloudSql = new CloudSqlProperties(),
                CreationTime = -5025413042314785256L,
                LastModifiedTime = 1315234198627015670L,
                HasCredential = true,
                Aws = new AwsProperties(),
                CloudSpanner = new CloudSpannerProperties(),
                CloudResource = new CloudResourceProperties(),
            };
            mockGrpcClient.Setup(x => x.UpdateConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Connection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            Connection responseCallSettings = await client.UpdateConnectionAsync(request.ConnectionName, request.Connection, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Connection responseCancellationToken = await client.UpdateConnectionAsync(request.ConnectionName, request.Connection, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConnectionRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteConnection(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConnectionRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConnectionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConnection()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteConnection(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConnectionAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteConnectionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConnectionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConnectionResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteConnection(request.ConnectionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConnectionResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteConnectionAsync(request.ConnectionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConnectionAsync(request.ConnectionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource, request.Options);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, request.Options, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, request.Options, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName, request.Options);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, request.Options, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, request.Options, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<ConnectionService.ConnectionServiceClient> mockGrpcClient = new moq::Mock<ConnectionService.ConnectionServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConnectionServiceClient client = new ConnectionServiceClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
