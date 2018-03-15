// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Logging.V2.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedConfigServiceV2ClientTest
    {
        [Fact]
        public void GetSinkTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetSink(It.IsAny<GetSinkRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink response = client.GetSink(sinkName);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSinkTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateSink(It.IsAny<CreateSinkRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogSink sink = new LogSink();
            LogSink response = client.CreateSink(parent, sink);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSinkTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogSink expectedResponse = new LogSink
            {
                Name = "name3373707",
                DestinationAsResourceName = new ProjectName("[PROJECT]"),
                Filter = "filter-1274492040",
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateSink(It.IsAny<UpdateSinkRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            LogSink sink = new LogSink();
            LogSink response = client.UpdateSink(sinkName, sink);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSinkTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteSink(It.IsAny<DeleteSinkRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            SinkNameOneof sinkName = SinkNameOneof.From(new SinkName("[PROJECT]", "[SINK]"));
            client.DeleteSink(sinkName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetExclusionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetExclusion(It.IsAny<GetExclusionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            LogExclusion response = client.GetExclusion(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateExclusionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateExclusion(It.IsAny<CreateExclusionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            LogExclusion exclusion = new LogExclusion();
            LogExclusion response = client.CreateExclusion(parent, exclusion);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateExclusionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            LogExclusion expectedResponse = new LogExclusion
            {
                Name = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateExclusion(It.IsAny<UpdateExclusionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            LogExclusion response = client.UpdateExclusion(name, exclusion, updateMask);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteExclusionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteExclusion(It.IsAny<DeleteExclusionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ExclusionNameOneof name = ExclusionNameOneof.From(new ExclusionName("[PROJECT]", "[EXCLUSION]"));
            client.DeleteExclusion(name);
            mockGrpcClient.VerifyAll();
        }

    }
}
