// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;

namespace Google.Cloud.Spanner.Data
{
    internal sealed class SingleUseTransaction : ISpannerTransaction, IDisposable
    {
        private readonly SpannerConnection _spannerConnection;
        private readonly Session _session;
        private readonly TransactionOptions _options;
        private SpannerClient _client;

        public SingleUseTransaction(
            SpannerConnection spannerConnection,
            Session session,
            TransactionOptions options)
        {
            _spannerConnection = spannerConnection;
            _session = session;
            _options = options;
        }

        public void Dispose()
        {
            // TODO: Investigate why we can't release the session when the ReliableStreamReader is closed,
            // like we do for EphemeralTransaction.
            if (_client != null)
            {
                _spannerConnection.ReleaseSession(_session, _spannerConnection.SpannerClient);
                _client = null;
            }
        }

        public Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds) =>
            throw new NotSupportedException("A single use transaction can only be used for read operations.");

        public Task<long> ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds) =>
            throw new NotSupportedException("A single use transaction can only be used for read operations.");

        public Task<ReliableStreamReader> ExecuteQueryAsync(
            ExecuteSqlRequest request,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () =>
                {
                    request.Transaction = new TransactionSelector {SingleUse = _options};
                    _client = _spannerConnection.SpannerClient;
                    return Task.FromResult(_client.GetSqlStreamReader(request, _session, timeoutSeconds));
                },
                "SingleUseTransaction.ExecuteQuery", _spannerConnection.Logger);
        }
    }
}
