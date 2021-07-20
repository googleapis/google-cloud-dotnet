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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

// Augmentations to the API index generated classes.

namespace Google.Cloud.Tools.ApiIndex.V1
{
    public partial class Index
    {
        /// <summary>
        /// Loads the API index from the JSON file in googleapis.
        /// </summary>
        public static Index LoadFromGoogleApis(string googleApisRoot)
        {
            Console.WriteLine(googleApisRoot);
            var json = File.ReadAllText(Path.Combine(googleApisRoot, "api-index-v1.json"));
            return Parser.ParseJson(json);
        }
    }

    public partial class Api
    {
        private static readonly Regex StableVersionPattern = new Regex(@"^v[\d]+$");

        public bool Stable => StableVersionPattern.IsMatch(Version);

        public string DeriveCSharpNamespace()
        {
            // TODO: Maybe record the total number of protos separately in the API index. This isn't ideal,
            // although realistically every proto will have a java_package option.
            var totalFiles = Options.Count == 0 ? 0 : Options.Max(pair => pair.Value.ValueCounts.Sum(pair => pair.Value));

            var options = Options.GetValueOrDefault("csharp_namespace") ?? new Api.Types.OptionValues();

            var allNamespaces = new HashSet<string>(options.ValueCounts.Keys);

            var optionCount = options.ValueCounts.Sum(pair => pair.Value);
            if (options.ValueCounts.Sum(pair => pair.Value) != totalFiles)
            {
                var namespaceFromProtoPackage = string.Join('.', Id.Split('.').Select(bit => ToUpperCamelCase(bit)));
                allNamespaces.Add(namespaceFromProtoPackage);
            }

            return allNamespaces.Count == 1
                ? allNamespaces.First()
                : $"<AMBIGUOUS: {string.Join(",", allNamespaces.OrderBy(x => x, StringComparer.Ordinal))}>";
        }

        // Copied from https://github.com/googleapis/gapic-generator-csharp/blob/master/Google.Api.Generator/Utils/SystemExtensions.cs.
        // We can move it somewhere more common if we need to...
        private static char MaybeForceCase(char c, bool? toUpper) =>
            toUpper is bool upper ? upper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c) : c;

        private static string Camelizer(string s, bool firstUpper, bool forceAllChars) =>
            s.Aggregate((upper: (bool?)firstUpper, prev: '\0', sb: new StringBuilder()), (acc, c) =>
                !char.IsLetterOrDigit(c) ?
                    (acc.sb.Length > 0 ? true : firstUpper, c, acc.sb) :
                    (char.IsDigit(c) ? true : forceAllChars ? (bool?)false : null, c,
                        acc.sb.Append(MaybeForceCase(c, char.IsLower(acc.prev) && char.IsUpper(c) ? true : acc.upper))),
                acc => acc.sb.ToString());

        private static string ToUpperCamelCase(string input, bool forceAllChars = false) => Camelizer(input, firstUpper: true, forceAllChars);
    }
}
