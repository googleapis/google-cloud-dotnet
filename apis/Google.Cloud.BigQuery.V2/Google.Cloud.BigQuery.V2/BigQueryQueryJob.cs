// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    // TODO: Rename this to avoid the double "query".

    /// <summary>
    /// A job known to be running a query. The job may not have completed yet.
    /// </summary>
    /// <remarks>
    /// The methods to return data from the query (<see cref="GetResultSet(int, PollSettings)"/>,
    /// <see cref="GetResultSetAsync(int, PollSettings, CancellationToken)"/>,
    /// <see cref="GetRows(PollSettings)"/> and <see cref="GetRowsAsync(PollSettings)"/>)
    /// all poll automatically if they are called
    /// on incomplete jobs. To poll manually, use <see cref="PollUntilCompleted(PollSettings)"/> or
    /// <see cref="PollUntilCompletedAsync(PollSettings, CancellationToken)"/>.
    /// </remarks>
    public sealed class BigQueryQueryJob
    {
        private readonly GetQueryResultsResponse _response;
        private readonly BigQueryClient _client;
        private readonly GetQueryResultsOptions _options;

        /// <summary>
        /// The reference to the job.
        /// </summary>
        public JobReference JobReference => _response.JobReference;

        /// <summary>
        /// Whether or not the query has completed or not.
        /// </summary>
        public bool Completed => _response.JobComplete ?? false;

        /// <summary>
        /// The schema of the query.
        /// </summary>
        public TableSchema Schema => _response.Schema;

        /// <summary>
        /// The total number of rows in the results, if known.
        /// </summary>
        public ulong? TotalRows => _response.TotalRows;

        /// <summary>
        /// The rows in the response, or an empty sequence if the response contains no rows.
        /// </summary>
        private IEnumerable<BigQueryRow> ResponseRows => (_response.Rows ?? Enumerable.Empty<TableRow>()).Select(r => new BigQueryRow(r, Schema));

        internal BigQueryQueryJob(BigQueryClient client, GetQueryResultsResponse response, GetQueryResultsOptions options)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _response = GaxPreconditions.CheckNotNull(response, nameof(response));
            _options = options;
        }

        internal BigQueryQueryJob(BigQueryClient client, QueryResponse response, ExecuteQueryOptions options)
            : this(client, ConvertQueryResponse(GaxPreconditions.CheckNotNull(response, nameof(response))), options?.ToGetQueryResultsOptions())
        {
        }

        /// <summary>
        /// Polls this query job until it has completed.
        /// </summary>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>This object, if it has already completed, or the results of polling repeatedly until
        /// the job has completed.</returns>
        public BigQueryQueryJob PollUntilCompleted(PollSettings pollSettings = null) =>
            Completed ? this : _client.PollQueryUntilCompleted(JobReference, _options, pollSettings);

        /// <summary>
        /// Returns a lazy enumeration of all the rows in the query (from any originally-specified page token onwards),
        /// making server calls as required. If the job has not completed already, it is polled until it has completed
        /// using <paramref name="pollSettings" />.
        /// </summary>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of rows from the query results.</returns>
        /// <seealso cref="PollUntilCompleted(PollSettings)"/>
        public IEnumerable<BigQueryRow> GetRows(PollSettings pollSettings = null) =>
            PollUntilCompleted(pollSettings).GetRowsImpl();

        // Implementation of GetRows for a completed job.
        private IEnumerable<BigQueryRow> GetRowsImpl()
        {
            foreach (var row in ResponseRows)
            {
                yield return row;
            }
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            clonedOptions.StartIndex = null;
            clonedOptions.PageToken = _response.PageToken;
            while (clonedOptions.PageToken != null)
            {
                var job = _client.GetQueryResults(JobReference, clonedOptions);
                foreach (var row in job.ResponseRows)
                {
                    yield return row;
                }
                clonedOptions.PageToken = job._response.PageToken;
            }
        }

        /// <summary>
        /// Eagerly fetches a set of rows, up to the specified count, providing a page of results with a next page token
        /// if more results are available. This is typically used within web applications, where the next page token
        /// is propagated to the client along with the results, so that the next page can be retrieved in another request.
        /// If the job is still incompleted, it is polled until it has completed.
        /// </summary>
        /// <remarks>
        /// If <paramref name="maxRows"/> is smaller than the number of rows originally requested,
        /// this may require another server call to retrieve an appropriate page token. When working
        /// in pages, always specify a maximum per-request number of rows less than or equal to the
        /// page size you want.
        /// </remarks>
        /// <param name="maxRows">The maximum number of rows to retrieve. Must be positive.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>An in-memory result set of at most the given number of rows.</returns>
        public BigQueryResultSet GetResultSet(int maxRows, PollSettings pollSettings = null)
        {
            GaxPreconditions.CheckArgumentRange(maxRows, nameof(maxRows), 1, int.MaxValue);
            return PollUntilCompleted(pollSettings).GetResultSetImpl(maxRows);
        }

        // Implementation of GetResultSet for an already-complete job.
        private BigQueryResultSet GetResultSetImpl(int maxRows)
        {
            if (!Completed)
            {
                throw new InvalidOperationException($"Cannot call {nameof(GetResultSet)} on an incomplete job");
            }
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            List<BigQueryRow> rows = new List<BigQueryRow>(maxRows);
            if ((clonedOptions.PageSize == null || clonedOptions.PageSize > maxRows) && _response.Rows?.Count > maxRows)
            {
                // Oops. Do it again from scratch, with a useful page size.
                // Still, we know it's already completed, so we can skip straight to the Impl method again.
                clonedOptions.PageSize = maxRows;
                return _client.GetQueryResults(JobReference, clonedOptions).GetResultSetImpl(maxRows);
            }
            // First add the rows from the first response which is part of the state
            // of the object.
            rows.AddRange(ResponseRows);
            string pageToken = _response.PageToken;
            clonedOptions.StartIndex = null;
            // Now keep going until we've filled the result set or know there's no more data.
            while (rows.Count > maxRows && pageToken != null)
            {
                clonedOptions.PageToken = pageToken;
                clonedOptions.PageSize = maxRows - rows.Count;
                var job = _client.GetQueryResults(JobReference, clonedOptions);
                rows.AddRange(job.ResponseRows);
                pageToken = job._response.PageToken;

            }
            return new BigQueryResultSet(rows, Schema, JobReference, pageToken);
        }

        /// <summary>
        /// Returns <c>this</c> if the job has no errors, or throws an exception containing the
        /// errors. A job may have errors but still contain useful information, and may also contain
        /// errors before completing.
        /// </summary>
        /// <exception cref="GoogleApiException">The job has errors.</exception>
        /// <returns><c>this</c> if the job has no errors.</returns>
        public BigQueryQueryJob ThrowOnAnyError()
        {
            var errors = _response.Errors;
            if (errors?.Count > 0)
            {
                throw new GoogleApiException(_client.Service.Name, $"Job {JobReference.ProjectId}/{JobReference.JobId} contained errors")
                {
                    Error = new RequestError
                    {
                        Errors = errors.Select(error => new SingleError
                        {
                            Location = error.Location,
                            Reason = error.Reason,
                            Message = error.Message
                        })
                        .ToList()
                    }
                };
            }
            return this;
        }

        /// <summary>
        /// Polls this query job until it has completed.
        /// </summary>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// this object, if it has already completed, or the results of polling repeatedly until
        /// the job has completed.</returns>
        public Task<BigQueryQueryJob> PollUntilCompletedAsync(PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            Completed ? Task.FromResult(this) : _client.PollQueryUntilCompletedAsync(JobReference, _options, pollSettings, cancellationToken);

        /// <summary>
        /// Returns a lazy asynchronous enumeration of all the rows in the query (from any originally-specified page token onwards),
        /// making server calls as required. If the job is not already completed, it will be polled with the given <paramref name="pollSettings"/>.
        /// </summary>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of rows from the query results.</returns>
        /// <seealso cref="PollUntilCompletedAsync(PollSettings, CancellationToken)"/>
        public IAsyncEnumerable<BigQueryRow> GetRowsAsync(PollSettings pollSettings = null)
            => new AsyncRowEnumerable(this, pollSettings);

        /// <summary>
        /// Asynchronously but eagerly fetches a set of rows, up to the specified count, providing a page of results with a next page token
        /// if more results are available. This is typically used within web applications, where the next page token
        /// is propagated to the client along with the results, so that the next page can be retrieved in another request.
        /// If the job is still incompleted, it is polled until it has completed.
        /// </summary>
        /// <remarks>
        /// If <paramref name="maxRows"/> is smaller than the number of rows originally requested,
        /// this may require another server call to retrieve an appropriate page token. When working
        /// in pages, always specify a maximum per-request number of rows less than or equal to the
        /// page size you want.
        /// </remarks>
        /// <param name="maxRows">The maximum number of rows to retrieve. Must be positive.</param>
        /// <param name="pollSettings">The settings to control how often and long the job is fetched before timing out if it is still incomplete.
        /// May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an in-memory result set of at most the given number of rows.</returns>
        public async Task<BigQueryResultSet> GetResultSetAsync(int maxRows, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckArgumentRange(maxRows, nameof(maxRows), 1, int.MaxValue);
            var job = await PollUntilCompletedAsync(pollSettings, cancellationToken);
            return await job.GetResultSetAsyncImpl(maxRows, cancellationToken);
        }

        // Implementation of GetResultSet for an already-complete job.
        private async Task<BigQueryResultSet> GetResultSetAsyncImpl(int maxRows, CancellationToken cancellationToken)
        {
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            List<BigQueryRow> rows = new List<BigQueryRow>(maxRows);
            if ((clonedOptions.PageSize == null || clonedOptions.PageSize > maxRows) && _response.Rows?.Count > maxRows)
            {
                // Oops. Do it again from scratch, with a useful page size.
                // Still, we know it's already completed, so we can skip straight to the Impl method again.
                clonedOptions.PageSize = maxRows;
                var newQueryJob = await _client.GetQueryResultsAsync(JobReference, clonedOptions, cancellationToken).ConfigureAwait(false);
                return await newQueryJob.GetResultSetAsyncImpl(maxRows, cancellationToken).ConfigureAwait(false);
            }
            // First add the rows from the first response which is part of the state
            // of the object.
            rows.AddRange(ResponseRows);
            string pageToken = _response.PageToken;
            clonedOptions.StartIndex = null;
            // Now keep going until we've filled the result set or know there's no more data.
            while (rows.Count > maxRows && pageToken != null)
            {
                clonedOptions.PageToken = pageToken;
                clonedOptions.PageSize = maxRows - rows.Count;
                var job = await _client.GetQueryResultsAsync(JobReference, clonedOptions, cancellationToken).ConfigureAwait(false);
                rows.AddRange(job.ResponseRows);
                pageToken = job._response.PageToken;

            }
            return new BigQueryResultSet(rows, Schema, JobReference, pageToken);
        }

        private static GetQueryResultsResponse ConvertQueryResponse(QueryResponse response) =>
            new GetQueryResultsResponse
            {
                CacheHit = response.CacheHit,
                Errors = response.Errors,
                ETag = response.ETag,
                JobComplete = response.JobComplete,
                JobReference = response.JobReference,
                NumDmlAffectedRows = response.NumDmlAffectedRows,
                PageToken = response.PageToken,
                Rows = response.Rows,
                Schema = response.Schema,
                TotalBytesProcessed = response.TotalBytesProcessed,
                TotalRows = response.TotalRows
            };

        private sealed class AsyncRowEnumerable : IAsyncEnumerable<BigQueryRow>
        {
            private readonly BigQueryQueryJob _job;
            private readonly PollSettings _pollSettings;

            public AsyncRowEnumerable(BigQueryQueryJob job, PollSettings pollSettings)
            {
                _job = job;
                _pollSettings = pollSettings;
            }

            public IAsyncEnumerator<BigQueryRow> GetEnumerator()
            {
                return new AsyncRowEnumerator(_job, _pollSettings);
            }
        }

        private sealed class AsyncRowEnumerator : IAsyncEnumerator<BigQueryRow>
        {
            private readonly GetQueryResultsOptions _options;
            private readonly PollSettings _pollSettings;
            private BigQueryQueryJob _job; // Not readonly as we may need to replace it with the completed one.
            private IEnumerator<BigQueryRow> _underlyingIterator;

            public AsyncRowEnumerator(BigQueryQueryJob job, PollSettings pollSettings)
            {
                _job = job;
                _pollSettings = pollSettings;
                _options = _job._options?.Clone() ?? new GetQueryResultsOptions();
                _options.StartIndex = null;
                _options.PageToken = _job._response.PageToken;
            }

            public BigQueryRow Current => _underlyingIterator.Current;

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (_underlyingIterator == null)
                {
                    if (!_job.Completed)
                    {
                        _job = await _job.PollUntilCompletedAsync(_pollSettings, cancellationToken);
                    }
                    _underlyingIterator = _job.ResponseRows.GetEnumerator();
                }
                // Keep asking for rows until we've got one, or we've run out of pages.
                while (!_underlyingIterator.MoveNext())
                {
                    if (_options.PageToken == null)
                    {
                        return false;
                    }
                    var nextResults = await _job._client.GetQueryResultsAsync(_job.JobReference, _options, cancellationToken).ConfigureAwait(false);
                    _options.PageToken = nextResults._response.PageToken;
                    _underlyingIterator = nextResults.ResponseRows.GetEnumerator();
                }
                return true;
            }

            public void Dispose()
            {
                // No-op
            }
        }
    }
}
