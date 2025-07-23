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
using gcbv = Google.Cloud.BackupDR.V1;
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Resource name for the <c>DataSourceReference</c> resource.</summary>
    public sealed partial class DataSourceReferenceName : gax::IResourceName, sys::IEquatable<DataSourceReferenceName>
    {
        /// <summary>The possible contents of <see cref="DataSourceReferenceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>.
            /// </summary>
            ProjectLocationDataSourceReference = 1,
        }

        private static gax::PathTemplate s_projectLocationDataSourceReference = new gax::PathTemplate("projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}");

        /// <summary>Creates a <see cref="DataSourceReferenceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataSourceReferenceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataSourceReferenceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataSourceReferenceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataSourceReferenceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceReferenceId">
        /// The <c>DataSourceReference</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DataSourceReferenceName"/> constructed from the provided ids.
        /// </returns>
        public static DataSourceReferenceName FromProjectLocationDataSourceReference(string projectId, string locationId, string dataSourceReferenceId) =>
            new DataSourceReferenceName(ResourceNameType.ProjectLocationDataSourceReference, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataSourceReferenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceReferenceId, nameof(dataSourceReferenceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceReferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceReferenceId">
        /// The <c>DataSourceReference</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceReferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataSourceReferenceId) =>
            FormatProjectLocationDataSourceReference(projectId, locationId, dataSourceReferenceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceReferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceReferenceId">
        /// The <c>DataSourceReference</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceReferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>.
        /// </returns>
        public static string FormatProjectLocationDataSourceReference(string projectId, string locationId, string dataSourceReferenceId) =>
            s_projectLocationDataSourceReference.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceReferenceId, nameof(dataSourceReferenceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSourceReferenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceReferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSourceReferenceName"/> if successful.</returns>
        public static DataSourceReferenceName Parse(string dataSourceReferenceName) => Parse(dataSourceReferenceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSourceReferenceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceReferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataSourceReferenceName"/> if successful.</returns>
        public static DataSourceReferenceName Parse(string dataSourceReferenceName, bool allowUnparsed) =>
            TryParse(dataSourceReferenceName, allowUnparsed, out DataSourceReferenceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceReferenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceReferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceReferenceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceReferenceName, out DataSourceReferenceName result) =>
            TryParse(dataSourceReferenceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceReferenceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceReferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceReferenceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceReferenceName, bool allowUnparsed, out DataSourceReferenceName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSourceReferenceName, nameof(dataSourceReferenceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataSourceReference.TryParseName(dataSourceReferenceName, out resourceName))
            {
                result = FromProjectLocationDataSourceReference(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataSourceReferenceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataSourceReferenceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataSourceReferenceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataSourceReferenceId = dataSourceReferenceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataSourceReferenceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/dataSourceReferences/{data_source_reference}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceReferenceId">
        /// The <c>DataSourceReference</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DataSourceReferenceName(string projectId, string locationId, string dataSourceReferenceId) : this(ResourceNameType.ProjectLocationDataSourceReference, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataSourceReferenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceReferenceId, nameof(dataSourceReferenceId)))
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
        /// The <c>DataSourceReference</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DataSourceReferenceId { get; }

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
                case ResourceNameType.ProjectLocationDataSourceReference: return s_projectLocationDataSourceReference.Expand(ProjectId, LocationId, DataSourceReferenceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataSourceReferenceName);

        /// <inheritdoc/>
        public bool Equals(DataSourceReferenceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataSourceReferenceName a, DataSourceReferenceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataSourceReferenceName a, DataSourceReferenceName b) => !(a == b);
    }

    public partial class DataSourceReference
    {
        /// <summary>
        /// <see cref="gcbv::DataSourceReferenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::DataSourceReferenceName DataSourceReferenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::DataSourceReferenceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataSourceName"/>-typed view over the <see cref="DataSource"/> resource name property.
        /// </summary>
        public DataSourceName DataSourceAsDataSourceName
        {
            get => string.IsNullOrEmpty(DataSource) ? null : DataSourceName.Parse(DataSource, allowUnparsed: true);
            set => DataSource = value?.ToString() ?? "";
        }
    }

    public partial class GetDataSourceReferenceRequest
    {
        /// <summary>
        /// <see cref="gcbv::DataSourceReferenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::DataSourceReferenceName DataSourceReferenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::DataSourceReferenceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchDataSourceReferencesForResourceTypeRequest
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
