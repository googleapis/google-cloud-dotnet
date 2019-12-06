// Copyright 2019 Google LLC
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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.UpdateReleaseNotes
{
    internal sealed class Release
    {
        public StructuredVersion Version { get; }
        public IReadOnlyList<Commit> Commits { get; }
        public DateTime ReleaseDate { get; }

        public Release(StructuredVersion version, Commit tagCommit, IEnumerable<Commit> commits)
        {
            Version = version;
            Commits = commits.ToList().AsReadOnly();
            // Assume that if a release isn't tagged yet, it's because we're releasing it today.
            ReleaseDate = tagCommit != null
                ? (tagCommit.Author ?? tagCommit.Committer).When.Date
                : DateTime.Today;
        }
    }
}
