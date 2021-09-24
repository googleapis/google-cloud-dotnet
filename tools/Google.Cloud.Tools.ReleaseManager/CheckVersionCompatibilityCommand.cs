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

namespace Google.Cloud.Tools.ReleaseManager
{
    public class CheckVersionCompatibilityCommand : ICommand
    {
        public string Description => "Compares a package (or all packages) for compatibility against previously-released versions";

        public string Command => "check-version-compatibility";

        public string ExpectedArguments => "[id [id...]]";

        public void Execute(string[] args)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            var catalog = ApiCatalog.Load();
            HashSet<string> tags;
            using (var repo = new Repository(root))
            {
                tags = new HashSet<string>(repo.Tags.Select(tag => tag.FriendlyName));
            }

            List<ApiMetadata> apisToCheck = args.Length == 0
                ? catalog.Apis.Where(api => !api.Version.EndsWith("00") && !tags.Contains($"{api.Id}-{api.Version}")).ToList()
                // Note: this basically validates the command line arguments.
                : args.Select(arg => catalog[arg]).ToList();

            foreach (var api in apisToCheck)
            {
                Console.WriteLine($"Checking compatibility for {api.Id} version {api.Version}");
                var prefix = api.Id + "-";

                var taggedVersions = tags
                    .Where(tag => tag.StartsWith(prefix))
                    .Select(tag => tag.Split(new char[] { '-' }, 2)[1])
                    .Where(v => !v.StartsWith("0")) // We can reasonably ignore old 0.x versions
                    .Select(StructuredVersion.FromString)
                    .OrderBy(v => v)
                    .ToList();

                var comparisons = GetComparisons(api.StructuredVersion, taggedVersions);
                foreach (var (oldVersion, requiredLevel) in comparisons)
                {
                    var actualLevel = CheckCompatibility(api, oldVersion);
                    if (actualLevel < requiredLevel)
                    {
                        throw new UserErrorException($"Required compatibility level: {requiredLevel}. Actual compatibility level: {actualLevel}.");
                    }
                }
            }
        }

        // Visible for testing
        static internal IEnumerable<(StructuredVersion, Level)> GetComparisons(StructuredVersion newVersion, List<StructuredVersion> taggedVersions)
        {
            // e.g. 1.0.0-beta00, 2.0.0-beta00. Initial not-even-beta libraries, and preparing for new major version.
            var isNonRelease = newVersion.IsNonRelease;

            // Whether pre-release or not, and whether new or not, if there's a previous stable version we should compare against it.
            if (newVersion.Major > 1 || newVersion.Minor > 0 || newVersion.Patch > 0)
            {
                var latestStable = taggedVersions.LastOrDefault(v => v.IsStable);
                if (latestStable is object)
                {
                    var level =
                        newVersion.Major != latestStable.Major ? Level.Major
                        : newVersion.Minor != latestStable.Minor ? Level.Minor
                        : Level.Identical;
                    yield return (latestStable, level);
                }
            }

            // If the new version is already a tag, we compare with that.
            var compareWithSelf = taggedVersions.Contains(newVersion);
            if (compareWithSelf)
            {
                yield return (newVersion, newVersion.IsStable ? Level.Minor : Level.Major);
            }
            else if (!newVersion.IsNonRelease)
            {
                // This is a release PR: the version doesn't already exist, and it isn't a *-beta00 version.
                // If there's any existing release with the same major/minor/patch (which must necessarily be a pre-release), compare with that, allowing any changes.
                // (We're already checking against the appropriate stable version, if any.)
                var latestSameMajorMinorPatch = taggedVersions.LastOrDefault(v => v.Major == newVersion.Major && v.Minor == newVersion.Minor && v.Patch == newVersion.Patch);
                if (latestSameMajorMinorPatch is object)
                {
                    yield return (latestSameMajorMinorPatch, Level.Major);
                }
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
