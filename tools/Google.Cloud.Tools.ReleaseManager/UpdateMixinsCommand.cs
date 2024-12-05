// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Tools.Common;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public sealed class UpdateMixinsCommand : CommandBase
{
    public UpdateMixinsCommand()
        : base("update-mixins", "Updates the mixin dependencies for the specified package, regenerating projects if necessary", "id", "googleapis-committish")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string id = args[0];
        string committish = args[1];

        var catalog = ApiCatalog.Load();
        var api = catalog[id];

        var root = DirectoryLayout.DetermineRootDirectory();
        var apiIndex = ApiIndex.V1.Index.LoadFromGitHub(committish);

        var targetApiFromIndex = apiIndex.Apis.FirstOrDefault(api => api.DeriveCSharpNamespace() == id);
        if (targetApiFromIndex is null)
        {
            Console.WriteLine($"Package {id} is not in the API index. Assuming it has no mixins.");
            return 0;
        }

        bool updated = false;
        foreach (var mixin in targetApiFromIndex.GetMixinPackages().Except(new[] { id }))
        {
            if (!api.Dependencies.ContainsKey(mixin))
            {
                api.Dependencies[mixin] = catalog[mixin].Version;
                Console.WriteLine($"Added mixin {mixin}");
                updated = true;
            }
        }

        if (!updated)
        {
            Console.WriteLine("No new mixins detected");
            return 0;
        }

        api.Json["dependencies"] = new JObject(api.Dependencies.Select(pair => new JProperty(pair.Key, pair.Value)));
        var layout = DirectoryLayout.ForApi(api.Id);
        var apiNames = catalog.CreateIdHashSet();
        var nonSourceGenerator = new NonSourceGenerator(catalog);
        nonSourceGenerator.GenerateApiFiles(api);
        string formatted = catalog.FormatJson();
        File.WriteAllText(ApiCatalog.CatalogPath, formatted);
        Console.WriteLine("Updated apis.json and project files");
        return 0;
    }
}
