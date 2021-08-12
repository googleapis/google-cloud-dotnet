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
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    public sealed class BatchReleaseCommand : CommandBase
    {
        public BatchReleaseCommand()
            : base("batch-release", "Release multiple APIs", "config-file")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string configFile = args[0];
            var json = File.ReadAllText(configFile);
            var config = JsonConvert.DeserializeObject<BatchReleaseConfig>(json);

            var criteria = config.GetCriteria().ToList();
            if (criteria.Count != 1)
            {
                throw new UserErrorException("Batch release config must specify exactly one criterion.");
            }

            var catalog = ApiCatalog.Load();
            foreach (var api in catalog.Apis)
            {

            }
        }
    }

}
