// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.Data.IntegrationTests;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Internal.IntegrationTests;

[Collection(nameof(SpannerDatabaseFixture))]
[CommonTestDiagnostics]
public class ExecuteHelperTests
{
    private readonly SpannerDatabaseFixture _fixture;

    public ExecuteHelperTests(SpannerDatabaseFixture fixture) =>
        _fixture = fixture;

    [Fact]
    public Task SessionNotFound() => WithSessionPool(async pool =>
    {
        var session = await pool.Client.CreateSessionAsync(_fixture.DatabaseName);
        await pool.Client.DeleteSessionAsync(session.SessionName);

        // The session doesn't become invalid immediately after deletion.
        // Wait for a minute to ensure the session is really expired.
        await Task.Delay(TimeSpan.FromMinutes(1));

        var request = new ExecuteSqlRequest
        {
            Sql = $"SELECT 1",
            Session = session.Name
        };
        var exception = await Assert.ThrowsAsync<RpcException>(() => pool.Client.ExecuteSqlAsync(request));
        Assert.True(ExecuteHelper.IsSessionExpiredError(exception));
    });

    // This code is separated out in case we need more tests. It's really just fluff.
    private async Task WithSessionPool(Func<SessionPool, Task> action)
    {
        var builder = new SpannerConnectionStringBuilder(_fixture.ConnectionString);
        var pool = await builder.AcquireSessionPoolAsync();
        try
        {
            await action(pool);
        }
        finally
        {
            builder.SessionPoolManager.Release(pool);
        }
    }
}
