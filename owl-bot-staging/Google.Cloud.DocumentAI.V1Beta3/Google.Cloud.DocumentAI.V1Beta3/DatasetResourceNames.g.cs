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
using gcdv = Google.Cloud.DocumentAI.V1Beta3;
using sys = System;

namespace Google.Cloud.DocumentAI.V1Beta3
{
    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>
            /// .
            /// </summary>
            ProjectLocationProcessor = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessor = new gax::PathTemplate("projects/{project}/locations/{location}/processors/{processor}/dataset");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            new DatasetName(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorId) =>
            FormatProjectLocationProcessor(projectId, locationId, processorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>.
        /// </returns>
        public static string FormatProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            s_projectLocationProcessor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}/dataset</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}/dataset</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}/dataset</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}/dataset</c></description>
        /// </item>
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
            if (s_projectLocationProcessor.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectLocationProcessor(resourceName[0], resourceName[1], resourceName[2]);
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

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorId = processorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string locationId, string processorId) : this(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)))
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
        /// The <c>Processor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessorId { get; }

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
                case ResourceNameType.ProjectLocationProcessor: return s_projectLocationProcessor.Expand(ProjectId, LocationId, ProcessorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DatasetSchema</c> resource.</summary>
    public sealed partial class DatasetSchemaName : gax::IResourceName, sys::IEquatable<DatasetSchemaName>
    {
        /// <summary>The possible contents of <see cref="DatasetSchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>.
            /// </summary>
            ProjectLocationProcessor = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessor = new gax::PathTemplate("projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema");

        /// <summary>Creates a <see cref="DatasetSchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetSchemaName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetSchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetSchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetSchemaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetSchemaName"/> constructed from the provided ids.</returns>
        public static DatasetSchemaName FromProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            new DatasetSchemaName(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorId) =>
            FormatProjectLocationProcessor(projectId, locationId, processorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>.
        /// </returns>
        public static string FormatProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            s_projectLocationProcessor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="datasetSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetSchemaName"/> if successful.</returns>
        public static DatasetSchemaName Parse(string datasetSchemaName) => Parse(datasetSchemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetSchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetSchemaName"/> if successful.</returns>
        public static DatasetSchemaName Parse(string datasetSchemaName, bool allowUnparsed) =>
            TryParse(datasetSchemaName, allowUnparsed, out DatasetSchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="datasetSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetSchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetSchemaName, out DatasetSchemaName result) =>
            TryParse(datasetSchemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetSchemaName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetSchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetSchemaName, bool allowUnparsed, out DatasetSchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetSchemaName, nameof(datasetSchemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessor.TryParseName(datasetSchemaName, out resourceName))
            {
                result = FromProjectLocationProcessor(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetSchemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetSchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorId = processorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetSchemaName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetSchemaName(string projectId, string locationId, string processorId) : this(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)))
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
        /// The <c>Processor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessorId { get; }

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
                case ResourceNameType.ProjectLocationProcessor: return s_projectLocationProcessor.Expand(ProjectId, LocationId, ProcessorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetSchemaName);

        /// <inheritdoc/>
        public bool Equals(DatasetSchemaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetSchemaName a, DatasetSchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetSchemaName a, DatasetSchemaName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Schema</c> resource.</summary>
    public sealed partial class SchemaName : gax::IResourceName, sys::IEquatable<SchemaName>
    {
        /// <summary>The possible contents of <see cref="SchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/schemas/{schema}</c>.
            /// </summary>
            ProjectLocationSchema = 1,
        }

        private static gax::PathTemplate s_projectLocationSchema = new gax::PathTemplate("projects/{project}/locations/{location}/schemas/{schema}");

        /// <summary>Creates a <see cref="SchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SchemaName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SchemaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SchemaName"/> constructed from the provided ids.</returns>
        public static SchemaName FromProjectLocationSchema(string projectId, string locationId, string schemaId) =>
            new SchemaName(ResourceNameType.ProjectLocationSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/schemas/{schema}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string schemaId) =>
            FormatProjectLocationSchema(projectId, locationId, schemaId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/schemas/{schema}</c>.
        /// </returns>
        public static string FormatProjectLocationSchema(string projectId, string locationId, string schemaId) =>
            s_projectLocationSchema.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>Parses the given resource name string into a new <see cref="SchemaName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/schemas/{schema}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SchemaName"/> if successful.</returns>
        public static SchemaName Parse(string schemaName) => Parse(schemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SchemaName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/schemas/{schema}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SchemaName"/> if successful.</returns>
        public static SchemaName Parse(string schemaName, bool allowUnparsed) =>
            TryParse(schemaName, allowUnparsed, out SchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/schemas/{schema}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string schemaName, out SchemaName result) => TryParse(schemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/schemas/{schema}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string schemaName, bool allowUnparsed, out SchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(schemaName, nameof(schemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSchema.TryParseName(schemaName, out resourceName))
            {
                result = FromProjectLocationSchema(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(schemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string schemaId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SchemaId = schemaId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SchemaName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/schemas/{schema}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        public SchemaName(string projectId, string locationId, string schemaId) : this(ResourceNameType.ProjectLocationSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)))
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

        /// <summary>
        /// The <c>Schema</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SchemaId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSchema: return s_projectLocationSchema.Expand(ProjectId, LocationId, SchemaId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SchemaName);

        /// <inheritdoc/>
        public bool Equals(SchemaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SchemaName a, SchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SchemaName a, SchemaName b) => !(a == b);
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

        public partial class Types
        {
            public partial class DocumentWarehouseConfig
            {
                /// <summary>
                /// <see cref="SchemaName"/>-typed view over the <see cref="Schema"/> resource name property.
                /// </summary>
                public SchemaName SchemaAsSchemaName
                {
                    get => string.IsNullOrEmpty(Schema) ? null : SchemaName.Parse(Schema, allowUnparsed: true);
                    set => Schema = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class DatasetSchema
    {
        /// <summary>
        /// <see cref="gcdv::DatasetSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetSchemaName DatasetSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
