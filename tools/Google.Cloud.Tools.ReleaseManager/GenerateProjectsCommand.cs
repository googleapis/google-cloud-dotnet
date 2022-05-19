// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
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
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    public class GenerateProjectsCommand : CommandBase
    {
        /// <summary>
        /// In "new major version mode", *all* references between different APIs become project references
        /// in the csproj file, and all GAX/gRPC references are treated as being for the default versions,
        /// regardless of anything explicitly specified. This makes it easier to create new major versions
        /// without manually changing apis.json.
        /// </summary>
        /// <remarks>This isn't a constant, as otherwise the compiler complains about unreachable code.</remarks>
        private static readonly bool NewMajorVersionMode = true;

        private static readonly Regex AnyVersionPattern = new Regex(@"^[0-9]\d*\.\d+\.\d+(\.\d+)?(-.*)?$");
        private static readonly Regex StableVersionPattern = new Regex(@"^[1-9]\d*\.\d+\.\d+(\.\d+)?$");
        private static readonly Regex AnyDesktopFramework = new Regex(@";net4\d+");

        // Project references which don't just follow the pattern of ..\..\{package}\{package}\{package}.csproj
        private static readonly Dictionary<string, string> KnownProjectReferences = new Dictionary<string, string>
        {
            { "Google.Cloud.AnalyzersTesting", @"..\..\..\tools\Google.Cloud.AnalyzersTesting\Google.Cloud.AnalyzersTesting.csproj" },
            { "Google.Cloud.ClientTesting", @"..\..\..\tools\Google.Cloud.ClientTesting\Google.Cloud.ClientTesting.csproj" },
            { "Google.Cloud.Diagnostics.Common.Tests", @"..\..\Google.Cloud.Diagnostics.Common\Google.Cloud.Diagnostics.Common.Tests\Google.Cloud.Diagnostics.Common.Tests.csproj" },
            { "Google.Cloud.Diagnostics.Common.IntegrationTests", @"..\..\Google.Cloud.Diagnostics.Common\Google.Cloud.Diagnostics.Common.IntegrationTests\Google.Cloud.Diagnostics.Common.IntegrationTests.csproj" },
            { "Google.Cloud.SampleUtil", @"..\..\..\tools\Google.Cloud.SampleUtil\Google.Cloud.SampleUtil.csproj"}
        };

        private static readonly Dictionary<ApiType, string> PackageTypeToDefaultTargetFrameworks = new Dictionary<ApiType, string>
        {
            { ApiType.Rest, "netstandard2.1;net462" },
            { ApiType.Grpc, "netstandard2.1;net462" },
            { ApiType.Regapic, "netstandard2.1;net462" }
        };

        private const string DefaultTestTargetFrameworks = "netcoreapp3.1;net462";

        private static Dictionary<ApiType, string[]> PackageTypeToImplicitDependencies = new Dictionary<ApiType, string[]>
        {
            {  ApiType.Rest, new[] { "Google.Api.Gax.Rest" } },
            {  ApiType.Grpc, new[] { "Grpc.Core", "Google.Api.Gax.Grpc" } },
            {  ApiType.Regapic, new[] { "Google.Api.Gax.Grpc" } },
        };

        // TODO: remove this, as we don't have any analyzers at the moment.
        private const string AnalyzersTargetFramework = "netstandard1.3";
        private const string AnalyzersTestTargetFramework = "netcoreapp2.0";

        private const string ProjectVersionValue = "project";
        private const string DefaultVersionValue = "default";
        private const string GrpcCorePackage = "Grpc.Core";
        private const string GrpcCorePackageConditionFramework = "net462";
        private const string DefaultGaxVersion = "4.0.0-alpha05";
        private const string GrpcVersion = "2.41.0";
        private static readonly Dictionary<string, string> DefaultPackageVersions = new Dictionary<string, string>
        {
            { "Google.Api.Gax", DefaultGaxVersion },
            { "Google.Api.Gax.Rest", DefaultGaxVersion },
            { "Google.Api.Gax.Grpc", DefaultGaxVersion },
            { "Google.Api.Gax.Testing", DefaultGaxVersion },
            { "Google.Api.Gax.Grpc.Testing", DefaultGaxVersion },
            { GrpcCorePackage, GrpcVersion },
            { "Grpc.Core.Testing", GrpcVersion },
            { "Grpc.Core.Api", GrpcVersion },
            { "Google.Api.CommonProtos", "2.5.0" },
            { "Google.Protobuf", "3.18.0" }
        };

        // Hard-coded versions for all analyzer projects.
        private static readonly Dictionary<string, string> CommonAnalyzerDependencies = new Dictionary<string, string>
        {
            { CSharpWorkspacesPackage, "2.4.0" }
        };

        // Hard-coded versions for all test packages. These can be defaulted even for stable packages, whereas
        // the packages in DefaultPackageVersions should be specified precisely in stable packages.
        private static readonly Dictionary<string, string> CommonTestDependencies = new Dictionary<string, string>
        {
            { "Google.Cloud.ClientTesting", ProjectVersionValue }, // Needed for all snippets and some other tests - easiest to just default
            { "Microsoft.NET.Test.Sdk", "17.0.0" },
            { "xunit", "2.4.1" },
            { "xunit.runner.visualstudio", "2.4.3" },
            { "Xunit.SkippableFact", "1.4.13" },
            { "Moq", "4.16.1" },
            { "System.Linq.Async", "5.1.0" },
        };

        // Hard-coded versions for dependencies for production packages that can be updated arbitrarily, as their assets are all private.
        // The relationship between this and PrivateAssets is tested on startup.
        private static readonly Dictionary<string, string> CommonHiddenProductionDependencies = new Dictionary<string, string>
        {
            { ConfigureAwaitAnalyzer, "5.0.0" },
        };

        private static readonly Dictionary<string, string> CommonSampleDependencies = new Dictionary<string, string>
        {
            { "CommandLineParser", "2.8.0" },
            { "Google.Cloud.SampleUtil", "project"},
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

        private const string AnalyzersPath = @"..\..\..\tools\Google.Cloud.Tools.Analyzers\bin\$(Configuration)\netstandard1.3\publish\Google.Cloud.Tools.Analyzers.dll";

        public GenerateProjectsCommand() : base("generate-projects", "Generates project files, coverage files etc from the API catalog")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            ValidateCommonHiddenProductionDependencies();
            var root = DirectoryLayout.DetermineRootDirectory();
            var catalog = ApiCatalog.Load();
            ValidateApiCatalog(catalog);
            Console.WriteLine($"API catalog contains {catalog.Apis.Count} entries");
            // Now we know we can parse the API catalog, let's reformat it.
            ReformatApiCatalog(catalog);
            RewriteReadme(catalog);
            RewriteRenovate(catalog);
            HashSet<string> apiNames = catalog.CreateIdHashSet();

            foreach (var api in catalog.Apis)
            {
                var path = Path.Combine(root, "apis", api.Id);
                GenerateProjects(path, api, apiNames);
                GenerateSolutionFiles(path, api);
                GenerateDocumentationStub(path, api);
                GenerateOwlBotConfiguration(path, api);
                GenerateMetadataFile(path, api);
            }
        }

        /// <summary>
        /// Perform some basic validation of the API catalog. Current validation steps:
        /// - Check that all project dependencies (prod-only; test is fine) are within a package group
        /// </summary>
        private static void ValidateApiCatalog(ApiCatalog catalog)
        {
            foreach (var api in catalog.Apis)
            {
                var projectDependencies = api.Dependencies.Where(d => d.Value == ProjectVersionValue).Select(d => d.Key).ToList();
                if (projectDependencies.Count == 0)
                {
                    continue;
                }
                if (api.PackageGroup is null)
                {
                    throw new UserErrorException($"Package '{api.Id}' cannot have project dependencies as it is not in a package group");
                }
                var badDependencies = projectDependencies.Except(api.PackageGroup.PackageIds).ToList();
                if (badDependencies.Any())
                {
                    throw new UserErrorException($"Package '{api.Id}' has bad project dependencies (outside package group '{api.PackageGroup.Id}': '{string.Join("', '", badDependencies)}'");
                }
            }
        }

        private static void ReformatApiCatalog(ApiCatalog catalog)
        {
            string path = ApiCatalog.CatalogPath;
            string existing = File.ReadAllText(path);
            string formatted = catalog.FormatJson();
            if (existing != formatted)
            {
                File.WriteAllText(path, formatted);
                Console.WriteLine("Reformatted apis.json");
            }
        }

        public static void RewriteReadme(ApiCatalog catalog)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            var readmePath = Path.Combine(root, "README.md");

            var existing = File.ReadAllLines(readmePath).ToList();

            string headerLine = "| Package | Latest version | Description |";
            string headerNext = "|---------|----------------|-------------|";
            int headerIndex = existing.IndexOf(headerLine);

            if (headerIndex == -1)
            {
                throw new UserErrorException($"Header line for library table not found.");
            }

            var linesBefore = existing.Take(headerIndex).ToList();
            var linesAfter = existing.Skip(headerIndex).SkipWhile(line => line.StartsWith("|")).ToList();

            var table = new List<string>();
            table.Add(headerLine);
            table.Add(headerNext);

            var ambiguousDescriptions = catalog.Apis
                .Select(api => api.EffectiveListingDescription)
                .GroupBy(description => description)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
            foreach (var api in catalog.Apis)
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
            if (!existing.SequenceEqual(newContent))
            {
                File.WriteAllLines(readmePath, newContent);
                Console.WriteLine($"Rewrote {Path.GetFileName(readmePath)}");
            }
        }

        public static void RewriteRenovate(ApiCatalog catalog)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            string path = Path.Combine(root, ".github", "renovate.json");
            string json = File.ReadAllText(path);
            JObject jobj = JObject.Parse(json);
            jobj["ignorePaths"] = new JArray(catalog.Apis.Select(api => $"apis/{api.Id}/{api.Id}/**").ToArray());
            json = jobj.ToString(Formatting.Indented);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Updates the dependencies in an API for known packages, but only if the default
        /// version is later than the current one, with the same major version number.
        /// </summary>
        public static void UpdateDependencies(ApiCatalog catalog, ApiMetadata api)
        {
            // Update any previously-defaulted versions to be explicit, if the new version is GA.
            // (This only affects production dependencies, so is not performed in UpdateDependencyDictionary.)
            // Implicit dependencies are always present in DefaultPackageVersions, so we don't need to worry about
            // "internal" dependencies.
            if (api.IsReleaseVersion && PackageTypeToImplicitDependencies.TryGetValue(api.Type, out var implicitDependencies))
            {
                foreach (var implicitDependency in implicitDependencies)
                {
                    if (!api.Dependencies.ContainsKey(implicitDependency))
                    {
                        api.Dependencies[implicitDependency] = DefaultPackageVersions[implicitDependency];
                    }
                }
            }

            UpdateDependencyDictionary(api.Dependencies, "dependencies");
            UpdateDependencyDictionary(api.TestDependencies, "testDependencies");

            void UpdateDependencyDictionary(SortedDictionary<string, string> dependencies, string jsonName)
            {
                if (dependencies.Count == 0)
                {
                    return;
                }

                // We want to update any dependencies to "external" packages as listed in DefaultPackageVersions,
                // but also "internal" packages such as Google.LongRunning.
                Dictionary<string, string> allDefaultPackageVersions = DefaultPackageVersions
                    .Concat(catalog.Apis.Select(api => new KeyValuePair<string, string>(api.Id, api.Version)))
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var package in dependencies.Keys.ToList())
                {
                    if (allDefaultPackageVersions.TryGetValue(package, out var defaultVersion))
                    {
                        var currentVersion = dependencies[package];
                        if (currentVersion == DefaultVersionValue ||
                            currentVersion == ProjectVersionValue ||
                            defaultVersion == currentVersion)
                        {
                            continue;
                        }
                        var structuredDefaultVersion = StructuredVersion.FromString(defaultVersion);
                        var structuredCurrentVersion = StructuredVersion.FromString(currentVersion);
                        if (structuredDefaultVersion.CompareTo(structuredCurrentVersion) > 0 &&
                            structuredDefaultVersion.Major == structuredCurrentVersion.Major)
                        {
                            dependencies[package] = defaultVersion;
                        }
                    }
                }

                if (api.Json is object)
                {
                    api.Json[jsonName] = new JObject(dependencies.Select(pair => new JProperty(pair.Key, pair.Value)));
                }
            }
        }

        public static void GenerateProjects(string apiRoot, ApiMetadata api, HashSet<string> apiNames)
        {
            if (api.Type == ApiType.Analyzers)
            {
                Directory.CreateDirectory(apiRoot);

                var mainDirectory = Path.Combine(apiRoot, api.Id);
                Directory.CreateDirectory(mainDirectory);

                var testDirectory = Path.Combine(apiRoot, api.Id + ".Tests");
                Directory.CreateDirectory(testDirectory);
            }

            // We assume the source directories already exist, either because they've just
            // been generated or because they were already there. We infer the type of each
            // project based on the directory name. Expected suffixes:
            // - None: main API
            // - .Snippets: snippets (manual and generated) TODO: Will contain manual snippets only after we have started using GeneratedSnippets for docs.
            // - .GeneratedSnippets: generated snippets.
            // - .Tests: unit tests
            // - .IntegrationTests: integration tests
            // - .Samples: generated standalone samples

            // Anything else will be ignored for now...
            var projectDirectories = Directory.GetDirectories(apiRoot)
                .Where(pd => Path.GetFileName(pd).StartsWith(api.Id))
                .ToList();
            foreach (var dir in projectDirectories)
            {
                string suffix = Path.GetFileName(dir).Substring(api.Id.Length);
                switch (suffix)
                {
                    case "":
                        GenerateMainProject(api, dir, apiNames);
                        break;
                    case ".SmokeTests":
                        GenerateSmokeTestProject(api, dir, apiNames);
                        break;
                    case ".IntegrationTests":
                    case ".Snippets":
                    case ".Tests":
                        GenerateTestProject(api, dir, apiNames, isForAnalyzers: api.Type == ApiType.Analyzers);
                        GenerateCoverageFile(api, dir);
                        break;
                    case ".GeneratedSnippets":
                        GenerateTestProject(api, dir, apiNames, isForAnalyzers: api.Type == ApiType.Analyzers);
                        break;
                    case ".Samples":
                        GenerateSampleProject(api, dir, apiNames);
                        break;
                }
            }

            // TODO: Updates for unknown project types? Tricky...
        }

        static void GenerateSolutionFiles(string apiRoot, ApiMetadata api)
        {
            var projectDirectories = Directory.GetDirectories(apiRoot)
                .Where(pd => Path.GetFileName(pd).StartsWith(api.Id))
                .ToList();

            HashSet<string> projects = new HashSet<string>();
            // We want to include all the project files, and all the project references
            // from those project files, being aware that the solution file is already one directory
            // higher than the project file...
            foreach (var dir in projectDirectories)
            {
                string projectName = Path.GetFileName(dir);
                string projectFile = Path.Combine(dir, $"{projectName}.csproj");
                if (File.Exists(projectFile))
                {
                    projects.Add($"{projectName}/{projectName}.csproj");
                    XDocument doc = XDocument.Load(projectFile);
                    var projectReferences = doc.Descendants("ProjectReference")
                        .Select(x => x.Attribute("Include").Value.Replace("\\", "/"))
                        .Select(x => x.StartsWith("../") ? x.Substring(3) : x);
                    foreach (var reference in projectReferences)
                    {
                        projects.Add(reference);
                    }
                }
            }

            var solutionFileName = $"{api.Id}.sln";
            string fullFile = Path.Combine(apiRoot, solutionFileName);
            string beforeHash = GetFileHash(fullFile);
            if (!File.Exists(fullFile))
            {
                Processes.RunDotnet(apiRoot, "new", "sln", "-n", api.Id);
            }
            else
            {
                // Optimization: don't run "dotnet sln add" if we can find project entries for all the relevant project
                // references already. This is crude, but speeds up the overall process significantly.
                var projectLines = File.ReadAllLines(fullFile).Where(line => line.StartsWith("Project(")).ToList();
                if (projects.Select(p => $"\"{p.Replace("/", "\\")}\"")
                            .All(expectedProject => projectLines.Any(pl => pl.Contains(expectedProject))))
                {
                    return;
                }
            }

            // It's much faster to run a single process than to run it once per project.
            Processes.RunDotnet(apiRoot, new[] { "sln", solutionFileName, "add" }.Concat(projects).ToArray());

            string afterHash = GetFileHash(fullFile);
            if (beforeHash != afterHash)
            {
                Console.WriteLine($"{(beforeHash == null ? "Created" : "Modified")} solution file for {api.Id}");
            }
        }

        static void GenerateDocumentationStub(string apiRoot, ApiMetadata api)
        {
            string file = Path.Combine(apiRoot, "docs", "index.md");
            if (File.Exists(file))
            {
                return;
            }
            Directory.CreateDirectory(Path.GetDirectoryName(file));
            string stub = api.ProductName != null && api.ProductUrl != null ?
@"{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}
"
: "{{non-product-stub}}";
            File.WriteAllText(file, stub);
            Console.WriteLine($"Generated documentation stub for {api.Id}");
        }

        private static void GenerateOwlBotConfiguration(string apiRoot, ApiMetadata api)
        {
            var owlBotConfigFile = Path.Combine(apiRoot, ".OwlBot.yaml");
            var owlBotForceRegenerationFile = Path.Combine(apiRoot, ".OwlBot-ForceRegeneration.txt");
            // We will recreate this if necessary.
            File.Delete(owlBotForceRegenerationFile);
            if (api.DetermineAutoGeneratorType() != AutoGeneratorType.OwlBot)
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
    - source: /{api.ProtoPath}/.*-csharp/{api.Id}.Tests
      dest: /owl-bot-staging/{api.Id}/{api.Id}.Tests
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
            if (File.Exists(Path.Combine(apiRoot, "pregeneration.sh")) ||
                File.Exists(Path.Combine(apiRoot, "midmicrogeneration.sh")))
            {
                forceRegenerationReasons.Add("API requires pre/mid-generation tweaks.");
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
        public static void GenerateMetadataFile(string apiRoot, ApiMetadata api)
        {
            string metadataPath = Path.Combine(apiRoot, ".repo-metadata.json");
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
                ["library_type"] = api.EffectiveMetadataType
            };
            if (api.ShortName is object)
            {
                metadata["api_shortname"] = api.ShortName;
            }
            string json = JsonConvert.SerializeObject(metadata, Formatting.Indented);
            File.WriteAllText(metadataPath, json);
        }

        private static void GenerateMainProject(ApiMetadata api, string directory, HashSet<string> apiNames)
        {
            if (api.Version == null)
            {
                throw new UserErrorException($"No version specified for {api.Id}");
            }
            string targetFrameworks = api.TargetFrameworks ?? PackageTypeToDefaultTargetFrameworks.GetValueOrDefault(api.Type);

            SortedList<string, string> dependencies;
            if (api.Type == ApiType.Analyzers)
            {
                if (targetFrameworks != AnalyzersTargetFramework)
                {
                    throw new UserErrorException($"Analyzers are expected to use {AnalyzersTargetFramework}");
                }

                dependencies = new SortedList<string, string>(CommonAnalyzerDependencies, StringComparer.Ordinal);

                // Note: If support is added here for using additional dependencies, we need to resolve
                //       the packaging issues and make sure the onus won't be on the user to add the
                //       dependency references.
            }
            else
            {

                dependencies = new SortedList<string, string>(CommonHiddenProductionDependencies, StringComparer.Ordinal);

                // Default dependencies by package type
                if (PackageTypeToImplicitDependencies.TryGetValue(api.Type, out var implicitDependencies))
                {
                    foreach (var dependency in implicitDependencies)
                    {
                        dependencies[dependency] = DefaultVersionValue;
                    }
                }

                // Deliberately not using Add, so that a project can override the defaults.
                // In particular, stable releases *must* override versions of GRPC and GAX.
                foreach (var dependency in api.Dependencies)
                {
                    dependencies[dependency.Key] = !NewMajorVersionMode ? dependency.Value
                        : DefaultPackageVersions.TryGetValue(dependency.Key, out var defaultVersion) ? defaultVersion
                        : apiNames.Contains(dependency.Key) ? ProjectVersionValue
                        : dependency.Value;
                }
            }

            var propertyGroup = new XElement("PropertyGroup",
                // Build-related properties
                new XElement("Version", api.Version), // TODO: Version, or VersionPrefix/VersionSuffix?
                new XElement("TargetFrameworks", targetFrameworks),
                new XElement("GenerateDocumentationFile", api.Type != ApiType.Analyzers),
                // Package-related properties
                new XElement("Description", api.Description),
                new XElement("PackageTags", string.Join(";", api.Tags.Concat(new[] { "Google", "Cloud" })))
            );
            if (dependencies.ContainsKey(GrpcCorePackage))
            {
                propertyGroup.Add(new XElement("CodeAnalysisRuleSet", "..\\..\\..\\grpc.ruleset"));
            }
            var dependenciesElement = CreateDependenciesElement(api.Id, dependencies, api.IsReleaseVersion, testProject: false, apiNames: apiNames);

            if (api.Type == ApiType.Analyzers)
            {
                propertyGroup.Add(new XElement("IncludeBuildOutput", false));

                void AddPackFile(string includePath, string packagePath)
                {
                    dependenciesElement.Add(
                        new XElement("None",
                            new XAttribute("Include", includePath),
                            new XAttribute("Pack", "true"),
                            new XAttribute("PackagePath", packagePath),
                            new XAttribute("Visible", "false")));
                }

                AddPackFile(
                    $"$(OutputPath)\\{AnalyzersTargetFramework}\\$(AssemblyName).dll",
                    "analyzers/dotnet/cs");

                // Add install scripts as per
                // https://docs.microsoft.com/en-us/nuget/reference/analyzers-conventions#install-and-uninstall-scripts
                // Name each file rather than using a wildcard so 'dotnet pack' will error out if the files are missing
                // for some reason.
                AddPackFile(
                    @"..\..\..\analyzerScripts\install.ps1",
                    "tools");
                AddPackFile(
                    @"..\..\..\analyzerScripts\uninstall.ps1",
                    "tools");
            }
            WriteProjectFile(api, directory, propertyGroup, dependenciesElement);
        }

        private static string GetTestTargetFrameworks(ApiMetadata api, bool isForAnalyzers) =>
            isForAnalyzers
                ? AnalyzersTestTargetFramework
                : api.TestTargetFrameworks ?? api.TargetFrameworks ?? DefaultTestTargetFrameworks;


        private static void GenerateSmokeTestProject(ApiMetadata api, string directory, HashSet<string> apiNames)
        {
            // Don't generate a project file if we've got a placeholder directory
            if (Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories).Length == 0)
            {
                return;
            }
            var propertyGroup =
                new XElement("PropertyGroup",
                    new XElement("TargetFramework", "net6.0"),
                    new XElement("OutputType", "Exe"),
                    new XElement("IsPackable", false));
            var dependenciesElement =
                new XElement("ItemGroup",
                    CreateDependencyElement(Path.GetFileName(directory), api.Id, ProjectVersionValue, stableRelease: false, testProject: true, apiNames));
            WriteProjectFile(api, directory, propertyGroup, dependenciesElement);
        }

        private static void GenerateSampleProject(ApiMetadata api, string directory, HashSet<string> apiNames)
        {
            // Don't generate a project file if we've got a placeholder directory
            if (Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories).Length == 0)
            {
                return;
            }
            var dependencies = new SortedList<string, string>(CommonSampleDependencies, StringComparer.Ordinal);
            dependencies.Add(api.Id, "project");
            var propertyGroup =
                new XElement("PropertyGroup",
                    new XElement("TargetFramework", "net6.0"),
                    new XElement("OutputType", "Exe"),
                    new XElement("IsPackable", false),
                    new XElement("StartupObject", api.Id + ".Samples.Program"));

            string project = Path.GetFileName(directory);
            var dependenciesElement = CreateDependenciesElement(project, dependencies, api.IsReleaseVersion, testProject: true, apiNames: apiNames);
            WriteProjectFile(api, directory, propertyGroup, dependenciesElement);
        }

        private static void GenerateTestProject(ApiMetadata api, string directory, HashSet<string> apiNames, bool isForAnalyzers = false)
        {
            // Don't generate a project file if we've got a placeholder directory
            if (Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories).Length == 0)
            {
                return;
            }
            var dependencies = new SortedList<string, string>(CommonTestDependencies, StringComparer.Ordinal);
            if (isForAnalyzers)
            {
                dependencies.Remove("Google.Cloud.ClientTesting");
                dependencies.Add("Google.Cloud.AnalyzersTesting", ProjectVersionValue);
            }

            dependencies.Add(api.Id, "project");

            // Deliberately not using Add, so that a project can override the defaults.
            foreach (var dependency in api.TestDependencies)
            {
                dependencies[dependency.Key] = !NewMajorVersionMode ? dependency.Value
                        : DefaultPackageVersions.TryGetValue(dependency.Key, out var defaultVersion) ? defaultVersion
                        : apiNames.Contains(dependency.Key) ? ProjectVersionValue
                        : dependency.Value;
            }

            var testTargetFrameworks = GetTestTargetFrameworks(api, isForAnalyzers);
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
                    // AD0001 is the error for an analyzer throwing an exception. We can remove this when
                    // the fix for https://github.com/xunit/xunit/issues/1409 is in NuGet.
                    new XElement("NoWarn", "1701;1702;1705;xUnit2004;xUnit2013;AD0001")
                );
            string project = Path.GetFileName(directory);
            var dependenciesElement = CreateDependenciesElement(project, dependencies, api.IsReleaseVersion, testProject: true, apiNames: apiNames);
            // Test service... it keeps on getting added by Visual Studio, so let's just include it everywhere.
            dependenciesElement.Add(new XElement("Service", new XAttribute("Include", "{82a7f48d-3b50-4b1e-b82e-3ada8210c358}")));
            WriteProjectFile(api, directory, propertyGroup, dependenciesElement);
        }

        private static void GenerateCoverageFile(ApiMetadata api, string directory)
        {
            // Don't generate a coverage file if we've got a placeholder directory
            if (Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories).Length == 0)
            {
                return;
            }
            var targetExecutable = new XElement("TargetExecutable", "C:/Program Files/dotnet/dotnet.exe");
            var targetArguments = new XElement("TargetArguments", "test --no-build -c Release");
            var filters = new XElement("Filters", new XElement("IncludeFilters",
                new XElement("FilterEntry", new XElement("ModuleMask", api.Id)),
                // Allow tests to contribute coverage to project dependencies, but not package dependencies
                // (as the latter will be covering code we're not reporting on).
                api.Dependencies
                    .Where(dep => dep.Value == ProjectVersionValue)
                    .Select(dep => new XElement("FilterEntry", new XElement("ModuleMask", dep.Key)))
                ));
            var attributeFilters = new XElement("AttributeFilters",
                new XElement("AttributeFilterEntry",
                    "System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute"),
                new XElement("AttributeFilterEntry", "System.Diagnostics.DebuggerNonUserCodeAttribute")
            );
            var output = new XElement("Output", $"../../../coverage/{Path.GetFileName(directory)}.dvcr");
            var workingDir = new XElement("TargetWorkingDir", ".");

            var doc = new XElement("CoverageParams",
                targetExecutable,
                targetArguments,
                filters,
                attributeFilters,
                workingDir,
                output
            );

            using (var stream = File.Create(Path.Combine(directory, "coverage.xml")))
            {
                doc.Save(stream);
            }
        }

        private static void WriteProjectFile(
            ApiMetadata api, string directory, XElement propertyGroup, XElement dependenciesItemGroup)
        {
            var file = Path.Combine(directory, $"{Path.GetFileName(directory)}.csproj");
            string beforeHash = GetFileHash(file);
            XElement doc;
            // If the file already exists, load it and replace the elements (leaving any further PropertyGroup and ItemGroup elements).
            if (File.Exists(file))
            {
                doc = XElement.Load(file);
                doc.Elements("PropertyGroup").First().ReplaceWith(propertyGroup);
                doc.Elements("ItemGroup").First().ReplaceWith(dependenciesItemGroup);
            }
            // Otherwise, create a new one
            else
            {
                doc = new XElement("Project",
                    new XAttribute("Sdk", "Microsoft.NET.Sdk"),
                    propertyGroup,
                    dependenciesItemGroup);
            }

            // Don't use File.CreateText as that omits the byte order mark.
            // While byte order marks are nasty, Visual Studio will add it back any time a project file is
            // manually edited, so it's best if we follow suit.
            using (var stream = File.Create(Path.Combine(directory, $"{Path.GetFileName(directory)}.csproj")))
            {
                doc.Save(stream);
            }
            string afterHash = GetFileHash(file);
            if (beforeHash != afterHash)
            {
                Console.WriteLine($"{(beforeHash == null ? "Created" : "Modified")} project file {Path.GetFileName(file)}");
            }
        }

        private static XElement CreateDependenciesElement(string project, IDictionary<string, string> dependencies, bool stableRelease, bool testProject, HashSet<string> apiNames) =>
            new XElement("ItemGroup",
                // Use the GAX version for all otherwise-unversioned GAX dependencies
                dependencies.Select(pair => CreateDependencyElement(project, pair.Key, pair.Value, stableRelease, testProject, apiNames)),
                new XElement("Analyzer",
                    new XAttribute("Condition", $"Exists('{AnalyzersPath}')"),
                    new XAttribute("Include", AnalyzersPath)));

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
        /// <param name="version">Version of dependency, or "project" or "default"</param>
        /// <param name="allowDefaultVersions">Whether to allow default versions for </param>
        /// <param name="apiNames">Names of all APIs in apis.json, valid for project references</param>
        /// <returns>The element to include in the project file to represent the dependency</returns>
        private static XElement CreateDependencyElement(string project, string package, string version, bool stableRelease, bool testProject, HashSet<string> apiNames)
        {
            if (version == ProjectVersionValue)
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

            if (version == DefaultVersionValue)
            {
                if (stableRelease)
                {
                    throw new UserErrorException($"Project {project} cannot use the default version for {package}");
                }
                if (!DefaultPackageVersions.TryGetValue(package, out version))
                {
                    throw new UserErrorException($"Project {project} depends on default version of unknown package {package}");
                }
            }

            PrivateAssets.TryGetValue(package, out string privateAssetValue);

            if (!AnyVersionPattern.IsMatch(version))
            {
                throw new UserErrorException($"Project {project} has invalid version '{version}' for package {package}");
            }
            // Dependencies from production projects, other than "hidden" packages, must be stable
            if (stableRelease && !testProject && !StableVersionPattern.IsMatch(version) && privateAssetValue != "All")
            {
                throw new UserErrorException($"Project {project} uses prerelease version '{version}' for package {package}");
            }
            var element = new XElement("PackageReference",
                new XAttribute("Include", package),
                new XAttribute("Version", GetDependencyVersionRange(package, version)));
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
        }

        /// <summary>
        /// Returns the appropriate version to include in a package dependency.
        /// For Google.* and Grpc.*, this is major-version pinned. For other packages, we just leave it as the version
        /// specified in the string - as some packages are fine to upgrade beyond major version boundaries.
        /// </summary>
        private static string GetDependencyVersionRange(string package, string specifiedVersion)
        {
            if (!(package.StartsWith("Google.") || package.StartsWith("Grpc.")))
            {
                return specifiedVersion;
            }
            var structuredVersion = StructuredVersion.FromString(specifiedVersion);
            var nextMajor = StructuredVersion.FromMajorMinorPatchBuild(structuredVersion.Major + 1, 0, 0, structuredVersion.Build is null ? default(int?) : 0, null);
            return $"[{structuredVersion}, {nextMajor})";
        }

        /// <summary>
        /// This is in lieu of a unit test... just make sure that all the dependencies we're hard-coding the values for
        /// really do hide all their assets.
        /// </summary>
        private static void ValidateCommonHiddenProductionDependencies()
        {
            var brokenDependencies = CommonHiddenProductionDependencies.Keys.Where(p => !PrivateAssets.ContainsKey(p) || PrivateAssets[p] != "All").ToList();
            if (brokenDependencies.Any())
            {
                throw new Exception($"ProjectGenerator error: invalid CommonHiddenProductionDependencies: {string.Join(", ", brokenDependencies)}");
            }
        }

        private static string GetFileHash(string file)
        {
            if (!File.Exists(file))
            {
                return null;
            }
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    byte[] hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash);
                }
            }
        }
    }
}
