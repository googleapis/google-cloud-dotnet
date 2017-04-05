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

using Google.Api.Gax;

namespace Google.Cloud.Language.V1
{
    public partial class Document
    {
        /// <summary>
        /// Constructs a document from a plain text string and optional language.
        /// </summary>
        /// <param name="text">The text of the document. Must not be null.</param>
        /// <param name="language">The language of the document, as an ISO or BCP-47 language code.
        /// This may be empty or null (the default), in which case the language will be detected
        /// by the Natural Language service.</param>
        /// <returns>The newly created document.</returns>
        public static Document FromPlainText(string text, string language = null)
        {
            GaxPreconditions.CheckNotNull(text, nameof(text));
            return new Document
            {
                Content = text,
                Type = Types.Type.PlainText,
                Language = language ?? ""
            };
        }

        /// <summary>
        /// Constructs a document from an HTML string and optional language.
        /// </summary>
        /// <param name="html">The HTML text of the document. Must not be null.</param>
        /// <param name="language">The language of the document, as an ISO or BCP-47 language code.
        /// This may be empty or null (the default), in which case the language will be detected
        /// by the Natural Language service.</param>
        /// <returns>The newly created document.</returns>
        public static Document FromHtml(string html, string language = null)
        {
            GaxPreconditions.CheckNotNull(html, nameof(html));
            return new Document
            {
                Content = html,
                Type = Types.Type.Html,
                Language = language ?? ""
            };
        }
    }
}
