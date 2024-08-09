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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents batched commands to execute against a Spanner database.
    /// Currently only DML commands are supported in batch mode.
    /// <para>
    /// You can create an instance of <see cref="SpannerBatchCommand"/> with no
    /// initial commands.
    /// You can then add commands to a <see cref="SpannerBatchCommand"/> using the
    /// <see cref="Add(SpannerCommandTextBuilder, SpannerParameterCollection)"/> or
    /// <see cref="Add(string, SpannerParameterCollection)"/> or <see cref="Add(SpannerCommand)"/> methods.
    /// </para>
    /// <para>
    /// For batched DML commands use <see cref="ExecuteNonQueryAsync(CancellationToken)"/> or
    /// <see cref="ExecuteNonQuery" /> to execute the batched commands.
    /// </para>
    /// </summary>
    public sealed partial class SpannerBatchCommand
    {
        private int _commandTimeout;
        private SpannerBatchCommandType _commandType;
        private TimeSpan? _maxCommitDelay;

        internal SpannerBatchCommand(SpannerConnection connection)
        {
            Connection = GaxPreconditions.CheckNotNull(connection, nameof(connection));
        }

        internal SpannerBatchCommand(SpannerTransaction transaction)
        {
            Transaction = GaxPreconditions.CheckNotNull(transaction, nameof(transaction));
            Connection = transaction.SpannerConnection; // Never null
        }

        // Visible for testing
        internal IList<SpannerCommand> Commands { get; } = new List<SpannerCommand>();

        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to execute a command and generating an error.
        /// Defaults to the timeout from the connection string.
        /// </summary>
        /// <remarks>
        /// A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </remarks>
        public int CommandTimeout
        {
            get => _commandTimeout;
            set => _commandTimeout = GaxPreconditions.CheckArgumentRange(value, nameof(value), 0, int.MaxValue);
        }

        /// <summary>
        /// The connection to the data source. This is never null.
        /// </summary>
        public SpannerConnection Connection { get; }

        /// <summary>
        /// The transaction to use when executing this command. If this is null, the command will be executed without a transaction.
        /// </summary>
        public SpannerTransaction Transaction { get; }

        /// <summary>
        /// The type of this batch command. If initialy set to <see cref="SpannerBatchCommandType.None"/>, this value will be
        /// calculated when the first command is added to the batch.
        /// <para>Only DML commands are currently supported in batch mode.</para>
        /// <para>You can set this property freely as long as there are no commands in this bacth command.
        /// Once there are commands in this batch command an attempt to change this property's value will throw
        /// and <see cref="ArgumentException"/>.</para>
        /// </summary>
        public SpannerBatchCommandType CommandType
        {
            get => _commandType;
            set
            {
                GaxPreconditions.CheckEnumValue(value, nameof(value));
                GaxPreconditions.CheckArgument(Commands.Count == 0 || _commandType == value, nameof(value), "Cannot change the type of this batch command because it already contains commands.");
                _commandType = value;
            }
        }

        /// <summary>
        /// The statement tag to send to Cloud Spanner for this command.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// The RPC priority to use for this command. The default priority is Unspecified.
        /// </summary>
        public Priority Priority { get; set; }

        /// <summary>
        /// The maximum amount of time the commit of the implicit transaction associated with this command, if any,
        /// may be delayed server side for batching with other commits.
        /// The bigger the delay, the better the throughput (QPS), but at the expense of commit latency.
        /// If set to <see cref="TimeSpan.Zero"/>, commit batching is disabled.
        /// May be null, in which case commits will continue to be batched as they had been before this configuration
        /// option was made available to Spanner API consumers.
        /// May be set to any value between <see cref="TimeSpan.Zero"/> and 500ms.
        /// </summary>
        /// <remarks>
        /// When a batch command is executed with no explicit or ambient transaction, an implicit transaction is created
        /// and the command is executed within it. This value will be applied to the commit operation of such transaction,
        /// if there is any. Otherwise, this value will be ignored.
        /// </remarks>
        public TimeSpan? MaxCommitDelay
        {
            get => _maxCommitDelay;
            set => _maxCommitDelay = SpannerTransaction.CheckMaxCommitDelayRange(value);
        }

        /// <summary>
        /// Options to be used for creating the ephemeral transaction under which this command will be executed
        /// if no explicit or ambient transaction is set.
        /// These options will be ignored if an explicit transaction is set on the command via <see cref="SpannerTransaction.CreateBatchDmlCommand"/>
        /// or an ambient transaction has been started via <see cref="SpannerConnection.OpenAsync(SpannerTransactionCreationOptions, SpannerTransactionOptions, CancellationToken)"/>
        /// and similar methods.
        /// May be null, in which case appropriate defaults will be used when needed.
        /// </summary>
        public SpannerTransactionCreationOptions EphemeralTransactionCreationOptions { get; set; }

        /// <summary>
        /// Adds a command to the collection of batch commands to be executed by this <see cref="SpannerBatchCommand"/>.
        /// </summary>
        /// <param name="commandText"> The command text to be added. Must not be null or empty.
        /// Currently only DML commands are supported in batch operations.</param>
        /// <param name="parameters">The parameters associated with <paramref name="commandText"/>.
        /// If <paramref name="commandText"/> doesn't require parameters then <paramref name="parameters"/>
        /// can be either <code>null</code> or empty.</param>
        public void Add(string commandText, SpannerParameterCollection parameters = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(commandText, nameof(commandText));

            SpannerCommand command = new SpannerCommand(commandText, parameters);
            ValidateAndSetCommandType(command.SpannerCommandTextBuilder.SpannerCommandType);
            Commands.Add(command);
        }

        /// <summary>
        /// Adds a command to the collection of batch commands to be executed by this <see cref="SpannerBatchCommand"/>.
        /// Only <see cref="SpannerCommand.CommandText"/> and <see cref="SpannerCommand.Parameters"/> will be taken into
        /// account. Other <see cref="SpannerCommand"/> properties like <see cref="SpannerCommand.SpannerConnection"/>
        /// and <see cref="SpannerCommand.DbTransaction"/> will be ignored.
        /// </summary>
        /// <param name="command">The command to be added.</param>
        public void Add(SpannerCommand command) =>
            Add(GaxPreconditions.CheckNotNull(command, nameof(command)).CommandText, command.Parameters);

        /// <summary>
        /// Adds a command to the collection of batch commands to be executed by this <see cref="SpannerBatchCommand"/>.
        /// </summary>
        /// <param name="commandTextBuilder"> A <see cref="SpannerCommandTextBuilder"/> representing the command to be added.
        /// Must not be null or empty.
        /// Currently only DML commands are supported in batch operations.</param>
        /// <param name="parameters">The parameters associated with <paramref name="commandTextBuilder"/>.
        /// If <paramref name="commandTextBuilder"/> doesn't require parameters then <paramref name="parameters"/>
        /// can be either <code>null</code> or empty.</param>
        public void Add(SpannerCommandTextBuilder commandTextBuilder, SpannerParameterCollection parameters = null) =>
            Add(GaxPreconditions.CheckNotNull(commandTextBuilder, nameof(commandTextBuilder)).CommandText, parameters);

        private void ValidateAndSetCommandType(SpannerCommandType spannerCommandType)
        {
            // CommandType is either set manually or because other commands had been added.
            // Check compatibility between the command being added and the set CommandType.
            if(CommandType != SpannerBatchCommandType.None)
            {
                GaxPreconditions.CheckState(
                    spannerCommandType == SpannerCommandType.Dml && CommandType == SpannerBatchCommandType.BatchDml,
                    $"{spannerCommandType} is not compatible with {CommandType}");
            }
            // CommandType is not set. This is the first command being added to the batch.
            // If the type of the command is batch supported, set CommandType to the supporting value.
            else
            {
                GaxPreconditions.CheckState(spannerCommandType == SpannerCommandType.Dml, "Only DML commands are supported in batch mode.");
                CommandType = SpannerBatchCommandType.BatchDml;
            }
        }

        /// <summary>
        /// Executes the batch commands sequentially.
        /// If a command fails, execution is halted and this method will throw an <see cref="SpannerBatchNonQueryException"/>
        /// containing information about the failure and the number of affected rows by each of the commands
        /// that executed successfully before the failure ocurred.
        /// </summary>
        /// <returns>The number of rows affected by each of the executed commands.</returns>
        public IEnumerable<long> ExecuteNonQuery() =>
            Task.Run(() => ExecuteNonQueryAsync(CancellationToken.None)).ResultWithUnwrappedExceptions();

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
        public Task<IReadOnlyList<long>> ExecuteNonQueryAsync(CancellationToken cancellationToken = default) =>
            CreateExecutableCommand().ExecuteNonQueryAsync(cancellationToken);

        private ExecutableCommand CreateExecutableCommand() =>
            new ExecutableCommand(this);
    }
}
