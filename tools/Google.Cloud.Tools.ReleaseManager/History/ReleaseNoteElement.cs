// Copyright 2021 Google LLC
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

using System.Text;

namespace Google.Cloud.Tools.ReleaseManager.History
{
    /// <summary>
    /// One element of a release note, representing a single feature, fix etc.
    /// </summary>
    internal sealed class ReleaseNoteElement
    {
        /// <summary>
        /// Whether or not we should actually include this note in the published
        /// release notes.
        /// </summary>
        public bool PublishInReleaseNotes => Type != ReleaseNoteElementType.Chore && Type != ReleaseNoteElementType.Placeholder;

        /// <summary>
        /// The commit within google-cloud-dotnet responsible for the change.
        /// </summary>
        public string CommitHash { get; }

        /// <summary>
        /// The type of the element, as derived from the conventional commit.
        /// </summary>
        public ReleaseNoteElementType Type { get; }

        /// <summary>
        /// Whether or not this is a breaking change.
        /// </summary>
        public bool BreakingChange { get; }

        /// <summary>
        /// The text of the element, not including any conventional commit prefix.
        /// </summary>
        public string Text { get; }

        private ReleaseNoteElement(string commitHash, string text, ReleaseNoteElementType type, bool breakingChange) =>
            (CommitHash, Text, Type, BreakingChange) = (commitHash, text, type, breakingChange);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (BreakingChange)
            {
                builder.Append("**BREAKING CHANGE** ");
            }
            builder.Append(Text);
            builder.Append($" ([commit {GitHelpers.GetHashPrefix(CommitHash)}](https://github.com/googleapis/google-cloud-dotnet/commit/{CommitHash}))");
            return builder.ToString();
        }

        /// <summary>
        /// Parses the given text, expecting it to be a conventional commit message.
        /// </summary>
        /// <param name="text">The message</param>
        /// <param name="hash">The git commit hash that this element is part of.</param>
        /// <returns>The parsed release note element, or null to skip entirely.</returns>
        public static ReleaseNoteElement Parse(string hash, string text)
        {
            string[] parts = text.Split(':', 2);

            if (parts.Length == 1)
            {
                // Not a conventional commit message.
                return null;
            }
            string prefix = parts[0];
            bool breakingChange = prefix.Contains('!');
            ReleaseNoteElementType type = prefix.Replace("!", "").Split('(')[0] switch
            {
                "feat" => ReleaseNoteElementType.Feature,
                "fix" => ReleaseNoteElementType.Fix,
                "chore" => ReleaseNoteElementType.Chore,
                "docs" => ReleaseNoteElementType.Docs,
                "doc" => ReleaseNoteElementType.Docs,
                "regen" => ReleaseNoteElementType.Placeholder,
                "BREAKING CHANGE" => ReleaseNoteElementType.BreakingChange,
                _ => ReleaseNoteElementType.Unknown
            };
            if (type == ReleaseNoteElementType.BreakingChange)
            {
                // In a breaking change section, we don't need to highlight that a change is breaking.
                breakingChange = false;
            }
            // If we the haven't got a valid type, and the text contains a space,
            // chances are it's not intended to be a conventional commit message, so we ignore it.
            if (type == ReleaseNoteElementType.Unknown && prefix.Contains(' '))
            {
                return null;
            }
            string message = parts[1].Trim();
            if (message == "")
            {
                message = "(No details.)";
            }
            message = char.ToUpperInvariant(message[0]) + message.Substring(1);
            return new ReleaseNoteElement(hash, message, type, breakingChange);
        }
    }
}
