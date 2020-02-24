// Copyright 2020 Google LLC
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

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Google.Cloud.Storage.V1
{
    internal static class HeadersExtensions
    {
        internal static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> s_empty =
                new ReadOnlyDictionary<string, IReadOnlyCollection<string>>(new Dictionary<string, IReadOnlyCollection<string>>());

        internal static IReadOnlyDictionary<string, IReadOnlyCollection<string>> AsReadOnly(
            this IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers) =>
            headers == null ? s_empty : new ReadOnlyDictionary<string, IReadOnlyCollection<string>>(
                headers.ToDictionary(
                    h => h.Key,
                    h => (IReadOnlyCollection<string>)h.Value.ToList().AsReadOnly()));
    }
}
