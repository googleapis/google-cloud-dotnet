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
    public class GeneratedAlertPolicyServiceClientTest
    {
        [Fact]
        public void GetAlertPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient> { DefaultValue = DefaultValue.Mock };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetAlertPolicy(It.IsAny<GetAlertPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            AlertPolicy response = client.GetAlertPolicy(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAlertPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient> { DefaultValue = DefaultValue.Mock };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name2-1052831874",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateAlertPolicy(It.IsAny<CreateAlertPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            AlertPolicy response = client.CreateAlertPolicy(name, alertPolicy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteAlertPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteAlertPolicy(It.IsAny<DeleteAlertPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            AlertPolicyName name = new AlertPolicyName("[PROJECT]", "[ALERT_POLICY]");
            client.DeleteAlertPolicy(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateAlertPolicyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<AlertPolicyService.AlertPolicyServiceClient> mockGrpcClient = new Mock<AlertPolicyService.AlertPolicyServiceClient> { DefaultValue = DefaultValue.Mock };
            AlertPolicy expectedResponse = new AlertPolicy
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateAlertPolicy(It.IsAny<UpdateAlertPolicyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            AlertPolicyServiceClient client = new AlertPolicyServiceClientImpl(mockGrpcClient.Object, null);
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            AlertPolicy response = client.UpdateAlertPolicy(updateMask, alertPolicy);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
