// Copyright 2016 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using System.Linq;

namespace Google.GCloud.Tools.GenerateSnippetMarkdown
{
    /// <summary>
    /// A snippet from the snippets directory.
    /// </summary>
    public class Snippet
    {
        /// <summary>
        /// The snippet ID that appears in source code. This is specified in a "Snippet:" or
        /// "Sample:" line.
        /// </summary>
        public string SnippetId { get; set; }

        /// <summary>
        /// Is this a sample for general documentation rather than API docs? If so, the snippet ID isn't
        /// used for member matching.
        /// </summary>
        public bool Sample { get; set; }

        /// <summary>
        /// Additional members which should receive the same snippet.
        /// </summary>
        public IList<string> AdditionalMembers { get; } = new List<string>();

        /// <summary>
        /// The UIDs of the docfx metadata items, if any.
        /// </summary>
        public IList<string> MetadataUids { get; } = new List<string>();

        /// <summary>
        /// Where in the snippet text this snippet starts (inclusive).
        /// </summary>
        public int StartLine { get; set; }

        /// <summary>
        /// Where in the snippet text this snippet ends (inclusive).
        /// </summary>
        public int EndLine { get; set; }

        /// <summary>
        /// Lines of the snippet.
        /// </summary>
        public List<string> Lines { get; } = new List<string>();

        /// <summary>
        /// File containing the snippet
        /// </summary>
        public string SourceFile { get; set; }

        /// <summary>
        /// First line of the snippet within the source file.
        /// </summary>
        public int SourceStartLine { get; set; }

        /// <summary>
        /// Formatted SourceFile:SourceStartLine.
        /// </summary>
        public string SourceLocation => $"{SourceFile}:{SourceStartLine}";

        /// <summary>
        /// Trim all leading spaces by a uniform amount (the smallest number of spaces in any line).
        /// </summary>
        internal void TrimLeadingSpaces()
        {
            var spacesToRemove = Lines.Min(line => line.Trim() == "" ? int.MaxValue : line.TakeWhile(c => c == ' ').Count());
            for (int i = 0; i < Lines.Count; i++)
            {
                Lines[i] = Lines[i].Trim() == "" ? "": Lines[i].Substring(spacesToRemove);
            }
        }
    }
}
