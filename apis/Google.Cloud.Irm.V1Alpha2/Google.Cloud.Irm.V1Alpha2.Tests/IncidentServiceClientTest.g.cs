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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncident(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident incident = new Incident();
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Incident response = client.CreateIncident(incident, formattedParent);
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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Incident incident = new Incident();
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Incident response = await client.CreateIncidentAsync(incident, formattedParent);
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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Name = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name2-1052831874",
                Title = "title110371416",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetIncident(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Incident response = client.GetIncident(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIncidentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetIncidentRequest expectedRequest = new GetIncidentRequest
            {
                Name = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name2-1052831874",
                Title = "title110371416",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.GetIncidentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Incident>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Incident response = await client.GetIncidentAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIncident2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetIncidentRequest request = new GetIncidentRequest
            {
                Name = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name2-1052831874",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Name = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
            };
            Incident expectedResponse = new Incident
            {
                Name = "name2-1052831874",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Name = "name3373707",
                Title = "title110371416",
                Etag = "etag3123477",
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateAnnotation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Annotation annotation = new Annotation();
            Annotation response = client.CreateAnnotation(formattedParent, annotation);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateAnnotationAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateAnnotationRequest expectedRequest = new CreateAnnotationRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateAnnotationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Annotation>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Annotation annotation = new Annotation();
            Annotation response = await client.CreateAnnotationAsync(formattedParent, annotation);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateAnnotation2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
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
        public void UpdateAnnotation()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateAnnotationRequest expectedRequest = new UpdateAnnotationRequest
            {
                Annotation = new Annotation(),
                UpdateMask = new FieldMask(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateAnnotation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Annotation annotation = new Annotation();
            FieldMask updateMask = new FieldMask();
            Annotation response = client.UpdateAnnotation(annotation, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateAnnotationAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateAnnotationRequest expectedRequest = new UpdateAnnotationRequest
            {
                Annotation = new Annotation(),
                UpdateMask = new FieldMask(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateAnnotationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Annotation>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Annotation annotation = new Annotation();
            FieldMask updateMask = new FieldMask();
            Annotation response = await client.UpdateAnnotationAsync(annotation, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateAnnotation2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateAnnotationRequest request = new UpdateAnnotationRequest
            {
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateAnnotation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Annotation response = client.UpdateAnnotation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateAnnotationAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            UpdateAnnotationRequest request = new UpdateAnnotationRequest
            {
                Annotation = new Annotation(),
            };
            Annotation expectedResponse = new Annotation
            {
                Name = "name3373707",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.UpdateAnnotationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Annotation>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            Annotation response = await client.UpdateAnnotationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTag()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest expectedRequest = new CreateTagRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateTag(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Tag tag = new Tag();
            Tag response = client.CreateTag(formattedParent, tag);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTagAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest expectedRequest = new CreateTagRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateTagAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Tag>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Tag tag = new Tag();
            Tag response = await client.CreateTagAsync(formattedParent, tag);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTag2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateTagRequest request = new CreateTagRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Url = "url116079",
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Tag = new Tag(),
            };
            Tag expectedResponse = new Tag
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Url = "url116079",
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
                Name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTag(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]").ToString();
            client.DeleteTag(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTagAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteTagRequest expectedRequest = new DeleteTagRequest
            {
                Name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTagAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]").ToString();
            await client.DeleteTagAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTag2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteTagRequest request = new DeleteTagRequest
            {
                Name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]").ToString(),
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
                Name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]").ToString(),
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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateSignal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Signal signal = new Signal();
            Signal response = client.CreateSignal(formattedParent, signal);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSignalAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSignalRequest expectedRequest = new CreateSignalRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name3373707",
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.CreateSignalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Signal signal = new Signal();
            Signal response = await client.CreateSignalAsync(formattedParent, signal);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSignal2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSignalRequest request = new CreateSignalRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name3373707",
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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Signal = new Signal(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name3373707",
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
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.GetSignal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new SignalName("[PROJECT]", "[SIGNAL]").ToString();
            Signal response = client.GetSignal(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSignalAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetSignalRequest expectedRequest = new GetSignalRequest
            {
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
                Incident = "incident86983890",
                Title = "title110371416",
                ContentType = "contentType831846208",
                Content = "content951530617",
            };
            mockGrpcClient.Setup(x => x.GetSignalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Signal>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new SignalName("[PROJECT]", "[SIGNAL]").ToString();
            Signal response = await client.GetSignalAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSignal2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetSignalRequest request = new GetSignalRequest
            {
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name2-1052831874",
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
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            Signal expectedResponse = new Signal
            {
                Name = "name2-1052831874",
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
                Name = "name3373707",
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
                Name = "name3373707",
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
                Name = "name3373707",
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
                Name = "name3373707",
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
        public void AcknowledgeSignal()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            AcknowledgeSignalRequest expectedRequest = new AcknowledgeSignalRequest
            {
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            AcknowledgeSignalResponse expectedResponse = new AcknowledgeSignalResponse();
            mockGrpcClient.Setup(x => x.AcknowledgeSignal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new SignalName("[PROJECT]", "[SIGNAL]").ToString();
            AcknowledgeSignalResponse response = client.AcknowledgeSignal(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AcknowledgeSignalAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            AcknowledgeSignalRequest expectedRequest = new AcknowledgeSignalRequest
            {
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            AcknowledgeSignalResponse expectedResponse = new AcknowledgeSignalResponse();
            mockGrpcClient.Setup(x => x.AcknowledgeSignalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AcknowledgeSignalResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new SignalName("[PROJECT]", "[SIGNAL]").ToString();
            AcknowledgeSignalResponse response = await client.AcknowledgeSignalAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AcknowledgeSignal2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            AcknowledgeSignalRequest request = new AcknowledgeSignalRequest
            {
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            AcknowledgeSignalResponse expectedResponse = new AcknowledgeSignalResponse();
            mockGrpcClient.Setup(x => x.AcknowledgeSignal(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            AcknowledgeSignalResponse response = client.AcknowledgeSignal(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AcknowledgeSignalAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            AcknowledgeSignalRequest request = new AcknowledgeSignalRequest
            {
                Name = new SignalName("[PROJECT]", "[SIGNAL]").ToString(),
            };
            AcknowledgeSignalResponse expectedResponse = new AcknowledgeSignalResponse();
            mockGrpcClient.Setup(x => x.AcknowledgeSignalAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AcknowledgeSignalResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            AcknowledgeSignalResponse response = await client.AcknowledgeSignalAsync(request);
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateArtifact(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Artifact artifact = new Artifact();
            Artifact response = client.CreateArtifact(formattedParent, artifact);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateArtifactAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateArtifactRequest expectedRequest = new CreateArtifactRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                Name = "name3373707",
                DisplayName = "displayName1615086568",
                Etag = "etag3123477",
                Url = "url116079",
            };
            mockGrpcClient.Setup(x => x.CreateArtifactAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Artifact>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Artifact artifact = new Artifact();
            Artifact response = await client.CreateArtifactAsync(formattedParent, artifact);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateArtifact2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                Name = "name3373707",
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Artifact = new Artifact(),
            };
            Artifact expectedResponse = new Artifact
            {
                Name = "name3373707",
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
                Name = "name3373707",
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
                Name = "name3373707",
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
                Name = "name3373707",
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
                Name = "name3373707",
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
                Name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifact(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]").ToString();
            client.DeleteArtifact(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteArtifactAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteArtifactRequest expectedRequest = new DeleteArtifactRequest
            {
                Name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]").ToString();
            await client.DeleteArtifactAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteArtifact2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                Name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]").ToString(),
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
                Name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteArtifactAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteArtifactAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetShiftHandoffPresets()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetShiftHandoffPresetsRequest expectedRequest = new GetShiftHandoffPresetsRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            ShiftHandoffPresets expectedResponse = new ShiftHandoffPresets
            {
                Subject = "subject-1867885268",
            };
            mockGrpcClient.Setup(x => x.GetShiftHandoffPresets(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            ShiftHandoffPresets response = client.GetShiftHandoffPresets(formattedParent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetShiftHandoffPresetsAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetShiftHandoffPresetsRequest expectedRequest = new GetShiftHandoffPresetsRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            ShiftHandoffPresets expectedResponse = new ShiftHandoffPresets
            {
                Subject = "subject-1867885268",
            };
            mockGrpcClient.Setup(x => x.GetShiftHandoffPresetsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ShiftHandoffPresets>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            ShiftHandoffPresets response = await client.GetShiftHandoffPresetsAsync(formattedParent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetShiftHandoffPresets2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetShiftHandoffPresetsRequest request = new GetShiftHandoffPresetsRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            ShiftHandoffPresets expectedResponse = new ShiftHandoffPresets
            {
                Subject = "subject-1867885268",
            };
            mockGrpcClient.Setup(x => x.GetShiftHandoffPresets(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            ShiftHandoffPresets response = client.GetShiftHandoffPresets(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetShiftHandoffPresetsAsync2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            GetShiftHandoffPresetsRequest request = new GetShiftHandoffPresetsRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            ShiftHandoffPresets expectedResponse = new ShiftHandoffPresets
            {
                Subject = "subject-1867885268",
            };
            mockGrpcClient.Setup(x => x.GetShiftHandoffPresetsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ShiftHandoffPresets>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            ShiftHandoffPresets response = await client.GetShiftHandoffPresetsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SendShiftHandoff()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            SendShiftHandoffRequest request = new SendShiftHandoffRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
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
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                Name = "name3373707",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Subscription subscription = new Subscription();
            Subscription response = client.CreateSubscription(formattedParent, subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSubscriptionAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSubscriptionRequest expectedRequest = new CreateSubscriptionRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                Name = "name3373707",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Subscription>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            Subscription subscription = new Subscription();
            Subscription response = await client.CreateSubscriptionAsync(formattedParent, subscription);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSubscription2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                Name = "name3373707",
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                Subscription = new Subscription(),
            };
            Subscription expectedResponse = new Subscription
            {
                Name = "name3373707",
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
        public void DeleteSubscription()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest expectedRequest = new DeleteSubscriptionRequest
            {
                Name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscription(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]").ToString();
            client.DeleteSubscription(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSubscriptionAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest expectedRequest = new DeleteSubscriptionRequest
            {
                Name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSubscriptionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]").ToString();
            await client.DeleteSubscriptionAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSubscription2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                Name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]").ToString(),
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
                Name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]").ToString(),
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name3373707",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentRoleAssignment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            IncidentRoleAssignment incidentRoleAssignment = new IncidentRoleAssignment();
            IncidentRoleAssignment response = client.CreateIncidentRoleAssignment(formattedParent, incidentRoleAssignment);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateIncidentRoleAssignmentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRoleAssignmentRequest expectedRequest = new CreateIncidentRoleAssignmentRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name3373707",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CreateIncidentRoleAssignmentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            IncidentRoleAssignment incidentRoleAssignment = new IncidentRoleAssignment();
            IncidentRoleAssignment response = await client.CreateIncidentRoleAssignmentAsync(formattedParent, incidentRoleAssignment);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateIncidentRoleAssignment2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CreateIncidentRoleAssignmentRequest request = new CreateIncidentRoleAssignmentRequest
            {
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name3373707",
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
                Parent = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name3373707",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIncidentRoleAssignment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            client.DeleteIncidentRoleAssignment(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteIncidentRoleAssignmentAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteIncidentRoleAssignmentRequest expectedRequest = new DeleteIncidentRoleAssignmentRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteIncidentRoleAssignmentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            await client.DeleteIncidentRoleAssignmentAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteIncidentRoleAssignment2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            DeleteIncidentRoleAssignmentRequest request = new DeleteIncidentRoleAssignmentRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.RequestIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = client.RequestIncidentRoleHandover(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RequestIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            RequestIncidentRoleHandoverRequest expectedRequest = new RequestIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.RequestIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.RequestIncidentRoleHandoverAsync(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RequestIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            RequestIncidentRoleHandoverRequest request = new RequestIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ConfirmIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = client.ConfirmIncidentRoleHandover(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ConfirmIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ConfirmIncidentRoleHandoverRequest expectedRequest = new ConfirmIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ConfirmIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.ConfirmIncidentRoleHandoverAsync(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ConfirmIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ConfirmIncidentRoleHandoverRequest request = new ConfirmIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ForceIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = client.ForceIncidentRoleHandover(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ForceIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ForceIncidentRoleHandoverRequest expectedRequest = new ForceIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.ForceIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.ForceIncidentRoleHandoverAsync(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ForceIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            ForceIncidentRoleHandoverRequest request = new ForceIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CancelIncidentRoleHandover(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = client.CancelIncidentRoleHandover(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelIncidentRoleHandoverAsync()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CancelIncidentRoleHandoverRequest expectedRequest = new CancelIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
                Etag = "etag3123477",
            };
            mockGrpcClient.Setup(x => x.CancelIncidentRoleHandoverAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<IncidentRoleAssignment>(Task.FromResult(expectedResponse), null, null, null, null));
            IncidentServiceClient client = new IncidentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString();
            User newAssignee = new User();
            IncidentRoleAssignment response = await client.CancelIncidentRoleHandoverAsync(formattedName, newAssignee);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelIncidentRoleHandover2()
        {
            Mock<IncidentService.IncidentServiceClient> mockGrpcClient = new Mock<IncidentService.IncidentServiceClient>(MockBehavior.Strict);
            CancelIncidentRoleHandoverRequest request = new CancelIncidentRoleHandoverRequest
            {
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
                Name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]").ToString(),
                NewAssignee = new User(),
            };
            IncidentRoleAssignment expectedResponse = new IncidentRoleAssignment
            {
                Name = "name2-1052831874",
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
