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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// The API catalog, containing all the metadata we need to generate and release APIs.
    /// </summary>
    public class ApiCatalog
    {
        private const string CatalogFile = "apis.json";

        /// <summary>
        /// The path of the API catalog within the google-cloud-dotnet repository.
        /// </summary>
        public const string PathInRepository = $"{RootLayout.GeneratorInputName}/{CatalogFile}";

        /// <summary>
        /// Groups of related packages which need to be released together.
        /// </summary>
        public List<PackageGroup> PackageGroups { get; set; }

        /// <summary>
        /// The APIs within the catalog.
        /// </summary>
        public List<ApiMetadata> Apis { get; set; }

        /// <summary>
        /// Proto paths for APIs we knowingly don't generate. The values are the reasons for not generating.
        /// </summary>
        public Dictionary<string, string> IgnoredPaths { get; set; }

        /// <summary>
        /// The JSON representation of the catalog. This is populated by <see cref="Load"/> and
        /// <see cref="FromJson(string)"/>, but nothing keeps this in sync with the in-memory data.
        /// </summary>
        [JsonIgnore]
        public JToken Json { get; set; }

        /// <summary>
        /// Formats <see cref="Json"/>.
        /// </summary>
        public string FormatJson() => Json.ToString(Formatting.Indented);

        /// <summary>
        /// Retrieves an API by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="UserErrorException"></exception>
        /// <returns>The API associated with the given ID</returns>
        public ApiMetadata this[string id] => TryGetApi(id, out var api) ? api : throw new UserErrorException($"No API with ID '{id}'");

        /// <summary>
        /// Tries to retrieves an API by ID, without throwing an exception if it's not present.
        /// </summary>
        public bool TryGetApi(string id, out ApiMetadata api)
        {
            api = Apis.SingleOrDefault(api => api.Id == id);
            return api is object;
        }

        /// <summary>
        /// Creates a hash set of the IDs of all the APIs in the catalog.
        /// </summary>
        /// <returns>A hash set of IDs.</returns>
        public HashSet<string> CreateIdHashSet() => new HashSet<string>(Apis.Select(api => api.Id));

        /// <summary>
        /// Creates a map from API ID to the current version of that ID (as a string).
        /// </summary>
        public Dictionary<string, string> CreateRawVersionMap() => Apis.ToDictionary(api => api.Id, api => api.Version);

        /// <summary>
        /// Loads the API catalog from the local disk, using <see cref="RootLayout.ForRepositoryRoot"/> as the layout.
        /// </summary>
        public static ApiCatalog Load() => Load(RootLayout.ForCurrentDirectory());

        /// <summary>
        /// Returns the path to the API catalog for the given root layout.
        /// </summary>
        private static string GetCatalogPath(RootLayout layout) => Path.Combine(layout.GeneratorInput, CatalogFile);

        public static ApiCatalog Load(RootLayout layout) => FromJson(File.ReadAllText(GetCatalogPath(layout)));

        public void Save(RootLayout layout) => File.WriteAllText(GetCatalogPath(layout), FormatJson());

        /// <summary>
        /// Loads the API catalog from the given JSON.
        /// </summary>
        /// <param name="json">The JSON containing the API catalog.</param>
        /// <returns>The API catalog.</returns>
        public static ApiCatalog FromJson(string json)
        {
            JToken parsed = JToken.Parse(json);
            var catalog = parsed.ToObject<ApiCatalog>(new JsonSerializer { MissingMemberHandling = MissingMemberHandling.Error });
            catalog.Json = parsed;
            // Provide the loaded JSON token for each API.
            foreach (var apiJson in parsed["apis"].Children().OfType<JObject>())
            {
                if (apiJson.TryGetValue("id", out var idToken))
                {
                    catalog[idToken.Value<string>()].Json = apiJson;
                }
            }

            // Populate package group relationships
            foreach (var group in catalog.PackageGroups)
            {
                foreach (var id in group.PackageIds)
                {
                    if (catalog.TryGetApi(id, out var member))
                    {
                        if (member.PackageGroup is object)
                        {
                            throw new UserErrorException($"Package '{id}' is in groups '{group.Id}' and '{member.PackageGroup.Id}'");
                        }
                        member.PackageGroup = group;
                    }
                    else
                    {
                        throw new UserErrorException($"Package '{id}' in group '{group.Id}' is unknonwn");
                    }
                }
            }
            return catalog;
        }
    }
}
