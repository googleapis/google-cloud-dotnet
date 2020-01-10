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
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    /// <summary>
    /// TODO: implement tests for Spanner
    /// </summary>
    internal class NullKeysSpannerTest : NullKeysTestBase<NullKeysSpannerTest.NullKeysSpannerFixture>
    {
        public NullKeysSpannerTest(NullKeysSpannerFixture fixture)
            : base(fixture)
        {
        }

        public class NullKeysSpannerFixture : NullKeysFixtureBase, IDisposable
        {
            private readonly DbContextOptions _options;
            private readonly SpannerTestStore _testStore;

            public NullKeysSpannerFixture()
            {
                var name = "stringscontext";
                var connectionString = SpannerTestStore.CreateConnectionString(name);

                _options = new DbContextOptionsBuilder()
                    .UseSpanner(connectionString, b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(new ServiceCollection()
                        .AddEntityFrameworkSpanner()
                        .AddSingleton(TestModelSource.GetFactory(OnModelCreating))
                        .BuildServiceProvider())
                    .Options;

                _testStore = SpannerTestStore.GetOrCreateShared(name, EnsureCreated);
            }

            public void Dispose() => _testStore.Dispose();

            public override DbContext CreateContext()
                => new DbContext(_options);
        }
    }
}