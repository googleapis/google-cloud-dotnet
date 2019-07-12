// Copyright 2018, Google LLC
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

// This code was originally auto-generated.

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Cloud.Spanner.Common.V1
{
    /// <summary>
    /// Resource name for the 'database' resource.
    /// </summary>
    public sealed partial class DatabaseName : gax::IResourceName, sys::IEquatable<DatabaseName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/instances/{instance}/databases/{database}");

        /// <summary>
        /// Parses the given database resource name in string form into a new
        /// <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <param name="databaseName">The database resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(databaseName);
            return new DatabaseName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given database resource name in string form into a new
        /// <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="databaseName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="databaseName">The database resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DatabaseName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, out DatabaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(databaseName, out resourceName))
            {
                result = new DatabaseName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DatabaseName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The <c>instance</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DatabaseName"/>.</returns>
        public static string Format(string projectId, string instanceId, string databaseId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DatabaseName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        public DatabaseName(string projectId, string instanceId, string databaseId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, DatabaseId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DatabaseName);

        /// <inheritdoc />
        public bool Equals(DatabaseName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DatabaseName a, DatabaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DatabaseName a, DatabaseName b) => !(a == b);
    }
}
