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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.Tools.Common;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using SharpCompress.Archives;
using SharpCompress.Archives.Tar;
using SharpCompress.Common;
using SharpCompress.Writers.Tar;
using System;
using System.Data.Common;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Packages a library (which may contain a set of packages) ready for publication.
/// Note that all information required for later publication must be included here,
/// as we don't have repo context at publication time.
/// </summary>
internal class PackageLibraryCommand : IContainerCommand
{
    internal const string PackageOwnerFile = "package-owner.txt";

    public int Execute(ContainerOptions options)
    {
        var repoRoot = options.RequireOption(options.RepoRoot);
        using var _ = SourceLinkFixer.Create(repoRoot);

        var outputDirectory = options.RequireOption(options.Output);
        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);
        var apis = options.GetApisFromLibraryId(catalog);

        // We assume all the packages in the library are for the same owner.
        File.WriteAllText(Path.Combine(outputDirectory, PackageOwnerFile), apis.First().EffectivePackageOwner);

        foreach (var api in apis)
        {
            Console.WriteLine($"Packing {api.Id}");
            // Note that although we'll be in the same repo directory as the one used
            // for building and testing, we'll be in a new container, so the NuGet package
            // cache will be empty - so we restore as part of packing.
            Processes.RunDotnet(repoRoot, "pack",
                "-c", "Release",
                "-o", outputDirectory,
                $"apis/{api.Id}/{api.Id}");

            // Run from the container directory to use the tool configuration from there.
            Processes.RunDotnet("/app", "generate-sbom", Path.Combine(outputDirectory, $"{api.Id}.{api.Version}.nupkg"));
        }
        Console.WriteLine("Building documentation");
        Processes.RunBashScript(Path.Combine(repoRoot, "docs"), "builddocs.sh", apis.Select(api => api.Id));

        Console.WriteLine("Packaging documentation");
        foreach (var api in apis)
        {
            PackageDocumentation(rootLayout, api, outputDirectory);
        }
        return 0;
    }

    // This is the container equivalent of running uploaddocs.sh, but creating a tgz file instead of
    // directly pushing to GCS. The code for metadata and compression is taken from DocUploader, but we may be
    // able to retire that tool later.
    private static void PackageDocumentation(RootLayout rootLayout, ApiMetadata api, string outputDirectory)
    {
        var docsDir = rootLayout.CreateDocsLayout(api.Id).OutputDirectory;
        if (!Directory.Exists(docsDir))
        {
            return;
        }
        // Note: a comment in uploaddocs.sh claims we don't generate documentation for all packages.
        // I believe this is no longer true.
        var siteDir = Path.Combine(docsDir, "site");
        if (Directory.Exists(siteDir))
        {
            FixDocfxOutput(siteDir, api);
        }

        var devSiteDir = Path.Combine(docsDir, "devsite");

        BundleDocumentation(siteDir, api, outputDirectory, "googleapisdev");
        if (Directory.Exists(devSiteDir))
        {
            BundleDocumentation(devSiteDir, api, outputDirectory, "devsite");
        }
    }

    private static void FixDocfxOutput(string directory, ApiMetadata api)
    {
        // Remove the "All APIs" link from the toc if it exists.
        var tocFile = Path.Combine(directory, "toc.html");
        var tocLines = File.ReadLines(tocFile).ToList();
        var allApisMatch = tocLines
            .Select((line, index) => (line, index))
            .FirstOrDefault(pair => pair.line.Contains("All APIs"));
        if (allApisMatch.line is not null)
        {
            // Remove 3 lines: the list item start, link, list item end
            tocLines.RemoveRange(allApisMatch.index - 1, 3);
            File.WriteAllLines(tocFile, tocLines);
        }

        // Insert a baseUrl at the start of xrefmap.yml
        var xrefmapFile = Path.Combine(directory, "xrefmap.yml");
        var xrefmapLines = File.ReadLines(xrefmapFile).ToList();
        if (xrefmapLines[0].StartsWith("baseUrl"))
        {
            xrefmapLines.Insert(0, $"baseUrl: https://googleapis.dev/dotnet/{api.Id}/{api.Version}/");
            File.WriteAllLines(xrefmapFile, xrefmapLines);
        }
    }

    private static void BundleDocumentation(string inputDirectory, ApiMetadata api, string outputDirectory, string outputPrefix)
    {
        var metadata = new Metadata
        {
            UpdateTime = Timestamp.FromDateTimeOffset(DateTimeOffset.UtcNow).ToString().Trim('\"'),
            Name = api.Id,
            Version = api.Version,
            Language = "dotnet",
            GithubRepository = Environment.GetEnvironmentVariable("DOCS_METADATA_REPO") ?? ""
        };
        // The output prefix will be used later on to work out which bucket to write to.
        // The output prefix will be replaced (on upload) by "dotnet" to create the appropriate file for processing.
        var json = JsonConvert.SerializeObject(metadata, Formatting.Indented);
        File.WriteAllText("docs.metadata.json", json);
        using var tgz = File.Create(Path.Combine(outputDirectory, $"{outputPrefix}-{api.Id}-{api.Version}.tar.gz"));
        CompressDirectory(inputDirectory, tgz);
    }

    /// <summary>
    /// Compress the given directory to the output stream.
    /// </summary>
    private static void CompressDirectory(string directory, Stream output)
    {
        if (Directory.EnumerateFiles(directory).Count() == 0)
        {
            throw new InvalidOperationException($"The documentation path `{directory}` is empty");
        }

        using var archive = TarArchive.Create();
        archive.AddAllFromDirectory(directory);
        var writerOptions = new TarWriterOptions(CompressionType.GZip, finalizeArchiveOnClose: true);
        archive.SaveTo(output, writerOptions);
    }

    private class Metadata
    {
        [JsonProperty("updateTime")]
        public string UpdateTime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("githubRepository")]
        public string GithubRepository { get; set; }
    }
}
