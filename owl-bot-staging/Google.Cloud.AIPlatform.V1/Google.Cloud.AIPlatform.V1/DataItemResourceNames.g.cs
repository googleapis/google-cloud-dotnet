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
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>DataItem</c> resource.</summary>
    public sealed partial class DataItemName : gax::IResourceName, sys::IEquatable<DataItemName>
    {
        /// <summary>The possible contents of <see cref="DataItemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>.
            /// </summary>
            ProjectLocationDatasetDataItem = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetDataItem = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}");

        /// <summary>Creates a <see cref="DataItemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataItemName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DataItemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataItemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataItemName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataItemName"/> constructed from the provided ids.</returns>
        public static DataItemName FromProjectLocationDatasetDataItem(string projectId, string locationId, string datasetId, string dataItemId) =>
            new DataItemName(ResourceNameType.ProjectLocationDatasetDataItem, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), dataItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string dataItemId) =>
            FormatProjectLocationDatasetDataItem(projectId, locationId, datasetId, dataItemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </returns>
        public static string FormatProjectLocationDatasetDataItem(string projectId, string locationId, string datasetId, string dataItemId) =>
            s_projectLocationDatasetDataItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataItemName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataItemName"/> if successful.</returns>
        public static DataItemName Parse(string dataItemName) => Parse(dataItemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataItemName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataItemName"/> if successful.</returns>
        public static DataItemName Parse(string dataItemName, bool allowUnparsed) =>
            TryParse(dataItemName, allowUnparsed, out DataItemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataItemName, out DataItemName result) => TryParse(dataItemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataItemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataItemName, bool allowUnparsed, out DataItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataItemName, nameof(dataItemName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetDataItem.TryParseName(dataItemName, out resourceName))
            {
                result = FromProjectLocationDatasetDataItem(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataItemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataItemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataItemId = null, string datasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataItemId = dataItemId;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataItemName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        public DataItemName(string projectId, string locationId, string datasetId, string dataItemId) : this(ResourceNameType.ProjectLocationDatasetDataItem, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), dataItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)))
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
        /// The <c>DataItem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataItemId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectLocationDatasetDataItem: return s_projectLocationDatasetDataItem.Expand(ProjectId, LocationId, DatasetId, DataItemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataItemName);

        /// <inheritdoc/>
        public bool Equals(DataItemName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataItemName a, DataItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataItemName a, DataItemName b) => !(a == b);
    }

    public partial class DataItem
    {
        /// <summary>
        /// <see cref="gcav::DataItemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DataItemName DataItemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DataItemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
