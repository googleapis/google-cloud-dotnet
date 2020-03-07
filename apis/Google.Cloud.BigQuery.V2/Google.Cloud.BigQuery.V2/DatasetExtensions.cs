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
using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods for making it easier to work with <see cref="Dataset"/>
    /// </summary>
    public static class DatasetExtensions
    {
        /// <summary>
        /// Gets the default expiration period for tables created in this dataset.
        /// Tables will (by default) be automatically deleted this long after they are created,
        /// unless otherwise specified, such as by <see cref="CreateTableOptions.Expiration"/>.
        /// </summary>
        /// <param name="dataset">The dataset for which to set the expiration for.
        /// Must not be null.</param>
        public static TimeSpan? GetDefaultTableExpiration(this Dataset dataset) =>
            GaxPreconditions.CheckNotNull(dataset, nameof(dataset)).DefaultTableExpirationMs.HasValue ?
            TimeSpan.FromMilliseconds(dataset.DefaultTableExpirationMs.Value) : (TimeSpan?)null;

        /// <summary>
        /// Sets the default expiration period for tables created in this dataset.
        /// Tables will (by default) be automatically deleted this long after they are created,
        /// unless otherwise specified, such as by <see cref="CreateTableOptions.Expiration"/>.
        /// </summary>
        /// <param name="dataset">The dataset for which to set the expiration for.
        /// Must not be null.</param>
        /// <param name="expiration">The new expiration to be set.</param>
        /// <returns>The same dataset on which the change was made. To facilitate method chaining.</returns>
        public static Dataset SetDefaultTableExpiration(this Dataset dataset, TimeSpan? expiration)
        {
            GaxPreconditions.CheckNotNull(dataset, nameof(dataset));
            dataset.DefaultTableExpirationMs = (long?)expiration?.TotalMilliseconds;
            return dataset;
        }

        /// <summary>
        /// Gets the default partition expiration period for all partitioned tables created in the dataset.
        /// Partitioned tables will (by default) be automatically deleted this long after they are created,
        /// unless otherwise specified, such as by <see cref="CreateTableOptions.Expiration"/>.
        /// For partitioned tables, this values has priority over <see cref="Dataset.DefaultTableExpirationMs"/>.
        /// </summary>
        /// <param name="dataset">The dataset for which to set the expiration for.
        /// Must not be null.</param>
        public static TimeSpan? GetDefaultPartitionExpiration(this Dataset dataset) =>
            GaxPreconditions.CheckNotNull(dataset, nameof(dataset)).DefaultPartitionExpirationMs.HasValue ?
            TimeSpan.FromMilliseconds(dataset.DefaultPartitionExpirationMs.Value) : (TimeSpan?)null;

        /// <summary>
        /// Gets the default partition expiration period for all partitioned tables created in the dataset.
        /// Partitioned tables will (by default) be automatically deleted this long after they are created,
        /// unless otherwise specified, such as by <see cref="CreateTableOptions.Expiration"/>.
        /// For partitioned tables, this values has priority over <see cref="Dataset.DefaultTableExpirationMs"/>.
        /// </summary>
        /// <param name="dataset">The dataset for which to set the expiration for.
        /// Must not be null.</param>
        /// <param name="expiration">The new expiration to be set.</param>
        /// <returns>The same dataset on which the change was made. To facilitate method chaining.</returns>
        public static Dataset SetDefaultPartitionExpiration(this Dataset dataset, TimeSpan? expiration)
        {
            GaxPreconditions.CheckNotNull(dataset, nameof(dataset));
            dataset.DefaultPartitionExpirationMs = (long?)expiration?.TotalMilliseconds;
            return dataset;
        }

        /// <summary>
        /// Determines whether two <see cref="DatasetReference"/> refer to the same <see cref="Dataset"/>,
        /// that is if the project ID and the dataset ID are the same.
        /// </summary>
        /// <param name="datasetReference1">The first dataset reference to compare. Must not be null.</param>
        /// <param name="datasetReference2">The second dataset reference to compare.</param>
        /// <returns>true isfthe specified dataset references refer to the same dataset, false otherwise.</returns>
        internal static bool ReferencesSameAs(this DatasetReference datasetReference1, DatasetReference datasetReference2)
        {
            GaxPreconditions.CheckNotNull(datasetReference1, nameof(datasetReference1));

            return string.Equals(datasetReference1.ProjectId, datasetReference2.ProjectId) &&
                string.Equals(datasetReference1.DatasetId, datasetReference2.DatasetId);
        }
    }
}
