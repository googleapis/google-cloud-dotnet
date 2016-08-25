// Copyright 2016 Google Inc. All Rights Reserved.
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

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.GenerateDocfxSources
{
    /// <summary>
    /// A project within an API. Anything with a version number...
    /// </summary>
    public class Project
    {
        private readonly JObject _json;

        public string Name { get; }

        private Project(string name, JObject json)
        {
            Name = name;
            _json = json;
        }

        // TODO: Handle dependencies in framework elements
        // TODO: Return version numbers as well
        public IEnumerable<string> Dependencies => ((JObject)_json["dependencies"])?.Properties().Select(prop => prop.Name);

        public static IEnumerable<Project> LoadProjects(string directory)
        {
            foreach (string candidate in Directory.GetDirectories(directory, "Google.*"))
            {
                string projectJson = Path.Combine(candidate, "project.json");
                if (!File.Exists(projectJson))
                {
                    continue;
                }
                JObject json = JObject.Parse(File.ReadAllText(projectJson));
                if (json["version"] != null)
                {
                    yield return new Project(Path.GetFileName(candidate), json);
                }
            }
        }
    }
}
