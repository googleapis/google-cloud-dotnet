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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.PoolRewrite
{
    /// <summary>
    /// A pool of sessions associated with a SpannerClient.
    /// Sessions can be acquired by specifying the desired transaction options, if any.
    /// A session/transaction pair is then returned, which should be returned to the pool when
    /// it is no longer required. Sessions are kept alive automatically, and retired if they
    /// are expired by the server.
    /// </summary>
    public sealed partial class SessionPool
    {
        private readonly ISessionPool _detachedSessionPool;

        private readonly Logger _logger;

        private readonly SpannerClient _client;

        /// <summary>
        /// The options governing this session pool.
        /// </summary>
        public SessionPoolOptions Options { get; }


        /// <summary>
        /// Creates a session pool for the given client.
        /// </summary>
        /// <param name="client">The client to use for this session pool. Must not be null.</param>
        /// <param name="options">The options for this session pool. Must not be null.</param>
        /// <param name="logger">The logger to use. May be null, in which case the default logger is used.</param>
        public SessionPool(SpannerClient client, SessionPoolOptions options, Logger logger)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            Options = GaxPreconditions.CheckNotNull(options, nameof(options));
            _logger = logger ?? Logger.DefaultLogger;
            _detachedSessionPool = new DetachedSessionPool(this);
        }

        // TODO: Rename?

        /// <summary>
        /// Creates a <see cref="PooledSession"/> with a known name and transaction ID/mode, with the client associated
        /// with this pool, but is otherwise not part of this pool. This method does not query the server for the session state.
        /// When the returned <see cref="PooledSession"/> is released, it will not become part of this pool.
        /// </summary>
        /// <param name="sessionName">The name of the transaction. Must not be null.</param>
        /// <param name="transactionId">The ID of the transaction. Must not be null.</param>
        /// <param name="transactionMode">The mode of the transaction.</param>
        /// <returns>A <see cref="PooledSession"/> for the given session and transaction.</returns>
        public PooledSession RecreateSession(SessionName sessionName, ByteString transactionId, ModeOneofCase transactionMode)
        {
            GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
            return PooledSession.FromSessionName(_detachedSessionPool, sessionName).WithTransaction(transactionId, transactionMode);
        }

        /// <summary>
        /// Awooga! Async void method! This is almost always a bad idea, but in this case we have "fire and forget" background
        /// tasks (all created within this method). We want to log errors, but that's all.
        /// </summary>
        private async void ConsumeBackgroundTask(Task task, string purpose)
        {
            try
            {
                await task.ConfigureAwait(false);
            }
            catch (Exception e)
            {
                _logger.Error($"Error in background session pool task for {purpose}", e);
            }
        }

        private void DeleteSessionFireAndForget(PooledSession session)
        {
            ConsumeBackgroundTask(DeleteSessionAsync(session), "session deletion");
        }

        private async Task DeleteSessionAsync(PooledSession session)
        {
            try
            {
                await _client.DeleteSessionAsync(new DeleteSessionRequest { SessionName = session.SessionName }).ConfigureAwait(false);
            }
            catch (RpcException e)
            {
                _logger.Warn("Failed to delete session. Session will be abandoned to garbage collection.", e);
            }
        }

    }
}
