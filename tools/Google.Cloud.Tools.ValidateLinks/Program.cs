// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Cloud.Tools.Common;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using TidyManaged;

namespace Google.Cloud.Tools.ValidateLinks
{
    /// <summary>
    /// Console app to validate that all relative links (just anchors for the moment) are valid.
    /// </summary>
    public class Program
    {
        private static int Main(string[] args)
        {
            try
            {
                return MainImpl(args);
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return 1;
            }
        }

        private static int MainImpl(string[] args)
        {
            if (args.Length != 1)
            {
                throw new UserErrorException("Please specify (just) the directory at the root of the generated docs");
            }

            string dir = args[0];

            if (!Directory.Exists(dir))
            {
                throw new UserErrorException($"No such directory: ${dir}");
            }

            bool allOkay = true;
            foreach (var file in Directory.EnumerateFiles(dir, "*.html", SearchOption.AllDirectories))
            {
                allOkay &= Validate(file, dir);
            }

            return allOkay ? 0 : 1;
        }

        private static bool Validate(string file, string rootDirectory)
        {
            var stream = new MemoryStream();
            using (var htmlDoc = Document.FromFile(file))
            {
                htmlDoc.OutputXml = true;
                // FIXME! (Probably a docfx issue...)
                htmlDoc.NewInlineTags = "see,example,returns,seealso";
                htmlDoc.ShowWarnings = false;
                htmlDoc.ShowInfo = false;
                htmlDoc.CleanAndRepair();
                htmlDoc.Save(stream);
            }

            stream.Position = 0;
            var doc = XDocument.Load(stream);
            var relativeHrefs = doc.Descendants("a")
                .Select(a => (string) a.Attribute("href"))
                .Where(href => href != null)
                .Select(href => href.Split('#')[0])
                .Where(href => href != "")
                .Where(href => !href.StartsWith("http") && !href.StartsWith("https"));

            var directory = Path.GetDirectoryName(Path.GetFullPath(file));

            var brokenHrefs = relativeHrefs.Where(href => !File.Exists(Path.Combine(directory, href))).GroupBy(x => x).ToList();
            if (brokenHrefs.Count == 0)
            {
                return true;
            }

            // Report relative filenames, for brevity. (This may not be the best way of doing this,
            // but it seems to work and is simple...)
            if (file.StartsWith(rootDirectory))
            {
                file = file.Substring(rootDirectory.Length).TrimStart('/', '\\');
            }
            Console.WriteLine($"Invalid relative hrefs in {file}:");
            foreach (var href in brokenHrefs)
            {
                Console.WriteLine($"  {href.Key} ({href.Count()})");
            }

            return false;
        }
    }
}
