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
using System;
using System.Linq;
using System.Threading;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Base class for commands, providing rudimentary validation and common command code.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        // The branch we're thinking of as primary (e.g. main). It may actually be some other branch for occasional
        // releases, but fundamentally it's "the current source of truth we're basing this release on".
        internal const string PrimaryBranch = "main";

        // This is lazy so that we can construct instances of CommandBase even when the current directory isn't
        // in a repo, but we don't go hunting for the root multiple times.
        private readonly Lazy<RootLayout> _lazyLayout = new(RootLayout.ForCurrentDirectory, LazyThreadSafetyMode.ExecutionAndPublication);

        private readonly int _minArgs;
        private readonly int _maxArgs;

        public string Description { get; }

        public string Command { get; }

        public string ExpectedArguments { get; }

        /// <summary>
        /// The RootLayout to use during the execution of this command.
        /// </summary>
        /// <remarks>
        /// Currently this is always derived from the current directory, but we may later have a way of specifying it separately.
        /// </remarks>
        protected RootLayout RootLayout => _lazyLayout.Value;

        protected CommandBase(string command, string description, int minArgs, int maxArgs, string expectedArguments)
        {
            Command = command;
            Description = description;
            _minArgs = minArgs;
            _maxArgs = maxArgs;
            ExpectedArguments = expectedArguments;
        }

        protected CommandBase(string command, string description, params string[] argNames)
            : this(command, description, argNames.Length, argNames.Length, string.Join(" ", argNames.Select(arg => $"<{arg}>")))
        {
        }

        public int Execute(string[] args)
        {
            if (args.Length < _minArgs || args.Length > _maxArgs)
            {
                throw new UserErrorException(_maxArgs == 0
                    ? $"{Command} does not accept additional arguments"
                    : $"{Command} expected arguments: {ExpectedArguments}");
            }
            return ExecuteImpl(args);
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="args">The command line arguments other than the command name.
        /// This will have been validated to have the expected number of arguments.</param>
        protected abstract int ExecuteImpl(string[] args);

        protected ApiCatalog LoadPrimaryCatalog()
        {
            using var repo = new Repository(RootLayout.RepositoryRoot);

            var primary = repo.Branches.FirstOrDefault(b => b.FriendlyName == PrimaryBranch);
            if (primary == null)
            {
                throw new UserErrorException($"Unable to find branch '{PrimaryBranch}'.");
            }

            var primaryCatalogJson = primary.Commits.First()[ApiCatalog.PathInRepository].Target.Peel<Blob>().GetContentText();
            return ApiCatalog.FromJson(primaryCatalogJson);
        }
    }
}
