// Copyright 2016 Google Inc. All Rights Reserved.
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
using System;
using Xunit;
using static Google.Apis.Bigquery.v2.JobsResource;
using static Google.Apis.Bigquery.v2.JobsResource.ListRequest;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class ListJobsOptionsTest
    {
        [Fact]
        public void ModifyRequest_NoOp()
        {
            var options = new ListJobsOptions();
            ListRequest request = new ListRequest(new BigqueryService(), "project");
            options.ModifyRequest(request);
            Assert.Null(request.MaxResults);
            Assert.Null(request.StateFilter);
            Assert.Null(request.AllUsers);
            Assert.Null(request.Projection);
            Assert.Null(request.PageToken);
            Assert.Null(request.MinCreationTime);
            Assert.Null(request.MaxCreationTime);
        }

        [Fact]
        public void ModifyRequest()
        {
            var options = new ListJobsOptions
            {
                PageSize = 25,
                StateFilter = JobState.Pending,
                AllUsers = true,
                Projection = ProjectionEnum.Full,
                PageToken = "nextpage",
                MinCreationTime = new DateTimeOffset(1970, 1, 1, 0, 0, 1, TimeSpan.Zero),
                // Negative offset means this UTC is ahead of local time - so this is 1970-01-01T00:01:01Z.
                MaxCreationTime = new DateTimeOffset(1970, 1, 1, 0, 0, 1, TimeSpan.FromMinutes(-1)),
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project");
            options.ModifyRequest(request);
            Assert.Equal(25, request.MaxResults);
            Assert.Equal(StateFilterEnum.Pending, request.StateFilter);
            Assert.Equal(true, request.AllUsers);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
            Assert.Equal("nextpage", request.PageToken);
            Assert.Equal(1000UL, request.MinCreationTime);
            Assert.Equal(61000UL, request.MaxCreationTime);
        }

        [Fact]
        public void MinCreationTimeBeforeUnixEpoch()
        {
            var options = new ListJobsOptions
            {
                MinCreationTime = new DateTimeOffset(1969, 12, 31, 23, 59, 59, TimeSpan.Zero),
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project");
            Assert.Throws<ArgumentOutOfRangeException>(() => options.ModifyRequest(request));
        }

        [Fact]
        public void MaxCreationTimeBeforeUnixEpoch()
        {
            var options = new ListJobsOptions
            {
                MaxCreationTime = new DateTimeOffset(1969, 12, 31, 23, 59, 59, TimeSpan.Zero),
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project");
            Assert.Throws<ArgumentOutOfRangeException>(() => options.ModifyRequest(request));
        }

        [Fact]
        public void MinCreationTimeLaterThanMaxCreationTime()
        {
            var options = new ListJobsOptions
            {
                MinCreationTime = new DateTimeOffset(2001, 1, 1, 0, 0, 0, TimeSpan.Zero),
                MaxCreationTime = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero)
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project");
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(request));
        }
    }
}
