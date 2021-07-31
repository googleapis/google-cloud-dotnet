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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Builds the <see cref="SpannerCommand.CommandText"/> string for executing a query or operation
    /// on a Spanner database. Instances are constructed with static factory methods.
    /// </summary>
    public sealed class SpannerCommandTextBuilder
    {
        private const string InsertCommand = "INSERT";
        private const string InsertUpdateCommand = "INSERTUPDATE";
        private const string UpdateCommand = "UPDATE";
        private const string DeleteCommand = "DELETE";
        private const string SelectCommand = "SELECT";
        private const string WithCommand = "WITH"; // Queries may also start with a WITH clause.
        private const string AlterCommand = "ALTER";
        private const string CreateCommand = "CREATE";
        private const string DropCommand = "DROP";
        //TODO(benwu): verify if whitespace between CREATE/DROP and DB is allowed.
        private const string CreateDatabaseCommand = "CREATE DATABASE ";
        private const string DropDatabaseCommand = "DROP DATABASE ";
        private static readonly HashSet<string> QueryAndDmlStatements = new HashSet<string>
            { SelectCommand, WithCommand, InsertCommand, UpdateCommand, DeleteCommand };

        private static readonly Dictionary<string, SpannerCommandType> s_commandToCommandType = new Dictionary<string, SpannerCommandType>
        {
            { InsertCommand, SpannerCommandType.Insert },
            { InsertUpdateCommand, SpannerCommandType.InsertOrUpdate },
            { UpdateCommand, SpannerCommandType.Update },
            { DeleteCommand, SpannerCommandType.Delete },
            { SelectCommand, SpannerCommandType.Select },
            { WithCommand, SpannerCommandType.Select },
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
        /// Gets the type of Spanner command (Select, Update, Delete, InsertOrUpdate, Insert, Ddl, Dml).
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
        /// for querying rows via a SQL query.
        /// </summary>
        /// <param name="dmlStatement">The full SQL query. Must not be null or empty.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> representing a <see cref="F:SpannerCommandType.Select"/> Spanner command.</returns>
        public static SpannerCommandTextBuilder CreateDmlTextBuilder(string dmlStatement) =>
            new SpannerCommandTextBuilder(GaxPreconditions.CheckNotNullOrEmpty(dmlStatement, nameof(dmlStatement)), SpannerCommandType.Dml, null, null);

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
        /// The given text will be analyzed to choose the proper <see cref="SpannerCommandType"/>.
        /// </summary>
        /// <remarks>
        /// If the intended <see cref="SpannerCommandType"/> is Select, then <paramref name="commandText"/> should be
        /// a SQL Query. If the intended <see cref="SpannerCommandType"/> is Ddl, then this string should be
        /// the DDL statement (eg 'CREATE TABLE MYTABLE...')
        /// If the intended <see cref="SpannerCommandType"/> is Update, Delete,
        /// InsertOrUpdate, or Insert, then the text should be '[spanner command type] [table name]'
        /// such as 'INSERT MYTABLE'.  Must not be null or empty.
        /// </remarks>
        /// <param name="commandText">The full command text containing a query, DDL statement or insert/update/delete
        /// operation.  The given text will be parsed and validated. Must not be null.</param>
        /// <returns>A <see cref="SpannerCommandTextBuilder"/> whose <see cref="SpannerCommandType"/> is determined
        /// from parsing <paramref name="commandText"/>.</returns>
        /// <exception cref="ArgumentException"><paramref name="commandText"/> is not formatted correctly.</exception>
        public static SpannerCommandTextBuilder FromCommandText(string commandText)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));
            var trimmedCommandText = RemoveCommentsAndStatementHint(commandText).Trim();
            // Split(new char[0]) splits the string using all whitespace characters.
            var commandSections = trimmedCommandText.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
            if (commandSections.Length < 2)
            {
                throw new ArgumentException($"'{commandText}' is not a recognized Spanner command.", nameof(commandText));
            }

            string commandName = commandSections[0].ToUpperInvariant();
            if (!s_commandToCommandType.TryGetValue(commandName, out var commandType))
            {
                throw new ArgumentException($"'{commandName}' is not a recognized Spanner command.", nameof(commandText));
            }

            string targetTable = null;

            // Any extra validation or assignments go here... currently just for the parameter-based DML cases.
            switch (commandType)
            {
                case SpannerCommandType.Insert:
                case SpannerCommandType.InsertOrUpdate:
                case SpannerCommandType.Delete:
                case SpannerCommandType.Update:
                    if (commandSections.Length != 2)
                    {
                        // This is the only DML command that can't be executed as more general DML.
                        if (commandType == SpannerCommandType.InsertOrUpdate)
                        {
                            throw new InvalidOperationException(
                                $"Spanner {commandName} commands are specified as '{commandName} <table>' with " +
                                "parameters added to customize the command with filtering or updated values.");
                        }
                        // We'll assume it's valid DML, at least.
                        commandType = SpannerCommandType.Dml;
                    }
                    else
                    {
                        targetTable = ValidateTableName(commandSections[1], nameof(commandText));
                        // This just normalizes the command text.
                        commandText = $"{commandName} {targetTable}";
                    }
                    break;
            }
            return new SpannerCommandTextBuilder(commandText, commandType, targetTable, extraStatements: null);
        }

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

        private static readonly char s_singleQuote = '\'';
        private static readonly char s_doubleQuote = '"';
        private static readonly char s_backtickQuote = '`';
        private static readonly char s_hyphen = '-';
        private static readonly char s_dash = '#';
        private static readonly char s_slash = '/';
        private static readonly char s_asterisk = '*';

        /// <summary>
        /// Removes any comments from the given sql string.
        /// </summary>
        /// <param name="sql">The sql string to strip for comments</param>
        /// <returns>The sql string without any comments</returns>
        /// <exception cref="SpannerException">
        /// Throws SpannerException if the sql string contains an unclosed
        /// literal or unclosed quoted identifier
        /// </exception>
        internal static string RemoveComments(string sql)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            bool isInQuoted = false;
            bool isInSingleLineComment = false;
            bool isInMultiLineComment = false;
            char startQuote = '\0';
            bool lastCharWasEscapeChar = false;
            bool isTripleQuoted = false;
            StringBuilder res = new StringBuilder(sql.Length);
            int index = 0;
            while (index < sql.Length)
            {
                char c = sql[index];
                if (isInQuoted)
                {
                    if ((c == '\n' || c == '\r') && !isTripleQuoted)
                    {
                        throw new SpannerException(
                            ErrorCode.InvalidArgument,
                            $"SQL statement contains an unclosed literal: {sql}");
                    }
                    else if (c == startQuote)
                    {
                        if (lastCharWasEscapeChar)
                        {
                            lastCharWasEscapeChar = false;
                        }
                        else if (isTripleQuoted)
                        {
                            if (sql.Length > index + 2
                                && sql[index + 1] == startQuote
                                && sql[index + 2] == startQuote)
                            {
                                isInQuoted = false;
                                startQuote = '\0';
                                isTripleQuoted = false;
                                res.Append(c).Append(c);
                                index += 2;
                            }
                        }
                        else
                        {
                            isInQuoted = false;
                            startQuote = '\0';
                        }
                    }
                    else if (c == '\\')
                    {
                        lastCharWasEscapeChar = true;
                    }
                    else
                    {
                        lastCharWasEscapeChar = false;
                    }

                    res.Append(c);
                }
                else
                {
                    // We are not in a quoted string.
                    if (isInSingleLineComment)
                    {
                        if (c == '\n')
                        {
                            isInSingleLineComment = false;
                            // Include the line feed in the result.
                            res.Append(c);
                        }
                    }
                    else if (isInMultiLineComment)
                    {
                        if (sql.Length > index + 1 && c == s_asterisk && sql[index + 1] == s_slash)
                        {
                            isInMultiLineComment = false;
                            index++;
                        }
                    }
                    else
                    {
                        if (c == s_dash
                            || (sql.Length > index + 1 && c == s_hyphen && sql[index + 1] == s_hyphen))
                        {
                            // This is a single line comment.
                            isInSingleLineComment = true;
                        }
                        else if (sql.Length > index + 1 && c == s_slash && sql[index + 1] == s_asterisk)
                        {
                            isInMultiLineComment = true;
                            index++;
                        }
                        else
                        {
                            if (c == s_singleQuote || c == s_doubleQuote || c == s_backtickQuote)
                            {
                                isInQuoted = true;
                                startQuote = c;
                                // Check whether it is a triple-quote.
                                if (sql.Length > index + 2
                                    && sql[index + 1] == startQuote
                                    && sql[index + 2] == startQuote)
                                {
                                    isTripleQuoted = true;
                                    res.Append(c).Append(c);
                                    index += 2;
                                }
                            }
                            res.Append(c);
                        }
                    }
                }
                index++;
            }
            if (isInQuoted)
            {
                throw new SpannerException(
                    ErrorCode.InvalidArgument, $"SQL statement contains an unclosed literal: {sql}");
            }
            if (res.Length > 0 && res[res.Length - 1] == ';')
            {
                res.Remove(res.Length - 1, 1);
            }
            return res.ToString();
        }

        /// <summary>
        /// First removes all comments from the entire sql string, and then removes any statement hints
        /// at the start of the sql statement. The returned statement should only be used to determine the
        /// type of statement. The original statement should always be passed on to Cloud Spanner.
        /// </summary>
        /// <param name="sql">The sql statement to strip for comments and statement hints</param>
        /// <returns>The sql statement without comments and statement hints</returns>
        internal static string RemoveCommentsAndStatementHint(string sql)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            // First remove all comments from the statement.
            sql = RemoveComments(sql);

            // Valid statement hints at the beginning of a query statement can only contain a fixed set of
            // possible values. Although it is possible to add a @{FORCE_INDEX=...} as a statement hint, the
            // only allowed value is _BASE_TABLE. This means that we can safely assume that the statement
            // hint will not contain any special characters, for example a closing curly brace or one of the
            // keywords SELECT, UPDATE, DELETE, WITH, and that we can keep the check simple by just
            // searching for the first occurrence of a keyword that should be preceded by a closing curly
            // brace at the end of the statement hint.
            int startStatementHintIndex = sql.IndexOf('{');
            // Statement hints are allowed for both queries and DML statements.
            int startQueryIndex = -1;
            string upperCaseSql = sql.ToUpperInvariant();
            foreach (string keyword in QueryAndDmlStatements) {
                startQueryIndex = upperCaseSql.IndexOf(keyword);
                if (startQueryIndex > -1) {
                    break;
                }
            }
            if (startQueryIndex > -1) {
                int endStatementHintIndex = sql.Substring(0, startQueryIndex).LastIndexOf('}');
                if (startStatementHintIndex == -1 || startStatementHintIndex > endStatementHintIndex) {
                    // Looks like an invalid statement hint. Just ignore at this point and let the caller handle
                    // the invalid query.
                    return sql;
                }
                return sql.Substring(endStatementHintIndex + 1);
            }
            // Seems invalid, just return the original statement.
            return sql;
        }
    }
}
