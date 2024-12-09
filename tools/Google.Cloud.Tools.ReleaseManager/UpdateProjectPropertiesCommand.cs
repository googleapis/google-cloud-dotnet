// Copyright 2024 Google LLC
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

using Google.Cloud.Tools.Common;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

// TODO: Create a GitHub action to run this and check it doesn't make any changes.

public sealed class UpdateProjectPropertiesCommand : CommandBase
{
    public UpdateProjectPropertiesCommand()
    : base("update-project-properties", "Updates the 'projects' property in the API catalog based on file/directory presence")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var catalog = ApiCatalog.Load();

        foreach (var api in catalog.Apis)
        {
            var catalogProjects = api.DeriveProjects().OrderBy(x => x, StringComparer.Ordinal).ToList();
            var fileSystemProjects = InferProjectsFromFileSystem(api).OrderBy(x => x, StringComparer.Ordinal).ToList();
            if (catalogProjects.SequenceEqual(fileSystemProjects))
            {
                continue;
            }

            Console.WriteLine($"{api.Id}:");
            Console.WriteLine($"  API catalog: {string.Join(", ", catalogProjects)}");
            Console.WriteLine($"  File system: {string.Join(", ", fileSystemProjects)}");
            Console.WriteLine();

            // Work out what it should be...
            api.Projects = null;
            string prefix = api.Id + ".";
            var explicitProjects = fileSystemProjects.Except(api.DeriveProjects()).ToList();
            if (explicitProjects.Count == 0)
            {
                api.Json.Remove("projects");
            }
            else
            {
                var array = explicitProjects.Select(p => p.StartsWith(prefix, StringComparison.Ordinal) ? p[prefix.Length..] : "^" + p);
                api.Json["projects"] = new JArray(array);
            }
        }
        string formatted = catalog.FormatJson();
        File.WriteAllText(ApiCatalog.CatalogPath, formatted);
        return 0;
    }

    private static IEnumerable<string> InferProjectsFromFileSystem(ApiMetadata api)
    {
        // We infer that a directory is a project if it either has .csproj files or .cs files.
        // (This is to handle Google.Cloud.DevTools.Common, and any similar situations we may find later.)
        var apiRoot = DirectoryLayout.ForApi(api.Id).SourceDirectory;
        return Directory.GetDirectories(apiRoot)
                .Where(pd => Directory.EnumerateFiles(pd, "*.cs").Any() || Directory.EnumerateFiles(pd, "*.csproj").Any())
                .Select(Path.GetFileName);
    }
}
