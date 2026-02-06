// Copyright 2026 Google LLC
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
using System.Threading;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Represents a batch of mutation groups to be executed against a Spanner database using the BatchWrite RPC.
/// Each group is applied atomically and independently of other groups.
/// Currently only Insert, Update, InsertOrUpdate, and Delete commands are supported in batch write mode.
/// <para>
/// You can create an instance of <see cref="SpannerBatchWriteCommand"/> with no
/// initial commands.
/// You can then add commands to a <see cref="SpannerBatchWriteCommand"/> using the
/// <see cref="Add(SpannerCommand, SpannerCommand[])"/> or
/// <see cref="Add(IEnumerable{SpannerCommand})"/> methods.
/// </para>
/// <para>
/// Use <see cref="ExecuteNonQueryAsync(CancellationToken)"/>.
/// </para>
/// </summary>
/// <remarks>
/// The BatchWrite RPC is intended for high-throughput write operations where
/// atomicity is required within each group, but not across groups. This allows for partial
/// success of the batch, where some groups may be committed while others fail.
/// </remarks>
public sealed partial class SpannerBatchWriteCommand
{
    private int _commandTimeout;
    private readonly List<CommandGroup> _commandGroups = new List<CommandGroup>();

    internal SpannerBatchWriteCommand(SpannerConnection connection)
    {
        Connection = GaxPreconditions.CheckNotNull(connection, nameof(connection));
    }

    // Visible for testing
    internal IList<CommandGroup> CommandGroups => _commandGroups;

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
    /// The statement tag to send to Cloud Spanner for this command.
    /// </summary>
    public string Tag { get; set; }

    /// <summary>
    /// The RPC priority to use for this command. The default priority is Unspecified.
    /// </summary>
    public Priority Priority { get; set; }

    /// <summary>
    /// Adds one or more <see cref="SpannerCommand"/> instances as a single atomic command group.
    /// </summary>
    /// <param name="firstCommand">The first command to add to the group. Must not be null.</param>
    /// <param name="otherCommands">Additional commands to add to the same group. May be null.</param>
    /// <exception cref="InvalidOperationException">One of the commands is not a supported write operation.</exception>
    public void Add(SpannerCommand firstCommand, params SpannerCommand[] otherCommands)
    {
        GaxPreconditions.CheckNotNull(firstCommand, nameof(firstCommand));
        var group = new CommandGroup();
        group.Commands.Add(firstCommand);
        if (otherCommands != null)
        {
            group.Commands.AddRange(otherCommands);
        }
        ValidateAndAddGroup(group);
    }

    /// <summary>
    /// Adds a collection of <see cref="SpannerCommand"/> instances as a single atomic command group.
    /// </summary>
    /// <param name="commands">The collection of commands to add. Must not be null or empty.</param>
    /// <exception cref="ArgumentException"><paramref name="commands"/> is empty.</exception>
    /// <exception cref="InvalidOperationException">One of the commands is not a supported write operation.</exception>
    public void Add(IEnumerable<SpannerCommand> commands)
    {
        GaxPreconditions.CheckNotNull(commands, nameof(commands));
        var group = new CommandGroup();
        group.Commands.AddRange(commands);
        ValidateAndAddGroup(group);
    }

    /// <summary>
    /// Executes the batch of command groups asynchronously, returning a stream of responses.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token for the operation.</param>
    /// <returns>An <see cref="IAsyncEnumerable{BatchWriteResponse}"/> representing the stream of results.</returns>
    public IAsyncEnumerable<BatchWriteResult> ExecuteNonQueryAsync(CancellationToken cancellationToken = default) =>
        new ExecutableCommand(this).ExecuteNonQueryAsync(cancellationToken);

    /// <summary>
    /// A simple container for a list of commands that form a single atomic unit.
    /// </summary>
    internal class CommandGroup
    {
        public List<SpannerCommand> Commands { get; set; } = new List<SpannerCommand>();

        public CommandGroup Clone() => new CommandGroup { Commands = [.. Commands] };
    }

    private void ValidateAndAddGroup(CommandGroup group)
    {
        foreach (var command in group.Commands)
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var type = command.SpannerCommandTextBuilder.SpannerCommandType;
            if (type != SpannerCommandType.Insert
                && type != SpannerCommandType.Update
                && type != SpannerCommandType.InsertOrUpdate
                && type != SpannerCommandType.Delete)
            {
                throw new InvalidOperationException($"Command type {type} is not supported in BatchWrite. Only Insert, Update, InsertOrUpdate, and Delete are supported.");
            }
        }
        _commandGroups.Add(group);
    }
}