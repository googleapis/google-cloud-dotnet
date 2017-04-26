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
using Newtonsoft.Json;
using NuGet.CatalogReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.DownloadDependencyInfo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required argument: output filename");
                Console.WriteLine("e.g. nuget-dependencies.json");
                return;
            }
            string outputFile = args[0];

            // The NuGet catalog reader only has async methods. That's a pain in a console
            // app :(
            Run(outputFile).Wait();
        }

        private static async Task Run(string outputFile)
        {
            var allDependencies = await LoadAllDependenciesAsync();
            using (var writer = File.CreateText(outputFile))
            {
                var serializer = JsonSerializer.CreateDefault();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, allDependencies);
            }
            Console.WriteLine($"Failures: {s_failureCount}");
        }

        private static async Task<List<PackageInfo>> LoadAllDependenciesAsync()
        {
            ServicePointManager.DefaultConnectionLimit = 64;
            var feed = new Uri("https://api.nuget.org/v3/index.json");
            
            using (var catalog = new CatalogReader(feed, TimeSpan.FromDays(1)))
            {
                Console.WriteLine("Loading latest package IDs");
                // The documentation lies: this retrieves all entries. Ignore pre-release,
                // and find the latest version for each package.
                var catalogEntries = (await catalog.GetFlattenedEntriesAsync())
                    .Where(p => !p.Version.IsPrerelease)
                    .Where(p => !p.IsDelete)
                    .GroupBy(p => p.Id)
                    // Spam... there must be a better way of detecting this. 
                    .Where(g => !g.Key.Contains("1-800") && !g.Key.ToLowerInvariant().Contains("-phone-") && !g.Key.ToLowerInvariant().Contains("-number-"))
                    .Select(g => g.OrderByDescending(p => p.Version).First())
                    .ToList();

                Console.WriteLine($"Loading dependencies for {catalogEntries.Count} packages");
                return catalogEntries
                    .AsParallel()
                    .WithDegreeOfParallelism(16)
                    .Select(GetPackageInfo)
                    .Where(p => p != null)
                    .ToList();
            }
        }

        private static int s_loadedPackageCount = 0;
        private static int s_failureCount = 0;
        private static PackageInfo GetPackageInfo(CatalogEntry entry)
        {
            try
            {
                // This is ugly. There must be something better. Not using Task.Run as we don't have any
                // synchronization context anyway.
                var nuspec = entry.GetNuspecAsync().Result;
                int loaded = Interlocked.Increment(ref s_loadedPackageCount);
                if (loaded % 100 == 0)
                {
                    Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss} Loaded dependencies for {loaded} packages.");
                }

                return new PackageInfo
                {
                    Id = entry.Id,
                    Version = entry.Version.ToString(),
                    Dependencies = nuspec.GetDependencyGroups()
                        .SelectMany(dg => dg.Packages)
                        .Select(d => d.Id)
                        .Distinct()
                        .ToList()
                };
            }
            catch
            {
                Console.WriteLine($"Failed to fetch dependencies for {entry.Id}");
                Interlocked.Increment(ref s_failureCount);
                return null;
            }
        }
    }
}
