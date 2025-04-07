// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Google.Protobuf.WellKnownTypes;
using System;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Options that may be applied to a transaction after creation, usually before committing the transaction
/// or before executing the first transactional statement.
/// </summary>
/// <remarks>
/// As opposed to <see cref="SpannerTransactionCreationOptions"/>, instances of this class are mutable.
/// This is useful for ORM and similar implementations that depend on ADO.NET for transaction and command
/// creation, which does not know about these Spanner specific options. These implementations may still
/// access transaction and commands after creation and change these options.
/// </remarks>
public sealed class SpannerTransactionOptions
{
    private TimeSpan? _maxCommitDelay;
    private int? _commitTimeout;
    private DisposeBehavior _disposeBehavior = DisposeBehavior.Default;

    /// <summary>
    /// Creates an instance of <see cref="SpannerTransactionOptions"/> with default values.
    /// </summary>
    public SpannerTransactionOptions()
    { }

    /// <summary>
    /// Creates an instance of <see cref="SpannerTransactionOptions"/> with the same values as <paramref name="other"/>.
    /// </summary>
    /// <param name="other">The options to create this instance from. Must not be null.</param>
    public SpannerTransactionOptions(SpannerTransactionOptions other)
    {
        GaxPreconditions.CheckNotNull(other, nameof(other));

        _maxCommitDelay = other._maxCommitDelay;
        _commitTimeout = other._commitTimeout;
        CommitPriority = other.CommitPriority;
        Tag = other.Tag;
        DisposeBehavior = other.DisposeBehavior;
        LogCommitStats = other.LogCommitStats;
    }

    /// <summary>
    /// The maximum amount of time the commit may be delayed server side for batching with other commits.
    /// The bigger the delay, the better the throughput (QPS), but at the expense of commit latency.
    /// If set to <see cref="TimeSpan.Zero"/>, commit batching is disabled.
    /// May be null, in which case commits will continue to be batched as they had been before this configuration
    /// option was made available to Spanner API consumers.
    /// May be set to any value between <see cref="TimeSpan.Zero"/> and 500ms.
    /// Cannot be modified after commit or rollback has been called on the transaction.
    /// </summary>
    public TimeSpan? MaxCommitDelay
    {
        get => _maxCommitDelay;
        set => _maxCommitDelay = value is null ? null : GaxPreconditions.CheckArgumentRange(value, nameof(MaxCommitDelay), TimeSpan.Zero, TimeSpan.MaxValue);
    }

    internal Duration MaxCommitDelayDuration => MaxCommitDelay is null ? null : Duration.FromTimeSpan(MaxCommitDelay.Value);

    // Note: We use seconds here to follow the convention set by DbCommand.CommandTimeout.
    /// <summary>
    /// The wait time, in seconds, before terminating the attempt to <see cref="SpannerTransaction.Commit()"/>
    /// or <see cref="SpannerTransaction.Rollback"/> and generating an error. May be null, in which case, a transaction
    /// using these options will default to the commit timeout defined on its connection string.
    /// A value of '0' normally indicates that no timeout should be used (wait an infinite amount of time).
    /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
    /// that expires immediately. This is normally used only for testing purposes.
    /// </summary>
    public int? CommitTimeout
    {
        get => _commitTimeout;
        set => _commitTimeout = value is null ? null : GaxPreconditions.CheckArgumentRange(value, nameof(value), 0, int.MaxValue);
    }

    internal int EffectiveCommitTimeout(SpannerConnection spannerConnection) =>
        _commitTimeout ?? GaxPreconditions.CheckNotNull(spannerConnection, nameof(spannerConnection)).Builder.Timeout;

    /// <summary>
    /// The priority to use for the <see cref="SpannerTransaction.Commit()"/> and similar overloads.
    /// For command execution priority, use <see cref="SpannerCommand.Priority"/>.
    /// This value will be ignored by read-only transactions.
    /// </summary>
    public Priority? CommitPriority { get; set; }

    internal Priority EffectivePriority(TransactionMode transactionMode) => transactionMode switch
    {
        TransactionMode.ReadOnly => Priority.Unspecified,
        _ => CommitPriority ?? Priority.Unspecified
    };

    /// <summary>
    /// The transaction tag to use for <see cref="SpannerTransaction"/>
    /// This value will be ignored by read-only transactions.
    /// Changes to this value will be ignored by the transaction after it has executed statements.
    /// </summary>
    public string Tag { get; set; }
    private string _beforeFirstStatementTag;

    internal string EffectiveTag(TransactionMode transactionMode, bool hasExecutedStatements)
    {
        MaybeAfterStatementExecution(hasExecutedStatements, transactionMode);
        return hasExecutedStatements ? _beforeFirstStatementTag : EffectiveTag(transactionMode);
    }

    private string EffectiveTag(TransactionMode transactionMode) => transactionMode switch
    {
        TransactionMode.ReadOnly => "",
        _ => Tag ?? ""
    };

    private bool _hasExecutedStatements = false;
    private readonly object _statementExecutionLock = new object();
    private void MaybeAfterStatementExecution(bool hasExecutedStatements, TransactionMode transactionMode)
    {
        lock (_statementExecutionLock)
        {
            // This should never fail, because once this method is called with hasExecutedStatemens == true,
            // it will always be called with hasExecutedStatements == true.
            // Each transaction creates its own instance of transaction options, and although the options themselves can be modified,
            // the options instance of any given transaction cannot be modified.
            GaxPreconditions.CheckState(!_hasExecutedStatements || hasExecutedStatements, "Statements were already executed for this transaction.");

            if (!_hasExecutedStatements && hasExecutedStatements)
            {
                _hasExecutedStatements = true;
                _beforeFirstStatementTag = EffectiveTag(transactionMode);
            }
        }
    }

    /// <summary>
    /// Specifies how resources are treated when <see cref="SpannerTransaction.Dispose"/> is called.
    /// Defaults to <see cref="DisposeBehavior.Default"/>. For a pooled transaction, 
    /// <see cref="DisposeBehavior.Default"/> will cause transactional resources
    /// to be sent back into a shared pool for re-use.
    /// For a detached transaction the default behaviour is to do nothing with transactional resources.
    /// If set to <see cref="DisposeBehavior.CloseResources"/> all transactional resource will be closed.
    /// A detached transaction must have one process choose <see cref="DisposeBehavior.CloseResources"/>
    /// to avoid leaks of transactional resources.
    /// Changes to this value will be ignored after the transaction has been disposed.
    /// </summary>
    public DisposeBehavior DisposeBehavior
    {
        get => _disposeBehavior;
        set
        {
            _disposeBehavior = GaxPreconditions.CheckEnumValue(value, nameof(DisposeBehavior));
        }
    }

    /// <summary>
    /// Specifies whether this transaction should request commit statistics from the backend
    /// and log these. If unset, the value set on the SpannerConnection
    /// of this transaction will be used.
    /// </summary>
    public bool? LogCommitStats { get; set; }

    internal bool EffectiveLogCommitStats(SpannerConnection spannerConnection) =>
        LogCommitStats ?? GaxPreconditions.CheckNotNull(spannerConnection, nameof(spannerConnection)).Builder.LogCommitStats;
}
