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
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.GenerateDocfxSources
{
    public class Program
    {
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
            var layout = DirectoryLayout.FromApi(api);

            string output = layout.DocsOutputDirectory;
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            Directory.CreateDirectory(output);

            var apiDirectory = layout.ApiSourceDirectory;
            var projects = Project.LoadProjects(apiDirectory).ToList();

            CreateDocfxJson(api, projects, output);
            CopyAndGenerateArticles(api, layout.ApiDocsSourceDirectory, output);
            CreateToc(api, output);
            return 0;
        }

        private static void CreateDocfxJson(string api, List<Project> projects, string outputDirectory)
        {
            var src = new JArray();
            foreach (var project in projects)
            {
                src.Add(new JObject
                {
                    ["files"] = new JArray { $"{project.Name}/{project.Name}.csproj" },
                    ["cwd"] = $"../../../apis/{api}"
                });
            }

            var dependencies = projects.SelectMany(p => p.Dependencies).OrderBy(d => d).Distinct().ToList();
            foreach (var dependency in dependencies)
            {
                // Cross-API dependencies (currently for IAM and LRO)
                string candidateDependency = $"../../../apis/{dependency}";
                if (Directory.Exists(Path.Combine(outputDirectory, candidateDependency)))
                {
                    src.Add(new JObject
                    {
                        ["files"] = new JArray { $"{dependency}/{dependency}.csproj" },
                        ["cwd"] = candidateDependency
                    });
                    continue;
                }
            }

            var json = new JObject
            {
                ["metadata"] = new JArray {
                    new JObject
                    {
                        ["src"] = src,
                        ["dest"] = "obj/api",
                        ["filter"] = "filterConfig.yml",
                        // TODO: net45, really?
                        ["properties"] = new JObject { ["TargetFramework"] = "net45" }
                    },
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
                        ["_appTitle"] = api,
                        ["_disableContribution"] = true,
                        ["_appFooter"] = " "
                    },
                    ["overwrite"] = new JArray { "obj/snippets/*.md" },
                    ["dest"] = "site"
                }
            };
            File.WriteAllText(Path.Combine(outputDirectory, "docfx.json"), json.ToString());

            // We let the build script do work with the dependencies:
            // - Copy all yml files
            // - Concatenate toc.yml files
            var externalDependencies = dependencies
                .Where(d => Directory.Exists(Path.Combine(outputDirectory, $"../../dependencies/api/{d}")))
                .ToList();

            File.WriteAllText(Path.Combine(outputDirectory, "dependencies"), string.Join(" ", externalDependencies));
        }

        private static void CopyAndGenerateArticles(string api, string inputDirectory, string outputDirectory)
        {
            // TODO: Do this properly, with templating etc.
            // TODO: Other resources, such as images?

            // Copy any existing documentation
            if (Directory.Exists(inputDirectory))
            {
                foreach (var file in Directory.GetFiles(inputDirectory, "*.md"))
                {
                    File.Copy(file, Path.Combine(outputDirectory, Path.GetFileName(file)));
                }
            }

            // Generate a landing page if it doesn't exist
            var index = Path.Combine(outputDirectory, "index.md");
            if (!File.Exists(index))
            {
                using (var writer = File.CreateText(index))
                {
                    writer.WriteLine($"Getting started with {api}");
                    writer.WriteLine("---");
                    writer.WriteLine("Authentication");
                    writer.WriteLine("---");
                    writer.WriteLine("Examples");
                    writer.WriteLine("---");
                }
            }
        }

        private static void CreateToc(string api, string outputDirectory)
        {
            // TODO: Use YamlDotNet?
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
                var serializer = new Serializer(namingConvention: new CamelCaseNamingConvention());
                serializer.Serialize(writer, tocEntries);
            }
        }
    }
}
