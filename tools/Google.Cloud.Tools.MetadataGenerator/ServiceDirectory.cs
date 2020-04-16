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
        public List<Service> Services { get; set; }

        internal static ServiceDirectory FromServiceConfigs(string googleapisRoot, IEnumerable<ServiceConfig> configs)
        {
            return new ServiceDirectory { Services = configs.Select(config => Service.FromServiceConfig(googleapisRoot, config)).ToList() };
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
        public bool Stable { get; set; }

        public static Service FromServiceConfig(string googleapisRoot, ServiceConfig config)
        {
            string relativeFile = Path.GetRelativePath(googleapisRoot, config.File).Replace('\\', '/'); // e.g. google/spanner/v1/spanner_v1.yaml
            string relativeDirectory = Path.GetDirectoryName(relativeFile).Replace('\\', '/');          // e.g. google/spanner/v1
            string version = Path.GetFileName(relativeDirectory);                                       // e.g. v1
            var packageFromDirectory = relativeDirectory.Replace('/', '.');                             // e.g. google.spanner.v1
            var packageFromProtos = LoadPackageFromProtos(Path.GetDirectoryName(config.File));
            return new Service
            {
                PackageFromDirectory = packageFromDirectory,
                PackageFromProtos = packageFromProtos,
                Version = version,
                ServiceConfigFile = relativeFile,
                ServiceDirectory = relativeDirectory,
                Name = config.Name,
                Title = config.Title,
                Description = config.Documentation?.Summary?.Replace('\n', ' ') ?? "<UNKNOWN - NO SERVICE CONFIG DOCUMENTATION SUMMARY>",
                Stable = StableVersionPattern.IsMatch(version)
            };
        }

        private static string LoadPackageFromProtos(string directory)
        {
            var protos = Directory.GetFiles(directory, "*.proto").OrderBy(f => f, StringComparer.Ordinal);
            foreach (var proto in protos)
            {
                var lines = File.ReadAllLines(proto);
                var package = lines.FirstOrDefault(line => line.StartsWith("package "));
                if (package is object)
                {
                    return package.Substring("package ".Length).TrimEnd(';');
                }
            }
            return "<UNKNOWN - NO PROTOS WITH PACKAGES>";
        }
    }
}
