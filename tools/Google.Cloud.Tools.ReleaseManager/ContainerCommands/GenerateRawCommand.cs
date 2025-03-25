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

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Generates files for either a single API, with no additional configuration. Expected options:
/// - api-root: effectively the googleapis directory; required
/// - output: root folder for result; required, must exist
/// - api-path: (relative to api-root) e.g. google/cloud/functions/v2; required
/// </summary>
internal class GenerateRawCommand : IContainerCommand
{
    public int Execute(ContainerOptions options)
    {
        string apiRoot = options.RequireOption(options.ApiRoot);
        string output = options.RequireOption(options.Output);
        string apiPath = options.RequireOption(options.ApiPath);

        // For unconfigured generation, we use a really minimal generator-input directory in the container itself.
        // At the time of writing, this is only used for the common resource config (which hadn't changed between March 2021
        // and December 2024, so is clearly pretty stable).
        var rootLayout = RootLayout.ForGeneration("/app/generator-input", output, apiRoot);

        // Note: we expect the container to already have environment variables for
        // protoc, protobuf tools root, the gRPC generator, and the GAPIC generator.
        var generatorCommand = new GenerateApisCommand(rootLayout);
        return generatorCommand.Execute(new[] { "--unconfigured", apiPath });
    }
}
