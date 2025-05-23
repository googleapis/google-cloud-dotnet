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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Configures a new library for a specified API. Expected options:
/// - api-root: effectively the googleapis directory; required.
/// - generator-input: required; generator-input directory for the repository
/// - api-path: (relative to api-root) e.g. google/cloud/functions/v2; required
/// </summary>
public class ConfigureCommand : IContainerCommand
{
    public int Execute(ContainerOptions options)
    {
        var apiRoot = options.RequireOption(options.ApiRoot);
        var apiPath = options.RequireOption(options.ApiPath);
        var generatorInput = options.RequireOption(options.GeneratorInput);

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
        catalog.Add(api);
        catalog.Save(rootLayout);

        // Now add the new library to the 
        // At some point we might generate the proto for this, but for the moment this will do.
        var pipelineStateFile = Path.Combine(rootLayout.GeneratorInput, "pipeline-state.json");
        JObject state = JObject.Parse(File.ReadAllText(pipelineStateFile));
        JArray libraries = (JArray) state["libraries"];
        libraries.Add(new JObject()
        {
            ["id"] = api.Id,
            ["generationAutomationLevel"] = "AUTOMATION_LEVEL_AUTOMATIC",
            ["releaseAutomationLevel"] = "AUTOMATION_LEVEL_BLOCKED",
            ["apiPaths"] = new JArray(apiPath),
            ["sourcePaths"] = new JArray($"apis/{api.Id}/{api.Id}"),
            // Prepare for the first release with an alpha or beta.
            ["nextVersion"] = api.Id.Split('.').Last().Contains("alpha", StringComparison.OrdinalIgnoreCase) ? "1.0.0-alpha01" : "1.0.0-beta01"
        });

        // Slightly fiddly serialization to mimic the indentation that Librarian uses.
        using var fileWriter = File.CreateText(pipelineStateFile);
        using var jsonWriter = new JsonTextWriter(fileWriter) { Formatting = Formatting.Indented, Indentation = 4 };
        state.WriteTo(jsonWriter);

        return 0;
    }
}
