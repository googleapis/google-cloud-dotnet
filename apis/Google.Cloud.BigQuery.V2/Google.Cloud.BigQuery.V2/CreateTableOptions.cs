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
using static Google.Apis.Bigquery.v2.TablesResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateTable</c> operations.
    /// </summary>
    public sealed class CreateTableOptions
    {
        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

        // TODO: Find out why both of these fields exist. What's the difference?

        /// <summary>
        /// A descriptive name for the table being created.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// A user-friendly description of the table being created.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The expiration time of this table. If this is not set and the dataset does not have a default
        /// expiration period, the table will persist until it is deleted.
        /// </summary>
        public DateTimeOffset? Expiration { get; set; }

        /// <summary>
        /// The time partitioning for the table. See <see cref="TimePartition"/> to create instances of <see cref="TimePartitioning"/>.
        /// </summary>
        public TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// The external data configuration, if the table should be created to use external data.
        /// </summary>
        public ExternalDataConfiguration ExternalDataConfiguration { get; set; }

        /// <summary>
        /// The view definition, if the table should be configured as a view.
        /// </summary>
        public ViewDefinition View { get; set; }

        /// <summary>
        /// The encryption configuration to apply to the created table, if any.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// The clustering to apply to the created table, if any.
        /// </summary>
        public Clustering Clustering { get; set; }

        internal void ModifyRequest(Table table, InsertRequest request)
        {
            if (Description != null)
            {
                table.Description = Description;
            }
            if (FriendlyName != null)
            {
                table.FriendlyName = FriendlyName;
            }
            if (Expiration != null)
            {
                table.ExpirationTime = (long) (Expiration.Value - UnixEpoch).TotalMilliseconds;
            }
            // TODO: There's currently no way of forcing table.TimePartitioning to be set to null. Not a problem at the moment,
            // but we may want a sentinel value at some point.
            if (TimePartitioning != null)
            {
                table.TimePartitioning = TimePartitioning;
            }
            if (ExternalDataConfiguration != null && View != null)
            {
                throw new ArgumentException($"Cannot specify both {nameof(ExternalDataConfiguration)} and {nameof(View)}");
            }
            if (ExternalDataConfiguration != null)
            {
                table.ExternalDataConfiguration = ExternalDataConfiguration;
            }
            if (View != null)
            {
                table.View = View;
            }
            if (EncryptionConfiguration != null)
            {
                table.EncryptionConfiguration = EncryptionConfiguration;
            }
            if (Clustering != null)
            {
                table.Clustering = Clustering;
            }
        }
    }
}
