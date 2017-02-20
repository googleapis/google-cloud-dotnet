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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.UpdateVersions
{
    public class Program
    {
        private static readonly Regex VersionPattern = new Regex(@"^([\d\.]+-)(alpha|beta)(\d+)-\*$");

        static void Main()
        {
            string root = DirectoryLayout.DetermineRootDirectory();

            var availableProjects = Directory.GetDirectories(Path.Combine(root, "apis"))
                .SelectMany(apiDir => Directory.GetDirectories(apiDir))
                .Where(projectDir => File.Exists(GetProjectFile(projectDir)))
                .Where(projectDir => CanUpdateVersion(projectDir));

            var projectsToUpdate = availableProjects.Where(PromptToUpdate).ToList();

            projectsToUpdate.ForEach(UpdateProjectVersion);

            File.WriteAllLines(
                Path.Combine(root, "tagselectedreleases.sh"),
                projectsToUpdate.Select(p => $"./tagrelease.sh {GetProjectName(p).Replace("/", " ")}"));

            File.WriteAllLines(
                Path.Combine(root, "pushselectedreleases.sh"),
                projectsToUpdate.Select(GetNugetPushLine));
        }

        /// <summary>
        /// Returns the project name in the form of dir/name, e.g. Google.Logging.V2/Google.Logging.Type
        /// </summary>
        private static string GetProjectName(string projectDir)
        {
            var dirInfo = new DirectoryInfo(projectDir);
            return $"{dirInfo.Parent.Name}/{dirInfo.Name}";
        }

        private static bool PromptToUpdate(string projectDir)
        {
            string name = GetProjectName(projectDir);
            Console.Write($"Update {name}? ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "y" || input == "Y")
                {
                    return true;
                }
                if (input == "n" || input == "N")
                {
                    return false;
                }
                Console.Write("Enter y or n");
            }
        }

        private static string GetProjectFile(string projectDir) => Path.Combine(projectDir, "project.json");

        private static bool CanUpdateVersion(string projectDir)
        {
            var json = File.ReadAllText(GetProjectFile(projectDir));
            var parsed = JObject.Parse(json);
            string version = (string) parsed["version"];
            if (version == null)
            {
                return false;
            }
            return VersionPattern.IsMatch(version);
        }

        private static void UpdateProjectVersion(string projectDir)
        {
            string projectFile = GetProjectFile(projectDir);
            var json = File.ReadAllText(projectFile);
            var parsed = JObject.Parse(json, new JsonLoadSettings { CommentHandling = CommentHandling.Load, LineInfoHandling = LineInfoHandling.Load });
            string version = (string) parsed["version"];
            var match = VersionPattern.Match(version);
            int number = int.Parse(match.Groups[3].Value);
            number++;
            string newVersion = $"{match.Groups[1]}{match.Groups[2]}{number:00}-*";

            // I don't know whether we can persuade JSON.NET to preserve formatting. It won't matter when
            // we're back in msbuild land.
            json = json.Replace($"\"version\": \"{version}\"", $"\"version\": \"{newVersion}\"");
            File.WriteAllText(projectFile, json);
        }

        private static string GetNugetPushLine(string projectDir)
        {
            var json = File.ReadAllText(GetProjectFile(projectDir));
            var parsed = JObject.Parse(json);
            string version = ((string) parsed["version"]).Replace("-*", "");
            string packageName = new DirectoryInfo(projectDir).Name;
            return $"nuget push -Source https://api.nuget.org/v3/index.json -ApiKey $api_key releasebuild/nuget/{packageName}.{version}.nupkg";
        }
    }
}
