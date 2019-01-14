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

namespace Google.Cloud.Logging.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Logging.V2;
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
    public class GeneratedConfigServiceV2ClientTest
    {
        [Fact]
        public void GetSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest expectedRequest = new GetSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink response = client.GetSink(sinkName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest expectedRequest = new GetSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink response = await client.GetSinkAsync(sinkName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.GetSink(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = await client.GetSinkAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest expectedRequest = new CreateSinkRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogSink sink = new LogSink();
            LogSink response = client.CreateSink(parent, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest expectedRequest = new CreateSinkRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogSink sink = new LogSink();
            LogSink response = await client.CreateSinkAsync(parent, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = await client.CreateSinkAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
                UpdateMask = new FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            LogSink response = client.UpdateSink(sinkName, sink, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
                UpdateMask = new FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            LogSink response = await client.UpdateSinkAsync(sinkName, sink, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            LogSink response = client.UpdateSink(sinkName, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            LogSink response = await client.UpdateSinkAsync(sinkName, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSink3()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSinkAsync3()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new BillingName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = await client.UpdateSinkAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest expectedRequest = new DeleteSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            client.DeleteSink(sinkName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest expectedRequest = new DeleteSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            await client.DeleteSinkAsync(sinkName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteSink(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkNameOneof = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSinkAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest expectedRequest = new GetExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            LogExclusion response = client.GetExclusion(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest expectedRequest = new GetExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            LogExclusion response = await client.GetExclusionAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.GetExclusion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = await client.GetExclusionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest expectedRequest = new CreateExclusionRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogExclusion exclusion = new LogExclusion();
            LogExclusion response = client.CreateExclusion(parent, exclusion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest expectedRequest = new CreateExclusionRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogExclusion exclusion = new LogExclusion();
            LogExclusion response = await client.CreateExclusionAsync(parent, exclusion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = await client.CreateExclusionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest expectedRequest = new UpdateExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            LogExclusion response = client.UpdateExclusion(name, exclusion, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest expectedRequest = new UpdateExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            LogExclusion response = await client.UpdateExclusionAsync(name, exclusion, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.UpdateExclusion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = await client.UpdateExclusionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest expectedRequest = new DeleteExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            client.DeleteExclusion(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest expectedRequest = new DeleteExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            await client.DeleteExclusionAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteExclusion(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionNameOneof = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]")),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteExclusionAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
