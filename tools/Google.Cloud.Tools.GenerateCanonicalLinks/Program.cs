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
using System.IO;

namespace Google.Cloud.Tools.GenerateCanonicalLinks
{
    /// <summary>
    /// Tool to canonicalize links in googleapis.dev.
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            foreach (var api in args)
            {
                Canonicalize(api);
            }
        }

        private static void Canonicalize(string api)
        {
            if (api == "root")
            {
                return;
            }
            var layout = DirectoryLayout.ForApi(api);
            var site = Path.Combine(layout.DocsOutputDirectory, "site");

            foreach (var page in Directory.GetFiles(site, "*.html", new EnumerationOptions { RecurseSubdirectories = true }))
            {
                var relative = Path.GetRelativePath(site, page).Replace('\\', '/');

                var canonicalLink = Canonicalizer.GetUrl(api, relative);
                // If the page isn't on CloudSite, skip it.
                if (canonicalLink is null)
                {
                    continue;
                }

                var canonicalElement = $"<link rel=\"canonical\" href=\"{canonicalLink}\" />";

                var html = File.ReadAllText(page);
                html = html.Replace("<head>", $"<head>{canonicalElement}");
                File.WriteAllText(page, html);
            }
        }
    }
}
