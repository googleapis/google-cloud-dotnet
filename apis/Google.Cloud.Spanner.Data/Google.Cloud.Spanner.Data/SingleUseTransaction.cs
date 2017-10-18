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
            _spannerConnection.ReleaseSession(_session);
        }

        public Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds) => throw
            new NotSupportedException("A single use transaction can only be used for read operations.");

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
                    return Task.FromResult(_spannerConnection.SpannerClient.GetSqlStreamReader(request, _session, timeoutSeconds));
                },
                "SingleUseTransaction.ExecuteQuery", _spannerConnection.Logger);
        }
    }
}
