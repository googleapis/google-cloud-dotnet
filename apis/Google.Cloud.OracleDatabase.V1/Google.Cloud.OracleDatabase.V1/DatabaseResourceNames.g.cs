// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>Database</c> resource.</summary>
    public sealed partial class DatabaseName : gax::IResourceName, sys::IEquatable<DatabaseName>
    {
        /// <summary>The possible contents of <see cref="DatabaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/databases/{database}</c>.
            /// </summary>
            ProjectLocationDatabase = 1,
        }

        private static gax::PathTemplate s_projectLocationDatabase = new gax::PathTemplate("projects/{project}/locations/{location}/databases/{database}");

        /// <summary>Creates a <see cref="DatabaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatabaseName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DatabaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatabaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatabaseName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatabaseName"/> constructed from the provided ids.</returns>
        public static DatabaseName FromProjectLocationDatabase(string projectId, string locationId, string databaseId) =>
            new DatabaseName(ResourceNameType.ProjectLocationDatabase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databases/{database}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string databaseId) =>
            FormatProjectLocationDatabase(projectId, locationId, databaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databases/{database}</c>.
        /// </returns>
        public static string FormatProjectLocationDatabase(string projectId, string locationId, string databaseId) =>
            s_projectLocationDatabase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatabaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/databases/{database}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName) => Parse(databaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/databases/{database}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName, bool allowUnparsed) =>
            TryParse(databaseName, allowUnparsed, out DatabaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/databases/{database}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, out DatabaseName result) => TryParse(databaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/databases/{database}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, bool allowUnparsed, out DatabaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatabase.TryParseName(databaseName, out resourceName))
            {
                result = FromProjectLocationDatabase(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(databaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatabaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatabaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/databases/{database}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        public DatabaseName(string projectId, string locationId, string databaseId) : this(ResourceNameType.ProjectLocationDatabase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Database</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDatabase: return s_projectLocationDatabase.Expand(ProjectId, LocationId, DatabaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatabaseName);

        /// <inheritdoc/>
        public bool Equals(DatabaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatabaseName a, DatabaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatabaseName a, DatabaseName b) => !(a == b);
    }

    public partial class Database
    {
        /// <summary>
        /// <see cref="gcov::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcov::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
