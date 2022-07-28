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
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods for making it easier to work with <see cref="Table"/>
    /// </summary>
    public static class TableExtensions
    {
        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

        /// <summary>
        /// Gets the time at which this table expires, at which point it will be deleted.
        /// </summary>
        /// <param name="table">The table for which to set the expiration for.
        /// Must not be null.</param>
        public static DateTimeOffset? GetExpirationTime(this Table table) =>
            GaxPreconditions.CheckNotNull(table, nameof(table)).ExpirationTime.HasValue ?
            UnixEpoch.AddMilliseconds(table.ExpirationTime.Value) : (DateTimeOffset?)null;

        /// <summary>
        /// Sets the time at which this table expires, at which point it will be deleted.
        /// If this is not set and the dataset does not have a default
        /// expiration period, the table will persist until it is deleted.
        /// </summary>
        /// <param name="table">The table for which to set the expiration for.
        /// Must not be null.</param>
        /// <param name="expiration">The new expiration to be set.</param>
        /// <returns>The same table on which the change was made. To facilitate method chaining.</returns>
        public static Table SetExpirationTime(this Table table, DateTimeOffset? expiration)
        {
            GaxPreconditions.CheckNotNull(table, nameof(table));
            table.ExpirationTime = (long?)(expiration - UnixEpoch)?.TotalMilliseconds;
            return table;
        }

        /// <summary>
        /// Determines whether two <see cref="TableReference"/> refer to the same <see cref="Table"/>,
        /// that is if the project ID, dataset ID and the table ID are the same.
        /// </summary>
        /// <param name="tableReference1">The first table reference to compare. Must not be null.</param>
        /// <param name="tableReference2">The second table reference to compare.</param>
        /// <returns>true if the specified table references refer to the same table, false otherwise.</returns>
        internal static bool ReferencesSameAs(this TableReference tableReference1, TableReference tableReference2)
        {
            GaxPreconditions.CheckNotNull(tableReference1, nameof(tableReference1));

            return tableReference1.ProjectId == tableReference2.ProjectId &&
                tableReference1.DatasetId == tableReference2.DatasetId &&
                tableReference1.TableId == tableReference2.TableId;
        }

        /// <summary>
        /// Gets the resource name from the given <see cref="TableReference"/> using
        /// the standard resource name format: projects/*/datasets/*/tables/*.
        /// </summary>
        internal static string GetResourceName(this TableReference tableReference) =>
            $"projects/{tableReference.ProjectId}/datasets/{tableReference.DatasetId}/tables/{tableReference.TableId}";
    }
}
