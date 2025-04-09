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

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Google.Cloud.Tools.Common;

// Eventually we'll have a proto for the pipeline state schema. The first draft is at
// https://github.com/googleapis/generator/blob/main/proto/pipeline.proto
// but for the moment we'll just create a copy here as a class - we only need the JSON representation.
// (We'll use strings for automation levels for simplicity for now.)
public class PipelineState
{
    [JsonProperty("imageTag")]
    public string ImageTag { get; set; }

    [JsonProperty("libraries")]
    public List<LibraryState> Libraries { get; } = new();

    [JsonProperty("commonLibrarySourcePaths")]
    public List<string> CommonLibrarySourcePaths { get; } = new();

    [JsonProperty("ignoredApiPaths")]
    public List<string> IgnoredApiPaths { get; } = new();

    private const string StateFile = "pipeline-state.json";

    private static string GetStatePath(RootLayout layout) => Path.Combine(layout.GeneratorInput, StateFile);
    public static PipelineState Load(RootLayout layout) => FromJson(File.ReadAllText(GetStatePath(layout)));

    public void Save(RootLayout layout)
    {
        // Slightly fiddly serialization to mimic the indentation that Librarian uses.
        var serializer = new JsonSerializer { DefaultValueHandling = DefaultValueHandling.Ignore };
        using var fileWriter = File.CreateText(GetStatePath(layout));
        using var jsonWriter = new JsonTextWriter(fileWriter) { Formatting = Formatting.Indented, Indentation = 4 };
        serializer.Serialize(jsonWriter, this);
    }

    /// <summary>
    /// Loads the pipeline state from the given JSON.
    /// </summary>
    /// <param name="json">The JSON containing the pipeline state.</param>
    /// <returns>The pipeline state.</returns>
    private static PipelineState FromJson(string json) => JsonConvert.DeserializeObject<PipelineState>(json);
}

public class LibraryState
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("currentVersion")]
    public string CurrentVersion { get; set; }

    [JsonProperty("nextVersion")]
    public string NextVersion { get; set; }

    [JsonProperty("generationAutomationLevel")]
    public string GenerationAutomationLevel { get; set; }

    [JsonProperty("releaseAutomationLevel")]
    public string ReleaseAutomationLevel { get; set; }

    [JsonProperty("releaseTimestamp")]
    public string ReleaseTimestamp { get; set; }

    [JsonProperty("lastGeneratedCommit")]
    public string LastGeneratedCommit { get; set; }

    [JsonProperty("lastReleasedCommit")]
    public string LastReleasedCommit { get; set; }

    [JsonProperty("apiPaths")]
    public List<string> ApiPaths { get; set; } = new();

    [JsonProperty("sourcePaths")]
    public List<string> SourcePaths { get; } = new();
}
