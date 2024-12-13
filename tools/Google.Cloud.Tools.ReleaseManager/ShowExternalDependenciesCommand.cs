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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

internal class ShowExternalDependenciesCommand : CommandBase
{
    public ShowExternalDependenciesCommand() : base("show-external-dependencies", "Shows all versions of external dependencies")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var catalog = ApiCatalog.Load(RootLayout);

        DisplayDependencies("Production", api => api.Dependencies);
        DisplayDependencies("Test", api => api.TestDependencies);

        void DisplayDependencies(string name, Func<ApiMetadata, SortedDictionary<string, string>> dependenciesSelector)
        {
            var dependencies = catalog.Apis.SelectMany(dependenciesSelector)
                .Where(pair => !catalog.TryGetApi(pair.Key, out _))
                .OrderBy(pair => pair.Key)
                .GroupBy(pair => pair.Key, pair => pair.Value);

            Console.WriteLine($"{name} dependencies:");
            foreach (var dependency in dependencies)
            {
                var package = dependency.Key;
                var versions = dependency.Distinct();
                Console.WriteLine($"{package}: {string.Join(",", versions)}");
            }
            Console.WriteLine();
        }
        return 0;
    }
}
