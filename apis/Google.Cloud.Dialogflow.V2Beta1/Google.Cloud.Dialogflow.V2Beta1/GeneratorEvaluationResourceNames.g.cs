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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>GeneratorEvaluation</c> resource.</summary>
    public sealed partial class GeneratorEvaluationName : gax::IResourceName, sys::IEquatable<GeneratorEvaluationName>
    {
        /// <summary>The possible contents of <see cref="GeneratorEvaluationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>.
            /// </summary>
            ProjectLocationGeneratorEvaluation = 1,
        }

        private static gax::PathTemplate s_projectLocationGeneratorEvaluation = new gax::PathTemplate("projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}");

        /// <summary>Creates a <see cref="GeneratorEvaluationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GeneratorEvaluationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GeneratorEvaluationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GeneratorEvaluationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GeneratorEvaluationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generatorId">The <c>Generator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="GeneratorEvaluationName"/> constructed from the provided ids.
        /// </returns>
        public static GeneratorEvaluationName FromProjectLocationGeneratorEvaluation(string projectId, string locationId, string generatorId, string evaluationId) =>
            new GeneratorEvaluationName(ResourceNameType.ProjectLocationGeneratorEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), generatorId: gax::GaxPreconditions.CheckNotNullOrEmpty(generatorId, nameof(generatorId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GeneratorEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generatorId">The <c>Generator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GeneratorEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string generatorId, string evaluationId) =>
            FormatProjectLocationGeneratorEvaluation(projectId, locationId, generatorId, evaluationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GeneratorEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generatorId">The <c>Generator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GeneratorEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string FormatProjectLocationGeneratorEvaluation(string projectId, string locationId, string generatorId, string evaluationId) =>
            s_projectLocationGeneratorEvaluation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(generatorId, nameof(generatorId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GeneratorEvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="generatorEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GeneratorEvaluationName"/> if successful.</returns>
        public static GeneratorEvaluationName Parse(string generatorEvaluationName) => Parse(generatorEvaluationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GeneratorEvaluationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="generatorEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GeneratorEvaluationName"/> if successful.</returns>
        public static GeneratorEvaluationName Parse(string generatorEvaluationName, bool allowUnparsed) =>
            TryParse(generatorEvaluationName, allowUnparsed, out GeneratorEvaluationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GeneratorEvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="generatorEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GeneratorEvaluationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string generatorEvaluationName, out GeneratorEvaluationName result) =>
            TryParse(generatorEvaluationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GeneratorEvaluationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="generatorEvaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GeneratorEvaluationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string generatorEvaluationName, bool allowUnparsed, out GeneratorEvaluationName result)
        {
            gax::GaxPreconditions.CheckNotNull(generatorEvaluationName, nameof(generatorEvaluationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGeneratorEvaluation.TryParseName(generatorEvaluationName, out resourceName))
            {
                result = FromProjectLocationGeneratorEvaluation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(generatorEvaluationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GeneratorEvaluationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string evaluationId = null, string generatorId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EvaluationId = evaluationId;
            GeneratorId = generatorId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GeneratorEvaluationName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/generators/{generator}/evaluations/{evaluation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="generatorId">The <c>Generator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        public GeneratorEvaluationName(string projectId, string locationId, string generatorId, string evaluationId) : this(ResourceNameType.ProjectLocationGeneratorEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), generatorId: gax::GaxPreconditions.CheckNotNullOrEmpty(generatorId, nameof(generatorId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)))
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
        /// The <c>Generator</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GeneratorId { get; }

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
                case ResourceNameType.ProjectLocationGeneratorEvaluation: return s_projectLocationGeneratorEvaluation.Expand(ProjectId, LocationId, GeneratorId, EvaluationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GeneratorEvaluationName);

        /// <inheritdoc/>
        public bool Equals(GeneratorEvaluationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GeneratorEvaluationName a, GeneratorEvaluationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GeneratorEvaluationName a, GeneratorEvaluationName b) => !(a == b);
    }

    public partial class CreateGeneratorEvaluationRequest
    {
        /// <summary>
        /// <see cref="GeneratorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GeneratorName ParentAsGeneratorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GeneratorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGeneratorEvaluationRequest
    {
        /// <summary>
        /// <see cref="gcdv::GeneratorEvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GeneratorEvaluationName GeneratorEvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GeneratorEvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGeneratorEvaluationsRequest
    {
        /// <summary>
        /// <see cref="GeneratorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GeneratorName ParentAsGeneratorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GeneratorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGeneratorEvaluationRequest
    {
        /// <summary>
        /// <see cref="gcdv::GeneratorEvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GeneratorEvaluationName GeneratorEvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GeneratorEvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GeneratorEvaluation
    {
        /// <summary>
        /// <see cref="gcdv::GeneratorEvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GeneratorEvaluationName GeneratorEvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GeneratorEvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
