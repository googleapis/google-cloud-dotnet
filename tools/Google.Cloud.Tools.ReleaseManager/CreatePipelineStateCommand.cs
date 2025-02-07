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
    public CreatePipelineStateCommand()
    : base("create-pipeline-state", "Create a pipeline state file for testing the new production pipeline")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var catalog = ApiCatalog.Load(RootLayout);

        using var repo = new Repository(RootLayout.RepositoryRoot);
        var state = new PipelineState { ImageTag = "latest" };

        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Fetching commmits with a source link.");
        var googleApisCommits = repo.Commits
            .Where(GitHelpers.CreateCommitPredicateForPathPrefix("apis/"))
            .Where(c => c.Message.Contains(SourceLinkPrefix, StringComparison.Ordinal))
            .ToList();
        Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Fetched {googleApisCommits.Count} commmits.");

        foreach (var api in catalog.Apis)
        {
            MaybeAddApi(api);
        }

        string json = JsonConvert.SerializeObject(state, Formatting.Indented);
        File.WriteAllText(Path.Combine(RootLayout.GeneratorInput, "pipeline-state.json"), json);
        return 0;

        void MaybeAddApi(ApiMetadata api)
        {
            if (api.ProtoPath is null)
            {
                return;
            }
            var path = $"apis/{api.Id}";
            var lastApiCommit = googleApisCommits.Where(GitHelpers.CreateCommitPredicateForPathPrefix(path)).FirstOrDefault();
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
                AutomationLevel = "AUTOMATION_LEVEL_AUTOMATIC"
            });
            Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Added {api.Id}");
        }
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
}
