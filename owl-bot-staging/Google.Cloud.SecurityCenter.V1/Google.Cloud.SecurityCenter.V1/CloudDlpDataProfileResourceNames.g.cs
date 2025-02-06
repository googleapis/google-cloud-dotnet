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
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>TableDataProfile</c> resource.</summary>
    public sealed partial class TableDataProfileName : gax::IResourceName, sys::IEquatable<TableDataProfileName>
    {
        /// <summary>The possible contents of <see cref="TableDataProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/tableProfiles/{table_profile}</c>.</summary>
            ProjectTableProfile = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c>
            /// .
            /// </summary>
            ProjectLocationTableProfile = 2,
        }

        private static gax::PathTemplate s_projectTableProfile = new gax::PathTemplate("projects/{project}/tableProfiles/{table_profile}");

        private static gax::PathTemplate s_projectLocationTableProfile = new gax::PathTemplate("projects/{project}/locations/{location}/tableProfiles/{table_profile}");

        /// <summary>Creates a <see cref="TableDataProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TableDataProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TableDataProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TableDataProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TableDataProfileName"/> with the pattern
        /// <c>projects/{project}/tableProfiles/{table_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableProfileId">The <c>TableProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TableDataProfileName"/> constructed from the provided ids.</returns>
        public static TableDataProfileName FromProjectTableProfile(string projectId, string tableProfileId) =>
            new TableDataProfileName(ResourceNameType.ProjectTableProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tableProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableProfileId, nameof(tableProfileId)));

        /// <summary>
        /// Creates a <see cref="TableDataProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableProfileId">The <c>TableProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TableDataProfileName"/> constructed from the provided ids.</returns>
        public static TableDataProfileName FromProjectLocationTableProfile(string projectId, string locationId, string tableProfileId) =>
            new TableDataProfileName(ResourceNameType.ProjectLocationTableProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tableProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableProfileId, nameof(tableProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableDataProfileName"/> with pattern
        /// <c>projects/{project}/tableProfiles/{table_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableProfileId">The <c>TableProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableDataProfileName"/> with pattern
        /// <c>projects/{project}/tableProfiles/{table_profile}</c>.
        /// </returns>
        public static string Format(string projectId, string tableProfileId) =>
            FormatProjectTableProfile(projectId, tableProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableDataProfileName"/> with pattern
        /// <c>projects/{project}/tableProfiles/{table_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableProfileId">The <c>TableProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableDataProfileName"/> with pattern
        /// <c>projects/{project}/tableProfiles/{table_profile}</c>.
        /// </returns>
        public static string FormatProjectTableProfile(string projectId, string tableProfileId) =>
            s_projectTableProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableProfileId, nameof(tableProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableDataProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableProfileId">The <c>TableProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableDataProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationTableProfile(string projectId, string locationId, string tableProfileId) =>
            s_projectLocationTableProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableProfileId, nameof(tableProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TableDataProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tableProfiles/{table_profile}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tableDataProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableDataProfileName"/> if successful.</returns>
        public static TableDataProfileName Parse(string tableDataProfileName) => Parse(tableDataProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TableDataProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tableProfiles/{table_profile}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableDataProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TableDataProfileName"/> if successful.</returns>
        public static TableDataProfileName Parse(string tableDataProfileName, bool allowUnparsed) =>
            TryParse(tableDataProfileName, allowUnparsed, out TableDataProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableDataProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tableProfiles/{table_profile}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tableDataProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableDataProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableDataProfileName, out TableDataProfileName result) =>
            TryParse(tableDataProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableDataProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tableProfiles/{table_profile}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tableProfiles/{table_profile}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableDataProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableDataProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableDataProfileName, bool allowUnparsed, out TableDataProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(tableDataProfileName, nameof(tableDataProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTableProfile.TryParseName(tableDataProfileName, out resourceName))
            {
                result = FromProjectTableProfile(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationTableProfile.TryParseName(tableDataProfileName, out resourceName))
            {
                result = FromProjectLocationTableProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tableDataProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TableDataProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tableProfileId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TableProfileId = tableProfileId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TableDataProfileName"/> class from the component parts of pattern
        /// <c>projects/{project}/tableProfiles/{table_profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableProfileId">The <c>TableProfile</c> ID. Must not be <c>null</c> or empty.</param>
        public TableDataProfileName(string projectId, string tableProfileId) : this(ResourceNameType.ProjectTableProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tableProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableProfileId, nameof(tableProfileId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TableProfile</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string TableProfileId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTableProfile: return s_projectTableProfile.Expand(ProjectId, TableProfileId);
                case ResourceNameType.ProjectLocationTableProfile: return s_projectLocationTableProfile.Expand(ProjectId, LocationId, TableProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TableDataProfileName);

        /// <inheritdoc/>
        public bool Equals(TableDataProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TableDataProfileName a, TableDataProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TableDataProfileName a, TableDataProfileName b) => !(a == b);
    }

    public partial class CloudDlpDataProfile
    {
        /// <summary>
        /// <see cref="TableDataProfileName"/>-typed view over the <see cref="DataProfile"/> resource name property.
        /// </summary>
        public TableDataProfileName DataProfileAsTableDataProfileName
        {
            get => string.IsNullOrEmpty(DataProfile) ? null : TableDataProfileName.Parse(DataProfile, allowUnparsed: true);
            set => DataProfile = value?.ToString() ?? "";
        }
    }
}
