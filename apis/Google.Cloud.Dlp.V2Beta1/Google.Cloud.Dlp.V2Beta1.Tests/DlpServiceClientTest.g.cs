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

namespace Google.Cloud.Dlp.V2Beta1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDlpServiceClientTest
    {
        [Fact]
        public void InspectContentTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient> { DefaultValue = DefaultValue.Mock };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.InspectContent(It.IsAny<InspectContentRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            IEnumerable<ContentItem> items = new[]
            {
                new ContentItem
                {
                    Type = "text/plain",
                    Value = "My email is example@example.com.",
                },
            };
            InspectContentResponse response = client.InspectContent(inspectConfig, items);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeidentifyContentTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient> { DefaultValue = DefaultValue.Mock };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeidentifyContent(It.IsAny<DeidentifyContentRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyConfig deidentifyConfig = new DeidentifyConfig();
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            DeidentifyContentResponse response = client.DeidentifyContent(deidentifyConfig, inspectConfig, items);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInspectFindingsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient> { DefaultValue = DefaultValue.Mock };
            ListInspectFindingsResponse expectedResponse = new ListInspectFindingsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListInspectFindings(It.IsAny<ListInspectFindingsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ResultName name = new ResultName("[RESULT]");
            ListInspectFindingsResponse response = client.ListInspectFindings(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInfoTypesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient> { DefaultValue = DefaultValue.Mock };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListInfoTypes(It.IsAny<ListInfoTypesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            string category = "PII";
            string languageCode = "en";
            ListInfoTypesResponse response = client.ListInfoTypes(category, languageCode);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListRootCategoriesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient> { DefaultValue = DefaultValue.Mock };
            ListRootCategoriesResponse expectedResponse = new ListRootCategoriesResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ListRootCategories(It.IsAny<ListRootCategoriesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            string languageCode = "en";
            ListRootCategoriesResponse response = client.ListRootCategories(languageCode);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
