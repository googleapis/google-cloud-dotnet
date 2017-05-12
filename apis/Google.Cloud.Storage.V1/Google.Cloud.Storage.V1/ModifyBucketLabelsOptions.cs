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
using System;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for operations which modify bucket labels.
    /// </summary>
    public sealed class ModifyBucketLabelsOptions
    {
        /// <summary>
        /// The default number of retries.
        /// </summary>
        internal const int DefaultRetries = 3;

        /// <summary>
        /// Precondition for modification: the labels are only modified if its current
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        private int? _retries;

        /// <summary>
        /// The number of times to retry the modification if the bucket's metageneration changes
        /// in the read/modify/write cycle. If this property is not set, a suitable default is used.
        /// The value must not be negative.
        /// </summary>
        /// <remarks>
        /// Modifying bucket labels involves reading the bucket metadata in one request,
        /// then sending another request with the new labels, including a metageneration check
        /// to ensure that the bucket hasn't changed between the two requests. If the metageneration
        /// *has* changed, the overall operation can be retried from the start. This property indicates
        /// the number of retries, so it has a minimum value of 0.
        /// </remarks>
        public int? Retries
        {
            get => _retries;
            set
            {
                if (value < 0) // False for null implicitly
                {
                    // Simplest way to get the right exception...
                    GaxPreconditions.CheckArgumentRange(value.Value, nameof(value), 0, int.MaxValue);
                }
                _retries = value;
            }
        }
    }
}
