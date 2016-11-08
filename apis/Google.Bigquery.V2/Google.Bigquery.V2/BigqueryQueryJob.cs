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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Bigquery.V2
{
    // TODO: Rename this to avoid the double "query".

    /// <summary>
    /// A job known to be running a query. The job may not have completed yet.
    /// </summary>
    public sealed class BigqueryQueryJob
    {
        private readonly GetQueryResultsResponse _response;
        private readonly BigqueryClient _client;
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
        private IEnumerable<BigqueryRow> ResponseRows => (_response.Rows ?? Enumerable.Empty<TableRow>()).Select(r => new BigqueryRow(r, Schema));

        internal BigqueryQueryJob(BigqueryClient client, GetQueryResultsResponse response, GetQueryResultsOptions options)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _response = GaxPreconditions.CheckNotNull(response, nameof(response));
            _options = options;
        }

        internal BigqueryQueryJob(BigqueryClient client, QueryResponse response, ExecuteQueryOptions options)
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
        public BigqueryQueryJob PollUntilCompleted(PollSettings pollSettings = null) =>
            Completed ? this : _client.PollQueryUntilCompleted(JobReference, _options, pollSettings);

        /// <summary>
        /// Returns a lazy enumeration of all the rows in the query (from any originally-specified page token onwards),
        /// making server calls as required. The job must be completed before this method is called.
        /// </summary>
        /// <exception cref="InvalidOperationException">This object does not represent a completed job.</exception>
        /// <returns>A sequence of rows from the query results.</returns>
        /// <seealso cref="PollUntilCompleted(PollSettings)"/>
        public IEnumerable<BigqueryRow> GetRows()
        {
            if (!Completed)
            {
                throw new InvalidOperationException($"Cannot call {nameof(GetRows)} on an incomplete job");
            }

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

        // Note to readers: we should make it as easy as possible to do the work below, of course.
        // Possibly BigqueryClient should have a GetResultSet(jobReference, pageSize, pageToken) call.

        /// <summary>
        /// Eagerly fetches a set of rows, up to the specified count.
        /// </summary>
        /// <remarks>
        /// If <paramref name="maxRows"/> is smaller than the number of rows originally requested,
        /// this may require another server call to retrieve an appropriate page token. When working
        /// in pages, always specify a maximum per-request number of rows less than or equal to the
        /// page size you want.
        /// </remarks>
        /// <param name="maxRows">The maximum number of rows to retrieve. Must be positive.</param>
        /// <returns>An in-memory result set of at most the given number of rows.</returns>
        public BigqueryResultSet GetResultSet(int maxRows)
        {
            GaxPreconditions.CheckArgumentRange(maxRows, nameof(maxRows), 1, int.MaxValue);
            if (!Completed)
            {
                throw new InvalidOperationException($"Cannot call {nameof(GetResultSet)} on an incomplete job");
            }
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            List<BigqueryRow> rows = new List<BigqueryRow>(maxRows);
            if ((clonedOptions.PageSize == null || clonedOptions.PageSize > maxRows) && _response.Rows?.Count > maxRows)
            {
                // Oops. Do it again from scratch, with a useful page size.
                clonedOptions.PageSize = maxRows;
                return _client.GetQueryResults(JobReference, clonedOptions).GetResultSet(maxRows);
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
            return new BigqueryResultSet(rows, Schema, JobReference, pageToken);
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
        public Task<BigqueryQueryJob> PollUntilCompletedAsync(PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            Completed ? Task.FromResult(this) : _client.PollQueryUntilCompletedAsync(JobReference, _options, pollSettings, cancellationToken);

        /// <summary>
        /// Returns a lazy asynchronous enumeration of all the rows in the query (from any originally-specified page token onwards),
        /// making server calls as required. The job must be completed before this method is called.
        /// </summary>
        /// <exception cref="InvalidOperationException">This object does not represent a completed job.</exception>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// a sequence of rows from the query results.</returns>
        /// <seealso cref="PollUntilCompletedAsync(PollSettings, CancellationToken)"/>
        public IAsyncEnumerable<BigqueryRow> GetRowsAsync()
        {
            if (!Completed)
            {
                throw new InvalidOperationException($"Cannot call {nameof(GetRows)} on an incomplete job");
            }
            return new AsyncRowEnumerable(this);
        }

        // Note to readers: we should make it as easy as possible to do the work below, of course.
        // Possibly BigqueryClient should have a GetResultSet(jobReference, pageSize, pageToken) call.

        /// <summary>
        /// Asynchronously but eagerly fetches a set of rows, up to the specified count.
        /// </summary>
        /// <remarks>
        /// If <paramref name="maxRows"/> is smaller than the number of rows originally requested,
        /// this may require another server call to retrieve an appropriate page token. When working
        /// in pages, always specify a maximum per-request number of rows less than or equal to the
        /// page size you want.
        /// </remarks>
        /// <param name="maxRows">The maximum number of rows to retrieve. Must be positive.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an in-memory result set of at most the given number of rows.</returns>
        public async Task<BigqueryResultSet> GetResultSetAsync(int maxRows, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckArgumentRange(maxRows, nameof(maxRows), 1, int.MaxValue);
            if (!Completed)
            {
                throw new InvalidOperationException($"Cannot call {nameof(GetResultSet)} on an incomplete job");
            }
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            List<BigqueryRow> rows = new List<BigqueryRow>(maxRows);
            if ((clonedOptions.PageSize == null || clonedOptions.PageSize > maxRows) && _response.Rows?.Count > maxRows)
            {
                // Oops. Do it again from scratch, with a useful page size.
                clonedOptions.PageSize = maxRows;
                var newQueryJob = await _client.GetQueryResultsAsync(JobReference, clonedOptions, cancellationToken).ConfigureAwait(false);
                return await newQueryJob.GetResultSetAsync(maxRows, cancellationToken).ConfigureAwait(false);
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
            return new BigqueryResultSet(rows, Schema, JobReference, pageToken);
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

        private sealed class AsyncRowEnumerable : IAsyncEnumerable<BigqueryRow>
        {
            private readonly BigqueryQueryJob _job;

            public AsyncRowEnumerable(BigqueryQueryJob job)
            {
                _job = job;
            }

            public IAsyncEnumerator<BigqueryRow> GetEnumerator()
            {
                return new AsyncRowEnumerator(_job);
            }
        }

        private sealed class AsyncRowEnumerator : IAsyncEnumerator<BigqueryRow>
        {
            private readonly BigqueryQueryJob _job;
            private readonly GetQueryResultsOptions _options;
            private IEnumerator<BigqueryRow> _underlyingIterator;

            public AsyncRowEnumerator(BigqueryQueryJob job)
            {
                _job = job;
                _options = _job._options?.Clone() ?? new GetQueryResultsOptions();
                _options.StartIndex = null;
                _options.PageToken = _job._response.PageToken;
                _underlyingIterator = _job.ResponseRows.GetEnumerator();
            }

            public BigqueryRow Current => _underlyingIterator.Current;

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();
                // Keep asking for rows until we've got one, or we've run out of pages.
                while(!_underlyingIterator.MoveNext())
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
