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

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Publishes a (previously-packaged) library to NuGet, and pushes the documentation tgz files.
/// </summary>
public sealed class PublishLibraryCommand : IContainerCommand
{
    private const string NuGetApiKeyEnvPrefix = "NUGET_API_KEY_";
    private const string DocsBucketEnvPrefix = "DOCS_BUCKET_";

    public int Execute(ContainerOptions options)
    {
        var packageOutput = options.RequireOption(options.PackageOutput);
        // Load everything first, so we've definitely got everything we need
        // before we actually publish anything.
        var nugetPackages = NuGetPackage.LoadPackages(packageOutput);
        var documentationBundles = DocumentationBundle.LoadBundles(packageOutput);

        nugetPackages.ForEach(pkg => pkg.Push());
        documentationBundles.ForEach(bundle => bundle.Upload());
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


    private sealed class DocumentationBundle
    {
        private readonly string _file;
        private readonly string _destinationObject;
        private readonly string _bucket;

        private DocumentationBundle(string file, string destinationObject, string bucket)
        {
            _file = file;
            _destinationObject = destinationObject;
            _bucket = bucket;
        }

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

                list.Add(new(bundle, destinationObject, bucket));
            }
            return list;
        }

        internal void Upload()
        {
            using var client = StorageClient.Create();
            using var bundleStream = File.OpenRead(_file);
            client.UploadObject(_bucket, _destinationObject, null, bundleStream);
            Console.WriteLine($"Uploaded {_destinationObject}");
        }
    }

    private sealed class NuGetPackage
    {
        private readonly string _apiKey;
        private readonly string _file;

        private NuGetPackage(string apiKey, string file)
        {
            _apiKey = apiKey;
            _file = file;
        }

        internal static List<NuGetPackage> LoadPackages(string packageOutput)
        {
            var packageOwner = File.ReadAllText(Path.Combine(packageOutput, PackageLibraryCommand.PackageOwnerFile));
            var packages  = Directory.GetFiles(packageOutput, "*.nupkg");
            var apiKey = GetRequiredEnvironmentVariable(NuGetApiKeyEnvPrefix + packageOwner.ToUpperInvariant().Replace("-", "_"));
            return packages.Select(p => new NuGetPackage(apiKey, p)).ToList();
        }

        internal void Push()
        {
            Console.WriteLine($"Pushing {Path.GetFileName(_file)}.");
            Processes.RunDotnetWithSensitiveArgs(Environment.CurrentDirectory,
                "nuget",
                "push",
                "-s", "https://api.nuget.org/v3/index.json",
                "-k", _apiKey,
                _file);
            Console.WriteLine($"Pushed {Path.GetFileName(_file)} successfully.");
        }
    }
}
