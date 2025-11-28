// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Google.Cloud.Tools.ReleaseManager.History;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Prepares the repository for an impending library release. Currently this involves:
/// - Updating the version in the API catalog
/// - Regenerating project files
/// - Updating release notes
/// - Updating README.md and Renovate
///
/// Note that in this context "a library" might be multiple NuGet packages. This is represented
/// by a "library" ID which is a package group in the API catalog.
///
/// Expected options:
/// - repo-root: the root of the google-cloud-dotnet repository
/// - library-id: the ID of the library being released
/// - version: the library version being released
/// - release-notes: path to a file containing release notes, to be included in the version history
///
/// This does *not* update dependencies on other libraries within this repo. That has previously
/// been convenient, but we should probably look at the process separately.
/// </summary>
public sealed class PrepareLibraryReleaseCommand : IContainerCommand
{
    public int Execute(ContainerOptions options)
    {
        string repoRoot = options.RequireOption(options.RepoRoot);
        string libraryId = options.RequireOption(options.LibraryId);
        string version = options.RequireOption(options.Version);
        var releaseNotes = File.ReadAllLines(options.RequireOption(options.ReleaseNotes)).ToList();
        // Make sure we always have a blank line at the end of the release notes.
        if (releaseNotes.LastOrDefault() != "")
        {
            releaseNotes.Add("");
        }
        var releaseDate = DateTime.UtcNow.Date;

        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var nonSourceGenerator = new NonSourceGenerator(rootLayout);
        // Use the same API catalog object as the non-source generator, so
        // that version changes we make here are reflected consistently.
        var apiCatalog = nonSourceGenerator.ApiCatalog;

        var packageGroup = apiCatalog.PackageGroups.FirstOrDefault(pg => pg.Id == libraryId);
        var packageIds = packageGroup?.PackageIds ?? new() { libraryId };
        var structuredVersion = StructuredVersion.FromString(version);

        foreach (var packageId in packageIds)
        {
            var api = apiCatalog[packageId];
            if (api.BlockRelease is string blockRelease)
            {
                Console.WriteLine($"The release of {api.Id} is blocked: {blockRelease}");
                return 1;
            }

            api.Version = version;

            // Update the parsed JObject associated with the ID, so we can later save it to apis.json
            api.Json["version"] = version;
            nonSourceGenerator.GenerateApiFiles(api);

            if (!api.NoVersionHistory)
            {
                var apiLayout = rootLayout.CreateDocsLayout(api);
                var historyFile = HistoryFile.Load(rootLayout, api.Id);

                if (historyFile.Sections.Any(s => structuredVersion.Equals(s.Version)))
                {
                    Console.WriteLine($"Package {api.Id} already has release notes for version {version}");
                    return 1;
                }

                // Insert after the first section, which will be the preamble.
                historyFile.Sections.Insert(1, HistoryFile.Section.FromReleaseNotes(structuredVersion, releaseDate, releaseNotes));
                historyFile.Save();
            }
        }
        nonSourceGenerator.GenerateNonApiFiles();
        apiCatalog.Save(rootLayout);

        return 0;
    }
}
