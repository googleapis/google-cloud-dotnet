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
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>ConversationModel</c> resource.</summary>
    public sealed partial class ConversationModelName : gax::IResourceName, sys::IEquatable<ConversationModelName>
    {
        /// <summary>The possible contents of <see cref="ConversationModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>.
            /// </summary>
            ProjectLocationConversationModel = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/conversationModels/{conversation_model}</c>.
            /// </summary>
            ProjectConversationModel = 2,
        }

        private static gax::PathTemplate s_projectLocationConversationModel = new gax::PathTemplate("projects/{project}/locations/{location}/conversationModels/{conversation_model}");

        private static gax::PathTemplate s_projectConversationModel = new gax::PathTemplate("projects/{project}/conversationModels/{conversation_model}");

        /// <summary>Creates a <see cref="ConversationModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationModelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationModelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConversationModelName"/> constructed from the provided ids.</returns>
        public static ConversationModelName FromProjectLocationConversationModel(string projectId, string locationId, string conversationModelId) =>
            new ConversationModelName(ResourceNameType.ProjectLocationConversationModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)));

        /// <summary>
        /// Creates a <see cref="ConversationModelName"/> with the pattern
        /// <c>projects/{project}/conversationModels/{conversation_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConversationModelName"/> constructed from the provided ids.</returns>
        public static ConversationModelName FromProjectConversationModel(string projectId, string conversationModelId) =>
            new ConversationModelName(ResourceNameType.ProjectConversationModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationModelId) =>
            FormatProjectLocationConversationModel(projectId, locationId, conversationModelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationModel(string projectId, string locationId, string conversationModelId) =>
            s_projectLocationConversationModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationModelName"/> with pattern
        /// <c>projects/{project}/conversationModels/{conversation_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationModelName"/> with pattern
        /// <c>projects/{project}/conversationModels/{conversation_model}</c>.
        /// </returns>
        public static string FormatProjectConversationModel(string projectId, string conversationModelId) =>
            s_projectConversationModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>
        /// </description>
        /// </item>
        /// <item><description><c>projects/{project}/conversationModels/{conversation_model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conversationModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversationModelName"/> if successful.</returns>
        public static ConversationModelName Parse(string conversationModelName) => Parse(conversationModelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>
        /// </description>
        /// </item>
        /// <item><description><c>projects/{project}/conversationModels/{conversation_model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationModelName"/> if successful.</returns>
        public static ConversationModelName Parse(string conversationModelName, bool allowUnparsed) =>
            TryParse(conversationModelName, allowUnparsed, out ConversationModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>
        /// </description>
        /// </item>
        /// <item><description><c>projects/{project}/conversationModels/{conversation_model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conversationModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationModelName, out ConversationModelName result) =>
            TryParse(conversationModelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationModelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>
        /// </description>
        /// </item>
        /// <item><description><c>projects/{project}/conversationModels/{conversation_model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationModelName, bool allowUnparsed, out ConversationModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationModelName, nameof(conversationModelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversationModel.TryParseName(conversationModelName, out resourceName))
            {
                result = FromProjectLocationConversationModel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectConversationModel.TryParseName(conversationModelName, out resourceName))
            {
                result = FromProjectConversationModel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationModelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationModelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationModelId = conversationModelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationModelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversationModelName(string projectId, string locationId, string conversationModelId) : this(ResourceNameType.ProjectLocationConversationModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)))
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
        /// The <c>ConversationModel</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConversationModelId { get; }

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
                case ResourceNameType.ProjectLocationConversationModel: return s_projectLocationConversationModel.Expand(ProjectId, LocationId, ConversationModelId);
                case ResourceNameType.ProjectConversationModel: return s_projectConversationModel.Expand(ProjectId, ConversationModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationModelName);

        /// <inheritdoc/>
        public bool Equals(ConversationModelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversationModelName a, ConversationModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversationModelName a, ConversationModelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ConversationModelEvaluation</c> resource.</summary>
    public sealed partial class ConversationModelEvaluationName : gax::IResourceName, sys::IEquatable<ConversationModelEvaluationName>
    {
        /// <summary>The possible contents of <see cref="ConversationModelEvaluationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>.
            /// </summary>
            ProjectConversationModelEvaluation = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
            /// .
            /// </summary>
            ProjectLocationConversationModelEvaluation = 2,
        }

        private static gax::PathTemplate s_projectConversationModelEvaluation = new gax::PathTemplate("projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}");

        private static gax::PathTemplate s_projectLocationConversationModelEvaluation = new gax::PathTemplate("projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}");

        /// <summary>
        /// Creates a <see cref="ConversationModelEvaluationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationModelEvaluationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationModelEvaluationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationModelEvaluationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationModelEvaluationName"/> with the pattern
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationModelEvaluationName"/> constructed from the provided ids.
        /// </returns>
        public static ConversationModelEvaluationName FromProjectConversationModelEvaluation(string projectId, string conversationModelId, string evaluationId) =>
            new ConversationModelEvaluationName(ResourceNameType.ProjectConversationModelEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Creates a <see cref="ConversationModelEvaluationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationModelEvaluationName"/> constructed from the provided ids.
        /// </returns>
        public static ConversationModelEvaluationName FromProjectLocationConversationModelEvaluation(string projectId, string locationId, string conversationModelId, string evaluationId) =>
            new ConversationModelEvaluationName(ResourceNameType.ProjectLocationConversationModelEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationModelEvaluationName"/> with
        /// pattern <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationModelEvaluationName"/> with pattern
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string Format(string projectId, string conversationModelId, string evaluationId) =>
            FormatProjectConversationModelEvaluation(projectId, conversationModelId, evaluationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationModelEvaluationName"/> with
        /// pattern <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationModelEvaluationName"/> with pattern
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string FormatProjectConversationModelEvaluation(string projectId, string conversationModelId, string evaluationId) =>
            s_projectConversationModelEvaluation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationModelEvaluationName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationModelEvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationConversationModelEvaluation(string projectId, string locationId, string conversationModelId, string evaluationId) =>
            s_projectLocationConversationModelEvaluation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationModelEvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationModelEvaluationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ConversationModelEvaluationName"/> if successful.</returns>
        public static ConversationModelEvaluationName Parse(string conversationModelEvaluationName) =>
            Parse(conversationModelEvaluationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationModelEvaluationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationModelEvaluationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationModelEvaluationName"/> if successful.</returns>
        public static ConversationModelEvaluationName Parse(string conversationModelEvaluationName, bool allowUnparsed) =>
            TryParse(conversationModelEvaluationName, allowUnparsed, out ConversationModelEvaluationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationModelEvaluationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationModelEvaluationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationModelEvaluationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationModelEvaluationName, out ConversationModelEvaluationName result) =>
            TryParse(conversationModelEvaluationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationModelEvaluationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationModelEvaluationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationModelEvaluationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationModelEvaluationName, bool allowUnparsed, out ConversationModelEvaluationName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationModelEvaluationName, nameof(conversationModelEvaluationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConversationModelEvaluation.TryParseName(conversationModelEvaluationName, out resourceName))
            {
                result = FromProjectConversationModelEvaluation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationConversationModelEvaluation.TryParseName(conversationModelEvaluationName, out resourceName))
            {
                result = FromProjectLocationConversationModelEvaluation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationModelEvaluationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationModelEvaluationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationModelId = null, string evaluationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationModelId = conversationModelId;
            EvaluationId = evaluationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationModelEvaluationName"/> class from the component parts
        /// of pattern <c>projects/{project}/conversationModels/{conversation_model}/evaluations/{evaluation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationModelId">The <c>ConversationModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversationModelEvaluationName(string projectId, string conversationModelId, string evaluationId) : this(ResourceNameType.ProjectConversationModelEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationModelId, nameof(conversationModelId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)))
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
        /// The <c>ConversationModel</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConversationModelId { get; }

        /// <summary>
        /// The <c>Evaluation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EvaluationId { get; }

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
                case ResourceNameType.ProjectConversationModelEvaluation: return s_projectConversationModelEvaluation.Expand(ProjectId, ConversationModelId, EvaluationId);
                case ResourceNameType.ProjectLocationConversationModelEvaluation: return s_projectLocationConversationModelEvaluation.Expand(ProjectId, LocationId, ConversationModelId, EvaluationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationModelEvaluationName);

        /// <inheritdoc/>
        public bool Equals(ConversationModelEvaluationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversationModelEvaluationName a, ConversationModelEvaluationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversationModelEvaluationName a, ConversationModelEvaluationName b) => !(a == b);
    }

    public partial class ConversationModel
    {
        /// <summary>
        /// <see cref="gcdv::ConversationModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationModelName ConversationModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ConversationModelEvaluation
    {
        /// <summary>
        /// <see cref="gcdv::ConversationModelEvaluationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::ConversationModelEvaluationName ConversationModelEvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationModelEvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EvaluationConfig
    {
        public partial class Types
        {
            public partial class SmartReplyConfig
            {
                /// <summary>
                /// <see cref="DocumentName"/>-typed view over the <see cref="AllowlistDocument"/> resource name
                /// property.
                /// </summary>
                public DocumentName AllowlistDocumentAsDocumentName
                {
                    get => string.IsNullOrEmpty(AllowlistDocument) ? null : DocumentName.Parse(AllowlistDocument, allowUnparsed: true);
                    set => AllowlistDocument = value?.ToString() ?? "";
                }
            }

            public partial class SmartComposeConfig
            {
                /// <summary>
                /// <see cref="DocumentName"/>-typed view over the <see cref="AllowlistDocument"/> resource name
                /// property.
                /// </summary>
                public DocumentName AllowlistDocumentAsDocumentName
                {
                    get => string.IsNullOrEmpty(AllowlistDocument) ? null : DocumentName.Parse(AllowlistDocument, allowUnparsed: true);
                    set => AllowlistDocument = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class InputDataset
    {
        /// <summary>
        /// <see cref="ConversationDatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public ConversationDatasetName DatasetAsConversationDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : ConversationDatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversationModelEvaluationRequest
    {
        /// <summary>
        /// <see cref="ConversationModelName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversationModelName ParentAsConversationModelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversationModelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
