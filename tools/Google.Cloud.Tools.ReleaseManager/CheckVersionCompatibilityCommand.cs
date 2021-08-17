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
                var lastVersion = tags
                    .Where(tag => tag.StartsWith(prefix))
                    .Select(tag => tag.Split(new char[] { '-' }, 2)[1])
                    .Where(v => !v.StartsWith("0")) // We can reasonably ignore old 0.x versions
                    .Select(StructuredVersion.FromString)
                    .OrderBy(v => v)
                    .LastOrDefault();

                if (lastVersion is null)
                {
                    Console.WriteLine("No previous versions released; ignoring.");
                    return;
                }

                var newVersion = api.StructuredVersion;

                // If we're releasing a new version, we should check against the previous one.
                // (For example, if this PR creates 1.2.0, then check against 1.1.0.)
                // Otherwise, just expect minor changes.
                Level requiredLevel = Level.Minor;
                if (!lastVersion.Equals(newVersion))
                {
                    requiredLevel =
                        lastVersion.Major != newVersion.Major ? Level.Major   // Major version bump: anything goes
                        : lastVersion.Minor != newVersion.Minor ? Level.Minor // Minor version bump: minor changes are okay
                        : Level.Identical;                                    // Patch version bump: API should be identical
                }

                var actualLevel = CheckCompatibility(api, lastVersion);
                if (actualLevel < requiredLevel)
                {
                    throw new UserErrorException($"Required compatibility level: {requiredLevel}. Actual compatibility level: {actualLevel}.");
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
