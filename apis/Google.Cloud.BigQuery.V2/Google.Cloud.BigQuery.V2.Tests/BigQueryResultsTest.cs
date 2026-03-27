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
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests;

public class BigQueryResultsTest
{
    private const string TestQueryId = "test-query-id";

    private static BigQueryResults CreateResults(string queryId = TestQueryId)
    {
        var client = new SimpleClient();
        var schema = new TableSchemaBuilder { { "col", BigQueryDbType.String } }.Build();
        var rows = new[] { new TableRow { F = new[] { new TableCell { V = "val" } } } };
        var response = new QueryResponse
        {
            JobReference = new JobReference { ProjectId = "p", JobId = "j" },
            QueryId = queryId,
            Schema = schema,
            Rows = rows,
            TotalRows = 1
        };
        return new BigQueryResults(client, response, null, null);
    }

    [Fact]
    public void QueryId_PropagatedToRows()
    {
        var results = CreateResults();
        Assert.Equal(TestQueryId, results.QueryId);

        var row = results.Single();
        Assert.Equal(TestQueryId, row.QueryId);
    }

    [Fact]
    public void ReadPage_QueryIdPropagatedToRows()
    {
        var results = CreateResults();
        var page = results.ReadPage(10);
        var row = page.Rows.Single();
        Assert.Equal(TestQueryId, row.QueryId);
    }

    [Fact]
    public async Task ReadPageAsync_QueryIdPropagatedToRows()
    {
        var results = CreateResults();
        var page = await results.ReadPageAsync(10);
        var row = page.Rows.Single();
        Assert.Equal(TestQueryId, row.QueryId);
    }

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
