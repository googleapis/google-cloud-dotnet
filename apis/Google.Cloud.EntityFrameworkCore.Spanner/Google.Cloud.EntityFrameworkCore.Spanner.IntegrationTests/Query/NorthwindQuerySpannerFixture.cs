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
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class NorthwindQuerySpannerFixture : NorthwindQueryRelationalFixture, IDisposable
    {
        private readonly Func<Action<ModelBuilder>, Func<IServiceProvider, IModelSource>> _modelSourceFactory;

        private readonly SpannerTestStore _testStore = SpannerTestStore.GetNorthwindStore();

        public NorthwindQuerySpannerFixture() : this(TestModelSource.GetFactory)
        {
        }

        protected NorthwindQuerySpannerFixture(
            Func<Action<ModelBuilder>, Func<IServiceProvider, IModelSource>> modelSourceFactory) =>
            _modelSourceFactory = modelSourceFactory;

        public TestSqlLoggerFactory TestSqlLoggerFactory { get; } = new TestSqlLoggerFactory();

        public void Dispose() => _testStore.Dispose();

        public override DbContextOptions BuildOptions(IServiceCollection additionalServices = null)
            => ConfigureOptions(
                    new DbContextOptionsBuilder()
                        .ConfigureWarnings(w => w.Log(CoreEventId.IncludeIgnoredWarning))
                        .EnableSensitiveDataLogging()
                        .UseInternalServiceProvider(
                            (additionalServices ?? new ServiceCollection())
                            .AddEntityFrameworkSpanner()
                            .AddSingleton(_modelSourceFactory(OnModelCreating))
                            .AddSingleton<ILoggerFactory>(TestSqlLoggerFactory)
                            .BuildServiceProvider()))
                .UseSpanner(
                    _testStore.ConnectionString,
                    b =>
                    {
                        b.ApplyConfiguration();
                        ConfigureOptions(b);
                        b.ApplyConfiguration();
                    })
                .Options;

        protected virtual DbContextOptionsBuilder ConfigureOptions(DbContextOptionsBuilder dbContextOptionsBuilder)
            => dbContextOptionsBuilder;

        protected virtual void ConfigureOptions(SpannerDbContextOptionsBuilder SpannerDbContextOptionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerID)
                .HasColumnType("STRING(5)");

            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.UnitPrice)
                .HasColumnType("FLOAT64");

            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .HasColumnType("FLOAT64");

            modelBuilder.Entity<OrderDetail>().ToTable("Order_Details");
        }
    }
}