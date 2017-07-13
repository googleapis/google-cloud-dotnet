// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Octokit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Google.Cloud.Tools.Common;

namespace Google.Cloud.Tools.TagReleases
{
    /// <summary>
    /// Tool to tag releases on GitHub for any projects where there's no existing tag
    /// with the currently-specified version.
    /// </summary>
    internal class Program
    {
        private const string RepositoryOwner = "GoogleCloudPlatform";
        private const string RepositoryName = "google-cloud-dotnet";
        private const string ApplicationName = "google-cloud-dotnet-tagreleases";

        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Arguments: <github access token>");
                return 1;
            }
            try
            {
                MainAsync(args).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 1;
            }
            return 0;
        }

        private static async Task MainAsync(string[] args)
        {
            var client = new GitHubClient(new ProductHeaderValue(ApplicationName))
            {
                Credentials = new Credentials(args[0])
            };
            var tags = (await client.Repository.GetAllTags(RepositoryOwner, RepositoryName)).Select(tag => tag.Name);

            var apis = ApiMetadata.LoadApis();
            var noChange = apis.Where(api => tags.Contains($"{api.Id}-{api.Version}") || api.Version.EndsWith("00")).ToList();
            var changed = apis.Except(noChange).ToList();

            Console.WriteLine("APIs already tagged at current version (or not ready for release):");
            noChange.ForEach(api => Console.WriteLine($"{api.Id,-50} v{api.Version}"));
            Console.WriteLine();
            Console.WriteLine("APIs requiring a new release:");
            changed.ForEach(api => Console.WriteLine($"{api.Id,-50} v{api.Version}"));

            Console.WriteLine();

            if (!changed.Any())
            {
                Console.WriteLine("No releases need to be created. Exiting.");
                return;
            }

            Console.WriteLine("Go ahead and create releases? (y/n)");
            string response = Console.ReadLine();
            bool createReleases = response == "y";
            if (!createReleases)
            {
                return;
            }
            foreach (var api in changed)
            {
                // We could parallelize, but there's very little point.
                await client.Repository.Release.Create(RepositoryOwner, RepositoryName, CreateNewRelease(api));
                Console.WriteLine($"Created release for {api.Id}");
            }
        }

        private static List<ApiMetadata> LoadApis()
        {
            var root = DirectoryLayout.DetermineRootDirectory();

            var json = File.ReadAllText(Path.Combine(root, "apis", "apis.json"));
            return JsonConvert.DeserializeObject<List<ApiMetadata>>(json).OrderBy(api => api.Id).ToList();
        }

        private static NewRelease CreateNewRelease(ApiMetadata api) => new NewRelease($"{api.Id}-{api.Version}")
        {
            Prerelease = !api.IsReleaseVersion,
            Name = $"{api.Version} release of {api.Id}",
            // Default TargetCommitish is master, which is fine for now.
        };
    }
}