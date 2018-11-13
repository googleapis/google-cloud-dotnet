// Copyright 2018 Google LLC
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// The algorithm version to use in <see cref="UrlSigner"/>. See
    /// <see cref="UrlSigner.WithSigningVersion(SigningVersion)" /> for usage.
    /// </summary>
    public enum SigningVersion
    {
        /// <summary>
        /// The default signing version, where the version to use is chosen by the client library implementation.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Always use V2 URL signing.
        /// </summary>
        V2 = 1,

        /// <summary>
        /// Always use V4 URL signing.
        /// </summary>
        V4 = 2
    }
}
