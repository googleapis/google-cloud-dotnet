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
    /// <summary>Resource name for the <c>DlpJob</c> resource.</summary>
    public sealed partial class DlpJobName : gax::IResourceName, sys::IEquatable<DlpJobName>
    {
        /// <summary>The possible contents of <see cref="DlpJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/dlpJobs/{dlp_job}</c>.</summary>
            ProjectDlpJob = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
            /// </summary>
            ProjectLocationDlpJob = 2,
        }

        private static gax::PathTemplate s_projectDlpJob = new gax::PathTemplate("projects/{project}/dlpJobs/{dlp_job}");

        private static gax::PathTemplate s_projectLocationDlpJob = new gax::PathTemplate("projects/{project}/locations/{location}/dlpJobs/{dlp_job}");

        /// <summary>Creates a <see cref="DlpJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DlpJobName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DlpJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DlpJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DlpJobName"/> with the pattern <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DlpJobName"/> constructed from the provided ids.</returns>
        public static DlpJobName FromProjectDlpJob(string projectId, string dlpJobId) =>
            new DlpJobName(ResourceNameType.ProjectDlpJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dlpJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Creates a <see cref="DlpJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DlpJobName"/> constructed from the provided ids.</returns>
        public static DlpJobName FromProjectLocationDlpJob(string projectId, string locationId, string dlpJobId) =>
            new DlpJobName(ResourceNameType.ProjectLocationDlpJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dlpJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </returns>
        public static string Format(string projectId, string dlpJobId) => FormatProjectDlpJob(projectId, dlpJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </returns>
        public static string FormatProjectDlpJob(string projectId, string dlpJobId) =>
            s_projectDlpJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
        /// </returns>
        public static string FormatProjectLocationDlpJob(string projectId, string locationId, string dlpJobId) =>
            s_projectLocationDlpJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="DlpJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName) => Parse(dlpJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DlpJobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName, bool allowUnparsed) =>
            TryParse(dlpJobName, allowUnparsed, out DlpJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DlpJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, out DlpJobName result) => TryParse(dlpJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DlpJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DlpJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, bool allowUnparsed, out DlpJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDlpJob.TryParseName(dlpJobName, out resourceName))
            {
                result = FromProjectDlpJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationDlpJob.TryParseName(dlpJobName, out resourceName))
            {
                result = FromProjectLocationDlpJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dlpJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DlpJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dlpJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DlpJobId = dlpJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DlpJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        public DlpJobName(string projectId, string dlpJobId) : this(ResourceNameType.ProjectDlpJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dlpJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)))
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
        /// The <c>DlpJob</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DlpJobId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectDlpJob: return s_projectDlpJob.Expand(ProjectId, DlpJobId);
                case ResourceNameType.ProjectLocationDlpJob: return s_projectLocationDlpJob.Expand(ProjectId, LocationId, DlpJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DlpJobName);

        /// <inheritdoc/>
        public bool Equals(DlpJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DlpJobName a, DlpJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DlpJobName a, DlpJobName b) => !(a == b);
    }

    public partial class CloudDlpInspection
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="InspectJob"/> resource name property.
        /// </summary>
        public DlpJobName InspectJobAsDlpJobName
        {
            get => string.IsNullOrEmpty(InspectJob) ? null : DlpJobName.Parse(InspectJob, allowUnparsed: true);
            set => InspectJob = value?.ToString() ?? "";
        }
    }
}
