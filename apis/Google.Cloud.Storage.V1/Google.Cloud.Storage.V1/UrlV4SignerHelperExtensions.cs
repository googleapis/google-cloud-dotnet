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

using System;
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
        internal static IReadOnlyDictionary<string, IReadOnlyCollection<string>> QueryAsReadOnly(this Uri uri)
        {
            // Query property is only valid for absolute Uris.
            // It will include the leading question mark.
            if (uri == null || !uri.IsAbsoluteUri || string.IsNullOrEmpty(uri.Query) || uri.Query.Length == 1)
            {
                return s_empty;
            }
            string noQuestionMark = uri.Query.Substring(1);
            // The query will be encoded so we can safely split on '&' and '='.
            string[] entries = noQuestionMark.Split('&');
            Dictionary<string, List<string>> queryDictionary = new Dictionary<string, List<string>>();
            foreach (string entry in entries)
            {
                string[] keyAndValue = entry.Split('=');
                if (!queryDictionary.TryGetValue(keyAndValue[0], out List<string> values))
                {
                    values = new List<string>();
                    queryDictionary.Add(keyAndValue[0], values);
                }
                values.Add(keyAndValue[1]);
            }
            return new ReadOnlyDictionary<string, IReadOnlyCollection<string>>(
                queryDictionary.ToDictionary(pair => pair.Key, pair => (IReadOnlyCollection<string>)pair.Value.AsReadOnly()));
        }

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
            var headerValue = UrlSigner.PrepareHeaderValue(value, true).Trim();
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
                var value = string.Join(", ", pair.Value.Select(v => UrlSigner.PrepareHeaderValue(v, true))).Trim();
                if (canonicalized.TryGetValue(headerName, out var existingValue))
                {
                    value = $"{existingValue}, {value}";
                }
                canonicalized[headerName] = value;
            }
        }

        internal static void AddQueryParameter(this SortedSet<string> canonicalized, string key, string value)
        {
            if (key == null)
            {
                return;
            }
            key = Uri.EscapeDataString(key);
            value = Uri.EscapeDataString(value ?? string.Empty);
            canonicalized.Add($"{key}={value}");
        }

        internal static void AddQueryParameters(this SortedSet<string> canonicalized, IReadOnlyDictionary<string, IReadOnlyCollection<string>> paramsToAdd)
        {
            if (paramsToAdd == null)
            {
                return;
            }
            foreach (var parameters in paramsToAdd)
            {
                foreach (var parameter in parameters.Value)
                {
                    canonicalized.AddQueryParameter(parameters.Key, parameter);
                }
            }
        }
    }
}
