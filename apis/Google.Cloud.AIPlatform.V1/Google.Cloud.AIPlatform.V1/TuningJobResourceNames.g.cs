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
    /// <summary>Resource name for the <c>TuningJob</c> resource.</summary>
    public sealed partial class TuningJobName : gax::IResourceName, sys::IEquatable<TuningJobName>
    {
        /// <summary>The possible contents of <see cref="TuningJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>.
            /// </summary>
            ProjectLocationTuningJob = 1,
        }

        private static gax::PathTemplate s_projectLocationTuningJob = new gax::PathTemplate("projects/{project}/locations/{location}/tuningJobs/{tuning_job}");

        /// <summary>Creates a <see cref="TuningJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TuningJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TuningJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TuningJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TuningJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tuningJobId">The <c>TuningJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TuningJobName"/> constructed from the provided ids.</returns>
        public static TuningJobName FromProjectLocationTuningJob(string projectId, string locationId, string tuningJobId) =>
            new TuningJobName(ResourceNameType.ProjectLocationTuningJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tuningJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(tuningJobId, nameof(tuningJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TuningJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tuningJobId">The <c>TuningJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TuningJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tuningJobId) =>
            FormatProjectLocationTuningJob(projectId, locationId, tuningJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TuningJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tuningJobId">The <c>TuningJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TuningJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>.
        /// </returns>
        public static string FormatProjectLocationTuningJob(string projectId, string locationId, string tuningJobId) =>
            s_projectLocationTuningJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tuningJobId, nameof(tuningJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="TuningJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TuningJobName"/> if successful.</returns>
        public static TuningJobName Parse(string tuningJobName) => Parse(tuningJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TuningJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TuningJobName"/> if successful.</returns>
        public static TuningJobName Parse(string tuningJobName, bool allowUnparsed) =>
            TryParse(tuningJobName, allowUnparsed, out TuningJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TuningJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TuningJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tuningJobName, out TuningJobName result) => TryParse(tuningJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TuningJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TuningJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tuningJobName, bool allowUnparsed, out TuningJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(tuningJobName, nameof(tuningJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTuningJob.TryParseName(tuningJobName, out resourceName))
            {
                result = FromProjectLocationTuningJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tuningJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TuningJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tuningJobId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TuningJobId = tuningJobId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TuningJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tuningJobs/{tuning_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tuningJobId">The <c>TuningJob</c> ID. Must not be <c>null</c> or empty.</param>
        public TuningJobName(string projectId, string locationId, string tuningJobId) : this(ResourceNameType.ProjectLocationTuningJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tuningJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(tuningJobId, nameof(tuningJobId)))
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
        /// The <c>TuningJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TuningJobId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTuningJob: return s_projectLocationTuningJob.Expand(ProjectId, LocationId, TuningJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TuningJobName);

        /// <inheritdoc/>
        public bool Equals(TuningJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TuningJobName a, TuningJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TuningJobName a, TuningJobName b) => !(a == b);
    }

    public partial class TuningJob
    {
        /// <summary>
        /// <see cref="gcav::TuningJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TuningJobName TuningJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TuningJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="Experiment"/> resource name property.
        /// </summary>
        public ContextName ExperimentAsContextName
        {
            get => string.IsNullOrEmpty(Experiment) ? null : ContextName.Parse(Experiment, allowUnparsed: true);
            set => Experiment = value?.ToString() ?? "";
        }
    }

    public partial class TunedModel
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }
}
