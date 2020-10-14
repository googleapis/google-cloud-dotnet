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
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager.History
{
    /// <summary>
    /// A commit in the history of an API. This class basically exists to avoid putting
    /// too much code into HistoryFile.
    /// </summary>
    internal class GitCommit
    {
        private static Lazy<Dictionary<string, string>> s_overrides = new Lazy<Dictionary<string, string>>(LoadOverrides);

        private const string AutosynthEmail = "yoshi-automation@google.com";
        /// <summary>
        /// A commit line consisting of just "Version history:" indicates that all the lines
        /// following that should be treated as the version history entries.
        /// </summary>
        private const string VersionHistoryOverride = "Version history:";
        /// <summary>
        /// Message to use in order to skip a commit entirely.
        /// </summary>
        private const string SkipMessage = "skip";

        private readonly Commit _libGit2Commit;

        private string Hash { get; }
        private string Url { get; }

        internal GitCommit(Commit libGit2Commit)
        {
            _libGit2Commit = libGit2Commit;
            Hash = _libGit2Commit.Sha.Substring(0, 7);
            Url = $"https://github.com/googleapis/google-cloud-dotnet/commit/{Hash}";
        }

        private static readonly Regex IssuePattern = new Regex(@"#(\d+)");

        /// <summary>
        /// Attempts to come up with suitable markdown for release notes, based on a commit.
        /// This is best effort, heuristic-based - and we'll want to tweak it over time.
        /// </summary>
        internal IEnumerable<string> GetHistoryLines()
        {
            // Use the override if one has been provided for this commit, or the commit message otherwise.
            string message = s_overrides.Value.GetValueOrDefault(Hash, _libGit2Commit.Message);

            var messageLines = message.Replace("\r", "").Split('\n')
                // Blank lines aren't helpful. It's slightly annoying that if the commit originally
                // contained multiple consecutive lines that were intended to be a single paragraph,
                // that won't come out nicely - we may want to try to detect that later.
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(AddIssueLink)
                .ToList();

            // Autosynth includes helpful metadata about the original internal and googleapis commit.
            // We don't need that in release notes though.
            if (_libGit2Commit.Author.Email == AutosynthEmail)
            {
                messageLines = messageLines.TakeWhile(line => !line.StartsWith("PiperOrigin-RevId")).ToList();
            }

            // Allow the version history to be overridden by a line on its own of "Version history:"
            // followed by all the lines that should be in version history.
            int overrideIndex = messageLines.IndexOf(VersionHistoryOverride);
            if (overrideIndex != -1)
            {
                messageLines = messageLines.Skip(overrideIndex + 1).ToList();
            }

            // A single line of "skip" (usually from an override, either in the commit or in the overrides file)
            // means we skip the commit entirely.
            if (messageLines.Count == 1 && messageLines[0].Equals(SkipMessage, StringComparison.OrdinalIgnoreCase))
            {
                yield break;
            }

            // Common commit format: "Meaningful text [linebreak] Fixes #5000". Put that all on one line.
            if (messageLines.Count == 2 && messageLines[1].StartsWith("Fixes [issue"))
            {
                if (messageLines[0].Last() != '.')
                {
                    messageLines[0] += '.';
                }
                messageLines[0] += $" {messageLines[1]}";
                messageLines.RemoveAt(1);
            }

            // Either format as a single list entry "Commit: purpose" or a list with a top-level "Commit:" and one
            // message line per original line.
            if (messageLines.Count == 1)
            {
                yield return $"- [Commit {Hash}]({Url}): {messageLines[0]}";
            }
            else
            {
                yield return $"- [Commit {Hash}]({Url}):";
                foreach (var line in messageLines)
                {
                    // Anything already in a list can keep its existing list indentation; otherwise, create a list item.
                    yield return line.TrimStart().StartsWith("-") ? $"  {line}" : $"  - {line}";
                }
            }

            string AddIssueLink(string line) =>
                IssuePattern.Replace(line, "[issue $1](https://github.com/googleapis/google-cloud-dotnet/issues/$1)");
        }

        private static Dictionary<string, string> LoadOverrides()
        {
            using var stream = typeof(GitCommit).Assembly.GetManifestResourceStream(typeof(GitCommit), "overrides.json");
            using var reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }
}
