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
    /// <summary>Resource name for the <c>ModelEvaluationSlice</c> resource.</summary>
    public sealed partial class ModelEvaluationSliceName : gax::IResourceName, sys::IEquatable<ModelEvaluationSliceName>
    {
        /// <summary>The possible contents of <see cref="ModelEvaluationSliceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>.
            /// </summary>
            ProjectLocationModelEvaluationSlice = 1,
        }

        private static gax::PathTemplate s_projectLocationModelEvaluationSlice = new gax::PathTemplate("projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}");

        /// <summary>Creates a <see cref="ModelEvaluationSliceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ModelEvaluationSliceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ModelEvaluationSliceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ModelEvaluationSliceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ModelEvaluationSliceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sliceId">The <c>Slice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ModelEvaluationSliceName"/> constructed from the provided ids.
        /// </returns>
        public static ModelEvaluationSliceName FromProjectLocationModelEvaluationSlice(string projectId, string locationId, string modelId, string evaluationId, string sliceId) =>
            new ModelEvaluationSliceName(ResourceNameType.ProjectLocationModelEvaluationSlice, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)), sliceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sliceId, nameof(sliceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelEvaluationSliceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sliceId">The <c>Slice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelEvaluationSliceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string modelId, string evaluationId, string sliceId) =>
            FormatProjectLocationModelEvaluationSlice(projectId, locationId, modelId, evaluationId, sliceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelEvaluationSliceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sliceId">The <c>Slice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelEvaluationSliceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>.
        /// </returns>
        public static string FormatProjectLocationModelEvaluationSlice(string projectId, string locationId, string modelId, string evaluationId, string sliceId) =>
            s_projectLocationModelEvaluationSlice.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sliceId, nameof(sliceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelEvaluationSliceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelEvaluationSliceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelEvaluationSliceName"/> if successful.</returns>
        public static ModelEvaluationSliceName Parse(string modelEvaluationSliceName) =>
            Parse(modelEvaluationSliceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelEvaluationSliceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelEvaluationSliceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ModelEvaluationSliceName"/> if successful.</returns>
        public static ModelEvaluationSliceName Parse(string modelEvaluationSliceName, bool allowUnparsed) =>
            TryParse(modelEvaluationSliceName, allowUnparsed, out ModelEvaluationSliceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelEvaluationSliceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelEvaluationSliceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelEvaluationSliceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelEvaluationSliceName, out ModelEvaluationSliceName result) =>
            TryParse(modelEvaluationSliceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelEvaluationSliceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelEvaluationSliceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelEvaluationSliceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelEvaluationSliceName, bool allowUnparsed, out ModelEvaluationSliceName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelEvaluationSliceName, nameof(modelEvaluationSliceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationModelEvaluationSlice.TryParseName(modelEvaluationSliceName, out resourceName))
            {
                result = FromProjectLocationModelEvaluationSlice(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(modelEvaluationSliceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ModelEvaluationSliceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string evaluationId = null, string locationId = null, string modelId = null, string projectId = null, string sliceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EvaluationId = evaluationId;
            LocationId = locationId;
            ModelId = modelId;
            ProjectId = projectId;
            SliceId = sliceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ModelEvaluationSliceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sliceId">The <c>Slice</c> ID. Must not be <c>null</c> or empty.</param>
        public ModelEvaluationSliceName(string projectId, string locationId, string modelId, string evaluationId, string sliceId) : this(ResourceNameType.ProjectLocationModelEvaluationSlice, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)), sliceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sliceId, nameof(sliceId)))
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
        /// The <c>Evaluation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EvaluationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Slice</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SliceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationModelEvaluationSlice: return s_projectLocationModelEvaluationSlice.Expand(ProjectId, LocationId, ModelId, EvaluationId, SliceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ModelEvaluationSliceName);

        /// <inheritdoc/>
        public bool Equals(ModelEvaluationSliceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ModelEvaluationSliceName a, ModelEvaluationSliceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ModelEvaluationSliceName a, ModelEvaluationSliceName b) => !(a == b);
    }

    public partial class ModelEvaluationSlice
    {
        /// <summary>
        /// <see cref="gcav::ModelEvaluationSliceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelEvaluationSliceName ModelEvaluationSliceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelEvaluationSliceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
