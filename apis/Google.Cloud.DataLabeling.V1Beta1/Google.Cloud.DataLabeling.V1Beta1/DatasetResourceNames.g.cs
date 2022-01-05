// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DataLabeling.V1Beta1;
using sys = System;

namespace Google.Cloud.DataLabeling.V1Beta1
{
    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/datasets/{dataset}</c>.</summary>
            ProjectDataset = 1,
        }

        private static gax::PathTemplate s_projectDataset = new gax::PathTemplate("projects/{project}/datasets/{dataset}");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectDataset(string projectId, string datasetId) =>
            new DatasetName(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId) => FormatProjectDataset(projectId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectDataset(string projectId, string datasetId) =>
            s_projectDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName) => Parse(datasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName, bool allowUnparsed) =>
            TryParse(datasetName, allowUnparsed, out DatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result) => TryParse(datasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, bool allowUnparsed, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDataset.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectDataset(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string datasetId) : this(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectDataset: return s_projectDataset.Expand(ProjectId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataItem</c> resource.</summary>
    public sealed partial class DataItemName : gax::IResourceName, sys::IEquatable<DataItemName>
    {
        /// <summary>The possible contents of <see cref="DataItemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>.
            /// </summary>
            ProjectDatasetDataItem = 1,
        }

        private static gax::PathTemplate s_projectDatasetDataItem = new gax::PathTemplate("projects/{project}/datasets/{dataset}/dataItems/{data_item}");

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
        /// <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataItemName"/> constructed from the provided ids.</returns>
        public static DataItemName FromProjectDatasetDataItem(string projectId, string datasetId, string dataItemId) =>
            new DataItemName(ResourceNameType.ProjectDatasetDataItem, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), dataItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string dataItemId) =>
            FormatProjectDatasetDataItem(projectId, datasetId, dataItemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataItemName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>.
        /// </returns>
        public static string FormatProjectDatasetDataItem(string projectId, string datasetId, string dataItemId) =>
            s_projectDatasetDataItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataItemName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c></description></item>
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
        /// <item><description><c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c></description></item>
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
        /// <item><description><c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c></description></item>
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
        /// <item><description><c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c></description></item>
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
            if (s_projectDatasetDataItem.TryParseName(dataItemName, out resourceName))
            {
                result = FromProjectDatasetDataItem(resourceName[0], resourceName[1], resourceName[2]);
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

        private DataItemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataItemId = null, string datasetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataItemId = dataItemId;
            DatasetId = datasetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataItemName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/dataItems/{data_item}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataItemId">The <c>DataItem</c> ID. Must not be <c>null</c> or empty.</param>
        public DataItemName(string projectId, string datasetId, string dataItemId) : this(ResourceNameType.ProjectDatasetDataItem, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), dataItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataItemId, nameof(dataItemId)))
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
                case ResourceNameType.ProjectDatasetDataItem: return s_projectDatasetDataItem.Expand(ProjectId, DatasetId, DataItemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataItemName);

        /// <inheritdoc/>
        public bool Equals(DataItemName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DataItemName a, DataItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DataItemName a, DataItemName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AnnotatedDataset</c> resource.</summary>
    public sealed partial class AnnotatedDatasetName : gax::IResourceName, sys::IEquatable<AnnotatedDatasetName>
    {
        /// <summary>The possible contents of <see cref="AnnotatedDatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>.
            /// </summary>
            ProjectDatasetAnnotatedDataset = 1,
        }

        private static gax::PathTemplate s_projectDatasetAnnotatedDataset = new gax::PathTemplate("projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}");

        /// <summary>Creates a <see cref="AnnotatedDatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnnotatedDatasetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnnotatedDatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnnotatedDatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnnotatedDatasetName"/> with the pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnnotatedDatasetName"/> constructed from the provided ids.</returns>
        public static AnnotatedDatasetName FromProjectDatasetAnnotatedDataset(string projectId, string datasetId, string annotatedDatasetId) =>
            new AnnotatedDatasetName(ResourceNameType.ProjectDatasetAnnotatedDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), annotatedDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDatasetId, nameof(annotatedDatasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotatedDatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotatedDatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string annotatedDatasetId) =>
            FormatProjectDatasetAnnotatedDataset(projectId, datasetId, annotatedDatasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotatedDatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotatedDatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>.
        /// </returns>
        public static string FormatProjectDatasetAnnotatedDataset(string projectId, string datasetId, string annotatedDatasetId) =>
            s_projectDatasetAnnotatedDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDatasetId, nameof(annotatedDatasetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotatedDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="annotatedDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnnotatedDatasetName"/> if successful.</returns>
        public static AnnotatedDatasetName Parse(string annotatedDatasetName) => Parse(annotatedDatasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotatedDatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotatedDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnnotatedDatasetName"/> if successful.</returns>
        public static AnnotatedDatasetName Parse(string annotatedDatasetName, bool allowUnparsed) =>
            TryParse(annotatedDatasetName, allowUnparsed, out AnnotatedDatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotatedDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="annotatedDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotatedDatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotatedDatasetName, out AnnotatedDatasetName result) =>
            TryParse(annotatedDatasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotatedDatasetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotatedDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotatedDatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotatedDatasetName, bool allowUnparsed, out AnnotatedDatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(annotatedDatasetName, nameof(annotatedDatasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatasetAnnotatedDataset.TryParseName(annotatedDatasetName, out resourceName))
            {
                result = FromProjectDatasetAnnotatedDataset(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(annotatedDatasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnnotatedDatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotatedDatasetId = null, string datasetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotatedDatasetId = annotatedDatasetId;
            DatasetId = datasetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnnotatedDatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        public AnnotatedDatasetName(string projectId, string datasetId, string annotatedDatasetId) : this(ResourceNameType.ProjectDatasetAnnotatedDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), annotatedDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDatasetId, nameof(annotatedDatasetId)))
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
        /// The <c>AnnotatedDataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnnotatedDatasetId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectDatasetAnnotatedDataset: return s_projectDatasetAnnotatedDataset.Expand(ProjectId, DatasetId, AnnotatedDatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnnotatedDatasetName);

        /// <inheritdoc/>
        public bool Equals(AnnotatedDatasetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AnnotatedDatasetName a, AnnotatedDatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AnnotatedDatasetName a, AnnotatedDatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Example</c> resource.</summary>
    public sealed partial class ExampleName : gax::IResourceName, sys::IEquatable<ExampleName>
    {
        /// <summary>The possible contents of <see cref="ExampleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>.
            /// </summary>
            ProjectDatasetAnnotatedDatasetExample = 1,
        }

        private static gax::PathTemplate s_projectDatasetAnnotatedDatasetExample = new gax::PathTemplate("projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}");

        /// <summary>Creates a <see cref="ExampleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExampleName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExampleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExampleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExampleName"/> with the pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExampleName"/> constructed from the provided ids.</returns>
        public static ExampleName FromProjectDatasetAnnotatedDatasetExample(string projectId, string datasetId, string annotatedDatasetId, string exampleId) =>
            new ExampleName(ResourceNameType.ProjectDatasetAnnotatedDatasetExample, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), annotatedDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDatasetId, nameof(annotatedDatasetId)), exampleId: gax::GaxPreconditions.CheckNotNullOrEmpty(exampleId, nameof(exampleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string annotatedDatasetId, string exampleId) =>
            FormatProjectDatasetAnnotatedDatasetExample(projectId, datasetId, annotatedDatasetId, exampleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExampleName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>.
        /// </returns>
        public static string FormatProjectDatasetAnnotatedDatasetExample(string projectId, string datasetId, string annotatedDatasetId, string exampleId) =>
            s_projectDatasetAnnotatedDatasetExample.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDatasetId, nameof(annotatedDatasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exampleId, nameof(exampleId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExampleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExampleName"/> if successful.</returns>
        public static ExampleName Parse(string exampleName) => Parse(exampleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExampleName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExampleName"/> if successful.</returns>
        public static ExampleName Parse(string exampleName, bool allowUnparsed) =>
            TryParse(exampleName, allowUnparsed, out ExampleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExampleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExampleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exampleName, out ExampleName result) => TryParse(exampleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExampleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exampleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExampleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exampleName, bool allowUnparsed, out ExampleName result)
        {
            gax::GaxPreconditions.CheckNotNull(exampleName, nameof(exampleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatasetAnnotatedDatasetExample.TryParseName(exampleName, out resourceName))
            {
                result = FromProjectDatasetAnnotatedDatasetExample(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(exampleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExampleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotatedDatasetId = null, string datasetId = null, string exampleId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotatedDatasetId = annotatedDatasetId;
            DatasetId = datasetId;
            ExampleId = exampleId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExampleName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/annotatedDatasets/{annotated_dataset}/examples/{example}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotatedDatasetId">The <c>AnnotatedDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exampleId">The <c>Example</c> ID. Must not be <c>null</c> or empty.</param>
        public ExampleName(string projectId, string datasetId, string annotatedDatasetId, string exampleId) : this(ResourceNameType.ProjectDatasetAnnotatedDatasetExample, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), annotatedDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDatasetId, nameof(annotatedDatasetId)), exampleId: gax::GaxPreconditions.CheckNotNullOrEmpty(exampleId, nameof(exampleId)))
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
        /// The <c>AnnotatedDataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnnotatedDatasetId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Example</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExampleId { get; }

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
                case ResourceNameType.ProjectDatasetAnnotatedDatasetExample: return s_projectDatasetAnnotatedDatasetExample.Expand(ProjectId, DatasetId, AnnotatedDatasetId, ExampleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExampleName);

        /// <inheritdoc/>
        public bool Equals(ExampleName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ExampleName a, ExampleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ExampleName a, ExampleName b) => !(a == b);
    }

    public partial class Dataset
    {
        /// <summary>
        /// <see cref="gcdv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataItem
    {
        /// <summary>
        /// <see cref="gcdv::DataItemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataItemName DataItemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataItemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnnotatedDataset
    {
        /// <summary>
        /// <see cref="gcdv::AnnotatedDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnnotatedDatasetName AnnotatedDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnnotatedDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Example
    {
        /// <summary>
        /// <see cref="gcdv::ExampleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ExampleName ExampleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ExampleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
