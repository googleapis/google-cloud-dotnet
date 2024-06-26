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
            SessionPoolOptions Options { get; }
            bool TracksSessions { get; }
            Task<PooledSession> RefreshedOrNewAsync(PooledSession session, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken);
            void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession);
        }
    }
}
