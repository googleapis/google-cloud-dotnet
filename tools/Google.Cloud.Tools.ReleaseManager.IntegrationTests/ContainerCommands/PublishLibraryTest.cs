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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(ContainerCommandFixture))]
public class PublishLibraryTest
{
    private const string PackageOwner = "test-owner";
    private const string ApiKeyEnvironmentVariable = PublishLibraryCommand.NuGetApiKeyEnvPrefix + "TEST_OWNER";
    private const string DocsBucketEnvironmentVariable = PublishLibraryCommand.DocsBucketEnvPrefix + "GOOGLEAPISDEV";
    private const string DocsBucket = "test-bucket";
    private const string NuGetApiKey = "api-key";
    private const string PackageFile = "Google.Test.V1.1.0.0.nupkg";
    private const string SbomFile = "Google.Test.V1.1.0.0.nupkg-sbom.spdx.json";
    private const string DocsFile = "googleapisdev-Google.Test.V1-1.0.0.tar.gz";
    private const string DestinationObject = "dotnet-Google.Test.V1-1.0.0.tar.gz";

    private readonly ContainerCommandFixture _fixture;

    public PublishLibraryTest(ContainerCommandFixture fixture) => _fixture = fixture;

    [Fact]
    public void DocBundleAndPackage()
    {
        var output = _fixture.CreateOutputFolder()
            .AddTextFile(PackageLibraryCommand.PackageOwnerFile, PackageOwner)
            .AddEmptyFile(PackageFile)
            .AddEmptyFile(SbomFile)
            .AddEmptyFile(DocsFile);
        var command = RunSuccessTest(output);

        var expectedPublishedPackage = new PublishLibraryCommand.NuGetPackage(NuGetApiKey, Path.Combine(output.Directory, PackageFile));
        var actualPublishedPackage = Assert.Single(command.PublishedPackages);
        Assert.Equal(expectedPublishedPackage, actualPublishedPackage);

        var actualUploadedDocsBundle = Assert.Single(command.UploadedDocsBundles);
        var expectedUploadedDocsBundle = new PublishLibraryCommand.DocumentationBundle(
            File: Path.Combine(output.Directory, DocsFile),
            DestinationObject: DestinationObject,
            Bucket: DocsBucket);
        Assert.Equal(expectedUploadedDocsBundle, actualUploadedDocsBundle);
    }

    [Fact]
    public void MultiplePackages_NoDocs()
    {
        var output = _fixture.CreateOutputFolder()
            .AddTextFile(PackageLibraryCommand.PackageOwnerFile, PackageOwner)
            .AddEmptyFile(PackageFile)
            .AddEmptyFile(SbomFile)
            .AddEmptyFile("Google.Test.V2.1.0.0.nupkg")
            .AddEmptyFile("Google.Test.V2.1.0.0.nupkg-sbom.spdx.json");
        var command = RunSuccessTest(output);

        var expectedPublishedPackages = new[]
        {
            new PublishLibraryCommand.NuGetPackage(NuGetApiKey, Path.Combine(output.Directory, PackageFile)),
            new PublishLibraryCommand.NuGetPackage(NuGetApiKey, Path.Combine(output.Directory, "Google.Test.V2.1.0.0.nupkg")),
        };
        Assert.Equal(
            expectedPublishedPackages.OrderBy(p => p.File, StringComparer.Ordinal),
            command.PublishedPackages.OrderBy(p => p.File, StringComparer.Ordinal));
        Assert.Empty(command.UploadedDocsBundles);
    }

    [Fact]
    public void MultipleDocsBundles_NoPackages()
    {
        var output = _fixture.CreateOutputFolder()
            .AddEmptyFile(DocsFile)
            .AddEmptyFile("googleapisdev-Google.Test.V2-1.0.0.tar.gz");
        var command = RunSuccessTest(output);

        Assert.Empty(command.PublishedPackages);
        var expectedUploadedDocsBundles = new[]
        {
            new PublishLibraryCommand.DocumentationBundle(
                File: Path.Combine(output.Directory, DocsFile),
                DestinationObject: DestinationObject,
                Bucket: DocsBucket),
            new PublishLibraryCommand.DocumentationBundle(
                File: Path.Combine(output.Directory, "googleapisdev-Google.Test.V2-1.0.0.tar.gz"),
                DestinationObject: "dotnet-Google.Test.V2-1.0.0.tar.gz",
                Bucket: DocsBucket),
        };
        Assert.Equal(
            expectedUploadedDocsBundles.OrderBy(b => b.File, StringComparer.Ordinal),
            command.UploadedDocsBundles.OrderBy(b => b.File, StringComparer.Ordinal));
    }

    [Fact]
    public void MissingApiKey()
    {
        var output = _fixture.CreateOutputFolder()
            .AddTextFile(PackageLibraryCommand.PackageOwnerFile, PackageOwner)
            .AddEmptyFile(PackageFile)
            .AddEmptyFile(SbomFile)
            .AddEmptyFile(DocsFile);
        RunFailingTest(output, null, DocsBucket);
    }

    [Fact]
    public void MissingDocsBucket()
    {
        var output = _fixture.CreateOutputFolder()
            .AddTextFile(PackageLibraryCommand.PackageOwnerFile, PackageOwner)
            .AddEmptyFile(PackageFile)
            .AddEmptyFile(SbomFile)
            .AddEmptyFile(DocsFile);
        RunFailingTest(output, NuGetApiKey, null);
    }

    [Fact]
    public void MissingPackageOwnerFile()
    {
        var output = _fixture.CreateOutputFolder()
            .AddEmptyFile(PackageFile)
            .AddEmptyFile(SbomFile)
            .AddEmptyFile(DocsFile);
        RunFailingTest(output, NuGetApiKey, DocsBucket);
    }

    private FakeCommand RunSuccessTest(OutputFolder output)
    {
        Environment.SetEnvironmentVariable(ApiKeyEnvironmentVariable, NuGetApiKey);
        Environment.SetEnvironmentVariable(DocsBucketEnvironmentVariable, DocsBucket);
        var command = new FakeCommand();
        var options = ContainerOptions.FromArgs($"--package-output={output.Directory}");
        command.Execute(options);
        return command;
    }

    private void RunFailingTest(OutputFolder output, string apiKeyEnvironmentValue, string docsBucketEnvironmentValue)
    {
        Environment.SetEnvironmentVariable(ApiKeyEnvironmentVariable, apiKeyEnvironmentValue);
        Environment.SetEnvironmentVariable(DocsBucketEnvironmentVariable, docsBucketEnvironmentValue);
        var command = new FakeCommand();
        var options = ContainerOptions.FromArgs($"--package-output={output.Directory}");
        // Either we return a non-zero exit code, or we throw an exception - we don't mind,
        // as we're just making sure there's a failure.
        try
        {
            var exitCode = command.Execute(options);
            Assert.NotEqual(0, exitCode);
        }
        catch
        {
            // No problem
        }
        // We shouldn't have uploaded anything.
        Assert.Empty(command.PublishedPackages);
        Assert.Empty(command.UploadedDocsBundles);
    }

    internal class FakeCommand : PublishLibraryCommand
    {
        public List<NuGetPackage> PublishedPackages { get; } = [];
        public List<DocumentationBundle> UploadedDocsBundles { get; } = [];

        internal override void PushPackage(NuGetPackage package) => PublishedPackages.Add(package);
        internal override void UploadDocumentation(DocumentationBundle bundle) => UploadedDocsBundles.Add(bundle);
    }
}
