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

using LibGit2Sharp;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Tools.ReleaseManager;

internal static class GitHelpers
{
    public static Commit CommitAll(Repository repo, string message, Identity identity)
    {
        RepositoryStatus status = repo.RetrieveStatus();
        AddAll(status.Modified);
        AddAll(status.Missing);
        AddAll(status.Untracked);
        repo.Index.Write();
        var timestamp = DateTime.UtcNow;
        var signature = identity is null ? repo.Config.BuildSignature(timestamp) : new Signature(identity, timestamp);
        return repo.Commit(message, signature, signature);

        void AddAll(IEnumerable<StatusEntry> entries)
        {
            foreach (var entry in entries)
            {
                if (entry.State == FileStatus.DeletedFromWorkdir)
                {
                    repo.Index.Remove(entry.FilePath);
                }
                else
                {
                    repo.Index.Add(entry.FilePath);
                }
            }
        }
    }
}
