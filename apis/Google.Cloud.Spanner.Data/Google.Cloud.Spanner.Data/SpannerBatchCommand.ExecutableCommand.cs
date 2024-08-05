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
using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.ExecuteBatchDmlRequest.Types;

namespace Google.Cloud.Spanner.Data
{
    public sealed partial class SpannerBatchCommand
    {
        /// <summary>
        /// Class that effectively contains a copy of the parameters of a SpannerBatchCommand, but in a shallow-immutable way.
        /// This means we can validate various things and not worry about them changing. The SpannerConnection can be modified,
        /// but other objects should be fine.
        /// This class is an implementation detail, used to keep "code required to execute Spanner commands" separate from the ADO
        /// API surface with its mutable properties and many overloads.
        /// </summary>
        private class ExecutableCommand
        {
            internal SpannerConnection Connection { get; }
            internal SpannerTransaction Transaction { get; }
            internal IList<SpannerCommand> Commands { get; }
            internal int CommandTimeout { get; }
            internal SpannerBatchCommandType CommandType { get; }
            internal Priority Priority { get; }
            internal string Tag { get; }
            internal SpannerConversionOptions ConversionOptions => SpannerConversionOptions.ForConnection(Connection);
            internal TimeSpan? MaxCommitDelay { get; }
            internal SpannerTransactionCreationOptions EphemeralTransactionCreationOptions { get; }

            public ExecutableCommand(SpannerBatchCommand command)
            {
                Connection = command.Connection;
                Transaction = command.Transaction;
                Commands = command.Commands.ToList();
                CommandTimeout = command.CommandTimeout;
                CommandType = command.CommandType;
                Priority = command.Priority;
                Tag = command.Tag;
                MaxCommitDelay = command.MaxCommitDelay;
                EphemeralTransactionCreationOptions = command.EphemeralTransactionCreationOptions;
            }

            /// <summary>
            /// Executes the batch commands sequentially. The execution of this method overall is asynchronous.
            /// </summary>
            /// <param name="cancellationToken">A cancellation token for the operation.</param>
            /// <returns>A task that once completed will indicate the number of rows
            /// affected by each of the executed commands.
            /// If a command fails, execution is halted and this method will return a faulted task with an <see cref="SpannerBatchNonQueryException"/>
            /// containing information about the failure and the number of affected rows by each of the commands
            /// that executed successfully before the failure ocurred.
            /// </returns>
            internal Task<IReadOnlyList<long>> ExecuteNonQueryAsync(CancellationToken cancellationToken)
            {
                ValidateConnectionAndCommandCount();

                switch (CommandType)
                {
                    case SpannerBatchCommandType.BatchDml:
                        return ExecuteBatchDmlAsync(cancellationToken);
                    default:
                        throw new InvalidOperationException("ExecuteNonQuery functionality is only available for batch DML commands");
                }
            }

            private async Task<IReadOnlyList<long>> ExecuteBatchDmlAsync(CancellationToken cancellationToken)
            {
                await Connection.EnsureIsOpenAsync(cancellationToken).ConfigureAwait(false);
                var transaction = Transaction ?? Connection.AmbientTransaction ?? new EphemeralTransaction(Connection, Priority, MaxCommitDelay, EphemeralTransactionCreationOptions);
                ExecuteBatchDmlRequest request = GetExecuteBatchDmlRequest();
                IEnumerable<long> result = await transaction.ExecuteBatchDmlAsync(request, cancellationToken, CommandTimeout).ConfigureAwait(false);
                return result.ToList().AsReadOnly();
            }

            private ExecuteBatchDmlRequest GetExecuteBatchDmlRequest()
            {
                var request = new ExecuteBatchDmlRequest
                {
                    RequestOptions = BuildRequestOptions()
                };
                // Avoid calling method multiple times in the loop.
                var conversionOptions = ConversionOptions;
                foreach (var command in Commands)
                {
                    var statement = new Statement { Sql = command.CommandText };
                    command.Parameters.FillSpannerCommandParams(out var parameters, statement.ParamTypes, conversionOptions);
                    statement.Params = parameters;
                    request.Statements.Add(statement);
                }
                return request;
            }

            private RequestOptions BuildRequestOptions() =>
                new RequestOptions { Priority = PriorityConverter.ToProto(Priority) , RequestTag = Tag ?? "", TransactionTag = Transaction?.Tag ?? "" };

            private void ValidateConnectionAndCommandCount()
            {
                GaxPreconditions.CheckState(Connection != null, "SpannerBatchCommand can only be executed when a connection is assigned.");
                GaxPreconditions.CheckState(Commands.Count > 0, "SpannerBatchCommand can only be executed when the batch contains at least one command.");
            }
        }
    }
}
