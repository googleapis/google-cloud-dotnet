// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Spanner.Common.V1;
using System;

namespace Google.Cloud.Spanner.V1;
public sealed partial class SessionPool
{
    /// <summary>
    /// Aspects under which a session pool is segmented.
    /// </summary>
    public sealed class SessionPoolSegmentKey : IEquatable<SessionPoolSegmentKey>
    {
        /// <summary>
        /// The database for which sessions are pooled on the associated session pool.
        /// </summary>
        public DatabaseName DatabaseName { get; }

        /// <summary>
        /// The database role of the sessions pooled on the associated session pool.
        /// </summary>
        public string DatabaseRole { get; }

        /// <summary>
        ///  Creates a new <see cref="SessionPoolSegmentKey"/>.
        /// </summary>
        /// <param name="databaseName">The database name for the associated pool. Must not be null</param>
        /// <param name="databaseRole">The database role for the associated pool. May be null
        /// in which case the default (public) database role is used if fine grained access control
        /// is enabled; otherwise the database role is ignored.</param>
        private SessionPoolSegmentKey(DatabaseName databaseName, string databaseRole)
        {
            DatabaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            DatabaseRole = databaseRole;
        }

        /// <summary>
        /// Creates a <see cref="SessionPoolSegmentKey"/> with the given database name. 
        /// </summary>
        /// <param name="databaseName">The database name for the associated pool. Must not be null.</param>
        public static SessionPoolSegmentKey Create(DatabaseName databaseName) =>
            new SessionPoolSegmentKey(databaseName, null);

        /// <summary>
        /// Creates a <see cref="SessionPoolSegmentKey"/> based on this one but with the given database role.  
        /// </summary>
        /// <param name="databaseRole">The database role for the associated pool. May be null
        /// in which case the default (public) database role is used if fine grained access control
        /// is enabled; otherwise the database role is ignored.</param>
        public SessionPoolSegmentKey WithDatabaseRole(string databaseRole) =>
            new SessionPoolSegmentKey(DatabaseName, databaseRole);

        /// <inheritdoc/>
        public override string ToString() =>
            $"DatabaseName: {DatabaseName}; DatabaseRole: {DatabaseRole}";

        /// <inheritdoc/>
        public override int GetHashCode() =>
            GaxEqualityHelpers.CombineHashCodes(DatabaseName.GetHashCode(), DatabaseRole?.GetHashCode() ?? 0);

        /// <inheritdoc/>
        public override bool Equals(object obj) =>
            Equals(obj as SessionPoolSegmentKey);

        /// <summary> 
        /// Determines whether <paramref name="other"/> is equal to this instance.
        /// </summary>
        /// <returns><c>true</c> if the specified object is equal to this instance; otherwise <c>false</c>.</returns>
        public bool Equals(SessionPoolSegmentKey other) =>
            (other is null) ? false : DatabaseName == other.DatabaseName && DatabaseRole == other.DatabaseRole;
    }
}
