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
using System.IO;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    [SnippetOutputCollector]
    public class SpannerDbContextOptionsExtensionsSnippets
    {
        private static IConfiguration Config { get; set; }

        public SpannerDbContextOptionsExtensionsSnippets()
        {
        }

        static SpannerDbContextOptionsExtensionsSnippets()
        {
            Config = new ConfigurationBuilder()
                .AddEnvironmentVariables().Build();
        }

        public static string DefaultConnection =>
            $"Data Source=projects/{Config["TEST_PROJECT"]}/instances/spannerinstance/databases/northwind";

        // Sample: UseSpanner
        [Fact]
        public void SampleUsage()
        {
            using (var context = new ChipsContext("chips"))
            {
                context.Database.EnsureCreated();

                context.Add(new PringleChips {Id = Guid.NewGuid().ToString(), Name = "Honey Dijon"});
                context.Add(new PringleChips {Id = Guid.NewGuid().ToString(), Name = "Ranch", BestBuyDate = new DateTime(2112, 2, 22)});

                context.SaveChanges();
            }
        }

        private class ChipsContext : DbContext
        {
            private readonly string _databaseName;

            public ChipsContext(string databaseName)
            {
                _databaseName = databaseName;
            }

            public DbSet<PringleChips> Chips { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder
                    .UseSpanner(CreateConnectionString(_databaseName));

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<PringleChips>()
                    .Property(e => e.BestBuyDate)
                    .HasDefaultValue(new DateTime(2035, 9, 25));
            }
        }

        private class PringleChips
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public DateTime BestBuyDate { get; set; }
        }

        private static string CreateConnectionString(string name)
        {
            var builder = new SpannerConnectionStringBuilder(DefaultConnection);
            builder.DataSource = string.IsNullOrEmpty(name) ? 
                $"projects/{builder.Project}/instances/{builder.SpannerInstance}" 
                : $"projects/{builder.Project}/instances/{builder.SpannerInstance}/databases/{name}";
            return builder.ConnectionString;
        }
        // End sample

    }
}
