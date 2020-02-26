// Copyright 2020 Google LLC
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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Logging.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConfigServiceV2ClientTest
    {
        [xunit::FactAttribute]
        public void GetSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.GetSink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.GetSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.GetSinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSink()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.GetSink(request.SinkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSinkAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.GetSinkAsync(request.SinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.GetSinkAsync(request.SinkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSinkResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.GetSink(request.SinkNameAsSinkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSinkResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.GetSinkAsync(request.SinkNameAsSinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.GetSinkAsync(request.SinkNameAsSinkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSink()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request.Parent, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.Parent, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.Parent, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames1()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request.ParentAsProjectName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames1Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsProjectName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsProjectName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames2()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request.ParentAsOrganizationName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames2Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsOrganizationName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsOrganizationName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames3()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request.ParentAsFolderName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames3Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsFolderName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsFolderName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames4()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request.ParentAsBillingAccountName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames4Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsBillingAccountName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsBillingAccountName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink1()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request.SinkName, request.Sink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink1Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkName, request.Sink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkName, request.Sink, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink1ResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request.SinkNameAsSinkName, request.Sink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink1ResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkNameAsSinkName, request.Sink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkNameAsSinkName, request.Sink, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink2()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request.SinkName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink2Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink2ResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request.SinkNameAsSinkName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink2ResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                SinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
#pragma warning disable CS0612
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
#pragma warning restore CS0612
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkNameAsSinkName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkNameAsSinkName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteSink(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSinkAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSink()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteSink(request.SinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSinkAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSinkAsync(request.SinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSinkAsync(request.SinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSinkResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteSink(request.SinkNameAsSinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSinkResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSinkAsync(request.SinkNameAsSinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSinkAsync(request.SinkNameAsSinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.GetExclusion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.GetExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.GetExclusionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.GetExclusion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.GetExclusionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.GetExclusionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExclusionResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.GetExclusion(request.ExclusionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExclusionResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.GetExclusionAsync(request.ExclusionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.GetExclusionAsync(request.ExclusionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request.Parent, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.Parent, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.Parent, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames1()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsProjectName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames1Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsProjectName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsProjectName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames2()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsOrganizationName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames2Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsOrganizationName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsOrganizationName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames3()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsFolderName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames3Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsFolderName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsFolderName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames4()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsBillingAccountName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames4Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsBillingAccountName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsBillingAccountName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.UpdateExclusion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.UpdateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.UpdateExclusionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.UpdateExclusion(request.Name, request.Exclusion, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.UpdateExclusionAsync(request.Name, request.Exclusion, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.UpdateExclusionAsync(request.Name, request.Exclusion, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExclusionResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.UpdateExclusion(request.ExclusionName, request.Exclusion, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExclusionResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion responseCallSettings = await client.UpdateExclusionAsync(request.ExclusionName, request.Exclusion, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.UpdateExclusionAsync(request.ExclusionName, request.Exclusion, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteExclusion(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExclusionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteExclusion(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteExclusionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExclusionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExclusionResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteExclusion(request.ExclusionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExclusionResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteExclusionAsync(request.ExclusionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExclusionAsync(request.ExclusionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCmekSettingsRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                Name = "name1c9368b0",
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                Name = "name1c9368b0",
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.GetCmekSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings response = client.GetCmekSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCmekSettingsRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                Name = "name1c9368b0",
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                Name = "name1c9368b0",
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.GetCmekSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CmekSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings responseCallSettings = await client.GetCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CmekSettings responseCancellationToken = await client.GetCmekSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCmekSettingsRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "name1c9368b0",
                CmekSettings = new CmekSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                Name = "name1c9368b0",
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.UpdateCmekSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings response = client.UpdateCmekSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCmekSettingsRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "name1c9368b0",
                CmekSettings = new CmekSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                Name = "name1c9368b0",
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.UpdateCmekSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CmekSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings responseCallSettings = await client.UpdateCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CmekSettings responseCancellationToken = await client.UpdateCmekSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
