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

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Contains the result from the wait for change operation.
    /// </summary>
    /// <seealso cref="MetadataClient.WaitForChange"/>
    /// <seealso cref="MetadataClient.WaitForChangeAsync"/>
    public sealed class WaitForChangeResult
    {
        /// <summary>
        /// Gets the ETag header from the server response.
        /// </summary>
        public string ETag { get; }

        /// <summary>
        /// Gets the content of the server response, which may or may not be a changed value, depending on whether the
        /// timeout expired.
        /// </summary>
        public string Content { get; }

        internal WaitForChangeResult(string content, string etag)
        {
            Content = content;
            ETag = etag;
        }
    }
}
