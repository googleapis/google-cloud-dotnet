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

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class GetQueryResultsOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new GetQueryResultsOptions
            {
                PageSize = 25,
                PageToken = "foo",
                Timeout = TimeSpan.FromSeconds(5),
            };
            GetQueryResultsRequest request = new GetQueryResultsRequest(new BigqueryService(), "project", "job");
            options.ModifyRequest(request);
            Assert.Equal("foo", request.PageToken);
            Assert.Equal(25, request.MaxResults);
            // ModifyRequest doesn't modify the timeout, as that's done externally
            Assert.Null(request.TimeoutMs);
        }


        [Fact]
        public void Clone()
        {
            var options = new GetQueryResultsOptions
            {
                PageSize = 25,
                StartIndex = 10,
                Timeout = TimeSpan.FromMinutes(20)
            };
            var clone = options.Clone();
            options.PageSize = 20;
            options.StartIndex = 5;
            Assert.Equal(25, clone.PageSize);
            Assert.Equal(10UL, clone.StartIndex);
            Assert.Equal(TimeSpan.FromMinutes(20), clone.Timeout);
        }
    }
}
