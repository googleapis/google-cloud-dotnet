// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryJobTest
    {
        [Fact]
        public void Properties()
        {
            var resource = new Job
            {
                JobReference = new JobReference { ProjectId = "project", JobId = "job" },
                Status = new JobStatus { State = "RUNNING" },
                Statistics = new JobStatistics { CreationTime = 1000L }
            };
            var job = new BigQueryJob(new SimpleClient(), resource);
            Assert.Same(resource, job.Resource);
            Assert.Same(resource.JobReference, job.Reference);
            Assert.Same(resource.Statistics, job.Statistics);
            Assert.Same(resource.Status, job.Status);
            Assert.Equal(JobState.Running, job.State);
        }

        [Fact]
        public void ThrowOnAnyError_WithErrors()
        {
            var resource = new Job
            {
                JobReference = new JobReference { ProjectId = "project", JobId = "job" },
                Status = new JobStatus
                {
                    State = "completed",
                    Errors = new[] { new ErrorProto { Message = "Error 1" }, new ErrorProto { Message = "Error 2" } }
                }
            };
            var job = new BigQueryJob(new SimpleClient(), resource);
            var exception = Assert.Throws<GoogleApiException>(() => job.ThrowOnAnyError());
            var requestError = exception.Error;
            Assert.Equal(new[] { "Error 1", "Error 2" }, requestError.Errors.Select(e => e.Message));
        }

        [Fact]
        public void ThrowOnAnyError_NoErrors()
        {
            var resource = new Job
            {
                Status = new JobStatus { State = "completed" },
            };
            var job = new BigQueryJob(new SimpleClient(), resource);
            job.ThrowOnAnyError();
        }

        [Fact]
        public async Task GetQueryResults_NonQuery()
        {
            var resource = new Job
            {
                JobReference = new JobReference { ProjectId = "project", JobId = "job" },
                Configuration = new JobConfiguration
                {
                    Copy = new JobConfigurationTableCopy { }
                }
            };
            var job = new BigQueryJob(new SimpleClient(), resource);
            Assert.Throws<InvalidOperationException>(() => job.GetQueryResults());
            await Assert.ThrowsAsync<InvalidOperationException>(() => job.GetQueryResultsAsync());
        }

        [Fact]
        public async Task GetQueryResults_NoDestinationTable()
        {
            var resource = new Job
            {
                JobReference = new JobReference { ProjectId = "project", JobId = "job" },
                Configuration = new JobConfiguration
                {
                    DryRun = true,
                    Query = new JobConfigurationQuery { } // No destination table
                }
            };
            var job = new BigQueryJob(new SimpleClient(), resource);
            Assert.Throws<InvalidOperationException>(() => job.GetQueryResults());
            await Assert.ThrowsAsync<InvalidOperationException>(() => job.GetQueryResultsAsync());
        }

        [Fact]
        public async Task GetQueryResults_NoJobReference()
        {
            var resource = new Job
            {
                Configuration = new JobConfiguration
                {
                    DryRun = true,
                    Query = new JobConfigurationQuery { DestinationTable = new TableReference { ProjectId = "project", DatasetId = "dataset", TableId = "table" } }
                }
            };
            var job = new BigQueryJob(new SimpleClient(), resource);
            Assert.Throws<InvalidOperationException>(() => job.GetQueryResults());
            await Assert.ThrowsAsync<InvalidOperationException>(() => job.GetQueryResultsAsync());
        }

        // ThrowOnAnyError uses the client service name. This is simpler than mocking that.
        private class SimpleClient : BigQueryClient
        {
            public override BigqueryService Service { get; } = new FakeBigqueryService();
        }
    }
}
