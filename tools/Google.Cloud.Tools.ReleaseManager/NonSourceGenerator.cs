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

using Google.Cloud.Tools.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Generator for everything which isn't source code:
///
/// - Project files
/// - Solution files
/// - Repo metadata
/// - Documentation stubs
/// - OwlBot configuration
///
/// This is effectively the business logic underlying <see cref="GenerateProjectsCommand"/>,
/// but designed for use from multiple places.
///
/// This class is also responsible for being able to clean up anything it created.
/// </summary>
internal sealed class NonSourceGenerator
{
    internal const string ProjectVersionValue = "project";
    internal const string DefaultVersionValue = "default";
    internal const string DefaultNetstandardTarget = "netstandard2.0";

    private const string ClientTestingName = "Google.Cloud.ClientTesting";
    private const string RootRelativeClientTestingDirectory = @"..\..\tools\Google.Cloud.ClientTesting";

    /// <summary>
    /// In "new major version mode", *all* references between different APIs become project references
    /// in the csproj file, and all GAX/gRPC references are treated as being for the default versions,
    /// regardless of anything explicitly specified. This makes it easier to create new major versions
    /// without manually changing apis.json.
    /// </summary>
    /// <remarks>This isn't a constant, as otherwise the compiler complains about unreachable code.</remarks>
    private static readonly bool NewMajorVersionMode = false;

    private static readonly Regex AnyVersionPattern = new Regex(@"^[0-9]\d*\.\d+\.\d+(\.\d+)?(-.*)?$");
    private static readonly Regex AnyDesktopFramework = new Regex(@";net4\d+");

    // Project references which don't just follow the pattern of ..\..\{package}\{package}\{package}.csproj
    private static readonly Dictionary<string, string> KnownProjectReferences = new Dictionary<string, string>
    {
        { ClientTestingName, $"..\\{RootRelativeClientTestingDirectory}\\{ClientTestingName}.csproj"},
        { "Google.Cloud.Diagnostics.Common.Tests", @"..\..\Google.Cloud.Diagnostics.Common\Google.Cloud.Diagnostics.Common.Tests\Google.Cloud.Diagnostics.Common.Tests.csproj" },
        { "Google.Cloud.Diagnostics.Common.IntegrationTests", @"..\..\Google.Cloud.Diagnostics.Common\Google.Cloud.Diagnostics.Common.IntegrationTests\Google.Cloud.Diagnostics.Common.IntegrationTests.csproj" }
    };

    private static readonly Dictionary<ApiType, string> PackageTypeToDefaultTargetFrameworks = new Dictionary<ApiType, string>
    {
        { ApiType.Rest, $"{DefaultNetstandardTarget};net462" },
        { ApiType.Grpc, $"{DefaultNetstandardTarget};net462" },
        { ApiType.Regapic, $"{DefaultNetstandardTarget};net462" },
        { ApiType.Other, $"{DefaultNetstandardTarget};net462" }
    };

    private const string DefaultTestTargetFrameworks = "net6.0;net462";

    private static readonly Dictionary<ApiType, string[]> PackageTypeToImplicitDependencies = new Dictionary<ApiType, string[]>
    {
        {  ApiType.Rest, new[] { "Google.Api.Gax.Rest" } },
        {  ApiType.Grpc, new[] { "Grpc.Core", "Google.Api.Gax.Grpc" } },
        {  ApiType.Regapic, new[] { "Google.Api.Gax.Grpc" } },
    };

    private const string GrpcCorePackage = "Grpc.Core";
    private const string GrpcCorePackageConditionFramework = "net462";

    // These are the packages where in "new major version mode" we ignore overrides, and always use the defaults.
    private static readonly HashSet<string> NewMajorVersionDefaultPackages = new()
    {
        "Google.Api.Gax",
        "Google.Api.Gax.Rest",
        "Google.Api.Gax.Grpc",
        "Google.Api.Gax.Testing",
        "Google.Api.Gax.Grpc.Testing",
        GrpcCorePackage,
        "Grpc.Core.Testing",
        "Google.Api.CommonProtos",
        "Google.Protobuf",
    };

