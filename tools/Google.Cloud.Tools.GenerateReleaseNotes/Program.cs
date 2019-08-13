// Copyright 2018 Google Inc. All Rights Reserved.
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
using LibGit2Sharp;
using System;
using System.Linq;

namespace Google.Cloud.Tools.GenerateReleaseNotes
{
    /// <summary>
    /// Tool to generate the first pass at release notes for an API. These then need to be
    /// examined by a human to turn them into *real* release notes.
    /// </summary>
    class Program
    {
        private const string IncludeProjectChangesOption = "--include-project-changes";
        private const string IncludeNonProductionChangesOption = "--include-non-production-changes";
        private static readonly string[] ProjectFileSuffixes = { ".csproj", ".sln", "project.json", ".xproj" };

        static int Main(string[] args)
        {
            bool includeProjectChanges = args.Contains(IncludeProjectChangesOption);
            bool includeNonProductionChanges = args.Contains(IncludeNonProductionChangesOption);
            var otherArgs = args.Except(new[] { IncludeProjectChangesOption, IncludeNonProductionChangesOption } ).ToArray();
            if (otherArgs.Length != 1)
            {
                Console.WriteLine($"Arguments: [{IncludeProjectChangesOption}] [{IncludeNonProductionChangesOption}] <api>");
                return 1;
            }
            string api = otherArgs[0];
            try
            {
                GenerateNotes(api, CreatePathFilter(api, includeProjectChanges, includeNonProductionChanges));
                return 0;
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Configuration error: {e.Message}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 1;
            }
        }

        static Func<string, bool> CreatePathFilter(string api, bool includeProjectChanges, bool includeNonProductionChanges)
        {
            var prefix = includeNonProductionChanges ? $"apis/{api}/" : $"apis/{api}/{api}/";
            return path =>
            {
                // Some versions return forward slashes, some return backslashes :(
                path = path.Replace('\\', '/');
                return path.StartsWith(prefix) && (includeProjectChanges || !ProjectFileSuffixes.Any(path.EndsWith));
            };
        }

        static void GenerateNotes(string api, Func<string, bool> pathFilter)
        {
            var apiDirectory = $"apis\\{api}\\";
            var tagPrefix = $"{api}-";

            Console.WriteLine($"Changes for {api}");

            var root = DirectoryLayout.DetermineRootDirectory();
            using (var repo = new Repository(root))
            {
                var diff = repo.Diff;
                var apiTags = repo.Tags
                    .Where(tag => tag.FriendlyName.StartsWith(tagPrefix))
                    .ToList();
                var idToTagName = apiTags.ToDictionary(tag => tag.Target.Id, tag => tag.FriendlyName.Substring(tagPrefix.Length));

                foreach (var commit in repo.Branches["master"].Commits)
                {
                    if (idToTagName.TryGetValue(commit.Id, out string version))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Release: {version}");
                        Console.WriteLine($"---------{new string('-', version.Length)}");
                    }
                    if (CommitContainsApi(diff, commit, pathFilter))
                    {
                        Console.WriteLine($"https://github.com/googleapis/google-cloud-dotnet/commit/{commit.Sha.Substring(0, 7)}");
                        Console.WriteLine(commit.Message);
                        Console.WriteLine();
                    }
                }
            }
        }

        static bool CommitContainsApi(Diff diff, Commit commit, Func<string, bool> pathFilter)
        {
            if (commit.Parents.Count() != 1)
            {
                return false;
            }
            var tree = commit.Tree;
            var parentTree = commit.Parents.First().Tree;
            var comparison = diff.Compare<TreeChanges>(parentTree, tree);
            return comparison.Select(change => change.Path).Any(pathFilter);
        }
    }
}
