// Copyright 2017 Google Inc. All Rights Reserved.
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestModels.GearsOfWarModel;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class GearsOfWarQuerySpannerFixture : GearsOfWarQueryRelationalFixture<SpannerTestStore>
    {
        public const string DatabaseName = "gearsofwarquerytest";

        private readonly string _connectionString = SpannerTestStore.CreateConnectionString(DatabaseName);

        private readonly DbContextOptions _options;

        public GearsOfWarQuerySpannerFixture()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                .BuildServiceProvider();

            _options = new DbContextOptionsBuilder()
                .EnableSensitiveDataLogging()
                .ConfigureWarnings(w => w.Log(CoreEventId.IncludeIgnoredWarning))
                .UseInternalServiceProvider(serviceProvider)
                .Options;
        }

        public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

        public override SpannerTestStore CreateTestStore()
        {
            return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                using (var context = new GearsOfWarContext(
                    new DbContextOptionsBuilder(_options)
                        .UseSpanner(_connectionString, b => b.ApplyConfiguration())
                        .Options))
                {
                    context.Database.EnsureCreated();
                    GearsOfWarModelInitializer.Seed(context);
                }
            });
        }

        public override GearsOfWarContext CreateContext(SpannerTestStore testStore)
        {
            var context = new GearsOfWarContext(
                new DbContextOptionsBuilder(_options)
                    .UseSpanner(testStore.Connection, b => b.ApplyConfiguration())
                    .Options);

            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            context.Database.UseTransaction(testStore.Transaction);

            return context;
        }
    }
}