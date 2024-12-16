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
/// Directory layout for a single API, suitable for scenarios which expect the whole repository
/// to be available.
/// </summary>
public class RepositoryApiLayout
{
    /// <summary>
    /// Root of all source for this API, including production code, tests, snippets etc.
    /// </summary>
    public string SourceDirectory => Path.Combine(_rootLayout.RepositoryRoot, "apis", Id);

    /// <summary>
    /// Directory for production source code for the library.
    /// (This is derived from <see cref="RootLayout.GeneratorOutput">.)
    /// </summary>
    public string ProductionDirectory => Path.Combine(SourceDirectory, Id);

    /// <summary>
    /// ID of the API.
    /// </summary>
    public string Id { get; }

    private readonly RootLayout _rootLayout;

    private RepositoryApiLayout(RootLayout rootLayout, string id)
    {
        _rootLayout = rootLayout;
        Id = id;
    }

    internal static RepositoryApiLayout Create(RootLayout rootLayout, string id) => new(rootLayout, id);

    /// <summary>
    /// Creates a <see cref="DocsLayout"/> which is aware of the location of documentation-related directories.
    /// </summary>
    public DocsLayout CreateDocsLayout() => DocsLayout.ForApi(_rootLayout, Id);

    /// <summary>
    /// Returns the filename of the built (but not published) assembly for the given target framework moniker.
    /// </summary>
    public string GetReleaseAssembly(string tfm) => Path.Combine(ProductionDirectory, "bin", "Release", tfm, $"{Id}.dll");

    /// <summary>
    /// Returns the filename of the published assembly for the given target framework moniker.
    /// </summary>
    public string GetPublishedAssembly(string tfm) => Path.Combine(ProductionDirectory, "bin", "Release", tfm, "publish", $"{Id}.dll");
}
