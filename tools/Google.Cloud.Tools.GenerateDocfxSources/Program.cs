// Copyright 2016 Google Inc. All Rights Reserved.
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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.GenerateDocfxSources
{
    public class Program
    {
        /// <summary>
        /// External dependencies we generate docs for, e.g. GAX, Grpc.Core, Protobuf, each with a list
        /// of its own dependencies. Note all of these are *actually* generated, which is something we
        /// need to fix - and it would be nice if we could discover the dependencies automatically instead of
        /// hard-coding them. For now though, this is a reasonable start.
        /// </summary>
        private static readonly IDictionary<string, string[]> s_externalDependencies =
            new Dictionary<string, string[]>
        {
            { "Google.Protobuf", new string[0] },
            { "Google.Api.Gax", new string[0] },
            { "Google.Api.CommonProtos", new[] { "Google.Protobuf" } },
            { "Google.Api.Gax.Grpc", new[] { "Google.Api.Gax", "Google.Api.CommonProtos", "Grpc.Core.Api" } },
            { "Google.Api.Gax.Grpc.Gcp", new[] { "Google.Api.Gax.Grpc.GrpcCore", "Grpc.Gcp" } },
            { "Google.Api.Gax.Grpc.GrpcCore", new[] { "Google.Api.Gax.Grpc", "Grpc.Core" } },
            { "Google.Api.Gax.Grpc.GrpcNetClient", new[] { "Google.Api.Gax.Grpc", "Grpc.Net.Client" } },
            { "Google.Api.Gax.Rest", new[] { "Google.Api.Gax" } }
        };

        private static int Main(string[] args)
        {
            try
            {
                return MainImpl(args);
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return 1;
            }
        }

        private static int MainImpl(string[] args)
        {
            if (args.Length != 1)
            {
                throw new UserErrorException("Please specify the API name");
            }
            string api = args[0];
            var layout = DirectoryLayout.ForApi(api);
            var apiCatalog = ApiCatalog.Load();
            var apiMetadata = apiCatalog[api];

            string output = layout.DocsOutputDirectory;
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            Directory.CreateDirectory(output);

            CreateGoogleApisDevDocfxJson(apiCatalog, apiMetadata, output);
            CreateDevsiteDocfxJson(apiCatalog, apiMetadata, output);
            CopyAndGenerateArticles(apiMetadata, layout.DocsSourceDirectory, output);
            CreateToc(api, output);
            return 0;
        }

        /// <summary>
        /// Generates the docfx.json file used to build googleapis.dev and GitHub pages sites.
        /// </summary>
        private static void CreateGoogleApisDevDocfxJson(ApiCatalog catalog, ApiMetadata rootApi, string outputDirectory)
        {
            var src = new JArray();

            var allApisToGenerate = GenerateApiSet(catalog, rootApi);
            foreach (var api in allApisToGenerate)
            {
                src.Add(new JObject
                {
                    ["files"] = new JArray { $"{api}/{api}.csproj" },
                    ["cwd"] = $"../../../apis/{api}"
                });
            }

            // Pick whichever framework is listed first. (This could cause problems if a dependency
            // doesn't target the given framework, but that seems unlikely.)
            // Default to netstandard2.0 if nothing is listed.
            string targetFramework = rootApi.TargetFrameworks?.Split(';').First() ?? "netstandard2.0";

            var json = new JObject
            {
                ["metadata"] = new JArray {
                    new JObject
                    {
                        ["src"] = src,
                        ["dest"] = "obj/api",
                        ["filter"] = "filterConfig.yml",
                        ["properties"] = new JObject { ["TargetFramework"] = targetFramework }
                    }
                },
                ["build"] = new JObject {
                    ["content"] = new JArray {
                        new JObject
                        {
                            ["files"] = "*.yml",
                            ["src"] = "obj/api",
                            ["dest"] = "api"
                        },
                        new JObject
                        {
                            ["files"] = new JArray { "*.md", "toc.yml" },
                        }
                    },
                    ["globalMetadata"] = new JObject
                    {
                        ["_appTitle"] = rootApi.Id,
                        ["_disableContribution"] = true,
                        ["_appFooter"] = " "
                    },
                    ["xref"] = new JArray
                    {
                        // Include the xref maps for REST APIs even if we may not need them, for simplicity.
                        // The directory is created in the build script.
                        $"../../dependencies/xrefmaps/Google.Apis.xrefmap.yml",
                        $"../../dependencies/xrefmaps/Google.Apis.Core.xrefmap.yml",
                        $"../../dependencies/xrefmaps/Google.Apis.Auth.xrefmap.yml",
                        $"../../dependencies/xrefmaps/Google.Apis.Storage.v1.xrefmap.yml",
                        $"../../dependencies/xrefmaps/Google.Apis.BigQuery.v2.xrefmap.yml",
                    },
                    ["template"] = new JArray { "default", "../../../third_party/docfx/templates/custom" },
                    ["overwrite"] = new JArray { "obj/snippets/*.md" },
                    ["dest"] = "site"
                }
            };
            File.WriteAllText(Path.Combine(outputDirectory, "docfx.json"), json.ToString());

            // We let the build script do work with the dependencies:
            // - Copy all yml files
            // - Concatenate toc.yml files
            var externalDependencies = GetExternalDependencies(catalog, allApisToGenerate)
                // Not all of our external dependencies are actually fetched yet. We need to fix that,
                // but that can come in a later step.
                .Where(d => Directory.Exists(Path.Combine(outputDirectory, $"../../dependencies/api/{d}")));
            File.WriteAllText(Path.Combine(outputDirectory, "dependencies"), string.Join(" ", externalDependencies));
        }

        /// <summary>
        /// Generates the docfx-devsite.json file used to generate just the metadata for DevSite.
        /// </summary>
        private static void CreateDevsiteDocfxJson(ApiCatalog catalog, ApiMetadata rootApi, string outputDirectory)
        {
            // Pick whichever framework is listed first. (This could cause problems if a dependency
            // doesn't target the given framework, but that seems unlikely.)
            // Default to netstandard2.0 if nothing is listed.
            string targetFramework = rootApi.TargetFrameworks?.Split(';').First() ?? "netstandard2.0";

            var json = new JObject
            {
                ["metadata"] = new JArray {
                    new JObject
                    {
                        ["src"] = new JObject
                        {
                            ["files"] = new JArray { $"{rootApi.Id}/{rootApi.Id}.csproj" },
                            ["cwd"] = $"../../../apis/{rootApi.Id}"
                        },
                        ["dest"] = "obj/bareapi",
                        ["filter"] = "filterConfig.yml",
                        ["properties"] = new JObject { ["TargetFramework"] = targetFramework }
                    },
                }
            };
            File.WriteAllText(Path.Combine(outputDirectory, "docfx-devsite.json"), json.ToString());
        }

        /// <summary>
        /// Given an initial starting API, return a set of all API IDs in the recursive set of dependencies.
        /// This does not include GAX etc.
        /// </summary>
        private static IEnumerable<string> GenerateApiSet(ApiCatalog catalog, ApiMetadata api)
        {
            var apiIds = catalog.CreateIdHashSet();
            HashSet<string> set = new HashSet<string>();
            Queue<string> processingQueue = new Queue<string>();
            processingQueue.Enqueue(api.Id);
            while (processingQueue.TryDequeue(out var next))
            {
                if (set.Add(next))
                {
                    var childApiDependencies = catalog[next].Dependencies.Keys.Intersect(apiIds).ToList();
                    foreach (var childApiDependency in childApiDependencies)
                    {
                        processingQueue.Enqueue(childApiDependency);
                    }
                }
            }
            return set;
        }

        /// <summary>
        /// Given a set of APIs we're generating docs for, find transitive external dependencies that we need to include in the doc set (if we have them).
        /// </summary>
        private static IEnumerable<string> GetExternalDependencies(ApiCatalog catalog, IEnumerable<string> apiIds)
        {
            var directExternalDependencies = apiIds
                .Select(id => catalog[id])
                .SelectMany(api => api.Dependencies.Keys)
                .Intersect(s_externalDependencies.Keys);
            HashSet<string> set = new HashSet<string>();
            Queue<string> processingQueue = new Queue<string>();
            foreach (var directDependency in directExternalDependencies)
            {
                processingQueue.Enqueue(directDependency);
            }

            while (processingQueue.TryDequeue(out var next))
            {
                if (set.Add(next))
                {
                    if (s_externalDependencies.TryGetValue(next, out var childDependencies))
                    {
                        foreach (var child in childDependencies)
                        {
                            processingQueue.Enqueue(child);
                        }
                    }
                }
            }
            return set;
        }

        private static void CopyAndGenerateArticles(ApiMetadata api, string inputDirectory, string outputDirectory)
        {
            // Make sure there's a landing page.
            var index = Path.Combine(inputDirectory, "index.md");
            if (!File.Exists(index))
            {
                throw new UserErrorException($"No index.md file for {api.Id}. Please add one!");
            }

            // TODO: Do this properly, with templating etc.
            // TODO: Other resources, such as images?

            // Copy any existing documentation
            if (Directory.Exists(inputDirectory))
            {
                foreach (var file in Directory.GetFiles(inputDirectory, "*.md"))
                {
                    string text = File.ReadAllText(file);
                    text = TransformDocTemplate(api, text);
                    File.WriteAllText(Path.Combine(outputDirectory, Path.GetFileName(file)), text);                    
                }
            }
        }

        /// <summary>
        /// Extremely crude templating, but just enough for now... it replaces the following tokens:
        /// {{title}}: Markdown for the page title with the API ID
        /// {{description}}: Markdown for the API description
        /// {{installation}}: Markdown for the installation section
        /// {{auth}}: Markdown for authentication instructions
        /// {{sample:sample ID}}: Include a sample. The sample ID is of the form "Source.Anchor",
        ///   e.g. "Index.GettingStarted" or "StorageClient.Overview"
        /// </summary>
        private static string TransformDocTemplate(ApiMetadata api, string text)
        {
            string title = $"# {api.Id}";
            string description = $"`{api.Id}` is a.NET client library for the [{api.ProductName} API]({api.ProductUrl}).";
            string version =
$@"Note:
This documentation is for version `{ api.Version}` of the library.
Some samples may not work with other versions.";
            string installation =
$@"## Installation

Install the `{api.Id}` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing ""Manage NuGet Packages..."").";
            if (!api.IsReleaseVersion)
            {
                installation += $@"
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the ""Include prerelease""
box). Some of the following samples might only work with the latest 
pre-release version (`{api.Version}`) of `{api.Id}`.";
            }

            string auth =
@"## Authentication

When running on Google Cloud Platform, no action needs to be taken to authenticate.

Otherwise, the simplest way of authenticating your API calls is to
download a service account JSON file then set the `GOOGLE_APPLICATION_CREDENTIALS` environment variable to refer to it.
The credentials will automatically be used to authenticate. See the [Getting Started With
Authentication](https://cloud.google.com/docs/authentication/getting-started) guide for more details.";

            var clients = GetClientClasses(api);
            string clientClasses = text.Contains("{{client-classes}}") ?
                CreateClientClassesDocumentation(api, clients) : "no client classes needed";

            var exampleClient = clients.FirstOrDefault();
            string clientConstruction =
$@"Create a client instance by calling the static `Create` or `CreateAsync` methods. Alternatively,
use the builder class associated with each client class (e.g. {exampleClient}Builder for {exampleClient})
as an easy way of specifying custom credentials, settings, or a custom endpoint. Clients are thread-safe,
and we recommend using a single instance across your entire application unless you have a particular need
to configure multiple client objects separately.";

            string nonProductStub = $@"# {api.Id}

This package is not a product in its own right; this page is
present as a root for the [API reference documentation](obj/api/{api.Id}.yml).";

            text = text
                .Replace("{{title}}", title)
                .Replace("{{description}}", description)
                .Replace("{{version}}", version)
                .Replace("{{installation}}", installation)
                .Replace("{{auth}}", auth)
                .Replace("{{client-classes}}", clientClasses)
                .Replace("{{client-construction}}", clientConstruction)
                .Replace("{{non-product-stub}}", nonProductStub);
            text = Regex.Replace(text, @"\{\{sample:([^\.]+)\.([^}]+)\}\}", "[!code-cs[](obj/snippets/" + api.Id + ".$1.txt#$2)]");
            return text;
        }

        private static string CreateClientClassesDocumentation(ApiMetadata api, List<string> clients)
        {
            clients = clients.Select(client => $"[{client}](obj/api/{api.Id}.{client}.yml)").ToList(); // Markdown link to API doc
            switch (clients.Count)
            {
                case 0: throw new InvalidOperationException("Couldn't find any clients for {{client-classes}} expansion.");
                case 1: return $"All operations are performed through {clients[0]}.";
                default:
                    var list = string.Join("\r\n", clients.Select(client => $"- {client}"));
                    return $"All operations are performed through the following client classes:\r\n\r\n{list}";
            }
        }

        // TODO: Find a more robust way of detecting the clients.
        private static List<string> GetClientClasses(ApiMetadata api)
        {
            if (api.Type != ApiType.Grpc && api.Type != ApiType.Regapic)
            {
                return new List<string>();
            }
            var layout = DirectoryLayout.ForApi(api.Id);
            var packageSource = Path.Combine(layout.SourceDirectory, api.Id);
            var sourceFiles = Directory.GetFiles(packageSource, "*Client.cs").Concat(Directory.GetFiles(packageSource, "*Client.g.cs"));
            return sourceFiles
                .Where(file => File.ReadAllText(file).Contains(": gaxgrpc::ServiceSettingsBase")) // Check it contains a generated client
                .Select(file => Path.GetFileName(file))             // Just the file name, not full path
                .Select(file => file.Split('.')[0]) // Trim .cs or .g.cs
                .OrderBy(client => client)
                .ToList();
        }

        private static void CreateToc(string api, string outputDirectory)
        {
            // TODO: Don't create it if it exists already?

            var tocEntries = new List<TocEntry>
            {
                new TocEntry { Name = "All APIs", Href = "../index.html" },
                new TocEntry { Name = "Home", Href = "index.md" },
            };

            // TODO: Ordering
            foreach (var file in Directory.GetFiles(outputDirectory, "*.md"))
            {
                string title = File.ReadLines(file).First().TrimStart(' ', '#');
                if (Path.GetFileName(file) == "index.md")
                {
                    continue;
                }
                tocEntries.Add(new TocEntry { Name = title, Href = Path.GetFileName(file) });
            }

            tocEntries.Add(new TocEntry { Name = "API Reference", Href = $"obj/api/{api}.yml" });

            using (var writer = File.CreateText(Path.Combine(outputDirectory, "toc.yml")))
            {
                var serializer = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
                serializer.Serialize(writer, tocEntries);
            }
        }
    }
}