    // Hard-coded versions for all test packages. These can be defaulted even for stable packages, whereas
    // the packages in DefaultPackageVersions should be specified precisely in stable packages.
    private static readonly Dictionary<string, string> CommonTestDependencies = new Dictionary<string, string>
    {
        { ClientTestingName, ProjectVersionValue }, // Needed for all snippets and some other tests - easiest to just default
        // These versions are in the top-level Directory.Build.props
        { "Microsoft.NET.Test.Sdk", DefaultVersionValue },
        { "xunit", DefaultVersionValue },
        { "xunit.runner.visualstudio", DefaultVersionValue },
        { "Xunit.SkippableFact", DefaultVersionValue },
        { "NSubstitute", DefaultVersionValue },
        { "System.Linq.Async", DefaultVersionValue },
    };

    // Hard-coded versions for dependencies for production packages that can be updated arbitrarily, as their assets are all private.
    // The relationship between this and PrivateAssets is tested on startup.
    private static readonly Dictionary<string, string> CommonHiddenProductionDependencies = new Dictionary<string, string>
    {
        { ConfigureAwaitAnalyzer, DefaultVersionValue },
    };

    private const string ConfigureAwaitAnalyzer = "ConfigureAwaitChecker.Analyzer";
    private const string CSharpWorkspacesPackage = "Microsoft.CodeAnalysis.CSharp.Workspaces";

    /// <summary>
    /// For packages which need a PrivateAssets attribute in dependencies, this dictionary provides the value of the attribute.
    /// </summary>
    private static readonly Dictionary<string, string> PrivateAssets = new Dictionary<string, string>
    {
        { GrpcCorePackage, "None" },
        { ConfigureAwaitAnalyzer, "All" },
        { CSharpWorkspacesPackage, "All" }
    };

    /// <summary>
    /// Packages which are okay to keep using defaults even in patch versions, as they don't affect the released library.
    /// </summary>
    private static readonly HashSet<string> PermittedPatchDefaultDependencies = new() { ConfigureAwaitAnalyzer };

    private static readonly IReadOnlyList<string> RenovateIgnorePaths = new List<string>
        {
            "issues/**"
        }.AsReadOnly();

    public ApiCatalog ApiCatalog { get; }
    public RootLayout RootLayout { get; }

    /// <summary>
    /// This is in lieu of a unit test... just make sure that all the dependencies we're hard-coding the values for
    /// really do hide all their assets.
    /// </summary>
    static NonSourceGenerator()
    {
        var brokenDependencies = CommonHiddenProductionDependencies.Keys.Where(p => !PrivateAssets.ContainsKey(p) || PrivateAssets[p] != "All").ToList();
        if (brokenDependencies.Any())
        {
            throw new Exception($"ProjectGenerator error: invalid CommonHiddenProductionDependencies: {string.Join(", ", brokenDependencies)}");
        }
    }

    internal NonSourceGenerator(RootLayout rootLayout)
    {
        RootLayout = rootLayout;
        ApiCatalog = ApiCatalog.Load(rootLayout);
    }

    #region API-specific files
    /// <summary>
    /// Generates all files specific to an API:
    /// - Project files
    /// - Solution files
    /// - Repo metadata
    /// - Documentation stubs
    /// - OwlBot configuration
    /// </summary>
    /// <param name="api"></param>
    internal void GenerateApiFiles(ApiMetadata api)
    {
        HashSet<string> apiNames = ApiCatalog.CreateIdHashSet();

        GenerateProjects(api, apiNames);
        GenerateSolutionFile(api);
        GenerateOwlBotConfiguration(api);
        GenerateMetadataFile(api);
    }

