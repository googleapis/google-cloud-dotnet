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
using Google.Cloud.Tools.GenerateCanonicalLinks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.RewriteGitHubPages
{
    class Program
    {
        private static Dictionary<string, string> HardCodedEntries = new Dictionary<string, string>
        {
            { "index.html", "https://cloud.google.com/dotnet/docs/reference" },
            { "docs/index.html", "https://cloud.google.com/dotnet/docs/reference" },
            { "docs/toc.html", "https://cloud.google.com/dotnet/docs/reference/help/getting-started" },
            { "docs/major-version.html", "https://cloud.google.com/dotnet/docs/reference" },
            { "docs/faq.html", "https://cloud.google.com/dotnet/docs/reference/help/troubleshooting" },
        };

        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Argument: <gh-pages directory>");
                return;
            }

            string root = args[0];

            var pages = Directory.EnumerateFiles(root, "*.html", new EnumerationOptions { RecurseSubdirectories = true });
            foreach (var page in pages)
            {
                var relative = Path.GetRelativePath(root, page);
                var uri = GenerateRedirectUri(relative);
                var content = GenerateRedirectPage(uri);
                File.WriteAllText(page, content);
            }
        }

        private static string GenerateRedirectUri(string relative)
        {
            relative = relative.Replace('\\', '/');
            var bits = relative.Split('/');
            if (HardCodedEntries.TryGetValue(relative, out var uri))
            {
                return uri;
            }
            if (bits.Length < 3 || bits.Length > 4 || bits[0] != "docs")
            {
                throw new Exception($"Don't know how to handle {relative}");
            }

            string api = bits[1];
            // Hard-code this... it's delisted anyway, but it breaks the link canonicalizer.
            if (api == "Google.Cloud.EntityFrameworkCore.Spanner")
            {
                return "https://cloud.google.com/dotnet/docs/reference";
            }

            string apiRelative = string.Join("/", bits.Skip(2));

            // If we have a canonical link, use it
            var canonical = Canonicalizer.GetUrl(api, apiRelative);
            if (canonical is string)
            {
                return canonical;
            }

            if (ApiMetadata.IsCloudPackage(api))
            {
                // Top-level TOC => getting started
                if (apiRelative == "toc.html")
                {
                    return $"https://cloud.google.com/dotnet/docs/reference/{api}/latest";
                }
                // API-level TOC => all types
                if (apiRelative == "api/toc.html")
                {
                    return $"https://cloud.google.com/dotnet/docs/reference/{api}/latest/{api}";
                }

                // No canonical link, and not a TOC, so we're probably in something like the Storage REST API... fall through.
            }

            string baseUri = $"https://googleapis.dev/dotnet/{api}/latest";

            // Top-level TOC => index
            if (apiRelative == "toc.html")
            {
                return $"{baseUri}/";
            }
            // API-level TOC => all types
            if (apiRelative == "api/toc.html")
            {
                return $"{baseUri}/api/{api}.html";
            }

            return $"{baseUri}/{apiRelative}";
        }

        private static string GenerateRedirectPage(string uri) => $@"
<html>
  <head>
    <meta http-equiv=""refresh"" content=""0; URL='{uri}'"" />
  </head>
  <body>
    <h1>Page moved</h1>
    <p>If your browser does not redirect you automatically, please visit <a href=""{uri}"">{uri}</a>.</p>
  <body>
</html>";
    }
}
