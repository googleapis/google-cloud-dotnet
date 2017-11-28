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
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class MappingQuerySpannerFixture : MappingQueryFixtureBase
    {
        private readonly DbContextOptions _options;
        private readonly SpannerTestStore _testDatabase;

        public MappingQuerySpannerFixture()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .AddSingleton<ILoggerFactory>(new TestSqlLoggerFactory())
                .BuildServiceProvider();

            _testDatabase = SpannerTestStore.GetNorthwindStore();

            _options = new DbContextOptionsBuilder()
                .UseModel(CreateModel())
                .UseSpanner(_testDatabase.ConnectionString)
                .UseInternalServiceProvider(serviceProvider)
                .Options;
        }

        protected override string DatabaseSchema { get; } = null;

        public DbContext CreateContext()
        {
            var context = new DbContext(_options);

            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return context;
        }

        public void Dispose() => _testDatabase.Dispose();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO(benwu)
//            modelBuilder.Entity<MappingQueryTestBase.MappedCustomer>(e =>
//            {
//                e.Property(c => c.CompanyName2).Metadata.Spanner().ColumnName = "CompanyName";
//                e.Metadata.Spanner().TableName = "Customers";
//            });
        }
    }
}