// Copyright 2021 Google LLC
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
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public sealed class UpdateDependenciesCommand : CommandBase
{
    public UpdateDependenciesCommand()
        : base("update-dependencies", "Updates dependencies for all APIs")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var nonSourceGenerator = new NonSourceGenerator(RootLayout);
        var catalog = nonSourceGenerator.ApiCatalog;
        var apiNames = catalog.CreateIdHashSet();

        foreach (var api in catalog.Apis)
        {
            UpdateDependencies(catalog, api);
            nonSourceGenerator.GenerateApiFiles(api);
        }
        nonSourceGenerator.GenerateNonApiFiles();
        catalog.Save(nonSourceGenerator.RootLayout);
        return 0;
    }

    /// <summary>
    /// Updates the dependencies in an API for other packages within this repository.
    /// </summary>
    private static void UpdateDependencies(ApiCatalog catalog, ApiMetadata api)
    {
        bool stableOnly = api.StructuredVersion.IsStable;
        UpdateDependencyDictionary(api.Dependencies, "dependencies");
        UpdateDependencyDictionary(api.TestDependencies, "testDependencies");

        void UpdateDependencyDictionary(SortedDictionary<string, string> dependencies, string jsonName)
        {
            if (dependencies.Count == 0)
            {
                return;
            }

            // We want to update any dependencies to "internal" packages such as Google.LongRunning.
            Dictionary<string, string> allInternalPackageVersions =
                catalog.Apis
                    .Select(api => new KeyValuePair<string, string>(api.Id, api.Version))
                    .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var package in dependencies.Keys.ToList())
            {
                if (allInternalPackageVersions.TryGetValue(package, out var latestVersion))
                {
                    var currentDependencyVersion = dependencies[package];
                    if (currentDependencyVersion == NonSourceGenerator.DefaultVersionValue ||
                        currentDependencyVersion == NonSourceGenerator.ProjectVersionValue ||
                        latestVersion == currentDependencyVersion)
                    {
                        continue;
                    }
                    var structuredDefaultVersion = StructuredVersion.FromString(latestVersion);
                    var structuredCurrentVersion = StructuredVersion.FromString(currentDependencyVersion);
                    if (structuredDefaultVersion.CompareTo(structuredCurrentVersion) > 0 &&
                        structuredDefaultVersion.Major == structuredCurrentVersion.Major &&
                        (structuredDefaultVersion.IsStable || !stableOnly))
                    {
                        dependencies[package] = latestVersion;
                    }
                }
            }

            if (api.Json is object)
            {
                api.Json[jsonName] = new JObject(dependencies.Select(pair => new JProperty(pair.Key, pair.Value)));
            }
        }
    }
}
