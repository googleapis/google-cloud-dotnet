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
using Microsoft.EntityFrameworkCore.TestModels.ConcurrencyModel;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class F1SpannerFixture : F1RelationalFixture<SpannerTestStore>
    {
        public static readonly string DatabaseName = "optimisticconcurrencytest";

        private readonly string _connectionString = SpannerTestStore.CreateConnectionString(DatabaseName);

        private readonly IServiceProvider _serviceProvider;

        public F1SpannerFixture() => _serviceProvider = new ServiceCollection()
            .AddEntityFrameworkSpanner()
            .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
            .AddSingleton<ILoggerFactory>(new TestSqlLoggerFactory())
            .BuildServiceProvider();

        public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

        public override SpannerTestStore CreateTestStore()
        {
            return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                var optionsBuilder = new DbContextOptionsBuilder()
                    .UseSpanner(_connectionString, b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(_serviceProvider);

                using (var context = new F1Context(optionsBuilder.Options))
                {
                    context.Database.EnsureCreated();
                    ConcurrencyModelInitializer.Seed(context);
                }
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chassis>()
                .Property(c => c.TeamId)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Gearbox>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Team>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Driver>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Sponsor>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Engine>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<Engine>()
                .Property(c => c.EngineSupplierId)
                .HasValueGenerator<IntGenerator>();

            modelBuilder.Entity<EngineSupplier>()
                .Property(c => c.Id)
                .HasValueGenerator<IntGenerator>();
        }

        public override F1Context CreateContext(SpannerTestStore testStore)
        {
            var optionsBuilder = new DbContextOptionsBuilder()
                .UseSpanner(testStore.Connection, b => b.ApplyConfiguration())
                .UseInternalServiceProvider(_serviceProvider);

            var context = new F1Context(optionsBuilder.Options);
            context.Database.UseTransaction(testStore.Transaction);
            return context;
        }
    }
}