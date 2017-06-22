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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ProjectGenerator
{
    public class ApiMetadata
    {
        const string GrpcVersion = "1.4.0";
        const string GaxVersion = "2.0.0";

        const string StripDesktopOnNonWindows = @"..\..\..\StripDesktopOnNonWindows.xml";

        public string Version { get; set; }
        public string Id { get; set; }
        public string Type { get; set; } // TODO: enum? Autodetect based on files?
        public string TargetFrameworks { get; set; }
        public string TestTargetFrameworks { get; set; }

        public string Description { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
        public Dictionary<string, string> Dependencies { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> TestDependencies { get; set; } = new Dictionary<string, string>();
        public List<string> MetaApis { get; set; } // TODO: enum?

        public void GenerateMainProject(string directory)
        {
            if (Version == null)
            {
                throw new Exception($"No version specified for {Id}");
            }
            string targetFrameworks = TargetFrameworks;
            var dependencies = new SortedList<string, string>(Dependencies);
            dependencies.Add("ConfigureAwaitChecker.Analyzer", "1.0.0-beta4");
            switch (Type)
            {
                case "rest":
                    dependencies.Add("Google.Api.Gax.Rest", GaxVersion);
                    targetFrameworks = targetFrameworks ?? "netstandard1.3;net45";
                    break;
                case "grpc":
                    dependencies.Add("Google.Api.Gax.Grpc", GaxVersion);
                    dependencies.Add("Grpc.Core", GrpcVersion);
                    targetFrameworks = targetFrameworks ?? "netstandard1.5;net45";
                    break;
            }

            var propertyGroup = new XElement("PropertyGroup",
                // Build-related properties
                new XElement("Version", Version), // TODO: Version, or VersionPrefix/VersionSuffix?
                new XElement("TargetFrameworks", targetFrameworks),
                new XElement("GenerateDocumentationFile", true),
                new XElement("AssemblyOriginatorKeyFile", "../../GoogleApis.snk"),
                new XElement("SignAssembly", true),
                new XElement("PublicSign", new XAttribute("Condition", " '$(OS)' != 'Windows_NT' "), true),
                new XElement("TreatWarningsAsErrors", true),
                // Package-related properties
                new XElement("Description", Description),
                new XElement("PackageTags", string.Join(";", Tags.Concat(new[] { "Google", "Cloud" }))),
                new XElement("IncludeSymbols", true),
                new XElement("IncludeSource", true),
                new XElement("Copyright", "Copyright 2017 Google Inc."),
                new XElement("Authors", "Google Inc."),
                new XElement("IconUrl", "https://cloud.google.com/images/gcp-icon-64x64.png"), // TODO: Check element name
                new XElement("PackageLicenseUrl", "http://www.apache.org/licenses/LICENSE-2.0"),
                new XElement("PackageProjectUrl", "https://github.com/GoogleCloudPlatform/google-cloud-dotnet"),
                new XElement("RepositoryType", "git"),
                new XElement("RepositoryUrl", "https://github.com/GoogleCloudPlatform/google-cloud-dotnet")
            );
            var itemGroup = CreateDependenciesElement(dependencies);
            WriteProjectFile(directory, propertyGroup, itemGroup);
        }

        public void GenerateTestProject(string directory)
        {
            var dependencies = new SortedList<string, string>(TestDependencies)
            {
                { $@"..\{Id}\{Id}.csproj", "" }, // Main project
                { "Microsoft.NET.Test.Sdk", "15.0.0" },
                { "xunit", "2.3.0-beta1-build3642" },
                { "xunit.runner.visualstudio", "2.3.0-beta1-build1309 " },
                { "Moq", "4.7.8" }
            };
            var propertyGroup =
                new XElement("PropertyGroup",
                    new XElement("TargetFrameworks", TestTargetFrameworks ?? TargetFrameworks ?? "netcoreapp1.0;net452"),
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
            var itemGroup = CreateDependenciesElement(dependencies);
            // Allow test projects to use dynamic...
            itemGroup.Add(new XElement("Reference",
                new XAttribute("Condition", "'$(TargetFramework)' == 'net452'"),
                new XAttribute("Include", "Microsoft.CSharp")));
            WriteProjectFile(directory, propertyGroup, itemGroup);
        }

        private static void WriteProjectFile(string directory, XElement propertyGroup, XElement itemGroup)
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
                doc.Elements("ItemGroup").First().ReplaceWith(itemGroup);
                if (!doc.Elements("Import").Any(x => (string) x.Attribute("Project") == StripDesktopOnNonWindows))
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
                    itemGroup,
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
                case "Google.Cloud.Logging.Type": return @"..\..\Google.Cloud.Logging.V2\Google.Cloud.Logging.Type\Google.Cloud.Logging.Type.csproj";
                case var _ when !key.Contains(".csproj"): return $@"..\..\{key}\{key}\{key}.csproj";
                default: return key;
            }
        }

        // Dependencies with an empty value will be treated as project dependencies;
        // dependencies with a value will be treated as package dependencies with the value as the version.
        private static XElement CreateDependenciesElement(IDictionary<string, string> dependencies) =>
            new XElement("ItemGroup",
                // Use the GAX version for all otherwise-unversioned GAX dependencies
                dependencies
                    .Where(d => d.Value == "" && d.Key.StartsWith("Google.Api.Gax"))
                    .Select(d => new XElement("PackageReference",
                        new XAttribute("Include", d.Key),
                        new XAttribute("Version", GaxVersion))),
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
                        d.Key == "Grpc.Core" ? new XElement("PrivateAssets", "None") : null,
                        // Make references to ConfigureAwaitChecker effectively private
                        d.Key == "ConfigureAwaitChecker.Analyzer" ? new XElement("PrivateAssets", "All") : null)
                    )
            );
    }
}
