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
        public void ModifyRequest_NoOp()
        {
            var options = new GetQueryResultsOptions
            {
                PageSize = 25,
                PageToken = "foo",
                Timeout = TimeSpan.FromSeconds(5),
            };
            GetQueryResultsRequest request = new GetQueryResultsRequest(new BigqueryService(), "project", "job");
            options.ModifyRequest(request);
            Assert.Null(request.PageToken);
            Assert.Null(request.MaxResults);
            Assert.Null(request.TimeoutMs);
        }        

        [Fact]
        public void ToListRowsOptions_BothPageTokenAndStartIndexSet()
        {
            var options = new GetQueryResultsOptions
            {
                StartIndex = 10,
                PageToken = "foo"
            };
            Assert.Throws<ArgumentException>(() => options.ToListRowsOptions());
        }

        [Fact]
        public void ToListRowsOptions_StartIndex()
        {
            var options = new GetQueryResultsOptions
            {
                StartIndex = 10,
                PageSize = 25,
            };
            var listOptions = options.ToListRowsOptions();
            Assert.Equal(10UL, listOptions.StartIndex);
            Assert.Equal(25, listOptions.PageSize);
            Assert.Null(listOptions.PageToken);
        }

        [Fact]
        public void ToListRowsOptions_PageToken()
        {
            var options = new GetQueryResultsOptions
            {
                PageSize = 25,
                PageToken = "token"
            };
            var listOptions = options.ToListRowsOptions();
            Assert.Equal(25, listOptions.PageSize);
            Assert.Equal("token", listOptions.PageToken);
            Assert.Null(listOptions.StartIndex);
        }
    }
}
