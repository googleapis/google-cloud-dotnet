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
using Google.Api.Gax;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Helper method to build filter strings.
    /// </summary>
    public static class Filters
    {
        /// <summary>
        /// Creates a filter for a single label.
        /// </summary>
        /// <param name="name">The name of the label to filter on. Must not be null or empty.</param>
        /// <param name="value">The value for the label. May be null or empty.</param>
        /// <returns>A string of the form "labels.{name}:{value}" when <paramref name="value"/> is non-null and non-empty,
        /// or "labels.{name}" when <paramref name="value"/> is null.</returns>
        public static string FromLabel(string name, string value)
        {
            GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name));
            return string.IsNullOrEmpty(value) ? $"labels.{name}" : $"labels.{name}:{value}";
        }

        /// <summary>
        /// Creates a filter for the given labels.
        /// </summary>
        /// <remarks>See <see cref="FromLabel(string, string)"/> for the format of a single label; this method joins
        /// multiple labels together with spaces.</remarks>
        /// <param name="labels">The labels to filter by. Must not be null.</param>
        /// <returns>A filter for the given labels.</returns>
        public static string FromLabels(IDictionary<string, string> labels)
        {
            GaxPreconditions.CheckNotNull(labels, nameof(labels));
            return string.Join(" ", labels.Select(kvp => FromLabel(kvp.Key, kvp.Value)));
        }
    }
}
