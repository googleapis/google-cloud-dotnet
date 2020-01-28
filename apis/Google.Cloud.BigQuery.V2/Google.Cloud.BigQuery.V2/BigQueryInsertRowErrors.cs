// Copyright 2020 Google Inc. All Rights Reserved.
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
using Google.Apis.Requests;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Google.Apis.Bigquery.v2.Data.TableDataInsertAllResponse;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Represents insert errors related to one row.
    /// </summary>
    public sealed class BigQueryInsertRowErrors : IEnumerable<SingleError>
    {
        private readonly IReadOnlyList<InsertErrorsData> _errors;

        /// <summary>
        /// The original row to which these errors are related to.
        /// </summary>
        /// <remarks>
        /// Some errors obtained after an insert request might not contain enough
        /// information so as to associate them with one row.
        /// In such cases this may be null.
        /// </remarks>
        public BigQueryInsertRow OriginalRow { get; }

        /// <summary>
        /// The index of the row these errors relate to in the original
        /// inser request. Might be unknown.
        /// </summary>
        public long? OriginalRowIndex => _errors[0].Index;

        /// <summary>
        /// Returns an iterator over the insert errors.
        /// </summary>
        /// <returns>An iterator over the insert errors.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Constructs a new set of insert errors related to one insert row.
        /// </summary>
        /// <param name="originalRow">The original row to which these errors are related to if known. May be null.</param>
        /// <param name="errors">The errors information.</param>
        public BigQueryInsertRowErrors(BigQueryInsertRow originalRow, IReadOnlyList<InsertErrorsData> errors)
        {
            GaxPreconditions.CheckArgument(errors?.Count > 0, nameof(errors), "Can't be null or empty");
            _errors = errors;
            OriginalRow = originalRow;
        }

        /// <summary>
        /// Returns an interator over the insert errors.
        /// </summary>
        /// <returns>An iterator over the insert errors.</returns>
        public IEnumerator<SingleError> GetEnumerator()
        {
            string messagePrefix = $"Error in row {OriginalRowIndex?.ToString() ?? "unknown"}.";

            IEnumerable<SingleError> singleErrors = from error in _errors
                                                    where error?.Errors != null
                                                    from detail in error.Errors
                                                    where detail != null
                                                    select new SingleError
                                                    {
                                                        Location = detail.Location,
                                                        Reason = detail.Reason,
                                                        Message = $"{messagePrefix} {detail.Message ?? string.Empty}"
                                                    };
            if (!singleErrors.Any())
            {
                // No error details, just unknown errors potentially associated to a row.
                return Enumerable.Repeat(new SingleError { Message = messagePrefix }, 1).GetEnumerator();
            }
            return singleErrors.GetEnumerator();
        }
    }
}
