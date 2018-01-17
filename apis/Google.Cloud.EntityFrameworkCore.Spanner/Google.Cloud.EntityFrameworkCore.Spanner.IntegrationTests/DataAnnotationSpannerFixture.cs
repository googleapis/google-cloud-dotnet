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
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class DataAnnotationSpannerFixture : DataAnnotationFixtureBase<SpannerTestStore>
    {
        public static readonly string DatabaseName = "dataannotations";

        private readonly string _connectionString = SpannerTestStore.CreateConnectionString(DatabaseName);
        private readonly DbContextOptions _options;

        public DataAnnotationSpannerFixture()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                .BuildServiceProvider();

            _options = new DbContextOptionsBuilder()
                .EnableSensitiveDataLogging()
                .UseInternalServiceProvider(serviceProvider)
                .ConfigureWarnings(w =>
                {
                    w.Default(WarningBehavior.Throw);
                    w.Ignore(CoreEventId.SensitiveDataLoggingEnabledWarning);
                }).Options;
        }

        public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

        public override SpannerTestStore CreateTestStore()
            => SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                var options = new DbContextOptionsBuilder(_options)
                    .UseSpanner(_connectionString, b => b.ApplyConfiguration())
                    .Options;

                using (var context = new DataAnnotationContext(options))
                {
                    context.Database.EnsureCreated();
                    DataAnnotationModelInitializer.Seed(context);
                }
            });

        public override DataAnnotationContext CreateContext(SpannerTestStore testStore)
        {
            var options = new DbContextOptionsBuilder(_options)
                .UseSpanner(testStore.Connection, b => b.ApplyConfiguration())
                .Options;

            var context = new DataAnnotationContext(options);
            context.Database.UseTransaction(testStore.Transaction);
            return context;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<One>()
                .Property(c => c.RowVersion)
                .HasColumnType("STRING(100)");

            modelBuilder.Entity<One>()
                .Property(c => c.UniqueNo)
                .Metadata.ValueGenerated = ValueGenerated.Never;

            modelBuilder.Entity<One>()
                .Property(c => c.UniqueNo)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Two>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<BookDetail>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();
        }
    }
}