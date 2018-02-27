// Copyright 2018 Google Inc. All Rights Reserved.
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

using Microsoft.AspNetCore.Http;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// A wrapper to hold a <see cref="IHttpContextAccessor"/>.
    /// This is used to allow easier access to the current trace id of
    /// an HTTP request at any time.
    /// </summary>
    internal static class HttpContextAccessorWrapper
    {
        /// <summary>
        /// The <see cref="IHttpContextAccessor"/> or null if none exists.
        /// </summary>
        internal static IHttpContextAccessor Accessor;
    }
}
