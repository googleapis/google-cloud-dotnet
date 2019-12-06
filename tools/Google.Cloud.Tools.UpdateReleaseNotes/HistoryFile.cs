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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.UpdateReleaseNotes
{
    /// <summary>
    /// A history file, which is basically a list of sections. Each section has
    /// a version and release date - except potentially the first section, which might contain
    /// some preamble. All sections then have a list of lines.
    /// </summary>
    internal sealed class HistoryFile
    {
        private static readonly Regex SectionHeader = new Regex(@"# Version (.*), released \d{4}-\d{2}-\d{2}");

        private List<Section> sections;

        private HistoryFile(List<Section> sections) => this.sections = sections;

        public static HistoryFile Load(string file)
        {
            var sections = new List<Section>();
            var lines = File.ReadAllLines(file);

            StructuredVersion currentVersion = null;
            var currentSectionLines = new List<string>();

            foreach (var line in lines)
            {
                var match = SectionHeader.Match(line);
                if (match.Success)
                {
                    sections.Add(new Section(currentVersion, currentSectionLines));
                    currentSectionLines = new List<string>();
                    currentVersion = new StructuredVersion(match.Groups[1].Value);
                }
                currentSectionLines.Add(line);
            }
            sections.Add(new Section(currentVersion, currentSectionLines));
            return new HistoryFile(sections);
        }

        public void Save(string file) =>
            File.WriteAllLines(file, sections.SelectMany(section => section.Lines));

        /// <summary>
        /// Merges the given list of releases into the file, ignoring releases that are already present.
        /// </summary>
        /// <param name="releases">The list of releases to merge, in reverse-chronological order (so latest first).</param>
        internal void MergeReleases(List<Release> releases)
        {
            int latestExistingVersionIndex = sections.FindIndex(s => s.Version != null);

            var latestExistingVersion = latestExistingVersionIndex == -1 ? null : sections[latestExistingVersionIndex].Version;
            var insertIndex = latestExistingVersionIndex == -1 ? sections.Count : latestExistingVersionIndex;

            foreach (var release in releases)
            {
                // If we've reached an already-documented version, stop.
                if (release.Version.Equals(latestExistingVersion))
                {
                    break;
                }
                Section section = new Section(release);
                sections.Insert(insertIndex, section);
                insertIndex++;
            }
        }

        private class Section
        {
            public StructuredVersion Version { get; }

            // The lines for the section, including the section header.
            public List<string> Lines { get; }

            public Section(StructuredVersion version, List<string> lines)
            {
                Version = version;
                Lines = lines;
            }

            public Section(Release release)
            {
                Version = release.Version;

                Lines = new List<string>();

                Lines.Add($"# Version {Version}, released {release.ReleaseDate:yyyy-MM-dd}");
                Lines.Add("");
                foreach (var commit in release.Commits)
                {
                    Lines.AddRange(GetCommitLines(commit));
                }
                Lines.Add("");
            }

            private static readonly Regex IssuePattern = new Regex(@"#(\d+)");

            /// <summary>
            /// Attempts to come up with suitable markdown for release notes, based on a commit.
            /// This is best effort, heuristic-based - and we'll want to tweak it over time.
            /// </summary>
            private IEnumerable<string> GetCommitLines(Commit commit)
            {
                string sha = commit.Sha.Substring(0, 7);
                string commitUrl = $"https://github.com/googleapis/google-cloud-dotnet/commit/{sha}";

                var messageLines = commit.Message.Replace("\r", "").Split('\n')
                    // Blank lines aren't helpful. It's slightly annoying that if the commit originally
                    // contained multiple consecutive lines that were intended to be a single paragraph,
                    // that won't come out nicely - we may want to try to detect that later.
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(AddIssueLink)
                    .ToList();

                // Autosynth commits have a meaningless title.
                if (commit.Author.Email == "yoshi-automation@google.com")
                {
                    messageLines.RemoveAt(0);
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
                    yield return $"- [Commit {sha}]({commitUrl}): {messageLines[0]}";
                }
                else
                {
                    yield return $"- [Commit {sha}]({commitUrl}):";
                    foreach (var line in messageLines)
                    {
                        yield return $"  - {line}";
                    }
                }

                string AddIssueLink(string line) =>
                    IssuePattern.Replace(line, "[issue $1](https://github.com/googleapis/google-cloud-dotnet/issues/$1)");
            }
        }
    }
}
