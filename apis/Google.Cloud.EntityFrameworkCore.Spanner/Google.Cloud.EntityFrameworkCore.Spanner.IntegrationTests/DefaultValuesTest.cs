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
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
#pragma warning disable xUnit1000 // Test classes must be public
    /// <summary>
    /// TODO: implement tests for Spanner
    /// </summary>
    internal class DefaultValuesTest : IDisposable
#pragma warning restore xUnit1000 // Test classes must be public
    {
        public void Dispose()
        {
            using (var context = new ChipsContext(_serviceProvider, "defaultkettlechips"))
            {
                context.Database.EnsureDeleted();
            }
        }

        private readonly IServiceProvider _serviceProvider = new ServiceCollection()
            .AddEntityFrameworkSpanner()
            .BuildServiceProvider();

        private class ChipsContext : DbContext
        {
            private readonly string _databaseName;
            private readonly IServiceProvider _serviceProvider;

            public ChipsContext(IServiceProvider serviceProvider, string databaseName)
            {
                _serviceProvider = serviceProvider;
                _databaseName = databaseName;
            }

            public DbSet<KettleChips> Chips { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder
                    .UseSpanner(SpannerTestStore.CreateConnectionString(_databaseName))
                    .UseInternalServiceProvider(_serviceProvider);

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<KettleChips>()
                    .Property(e => e.BestBuyDate)
                    .HasDefaultValue(new DateTime(2035, 9, 25));

                modelBuilder.Entity<KettleChips>()
                    .Property(e => e.Id)
                    .HasValueGenerator<IntGenerator>();
            }
        }

        private class KettleChips
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime BestBuyDate { get; set; }
        }

        [Fact]
        public void Can_use_Spanner_default_values()
        {
            using (var context = new ChipsContext(_serviceProvider, "defaultkettlechips"))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var honeyDijon = context.Add(new KettleChips {Name = "Honey Dijon"}).Entity;
                var buffaloBleu = context
                    .Add(new KettleChips {Name = "Buffalo Bleu", BestBuyDate = new DateTime(2111, 1, 11)}).Entity;

                context.SaveChanges();

                Assert.Equal(new DateTime(2035, 9, 25), honeyDijon.BestBuyDate);
                Assert.Equal(new DateTime(2111, 1, 11), buffaloBleu.BestBuyDate);
            }

            using (var context = new ChipsContext(_serviceProvider, "defaultkettlechips"))
            {
                Assert.Equal(new DateTime(2035, 9, 25), context.Chips.Single(c => c.Name == "Honey Dijon").BestBuyDate);
                Assert.Equal(new DateTime(2111, 1, 11),
                    context.Chips.Single(c => c.Name == "Buffalo Bleu").BestBuyDate);
            }
        }
    }
}