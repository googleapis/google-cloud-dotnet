// Copyright 2020 Google LLC
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
using Google.Apis.Auth.OAuth2.Requests;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Rpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Status = Grpc.Core.Status;

namespace Google.Cloud.Spanner.Data
{
    internal interface IRetriableStatement
    {
        internal Task Retry(RetriableSpannerTransaction transaction, CancellationToken cancellationToken, int timeoutSeconds);
    }

    internal sealed class RetriableDmlStatement : IRetriableStatement
    {
        private readonly ExecuteSqlRequest _request;
        private readonly long _updateCount;

        internal RetriableDmlStatement(ExecuteSqlRequest request, long updateCount)
        {
            this._request = request;
            this._updateCount = updateCount;
        }

        async Task IRetriableStatement.Retry(RetriableSpannerTransaction transaction, CancellationToken cancellationToken, int timeoutSeconds)
        {
            try
            {
                if (await transaction.DoExecuteDmlAsync(_request, cancellationToken, timeoutSeconds).ConfigureAwait(false) != _updateCount)
                {
                    throw new SpannerAbortedDueToConcurrentModificationException();
                }
            }
            catch (SpannerException e) when (e.ErrorCode != ErrorCode.Aborted)
            {
                throw new SpannerAbortedDueToConcurrentModificationException();
            }
        }
    }

    internal sealed class FailedDmlStatement : IRetriableStatement
    {
        private readonly ExecuteSqlRequest _request;
        private readonly SpannerException _exception;

        internal FailedDmlStatement(ExecuteSqlRequest request, SpannerException exception)
        {
            this._request = request;
            this._exception = exception;
        }

        async Task IRetriableStatement.Retry(RetriableSpannerTransaction transaction, CancellationToken cancellationToken, int timeoutSeconds)
        {
            try
            {
                await transaction.DoExecuteDmlAsync(_request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
                // Fallthrough and throw the exception at the end of the method.
            }
            catch (SpannerException e) when (e.ErrorCode != ErrorCode.Aborted)
            {
                // Check that we got the exact same exception this time as the previous time.
                if (RetriableSpannerTransaction.SpannerExceptionsEqualForRetry(e, _exception))
                {
                    return;
                }
            }
            throw new SpannerAbortedDueToConcurrentModificationException();
        }
    }

    internal sealed class RetriableBatchDmlStatement : IRetriableStatement
    {
        private readonly ExecuteBatchDmlRequest _request;
        private readonly IEnumerable<long> _updateCounts;

        internal RetriableBatchDmlStatement(ExecuteBatchDmlRequest request, IEnumerable<long> updateCounts)
        {
            this._request = request;
            this._updateCounts = updateCounts;
        }

        async Task IRetriableStatement.Retry(RetriableSpannerTransaction transaction, CancellationToken cancellationToken, int timeoutSeconds)
        {
            try
            {
                if (!_updateCounts.SequenceEqual(await transaction.DoExecuteBatchDmlAsync(_request, cancellationToken, timeoutSeconds).ConfigureAwait(false)))
                {
                    throw new SpannerAbortedDueToConcurrentModificationException();
                }
            }
            catch (SpannerException e) when (e.ErrorCode != ErrorCode.Aborted)
            {
                throw new SpannerAbortedDueToConcurrentModificationException();
            }
        }
    }

    internal sealed class FailedBatchDmlStatement : IRetriableStatement
    {
        private readonly ExecuteBatchDmlRequest _request;
        private readonly SpannerException _exception;

        internal FailedBatchDmlStatement(ExecuteBatchDmlRequest request, SpannerException exception)
        {
            this._request = request;
            this._exception = exception;
        }

        async Task IRetriableStatement.Retry(RetriableSpannerTransaction transaction, CancellationToken cancellationToken, int timeoutSeconds)
        {
            try
            {
                await transaction.DoExecuteBatchDmlAsync(_request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
                // Fallthrough and throw the exception at the end of the method.
            }
            catch (SpannerBatchNonQueryException e)
            {
                // Check that we got the exact same exception and results this time as the previous time.
                if (_exception is SpannerBatchNonQueryException
                    && e.ErrorCode == _exception.ErrorCode
                    && e.Message.Equals(_exception.Message)
                    && e.SuccessfulCommandResults.SequenceEqual(((SpannerBatchNonQueryException) _exception).SuccessfulCommandResults)
                    )
                {
                    return;
                }
            }
            catch (SpannerException e) when (e.ErrorCode != ErrorCode.Aborted)
            {
                // Check that we got the exact same exception this time as the previous time.
                if (!(_exception is SpannerBatchNonQueryException) && RetriableSpannerTransaction.SpannerExceptionsEqualForRetry(e, _exception))
                {
                    return;
                }
            }
            throw new SpannerAbortedDueToConcurrentModificationException();
        }
    }

