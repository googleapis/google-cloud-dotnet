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

namespace Google.Cloud.Dataproc.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedJobControllerClientTest
    {
        [Fact]
        public void SubmitJobTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient> { DefaultValue = DefaultValue.Mock };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.SubmitJob(It.IsAny<SubmitJobRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            Job job = new Job();
            Job response = client.SubmitJob(projectId, region, job);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetJobTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient> { DefaultValue = DefaultValue.Mock };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetJob(It.IsAny<GetJobRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            Job response = client.GetJob(projectId, region, jobId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelJobTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient> { DefaultValue = DefaultValue.Mock };
            Job expectedResponse = new Job
            {
                DriverOutputResourceUri = "driverOutputResourceUri-542229086",
                DriverControlFilesUri = "driverControlFilesUri207057643",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CancelJob(It.IsAny<CancelJobRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            Job response = client.CancelJob(projectId, region, jobId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteJobTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<JobController.JobControllerClient> mockGrpcClient = new Mock<JobController.JobControllerClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteJob(It.IsAny<DeleteJobRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string region = "region-934795532";
            string jobId = "jobId-1154752291";
            client.DeleteJob(projectId, region, jobId);
            mockGrpcClient.VerifyAll();
        }

    }
}
