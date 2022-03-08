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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// The results of a completed query.
    /// </summary>
    public sealed class BigQueryResults : IEnumerable<BigQueryRow>
    {
        private readonly BigQueryClient _client;
        private readonly GetQueryResultsOptions _options;
        private readonly GetQueryResultsResponse _response;
        private readonly Dictionary<string, int> _fieldNames;

        /// <summary>
        /// The reference to the query job.
        /// </summary>
        public JobReference JobReference => _response.JobReference;

        /// <summary>
        /// The schema of the query.
        /// </summary>
        public TableSchema Schema => _response.Schema;

        /// <summary>
        /// The reference to the table containing the query results.
        /// May be null. (For example, script queries don't store results in tables.)
        /// </summary>
        public TableReference TableReference { get; }

        /// <summary>
        /// The total number of rows in the results, or <c>null</c> if the query results do not provide a row count.
        /// </summary>
        public ulong? TotalRows => _response.TotalRows;

        /// <summary>
        /// The total number of rows affected by a DML statement, or <c>null</c> for non-DML results.
        /// </summary>
        public long? NumDmlAffectedRows => _response.NumDmlAffectedRows;

        /// <summary>
        /// The rows in the response, or an empty sequence if the response contains no rows.
        /// </summary>
        private IEnumerable<BigQueryRow> ResponseRows => ConvertResponseRows(_response);

        /// <summary>
        /// Returns an asynchronous sequence of rows from this set of results.
        /// </summary>
        /// <remarks>
        /// <para>This method exists rather than making the class implement <see cref="IAsyncEnumerable{BigQueryRow}"/> to avoid
        /// ambiguity.</para>
        /// </remarks>
        /// <returns>An asynchronous sequence of rows from this set of results.</returns>
        public IAsyncEnumerable<BigQueryRow> GetRowsAsync() => new AsyncRowEnumerable(this);

        /// <summary>
        /// Returns an iterator over the query results.
        /// </summary>
        /// <returns>An iterator over the query results.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Constructs a new set of results.
        /// </summary>
        /// <remarks>
        /// This is public to allow tests to construct instances for production code to consume;
        /// production code should not normally construct instances itself.
        /// </remarks>
        /// <param name="client">The client to use for further operations. Must not be null.</param>
        /// <param name="response">The response to a GetQueryResults API call. Must not be null.</param>
        /// <param name="tableReference">A reference to the table containing the results.
        /// May be null. (For example, script queries don't store results in tables.)</param>
        /// <param name="options">Options to use when fetching results. May be null.</param>
        public BigQueryResults(BigQueryClient client, GetQueryResultsResponse response, TableReference tableReference, GetQueryResultsOptions options)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _response = GaxPreconditions.CheckNotNull(response, nameof(response));
            TableReference = tableReference;
            _options = options;
            _fieldNames = response.Schema?.IndexFieldNames();
        }

        /// <summary>
        /// Returns an iterator over the query results.
        /// </summary>
        /// <returns>An iterator over the query results.</returns>
        public IEnumerator<BigQueryRow> GetEnumerator()
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
                var response = _client.GetRawQueryResults(JobReference, clonedOptions, timeoutBase: null);
                foreach (var row in ConvertResponseRows(response))
                {
                    yield return row;
                }
                clonedOptions.PageToken = response.PageToken;
            }
        }

        /// <summary>
        /// Eagerly fetches a set of rows, up to the specified count, providing a page of results with a next page token
        /// if more results are available. This is typically used within web applications, where the next page token
        /// is propagated to the client along with the results, so that the next page can be retrieved in another request.
        /// </summary>
        /// <param name="pageSize">The maximum number of rows to retrieve. Must be positive.</param>
        /// <returns>An in-memory result set of at most the given number of rows.</returns>
        public BigQueryPage ReadPage(int pageSize)
        {
            GaxPreconditions.CheckArgumentRange(pageSize, nameof(pageSize), 1, int.MaxValue);
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            List<BigQueryRow> rows = new List<BigQueryRow>(pageSize);

            // Work out whether to use the response we've already got, or create a new one.
            GetQueryResultsResponse response = _response;
            if (response.Rows?.Count > pageSize)
            {
                // Oops. Do it again from scratch, with a useful page size.
                clonedOptions.PageSize = pageSize;
                response = _client.GetRawQueryResults(JobReference, clonedOptions, timeoutBase: null);
            }
            // First add the rows from the existing response.
            rows.AddRange(ConvertResponseRows(response));
            string pageToken = response.PageToken;
            clonedOptions.StartIndex = null;

            // Now keep going until we've filled the result set or know there's no more data.
            while (rows.Count < pageSize && pageToken != null)
            {
                clonedOptions.PageToken = pageToken;
                clonedOptions.PageSize = pageSize - rows.Count;
                var nextResponse = _client.GetRawQueryResults(JobReference, clonedOptions, timeoutBase: null);
                rows.AddRange(ConvertResponseRows(nextResponse));
                pageToken = nextResponse.PageToken;
            }
            return new BigQueryPage(rows, Schema, JobReference, TableReference, pageToken);
        }

        /// <summary>
        /// Asynchronously but eagerly fetches a set of rows, up to the specified count, providing a page of results with a next page token
        /// if more results are available. This is typically used within web applications, where the next page token
        /// is propagated to the client along with the results, so that the next page can be retrieved in another request.
        /// </summary>
        /// <param name="pageSize">The maximum number of rows to retrieve. Must be positive.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// an in-memory result set of at most the given number of rows.</returns>
        public async Task<BigQueryPage> ReadPageAsync(int pageSize, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckArgumentRange(pageSize, nameof(pageSize), 1, int.MaxValue);
            GetQueryResultsOptions clonedOptions = _options?.Clone() ?? new GetQueryResultsOptions();
            List<BigQueryRow> rows = new List<BigQueryRow>(pageSize);

            // Work out whether to use the response we've already got, or create a new one.
            GetQueryResultsResponse response = _response;
            if (response.Rows?.Count > pageSize)
            {
                // Oops. Do it again from scratch, with a useful page size.
                clonedOptions.PageSize = pageSize;
                response = await _client.GetRawQueryResultsAsync(JobReference, clonedOptions, timeoutBase: null, cancellationToken).ConfigureAwait(false);
            }
            // First add the rows from the existing response.
            rows.AddRange(ConvertResponseRows(response));
            string pageToken = response.PageToken;
            clonedOptions.StartIndex = null;

            // Now keep going until we've filled the result set or know there's no more data.
            while (rows.Count < pageSize && pageToken != null)
            {
                clonedOptions.PageToken = pageToken;
                clonedOptions.PageSize = pageSize - rows.Count;
                var nextResponse = await _client.GetRawQueryResultsAsync(JobReference, clonedOptions, timeoutBase: null, cancellationToken).ConfigureAwait(false);
                rows.AddRange(ConvertResponseRows(nextResponse));
                pageToken = nextResponse.PageToken;
            }
            return new BigQueryPage(rows, Schema, JobReference, TableReference, pageToken);
        }

        // TODO: Work out how we can get this far (a valid query with results, but with an error as well).

        /// <summary>
        /// Returns <c>this</c> if the job has no errors, or throws an exception containing the
        /// errors. A job may have errors but still contain useful information.
        /// </summary>
        /// <exception cref="GoogleApiException">The job has errors.</exception>
        /// <returns><c>this</c> if the job has no errors.</returns>
        public BigQueryResults ThrowOnAnyError()
        {
            var errors = _response.Errors;
            if (errors?.Count > 0)
            {
                throw new GoogleApiException(_client.Service.Name)
                {
                    Error = new RequestError
                    {
                        Errors = errors.Select(error => new SingleError
                        {
                            Location = error.Location,
                            Reason = error.Reason,
                            Message = error.Message
                        }).ToList(),
                        Message = $"Job {JobReference.ProjectId}/{JobReference.Location}/{JobReference.JobId} contained {errors.Count} error(s). " +
                            $"First error message: {errors.First().Message}"
                    }
                };
            }
            return this;
        }

        private sealed class AsyncRowEnumerable : IAsyncEnumerable<BigQueryRow>
        {
            private readonly BigQueryResults _parent;

            public AsyncRowEnumerable(BigQueryResults parent) => _parent = parent;

            public IAsyncEnumerator<BigQueryRow> GetAsyncEnumerator(CancellationToken cancellationToken) =>
                new AsyncRowEnumerator(_parent, cancellationToken);
        }

        private sealed class AsyncRowEnumerator : IAsyncEnumerator<BigQueryRow>
        {
            private readonly GetQueryResultsOptions _options;
            private readonly BigQueryResults _parent;
            private readonly CancellationToken _cancellationToken;
            private IEnumerator<BigQueryRow> _underlyingEnumerator;

            public AsyncRowEnumerator(BigQueryResults parent, CancellationToken cancellationToken)
            {
                _parent = parent;
                _cancellationToken = cancellationToken;
                _options = parent._options?.Clone() ?? new GetQueryResultsOptions();
                _options.StartIndex = null;
                _options.PageToken = parent._response.PageToken;
                _underlyingEnumerator = parent.ResponseRows.GetEnumerator();
            }

            public BigQueryRow Current => _underlyingEnumerator.Current;

            public async ValueTask<bool> MoveNextAsync()
            {
                _cancellationToken.ThrowIfCancellationRequested();
                // Keep asking for rows until we've got one, or we've run out of pages.
                while (!_underlyingEnumerator.MoveNext())
                {
                    if (_options.PageToken == null)
                    {
                        return false;
                    }
                    var nextResponse = await _parent._client.GetRawQueryResultsAsync(_parent.JobReference, _options, timeoutBase: null, _cancellationToken).ConfigureAwait(false);
                    // Set the page token for the next time we need to fetch
                    _options.PageToken = nextResponse.PageToken;
                    _underlyingEnumerator = _parent.ConvertResponseRows(nextResponse).GetEnumerator();
                }
                return true;
            }

            public ValueTask DisposeAsync() => default;
        }

        private IEnumerable<BigQueryRow> ConvertResponseRows(GetQueryResultsResponse response) =>
            (response.Rows ?? Enumerable.Empty<TableRow>()).Select(r => new BigQueryRow(r, Schema, _fieldNames));
    }
}
