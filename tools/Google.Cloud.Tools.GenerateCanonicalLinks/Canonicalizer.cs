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

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.GenerateCanonicalLinks
{
    public static class Canonicalizer
    {
        public const string CloudSitePrefix = "https://cloud.google.com/dotnet/docs/reference/";

        /// <summary>
        /// "Packages" which are on DevSite to support client libraries. (Often these packages actually
        /// contain the types from multiple NuGet packages.)
        /// </summary>
        private static readonly ISet<string> DevSiteSupportPackages = new HashSet<string>
        {
            "Grpc.Core",
            "Google.Protobuf",
            "Google.Api.Gax",
            "Google.Api.CommonProtos",
            "Google.Apis"
        };

        // Note: list rather than a dictionary, as order is important.
        private static readonly List<(string prefix, string package)> Prefixes = new List<(string, string)>
        {
            { ("Grpc", "Grpc.Core") },
            { ("Google.Protobuf", "Google.Protobuf") },
            { ("Google.Api.Gax", "Google.Api.Gax") },
            // Google.Apis, Google.Apis.Auth and Google.Apis.Core contain some types in the Google namespace and some in
            // the Google.Apis namespace, then some sub-namespaces. We want to be able to distinguish between
            // those and things like Google.Apis.Storage.V1.
            { ("Google.ApplicationContext", "Google.Apis") },
            { ("Google.GoogleApiException", "Google.Apis") },
            { ("Google.Apis.Auth", "Google.Apis") },
            { ("Google.Apis.Discovery", "Google.Apis") },
            { ("Google.Apis.Download", "Google.Apis") },
            { ("Google.Apis.ETagAction", "Google.Apis") },
            { ("Google.Apis.ISerializer", "Google.Apis") },
            { ("Google.Apis.Http", "Google.Apis") },
            { ("Google.Apis.Json", "Google.Apis") },
            { ("Google.Apis.Logging", "Google.Apis") },
            { ("Google.Apis.Requests", "Google.Apis") },
            { ("Google.Apis.Services", "Google.Apis") },
            { ("Google.Apis.Upload", "Google.Apis") },
            { ("Google.Apis.Testing", "Google.Apis") },
            { ("Google.Apis.Util", "Google.Apis") },
            { ("Google.Cloud.Diagnostics.Common", "Google.Cloud.Diagnostics.Common") },
            { ("Google.Cloud.OsLogin.Common", "Google.Cloud.OsLogin.Common") },
            { ("Google.Cloud.DevTools.Source", "Google.Cloud.DevTools.Common") },
            { ("Google.LongRunning", "Google.LongRunning") },
            // To avoid using putting V1 protos in Google.Cloud.Firestore.
            { ("Google.Cloud.Firestore.V1", "Google.Cloud.Firestore.V1") },

            // Google.Api.CommonProtos also contains a bunch of types in various namespaces
            { ("Google.Api", "Google.Api.CommonProtos") },
            { ("Google.Rpc", "Google.Api.CommonProtos") },
            { ("Google.Type", "Google.Api.CommonProtos") },
        };

        /// <summary>
        /// Returns the canonical link for the given page
        /// </summary>
        /// <param name="package">The package in which the page occurs</param>
        /// <param name="page">The page URL relative to the root, e.g. api/Google.Cloud.SomeApi.V1.SomeType</param>
        /// <returns>The canonical DevSite URL, or null if the page is not on DevSite.</returns>
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

            // DevSite doesn't have toc.html files
            if (page == "api/toc.html")
            {
                return null;
            }

            // DevSite URLs don't have an extension
            if (page.EndsWith(".html"))
            {
                page = page[..^5];
            }

            // DevSite URLs are flattened - user guides are mixed with API reference docs
            page = page.Split('/').Last();

            package = MaybeAdjustPackage(package, page);

            // DevSite doesn't have REST-based libraries from https://github.com/googleapis/google-api-dotnet-client
            // other than Google.Apis, Google.Apis.Core and Google.Apis.Auth, all of which are mapped
            // to Google.Apis as the package (as that's the DevSite "bundle of packages").
            if (package.StartsWith("Google.Apis") && package != "Google.Apis")
            {
                return null;
            }

            return ApiMetadata.IsCloudPackage(package) || DevSiteSupportPackages.Contains(package)
                ? $"{CloudSitePrefix}{package}/latest/{page}"
                : null;
        }

        private static string MaybeAdjustPackage(string package, string page)
        {
            // We've hardcoded a bunch of packages which are hard to handle otherwise.
            var overriddenPackage = Prefixes.FirstOrDefault(pair => page.StartsWith(pair.prefix + ".") || page == pair.prefix).package;
            if (overriddenPackage is object)
            {
                return overriddenPackage;
            }
            // If the page looks like it's genuinely in the package, that's probably fine.
            if (page.StartsWith(package))
            {
                return package;
            }

            // May be a guide, may be a type from a different package.
            var parts = page.Split('.');
            // Single-part pages are always guides.
            if (parts.Length == 1)
            {
                return package;
            }

            // Hmm. Looks like it's a reference from the actual package to somewhere else that we haven't configured. That's awkward.
            // For API protos, we can effectively guess the package by finding the first namespace element that starts with "V" and then a digit, or "Type".
            var finalPartOfPackage = parts.FirstOrDefault(part => part == "Type" || Regex.IsMatch(part, @"V[\d].*"));
            if (finalPartOfPackage is null)
            {
                throw new ArgumentException($"Unable to determine real package for page {page} in package {package}");
            }
            int packageParts = Array.IndexOf(parts, finalPartOfPackage) + 1;
            return string.Join(".", parts.Take(packageParts));
        }
    }
}
