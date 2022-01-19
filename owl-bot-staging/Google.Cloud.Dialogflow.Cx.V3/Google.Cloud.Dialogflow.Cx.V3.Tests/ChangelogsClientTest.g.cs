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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedChangelogsClientTest
    {
        [xunit::FactAttribute]
        public void GetChangelogRequestObject()
        {
            moq::Mock<Changelogs.ChangelogsClient> mockGrpcClient = new moq::Mock<Changelogs.ChangelogsClient>(moq::MockBehavior.Strict);
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            Changelog expectedResponse = new Changelog
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
                UserEmail = "user_emaildc7bc240",
                Resource = "resource164eab96",
                CreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Action = "action09558c41",
            };
            mockGrpcClient.Setup(x => x.GetChangelog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangelogsClient client = new ChangelogsClientImpl(mockGrpcClient.Object, null);
            Changelog response = client.GetChangelog(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChangelogRequestObjectAsync()
        {
            moq::Mock<Changelogs.ChangelogsClient> mockGrpcClient = new moq::Mock<Changelogs.ChangelogsClient>(moq::MockBehavior.Strict);
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            Changelog expectedResponse = new Changelog
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
                UserEmail = "user_emaildc7bc240",
                Resource = "resource164eab96",
                CreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Action = "action09558c41",
            };
            mockGrpcClient.Setup(x => x.GetChangelogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Changelog>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangelogsClient client = new ChangelogsClientImpl(mockGrpcClient.Object, null);
            Changelog responseCallSettings = await client.GetChangelogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Changelog responseCancellationToken = await client.GetChangelogAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetChangelog()
        {
            moq::Mock<Changelogs.ChangelogsClient> mockGrpcClient = new moq::Mock<Changelogs.ChangelogsClient>(moq::MockBehavior.Strict);
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            Changelog expectedResponse = new Changelog
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
                UserEmail = "user_emaildc7bc240",
                Resource = "resource164eab96",
                CreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Action = "action09558c41",
            };
            mockGrpcClient.Setup(x => x.GetChangelog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangelogsClient client = new ChangelogsClientImpl(mockGrpcClient.Object, null);
            Changelog response = client.GetChangelog(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChangelogAsync()
        {
            moq::Mock<Changelogs.ChangelogsClient> mockGrpcClient = new moq::Mock<Changelogs.ChangelogsClient>(moq::MockBehavior.Strict);
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            Changelog expectedResponse = new Changelog
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
                UserEmail = "user_emaildc7bc240",
                Resource = "resource164eab96",
                CreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Action = "action09558c41",
            };
            mockGrpcClient.Setup(x => x.GetChangelogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Changelog>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangelogsClient client = new ChangelogsClientImpl(mockGrpcClient.Object, null);
            Changelog responseCallSettings = await client.GetChangelogAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Changelog responseCancellationToken = await client.GetChangelogAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetChangelogResourceNames()
        {
            moq::Mock<Changelogs.ChangelogsClient> mockGrpcClient = new moq::Mock<Changelogs.ChangelogsClient>(moq::MockBehavior.Strict);
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            Changelog expectedResponse = new Changelog
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
                UserEmail = "user_emaildc7bc240",
                Resource = "resource164eab96",
                CreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Action = "action09558c41",
            };
            mockGrpcClient.Setup(x => x.GetChangelog(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangelogsClient client = new ChangelogsClientImpl(mockGrpcClient.Object, null);
            Changelog response = client.GetChangelog(request.ChangelogName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetChangelogResourceNamesAsync()
        {
            moq::Mock<Changelogs.ChangelogsClient> mockGrpcClient = new moq::Mock<Changelogs.ChangelogsClient>(moq::MockBehavior.Strict);
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            Changelog expectedResponse = new Changelog
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
                UserEmail = "user_emaildc7bc240",
                Resource = "resource164eab96",
                CreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = "typee2cc9d59",
                Action = "action09558c41",
            };
            mockGrpcClient.Setup(x => x.GetChangelogAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Changelog>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangelogsClient client = new ChangelogsClientImpl(mockGrpcClient.Object, null);
            Changelog responseCallSettings = await client.GetChangelogAsync(request.ChangelogName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Changelog responseCancellationToken = await client.GetChangelogAsync(request.ChangelogName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
