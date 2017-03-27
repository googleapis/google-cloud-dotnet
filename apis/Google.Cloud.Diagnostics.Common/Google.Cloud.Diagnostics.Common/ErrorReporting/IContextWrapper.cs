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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Wraps an http context.
    /// </summary>
    internal interface IContextWrapper
    {
        /// <summary>
        /// Gets the http method.  GET, POST, ect. Can be null.
        /// </summary>
        string GetMethod();

        /// <summary>
        /// Gets the http request uri. Can be null.
        /// </summary>
        string GetUri();

        /// <summary>
        /// Gets the user agent. Can be null.
        /// </summary>
        string GetUserAgent();

        /// <summary>
        /// Gets the http status code. If not set 0 will be returned.
        /// </summary>
        int GetStatusCode();
    }
}
