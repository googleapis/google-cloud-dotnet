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

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

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
                    FROM information_schema.tables AS t
                    WHERE t.table_catalog = '' and t.table_schema = ''
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
            return ExistsAsync().ResultWithUnwrappedExceptions();
        }

        /// <inheritdoc />
        public override async Task<bool> ExistsAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _rawSqlCommandBuilder
                    .Build(@"SELECT COUNT(*) FROM information_schema.tables").ExecuteReaderAsync(_connection)
                    .ConfigureAwait(false);
            }
            catch (SpannerException e) when (e.ErrorCode == ErrorCode.NotFound ||
                                             e.ErrorCode == ErrorCode.InvalidArgument)
            {
                return false;
            }
            return true;
        }

        /// <inheritdoc />
        public override void Delete()
        {
            using (var masterConnection = _connection.CreateMasterConnection())
            {
                Dependencies.MigrationCommandExecutor
                    .ExecuteNonQuery(CreateDropCommands(), masterConnection);
            }
        }

        /// <inheritdoc />
        public override async Task DeleteAsync(CancellationToken cancellationToken = default)
        {
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

        private IReadOnlyList<MigrationCommand> CreateDropCommands()
        {
            var operations = new MigrationOperation[]
            {
                new SpannerDropDatabaseOperation { Name = _connection.DbConnection.Database }
            };

            return Dependencies.MigrationsSqlGenerator.Generate(operations);
        }
    }
}
