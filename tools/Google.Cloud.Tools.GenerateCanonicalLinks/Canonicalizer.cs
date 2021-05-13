// Copyright 2021 Google LLC
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

using System.Linq;

namespace Google.Cloud.Tools.GenerateCanonicalLinks
{
    public static class Canonicalizer
    {
        /// <summary>
        /// Returns the canonical link for the given page
        /// </summary>
        /// <param name="package">The package in which the page occurs</param>
        /// <param name="page">The page URL relative to the root, e.g. api/Google.Cloud.SomeApi.V1.SomeType</param>
        /// <returns>The canonical DevSite URL</returns>
        public static string GetUrl(string package, string page)
        {
            // TODO: Implement this properly, including utility docs, non-reference docs etc.

            // Handle either just a package name, or a staging blob name.
            // TODO: Do we actually need the package name? Can we get everything from the page?
            var packageParts = package.Split('-');
            if (packageParts.Length > 2)
            {
                // Last-but one value is the package name, e.g. Google.Cloud.Speech.V1
                package = packageParts[^2];
            }

            // DevSite URLs don't have an extension
            if (page.EndsWith(".html"))
            {
                page = page[..^5];
            }

            // For now, just take the final segment.
            page = page.Split('/').Last();

            return $"https://cloud.google.com/dotnet/docs/reference/{package}/latest/{page}";
        }
    }
}
