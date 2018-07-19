// Copyright 2018 Google LLC
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

using System;
using System.Globalization;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Utility methods for generating IDs
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Generates a GUID-based hex ID. The default is 36 characters long, lower-case, with dashes
        /// as separators (with a pattern of 8-4-4-4-12 characters).
        /// </summary>
        /// <param name="prefix">An optional prefix to prepend to the generated value.</param>
        /// <param name="suffix">An optional suffix to append to the generated value.</param>
        /// <param name="separator">An optional separator to use instead of "-"</param>
        /// <param name="maxLength">The maximum overall length of the generated ID</param>
        /// <returns>The generated ID</returns>
        public static string FromGuid(string prefix = "", string suffix = "", bool upperCase = false, string separator = null, int maxLength = int.MaxValue)
        {
            string id = Guid.NewGuid().ToString();
            if (separator != null)
            {
                id = id.Replace("-", separator);
            }
            if (upperCase)
            {
                id = id.ToUpperInvariant();
            }
            id = prefix + id + suffix;
            if (maxLength < id.Length)
            {
                id = id.Substring(0, maxLength);
            }
            return id;
        }

        /// <summary>
        /// Generates an ID based on the current date and time (in UTC).
        /// </summary>
        /// <param name="prefix">An optional prefix to prepend to the generated value.</param>
        /// <param name="suffix">An optional suffix to append to the generated value.</param>
        /// <param name="pattern">The text pattern to use when formatting the date and time; defaults to "yyyyMMdd't'HHmmssfff"</param>
        /// <returns></returns>
        public static string FromDateTime(string prefix = "", string suffix = "", string pattern = "yyyyMMdd't'HHmmssfff") =>
            prefix + DateTime.UtcNow.ToString(pattern, CultureInfo.InvariantCulture) + suffix;
    }
}
