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
using LibGit2Sharp;
using Newtonsoft.Json;
using System;
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

        protected override int ExecuteImpl(string[] args)
        {
            string configFile = args[0];
            var rootLayout = RootLayout.ForCurrentDirectory();
            var json = File.ReadAllText(configFile);
            var config = JsonConvert.DeserializeObject<BatchReleaseConfig>(json);

            var criteria = config.GetCriteria().ToList();
            if (criteria.Count != 1)
            {
                throw new UserErrorException("Batch release config must specify exactly one criterion.");
            }

            if (!config.DryRun)
            {
                using var repo = new Repository(rootLayout.RepositoryRoot);

                if (repo.RetrieveStatus().IsDirty)
                {
                    throw new UserErrorException("In non-dry-run mode, the current branch must not have changes.");
                }
            }

            var catalog = ApiCatalog.Load(rootLayout);
            var criterion = criteria[0];
            Func<string, StructuredVersion, StructuredVersion> versionIncrementer =
                config.PostMajorVersion
                ? (id, sv) => sv.AfterMajorVersion(id)
                : (id, sv) => sv.AfterIncrement();
            string defaultMessage = config.DefaultHistoryMessageFile is null ? null : File.ReadAllText(config.DefaultHistoryMessageFile);

            var lastLog = DateTime.UtcNow;
            var proposals = criterion.GetProposals(catalog, versionIncrementer, defaultMessage, MaybeLogProgress);

            if (config.CollectProposalsEagerly)
            {
                Console.WriteLine("Collecting proposals eagerly. Will periodically report progress.");
                proposals = proposals.ToList();
            }

            foreach (var proposal in proposals)
            {
                // Note: This takes into account the dry-run flag.
                proposal.Execute(config);
            }

            if (config.DeferPush && proposals.Any(p => p.Completed))
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("* Don't forget to push the release branches with the push-releases command. *");
                Console.WriteLine("*****************************************************************************");
            }
            return 0;

            void MaybeLogProgress(int progress, int total)
            {
                if (!config.CollectProposalsEagerly)
                {
                    return;
                }
                var now = DateTime.UtcNow;
                if ((now - lastLog).TotalMinutes >= 1)
                {
                    Console.WriteLine($"{now:HH:mm:ss}Z: Evaluating API {progress} out of {total}");
                    lastLog = now;
                }
            }
        }
    }
}
