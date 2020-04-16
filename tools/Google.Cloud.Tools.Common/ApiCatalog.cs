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
        public List<ApiMetadata> Apis { get; set; }

        /// <summary>
        /// Retrieves an API by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="UserErrorException"></exception>
        /// <returns>The API associated with the given ID</returns>
        public ApiMetadata this[string id] => Apis.SingleOrDefault(api => api.Id == id) ?? throw new UserErrorException($"No API with ID '{id}'");

        /// <summary>
        /// The path to the API catalog (apis.json).
        /// </summary>
        public static string CatalogPath => Path.Combine(DirectoryLayout.DetermineRootDirectory(), RelativeCatalogPath);

        /// <summary>
        /// The relative path to the catalog path, e.g. for use when fetching from GitHub.
        /// </summary>
        public static string RelativeCatalogPath => "apis/apis.json";

        /// <summary>
        /// Loads the API catalog from the local disk, automatically determining the location.
        /// </summary>
        /// <returns></returns>
        public static ApiCatalog Load() => FromJson(File.ReadAllText(CatalogPath));

        /// <summary>
        /// Loads the API catalog from the given JSON.
        /// </summary>
        /// <param name="json">The JSON containing the API catalog.</param>
        /// <returns>The API catalog.</returns>
        public static ApiCatalog FromJson(string json) =>
            JsonConvert.DeserializeObject<ApiCatalog>(json);
    }
}
