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
using static Google.Apis.Bigquery.v2.TabledataResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class ListRowsOptionsTest
    {
        [Fact]
        public void ModifyRequest_PageToken()
        {
            var options = new ListRowsOptions
            {
                PageSize = 25,
                PageToken = "token"
            };
            var request = new ListRequest(new BigqueryService(), "project", "dataset", "table");
            options.ModifyRequest(request);
            Assert.Equal(25, request.MaxResults);
            Assert.Equal("token", request.PageToken);
        }

        [Fact]
        public void ModifyRequest_StartIndex()
        {
            var options = new ListRowsOptions
            {
                PageSize = 25,
                StartIndex = 10
            };
            var request = new ListRequest(new BigqueryService(), "project", "dataset", "table");
            options.ModifyRequest(request);
            Assert.Equal(25, request.MaxResults);
            Assert.Equal(10UL, request.StartIndex);
        }

        [Fact]
        public void ModifyRequest_StartIndexAndPageToken()
        {
            var options = new ListRowsOptions
            {
                PageSize = 25,
                StartIndex = 10,
                PageToken = "token"
            };
            var request = new ListRequest(new BigqueryService(), "project", "dataset", "table");
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(request));
        }
    }
}
