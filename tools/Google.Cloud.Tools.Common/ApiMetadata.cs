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

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.Common
{
    public class ApiMetadata
    {
        private static readonly Regex PrereleaseApiPattern = new Regex(@"^V[1-9]\d*[^\d]+.*$");

        private static readonly Regex ReleaseVersion = new Regex(@"^[1-9]\d*\.\d+\.\d+$");

        public string Version { get; set; }
        public string Id { get; set; }
        public ApiType Type { get; set; }
        public string TargetFrameworks { get; set; }
        public string TestTargetFrameworks { get; set; }

        /// <summary>
        /// API name to include in documentation, e.g. "Google Monitoring"
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// API URL to include in documentation, e.g. "https://cloud.google.com/monitoring/api/v3/"
        /// </summary>
        public string ProductUrl { get; set; }

        public string Description { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
        public Dictionary<string, string> Dependencies { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> TestDependencies { get; set; } = new Dictionary<string, string>();
        public List<string> MetaApis { get; set; } // TODO: enum?
        
        /// <summary>
        /// The type of generator used to generate source code for this API.
        /// </summary>
        public GeneratorType Generator { get; set;  }
        
        /// <summary>
        /// The path within googleapis for the API protos.
        /// </summary>
        public string ProtoPath { get; set; }
        
        /// <summary>
        /// The path in the directory above <see cref="ProtoPath"/> for the service YAML.
        /// (Only appropriate for GAPIC generated APIs.)
        /// </summary>
        public string ServiceYaml { get; set; }

        public bool IsReleaseVersion => ReleaseVersion.IsMatch(Version);

        public StructuredVersion StructuredVersion => new StructuredVersion(Version);

        /// <summary>
        /// The release level to record in .repo-metadata.json, if this differs from the one
        /// inferred from the JSON. (For example, we will have 2.0.0-alpha00 versions that didn't
        /// have a 1.0.0.)
        /// </summary>
        public string ReleaseLevelOverride { get; set; }

        // TODO: Optimize to do this lazily if it's ever an issue
        public bool CanHaveGaRelease
        {
            get
            {
                string[] parts = Id.Split('.');
                // Three possibilities:
                // - GA API, e.g. Google.Cloud.Spanner.V1
                // - Prerelease API, e.g. Google.Cloud.Spanner.V1Beta1 or Google.Cloud.Spanner.V1P1Beta1
                // - Non-API, e.g. Google.Cloud.Spanner.Data
                // We can create GA packages for the first and the last.
                return !PrereleaseApiPattern.IsMatch(parts.Last());
            }
        }

        public static List<ApiMetadata> LoadApis()
        {
            var root = DirectoryLayout.DetermineRootDirectory();

            var json = File.ReadAllText(Path.Combine(root, "apis", "apis.json"));
            return JsonConvert.DeserializeObject<List<ApiMetadata>>(json);
        }
    }
}
