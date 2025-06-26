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

using Google.Cloud.Storage.V1;
using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Publishes a (previously-packaged) library to NuGet, and pushes the documentation tgz files.
/// </summary>
public class PublishLibraryCommand : IContainerCommand
{
    internal const string NuGetApiKeyEnvPrefix = "NUGET_API_KEY_";
    internal const string DocsBucketEnvPrefix = "DOCS_BUCKET_";

    public int Execute(ContainerOptions options)
    {
        var packageOutput = options.RequireOption(options.PackageOutput);
        // Load everything first, so we've definitely got everything we need
        // before we actually publish anything.
        var nugetPackages = NuGetPackage.LoadPackages(packageOutput);
        var documentationBundles = DocumentationBundle.LoadBundles(packageOutput);

        nugetPackages.ForEach(PushPackage);
        documentationBundles.ForEach(UploadDocumentation);
        return 0;
    }

    private static string GetRequiredEnvironmentVariable(string name)
    {
        string value = Environment.GetEnvironmentVariable(name);
        if (string.IsNullOrEmpty(value))
        {
            throw new Exception($"Expected environment variable '{name}'");
        }
        return value;
    }

    // Virtual for testing purposes
    internal virtual void PushPackage(NuGetPackage package)
    {
        Console.WriteLine($"Pushing {Path.GetFileName(package.File)}.");
        Processes.RunDotnetWithSensitiveArgs(Environment.CurrentDirectory,
            "nuget",
            "push",
            "-s", "https://api.nuget.org/v3/index.json",
            "-k", package.ApiKey,
            "--skip-duplicate", // Allows us to rerun a release step.
            package.File);
        Console.WriteLine($"Pushed {Path.GetFileName(package.File)} successfully.");
    }

    // Virtual for testing purposes
    internal virtual void UploadDocumentation(DocumentationBundle bundle)
    {
        using var client = StorageClient.Create();
        using var bundleStream = File.OpenRead(bundle.File);
        Console.WriteLine($"Uploading {bundle.DestinationObject} to {bundle.Bucket}");
        var options = new UploadObjectOptions { IfGenerationMatch = 0 };
        try
        {
            client.UploadObject(bundle.Bucket, bundle.DestinationObject, null, bundleStream, options);
            Console.WriteLine($"Uploaded {bundle.DestinationObject} to {bundle.Bucket}");
        }
        catch (GoogleApiException e) when (e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
        {
            Console.WriteLine("Documentation bundle already exists. Continuing.");
        }
    }

    internal sealed record DocumentationBundle(string File, string DestinationObject, string Bucket)
    {
        internal static List<DocumentationBundle> LoadBundles(string packageOutput)
        {
            var bundles = Directory.GetFiles(packageOutput, "*.tar.gz");
            var list = new List<DocumentationBundle>();
            foreach (var bundle in bundles)
            {
                // We use the start of the name to determine which site this
                // bundle is to be uploaded to, and then replace that start with
                // "dotnet" to get the destination object name.
                var name = Path.GetFileName(bundle);
                var bits = name.Split('-');

                var site = bits[0]; // e.g. googleapisdev or devsite
                var siteUpper = site.ToUpperInvariant();
                var bucket = GetRequiredEnvironmentVariable(DocsBucketEnvPrefix + siteUpper);
                
                bits[0] = "dotnet";
                var destinationObject = string.Join("-", bits);

                // Apply a suitable prefix only for devsite, as we did in the (now obsolete)
                // uploaddocs.sh.
                if (site == "devsite")
                {
                    destinationObject = "docfx-" + destinationObject;
                }

                list.Add(new(bundle, destinationObject, bucket));
            }
            return list;
        }
    }

    internal sealed record NuGetPackage(string ApiKey, string File)
    {
        internal static List<NuGetPackage> LoadPackages(string packageOutput)
        {
            var packages = Directory.GetFiles(packageOutput, "*.nupkg");
            // If we don't have any packages, we don't need an owners file.
            if (packages.Length == 0)
            {
                return new List<NuGetPackage>();
            }
            var packageOwner = System.IO.File.ReadAllText(Path.Combine(packageOutput, PackageLibraryCommand.PackageOwnerFile));
            var apiKey = GetRequiredEnvironmentVariable(NuGetApiKeyEnvPrefix + packageOwner.ToUpperInvariant().Replace("-", "_"));
            return packages.Select(p => new NuGetPackage(apiKey, p)).ToList();
        }
    }
}
