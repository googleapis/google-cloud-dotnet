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
using System.Threading.Tasks;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class ExistingConnectionTest
    {
        private static async Task Can_use_an_existing_closed_connection_test(bool openConnection)
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .BuildServiceProvider();

            using (var store = SpannerTestStore.GetNorthwindStore())
            {
                var openCount = 0;
                var closeCount = 0;
                var disposeCount = 0;

                using (var connection = new SpannerConnection(store.ConnectionString))
                {
                    if (openConnection)
                    {
                        await connection.OpenAsync();
                    }

                    connection.StateChange += (_, a) =>
                    {
                        if (a.CurrentState == ConnectionState.Open)
                        {
                            openCount++;
                        }
                        else if (a.CurrentState == ConnectionState.Closed)
                        {
                            closeCount++;
                        }
                    };
                    connection.Disposed += (_, __) => disposeCount++;

                    using (var context = new NorthwindContext(serviceProvider, connection))
                    {
                        Assert.Equal(91, await context.Customers.CountAsync());
                    }

                    if (openConnection)
                    {
                        Assert.Equal(ConnectionState.Open, connection.State);
                        Assert.Equal(0, openCount);
                        Assert.Equal(0, closeCount);
                    }
                    else
                    {
                        Assert.Equal(ConnectionState.Closed, connection.State);
                        Assert.Equal(1, openCount);
                        Assert.Equal(1, closeCount);
                    }

                    Assert.Equal(0, disposeCount);
                }
            }
        }

        private class NorthwindContext : DbContext
        {
            private readonly SpannerConnection _connection;
            private readonly IServiceProvider _serviceProvider;

            public NorthwindContext(IServiceProvider serviceProvider, SpannerConnection connection)
            {
                _serviceProvider = serviceProvider;
                _connection = connection;
            }

            public DbSet<Customer> Customers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder
                    .UseSpanner(_connection)
                    .UseInternalServiceProvider(_serviceProvider);

            protected override void OnModelCreating(ModelBuilder modelBuilder)
                => modelBuilder.Entity<Customer>(b =>
                {
                    b.HasKey(c => c.CustomerID);
                    b.ToTable("Customers");
                });
        }

        private class Customer
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string Fax { get; set; }
        }

        // See aspnet/Data#135
        [Fact]
        public async Task Can_use_an_existing_closed_connection()
        {
            await Can_use_an_existing_closed_connection_test(false);
        }

        [Fact]
        public async Task Can_use_an_existing_open_connection()
        {
            await Can_use_an_existing_closed_connection_test(true);
        }
    }
}