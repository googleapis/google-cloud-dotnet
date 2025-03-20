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
using Google.Protobuf.WellKnownTypes;
using LibGit2Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Temporary command to create a pipeline-state.json file for the new production pipeline,
/// based on what's already in the API catalog. This command can be removed when the production pipeline
/// is up and running, as that will maintain the state itself.
/// </summary>
public sealed class CreatePipelineStateCommand : CommandBase
{
    private const string SourceLinkPrefix = "Source-Link: https://github.com/googleapis/googleapis/commit/";
    private const string AutomationLevelAutomatic = "AUTOMATION_LEVEL_AUTOMATIC";
    private const string AutomationLevelBlocked = "AUTOMATION_LEVEL_BLOCKED";


    public CreatePipelineStateCommand()
    : base("create-pipeline-state", "Create a pipeline state file for testing the new production pipeline", "googleapis")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var catalog = ApiCatalog.Load(RootLayout);

        using var repo = new Repository(RootLayout.RepositoryRoot);
        using var googleapisRepo = new Repository(args[0]);
        var state = new PipelineState
        {
            ImageTag = "latest",
            CommonLibrarySourcePaths = { "Directory.Packages.props" }
        };
        var tagsByName = repo.Tags.ToDictionary(t => t.FriendlyName);

        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Fetching commmits with a source link.");
        var googleApisCommits = repo.Commits
            .Where(GitHelpers.CreateCommitPredicateForPathPrefix("apis/"))
            .Where(c => c.Message.Contains(SourceLinkPrefix, StringComparison.Ordinal))
            .ToList();
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Fetched {googleApisCommits.Count} commmits.");

        foreach (var api in catalog.Apis)
        {
            MaybeAddApi(api);
            MaybeAddApiLibrary(api);
        }
        foreach (var packageGroup in catalog.PackageGroups)
        {
            AddPackageGroupLibrary(packageGroup);
        }
        // Avoid serializing empty lists. There may be a better way of doing this...
        foreach (var library in state.LibraryReleaseStates)
        {
            if (library.Apis.Count == 0)
            {
                library.Apis = null;
            }
        }
        
