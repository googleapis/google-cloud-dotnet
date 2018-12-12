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
        /// <remarks>
        /// In certain cases, the query results do not provide a row count. In these cases, accessing this property
        /// will throw an <see cref="InvalidOperationException"/>. The <see cref="SafeTotalRows"/> property provides
        /// a way of accessing the same value, but with a nullable value which will be null if the query results do not
        /// provide a row count.
        /// </remarks>
        /// <exception cref="InvalidOperationException">The query results do not provide a row count.</exception>
        public ulong TotalRows => _response.TotalRows.Value;

        /// <summary>
        /// The total number of rows in the results, or <c>null</c> if the query results do not provide a row count.
        /// </summary>
        public ulong? SafeTotalRows => _response.TotalRows;

        /// <summary>
        /// The total number of rows affected by a DML statement, or <c>null</c> for non-DML results.
        /// </summary>
        public long? NumDmlAffectedRows => _response.NumDmlAffectedRows;

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
        /// <param name="tableReference">A reference to the table containing the results.</param>
        /// <param name="options">Options to use when listing rows. May be null.</param>
        public BigQueryResults(BigQueryClient client, GetQueryResultsResponse response, TableReference tableReference, ListRowsOptions options)
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
        public async Task<BigQueryPage> ReadPageAsync(int pageSize, CancellationToken cancellationToken = default)
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
                throw new GoogleApiException(_client.Service.Name, $"Job {JobReference.ProjectId}/{JobReference.Location}/{JobReference.JobId} contained errors")
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
