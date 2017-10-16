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
    /// Operators for use in queries.
    /// </summary>
    public enum QueryOperator
    {
        /// <summary>
        /// Requires that the specified field has a value equal to the one in the filter.
        /// </summary>
        Equal,

        /// <summary>
        /// Requires that the specified field has a value less than the one in the filter.
        /// </summary>
        LessThan,

        /// <summary>
        /// Requires that the specified field has a value less than or equal to the one in the filter.
        /// </summary>
        LessThanOrEqual,

        /// <summary>
        /// Requires that the specified field has a value greater than the one in the filter.
        /// </summary>
        GreaterThan,

        /// <summary>
        /// Requires that the specified field has a value greater than or equal to the one in the filter.
        /// </summary>
        GreaterThanOrEqual
    }
}
