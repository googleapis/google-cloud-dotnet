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
using gctv = Google.Cloud.Translate.V3;
using sys = System;

namespace Google.Cloud.Translate.V3
{
    /// <summary>Resource name for the <c>AdaptiveMtDataset</c> resource.</summary>
    public sealed partial class AdaptiveMtDatasetName : gax::IResourceName, sys::IEquatable<AdaptiveMtDatasetName>
    {
        /// <summary>The possible contents of <see cref="AdaptiveMtDatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>
            /// .
            /// </summary>
            ProjectLocationDataset = 1,
        }

        private static gax::PathTemplate s_projectLocationDataset = new gax::PathTemplate("projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}");

        /// <summary>Creates a <see cref="AdaptiveMtDatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdaptiveMtDatasetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdaptiveMtDatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdaptiveMtDatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdaptiveMtDatasetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdaptiveMtDatasetName"/> constructed from the provided ids.</returns>
        public static AdaptiveMtDatasetName FromProjectLocationDataset(string projectId, string locationId, string datasetId) =>
            new AdaptiveMtDatasetName(ResourceNameType.ProjectLocationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdaptiveMtDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdaptiveMtDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId) =>
            FormatProjectLocationDataset(projectId, locationId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdaptiveMtDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdaptiveMtDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectLocationDataset(string projectId, string locationId, string datasetId) =>
            s_projectLocationDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdaptiveMtDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adaptiveMtDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdaptiveMtDatasetName"/> if successful.</returns>
        public static AdaptiveMtDatasetName Parse(string adaptiveMtDatasetName) => Parse(adaptiveMtDatasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdaptiveMtDatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adaptiveMtDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdaptiveMtDatasetName"/> if successful.</returns>
        public static AdaptiveMtDatasetName Parse(string adaptiveMtDatasetName, bool allowUnparsed) =>
            TryParse(adaptiveMtDatasetName, allowUnparsed, out AdaptiveMtDatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdaptiveMtDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adaptiveMtDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdaptiveMtDatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adaptiveMtDatasetName, out AdaptiveMtDatasetName result) =>
            TryParse(adaptiveMtDatasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdaptiveMtDatasetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adaptiveMtDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdaptiveMtDatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adaptiveMtDatasetName, bool allowUnparsed, out AdaptiveMtDatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(adaptiveMtDatasetName, nameof(adaptiveMtDatasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataset.TryParseName(adaptiveMtDatasetName, out resourceName))
            {
                result = FromProjectLocationDataset(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adaptiveMtDatasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdaptiveMtDatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdaptiveMtDatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public AdaptiveMtDatasetName(string projectId, string locationId, string datasetId) : this(ResourceNameType.ProjectLocationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
                case ResourceNameType.ProjectLocationDataset: return s_projectLocationDataset.Expand(ProjectId, LocationId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdaptiveMtDatasetName);

        /// <inheritdoc/>
        public bool Equals(AdaptiveMtDatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdaptiveMtDatasetName a, AdaptiveMtDatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdaptiveMtDatasetName a, AdaptiveMtDatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AdaptiveMtFile</c> resource.</summary>
    public sealed partial class AdaptiveMtFileName : gax::IResourceName, sys::IEquatable<AdaptiveMtFileName>
    {
        /// <summary>The possible contents of <see cref="AdaptiveMtFileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>.
            /// </summary>
            ProjectLocationDatasetFile = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetFile = new gax::PathTemplate("projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}");

        /// <summary>Creates a <see cref="AdaptiveMtFileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdaptiveMtFileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdaptiveMtFileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdaptiveMtFileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdaptiveMtFileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdaptiveMtFileName"/> constructed from the provided ids.</returns>
        public static AdaptiveMtFileName FromProjectLocationDatasetFile(string projectId, string locationId, string datasetId, string fileId) =>
            new AdaptiveMtFileName(ResourceNameType.ProjectLocationDatasetFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fileId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdaptiveMtFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdaptiveMtFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string fileId) =>
            FormatProjectLocationDatasetFile(projectId, locationId, datasetId, fileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdaptiveMtFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdaptiveMtFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>.
        /// </returns>
        public static string FormatProjectLocationDatasetFile(string projectId, string locationId, string datasetId, string fileId) =>
            s_projectLocationDatasetFile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdaptiveMtFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adaptiveMtFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdaptiveMtFileName"/> if successful.</returns>
        public static AdaptiveMtFileName Parse(string adaptiveMtFileName) => Parse(adaptiveMtFileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdaptiveMtFileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adaptiveMtFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdaptiveMtFileName"/> if successful.</returns>
        public static AdaptiveMtFileName Parse(string adaptiveMtFileName, bool allowUnparsed) =>
            TryParse(adaptiveMtFileName, allowUnparsed, out AdaptiveMtFileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdaptiveMtFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adaptiveMtFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdaptiveMtFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adaptiveMtFileName, out AdaptiveMtFileName result) =>
            TryParse(adaptiveMtFileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdaptiveMtFileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adaptiveMtFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdaptiveMtFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adaptiveMtFileName, bool allowUnparsed, out AdaptiveMtFileName result)
        {
            gax::GaxPreconditions.CheckNotNull(adaptiveMtFileName, nameof(adaptiveMtFileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetFile.TryParseName(adaptiveMtFileName, out resourceName))
            {
                result = FromProjectLocationDatasetFile(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adaptiveMtFileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdaptiveMtFileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string fileId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            FileId = fileId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdaptiveMtFileName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        public AdaptiveMtFileName(string projectId, string locationId, string datasetId, string fileId) : this(ResourceNameType.ProjectLocationDatasetFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fileId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)))
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
        /// The <c>File</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FileId { get; }

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
                case ResourceNameType.ProjectLocationDatasetFile: return s_projectLocationDatasetFile.Expand(ProjectId, LocationId, DatasetId, FileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdaptiveMtFileName);

        /// <inheritdoc/>
        public bool Equals(AdaptiveMtFileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdaptiveMtFileName a, AdaptiveMtFileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdaptiveMtFileName a, AdaptiveMtFileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AdaptiveMtSentence</c> resource.</summary>
    public sealed partial class AdaptiveMtSentenceName : gax::IResourceName, sys::IEquatable<AdaptiveMtSentenceName>
    {
        /// <summary>The possible contents of <see cref="AdaptiveMtSentenceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
            /// .
            /// </summary>
            ProjectLocationDatasetFileSentence = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetFileSentence = new gax::PathTemplate("projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}");

        /// <summary>Creates a <see cref="AdaptiveMtSentenceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdaptiveMtSentenceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdaptiveMtSentenceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdaptiveMtSentenceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdaptiveMtSentenceName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sentenceId">The <c>Sentence</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdaptiveMtSentenceName"/> constructed from the provided ids.</returns>
        public static AdaptiveMtSentenceName FromProjectLocationDatasetFileSentence(string projectId, string locationId, string datasetId, string fileId, string sentenceId) =>
            new AdaptiveMtSentenceName(ResourceNameType.ProjectLocationDatasetFileSentence, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fileId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)), sentenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sentenceId, nameof(sentenceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdaptiveMtSentenceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sentenceId">The <c>Sentence</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdaptiveMtSentenceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string fileId, string sentenceId) =>
            FormatProjectLocationDatasetFileSentence(projectId, locationId, datasetId, fileId, sentenceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdaptiveMtSentenceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sentenceId">The <c>Sentence</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdaptiveMtSentenceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDatasetFileSentence(string projectId, string locationId, string datasetId, string fileId, string sentenceId) =>
            s_projectLocationDatasetFileSentence.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sentenceId, nameof(sentenceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdaptiveMtSentenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adaptiveMtSentenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdaptiveMtSentenceName"/> if successful.</returns>
        public static AdaptiveMtSentenceName Parse(string adaptiveMtSentenceName) => Parse(adaptiveMtSentenceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdaptiveMtSentenceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adaptiveMtSentenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdaptiveMtSentenceName"/> if successful.</returns>
        public static AdaptiveMtSentenceName Parse(string adaptiveMtSentenceName, bool allowUnparsed) =>
            TryParse(adaptiveMtSentenceName, allowUnparsed, out AdaptiveMtSentenceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdaptiveMtSentenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adaptiveMtSentenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdaptiveMtSentenceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adaptiveMtSentenceName, out AdaptiveMtSentenceName result) =>
            TryParse(adaptiveMtSentenceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdaptiveMtSentenceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adaptiveMtSentenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdaptiveMtSentenceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adaptiveMtSentenceName, bool allowUnparsed, out AdaptiveMtSentenceName result)
        {
            gax::GaxPreconditions.CheckNotNull(adaptiveMtSentenceName, nameof(adaptiveMtSentenceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetFileSentence.TryParseName(adaptiveMtSentenceName, out resourceName))
            {
                result = FromProjectLocationDatasetFileSentence(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adaptiveMtSentenceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdaptiveMtSentenceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string fileId = null, string locationId = null, string projectId = null, string sentenceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            FileId = fileId;
            LocationId = locationId;
            ProjectId = projectId;
            SentenceId = sentenceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdaptiveMtSentenceName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/adaptiveMtDatasets/{dataset}/adaptiveMtFiles/{file}/adaptiveMtSentences/{sentence}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fileId">The <c>File</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sentenceId">The <c>Sentence</c> ID. Must not be <c>null</c> or empty.</param>
        public AdaptiveMtSentenceName(string projectId, string locationId, string datasetId, string fileId, string sentenceId) : this(ResourceNameType.ProjectLocationDatasetFileSentence, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fileId: gax::GaxPreconditions.CheckNotNullOrEmpty(fileId, nameof(fileId)), sentenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sentenceId, nameof(sentenceId)))
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
        /// The <c>File</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FileId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Sentence</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SentenceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDatasetFileSentence: return s_projectLocationDatasetFileSentence.Expand(ProjectId, LocationId, DatasetId, FileId, SentenceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdaptiveMtSentenceName);

        /// <inheritdoc/>
        public bool Equals(AdaptiveMtSentenceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdaptiveMtSentenceName a, AdaptiveMtSentenceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdaptiveMtSentenceName a, AdaptiveMtSentenceName b) => !(a == b);
    }

    public partial class AdaptiveMtDataset
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtDatasetName AdaptiveMtDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAdaptiveMtDatasetRequest
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

    public partial class DeleteAdaptiveMtDatasetRequest
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtDatasetName AdaptiveMtDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAdaptiveMtDatasetRequest
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtDatasetName AdaptiveMtDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAdaptiveMtDatasetsRequest
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

    public partial class AdaptiveMtTranslateRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdaptiveMtDatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public AdaptiveMtDatasetName DatasetAsAdaptiveMtDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : AdaptiveMtDatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class GlossaryConfig
            {
                /// <summary>
                /// <see cref="GlossaryName"/>-typed view over the <see cref="Glossary"/> resource name property.
                /// </summary>
                public GlossaryName GlossaryAsGlossaryName
                {
                    get => string.IsNullOrEmpty(Glossary) ? null : GlossaryName.Parse(Glossary, allowUnparsed: true);
                    set => Glossary = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class AdaptiveMtFile
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtFileName AdaptiveMtFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAdaptiveMtFileRequest
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtFileName AdaptiveMtFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAdaptiveMtFileRequest
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtFileName AdaptiveMtFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportAdaptiveMtFileRequest
    {
        /// <summary>
        /// <see cref="AdaptiveMtDatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AdaptiveMtDatasetName ParentAsAdaptiveMtDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AdaptiveMtDatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListAdaptiveMtFilesRequest
    {
        /// <summary>
        /// <see cref="AdaptiveMtDatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AdaptiveMtDatasetName ParentAsAdaptiveMtDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AdaptiveMtDatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AdaptiveMtSentence
    {
        /// <summary>
        /// <see cref="gctv::AdaptiveMtSentenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::AdaptiveMtSentenceName AdaptiveMtSentenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::AdaptiveMtSentenceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAdaptiveMtSentencesRequest
    {
        /// <summary>
        /// <see cref="AdaptiveMtFileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AdaptiveMtFileName ParentAsAdaptiveMtFileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AdaptiveMtFileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
