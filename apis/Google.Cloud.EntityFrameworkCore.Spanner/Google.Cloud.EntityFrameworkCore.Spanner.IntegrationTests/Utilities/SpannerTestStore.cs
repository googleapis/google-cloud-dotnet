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
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public class SpannerTestStore : RelationalTestStore
    {
        private const string Northwind = "northwind";

        public const int CommandTimeout = 90;

        public static readonly string NorthwindConnectionString = CreateConnectionString(Northwind);
        private readonly bool _cleanDatabase;
        private SpannerConnection _connection;

        private string _connectionString;
        private bool _deleteDatabase;

        /// <summary>
        /// This map helps us parse INSERT INTO TSQL when the sql does not indicate the column
        /// </summary>
        private static readonly Dictionary<string, string[]> s_tableFieldsNames
            = new Dictionary<string, string[]>
            {
                {
                    "Employees",
                    new[]
                    {
                        "EmployeeID",
                        "LastName",
                        "FirstName",
                        "Title",
                        "TitleOfCourtesy",
                        "BirthDate",
                        "HireDate",
                        "Address",
                        "City",
                        "Region",
                        "PostalCode",
                        "Country",
                        "HomePhone",
                        "Extension",
                        "Photo",
                        "Notes",
                        "ReportsTo",
                        "PhotoPath"
                    }
                },
                {
                    "Categories",
                    new[]
                    {
                        "CategoryID",
                        "CategoryName",
                        "Description",
                        "Picture"
                    }
                },
                {
                    "Customers",
                    new[]
                    {
                        "CustomerID",
                        "CompanyName",
                        "ContactName",
                        "ContactTitle",
                        "Address",
                        "City",
                        "Region",
                        "PostalCode",
                        "Country",
                        "Phone",
                        "Fax"
                    }
                },
                {
                    "Shippers",
                    new[]
                    {
                        "ShipperID",
                        "CompanyName",
                        "Phone"
                    }
                },
                {
                    "Suppliers",
                    new[]
                    {
                        "SupplierID",
                        "CompanyName",
                        "ContactName",
                        "ContactTitle",
                        "Address",
                        "City",
                        "Region",
                        "PostalCode",
                        "Country",
                        "Phone",
                        "Fax",
                        "HomePage"
                    }
                },
                {
                    "Orders",
                    new[]
                    {
                        "OrderID",
                        "CustomerID",
                        "EmployeeID",
                        "OrderDate",
                        "RequiredDate",
                        "ShippedDate",
                        "ShipVia",
                        "Freight",
                        "ShipName",
                        "ShipAddress",
                        "ShipCity",
                        "ShipRegion",
                        "ShipPostalCode",
                        "ShipCountry"
                    }
                },
                {
                    "Products",
                    new[]
                    {
                        "ProductID",
                        "ProductName",
                        "SupplierID",
                        "CategoryID",
                        "QuantityPerUnit",
                        "UnitPrice",
                        "UnitsInStock",
                        "UnitsOnOrder",
                        "ReorderLevel",
                        "Discontinued"
                    }
                },
                {
                    "Order_Details",
                    new[]
                    {
                        "OrderID",
                        "ProductID",
                        "UnitPrice",
                        "Quantity",
                        "Discount"
                    }
                }

            };


        private SpannerTestStore(string name, bool cleanDatabase = true)
        {
            Name = name;
            _cleanDatabase = cleanDatabase;
        }

        private static string BaseDirectory => AppContext.BaseDirectory;

        public string Name { get; }
        public override string ConnectionString => _connectionString;

        public override DbConnection Connection => _connection;

        public override DbTransaction Transaction => null;

        public static SpannerTestStore GetNorthwindStore()
            => GetOrCreateShared(
                Northwind,
                () => ExecuteScript(Northwind, "Northwind.sql"),
                false);

        public static SpannerTestStore GetOrCreateShared(string name, Action initializeDatabase,
            bool cleanDatabase = true)
            => new SpannerTestStore(name, cleanDatabase).CreateShared(initializeDatabase);

        public static SpannerTestStore Create(string name)
            => new SpannerTestStore(name).CreateTransient(true, false);

        public static SpannerTestStore CreateScratch(bool createDatabase = true)
            => new SpannerTestStore(GetScratchDbName()).CreateTransient(createDatabase, true);

        private static string GetScratchDbName()
        {
            string name;
            do
            {
                name = "Scratch_" + Guid.NewGuid();
            } while (DatabaseExists(name));

            return name;
        }

        private SpannerTestStore CreateShared(Action initializeDatabase)
        {
            _connectionString = CreateConnectionString(Name);
            _connection = new SpannerConnection(_connectionString);

            CreateShared(typeof(SpannerTestStore).Name + Name,
                () =>
                {
                    if (CreateDatabase())
                    {
                        initializeDatabase?.Invoke();
                    }
                });

            return this;
        }

        private bool CreateDatabase()
        {
            using (var master = new SpannerConnection(CreateAdminConnectionString()))
            {
                if (DatabaseExists(Name))
                {
                    if (!_cleanDatabase)
                    {
                        return false;
                    }

                    Clean(Name);
                }
                else
                {
                    ExecuteNonQuery(master, GetCreateDatabaseStatement(Name));
                }
            }

            return true;
        }

        public static void ExecuteScript(string databaseName, string scriptPath)
        {
            // HACK: Probe for script file as current dir
            // is different between k build and VS run.
            if (File.Exists(@"..\..\" + scriptPath))
            {
                //executing in VS - so path is relative to bin\<config> dir
                scriptPath = @"..\..\" + scriptPath;
            }
            else
            {
                scriptPath = Path.Combine(BaseDirectory, scriptPath);
            }

            var script = File.ReadAllText(scriptPath);
            using (var connection = new SpannerConnection(CreateConnectionString(databaseName)))
            {
                Execute(connection, command =>
                {

                    var statements = Regex.Split(script, @";[\r?\n]\s+", RegexOptions.Multiline);

                    foreach (var statement in statements)
                    {
                        if (string.IsNullOrWhiteSpace(statement)
                            || statement.StartsWith("SET ", StringComparison.Ordinal))
                        {
                            continue;
                        }

                        command.CommandText = statement;
                        command.ExecuteNonQuery();
                    }

                    return 0;
                }, "");
            }
        }

        private SpannerTestStore CreateTransient(bool createDatabase, bool deleteDatabase)
        {
            _connectionString = CreateConnectionString(Name);
            _connection = new SpannerConnection(_connectionString);

            if (createDatabase)
            {
                CreateDatabase();

                OpenConnection();
            }
            else if (DatabaseExists(Name))
            {
                DeleteDatabase(Name);
            }

            _deleteDatabase = deleteDatabase;
            return this;
        }

        private static void Clean(string name)
        {
            //TODO(benwu)
//            var options = new DbContextOptionsBuilder()
//                .UseSpanner(CreateConnectionString(name), b => b.ApplyConfiguration())
//                .UseInternalServiceProvider(
//                    new ServiceCollection()
//                        .AddEntityFrameworkSpanner()
//                        .BuildServiceProvider())
//                .Options;
//
//            using (var context = new DbContext(options))
//            {
//                context.Database.EnsureClean();
//            }
        }

        private static string GetCreateDatabaseStatement(string name)
            => $@"CREATE DATABASE {name}";

        private static bool DatabaseExists(string name)
        {
            using (var targetDb = new SpannerConnection(CreateConnectionString(name)))
            {
                try
                {
                    var reader = targetDb.CreateSelectCommand("SELECT COUNT(*) FROM information_schema.tables").ExecuteReader();
                    reader.Dispose();
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.NotFound)
                {
                    return false;
                }
                return true;
            }
        }

        private void DeleteDatabase(string name)
        {
            if (!DatabaseExists(name))
            {
                return;
            }
            using (var master = new SpannerConnection(CreateAdminConnectionString()))
            {
                ExecuteNonQuery(master, GetDropDatabaseSql(name));

                SpannerConnection.ClearPooledResourcesAsync().WaitWithUnwrappedExceptions();
            }
        }

        private static string GetDropDatabaseSql(string name) => $@"DROP DATABASE ""{name}""";

        public override void OpenConnection() => _connection.Open();

        public Task OpenConnectionAsync() => _connection.OpenAsync();

        public T ExecuteScalar<T>(string sql, params object[] parameters)
            => ExecuteScalar<T>(_connection, sql, parameters);

        private static T ExecuteScalar<T>(SpannerConnection connection, string sql, params object[] parameters)
            => Execute(connection, command => (T) command.ExecuteScalar(), sql, false, parameters);

        public Task<T> ExecuteScalarAsync<T>(string sql, params object[] parameters)
            => ExecuteScalarAsync<T>(_connection, sql, parameters);

        private static Task<T> ExecuteScalarAsync<T>(SpannerConnection connection, string sql,
            object[] parameters = null)
            => ExecuteAsync(connection, async command => (T) await command.ExecuteScalarAsync(), sql, false,
                parameters);

        public int ExecuteNonQuery(string sql, params object[] parameters)
            => ExecuteNonQuery(_connection, sql, parameters);

        private static int ExecuteNonQuery(SpannerConnection connection, string sql, object[] parameters = null)
            => Execute(connection, command => command.ExecuteNonQuery(), sql, false, parameters);

        public Task<int> ExecuteNonQueryAsync(string sql, params object[] parameters)
            => ExecuteNonQueryAsync(_connection, sql, parameters);

        private static Task<int> ExecuteNonQueryAsync(SpannerConnection connection, string sql,
            object[] parameters = null)
            => ExecuteAsync(connection, command => command.ExecuteNonQueryAsync(), sql, false, parameters);

        public IEnumerable<T> Query<T>(string sql, params object[] parameters)
            => Query<T>(_connection, sql, parameters);

        private static IEnumerable<T> Query<T>(SpannerConnection connection, string sql, object[] parameters = null)
            => Execute(connection, command =>
            {
                using (var dataReader = command.ExecuteReader())
                {
                    var results = Enumerable.Empty<T>();
                    while (dataReader.Read())
                        results = results.Concat(new[] {dataReader.GetFieldValue<T>(0)});
                    return results;
                }
            }, sql, false, parameters);

        public Task<IEnumerable<T>> QueryAsync<T>(string sql, params object[] parameters)
            => QueryAsync<T>(_connection, sql, parameters);

        private static Task<IEnumerable<T>> QueryAsync<T>(SpannerConnection connection, string sql,
            object[] parameters = null)
            => ExecuteAsync(connection, async command =>
            {
                using (var dataReader = await command.ExecuteReaderAsync())
                {
                    var results = Enumerable.Empty<T>();
                    while (await dataReader.ReadAsync())
                        results = results.Concat(new[] {await dataReader.GetFieldValueAsync<T>(0)});
                    return results;
                }
            }, sql, false, parameters);

        private static T Execute<T>(
            SpannerConnection connection, Func<DbCommand, T> execute, string sql,
            bool useTransaction = false, object[] parameters = null)
            => ExecuteCommand(connection, execute, sql, useTransaction, parameters);

        private static T ExecuteCommand<T>(
            SpannerConnection connection, Func<DbCommand, T> execute, string sql, bool useTransaction,
            object[] parameters)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();
            try
            {
                using (var transaction = useTransaction ? connection.BeginTransaction() : null)
                {
                    T result;
                    using (var command = CreateCommand(connection, sql, parameters))
                    {
                        command.Transaction = transaction;
                        result = execute(command);
                    }
                    transaction?.Commit();

                    return result;
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Closed
                    && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private static Task<T> ExecuteAsync<T>(
            SpannerConnection connection, Func<DbCommand, Task<T>> executeAsync, string sql,
            bool useTransaction = false, IReadOnlyList<object> parameters = null)
            => ExecuteCommandAsync(connection, executeAsync, sql, useTransaction, parameters);

        private static async Task<T> ExecuteCommandAsync<T>(
            SpannerConnection connection, Func<DbCommand, Task<T>> executeAsync, string sql, bool useTransaction,
            IReadOnlyList<object> parameters)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            await connection.OpenAsync();
            try
            {
                using (var transaction = useTransaction ? connection.BeginTransaction() : null)
                {
                    T result;
                    using (var command = CreateCommand(connection, sql, parameters))
                    {
                        result = await executeAsync(command);
                    }
                    transaction?.Commit();

                    return result;
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Closed
                    && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private static DbCommand CreateCommand(
            SpannerConnection connection, string commandText, IReadOnlyList<object> parameters = null)
        {
            var command = connection.CreateCommand();

            command.CommandText = commandText;
            command.CommandTimeout = CommandTimeout;

            if (parameters != null)
            {
                //TODO(benu): proper parameter types.
                for (var i = 0; i < parameters.Count; i++)
                    command.Parameters.Add(new SpannerParameter("p" + i, SpannerDbType.String, parameters[i]));
            }

            return command;
        }

        public override void Dispose()
        {
            _connection.Dispose();

            if (_deleteDatabase)
            {
                DeleteDatabase(Name);
            }
        }

        public static string CreateConnectionString(string name)
        {
            var builder = new SpannerConnectionStringBuilder(TestEnvironment.DefaultConnection);
            if (string.IsNullOrEmpty(name))
            {
                builder.DataSource = $"projects/{builder.Project}/instances/{builder.SpannerInstance}";
            }
            else
            {
                builder.DataSource = $"projects/{builder.Project}/instances/{builder.SpannerInstance}/databases/{name}";
            }
            return builder.ConnectionString;
        }

        private static string CreateAdminConnectionString() => CreateConnectionString(null);
    }
}