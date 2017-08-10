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

using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2.GenerateOverloads
{
    /// <summary>
    /// Internal extensions to List{T} to make it easier to construct parameter lists.
    /// </summary>
    internal static class ListExtensions
    {
        public static void Add<T>(this List<T> list, IEnumerable<T> items) => list.AddRange(items);

        /// <summary>
        /// Conditionally adds an item to the list
        /// </summary>
        public static void Add<T>(this List<T> list, T item, bool condition)
        {
            if (condition)
            {
                list.Add(item);
            }
        }
    }
}
