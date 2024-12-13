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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Generates files for either a single API or all configured APIs. Expected options:
/// - api-root: effectively the googleapis directory.
/// - generator-input: optional, when omitted, run "raw generation"
/// - output: root folder for result; required, must exist
/// - api-path: (related to api-root) e.g. google/cloud/functions/v2
//    optional when generator-input is specified, when omitted, all configured APIs should be regenerated
//    required when generator-input is not specified (because we don’t want to raw-generate everything in api-root)
/// </summary>
internal class GenerateCommand : IContainerCommand
{
    public int Execute(Dictionary<string, string> options)
    {
        string apiRoot = options["api-root"];
        string output = options["output"];
        string generatorInput = options.GetValueOrDefault("generator-input");
        string apiPath = options.GetValueOrDefault("api-path");

        if (apiPath is null && generatorInput is null)
        {
            throw new UserErrorException("At least one of api-path or generator-input must be specified");
        }

        // Note: we expect the container to already have environment variables for
        // protoc, protobuf tools root, the gRPC generator, and the GAPIC generator.

        // For unconfigured generation, we use a really minimal generator-input directory in the container itself.
        // At the time of writing, this is only used for the common resource config (which hadn't changed between March 2021
        // and December 2024, so is clearly pretty stable).
        Environment.SetEnvironmentVariable(GenerateApisCommand.GeneratorInputDirectoryEnvironmentVariable, generatorInput ?? "/app/generator-input");
        Environment.SetEnvironmentVariable(GenerateApisCommand.GeneratorOutputDirectoryEnvironmentVariable, output);
        Environment.SetEnvironmentVariable(GenerateApisCommand.GoogleApisDirectoryEnvironmentVariable, apiRoot);

        var generatorCommand = new GenerateApisCommand();
        if (generatorInput is null)
        {
            return generatorCommand.Execute(new[] { "--unconfigured", apiPath });
        }
        else
        {
            if (apiPath is not null)
            {
                var catalog = ApiCatalog.LoadFromGeneratorInput(generatorInput);
                var id = catalog.Apis.FirstOrDefault(api => api.ProtoPath == apiPath)?.Id;
                if (id is null)
                {
                    // TODO: Optionally, create a temporary configuration.
                    Console.WriteLine($"No configured API for path '{apiPath}'. Aborting.");
                    return 1;
                }
                return generatorCommand.Execute(new[] { id });
            }
            else
            {
                return generatorCommand.Execute(new string[0]);
            }
        }
    }
}
