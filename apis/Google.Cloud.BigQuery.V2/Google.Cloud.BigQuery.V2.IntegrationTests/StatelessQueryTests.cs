// Copyright 2026 Google Inc. All Rights Reserved.
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

using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests;

[Collection(nameof(BigQueryFixture))]
public class StatelessQueryTest
{
    private readonly BigQueryFixture _fixture;

    public StatelessQueryTest(BigQueryFixture fixture)
    {
        _fixture = fixture;
    }

    public static IEnumerable<object[]> StatelessOptionsData =>
        new List<object[]>
        {
            new object[] { null },
            new object[] { new QueryOptions() },
            new object[] { new QueryOptions { UseQueryCache = true } },
            new object[] { new QueryOptions { UseQueryCache = false } },
            new object[] { new QueryOptions { MaximumBytesBilled = 1024 * 1024 } },
            new object[] { new QueryOptions { ParameterMode = BigQueryParameterMode.Named } },
            new object[] { new QueryOptions { DefaultDataset = new DatasetReference { ProjectId = "p", DatasetId = "d" } } },
        };

    [Theory]
    [MemberData(nameof(StatelessOptionsData))]
    public void ExecuteQuery_Stateless(QueryOptions options)
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var sql = "SELECT 1 as val";
        var results = client.ExecuteQuery(sql, null, options);
        AssertStatelessQueryWasRun(results);
        var rows = results.ToList();
        Assert.Single(rows);
        Assert.Equal(1L, (long)rows[0]["val"]);
        Assert.NotNull(results.JobReference);
    }

    [Theory]
    [MemberData(nameof(StatelessOptionsData))]
    public async Task ExecuteQueryAsync_Stateless(QueryOptions options)
    {
        var client = await BigQueryClient.CreateAsync(_fixture.ProjectId);
        var sql = "SELECT 'somestring' as val";
        var results = await client.ExecuteQueryAsync(sql, null, options);
        AssertStatelessQueryWasRun(results);
        var rows = results.ToList();
        Assert.Single(rows);
        Assert.Equal("somestring", (string)rows[0]["val"]);
        Assert.NotNull(results.JobReference);
    }

    [Fact]
    public void ExecuteQuery_Stateless_WithParameters()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var sql = "SELECT @val as val";
        var parameters = new[] { new BigQueryParameter("val", BigQueryDbType.Int64, 42) };
        var results = client.ExecuteQuery(sql, parameters);
        AssertStatelessQueryWasRun(results);
        var rows = results.ToList();
        Assert.Single(rows);
        Assert.Equal(42L, (long)rows[0]["val"]);
    }

    [Fact]
    public void ExecutQuery_Stateless_EmptyResults()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var sql = "SELECT * FROM (SELECT 1 as val) WHERE val=0";
        var results = client.ExecuteQuery(sql, null);
        AssertStatelessQueryWasRun(results);
        var rows = results.ToList();
        Assert.Empty(rows);
        Assert.NotNull(results.Schema);
    }

    [Fact]
    public void ExecuteQuery_Stateless_Pagination()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        // Create 10 rows
        var sql = "SELECT val FROM UNNEST(GENERATE_ARRAY(1, 10)) as val ORDER BY val";

        // Request 3 rows at a time
        var resultsOptions = new GetQueryResultsOptions { PageSize = 3 };
        var results = client.ExecuteQuery(sql, null, null, resultsOptions);
        AssertStatelessQueryWasRun(results);
        var rows = results.ToList();
        Assert.Equal(10, rows.Count);
        for (int i = 0; i < 10; i++)
        {
            Assert.Equal((long)i + 1, (long)rows[i]["val"]);
        }
    }

    public static IEnumerable<object[]> StatefulOptionsData =>
        new List<object[]>
        {
            new object[] { new QueryOptions { Priority = QueryPriority.Batch } },
            new object[] { new QueryOptions { AllowLargeResults = true } },
            new object[] { new QueryOptions { FlattenResults = false } },
            new object[] { new QueryOptions { MaximumBillingTier = 1 } },
            new object[] { new QueryOptions { CreateDisposition = CreateDisposition.CreateIfNeeded } },
            new object[] { new QueryOptions { WriteDisposition = WriteDisposition.WriteIfEmpty } },
        };

    [Theory]
    [MemberData(nameof(StatefulOptionsData))]
    public void ExecuteQuery_Stateful(QueryOptions options)
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var sql = "SELECT 1 as val";
        var results = client.ExecuteQuery(sql, null, options);
        Assert.Null(results.QueryId);
        var rows = results.ToList();
        Assert.Single(rows);
    }

    [Theory]
    [MemberData(nameof(StatefulOptionsData))]
    public async Task ExecuteQueryAsync_Stateful(QueryOptions options)
    {
        var client = await BigQueryClient.CreateAsync(_fixture.ProjectId);
        var sql = "SELECT 1 as val";
       var results = await client.ExecuteQueryAsync(sql, null, options);
        Assert.Null(results.QueryId);
        var rows = results.ToList();
        Assert.Single(rows);
    }

    private void AssertStatelessQueryWasRun(BigQueryResults results)
    {
        // We can verify a Jobs.Query stateless query was run checking if the QueryId was populated on the result.
        Assert.NotNull(results.QueryId);
        foreach (var row in results)
        {
            Assert.Equal(results.QueryId, row.QueryId);
        }
    }
}
