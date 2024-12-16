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

using System;
using System.IO;

namespace Google.Cloud.Tools.Common;

/// <summary>
/// Directory layout for documentation.
/// </summary>
public class DocsLayout
{
    /// <summary>
    /// Location where docs will be build by builddocs.sh.
    /// (This is derived from <see cref="RootLayout.RepositoryRoot"/>.)
    /// </summary>
    public string OutputDirectory { get; }

    /// <summary>
    /// Location for API metadata, built by builddocs.sh
    /// (This is derived from <see cref="RootLayout.RepositoryRoot"/>.)
    /// </summary>
    public string DocfxMetadataDirectory { get; }

    /// <summary>
    /// Source directory for snippets, if any.
    /// (This is derived from <see cref="RootLayout.RepositoryRoot"/>.)
    /// </summary>
    public string SnippetSourceDirectory { get; }

    /// <summary>
    /// Output directory for snippet text files.
    /// (This is derived from <see cref="RootLayout.RepositoryRoot"/>.)
    /// </summary>
    public string SnippetOutputDirectory { get; }

    /// <summary>
    /// Directory containing markdown files to generate documentation from.
    /// (This is derived from <see cref="RootLayout.RepositoryRoot"/>.)
    /// </summary>
    public string MarkdownDirectory { get; }

    private DocsLayout(RootLayout rootLayout, string id)
    {
        OutputDirectory = Path.Combine(rootLayout.RepositoryRoot, "docs", "output", id);
        DocfxMetadataDirectory = Path.Combine(OutputDirectory, "obj", "api");
        SnippetSourceDirectory = Path.Combine(rootLayout.RepositoryRoot, "apis", id, $"{id}.Snippets");
        SnippetOutputDirectory = Path.Combine(OutputDirectory, "obj", "snippets");
        MarkdownDirectory = Path.Combine(rootLayout.RepositoryRoot, "apis", id, "docs");
    }

    private DocsLayout(RootLayout rootLayout, HelpSnippetsMarker helpSnippetsMarker)
    {
        SnippetSourceDirectory = Path.Combine(rootLayout.RepositoryRoot, "tools", "Google.Cloud.Docs.Snippets");
        SnippetOutputDirectory = Path.Combine(rootLayout.RepositoryRoot, "docs", "output", "help", "obj", "snippets");
    }

    /// <summary>
    /// Creates a layout which has <see cref="SnippetSourceDirectory"/> and <see cref="SnippetOutputDirectory"/> set
    /// appropriately for the snippets in Google.Cloud.Docs.Snippets. All other properties are null.
    /// </summary>
    public static DocsLayout ForHelpSnippets(RootLayout rootLayout) => new(rootLayout, helpSnippetsMarker: null);

    public static DocsLayout ForApi(RootLayout rootLayout, string id) => new(rootLayout, id);

    // Type just to allow us to write a constructor that is obviously geared towards help snippets,
    // and ensure that the calling code is clear too.
    private sealed class HelpSnippetsMarker { }
}
