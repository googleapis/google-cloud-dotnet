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

using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Google.Cloud.Speech.V1.LanguageCodeGenerator
{
    /// <summary>
    /// Somewhat "quick and dirty" program to parse the table displayed on
    /// https://cloud.google.com/speech/docs/languages (although data is actually
    /// populated from https://cloud.google.com/speech-to-text/docs/common/languages.json) and generate
    /// the body of LanguageCodes.cs in the main client library.
    /// Only the nested classes are generated - it's expected that they'll
    /// periodically be edited in.
    /// </summary>
    public class Program
    {
        private static readonly Regex NonAsciiLetters = new Regex($"[^a-zA-Z]");

        static async Task Main()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://cloud.google.com/speech-to-text/docs/common/languages.json");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            JArray array = JArray.Parse(json);
            // We see multiple entries per language, but only based on things we don't care about.
            var entries = array.Skip(1).Cast<JArray>().Select(LanguageEntry.FromJArray).Distinct().ToList();

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

        private class LanguageEntry : IEquatable<LanguageEntry>
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

            // The JSON returns entries as an array of strings. Only the first two are relevant to us though:
            // - Name (language and region)
            // - BCP-47 code
            public static LanguageEntry FromJArray(JArray array)
            {
                string name = (string) array[0];
                string code = (string) array[1];
                var match = LanguageRegionPattern.Match(name);
                if (!match.Success)
                {
                    throw new Exception($"Language/region '{name}' invalid");
                }
                return new LanguageEntry(code, match.Groups[1].Value, match.Groups[2].Value);
            }

            public override bool Equals(object obj) => Equals(obj as LanguageEntry);

            public override int GetHashCode() => (Code, Language, Region).GetHashCode();

            public bool Equals(LanguageEntry other) =>
                (Code, Language, Region) == (other.Code, other.Language, other.Region);
        }
    }
}
