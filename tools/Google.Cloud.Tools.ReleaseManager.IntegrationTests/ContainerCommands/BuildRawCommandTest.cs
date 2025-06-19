// Copyright 2025 Google LLC
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

using Google.Cloud.Tools.ReleaseManager.ContainerCommands;
using System.IO;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(ContainerCommandFixture))]
public class BuildRawCommandTest
{
    private readonly ContainerCommandFixture _fixture;

    public BuildRawCommandTest(ContainerCommandFixture fixture) => _fixture = fixture;

    [Fact]
    public void BuildRaw()
    {
        var outputFolder = _fixture.CreateGeneratorOutputFolder();
        outputFolder
            .CopyDirectory(Path.Combine(TestFiles.CommonFilesDirectory, "Google.Test.V1"), "google/test/v1")
            .CopyDirectory(Path.Combine(TestFiles.CommonFilesDirectory, "Google.Test.V2"), "google/test/v2");
        var apiPath = "google/test/v1";

        var command = new BuildRawCommand();
        var options = ContainerOptions.FromArgs(
            $"--generator-output={outputFolder.Directory}",
            $"--api-path={apiPath}",
            "--dotnet-path=dotnet");
        Assert.Equal(0, command.Execute(options));

        Assert.True(Directory.Exists(Path.Combine(outputFolder.Directory, apiPath, "Google.Test.V1", "bin")));
        Assert.False(Directory.Exists(Path.Combine(outputFolder.Directory, "google/test/v2", "Google.Test.V2", "bin")));
    }
}
