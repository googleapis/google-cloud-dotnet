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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseManager.History
{
    /// <summary>
    /// A history file, which is basically a list of sections. Each section has
    /// a version and release date - except potentially the first section, which might contain
    /// some preamble. All sections then have a list of lines.
    /// </summary>
    /// <remarks>
    /// This is now only used by PrepareLibraryReleaseCommand, and can probably be moved and simplified in
    /// the longer term.
    /// </remarks>
    internal sealed class HistoryFile
    {
        private static readonly string[] PreambleLines = new[] { "# Version history", "" };
        private const string MarkdownFile = "history.md";
        private static readonly Regex SectionHeader = new Regex(@"## Version (.*), released \d{4}-\d{2}-\d{2}");

        /// <summary>
        /// The sections within the history file, in file order (reverse chronological).
        /// </summary>
        public List<Section> Sections { get; }

        public string FilePath { get; }

        private HistoryFile(string path, List<Section> sections) => (FilePath, Sections) = (path, sections);

        public static HistoryFile Load(RootLayout rootLayout, string id, bool createIfAbsent = true)
        {
            string file = Path.Combine(rootLayout.CreateDocsLayout(id).MarkdownDirectory, MarkdownFile);
            var sections = new List<Section>();
            if (!File.Exists(file))
            {
                if (!createIfAbsent)
                {
                    throw new UserErrorException($"Expected history file {file} to already exist");
                }
                sections.Add(new Section(null, PreambleLines.ToList()));
                return new HistoryFile(file, sections);
            }

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
                    currentVersion = StructuredVersion.FromString(match.Groups[1].Value);
                }
                currentSectionLines.Add(line);
            }
            sections.Add(new Section(currentVersion, currentSectionLines));
            return new HistoryFile(file, sections);
        }

        public void Save()
        {
            // Make sure the directory exists. (This is a no-op if it already exists.)
            new FileInfo(FilePath).Directory.Create();
            File.WriteAllLines(FilePath, Sections.SelectMany(section => section.Lines));
        }

        public sealed class Section
        {
            /// <summary>
            /// The version represented in this section. May be null, for the preamble.
            /// </summary>
            public StructuredVersion Version { get; }

            /// <summary>
            /// The lines for the section, including the section header.
            /// </summary>
            public List<string> Lines { get; }

            /// <summary>
            /// Creates a section with the given version and lines, which are expected to include the section header.
            /// </summary>
            public Section(StructuredVersion version, List<string> lines)
            {
                Version = version;
                Lines = lines;
            }

            public static Section FromReleaseNotes(StructuredVersion version, DateTime date, List<string> releaseNotes)
            {
                var sectionHeader = $"## Version {version}, released {date:yyyy-MM-dd}";
                var lines = new List<string>()
                {
                    sectionHeader, ""
                };
                lines.AddRange(releaseNotes);
                return new Section(version, lines);
            }
        }
    }
}
