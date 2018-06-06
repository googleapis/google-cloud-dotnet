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
using System.Text;
using Google.Api.Gax;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Builds the <see cref="SpannerCommand.CommandText"/> string for executing a query or operation
    /// on a Spanner database.
    /// </summary>
    public sealed class SpannerCommandTextBuilder
    {
        private const string InsertCommand = "INSERT";
        private const string InsertUpdateCommand = "INSERTUPDATE";
        private const string UpdateCommand = "UPDATE";
        private const string DeleteCommand = "DELETE";
        private const string SelectCommand = "SELECT";
        private const string AlterCommand = "ALTER";
        private const string CreateCommand = "CREATE";
        private const string DropCommand = "DROP";
        //TODO(benwu): verify if whitespace between CREATE/DROP and DB is allowed.
        private const string CreateDatabaseCommand = "CREATE DATABASE ";
        private const string DropDatabaseCommand = "DROP DATABASE ";

        private static readonly Dictionary<string, SpannerCommandType> s_commandToCommandType = new Dictionary<string, SpannerCommandType>
        {
            { InsertCommand, SpannerCommandType.Insert },
            { InsertUpdateCommand, SpannerCommandType.InsertOrUpdate },
            { UpdateCommand, SpannerCommandType.Update },
            { DeleteCommand, SpannerCommandType.Delete },
            { SelectCommand, SpannerCommandType.Select },
            // These three form the ddl for spanner.
            // For reference: https://cloud.google.com/spanner/docs/data-definition-language
            { AlterCommand, SpannerCommandType.Ddl },
            { CreateCommand, SpannerCommandType.Ddl },
            { DropCommand, SpannerCommandType.Ddl },
        };

        /// <summary>
        /// Gets the resulting string to be used for <see cref="SpannerCommand.CommandText"/>.
        /// </summary>
        public string CommandText { get; }

        /// <summary>
        /// Gets the type of Spanner command (Select, Update, Delete, InsertOrUpdate, Insert, Ddl).
        /// </summary>
        public SpannerCommandType SpannerCommandType { get; }

        /// <summary>
        /// Returns the target Spanner database table if the command is Update, Delete, InsertOrUpdate,
        /// or Insert, or null otherwise.
        /// </summary>
        public string TargetTable { get; }

        /// <summary>
        /// A set of additional statements to execute if supported by the command.
        /// </summary>
        public IReadOnlyList<string> ExtraStatements { get; }

        /// <summary>
        /// Constructs an instance without performing any validation. (Callers must validate.)
        /// </summary>
        private SpannerCommandTextBuilder(string commandText, SpannerCommandType type, string targetTable, string[] extraStatements)
        {
            CommandText = commandText;
            SpannerCommandType = type;
            TargetTable = targetTable;
            ExtraStatements = extraStatements?.ToList().AsReadOnly();
        }

        /// <summary>
        /// Initializes a new SpannerCommandTextBuilder with the given command text.
        /// The given text will be analyzed to choose the proper <see cref="SpannerCommandType"/>.
        /// </summary>
        /// <param name="commandText">The command text intended for <see cref="SpannerCommand.CommandText"/>
        /// If the intended <see cref="SpannerCommandType"/> is Select, then this string should be
        /// a SQL Query. If the intended <see cref="SpannerCommandType"/> is Ddl, then this string should be
        /// the Ddl statement (eg 'CREATE TABLE MYTABLE...')
        /// If the intended <see cref="SpannerCommandType"/> is Update, Delete,
        /// InsertOrUpdate, or Insert, then the text should be '[spannercommandtype] [tablename]'
        /// such as 'INSERT MYTABLE'.  Must not be null or empty.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="commandText"/> is null.</exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="commandText"/> is not formatted correctly.</exception>
        public SpannerCommandTextBuilder(string commandText)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));
            commandText = commandText.Trim();
            var commandSections = commandText.Split(' ');
            if (commandSections.Length < 2)
            {
                throw new ArgumentException($"'{commandText}' is not a recognized Spanner command.", nameof(commandText));
            }

            string commandName = commandSections[0].ToUpperInvariant();
            if (!s_commandToCommandType.TryGetValue(commandName, out var commandType))
            {
                throw new ArgumentException($"'{commandName}' is not a recognized Spanner command.", nameof(commandText));
            }
            SpannerCommandType = commandType;
            CommandText = commandText;

            // Any extra validation or assignments go here... currently just for the parameter-based DML cases.
            switch (commandType)
            {
                case SpannerCommandType.Insert:
                case SpannerCommandType.InsertOrUpdate:
                case SpannerCommandType.Delete:
                case SpannerCommandType.Update:
                    if (commandSections.Length != 2)
                    {
                        throw new InvalidOperationException(
                            $"Spanner {commandName} commands are specified as '{commandName} <table>' with " +
                            "parameters added to customize the command with filtering or updated values.");
                    }
                    TargetTable = ValidateTableName(commandSections[1], nameof(commandText));
                    // This just makes sure the command starts with the upper-case version.
                    CommandText = $"{commandName} {TargetTable}";
                    break;
            }            
        }        

        internal bool IsCreateDatabaseCommand => CommandText?.StartsWith(CreateDatabaseCommand, StringComparison.OrdinalIgnoreCase) ?? false;

        internal bool IsDropDatabaseCommand => CommandText?.StartsWith(DropDatabaseCommand, StringComparison.OrdinalIgnoreCase) ?? false;

        internal string DatabaseToDrop
        {
            get
            {
                if (!IsDropDatabaseCommand)
                {
                    return "";
                }
                string commandText = CommandText;
                var dbName = new StringBuilder();
                int i = DropDatabaseCommand.Length;
                for (; i < commandText.Length; i++)
                {
                    if (char.IsWhiteSpace(commandText[i]) || commandText[i] == ';')
                    {
                        // if we see a whitespace after the dbname, we'll just bail.
                        if (dbName.Length > 0)
                        {
                            break;
                        }
                        // keep looking for the start of the db name.
                        continue;
                    }
                    dbName.Append(commandText[i]);
                }
                //ensure the rest of the string is whitespace
                while (i < commandText.Length)
                {
                    if (!char.IsWhiteSpace(commandText[i]) && commandText[i] != ';')
                    {
                        throw new InvalidOperationException($"Could not parse the database to drop in `{CommandText}`.");
                    }
                    i++;
                }
                return dbName.ToString();
            }
        }

        private static SpannerCommandTextBuilder CreateBuilderForTableDml(string command, SpannerCommandType type, string table) =>
            new SpannerCommandTextBuilder($"{command} {table}", type, ValidateTableName(table, nameof(table)), null);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for deleting rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be deleted.
        /// Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Delete"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateDeleteTextBuilder(string table) =>
            CreateBuilderForTableDml(DeleteCommand, SpannerCommandType.Delete, table);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for inserting or updating rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be updated or inserted.
        /// Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.InsertOrUpdate"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateInsertOrUpdateTextBuilder(string table) =>
            CreateBuilderForTableDml(InsertUpdateCommand, SpannerCommandType.InsertOrUpdate, table);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for inserting rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be inserted. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Insert"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateInsertTextBuilder(string table) =>
            CreateBuilderForTableDml(InsertCommand, SpannerCommandType.Insert, table);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for querying rows via a SQL query.
        /// </summary>
        /// <param name="sqlQuery">The full SQL query. Must not be null or empty.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Select"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateSelectTextBuilder(string sqlQuery) =>
            new SpannerCommandTextBuilder(GaxPreconditions.CheckNotNullOrEmpty(sqlQuery, nameof(sqlQuery)), SpannerCommandType.Select, null, null);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for updating rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be updated. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Update"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateUpdateTextBuilder(string table) =>
            CreateBuilderForTableDml(UpdateCommand, SpannerCommandType.Update, table);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for executing a DDL statement.
        /// </summary>
        /// <param name="ddlStatement">The full DDL statement. Must not be null.</param>
        /// <param name="extraDdlStatements">An optional set of additional DDL statements to execute after
        /// the first statement.  Extra Ddl statements cannot be used to create additional databases.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Ddl"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateDdlTextBuilder(string ddlStatement, params string[] extraDdlStatements) =>
            new SpannerCommandTextBuilder(GaxPreconditions.CheckNotNullOrEmpty(ddlStatement, nameof(ddlStatement)), SpannerCommandType.Ddl, null, extraDdlStatements);

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance by parsing existing command text.
        /// </summary>
        /// <param name="commandText">The full command text containing a query, ddl statement or insert/update/delete
        /// operation.  The given text will be parsed and validated. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> whose <see cref="SpannerCommandType"/> is determined
        /// from parsing <paramref name="commandText"/>.</returns>
        public static SpannerCommandTextBuilder FromCommandText(string commandText) =>
            new SpannerCommandTextBuilder(GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText)));

        /// <inheritdoc />
        public override string ToString() => CommandText;

        private static string ValidateTableName(string table, string parameterName)
        {
            GaxPreconditions.CheckNotNullOrEmpty(table, parameterName);
            if (!table.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                throw new ArgumentException($"Table names must consist of letters, numbers or underscores", parameterName);
            }
            return table;
        }
    }
}
