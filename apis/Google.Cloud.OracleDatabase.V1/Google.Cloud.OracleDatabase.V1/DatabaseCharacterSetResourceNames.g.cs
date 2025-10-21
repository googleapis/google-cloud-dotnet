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
    /// <summary>Resource name for the <c>DatabaseCharacterSet</c> resource.</summary>
    public sealed partial class DatabaseCharacterSetName : gax::IResourceName, sys::IEquatable<DatabaseCharacterSetName>
    {
        /// <summary>The possible contents of <see cref="DatabaseCharacterSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>.
            /// </summary>
            ProjectLocationDatabaseCharacterSet = 1,
        }

        private static gax::PathTemplate s_projectLocationDatabaseCharacterSet = new gax::PathTemplate("projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}");

        /// <summary>Creates a <see cref="DatabaseCharacterSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatabaseCharacterSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatabaseCharacterSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatabaseCharacterSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatabaseCharacterSetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseCharacterSetId">
        /// The <c>DatabaseCharacterSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DatabaseCharacterSetName"/> constructed from the provided ids.
        /// </returns>
        public static DatabaseCharacterSetName FromProjectLocationDatabaseCharacterSet(string projectId, string locationId, string databaseCharacterSetId) =>
            new DatabaseCharacterSetName(ResourceNameType.ProjectLocationDatabaseCharacterSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), databaseCharacterSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseCharacterSetId, nameof(databaseCharacterSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseCharacterSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseCharacterSetId">
        /// The <c>DatabaseCharacterSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseCharacterSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string databaseCharacterSetId) =>
            FormatProjectLocationDatabaseCharacterSet(projectId, locationId, databaseCharacterSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseCharacterSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseCharacterSetId">
        /// The <c>DatabaseCharacterSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseCharacterSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>.
        /// </returns>
        public static string FormatProjectLocationDatabaseCharacterSet(string projectId, string locationId, string databaseCharacterSetId) =>
            s_projectLocationDatabaseCharacterSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseCharacterSetId, nameof(databaseCharacterSetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseCharacterSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="databaseCharacterSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseCharacterSetName"/> if successful.</returns>
        public static DatabaseCharacterSetName Parse(string databaseCharacterSetName) =>
            Parse(databaseCharacterSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseCharacterSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseCharacterSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatabaseCharacterSetName"/> if successful.</returns>
        public static DatabaseCharacterSetName Parse(string databaseCharacterSetName, bool allowUnparsed) =>
            TryParse(databaseCharacterSetName, allowUnparsed, out DatabaseCharacterSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseCharacterSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="databaseCharacterSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseCharacterSetName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseCharacterSetName, out DatabaseCharacterSetName result) =>
            TryParse(databaseCharacterSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseCharacterSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseCharacterSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseCharacterSetName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseCharacterSetName, bool allowUnparsed, out DatabaseCharacterSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseCharacterSetName, nameof(databaseCharacterSetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatabaseCharacterSet.TryParseName(databaseCharacterSetName, out resourceName))
            {
                result = FromProjectLocationDatabaseCharacterSet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(databaseCharacterSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatabaseCharacterSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseCharacterSetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseCharacterSetId = databaseCharacterSetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatabaseCharacterSetName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/databaseCharacterSets/{database_character_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseCharacterSetId">
        /// The <c>DatabaseCharacterSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DatabaseCharacterSetName(string projectId, string locationId, string databaseCharacterSetId) : this(ResourceNameType.ProjectLocationDatabaseCharacterSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), databaseCharacterSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseCharacterSetId, nameof(databaseCharacterSetId)))
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
        /// The <c>DatabaseCharacterSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DatabaseCharacterSetId { get; }

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
                case ResourceNameType.ProjectLocationDatabaseCharacterSet: return s_projectLocationDatabaseCharacterSet.Expand(ProjectId, LocationId, DatabaseCharacterSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatabaseCharacterSetName);

        /// <inheritdoc/>
        public bool Equals(DatabaseCharacterSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatabaseCharacterSetName a, DatabaseCharacterSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatabaseCharacterSetName a, DatabaseCharacterSetName b) => !(a == b);
    }

    public partial class DatabaseCharacterSet
    {
        /// <summary>
        /// <see cref="gcov::DatabaseCharacterSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseCharacterSetName DatabaseCharacterSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseCharacterSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabaseCharacterSetsRequest
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
