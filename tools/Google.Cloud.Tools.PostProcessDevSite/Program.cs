// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.PostProcessDevSite
{
    /// <summary>
    /// Performs post-processing on the result of a docfx metadata build,
    /// so that it's ready for uploading to be presented on DevSite.
    /// 
    /// Command line argument: package ID
    /// 
    /// Expected inputs:
    /// - docs/output/{package}/obj/bareapi
    /// - docs/output/{package}/obj/snippets
    /// - docs/output/{package}/*.md (created by GenerateDocfxSources)
    /// 
    /// Output:
    /// - docs/output/{package}/devsite/api (including guides and tweaked TOC)
    /// - docs/output/{package}/devsite/examples
    /// - docs/output/{package}/devsite/docs-metadata.json (includes xrefs and xrefservices)
    /// </summary>
    class Program
    {
        /// <summary>
        /// The package/API ID
        /// </summary>
        private readonly string _apiId;

        /// <summary>
        /// Root docs output directory for the package: docs/output/{package}
        /// </summary>
        private readonly string _outputRoot;

        /// <summary>
        /// Output directory for everything for DevSite: docs/output/{package}/devsite
        /// </summary>
        private readonly string _devSiteRoot;

        private readonly ApiCatalog _apiCatalog;
        private readonly HashSet<string> _apiIds;

        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Expected argument: package ID");
                return 1;
            }
            new Program(args[0]).Execute();
            return 0;
        }

        private Program(string apiId)
        {
            DirectoryLayout layout = DirectoryLayout.ForApi(apiId);
            _apiId = apiId;
            _outputRoot = layout.DocsOutputDirectory;
            _devSiteRoot = Path.Combine(_outputRoot, "devsite");
            _apiCatalog = ApiCatalog.Load();
            _apiIds = _apiCatalog.CreateIdHashSet();
        }

        private void Execute()
        {
            if (Directory.Exists(_devSiteRoot))
            {
                Directory.Delete(_devSiteRoot, recursive: true);
            }
            // Non-Cloud packages shouldn't be uploaded to devsite.
            // This is indicated to later stages by the absence of the devsite output directory.
            if (!ApiMetadata.IsCloudPackage(_apiId))
            {
                return;
            }
            Directory.CreateDirectory(_devSiteRoot);

            CopyApiDirectory();
            FixExternalReferences();
            RegenerateToc();
            CopyGuides();
            AddGuidesToToc();
            CopySnippetsToExamples();
            CreateDocUploaderMetadata();
        }

        private void CopyApiDirectory()
        {
            var src = Path.Combine(_outputRoot, "obj", "bareapi");
            var dest = Path.Combine(_devSiteRoot, "api");
            Directory.CreateDirectory(dest);
            foreach (var file in Directory.GetFiles(src))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
            }
        }

        /// <summary>
        /// If we have project references (e.g. from Google.Cloud.Spanner.V1 to Google.Cloud.Spanner.Common.V1)
        /// the references within the docfx aren't labeled as "isExternal", so they aren't resolved against
        /// xrefmaps. This method fixes that, rewriting the YAML files.
        /// </summary>
        private void FixExternalReferences()
        {
            var dir = Path.Combine(_devSiteRoot, "api");
            var manifest = File.ReadAllText(Path.Combine(dir, ".manifest"));
            var packageUids = new HashSet<string>(JsonConvert.DeserializeObject<Dictionary<string, string>>(manifest).Keys);

            Console.WriteLine($"Loaded {packageUids.Count} manifest entries");
            foreach (var yamlFile in Directory.GetFiles(dir, "*.yml"))
            {
                if (Path.GetFileName(yamlFile) == "toc.yml")
                {
                    continue;
                }
                var yaml = new YamlStream();
                using (var reader = File.OpenText(yamlFile))
                {
                    yaml.Load(reader);
                }

                var doc = (YamlMappingNode) yaml.Documents[0].RootNode;
                var references = GetChildByName(doc, "references");
                if (references is object)
                {
                    FixExternalReferences(references);
                }

                // Note: this rewriting adds a "..." at the end of each file.
                // That indicates the end of a YAML document, and is fine.
                // We have to add the YamlMime header line ourselves as that isn't
                // preserved otherwise.
                using (var writer = File.CreateText(yamlFile))
                {
                    writer.WriteLine("### YamlMime:ManagedReference");
                    yaml.Save(writer, assignAnchors: false);
                }
            }

            void FixExternalReferences(YamlNode node)
            {
                switch (node)
                {
                    case YamlMappingNode mappingNode:
                        // Main part... find any nodes with a UID that isn't in this package, and no "isExternal" node,
                        // and no "definition" node (used for constructed types), and set that to be explicitly external.
                        // We trim any stars from the end of the name, as those
                        // are used for method overloads, and aren't included in the manifest.
                        var uidNode = GetChildByName(mappingNode, "uid");
                        var isExternalNode = GetChildByName(mappingNode, "isExternal");
                        var definitionNode = GetChildByName(mappingNode, "definition");
                        if (uidNode is YamlScalarNode { Value: string uid } &&
                            !packageUids.Contains(uid.TrimEnd('*')) &&
                            isExternalNode is null &&
                            definitionNode is null)
                        {
                            mappingNode.Add("isExternal", "true");
                        }
                        // Recurse
                        foreach (var pair in mappingNode.Children)
                        {
                            FixExternalReferences(pair.Value);
                        }
                        break;
                    case YamlSequenceNode sequenceNode:
                        // Recurse
                        foreach (var child in sequenceNode.Children)
                        {
                            FixExternalReferences(child);
                        }
                        break;
                }
            }

            YamlNode GetChildByName(YamlMappingNode parent, string name) =>
                parent.Children.FirstOrDefault(node => node.Key is YamlScalarNode key && key.Value == name).Value;
        }

        private void RegenerateToc()
        {
            var apiDir = Path.Combine(_devSiteRoot, "api");
            Tools.RegenerateToc.Program.Regenerate(apiDir);
        }

        private void CopyGuides()
        {
            var dest = Path.Combine(_devSiteRoot, "api");
            foreach (var file in Directory.GetFiles(_outputRoot, "*.md"))
            {
                var destFile = Path.Combine(dest, Path.GetFileName(file));
                // Fix up links within the guides
                var text = File.ReadAllText(file)
                    .Replace("obj/api/", "")
                    .Replace("obj/snippets/", "../examples/");
                File.WriteAllText(destFile, text);
            }
        }

        private void AddGuidesToToc()
        {
            var apiDirectory = Path.Combine(_devSiteRoot, "api");
            var tocFile = Path.Combine(apiDirectory, "toc.yml");

            // Construct a TOC for guides from files
            var guidesToc = new List<dynamic>();
            foreach (var file in Directory.GetFiles(_outputRoot, "*.md").OrderBy(GuideOrderingSelector, StringComparer.Ordinal))
            {
                string title = Path.GetFileName(file) == "index.md"
                    ? "Getting started"
                    : File.ReadLines(file).First().TrimStart(' ', '#');
                guidesToc.Add(new { Name = title, Href = Path.GetFileName(file) });
            }
            // All overview pages go under an "Overview" node
            var guidesNode = new Dictionary<string, object>
            {
                ["name"] = "Overview",
                ["items"] = guidesToc
            };

            // Read the current TOC, and add the new node as the first child of the root element.
            var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            var apiToc = deserializer.Deserialize<List<dynamic>>(File.ReadAllText(tocFile));

            // We're building for a single package, so we should have a single TOC entry.
            var root = apiToc[0];

            var rootItems = ((IEnumerable<dynamic>)root["items"]).ToList();
            rootItems.Insert(0, guidesNode);
            root["items"] = rootItems;

            var serializer = new SerializerBuilder()
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            string newText = serializer.Serialize(apiToc);
            File.WriteAllText(tocFile, newText);
        }

        /// <summary>
        /// Simple hack to enforce a reasonable Guide ordering:
        /// - Getting Started (index.md)
        /// - Version History (history.md)
        /// - Everything else
        /// </summary>
        private static string GuideOrderingSelector(string file) => Path.GetFileName(file) switch
        {
            "index.md" => "!0",
            "history.md" => "!1",
            var text => text
        };

        private void CopySnippetsToExamples()
        {
            var src = Path.Combine(_outputRoot, "obj", "snippets");
            var dest = Path.Combine(_devSiteRoot, "examples");
            Directory.CreateDirectory(dest);

            // If we don't have any snippets, bail now. We'll keep
            // the empty examples directory for the sake of consistency.
            if (!Directory.Exists(src))
            {
                return;
            }

            foreach (var file in Directory.GetFiles(src, "*.md"))
            {
                var lines = File.ReadAllLines(file)
                    .Select(MaybeReplaceSnippetWithExample);
                var destFile = Path.Combine(dest, Path.GetFileName(file));
                File.WriteAllLines(destFile, lines);
            }
            foreach (var file in Directory.GetFiles(src, "*.txt"))
            {
                var destFile = Path.Combine(dest, Path.GetFileName(file));
                File.Copy(file, destFile);
            }

            // The template expects "example" to be a list, so we wrap it in a single element list.
            string MaybeReplaceSnippetWithExample(string line) =>
                line == "snippet: *content" ? "example: [*content]" : line;
        }

        private void CreateDocUploaderMetadata()
        {
            var apiMetadata = ApiCatalog.Load()[_apiId];
            var docUploaderMetadata = new JObject
            {
                ["version"] = apiMetadata.Version,
                ["language"] = "dotnet",
                ["name"] = apiMetadata.Id,
                ["xrefs"] = new JArray(GetXrefUrls(apiMetadata)),
                ["xrefServices"] = new JArray("https://xref.docs.microsoft.com/query?uid={uid}")
            };
            string json = docUploaderMetadata.ToString(Formatting.Indented);
            File.WriteAllText(Path.Combine(_devSiteRoot, "docs.metadata.json"), json);
        }

        private const string GoogleApisXrefPrefix = "https://googleapis.dev/dotnet";
        private const string GoogleApisXrefSuffix = "/xrefmap.yml";
        private const string DevSiteXrefPrefix = "devsite://dotnet";

        // Dependencies to assume are always present. Note that while these
        // *are* valid packages in themselves, we may find other packages
        // that are similar, e.g. for the GAX "subpackages". In each case,
        // all the "subpackages" are contained in the same xrefmap because we
        // publish sets of utility packages together.
        private static readonly string[] s_defaultDependencies =
        {
            "Google.Apis",
            "Grpc.Core",
            "Google.Protobuf",
            "Google.Api.Gax",
            "Google.Api.CommonProtos"
        };

        private List<string> GetXrefUrls(ApiMetadata api)
        {
            // First create a dictionary of transitive dependencies, from
            // package to version, or null for "latest".

            // Start off with a bunch of default dependencies with "latest" version.
            // It's unlikely that using a later version than the real transitive
            // dependency will be a problem here.
            var dependencies = s_defaultDependencies.ToDictionary(dep => dep, dep => (string) null);

            PopulateTransitiveDependencies(api, dependencies);

            // We can still have multiple dependencies with the same xref stem, because
            // of the way utility packages are handled.
            var xrefStemsToVersions = dependencies.GroupBy(pair => GetXrefStem(pair.Key), pair => pair.Value);

            return xrefStemsToVersions
                .Select(GroupToXref)
                .Where(xref => xref is object)
                .OrderBy(xref => xref)
                .ToList();

            // Fetch the non-version-specific part of the xref map URL, or null for no xref.
            string GetXrefStem(string pkg)
            {
                // We have four types of dependency to consider:
                // - Utility: use a devsite:// URL for the package bundle
                // - google-cloud-dotnet: use a devsite:// URL for the package
                // - REST library (e.g. Storage, BigQuery): use an https://googleapis.dev URL for the package
                // - Anything else: skip (by returning null)
                return pkg switch
                {
                    "Google.Apis" => $"{DevSiteXrefPrefix}/Google.Apis",
                    "Google.Apis.Core" => $"{DevSiteXrefPrefix}/Google.Apis",
                    "Google.Apis.Auth" => $"{DevSiteXrefPrefix}/Google.Apis",
                    "Google.Api.CommonProtos" => $"{DevSiteXrefPrefix}/Google.Api.CommonProtos",
                    "Google.Protobuf" => $"{DevSiteXrefPrefix}/Google.Protobuf",
                    var grpc when grpc.StartsWith("Grpc.") => $"{DevSiteXrefPrefix}/Grpc.Core",
                    var gax when gax.StartsWith("Google.Api.Gax") => $"{DevSiteXrefPrefix}/Google.Api.Gax",
                    var api when _apiIds.Contains(api) => $"{DevSiteXrefPrefix}/{api}",
                    var api when api.StartsWith("Google.Apis") => $"{GoogleApisXrefPrefix}/{api}",
                    _ => null
                };
            }

            // Key is the xref stem; values are versions
            string GroupToXref(IGrouping<string, string> dependencyGroup)
            {
                var stem = dependencyGroup.Key;
                if (stem is null)
                {
                    return null;
                }
                // If we have more than one version, let's just go with "latest".
                string version = dependencyGroup.Count() == 1 ? dependencyGroup.Single() : null;

                return stem.StartsWith(DevSiteXrefPrefix)
                    ? version is null ? stem : $"{stem}@{version}"
                    : $"{stem}/{version ?? "latest"}{GoogleApisXrefSuffix}";
            }
        }

        private void PopulateTransitiveDependencies(ApiMetadata api, Dictionary<string, string> dependencies)
        {
            foreach (var dependency in api.Dependencies)
            {
                string pkg = dependency.Key;
                string version = dependency.Value switch
                {
                    "project" => _apiCatalog[pkg].Version,
                    "default" => null, // Latest
                    _ => dependency.Value
                };
                if (dependencies.TryGetValue(pkg, out var existingVersion))
                {
                    // Replace the existing dependency version with our new one if
                    // the existing dependency is a specific version, and ours is
                    // either "latest" or a more recent specific version.
                    if (existingVersion is object)
                    {
                        if (version is null)
                        {
                            dependencies[pkg] = null;
                        }
                        else
                        {
                            StructuredVersion existingStructured = StructuredVersion.FromString(existingVersion);
                            StructuredVersion candidateStructured = StructuredVersion.FromString(version);
                            if (candidateStructured.CompareTo(existingStructured) > 0)
                            {
                                dependencies[pkg] = version;
                            }
                        }
                    }
                    // We don't need to recurse here. We'll already have pulled in
                    // any transitive dependencies when first adding it.
                }
                else
                {
                    dependencies[pkg] = version;
                    // If the dependency is another API in google-cloud-dotnet, add transitive dependencies.
                    // These are the dependencies of "latest" rather than the specific version, but it's
                    // very unlikely to actually cause problems.
                    if (_apiIds.Contains(pkg))
                    {
                        PopulateTransitiveDependencies(_apiCatalog[pkg], dependencies);
                    }
                }
            }
        }
    }
}
