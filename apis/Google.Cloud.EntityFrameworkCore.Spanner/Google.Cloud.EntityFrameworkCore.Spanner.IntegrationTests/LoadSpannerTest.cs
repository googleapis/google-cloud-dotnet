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

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class LoadSpannerTest
        : LoadTestBase<SpannerTestStore, LoadSpannerTest.LoadSpannerFixture>
    {
        private const string FileLineEnding = @"
";

        public LoadSpannerTest(LoadSpannerFixture fixture)
            : base(fixture)
        {
            fixture.TestSqlLoggerFactory.Clear();
        }

        private string Sql { get; set; }

        protected override void ClearLog() => Fixture.TestSqlLoggerFactory.Clear();

        protected override void RecordLog() => Sql =
            Fixture.TestSqlLoggerFactory.Sql.Replace(Environment.NewLine, FileLineEnding);

        public class LoadSpannerFixture : LoadFixtureBase
        {
            private const string DatabaseName = "loadtest";
            private readonly DbContextOptions _options;

            public LoadSpannerFixture()
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
                    using (var context = new LoadContext(_options))
                    {
                        context.Database.EnsureCreated();
                        Seed(context);
                    }
                });
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Parent>().ToTable("ParentTable");
            }

            public override DbContext CreateContext(SpannerTestStore testStore)
                => new LoadContext(_options);
        }
    }
}