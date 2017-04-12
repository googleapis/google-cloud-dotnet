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

namespace Google.Cloud.DevTools.Source.V1
{
    /// <summary>
    /// Partial class to SourceContext proto to add additional properties etc.
    /// </summary>
    public sealed partial class SourceContext
    {
        /// <summary>
        /// Gets the custom log label of Stackdriver Logging entry for Git commit id.
        /// </summary>
        public const string GitRevisionIdLogLabel = "git_revision_id";

        /// <summary>
        /// Gets the Git revision id if it is present. 
        /// Returns null if there is no <seealso cref="GitSourceContext"/> in the protobuf.
        /// </summary>
        public string GitRevisionId => Git?.RevisionId;
    }
}
