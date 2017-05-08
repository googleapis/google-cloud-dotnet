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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Google.Cloud.Tools.GenerateDocfxSources
{
    /// <summary>
    /// A project within an API. Anything with a version number...
    /// </summary>
    public class Project
    {
        private readonly XElement _project;

        public string Name { get; }

        private Project(string name, XElement project)
        {
            Name = name;
            _project = project;
        }

        // TODO: Handle dependencies in framework elements
        // TODO: Return version numbers as well
        public IEnumerable<string> Dependencies
        {
            get
            {
                // We mostly only care about the explicit dependencies, but we should include Gax when we depend on Gax.Rest or Gax.Grpc.
                var packageRefs = _project.Elements("ItemGroup").Elements("PackageReference").Select(x => (string) x.Attribute("Include"));
                var projectRefs = _project.Elements("ItemGroup").Elements("ProjectReference").Select(ExtractProjectReference);
                var dependencies = new HashSet<string>(packageRefs.Concat(projectRefs));
                if (dependencies.Contains("Google.Api.Gax.Rest") ||
                    dependencies.Contains("Google.Api.Gax.Grpc"))
                {
                    dependencies.Add("Google.Api.Gax");
                }
                // Likewise add protobuf and GRPC whenever we depend on Gax.Rrpc...
                // (It would be quite nice to do all this automatically...)
                if (dependencies.Contains("Google.Api.Gax.Grpc"))
                {
                    dependencies.Add("Google.Protobuf");
                    dependencies.Add("Google.Api.CommonProtos");
                    dependencies.Add("Grpc.Core");
                }
                return dependencies;
            }
        }

        private static string ExtractProjectReference(XElement element)
        {
            string project = (string)element.Attribute("Include");
            string lastPart = project.Split('\\', '/').Last();
            if (lastPart.EndsWith(".csproj"))
            {
                return lastPart.Substring(0, lastPart.Length - ".csproj".Length);
            }
            else
            {
                throw new Exception($"Unable to determine project reference from {project}");
            }
        }

        public static IEnumerable<Project> LoadProjects(string directory)
        {
            foreach (string candidate in Directory.GetDirectories(directory, "Google.*"))
            {
                var csproj = Directory.GetFiles(candidate, "*.csproj").FirstOrDefault();
                if (csproj == null)
                {
                    continue;
                }
                XElement project = XElement.Load(csproj);
                if (project.Descendants("Version").Any())
                {
                    yield return new Project(Path.GetFileName(candidate), project);
                }
            }
        }
    }
}
