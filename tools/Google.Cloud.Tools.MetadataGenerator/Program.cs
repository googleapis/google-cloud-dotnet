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
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.MetadataGenerator
{
    /// <summary>
    /// Experimental crawler to load service YAML files in googleapis and make
    /// the data within them more conveniently accessible. We might want to then write
    /// them out as JSON in the future, but before then we can still get useful information out,
    /// such as which stable APIs exist but aren't yet generated as C# libraries.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            var googleapisRoot = Path.Combine(root, "googleapis");
            var directory = LoadServiceDirectory(googleapisRoot);

            var catalog = ApiCatalog.Load();
            var paths = new HashSet<string>(catalog.Apis.Select(api => api.ProtoPath));
            var serviceDirectories = directory.Services
                .Where(service => service.Stable)
                .Select(service => service.ServiceDirectory).ToList();

            var ungenerated = serviceDirectories
                .Except(paths)
                .Except(catalog.IgnoredPaths)
                .OrderBy(path => path).ToList();
            ungenerated.ForEach(Console.WriteLine);
        }

        static ServiceDirectory LoadServiceDirectory(string googleapisRoot)
        {
            var configs = LoadServiceConfigsRecursively(googleapisRoot);
            Console.WriteLine($"Loaded {configs.Count} service config YAML files");
            return ServiceDirectory.FromServiceConfigs(googleapisRoot, configs);
        }

        private static readonly Regex ServiceVersionPattern = new Regex(@"^v\d+.*");
        static IReadOnlyList<ServiceConfig> LoadServiceConfigsRecursively(string directory)
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
