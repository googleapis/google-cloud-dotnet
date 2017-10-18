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
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.EntityFrameworkCore.Spanner.Diagnostics;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Google.Cloud.EntityFrameworkCore.Spanner.Storage.Internal
{
    /// <summary>
    /// </summary>
    public class SpannerRelationalCommandBuilderFactory : RelationalCommandBuilderFactory
    {
        /// <summary>
        /// </summary>
        public SpannerRelationalCommandBuilderFactory(
            IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
            IRelationalTypeMapper typeMapper)
            : base(logger, typeMapper)
        {
        }

        /// <inheritdoc />
        protected override IRelationalCommandBuilder CreateCore(
            IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
            IRelationalTypeMapper relationalTypeMapper)
            => new SpannerRelationalCommandBuilder(logger, relationalTypeMapper);

        private sealed class SpannerRelationalCommandBuilder : RelationalCommandBuilder
        {
            public SpannerRelationalCommandBuilder(
                IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
                IRelationalTypeMapper typeMapper)
                : base(logger, typeMapper)
            {
            }

            protected override IRelationalCommand BuildCore(
                IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
                string commandText,
                IReadOnlyList<IRelationalParameter> parameters)
                => new SpannerRelationalCommand(logger, commandText, parameters);

            private sealed class SpannerRelationalCommand : RelationalCommand
            {
                public SpannerRelationalCommand(
                    IDiagnosticsLogger<DbLoggerCategory.Database.Command> logger,
                    string commandText,
                    IReadOnlyList<IRelationalParameter> parameters)
                    : base(
                        logger,
                        commandText,
                        parameters)
                {
                }

                protected override object Execute(
                    IRelationalConnection connection,
                    DbCommandMethod executeMethod,
                    IReadOnlyDictionary<string, object> parameterValues)
                {
                    GaxPreconditions.CheckNotNull(connection, nameof(connection));

                    var dbCommand = CreateCommand(connection, parameterValues);

                    connection.Open();

                    var commandId = Guid.NewGuid();
                    var startTime = DateTimeOffset.UtcNow;
                    var stopwatch = Stopwatch.StartNew();

                    Logger.CommandExecuting(
                        dbCommand,
                        executeMethod,
                        commandId,
                        connection.ConnectionId,
                        false,
                        startTime);

                    object result;
                    var readerOpen = false;

                    try
                    {
                        //Note that adds/updates/deletes get intercepted at the 
                        //modificationcommandbatch level and normally do not get translated
                        //into ADO.NET commands here.  However, there are features in EF that
                        //allow raw DML to be sent to the database which end up here and we need
                        //to create the proper command and throw a useful exception.
                        //TODO(benwu): there may be a way we can accept a non-DML text version of updates
                        // but we'll need to send it thru detailed design review.
                        switch (executeMethod)
                        {
                            case DbCommandMethod.ExecuteNonQuery:
                            {
                                result = dbCommand.ExecuteNonQuery();

                                break;
                            }
                            case DbCommandMethod.ExecuteScalar:
                            {
                                result = dbCommand.ExecuteScalar();

                                break;
                            }
                            case DbCommandMethod.ExecuteReader:
                            {
                                result
                                    = new RelationalDataReader(
                                        connection,
                                        dbCommand,
                                        dbCommand.ExecuteReader(),
                                        commandId,
                                        Logger);

                                readerOpen = true;

                                break;
                            }
                            default:
                            {
                                throw new NotSupportedException();
                            }
                        }

                        Logger.CommandExecuted(
                            dbCommand,
                            executeMethod,
                            commandId,
                            connection.ConnectionId,
                            result,
                            false,
                            startTime,
                            stopwatch.Elapsed);
                    }
                    catch (Exception exception)
                    {
                        Logger.CommandError(
                            dbCommand,
                            executeMethod,
                            commandId,
                            connection.ConnectionId,
                            exception,
                            false,
                            startTime,
                            stopwatch.Elapsed);

                        throw;
                    }
                    finally
                    {
                        if (!readerOpen)
                        {
                            dbCommand.Dispose();
                            connection.Close();
                        }

                        dbCommand.Parameters.Clear();
                    }

                    return result;
                }

                protected override async Task<object> ExecuteAsync(
                    IRelationalConnection connection,
                    DbCommandMethod executeMethod,
                    IReadOnlyDictionary<string, object> parameterValues,
                    CancellationToken cancellationToken = default(CancellationToken))
                {
                    GaxPreconditions.CheckNotNull(connection, nameof(connection));

                    var dbCommand = CreateCommand(connection, parameterValues);

                    await connection.OpenAsync(cancellationToken).ConfigureAwait(false);

                    var commandId = Guid.NewGuid();

                    var startTime = DateTimeOffset.UtcNow;
                    var stopwatch = Stopwatch.StartNew();

                    Logger.CommandExecuting(
                        dbCommand,
                        executeMethod,
                        commandId,
                        connection.ConnectionId,
                        true,
                        startTime);

                    object result;
                    var readerOpen = false;

                    try
                    {
                        switch (executeMethod)
                        {
                            case DbCommandMethod.ExecuteNonQuery:
                            {
                                result = await dbCommand.ExecuteNonQueryAsync(cancellationToken).ConfigureAwait(false);

                                break;
                            }
                            case DbCommandMethod.ExecuteScalar:
                            {
                                result = await dbCommand.ExecuteScalarAsync(cancellationToken).ConfigureAwait(false);

                                break;
                            }
                            case DbCommandMethod.ExecuteReader:
                            {
                                result = new RelationalDataReader(
                                    connection,
                                    dbCommand,
                                    await dbCommand.ExecuteReaderAsync(cancellationToken).ConfigureAwait(false),
                                    commandId,
                                    Logger);
                                readerOpen = true;

                                break;
                            }
                            default:
                            {
                                throw new NotSupportedException();
                            }
                        }

                        Logger.CommandExecuted(
                            dbCommand,
                            executeMethod,
                            commandId,
                            connection.ConnectionId,
                            result,
                            true,
                            startTime,
                            stopwatch.Elapsed);
                    }
                    catch (Exception exception)
                    {
                        Logger.CommandError(
                            dbCommand,
                            executeMethod,
                            commandId,
                            connection.ConnectionId,
                            exception,
                            true,
                            startTime,
                            stopwatch.Elapsed);

                        throw;
                    }
                    finally
                    {
                        if (!readerOpen)
                        {
                            dbCommand.Dispose();
                            connection.Close();
                        }

                        dbCommand.Parameters.Clear();
                    }

                    return result;
                }

                private DbCommand CreateCommand(
                    IRelationalConnection connection,
                    IReadOnlyDictionary<string, object> parameterValues)
                {
                    if (parameterValues != null)
                    {
                        parameterValues = AdjustParameters(parameterValues);
                    }

                    var command = (SpannerCommand)connection.DbConnection.CreateCommand();
                    command.Logger = new SpannerLogBridge<DbLoggerCategory.Database.Command>(Logger);
                    command.CommandText = CommandText;

                    if (connection.CurrentTransaction != null)
                    {
                        command.Transaction = connection.CurrentTransaction.GetDbTransaction();
                    }

                    if (connection.CommandTimeout != null)
                    {
                        command.CommandTimeout = (int) connection.CommandTimeout;
                    }

                    if (Parameters.Count > 0)
                    {
                        if (parameterValues == null)
                        {
                            throw new InvalidOperationException(
                                RelationalStrings.MissingParameterValue(
                                    Parameters[0].InvariantName));
                        }

                        foreach (var parameter in Parameters)
                            parameter.AddDbParameter(command, parameterValues);
                    }
                    return command;
                }

                private static IReadOnlyDictionary<string, object> AdjustParameters(
                    IReadOnlyDictionary<string, object> parameterValues)
                {
                    if (parameterValues.Count == 0)
                    {
                        return parameterValues;
                    }

                    return parameterValues.ToDictionary(
                        kv => kv.Key,
                        kv =>
                        {
                            var type = kv.Value?.GetType();

                            if (type != null)
                            {
                                type = Nullable.GetUnderlyingType(type) ?? type;

                                if (type == typeof(bool))
                                {
                                    var b = (bool) kv.Value;

                                    return b ? 1 : 0;
                                }

                                if (type == typeof(Guid))
                                {
                                    var g = (Guid) kv.Value;

                                    return g.ToByteArray();
                                }

                                if (type.IsEnum)
                                {
                                    var underlyingType = Enum.GetUnderlyingType(type);

                                    return Convert.ChangeType(kv.Value, underlyingType);
                                }

                                if (type == typeof(DateTimeOffset))
                                {
                                    throw new NotSupportedException("DateTimeOffset is not supported.");
                                }
                                //TODO(benwu): test all types.
                            }

                            return kv.Value;
                        });
                }
            }
        }
    }
}