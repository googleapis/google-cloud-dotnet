// Copyright 2018 Google LLC
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

using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    using ClientFactory = Func<SpannerClientCreationOptions, SpannerSettings, Logger, Task<SpannerClient>>;

    public class SessionPoolManagerTests
    {
        // Sample connection string for most tests
        private const string ConnectionString = "DataSource=projects/x/instances/y/databases/z";

        [Fact]
        public async Task EqualOptions_SameSessionPool()
        {
            int factoryCalls = 0;
            ClientFactory factory = (options, settings, logger) =>
            {
                factoryCalls++;
                return Task.FromResult<SpannerClient>(new FailingSpannerClient());
            };
            var manager = new SessionPoolManager(new SessionPoolOptions(), Logger.DefaultLogger, factory);

            var options1 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
            var options2 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));

            var pool1 = await manager.AcquireSessionPoolAsync(options1);
            var pool2 = await manager.AcquireSessionPoolAsync(options2);
            Assert.Same(pool1, pool2);
            Assert.Equal(1, factoryCalls);
            Assert.Equal(1, manager.GetStatistics().Count);
        }

        [Fact]
        public async Task DifferentOptions_DifferentSessionPools()
        {
            int factoryCalls = 0;
            ClientFactory factory = (options, settings, logger) =>
            {
                factoryCalls++;
                return Task.FromResult<SpannerClient>(new FailingSpannerClient());
            };
            var manager = new SessionPoolManager(new SessionPoolOptions(), Logger.DefaultLogger, factory);

            var options1 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
            var options2 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString) { Port = 1234 });

            var pool1 = await manager.AcquireSessionPoolAsync(options1);
            var pool2 = await manager.AcquireSessionPoolAsync(options2);
            Assert.NotSame(pool1, pool2);
            Assert.Equal(2, factoryCalls);
            Assert.Equal(2, manager.GetStatistics().Count);
        }

        [Fact]
        public async Task ReleaseDecreasesCount()
        {
            var manager = new SessionPoolManager(new SessionPoolOptions(), Logger.DefaultLogger, FailingSpannerClient.Factory);

            var options = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
            var pool = await manager.AcquireSessionPoolAsync(options);

            var stats = manager.GetStatistics().Single();
            Assert.Equal(1, stats.ActiveConnectionCount);

            manager.Release(pool);

            stats = manager.GetStatistics().Single();
            Assert.Equal(0, stats.ActiveConnectionCount);
        }       

        // A SpannerClient that always fails, but does have valid settings.
        private class FailingSpannerClient : SpannerClient
        {
            // A simple non-counting factory.
            internal static ClientFactory Factory { get; } = (options, settings, logger) => Task.FromResult<SpannerClient>(new FailingSpannerClient());

            public FailingSpannerClient()
            {
                Settings = SpannerSettings.GetDefault();
            }
        }
    }
}
