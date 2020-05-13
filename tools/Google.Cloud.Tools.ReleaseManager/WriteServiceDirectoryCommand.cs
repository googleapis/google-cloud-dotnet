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
using LibGit2Sharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Temporary command to write out the "service directory", until we have a more centralized location.
    /// </summary>
    public class WriteServiceDirectoryCommand : CommandBase
    {
        public WriteServiceDirectoryCommand() : base("write-service-directory", "Writes out the service directory as a JSON file")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            var googleapisRoot = GetGoogleapisRoot();
            var serviceDirectory = ServiceDirectory.LoadFromGoogleapis(googleapisRoot);
            var outputDirectory = DirectoryLayout.ForApi("ServiceDirectory").SourceDirectory;

            string directoryJson = JsonConvert.SerializeObject(serviceDirectory, Formatting.Indented);
            File.WriteAllText(Path.Combine(outputDirectory, "directory.json"), directoryJson);

            var gitCommit = GetCommit(googleapisRoot);
            var synthMetadata = new
            {
                sources = new[] {
                    new {
                        git = new
                        {
                            name = "googleapis",
                            remote = "https://github.com/googleapis/googleapis.git",
                            sha = gitCommit
                        }
                    }
                }
            };
            var synthMetadataJson = JsonConvert.SerializeObject(synthMetadata, Formatting.Indented);
            File.WriteAllText(Path.Combine(outputDirectory, "synth.metadata"), synthMetadataJson);
        }

        private string GetCommit(string repoRoot)
        {
            using (var repo = new Repository(repoRoot))
            {
                return repo.Head.Tip.Sha;
            }
        }

        private string GetGoogleapisRoot()
        {
            if (Environment.GetEnvironmentVariable("SYNTHTOOL_PRECONFIG_FILE") is string preconfigFile && preconfigFile != "")
            {
                JObject preconfig = JObject.Parse(File.ReadAllText(preconfigFile));
                return (string) preconfig["preclonedRepos"]["https://github.com/googleapis/googleapis.git"];
            }
            if (Environment.GetEnvironmentVariable("SYNTHTOOL_GOOGLEAPIS") is string synthtoolGoogleapis && synthtoolGoogleapis != "")
            {
                return synthtoolGoogleapis;
            }
            var root = DirectoryLayout.DetermineRootDirectory();
            return Path.Combine(root, "googleapis");
        }
    }
}
