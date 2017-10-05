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


using Google.Cloud.Firestore.V1Beta1;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// A query against a collection.
    /// </summary>
    /// <remarks>
    /// <see cref="CollectionReference"/> derives from this class as a "return-all" query against the
    /// collection it refers to.
    /// </remarks>
    public class Query
    {
        /// <summary>
        /// The database this query will search over.
        /// </summary>
        public FirestoreDb Database { get; }

        internal string ParentPath { get; }

        private readonly StructuredQuery _query;

        internal Query(FirestoreDb database, StructuredQuery query, string parentPath)
        {
            Database = database;
            _query = query;
            ParentPath = parentPath;
        }
    }
}
