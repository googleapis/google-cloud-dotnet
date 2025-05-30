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

        internal void Upload()
        {
            using var client = StorageClient.Create();
            using var bundleStream = File.OpenRead(_file);
            Console.WriteLine($"Uploading {_destinationObject} to {_bucket}");
            var options = new UploadObjectOptions { IfGenerationMatch = 0, timeout = TimeSpan.FromMinutes(5) };
            checkServiceAccount();
            try
            {
                client.UploadObject(_bucket, _destinationObject, null, bundleStream, options);
                Console.WriteLine($"Uploaded {_destinationObject} to {_bucket}");
            }
            catch (GoogleApiException e) when (e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
            {
                Console.WriteLine("Documentation bundle already exists. Continuing.");
            }
        }
        
        internal  async static void checkServiceAccount()
        {
            try
            {
                GoogleCredential credential = await GoogleCredential.GetApplicationDefaultAsync();

                if (credential.IsCreateScopedRequired)
                {
                    // This might happen if the initial credential doesn't have sufficient scopes,
                    // but the underlying credential source (e.g., service account) can be scoped.
                    // For direct service account email, this often isn't strictly necessary.
                    // However, it's good practice for general ADC usage.
                    credential = credential.CreateScoped("https://www.googleapis.com/auth/cloud-platform"); // Or a more specific scope
                }

                // Check if the credential is a service account credential
                if (credential.UnderlyingCredential is ServiceAccountCredential serviceAccountCredential)
                {
                    Console.WriteLine($"Application is authenticated as Service Account: {serviceAccountCredential.ClientEmail}");
                }

                else if (credential.UnderlyingCredential != null)
                {
                    Console.WriteLine($"Application is authenticated with an unknown credential type: {credential.UnderlyingCredential.GetType().Name}");
                }
                else
                {
                    Console.WriteLine("Could not determine credential type or no credentials found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine("This usually means no Application Default Credentials were found or configured.");
                Console.WriteLine("Ensure you've run 'gcloud auth application-default login' locally,");
                Console.WriteLine("or that a service account is attached to your Google Cloud instance.");
            }
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
            var packages = Directory.GetFiles(packageOutput, "*.nupkg");
            // If we don't have any packages, we don't need an owners file.
            if (packages.Length == 0)
            {
                return new List<NuGetPackage>();
            }
            var packageOwner = File.ReadAllText(Path.Combine(packageOutput, PackageLibraryCommand.PackageOwnerFile));
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
                "--skip-duplicate", // Allows us to rerun a release step.
                _file);
            Console.WriteLine($"Pushed {Path.GetFileName(_file)} successfully.");
        }
    }
}
