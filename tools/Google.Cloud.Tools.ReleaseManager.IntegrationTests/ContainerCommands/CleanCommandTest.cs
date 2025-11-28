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

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.ReleaseManager.ContainerCommands;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(ContainerCommandFixture))]
public class CleanCommandTest
{
    private readonly ContainerCommandFixture _fixture;

    public CleanCommandTest(ContainerCommandFixture fixture) => _fixture = fixture;

    [Fact]
    public void SinglePackage()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Test.Other", "Test.CleanMe");
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddGeneratedFiles(catalog.Apis)
            .AddFile("apis/Test.CleanMe/Test.CleanMe/Handwritten.cs")
            .AddFile("apis/Test.CleanMe/Test.CleanMe.Snippets/Handwritten.cs");
        var command = new CleanCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}",
            "--library-id=Test.CleanMe");
        Assert.Equal(0, command.Execute(options));

        // We've deleted what we should...
        context.CodeRepo.AssertDoNotExist(
            "apis/Test.CleanMe/Test.CleanMe.sln",
            "apis/Test.CleanMe/Test.CleanMe/Test.CleanMe.csproj",
            "apis/Test.CleanMe/Test.CleanMe/SourceCode.g.cs",
            "apis/Test.CleanMe/Test.CleanMe.Snippets/Test.CleanMe.Snippets.csproj",
            "apis/Test.CleanMe/Test.CleanMe.Snippets/SourceCode.g.cs",
            "apis/Test.CleanMe/Test.CleanMe.GeneratedSnippets/Test.CleanMe.GeneratedSnippets.csproj",
            "apis/Test.CleanMe/Test.CleanMe.GeneratedSnippets/SourceCode.g.cs",
            // The directory itself should have been deleted.
            "apis/Test.CleanMe/Test.CleanMe.GeneratedSnippets",
            "apis/Test.CleanMe/gapic_metadata.json",
            "apis/Test.CleanMe/.repo-metadata.json"
            );

        // We haven't touched the other project...
        context.CodeRepo.AssertExist(
            "apis/Test.Other/Test.Other.sln",
            "apis/Test.Other/Test.Other/Test.Other.csproj",
            "apis/Test.Other/Test.Other/SourceCode.g.cs",
            "apis/Test.Other/Test.Other.Snippets/Test.Other.Snippets.csproj",
            "apis/Test.Other/Test.Other.Snippets/SourceCode.g.cs",
            "apis/Test.Other/Test.Other.GeneratedSnippets/Test.Other.GeneratedSnippets.csproj",
            "apis/Test.Other/Test.Other.GeneratedSnippets/SourceCode.g.cs",
            "apis/Test.Other/gapic_metadata.json",
            "apis/Test.Other/.repo-metadata.json"
            );

        // The handwritten files are still there
        context.CodeRepo.AssertExist(
            "apis/Test.CleanMe/Test.CleanMe/Handwritten.cs",
            "apis/Test.CleanMe/Test.CleanMe.Snippets/Handwritten.cs");
    }

    [Fact]
    public void PackageGroup()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Test.Other", "Test.Clean1", "Test.Clean2");
        var group = new PackageGroup
        {
            DisplayName = "Test clean",
            Id = "Test.Clean",
            PackageIds = { "Test.Clean1", "Test.Clean2" }
        };
        catalog.PackageGroups.Add(group);
        catalog["Test.Clean1"].PackageGroup = group;
        catalog["Test.Clean2"].PackageGroup = group;
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddGeneratedFiles(catalog.Apis);
        var command = new CleanCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}",
            "--library-id=Test.Clean");
        Assert.Equal(0, command.Execute(options));

        // Only checking the solution files as a simple way of checking that we've cleaned the right projects.
        context.CodeRepo.AssertDoNotExist(
            "apis/Test.Clean1/Test.Clean1.sln",
            "apis/Test.Clean2/Test.Clean2.sln");
        context.CodeRepo.AssertExist("apis/Test.Other/Test.Other.sln");
    }

    [Fact]
    public void MissingLibrary()
    {
        var context = _fixture.CreateContext();
        var catalog = context.CreateApiCatalog("Test.Other", "Test.CleanMe");
        var codeRepo = context.CreateCodeRepo(catalog);
        codeRepo.AddGeneratedFiles(catalog.Apis);
        var command = new CleanCommand();
        var options = ContainerOptions.FromArgs(
            $"--repo-root={codeRepo.Directory}",
            $"--library-id=no-such-library");
        Assert.Throws<UserErrorException>(() => command.Execute(options));
    }
}
