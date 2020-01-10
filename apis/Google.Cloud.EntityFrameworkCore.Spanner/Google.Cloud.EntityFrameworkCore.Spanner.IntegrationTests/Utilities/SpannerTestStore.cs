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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.Data;
using Google.Cloud.ClientTesting;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public class SpannerTestStore : RelationalTestStore
    {
        private const string Northwind = "northwind";

        public const int CommandTimeout = 90;
        private const int SkipToLine = 0;

        public static readonly string NorthwindConnectionString = CreateConnectionString(Northwind);

        private static readonly Dictionary<string, List<Tuple<string, SpannerDbType>>> s_columnMap
            = new Dictionary<string, List<Tuple<string, SpannerDbType>>>();

        private static int s_gStatements;
        private readonly bool _cleanDatabase;
        private SpannerConnection _connection;

        private string _connectionString;
        private bool _deleteDatabase;

        private SpannerTestStore(string name, bool cleanDatabase = true)
        {
            name = name.ToLowerInvariant();
            if (name.Length > 30)
            {
                name = name.Substring(0, 30);
            }
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
            bool cleanDatabase = false)
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
                name = IdGenerator.FromGuid(prefix: "s", separator: "");
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

                    DeleteDatabase(Name);
                }
                ExecuteNonQuery(master, GetCreateDatabaseStatement(Name));
            }

            return true;
        }

        public static void ExecuteScript(string databaseName, string scriptPath)
        {
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
                        s_gStatements++;
                        if (string.IsNullOrWhiteSpace(statement)
                            || statement.StartsWith("SET ", StringComparison.Ordinal))
                        {
                            continue;
                        }

                        var tokens = statement.Split(' ', '(', ')', ',', ';').Where(
                            x => !string.IsNullOrEmpty(x?.Trim())).ToList();
                        if (tokens.Count == 0)
                        {
                            continue;
                        }

                        if (tokens[0] == "CREATE")
                        {
                            if (tokens[1] == "TABLE")
                            {
                                var tableName = tokens[2];
                                var columnData = new List<Tuple<string, SpannerDbType>>();
                                var i = 3;
                                while (tokens[i] != "PRIMARY")
                                {
                                    SpannerDbType type;
                                    if (!SpannerDbType.TryParse(tokens[i + 1], out type))
                                    {
                                        throw new InvalidOperationException($"Unable to parse {tokens[i + 1]}");
                                    }
                                    columnData.Add(new Tuple<string, SpannerDbType>(tokens[i], type));
                                    i += 2;
                                    if (tokens[i] == "MAX" || tokens[i][0] >= '0' && tokens[i][0] <= '9')
                                    {
                                        i++;
                                    }
                                    if (tokens[i] == "NOT")
                                    {
                                        i += 2;
                                    }
                                }
                                s_columnMap[tableName] = columnData;
                            }
                            command.CommandText = statement;
                        }
                        else if (tokens[0] == "INSERT")
                        {
//                            if (s_gStatements >= s_skipToLine)
//                            {
//                                Console.WriteLine("break here");
//                            }

                            // we do some simple parsing of a DML insert to a write command.
                            if (tokens.Count < 5 || tokens[0] != "INSERT" || tokens[1] != "INTO")
                            {
                                continue;
                            }

                            var m = Regex.Match(statement,
                                @"INSERT INTO ([^\r\n\t\f\v(]+)\s?(\(.*\))?.*VALUES.(\(.*\))", RegexOptions.Singleline);
                            var targetTable = m.Groups[1].Value.Trim();
                            var columnGroup = m.Groups[2].Value;
                            var valueGroup = m.Groups[3].Value;

                            //get columns to set.
                            IEnumerable<Tuple<string, SpannerDbType>> targetColumns;
                            if (string.IsNullOrEmpty(columnGroup))
                            {
                                //use the lookup table.
                                targetColumns = s_columnMap[targetTable];
                            }
                            else
                            {
                                var trimmedCols = columnGroup.Remove(columnGroup.Length - 1, 1).Remove(0, 1);
                                targetColumns = trimmedCols.Split(',')
                                    .Select(x => s_columnMap[targetTable].First(y => y.Item1 == x.Trim()));
                            }

                            //value parsing is a bit complicated and we do a simpler (hackish) heuristic which
                            //isnt completely valid for all cases, but works for our inputs.
                            valueGroup = valueGroup.Remove(valueGroup.Length - 1, 1).Remove(0, 1);
                            var valueTokens = valueGroup.Split(',').ToList();
                            var values = new List<string>();
                            StringBuilder sb = null;
                            for (var i = 0; i < valueTokens.Count; i++)
                            {
                                var valueToken = valueTokens[i].Replace("''", "'");
                                if (sb != null)
                                {
                                    sb.Append(',');
                                    sb.Append(valueToken);
                                    if (sb[sb.Length - 1] == '\'')
                                    {
                                        values.Add(sb.ToString().Substring(0, sb.Length - 1));
                                        sb = null;
                                    }
                                    continue;
                                }
                                valueToken = valueToken.TrimStart();
                                if (valueToken.StartsWith("TO_DATE"))
                                {
                                    var dateQuoteInd = valueToken.IndexOf('\'');
                                    var endDateQuote = valueToken.IndexOf('\'', dateQuoteInd + 1);

                                    values.Add(valueToken.Substring(dateQuoteInd + 1, endDateQuote - dateQuoteInd - 1));
                                    i++;
                                }
                                else if (valueToken.StartsWith("'") || valueToken.StartsWith("N'"))
                                {
                                    valueToken = valueToken.StartsWith("'")
                                        ? valueToken.Substring(1, valueToken.Length - 1)
                                        : valueToken.Substring(2, valueToken.Length - 2);
                                    if (valueToken.EndsWith("'"))
                                    {
                                        values.Add(valueToken.Substring(0, valueToken.Length - 1));
                                    }
                                    else
                                    {
                                        sb = new StringBuilder(valueToken);
                                    }
                                }
                                else
                                {
                                    values.Add(string.Equals(valueToken, "NULL",
                                        StringComparison.InvariantCultureIgnoreCase)
                                        ? null
                                        : valueToken);
                                }
                            }

                            command.CommandText = $"INSERT {targetTable}";
                            command.Parameters.Clear();
                            command.Parameters.AddRange(targetColumns.Select(x =>
                                new SpannerParameter(x.Item1, x.Item2)).ToArray());

                            if (values.Count != command.Parameters.Count)
                            {
                                throw new InvalidOperationException("error parsing input northwind.sql");
                            }
                            for (var j = 0; j < command.Parameters.Count; j++)
                                if (Equals(((SpannerParameter) command.Parameters[j]).SpannerDbType, SpannerDbType.Bool)
                                    && (values[j].Contains("0") || values[j].Contains("1")))
                                {
                                    command.Parameters[j].Value = Convert.ToInt32(values[j]);
                                }
                                else
                                {
                                    command.Parameters[j].Value = values[j];
                                }
                        }
                        if (s_gStatements < SkipToLine)
                        {
                            continue;
                        }
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

        private static string GetCreateDatabaseStatement(string name)
            => $@"CREATE DATABASE {name}";

        private static bool DatabaseExists(string name)
        {
            using (var targetDb = new SpannerConnection(CreateConnectionString(name)))
            {
                try
                {
                    var reader = targetDb.CreateSelectCommand("SELECT COUNT(*) FROM information_schema.tables")
                        .ExecuteReader();
                    reader.Dispose();
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.NotFound ||
                                                 e.ErrorCode == ErrorCode.InvalidArgument)
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
            }
        }

        private static string GetDropDatabaseSql(string name) => $@"DROP DATABASE {name}";

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
            => ExecuteAsync(connection, async command => (T) await command.ExecuteScalarAsync().ConfigureAwait(false),
                sql, false,
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
                using (var dataReader = await command.ExecuteReaderAsync().ConfigureAwait(false))
                {
                    var results = Enumerable.Empty<T>();
                    while (await dataReader.ReadAsync().ConfigureAwait(false))
                        results = results.Concat(
                            new[] {await dataReader.GetFieldValueAsync<T>(0).ConfigureAwait(false)});
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
                //To debug the parse error, set SkipToLine= this value.
                Trace.WriteLine($"Error encountered at statement {s_gStatements}");
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
            await connection.OpenAsync().ConfigureAwait(false);
            try
            {
                using (var transaction = useTransaction ? connection.BeginTransaction() : null)
                {
                    T result;
                    using (var command = CreateCommand(connection, sql, parameters))
                    {
                        result = await executeAsync(command).ConfigureAwait(false);
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