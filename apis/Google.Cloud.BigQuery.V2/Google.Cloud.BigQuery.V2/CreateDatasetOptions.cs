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

using Google.Apis.Bigquery.v2.Data;
using System;
using static Google.Apis.Bigquery.v2.DatasetsResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateDatasetOptions</c> operations.
    /// </summary>
    public sealed class CreateDatasetOptions
    {
        /// <summary>
        /// A user-friendly description of the dataset being created.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A descriptive name for the table being created.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// The default expiration period for tables created in the new dataset. Tables
        /// will (by default) be automatically deleted this long after they are created,
        /// unless otherwise specified, such as by <see cref="CreateTableOptions.Expiration"/>.
        /// </summary>
        public TimeSpan? DefaultTableExpiration { get; set; }

        /// <summary>
        /// The default partition expiration for all partitioned tables created in the new dataset.
        /// Partitioned tables will (by default) be automatically deleted this long after they are created,
        /// unless otherwise specified, such as by <see cref="CreateTableOptions.Expiration"/>.
        /// For partitioned tables, this values has priority over <see cref="DefaultTableExpiration"/>.
        /// </summary>
        public TimeSpan? DefaultPartitionExpiration { get; set; }

        /// <summary>
        /// Location to create the dataset in, such as "EU" or "US". See
        /// the Dataset resource documentation for all possible values. If this is not set, the
        /// client's <see cref="BigQueryClient.DefaultLocation">default location</see> will be used
        /// instead.
        /// </summary>
        /// <seealso cref="BigQueryClient.WithDefaultLocation(string)"/>
        public string Location { get; set; }

        /// <summary>
        /// The default encryption key for all tables in the dataset.
        /// Once this property is set, all newly-created tables in the dataset
        /// will have encryption key set to this value, unless otherwise specified,
        /// such as by <see cref="CreateTableOptions.EncryptionConfiguration"/>.
        /// </summary>
        public EncryptionConfiguration DefaultEncryptionConfiguration { get; set; }

        internal void ModifyRequest(Dataset dataset, InsertRequest request)
        {
            if (Description != null)
            {
                dataset.Description = Description;
            }
            if (FriendlyName != null)
            {
                dataset.FriendlyName = FriendlyName;
            }
            if (Location != null)
            {
                dataset.Location = Location;
            }
            if (DefaultTableExpiration != null)
            {
                dataset.DefaultTableExpirationMs = (long) DefaultTableExpiration.Value.TotalMilliseconds;
            }
            if (DefaultPartitionExpiration != null)
            {
                dataset.DefaultPartitionExpirationMs = (long) DefaultPartitionExpiration.Value.TotalMilliseconds;
            }
            if (DefaultEncryptionConfiguration != null)
            {
                dataset.DefaultEncryptionConfiguration = DefaultEncryptionConfiguration;
            }
        }
    }
}
