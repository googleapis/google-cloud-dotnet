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
using Google.Cloud.Tools.UpdateReleaseNotes;
using LibGit2Sharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Release management tool, providing a single entry point to multiple common tasks
    /// when releasing  libraries.
    /// </summary>
    internal sealed class Program
    {
        // The branch we're thinking of as master. It may actually be some other branch for occasional
        // releases, but fundamentally it's "the current source of truth we're basing this release on".
        private const string MasterBranch = "master";

        private const string ShowVersionCommand = "show-version";
        private const string SetVersionCommand = "set-version";
        private const string IncrementVersionCommand = "increment-version";
        private const string ShowCommand = "show";
        private const string CompareCommand = "compare";
        private const string UpdateHistoryCommand = "update-history";
        private const string CommitCommand = "commit";

        private static int Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    ShowUsage();
                    return 0;
                }
                var command = args[0];
                var commandArgs = args.Skip(1).ToArray();
                switch (command)
                {
                    case ShowVersionCommand:
                        ShowVersion(commandArgs);
                        break;
                    case SetVersionCommand:
                        SetVersion(commandArgs);
                        break;
                    case IncrementVersionCommand:
                        IncrementVersion(commandArgs);
                        break;
                    case ShowCommand:
                        ShowVersions(commandArgs);
                        break;
                    case CompareCommand:
                        CompareVersions(commandArgs);
                        break;
                    case UpdateHistoryCommand:
                        UpdateHistory(commandArgs);
                        break;
                    case CommitCommand:
                        Commit(commandArgs);
                        break;
                    default:
                        Console.WriteLine($"Unknown command: '{command}'");
                        ShowUsage();
                        return 1;
                }
                return 0;
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Configuration error: {e.Message}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed: {e}");
                return 1;
            }
        }

        private static void ShowUsage()
        {
            Console.WriteLine($"{nameof(ReleaseManager)} commands:");
            Console.WriteLine("");
            Console.WriteLine($"{SetVersionCommand} <id> <new-version>: Set a version in apis.json and generate project files");
            Console.WriteLine($"{IncrementVersionCommand} <id>: Increment a version in apis.json and generate project files");
            Console.WriteLine($"{ShowVersionCommand} <id>: Show the current version of the given API on the master branch");
            Console.WriteLine($"{ShowCommand}: Show the versions changes in the current PR");
            Console.WriteLine($"{CompareCommand}: Compare each changed version with the previous release");
            Console.WriteLine($"{UpdateHistoryCommand}: Update the release history file for each changed version");
            Console.WriteLine($"{CommitCommand}: Commit the current set of changes with an appropriate commit message");
        }

        private static void SetVersion(string[] args)
        {
            if (args.Length != 2)
            {
                throw new UserErrorException($"{SetVersionCommand} requires two arguments: the package ID and the new version");
            }
            SetVersion(args[0], args[1]);
        }

        private static void ShowVersion(string[] args)
        {
            if (args.Length != 1)
            {
                throw new UserErrorException($"{ShowVersionCommand} requires one argument: the package ID");
            }
            string id = args[0];
            var masterCatalog = LoadMasterCatalog();
            var api = masterCatalog.FirstOrDefault(x => x.Id == id);
            if (api == null)
            {
                throw new UserErrorException($"API '{id}' not found in API catalog.");
            }
            Console.WriteLine($"Current version of {id} on master branch: {api.Version}");
        }

        private static void IncrementVersion(string[] args)
        {
            if (args.Length != 1)
            {
                throw new UserErrorException($"{IncrementVersionCommand} requires one argument: the package ID");
            }
            string id = args[0];

            // It's slightly inefficient that we load the API catalog once here and once later on, and the code duplication
            // is annoying too, but it's insignficant really - and at least the code is simple.

            var catalog = ApiMetadata.LoadApis();
            var api = catalog.FirstOrDefault(x => x.Id == id);
            if (api == null)
            {
                throw new UserErrorException($"API '{id}' not found in API catalog.");
            }
            var version = IncrementStructuredVersion(api.StructuredVersion).ToString();
            SetVersion(id, version);

            StructuredVersion IncrementStructuredVersion(StructuredVersion originalVersion)
            {
                // Any GA version just increments the minor version.
                if (originalVersion.Prerelease is null)
                {
                    return new StructuredVersion(originalVersion.Major, originalVersion.Minor + 1, 0, null);
                }

                // For prereleases, expect something like "beta01" which should be incremented to "beta02".
                var prereleasePattern = new Regex(@"^([^\d]*)(\d+)$");
                var match = prereleasePattern.Match(originalVersion.Prerelease);
                if (!match.Success)
                {
                    throw new UserErrorException($"Don't know how to auto-increment version '{originalVersion}'");
                }
                var prefix = match.Groups[1].Value;
                var suffix = match.Groups[2].Value;
                if (!int.TryParse(suffix, out var counter))
                {
                    throw new UserErrorException($"Don't know how to auto-increment version '{originalVersion}'");
                }
                counter++;
                var newSuffix = counter.ToString().PadLeft(suffix.Length, '0');
                return new StructuredVersion(originalVersion.Major, originalVersion.Minor, originalVersion.Patch, $"{prefix}{newSuffix}");
            }
        }

        private static void SetVersion(string id, string version)
        {
            var catalog = ApiMetadata.LoadApis();
            var api = catalog.FirstOrDefault(x => x.Id == id);
            if (api == null)
            {
                throw new UserErrorException($"API '{id}' not found in API catalog.");
            }

            string oldVersion = api.Version;
            api.Version = version;
            var layout = DirectoryLayout.ForApi(id);
            var apiNames = new HashSet<string>(catalog.Select(x => x.Id));
            ProjectGenerator.Program.GenerateMetadataFile(layout.SourceDirectory, api);
            ProjectGenerator.Program.GenerateProjects(layout.SourceDirectory, api, apiNames);
            ProjectGenerator.Program.RewriteReadme(catalog);
            ProjectGenerator.Program.RewriteDocsRootIndex(catalog);

            // This is somewhat annoying and ugly, but never mind.
            // If we need similar code in other places, we should put it in ApiMetadata.
            JToken parsed = JToken.Parse(File.ReadAllText(ApiMetadata.CatalogPath));
            var apiObject = parsed
                .Children()
                .OfType<JObject>()
                .FirstOrDefault(obj => obj.TryGetValue("id", out var idToken) && idToken.Value<string>() == id);
            apiObject["version"] = version;
            string formatted = parsed.ToString(Formatting.Indented);
            File.WriteAllText(ApiMetadata.CatalogPath, formatted);
            Console.WriteLine("Updated apis.json");
            Console.WriteLine();
            Console.WriteLine(new ApiVersionPair(id, oldVersion, version));
        }

        private static void ShowVersions(string[] args)
        {
            if (args.Length != 0)
            {
                throw new UserErrorException($"{ShowCommand} does not accept additional arguments");
            }

            foreach (var change in FindChangedVersions())
            {
                Console.WriteLine(change);
            }
        }

        private static List<ApiVersionPair> FindChangedVersions()
        {
            var currentCatalog = ApiMetadata.LoadApis();
            var masterCatalog = LoadMasterCatalog();
            var currentVersions = currentCatalog.ToDictionary(api => api.Id, api => api.Version);
            var masterVersions = masterCatalog.ToDictionary(api => api.Id, api => api.Version);
            return currentVersions.Keys.Concat(masterVersions.Keys)
                .Distinct()
                .OrderBy(id => id)
                .Select(id => new ApiVersionPair(id, masterVersions.GetValueOrDefault(id), currentVersions.GetValueOrDefault(id)))
                .Where(v => v.NewVersion != v.OldVersion)
                .ToList();
        }

        private static List<ApiMetadata> LoadMasterCatalog()
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                var master = repo.Branches.FirstOrDefault(b => b.FriendlyName == MasterBranch);
                if (master == null)
                {
                    throw new UserErrorException($"Unable to find branch '{MasterBranch}'.");
                }

                var masterCatalogJson = master.Commits.First()["apis/apis.json"].Target.Peel<Blob>().GetContentText();
                return JsonConvert.DeserializeObject<List<ApiMetadata>>(masterCatalogJson);
            }
        }

        private static void CompareVersions(string[] args)
        {
            if (args.Length != 0)
            {
                throw new UserErrorException($"{CompareCommand} does not accept additional arguments");
            }

            var idsToCheck = new List<string>();
            foreach (var diff in FindChangedVersions())
            {
                if (diff.OldVersion is null)
                {
                    Console.WriteLine($"{diff.Id} is new; no comparison required.");
                }
                else if (diff.NewVersion is null)
                {
                    Console.WriteLine($"{diff.Id} has been deleted; no comparison required.");
                }
                else
                {
                    // Found an API to compare. Build it locally first, so we know we're up-to-date.
                    var api = diff.Id;
                    idsToCheck.Add(api);
                    Console.WriteLine($"Building {api} locally");
                    var sourceRoot = DirectoryLayout.ForApi(api).SourceDirectory;
                    Processes.RunDotnet(sourceRoot, "build", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", api);
                }
            }
            CheckVersionCompatibility.Program.Main(idsToCheck.ToArray());
        }

        private static void UpdateHistory(string[] args)
        {
            if (args.Length != 0)
            {
                throw new UserErrorException($"{UpdateHistoryCommand} does not accept additional arguments");
            }

            foreach (var diff in FindChangedVersions())
            {
                if (diff.NewVersion is null)
                {
                    Console.WriteLine($"{diff.Id} has been deleted; no history required.");
                }
                else
                {
                    UpdateReleaseNotes.Program.Execute(diff.Id);
                }
            }
        }

        private static void Commit(string[] args)
        {
            if (args.Length != 0)
            {
                throw new UserErrorException($"{CommitCommand} does not accept additional arguments");
            }

            var diffs = FindChangedVersions();
            if (diffs.Count != 1)
            {
                throw new UserErrorException($"Can only automate a release commit with exactly 1 release. Found {diffs.Count}.");
            }
            var diff = diffs[0];
            if (diff.NewVersion is null)
            {
                throw new UserErrorException($"Cannot automate a release commit for a deleted API.");
            }

            var historyFilePath = HistoryFile.GetPathForPackage(diff.Id);
            if (!File.Exists(historyFilePath))
            {
                throw new UserErrorException($"Cannot automate a release commit without a version history file.");
            }

            var historyFile = HistoryFile.Load(historyFilePath);
            var section = historyFile.Sections.FirstOrDefault(s  => s.Version?.ToString() == diff.NewVersion);
            if (section is null)
            {
                throw new UserErrorException($"Unable to find history file section for {diff.NewVersion}. Cannot automate a release commit in this state.");
            }

            string header = $"Release {diff.Id} version {diff.NewVersion}";
            var message = string.Join("\n", new[] { header, "", "Changes in this release:", "" }.Concat(section.Lines.Skip(2)));

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                RepositoryStatus status = repo.RetrieveStatus();
                // TODO: Work out whether this is enough, and whether we actually need all of these.
                // We basically want git add --all.
                AddAll(status.Modified);
                AddAll(status.Missing);
                AddAll(status.Untracked);
                repo.Index.Write();
                var signature = repo.Config.BuildSignature(DateTimeOffset.UtcNow);
                var commit = repo.Commit(message, signature, signature);
                Console.WriteLine($"Created commit {commit.Sha}. Review the message and amend if necessary.");

                void AddAll(IEnumerable<StatusEntry> entries)
                {
                    foreach (var entry in entries)
                    {
                        repo.Index.Add(entry.FilePath);
                    }
                }
            }
        }
    }
}
