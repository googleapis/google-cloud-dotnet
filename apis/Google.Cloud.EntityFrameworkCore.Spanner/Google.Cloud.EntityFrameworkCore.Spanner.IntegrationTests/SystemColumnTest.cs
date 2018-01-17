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
using Microsoft.EntityFrameworkCore.Utilities;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class SystemColumnTest : IDisposable
    {
        public SystemColumnTest()
        {
            _testStore = SpannerTestStore.CreateScratch();

            _options = new DbContextOptionsBuilder()
                .UseSpanner(_testStore.Connection)
                .Options;

            using (var context = CreateContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void Dispose() => _testStore.Dispose();

        private class SystemColumnContext : DbContext
        {
            internal SystemColumnContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<SomeEntity> SomeEntity { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<SomeEntity>().Property(e => e.xmin).ValueGeneratedOnAddOrUpdate();
            }
        }

        public class SomeEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public uint xmin { get; set; }
        }

        private SystemColumnContext CreateContext()
        {
            var context = new SystemColumnContext(_options);
            context.Database.UseTransaction(_testStore.Transaction);
            return context;
        }

        private readonly DbContextOptions _options;
        private readonly SpannerTestStore _testStore;

        [Fact(Skip = "Server generated column values are not supported by Spanner")]
        public void xmin()
        {
            using (var context = CreateContext())
            {
                var e = new SomeEntity {Name = "Bart"};
                context.Add(e);
                context.SaveChanges();
                var firstVersion = e.xmin;

                e.Name = "Lisa";
                context.SaveChanges();
                var secondVersion = e.xmin;

                Assert.NotEqual(firstVersion, secondVersion);
            }
        }
    }
}