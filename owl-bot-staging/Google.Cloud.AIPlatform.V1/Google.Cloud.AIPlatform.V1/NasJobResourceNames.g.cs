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
    /// <summary>Resource name for the <c>NasJob</c> resource.</summary>
    public sealed partial class NasJobName : gax::IResourceName, sys::IEquatable<NasJobName>
    {
        /// <summary>The possible contents of <see cref="NasJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>.
            /// </summary>
            ProjectLocationNasJob = 1,
        }

        private static gax::PathTemplate s_projectLocationNasJob = new gax::PathTemplate("projects/{project}/locations/{location}/nasJobs/{nas_job}");

        /// <summary>Creates a <see cref="NasJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NasJobName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NasJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NasJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NasJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NasJobName"/> constructed from the provided ids.</returns>
        public static NasJobName FromProjectLocationNasJob(string projectId, string locationId, string nasJobId) =>
            new NasJobName(ResourceNameType.ProjectLocationNasJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nasJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(nasJobId, nameof(nasJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NasJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NasJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string nasJobId) =>
            FormatProjectLocationNasJob(projectId, locationId, nasJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NasJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NasJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>.
        /// </returns>
        public static string FormatProjectLocationNasJob(string projectId, string locationId, string nasJobId) =>
            s_projectLocationNasJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nasJobId, nameof(nasJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="NasJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="nasJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NasJobName"/> if successful.</returns>
        public static NasJobName Parse(string nasJobName) => Parse(nasJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NasJobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nasJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NasJobName"/> if successful.</returns>
        public static NasJobName Parse(string nasJobName, bool allowUnparsed) =>
            TryParse(nasJobName, allowUnparsed, out NasJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NasJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="nasJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NasJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nasJobName, out NasJobName result) => TryParse(nasJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NasJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nasJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NasJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nasJobName, bool allowUnparsed, out NasJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(nasJobName, nameof(nasJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNasJob.TryParseName(nasJobName, out resourceName))
            {
                result = FromProjectLocationNasJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nasJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NasJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string nasJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NasJobId = nasJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NasJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        public NasJobName(string projectId, string locationId, string nasJobId) : this(ResourceNameType.ProjectLocationNasJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nasJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(nasJobId, nameof(nasJobId)))
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
        /// The <c>NasJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NasJobId { get; }

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
                case ResourceNameType.ProjectLocationNasJob: return s_projectLocationNasJob.Expand(ProjectId, LocationId, NasJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NasJobName);

        /// <inheritdoc/>
        public bool Equals(NasJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NasJobName a, NasJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NasJobName a, NasJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NasTrialDetail</c> resource.</summary>
    public sealed partial class NasTrialDetailName : gax::IResourceName, sys::IEquatable<NasTrialDetailName>
    {
        /// <summary>The possible contents of <see cref="NasTrialDetailName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>.
            /// </summary>
            ProjectLocationNasJobNasTrialDetail = 1,
        }

        private static gax::PathTemplate s_projectLocationNasJobNasTrialDetail = new gax::PathTemplate("projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}");

        /// <summary>Creates a <see cref="NasTrialDetailName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NasTrialDetailName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NasTrialDetailName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NasTrialDetailName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NasTrialDetailName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasTrialDetailId">The <c>NasTrialDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NasTrialDetailName"/> constructed from the provided ids.</returns>
        public static NasTrialDetailName FromProjectLocationNasJobNasTrialDetail(string projectId, string locationId, string nasJobId, string nasTrialDetailId) =>
            new NasTrialDetailName(ResourceNameType.ProjectLocationNasJobNasTrialDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nasJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(nasJobId, nameof(nasJobId)), nasTrialDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(nasTrialDetailId, nameof(nasTrialDetailId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NasTrialDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasTrialDetailId">The <c>NasTrialDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NasTrialDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string nasJobId, string nasTrialDetailId) =>
            FormatProjectLocationNasJobNasTrialDetail(projectId, locationId, nasJobId, nasTrialDetailId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NasTrialDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasTrialDetailId">The <c>NasTrialDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NasTrialDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>.
        /// </returns>
        public static string FormatProjectLocationNasJobNasTrialDetail(string projectId, string locationId, string nasJobId, string nasTrialDetailId) =>
            s_projectLocationNasJobNasTrialDetail.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nasJobId, nameof(nasJobId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nasTrialDetailId, nameof(nasTrialDetailId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NasTrialDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nasTrialDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NasTrialDetailName"/> if successful.</returns>
        public static NasTrialDetailName Parse(string nasTrialDetailName) => Parse(nasTrialDetailName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NasTrialDetailName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nasTrialDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NasTrialDetailName"/> if successful.</returns>
        public static NasTrialDetailName Parse(string nasTrialDetailName, bool allowUnparsed) =>
            TryParse(nasTrialDetailName, allowUnparsed, out NasTrialDetailName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NasTrialDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nasTrialDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NasTrialDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nasTrialDetailName, out NasTrialDetailName result) =>
            TryParse(nasTrialDetailName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NasTrialDetailName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nasTrialDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NasTrialDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nasTrialDetailName, bool allowUnparsed, out NasTrialDetailName result)
        {
            gax::GaxPreconditions.CheckNotNull(nasTrialDetailName, nameof(nasTrialDetailName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNasJobNasTrialDetail.TryParseName(nasTrialDetailName, out resourceName))
            {
                result = FromProjectLocationNasJobNasTrialDetail(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nasTrialDetailName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NasTrialDetailName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string nasJobId = null, string nasTrialDetailId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NasJobId = nasJobId;
            NasTrialDetailId = nasTrialDetailId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NasTrialDetailName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasJobId">The <c>NasJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nasTrialDetailId">The <c>NasTrialDetail</c> ID. Must not be <c>null</c> or empty.</param>
        public NasTrialDetailName(string projectId, string locationId, string nasJobId, string nasTrialDetailId) : this(ResourceNameType.ProjectLocationNasJobNasTrialDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nasJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(nasJobId, nameof(nasJobId)), nasTrialDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(nasTrialDetailId, nameof(nasTrialDetailId)))
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
        /// The <c>NasJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NasJobId { get; }

        /// <summary>
        /// The <c>NasTrialDetail</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NasTrialDetailId { get; }

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
                case ResourceNameType.ProjectLocationNasJobNasTrialDetail: return s_projectLocationNasJobNasTrialDetail.Expand(ProjectId, LocationId, NasJobId, NasTrialDetailId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NasTrialDetailName);

        /// <inheritdoc/>
        public bool Equals(NasTrialDetailName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NasTrialDetailName a, NasTrialDetailName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NasTrialDetailName a, NasTrialDetailName b) => !(a == b);
    }

    public partial class NasJob
    {
        /// <summary>
        /// <see cref="gcav::NasJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NasJobName NasJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NasJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NasTrialDetail
    {
        /// <summary>
        /// <see cref="gcav::NasTrialDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NasTrialDetailName NasTrialDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NasTrialDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
