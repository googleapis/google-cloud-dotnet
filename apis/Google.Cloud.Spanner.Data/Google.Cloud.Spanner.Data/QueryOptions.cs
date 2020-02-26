// Copyright 2020 Google LLC
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

using Google.Cloud.Spanner.V1;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Immutable class representing query options.
    /// </summary>
    public sealed class QueryOptions
    {
        /// <summary>
        /// An option to control the selection of optimizer version.
        ///
        /// This parameter allows individual queries to pick different query
        /// optimizer versions.
        ///
        /// Specifying "latest" as a value instructs Cloud Spanner to use the
        /// latest supported query optimizer version. If not specified, Cloud Spanner
        /// uses optimizer version set at the database level options. Any other
        /// positive integer (from the list of supported optimizer versions)
        /// overrides the default optimizer version for query execution.
        /// </summary>
        public string OptimizerVersion
        {
            get { return Proto.OptimizerVersion; }
            set { Proto.OptimizerVersion = value; }
        }

        /// <summary>
        /// The proto representation of the query options. Must not be mutated
        /// or exposed publicly.
        /// </summary>
        internal V1.ExecuteSqlRequest.Types.QueryOptions Proto { get; }

        private QueryOptions(V1.ExecuteSqlRequest.Types.QueryOptions proto) => Proto = proto;

        /// <summary>
        /// Creates query options without specifying any options.
        /// </summary>
        public QueryOptions() : this(new V1.ExecuteSqlRequest.Types.QueryOptions())
        {
        }

        /// <summary>
        /// Set query options from the proto.
        /// </summary>
        public static QueryOptions FromProto(
            V1.ExecuteSqlRequest.Types.QueryOptions proto) => proto == null ? null : new QueryOptions(proto);

        /// <summary>
        /// Get proto version of the query options.
        /// </summary>
        public V1.ExecuteSqlRequest.Types.QueryOptions ToProto()
        {
            return Proto.Clone();
        }
    }
}
