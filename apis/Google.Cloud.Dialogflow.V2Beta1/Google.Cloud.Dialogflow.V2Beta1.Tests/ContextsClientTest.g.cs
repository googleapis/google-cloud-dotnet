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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedContextsClientTest
    {
        [xunit::FactAttribute]
        public void GetContextRequestObject()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.GetContext(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContextRequestObjectAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.GetContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.GetContextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContext()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.GetContext(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContextAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.GetContextAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.GetContextAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetContextResourceNames()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.GetContext(request.ContextName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetContextResourceNamesAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.GetContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.GetContextAsync(request.ContextName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.GetContextAsync(request.ContextName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContextRequestObject()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.CreateContext(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContextRequestObjectAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.CreateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.CreateContextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContext()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.CreateContext(request.Parent, request.Context);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContextAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.CreateContextAsync(request.Parent, request.Context, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.CreateContextAsync(request.Parent, request.Context, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateContextResourceNames()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.CreateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.CreateContext(request.ParentAsSessionName, request.Context);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateContextResourceNamesAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.CreateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.CreateContextAsync(request.ParentAsSessionName, request.Context, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.CreateContextAsync(request.ParentAsSessionName, request.Context, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContextRequestObject()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.UpdateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.UpdateContext(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContextRequestObjectAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.UpdateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.UpdateContextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContext1()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.UpdateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.UpdateContext(request.Context, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContext1Async()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new wkt::FieldMask(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.UpdateContextAsync(request.Context, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.UpdateContextAsync(request.Context, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateContext2()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.UpdateContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context response = client.UpdateContext(request.Context);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateContext2Async()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
            };
            Context expectedResponse = new Context
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
                LifespanCount = -2034952532,
                Parameters = new wkt::Struct(),
            };
            mockGrpcClient.Setup(x => x.UpdateContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Context>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            Context responseCallSettings = await client.UpdateContextAsync(request.Context, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Context responseCancellationToken = await client.UpdateContextAsync(request.Context, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContextRequestObject()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteContext(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContextRequestObjectAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContextAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContext()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteContext(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContextAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteContextAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContextAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteContextResourceNames()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContext(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteContext(request.ContextName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteContextResourceNamesAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteContextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteContextAsync(request.ContextName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteContextAsync(request.ContextName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAllContextsRequestObject()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAllContexts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAllContexts(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAllContextsRequestObjectAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAllContextsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAllContextsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAllContextsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAllContexts()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAllContexts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAllContexts(request.Parent);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAllContextsAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAllContextsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAllContextsAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAllContextsAsync(request.Parent, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAllContextsResourceNames()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAllContexts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAllContexts(request.ParentAsSessionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAllContextsResourceNamesAsync()
        {
            moq::Mock<Contexts.ContextsClient> mockGrpcClient = new moq::Mock<Contexts.ContextsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAllContextsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContextsClient client = new ContextsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAllContextsAsync(request.ParentAsSessionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAllContextsAsync(request.ParentAsSessionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
