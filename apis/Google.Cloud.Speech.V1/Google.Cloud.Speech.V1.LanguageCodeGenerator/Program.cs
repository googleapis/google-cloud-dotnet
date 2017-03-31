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

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Google.Cloud.Speech.V1.LanguageCodeGenerator
{
    /// <summary>
    /// Somewhat "quick and dirty" program to parse the table on
    /// https://cloud.google.com/speech/docs/languages and generate
    /// the body of LanguageCodes.cs in the main client library.
    /// Only the nested classes are generated - it's expected that they'll
    /// periodically be edited in.
    /// </summary>
    public class Program
    {
        private static readonly Regex NonAsciiLetters = new Regex($"[^a-zA-Z]");

        static void Main()
        {
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;

            var html = client.DownloadString("https://cloud.google.com/speech/docs/languages");
            // Yes, we're assuming a single table element. It'll be very obvious if this assumption
            // is violated, at which point we can become smarter.
            int tableStart = html.IndexOf("<table>");
            int tableEnd = html.IndexOf("</table>");
            string table = html.Substring(tableStart, tableEnd - tableStart + "</table>".Length);

            var doc = XDocument.Parse(table);
            var entries = doc.Root.Element("tbody").Elements("tr").Select(LanguageEntry.FromXElement).ToList();

            var languages = entries.GroupBy(code => code.Language).OrderBy(g => g.Key);

            using (var writer = File.CreateText("language-codes.tmp.txt"))
            {
                writer.WriteLine($"// Generated {DateTime.UtcNow:yyyy-MM-dd}; {entries.Count} entries.");
                writer.WriteLine();

                foreach (var language in languages)
                {
                    writer.WriteLine($"/// <summary>Language codes for {language.Key}.</summary>");
                    writer.WriteLine($"public static class {MakeIdentifier(language.Key)}");
                    writer.WriteLine("{");
                    foreach (var item in language.OrderBy(c => c.Region))
                    {
                        writer.WriteLine($"    /// <summary>Language code for {item.Language} ({item.Region})</summary>");
                        writer.WriteLine($"    public const string {MakeIdentifier(item.Region)} = \"{item.Code}\";");
                        writer.WriteLine();
                    }
                    writer.WriteLine("}");
                    writer.WriteLine();
                }
            }
            Console.WriteLine($"Generated file with {entries.Count} entries");
        }

        private static string MakeIdentifier(string name)
        {
            var normalized = name.Normalize(NormalizationForm.FormKD);
            return NonAsciiLetters.Replace(normalized, "");
        }

        private class LanguageEntry
        {
            private static readonly Regex LanguageRegionPattern = new Regex(@"(.+) \((.+)\)");

            public string Code { get; }
            public string Language { get; }
            public string Region { get; }

            private LanguageEntry(string code, string language, string region)
            {
                Code = code;
                Language = language;
                Region = region;
            }

            public static LanguageEntry FromXElement(XElement element)
            {
                string code = element.Elements().ElementAt(1).Value;
                string languageRegion = element.Elements().ElementAt(2).Value;
                var match = LanguageRegionPattern.Match(languageRegion);
                if (!match.Success)
                {
                    throw new Exception($"Language/region '{languageRegion}' invalid");
                }
                return new LanguageEntry(code, match.Groups[1].Value, match.Groups[2].Value);
            }
        }
    }
}
