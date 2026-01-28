// Copyright 2025 Google LLC
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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Manages an underlying Spanner multiplex session and its lifecycle.
/// </summary>
public sealed partial class ManagedSession
{
    private readonly ManagedSessionOptions _options;
    private readonly LifecycleManager _lifecycleManager;

    /// <summary>
    /// Creates a <see cref="ManagedSession"/> for the given <paramref name="options"/>.
    /// </summary>
    public ManagedSession(ManagedSessionOptions options)
    {
        _options = GaxPreconditions.CheckNotNull(options, nameof(options));
        _lifecycleManager = new LifecycleManager(options);
    }

    /// <summary>
    /// Creates a <see cref="ManagedTransaction"/> associated to this session.
    /// </summary>
    /// <remarks>
    /// Note that obtaining a <see cref="ManagedTransaction"/> won't inmediately start a Spanner transaction.
    /// Instead, a <see cref="ManagedTransaction"/> will start a Spanner transaction when needed, usually when
    /// exeucting the first command, and will manage the Spanner transaction lifecycle.
    /// </remarks>
    public async Task<ManagedTransaction> BeginTransactionAsync(TransactionOptions transactionOptions, bool singleUse, bool shared, CancellationToken cancellationToken)
    {
        var session = await _lifecycleManager.GetFreshSessionAsync(cancellationToken).ConfigureAwait(false);
        return ManagedTransaction.FromTransactionOptions(_options, session, transactionOptions, singleUse, shared);
    }

    /// <summary>
    /// Ennsures the underlying Spanner session is fresh.
    /// </summary>
    /// <remarks>
    /// Note that session freshness and lifecycle is handled automatically, so this method rarely needs to be called,
    /// except maybe after the <see cref="ManagedSession"/> has been created or has been idle for a long time, and before
    /// executing the first command, to make certain refreshing the session does not penalize, latency wise, the first few commands.
    /// </remarks>
    public async Task EnsureFreshAsync(CancellationToken cancellationToken)
    {
        _ = await _lifecycleManager.GetFreshSessionAsync(cancellationToken).ConfigureAwait(false);
    }
}