    private void GenerateProjects(ApiMetadata api, HashSet<string> apiNames)
    {
        var apiLayout = RootLayout.CreateGeneratorApiLayout(api);
        var projects = api.DeriveProjects();
        foreach (var projectName in projects)
        {
            if (!projectName.StartsWith(api.Id, StringComparison.Ordinal))
            {
                continue;
            }
            string suffix = projectName[api.Id.Length..];
            switch (suffix)
            {
                case "":
                    GenerateMainProject();
                    break;
                case ".Tests":
                case ".IntegrationTests":
                case ".Snippets":
                case ".GeneratedSnippets":
                    GenerateTestProject(projectName);
                    break;
            }
        }

        void GenerateMainProject()
        {
            if (api.Version == null)
            {
                throw new UserErrorException($"No version specified for {api.Id}");
            }
            string targetFrameworks = api.TargetFrameworks ?? PackageTypeToDefaultTargetFrameworks.GetValueOrDefault(api.Type);

            var dependencies = new SortedList<string, string>(CommonHiddenProductionDependencies, StringComparer.Ordinal);

            // Default dependencies by package type
            if (PackageTypeToImplicitDependencies.TryGetValue(api.Type, out var implicitDependencies))
            {
                foreach (var dependency in implicitDependencies)
                {
                    dependencies[dependency] = DefaultVersionValue;
                }
            }

            // Deliberately not using Add, so that a project can override the defaults.
            foreach (var dependency in api.Dependencies)
            {
                dependencies[dependency.Key] = !NewMajorVersionMode ? dependency.Value
                    : NewMajorVersionDefaultPackages.Contains(dependency.Key) ? DefaultVersionValue
                    : apiNames.Contains(dependency.Key) ? ProjectVersionValue
                    : dependency.Value;
            }

            var propertyGroup = new XElement("PropertyGroup",
                // Build-related properties
                new XElement("Version", api.Version), // TODO: Version, or VersionPrefix/VersionSuffix?
                new XElement("TargetFrameworks", targetFrameworks),
                new XElement("GenerateDocumentationFile", true),
                // Package-related properties
                new XElement("Description", api.Description),
                new XElement("PackageTags", string.Join(";", api.Tags.Concat(new[] { "Google", "Cloud" })))
            );
            var dependenciesElement = CreateDependenciesElement(api.Id, dependencies, api.StructuredVersion, testProject: false);
            WriteProjectFile(api.Id, propertyGroup, dependenciesElement);
        }

        void GenerateTestProject(string projectName)
        {
            var dependencies = new SortedList<string, string>(CommonTestDependencies, StringComparer.Ordinal);
            dependencies.Add(api.Id, "project");

            // Deliberately not using Add, so that a project can override the defaults.
            foreach (var dependency in api.TestDependencies)
            {
                dependencies[dependency.Key] = !NewMajorVersionMode ? dependency.Value
                        : NewMajorVersionDefaultPackages.Contains(dependency.Key) ? DefaultVersionValue
                        : apiNames.Contains(dependency.Key) ? ProjectVersionValue
                        : dependency.Value;
            }

            var testTargetFrameworks = api.TestTargetFrameworks ?? DefaultTestTargetFrameworks;
            var propertyGroup =
                new XElement("PropertyGroup",
                    new XElement("TargetFrameworks", testTargetFrameworks),
                    // Note: this would normally be TestTargetFrameworks, but that appears to be broken in .NET 6. I don't know why.
                    new XElement("TargetFrameworks", new XAttribute("Condition", " '$(OS)' != 'Windows_NT' "), AnyDesktopFramework.Replace(testTargetFrameworks, "")),
                    new XElement("IsPackable", false),
                    // 1701, 1702 and 1705 are disabled by default.
                    // xUnit2004 prevents Assert.Equal(true, value) etc, preferring Assert.True and Assert.False, but
                    //   Assert.Equal is clearer (IMO) for comparing values rather than conditions.
                    // xUnit2013 prevents simple checks for the number of items in a collection
                    new XElement("NoWarn", "1701;1702;1705;xUnit2004;xUnit2013")
                );
            var dependenciesElement = CreateDependenciesElement(projectName, dependencies, api.StructuredVersion, testProject: true);
            // Test service... it keeps on getting added by Visual Studio, so let's just include it everywhere.
            dependenciesElement.Add(new XElement("Service", new XAttribute("Include", "{82a7f48d-3b50-4b1e-b82e-3ada8210c358}")));
            WriteProjectFile(projectName, propertyGroup, dependenciesElement);
        }

        void WriteProjectFile(string projectName, XElement propertyGroup, XElement dependenciesItemGroup)
        {
            var directory = Path.Combine(apiLayout.SourceDirectory, projectName);
            Directory.CreateDirectory(directory);
            var doc = new XElement("Project",
                    new XAttribute("Sdk", "Microsoft.NET.Sdk"),
                    propertyGroup,
                    dependenciesItemGroup);

            // To keep generator inputs and outputs cleanly separated, we look for an augmentation file
            // with a ".csproj.google" extension in the API-specific "tweaks" directory (under generator-input/tweaks).
            // If this exists, it's expected to be an XML file, and any elements under the root
            // are included in the generated .csproj file.
            var augmentationFile = Path.Combine(RootLayout.CreateGeneratorApiLayout(api).TweaksDirectory, $"{projectName}.csproj.google");
            if (File.Exists(augmentationFile))
            {
                var augmentationDoc = XDocument.Load(augmentationFile);
                doc.Add(augmentationDoc.Root.Elements());
            }

            // Don't use File.CreateText as that omits the byte order mark.
            // While byte order marks are nasty, Visual Studio will add it back any time a project file is
            // manually edited, so it's best if we follow suit.
            var file = Path.Combine(directory, $"{projectName}.csproj");
            using (var stream = File.Create(file))
            {
                doc.Save(stream);
            }
        }

        XElement CreateDependenciesElement(string project, IDictionary<string, string> dependencies, StructuredVersion projectVersion, bool testProject) =>
            new XElement("ItemGroup",
                // Use the GAX version for all otherwise-unversioned GAX dependencies
                dependencies.Select(pair => CreateDependencyElement(project, pair.Key, pair.Value, projectVersion, testProject)));

        /// <summary>
        /// Creates a single XElement for a dependency. This can be a package reference or a project reference:
        /// - If the version is "project" it will be handled as a project reference:
        ///   - The project must be known, either as the ID of an API or a member of <see cref="KnownProjectReferences"/>
        /// - If the version is "default" it will be handled as a package reference to a common package, e.g. Grpc.Core or GAX
        ///   with the version automatically populated. This is only valid for prereleases; stable packages must specify
        ///   a version number (so that it's not accidentally increased)
        /// - Otherwise, it will be treated as a package reference with the 
        /// </summary>
        /// <param name="project">The project depending on <paramref name="package"/></param>
        /// <param name="package">Package name of dependency</param>
        /// <param name="dependencyVersion">Version of dependency, or "project" or "default"</param>
        /// <param name="projectVersion">Version of <paramref name="project"/>.</param>
        /// <param name="allowDefaultVersions">Whether to allow default versions for </param>
        /// <param name="apiNames">Names of all APIs in apis.json, valid for project references</param>
        /// <returns>The element to include in the project file to represent the dependency</returns>
        XElement CreateDependencyElement(string project, string package, string dependencyVersion, StructuredVersion projectVersion, bool testProject)
        {
            if (dependencyVersion == ProjectVersionValue)
            {
                string path;
                if (apiNames.Contains(package))
                {
                    // Simplify path for test packages - no need to go all the way back to the api directory
                    path = project.StartsWith(package + ".")
                        ? $@"..\{package}\{package}.csproj"
                        : $@"..\..\{package}\{package}\{package}.csproj";
                }
                else if (KnownProjectReferences.ContainsKey(package))
                {
                    path = KnownProjectReferences[package];
                }
                else
                {
                    throw new UserErrorException($"Invalid project reference from {project} to {package}");
                }
                return new XElement("ProjectReference", new XAttribute("Include", path));
            }

            // TODO: Maybe remove this requirement, if it becomes too onerous and we don't see much benefit.
            // If we improved our diffing to include dependency versions, that might give a better way of guarding
            // against accidentally updating dependency versions in patches (which is what this is for).
            if (dependencyVersion == DefaultVersionValue && projectVersion.IsStable && projectVersion.Patch > 0 &&
                !testProject && !PermittedPatchDefaultDependencies.Contains(package))
            {
                throw new UserErrorException($"Project {project} cannot use the default version for {package}. (Stable patch releases must list dependencies explicitly.)");
            }

            PrivateAssets.TryGetValue(package, out string privateAssetValue);

            // Extra validation for overrides
            if (dependencyVersion != DefaultVersionValue)
            {
                if (!IsValidVersion())
                {
                    throw new UserErrorException($"Project {project} has invalid version '{dependencyVersion}' for package {package}");
                }
                // Dependencies from production projects, other than "hidden" packages, must be stable
                if (projectVersion.IsStable && !testProject && !StructuredVersion.FromString(dependencyVersion).IsStable && privateAssetValue != "All")
                {
                    throw new UserErrorException($"Project {project} uses prerelease version '{dependencyVersion}' for package {package}");
                }
            }
            var element = new XElement("PackageReference", new XAttribute("Include", package), MaybeGetVersionOverrideAttribute(package, dependencyVersion));
            if (privateAssetValue != null)
            {
                element.Add(new XAttribute("PrivateAssets", privateAssetValue));
            }

            // We only include Grpc.Core when targeting .NET Framework.
            // While in an ideal world we'd pull the condition frameworks from the project we're generating, that's
            // awkward and in reality the only .NET Framework version we target now is .NET 4.6.2.
            if (package == GrpcCorePackage)
            {
                element.Add(new XAttribute("Condition", $"'$(TargetFramework)'=='{GrpcCorePackageConditionFramework}'"));
            }

            return element;

            bool IsValidVersion() => AnyVersionPattern.IsMatch(dependencyVersion);

            // We only need a VersionOverride for packages that aren't overriding the version in the API catalog.
            // (We don't detect if the "override" is actually just to use the default version from Directory.Packages.props -
            // that could be checked for in a different tool though.)
            static XAttribute MaybeGetVersionOverrideAttribute(string package, string version) =>
                version == DefaultVersionValue
                ? null
                : new XAttribute("VersionOverride", GetDependencyVersionRange(package, version));

            // Returns the appropriate version to include in a package dependency.
            // For Google.* and Grpc.*, this is major-version pinned. For other packages, we just leave it as the version
            // specified in the string - as some packages are fine to upgrade beyond major version boundaries.
            static string GetDependencyVersionRange(string package, string specifiedVersion)
            {
                if (!(package.StartsWith("Google.") || package.StartsWith("Grpc.")))
                {
                    return specifiedVersion;
                }
                var structuredVersion = StructuredVersion.FromString(specifiedVersion);
                var nextMajor = StructuredVersion.FromMajorMinorPatchBuild(structuredVersion.Major + 1, 0, 0, structuredVersion.Build is null ? default(int?) : 0, null);
                return $"[{structuredVersion}, {nextMajor})";
            }
        }
    }

