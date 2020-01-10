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
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class ArrayQueryTest : IClassFixture<ArrayFixture>
    {
        public ArrayQueryTest(ArrayFixture fixture)
        {
            Fixture = fixture;
            Fixture.TestSqlLoggerFactory.Clear();
        }

        private ArrayFixture Fixture { get; }

        private ArrayContext CreateContext() => Fixture.CreateContext();

        private void AssertContainsInSql(string expected)
            => Assert.Contains(expected, Fixture.TestSqlLoggerFactory.Sql);

        private void AssertDoesNotContainInSql(string expected)
            => Assert.DoesNotContain(expected, Fixture.TestSqlLoggerFactory.Sql);

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Contains_with_column()
        {
            using (var ctx = CreateContext())
            {
                var x = ctx.SomeEntities.Single(e => e.SomeArray.Contains(e.Id + 2));
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE ""e"".""Id"" + 2 = ANY (""e"".""SomeArray"")");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Contains_with_literal()
        {
            using (var ctx = CreateContext())
            {
                var x = ctx.SomeEntities.Single(e => e.SomeArray.Contains(3));
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE 3 = ANY (""e"".""SomeArray"")");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Contains_with_parameter()
        {
            using (var ctx = CreateContext())
            {
                var p = 3;
                var x = ctx.SomeEntities.Single(e => e.SomeArray.Contains(p));
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE @__p_0 = ANY (""e"".""SomeArray"")");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Index_bytea_with_constant()
        {
            using (var ctx = CreateContext())
            {
                var actual = ctx.SomeEntities.Where(e => e.SomeBytea[0] == 3).ToList();
                Assert.Equal(1, actual.Count);
                AssertContainsInSql(@"WHERE (get_byte(""e"".""SomeBytea"", 0)) = 3");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Index_multidimensional()
        {
            using (var ctx = CreateContext())
            {
                // Operations on multidimensional arrays aren't mapped to SQL yet
                var actual = ctx.SomeEntities.Where(e => e.SomeMatrix[0, 0] == 5).ToList();
                Assert.Equal(1, actual.Count);
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Index_with_constant()
        {
            using (var ctx = CreateContext())
            {
                var actual = ctx.SomeEntities.Where(e => e.SomeArray[0] == 3).ToList();
                Assert.Equal(1, actual.Count);
                AssertContainsInSql(@"WHERE (""e"".""SomeArray""[1]) = 3");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Index_with_non_constant()
        {
            using (var ctx = CreateContext())
            {
                var x = 0;
                var actual = ctx.SomeEntities.Where(e => e.SomeArray[x] == 3).ToList();
                Assert.Equal(1, actual.Count);
                AssertContainsInSql(@"WHERE (""e"".""SomeArray""[@__x_0 + 1]) = 3");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Length()
        {
            using (var ctx = CreateContext())
            {
                var x = ctx.SomeEntities.Single(e => e.SomeArray.Length == 2);
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE array_length(""e"".""SomeArray"", 1) = 2");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Length_on_EF_Property()
        {
            using (var ctx = CreateContext())
            {
                // TODO: This fails
                var x = ctx.SomeEntities.Single(e => EF.Property<int[]>(e, nameof(SomeEntity.SomeArray)).Length == 2);
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE array_length(""e"".""SomeArray"", 1) = 2");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Length_on_literal_not_translated()
        {
            using (var ctx = CreateContext())
            {
                var x = ctx.SomeEntities.Where(e => new[] {1, 2, 3}.Length == e.Id).ToList();
                AssertDoesNotContainInSql("array_length");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void Roundtrip()
        {
            using (var ctx = CreateContext())
            {
                var x = ctx.SomeEntities.Single(e => e.Id == 1);
                Assert.Equal(new[] {3, 4}, x.SomeArray);
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void SequenceEqual_with_array_literal()
        {
            using (var ctx = CreateContext())
            {
                var x = ctx.SomeEntities.Single(e => e.SomeArray.SequenceEqual(new[] {3, 4}));
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE ""e"".""SomeArray"" = ARRAY[3,4]");
            }
        }

        [Fact(Skip = "of type 'Int32[]' which is not a supported primitive type")]
        public void SequenceEqual_with_parameter()
        {
            using (var ctx = CreateContext())
            {
                var arr = new[] {3, 4};
                var x = ctx.SomeEntities.Single(e => e.SomeArray.SequenceEqual(arr));
                Assert.Equal(new[] {3, 4}, x.SomeArray);
                AssertContainsInSql(@"WHERE ""e"".""SomeArray"" = @");
            }
        }
    }

    public class ArrayContext : DbContext
    {
        public ArrayContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SomeEntity> SomeEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }

    public class SomeEntity
    {
        public int Id { get; set; }
        public int[] SomeArray { get; set; }
        public int[,] SomeMatrix { get; set; }
        public byte[] SomeBytea { get; set; }
        public string SomeText { get; set; }
    }

    public class ArrayFixture : IDisposable
    {
        private readonly DbContextOptions _options;

        private readonly SpannerTestStore _testStore;

        public ArrayFixture()
        {
            _testStore = SpannerTestStore.CreateScratch();
            _options = new DbContextOptionsBuilder()
                .UseSpanner(_testStore.Connection, b => b.ApplyConfiguration())
                .UseInternalServiceProvider(
                    new ServiceCollection()
                        .AddEntityFrameworkSpanner()
                        .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                        .BuildServiceProvider())
                .Options;

            using (var ctx = CreateContext())
            {
                ctx.Database.EnsureCreated();
                ctx.SomeEntities.Add(new SomeEntity
                {
                    Id = 1,
                    SomeArray = new[] {3, 4},
                    SomeBytea = new byte[] {3, 4},
                    SomeMatrix = new[,] {{5, 6}, {7, 8}}
                });
                ctx.SomeEntities.Add(new SomeEntity
                {
                    Id = 2,
                    SomeArray = new[] {5, 6, 7},
                    SomeBytea = new byte[] {5, 6, 7},
                    SomeMatrix = new[,] {{10, 11}, {12, 13}}
                });
                ctx.SaveChanges();
            }
        }

        public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();
        public void Dispose() => _testStore.Dispose();
        public ArrayContext CreateContext() => new ArrayContext(_options);
    }
}