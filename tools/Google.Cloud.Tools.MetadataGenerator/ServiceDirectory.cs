// Copyright 2020 Google LLC
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
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.MetadataGenerator
{
    /// <summary>
    /// The service directory, in a ready-to-serialize form.
    /// </summary>
    public class ServiceDirectory
    {
        private static readonly Regex ServiceVersionPattern = new Regex(@"^v\d+.*");
        public List<Service> Services { get; set; }

        internal static ServiceDirectory FromServiceConfigs(string googleapisRoot, IEnumerable<ServiceConfig> configs)
        {
            return new ServiceDirectory { Services = configs.Select(config => Service.FromServiceConfig(googleapisRoot, config)).ToList() };
        }

        /// <summary>
        /// Loads the service directory from service config files in the "googleapis"
        /// directory under the root layout.
        /// </summary>
        public static ServiceDirectory LoadFromGoogleapis()
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            var googleapisRoot = Path.Combine(root, "googleapis");
            return LoadFromGoogleapis(googleapisRoot);
        }

        /// <summary>
        /// Loads the service directory from service config files in the specified directory.
        /// </summary>
        public static ServiceDirectory LoadFromGoogleapis(string googleApisRoot)
        {
            var configs = LoadServiceConfigsRecursively(googleApisRoot);
            return FromServiceConfigs(googleApisRoot, configs);

            IReadOnlyList<ServiceConfig> LoadServiceConfigsRecursively(string directory)
            {
                var configs = new List<ServiceConfig>();
                // Only load service config files from versioned directories (e.g. "google/spanner/v1")
                if (ServiceVersionPattern.IsMatch(Path.GetFileName(directory)))
                {
                    var configsInDirectory = Directory.GetFiles(directory, "*.yaml")
                        .Select(ServiceConfig.TryLoadFile)
                        .Where(config => config != null);
                    configs.AddRange(configsInDirectory);
                }

                foreach (var subdir in Directory.GetDirectories(directory))
                {
                    configs.AddRange(LoadServiceConfigsRecursively(subdir));
                }
                return configs;
            }
        }
    }

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

        public static Service FromServiceConfig(string googleapisRoot, ServiceConfig config)
        {
            string relativeFile = Path.GetRelativePath(googleapisRoot, config.File).Replace('\\', '/'); // e.g. google/spanner/v1/spanner_v1.yaml
            string relativeDirectory = Path.GetDirectoryName(relativeFile).Replace('\\', '/');          // e.g. google/spanner/v1
            string version = Path.GetFileName(relativeDirectory);                                       // e.g. v1
            var packageFromDirectory = relativeDirectory.Replace('/', '.');                             // e.g. google.spanner.v1

            var protos = Directory.GetFiles(Path.GetDirectoryName(config.File), "*.proto")
                .OrderBy(f => f, StringComparer.Ordinal)
                .Select(ProtoFileSummary.Load)
                .ToList();

            var distinctPackagesFromProtos = protos.Select(proto => proto.Package).Distinct().Where(p => p is object).ToList();
            var packageFromProtos = distinctPackagesFromProtos.Count switch
            {
                0 => "<UNKNOWN - NO PROTOS WITH PACKAGES>",
                1 => distinctPackagesFromProtos[0],
                _ => $"<AMBIGUOUS: {string.Join(", ", distinctPackagesFromProtos)}>"
            };

            var distinctNamespacesFromProtos = protos.Select(proto => proto.InferredCSharpNamepace).Distinct().Where(p => p is object).ToList();
            var namespaceFromProtos = distinctNamespacesFromProtos.Count switch
            {
                0 => "<UNKNOWN - NO PROTOS WITH NAMESPACES/PACKAGES>",
                1 => distinctNamespacesFromProtos[0],
                _ => $"<AMBIGUOUS: {string.Join(", ", distinctNamespacesFromProtos)}>"
            };

            return new Service
            {
                PackageFromDirectory = packageFromDirectory,
                PackageFromProtos = packageFromProtos,
                ImportDirectories = protos.SelectMany(p => p.ImportDirectories).Distinct().OrderBy(import => import).ToList(),
                Version = version,
                ServiceConfigFile = relativeFile,
                ServiceDirectory = relativeDirectory,
                Name = config.Name,
                Title = config.Title,
                Description = config.Documentation?.Summary?.Replace('\n', ' ') ?? "<UNKNOWN - NO SERVICE CONFIG DOCUMENTATION SUMMARY>",
                Stable = StableVersionPattern.IsMatch(version),
                CSharpNamespaceFromProtos = namespaceFromProtos
            };
        }

        public class ProtoFileSummary
        {
            private static readonly HashSet<string> LibraryOptions = new HashSet<string>
            {
                "csharp_namespace",
                "go_package",
                "java_package",
                "php_namespace",
                "ruby_package"
            };
            private static readonly char[] ImportAndOptionValueTrimChars = { ' ', '"', ';'};

            public string Package { get; }
            public IReadOnlyList<string> ImportDirectories { get; }
            public IReadOnlyDictionary<string, string> Options { get; }

            public string InferredCSharpNamepace => Options.GetValueOrDefault("csharp_namespace") ?? GetPascalCasePackage();

            private ProtoFileSummary(string package, IReadOnlyList<string> importDirectories, IReadOnlyDictionary<string, string> options) =>
                (Package, ImportDirectories, Options) = (package, importDirectories, options);

            internal static ProtoFileSummary Load(string file)
            {
                var lines = File.ReadAllLines(file);
                var package = lines.FirstOrDefault(line => line.StartsWith("package "));
                if (package is object)
                {
                    package = package.Substring("package ".Length).TrimEnd(';');
                }
                var importDirectories = lines
                    .Where(line => line.StartsWith("import "))
                    .Select(line => line.Substring("import ".Length).Trim(ImportAndOptionValueTrimChars))
                    .Select(file => Path.GetDirectoryName(file).Replace('\\', '/'))
                    .Distinct()
                    .OrderBy(import => import)
                    .ToList();

                var options = lines
                    .Where(line => line.StartsWith("option "))
                    .Select(line => line.Substring("option ".Length).Split('=', 2))
                    .Select(bits => (key: bits[0].Trim(), value: bits[1].Trim(ImportAndOptionValueTrimChars)))
                    .Where(pair => LibraryOptions.Contains(pair.key))
                    .ToDictionary(pair => pair.key, pair => pair.value);

                return new ProtoFileSummary(package, importDirectories, options);
            }

            private string GetPascalCasePackage()
            {
                if (Package is null)
                {
                    return null;
                }
                return string.Join('.', Package.Split('.').Select(bit => ToUpperCamelCase(bit)));
            }

            // Copied from https://github.com/googleapis/gapic-generator-csharp/blob/master/Google.Api.Generator/Utils/SystemExtensions.cs.
            // We can move it somewhere more common if we need to...
            private static char MaybeForceCase(char c, bool? toUpper) =>
                toUpper is bool upper ? upper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c) : c;

            private static string Camelizer(string s, bool firstUpper, bool forceAllChars) =>
                s.Aggregate((upper: (bool?) firstUpper, prev: '\0', sb: new StringBuilder()), (acc, c) =>
                     !char.IsLetterOrDigit(c) ?
                         (acc.sb.Length > 0 ? true : firstUpper, c, acc.sb) :
                         (char.IsDigit(c) ? true : forceAllChars ? (bool?) false : null, c,
                             acc.sb.Append(MaybeForceCase(c, char.IsLower(acc.prev) && char.IsUpper(c) ? true : acc.upper))),
                    acc => acc.sb.ToString());

            private static string ToUpperCamelCase(string input, bool forceAllChars = false) => Camelizer(input, firstUpper: true, forceAllChars);
        }
    }
}
