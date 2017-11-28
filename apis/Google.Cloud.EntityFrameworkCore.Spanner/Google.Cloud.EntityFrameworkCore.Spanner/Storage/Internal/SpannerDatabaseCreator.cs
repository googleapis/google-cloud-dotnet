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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Storage.Internal
{
    /// <summary>
    /// </summary>
    public class SpannerDatabaseCreator : RelationalDatabaseCreator
    {
        readonly ISpannerRelationalConnection _connection;
        readonly IRawSqlCommandBuilder _rawSqlCommandBuilder;

        /// <summary>
        /// </summary>
        public SpannerDatabaseCreator(
            RelationalDatabaseCreatorDependencies dependencies,
            ISpannerRelationalConnection connection,
            IRawSqlCommandBuilder rawSqlCommandBuilder)
            : base(dependencies)
        {
            _connection = connection;
            _rawSqlCommandBuilder = rawSqlCommandBuilder;
        }

        /// <summary>
        /// </summary>
        public override void Create()
        {
            using (var masterConnection = _connection.CreateMasterConnection())
            {
                Dependencies.MigrationCommandExecutor
                    .ExecuteNonQuery(CreateCreateOperations(), masterConnection);
            }
        }


        /// <inheritdoc />
        public override async Task CreateAsync(CancellationToken cancellationToken = default)
        {
            using (var masterConnection = _connection.CreateMasterConnection())
            {
                await Dependencies.MigrationCommandExecutor
                    .ExecuteNonQueryAsync(CreateCreateOperations(), masterConnection, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        protected override bool HasTables()
            => (bool)CreateHasTablesCommand().ExecuteScalar(_connection);

        /// <inheritdoc />
        protected override async Task<bool> HasTablesAsync(CancellationToken cancellationToken = default)
            => (bool)await CreateHasTablesCommand()
                    .ExecuteScalarAsync(_connection, cancellationToken: cancellationToken).ConfigureAwait(false);

        IRelationalCommand CreateHasTablesCommand()
            => _rawSqlCommandBuilder
                .Build(@"
                    SELECT CASE WHEN COUNT(*) = 0 THEN FALSE ELSE TRUE END
                    FROM information_schema.tables
                    WHERE table_type = 'BASE TABLE' AND table_schema NOT IN ('pg_catalog', 'information_schema')
                ");

        IReadOnlyList<MigrationCommand> CreateCreateOperations()
            => Dependencies.MigrationsSqlGenerator.Generate(new[]
            {
                new SpannerCreateDatabaseOperation
                {
                    Name = _connection.DbConnection.Database
                }
            });

        /// <inheritdoc />
        public override bool Exists()
        {
            //TODO(benwu)
            return false;
        }

        /// <inheritdoc />
        public override async Task<bool> ExistsAsync(CancellationToken cancellationToken = default)
        {
            //TODO(benwu)
            await Task.Delay(1, cancellationToken).ConfigureAwait(false);
            return false;
        }

        static bool IsDoesNotExist(SpannerException exception) => exception.ErrorCode == ErrorCode.NotFound;

        /// <inheritdoc />
        public override void Delete()
        {
            ClearAllPools();

            using (var masterConnection = _connection.CreateMasterConnection())
            {
                Dependencies.MigrationCommandExecutor
                    .ExecuteNonQuery(CreateDropCommands(), masterConnection);
            }
        }

        /// <inheritdoc />
        public override async Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            ClearAllPools();

            using (var masterConnection = _connection.CreateMasterConnection())
            {
                await Dependencies.MigrationCommandExecutor
                    .ExecuteNonQueryAsync(CreateDropCommands(), masterConnection, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public override void CreateTables()
        {
            var operations = Dependencies.ModelDiffer.GetDifferences(null, Dependencies.Model);
            var commands = Dependencies.MigrationsSqlGenerator.Generate(operations, Dependencies.Model);

            Dependencies.MigrationCommandExecutor.ExecuteNonQuery(commands, _connection);
        }

        /// <inheritdoc />
        public override async Task CreateTablesAsync(CancellationToken cancellationToken = default)
        {
            var operations = Dependencies.ModelDiffer.GetDifferences(null, Dependencies.Model);
            var commands = Dependencies.MigrationsSqlGenerator.Generate(operations, Dependencies.Model);

            await Dependencies.MigrationCommandExecutor.ExecuteNonQueryAsync(commands, _connection,
                cancellationToken).ConfigureAwait(false);
        }

        IReadOnlyList<MigrationCommand> CreateDropCommands()
        {
            var operations = new MigrationOperation[]
            {
                // TODO Check DbConnection.Database always gives us what we want
                // Issue #775
                new SpannerDropDatabaseOperation { Name = _connection.DbConnection.Database }
            };

            return Dependencies.MigrationsSqlGenerator.Generate(operations);
        }

        // Clear connection pools in case there are active connections that are pooled
        private static void ClearAllPools() => SpannerConnection.ClearPooledResourcesAsync().Wait();

    }
}
