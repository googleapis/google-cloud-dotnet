// Copyright 2019 Google LLC
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
using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.VersionCompat;
using LibGit2Sharp;
using Mono.Cecil;

namespace Google.Cloud.Tools.CheckVersionCompatibility
{
    class Program
    {
        // These APIs don't build for netstandard2.0, so for now we ignore them.
        // We could potentially detect the right TFM, but that's more work than it's probably worth.
        private static readonly List<string> IgnoredApis = new[]
        {
            "Google.Cloud.Diagnostics.AspNet",
            "Google.Cloud.Diagnostics.AspNetCore.Analyzers"
        }.ToList();

        static int Main(string[] args)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            var apis = ApiMetadata.LoadApis();
            HashSet<string> tags;
            using (var repo = new Repository(root))
            {
                tags = new HashSet<string>(repo.Tags.Select(tag => tag.FriendlyName));
            }

            List<ApiMetadata> apisToCheck = args.Length == 0
                ? apis.Where(api => !api.Version.EndsWith("00") && !tags.Contains($"{api.Id}-{api.Version}")).ToList()
                // Note: this basically validates the command line arguments. The failure isn't great when the API isn't found,
                // but that could be worse.
                : args.Select(arg => apis.Single(api => api.Id == arg)).ToList();

            foreach (var api in apisToCheck)
            {
                if (IgnoredApis.Contains(api.Id))
                {
                    Console.WriteLine($"Skipping check for {api.Id} as it doesn't target netstandard2.0");
                    continue;
                }
                Console.WriteLine($"Checking compatibility for {api.Id} version {api.Version}");
                var prefix = api.Id + "-";
                var previousVersions = tags
                    .Where(tag => tag.StartsWith(prefix))
                    .Select(tag => tag.Split(new char[] { '-' }, 2)[1])
                    .Where(v => !v.StartsWith("0")) // We can reasonably ignore old 0.x versions
                    .Select(v => new StructuredVersion(v))
                    .OrderBy(v => v)
                    .ToList();
               
                var newVersion = api.StructuredVersion;

                // First perform a "strict" check, where necessary, failing the build if the difference
                // is inappropriate.
                var (requiredVersion, requiredLevel) = GetRequiredCompatibility(api.StructuredVersion);
                if (requiredVersion != null)
                {
                    if (!previousVersions.Contains(requiredVersion))
                    {
                        Console.WriteLine($"Expected to check compatibility with {requiredVersion}, but no corresponding tag found");
                        return 1;
                    }
                    var actualLevel = CheckCompatibility(api, requiredVersion);
                    if (actualLevel < requiredLevel)
                    {
                        Console.WriteLine($"Required compatibility level: {requiredLevel}. Actual compatibility level: {actualLevel}.");
                        return 1;
                    }
                }

                // Next log the changes compared with the previous release (if we haven't already diffed it)
                // in an informational way. (This can be used to improve or check release notes.)
                var lastRelease = previousVersions.LastOrDefault();
                if (lastRelease != null && !lastRelease.Equals(requiredVersion))
                {
                    CheckCompatibility(api, lastRelease);
                }
            }
            return 0;
        }

        /// <summary>
        /// Returns the previous version that the given new version *must* be compatible with,
        /// and the required level of compatibility. The version part is null if no compatibility
        /// check is required.
        /// </summary>
        private static (StructuredVersion version, Level level) GetRequiredCompatibility(StructuredVersion newVersion)
        {
            if (newVersion.Patch != 0)
            {
                // A patch version must be identical to major.minor.0.
                var oldVersion = new StructuredVersion(newVersion.Major, newVersion.Minor, 0, null);
                return (oldVersion, Level.Identical);
            }
            else if (newVersion.Minor == 0)
            {
                // A new major version doesn't need to check anything.
                return (null, Level.Identical);
            }
            else
            {
                // A new minor version must be compatible with the previous minor version
                var oldVersion = new StructuredVersion(newVersion.Major, newVersion.Minor - 1, 0, null);
                return (oldVersion, Level.Minor);
            }
        }

        /// <summary>
        /// Checks the compatibility of the locally-built API against a version on NuGet.
        /// This assumes the local package has already been built and is up-to-date.
        /// </summary>
        private static Level CheckCompatibility(ApiMetadata api, StructuredVersion version)
        {
            Console.WriteLine($"Differences from {version}");

            // TODO: Remove this try/catch when *everything* has a previous minor version on netstandard2.0.
            AssemblyDefinition oldMetadata;
            try
            {
                oldMetadata = Assemblies.LoadPackageAsync(api.Id, version.ToString(), null, null).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to load {api.Id} version {version} from NuGet. Some possible causes:");
                Console.WriteLine("- Package was pre-netstandard2.0");
                Console.WriteLine("- Package was never published");
                Console.WriteLine("- nuget.org failure");
                Console.WriteLine($"Exception message: {e.Message}");
                Console.WriteLine($"Returning 'identical' as the change level; please check carefully before release.");
                return Level.Identical;
            }
            var sourceAssembly = Path.Combine(DirectoryLayout.ForApi(api.Id).SourceDirectory, api.Id, "bin", "Release", "netstandard2.0", $"{api.Id}.dll");
            var newMetadata = Assemblies.LoadFile(sourceAssembly);

            var diff = Assemblies.Compare(oldMetadata, newMetadata, null);
            diff.PrintDifferences(Level.Major, FormatDetail.Brief);
            diff.PrintDifferences(Level.Minor, FormatDetail.Brief);
            Console.WriteLine($"Diff level: {diff.Level}");
            Console.WriteLine();
            return diff.Level;
        }
    }
}
