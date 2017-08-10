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

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods for <see cref="DatasetReference"/> etc.
    /// </summary>
    internal static class EntityReferenceExtensions
    {
        /// <summary>
        /// Returns <paramref name="reference"/> if <paramref name="etag"/> is null, or a new
        /// <see cref="DatasetReference"/> with the specified ETag but the same project ID and dataset ID.
        /// </summary>
        /// <remarks>
        /// The handling of null here is convenient for dealing with options where null means "don't change the original".
        /// It means that clearing the etag is trickier, but that's a rarer use case. Note that the reference that comes back
        /// from GetDataset(...).Reference does *not* include an ETag. (The resource does.)
        /// </remarks>
        /// <param name="reference">The original reference</param>
        /// <param name="etag">The etag to populate in the returned reference, or null for a no-op.</param>
        /// <returns>A new dataset reference, or the original</returns>
        internal static DatasetReference WithETag(this DatasetReference reference, string etag)
            => etag == null ? reference : new DatasetReference { ProjectId = reference.ProjectId, DatasetId = reference.DatasetId, ETag = etag };

        /// <summary>
        /// Returns <paramref name="reference"/> if <paramref name="etag"/> is null, or a new
        /// <see cref="TableReference"/> with the specified ETag but the same project ID and dataset ID.
        /// </summary>
        /// <remarks>
        /// The handling of null here is convenient for dealing with options where null means "don't change the original".
        /// It means that clearing the etag is trickier, but that's a rarer use case. Note that the reference that comes back
        /// from GetTable(...).Reference does *not* include an ETag. (The resource does.)
        /// </remarks>
        /// <param name="reference">The original reference</param>
        /// <param name="etag">The etag to populate in the returned reference, or null for a no-op.</param>
        /// <returns>A new table reference, or the original</returns>
        internal static TableReference WithETag(this TableReference reference, string etag)
            => etag == null ? reference : new TableReference { ProjectId = reference.ProjectId, TableId = reference.TableId, ETag = etag };

        /// <summary>
        /// Returns <paramref name="reference"/> if <paramref name="etag"/> is null, or a new
        /// <see cref="JobReference"/> with the specified ETag but the same project ID and dataset ID.
        /// </summary>
        /// <remarks>
        /// The handling of null here is convenient for dealing with options where null means "don't change the original".
        /// It means that clearing the etag is trickier, but that's a rarer use case. Note that the reference that comes back
        /// from GetJob(...).Reference does *not* include an ETag. (The resource does.)
        /// </remarks>
        /// <param name="reference">The original reference</param>
        /// <param name="etag">The etag to populate in the returned reference, or null for a no-op.</param>
        /// <returns>A new job reference, or the original</returns>
        internal static JobReference WithETag(this JobReference reference, string etag)
            => etag == null ? reference : new JobReference { ProjectId = reference.ProjectId, JobId = reference.JobId, ETag = etag };
    }
}
