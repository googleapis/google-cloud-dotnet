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

        private string _targetTable;

        /// <summary>
        /// Gets the resulting string to be used for <see cref="SpannerCommand.CommandText"/>.
        /// </summary>
        public string CommandText { get; private set; }

        /// <summary>
        /// Gets the type of Spanner command (Select, Update, Delete, InsertOrUpdate, Insert, Ddl).
        /// </summary>
        public SpannerCommandType SpannerCommandType { get; private set; }

        /// <summary>
        /// Gets the target Spanner database table if the command is Update, Delete, InsertOrUpdate,
        /// or Insert
        /// </summary>
        public string TargetTable
        {
            get => _targetTable;
            private set
            {
                ValidateTable(value);
                _targetTable = value;
            }
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
        /// such as 'INSERT MYTABLE'.  Must not be null.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="commandText"/> is null.</exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="commandText"/> is not formatted correctly.</exception>
        public SpannerCommandTextBuilder(string commandText)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));
            var commandSections = commandText.Split(' ');
            if (commandSections.Length < 2)
            {
                throw new InvalidOperationException($"'{commandText}' is not a recognized Spanner command.");
            }

            if (!TryParseCommand(this, DeleteCommand, SpannerCommandType.Delete, commandSections)
                && !TryParseCommand(this, UpdateCommand, SpannerCommandType.Update, commandSections)
                && !TryParseCommand(this, InsertCommand, SpannerCommandType.Insert, commandSections)
                && !TryParseCommand(this, InsertUpdateCommand, SpannerCommandType.InsertOrUpdate, commandSections))
            {
                if (string.Equals(commandSections[0], SelectCommand, StringComparison.OrdinalIgnoreCase))
                {
                    CommandText = commandText;
                    SpannerCommandType = SpannerCommandType.Select;
                }
                else if (IsDdl(commandSections[0]))
                {
                    CommandText = commandText;
                    SpannerCommandType = SpannerCommandType.Ddl;
                }
                else
                {
                    throw new InvalidOperationException($"'{commandText}' is not a recognized Spanner command.");
                }
            }
        }

        private static bool IsDdl(string commandPart)
        {
            // These three form the ddl for spanner.
            // For reference: https://cloud.google.com/spanner/docs/data-definition-language
            return string.Equals(commandPart, CreateCommand, StringComparison.OrdinalIgnoreCase)
                || string.Equals(commandPart, AlterCommand, StringComparison.OrdinalIgnoreCase)
                || string.Equals(commandPart, DropCommand, StringComparison.OrdinalIgnoreCase);
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

        /// <summary>
        /// </summary>
        private SpannerCommandTextBuilder() { }

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for deleting rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be deleted.
        /// Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Delete"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateDeleteTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder
            {
                SpannerCommandType = SpannerCommandType.Delete,
                TargetTable = table,
                CommandText = $"{DeleteCommand} {table}"
            };
        }

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for inserting or updating rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be updated or inserted.
        /// Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.InsertOrUpdate"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateInsertOrUpdateTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder
            {
                SpannerCommandType = SpannerCommandType.InsertOrUpdate,
                TargetTable = table,
                CommandText = $"{InsertUpdateCommand} {table}"
            };
        }

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for inserting rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be inserted. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Insert"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateInsertTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder
            {
                SpannerCommandType = SpannerCommandType.Insert,
                TargetTable = table,
                CommandText = $"{InsertCommand} {table}"
            };
        }

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for querying rows via a SQL query.
        /// </summary>
        /// <param name="sqlQuery">The full SQL query. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Select"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateSelectTextBuilder(string sqlQuery) => new
            SpannerCommandTextBuilder
            {
                SpannerCommandType = SpannerCommandType.Select,
                CommandText = sqlQuery
            };

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for updating rows.
        /// </summary>
        /// <param name="table">The name of the Spanner database table from which rows will be updated. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Update"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateUpdateTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder
            {
                SpannerCommandType = SpannerCommandType.Update,
                TargetTable = table,
                CommandText = $"{UpdateCommand} {table}"
            };
        }

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance that generates <see cref="SpannerCommand.CommandText"/>
        /// for executing a DDL statement.
        /// </summary>
        /// <param name="ddlStatement">The full DDL statement. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Ddl"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateDdlTextBuilder(string ddlStatement)
        {
            return new SpannerCommandTextBuilder
            {
                SpannerCommandType = SpannerCommandType.Ddl,
                CommandText = ddlStatement
            };
        }

        /// <summary>
        /// Creates a <see cref="SpannerCommandTextBuilder"/> instance by parsing existing command text.
        /// </summary>
        /// <param name="commandText">The full command text containing a query, ddl statement or insert/update/delete
        /// operation.  The given text will be parsed and validated. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> whose <see cref="SpannerCommandType"/> is determined
        /// from parsing <paramref name="commandText"/>.</returns>
        public static SpannerCommandTextBuilder FromCommandText(string commandText)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));
            return new SpannerCommandTextBuilder(commandText);
        }

        /// <inheritdoc />
        public override string ToString() => CommandText;

        private static bool TryParseCommand(
            SpannerCommandTextBuilder newbuilder,
            string commandToParseFor,
            SpannerCommandType commandType,
            string[] commandSections)
        {
            string operationName = commandSections[0].ToUpperInvariant();
            if (operationName == commandToParseFor)
            {
                if (commandSections.Length != 2)
                {
                    throw new InvalidOperationException(
                        $"Spanner {commandToParseFor} commands are specified as '{commandToParseFor} <table>' with " +
                        "parameters added to customize the command with filtering or updated values.");
                }

                newbuilder.CommandText = $"{commandToParseFor} {commandSections[1]}";
                newbuilder.SpannerCommandType = commandType;
                newbuilder.TargetTable = commandSections[1];
                return true;
            }
            return false;
        }

        private static void ValidateTable(string databaseTableName)
        {
            GaxPreconditions.CheckNotNullOrEmpty(databaseTableName, nameof(databaseTableName));
            if (!databaseTableName.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                throw new ArgumentException($"{nameof(databaseTableName)} only allows letters, numbers or underscore");
            }
        }
    }
}
