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
/// Directory layout for a single API, suitable for scenarios involving generated code.
/// (Handwritten API-specific code may not be available.)
/// </summary>
public class GeneratorApiLayout
{
    /// <summary>
    /// Root of all source for this API, including production code, tests, snippets etc.
    /// </summary>
    public string SourceDirectory => Path.Combine(_rootLayout.GeneratorOutput, "apis", Id);

    /// <summary>
    /// Directory for production source code for the library.
    /// </summary>
    public string ProductionDirectory => Path.Combine(SourceDirectory, Id);

    /// <summary>
    /// Directory for snippets for the library, including hand-written snippets.
    /// </summary>
    public string SnippetsDirectory => Path.Combine(SourceDirectory, $"{Id}.Snippets");

    /// <summary>
    /// Directory for purely generated snippets for the library.
    /// </summary>
    public string GeneratedSnippetsDirectory => Path.Combine(SourceDirectory, $"{Id}.GeneratedSnippets");

    /// <summary>
    /// Directory for unit tests.
    /// </summary>
    public string UnitTestsDirectory => Path.Combine(SourceDirectory, $"{Id}.Tests");

    /// <summary>
    /// Directory for integration tests.
    /// </summary>
    public string IntegrationTestsDirectory => Path.Combine(SourceDirectory, $"{Id}.IntegrationTests");

    /// <summary>
    /// Location of API-specific tweaks for this API.
    /// </summary>
    public string TweaksDirectory => Path.Combine(_rootLayout.GeneratorInput, "tweaks", Id);

    /// <summary>
    /// ID of the API.
    /// </summary>
    public string Id { get; }

    private readonly RootLayout _rootLayout;

    private GeneratorApiLayout(RootLayout rootLayout, string id)
    {
        _rootLayout = rootLayout;
        Id = id;
    }

    internal static GeneratorApiLayout Create(RootLayout rootLayout, string id) => new(rootLayout, id);
}
