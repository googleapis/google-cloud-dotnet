// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    public sealed partial class SpannerCommand
    {
        /// <summary>
        /// Class that effectively contains a copy of the parameters of a SpannerCommand, but in a shallow-immutable way.
        /// This means we can validate various things and not worry about them changing. The parameter collection may be modified
        /// externally, along with the SpannerConnection, but other objects should be fine.
        ///
        /// This class is an implementation detail, used to keep "code required to execute Spanner commands" separate from the ADO
        /// API surface with its mutable properties and many overloads.
        /// </summary>
        private class ExecutableCommand
        {
            private const string SpannerOptimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            private const string SpannerOptimizerStatisticsPackageVariable = "SPANNER_OPTIMIZER_STATISTICS_PACKAGE";

            internal SpannerConnection Connection { get; }
            internal SpannerCommandTextBuilder CommandTextBuilder { get; }
            internal int CommandTimeout { get; }
            internal SpannerTransaction Transaction { get; }
            internal SpannerTransactionCreationOptions EphemeralTransactionCreationOptions { get; }
            internal SpannerTransactionOptions EphemeralTransactionOptions { get; }
            internal CommandPartition Partition { get; }
            internal SpannerParameterCollection Parameters { get; }
            internal KeySet KeySet { get; }
            internal QueryOptions QueryOptions { get; }
            internal Priority Priority { get; }
            internal string Tag { get; }
            internal DirectedReadOptions DirectedReadOptions { get; }
            internal SpannerConversionOptions ConversionOptions => SpannerConversionOptions.ForConnection(Connection);

            public ExecutableCommand(SpannerCommand command)
            {
                GaxPreconditions.CheckState(!(command.KeySet != null && command.Parameters.Count > 0), "Command may not contain both a KeySet and Parameters");
                Connection = command.SpannerConnection;
                CommandTextBuilder = command.SpannerCommandTextBuilder;
                CommandTimeout = command.CommandTimeout;
                Partition = command.Partition;
                Parameters = command.Parameters;
                KeySet = command.KeySet;
                Transaction = command._transaction;
                QueryOptions = command.QueryOptions;
                Priority = command.Priority;
                Tag = command.Tag;
                DirectedReadOptions = command.DirectedReadOptions;
                EphemeralTransactionCreationOptions = command.EphemeralTransactionCreationOptions;
                EphemeralTransactionOptions = new SpannerTransactionOptions(command.EphemeralTransactionOptions);
                EphemeralTransactionOptions.CommitPriority ??= Priority;
            }

            // ExecuteScalar is simply implemented in terms of ExecuteReader.
            internal async Task<T> ExecuteScalarAsync<T>(CancellationToken cancellationToken)
            {
                // Duplication of later checks, but this means we can report the right method name.
                ValidateConnectionAndCommandTextBuilder();
                if (CommandTextBuilder.SpannerCommandType != SpannerCommandType.Select && CommandTextBuilder.SpannerCommandType != SpannerCommandType.Read)
                {
                    throw new InvalidOperationException("ExecuteScalar functionality is only available for queries and reads.");
                }

                using (var reader = await ExecuteReaderAsync(CommandBehavior.SingleRow, cancellationToken).ConfigureAwait(false))
                {
                    bool readValue = await reader.ReadAsync(cancellationToken).ConfigureAwait(false) && reader.FieldCount > 0;
                    return readValue ? reader.GetFieldValue<T>(0) : default;
                }
            }

            // Convenience method for upcasting the from SpannerDataReader to DbDataReader.
            internal async Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken) =>
                await ExecuteReaderAsync(behavior, cancellationToken).ConfigureAwait(false);

            internal async Task<SpannerDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
            {
                ValidateConnectionAndCommandTextBuilder();

                if (CommandTextBuilder.SpannerCommandType == SpannerCommandType.Dml)
                {
                    return await ExecuteDmlReaderAsync(behavior, cancellationToken).ConfigureAwait(false);
                }

                ValidateCommandBehavior(behavior);

                if (CommandTextBuilder.SpannerCommandType != SpannerCommandType.Select && CommandTextBuilder.SpannerCommandType != SpannerCommandType.Read)
                {
                    throw new InvalidOperationException("ExecuteReader functionality is only available for queries, reads and DML commands.");
                }

                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);

                ISpannerTransaction effectiveTransaction = Transaction
                    ?? Connection.AmbientTransaction
                    ?? new EphemeralTransaction(Connection, EphemeralTransactionCreationOptions, EphemeralTransactionOptions);

                var resultSet = await ExecuteReadOrQueryRequestAsync(effectiveTransaction, cancellationToken).ConfigureAwait(false);

                var enableGetSchemaTable = Connection.Builder.EnableGetSchemaTable;
                // When the data reader is closed, we may need to dispose of the connection.
                IDisposable resourceToClose = (behavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection ? Connection : null;

                return new SpannerDataReader(Connection.Logger, resultSet, Transaction?.ReadTimestamp, resourceToClose, ConversionOptions, enableGetSchemaTable, CommandTimeout);
            }

            private Task<ReliableStreamReader> ExecuteReadOrQueryRequestAsync(ISpannerTransaction effectiveTransaction, CancellationToken cancellationToken)
            {
                var request = GetReadOrQueryRequest();

                if (request.IsQuery)
                {
                    Connection.Logger.SensitiveInfo(() => $"SpannerCommand.ExecuteReader.Query={request.ExecuteSqlRequest.Sql}");
                }

                return effectiveTransaction.ExecuteReadOrQueryAsync(request, cancellationToken);
            }

            internal async Task<IReadOnlyList<CommandPartition>> GetReaderPartitionsAsync(PartitionOptions options, CancellationToken cancellationToken)
            {
                ValidateConnectionAndCommandTextBuilder();

                GaxPreconditions.CheckState(Transaction?.Mode == TransactionMode.ReadOnly && Transaction?.IsDetached == true,
                    "GetReaderPartitions can only be executed within an explicitly created detached read-only transaction.");

                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);
                var readOrQueryRequest = GetReadOrQueryRequest();
                readOrQueryRequest.DataBoostEnabled = options.DataBoostEnabled;
                var tokens = await Transaction.GetPartitionTokensAsync(
                        readOrQueryRequest, options.PartitionSizeBytes, options.MaxPartitions, cancellationToken, CommandTimeout)
                    .ConfigureAwait(false);
                return tokens.Select(
                    x =>
                    {
                        var request = readOrQueryRequest.CloneRequest();
                        request.PartitionToken = x;
                        return new CommandPartition(request);
                    }).ToList();
            }

            internal Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
            {
                ValidateConnectionAndCommandTextBuilder();

                switch (CommandTextBuilder.SpannerCommandType)
                {
                    case SpannerCommandType.Ddl:
                        return ExecuteDdlAsync(cancellationToken);
                    case SpannerCommandType.Delete:
                    case SpannerCommandType.Insert:
                    case SpannerCommandType.InsertOrUpdate:
                    case SpannerCommandType.Update:
                        return ExecuteMutationsAsync(cancellationToken);
                    case SpannerCommandType.Dml:
                        return ExecuteDmlAsync(cancellationToken);
                    default:
                        throw new InvalidOperationException("ExecuteNonQuery functionality is only available for DML and DDL commands");
                }
            }

            internal async Task<long> ExecutePartitionedUpdateAsync(CancellationToken cancellationToken)
            {
                ValidateConnectionAndCommandTextBuilder();
                GaxPreconditions.CheckState(CommandTextBuilder.SpannerCommandType == SpannerCommandType.Dml, "Only general DML commands can be executed in as partitioned updates");

                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);

                // Opening the connection may enlist it in a scoped transaction, so we need to check for ambient transactions after opening the connection.
                GaxPreconditions.CheckState(Transaction is null && Connection.AmbientTransaction is null, "Partitioned updates cannot be executed within another transaction");

                ExecuteSqlRequest request = GetExecuteSqlRequest();

                var transaction = new EphemeralTransaction(Connection, EphemeralTransactionCreationOptions, EphemeralTransactionOptions);
                // Note: no commit here. PDML transactions are implicitly committed as they go along.
                return await transaction.ExecutePartitionedDmlAsync(request, cancellationToken, CommandTimeout).ConfigureAwait(false);
            }

            private void ValidateConnectionAndCommandTextBuilder()
            {
                GaxPreconditions.CheckState(Connection != null, "SpannerCommand can only be executed when a connection is assigned.");
                GaxPreconditions.CheckState(CommandTextBuilder != null, "SpannerCommand can only be executed when command text is assigned.");
            }

            private async Task<int> ExecuteDmlAsync(CancellationToken cancellationToken)
            {
                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);
                var transaction = Transaction ?? Connection.AmbientTransaction ?? new EphemeralTransaction(Connection, EphemeralTransactionCreationOptions, EphemeralTransactionOptions);
                ExecuteSqlRequest request = GetExecuteSqlRequest();
                long count = await transaction.ExecuteDmlAsync(request, cancellationToken, CommandTimeout).ConfigureAwait(false);
                // This cannot currently exceed int.MaxValue due to Spanner commit limitations anyway.
                return checked((int) count);
            }

            private async Task<SpannerDataReader> ExecuteDmlReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
            {
                ValidateCommandBehavior(behavior);

                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);
                var transaction = Transaction ?? Connection.AmbientTransaction ?? new EphemeralTransaction(Connection, EphemeralTransactionCreationOptions, EphemeralTransactionOptions);
                ExecuteSqlRequest request = GetExecuteSqlRequest();
                var resultSet = await transaction.ExecuteDmlReaderAsync(request, cancellationToken, CommandTimeout).ConfigureAwait(false);

                var enableGetSchemaTable = Connection.Builder.EnableGetSchemaTable;
                // When the data reader is closed, we may need to dispose of the connection.
                IDisposable resourceToClose = (behavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection ? Connection : null;

                return new SpannerDataReader(Connection.Logger, resultSet, Transaction?.ReadTimestamp, resourceToClose, ConversionOptions, enableGetSchemaTable, CommandTimeout);
            }

            private async Task<int> ExecuteDdlAsync(CancellationToken cancellationToken)
            {
                string commandText = CommandTextBuilder.CommandText;
                var builder = Connection.Builder;
                var connectionOptions = new SpannerClientCreationOptions(builder);

                // Create the builder separately from actually building, so we can note the channel that it created.
                // (This is fairly unpleasant, but we'll try to improve this in the next version of GAX.)
                var databaseAdminClientBuilder = connectionOptions.CreateDatabaseAdminClientBuilder();
                var databaseAdminClient = await databaseAdminClientBuilder.BuildAsync(cancellationToken).ConfigureAwait(false);
                var channel = databaseAdminClientBuilder.LastCreatedChannel;
                try
                {
                    if (CommandTextBuilder.IsCreateDatabaseCommand)
                    {
                        var parent = new InstanceName(Connection.Project, Connection.SpannerInstance);
                        var request = new CreateDatabaseRequest
                        {
                            ParentAsInstanceName = parent,
                            CreateStatement = CommandTextBuilder.CommandText,
                            ExtraStatements = { CommandTextBuilder.ExtraStatements ?? new string[0] },
                            ProtoDescriptors = CommandTextBuilder.ProtobufDescriptors?.ToByteString() ?? ByteString.Empty,
                        };
                        var response = await databaseAdminClient.CreateDatabaseAsync(request).ConfigureAwait(false);
                        response = await response.PollUntilCompletedAsync().ConfigureAwait(false);
                        if (response.IsFaulted)
                        {
                            throw SpannerException.FromOperationFailedException(response.Exception);
                        }
                    }
                    else if (CommandTextBuilder.IsDropDatabaseCommand)
                    {
                        if (CommandTextBuilder.ExtraStatements?.Count > 0)
                        {
                            throw new InvalidOperationException(
                                "Drop database commands do not support additional ddl statements");
                        }
                        if (CommandTextBuilder.ProtobufDescriptors is not null)
                        {
                            throw new InvalidOperationException(
                                "Drop database commands do not support protobuf descriptors");
                        }
                        var dbName = new DatabaseName(Connection.Project, Connection.SpannerInstance, CommandTextBuilder.DatabaseToDrop);
                        await databaseAdminClient.DropDatabaseAsync(dbName, cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        if (builder.DatabaseName == null)
                        {
                            throw new InvalidOperationException(
                                "DDL commands other than CREATE/DROP DATABASE require a database in the data source");
                        }

                        var request = new UpdateDatabaseDdlRequest
                        {
                            DatabaseAsDatabaseName = builder.DatabaseName,
                            Statements = { commandText, CommandTextBuilder.ExtraStatements ?? Enumerable.Empty<string>() },
                            ProtoDescriptors = CommandTextBuilder.ProtobufDescriptors?.ToByteString() ?? ByteString.Empty,
                        };

                        var response = await databaseAdminClient.UpdateDatabaseDdlAsync(request).ConfigureAwait(false);
                        response = await response.PollUntilCompletedAsync().ConfigureAwait(false);
                        if (response.IsFaulted)
                        {
                            throw SpannerException.FromOperationFailedException(response.Exception);
                        }
                    }
                }
                catch (RpcException gRpcException)
                {
                    //we translate rpc errors into a spanner exception
                    throw new SpannerException(gRpcException);
                }
                finally
                {
                    channel?.Shutdown();
                }

                return 0;
            }

            private async Task<int> ExecuteMutationsAsync(CancellationToken cancellationToken)
            {
                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);
                var mutations = GetMutations();
                var transaction = Transaction ?? Connection.AmbientTransaction ?? new EphemeralTransaction(Connection, EphemeralTransactionCreationOptions, EphemeralTransactionOptions);
                // Make the request. This will commit immediately or not depending on whether a transaction was explicitly created.
                await transaction.ExecuteMutationsAsync(mutations, cancellationToken, CommandTimeout).ConfigureAwait(false);
                // Return the number of records affected.
                return mutations.Count;
            }

            private List<Mutation> GetMutations()
            {
                // Avoid calling method multiple times in the loop.
                var conversionOptions = ConversionOptions;
                // Whatever we do with the parameters, we'll need them in a ListValue.
                var listValue = new ListValue
                {
                    Values = { Parameters.Select(x => x.GetConfiguredSpannerDbType(conversionOptions).ToProtobufValue(x.GetValidatedValue())) }
                };

                if (CommandTextBuilder.SpannerCommandType != SpannerCommandType.Delete)
                {
                    var w = new Mutation.Types.Write
                    {
                        Table = CommandTextBuilder.TargetTable,
                        Columns = { Parameters.Select(x => x.SourceColumn ?? x.ParameterName) },
                        Values = { listValue }
                    };
                    switch (CommandTextBuilder.SpannerCommandType)
                    {
                        case SpannerCommandType.Update:
                            return new List<Mutation> { new Mutation { Update = w } };
                        case SpannerCommandType.Insert:
                            return new List<Mutation> { new Mutation { Insert = w } };
                        case SpannerCommandType.InsertOrUpdate:
                            return new List<Mutation> { new Mutation { InsertOrUpdate = w } };
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    var w = new Mutation.Types.Delete
                    {
                        Table = CommandTextBuilder.TargetTable,
                        KeySet = new V1.KeySet { Keys = { listValue } }
                    };
                    return new List<Mutation> { new Mutation { Delete = w } };
                }
            }

            // Based on the QueryOptions set at various levels (connection, environment and command),
            // constructs the QueryOptions proto to set in the ExecuteSqlRequest.
            // Options set at the SpannerCommand-level has the highest precedence.
            // Options set at the environment variable level has the next highest precedence.
            // Options set at the connection level has the lowest precedence.
            private V1.ExecuteSqlRequest.Types.QueryOptions GetEffectiveQueryOptions()
            {
                var queryOptionsProto = new V1.ExecuteSqlRequest.Types.QueryOptions();

                // Query options set through the connection have the lowest precedence.
                if (Connection.QueryOptions != null)
                {
                    queryOptionsProto.MergeFrom(Connection.QueryOptions.ToProto());
                }

                // Query options set through an environment variable have the next highest precedence.
                var envQueryOptionsProto = new V1.ExecuteSqlRequest.Types.QueryOptions
                {
                    OptimizerVersion = Environment.GetEnvironmentVariable(SpannerOptimizerVersionVariable)?.Trim() ?? "",
                    OptimizerStatisticsPackage = Environment.GetEnvironmentVariable(SpannerOptimizerStatisticsPackageVariable)?.Trim() ?? ""
                };
                queryOptionsProto.MergeFrom(envQueryOptionsProto);

                // Query options set at the command level have the highest precedence.
                if (QueryOptions != null)
                {
                    queryOptionsProto.MergeFrom(QueryOptions.ToProto());
                }

                return queryOptionsProto;
            }

            private RequestOptions BuildRequestOptions() =>
                new RequestOptions
                {
                    Priority = PriorityConverter.ToProto(Priority),
                    RequestTag = Tag ?? "",
                };

            private ExecuteSqlRequest GetExecuteSqlRequest()
            {
                var request = new ExecuteSqlRequest
                {
                    Sql = CommandTextBuilder.ToString(),
                    QueryOptions = GetEffectiveQueryOptions(),
                    RequestOptions = BuildRequestOptions()
                };

                Parameters.FillSpannerCommandParams(out var parameters, request.ParamTypes, ConversionOptions);
                request.Params = parameters;

                return request;
            }

            private ReadRequest GetReadRequest()
            {
                GaxPreconditions.CheckState(CommandTextBuilder.ReadOptions != null, "Cannot create a ReadRequest without ReadOptions");
                return new ReadRequest
                {
                    Table = CommandTextBuilder.TargetTable,
                    Index = CommandTextBuilder.ReadOptions.IndexName ?? "",
                    Limit = CommandTextBuilder.ReadOptions.Limit ?? 0L,
                    KeySet = KeySet.ToProtobuf(ConversionOptions),
                    Columns = { CommandTextBuilder.ReadOptions.Columns },
                    RequestOptions = BuildRequestOptions()
                };
            }

            private ReadOrQueryRequest GetReadOrQueryRequest()
            {
                ReadOrQueryRequest request = Partition switch
                {
                    // If this is not a partition, then it's a query or read. We build the right request.
                    null => CommandTextBuilder.SpannerCommandType switch
                    {
                        SpannerCommandType.Select => ReadOrQueryRequest.FromQueryRequest(GetExecuteSqlRequest()),
                        SpannerCommandType.Read => ReadOrQueryRequest.FromReadRequest(GetReadRequest()),
                        _ => throw new InvalidOperationException($"Implementation error: Invalid command type ${CommandTextBuilder.SpannerCommandType} for read or query. This should not happen.")
                    },
                    // If this is a partition, we already have a request, but we need to clone it if we are applying
                    // directed read options later on.
                    _ => DirectedReadOptions switch
                    {
                        null => Partition.Request,
                        _ => Partition.Request.CloneRequest()
                    }
                };

                // We don't validate that DirectedReadOptions is null when this is a non-read-only transaction.
                // The service should fail if there are options set.
                // This was agreed as part of the client library desing.
                if (DirectedReadOptions is not null)
                {
                    request.DirectedReadOptions = DirectedReadOptions;
                }

                return request;
            }

            private static void ValidateCommandBehavior(CommandBehavior behavior)
            {
                if ((behavior & CommandBehavior.KeyInfo) == CommandBehavior.KeyInfo)
                {
                    throw new NotSupportedException(
                        $"{nameof(CommandBehavior.KeyInfo)} is not supported by Cloud Spanner.");
                }
                if ((behavior & CommandBehavior.SchemaOnly) == CommandBehavior.SchemaOnly)
                {
                    throw new NotSupportedException(
                        $"{nameof(CommandBehavior.SchemaOnly)} is not supported by Cloud Spanner.");
                }
            }
        }
    }
}
