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

using System;
using System.Globalization;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods for <c>System.DateTime</c> and <c>System.DateTimeOffset</c> for use with BigQuery.
    /// </summary>
    public static class BigQueryDateTimeExtensions
    {
        /// <summary>
        /// Returns the given date and time formatted as BigQuery expects date values to be formatted.
        /// </summary>
        /// <param name="value">The date/time value to extract the date from.</param>
        /// <returns>The date in yyyy-MM-dd format.</returns>
        public static string AsBigQueryDate(this DateTime value) =>
            value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

        /// <summary>
        /// Returns the given date and time formatted as BigQuery expects date values to be formatted.
        /// The "local" value of the <c>DateTimeOffset</c> is used; it is not converted to UTC.
        /// </summary>
        /// <param name="value">The date/time offset value to extract the date from.</param>
        /// <returns>The date in yyyy-MM-dd format.</returns>
        public static string AsBigQueryDate(this DateTimeOffset value) =>
            value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }
}
