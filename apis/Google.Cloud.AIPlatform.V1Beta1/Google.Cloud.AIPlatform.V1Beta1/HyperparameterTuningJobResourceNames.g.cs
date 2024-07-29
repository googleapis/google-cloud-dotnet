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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>HyperparameterTuningJob</c> resource.</summary>
    public sealed partial class HyperparameterTuningJobName : gax::IResourceName, sys::IEquatable<HyperparameterTuningJobName>
    {
        /// <summary>The possible contents of <see cref="HyperparameterTuningJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>.
            /// </summary>
            ProjectLocationHyperparameterTuningJob = 1,
        }

        private static gax::PathTemplate s_projectLocationHyperparameterTuningJob = new gax::PathTemplate("projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}");

        /// <summary>Creates a <see cref="HyperparameterTuningJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HyperparameterTuningJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HyperparameterTuningJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HyperparameterTuningJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HyperparameterTuningJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hyperparameterTuningJobId">
        /// The <c>HyperparameterTuningJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="HyperparameterTuningJobName"/> constructed from the provided ids.
        /// </returns>
        public static HyperparameterTuningJobName FromProjectLocationHyperparameterTuningJob(string projectId, string locationId, string hyperparameterTuningJobId) =>
            new HyperparameterTuningJobName(ResourceNameType.ProjectLocationHyperparameterTuningJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), hyperparameterTuningJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(hyperparameterTuningJobId, nameof(hyperparameterTuningJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HyperparameterTuningJobName"/> with
        /// pattern <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hyperparameterTuningJobId">
        /// The <c>HyperparameterTuningJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="HyperparameterTuningJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string hyperparameterTuningJobId) =>
            FormatProjectLocationHyperparameterTuningJob(projectId, locationId, hyperparameterTuningJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HyperparameterTuningJobName"/> with
        /// pattern <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hyperparameterTuningJobId">
        /// The <c>HyperparameterTuningJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="HyperparameterTuningJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>.
        /// </returns>
        public static string FormatProjectLocationHyperparameterTuningJob(string projectId, string locationId, string hyperparameterTuningJobId) =>
            s_projectLocationHyperparameterTuningJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hyperparameterTuningJobId, nameof(hyperparameterTuningJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HyperparameterTuningJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hyperparameterTuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HyperparameterTuningJobName"/> if successful.</returns>
        public static HyperparameterTuningJobName Parse(string hyperparameterTuningJobName) =>
            Parse(hyperparameterTuningJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HyperparameterTuningJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hyperparameterTuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HyperparameterTuningJobName"/> if successful.</returns>
        public static HyperparameterTuningJobName Parse(string hyperparameterTuningJobName, bool allowUnparsed) =>
            TryParse(hyperparameterTuningJobName, allowUnparsed, out HyperparameterTuningJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HyperparameterTuningJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hyperparameterTuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HyperparameterTuningJobName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hyperparameterTuningJobName, out HyperparameterTuningJobName result) =>
            TryParse(hyperparameterTuningJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HyperparameterTuningJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hyperparameterTuningJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HyperparameterTuningJobName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hyperparameterTuningJobName, bool allowUnparsed, out HyperparameterTuningJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(hyperparameterTuningJobName, nameof(hyperparameterTuningJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationHyperparameterTuningJob.TryParseName(hyperparameterTuningJobName, out resourceName))
            {
                result = FromProjectLocationHyperparameterTuningJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hyperparameterTuningJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HyperparameterTuningJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hyperparameterTuningJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HyperparameterTuningJobId = hyperparameterTuningJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HyperparameterTuningJobName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hyperparameterTuningJobId">
        /// The <c>HyperparameterTuningJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public HyperparameterTuningJobName(string projectId, string locationId, string hyperparameterTuningJobId) : this(ResourceNameType.ProjectLocationHyperparameterTuningJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), hyperparameterTuningJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(hyperparameterTuningJobId, nameof(hyperparameterTuningJobId)))
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
        /// The <c>HyperparameterTuningJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string HyperparameterTuningJobId { get; }

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
                case ResourceNameType.ProjectLocationHyperparameterTuningJob: return s_projectLocationHyperparameterTuningJob.Expand(ProjectId, LocationId, HyperparameterTuningJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HyperparameterTuningJobName);

        /// <inheritdoc/>
        public bool Equals(HyperparameterTuningJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HyperparameterTuningJobName a, HyperparameterTuningJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HyperparameterTuningJobName a, HyperparameterTuningJobName b) => !(a == b);
    }

    public partial class HyperparameterTuningJob
    {
        /// <summary>
        /// <see cref="gcav::HyperparameterTuningJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::HyperparameterTuningJobName HyperparameterTuningJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::HyperparameterTuningJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
