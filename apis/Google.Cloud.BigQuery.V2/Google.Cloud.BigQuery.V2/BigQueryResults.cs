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
        private readonly ListRowsOptions _options;
        private readonly GetQueryResultsResponse _response;

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
        /// </summary>
        public TableReference TableReference { get; }

        /// <summary>
        /// The total number of rows in the results.
        /// </summary>
        public ulong TotalRows => _response.TotalRows.Value;

        /// <summary>
        /// Returns an asynchronous sequence of rows from this set of results.
        /// </summary>
        /// <remarks>
        /// <para>This method exists rather than making the class implement <see cref="IAsyncEnumerable{BigQueryRow}"/> to avoid
        /// ambiguity.</para>
        /// </remarks>
        /// <returns>An asynchronous sequence of rows from this set of results.</returns>
        public IAsyncEnumerable<BigQueryRow> GetRowsAsync() => _client.ListRowsAsync(TableReference, Schema, _options);

        /// <summary>
        /// Returns an iterator over the query results.
        /// </summary>
        /// <returns>An iterator over the query results.</returns>
        public IEnumerator<BigQueryRow> GetEnumerator() =>
            _client.ListRows(TableReference, Schema, _options).GetEnumerator();

        /// <summary>
        /// </summary>
        public BigQueryDataReader GetDataReader() => new BigQueryDataReader(this);

        /// <summary>
        /// Returns an iterator over the query results.
        /// </summary>
        /// <returns>An iterator over the query results.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        internal BigQueryResults(BigQueryClient client, GetQueryResultsResponse response, TableReference tableReference, ListRowsOptions options)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _response = GaxPreconditions.CheckNotNull(response, nameof(response));
            TableReference = GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            _options = options;
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
            // Make sure we start off by trying to read the right page size...
            var options = GetOptionsWithPageSize(pageSize);
            var page = _client.ListRows(TableReference, Schema, options).ReadPage(pageSize);
            return new BigQueryPage(page, Schema, JobReference, TableReference);
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
        public async Task<BigQueryPage> ReadPageAsync(int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckArgumentRange(pageSize, nameof(pageSize), 1, int.MaxValue);
            // Make sure we start off by trying to read the right page size...
            var options = GetOptionsWithPageSize(pageSize);
            var page = await _client.ListRowsAsync(TableReference, Schema, options)
                .ReadPageAsync(pageSize, cancellationToken)
                .ConfigureAwait(false);
            return new BigQueryPage(page, Schema, JobReference, TableReference);
        }

        private ListRowsOptions GetOptionsWithPageSize(int pageSize)
        {
            if (_options == null)
            {
                return new ListRowsOptions { PageSize = pageSize };
            }
            if (_options.PageSize == pageSize)
            {
                return _options;
            }
            var clone = _options.Clone();
            clone.PageSize = pageSize;
            return clone;
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
    }
}
