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
            Directory.CreateDirectory(_devSiteRoot);

            CopyApiDirectory();
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
            // Read the current TOC
            var deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            var apiToc = deserializer.Deserialize<List<dynamic>>(File.ReadAllText(tocFile));

            // Construct a TOC for guides from files
            var guidesToc = new List<dynamic>();
            foreach (var file in Directory.GetFiles(_outputRoot, "*.md"))
            {
                string title = Path.GetFileName(file) == "index.md"
                    ? "Getting started"
                    : File.ReadLines(file).First().TrimStart(' ', '#');
                guidesToc.Add(new { Name = title, Href = Path.GetFileName(file) });
            }

            // All guides go under a "Guides" node
            var guidesNode = new Dictionary<string, object>
            {
                ["name"] = "User Guides",
                ["items"] = guidesToc
            };

            // After the Guides node, there's an "All types" page
            var allTypesNode = new Dictionary<string, object>
            {
                ["name"] = "All types",
                ["uid"] = apiToc[0]["uid"]
            };

            // All other items come after Guides and All types
            var items = new dynamic[] { guidesNode, allTypesNode }.Concat((IEnumerable<dynamic>)apiToc[0]["items"]).ToList();

            var newToc = new[]
            {
                new Dictionary<string, object>
                {
                    ["name"] = apiToc[0]["name"],
                    ["items"] = items
                }
            };

            var serializer = new SerializerBuilder()
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            string newText = serializer.Serialize(newToc);
            File.WriteAllText(tocFile, newText);

        }

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
                ["xrefservices"] = new JArray("https://xref.docs.microsoft.com/query?uid={uid}")
                // TODO: xrefs
            };
            string json = docUploaderMetadata.ToString(Formatting.Indented);
            File.WriteAllText(Path.Combine(_devSiteRoot, "docs-metadata.json"), json);
        }

        private const string GoogleApisXrefPrefix = "https://googleapis.dev/dotnet";
        private const string GoogleApisXrefSuffix = "latest/xrefmap.yml";
        private const string DevSiteXrefPrefix = "https://cloud.devsite.corp.google.com/dotnet/docs/reference";
        private const string DevSiteXrefSuffix = "latest/xrefmap.yml";

        private static readonly string[] s_utilityXrefUrls =
        {
            $"{DevSiteXrefPrefix}/Google.Apis/{DevSiteXrefSuffix}",
            $"{DevSiteXrefPrefix}/Google.Api.Gax/{DevSiteXrefSuffix}",
            $"{DevSiteXrefPrefix}/Google.Protobuf/{DevSiteXrefSuffix}",
            $"{DevSiteXrefPrefix}/Grpc.Core/{DevSiteXrefSuffix}",
        };

        private List<string> GetXrefUrls(ApiMetadata api) =>
            s_utilityXrefUrls // It's harmless to include all of these, even if we don't use them.
                .Concat(GetTransitiveDependencies(api).Select(GetXrefUrl))
                .Where(xref => xref is object)
                .OrderBy(xref => xref)
                .ToList();

        private HashSet<string> GetTransitiveDependencies(ApiMetadata api)
        {
            // Note: this assumes there are no dependency cycles, but that's pretty reasonable.
            HashSet<string> ret = new HashSet<string>(api.Dependencies.Keys);
            foreach (var immediateDependency in ret.ToList())
            {
                if (_apiIds.Contains(immediateDependency))
                {
                    var dependencyMetadata = _apiCatalog[immediateDependency];
                    foreach (var transitive in GetTransitiveDependencies(dependencyMetadata))
                    {
                        ret.Add(transitive);
                    }
                }
            }
            return ret;
        }

        private string GetXrefUrl(string dependency) =>
            dependency switch
            {
                string pkg when pkg.StartsWith("Google.Apis") => $"{GoogleApisXrefPrefix}/{pkg}/{GoogleApisXrefSuffix}",
                string pkg when _apiCatalog.CreateIdHashSet().Contains(pkg) => $"{DevSiteXrefPrefix}/{pkg}/{DevSiteXrefSuffix}",
                _ => null
            };
    }
}
