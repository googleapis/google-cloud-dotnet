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
        /// Trivial base class for TargetedSessionPool and DetachedSessionPool.
        /// Only internal so that <see cref="TargetedSessionPool"/> can be internal too.
        /// </summary>
        internal abstract class SessionPoolBase : ISessionPool
        {
            public SpannerClient Client => Parent.Client;
            public IClock Clock => Parent._clock;
            public SessionPoolOptions Options => Parent.Options;
            protected SessionPool Parent { get; }
            public abstract Task<PooledSession> WithFreshTransactionOrNewAsync(PooledSession session, TransactionOptions transactionOptions, CancellationToken cancellationToken);
            public abstract void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession);
            public abstract void Detach(PooledSession session);

            protected SessionPoolBase(SessionPool parent) => Parent = parent;
        }
    }
}
