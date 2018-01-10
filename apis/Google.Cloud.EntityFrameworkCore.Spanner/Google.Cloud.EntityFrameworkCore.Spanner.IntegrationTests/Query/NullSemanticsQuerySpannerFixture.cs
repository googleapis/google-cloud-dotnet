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
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestModels.NullSemanticsModel;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class NullSemanticsQuerySpannerFixture : NullSemanticsQueryRelationalFixture<SpannerTestStore>
    {
        public static readonly string DatabaseName = "nullsemanticsquerytest";

        private readonly string _connectionString = SpannerTestStore.CreateConnectionString(DatabaseName);

        private readonly DbContextOptions _options;

        public NullSemanticsQuerySpannerFixture()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                .BuildServiceProvider();

            _options = new DbContextOptionsBuilder()
                .EnableSensitiveDataLogging()
                .UseInternalServiceProvider(serviceProvider)
                .Options;
        }

        public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

        public override SpannerTestStore CreateTestStore()
        {
            return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                using (var context = new NullSemanticsContext(new DbContextOptionsBuilder(_options)
                    .UseSpanner(_connectionString, b => b.ApplyConfiguration()).Options))
                {
                    context.Database.EnsureCreated();
                    NullSemanticsModelInitializer.Seed(context);
                }
            });
        }

        public override NullSemanticsContext CreateContext(SpannerTestStore testStore, bool useRelationalNulls)
        {
            var options = new DbContextOptionsBuilder(_options)
                .UseSpanner(
                    testStore.Connection,
                    b =>
                    {
                        b.ApplyConfiguration();
                        if (useRelationalNulls)
                        {
                            b.UseRelationalNulls();
                        }
                    }).Options;

            var context = new NullSemanticsContext(options);

            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            context.Database.UseTransaction(testStore.Transaction);

            return context;
        }
    }
}