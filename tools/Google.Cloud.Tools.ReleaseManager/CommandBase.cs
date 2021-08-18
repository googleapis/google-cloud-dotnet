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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Base class for commands, providing rudimentary validation and common command code.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        // The branch we're thinking of as primary (e.g. master). It may actually be some other branch for occasional
        // releases, but fundamentally it's "the current source of truth we're basing this release on".
        internal const string PrimaryBranch = "master";

        private readonly int _expectedArgCount;

        public string Description { get; }

        public string Command { get; }

        public string ExpectedArguments { get; }


        protected CommandBase(string command, string description, params string[] argNames)
        {
            Command = command;
            Description = description;
            _expectedArgCount = argNames.Length;
            ExpectedArguments = string.Join(" ", argNames.Select(arg => $"<{arg}>"));
        }

        public void Execute(string[] args)
        {
            if (args.Length != _expectedArgCount)
            {
                throw new UserErrorException(_expectedArgCount == 0
                    ? $"{Command} does not accept additional arguments"
                    : $"{Command} expected arguments: {ExpectedArguments}");
            }
            ExecuteImpl(args);
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="args">The command line arguments other than the command name.
        /// This will have been validated to have the expected number of arguments.</param>
        protected abstract void ExecuteImpl(string[] args);

        protected List<ApiVersionPair> FindChangedVersions()
        {
            var currentCatalog = ApiCatalog.Load();
            var primaryCatalog = LoadPrimaryCatalog();
            var currentVersions = currentCatalog.CreateRawVersionMap();
            var primaryVersions = primaryCatalog.CreateRawVersionMap();
            return currentVersions.Keys.Concat(primaryVersions.Keys)
                .Distinct()
                .OrderBy(id => id)
                .Select(id => new ApiVersionPair(id, primaryVersions.GetValueOrDefault(id), currentVersions.GetValueOrDefault(id)))
                .Where(v => v.NewVersion != v.OldVersion)
                .ToList();
        }

        protected ApiCatalog LoadPrimaryCatalog()
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                var primary = repo.Branches.FirstOrDefault(b => b.FriendlyName == PrimaryBranch);
                if (primary == null)
                {
                    throw new UserErrorException($"Unable to find branch '{PrimaryBranch}'.");
                }

                var primaryCatalogJson = primary.Commits.First()["apis/apis.json"].Target.Peel<Blob>().GetContentText();
                return ApiCatalog.FromJson(primaryCatalogJson);
            }
        }
    }
}
