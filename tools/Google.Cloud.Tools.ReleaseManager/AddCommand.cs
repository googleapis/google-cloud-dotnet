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

using Google.Cloud.Tools.ApiIndex.V1;
using Google.Cloud.Tools.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Tool to add a new library based on the service config (and protos) for an API.
    /// </summary>
    public class AddCommand : CommandBase
    {
        public AddCommand()
            : base("add", "Adds an API to the API catalog", "id")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];

            var catalog = ApiCatalog.Load();
            if (catalog.Apis.Any(api => api.Id == id))
            {
                throw new UserErrorException($"API {id} already exists in the API catalog.");
            }
            var root = DirectoryLayout.DetermineRootDirectory();
            var googleapis = Path.Combine(root, "googleapis");
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

            var api = new ApiMetadata
            {
                Id = id,
                ProtoPath = targetApi.Directory,
                ProductName = targetApi.Title.EndsWith(" API") ? targetApi.Title[..^4] : targetApi.Title,
                Description = targetApi.Description,
                Version = "1.0.0-beta00",
                Type = ApiType.Grpc,
                Generator = GeneratorType.Micro,
                // Let's not include test dependencies, which are rarely useful.
                TestDependencies = null,
                // Translate the host name into the "short name", e.g. bigquery.googleapis.com => bigquery
                ShortName = targetApi.HostName.Split('.').First(),
                // The service config file is always populated in the index, so we don't need to translate empty to null here.
                ServiceConfigFile = targetApi.ConfigFile
            };

            // Add dependencies discovered via the proto imports.
            // This doesn't fail on any dependencies that aren't found - we could tighten this up later
            // by knowing about common protos, for example.
            var apisByProtoPath = catalog.Apis.Where(api => api.ProtoPath is object).ToDictionary(api => api.ProtoPath);
            foreach (var import in targetApi.ImportDirectories)
            {
                if (apisByProtoPath.TryGetValue(import, out var dependency))
                {
                    api.Dependencies.Add(dependency.Id, dependency.Version);
                }
            }

            // Now work out what the new API metadata looks like in JSON.
            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
                ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
            };            
            api.Json = JToken.FromObject(api, serializer);

            var followingApi = catalog.Apis.FirstOrDefault(api => string.Compare(api.Id, id, StringComparison.Ordinal) > 0);
            if (followingApi is object)
            {
                followingApi.Json.AddBeforeSelf(api.Json);
            }
            else
            {
                // Looks like this API will be last in the list.
                catalog.Apis.Last().Json.AddAfterSelf(api.Json);
            }

            // Done. Let's write out the catalog and display what we've done.
            File.WriteAllText(ApiCatalog.CatalogPath, catalog.FormatJson());
            Console.WriteLine($"Added {id} to the API catalog with the following configuration:");
            Console.WriteLine(api.Json.ToString(Formatting.Indented));
        }
    }
}
