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
    /// (This is derived from <see cref="RootLayout.GeneratorOutput">.)
    /// </summary>
    public string SourceDirectory { get; }

    /// <summary>
    /// Location of API-specific tweaks for this API.
    /// (This is derived from <see cref="RootLayout.GeneratorInput">.)
    /// </summary>
    public string TweaksDirectory { get; }

    /// <summary>
    /// ID of the API.
    /// </summary>
    public string Id { get; }

    private readonly RootLayout _rootLayout;

    private ApiLayout(RootLayout rootLayout, string id)
    {
        _rootLayout = rootLayout;
        SourceDirectory = Path.Combine(rootLayout.GeneratorOutput, "apis", id);
        TweaksDirectory = Path.Combine(rootLayout.GeneratorInput, "tweaks", id);
        Id = id;
    }

    internal static ApiLayout Create(RootLayout rootLayout, string id) => new(rootLayout, id);

    /// <summary>
    /// Creates a <see cref="DocsLayout"/> which is aware of the location of documentation-related directories.
    /// </summary>
    public DocsLayout CreateDocsLayout() => DocsLayout.ForApi(_rootLayout, Id);
}