    // Note: we generate the solution file from scratch so that
    // we get consistent project IDs (hashed from the project name).
    // This also means we don't need the project files to exist before we
    // create the solution file (as they may be handwritten projects).
    // Currently this is really ugly - it will be a lot cleaner with slnx files.
    private void GenerateSolutionFile(ApiMetadata api)
    {
        var apiLayout = RootLayout.CreateGeneratorApiLayout(api);
        string solutionFile = Path.Combine(apiLayout.SourceDirectory, $"{api.Id}.sln");
        List<string> projectDirectories = new();
        foreach (var project in api.DeriveProjects())
        {
            projectDirectories.Add(project);
        }
        if (api.DeriveProjects().Any(p => p.EndsWith("Tests", StringComparison.Ordinal) || p.EndsWith("Snippets", StringComparison.Ordinal)))
        {
            projectDirectories.Add(RootRelativeClientTestingDirectory);
        }
        foreach (var pair in api.Dependencies.Where(pair => pair.Value == ProjectVersionValue))
        {
            string dependencyId = pair.Key;
            projectDirectories.Add($@"..\{dependencyId}\{dependencyId}");
        }
        GenerateSolutionFile(solutionFile, projectDirectories);
    }

    internal static void GenerateSolutionFile(string file, List<string> projectDirectories)
    {
        string[] prefixLines =
        {
            "\uFEFF", // Byte order mark (on a line on its own), not written by File.WriteAllLines
            "Microsoft Visual Studio Solution File, Format Version 12.00",
            "# Visual Studio Version 17",
            "VisualStudioVersion = 17.2.32516.85",
            "MinimumVisualStudioVersion = 10.0.40219.1"
        };
        List<string> projectLines = new();
        string[] betweenLines =
        {
            "Global",
            "    GlobalSection(SolutionConfigurationPlatforms) = preSolution",
            "        Debug|Any CPU = Debug|Any CPU",
            "        Release|Any CPU = Release|Any CPU",
            "    EndGlobalSection",
            "    GlobalSection(ProjectConfigurationPlatforms) = postSolution"
        };
        List<string> postSolutionLines = new();
        string[] suffixLines =
        {
            "    EndGlobalSection",
            "EndGlobal"
        };

        foreach (var directory in projectDirectories)
        {
            // We assume we always follow the convention of the project name (including the csproj file)
            // being the same as the name of the directory.
            // On Windows, Path.GetFileName is fine with /-separated directories, whereas
            // on Linux, it doesn't "know" that backslash is a separator. Normalize to slashes just to find the name.
            string name = Path.GetFileName(directory.Replace('\\', '/'));
            var guid = GenerateGuid(name).ToString().ToUpperInvariant();
            projectLines.Add($"Project(\"{{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}}\") = \"{name}\", \"{directory}\\{name}.csproj\", \"{{{guid}}}\"");
            projectLines.Add("EndProject");
            postSolutionLines.Add($"        {{{guid}}}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            postSolutionLines.Add($"        {{{guid}}}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            postSolutionLines.Add($"        {{{guid}}}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            postSolutionLines.Add($"        {{{guid}}}.Release|Any CPU.Build.0 = Release|Any CPU");

            static Guid GenerateGuid(string name)
            {
                // Note: We're using MD5 to get 16 bytes for the GUID.
                // This is only meant to be unique - it doesn't need to be cryptographically secure at all.
                var bytes = MD5.HashData(Encoding.UTF8.GetBytes(name));
                return new Guid(bytes);
            }
        }

        var allLines = prefixLines.Concat(projectLines).Concat(betweenLines).Concat(postSolutionLines).Concat(suffixLines);
        // Note: this deliberately uses the platform-default line ending. That's how our git repository is set up (core.crlf)
        // so we *expect* to have CRLF on Windows and LF on Linux. We have GitHub actions to detect any CRLF files in a PR,
        // so we need to make sure that when an action on Linux rewrites solution files, it doesn't actually change anything.
        File.WriteAllLines(file, allLines);
    }

    private void GenerateOwlBotConfiguration(ApiMetadata api)
    {
        var apiLayout = RootLayout.CreateGeneratorApiLayout(api);
        var owlBotConfigFile = Path.Combine(apiLayout.SourceDirectory, ".OwlBot.yaml");
        var owlBotForceRegenerationFile = Path.Combine(apiLayout.SourceDirectory, ".OwlBot-ForceRegeneration.txt");
        // We will recreate this if necessary.
        File.Delete(owlBotForceRegenerationFile);
        if (api.Generator == GeneratorType.None)
        {
            // Clean up any previous OwlBot configuration
            File.Delete(owlBotConfigFile);
            return;
        }
        string content =
$@"
# Copyright {DateTime.UtcNow.Year} Google LLC
#
# Licensed under the Apache License, Version 2.0 (the ""License"");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an ""AS IS"" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

squash: true

deep-remove-regex:
    - /owl-bot-staging

deep-copy-regex:
    - source: /{api.ProtoPath}/.*-csharp/{api.Id}
      dest: /owl-bot-staging/{api.Id}/{api.Id}
    - source: /{api.ProtoPath}/.*-csharp/{api.Id}.Snippets
      dest: /owl-bot-staging/{api.Id}/{api.Id}.Snippets
    - source: /{api.ProtoPath}/.*-csharp/{api.Id}.GeneratedSnippets
      dest: /owl-bot-staging/{api.Id}/{api.Id}.GeneratedSnippets
    - source: /{api.ProtoPath}/.*-csharp/gapic_metadata.json
      dest: /owl-bot-staging/{api.Id}/gapic_metadata.json

api-name: {api.Id}
";
        File.WriteAllText(owlBotConfigFile, content);

        var forceRegenerationReasons = new List<string>();
        if (File.Exists(Path.Combine(apiLayout.TweaksDirectory, "pregeneration.sh")))
        {
            forceRegenerationReasons.Add("API requires pre-generation tweaks.");
        }
        if (api.CommonResourcesConfig is object)
        {
            forceRegenerationReasons.Add("API uses a custom resources configuration.");
        }
        if (api.ForceOwlBotRegeneration is string reason)
        {
            forceRegenerationReasons.Add(reason);
        }
        if (forceRegenerationReasons.Any())
        {
            File.WriteAllLines(owlBotForceRegenerationFile, forceRegenerationReasons);
        }
    }

    /// <summary>
    /// Generates a metadata file (currently .repo-metadata.json; may change name later) with
    /// all the information that language-agnostic tools require.
    /// </summary>
    private void GenerateMetadataFile(ApiMetadata api)
    {
        var apiLayout = RootLayout.CreateGeneratorApiLayout(api);
        string metadataPath = Path.Combine(apiLayout.SourceDirectory, ".repo-metadata.json");
        var version = api.StructuredVersion;
        string versionBasedReleaseLevel =
            // Version "1.0.0-beta00" hasn't been released at all, so we don't have a package to talk about.
            (version.Prerelease ?? "").EndsWith("00") && version.Major == 1 && version.Minor == 0 ? "unreleased"
            // If it's not a prerelease now, or it's ever got to 1.0, it's generally "ga"
            : version.Major > 1 || version.Minor > 0 || version.Prerelease == null ? "stable"
            : "preview";

        string releaseLevel = api.ReleaseLevelOverride ?? versionBasedReleaseLevel;
        var metadata = new JObject
        {
            ["distribution_name"] = api.Id,
            ["release_level"] = releaseLevel,
            ["client_documentation"] = ApiMetadata.IsCloudPackage(api.Id) ? $"https://cloud.google.com/dotnet/docs/reference/{api.Id}/latest" : $"https://googleapis.dev/dotnet/{api.Id}/latest",
            ["library_type"] = api.EffectiveMetadataType,
            ["language"] = "dotnet"
        };
        if (api.ShortName is object)
        {
            metadata["api_shortname"] = api.ShortName;
        }
        string json = JsonConvert.SerializeObject(metadata, Formatting.Indented);
        File.WriteAllText(metadataPath, json);
    }
    #endregion

    #region Non-API-specific files
    /// <summary>
    /// Generates files which aren't specific to any API:
    ///
    /// - README.md
    /// - .github/renovate.json
    /// </summary>
    internal void GenerateNonApiFiles()
    {
        RewriteReadme();
        RewriteRenovate();
    }

    private void RewriteReadme()
    {
        var templatePath = Path.Combine(RootLayout.GeneratorInput, "README-template.md");
        var templateLines = File.ReadAllLines(templatePath).ToList();

        var tableIndex = templateLines.IndexOf("{api-table}");
        if (tableIndex == -1)
        {
            throw new UserErrorException("{api-table} not found in README template.");
        }

        var linesBefore = templateLines.Take(tableIndex).ToList();
        var linesAfter = templateLines.Skip(tableIndex + 1).ToList();

        var table = new List<string>
        {
            "| Package | Latest version | Description |",
            "|---------|----------------|-------------|"
        };

        var ambiguousDescriptions = ApiCatalog.Apis
            .Select(api => api.EffectiveListingDescription)
            .GroupBy(description => description)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();
        foreach (var api in ApiCatalog.Apis)
        {
            // TODO: What about 2.0.0-beta00 etc? We'd need to know what version to link to.
            // We can cross that bridge when we come to it.
            if (api.Version == "1.0.0-beta00" || api.Version == "1.0.0-alpha00" || api.ReleaseLevelOverride == "unreleased")
            {
                continue;
            }
            string url = ApiMetadata.IsCloudPackage(api.Id)
                ? $"https://cloud.google.com/dotnet/docs/reference/{api.Id}/latest"
                : $"https://googleapis.dev/dotnet/{api.Id}/latest";
            string referenceDocsLink = $"[{api.Id}]({url})";

            string packageLinkAndBadge = $"[![NuGet](https://img.shields.io/nuget/v/{api.Id})](https://nuget.org/packages/{api.Id})";

            // Disambiguate direct API packages for the same product.
            string description = api.EffectiveListingDescription;
            if (ambiguousDescriptions.Contains(description) && api.ApiVersion is string apiVersion)
            {
                description += $" ({apiVersion} API)";
            }

            // TODO: It gets awkward when there are multiple description for the same product (e.g. Spanner).
            // This is basically caused by conflating "link to product docs" with "package description", but
            // in most cases that simplifies things. Never mind.
            string productLink = api.ProductUrl is null
                ? api.ListingDescription ?? api.ProductName ?? api.Description.TrimEnd('.') // No URL
                : $"[{description}]({api.ProductUrl})";
            table.Add($"| {referenceDocsLink} | {packageLinkAndBadge} | {productLink} |");
        }

        var newContent = linesBefore.Concat(table).Concat(linesAfter);
        var outputPath = Path.Combine(RootLayout.GeneratorOutput, "README.md");
        File.WriteAllLines(outputPath, newContent);
    }

    // TODO: It would be nice if we could configure renovate more statically than this.
    // We should see how our change to use centrally-managed versions (and more defaulting)
    // affects this.
    private void RewriteRenovate()
    {
        string templatePath = Path.Combine(RootLayout.GeneratorInput, "renovate-template.json");
        string json = File.ReadAllText(templatePath);
        JObject jobj = JObject.Parse(json);
        JArray ignorePaths = (JArray) jobj["ignorePaths"];
        foreach (var api in ApiCatalog.Apis)
        {
            ignorePaths.Add($"apis/{api.Id}/{api.Id}/**");
        }
        json = jobj.ToString(Formatting.Indented);

        string outputPath = Path.Combine(RootLayout.GeneratorOutput, ".github", "renovate.json");
        Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
        File.WriteAllText(outputPath, json);
    }
    #endregion

    #region Clean-up
    public void CleanApiFiles(ApiMetadata api)
    {
        var apiLayout = RootLayout.CreateGeneratorApiLayout(api);

        // We just try to delete everything we *might* generate, whether it exists or not.
        DeleteRelative($"{api.Id}.sln");
        DeleteRelative(".repo-metadata.json");
        DeleteRelative(".repo-metadata.json");
        DeleteRelative(".OwlBot.yaml");
        DeleteRelative(".OwlBot-ForceRegeneration.txt");

        DeleteProject(apiLayout.ProductionDirectory);
        DeleteProject(apiLayout.UnitTestsDirectory);
        DeleteProject(apiLayout.IntegrationTestsDirectory);
        DeleteProject(apiLayout.GeneratedSnippetsDirectory);
        DeleteProject(apiLayout.SnippetsDirectory);

        void DeleteProject(string directory)
        {
            string name = Path.GetFileName(directory.Replace('\\', '/'));
            MaybeDelete(Path.Combine(directory, $"{name}.csproj"));
        }

        void DeleteRelative(string relativeFile) => MaybeDelete(Path.Combine(apiLayout.SourceDirectory, relativeFile));

        void MaybeDelete(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }
    }

    public void CleanNonApiFiles()
    {
        File.Delete(Path.Combine(RootLayout.GeneratorOutput, "README.md"));
        File.Delete(Path.Combine(RootLayout.GeneratorOutput, ".github", "renovate.json"));
    }
    #endregion
}
