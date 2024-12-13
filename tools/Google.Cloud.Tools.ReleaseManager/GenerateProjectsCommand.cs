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

using Google.Cloud.Tools.Common;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    public class GenerateProjectsCommand : CommandBase
    {
        public GenerateProjectsCommand() : base("generate-projects", "Generates project files, coverage files etc from the API catalog")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            var rootLayout = RootLayout.ForCurrentDirectory();
            var catalog = ApiCatalog.Load(rootLayout);
            ValidateApiCatalog(catalog);
            Console.WriteLine($"API catalog contains {catalog.Apis.Count} entries");
            // Now we know we can parse the API catalog, let's save it again, potentially reformatting.
            catalog.Save(rootLayout);

            var generator = NonSourceGenerator.ForInPlaceGeneration();
            foreach (var api in catalog.Apis)
            {
                generator.GenerateApiFiles(api);
            }
            generator.GenerateNonApiFiles();
            return 0;
        }

        /// <summary>
        /// Perform some basic validation of the API catalog. Current validation steps:
        /// - Check that all project dependencies (prod-only; test is fine) are within a package group
        /// </summary>
        private static void ValidateApiCatalog(ApiCatalog catalog)
        {
            foreach (var api in catalog.Apis)
            {
                // If we're not releasing anything, it's fine for this to use project dependencies.
                // This is typically the case when creating a pair of packages, one of which will be
                // general (e.g. X.Y.Type) and the other of which depends on it.
                if (api.Version.EndsWith("00"))
                {
                    continue;
                }
                var projectDependencies = api.Dependencies.Where(d => d.Value == NonSourceGenerator.ProjectVersionValue).Select(d => d.Key).ToList();
                if (projectDependencies.Count == 0)
                {
                    continue;
                }
                if (api.PackageGroup is null)
                {
                    throw new UserErrorException($"Package '{api.Id}' cannot have project dependencies as it is not in a package group");
                }
                var badDependencies = projectDependencies.Except(api.PackageGroup.PackageIds).ToList();
                if (badDependencies.Any())
                {
                    throw new UserErrorException($"Package '{api.Id}' has bad project dependencies (outside package group '{api.PackageGroup.Id}': '{string.Join("', '", badDependencies)}'");
                }
            }
        }
    }
}
