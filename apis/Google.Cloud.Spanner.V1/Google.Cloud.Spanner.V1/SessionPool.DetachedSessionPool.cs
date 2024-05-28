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

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        /// <summary>
        /// A "session pool" for sessions that aren't really pooled. This is used by
        /// <see cref="SessionPool.CreateDetachedSession(SessionName, Protobuf.ByteString, TransactionOptions.ModeOneofCase, Timestamp)"/>.
        /// We need to have it in *a* pool so that we can use <see cref="PooledSession"/>, and we need to be able to
        /// delete the session if requested (so we need to know our parent), but that's all.
        /// </summary>
        private sealed class DetachedSessionPool : SessionPoolBase
        {
            public override bool TracksSessions => false;

            internal DetachedSessionPool(SessionPool parent) : base(parent)
            {
            }

            public override void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession)
            {
                if (deleteSession)
                {
                    Parent.ConsumeBackgroundTask(DeleteSessionAsync(), "detached session delete");
                }

                async Task DeleteSessionAsync()
                {
                    // Before deleting the session we attempt to rollback the transaction gracefully.
                    if (transactionToRollback is not null)
                    {
                        var request = new RollbackRequest { SessionAsSessionName = session.SessionName, TransactionId = transactionToRollback };
                        try
                        {
                            await Client.RollbackAsync(request).ConfigureAwait(false);
                        }
                        catch (RpcException e)
                        {
                            Parent._logger.Warn("Failed to rollback transaction for detached session", e);
                        }
                    }
                    await Parent.DeleteSessionAsync(session).ConfigureAwait(false);
                }
            }

            public override Task<PooledSession> RefreshedOrNewAsync(PooledSession session, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) =>
                throw new InvalidOperationException(
                    $"{nameof(session)} is a detached session. Its transaction can't be refreshed and it can't be substituted by a new session.");
        }
    }
}
