// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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
using System;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Shows the packages in the catalog in different levels, with everything in
/// each level being simultaneously-releasable, so long as the earlier levels have been released.
/// Groups are displayed at the end, unordered.
/// </summary>
internal class ShowDependencyLevelsCommand : CommandBase
{
    public ShowDependencyLevelsCommand() : base("show-dependency-levels", "Shows the levels of different dependencies, to aid release ordering")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var catalog = ApiCatalog.Load(RootLayout);

        var dependenciesOnGroups = catalog.Apis
            .Where(api => api.PackageGroup is null)
            .Where(api => api.Dependencies.Keys.Any(dep => catalog.TryGetApi(dep, out var depApi) && depApi.PackageGroup is not null))
            .ToList();

        // Map from the package ID to the (in-catalog) IDs it depends on, excluding grouped APIs and those depending on groups.
        var apiToDependencies = catalog.Apis
            .Where(api => api.PackageGroup is null)
            .Except(dependenciesOnGroups)
            .ToDictionary(
                api => api.Id,
                api => api.Dependencies.Keys.Where(dep => catalog.TryGetApi(dep, out var depApi) && depApi.PackageGroup is null).ToHashSet());

        int level = 0;
        while (apiToDependencies.Any())
        {
            var next = apiToDependencies.Where(mapping => mapping.Value.Count == 0)
                .Select(mapping => mapping.Key)
                .OrderBy(x => x, StringComparer.Ordinal)
                .ToList();
            if (next.Count == 0)
            {
                Console.WriteLine($"ERROR: {apiToDependencies.Count} dependencies still to resolve, but nothing left with no dependencies:");
                Console.WriteLine(string.Join(", ", apiToDependencies.Keys));
                return 0;
            }

            Console.WriteLine($"Level {level}:");
            foreach (var id in next)
            {
                Console.WriteLine($"  {id}");
            }
            Console.WriteLine();

            // Remove everything in the lowest level from the map, and remove each item
            // from the dependency list too.
            foreach (var id in next)
            {
                apiToDependencies.Remove(id);
                foreach (var mapping in apiToDependencies)
                {
                    mapping.Value.Remove(id);
                }
            }
            level++;
        }

        Console.WriteLine();
        Console.WriteLine("Grouped APIs:");
        foreach (var group in catalog.PackageGroups)
        {
            Console.WriteLine($"  {group.Id}:");
            foreach (var id in group.PackageIds)
            {
                Console.WriteLine($"    {id}:");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("APIs with dependencies on groups:");
        foreach (var api in dependenciesOnGroups)
        {
            Console.WriteLine($"  {api.Id}");
        }
        return 0;
    }
}
