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
using Google.Api.Gax;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class SpannerCommandTextBuilder
    {
        private const string InsertCommand = "INSERT";
        private const string InsertUpdateCommand = "INSERTUPDATE";
        private const string UpdateCommand = "UPDATE";
        private const string DeleteCommand = "DELETE";
        private const string SelectCommand = "SELECT";

        private string _targetTable;

        /// <summary>
        /// </summary>
        /// <param name="commandText"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public SpannerCommandTextBuilder(string commandText)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));
            var commandSections = commandText.Split(' ');
            if (commandSections.Length < 2)
                throw new InvalidOperationException($"{commandText} is not a recognized Spanner command.");
            var newBuilder = new SpannerCommandTextBuilder();
            if (!TryParseCommand(this, DeleteCommand, SpannerCommandType.Delete, commandSections)
                && !TryParseCommand(this, UpdateCommand, SpannerCommandType.Update, commandSections)
                && !TryParseCommand(this, InsertCommand, SpannerCommandType.Insert, commandSections)
                && !TryParseCommand(this, InsertUpdateCommand, SpannerCommandType.InsertOrUpdate, commandSections))
            {
                if (!commandSections[0].ToUpper().StartsWith(SelectCommand))
                    throw new InvalidOperationException($"{commandText} is not a recognized Spanner command.");
                newBuilder.CommandText = commandText;
                newBuilder.SpannerCommandType = SpannerCommandType.Select;
            }
        }

        /// <summary>
        /// </summary>
        private SpannerCommandTextBuilder()
        {
        }

        /// <summary>
        /// </summary>
        public string CommandText { get; private set; }

        /// <summary>
        /// </summary>
        public SpannerCommandType SpannerCommandType { get; private set; }

        /// <summary>
        /// </summary>
        public string TargetTable
        {
            get { return _targetTable; }
            private set
            {
                ValidateTable(value);
                _targetTable = value;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateDeleteTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder {
                SpannerCommandType = SpannerCommandType.Delete,
                TargetTable = table,
                CommandText = $"{DeleteCommand} {table}"
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateInsertOrUpdateTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder {
                SpannerCommandType = SpannerCommandType.InsertOrUpdate,
                TargetTable = table,
                CommandText = $"{InsertUpdateCommand} {table}"
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateInsertTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder {
                SpannerCommandType = SpannerCommandType.Insert,
                TargetTable = table,
                CommandText = $"{InsertCommand} {table}"
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateSelectTextBuilder(string sqlQuery)
        {
            return new SpannerCommandTextBuilder {
                SpannerCommandType = SpannerCommandType.Select,
                CommandText = sqlQuery
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder CreateUpdateTextBuilder(string table)
        {
            ValidateTable(table);
            return new SpannerCommandTextBuilder {
                SpannerCommandType = SpannerCommandType.Update,
                TargetTable = table,
                CommandText = $"{UpdateCommand} {table}"
            };
        }

        /// <summary>
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public static SpannerCommandTextBuilder FromCommandText(string commandText)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));
            return new SpannerCommandTextBuilder(commandText);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return CommandText;
        }

        private static bool TryParseCommand(SpannerCommandTextBuilder newbuilder,
            string commandToParseFor, SpannerCommandType commandType,
            string[] commandSections)
        {
            var operationName = commandSections[0].ToUpperInvariant();
            if (operationName == commandToParseFor)
            {
                if (commandSections.Length != 2)
                    throw new InvalidOperationException(
                        $"Spanner {commandToParseFor} commands are specified as '{commandToParseFor} <table>' with " +
                        "parameters added to customize the command with filtering or updated values.");
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
                throw new ArgumentException($"{nameof(databaseTableName)} only allows letters, numbers or underscore");
        }
    }
}