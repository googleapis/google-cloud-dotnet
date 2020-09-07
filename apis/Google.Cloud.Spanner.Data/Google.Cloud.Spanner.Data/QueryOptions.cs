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

using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using System;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Immutable class representing query options.
    /// </summary>
    public sealed class QueryOptions : IEquatable<QueryOptions>
    {
        /// <summary>
        /// The query optimizer version configured in the options.
        /// </summary>
        public string OptimizerVersion => Proto.OptimizerVersion;

        /// <summary>
        /// The query optimizer statistics package configured in the options.
        /// </summary>
        public string OptimizerStatisticsPackage => Proto.OptimizerStatisticsPackage;

        /// <summary>
        /// Clones the options and sets the optimizer version to the given value.
        /// </summary>
        /// <returns>
        /// A clone of the options with the updated optimizer version.
        /// </returns>
        /// <remarks>
        /// <para>The parameter allows individual queries to pick different query
        /// optimizer versions.</para>
        /// <para>Specifying "latest" as a value instructs Cloud Spanner to use the
        /// latest supported query optimizer version. If not specified, Cloud Spanner
        /// uses optimizer version set at the database level options. Any other
        /// positive integer (from the list of supported optimizer versions)
        /// overrides the default optimizer version for query execution.</para>
        /// </remarks>
        /// <param name="optimizerVersion">Optimizer version to set.</param>
        public QueryOptions WithOptimizerVersion(string optimizerVersion)
        {
           var protoCopy = Proto.Clone();
           protoCopy.OptimizerVersion = optimizerVersion;
           return new QueryOptions(protoCopy);
        }

        /// <summary>
        /// Clones the options and sets the optimizer statistics package to the given value.
        /// </summary>
        /// <returns>
        /// A clone of the options with the updated optimizer statistics package.
        /// </returns>
        /// <remarks>
        /// <para>The parameter allows individual queries to pick different query
        /// optimizer statistics packages.</para>
        /// <para>Specifying "latest" as a value instructs Cloud Spanner to use the
        /// latest supported query optimizer statistics package. If not specified,
        /// Cloud Spanner uses the optimizer statistics package set at the database
        /// level options. Any other supported statistics package value overrides
        /// the default optimizer statistics package for query execution.</para>
        /// </remarks>
        /// <param name="optimizerStatisticsPackage">Optimizer statistics package to set.</param>
        public QueryOptions WithOptimizerStatisticsPackage(string optimizerStatisticsPackage)
        {
           var protoCopy = Proto.Clone();
           protoCopy.OptimizerStatisticsPackage = optimizerStatisticsPackage;
           return new QueryOptions(protoCopy);
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
        public static QueryOptions Empty { get; } = new QueryOptions(new V1.ExecuteSqlRequest.Types.QueryOptions());

        /// <summary>
        /// Set query options from the given proto.
        /// </summary>
        /// <remarks>
        /// The given proto should not be null. The given proto is cloned.
        /// </remarks>
        /// <param name="proto">The proto to construct <see cref="QueryOptions"/> from.</param>
        public static QueryOptions FromProto(V1.ExecuteSqlRequest.Types.QueryOptions proto)
        {
            GaxPreconditions.CheckNotNull(proto, nameof(proto));
            return new QueryOptions(proto.Clone());
        }

        /// <summary>
        /// Get proto version of the query options.
        /// </summary>
        public V1.ExecuteSqlRequest.Types.QueryOptions ToProto() => Proto.Clone();

        /// <inheritdoc />
        public bool Equals(QueryOptions other) =>
            other is object &&
            OptimizerVersion == other.OptimizerVersion &&
            OptimizerStatisticsPackage == other.OptimizerStatisticsPackage;

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as QueryOptions);

        /// <inheritdoc />
        public override int GetHashCode() => Proto.GetHashCode();
    }
}
