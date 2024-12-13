// Copyright 2024 Google LLC
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

using System.IO;

namespace Google.Cloud.Tools.Common;

/// <summary>
/// Directory layout for a single API. 
/// </summary>
public class ApiLayout
{
    /// <summary>
    /// Root of all source for this API, including production code, tests, snippets etc.
    /// </summary>
    public string SourceDirectory { get; }
    public string DocsOutputDirectory { get; }
    public string DocfxMetadataDirectory { get; }
    public string SnippetOutputDirectory { get; }
    public string DocsSourceDirectory { get; }
    public string TweaksDirectory { get; }

    private ApiLayout(string source, string docsOutput, string metadata, string snippetOutput, string docsSource, string tweaks)
    {
        SourceDirectory = source;
        DocsOutputDirectory = docsOutput;
        DocfxMetadataDirectory = metadata;
        SnippetOutputDirectory = snippetOutput;
        DocsSourceDirectory = docsSource;
        TweaksDirectory = tweaks;
    }

    internal static ApiLayout Create(RootLayout rootLayout, string id)
    {
        var outputRoot = rootLayout.GeneratorOutput;

        return new ApiLayout(
            source: Path.Combine(outputRoot, "apis", id),
            docsOutput: Path.Combine(outputRoot, "docs", "output", id),
            metadata: Path.Combine(outputRoot, "docs", "output", id, "obj", "api"),
            snippetOutput: Path.Combine(outputRoot, "docs", "output", id, "obj", "snippets"),
            docsSource: Path.Combine(outputRoot, "apis", id, "docs"),
            tweaks: Path.Combine(rootLayout.GeneratorInput, "tweaks", id)
        );
    }

    public static ApiLayout ForHelpSnippets(RootLayout rootLayout) =>
        new ApiLayout(
            source: Path.Combine(rootLayout.RepositoryRoot, "tools"),
            docsOutput: null,
            metadata: null,
            snippetOutput: Path.Combine(rootLayout.RepositoryRoot, "docs", "output", "help", "obj", "snippets"),
            docsSource: null,
            tweaks: null
            );
}
