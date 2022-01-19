// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DataQnA.V1Alpha;
using sys = System;

namespace Google.Cloud.DataQnA.V1Alpha
{
    /// <summary>Resource name for the <c>Question</c> resource.</summary>
    public sealed partial class QuestionName : gax::IResourceName, sys::IEquatable<QuestionName>
    {
        /// <summary>The possible contents of <see cref="QuestionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/questions/{question}</c>.
            /// </summary>
            ProjectLocationQuestion = 1,
        }

        private static gax::PathTemplate s_projectLocationQuestion = new gax::PathTemplate("projects/{project}/locations/{location}/questions/{question}");

        /// <summary>Creates a <see cref="QuestionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QuestionName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static QuestionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QuestionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QuestionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/questions/{question}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="questionId">The <c>Question</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuestionName"/> constructed from the provided ids.</returns>
        public static QuestionName FromProjectLocationQuestion(string projectId, string locationId, string questionId) =>
            new QuestionName(ResourceNameType.ProjectLocationQuestion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), questionId: gax::GaxPreconditions.CheckNotNullOrEmpty(questionId, nameof(questionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuestionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/questions/{question}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="questionId">The <c>Question</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuestionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/questions/{question}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string questionId) =>
            FormatProjectLocationQuestion(projectId, locationId, questionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuestionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/questions/{question}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="questionId">The <c>Question</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuestionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/questions/{question}</c>.
        /// </returns>
        public static string FormatProjectLocationQuestion(string projectId, string locationId, string questionId) =>
            s_projectLocationQuestion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(questionId, nameof(questionId)));

        /// <summary>Parses the given resource name string into a new <see cref="QuestionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/questions/{question}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="questionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QuestionName"/> if successful.</returns>
        public static QuestionName Parse(string questionName) => Parse(questionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuestionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/questions/{question}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="questionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QuestionName"/> if successful.</returns>
        public static QuestionName Parse(string questionName, bool allowUnparsed) =>
            TryParse(questionName, allowUnparsed, out QuestionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuestionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/questions/{question}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="questionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuestionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string questionName, out QuestionName result) => TryParse(questionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuestionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/questions/{question}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="questionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuestionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string questionName, bool allowUnparsed, out QuestionName result)
        {
            gax::GaxPreconditions.CheckNotNull(questionName, nameof(questionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQuestion.TryParseName(questionName, out resourceName))
            {
                result = FromProjectLocationQuestion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(questionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QuestionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string questionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            QuestionId = questionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QuestionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/questions/{question}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="questionId">The <c>Question</c> ID. Must not be <c>null</c> or empty.</param>
        public QuestionName(string projectId, string locationId, string questionId) : this(ResourceNameType.ProjectLocationQuestion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), questionId: gax::GaxPreconditions.CheckNotNullOrEmpty(questionId, nameof(questionId)))
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
        /// The <c>Question</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QuestionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQuestion: return s_projectLocationQuestion.Expand(ProjectId, LocationId, QuestionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QuestionName);

        /// <inheritdoc/>
        public bool Equals(QuestionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(QuestionName a, QuestionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(QuestionName a, QuestionName b) => !(a == b);
    }

    public partial class Question
    {
        /// <summary>
        /// <see cref="gcdv::QuestionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::QuestionName QuestionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::QuestionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
