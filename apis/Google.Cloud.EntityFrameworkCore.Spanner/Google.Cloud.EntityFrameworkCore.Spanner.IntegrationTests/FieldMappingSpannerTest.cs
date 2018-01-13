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
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    /// <summary>
    /// TODO: implement tests for Spanner
    /// </summary>
    internal class FieldMappingSpannerTest
        : FieldMappingTestBase<SpannerTestStore, FieldMappingSpannerTest.FieldMappingSpannerFixture>
    {
        public FieldMappingSpannerTest(FieldMappingSpannerFixture fixture)
            : base(fixture)
        {
        }

        protected override void UseTransaction(DatabaseFacade facade, IDbContextTransaction transaction)
            => facade.UseTransaction(transaction.GetDbTransaction());

        public class FieldMappingSpannerFixture : FieldMappingFixtureBase
        {
            private const string DatabaseName = "fieldmapping";

            private readonly IServiceProvider _serviceProvider;

            public FieldMappingSpannerFixture() => _serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                .BuildServiceProvider();

            public override SpannerTestStore CreateTestStore()
            {
                return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder()
                        .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName), b => b.ApplyConfiguration())
                        .UseInternalServiceProvider(_serviceProvider);

                    using (var context = new FieldMappingContext(optionsBuilder.Options))
                    {
                        context.Database.EnsureCreated();
                        Seed(context);
                    }
                });
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<PostFields>(
                    b =>
                    {
                        b.Property("_id").HasColumnName("Id");
                        b.Property("_title").HasColumnName("Title");
                        b.Property("_blogId").HasColumnName("BlogId");
                    });

                modelBuilder.Entity<BlogFields>(
                    b =>
                    {
                        b.Property("_id").HasColumnName("Id");
                        b.Property("_title").HasColumnName("Title");
                    });
            }

            public override DbContext CreateContext(SpannerTestStore testStore)
            {
                var optionsBuilder = new DbContextOptionsBuilder()
                    .UseSpanner(testStore.Connection, b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(_serviceProvider);

                var context = new FieldMappingContext(optionsBuilder.Options);
                context.Database.UseTransaction(testStore.Transaction);

                return context;
            }
        }
    }
}