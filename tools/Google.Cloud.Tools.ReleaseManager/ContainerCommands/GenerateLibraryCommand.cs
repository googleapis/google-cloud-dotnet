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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Generates files for a single library. Expected options:
/// - api-root: effectively the googleapis directory; required
/// - generator-input: required
/// - output: root folder for result; required, must exist
/// - library-id: the library to generate; required
/// </summary>
internal class GenerateLibraryCommand : IContainerCommand
{
    public int Execute(ContainerOptions options)
    {
        string apiRoot = options.RequireOption(options.ApiRoot);
        string output = options.RequireOption(options.Output);
        string generatorInput = options.RequireOption(options.GeneratorInput);

        var rootLayout = RootLayout.ForGeneration(generatorInput, output, apiRoot);

        // Note: we expect the container to already have environment variables for
        // protoc, protobuf tools root, the gRPC generator, and the GAPIC generator.
        var generatorCommand = new GenerateApisCommand(rootLayout);
        // Set environment variables used by scripts invoked by GenerateApisCommand.
        Environment.SetEnvironmentVariable(GenerateApisCommand.GeneratorInputDirectoryEnvironmentVariable, rootLayout.GeneratorInput);
        Environment.SetEnvironmentVariable(GenerateApisCommand.GeneratorOutputDirectoryEnvironmentVariable, rootLayout.GeneratorOutput);
        Environment.SetEnvironmentVariable(GenerateApisCommand.GoogleApisDirectoryEnvironmentVariable, rootLayout.Googleapis);

        var catalog = ApiCatalog.Load(rootLayout);
        var apis = options.GetApisFromLibraryId(catalog);
        return generatorCommand.Execute(apis.Select(api => api.Id).ToArray());
    }
}
