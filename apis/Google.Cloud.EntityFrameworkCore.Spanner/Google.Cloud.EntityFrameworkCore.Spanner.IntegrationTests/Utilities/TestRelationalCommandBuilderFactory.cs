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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public class TestRelationalCommandBuilderFactory : IRelationalCommandBuilderFactory
    {
        private readonly IDiagnosticsLogger<DbLoggerCategory.Database.Command> _logger;
        private readonly IRelationalTypeMapper _typeMapper;

        public TestRelationalCommandBuilderFactory(
            IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
            IRelationalTypeMapper typeMapper)
        {
            _logger = logger;
            _typeMapper = typeMapper;
        }

        public virtual IRelationalCommandBuilder Create()
            => new TestRelationalCommandBuilder(_logger, _typeMapper);

        private class TestRelationalCommandBuilder : IRelationalCommandBuilder
        {
            private readonly IDiagnosticsLogger<DbLoggerCategory.Database.Command> _logger;

            public TestRelationalCommandBuilder(
                IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
                IRelationalTypeMapper typeMapper)
            {
                _logger = logger;
                ParameterBuilder = new RelationalParameterBuilder(typeMapper);
            }

            IndentedStringBuilder IInfrastructure<IndentedStringBuilder>.Instance { get; } =
                new IndentedStringBuilder();

            public IRelationalParameterBuilder ParameterBuilder { get; }

            public IRelationalCommand Build()
                => new TestRelationalCommand(
                    _logger,
                    ((IInfrastructure<IndentedStringBuilder>) this).Instance.ToString(),
                    ParameterBuilder.Parameters);
        }

        private class TestRelationalCommand : IRelationalCommand
        {
            private readonly RelationalCommand _realRelationalCommand;

            public TestRelationalCommand(
                IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
                string commandText,
                IReadOnlyList<IRelationalParameter> parameters) => _realRelationalCommand =
                new RelationalCommand(logger, commandText, parameters);

            public string CommandText => _realRelationalCommand.CommandText;

            public IReadOnlyList<IRelationalParameter> Parameters => _realRelationalCommand.Parameters;

            public int ExecuteNonQuery(
                IRelationalConnection connection, IReadOnlyDictionary<string, object> parameterValues)
            {
                var errorNumber = PreExecution(connection);

                var result = _realRelationalCommand.ExecuteNonQuery(connection, parameterValues);
                if (errorNumber != null)
                {
                    connection.DbConnection.Close();
                    throw new Exception($"errorNumber:{errorNumber}");
                }
                return result;
            }

            public Task<int> ExecuteNonQueryAsync(
                IRelationalConnection connection, IReadOnlyDictionary<string, object> parameterValues,
                CancellationToken cancellationToken = new CancellationToken())
            {
                var errorNumber = PreExecution(connection);

                var result =
                    _realRelationalCommand.ExecuteNonQueryAsync(connection, parameterValues, cancellationToken);
                if (errorNumber != null)
                {
                    connection.DbConnection.Close();
                    throw new Exception($"errorNumber:{errorNumber}");
                }
                return result;
            }

            public object ExecuteScalar(
                IRelationalConnection connection, IReadOnlyDictionary<string, object> parameterValues)
            {
                var errorNumber = PreExecution(connection);

                var result = _realRelationalCommand.ExecuteScalar(connection, parameterValues);
                if (errorNumber != null)
                {
                    connection.DbConnection.Close();
                    throw new Exception($"errorNumber:{errorNumber}");
                }
                return result;
            }

            public async Task<object> ExecuteScalarAsync(
                IRelationalConnection connection, IReadOnlyDictionary<string, object> parameterValues,
                CancellationToken cancellationToken = new CancellationToken())
            {
                var errorNumber = PreExecution(connection);

                var result =
                    await _realRelationalCommand.ExecuteScalarAsync(connection, parameterValues, cancellationToken);
                if (errorNumber != null)
                {
                    connection.DbConnection.Close();
                    throw new Exception($"errorNumber:{errorNumber}");
                }
                return result;
            }

            public RelationalDataReader ExecuteReader(
                IRelationalConnection connection, IReadOnlyDictionary<string, object> parameterValues)
            {
                var errorNumber = PreExecution(connection);

                var result = _realRelationalCommand.ExecuteReader(connection, parameterValues);
                if (errorNumber != null)
                {
                    connection.DbConnection.Close();
                    throw new Exception($"errorNumber:{errorNumber}");
                }
                return result;
            }

            public async Task<RelationalDataReader> ExecuteReaderAsync(
                IRelationalConnection connection, IReadOnlyDictionary<string, object> parameterValues,
                CancellationToken cancellationToken = new CancellationToken())
            {
                var errorNumber = PreExecution(connection);

                var result =
                    await _realRelationalCommand.ExecuteReaderAsync(connection, parameterValues, cancellationToken);
                if (errorNumber != null)
                {
                    connection.DbConnection.Close();
                    throw new Exception($"errorNumber:{errorNumber}");
                }
                return result;
            }

            private string PreExecution(IRelationalConnection connection)
            {
                string errorNumber = null;
                var testConnection = (TestSpannerConnection) connection;

                testConnection.ExecutionCount++;
                if (testConnection.ExecutionFailures.Count > 0)
                {
                    var fail = testConnection.ExecutionFailures.Dequeue();
                    if (fail.HasValue)
                    {
                        if (fail.Value)
                        {
                            testConnection.DbConnection.Close();
                            throw new Exception($"errorNumber:{errorNumber}");
                        }
                        errorNumber = testConnection.ErrorCode;
                    }
                }
                return errorNumber;
            }
        }
    }
}