    /// <summary>
    /// Represents a SQL transaction to be made in a Spanner database.
    /// A transaction in Cloud Spanner is a set of reads and writes that execute
    /// atomically at a single logical point in time across columns, rows, and
    /// tables in a database.
    /// 
    /// This transaction will automatically be retried if it is aborted by the
    /// Cloud Spanner backend.
    /// </summary>
    public sealed class RetriableSpannerTransaction : SpannerTransaction, ISpannerTransaction
    {
        internal static bool SpannerExceptionsEqualForRetry(SpannerException e1, SpannerException e2)
        {
            // Quick return for the most common case.
            if (e1 == null && e2 == null)
            {
                return true;
            }
            if (!Object.Equals(e1?.ErrorCode, e2?.ErrorCode))
            {
                return false;
            }
            if (!Object.Equals(e1?.Message, e2?.Message))
            {
                return false;
            }
            if (!Object.Equals(e1?.InnerException?.GetType(), e2?.InnerException?.GetType()))
            {
                return false;
            }
            if(e1?.InnerException is RpcException)
            {
                Status status1 = ((RpcException)e1.InnerException).Status;
                Status status2 = ((RpcException)e2.InnerException).Status;
                if(!(Object.Equals(status1.StatusCode, status2.StatusCode) && Object.Equals(status1.Detail, status2.Detail)))
                {
                    return false;
                }
            }
            return true;
        }

        private const int MAX_RETRIES = 1000;
        private const int MAX_TIMEOUT_SECONDS = Int32.MaxValue / 1000; // Max is Int32.MaxValue milliseconds.
        private readonly IClock _clock;
        private readonly IScheduler _scheduler;
        private readonly RetriableTransactionOptions _options;
        private readonly List<IRetriableStatement> _retriableStatements = new List<IRetriableStatement>();
        private int _retryCount;
        internal int RetryCount { get => _retryCount; }

        internal RetriableSpannerTransaction(
            SpannerConnection connection,
            PooledSession session,
            IClock clock,
            IScheduler scheduler,
            RetriableTransactionOptions options = null)
            : base(connection, TransactionMode.ReadWrite, session, null)
        {
            _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
            _scheduler = GaxPreconditions.CheckNotNull(scheduler, nameof(scheduler));
            _options = options ?? RetriableTransactionOptions.CreateDefault();
        }

        internal void Retry(int timeoutSeconds = MAX_TIMEOUT_SECONDS)
        {
            RetryAsync(CancellationToken.None, timeoutSeconds).WaitWithUnwrappedExceptions();
        }

        internal async Task RetryAsync(CancellationToken cancellationToken, int timeoutSeconds = MAX_TIMEOUT_SECONDS)
        {
            while (true)
            {
                _retryCount++;
                Session = await (Session?.WithFreshTransactionOrNewAsync(SpannerConnection.s_readWriteTransactionOptions, cancellationToken) ?? SpannerConnection.AcquireReadWriteSessionAsync(cancellationToken)).ConfigureAwait(false);
                try
                {
                    foreach (IRetriableStatement statement in _retriableStatements)
                    {
                        await statement.Retry(this, cancellationToken, timeoutSeconds).ConfigureAwait(false);
                    }
                    break;
                } catch (SpannerAbortedDueToConcurrentModificationException e)
                {
                    // Retry failed because of a concurrent modification.
                    throw e;
                } catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    // Ignore and retry.
                    if (_retryCount >= MAX_RETRIES)
                    {
                        throw new SpannerException(ErrorCode.Aborted, "Transaction was aborted because it aborted and retried too many times");
                    }
                }
            }
        }

        /// <summary>
        /// Commits the database transaction asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <returns>Returns the UTC timestamp when the data was written to the database.</returns>
        public async override Task<DateTime> CommitAsync(CancellationToken cancellationToken = default)
        {
            while (true)
            {
                try
                {
                    return await base.CommitAsync(cancellationToken).ConfigureAwait(false);
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    await RetryAsync(cancellationToken).ConfigureAwait(false);
                }
            }
        }

        /// <inheritdoc />
        public override void Commit()
        {
            while (true)
            {
                try
                {
                    base.Commit();
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    Retry();
                }
            }
        }

        Task<int> ISpannerTransaction.ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds)
        {
            return DoExecuteMutationsAsync(mutations, cancellationToken, timeoutSeconds);
        }

        async Task<long> ISpannerTransaction.ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            while (true)
            { 
                try
                {
                    long res = await DoExecuteDmlAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
                    _retriableStatements.Add(new RetriableDmlStatement(request, res));
                    return res;
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    await RetryAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
                }
                catch (SpannerException e)
                {
                    _retriableStatements.Add(new FailedDmlStatement(request, e));
                    throw e;
                }
            }
        }

        async Task<IEnumerable<long>> ISpannerTransaction.ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            while (true)
            {
                try
                {
                    var res = await DoExecuteBatchDmlAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
                    _retriableStatements.Add(new RetriableBatchDmlStatement(request, res));
                    return res;
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    await RetryAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
                }
                catch (SpannerException e)
                {
                    _retriableStatements.Add(new FailedBatchDmlStatement(request, e));
                    throw e;
                }
            }
        }

        Task<ReliableStreamReader> ISpannerTransaction.ExecuteQueryAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            return DoExecuteQueryAsync(request, cancellationToken, timeoutSeconds);
        }

        SpannerDataReader ISpannerTransaction.CreateDataReader(
            ExecuteSqlRequest request,
            Logger logger,
            ReliableStreamReader resultSet,
            IDisposable resourceToClose,
            SpannerConversionOptions conversionOptions,
            bool provideSchemaTable,
            int readTimeoutSeconds)
        {
            SpannerDataReaderWithChecksum res = new SpannerDataReaderWithChecksum(
                this,
                request,
                logger,
                resultSet,
                resourceToClose,
                conversionOptions,
                provideSchemaTable,
                readTimeoutSeconds);
            _retriableStatements.Add(res);
            return res;
        }
    }
}
