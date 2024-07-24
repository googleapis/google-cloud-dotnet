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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>DataScan</c> resource.</summary>
    public sealed partial class DataScanName : gax::IResourceName, sys::IEquatable<DataScanName>
    {
        /// <summary>The possible contents of <see cref="DataScanName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>.
            /// </summary>
            ProjectLocationDataScan = 1,
        }

        private static gax::PathTemplate s_projectLocationDataScan = new gax::PathTemplate("projects/{project}/locations/{location}/dataScans/{dataScan}");

        /// <summary>Creates a <see cref="DataScanName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataScanName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DataScanName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataScanName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataScanName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataScanName"/> constructed from the provided ids.</returns>
        public static DataScanName FromProjectLocationDataScan(string projectId, string locationId, string dataScanId) =>
            new DataScanName(ResourceNameType.ProjectLocationDataScan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataScanId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataScanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataScanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataScanId) =>
            FormatProjectLocationDataScan(projectId, locationId, dataScanId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataScanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataScanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>.
        /// </returns>
        public static string FormatProjectLocationDataScan(string projectId, string locationId, string dataScanId) =>
            s_projectLocationDataScan.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataScanName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dataScans/{dataScan}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataScanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataScanName"/> if successful.</returns>
        public static DataScanName Parse(string dataScanName) => Parse(dataScanName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataScanName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dataScans/{dataScan}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataScanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataScanName"/> if successful.</returns>
        public static DataScanName Parse(string dataScanName, bool allowUnparsed) =>
            TryParse(dataScanName, allowUnparsed, out DataScanName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataScanName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dataScans/{dataScan}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dataScanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataScanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataScanName, out DataScanName result) => TryParse(dataScanName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataScanName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/dataScans/{dataScan}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataScanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataScanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataScanName, bool allowUnparsed, out DataScanName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataScanName, nameof(dataScanName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataScan.TryParseName(dataScanName, out resourceName))
            {
                result = FromProjectLocationDataScan(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataScanName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataScanName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataScanId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataScanId = dataScanId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataScanName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        public DataScanName(string projectId, string locationId, string dataScanId) : this(ResourceNameType.ProjectLocationDataScan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataScanId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)))
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
        /// The <c>DataScan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataScanId { get; }

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
                case ResourceNameType.ProjectLocationDataScan: return s_projectLocationDataScan.Expand(ProjectId, LocationId, DataScanId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataScanName);

        /// <inheritdoc/>
        public bool Equals(DataScanName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataScanName a, DataScanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataScanName a, DataScanName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataScanJob</c> resource.</summary>
    public sealed partial class DataScanJobName : gax::IResourceName, sys::IEquatable<DataScanJobName>
    {
        /// <summary>The possible contents of <see cref="DataScanJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>
            /// .
            /// </summary>
            ProjectLocationDataScanJob = 1,
        }

        private static gax::PathTemplate s_projectLocationDataScanJob = new gax::PathTemplate("projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}");

        /// <summary>Creates a <see cref="DataScanJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataScanJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataScanJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataScanJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataScanJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataScanJobName"/> constructed from the provided ids.</returns>
        public static DataScanJobName FromProjectLocationDataScanJob(string projectId, string locationId, string dataScanId, string jobId) =>
            new DataScanJobName(ResourceNameType.ProjectLocationDataScanJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataScanId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataScanJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataScanJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataScanId, string jobId) =>
            FormatProjectLocationDataScanJob(projectId, locationId, dataScanId, jobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataScanJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataScanJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>.
        /// </returns>
        public static string FormatProjectLocationDataScanJob(string projectId, string locationId, string dataScanId, string jobId) =>
            s_projectLocationDataScanJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataScanJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataScanJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataScanJobName"/> if successful.</returns>
        public static DataScanJobName Parse(string dataScanJobName) => Parse(dataScanJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataScanJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataScanJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataScanJobName"/> if successful.</returns>
        public static DataScanJobName Parse(string dataScanJobName, bool allowUnparsed) =>
            TryParse(dataScanJobName, allowUnparsed, out DataScanJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataScanJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataScanJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataScanJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataScanJobName, out DataScanJobName result) =>
            TryParse(dataScanJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataScanJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataScanJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataScanJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataScanJobName, bool allowUnparsed, out DataScanJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataScanJobName, nameof(dataScanJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataScanJob.TryParseName(dataScanJobName, out resourceName))
            {
                result = FromProjectLocationDataScanJob(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataScanJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataScanJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataScanId = null, string jobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataScanId = dataScanId;
            JobId = jobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataScanJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataScans/{dataScan}/jobs/{job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataScanId">The <c>DataScan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        public DataScanJobName(string projectId, string locationId, string dataScanId, string jobId) : this(ResourceNameType.ProjectLocationDataScanJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataScanId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)))
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
        /// The <c>DataScan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataScanId { get; }

        /// <summary>
        /// The <c>Job</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string JobId { get; }

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
                case ResourceNameType.ProjectLocationDataScanJob: return s_projectLocationDataScanJob.Expand(ProjectId, LocationId, DataScanId, JobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataScanJobName);

        /// <inheritdoc/>
        public bool Equals(DataScanJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataScanJobName a, DataScanJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataScanJobName a, DataScanJobName b) => !(a == b);
    }

    public partial class CreateDataScanRequest
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

    public partial class DeleteDataScanRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataScanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataScanName DataScanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataScanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataScanRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataScanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataScanName DataScanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataScanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataScansRequest
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

    public partial class RunDataScanRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataScanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataScanName DataScanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataScanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataScanJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataScanJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataScanJobName DataScanJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataScanJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataScanJobsRequest
    {
        /// <summary>
        /// <see cref="DataScanName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataScanName ParentAsDataScanName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataScanName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DataScan
    {
        /// <summary>
        /// <see cref="gcdv::DataScanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataScanName DataScanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataScanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataScanJob
    {
        /// <summary>
        /// <see cref="gcdv::DataScanJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataScanJobName DataScanJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataScanJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
