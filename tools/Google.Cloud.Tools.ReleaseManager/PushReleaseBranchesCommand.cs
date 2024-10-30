// Copyright 2024 Google LLC
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
using Repository = LibGit2Sharp.Repository;

namespace Google.Cloud.Tools.ReleaseManager;

public sealed class PushReleaseBranchesCommand : CommandBase
{
    public PushReleaseBranchesCommand()
        : base("push-releases", "Push all branches with a name starting with 'release-'")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var root = DirectoryLayout.DetermineRootDirectory();
        using var repo = new Repository(root);

        var originalBranch = repo.Head;
        var releaseBranches = repo.Branches.Where(b => b.FriendlyName.StartsWith("release-")).ToList();

        foreach (var branch in releaseBranches)
        {
            Console.WriteLine($"Releasing {branch.FriendlyName}");
            Commands.Checkout(repo, branch);
            new PushCommand().InternalExecute();
        }

        Commands.Checkout(repo, originalBranch);

        if (ConfirmDeleteBranches())
        {
            foreach (var branch in releaseBranches)
            {
                Console.WriteLine($"Deleting {branch.FriendlyName}");
                repo.Branches.Remove(branch);
            }
        }

        return 0;
    }

    private static bool ConfirmDeleteBranches()
    {
        while (true)
        {
            Console.Write("Deleted pushed branches?(y/n) ");
            string response = Console.ReadLine();
            switch (response)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    Console.WriteLine($"Unexpected response '{response}'.");
                    continue;
            }
        }
    }

}
