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
using gcdv = Google.Cloud.DiscoveryEngine.V1;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>AssistAnswer</c> resource.</summary>
    public sealed partial class AssistAnswerName : gax::IResourceName, sys::IEquatable<AssistAnswerName>
    {
        /// <summary>The possible contents of <see cref="AssistAnswerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionEngineSessionAssistAnswer = 1,
        }

        private static gax::PathTemplate s_projectLocationCollectionEngineSessionAssistAnswer = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}");

        /// <summary>Creates a <see cref="AssistAnswerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssistAnswerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssistAnswerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssistAnswerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssistAnswerName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistAnswerId">The <c>AssistAnswer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssistAnswerName"/> constructed from the provided ids.</returns>
        public static AssistAnswerName FromProjectLocationCollectionEngineSessionAssistAnswer(string projectId, string locationId, string collectionId, string engineId, string sessionId, string assistAnswerId) =>
            new AssistAnswerName(ResourceNameType.ProjectLocationCollectionEngineSessionAssistAnswer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), assistAnswerId: gax::GaxPreconditions.CheckNotNullOrEmpty(assistAnswerId, nameof(assistAnswerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssistAnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistAnswerId">The <c>AssistAnswer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssistAnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string collectionId, string engineId, string sessionId, string assistAnswerId) =>
            FormatProjectLocationCollectionEngineSessionAssistAnswer(projectId, locationId, collectionId, engineId, sessionId, assistAnswerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssistAnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistAnswerId">The <c>AssistAnswer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssistAnswerName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionEngineSessionAssistAnswer(string projectId, string locationId, string collectionId, string engineId, string sessionId, string assistAnswerId) =>
            s_projectLocationCollectionEngineSessionAssistAnswer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assistAnswerId, nameof(assistAnswerId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssistAnswerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assistAnswerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssistAnswerName"/> if successful.</returns>
        public static AssistAnswerName Parse(string assistAnswerName) => Parse(assistAnswerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssistAnswerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assistAnswerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssistAnswerName"/> if successful.</returns>
        public static AssistAnswerName Parse(string assistAnswerName, bool allowUnparsed) =>
            TryParse(assistAnswerName, allowUnparsed, out AssistAnswerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssistAnswerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assistAnswerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssistAnswerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assistAnswerName, out AssistAnswerName result) =>
            TryParse(assistAnswerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssistAnswerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assistAnswerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssistAnswerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assistAnswerName, bool allowUnparsed, out AssistAnswerName result)
        {
            gax::GaxPreconditions.CheckNotNull(assistAnswerName, nameof(assistAnswerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCollectionEngineSessionAssistAnswer.TryParseName(assistAnswerName, out resourceName))
            {
                result = FromProjectLocationCollectionEngineSessionAssistAnswer(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assistAnswerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssistAnswerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assistAnswerId = null, string collectionId = null, string engineId = null, string locationId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssistAnswerId = assistAnswerId;
            CollectionId = collectionId;
            EngineId = engineId;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssistAnswerName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/sessions/{session}/assistAnswers/{assist_answer}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assistAnswerId">The <c>AssistAnswer</c> ID. Must not be <c>null</c> or empty.</param>
        public AssistAnswerName(string projectId, string locationId, string collectionId, string engineId, string sessionId, string assistAnswerId) : this(ResourceNameType.ProjectLocationCollectionEngineSessionAssistAnswer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), assistAnswerId: gax::GaxPreconditions.CheckNotNullOrEmpty(assistAnswerId, nameof(assistAnswerId)))
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
        /// The <c>AssistAnswer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AssistAnswerId { get; }

        /// <summary>
        /// The <c>Collection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>Engine</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EngineId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Session</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationCollectionEngineSessionAssistAnswer: return s_projectLocationCollectionEngineSessionAssistAnswer.Expand(ProjectId, LocationId, CollectionId, EngineId, SessionId, AssistAnswerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssistAnswerName);

        /// <inheritdoc/>
        public bool Equals(AssistAnswerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssistAnswerName a, AssistAnswerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssistAnswerName a, AssistAnswerName b) => !(a == b);
    }

    public partial class AssistAnswer
    {
        /// <summary>
        /// <see cref="gcdv::AssistAnswerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AssistAnswerName AssistAnswerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AssistAnswerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AssistantGroundedContent
    {
        public partial class Types
        {
            public partial class TextGroundingMetadata
            {
                public partial class Types
                {
                    public partial class Reference
                    {
                        public partial class Types
                        {
                            public partial class DocumentMetadata
                            {
                                /// <summary>
                                /// <see cref="DocumentName"/>-typed view over the <see cref="Document"/> resource name
                                /// property.
                                /// </summary>
                                public DocumentName DocumentAsDocumentName
                                {
                                    get => string.IsNullOrEmpty(Document) ? null : DocumentName.Parse(Document, allowUnparsed: true);
                                    set => Document = value?.ToString() ?? "";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
