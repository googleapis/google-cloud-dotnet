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
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System.Collections.Generic;
using System.Linq;
using static Google.Apis.Bigquery.v2.Data.TableDataInsertAllResponse;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// The results obtained after an insertion attempt.
    /// This will contain information on invalid rows if any.
    /// </summary>
    public sealed class BigQueryInsertResults
    {
        private readonly BigQueryClient _client;
        private readonly InsertOptions _options;
        private IReadOnlyList<BigQueryInsertRowErrors> _errors;

        /// <summary>
        /// Status of the insert request.
        /// See <see cref="BigQueryInsertStatus"/> for a detailed explanation.
        /// </summary>
        public BigQueryInsertStatus Status
        {
            get
            {
                if (_errors.Count == 0)
                {
                    return BigQueryInsertStatus.AllRowsInserted;
                }
                if (OriginalRowsWithErrors >= InsertAttemptRowCount || _options?.SkipInvalidRows != true)
                {
                    return BigQueryInsertStatus.NoRowsInserted;
                }

                return BigQueryInsertStatus.SomeRowsInserted;
            }
        }

        /// <summary>
        /// Returns a sequence over rows with insert errors.
        /// Each element represents a row with possibly multiple errors associated to it.
        /// </summary>
        /// <returns>A sequence over rows with insert errors. Will never be null.</returns>
        public IEnumerable<BigQueryInsertRowErrors> Errors => _errors;

        /// <summary>
        /// The amount of rows that were attempted in the insert operation.
        /// </summary>
        public int InsertAttemptRowCount { get; }

        /// <summary>
        /// The number of rows with reported errors in <see cref="Errors"/>.
        /// Note that it's possible that some errors are not associated to 
        /// any particular row so this number might be smaller than the number
        /// of elements in <see cref="Errors"/>.
        /// </summary>
        public int OriginalRowsWithErrors { get; }

        /// <summary>
        /// Constructs a new set of insert results.
        /// </summary>
        /// <param name="client">The client used for the insert request. Must not be null.</param>
        /// <param name="options">The options used for the insert request. May be null.</param>
        /// <param name="originalRows">The rows whose insert was attempted. Must not be null.</param>
        /// <param name="insertResponse">The response obtained after attempting the insert. Must not be null.</param>
        public BigQueryInsertResults(BigQueryClient client, InsertOptions options, IReadOnlyList<BigQueryInsertRow> originalRows, TableDataInsertAllResponse insertResponse)
        {
            GaxPreconditions.CheckNotNull(insertResponse, nameof(insertResponse));
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            GaxPreconditions.CheckNotNull(originalRows, nameof(originalRows));
            InsertAttemptRowCount = originalRows.Count;
            _options = options;

            var errorsByRow = insertResponse.InsertErrors
                ?.Where(error => error != null)
                .GroupBy(error => error.Index) ?? Enumerable.Empty<IGrouping<long?, InsertErrorsData>>();

            int originalRowsWithErrors = 0;
            _errors = errorsByRow
                .Select(rowErrors => new BigQueryInsertRowErrors(GetRow(rowErrors.Key), rowErrors.ToList().AsReadOnly()))
                .OrderBy(rowErrors => rowErrors.OriginalRowIndex ?? long.MaxValue)
                .ToList().AsReadOnly();

            OriginalRowsWithErrors = originalRowsWithErrors;

            BigQueryInsertRow GetRow(long? index)
            {
                if (index.HasValue && index.Value >= 0 && index.Value < InsertAttemptRowCount)
                {
                    originalRowsWithErrors++;
                    return originalRows[(int)index.Value];
                }
                return null;
            }
        }

        /// <summary>
        /// Throws <see cref="GoogleApiException"/> if not all rows were inserted.
        /// </summary>
        /// <exception cref="GoogleApiException">Not all rows were inserted.</exception>
        public BigQueryInsertResults ThrowOnNotAllInserted() =>
            Status == BigQueryInsertStatus.AllRowsInserted ? this : ThrowOnAnyError();

        /// <summary>
        /// Throws <see cref="GoogleApiException"/> if no row was inserted.
        /// </summary>
        /// <exception cref="GoogleApiException">No row was inserted.</exception>
        public BigQueryInsertResults ThrowOnNoneInserted() =>
            Status == BigQueryInsertStatus.NoRowsInserted ? ThrowOnAnyError() : this;

        /// <summary>
        /// Throws <see cref="GoogleApiException"/> if there were insert errors.
        /// The exception will contain details of these errors.
        /// </summary>
        /// <exception cref="GoogleApiException">There were insert errors.</exception>
        public BigQueryInsertResults ThrowOnAnyError()
        {
            if (_errors.Count == 0)
            {
                return this;
            }

            var flattenedErrors = Errors.SelectMany(rowErrors => rowErrors).ToList();
            throw new GoogleApiException(_client.Service.Name)
            {
                Error = new RequestError
                {
                    Errors = flattenedErrors,
                    Message = $"Error inserting data: {flattenedErrors.Count} error(s). " +
                        $"Status: {Status}. " +
                        $"First error message: { flattenedErrors.First().Message }"
                }
            };
        }

        internal BigQueryInsertResults ThrowIfNotSuppressing(bool? suppressInsertErrors) =>
            suppressInsertErrors == true ? this : ThrowOnAnyError();
    }
}
