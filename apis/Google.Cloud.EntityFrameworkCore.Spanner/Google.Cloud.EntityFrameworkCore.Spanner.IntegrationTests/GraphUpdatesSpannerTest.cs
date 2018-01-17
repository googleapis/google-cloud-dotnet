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
    internal class GraphUpdatesSpannerTest
        : GraphUpdatesTestBase<SpannerTestStore, GraphUpdatesSpannerTest.GraphUpdatesSpannerFixture>
    {
        public GraphUpdatesSpannerTest(GraphUpdatesSpannerFixture fixture)
            : base(fixture)
        {
        }

        protected override void UseTransaction(DatabaseFacade facade, IDbContextTransaction transaction)
            => facade.UseTransaction(transaction.GetDbTransaction());

        public class GraphUpdatesSpannerFixture : GraphUpdatesFixtureBase
        {
            private const string DatabaseName = "graphupdatestest";

            private readonly IServiceProvider _serviceProvider;

            public GraphUpdatesSpannerFixture() => _serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                .BuildServiceProvider();

            public override SpannerTestStore CreateTestStore()
            {
                return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder()
                        .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName))
                        .UseInternalServiceProvider(_serviceProvider);

                    using (var context = new GraphUpdatesContext(optionsBuilder.Options))
                    {
                        context.Database.EnsureDeleted();
                        if (context.Database.EnsureCreated())
                        {
                            Seed(context);
                        }
                    }
                });
            }

            public override DbContext CreateContext(SpannerTestStore testStore)
            {
                var optionsBuilder = new DbContextOptionsBuilder()
                    .UseSpanner(testStore.Connection)
                    .UseInternalServiceProvider(_serviceProvider);

                var context = new GraphUpdatesContext(optionsBuilder.Options);
                context.Database.UseTransaction(testStore.Transaction);
                return context;
            }
        }
    }
}