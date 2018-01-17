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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class BatchingTest : IDisposable
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly SpannerTestStore _testStore;

        public BatchingTest()
        {
            _testStore = SpannerTestStore.CreateScratch();
            _serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .BuildServiceProvider();
        }

        public void Dispose() => _testStore.Dispose();

        [Theory(Skip = "'Order' is a reserved word in Spanner can cannot be used as a column name.")]
        [InlineData(true, true, true)]
        [InlineData(false, true, true)]
        [InlineData(true, false, true)]
        [InlineData(false, false, true)]
        [InlineData(true, true, false)]
        [InlineData(false, true, false)]
        [InlineData(true, false, false)]
        [InlineData(false, false, false)]
        public void Inserts_are_batched_correctly(bool clientPk, bool clientFk, bool clientOrder)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSpanner(_testStore.Connection);

            var expectedBlogs = new List<Blog>();
            using (var context = new BloggingContext(_serviceProvider, optionsBuilder.Options))
            {
                context.Database.EnsureCreated();
                var owner1 = new Owner();
                var owner2 = new Owner();
                context.Owners.Add(owner1);
                context.Owners.Add(owner2);

                for (var i = 1; i < 500; i++)
                {
                    var blog = new Blog();
                    if (clientPk)
                    {
                        blog.Id = Guid.NewGuid();
                    }

                    if (clientFk)
                    {
                        blog.Owner = i % 2 == 0 ? owner1 : owner2;
                    }

                    if (clientOrder)
                    {
                        blog.Order = i;
                    }

                    context.Blogs.Add(blog);
                    expectedBlogs.Add(blog);
                }

                context.SaveChanges();
            }

            expectedBlogs = clientOrder
                ? expectedBlogs.OrderBy(b => b.Order).ToList()
                : expectedBlogs.OrderBy(b => b.Id).ToList();
            using (var context = new BloggingContext(_serviceProvider, optionsBuilder.Options))
            {
                var actualBlogs = clientOrder
                    ? context.Blogs.OrderBy(b => b.Order).ToList()
                    : expectedBlogs.OrderBy(b => b.Id).ToList();
                Assert.Equal(expectedBlogs.Count, actualBlogs.Count);

                for (var i = 0; i < actualBlogs.Count; i++)
                {
                    var expected = expectedBlogs[i];
                    var actual = actualBlogs[i];
                    Assert.Equal(expected.Id, actual.Id);
                    Assert.Equal(expected.Order, actual.Order);
                    Assert.Equal(expected.OwnerId, actual.OwnerId);
                    Assert.Equal(expected.Version, actual.Version);
                }
            }
        }

        private class BloggingContext : DbContext
        {
            public BloggingContext(IServiceProvider serviceProvider, DbContextOptions options)
                : base(new DbContextOptionsBuilder(options).UseInternalServiceProvider(serviceProvider).Options)
            {
            }

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Owner> Owners { get; set; }
        }

        private class Blog
        {
            public Guid Id { get; set; }
            public int Order { get; set; }
            public int? OwnerId { get; set; }
            public Owner Owner { get; set; }
            public byte[] Version { get; set; }
        }

        public class Owner
        {
            public int Id { get; set; }
        }
    }
}