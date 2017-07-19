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
using System.Xml.Linq;

namespace Google.Cloud.Tools.ProjectGenerator
{
    public class Program
    {
        private const string GrpcVersion = "1.4.0";
        private const string StableGaxVersion = "2.0.0";
        private const string PrereleaseGaxVersion = "2.1.0-beta01";
        private const string DotnetPackInstructionsLabel = "dotnet pack instructions";

        private const string ConfigureAwaitAnalyzer = "ConfigureAwaitChecker.Analyzer";
        private const string SourceLinkPackage = "SourceLink.Create.CommandLine";
        private static readonly HashSet<string> PrivateAssetPackages = new HashSet<string> { ConfigureAwaitAnalyzer, SourceLinkPackage };

        private const string AnalyzersPath = @"..\..\..\tools\Google.Cloud.Tools.Analyzers\bin\$(Configuration)\netstandard1.3\publish\Google.Cloud.Tools.Analyzers.dll";
        private const string StripDesktopOnNonWindows = @"..\..\..\StripDesktopOnNonWindows.xml";

        static int Main()
        {
            try
            {
                var root = DirectoryLayout.DetermineRootDirectory();
                foreach (var api in ApiMetadata.LoadApis())
                {
                    GenerateProjects(Path.Combine(root, "apis", api.Id), api);
                }
                foreach (var api in ApiMetadata.LoadApis())
                {
                    GenerateSolutionFiles(Path.Combine(root, "apis", api.Id), api);
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed: {e}");
                return 1;
            }
        }

        static void GenerateProjects(string apiRoot, ApiMetadata api)
        {
            // We assume the source directories already exist, either because they've just
            // been generated or because they were already there. We infer the type of each
            // project based on the directory name. Expected suffixes:
            // - None: main API
            // - .Snippets: snippets (manual and generated)
            // - .Tests: unit tests
            // - .IntegrationTests: integration tests

            // Anything else will be ignored for now...
            Console.WriteLine($"Generating projects for {api.Id}");
            var projectDirectories = Directory.GetDirectories(apiRoot)
                .Where(pd => Path.GetFileName(pd).StartsWith(api.Id))
                .ToList();
            foreach (var dir in projectDirectories)
            {
                string suffix = Path.GetFileName(dir).Substring(api.Id.Length);
                switch (suffix)
                {
                    case "":
                        GenerateMainProject(api, dir);
                        break;
                    case ".IntegrationTests":
                    case ".Tests":
                    case ".Snippets":
                        GenerateTestProject(api, dir);
                        break;
                }
            }

            // TODO: Updates for unknown project types? Tricky...
        }

        static void GenerateSolutionFiles(string apiRoot, ApiMetadata api)
        {
            Console.WriteLine($"Generating solution file for {api.Id}");
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
            if (!File.Exists(Path.Combine(apiRoot, solutionFile)))
            {
                RunDotnet(apiRoot, "new", "sln", "-n", api.Id);
            }
            // It's much faster to run a single process than to run it once per project.
            RunDotnet(apiRoot, new[] { "sln", solutionFile, "add" }.Concat(projects).ToArray());
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

        private static void GenerateMainProject(ApiMetadata api, string directory)
        {
            if (api.Version == null)
            {
                throw new Exception($"No version specified for {api.Id}");
            }
            string targetFrameworks = api.TargetFrameworks;
            var dependencies = new SortedList<string, string>(api.Dependencies)
            {
                { ConfigureAwaitAnalyzer, "1.0.0-beta4" },
                { SourceLinkPackage, "2.1.2" }
            };
            // If Grpc.Core is ever specified explicitly (e.g. for "other" projects),
            // but without a version number, fill it in.
            if (dependencies.ContainsKey("Grpc.Core") && dependencies["Grpc.Core"] == "")
            {
                dependencies["Grpc.Core"] = GrpcVersion;
            }
            switch (api.Type)
            {
                case "rest":
                    dependencies.Add("Google.Api.Gax.Rest", api.IsReleaseVersion ? StableGaxVersion : PrereleaseGaxVersion);
                    targetFrameworks = targetFrameworks ?? "netstandard1.3;net45";
                    break;
                case "grpc":
                    dependencies.Add("Google.Api.Gax.Grpc", api.IsReleaseVersion ? StableGaxVersion : PrereleaseGaxVersion);
                    dependencies.Add("Grpc.Core", GrpcVersion);
                    targetFrameworks = targetFrameworks ?? "netstandard1.5;net45";
                    break;
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
            WriteProjectFile(api, directory, propertyGroup, CreateDependenciesElement(dependencies, api.IsReleaseVersion), packingElement);
        }

        private static void GenerateTestProject(ApiMetadata api, string directory)
        {
            var dependencies = new SortedList<string, string>(api.TestDependencies)
            {
                { $@"..\{api.Id}\{api.Id}.csproj", "" }, // Main project
                { "Microsoft.NET.Test.Sdk", "15.0.0" },
                { "xunit", "2.3.0-beta1-build3642" },
                { "xunit.runner.visualstudio", "2.3.0-beta1-build1309 " },
                { "Moq", "4.7.8" }
            };
            var propertyGroup =
                new XElement("PropertyGroup",
                    new XElement("TargetFrameworks", api.TestTargetFrameworks ?? api.TargetFrameworks ?? "netcoreapp1.0;net452"),
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
            var itemGroup = CreateDependenciesElement(dependencies, api.IsReleaseVersion);
            // Allow test projects to use dynamic...
            itemGroup.Add(new XElement("Reference",
                new XAttribute("Condition", "'$(TargetFramework)' == 'net452'"),
                new XAttribute("Include", "Microsoft.CSharp")));
            // Test service... it keeps on getting added by Visual Studio, so let's just include it everywhere.
            itemGroup.Add(new XElement("Service", new XAttribute("Include", "{82a7f48d-3b50-4b1e-b82e-3ada8210c358}")));
            WriteProjectFile(api, directory, propertyGroup, itemGroup, null);
        }

        private static void WriteProjectFile(
            ApiMetadata api, string directory, XElement propertyGroup, XElement dependenciesItemGroup, XElement packingElement)
        {
            var file = Path.Combine(directory, $"{Path.GetFileName(directory)}.csproj");
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

        // Dependencies with an empty value will be treated as project dependencies;
        // dependencies with a value will be treated as package dependencies with the value as the version.
        private static XElement CreateDependenciesElement(IDictionary<string, string> dependencies, bool stableRelease) =>
            new XElement("ItemGroup",
                // Use the GAX version for all otherwise-unversioned GAX dependencies
                dependencies
                    .Where(d => d.Value == "" && d.Key.StartsWith("Google.Api.Gax"))
                    .Select(d => new XElement("PackageReference",
                        new XAttribute("Include", d.Key),
                        new XAttribute("Version", stableRelease ? StableGaxVersion : PrereleaseGaxVersion))),
                dependencies
                    .Where(d => d.Value == "" && !d.Key.StartsWith("Google.Api.Gax"))
                    .Select(d => new XElement("ProjectReference", new XAttribute("Include", GenerateProjectReference(d.Key)))),
                dependencies
                    .Where(d => d.Value != "")
                    .Select(d => new XElement("PackageReference",
                        new XAttribute("Include", d.Key),
                        new XAttribute("Version", d.Value),
                        // Make references to Grpc.Core deploy native dependencies
                        // See https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1066
                        d.Key == "Grpc.Core" ? new XAttribute("PrivateAssets", "None") : null,
                        // Make references to ConfigureAwaitChecker effectively private
                        PrivateAssetPackages.Contains(d.Key) ? new XAttribute("PrivateAssets", "All") : null)
                    ),
                new XElement("Analyzer",
                    new XAttribute("Condition", $"Exists('{AnalyzersPath}')"),
                    new XAttribute("Include", AnalyzersPath)));
    }
}
