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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ProjectGenerator
{
    public class Program
    {
        static void Main()
        {
            try
            {
                var root = DirectoryLayout.DetermineRootDirectory();

                var json = File.ReadAllText(Path.Combine(root, "apis", "apis.json"));
                var apis = JsonConvert.DeserializeObject<List<ApiMetadata>>(json);

                foreach (var api in apis)
                {
                    GenerateProjects(Path.Combine(root, "apis", api.Id), api);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed: {e}");
            }
        }

        static void GenerateProjects(string apiRoot, ApiMetadata api)
        {
            // We assume the source directories already exist, either because they've just
            // been generated or because they were already there. We infer the type of each
            // project based on the directory name. Expected suffixes:
            // - None: main API
            // - .Snippets: snippets (manual and generated)
            // - .Tests: unit tests
            // - .IntegrationTests: integration tests

            // Anything else will be ignored for now...
            Console.WriteLine($"Generating projects for {api.Id}");
            var projectDirectories = Directory.GetDirectories(apiRoot)
                .Where(pd => Path.GetFileName(pd).StartsWith(api.Id))
                .ToList();
            foreach (var dir in projectDirectories)
            {
                string suffix = Path.GetFileName(dir).Substring(api.Id.Length);
                switch (suffix)
                {
                    case "":
                        api.GenerateMainProject(dir);
                        break;
                    case ".IntegrationTests":
                    case ".Tests":
                    case ".Snippets":
                        api.GenerateTestProject(dir);
                        break;
                }
            }

            // TODO: Solution file
            // TODO: Updates for unknown project types? Tricky...
        }
    }
}
