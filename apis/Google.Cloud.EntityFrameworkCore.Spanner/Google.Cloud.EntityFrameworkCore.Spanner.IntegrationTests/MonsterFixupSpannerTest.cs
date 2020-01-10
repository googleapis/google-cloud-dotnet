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
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.TestModels;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    //TODO: monster fixup support.
    internal class MonsterFixupSpannerTest : MonsterFixupTestBase, IDisposable
    {
        private SpannerTestStore _testStore;

        public virtual void Dispose() => _testStore?.Dispose();

        protected override IServiceProvider CreateServiceProvider(bool throwingStateManager = false)
        {
            var serviceCollection = new ServiceCollection()
                .AddEntityFrameworkSpanner();

            if (throwingStateManager)
            {
                serviceCollection.AddScoped<IStateManager, ThrowingMonsterStateManager>();
            }

            return serviceCollection.BuildServiceProvider();
        }

        protected override DbContextOptions CreateOptions(string databaseName)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSpanner(CreateConnectionString(databaseName), b => b.ApplyConfiguration());

            return optionsBuilder.Options;
        }

        private static string CreateConnectionString(string name)
            => new SpannerConnectionStringBuilder(TestEnvironment.DefaultConnection)
                .WithDatabase(name).ConnectionString;

        protected override void CreateAndSeedDatabase(string databaseName, Func<MonsterContext> createContext,
            Action<MonsterContext> seed)
        {
            _testStore = SpannerTestStore.GetOrCreateShared(databaseName, () =>
            {
                using (var context = createContext())
                {
                    context.Database.EnsureCreated();
                    seed(context);
                }
            });
        }

        protected override void OnModelCreating<TMessage, TProductPhoto, TProductReview>(ModelBuilder builder)
        {
            base.OnModelCreating<TMessage, TProductPhoto, TProductReview>(builder);

            builder.Entity<TMessage>().HasKey(e => e.MessageId);
            builder.Entity<TProductPhoto>().HasKey(e => e.PhotoId);
            builder.Entity<TProductReview>().HasKey(e => e.ReviewId);
        }
    }
}