// Copyright 2024 Google LLC
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
using gcfav = Google.Cloud.Firestore.Admin.V1;
using sys = System;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>Resource name for the <c>Location</c> resource.</summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        /// <summary>The possible contents of <see cref="LocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}</c>.</summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>Creates a <see cref="LocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LocationName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static LocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LocationName"/> with the pattern <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LocationName"/> constructed from the provided ids.</returns>
        public static LocationName FromProjectLocation(string projectId, string locationId) =>
            new LocationName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="LocationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName) => Parse(locationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocationName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName, bool allowUnparsed) =>
            TryParse(locationName, allowUnparsed, out LocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result) => TryParse(locationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, bool allowUnparsed, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(locationName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(locationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LocationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public LocationName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc/>
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CollectionGroup</c> resource.</summary>
    public sealed partial class CollectionGroupName : gax::IResourceName, sys::IEquatable<CollectionGroupName>
    {
        /// <summary>The possible contents of <see cref="CollectionGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>
            /// .
            /// </summary>
            ProjectDatabaseCollection = 1,
        }

        private static gax::PathTemplate s_projectDatabaseCollection = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection}");

        /// <summary>Creates a <see cref="CollectionGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CollectionGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CollectionGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CollectionGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CollectionGroupName"/> with the pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CollectionGroupName"/> constructed from the provided ids.</returns>
        public static CollectionGroupName FromProjectDatabaseCollection(string projectId, string databaseId, string collectionId) =>
            new CollectionGroupName(ResourceNameType.ProjectDatabaseCollection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </returns>
        public static string Format(string projectId, string databaseId, string collectionId) =>
            FormatProjectDatabaseCollection(projectId, databaseId, collectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </returns>
        public static string FormatProjectDatabaseCollection(string projectId, string databaseId, string collectionId) =>
            s_projectDatabaseCollection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectionGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CollectionGroupName"/> if successful.</returns>
        public static CollectionGroupName Parse(string collectionGroupName) => Parse(collectionGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectionGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CollectionGroupName"/> if successful.</returns>
        public static CollectionGroupName Parse(string collectionGroupName, bool allowUnparsed) =>
            TryParse(collectionGroupName, allowUnparsed, out CollectionGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionGroupName, out CollectionGroupName result) =>
            TryParse(collectionGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionGroupName, bool allowUnparsed, out CollectionGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(collectionGroupName, nameof(collectionGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatabaseCollection.TryParseName(collectionGroupName, out resourceName))
            {
                result = FromProjectDatabaseCollection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(collectionGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CollectionGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string databaseId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DatabaseId = databaseId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CollectionGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        public CollectionGroupName(string projectId, string databaseId, string collectionId) : this(ResourceNameType.ProjectDatabaseCollection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)))
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
        /// The <c>Collection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>Database</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatabaseId { get; }

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
                case ResourceNameType.ProjectDatabaseCollection: return s_projectDatabaseCollection.Expand(ProjectId, DatabaseId, CollectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CollectionGroupName);

        /// <inheritdoc/>
        public bool Equals(CollectionGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CollectionGroupName a, CollectionGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CollectionGroupName a, CollectionGroupName b) => !(a == b);
    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBackupScheduleRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatabaseName ParentAsDatabaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatabaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupScheduleRequest
    {
        /// <summary>
        /// <see cref="gcfav::BackupScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::BackupScheduleName BackupScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::BackupScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupSchedulesRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatabaseName ParentAsDatabaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatabaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupScheduleRequest
    {
        /// <summary>
        /// <see cref="gcfav::BackupScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::BackupScheduleName BackupScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::BackupScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateIndexRequest
    {
        /// <summary>
        /// <see cref="CollectionGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionGroupName ParentAsCollectionGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListIndexesRequest
    {
        /// <summary>
        /// <see cref="CollectionGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionGroupName ParentAsCollectionGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIndexRequest
    {
        /// <summary>
        /// <see cref="gcfav::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIndexRequest
    {
        /// <summary>
        /// <see cref="gcfav::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFieldRequest
    {
        /// <summary>
        /// <see cref="gcfav::FieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::FieldName FieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::FieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFieldsRequest
    {
        /// <summary>
        /// <see cref="CollectionGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionGroupName ParentAsCollectionGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ExportDocumentsRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportDocumentsRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BulkDeleteDocumentsRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupRequest
    {
        /// <summary>
        /// <see cref="gcfav::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupRequest
    {
        /// <summary>
        /// <see cref="gcfav::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestoreDatabaseRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.</summary>
        public BackupName BackupAsBackupName
        {
            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
            set => Backup = value?.ToString() ?? "";
        }
    }
}
