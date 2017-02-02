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

using Google.Api.Gax;
using Google.Apis.Translate.v2.Data;

namespace Google.Cloud.Translation.V2
{
    /// <summary>
    /// A language supported by the Google Cloud Translation API.
    /// </summary>
    public sealed class Language
    {
        /// <summary>
        /// The descriptive name of the language, e.g. "English". May be null if no target language was
        /// provided when requesting the supported languages.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The code to use for the language when providing this to the API
        /// as a source or target language.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Constructs an instance.
        /// </summary>
        /// <param name="name">The name of the language. May be null.</param>
        /// <param name="code">The code of the language. Must not be null.</param>
        public Language(string name, string code)
        {
            Name = name;
            Code = GaxPreconditions.CheckNotNull(code, nameof(code));
        }

        internal static Language FromResource(LanguagesResource resource) =>
            new Language(resource.Name, resource.Language);
    }
}
