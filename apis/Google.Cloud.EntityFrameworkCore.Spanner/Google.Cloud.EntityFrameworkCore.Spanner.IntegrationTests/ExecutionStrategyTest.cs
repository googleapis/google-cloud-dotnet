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
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
#pragma warning disable xUnit1000 // Test classes must be public
    /// <summary>
    /// TODO: implement tests for Spanner
    /// </summary>
    internal class ExecutionStrategyTest : IClassFixture<ExecutionStrategyTest.ExecutionStrategyFixture>, IDisposable
#pragma warning restore xUnit1000 // Test classes must be public
    {
        public ExecutionStrategyTest(ExecutionStrategyFixture fixture)
        {
            Fixture = fixture;
            TestStore = SpannerTestStore.GetOrCreateShared(DatabaseName, () =>
            {
                using (var context = CreateContext())
                {
                    context.Database.EnsureCreated();
                }
            });
        }

        public virtual void Dispose() => TestStore.Dispose();

        private void Test_commit_failure(bool realFailure)
        {
            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                () => { db.SaveChanges(false); },
                () => db.Products.AsNoTracking().Any()));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                () => db.SaveChanges(false),
                () => db.Products.AsNoTracking().Any()));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                db,
                c => { c.SaveChanges(acceptAllChangesOnSuccess: false); },
                c => c.Products.AsNoTracking().Any()));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                db,
                c => c.SaveChanges(acceptAllChangesOnSuccess: false),
                c => c.Products.AsNoTracking().Any()));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                () => { db.SaveChanges(false); },
                () => db.Products.AsNoTracking().Any(),
                IsolationLevel.Serializable));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                () => db.SaveChanges(false),
                () => db.Products.AsNoTracking().Any(),
                IsolationLevel.Serializable));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                db,
                c => { c.SaveChanges(acceptAllChangesOnSuccess: false); },
                c => c.Products.AsNoTracking().Any(),
                IsolationLevel.Serializable));

            Test_commit_failure(realFailure, (e, db) => e.ExecuteInTransaction(
                db,
                c => c.SaveChanges(acceptAllChangesOnSuccess: false),
                c => c.Products.AsNoTracking().Any(),
                IsolationLevel.Serializable));
        }

        private void Test_commit_failure(bool realFailure,
            Action<TestSpannerRetryingExecutionStrategy, ExecutionStrategyContext> execute)
        {
            CleanContext();

            using (var context = CreateContext())
            {
                var connection = (TestSpannerConnection) context.GetService<ISpannerRelationalConnection>();

                connection.CommitFailures.Enqueue(new bool?[] {realFailure});

                context.Products.Add(new Product());
                execute(new TestSpannerRetryingExecutionStrategy(context), context);
                context.ChangeTracker.AcceptAllChanges();

                Assert.Equal(realFailure ? 3 : 2, connection.OpenCount);
            }

            using (var context = CreateContext())
            {
                Assert.Equal(1, context.Products.Count());
            }
        }

        private async Task Test_commit_failure_async(bool realFailure)
        {
            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                () => db.SaveChangesAsync(false),
                () => db.Products.AsNoTracking().AnyAsync()));

            var cancellationToken = CancellationToken.None;
            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                async ct => { await db.SaveChangesAsync(false); },
                ct => db.Products.AsNoTracking().AnyAsync(),
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                ct => db.SaveChangesAsync(false),
                ct => db.Products.AsNoTracking().AnyAsync(),
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                db,
                async (c, ct) => { await c.SaveChangesAsync(acceptAllChangesOnSuccess: false); },
                (c, ct) => c.Products.AsNoTracking().AnyAsync(),
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                db,
                (c, ct) => c.SaveChangesAsync(acceptAllChangesOnSuccess: false),
                (c, ct) => c.Products.AsNoTracking().AnyAsync(),
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                () => db.SaveChangesAsync(false),
                () => db.Products.AsNoTracking().AnyAsync(),
                IsolationLevel.Serializable));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                async ct => { await db.SaveChangesAsync(false); },
                ct => db.Products.AsNoTracking().AnyAsync(),
                IsolationLevel.Serializable,
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                ct => db.SaveChangesAsync(false),
                ct => db.Products.AsNoTracking().AnyAsync(),
                IsolationLevel.Serializable,
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                db,
                async (c, ct) => { await c.SaveChangesAsync(acceptAllChangesOnSuccess: false); },
                (c, ct) => c.Products.AsNoTracking().AnyAsync(),
                IsolationLevel.Serializable,
                cancellationToken));

            await Test_commit_failure_async(realFailure, (e, db) => e.ExecuteInTransactionAsync(
                db,
                (c, ct) => { return c.SaveChangesAsync(acceptAllChangesOnSuccess: false); },
                (c, ct) => c.Products.AsNoTracking().AnyAsync(),
                IsolationLevel.Serializable,
                cancellationToken));
        }

        private async Task Test_commit_failure_async(bool realFailure,
            Func<TestSpannerRetryingExecutionStrategy, ExecutionStrategyContext, Task> execute)
        {
            CleanContext();

            using (var context = CreateContext())
            {
                var connection = (TestSpannerConnection) context.GetService<ISpannerRelationalConnection>();

                connection.CommitFailures.Enqueue(new bool?[] {realFailure});

                context.Products.Add(new Product());
                await execute(new TestSpannerRetryingExecutionStrategy(context), context);
                context.ChangeTracker.AcceptAllChanges();

                Assert.Equal(realFailure ? 3 : 2, connection.OpenCount);
            }

            using (var context = CreateContext())
            {
                Assert.Equal(1, await context.Products.CountAsync());
            }
        }

        private void Test_commit_failure_multiple_SaveChanges(bool realFailure)
        {
            CleanContext();

            using (var context1 = CreateContext())
            {
                var connection = (TestSpannerConnection) context1.GetService<ISpannerRelationalConnection>();

                using (var context2 = CreateContext(connection.DbConnection))
                {
                    connection.CommitFailures.Enqueue(new bool?[] {realFailure});

                    context1.Products.Add(new Product());
                    context2.Products.Add(new Product());

                    new TestSpannerRetryingExecutionStrategy(context1).ExecuteInTransaction(
                        context1,
                        c1 =>
                        {
                            context2.Database.UseTransaction(null);
                            context2.Database.UseTransaction(context1.Database.CurrentTransaction.GetDbTransaction());

                            c1.SaveChanges(acceptAllChangesOnSuccess: false);

                            return context2.SaveChanges(acceptAllChangesOnSuccess: false);
                        },
                        c => c.Products.AsNoTracking().Any());

                    context1.ChangeTracker.AcceptAllChanges();
                    context2.ChangeTracker.AcceptAllChanges();
                }

                using (var context = CreateContext())
                {
                    Assert.Equal(2, context.Products.Count());
                }
            }
        }

        private void Test_execution_failure(bool realFailure)
        {
            CleanContext();

            using (var context = CreateContext())
            {
                var connection = (TestSpannerConnection) context.GetService<ISpannerRelationalConnection>();

                connection.ExecutionFailures.Enqueue(new bool?[] {null, realFailure});

                context.Products.Add(new Product());
                context.Products.Add(new Product());
                new TestSpannerRetryingExecutionStrategy(context).ExecuteInTransaction(
                    context,
                    c => c.SaveChanges(acceptAllChangesOnSuccess: false),
                    c =>
                    {
                        // This shouldn't be called if SaveChanges failed
                        Assert.True(false);
                        return false;
                    });
                context.ChangeTracker.AcceptAllChanges();

                Assert.Equal(2, connection.OpenCount);
                Assert.Equal(4, connection.ExecutionCount);
            }

            using (var context = CreateContext())
            {
                Assert.Equal(2, context.Products.Count());
            }
        }

        protected class ExecutionStrategyContext : DbContext
        {
            public ExecutionStrategyContext(DbContextOptions options)
                : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
        }

        protected class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private const string DatabaseName = "executionstrategytest";

        protected ExecutionStrategyFixture Fixture { get; }
        protected SpannerTestStore TestStore { get; }

        protected virtual ExecutionStrategyContext CreateContext()
            => (ExecutionStrategyContext) Fixture.CreateContext();

        protected virtual ExecutionStrategyContext CreateContext(DbConnection connection)
            => (ExecutionStrategyContext) Fixture.CreateContext(connection);

        public class ExecutionStrategyFixture
        {
            private readonly DbContextOptions _baseOptions;
            private readonly DbContextOptions _options;

            public ExecutionStrategyFixture()
            {
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkSpanner()
                    .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                    .AddScoped<ISpannerRelationalConnection, TestSpannerConnection>()
                    .AddScoped<IRelationalCommandBuilderFactory, TestRelationalCommandBuilderFactory>()
                    .BuildServiceProvider();

                _baseOptions = new DbContextOptionsBuilder()
                    .UseInternalServiceProvider(serviceProvider)
                    .EnableSensitiveDataLogging()
                    .Options;

                _options = new DbContextOptionsBuilder(_baseOptions)
                    .UseSpanner(SpannerTestStore.CreateConnectionString(DatabaseName), ApplySpannerOptions)
                    .Options;
            }

            public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

            private static void ApplySpannerOptions(SpannerDbContextOptionsBuilder b)
            {
                b.ApplyConfiguration();
                b.MaxBatchSize(1);
            }

            public virtual DbContext CreateContext()
                => new ExecutionStrategyContext(_options);

            public virtual DbContext CreateContext(DbConnection connection)
                => new ExecutionStrategyContext(
                    new DbContextOptionsBuilder(_baseOptions)
                        .UseSpanner(connection, ApplySpannerOptions)
                        .Options);
        }

        private void CleanContext()
        {
            using (var context = CreateContext())
            {
                foreach (var product in context.Products.ToList())
                {
                    context.Remove(product);
                    context.SaveChanges();
                }
            }
        }

        [Fact]
        public void Does_not_throw_or_retry_on_false_commit_failure()
        {
            Test_commit_failure(false);
        }

        [Fact]
        public Task Does_not_throw_or_retry_on_false_commit_failure_async() => Test_commit_failure_async(false);

        [Fact]
        public void Does_not_throw_or_retry_on_false_commit_failure_multiple_SaveChanges()
        {
            Test_commit_failure_multiple_SaveChanges(false);
        }

        [Fact]
        public void Does_not_throw_or_retry_on_false_execution_failure()
        {
            Test_execution_failure(false);
        }

        [Fact]
        public void Retries_on_true_commit_failure()
        {
            Test_commit_failure(true);
        }

        [Fact]
        public Task Retries_on_true_commit_failure_async() => Test_commit_failure_async(true);

        [Fact]
        public void Retries_on_true_commit_failure_multiple_SaveChanges()
        {
            Test_commit_failure_multiple_SaveChanges(true);
        }

        [Fact]
        public void Retries_on_true_execution_failure()
        {
            Test_execution_failure(true);
        }

        [Fact]
        public void Verification_is_retried_using_same_retry_limit()
        {
            CleanContext();

            using (var context = CreateContext())
            {
                var connection = (TestSpannerConnection) context.GetService<ISpannerRelationalConnection>();

                connection.ExecutionFailures.Enqueue(new bool?[] {true, null, true, true});
                connection.CommitFailures.Enqueue(new bool?[] {true, true, true, true});

                context.Products.Add(new Product());
                Assert.Throws<RetryLimitExceededException>(() =>
                    new TestSpannerRetryingExecutionStrategy(context, TimeSpan.FromMilliseconds(100))
                        .ExecuteInTransaction(
                            context,
                            c => c.SaveChanges(acceptAllChangesOnSuccess: false),
                            c => false));
                context.ChangeTracker.AcceptAllChanges();

                Assert.Equal(7, connection.OpenCount);
                Assert.Equal(7, connection.ExecutionCount);
            }

            using (var context = CreateContext())
            {
                Assert.Equal(0, context.Products.Count());
            }
        }
    }
}