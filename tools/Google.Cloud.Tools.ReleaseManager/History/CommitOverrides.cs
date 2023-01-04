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

using LibGit2Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager.History
{
    /// <summary>
    /// Central point to load and provide the data from overrides.json.
    /// </summary>
    public static class CommitOverrides
    {
        private static readonly Lazy<IReadOnlyDictionary<string, string>> s_overrides = new Lazy<IReadOnlyDictionary<string, string>>(LoadOverrides);

        /// <summary>
        /// A read-only map from commit hash prefix (7 characters) to the message.
        /// </summary>
        public static IReadOnlyDictionary<string, string> HashPrefixToMessageMap => s_overrides.Value;

        /// <summary>
        /// The message used to skip a commit in the update history and staleness testing.
        /// </summary>
        public const string SkipMessage = "skip";

        /// <summary>
        /// Checks whether the commit with the given hash prefix should be skipped.
        /// </summary>
        public static bool IsSkipped(string hash) => SkipMessage.Equals(HashPrefixToMessageMap.GetValueOrDefault(hash), StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Checks whether the given commit should be skipped.
        /// </summary>
        public static bool IsSkipped(Commit commit) => IsSkipped(commit.GetHashPrefix());

        private static IReadOnlyDictionary<string, string> LoadOverrides()
        {
            using var stream = typeof(GitCommit).Assembly.GetManifestResourceStream(typeof(GitCommit), "overrides.json");
            using var reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            return new ReadOnlyDictionary<string, string>(JsonConvert.DeserializeObject<Dictionary<string, string>>(json));
        }

    }
}
