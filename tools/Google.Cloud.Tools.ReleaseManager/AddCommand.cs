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
using System;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Tool to add a new library based on the service config (and protos) for an API.
    /// </summary>
    public class AddCommand : ICommand
    {
        private const string NoPullArgument = "--no-pull";
        public string Description => "Adds an API to the API catalog";

        public string Command => "add";

        public string ExpectedArguments => $"<id> [{NoPullArgument}]";

        public int Execute(string[] args)
        {
            if (args.Length == 0 || args.Length > 2 || (args.Length == 2 && args[1] != NoPullArgument))
            {
                throw new UserErrorException($"{Command} expected arguments: {ExpectedArguments}");
            }
            string id = args[0];
            bool pull = args.Length == 1; // We've already validated that if we've got 2 arguments, the second is NoPullArgument...

            var rootLayout = RootLayout.ForCurrentDirectory();
            var catalog = ApiCatalog.Load(rootLayout);
            if (catalog.Apis.Any(api => api.Id == id))
            {
                throw new UserErrorException($"API {id} already exists in the API catalog.");
            }
            var googleapis = rootLayout.Googleapis;

            if (pull)
            {
                Console.WriteLine($"Pulling googleapis directory");
                using var repo = new Repository(googleapis);
                string oldSha = repo.Head.Tip.Sha;

                // The "merger" signature will never be used, due to requiring fast-forward-only,
                // but we have to specify something.
                var merger = new Signature("Ignored", "ignored@google.com", DateTimeOffset.UtcNow);
                var pullOptions = new PullOptions
                {
                    MergeOptions = new MergeOptions { FastForwardStrategy = FastForwardStrategy.FastForwardOnly, FailOnConflict = true }
                };
                Commands.Pull(repo, merger, pullOptions);
                string newSha = repo.Head.Tip.Sha;
                Console.WriteLine(oldSha == newSha ? "Pull did not make changes" : $"Pull moved from {oldSha} to {newSha}");
            }

            var apiIndex = ApiIndex.V1.Index.LoadFromGoogleApis(googleapis);

            var targetApi = apiIndex.Apis.FirstOrDefault(api => api.DeriveCSharpNamespace() == id);
            if (targetApi is null)
            {
                var lowerWithoutCloud = id.Replace(".Cloud", "").ToLowerInvariant();
                var possibilities = apiIndex.Apis
                    .Select(api => api.DeriveCSharpNamespace())
                    .Where(ns => ns.Replace(".Cloud", "").ToLowerInvariant() == lowerWithoutCloud);
                throw new UserErrorException(
                    $"No service found for '{id}'.{Environment.NewLine}Similar possibilities (check options?): {string.Join(", ", possibilities)}");
            }

            var api = ApiAnalyzer.ConfigureApi(googleapis, catalog, targetApi);
            catalog.Add(api);

            // Done. Let's write out the catalog and display what we've done.
            catalog.Save(rootLayout);
            Console.WriteLine($"Added {id} to the API catalog with the following configuration:");
            Console.WriteLine(api.Json.ToString(Formatting.Indented));
            return 0;
        }
    }
}
