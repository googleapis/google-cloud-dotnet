// Copyright 2026 Google LLC
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
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests;

public class BigQueryResultsTest
{
    [Fact]
    public void ReadPage_NoJobReference_ThrowsException()
    {
        var client = new SimpleClient();
        var response = new GetQueryResultsResponse { JobReference = null };
        var results = new BigQueryResults(client, response, null, null);
        Assert.Throws<InvalidOperationException>(() => results.ReadPage(10));
    }

    [Fact]
    public async Task ReadPageAsync_NoJobReference_ThrowsException()
    {
        var client = new SimpleClient();
        var response = new GetQueryResultsResponse { JobReference = null };
        var results = new BigQueryResults(client, response, null, null);
        await Assert.ThrowsAsync<InvalidOperationException>(() => results.ReadPageAsync(10));
    }

    private class SimpleClient : BigQueryClient
    {
        public override BigqueryService Service => throw new NotImplementedException();
    }
}
