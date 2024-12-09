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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Removes generated APIs from a repo clone. Expected options:
/// - repo-root: path to the root of the clone
/// - api-path: path to the API to clean generated files from, e.g. google/cloud/functions/v2
///   This is optional; when omitted, all configured APIs are cleaned.
/// </summary>
internal class CleanCommand : IContainerCommand
{
    public int Execute(Dictionary<string, string> options)
    {
        var repoRoot = options["repo-root"];
        var apiPath = options.GetValueOrDefault("api-path");

        var generatorInput = Path.Combine(repoRoot, DirectoryLayout.GeneratorInput);
        var catalog = ApiCatalog.LoadFromGeneratorInput(generatorInput);

        List<string> ids;
        if (apiPath is not null)
        {
            ids = new List<string>();
            var targetApi = catalog.Apis.SingleOrDefault(api => api.ProtoPath == apiPath);
            if (targetApi is null)
            {
                Console.WriteLine($"API path '{apiPath}' is not configured for any API. Ignoring.");
            }
            else
            {
                ids.Add(targetApi.Id);
            }
        }
        else
        {
            ids = catalog.Apis.Select(api => api.Id).OrderBy(id => id, StringComparer.Ordinal).ToList();
        }

        var nonSourceGenerator = new NonSourceGenerator(generatorInput, repoRoot);

        foreach (var id in ids)
        {
            Console.WriteLine($"Cleaning {id}");

            // GAPIC files and directories (except project files, which are removed by the non-source generator).
            var layout = DirectoryLayout.ForApi(id, repoRoot, generatorInput);
            // Source code
            DeleteAll(Directory.EnumerateFiles(layout.SourceDirectory, "*.g.cs", SearchOption.AllDirectories));
            // Snippet metadata
            var generatedSnippetsDirectory = Path.Combine(layout.SourceDirectory, $"{id}.GeneratedSnippets");
            if (Directory.Exists(generatedSnippetsDirectory))
            {
                DeleteAll(Directory.EnumerateFiles(generatedSnippetsDirectory, "*.json"));
            }
            // GAPIC metadata
            File.Delete(Path.Combine(layout.SourceDirectory, "gapic_metadata.json"));

            nonSourceGenerator.CleanApiFiles(id);
            PruneEmptyDirectories(layout.SourceDirectory);
        }
        Console.WriteLine($"Cleaning non-API-specific files");
        nonSourceGenerator.CleanNonApiFiles();
        return 0;
    }

    private static void DeleteAll(IEnumerable<string> files)
    {
        foreach (var file in files)
        {
            File.Delete(file);
        }
    }

    private static bool PruneEmptyDirectories(string directory)
    {
        bool allDirectoriesRemoved = true;
        // We go depth first, so it's easier to see what's left.
        foreach (var nested in Directory.GetDirectories(directory))
        {
            allDirectoriesRemoved &= PruneEmptyDirectories(nested);
        }
        var empty = allDirectoriesRemoved && Directory.GetFiles(directory).Length == 0;
        if (empty)
        {
            Directory.Delete(directory);
        }
        return empty;
    }
}
