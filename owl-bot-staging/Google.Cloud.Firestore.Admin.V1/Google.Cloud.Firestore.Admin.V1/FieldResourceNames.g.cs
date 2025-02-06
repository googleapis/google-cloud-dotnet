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
using gax = Google.Api.Gax;
using gcfav = Google.Cloud.Firestore.Admin.V1;
using sys = System;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>Resource name for the <c>Field</c> resource.</summary>
    public sealed partial class FieldName : gax::IResourceName, sys::IEquatable<FieldName>
    {
        /// <summary>The possible contents of <see cref="FieldName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>.
            /// </summary>
            ProjectDatabaseCollectionField = 1,
        }

        private static gax::PathTemplate s_projectDatabaseCollectionField = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}");

        /// <summary>Creates a <see cref="FieldName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FieldName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FieldName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FieldName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FieldName"/> with the pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FieldName"/> constructed from the provided ids.</returns>
        public static FieldName FromProjectDatabaseCollectionField(string projectId, string databaseId, string collectionId, string fieldId) =>
            new FieldName(ResourceNameType.ProjectDatabaseCollectionField, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), fieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldId, nameof(fieldId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FieldName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FieldName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>.
        /// </returns>
        public static string Format(string projectId, string databaseId, string collectionId, string fieldId) =>
            FormatProjectDatabaseCollectionField(projectId, databaseId, collectionId, fieldId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FieldName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FieldName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>.
        /// </returns>
        public static string FormatProjectDatabaseCollectionField(string projectId, string databaseId, string collectionId, string fieldId) =>
            s_projectDatabaseCollectionField.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fieldId, nameof(fieldId)));

        /// <summary>Parses the given resource name string into a new <see cref="FieldName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FieldName"/> if successful.</returns>
        public static FieldName Parse(string fieldName) => Parse(fieldName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FieldName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FieldName"/> if successful.</returns>
        public static FieldName Parse(string fieldName, bool allowUnparsed) =>
            TryParse(fieldName, allowUnparsed, out FieldName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fieldName, out FieldName result) => TryParse(fieldName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FieldName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fieldName, bool allowUnparsed, out FieldName result)
        {
            gax::GaxPreconditions.CheckNotNull(fieldName, nameof(fieldName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatabaseCollectionField.TryParseName(fieldName, out resourceName))
            {
                result = FromProjectDatabaseCollectionField(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fieldName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FieldName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string databaseId = null, string fieldId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DatabaseId = databaseId;
            FieldId = fieldId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FieldName"/> class from the component parts of pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/fields/{field}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        public FieldName(string projectId, string databaseId, string collectionId, string fieldId) : this(ResourceNameType.ProjectDatabaseCollectionField, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), fieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldId, nameof(fieldId)))
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
        /// The <c>Field</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FieldId { get; }

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
                case ResourceNameType.ProjectDatabaseCollectionField: return s_projectDatabaseCollectionField.Expand(ProjectId, DatabaseId, CollectionId, FieldId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FieldName);

        /// <inheritdoc/>
        public bool Equals(FieldName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FieldName a, FieldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FieldName a, FieldName b) => !(a == b);
    }

    public partial class Field
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
}
