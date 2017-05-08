// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.GenerateSnippetMarkdown
{
    /// <summary>
    /// A "see-also" to refer to one member from another.
    /// </summary>
    public class SeeAlso
    {
        /// <summary>
        /// The ID of the snippet this refers to, referring to the member which is the target
        /// of the link.
        /// </summary>
        public string SnippetId { get; set; }

        /// <summary>
        /// The metadata UID for the member referred to by SnippetId.
        /// </summary>
        public string SnippetUid { get; set; }

        /// <summary>
        /// Members to resolve in metadata, i.e. code members to use this snippet in as sample code.
        /// </summary>
        public IList<string> MetadataMembers { get; } = new List<string>();

        /// <summary>
        /// The UIDs of the docfx metadata items.
        /// </summary>
        public IList<string> MetadataUids { get; } = new List<string>();

        /// <summary>
        /// Lines of the see-also. (These may contain {ref} which needs to be
        /// replaced with the target UID.)
        /// </summary>
        public List<string> Lines { get; } = new List<string>();

        /// <summary>
        /// File containing the see-also.
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
    }
}
