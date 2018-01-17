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
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class NavigationTest : IClassFixture<NavigationTestFixture>
    {
        public NavigationTest(NavigationTestFixture fixture) => _fixture = fixture;

        private readonly NavigationTestFixture _fixture;

        [Fact]
        public void Duplicate_entries_are_not_created_for_navigations_to_dependant()
        {
            using (var context = _fixture.CreateContext())
            {
                context.ConfigAction = modelBuilder =>
                {
                    modelBuilder.Entity<GoTPerson>().HasOne(p => p.SiblingReverse).WithMany(p => p.Siblings)
                        .IsRequired(false);
                    modelBuilder.Entity<GoTPerson>().HasOne(p => p.Lover).WithOne(p => p.LoverReverse)
                        .IsRequired(false);
                    return 0;
                };

                var model = context.Model;
                var entityType = model.GetEntityTypes().First();

                Assert.Equal(
                    "ForeignKey: GoTPerson {'LoverId'} -> GoTPerson {'Id'} Unique ToDependent: LoverReverse ToPrincipal: Lover",
                    entityType.GetForeignKeys().First().ToString());

                Assert.Equal(
                    "ForeignKey: GoTPerson {'SiblingReverseId'} -> GoTPerson {'Id'} ToDependent: Siblings ToPrincipal: SiblingReverse",
                    entityType.GetForeignKeys().Skip(1).First().ToString());
            }
        }

        [Fact]
        public void Duplicate_entries_are_not_created_for_navigations_to_principal()
        {
            using (var context = _fixture.CreateContext())
            {
                context.ConfigAction = modelBuilder =>
                {
                    modelBuilder.Entity<GoTPerson>().HasMany(p => p.Siblings).WithOne(p => p.SiblingReverse)
                        .IsRequired(false);
                    modelBuilder.Entity<GoTPerson>().HasOne(p => p.Lover).WithOne(p => p.LoverReverse)
                        .IsRequired(false);
                    return 0;
                };

                var model = context.Model;
                var entityType = model.GetEntityTypes().First();

                Assert.Equal(
                    "ForeignKey: GoTPerson {'LoverId'} -> GoTPerson {'Id'} Unique ToDependent: LoverReverse ToPrincipal: Lover",
                    entityType.GetForeignKeys().First().ToString());

                Assert.Equal(
                    "ForeignKey: GoTPerson {'SiblingReverseId'} -> GoTPerson {'Id'} ToDependent: Siblings ToPrincipal: SiblingReverse",
                    entityType.GetForeignKeys().Skip(1).First().ToString());
            }
        }
    }

    public class GoTPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<GoTPerson> Siblings { get; set; }
        public GoTPerson Lover { get; set; }
        public GoTPerson LoverReverse { get; set; }
        public GoTPerson SiblingReverse { get; set; }
    }

    public class GoTContext : DbContext
    {
        public GoTContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<GoTPerson> People { get; set; }
        public Func<ModelBuilder, int> ConfigAction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => ConfigAction.Invoke(modelBuilder);
    }

    public class NavigationTestFixture
    {
        private readonly DbContextOptions _options;

        public NavigationTestFixture()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .BuildServiceProvider();

            var connStrBuilder = new SpannerConnectionStringBuilder(TestEnvironment.DefaultConnection);

            _options = new DbContextOptionsBuilder()
                .UseSpanner(connStrBuilder.ConnectionString)
                .UseInternalServiceProvider(serviceProvider)
                .Options;
        }

        public virtual GoTContext CreateContext() => new GoTContext(_options);
    }
}