// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Fetches the tags which point at the current HEAD, and prints all the package
/// IDs that should be released based on those tags, translating package groups
/// appropriately.
/// </summary>
public class GetTaggedLibrariesCommand : CommandBase
{
    public GetTaggedLibrariesCommand() : base("get-tagged-libraries", "Prints the set of package IDs to release based on tags at the current commit")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        var repo = new Repository(RootLayout.RepositoryRoot);
        var catalog = ApiCatalog.Load(RootLayout);
        var headSha = repo.Head.Tip.Sha;
        var tags = repo.Tags.Where(tag => tag.PeeledTarget.Sha == headSha).ToList();

        if (tags.Count == 0)
        {
            throw new UserErrorException("Current HEAD is not tagged.");
        }
        var apis = tags.Select(tag => tag.FriendlyName).SelectMany(TranslateTag).ToList();
        Console.WriteLine(string.Join(" ", apis));
        return 0;

        IEnumerable<string> TranslateTag(string tag)
        {
            var bits = tag.Split('-');
            if (bits.Length != 2)
            {
                throw new UserErrorException($"Cannot translate tag '{tag}'; incorrect format");
            }
            var libraryId = bits[0];

            if (catalog.TryGetApi(libraryId, out var api))
            {
                return new[] { api.Id };
            }
            return catalog.PackageGroups.FirstOrDefault(pg => pg.Id == libraryId)?.PackageIds
                ?? throw new UserErrorException($"Unknown library ID '{libraryId}' from tag '{tag}'");
        }
    }
}
