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

using System;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Base event args for events which fire on metadata changes.
    /// </summary>
    /// <typeparam name="T">The type representing the changed metadata.</typeparam>
    public abstract class MetadataChangedEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Gets the changed metadata.
        /// </summary>
        public T NewMetadata { get; }

        /// <summary>
        /// Creates a new <see cref="MetadataChangedEventArgs{T}"/> instance.
        /// </summary>
        /// <param name="newMetadata">The changed metadata.</param>
        protected MetadataChangedEventArgs(T newMetadata)
        {
            NewMetadata = newMetadata;
        }
    }
}
