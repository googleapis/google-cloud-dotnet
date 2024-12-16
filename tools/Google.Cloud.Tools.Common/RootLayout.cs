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
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Google.Cloud.Tools.Common;

/// <summary>
/// Information about how "root" directories are laid out on disk, notably:
/// - googleapis
/// - generator-input
/// - generator output
/// - repository root
///
/// Not all directory names are present in all contexts. Attempting to fetch a "missing" directory
/// will throw an exception. All properties return absolute paths.
/// </summary>
public sealed class RootLayout
{
    /// <summary>
    /// Directory for generator input, relative to the root.
    /// </summary>
    internal const string GeneratorInputName = "generator-input";

    private static string cachedRoot;

    private readonly string _repositoryRoot;
    private readonly string _generatorInput;
    private readonly string _generatorOutput;
    private readonly string _googleapis;

    private RootLayout(string repositoryRoot, string generatorInput, string generatorOutput, string googleapis)
    {
        _repositoryRoot = repositoryRoot;
        _generatorInput = generatorInput;
        _generatorOutput = generatorOutput;
        _googleapis = googleapis;
    }

    /// <summary>
    /// Directory to retrieve all generator input from: the API catalog, API-specific tweaks etc.
    /// </summary>
    public string GeneratorInput => FailIfAbsent(_generatorInput);
    /// <summary>
    /// Root of the directory tree to write all generator output to.
    /// </summary>
    public string GeneratorOutput => FailIfAbsent(_generatorOutput);
    /// <summary>
    /// Root of a clone of the googleapis repo, for API definitions (protos etc).
    /// </summary>
    public string Googleapis => FailIfAbsent(_googleapis);
    /// <summary>
    /// Root of the local clone of google-cloud-dotnet.
    /// </summary>
    public string RepositoryRoot => FailIfAbsent(_repositoryRoot);

    private static string FailIfAbsent(string value, [CallerMemberName] string caller = null) =>
        value ?? throw new InvalidOperationException($"Directory '{caller}' is not specified in this layout.");

    /// <summary>
    /// Returns a layout derived from finding the repository root relative to
    /// the current directory, which is expected to be within the repository.
    /// Generation is performed in-place, with googleapis as a git-ignored child
    /// directory. This is typically used for ReleaseManager commands.
    /// </summary>
    public static RootLayout ForCurrentDirectory()
    {
        var repoRoot = DetermineRootDirectory();
        return new RootLayout(repoRoot, Path.Combine(repoRoot, GeneratorInputName), repoRoot, Path.Combine(repoRoot, "googleapis"));
    }

    /// <summary>
    /// Returns a layout derived from the specified repository root, but not assuming that googleapis
    /// is cloned within it.
    /// </summary>
    public static RootLayout ForRepositoryRoot(string repoRoot) =>
        new RootLayout(repoRoot, Path.Combine(repoRoot, GeneratorInputName), repoRoot, null);

    /// <summary>
    /// Returns a layout suitable for generation tasks. This knows about the generator input, generator output,
    /// and googleapis directory, but does not have a repository root.
    /// </summary>
    public static RootLayout ForGeneration(string generatorInput, string generatorOutput, string googleapis) =>
        new(null, generatorInput, generatorOutput, googleapis);

    /// <summary>
    /// Returns a layout suitable for configuration tasks. This knows about the generator input and googleapis directory,
    /// but does not have a repository root or generator output.
    /// </summary>
    public static RootLayout ForConfiguration(string generatorInput, string googleApis) =>
        new(null, generatorInput, null, googleApis);

    // Convenience methods
    public RepositoryApiLayout CreateRepositoryApiLayout(string id) => RepositoryApiLayout.Create(this, id);
    public RepositoryApiLayout CreateRepositoryApiLayout(ApiMetadata api) => RepositoryApiLayout.Create(this, api.Id);
    public GeneratorApiLayout CreateGeneratorApiLayout(ApiMetadata api) => GeneratorApiLayout.Create(this, api.Id);
    public DocsLayout CreateDocsLayout(string id) => CreateRepositoryApiLayout(id).CreateDocsLayout();
    public DocsLayout CreateDocsLayout(ApiMetadata api) => CreateRepositoryApiLayout(api).CreateDocsLayout();

    /// <summary>
    /// Find the root directory of the project. We expect this to contain "apis" and "LICENSE".
    /// </summary>
    /// <returns></returns>
    private static string DetermineRootDirectory()
    {
        if (cachedRoot is string)
        {
            return cachedRoot;
        }
        var currentDirectory = Path.GetFullPath(".");
        var directory = new DirectoryInfo(currentDirectory);
        while (directory != null &&
            (!File.Exists(Path.Combine(directory.FullName, "LICENSE"))
            || !Directory.Exists(Path.Combine(directory.FullName, "apis"))))
        {
            directory = directory.Parent;
        }
        if (directory == null)
        {
            throw new UserErrorException("Unable to determine root directory. Please run within google-cloud-dotnet repository.");
        }
        cachedRoot = directory.FullName;
        return cachedRoot;
    }
}
