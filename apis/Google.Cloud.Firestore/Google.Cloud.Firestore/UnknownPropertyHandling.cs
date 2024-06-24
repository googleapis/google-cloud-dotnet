// Copyright 2018, Google LLC
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

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Determines how unknown properties are handling when deserializing a
    /// Firestore document.
    /// </summary>
    public enum UnknownPropertyHandling
    {
        /// <summary>
        /// Unknown properties are silently ignored.
        /// </summary>
        Ignore = 0,

        /// <summary>
        /// Unknown properties cause a warning, but no error.
        /// </summary>
        Warn = 1,

        /// <summary>
        /// Unknown properties cause an exception to be thrown.
        /// </summary>
        Throw = 2
    }
}
