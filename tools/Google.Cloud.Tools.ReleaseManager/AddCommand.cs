// Copyright 2020 Google LLC
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
using Google.Protobuf;
using LibGit2Sharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Tool to add a new library based on the service config (and protos) for an API.
    /// </summary>
    public class AddCommand : ICommand
    {
        private const string NoPullArgument = "--no-pull";
        public string Description => "Adds an API to the API catalog";

        public string Command => "add";

        public string ExpectedArguments => $"<id> [{NoPullArgument}]";

        public int Execute(string[] args)
        {
            if (args.Length == 0 || args.Length > 2 || (args.Length == 2 && args[1] != NoPullArgument))
            {
                throw new UserErrorException($"{Command} expected arguments: {ExpectedArguments}");
            }
            string id = args[0];
            bool pull = args.Length == 1; // We've already validated that if we've got 2 arguments, the second is NoPullArgument...

            var rootLayout = RootLayout.ForCurrentDirectory();
            var catalog = ApiCatalog.Load(rootLayout);
            if (catalog.Apis.Any(api => api.Id == id))
            {
                throw new UserErrorException($"API {id} already exists in the API catalog.");
            }
            var googleapis = rootLayout.Googleapis;

            if (pull)
            {
                Console.WriteLine($"Pulling googleapis directory");
                using var repo = new Repository(googleapis);
                string oldSha = repo.Head.Tip.Sha;
                
                // The "merger" signature will never be used, due to requiring fast-forward-only,
                // but we have to specify something.
                var merger = new Signature("Ignored", "ignored@google.com", DateTimeOffset.UtcNow);
                var pullOptions = new PullOptions
                {
                    MergeOptions = new MergeOptions { FastForwardStrategy = FastForwardStrategy.FastForwardOnly, FailOnConflict = true }
                };
                Commands.Pull(repo, merger, pullOptions);
                string newSha = repo.Head.Tip.Sha;
                Console.WriteLine(oldSha == newSha ? "Pull did not make changes" : $"Pull moved from {oldSha} to {newSha}");
            }

            var apiIndex = ApiIndex.V1.Index.LoadFromGoogleApis(googleapis);

            var targetApi = apiIndex.Apis.FirstOrDefault(api => api.DeriveCSharpNamespace() == id);
            if (targetApi is null)
            {
                var lowerWithoutCloud = id.Replace(".Cloud", "").ToLowerInvariant();
                var possibilities = apiIndex.Apis
                    .Select(api => api.DeriveCSharpNamespace())
                    .Where(ns => ns.Replace(".Cloud", "").ToLowerInvariant() == lowerWithoutCloud);
                throw new UserErrorException(
                    $"No service found for '{id}'.{Environment.NewLine}Similar possibilities (check options?): {string.Join(", ", possibilities)}");
            }

            var api = ConfigureApi(googleapis, catalog, targetApi);
            AddApiToCatalog(catalog, api);

            // Done. Let's write out the catalog and display what we've done.
            catalog.Save(rootLayout);
            Console.WriteLine($"Added {id} to the API catalog with the following configuration:");
            Console.WriteLine(api.Json.ToString(Formatting.Indented));
            return 0;
        }

        internal static void AddApiToCatalog(ApiCatalog catalog, ApiMetadata api)
        {
            // Now work out what the new API metadata looks like in JSON.
            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
                ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
            };
            api.Json = (JObject) JToken.FromObject(api, serializer);

            var followingApi = catalog.Apis.FirstOrDefault(candidate => string.Compare(candidate.Id, api.Id, StringComparison.Ordinal) > 0);
            if (followingApi is object)
            {
                followingApi.Json.AddBeforeSelf(api.Json);
            }
            else
            {
                // Looks like this API will be last in the list.
                catalog.Apis.Last().Json.AddAfterSelf(api.Json);
            }
        }

        internal static ApiMetadata ConfigureApi(string googleapis, ApiCatalog catalog, ApiIndex.V1.Api apiIndexEntry)
        {
            var serviceConfig = ParseServiceConfigYaml(Path.Combine(googleapis, apiIndexEntry.Directory, apiIndexEntry.ConfigFile));

            var api = new ApiMetadata
            {
                Id = apiIndexEntry.DeriveCSharpNamespace(),
                ProtoPath = apiIndexEntry.Directory,
                ProductName = apiIndexEntry.Title.EndsWith(" API") ? apiIndexEntry.Title[..^4] : apiIndexEntry.Title,
                ProductUrl = serviceConfig.Publishing?.DocumentationUri,
                Description = apiIndexEntry.Description,
                Version = "1.0.0-beta00",
                Type = ApiType.Grpc,
                Generator = GeneratorType.Micro,
                // Let's not include test dependencies, which are rarely useful.
                TestDependencies = null,
                // Translate the host name into the "short name", e.g. bigquery.googleapis.com => bigquery
                ShortName = apiIndexEntry.HostName.Split('.').First(),
                // The service config file is always populated in the index, so we don't need to translate empty to null here.
                ServiceConfigFile = apiIndexEntry.ConfigFile
            };

            // Add dependencies discovered via the proto imports.
            // This doesn't fail on any dependencies that aren't found - we could tighten this up later
            // by knowing about common protos, for example.
            var apisByProtoPath = catalog.Apis.Where(api => api.ProtoPath is object).ToDictionary(api => api.ProtoPath);
            foreach (var import in apiIndexEntry.ImportDirectories)
            {
                if (apisByProtoPath.TryGetValue(import, out var dependency))
                {
                    api.Dependencies.Add(dependency.Id, dependency.Version);
                }
            }

            // Add mixin dependencies discovered via APIs listed in the service config file.
            // This *does* fail if we can't find the API, as that would indicate a general issue.
            foreach (var mixin in apiIndexEntry.GetMixinPackages())
            {
                api.Dependencies[mixin] = catalog[mixin].Version;
            }

            // Add any other information from BUILD.bazel
            UpdateFromBazelCommand.Update(api, googleapis);
            return api;
        }

        // This is internal so that it's available to GenerateApisCommand, for unconfigured
        // APIs. This is somewhat experimental - if we want this long-term, we should probably
        // move it elsewhere.
        internal static Api.Service ParseServiceConfigYaml(string path)
        {
            if (path is null)
            {
                return null;
            }

            var deserializer = new Deserializer();
            using (var reader = File.OpenText(path))
            {
                var yamlObject = deserializer.Deserialize(reader);
                var serializer = new SerializerBuilder().JsonCompatible().Build();
                var writer = new StringWriter();
                serializer.Serialize(writer, yamlObject);
                string json = writer.ToString();
                // Hack to avoid proto parse failures with the serialized JSON: YamlDotNet serializes
                // values as strings (because it doesn't know that they're Boolean). Ideally, we should
                // deserialize straight from YAML to a Service...
                json = json.Replace("\"true\"", "true").Replace("\"false\"", "false");
                var parser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
                return parser.Parse<Api.Service>(json);
            }
        }
    }
}
