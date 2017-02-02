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
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Cloud.Translation.V2.LanguageCodeGenerator
{
    /// <summary>
    /// Somewhat "quick and dirty" program to list the languages supported by Translate
    /// and generate the body of LanguageCodes.cs in the main client library.
    /// Only the nested classes are generated - it's expected that they'll
    /// periodically be edited in.
    /// </summary>
    public class Program
    {
        private static readonly Regex NonAsciiLetters = new Regex($"[^a-zA-Z]");

        static void Main()
        {
            var client = TranslationClient.Create();
            var languages = client.ListLanguages(LanguageCodes.English).OrderBy(x => x.Code).ToList();

            using (var writer = File.CreateText("language-codes.tmp.txt"))
            {
                writer.WriteLine($"// Generated {DateTime.UtcNow:yyyy-MM-dd}; {languages.Count} entries.");
                writer.WriteLine();

                foreach (var language in languages)
                {
                    writer.WriteLine($"/// <summary>Language code for {language.Name}</summary>");
                    writer.WriteLine($"public const string {MakeIdentifier(language.Name)} = \"{language.Code}\";");
                    writer.WriteLine();
                }
            }
            Console.WriteLine($"Generated file with {languages.Count} entries");
        }

        private static string MakeIdentifier(string name)
        {
            var normalized = name.Normalize(NormalizationForm.FormKD);
            return NonAsciiLetters.Replace(normalized, "");
        }
    }
}
