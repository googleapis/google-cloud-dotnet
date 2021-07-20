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

namespace Google.Cloud.Tools.ApiIndex.V1
{
    /// <summary>
    /// The service directory, which is a very slightly different form of the API Index.
    /// TODO: Update consumer code to use the API index directly, with an extension methods to
    /// derive the C# namespace.
    /// </summary>
    public class ServiceDirectory
    {
        public List<Service> Services { get; set; }

        /// <summary>
        /// Loads the service directory from service config files in the specified directory.
        /// </summary>
        public static ServiceDirectory LoadFromGoogleApis(string googleApisRoot)
        {
            Console.WriteLine(googleApisRoot);
            var json = File.ReadAllText(Path.Combine(googleApisRoot, "api-index-v1.json"));
            var index = Index.Parser.ParseJson(json);
            return new ServiceDirectory
            {
                Services = index.Apis.Select(api => Service.FromApi(api)).OrderBy(config => config.ServiceDirectory, StringComparer.Ordinal).ToList()
            };
        }

        // Note: nested class to avoid a conflict with the API Index Service class.
        public class Service
        {
            private static readonly Regex StableVersionPattern = new Regex(@"^v[\d]+$");

            public string ServiceDirectory { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string ServiceConfigFile { get; set; }
            public string Version { get; set; }
            public string PackageFromDirectory { get; set; }
            public string PackageFromProtos { get; set; }
            public List<string> ImportDirectories { get; set; }
            public bool Stable { get; set; }

            /// <summary>
            /// The C# namespace, either inferred from the package, or specified with a csharp_namespace option.
            /// </summary>
            public string CSharpNamespaceFromProtos { get; set; }

            public static Service FromApi(Api api) => new Service
            {
                ServiceDirectory = api.Directory,
                Name = api.HostName,
                Title = api.Title,
                Description = api.Description,
                // Skip ServiceConfigFile
                Version = api.Version,
                PackageFromDirectory = api.Directory.Replace('/', '.'),
                // Note: this isn't actually validated at the moment in the index generator
                PackageFromProtos = api.Id,
                ImportDirectories = api.ImportDirectories.ToList(),
                Stable = StableVersionPattern.IsMatch(api.Version),
                CSharpNamespaceFromProtos = DeriveCSharpNamespace(api)
            };

            private static string DeriveCSharpNamespace(Api api)
            {
                // TODO: Maybe record the total number of protos separately in the API index. This isn't ideal,
                // although realistically every proto will have a java_package option.
                var totalFiles = api.Options.Count == 0 ? 0 : api.Options.Max(pair => pair.Value.ValueCounts.Sum(pair => pair.Value));

                var options = api.Options.GetValueOrDefault("csharp_namespace") ?? new Api.Types.OptionValues();

                var allNamespaces = new HashSet<string>(options.ValueCounts.Keys);

                var optionCount = options.ValueCounts.Sum(pair => pair.Value);
                if (options.ValueCounts.Sum(pair => pair.Value)  != totalFiles)
                {
                    var namespaceFromProtoPackage = string.Join('.', api.Id.Split('.').Select(bit => ToUpperCamelCase(bit)));
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
}
