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
using System.Collections.Generic;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// An immutable snapshot of complete query results.
    /// </summary>
    public sealed class QuerySnapshot
    {
        internal QuerySnapshot(Query query, IReadOnlyList<DocumentSnapshot> documents, Timestamp readTime)
        {
            Query = query;
            Documents = documents;
            ReadTime = readTime;
        }

        /// <summary>
        /// The query producing this snapshot.
        /// </summary>
        public Query Query { get; }

        /// <summary>
        /// The time at which the snapshot was read.
        /// </summary>
        public Timestamp ReadTime { get; }

        /// <summary>
        /// The documents in the snapshot.
        /// </summary>
        public IReadOnlyList<DocumentSnapshot> Documents { get; }
    }
}
