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
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Utilities;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
#pragma warning disable xUnit1000 // Test classes must be public
    /// <summary>
    /// TODO: implement tests for Spanner (most of these are N/A in Spanner)
    /// </summary>
    internal class SpannerValueGenerationScenariosTest
#pragma warning restore xUnit1000 // Test classes must be public
    {
        private static readonly string DatabaseName = "spannervaluegenerationscenariostest";

        public class BlogContextSequence : ContextBase
        {
            public BlogContextSequence(string databaseName) : base(databaseName)
            {
            }
        }

        public class BlogContextDefaultValue : ContextBase
        {
            public BlogContextDefaultValue(string databaseName)
                : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder
                    .HasSequence("MySequence")
                    .StartsAt(77);

                modelBuilder
                    .Entity<Blog>()
                    .Property(e => e.Id)
                    .HasDefaultValueSql("nextval('\"MySequence\"')");
            }
        }

        public class BlogContextKeyColumnWithDefaultValue : ContextBase
        {
            public BlogContextKeyColumnWithDefaultValue(string databaseName)
                : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder
                    .HasSequence("MySequence")
                    .StartsAt(77);

                modelBuilder
                    .Entity<Blog>()
                    .Property(e => e.Id)
                    .HasDefaultValueSql("nextval('\"MySequence\"')")
                    .Metadata.BeforeSaveBehavior = PropertySaveBehavior.Throw;
            }
        }

        public class BlogContextNoKeyGeneration : ContextBase
        {
            public BlogContextNoKeyGeneration(string databaseName) : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder
                    .Entity<Blog>()
                    .Property(e => e.Id)
                    .ValueGeneratedNever();
            }
        }

        public class BlogContextNoKeyGenerationNullableKey : ContextBase
        {
            public BlogContextNoKeyGenerationNullableKey(string databaseName)
                : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder
                    .Entity<NullableKeyBlog>()
                    .Property(e => e.Id)
                    .ValueGeneratedNever();
            }
        }

        public class BlogContextNonKeyDefaultValue : ContextBase
        {
            public BlogContextNonKeyDefaultValue(string databaseName)
                : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Blog>()
                    .Property(e => e.CreatedOn)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("now()");
            }
        }

        public class BlogContextNonKeyReadOnlyDefaultValue : ContextBase
        {
            public BlogContextNonKeyReadOnlyDefaultValue(string databaseName)
                : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Blog>()
                    .Property(e => e.CreatedOn)
                    .HasDefaultValueSql("now()")
                    .Metadata.BeforeSaveBehavior = PropertySaveBehavior.Throw;
            }
        }

        public class BlogContextSequenceNonId : ContextBase
        {
            public BlogContextSequenceNonId(string databaseName) : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder
                    .Entity<Blog>()
                    .Property(e => e.OtherId)
                    .ValueGeneratedOnAdd();

                modelBuilder
                    .Entity<Blog>()
                    .Property(e => e.Id)
                    .HasValueGenerator<IntGenerator>();
            }
        }

        public class BlogContext : ContextBase
        {
            public BlogContext(string databaseName) : base(databaseName)
            {
            }
        }

        public class BlogContextServerGuidKey : ContextBase
        {
            public BlogContextServerGuidKey(string databaseName)
                : base(databaseName)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder
                    .Entity<GuidBlog>()
                    .Property(e => e.Id)
                    .HasDefaultValueSql("uuid_generate_v4()");
            }
        }

        public class Blog
        {
            public int Id { get; set; }
            public int OtherId { get; set; }
            public string Name { get; set; }
            public DateTime CreatedOn { get; set; }
        }

        public class NullableKeyBlog
        {
            public int? Id { get; set; }
            public string Name { get; set; }
            public DateTime CreatedOn { get; set; }
        }

        public class FullNameBlog
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
        }

        public class GuidBlog
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }

        public class ConcurrentBlog
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public byte[] Timestamp { get; set; }
        }

        public abstract class ContextBase : DbContext
        {
            private readonly string _databaseName;

            protected ContextBase(string databaseName) => _databaseName = databaseName;

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<NullableKeyBlog> NullableKeyBlogs { get; set; }
            public DbSet<FullNameBlog> FullNameBlogs { get; set; }
            public DbSet<GuidBlog> GuidBlogs { get; set; }
            public DbSet<ConcurrentBlog> ConcurrentBlogs { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseSpanner(SpannerTestStore.CreateConnectionString(_databaseName),
                    b => b.ApplyConfiguration());
        }

        public class TestBase<TContext>
            where TContext : ContextBase, new()
        {
            public TestBase()
            {
                using (var context = new TContext())
                {
                    context.Database.EnsureDeleted();
                }
            }
        }

        [Fact]
        public void Insert_with_client_generated_GUID_key()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                Guid afterSave;
                using (var context = new BlogContext(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    var blog = context.Add(new GuidBlog {Name = "One Unicorn"}).Entity;

                    var beforeSave = blog.Id;

                    context.SaveChanges();

                    afterSave = blog.Id;

                    Assert.Equal(beforeSave, afterSave);
                }

                using (var context = new BlogContext(testStore.Name))
                {
                    Assert.Equal(afterSave, context.GuidBlogs.Single().Id);
                }
            }
        }

        [Fact(Skip = "sequence not supported.")]
        public void Insert_with_default_value_from_sequence()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextDefaultValue(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    context.AddRange(new Blog {Name = "One Unicorn"}, new Blog {Name = "Two Unicorns"});

                    context.SaveChanges();
                }

                using (var context = new BlogContextDefaultValue(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Id).ToList();

                    Assert.Equal(77, blogs[0].Id);
                    Assert.Equal(78, blogs[1].Id);
                }
            }
        }

        [Fact]
        public void Insert_with_explicit_non_default_keys()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextNoKeyGeneration(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    context.AddRange(new Blog {Id = 66, Name = "One Unicorn"},
                        new Blog {Id = 67, Name = "Two Unicorns"});

                    context.SaveChanges();
                }

                using (var context = new BlogContextNoKeyGeneration(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Id).ToList();

                    Assert.Equal(66, blogs[0].Id);
                    Assert.Equal(67, blogs[1].Id);
                }
            }
        }

        [Fact]
        public void Insert_with_explicit_with_default_keys()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextNoKeyGenerationNullableKey(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    context.AddRange(
                        new NullableKeyBlog {Id = 0, Name = "One Unicorn"},
                        new NullableKeyBlog {Id = 1, Name = "Two Unicorns"});

                    context.SaveChanges();
                }

                using (var context = new BlogContextNoKeyGenerationNullableKey(testStore.Name))
                {
                    var blogs = context.NullableKeyBlogs.OrderBy(e => e.Id).ToList();

                    Assert.Equal(0, blogs[0].Id);
                    Assert.Equal(1, blogs[1].Id);
                }
            }
        }

        [Fact(Skip = "Sequence type not supported by Spanner")]
        public void Insert_with_key_default_value_from_sequence()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextKeyColumnWithDefaultValue(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    context.AddRange(new Blog {Name = "One Unicorn"}, new Blog {Name = "Two Unicorns"});

                    context.SaveChanges();
                }

                using (var context = new BlogContextKeyColumnWithDefaultValue(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Id).ToList();

                    Assert.Equal(77, blogs[0].Id);
                    Assert.Equal(78, blogs[1].Id);
                }
            }
        }

        [Fact(Skip = "database values generated on add not supported")]
        public void Insert_with_non_key_default_value()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextNonKeyDefaultValue(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    var blogs = new List<Blog>
                    {
                        new Blog {Name = "One Unicorn"},
                        new Blog {Name = "Two Unicorns", CreatedOn = new DateTime(1969, 8, 3, 0, 10, 0)}
                    };

                    context.AddRange(blogs);

                    context.SaveChanges();

                    Assert.NotEqual(new DateTime(), blogs[0].CreatedOn);
                    Assert.NotEqual(new DateTime(), blogs[1].CreatedOn);
                }

                using (var context = new BlogContextNonKeyDefaultValue(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Name).ToList();

                    Assert.NotEqual(new DateTime(), blogs[0].CreatedOn);
                    Assert.Equal(new DateTime(1969, 8, 3, 0, 10, 0), blogs[1].CreatedOn);

                    blogs[0].CreatedOn = new DateTime(1973, 9, 3, 0, 10, 0);
                    blogs[1].Name = "Zwo Unicorns";

                    context.SaveChanges();
                }

                using (var context = new BlogContextNonKeyDefaultValue(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Name).ToList();

                    Assert.Equal(new DateTime(1969, 8, 3, 0, 10, 0), blogs[1].CreatedOn);
                    Assert.Equal(new DateTime(1973, 9, 3, 0, 10, 0), blogs[0].CreatedOn);
                }
            }
        }

        [Fact]
        public void Insert_with_non_key_default_value_readonly()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextNonKeyReadOnlyDefaultValue(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    context.AddRange(
                        new Blog {Name = "One Unicorn"},
                        new Blog {Name = "Two Unicorns"});

                    context.SaveChanges();

                    Assert.NotEqual(new DateTime(), context.Blogs.ToList()[0].CreatedOn);
                }

                DateTime dateTime0;

                using (var context = new BlogContextNonKeyReadOnlyDefaultValue(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Id).ToList();

                    dateTime0 = blogs[0].CreatedOn;

                    Assert.NotEqual(new DateTime(), dateTime0);
                    Assert.NotEqual(new DateTime(), blogs[1].CreatedOn);

                    blogs[0].Name = "One Pegasus";
                    blogs[1].CreatedOn = new DateTime(1973, 9, 3, 0, 10, 0);

                    context.SaveChanges();
                }

                using (var context = new BlogContextNonKeyReadOnlyDefaultValue(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Id).ToList();

                    Assert.Equal(dateTime0, blogs[0].CreatedOn);
                    Assert.Equal(new DateTime(1973, 9, 3, 0, 10, 0), blogs[1].CreatedOn);
                }
            }
        }

        [Fact(Skip = "server generated sequence values not supported")]
        public void Insert_with_sequence_id()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                using (var context = new BlogContextSequence(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    context.AddRange(new Blog {Name = "One Unicorn"}, new Blog {Name = "Two Unicorns"});

                    context.SaveChanges();
                }

                using (var context = new BlogContextSequence(testStore.Name))
                {
                    var blogs = context.Blogs.OrderBy(e => e.Id).ToList();

                    Assert.Equal(1, blogs[0].Id);
                    Assert.Equal(2, blogs[1].Id);
                }
            }
        }

        [Fact(Skip = "Sequence not supported in Spanner.")]
        public void Insert_with_serial_non_id()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                int afterSave;

                using (var context = new BlogContextSequenceNonId(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    var blog = context.Add(new Blog {Name = "One Unicorn"}).Entity;
                    var beforeSave = blog.OtherId;
                    context.SaveChanges();
                    afterSave = blog.OtherId;
                    Assert.NotEqual(beforeSave, afterSave);
                }

                using (var context = new BlogContextSequenceNonId(testStore.Name))
                {
                    Assert.Equal(afterSave, context.Blogs.Single().OtherId);
                }
            }
        }

        [Fact(Skip = "server generated GUID values not supported.")]
        public void Insert_with_server_generated_GUID_key()
        {
            using (var testStore = SpannerTestStore.Create(DatabaseName))
            {
                Guid afterSave;
                using (var context = new BlogContextServerGuidKey(testStore.Name))
                {
                    context.Database.EnsureCreated();

                    var blog = context.Add(new GuidBlog {Name = "One Unicorn"}).Entity;

                    var beforeSave = blog.Id;

                    context.SaveChanges();

                    afterSave = blog.Id;

                    Assert.NotEqual(beforeSave, afterSave);
                }

                using (var context = new BlogContextServerGuidKey(testStore.Name))
                {
                    Assert.Equal(afterSave, context.GuidBlogs.Single().Id);
                }
            }
        }
    }
}