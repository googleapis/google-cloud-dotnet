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
        }
    }
}
