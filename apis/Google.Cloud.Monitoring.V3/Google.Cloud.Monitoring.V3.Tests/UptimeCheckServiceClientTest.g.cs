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

namespace Google.Cloud.Monitoring.V3.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedUptimeCheckServiceClientTest
    {
        [Fact]
        public void GetUptimeCheckConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient> { DefaultValue = DefaultValue.Mock };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetUptimeCheckConfig(It.IsAny<GetUptimeCheckConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]").ToString();
            UptimeCheckConfig response = client.GetUptimeCheckConfig(formattedName);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateUptimeCheckConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient> { DefaultValue = DefaultValue.Mock };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateUptimeCheckConfig(It.IsAny<CreateUptimeCheckConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            UptimeCheckConfig response = client.CreateUptimeCheckConfig(formattedParent, uptimeCheckConfig);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateUptimeCheckConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient> { DefaultValue = DefaultValue.Mock };
            UptimeCheckConfig expectedResponse = new UptimeCheckConfig
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateUptimeCheckConfig(It.IsAny<UpdateUptimeCheckConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            UptimeCheckConfig response = client.UpdateUptimeCheckConfig(uptimeCheckConfig);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteUptimeCheckConfigTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<UptimeCheckService.UptimeCheckServiceClient> mockGrpcClient = new Mock<UptimeCheckService.UptimeCheckServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteUptimeCheckConfig(It.IsAny<DeleteUptimeCheckConfigRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            UptimeCheckServiceClient client = new UptimeCheckServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new UptimeCheckConfigName("[PROJECT]", "[UPTIME_CHECK_CONFIG]").ToString();
            client.DeleteUptimeCheckConfig(formattedName);
            mockGrpcClient.VerifyAll();
        }

    }
}
