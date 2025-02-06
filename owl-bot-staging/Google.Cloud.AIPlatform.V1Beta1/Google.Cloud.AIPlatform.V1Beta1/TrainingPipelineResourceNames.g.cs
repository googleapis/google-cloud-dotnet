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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>TrainingPipeline</c> resource.</summary>
    public sealed partial class TrainingPipelineName : gax::IResourceName, sys::IEquatable<TrainingPipelineName>
    {
        /// <summary>The possible contents of <see cref="TrainingPipelineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>.
            /// </summary>
            ProjectLocationTrainingPipeline = 1,
        }

        private static gax::PathTemplate s_projectLocationTrainingPipeline = new gax::PathTemplate("projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}");

        /// <summary>Creates a <see cref="TrainingPipelineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TrainingPipelineName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TrainingPipelineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TrainingPipelineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TrainingPipelineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trainingPipelineId">The <c>TrainingPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TrainingPipelineName"/> constructed from the provided ids.</returns>
        public static TrainingPipelineName FromProjectLocationTrainingPipeline(string projectId, string locationId, string trainingPipelineId) =>
            new TrainingPipelineName(ResourceNameType.ProjectLocationTrainingPipeline, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), trainingPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(trainingPipelineId, nameof(trainingPipelineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TrainingPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trainingPipelineId">The <c>TrainingPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TrainingPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string trainingPipelineId) =>
            FormatProjectLocationTrainingPipeline(projectId, locationId, trainingPipelineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TrainingPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trainingPipelineId">The <c>TrainingPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TrainingPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>.
        /// </returns>
        public static string FormatProjectLocationTrainingPipeline(string projectId, string locationId, string trainingPipelineId) =>
            s_projectLocationTrainingPipeline.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(trainingPipelineId, nameof(trainingPipelineId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TrainingPipelineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="trainingPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TrainingPipelineName"/> if successful.</returns>
        public static TrainingPipelineName Parse(string trainingPipelineName) => Parse(trainingPipelineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TrainingPipelineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="trainingPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TrainingPipelineName"/> if successful.</returns>
        public static TrainingPipelineName Parse(string trainingPipelineName, bool allowUnparsed) =>
            TryParse(trainingPipelineName, allowUnparsed, out TrainingPipelineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TrainingPipelineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="trainingPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TrainingPipelineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string trainingPipelineName, out TrainingPipelineName result) =>
            TryParse(trainingPipelineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TrainingPipelineName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="trainingPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TrainingPipelineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string trainingPipelineName, bool allowUnparsed, out TrainingPipelineName result)
        {
            gax::GaxPreconditions.CheckNotNull(trainingPipelineName, nameof(trainingPipelineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTrainingPipeline.TryParseName(trainingPipelineName, out resourceName))
            {
                result = FromProjectLocationTrainingPipeline(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(trainingPipelineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TrainingPipelineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string trainingPipelineId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TrainingPipelineId = trainingPipelineId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TrainingPipelineName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trainingPipelineId">The <c>TrainingPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        public TrainingPipelineName(string projectId, string locationId, string trainingPipelineId) : this(ResourceNameType.ProjectLocationTrainingPipeline, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), trainingPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(trainingPipelineId, nameof(trainingPipelineId)))
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
        /// The <c>TrainingPipeline</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TrainingPipelineId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTrainingPipeline: return s_projectLocationTrainingPipeline.Expand(ProjectId, LocationId, TrainingPipelineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TrainingPipelineName);

        /// <inheritdoc/>
        public bool Equals(TrainingPipelineName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TrainingPipelineName a, TrainingPipelineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TrainingPipelineName a, TrainingPipelineName b) => !(a == b);
    }

    public partial class TrainingPipeline
    {
        /// <summary>
        /// <see cref="gcav::TrainingPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrainingPipelineName TrainingPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrainingPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
