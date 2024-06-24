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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Immutable class representing options for Set operations.
    /// </summary>
    public sealed class SetOptions
    {
        /// <summary>
        /// Returns an instance that overwrites the target object. This is the default when no
        /// options are provided.
        /// </summary>
        public static SetOptions Overwrite { get; } = new SetOptions(false, new FieldPath[0]);

        /// <summary>
        /// Returns an instance that merges all fields.
        /// </summary>
        public static SetOptions MergeAll { get; } = new SetOptions(true, new FieldPath[0]);

        /// <summary>
        /// Returns an instance that merges the given fields.
        /// </summary>
        /// <param name="fieldMask">The fields to merge. An empty array is equivalent to using <see cref="MergeAll"/>.
        /// Must not be null or contain any empty or null elements. Each field is treated as a dot-separated list of segments.
        /// </param>
        /// <returns>An instance that merges the given fields.</returns>
        public static SetOptions MergeFields(params string[] fieldMask)
        {
            GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask));
            GaxPreconditions.CheckArgument(fieldMask.All(x => !string.IsNullOrEmpty(x)), nameof(fieldMask), "Field mask must not contain any null or empty elements");
            return new SetOptions(true, fieldMask.Select(field => FieldPath.FromDotSeparatedString(field)).ToArray());
        }

        /// <summary>
        /// Returns an instance that merges the given fields.
        /// </summary>
        /// <param name="fieldMask">The fields to merge. An empty array is equivalent to using <see cref="MergeAll"/>.
        /// Must not be null or contain any null elements.</param>
        /// <returns>An instance that merges the given fields.</returns>
        public static SetOptions MergeFields(params FieldPath[] fieldMask)
        {
            GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask));
            GaxPreconditions.CheckArgument(fieldMask.All(x => x != null), nameof(fieldMask), "Field mask must not contain any null elements");
            // Note: field mask is copied for the sake of immutability.
            return new SetOptions(true, fieldMask.ToArray());
        }

        private SetOptions(bool merge, FieldPath[] fieldMask)
        {
            Merge = merge;
            FieldMask = new ReadOnlyCollection<FieldPath>(fieldMask);
        }

        /// <summary>
        /// Whether or not to merge values. If <see cref="FieldMask"/> is non-empty,
        /// this is always <c>true</c>.
        /// </summary>
        public bool Merge { get; }

        /// <summary>
        /// The fields to merge. This property is never null; if the mask is empty,
        /// all fields will be merged or overwritten.
        /// </summary>
        public IReadOnlyList<FieldPath> FieldMask { get; }
    }
}
