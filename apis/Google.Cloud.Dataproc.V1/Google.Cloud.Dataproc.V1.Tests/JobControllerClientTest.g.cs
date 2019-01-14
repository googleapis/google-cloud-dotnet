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

namespace Google.Cloud.Dataproc.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
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
    public class GeneratedJobControllerClientTest
    {
        [Fact]
        public void SubmitJob()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            SubmitJobRequest expectedRequest = new SubmitJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.SubmitJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            Job job = new Job();
            Job response = client.SubmitJob(projectId, region, job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SubmitJobAsync()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            SubmitJobRequest expectedRequest = new SubmitJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.SubmitJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            Job job = new Job();
            Job response = await client.SubmitJobAsync(projectId, region, job);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SubmitJob2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.SubmitJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.SubmitJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SubmitJobAsync2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.SubmitJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.SubmitJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJob()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            GetJobRequest expectedRequest = new GetJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.GetJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            Job response = client.GetJob(projectId, region, jobId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobAsync()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            GetJobRequest expectedRequest = new GetJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            Job response = await client.GetJobAsync(projectId, region, jobId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJob2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.GetJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetJobAsync2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.GetJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateJob()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateJobAsync()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.UpdateJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelJob()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            CancelJobRequest expectedRequest = new CancelJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.CancelJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            Job response = client.CancelJob(projectId, region, jobId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelJobAsync()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            CancelJobRequest expectedRequest = new CancelJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.CancelJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            Job response = await client.CancelJobAsync(projectId, region, jobId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelJob2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.CancelJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CancelJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelJobAsync2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
                JobUuid = "jobUuid-1615012099",
            };
            mockGrpcClient.Setup(x => x.CancelJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Job>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = await client.CancelJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJob()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            DeleteJobRequest expectedRequest = new DeleteJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            client.DeleteJob(projectId, region, jobId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobAsync()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            DeleteJobRequest expectedRequest = new DeleteJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            await client.DeleteJobAsync(projectId, region, jobId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJob2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteJobAsync2()
        {
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient>(MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "projectId-1969970175",
                Region = "region-934795532",
                JobId = "jobId-1154752291",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
