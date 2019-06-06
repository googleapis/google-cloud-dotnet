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

namespace Grafeas.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using apis = global::Grafeas.V1;
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
    public class GeneratedGrafeasClientTest
    {
        [Fact]
        public void GetOccurrence()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceRequest expectedRequest = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.GetOccurrence(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence response = client.GetOccurrence(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOccurrenceAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceRequest expectedRequest = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Occurrence>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence response = await client.GetOccurrenceAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOccurrence2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.GetOccurrence(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.GetOccurrence(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOccurrenceAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Occurrence>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = await client.GetOccurrenceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteOccurrence()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteOccurrenceRequest expectedRequest = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOccurrence(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            client.DeleteOccurrence(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteOccurrenceAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteOccurrenceRequest expectedRequest = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOccurrenceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            await client.DeleteOccurrenceAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteOccurrence2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOccurrence(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteOccurrence(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteOccurrenceAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteOccurrenceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteOccurrenceAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateOccurrence()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateOccurrenceRequest expectedRequest = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.CreateOccurrence(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            Occurrence response = client.CreateOccurrence(parent, occurrence);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateOccurrenceAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateOccurrenceRequest expectedRequest = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.CreateOccurrenceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Occurrence>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            Occurrence response = await client.CreateOccurrenceAsync(parent, occurrence);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateOccurrence2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.CreateOccurrence(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.CreateOccurrence(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateOccurrenceAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.CreateOccurrenceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Occurrence>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = await client.CreateOccurrenceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchCreateOccurrences()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateOccurrencesRequest expectedRequest = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateOccurrences(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new List<Occurrence>();
            BatchCreateOccurrencesResponse response = client.BatchCreateOccurrences(parent, occurrences);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchCreateOccurrencesAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateOccurrencesRequest expectedRequest = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateOccurrencesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchCreateOccurrencesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new List<Occurrence>();
            BatchCreateOccurrencesResponse response = await client.BatchCreateOccurrencesAsync(parent, occurrences);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchCreateOccurrences2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateOccurrences(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse response = client.BatchCreateOccurrences(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchCreateOccurrencesAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            BatchCreateOccurrencesResponse expectedResponse = new BatchCreateOccurrencesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateOccurrencesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchCreateOccurrencesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateOccurrencesResponse response = await client.BatchCreateOccurrencesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateOccurrence()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateOccurrenceRequest expectedRequest = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrence(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            Occurrence response = client.UpdateOccurrence(name, occurrence, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateOccurrenceAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateOccurrenceRequest expectedRequest = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new FieldMask(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrenceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Occurrence>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            Occurrence response = await client.UpdateOccurrenceAsync(name, occurrence, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateOccurrence2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrence(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = client.UpdateOccurrence(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateOccurrenceAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
            };
            Occurrence expectedResponse = new Occurrence
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                ResourceUri = "resourceUri-384040517",
                NoteName = "noteName1780787896",
                Remediation = "remediation779381797",
            };
            mockGrpcClient.Setup(x => x.UpdateOccurrenceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Occurrence>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Occurrence response = await client.UpdateOccurrenceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOccurrenceNote()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceNoteRequest expectedRequest = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNote(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Note response = client.GetOccurrenceNote(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOccurrenceNoteAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceNoteRequest expectedRequest = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNoteAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Note response = await client.GetOccurrenceNoteAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOccurrenceNote2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNote(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetOccurrenceNote(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOccurrenceNoteAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetOccurrenceNoteAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = await client.GetOccurrenceNoteAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNote()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetNoteRequest expectedRequest = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetNote(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note response = client.GetNote(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNoteAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetNoteRequest expectedRequest = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetNoteAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note response = await client.GetNoteAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNote2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetNote(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.GetNote(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNoteAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.GetNoteAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = await client.GetNoteAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNote()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteNoteRequest expectedRequest = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNote(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            client.DeleteNote(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteNoteAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteNoteRequest expectedRequest = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNoteAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            await client.DeleteNoteAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNote2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNote(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            client.DeleteNote(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteNoteAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteNoteAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            await client.DeleteNoteAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNote()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateNoteRequest expectedRequest = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "noteId2129224840",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.CreateNote(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            string noteId = "noteId2129224840";
            Note note = new Note();
            Note response = client.CreateNote(parent, noteId, note);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateNoteAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateNoteRequest expectedRequest = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "noteId2129224840",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.CreateNoteAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            string noteId = "noteId2129224840";
            Note note = new Note();
            Note response = await client.CreateNoteAsync(parent, noteId, note);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNote2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "noteId2129224840",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.CreateNote(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.CreateNote(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateNoteAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "noteId2129224840",
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.CreateNoteAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = await client.CreateNoteAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchCreateNotes()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateNotesRequest expectedRequest = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateNotes(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note>();
            BatchCreateNotesResponse response = client.BatchCreateNotes(parent, notes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchCreateNotesAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateNotesRequest expectedRequest = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateNotesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchCreateNotesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note>();
            BatchCreateNotesResponse response = await client.BatchCreateNotesAsync(parent, notes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchCreateNotes2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateNotes(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse response = client.BatchCreateNotes(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchCreateNotesAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            BatchCreateNotesResponse expectedResponse = new BatchCreateNotesResponse();
            mockGrpcClient.Setup(x => x.BatchCreateNotesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchCreateNotesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            BatchCreateNotesResponse response = await client.BatchCreateNotesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateNote()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateNoteRequest expectedRequest = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.UpdateNote(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            Note response = client.UpdateNote(name, note, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateNoteAsync()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateNoteRequest expectedRequest = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new FieldMask(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.UpdateNoteAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            Note response = await client.UpdateNoteAsync(name, note, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateNote2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.UpdateNote(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = client.UpdateNote(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateNoteAsync2()
        {
            Mock<Grafeas.GrafeasClient> mockGrpcClient = new Mock<Grafeas.GrafeasClient>(MockBehavior.Strict);
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
            };
            Note expectedResponse = new Note
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                ShortDescription = "shortDescription-235369287",
                LongDescription = "longDescription-1747792199",
            };
            mockGrpcClient.Setup(x => x.UpdateNoteAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Note>(Task.FromResult(expectedResponse), null, null, null, null));
            GrafeasClient client = new GrafeasClientImpl(mockGrpcClient.Object, null);
            Note response = await client.UpdateNoteAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
