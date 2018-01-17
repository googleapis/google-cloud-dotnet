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

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public abstract class FindSpannerTest : FindTestBase<SpannerTestStore, FindSpannerTest.FindSpannerFixture>
    {
        protected FindSpannerTest(FindSpannerFixture fixture)
            : base(fixture)
        {
            fixture.TestSqlLoggerFactory.Clear();
        }

        public class FindSpannerTestSet : FindSpannerTest
        {
            public FindSpannerTestSet(FindSpannerFixture fixture)
                : base(fixture)
            {
            }

            protected override TEntity Find<TEntity>(DbContext context, params object[] keyValues)
                => context.Set<TEntity>().Find(keyValues);

            protected override Task<TEntity> FindAsync<TEntity>(DbContext context, params object[] keyValues)
                => context.Set<TEntity>().FindAsync(keyValues);
        }

        public class FindSpannerTestContext : FindSpannerTest
        {
            public FindSpannerTestContext(FindSpannerFixture fixture)
                : base(fixture)
            {
            }

            protected override TEntity Find<TEntity>(DbContext context, params object[] keyValues)
                => context.Find<TEntity>(keyValues);

            protected override Task<TEntity> FindAsync<TEntity>(DbContext context, params object[] keyValues)
                => context.FindAsync<TEntity>(keyValues);
        }

        public class FindSpannerTestNonGeneric : FindSpannerTest
        {
            public FindSpannerTestNonGeneric(FindSpannerFixture fixture)
                : base(fixture)
            {
            }

            protected override TEntity Find<TEntity>(DbContext context, params object[] keyValues)
                => (TEntity) context.Find(typeof(TEntity), keyValues);

            protected override async Task<TEntity> FindAsync<TEntity>(DbContext context, params object[] keyValues)
                => (TEntity) await context.FindAsync(typeof(TEntity), keyValues);
        }

        public class FindSpannerFixture : FindFixtureBase
        {
            private const string DatabaseName = "findtest";
            private readonly DbContextOptions _options;

            public FindSpannerFixture()
            {
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkSpanner()
                    .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                    .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                    .BuildServiceProvider();

                _options = new DbContextOptionsBuilder()
                    .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName), b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(serviceProvider)
                    .EnableSensitiveDataLogging()
                    .Options;
            }

            public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

            public override SpannerTestStore CreateTestStore()
            {
                return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
                {
                    using (var context = new FindContext(_options))
                    {
                        context.Database.EnsureCreated();
                        Seed(context);
                    }
                });
            }

            public override DbContext CreateContext(SpannerTestStore testStore)
                => new FindContext(_options);
        }
    }
}