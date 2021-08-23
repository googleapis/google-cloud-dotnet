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
using System;
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class UpdateDependenciesCommand : CommandBase
    {
        public UpdateDependenciesCommand()
            : base("update-dependencies", "Updates dependencies for all APIs")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            var catalog = ApiCatalog.Load();
            var apiNames = catalog.CreateIdHashSet();

            foreach (var api in catalog.Apis)
            {
                GenerateProjectsCommand.UpdateDependencies(catalog, api);
                var layout = DirectoryLayout.ForApi(api.Id);
                GenerateProjectsCommand.GenerateMetadataFile(layout.SourceDirectory, api);
                GenerateProjectsCommand.GenerateProjects(layout.SourceDirectory, api, apiNames);
            }
            string formatted = catalog.FormatJson();
            File.WriteAllText(ApiCatalog.CatalogPath, formatted);
            Console.WriteLine("Updated apis.json");
        }
    }
}
