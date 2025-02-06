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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>DataLabelingJob</c> resource.</summary>
    public sealed partial class DataLabelingJobName : gax::IResourceName, sys::IEquatable<DataLabelingJobName>
    {
        /// <summary>The possible contents of <see cref="DataLabelingJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>.
            /// </summary>
            ProjectLocationDataLabelingJob = 1,
        }

        private static gax::PathTemplate s_projectLocationDataLabelingJob = new gax::PathTemplate("projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}");

        /// <summary>Creates a <see cref="DataLabelingJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataLabelingJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataLabelingJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataLabelingJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataLabelingJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLabelingJobId">The <c>DataLabelingJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataLabelingJobName"/> constructed from the provided ids.</returns>
        public static DataLabelingJobName FromProjectLocationDataLabelingJob(string projectId, string locationId, string dataLabelingJobId) =>
            new DataLabelingJobName(ResourceNameType.ProjectLocationDataLabelingJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataLabelingJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataLabelingJobId, nameof(dataLabelingJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataLabelingJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLabelingJobId">The <c>DataLabelingJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataLabelingJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataLabelingJobId) =>
            FormatProjectLocationDataLabelingJob(projectId, locationId, dataLabelingJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataLabelingJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLabelingJobId">The <c>DataLabelingJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataLabelingJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>.
        /// </returns>
        public static string FormatProjectLocationDataLabelingJob(string projectId, string locationId, string dataLabelingJobId) =>
            s_projectLocationDataLabelingJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataLabelingJobId, nameof(dataLabelingJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataLabelingJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataLabelingJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataLabelingJobName"/> if successful.</returns>
        public static DataLabelingJobName Parse(string dataLabelingJobName) => Parse(dataLabelingJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataLabelingJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataLabelingJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataLabelingJobName"/> if successful.</returns>
        public static DataLabelingJobName Parse(string dataLabelingJobName, bool allowUnparsed) =>
            TryParse(dataLabelingJobName, allowUnparsed, out DataLabelingJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataLabelingJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataLabelingJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataLabelingJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataLabelingJobName, out DataLabelingJobName result) =>
            TryParse(dataLabelingJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataLabelingJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataLabelingJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataLabelingJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataLabelingJobName, bool allowUnparsed, out DataLabelingJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataLabelingJobName, nameof(dataLabelingJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataLabelingJob.TryParseName(dataLabelingJobName, out resourceName))
            {
                result = FromProjectLocationDataLabelingJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataLabelingJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataLabelingJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataLabelingJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataLabelingJobId = dataLabelingJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataLabelingJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLabelingJobId">The <c>DataLabelingJob</c> ID. Must not be <c>null</c> or empty.</param>
        public DataLabelingJobName(string projectId, string locationId, string dataLabelingJobId) : this(ResourceNameType.ProjectLocationDataLabelingJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataLabelingJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataLabelingJobId, nameof(dataLabelingJobId)))
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
        /// The <c>DataLabelingJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataLabelingJobId { get; }

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
                case ResourceNameType.ProjectLocationDataLabelingJob: return s_projectLocationDataLabelingJob.Expand(ProjectId, LocationId, DataLabelingJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataLabelingJobName);

        /// <inheritdoc/>
        public bool Equals(DataLabelingJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataLabelingJobName a, DataLabelingJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataLabelingJobName a, DataLabelingJobName b) => !(a == b);
    }

    public partial class DataLabelingJob
    {
        /// <summary>
        /// <see cref="gcav::DataLabelingJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DataLabelingJobName DataLabelingJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DataLabelingJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Datasets"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DatasetName> DatasetsAsDatasetNames
        {
            get => new gax::ResourceNameList<DatasetName>(Datasets, s => string.IsNullOrEmpty(s) ? null : DatasetName.Parse(s, allowUnparsed: true));
        }
    }
}
