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
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class TransactionSpannerFixture : TransactionFixtureBase<SpannerTestStore>
    {
        private readonly IServiceProvider _serviceProvider;

        public TransactionSpannerFixture() => _serviceProvider = new ServiceCollection()
            .AddEntityFrameworkSpanner()
            .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
            .BuildServiceProvider();

        protected override string DatabaseName { get; } = "transactiontest";

        public override SpannerTestStore CreateTestStore()
        {
            return SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                var optionsBuilder = new DbContextOptionsBuilder()
                    .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName))
                    .UseInternalServiceProvider(_serviceProvider);

                using (var context = new DbContext(optionsBuilder.Options))
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                }
            });
        }

        public override DbContext CreateContext(SpannerTestStore testStore)
            => new DbContext(new DbContextOptionsBuilder()
                .UseSpanner(testStore.ConnectionString)
                .UseInternalServiceProvider(_serviceProvider).Options);

        public override DbContext CreateContext(DbConnection connection)
            => new DbContext(new DbContextOptionsBuilder()
                .UseSpanner(connection)
                .UseInternalServiceProvider(_serviceProvider).Options);
    }
}