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
    /// <summary>Resource name for the <c>CustomJob</c> resource.</summary>
    public sealed partial class CustomJobName : gax::IResourceName, sys::IEquatable<CustomJobName>
    {
        /// <summary>The possible contents of <see cref="CustomJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>.
            /// </summary>
            ProjectLocationCustomJob = 1,
        }

        private static gax::PathTemplate s_projectLocationCustomJob = new gax::PathTemplate("projects/{project}/locations/{location}/customJobs/{custom_job}");

        /// <summary>Creates a <see cref="CustomJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customJobId">The <c>CustomJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomJobName"/> constructed from the provided ids.</returns>
        public static CustomJobName FromProjectLocationCustomJob(string projectId, string locationId, string customJobId) =>
            new CustomJobName(ResourceNameType.ProjectLocationCustomJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(customJobId, nameof(customJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customJobId">The <c>CustomJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string customJobId) =>
            FormatProjectLocationCustomJob(projectId, locationId, customJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customJobId">The <c>CustomJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>.
        /// </returns>
        public static string FormatProjectLocationCustomJob(string projectId, string locationId, string customJobId) =>
            s_projectLocationCustomJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customJobId, nameof(customJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="CustomJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/customJobs/{custom_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomJobName"/> if successful.</returns>
        public static CustomJobName Parse(string customJobName) => Parse(customJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/customJobs/{custom_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomJobName"/> if successful.</returns>
        public static CustomJobName Parse(string customJobName, bool allowUnparsed) =>
            TryParse(customJobName, allowUnparsed, out CustomJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/customJobs/{custom_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customJobName, out CustomJobName result) => TryParse(customJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/customJobs/{custom_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customJobName, bool allowUnparsed, out CustomJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(customJobName, nameof(customJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCustomJob.TryParseName(customJobName, out resourceName))
            {
                result = FromProjectLocationCustomJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomJobId = customJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/customJobs/{custom_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customJobId">The <c>CustomJob</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomJobName(string projectId, string locationId, string customJobId) : this(ResourceNameType.ProjectLocationCustomJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(customJobId, nameof(customJobId)))
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
        /// The <c>CustomJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomJobId { get; }

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
                case ResourceNameType.ProjectLocationCustomJob: return s_projectLocationCustomJob.Expand(ProjectId, LocationId, CustomJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomJobName);

        /// <inheritdoc/>
        public bool Equals(CustomJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomJobName a, CustomJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomJobName a, CustomJobName b) => !(a == b);
    }

    public partial class CustomJob
    {
        /// <summary>
        /// <see cref="gcav::CustomJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::CustomJobName CustomJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::CustomJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CustomJobSpec
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Tensorboard"/> resource name property.
        /// </summary>
        public TensorboardName TensorboardAsTensorboardName
        {
            get => string.IsNullOrEmpty(Tensorboard) ? null : TensorboardName.Parse(Tensorboard, allowUnparsed: true);
            set => Tensorboard = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PersistentResourceName"/>-typed view over the <see cref="PersistentResourceId"/> resource name
        /// property.
        /// </summary>
        public PersistentResourceName PersistentResourceIdAsPersistentResourceName
        {
            get => string.IsNullOrEmpty(PersistentResourceId) ? null : PersistentResourceName.Parse(PersistentResourceId, allowUnparsed: true);
            set => PersistentResourceId = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="Experiment"/> resource name property.
        /// </summary>
        public ContextName ExperimentAsContextName
        {
            get => string.IsNullOrEmpty(Experiment) ? null : ContextName.Parse(Experiment, allowUnparsed: true);
            set => Experiment = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ContextName"/>-typed view over the <see cref="ExperimentRun"/> resource name property.
        /// </summary>
        public ContextName ExperimentRunAsContextName
        {
            get => string.IsNullOrEmpty(ExperimentRun) ? null : ContextName.Parse(ExperimentRun, allowUnparsed: true);
            set => ExperimentRun = value?.ToString() ?? "";
        }

        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Models"/> resource name property.</summary>
        public gax::ResourceNameList<ModelName> ModelsAsModelNames
        {
            get => new gax::ResourceNameList<ModelName>(Models, s => string.IsNullOrEmpty(s) ? null : ModelName.Parse(s, allowUnparsed: true));
        }
    }
}
