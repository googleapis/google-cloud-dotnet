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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ProjectGenerator
{
    public class Program
    {
        private static readonly Regex AnyVersionPattern = new Regex(@"^[0-9]\d*\.\d+\.\d+(\.\d+)?(-.*)?$");
        private static readonly Regex StableVersionPattern = new Regex(@"^[1-9]\d*\.\d+\.\d+(\.\d+)?$");

        // Project references which don't just follow the pattern of ..\..\{package}\{package}\{package}.csproj
        private static readonly Dictionary<string, string> KnownProjectReferences = new Dictionary<string, string>
        {
            { "Google.Cloud.ClientTesting", @"..\..\..\tools\Google.Cloud.ClientTesting\Google.Cloud.ClientTesting.csproj" },
            { "Google.Cloud.Diagnostics.Common.Tests", @"..\..\Google.Cloud.Diagnostics.Common\Google.Cloud.Diagnostics.Common.Tests\Google.Cloud.Diagnostics.Common.Tests.csproj" },
            { "Google.Cloud.Diagnostics.Common.IntegrationTests", @"..\..\Google.Cloud.Diagnostics.Common\Google.Cloud.Diagnostics.Common.IntegrationTests\Google.Cloud.Diagnostics.Common.IntegrationTests.csproj" }
        };

        private const string DefaultRestTargetFrameworks = "netstandard1.3;net45";
        private const string DefaultGrpcTargetFrameworks = "netstandard1.5;net45";
        private const string DefaultTestTargetFrameworks = "netcoreapp1.0;net452";

        private const string ProjectVersionValue = "project";
        private const string DefaultVersionValue = "default";
        private const string GrpcPackage = "Grpc.Core";
        private const string DefaultGaxVersion = "2.1.0-beta02";
        private const string GrpcVersion = "1.4.0";
        private static readonly Dictionary<string, string> DefaultPackageVersions = new Dictionary<string, string>
        {
            { "Google.Api.Gax", DefaultGaxVersion },
            { "Google.Api.Gax.Rest", DefaultGaxVersion },
            { "Google.Api.Gax.Grpc", DefaultGaxVersion },
            { "Google.Api.Gax.Testing", DefaultGaxVersion },
            { "Google.Api.Gax.Grpc.Testing", DefaultGaxVersion },
            { GrpcPackage, GrpcVersion },
        };

        // Hard-coded versions for all test packages. These can be defaulted even for stable packages, whereas
        // the packages in DefaultPackageVersions should be specified precisely in stable packages.
        private static readonly Dictionary<string, string> CommonTestDependencies = new Dictionary<string, string>
        {
            { "Microsoft.NET.Test.Sdk", "15.0.0" },
            { "xunit", "2.3.0-beta1-build3642" },
            { "xunit.runner.visualstudio", "2.3.0-beta1-build1309" },
            { "Moq", "4.7.8" }
        };

        // Hard-coded versions for dependencies for production packages that can be updated arbitrarily, as their assets are all private.
        // The relationship between this and PrivateAssets is tested on startup.
        private static readonly Dictionary<string, string> CommonHiddenProductionDependencies = new Dictionary<string, string>
        {
            { ConfigureAwaitAnalyzer, "1.0.0-beta4" },
            { SourceLinkPackage, "2.1.2" }
        };

        private const string DotnetPackInstructionsLabel = "dotnet pack instructions";
        private const string ConfigureAwaitAnalyzer = "ConfigureAwaitChecker.Analyzer";
        private const string SourceLinkPackage = "SourceLink.Create.CommandLine";

        /// <summary>
        /// For packages which need a PrivateAssets attribute in dependencies, this dictionary provides the value of the attribute.
        /// </summary>
        private static readonly Dictionary<string, string> PrivateAssets = new Dictionary<string, string>
        {
            { GrpcPackage, "None" },
            { ConfigureAwaitAnalyzer, "All" },
            { SourceLinkPackage, "All" }
        };

        private const string AnalyzersPath = @"..\..\..\tools\Google.Cloud.Tools.Analyzers\bin\$(Configuration)\netstandard1.3\publish\Google.Cloud.Tools.Analyzers.dll";
        private const string StripDesktopOnNonWindows = @"..\..\..\StripDesktopOnNonWindows.xml";

        private const string TargetFrameworkCore = "netcoreapp1.0";
        private const string TargetFrameworkClassic = "net452";

        static int Main()
        {
            try
            {
                ValidateCommonHiddenProductionDependencies();
                var root = DirectoryLayout.DetermineRootDirectory();
                var apis = ApiMetadata.LoadApis();
                Console.WriteLine($"API catalog contains {apis.Count} entries");
                HashSet<string> apiNames = new HashSet<string>(apis.Select(api => api.Id));

                foreach (var api in apis)
                {
                    GenerateProjects(Path.Combine(root, "apis", api.Id), api, apiNames);
                }
                foreach (var api in apis)
                {
                    GenerateSolutionFiles(Path.Combine(root, "apis", api.Id), api);
                }
                foreach (var api in apis)
                {
                    GenerateDocumentationStub(Path.Combine(root, "apis", api.Id), api);
                }
                return 0;
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Configuration error: {e.Message}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed: {e}");
                return 1;
            }
        }

        static void GenerateProjects(string apiRoot, ApiMetadata api, HashSet<string> apiNames)
        {
            // We assume the source directories already exist, either because they've just
            // been generated or because they were already there. We infer the type of each
            // project based on the directory name. Expected suffixes:
            // - None: main API
            // - .Snippets: snippets (manual and generated)
            // - .Tests: unit tests
            // - .IntegrationTests: integration tests

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
                    case ".IntegrationTests":
                    case ".Snippets":
                    case ".Tests":
                        GenerateTestProject(api, dir, apiNames);
                        GenerateCoverageFile(api, dir);
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
                    projects.Add($"{projectName}\\{projectName}.csproj");
                    XDocument doc = XDocument.Load(projectFile);
                    var projectReferences = doc.Descendants("ProjectReference")
                        .Select(x => x.Attribute("Include").Value.Replace("/", "\\"))
                        .Select(x => x.StartsWith("..\\") ? x.Substring(3) : x);
                    foreach (var reference in projectReferences)
                    {
                        projects.Add(reference);
                    }
                }
            }

            var solutionFile = $"{api.Id}.sln";
            string fullFile = Path.Combine(apiRoot, solutionFile);
            string beforeHash = GetFileHash(fullFile);
            if (!File.Exists(fullFile))
            {
                RunDotnet(apiRoot, "new", "sln", "-n", api.Id);
            }
            // It's much faster to run a single process than to run it once per project.
            RunDotnet(apiRoot, new[] { "sln", solutionFile, "add" }.Concat(projects).ToArray());
            string afterHash = GetFileHash(fullFile);
            if (beforeHash != afterHash)
            {
                Console.WriteLine($"{(beforeHash == null ? "Created" : "Modified")} solution file for {api.Id}");
            }
        }

        static void GenerateDocumentationStub(string apiRoot, ApiMetadata api)
        {
            string file = Path.Combine(apiRoot, "docs", "index.md");
            if (!File.Exists(file) && api.ProductName != null && api.ProductUrl != null)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(file));
                File.WriteAllText(file,
@"{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

TODO: Add a link to the client classes here, and introductory text.

# Sample code

TODO: Add snippet references here.
");
                Console.WriteLine($"Generated documentation stub for {api.Id}");
            }
        }

        private static void RunDotnet(string root, params string[] args)
        {
            string joinedArguments = string.Join(" ", args);
            var psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = joinedArguments,
                WorkingDirectory = root,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            var process = Process.Start(psi);
            // We assume there isn't so much output that this will block. Otherwise we'd have to read it in a different thread etc.
            // 10s limit stops us from hanging forever...
            process.WaitForExit(10000);
            if (process.ExitCode != 0)
            {
                var output = process.StandardOutput.ReadToEnd();
                var error = process.StandardError.ReadToEnd();
                throw new Exception($"dotnet exit code {process.ExitCode}. Directory: {root}. Args: {joinedArguments}. Output: {output}. Error: {error}");
            }
        }

        private static void GenerateMainProject(ApiMetadata api, string directory, HashSet<string> apiNames)
        {
            if (api.Version == null)
            {
                throw new UserErrorException($"No version specified for {api.Id}");
            }
            string targetFrameworks = api.TargetFrameworks;

            var dependencies = new SortedList<string, string>(CommonHiddenProductionDependencies);

            switch (api.Type)
            {
                case "rest":
                    dependencies.Add("Google.Api.Gax.Rest", DefaultVersionValue);
                    targetFrameworks = targetFrameworks ?? DefaultRestTargetFrameworks;
                    break;
                case "grpc":
                    dependencies.Add("Google.Api.Gax.Grpc", DefaultVersionValue);
                    dependencies.Add("Grpc.Core", DefaultVersionValue);
                    targetFrameworks = targetFrameworks ?? DefaultGrpcTargetFrameworks;
                    break;
            }

            // Deliberately not using Add, so that a project can override the defaults.
            // In particular, stable releases *must* override versions of GRPC and GAX.
            foreach (var dependency in api.Dependencies)
            {
                dependencies[dependency.Key] = dependency.Value;
            }

            var propertyGroup = new XElement("PropertyGroup",
                // Build-related properties
                new XElement("Version", api.Version), // TODO: Version, or VersionPrefix/VersionSuffix?
                new XElement("TargetFrameworks", targetFrameworks),
                new XElement("Features", "IOperation"),
                new XElement("GenerateDocumentationFile", true),
                new XElement("AssemblyOriginatorKeyFile", "../../GoogleApis.snk"),
                new XElement("SignAssembly", true),
                new XElement("Deterministic", true),
                new XElement("PublicSign", new XAttribute("Condition", " '$(OS)' != 'Windows_NT' "), true),
                new XElement("TreatWarningsAsErrors", true),
                // Package-related properties
                new XElement("Description", api.Description),
                new XElement("PackageTags", string.Join(";", api.Tags.Concat(new[] { "Google", "Cloud" }))),
                new XElement("Copyright", "Copyright 2017 Google Inc."),
                new XElement("Authors", "Google Inc."),
                new XElement("PackageIconUrl", "https://cloud.google.com/images/gcp-icon-64x64.png"),
                new XElement("PackageLicenseUrl", "http://www.apache.org/licenses/LICENSE-2.0"),
                new XElement("PackageProjectUrl", "https://github.com/GoogleCloudPlatform/google-cloud-dotnet"),
                new XElement("RepositoryType", "git"),
                new XElement("RepositoryUrl", "https://github.com/GoogleCloudPlatform/google-cloud-dotnet")
            );
            var packingElement = new XElement("ItemGroup",
                new XAttribute("Label", DotnetPackInstructionsLabel),
                targetFrameworks.Split(';').Select(tfm => new XElement("Content",
                    new XAttribute("Include", $@"$(OutputPath){tfm}\$(PackageId).pdb"),
                    new XElement("Pack", true),
                    new XElement("PackagePath", $"lib/{tfm}")
                ))
            );
            var dependenciesElement = CreateDependenciesElement(api.Id, dependencies, api.IsReleaseVersion, testProject: false, apiNames: apiNames);
            WriteProjectFile(api, directory, propertyGroup, dependenciesElement, packingElement);
        }

        private static string GetTestTargetFrameworks(ApiMetadata api) => api.TestTargetFrameworks ??
                                                                      api.TargetFrameworks ?? DefaultTestTargetFrameworks;

        private static string GetPreferredCoverageFramework(ApiMetadata api)
        {
            var targetFrameworks = GetTestTargetFrameworks(api);
            if (targetFrameworks.Contains(TargetFrameworkClassic))
            {
                return TargetFrameworkClassic;
            }
            // Otherwise, return the first one found.
            return targetFrameworks.Split(';').FirstOrDefault();
        }

        private static void GenerateTestProject(ApiMetadata api, string directory, HashSet<string> apiNames)
        {
            var dependencies = new SortedList<string, string>(CommonTestDependencies);
            dependencies.Add(api.Id, "project");

            // Deliberately not using Add, so that a project can override the defaults.
            foreach (var dependency in api.TestDependencies)
            {
                dependencies[dependency.Key] = dependency.Value;
            }
            
            var propertyGroup =
                new XElement("PropertyGroup",
                    new XElement("TargetFrameworks", GetTestTargetFrameworks(api)),
                    new XElement("Features", "IOperation"),
                    new XElement("IsPackable", false),
                    new XElement("AssemblyOriginatorKeyFile", "../../GoogleApis.snk"),
                    new XElement("SignAssembly", true),
                    new XElement("PublicSign", new XAttribute("Condition", " '$(OS)' != 'Windows_NT' "), true),
                    new XElement("TreatWarningsAsErrors", true),
                    // 1701, 1702 and 1705 are disabled by default.
                    // 4014 is required as snippets for streaming samples call Task.Run and don't await the result.
                    // See https://github.com/googleapis/toolkit/issues/1271 - when that's fixed, we can remove this.
                    new XElement("NoWarn", "1701;1702;1705;4014")
                );
            string project = Path.GetFileName(directory);
            var dependenciesElement = CreateDependenciesElement(project, dependencies, api.IsReleaseVersion, testProject: true, apiNames: apiNames);
            // Allow test projects to use dynamic...
            dependenciesElement.Add(new XElement("Reference",
                new XAttribute("Condition", "'$(TargetFramework)' == 'net452'"),
                new XAttribute("Include", "Microsoft.CSharp")));
            // Test service... it keeps on getting added by Visual Studio, so let's just include it everywhere.
            dependenciesElement.Add(new XElement("Service", new XAttribute("Include", "{82a7f48d-3b50-4b1e-b82e-3ada8210c358}")));
            WriteProjectFile(api, directory, propertyGroup, dependenciesElement, null);
        }

        private static void GenerateCoverageFile(ApiMetadata api, string directory)
        {
            var targetExecutable = new XElement("TargetExecutable", "/Program Files/dotnet/dotnet.exe");
            var targetArguments = new XElement("TargetArguments",
                $"test --no-build -f {GetPreferredCoverageFramework(api)} -c Release");
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
            ApiMetadata api, string directory, XElement propertyGroup, XElement dependenciesItemGroup, XElement packingElement)
        {
            var file = Path.Combine(directory, $"{Path.GetFileName(directory)}.csproj");
            string beforeHash = GetFileHash(file);
            XElement doc;
            // If the file already exists, load it and replace the elements (leaving any further PropertyGroup and ItemGroup elements).
            // Make sure there's an appropriate import for stripping desktop builds on non-Windows platforms.
            if (File.Exists(file))
            {
                doc = XElement.Load(file);
                doc.Elements("Import").Where(x => (string)x.Attribute("Project") == @"..\..\StripDesktopOnNonWindows.xml").Remove();
                doc.Elements("PropertyGroup").First().ReplaceWith(propertyGroup);
                doc.Elements("ItemGroup").First().ReplaceWith(dependenciesItemGroup);
                doc.Elements("ItemGroup").Where(x => (string)x.Attribute("Label") == DotnetPackInstructionsLabel).Remove();
                doc.Elements("ItemGroup").First().AddAfterSelf(packingElement);

                if (!doc.Elements("Import").Any(x => (string)x.Attribute("Project") == StripDesktopOnNonWindows))
                {
                    doc.Add(new XElement("Import", new XAttribute("Project", StripDesktopOnNonWindows)));
                }
            }
            // Otherwise, create a new one
            else
            {
                doc = new XElement("Project",
                    new XAttribute("Sdk", "Microsoft.NET.Sdk"),
                    propertyGroup,
                    dependenciesItemGroup,
                    packingElement,
                    new XElement("Import", new XAttribute("Project", StripDesktopOnNonWindows))
                );
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

        private static string GenerateProjectReference(string key)
        {
            // There are a few special cases which don't fit in, then the common case
            // where it follows the normal pattern, then being flexible for anything
            // that doesn't fit...
            switch (key)
            {
                case "Google.Cloud.ClientTesting": return @"..\..\..\tools\Google.Cloud.ClientTesting\Google.Cloud.ClientTesting.csproj";
                case var _ when !key.Contains(".csproj"): return $@"..\..\{key}\{key}\{key}.csproj";
                default: return key;
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
                new XAttribute("Version", version));
            if (privateAssetValue != null)
            {
                element.Add(new XAttribute("PrivateAssets", privateAssetValue));
            }
            return element;
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
