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
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    //TODO: enable notificationentities tests.
    internal class NotificationEntitiesSpannerTest
        : NotificationEntitiesTestBase<SpannerTestStore,
            NotificationEntitiesSpannerTest.NotificationEntitiesSpannerFixture>
    {
        public NotificationEntitiesSpannerTest(NotificationEntitiesSpannerFixture fixture)
            : base(fixture)
        {
        }

        public class NotificationEntitiesSpannerFixture : NotificationEntitiesFixtureBase
        {
            public const string DatabaseName = "notificationentities";

            private readonly DbContextOptions _options;

            public NotificationEntitiesSpannerFixture()
            {
                _options = new DbContextOptionsBuilder()
                    .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName), b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(new ServiceCollection()
                        .AddEntityFrameworkSpanner()
                        .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                        .BuildServiceProvider())
                    .Options;
            }

            public override DbContext CreateContext()
                => new DbContext(_options);

            public override SpannerTestStore CreateTestStore()
                => SpannerTestStore.GetOrCreateShared(DatabaseName, EnsureCreated);
        }
    }
}