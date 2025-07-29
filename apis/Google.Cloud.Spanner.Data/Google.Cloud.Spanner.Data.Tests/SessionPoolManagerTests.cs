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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
#pragma warning disable IDE0065 // Misplaced using directive
    using ClientFactory = Func<SpannerClientCreationOptions, SpannerSettings, Task<SpannerClient>>;
#pragma warning restore IDE0065 // Misplaced using directive

    public class SessionPoolManagerTests
    {
        // Sample connection string for most tests
        private const string ConnectionString = "DataSource=projects/x/instances/y/databases/z";

        [Fact]
        public async Task EqualOptions_SameSessionPool()
        {
            int factoryCalls = 0;
            ClientFactory factory = (options, settings) =>
            {
                factoryCalls++;
                return Task.FromResult<SpannerClient>(new FailingSpannerClient());
            };
            var manager = new SessionPoolManager(new SessionPoolOptions(), SessionPoolManager.CreateDefaultSpannerSettings(), Logger.DefaultLogger, factory);

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
            ClientFactory factory = (options, settings) =>
            {
                factoryCalls++;
                return Task.FromResult<SpannerClient>(new FailingSpannerClient());
            };
            var manager = new SessionPoolManager(new SessionPoolOptions(), SessionPoolManager.CreateDefaultSpannerSettings(), Logger.DefaultLogger, factory);

            var options1 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
            var options2 = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString) { Port = 1234 });

            var pool1 = await manager.AcquireSessionPoolAsync(options1);
            var pool2 = await manager.AcquireSessionPoolAsync(options2);
            Assert.NotSame(pool1, pool2);
            Assert.Equal(2, factoryCalls);
            Assert.Equal(2, manager.GetStatistics().Count);
        }

        [Fact]
        public async Task UsesSpannerSettings()
        {
            ClientFactory factory = (options, settings) =>
            {
                return Task.FromResult<SpannerClient>(new FailingSpannerClient(settings));
            };
            var customSettings = new SpannerSettings();
            var manager = new SessionPoolManager(new SessionPoolOptions(), customSettings, Logger.DefaultLogger, factory);

            var pool = await manager.AcquireSessionPoolAsync(new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString)));
            Assert.Same(customSettings, pool.Client.Settings);
        }

        [Fact]
        public async Task DefaultClientFactory_UsesEnableLeaderRouting()
        {
            var manager = new SessionPoolManager(new SessionPoolOptions(), new SpannerSettings(), Logger.DefaultLogger, SessionPoolManager.CreateClientAsync);

            var pool = await manager.AcquireSessionPoolAsync(
                new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString, GoogleCredential.FromAccessToken("token"))
                {
                    EnableLeaderRouting = false,
                }));
            Assert.False(pool.Client.Settings.LeaderRoutingEnabled);
        }

        [Fact]
        public async Task DefaultClientFactory_UsesDirectedReadOptions()
        {
            var manager = new SessionPoolManager(new SessionPoolOptions(), new SpannerSettings(), Logger.DefaultLogger, SessionPoolManager.CreateClientAsync);

            var pool = await manager.AcquireSessionPoolAsync(
                new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString, GoogleCredential.FromAccessToken("token"))
                {
                    DirectedReadOptions = DirectedReadTests.IncludeDirectedReadOptions,
                }));
            Assert.Equal(DirectedReadTests.IncludeDirectedReadOptions, pool.Client.Settings.DirectedReadOptions);
            Assert.NotSame(DirectedReadTests.IncludeDirectedReadOptions, pool.Client.Settings.DirectedReadOptions);
        }

        [Fact]
        public void Create_UsesDefaultLogger()
        {
            var manager = SessionPoolManager.Create(new SessionPoolOptions());
            Assert.Same(Logger.DefaultLogger, manager.Logger);
        }

        [Fact]
        public void CreateWithSettings_UsesLoggerInSettings()
        {
            var settings = new SpannerSettings {Logger = new DefaultLogger()};
            var manager = SessionPoolManager.CreateWithSettings(new SessionPoolOptions(), settings);
            Assert.Same(settings.Logger, manager.Logger);
        }

        [Fact]
        public async Task ReleaseDecreasesCount()
        {
            var manager = new SessionPoolManager(new SessionPoolOptions(), SessionPoolManager.CreateDefaultSpannerSettings(), Logger.DefaultLogger, FailingSpannerClient.Factory);

            var options = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
            var pool = await manager.AcquireSessionPoolAsync(options);

            var stats = manager.GetStatistics().Single();
            Assert.Equal(1, stats.ActiveConnectionCount);

            manager.Release(pool);

            stats = manager.GetStatistics().Single();
            Assert.Equal(0, stats.ActiveConnectionCount);
        }

        // At one point we thought we'd need different options for production and emulators. We reverted that.
        // This tests that whether or not we're using an emulator, we get the options we asked for.
        [Theory]
        [InlineData("localhost")]
        [InlineData(null)]
        public async Task EmulatorDetection_AlwaysUsesRegularOptions(string emulatorHost)
        {
            var regularOptions = new SessionPoolOptions();
            var manager = new SessionPoolManager(regularOptions, SessionPoolManager.CreateDefaultSpannerSettings(), Logger.DefaultLogger, FailingSpannerClient.Factory);

            var builder = new SpannerConnectionStringBuilder(ConnectionString)
            {
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction,
                // Effectively "there are no environment variables"
                EnvironmentVariableProvider = key => key == "SPANNER_EMULATOR_HOST" ? emulatorHost: null
            };
            var clientCreationOptions = new SpannerClientCreationOptions(new SpannerConnectionStringBuilder(ConnectionString));
            var pool = await manager.AcquireSessionPoolAsync(clientCreationOptions);

            Assert.Same(regularOptions, pool.Options);
        }

        // A SpannerClient that always fails, but does have valid settings.
        private class FailingSpannerClient : SpannerClient
        {
            // A simple non-counting factory.
            internal static ClientFactory Factory { get; } = (options, settings) => Task.FromResult<SpannerClient>(new FailingSpannerClient(settings));

            public FailingSpannerClient(SpannerSettings settings = null)
            {
                Settings = settings ?? SpannerSettings.GetDefault();
            }
        }
    }
}
