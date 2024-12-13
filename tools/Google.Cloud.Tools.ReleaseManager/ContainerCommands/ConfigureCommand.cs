// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Configures a new library for a specified API. Expected options:
/// - api-root: effectively the googleapis directory.
/// - generator-input: required; generator-input directory for the repository
/// - output: root folder for result; required, must exist
/// - api-path: (related to api-root) e.g. google/cloud/functions/v2
/// </summary>
public class ConfigureCommand : IContainerCommand
{
    public int Execute(Dictionary<string, string> options)
    {
        var apiRoot = options["api-root"];
        var apiPath = options["api-path"];
        var generatorInput = options["generator-input"];

        var rootLayout = RootLayout.ForConfiguration(generatorInput, apiRoot);
        var apiIndex = ApiIndex.V1.Index.LoadFromGoogleApis(rootLayout.Googleapis);
        var targetApi = apiIndex.Apis.FirstOrDefault(api => api.Directory == apiPath);
        var catalog = ApiCatalog.Load(rootLayout);

        if (targetApi is null)
        {
            Console.WriteLine($"No API index entry for API path {apiPath}");
            return 1;
        }
        if (catalog.Apis.FirstOrDefault(api => api.ProtoPath == apiPath) is ApiMetadata api)
        {
            Console.WriteLine($"API path {apiPath} is already configured for {api.Id}");
            return 1;
        }

        api = AddCommand.ConfigureApi(apiRoot, catalog, targetApi);
        AddCommand.AddApiToCatalog(catalog, api);
        catalog.Save(rootLayout);
        return 0;
    }
}
