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
    internal static class UrlV4SignerHelperExtensions
    {
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> s_empty =
                new ReadOnlyDictionary<string, IReadOnlyCollection<string>>(new Dictionary<string, IReadOnlyCollection<string>>());

        internal static IReadOnlyDictionary<string, IReadOnlyCollection<string>> AsReadOnly(
            this IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers) =>
            headers == null ? s_empty : new ReadOnlyDictionary<string, IReadOnlyCollection<string>>(
                headers.ToDictionary(
                    h => h.Key,
                    h => (IReadOnlyCollection<string>)h.Value.ToList().AsReadOnly()));

        internal static void AddHeader(this SortedDictionary<string, string> canonicalized, string key, string value)
        {
            if (key == null || value == null)
            {
                return;
            }
            var headerName = key.ToLowerInvariant();
            // Note: the comma-space separating here is because this is what HttpClient does.
            // Google Cloud Storage itself will just use commas if it receives multiple values for the same header name,
            // but HttpClient coalesces the values itself. This approach means that if the same request is made from .NET
            // with the signed URL, it will succeed - but it does mean that the signed URL won't be valid when used from
            // another platform that sends actual multiple values.
            var headerValue = UrlSigner.PrepareHeaderValue(value).Trim();
            if (canonicalized.TryGetValue(headerName, out var existingValue))
            {
                headerValue = $"{existingValue}, {headerValue}";
            }
            canonicalized[headerName] = headerValue;
        }

        internal static void AddHeaders(this SortedDictionary<string, string> canonicalized, IReadOnlyDictionary<string, IReadOnlyCollection<string>> headersToAdd)
        {
            if (headersToAdd == null)
            {
                return;
            }
            foreach (var pair in headersToAdd)
            {
                if (pair.Value == null)
                {
                    continue;
                }
                var headerName = pair.Key.ToLowerInvariant();
                // Note: the comma-space separating here is because this is what HttpClient does.
                // Google Cloud Storage itself will just use commas if it receives multiple values for the same header name,
                // but HttpClient coalesces the values itself. This approach means that if the same request is made from .NET
                // with the signed URL, it will succeed - but it does mean that the signed URL won't be valid when used from
                // another platform that sends actual multiple values.
                var value = string.Join(", ", pair.Value.Select(v => UrlSigner.PrepareHeaderValue(v))).Trim();
                if (canonicalized.TryGetValue(headerName, out var existingValue))
                {
                    value = $"{existingValue}, {value}";
                }
                canonicalized[headerName] = value;
            }
        }
    }
}
