// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

namespace Google.Cloud.BigQuery.V2;

// Note: the numbers in this enum must match the ones in TablesResource.GetRequest.ViewEnum.

/// <summary>
/// Controls the data returned in a GetTable operation, specified in <see cref="GetTableOptions"/>.
/// </summary>
public enum TableView
{
    /// <summary>
    /// Includes basic table information including schema and partitioning specification.
    /// This view does not include storage statistics such as numRows or numBytes. This
    /// view is significantly more efficient and should be used to support high query
    /// rates.
    /// </summary>
    Basic = 0,

    /// <summary>
    /// Includes all table information, including storage statistics. It returns same
    /// information as <see cref="StorageStats"/> view, but may contain additional information in
    /// the future.
    /// </summary>
    Full = 1,

    /// <summary>
    /// Includes all information in the <see cref="Basic"/> view as well as storage statistics (numBytes,
    /// numLongTermBytes, numRows and lastModifiedTime).
    /// </summary>
    StorageStats = 2,
}
