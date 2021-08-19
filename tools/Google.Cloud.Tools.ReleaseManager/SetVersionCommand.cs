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
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class SetVersionCommand : CommandBase
    {
        public SetVersionCommand()
            : base("set-version", "Set a version in apis.json and generate project files", "id", "new-version")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];
            string version = args[1];
            InternalExecute(id, version, rewriteReadme: true);
        }

        internal void InternalExecute(string id, string version, bool rewriteReadme)
        {
            var catalog = ApiCatalog.Load();
            var api = catalog[id];

            string oldVersion = api.Version;
            api.Version = version;
            if (api.StructuredVersion.Patch == 0)
            {
                GenerateProjectsCommand.UpdateDependencies(catalog, api);
            }
            var layout = DirectoryLayout.ForApi(id);
            var apiNames = catalog.CreateIdHashSet();
            GenerateProjectsCommand.GenerateMetadataFile(layout.SourceDirectory, api);
            GenerateProjectsCommand.GenerateProjects(layout.SourceDirectory, api, apiNames);
            if (rewriteReadme)
            {
                GenerateProjectsCommand.RewriteReadme(catalog);
            }

            // Update the parsed JObject associated with the ID, and write it back to apis.json.
            api.Json["version"] = version;
            string formatted = catalog.FormatJson();
            File.WriteAllText(ApiCatalog.CatalogPath, formatted);
            Console.WriteLine("Updated apis.json");
            Console.WriteLine();
            Console.WriteLine(new ApiVersionPair(id, oldVersion, version));
        }
    }
}
