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

namespace Google.Cloud.Irm.V1Alpha2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Irm.V1Alpha2;
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
    public class GeneratedIncidentServiceClientTest
    {
        [Fact]
        public void CreateIncident()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRequest expectedRequest = new CreateIncidentRequest
            {
                Incident = new Incident(),
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.CreateIncident(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident incident = new Incident();
            ProjectName parent = new ProjectName("[PROJECT]");
            Incident response = client.CreateIncident(incident, parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIncidentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRequest expectedRequest = new CreateIncidentRequest
            {
                Incident = new Incident(),
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident incident = new Incident();
            ProjectName parent = new ProjectName("[PROJECT]");
            Incident response = await client.CreateIncidentAsync(incident, parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIncident2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRequest request = new CreateIncidentRequest
            {
                Incident = new Incident(),
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.CreateIncident(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident response = client.CreateIncident(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIncidentAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRequest request = new CreateIncidentRequest
            {
                Incident = new Incident(),
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident response = await client.CreateIncidentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIncident()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetIncidentRequest expectedRequest = new GetIncidentRequest
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.GetIncident(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName name = new IncidentName("[PROJECT]", "[INCIDENT]");
            Incident response = client.GetIncident(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIncidentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetIncidentRequest expectedRequest = new GetIncidentRequest
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.GetIncidentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName name = new IncidentName("[PROJECT]", "[INCIDENT]");
            Incident response = await client.GetIncidentAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIncident2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetIncidentRequest request = new GetIncidentRequest
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.GetIncident(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident response = client.GetIncident(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIncidentAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetIncidentRequest request = new GetIncidentRequest
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.GetIncidentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident response = await client.GetIncidentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateIncident()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateIncidentRequest expectedRequest = new UpdateIncidentRequest
            {
                Incident = new Incident(),
                UpdateMask = new FieldMask(),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.UpdateIncident(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident incident = new Incident();
            FieldMask updateMask = new FieldMask();
            Incident response = client.UpdateIncident(incident, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateIncidentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateIncidentRequest expectedRequest = new UpdateIncidentRequest
            {
                Incident = new Incident(),
                UpdateMask = new FieldMask(),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.UpdateIncidentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident incident = new Incident();
            FieldMask updateMask = new FieldMask();
            Incident response = await client.UpdateIncidentAsync(incident, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateIncident2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateIncidentRequest request = new UpdateIncidentRequest
            {
                Incident = new Incident(),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.UpdateIncident(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident response = client.UpdateIncident(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateIncidentAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateIncidentRequest request = new UpdateIncidentRequest
            {
                Incident = new Incident(),
            };
            Incident expectedResponse = new Incident
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Title = "title110371416",
                Etag = "etag3123477",
                DuplicateIncident = "duplicateIncident-316496506",
            };
            mockGrpcClient.Setup(x => x.UpdateIncidentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident response = await client.UpdateIncidentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAnnotation()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateAnnotationRequest expectedRequest = new CreateAnnotationRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                AnnotationName = new AnnotationName("[PROJECT]", "[INCIDENT]", "[ANNOTATION]"),
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateAnnotation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Annotation annotation = new Annotation();
            Annotation response = client.CreateAnnotation(parent, annotation);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAnnotationAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateAnnotationRequest expectedRequest = new CreateAnnotationRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                AnnotationName = new AnnotationName("[PROJECT]", "[INCIDENT]", "[ANNOTATION]"),
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Annotation>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Annotation annotation = new Annotation();
            Annotation response = await client.CreateAnnotationAsync(parent, annotation);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAnnotation2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                AnnotationName = new AnnotationName("[PROJECT]", "[INCIDENT]", "[ANNOTATION]"),
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateAnnotation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Annotation response = client.CreateAnnotation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAnnotationAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                AnnotationName = new AnnotationName("[PROJECT]", "[INCIDENT]", "[ANNOTATION]"),
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Annotation>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Annotation response = await client.CreateAnnotationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTag()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest expectedRequest = new CreateTagRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateTag(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Tag tag = new Tag();
            Tag response = client.CreateTag(parent, tag);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTagAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest expectedRequest = new CreateTagRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tag>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Tag tag = new Tag();
            Tag response = await client.CreateTagAsync(parent, tag);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTag2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateTag(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Tag response = client.CreateTag(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTagAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
                DisplayName = "displayName1615086568",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tag>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Tag response = await client.CreateTagAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTag()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteTagRequest expectedRequest = new DeleteTagRequest
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTag(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            TagName name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]");
            client.DeleteTag(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTagAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteTagRequest expectedRequest = new DeleteTagRequest
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTagAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            TagName name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]");
            await client.DeleteTagAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTag2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTag(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTag(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTagAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTagAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTagAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSignal()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSignalRequest expectedRequest = new CreateSignalRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateSignal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Signal signal = new Signal();
            Signal response = client.CreateSignal(parent, signal);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSignalAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSignalRequest expectedRequest = new CreateSignalRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateSignalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Signal signal = new Signal();
            Signal response = await client.CreateSignalAsync(parent, signal);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSignal2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSignalRequest request = new CreateSignalRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateSignal(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal response = client.CreateSignal(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSignalAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSignalRequest request = new CreateSignalRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateSignalAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal response = await client.CreateSignalAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSignal()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetSignalRequest expectedRequest = new GetSignalRequest
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.GetSignal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            SignalName name = new SignalName("[PROJECT]", "[SIGNAL]");
            Signal response = client.GetSignal(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSignalAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetSignalRequest expectedRequest = new GetSignalRequest
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.GetSignalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            SignalName name = new SignalName("[PROJECT]", "[SIGNAL]");
            Signal response = await client.GetSignalAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSignal2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetSignalRequest request = new GetSignalRequest
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.GetSignal(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal response = client.GetSignal(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSignalAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetSignalRequest request = new GetSignalRequest
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.GetSignalAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal response = await client.GetSignalAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSignal()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSignalRequest expectedRequest = new UpdateSignalRequest
            {
                Signal = new Signal(),
                UpdateMask = new FieldMask(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateSignal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal signal = new Signal();
            FieldMask updateMask = new FieldMask();
            Signal response = client.UpdateSignal(signal, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSignalAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSignalRequest expectedRequest = new UpdateSignalRequest
            {
                Signal = new Signal(),
                UpdateMask = new FieldMask(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateSignalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal signal = new Signal();
            FieldMask updateMask = new FieldMask();
            Signal response = await client.UpdateSignalAsync(signal, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSignal2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSignalRequest request = new UpdateSignalRequest
            {
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateSignal(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal response = client.UpdateSignal(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSignalAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSignalRequest request = new UpdateSignalRequest
            {
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateSignalAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Signal response = await client.UpdateSignalAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void EscalateIncident()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            EscalateIncidentRequest request = new EscalateIncidentRequest
            {
                Incident = new Incident(),
            };
            EscalateIncidentResponse expectedResponse = new EscalateIncidentResponse();
            mockGrpcClient.Setup(x => x.EscalateIncident(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            EscalateIncidentResponse response = client.EscalateIncident(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task EscalateIncidentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            EscalateIncidentRequest request = new EscalateIncidentRequest
            {
                Incident = new Incident(),
            };
            EscalateIncidentResponse expectedResponse = new EscalateIncidentResponse();
            mockGrpcClient.Setup(x => x.EscalateIncidentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EscalateIncidentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            EscalateIncidentResponse response = await client.EscalateIncidentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateArtifact()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateArtifactRequest expectedRequest = new CreateArtifactRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Artifact artifact = new Artifact();
            Artifact response = client.CreateArtifact(parent, artifact);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateArtifactAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateArtifactRequest expectedRequest = new CreateArtifactRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Artifact>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Artifact artifact = new Artifact();
            Artifact response = await client.CreateArtifactAsync(parent, artifact);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateArtifact2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Artifact response = client.CreateArtifact(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateArtifactAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Artifact>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Artifact response = await client.CreateArtifactAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateArtifact()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateArtifactRequest expectedRequest = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new FieldMask(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifact(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Artifact artifact = new Artifact();
            FieldMask updateMask = new FieldMask();
            Artifact response = client.UpdateArtifact(artifact, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateArtifactAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateArtifactRequest expectedRequest = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
                UpdateMask = new FieldMask(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifactAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Artifact>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Artifact artifact = new Artifact();
            FieldMask updateMask = new FieldMask();
            Artifact response = await client.UpdateArtifactAsync(artifact, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateArtifact2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifact(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Artifact response = client.UpdateArtifact(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateArtifactAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.UpdateArtifactAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Artifact>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Artifact response = await client.UpdateArtifactAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteArtifact()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteArtifactRequest expectedRequest = new DeleteArtifactRequest
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifact(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            ArtifactName name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]");
            client.DeleteArtifact(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteArtifactAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteArtifactRequest expectedRequest = new DeleteArtifactRequest
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            ArtifactName name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]");
            await client.DeleteArtifactAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteArtifact2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifact(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteArtifact(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteArtifactAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteArtifactAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SendShiftHandoff()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            SendShiftHandoffRequest request = new SendShiftHandoffRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Recipients = { },
                Subject = "subject-1867885268",
            };
            SendShiftHandoffResponse expectedResponse = new SendShiftHandoffResponse
            {
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.SendShiftHandoff(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            SendShiftHandoffResponse response = client.SendShiftHandoff(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SendShiftHandoffAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            SendShiftHandoffRequest request = new SendShiftHandoffRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Recipients = { },
                Subject = "subject-1867885268",
            };
            SendShiftHandoffResponse expectedResponse = new SendShiftHandoffResponse
            {
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.SendShiftHandoffAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SendShiftHandoffResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            SendShiftHandoffResponse response = await client.SendShiftHandoffAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSubscription()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSubscriptionRequest expectedRequest = new CreateSubscriptionRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Subscription subscription = new Subscription();
            Subscription response = client.CreateSubscription(parent, subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSubscriptionAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSubscriptionRequest expectedRequest = new CreateSubscriptionRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Subscription subscription = new Subscription();
            Subscription response = await client.CreateSubscriptionAsync(parent, subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSubscription2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.CreateSubscription(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSubscriptionAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = await client.CreateSubscriptionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSubscription()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSubscriptionRequest expectedRequest = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            Subscription response = client.UpdateSubscription(subscription, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSubscriptionAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSubscriptionRequest expectedRequest = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            Subscription response = await client.UpdateSubscriptionAsync(subscription, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSubscription2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = client.UpdateSubscription(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSubscriptionAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.UpdateSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Subscription response = await client.UpdateSubscriptionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSubscription()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest expectedRequest = new DeleteSubscriptionRequest
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]");
            client.DeleteSubscription(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSubscriptionAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest expectedRequest = new DeleteSubscriptionRequest
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]");
            await client.DeleteSubscriptionAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSubscription2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscription(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSubscription(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSubscriptionAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSubscriptionAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIncidentRoleAssignment()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRoleAssignmentRequest expectedRequest = new CreateIncidentRoleAssignmentRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentRoleAssignment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            IncidentRoleAssignment incidentRoleAssignment = new IncidentRoleAssignment();
            IncidentRoleAssignment response = client.CreateIncidentRoleAssignment(parent, incidentRoleAssignment);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIncidentRoleAssignmentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRoleAssignmentRequest expectedRequest = new CreateIncidentRoleAssignmentRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentRoleAssignmentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            IncidentRoleAssignment incidentRoleAssignment = new IncidentRoleAssignment();
            IncidentRoleAssignment response = await client.CreateIncidentRoleAssignmentAsync(parent, incidentRoleAssignment);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIncidentRoleAssignment2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRoleAssignmentRequest request = new CreateIncidentRoleAssignmentRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentRoleAssignment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = client.CreateIncidentRoleAssignment(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIncidentRoleAssignmentAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRoleAssignmentRequest request = new CreateIncidentRoleAssignmentRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentRoleAssignmentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = await client.CreateIncidentRoleAssignmentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIncidentRoleAssignment()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteIncidentRoleAssignmentRequest expectedRequest = new DeleteIncidentRoleAssignmentRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIncidentRoleAssignment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            client.DeleteIncidentRoleAssignment(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIncidentRoleAssignmentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteIncidentRoleAssignmentRequest expectedRequest = new DeleteIncidentRoleAssignmentRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIncidentRoleAssignmentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            await client.DeleteIncidentRoleAssignmentAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIncidentRoleAssignment2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteIncidentRoleAssignmentRequest request = new DeleteIncidentRoleAssignmentRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIncidentRoleAssignment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteIncidentRoleAssignment(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIncidentRoleAssignmentAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteIncidentRoleAssignmentRequest request = new DeleteIncidentRoleAssignmentRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIncidentRoleAssignmentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIncidentRoleAssignmentAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RequestIncidentRoleHandover()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            RequestIncidentRoleHandoverRequest expectedRequest = new RequestIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.RequestIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = client.RequestIncidentRoleHandover(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RequestIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            RequestIncidentRoleHandoverRequest expectedRequest = new RequestIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.RequestIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.RequestIncidentRoleHandoverAsync(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RequestIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            RequestIncidentRoleHandoverRequest request = new RequestIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.RequestIncidentRoleHandover(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = client.RequestIncidentRoleHandover(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RequestIncidentRoleHandoverAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            RequestIncidentRoleHandoverRequest request = new RequestIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.RequestIncidentRoleHandoverAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = await client.RequestIncidentRoleHandoverAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ConfirmIncidentRoleHandover()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ConfirmIncidentRoleHandoverRequest expectedRequest = new ConfirmIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ConfirmIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = client.ConfirmIncidentRoleHandover(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ConfirmIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ConfirmIncidentRoleHandoverRequest expectedRequest = new ConfirmIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ConfirmIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.ConfirmIncidentRoleHandoverAsync(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ConfirmIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ConfirmIncidentRoleHandoverRequest request = new ConfirmIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ConfirmIncidentRoleHandover(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = client.ConfirmIncidentRoleHandover(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ConfirmIncidentRoleHandoverAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ConfirmIncidentRoleHandoverRequest request = new ConfirmIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ConfirmIncidentRoleHandoverAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = await client.ConfirmIncidentRoleHandoverAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ForceIncidentRoleHandover()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ForceIncidentRoleHandoverRequest expectedRequest = new ForceIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ForceIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = client.ForceIncidentRoleHandover(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ForceIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ForceIncidentRoleHandoverRequest expectedRequest = new ForceIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ForceIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.ForceIncidentRoleHandoverAsync(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ForceIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ForceIncidentRoleHandoverRequest request = new ForceIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ForceIncidentRoleHandover(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = client.ForceIncidentRoleHandover(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ForceIncidentRoleHandoverAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ForceIncidentRoleHandoverRequest request = new ForceIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ForceIncidentRoleHandoverAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = await client.ForceIncidentRoleHandoverAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelIncidentRoleHandover()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CancelIncidentRoleHandoverRequest expectedRequest = new CancelIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CancelIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = client.CancelIncidentRoleHandover(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CancelIncidentRoleHandoverRequest expectedRequest = new CancelIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CancelIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.CancelIncidentRoleHandoverAsync(name, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CancelIncidentRoleHandoverRequest request = new CancelIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CancelIncidentRoleHandover(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = client.CancelIncidentRoleHandover(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelIncidentRoleHandoverAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CancelIncidentRoleHandoverRequest request = new CancelIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CancelIncidentRoleHandoverAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            IncidentRoleAssignment response = await client.CancelIncidentRoleHandoverAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
