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
using Google.Protobuf;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        /// <summary>
        /// Interface for communication between PooledSession and TargetedSessionPool/DetachedSessionPool.
        /// </summary>
        internal interface ISessionPool
        {
            SpannerClient Client { get; }
            IClock Clock { get; }
            Task<PooledSession> WithFreshTransactionOrNewAsync(PooledSession session, TransactionOptions transactionOptions, CancellationToken cancellationToken);
            void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession);
            /// <summary>
            /// Detaches the given session from the pool, meaning the pool stops tracking this session as active,
            /// but does nothing else, in particular it doesn't return the session to the pool or attempts to delete it.
            /// </summary>
            /// <param name="session">The pooled session to be detached. Currently unusued by all <see cref="ISessionPool"/>
            /// implementations, but that's just an implementation detail: the <see cref="TargetedSessionPool"/> does not
            /// keep track of active <see cref="PooledSession"/> instances themselves, but only through counters.</param>
            void Detach(PooledSession session);
            SessionPoolOptions Options { get; }
        }
    }
}
