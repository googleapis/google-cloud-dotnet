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

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.Scheduler.V1.Snippets
{
    [SnippetOutputCollector]
    public class CloudSchedulerClientSnippets
    {
        [Fact]
        public void CreateJobSample()
        {
            string projectId = TestEnvironment.GetTestProjectId();
            string locationId = TestEnvironment.GetProjectLocationId();

            // Sample: CreateJob
            CloudSchedulerClient client = CloudSchedulerClient.Create();
            LocationName parent = new LocationName(projectId, locationId);
            Job job = new Job
            {
                Description = "Sample job",
                Schedule = "0 9 * * 1", // Every Monday at 9am, UTC.
                TimeZone = "UTC",
                // Other options are to create an App Engine HTTP target or a PubSub target.
                HttpTarget = new HttpTarget
                {
                    HttpMethod = HttpMethod.Get,
                    Uri = "https://www.google.com"
                }
            };
            Job createdJob = client.CreateJob(parent, job);
            Console.WriteLine($"Created job details: {createdJob}");
            // End sample

            client.DeleteJob(createdJob.JobName);
        }

        [Fact]
        public void ListJobs()
        {
            string projectId = TestEnvironment.GetTestProjectId();
            string locationId = TestEnvironment.GetProjectLocationId();

            // Sample: ListJobs
            CloudSchedulerClient client = CloudSchedulerClient.Create();
            LocationName parent = new LocationName(projectId, locationId);
            PagedEnumerable<ListJobsResponse, Job> jobs = client.ListJobs(parent);
            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
            // End sample
        }
    }
}
