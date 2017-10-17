// Copyright 2017, Google Inc. All rights reserved.
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

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// Sentinel values are special values where the client-side value is not part of the
    /// document modification sent to the server. A property decorated with
    /// <see cref="FirestorePropertyAttribute"/> can specify the sentinel value in the attribute
    /// using <see cref="FirestorePropertyAttribute.SentinelValue"/>, or the sentinel values in this enum
    /// can be used directly as values to be serialized (for example, in anonymous types), and they will be handled
    /// directly by the serialization mechanism.
    /// </summary>
    public enum SentinelValue
    {
        /// <summary>
        /// Only present to allow <see cref="FirestorePropertyAttribute"/> to indicate that
        /// a property is not a sentinel value; this value cannot be serialized.
        /// </summary>
        None = 0,

        /// <summary>
        /// The value should be ignored on creation and modification operations,
        /// using the server time for the commit that modifies the document.
        /// </summary>
        ServerTimestamp = 1,

        /// <summary>
        /// The value should be ignored, and the document field deleted.
        /// </summary>
        Delete = 2
    }
}