        string json = JsonConvert.SerializeObject(state,
            new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore, Formatting = Formatting.Indented });
        File.WriteAllText(Path.Combine(RootLayout.GeneratorInput, "pipeline-state.json"), json);
        return 0;

        void MaybeAddApi(ApiMetadata api)
        {
            if (api.ProtoPath is null)
            {
                return;
            }
            var path = $"apis/{api.Id}";
            var lastApiCommit = GetCommitForPath(googleApisCommits, path);
            if (lastApiCommit is null)
            {
                Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: No googleapis commits found for {api.Id}; skipping.");
                return;
            }
            var message = lastApiCommit.Message;
            var sourceLinkIndex = message.IndexOf(SourceLinkPrefix);
            // Commit hashes are always 40 characters long.
            var hash = message.Substring(sourceLinkIndex + SourceLinkPrefix.Length, 40);
            state.ApiGenerationStates.Add(new()
            {
                Id = api.ProtoPath,
                LastGeneratedCommit = hash,
                AutomationLevel = AutomationLevelAutomatic
            });
            Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Added {api.Id}");
        }

        void MaybeAddApiLibrary(ApiMetadata api)
        {
            // Package groups are handled later
            if (api.PackageGroup is not null)
            {
                return;
            }
            if (api.Version.EndsWith("00"))
            {
                return;
            }
            var timestamp = GetLastReleaseTimestamp(api);
            var library = new LibraryReleaseState
            {
                Id = api.Id,
                CurrentVersion = api.Version,
                ReleaseTimestamp = Timestamp.FromDateTimeOffset(timestamp).ToString().Trim('"'),
                AutomationLevel = api.BlockRelease is not null ? AutomationLevelBlocked : AutomationLevelAutomatic
            };
            if (MaybeCreateApiMapping(api) is LibraryApiMapping mapping)
            {
                library.Apis.Add(mapping);
            }
            library.SourcePaths.Add($"apis/{api.Id}/{api.Id}");
            state.LibraryReleaseStates.Add(library);
        }

        void AddPackageGroupLibrary(PackageGroup packageGroup)
        {
            var packages = packageGroup.PackageIds.Select(id => catalog[id]).ToList();
            var timestamp = GetLastReleaseTimestamp(packages[0]);
            var library = new LibraryReleaseState
            {
                Id = packageGroup.Id,
                CurrentVersion = packages[0].Version,
                ReleaseTimestamp = Timestamp.FromDateTimeOffset(timestamp).ToString().Trim('"'),
                AutomationLevel = packages.Any(p => p.BlockRelease is not null) ? AutomationLevelBlocked : AutomationLevelAutomatic
            };
            library.Apis.AddRange(packages.Select(MaybeCreateApiMapping).OfType<LibraryApiMapping>());
            library.SourcePaths.AddRange(packages.Select(p => $"apis/{p.Id}/{p.Id}"));
            state.LibraryReleaseStates.Add(library);
        }

        DateTimeOffset GetLastReleaseTimestamp(ApiMetadata api)
        {
            var expectedTag = $"{api.Id}-{api.Version}";
            var tag = tagsByName[expectedTag];
            return tag.GetDate();
        }

        LibraryApiMapping MaybeCreateApiMapping(ApiMetadata package)
        {
            if (package.ProtoPath is null)
            {
                return null;
            }
            // Assume we were last generated at the last commit affecting the proto path, before the timestamp.
            // This is only a nice-to-have for now, so we can leave it empty if necessary.
            var timestamp = GetLastReleaseTimestamp(package);
            var commit = GetCommitForPath(googleapisRepo.Head.Commits.Where(c => c.GetDate() < timestamp), package.ProtoPath);
            return new LibraryApiMapping
            {
                ApiId = package.ProtoPath,
                LastReleasedCommit = commit?.Sha ?? ""
            };
        }
    }

    private static Commit GetCommitForPath(IEnumerable<Commit> commits, string path)
    {
        var predicate = GitHelpers.CreateCommitPredicateForPathPrefix(path);
        return commits.Where(predicate).FirstOrDefault();
    }

    // Eventually use have a proto for the pipeline state schema. The first draft is at
    // https://github.com/googleapis/generator/blob/main/proto/pipeline.proto
    // but for the moment we'll just create a copy here as a class - we only need the JSON representation.
    // (We'll use strings for automation levels for simplicity for now.)
    private class PipelineState
    {
        [JsonProperty("imageTag")]
        public string ImageTag { get; set; }

        [JsonProperty("apiGenerationStates")]
        public List<ApiGenerationState> ApiGenerationStates { get; } = new();

        [JsonProperty("libraryReleaseStates")]
        public List<LibraryReleaseState> LibraryReleaseStates { get; } = new();

        [JsonProperty("commonLibrarySourcePaths")]
        public List<string> CommonLibrarySourcePaths { get; } = new();
    }

    private class ApiGenerationState
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastGeneratedCommit")]
        public string LastGeneratedCommit { get; set; }

        [JsonProperty("automationLevel")]
        public string AutomationLevel { get; set; }
    }

    private class LibraryReleaseState
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("currentVersion")]
        public string CurrentVersion { get; set; }

        [JsonProperty("nextVersion")]
        public string NextVersion { get; set; }

        [JsonProperty("automationLevel")]
        public string AutomationLevel { get; set; }

        [JsonProperty("releaseTimestamp")]
        public string ReleaseTimestamp { get; set; }

        [JsonProperty("apis")]
        public List<LibraryApiMapping> Apis { get; set; } = new();

        [JsonProperty("sourcePaths")]
        public List<string> SourcePaths { get; } = new();
    }

    private class LibraryApiMapping
    {
        [JsonProperty("apiId")]
        public string ApiId { get; set; }

        [JsonProperty("lastReleasedCommit")]
        public string LastReleasedCommit { get; set; }
    }
}
