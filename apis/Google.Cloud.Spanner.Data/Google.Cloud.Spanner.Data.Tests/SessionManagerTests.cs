// Copyright 2025 Google LLC
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

using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;

public class SessionManagerTests
{
    private const string ConnectionString = "DataSource=projects/x/instances/y/databases/z";
    private static readonly DatabaseName s_databaseName = DatabaseName.FromProjectInstanceDatabase("x", "y", "z");

    [Fact]
    public async Task EqualOptions_SameClient()
    {
        int factoryCalls = 0;
        Func<SpannerClientCreationOptions, SpannerSettings, Task<SpannerClient>> factory = (options, settings) =>
        {
            factoryCalls++;
            return Task.FromResult<SpannerClient>(new FailingSpannerClient());
        };
        var manager = new SessionManager(new SpannerSettings(), factory);

        var clientOptions1 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
        var clientOptions2 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
        
        var sessionOptions1 = new SessionAcquisitionOptions(clientOptions1, s_databaseName, null, null);
        var sessionOptions2 = new SessionAcquisitionOptions(clientOptions2, s_databaseName, null, null);

        var session1 = await manager.AcquireSessionAsync(sessionOptions1);
        var session2 = await manager.AcquireSessionAsync(sessionOptions2);
        
        // Factory calls should be 1 because clientOptions1 and clientOptions2 are equal
        Assert.Equal(1, factoryCalls);
        Assert.Same(session1, session2); // Sessions should also be same (cached)
    }

    [Fact]
    public async Task DifferentOptions_DifferentClients()
    {
        int factoryCalls = 0;
        Func<SpannerClientCreationOptions, SpannerSettings, Task<SpannerClient>> factory = (options, settings) =>
        {
            factoryCalls++;
            return Task.FromResult<SpannerClient>(new FailingSpannerClient());
        };
        var manager = new SessionManager(new SpannerSettings(), factory);

        var clientOptions1 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
        var clientOptions2 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString) { Port = 1234 });
        
        var sessionOptions1 = new SessionAcquisitionOptions(clientOptions1, s_databaseName, null, null);
        var sessionOptions2 = new SessionAcquisitionOptions(clientOptions2, s_databaseName, null, null);

        var session1 = await manager.AcquireSessionAsync(sessionOptions1);
        var session2 = await manager.AcquireSessionAsync(sessionOptions2);
        
        Assert.Equal(2, factoryCalls);
        Assert.NotSame(session1, session2);
    }

    [Fact]
    public async Task SameClient_DifferentDatabase_DifferentSessions()
    {
        int factoryCalls = 0;
        Func<SpannerClientCreationOptions, SpannerSettings, Task<SpannerClient>> factory = (options, settings) =>
        {
            factoryCalls++;
            return Task.FromResult<SpannerClient>(new FailingSpannerClient());
        };
        var manager = new SessionManager(new SpannerSettings(), factory);
        var clientOptions = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));

        var db1 = DatabaseName.FromProjectInstanceDatabase("x", "y", "db1");
        var db2 = DatabaseName.FromProjectInstanceDatabase("x", "y", "db2");

        var sessionOptions1 = new SessionAcquisitionOptions(clientOptions, db1, null, null);
        var sessionOptions2 = new SessionAcquisitionOptions(clientOptions, db2, null, null);

        var session1 = await manager.AcquireSessionAsync(sessionOptions1);
        var session2 = await manager.AcquireSessionAsync(sessionOptions2);

        Assert.Equal(1, factoryCalls);
        Assert.NotSame(session1, session2);
    }

    private class FailingSpannerClient : SpannerClient
    {
        public FailingSpannerClient(SpannerSettings settings = null)
        {
            Settings = settings ?? SpannerSettings.GetDefault();
        }
    }
}
