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
using gccv = Google.Cloud.ContactCenterInsights.V1;
using sys = System;

namespace Google.Cloud.ContactCenterInsights.V1
{
    /// <summary>Resource name for the <c>Conversation</c> resource.</summary>
    public sealed partial class ConversationName : gax::IResourceName, sys::IEquatable<ConversationName>
    {
        /// <summary>The possible contents of <see cref="ConversationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/conversations/{conversation}</c>
            /// .
            /// </summary>
            ProjectLocationConversation = 1,
        }

        private static gax::PathTemplate s_projectLocationConversation = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}");

        /// <summary>Creates a <see cref="ConversationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConversationName"/> constructed from the provided ids.</returns>
        public static ConversationName FromProjectLocationConversation(string projectId, string locationId, string conversationId) =>
            new ConversationName(ResourceNameType.ProjectLocationConversation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationId) =>
            FormatProjectLocationConversation(projectId, locationId, conversationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>.
        /// </returns>
        public static string FormatProjectLocationConversation(string projectId, string locationId, string conversationId) =>
            s_projectLocationConversation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConversationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversationName"/> if successful.</returns>
        public static ConversationName Parse(string conversationName) => Parse(conversationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationName"/> if successful.</returns>
        public static ConversationName Parse(string conversationName, bool allowUnparsed) =>
            TryParse(conversationName, allowUnparsed, out ConversationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationName, out ConversationName result) =>
            TryParse(conversationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/conversations/{conversation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationName, bool allowUnparsed, out ConversationName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationName, nameof(conversationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversation.TryParseName(conversationName, out resourceName))
            {
                result = FromProjectLocationConversation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationId = conversationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversationName(string projectId, string locationId, string conversationId) : this(ResourceNameType.ProjectLocationConversation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)))
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
        /// The <c>Conversation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversationId { get; }

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
                case ResourceNameType.ProjectLocationConversation: return s_projectLocationConversation.Expand(ProjectId, LocationId, ConversationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationName);

        /// <inheritdoc/>
        public bool Equals(ConversationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversationName a, ConversationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversationName a, ConversationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Analysis</c> resource.</summary>
    public sealed partial class AnalysisName : gax::IResourceName, sys::IEquatable<AnalysisName>
    {
        /// <summary>The possible contents of <see cref="AnalysisName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
            /// </summary>
            ProjectLocationConversationAnalysis = 1,
        }

        private static gax::PathTemplate s_projectLocationConversationAnalysis = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}");

        /// <summary>Creates a <see cref="AnalysisName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnalysisName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static AnalysisName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnalysisName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnalysisName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnalysisName"/> constructed from the provided ids.</returns>
        public static AnalysisName FromProjectLocationConversationAnalysis(string projectId, string locationId, string conversationId, string analysisId) =>
            new AnalysisName(ResourceNameType.ProjectLocationConversationAnalysis, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), analysisId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationId, string analysisId) =>
            FormatProjectLocationConversationAnalysis(projectId, locationId, conversationId, analysisId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationAnalysis(string projectId, string locationId, string conversationId, string analysisId) =>
            s_projectLocationConversationAnalysis.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnalysisName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnalysisName"/> if successful.</returns>
        public static AnalysisName Parse(string analysisName) => Parse(analysisName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalysisName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnalysisName"/> if successful.</returns>
        public static AnalysisName Parse(string analysisName, bool allowUnparsed) =>
            TryParse(analysisName, allowUnparsed, out AnalysisName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisName, out AnalysisName result) => TryParse(analysisName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisName, bool allowUnparsed, out AnalysisName result)
        {
            gax::GaxPreconditions.CheckNotNull(analysisName, nameof(analysisName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversationAnalysis.TryParseName(analysisName, out resourceName))
            {
                result = FromProjectLocationConversationAnalysis(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(analysisName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnalysisName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string analysisId = null, string conversationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnalysisId = analysisId;
            ConversationId = conversationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnalysisName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/analyses/{analysis}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        public AnalysisName(string projectId, string locationId, string conversationId, string analysisId) : this(ResourceNameType.ProjectLocationConversationAnalysis, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), analysisId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)))
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
        /// The <c>Analysis</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AnalysisId { get; }

        /// <summary>
        /// The <c>Conversation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversationId { get; }

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
                case ResourceNameType.ProjectLocationConversationAnalysis: return s_projectLocationConversationAnalysis.Expand(ProjectId, LocationId, ConversationId, AnalysisId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnalysisName);

        /// <inheritdoc/>
        public bool Equals(AnalysisName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnalysisName a, AnalysisName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnalysisName a, AnalysisName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FeedbackLabel</c> resource.</summary>
    public sealed partial class FeedbackLabelName : gax::IResourceName, sys::IEquatable<FeedbackLabelName>
    {
        /// <summary>The possible contents of <see cref="FeedbackLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>
            /// .
            /// </summary>
            ProjectLocationConversationFeedbackLabel = 1,
        }

        private static gax::PathTemplate s_projectLocationConversationFeedbackLabel = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}");

        /// <summary>Creates a <see cref="FeedbackLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedbackLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedbackLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedbackLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedbackLabelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedbackLabelId">The <c>FeedbackLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedbackLabelName"/> constructed from the provided ids.</returns>
        public static FeedbackLabelName FromProjectLocationConversationFeedbackLabel(string projectId, string locationId, string conversationId, string feedbackLabelId) =>
            new FeedbackLabelName(ResourceNameType.ProjectLocationConversationFeedbackLabel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), feedbackLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedbackLabelId, nameof(feedbackLabelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedbackLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedbackLabelId">The <c>FeedbackLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedbackLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationId, string feedbackLabelId) =>
            FormatProjectLocationConversationFeedbackLabel(projectId, locationId, conversationId, feedbackLabelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedbackLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedbackLabelId">The <c>FeedbackLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedbackLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationFeedbackLabel(string projectId, string locationId, string conversationId, string feedbackLabelId) =>
            s_projectLocationConversationFeedbackLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedbackLabelId, nameof(feedbackLabelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedbackLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedbackLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedbackLabelName"/> if successful.</returns>
        public static FeedbackLabelName Parse(string feedbackLabelName) => Parse(feedbackLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedbackLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedbackLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedbackLabelName"/> if successful.</returns>
        public static FeedbackLabelName Parse(string feedbackLabelName, bool allowUnparsed) =>
            TryParse(feedbackLabelName, allowUnparsed, out FeedbackLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedbackLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedbackLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedbackLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedbackLabelName, out FeedbackLabelName result) =>
            TryParse(feedbackLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedbackLabelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedbackLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedbackLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedbackLabelName, bool allowUnparsed, out FeedbackLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedbackLabelName, nameof(feedbackLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversationFeedbackLabel.TryParseName(feedbackLabelName, out resourceName))
            {
                result = FromProjectLocationConversationFeedbackLabel(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedbackLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedbackLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationId = null, string feedbackLabelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationId = conversationId;
            FeedbackLabelId = feedbackLabelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedbackLabelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/feedbackLabels/{feedback_label}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedbackLabelId">The <c>FeedbackLabel</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedbackLabelName(string projectId, string locationId, string conversationId, string feedbackLabelId) : this(ResourceNameType.ProjectLocationConversationFeedbackLabel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), feedbackLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedbackLabelId, nameof(feedbackLabelId)))
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
        /// The <c>Conversation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversationId { get; }

        /// <summary>
        /// The <c>FeedbackLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeedbackLabelId { get; }

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
                case ResourceNameType.ProjectLocationConversationFeedbackLabel: return s_projectLocationConversationFeedbackLabel.Expand(ProjectId, LocationId, ConversationId, FeedbackLabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedbackLabelName);

        /// <inheritdoc/>
        public bool Equals(FeedbackLabelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeedbackLabelName a, FeedbackLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeedbackLabelName a, FeedbackLabelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IssueModel</c> resource.</summary>
    public sealed partial class IssueModelName : gax::IResourceName, sys::IEquatable<IssueModelName>
    {
        /// <summary>The possible contents of <see cref="IssueModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
            /// </summary>
            ProjectLocationIssueModel = 1,
        }

        private static gax::PathTemplate s_projectLocationIssueModel = new gax::PathTemplate("projects/{project}/locations/{location}/issueModels/{issue_model}");

        /// <summary>Creates a <see cref="IssueModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IssueModelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IssueModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IssueModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IssueModelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IssueModelName"/> constructed from the provided ids.</returns>
        public static IssueModelName FromProjectLocationIssueModel(string projectId, string locationId, string issueModelId) =>
            new IssueModelName(ResourceNameType.ProjectLocationIssueModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string issueModelId) =>
            FormatProjectLocationIssueModel(projectId, locationId, issueModelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>.
        /// </returns>
        public static string FormatProjectLocationIssueModel(string projectId, string locationId, string issueModelId) =>
            s_projectLocationIssueModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)));

        /// <summary>Parses the given resource name string into a new <see cref="IssueModelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IssueModelName"/> if successful.</returns>
        public static IssueModelName Parse(string issueModelName) => Parse(issueModelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IssueModelName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IssueModelName"/> if successful.</returns>
        public static IssueModelName Parse(string issueModelName, bool allowUnparsed) =>
            TryParse(issueModelName, allowUnparsed, out IssueModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueModelName, out IssueModelName result) =>
            TryParse(issueModelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/issueModels/{issue_model}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueModelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueModelName, bool allowUnparsed, out IssueModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(issueModelName, nameof(issueModelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationIssueModel.TryParseName(issueModelName, out resourceName))
            {
                result = FromProjectLocationIssueModel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(issueModelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IssueModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string issueModelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IssueModelId = issueModelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IssueModelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        public IssueModelName(string projectId, string locationId, string issueModelId) : this(ResourceNameType.ProjectLocationIssueModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)))
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
        /// The <c>IssueModel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueModelId { get; }

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
                case ResourceNameType.ProjectLocationIssueModel: return s_projectLocationIssueModel.Expand(ProjectId, LocationId, IssueModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IssueModelName);

        /// <inheritdoc/>
        public bool Equals(IssueModelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IssueModelName a, IssueModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IssueModelName a, IssueModelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Issue</c> resource.</summary>
    public sealed partial class IssueName : gax::IResourceName, sys::IEquatable<IssueName>
    {
        /// <summary>The possible contents of <see cref="IssueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
            /// </summary>
            ProjectLocationIssueModelIssue = 1,
        }

        private static gax::PathTemplate s_projectLocationIssueModelIssue = new gax::PathTemplate("projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}");

        /// <summary>Creates a <see cref="IssueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IssueName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IssueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IssueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IssueName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IssueName"/> constructed from the provided ids.</returns>
        public static IssueName FromProjectLocationIssueModelIssue(string projectId, string locationId, string issueModelId, string issueId) =>
            new IssueName(ResourceNameType.ProjectLocationIssueModelIssue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string issueModelId, string issueId) =>
            FormatProjectLocationIssueModelIssue(projectId, locationId, issueModelId, issueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>.
        /// </returns>
        public static string FormatProjectLocationIssueModelIssue(string projectId, string locationId, string issueModelId, string issueId) =>
            s_projectLocationIssueModelIssue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>Parses the given resource name string into a new <see cref="IssueName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IssueName"/> if successful.</returns>
        public static IssueName Parse(string issueName) => Parse(issueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IssueName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IssueName"/> if successful.</returns>
        public static IssueName Parse(string issueName, bool allowUnparsed) =>
            TryParse(issueName, allowUnparsed, out IssueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueName, out IssueName result) => TryParse(issueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueName, bool allowUnparsed, out IssueName result)
        {
            gax::GaxPreconditions.CheckNotNull(issueName, nameof(issueName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationIssueModelIssue.TryParseName(issueName, out resourceName))
            {
                result = FromProjectLocationIssueModelIssue(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(issueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IssueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string issueId = null, string issueModelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IssueId = issueId;
            IssueModelId = issueModelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IssueName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/issueModels/{issue_model}/issues/{issue}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueModelId">The <c>IssueModel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        public IssueName(string projectId, string locationId, string issueModelId, string issueId) : this(ResourceNameType.ProjectLocationIssueModelIssue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), issueModelId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueModelId, nameof(issueModelId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)))
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
        /// The <c>Issue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueId { get; }

        /// <summary>
        /// The <c>IssueModel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueModelId { get; }

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
                case ResourceNameType.ProjectLocationIssueModelIssue: return s_projectLocationIssueModelIssue.Expand(ProjectId, LocationId, IssueModelId, IssueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IssueName);

        /// <inheritdoc/>
        public bool Equals(IssueName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IssueName a, IssueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IssueName a, IssueName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PhraseMatcher</c> resource.</summary>
    public sealed partial class PhraseMatcherName : gax::IResourceName, sys::IEquatable<PhraseMatcherName>
    {
        /// <summary>The possible contents of <see cref="PhraseMatcherName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>
            /// .
            /// </summary>
            ProjectLocationPhraseMatcher = 1,
        }

        private static gax::PathTemplate s_projectLocationPhraseMatcher = new gax::PathTemplate("projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}");

        /// <summary>Creates a <see cref="PhraseMatcherName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PhraseMatcherName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PhraseMatcherName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PhraseMatcherName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PhraseMatcherName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PhraseMatcherName"/> constructed from the provided ids.</returns>
        public static PhraseMatcherName FromProjectLocationPhraseMatcher(string projectId, string locationId, string phraseMatcherId) =>
            new PhraseMatcherName(ResourceNameType.ProjectLocationPhraseMatcher, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phraseMatcherId: gax::GaxPreconditions.CheckNotNullOrEmpty(phraseMatcherId, nameof(phraseMatcherId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string phraseMatcherId) =>
            FormatProjectLocationPhraseMatcher(projectId, locationId, phraseMatcherId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhraseMatcherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>.
        /// </returns>
        public static string FormatProjectLocationPhraseMatcher(string projectId, string locationId, string phraseMatcherId) =>
            s_projectLocationPhraseMatcher.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(phraseMatcherId, nameof(phraseMatcherId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhraseMatcherName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PhraseMatcherName"/> if successful.</returns>
        public static PhraseMatcherName Parse(string phraseMatcherName) => Parse(phraseMatcherName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhraseMatcherName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PhraseMatcherName"/> if successful.</returns>
        public static PhraseMatcherName Parse(string phraseMatcherName, bool allowUnparsed) =>
            TryParse(phraseMatcherName, allowUnparsed, out PhraseMatcherName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhraseMatcherName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhraseMatcherName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phraseMatcherName, out PhraseMatcherName result) =>
            TryParse(phraseMatcherName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhraseMatcherName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phraseMatcherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhraseMatcherName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phraseMatcherName, bool allowUnparsed, out PhraseMatcherName result)
        {
            gax::GaxPreconditions.CheckNotNull(phraseMatcherName, nameof(phraseMatcherName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPhraseMatcher.TryParseName(phraseMatcherName, out resourceName))
            {
                result = FromProjectLocationPhraseMatcher(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(phraseMatcherName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PhraseMatcherName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string phraseMatcherId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PhraseMatcherId = phraseMatcherId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PhraseMatcherName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/phraseMatchers/{phrase_matcher}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseMatcherId">The <c>PhraseMatcher</c> ID. Must not be <c>null</c> or empty.</param>
        public PhraseMatcherName(string projectId, string locationId, string phraseMatcherId) : this(ResourceNameType.ProjectLocationPhraseMatcher, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phraseMatcherId: gax::GaxPreconditions.CheckNotNullOrEmpty(phraseMatcherId, nameof(phraseMatcherId)))
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
        /// The <c>PhraseMatcher</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PhraseMatcherId { get; }

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
                case ResourceNameType.ProjectLocationPhraseMatcher: return s_projectLocationPhraseMatcher.Expand(ProjectId, LocationId, PhraseMatcherId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PhraseMatcherName);

        /// <inheritdoc/>
        public bool Equals(PhraseMatcherName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PhraseMatcherName a, PhraseMatcherName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PhraseMatcherName a, PhraseMatcherName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}/settings</c>.</summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>projects/{project}/locations/{location}/settings</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectLocation(string projectId, string locationId) =>
            new SettingsName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/settings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AnalysisRule</c> resource.</summary>
    public sealed partial class AnalysisRuleName : gax::IResourceName, sys::IEquatable<AnalysisRuleName>
    {
        /// <summary>The possible contents of <see cref="AnalysisRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>
            /// .
            /// </summary>
            ProjectLocationAnalysisRule = 1,
        }

        private static gax::PathTemplate s_projectLocationAnalysisRule = new gax::PathTemplate("projects/{project}/locations/{location}/analysisRules/{analysis_rule}");

        /// <summary>Creates a <see cref="AnalysisRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnalysisRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnalysisRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnalysisRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnalysisRuleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisRuleId">The <c>AnalysisRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnalysisRuleName"/> constructed from the provided ids.</returns>
        public static AnalysisRuleName FromProjectLocationAnalysisRule(string projectId, string locationId, string analysisRuleId) =>
            new AnalysisRuleName(ResourceNameType.ProjectLocationAnalysisRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), analysisRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisRuleId, nameof(analysisRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisRuleId">The <c>AnalysisRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string analysisRuleId) =>
            FormatProjectLocationAnalysisRule(projectId, locationId, analysisRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisRuleId">The <c>AnalysisRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>.
        /// </returns>
        public static string FormatProjectLocationAnalysisRule(string projectId, string locationId, string analysisRuleId) =>
            s_projectLocationAnalysisRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analysisRuleId, nameof(analysisRuleId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnalysisRuleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnalysisRuleName"/> if successful.</returns>
        public static AnalysisRuleName Parse(string analysisRuleName) => Parse(analysisRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalysisRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnalysisRuleName"/> if successful.</returns>
        public static AnalysisRuleName Parse(string analysisRuleName, bool allowUnparsed) =>
            TryParse(analysisRuleName, allowUnparsed, out AnalysisRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisRuleName, out AnalysisRuleName result) =>
            TryParse(analysisRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisRuleName, bool allowUnparsed, out AnalysisRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(analysisRuleName, nameof(analysisRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAnalysisRule.TryParseName(analysisRuleName, out resourceName))
            {
                result = FromProjectLocationAnalysisRule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(analysisRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnalysisRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string analysisRuleId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnalysisRuleId = analysisRuleId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnalysisRuleName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/analysisRules/{analysis_rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisRuleId">The <c>AnalysisRule</c> ID. Must not be <c>null</c> or empty.</param>
        public AnalysisRuleName(string projectId, string locationId, string analysisRuleId) : this(ResourceNameType.ProjectLocationAnalysisRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), analysisRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisRuleId, nameof(analysisRuleId)))
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
        /// The <c>AnalysisRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnalysisRuleId { get; }

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
                case ResourceNameType.ProjectLocationAnalysisRule: return s_projectLocationAnalysisRule.Expand(ProjectId, LocationId, AnalysisRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnalysisRuleName);

        /// <inheritdoc/>
        public bool Equals(AnalysisRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnalysisRuleName a, AnalysisRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnalysisRuleName a, AnalysisRuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EncryptionSpec</c> resource.</summary>
    public sealed partial class EncryptionSpecName : gax::IResourceName, sys::IEquatable<EncryptionSpecName>
    {
        /// <summary>The possible contents of <see cref="EncryptionSpecName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/encryptionSpec</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/encryptionSpec");

        /// <summary>Creates a <see cref="EncryptionSpecName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EncryptionSpecName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EncryptionSpecName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EncryptionSpecName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EncryptionSpecName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/encryptionSpec</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EncryptionSpecName"/> constructed from the provided ids.</returns>
        public static EncryptionSpecName FromProjectLocation(string projectId, string locationId) =>
            new EncryptionSpecName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EncryptionSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/encryptionSpec</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EncryptionSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/encryptionSpec</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EncryptionSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/encryptionSpec</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EncryptionSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/encryptionSpec</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EncryptionSpecName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/encryptionSpec</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="encryptionSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EncryptionSpecName"/> if successful.</returns>
        public static EncryptionSpecName Parse(string encryptionSpecName) => Parse(encryptionSpecName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EncryptionSpecName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/encryptionSpec</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="encryptionSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EncryptionSpecName"/> if successful.</returns>
        public static EncryptionSpecName Parse(string encryptionSpecName, bool allowUnparsed) =>
            TryParse(encryptionSpecName, allowUnparsed, out EncryptionSpecName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EncryptionSpecName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/encryptionSpec</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="encryptionSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EncryptionSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string encryptionSpecName, out EncryptionSpecName result) =>
            TryParse(encryptionSpecName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EncryptionSpecName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/encryptionSpec</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="encryptionSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EncryptionSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string encryptionSpecName, bool allowUnparsed, out EncryptionSpecName result)
        {
            gax::GaxPreconditions.CheckNotNull(encryptionSpecName, nameof(encryptionSpecName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(encryptionSpecName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(encryptionSpecName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EncryptionSpecName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EncryptionSpecName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/encryptionSpec</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public EncryptionSpecName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EncryptionSpecName);

        /// <inheritdoc/>
        public bool Equals(EncryptionSpecName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EncryptionSpecName a, EncryptionSpecName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EncryptionSpecName a, EncryptionSpecName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>View</c> resource.</summary>
    public sealed partial class ViewName : gax::IResourceName, sys::IEquatable<ViewName>
    {
        /// <summary>The possible contents of <see cref="ViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/views/{view}</c>.
            /// </summary>
            ProjectLocationView = 1,
        }

        private static gax::PathTemplate s_projectLocationView = new gax::PathTemplate("projects/{project}/locations/{location}/views/{view}");

        /// <summary>Creates a <see cref="ViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ViewName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ViewName"/> with the pattern <c>projects/{project}/locations/{location}/views/{view}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ViewName"/> constructed from the provided ids.</returns>
        public static ViewName FromProjectLocationView(string projectId, string locationId, string viewId) =>
            new ViewName(ResourceNameType.ProjectLocationView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/views/{view}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string viewId) =>
            FormatProjectLocationView(projectId, locationId, viewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/views/{view}</c>.
        /// </returns>
        public static string FormatProjectLocationView(string projectId, string locationId, string viewId) =>
            s_projectLocationView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>Parses the given resource name string into a new <see cref="ViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/views/{view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ViewName"/> if successful.</returns>
        public static ViewName Parse(string viewName) => Parse(viewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ViewName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/views/{view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ViewName"/> if successful.</returns>
        public static ViewName Parse(string viewName, bool allowUnparsed) =>
            TryParse(viewName, allowUnparsed, out ViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/views/{view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string viewName, out ViewName result) => TryParse(viewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/views/{view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string viewName, bool allowUnparsed, out ViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(viewName, nameof(viewName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationView.TryParseName(viewName, out resourceName))
            {
                result = FromProjectLocationView(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(viewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string viewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ViewId = viewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ViewName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/views/{view}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        public ViewName(string projectId, string locationId, string viewId) : this(ResourceNameType.ProjectLocationView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)))
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
        /// The <c>View</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationView: return s_projectLocationView.Expand(ProjectId, LocationId, ViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ViewName);

        /// <inheritdoc/>
        public bool Equals(ViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ViewName a, ViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ViewName a, ViewName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>QaQuestion</c> resource.</summary>
    public sealed partial class QaQuestionName : gax::IResourceName, sys::IEquatable<QaQuestionName>
    {
        /// <summary>The possible contents of <see cref="QaQuestionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
            /// .
            /// </summary>
            ProjectLocationQaScorecardRevisionQaQuestion = 1,
        }

        private static gax::PathTemplate s_projectLocationQaScorecardRevisionQaQuestion = new gax::PathTemplate("projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}");

        /// <summary>Creates a <see cref="QaQuestionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QaQuestionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QaQuestionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QaQuestionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QaQuestionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaQuestionId">The <c>QaQuestion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QaQuestionName"/> constructed from the provided ids.</returns>
        public static QaQuestionName FromProjectLocationQaScorecardRevisionQaQuestion(string projectId, string locationId, string qaScorecardId, string revisionId, string qaQuestionId) =>
            new QaQuestionName(ResourceNameType.ProjectLocationQaScorecardRevisionQaQuestion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)), qaQuestionId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaQuestionId, nameof(qaQuestionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaQuestionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaQuestionId">The <c>QaQuestion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaQuestionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string qaScorecardId, string revisionId, string qaQuestionId) =>
            FormatProjectLocationQaScorecardRevisionQaQuestion(projectId, locationId, qaScorecardId, revisionId, qaQuestionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaQuestionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaQuestionId">The <c>QaQuestion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaQuestionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationQaScorecardRevisionQaQuestion(string projectId, string locationId, string qaScorecardId, string revisionId, string qaQuestionId) =>
            s_projectLocationQaScorecardRevisionQaQuestion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(qaQuestionId, nameof(qaQuestionId)));

        /// <summary>Parses the given resource name string into a new <see cref="QaQuestionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QaQuestionName"/> if successful.</returns>
        public static QaQuestionName Parse(string qaQuestionName) => Parse(qaQuestionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QaQuestionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QaQuestionName"/> if successful.</returns>
        public static QaQuestionName Parse(string qaQuestionName, bool allowUnparsed) =>
            TryParse(qaQuestionName, allowUnparsed, out QaQuestionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaQuestionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaQuestionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaQuestionName, out QaQuestionName result) =>
            TryParse(qaQuestionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaQuestionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaQuestionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaQuestionName, bool allowUnparsed, out QaQuestionName result)
        {
            gax::GaxPreconditions.CheckNotNull(qaQuestionName, nameof(qaQuestionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQaScorecardRevisionQaQuestion.TryParseName(qaQuestionName, out resourceName))
            {
                result = FromProjectLocationQaScorecardRevisionQaQuestion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(qaQuestionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QaQuestionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string qaQuestionId = null, string qaScorecardId = null, string revisionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            QaQuestionId = qaQuestionId;
            QaScorecardId = qaScorecardId;
            RevisionId = revisionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QaQuestionName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}/qaQuestions/{qa_question}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaQuestionId">The <c>QaQuestion</c> ID. Must not be <c>null</c> or empty.</param>
        public QaQuestionName(string projectId, string locationId, string qaScorecardId, string revisionId, string qaQuestionId) : this(ResourceNameType.ProjectLocationQaScorecardRevisionQaQuestion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)), qaQuestionId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaQuestionId, nameof(qaQuestionId)))
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
        /// The <c>QaQuestion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QaQuestionId { get; }

        /// <summary>
        /// The <c>QaScorecard</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QaScorecardId { get; }

        /// <summary>
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQaScorecardRevisionQaQuestion: return s_projectLocationQaScorecardRevisionQaQuestion.Expand(ProjectId, LocationId, QaScorecardId, RevisionId, QaQuestionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QaQuestionName);

        /// <inheritdoc/>
        public bool Equals(QaQuestionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QaQuestionName a, QaQuestionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QaQuestionName a, QaQuestionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>QaScorecard</c> resource.</summary>
    public sealed partial class QaScorecardName : gax::IResourceName, sys::IEquatable<QaScorecardName>
    {
        /// <summary>The possible contents of <see cref="QaScorecardName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>.
            /// </summary>
            ProjectLocationQaScorecard = 1,
        }

        private static gax::PathTemplate s_projectLocationQaScorecard = new gax::PathTemplate("projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}");

        /// <summary>Creates a <see cref="QaScorecardName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QaScorecardName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QaScorecardName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QaScorecardName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QaScorecardName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QaScorecardName"/> constructed from the provided ids.</returns>
        public static QaScorecardName FromProjectLocationQaScorecard(string projectId, string locationId, string qaScorecardId) =>
            new QaScorecardName(ResourceNameType.ProjectLocationQaScorecard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaScorecardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaScorecardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string qaScorecardId) =>
            FormatProjectLocationQaScorecard(projectId, locationId, qaScorecardId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaScorecardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaScorecardName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>.
        /// </returns>
        public static string FormatProjectLocationQaScorecard(string projectId, string locationId, string qaScorecardId) =>
            s_projectLocationQaScorecard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)));

        /// <summary>Parses the given resource name string into a new <see cref="QaScorecardName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaScorecardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QaScorecardName"/> if successful.</returns>
        public static QaScorecardName Parse(string qaScorecardName) => Parse(qaScorecardName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QaScorecardName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaScorecardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QaScorecardName"/> if successful.</returns>
        public static QaScorecardName Parse(string qaScorecardName, bool allowUnparsed) =>
            TryParse(qaScorecardName, allowUnparsed, out QaScorecardName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaScorecardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaScorecardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaScorecardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaScorecardName, out QaScorecardName result) =>
            TryParse(qaScorecardName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaScorecardName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaScorecardName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaScorecardName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaScorecardName, bool allowUnparsed, out QaScorecardName result)
        {
            gax::GaxPreconditions.CheckNotNull(qaScorecardName, nameof(qaScorecardName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQaScorecard.TryParseName(qaScorecardName, out resourceName))
            {
                result = FromProjectLocationQaScorecard(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(qaScorecardName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QaScorecardName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string qaScorecardId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            QaScorecardId = qaScorecardId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QaScorecardName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        public QaScorecardName(string projectId, string locationId, string qaScorecardId) : this(ResourceNameType.ProjectLocationQaScorecard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)))
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
        /// The <c>QaScorecard</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QaScorecardId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQaScorecard: return s_projectLocationQaScorecard.Expand(ProjectId, LocationId, QaScorecardId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QaScorecardName);

        /// <inheritdoc/>
        public bool Equals(QaScorecardName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QaScorecardName a, QaScorecardName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QaScorecardName a, QaScorecardName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>QaScorecardRevision</c> resource.</summary>
    public sealed partial class QaScorecardRevisionName : gax::IResourceName, sys::IEquatable<QaScorecardRevisionName>
    {
        /// <summary>The possible contents of <see cref="QaScorecardRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>.
            /// </summary>
            ProjectLocationQaScorecardRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationQaScorecardRevision = new gax::PathTemplate("projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}");

        /// <summary>Creates a <see cref="QaScorecardRevisionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QaScorecardRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QaScorecardRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QaScorecardRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QaScorecardRevisionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="QaScorecardRevisionName"/> constructed from the provided ids.
        /// </returns>
        public static QaScorecardRevisionName FromProjectLocationQaScorecardRevision(string projectId, string locationId, string qaScorecardId, string revisionId) =>
            new QaScorecardRevisionName(ResourceNameType.ProjectLocationQaScorecardRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaScorecardRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaScorecardRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string qaScorecardId, string revisionId) =>
            FormatProjectLocationQaScorecardRevision(projectId, locationId, qaScorecardId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaScorecardRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaScorecardRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>.
        /// </returns>
        public static string FormatProjectLocationQaScorecardRevision(string projectId, string locationId, string qaScorecardId, string revisionId) =>
            s_projectLocationQaScorecardRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QaScorecardRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaScorecardRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QaScorecardRevisionName"/> if successful.</returns>
        public static QaScorecardRevisionName Parse(string qaScorecardRevisionName) => Parse(qaScorecardRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QaScorecardRevisionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaScorecardRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QaScorecardRevisionName"/> if successful.</returns>
        public static QaScorecardRevisionName Parse(string qaScorecardRevisionName, bool allowUnparsed) =>
            TryParse(qaScorecardRevisionName, allowUnparsed, out QaScorecardRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaScorecardRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaScorecardRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaScorecardRevisionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaScorecardRevisionName, out QaScorecardRevisionName result) =>
            TryParse(qaScorecardRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaScorecardRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaScorecardRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaScorecardRevisionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaScorecardRevisionName, bool allowUnparsed, out QaScorecardRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(qaScorecardRevisionName, nameof(qaScorecardRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQaScorecardRevision.TryParseName(qaScorecardRevisionName, out resourceName))
            {
                result = FromProjectLocationQaScorecardRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(qaScorecardRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QaScorecardRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string qaScorecardId = null, string revisionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            QaScorecardId = qaScorecardId;
            RevisionId = revisionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QaScorecardRevisionName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/qaScorecards/{qa_scorecard}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardId">The <c>QaScorecard</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public QaScorecardRevisionName(string projectId, string locationId, string qaScorecardId, string revisionId) : this(ResourceNameType.ProjectLocationQaScorecardRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardId, nameof(qaScorecardId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
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
        /// The <c>QaScorecard</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QaScorecardId { get; }

        /// <summary>
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQaScorecardRevision: return s_projectLocationQaScorecardRevision.Expand(ProjectId, LocationId, QaScorecardId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QaScorecardRevisionName);

        /// <inheritdoc/>
        public bool Equals(QaScorecardRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QaScorecardRevisionName a, QaScorecardRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QaScorecardRevisionName a, QaScorecardRevisionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>QaScorecardResult</c> resource.</summary>
    public sealed partial class QaScorecardResultName : gax::IResourceName, sys::IEquatable<QaScorecardResultName>
    {
        /// <summary>The possible contents of <see cref="QaScorecardResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>.
            /// </summary>
            ProjectLocationQaScorecardResult = 1,
        }

        private static gax::PathTemplate s_projectLocationQaScorecardResult = new gax::PathTemplate("projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}");

        /// <summary>Creates a <see cref="QaScorecardResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QaScorecardResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QaScorecardResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QaScorecardResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QaScorecardResultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardResultId">The <c>QaScorecardResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QaScorecardResultName"/> constructed from the provided ids.</returns>
        public static QaScorecardResultName FromProjectLocationQaScorecardResult(string projectId, string locationId, string qaScorecardResultId) =>
            new QaScorecardResultName(ResourceNameType.ProjectLocationQaScorecardResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardResultId, nameof(qaScorecardResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaScorecardResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardResultId">The <c>QaScorecardResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaScorecardResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string qaScorecardResultId) =>
            FormatProjectLocationQaScorecardResult(projectId, locationId, qaScorecardResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QaScorecardResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardResultId">The <c>QaScorecardResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QaScorecardResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>.
        /// </returns>
        public static string FormatProjectLocationQaScorecardResult(string projectId, string locationId, string qaScorecardResultId) =>
            s_projectLocationQaScorecardResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardResultId, nameof(qaScorecardResultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QaScorecardResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaScorecardResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QaScorecardResultName"/> if successful.</returns>
        public static QaScorecardResultName Parse(string qaScorecardResultName) => Parse(qaScorecardResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QaScorecardResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaScorecardResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QaScorecardResultName"/> if successful.</returns>
        public static QaScorecardResultName Parse(string qaScorecardResultName, bool allowUnparsed) =>
            TryParse(qaScorecardResultName, allowUnparsed, out QaScorecardResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaScorecardResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="qaScorecardResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaScorecardResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaScorecardResultName, out QaScorecardResultName result) =>
            TryParse(qaScorecardResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QaScorecardResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qaScorecardResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QaScorecardResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qaScorecardResultName, bool allowUnparsed, out QaScorecardResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(qaScorecardResultName, nameof(qaScorecardResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQaScorecardResult.TryParseName(qaScorecardResultName, out resourceName))
            {
                result = FromProjectLocationQaScorecardResult(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(qaScorecardResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QaScorecardResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string qaScorecardResultId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            QaScorecardResultId = qaScorecardResultId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QaScorecardResultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/qaScorecardResults/{qa_scorecard_result}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="qaScorecardResultId">The <c>QaScorecardResult</c> ID. Must not be <c>null</c> or empty.</param>
        public QaScorecardResultName(string projectId, string locationId, string qaScorecardResultId) : this(ResourceNameType.ProjectLocationQaScorecardResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), qaScorecardResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(qaScorecardResultId, nameof(qaScorecardResultId)))
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
        /// The <c>QaScorecardResult</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string QaScorecardResultId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQaScorecardResult: return s_projectLocationQaScorecardResult.Expand(ProjectId, LocationId, QaScorecardResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QaScorecardResultName);

        /// <inheritdoc/>
        public bool Equals(QaScorecardResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QaScorecardResultName a, QaScorecardResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QaScorecardResultName a, QaScorecardResultName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ConversationProfile</c> resource.</summary>
    public sealed partial class ConversationProfileName : gax::IResourceName, sys::IEquatable<ConversationProfileName>
    {
        /// <summary>The possible contents of <see cref="ConversationProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
            /// </summary>
            ProjectLocationConversationProfile = 1,
        }

        private static gax::PathTemplate s_projectLocationConversationProfile = new gax::PathTemplate("projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}");

        /// <summary>Creates a <see cref="ConversationProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversationProfileName"/> constructed from the provided ids.
        /// </returns>
        public static ConversationProfileName FromProjectLocationConversationProfile(string projectId, string locationId, string conversationProfileId) =>
            new ConversationProfileName(ResourceNameType.ProjectLocationConversationProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationProfileId) =>
            FormatProjectLocationConversationProfile(projectId, locationId, conversationProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationProfile(string projectId, string locationId, string conversationProfileId) =>
            s_projectLocationConversationProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversationProfileName"/> if successful.</returns>
        public static ConversationProfileName Parse(string conversationProfileName) => Parse(conversationProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationProfileName"/> if successful.</returns>
        public static ConversationProfileName Parse(string conversationProfileName, bool allowUnparsed) =>
            TryParse(conversationProfileName, allowUnparsed, out ConversationProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationProfileName, out ConversationProfileName result) =>
            TryParse(conversationProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationProfileName, bool allowUnparsed, out ConversationProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationProfileName, nameof(conversationProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversationProfile.TryParseName(conversationProfileName, out resourceName))
            {
                result = FromProjectLocationConversationProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationProfileId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationProfileId = conversationProfileId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationProfileName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/conversationProfiles/{conversation_profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationProfileId">
        /// The <c>ConversationProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ConversationProfileName(string projectId, string locationId, string conversationProfileId) : this(ResourceNameType.ProjectLocationConversationProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfileId, nameof(conversationProfileId)))
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
        /// The <c>ConversationProfile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ConversationProfileId { get; }

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
                case ResourceNameType.ProjectLocationConversationProfile: return s_projectLocationConversationProfile.Expand(ProjectId, LocationId, ConversationProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationProfileName);

        /// <inheritdoc/>
        public bool Equals(ConversationProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversationProfileName a, ConversationProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversationProfileName a, ConversationProfileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Participant</c> resource.</summary>
    public sealed partial class ParticipantName : gax::IResourceName, sys::IEquatable<ParticipantName>
    {
        /// <summary>The possible contents of <see cref="ParticipantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
            /// </summary>
            ProjectConversationParticipant = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
            /// </summary>
            ProjectLocationConversationParticipant = 2,
        }

        private static gax::PathTemplate s_projectConversationParticipant = new gax::PathTemplate("projects/{project}/conversations/{conversation}/participants/{participant}");

        private static gax::PathTemplate s_projectLocationConversationParticipant = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}");

        /// <summary>Creates a <see cref="ParticipantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParticipantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParticipantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParticipantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParticipantName"/> with the pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParticipantName"/> constructed from the provided ids.</returns>
        public static ParticipantName FromProjectConversationParticipant(string projectId, string conversationId, string participantId) =>
            new ParticipantName(ResourceNameType.ProjectConversationParticipant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Creates a <see cref="ParticipantName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParticipantName"/> constructed from the provided ids.</returns>
        public static ParticipantName FromProjectLocationConversationParticipant(string projectId, string locationId, string conversationId, string participantId) =>
            new ParticipantName(ResourceNameType.ProjectLocationConversationParticipant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </returns>
        public static string Format(string projectId, string conversationId, string participantId) =>
            FormatProjectConversationParticipant(projectId, conversationId, participantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>.
        /// </returns>
        public static string FormatProjectConversationParticipant(string projectId, string conversationId, string participantId) =>
            s_projectConversationParticipant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationParticipant(string projectId, string locationId, string conversationId, string participantId) =>
            s_projectLocationConversationParticipant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>Parses the given resource name string into a new <see cref="ParticipantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParticipantName"/> if successful.</returns>
        public static ParticipantName Parse(string participantName) => Parse(participantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParticipantName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParticipantName"/> if successful.</returns>
        public static ParticipantName Parse(string participantName, bool allowUnparsed) =>
            TryParse(participantName, allowUnparsed, out ParticipantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantName, out ParticipantName result) =>
            TryParse(participantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantName, bool allowUnparsed, out ParticipantName result)
        {
            gax::GaxPreconditions.CheckNotNull(participantName, nameof(participantName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConversationParticipant.TryParseName(participantName, out resourceName))
            {
                result = FromProjectConversationParticipant(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationConversationParticipant.TryParseName(participantName, out resourceName))
            {
                result = FromProjectLocationConversationParticipant(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(participantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParticipantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationId = null, string locationId = null, string participantId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationId = conversationId;
            LocationId = locationId;
            ParticipantId = participantId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParticipantName"/> class from the component parts of pattern
        /// <c>projects/{project}/conversations/{conversation}/participants/{participant}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        public ParticipantName(string projectId, string conversationId, string participantId) : this(ResourceNameType.ProjectConversationParticipant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)))
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
        /// The <c>Conversation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConversationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Participant</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ParticipantId { get; }

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
                case ResourceNameType.ProjectConversationParticipant: return s_projectConversationParticipant.Expand(ProjectId, ConversationId, ParticipantId);
                case ResourceNameType.ProjectLocationConversationParticipant: return s_projectLocationConversationParticipant.Expand(ProjectId, LocationId, ConversationId, ParticipantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParticipantName);

        /// <inheritdoc/>
        public bool Equals(ParticipantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ParticipantName a, ParticipantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ParticipantName a, ParticipantName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Recognizer</c> resource.</summary>
    public sealed partial class RecognizerName : gax::IResourceName, sys::IEquatable<RecognizerName>
    {
        /// <summary>The possible contents of <see cref="RecognizerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>.
            /// </summary>
            ProjectLocationRecognizer = 1,
        }

        private static gax::PathTemplate s_projectLocationRecognizer = new gax::PathTemplate("projects/{project}/locations/{location}/recognizers/{recognizer}");

        /// <summary>Creates a <see cref="RecognizerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecognizerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecognizerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecognizerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecognizerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recognizerId">The <c>Recognizer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecognizerName"/> constructed from the provided ids.</returns>
        public static RecognizerName FromProjectLocationRecognizer(string projectId, string locationId, string recognizerId) =>
            new RecognizerName(ResourceNameType.ProjectLocationRecognizer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recognizerId: gax::GaxPreconditions.CheckNotNullOrEmpty(recognizerId, nameof(recognizerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecognizerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recognizerId">The <c>Recognizer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecognizerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string recognizerId) =>
            FormatProjectLocationRecognizer(projectId, locationId, recognizerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecognizerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recognizerId">The <c>Recognizer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecognizerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>.
        /// </returns>
        public static string FormatProjectLocationRecognizer(string projectId, string locationId, string recognizerId) =>
            s_projectLocationRecognizer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recognizerId, nameof(recognizerId)));

        /// <summary>Parses the given resource name string into a new <see cref="RecognizerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recognizers/{recognizer}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recognizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecognizerName"/> if successful.</returns>
        public static RecognizerName Parse(string recognizerName) => Parse(recognizerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecognizerName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recognizers/{recognizer}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recognizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecognizerName"/> if successful.</returns>
        public static RecognizerName Parse(string recognizerName, bool allowUnparsed) =>
            TryParse(recognizerName, allowUnparsed, out RecognizerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecognizerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recognizers/{recognizer}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recognizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecognizerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recognizerName, out RecognizerName result) =>
            TryParse(recognizerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecognizerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recognizers/{recognizer}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recognizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecognizerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recognizerName, bool allowUnparsed, out RecognizerName result)
        {
            gax::GaxPreconditions.CheckNotNull(recognizerName, nameof(recognizerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRecognizer.TryParseName(recognizerName, out resourceName))
            {
                result = FromProjectLocationRecognizer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recognizerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecognizerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string recognizerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RecognizerId = recognizerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecognizerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/recognizers/{recognizer}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recognizerId">The <c>Recognizer</c> ID. Must not be <c>null</c> or empty.</param>
        public RecognizerName(string projectId, string locationId, string recognizerId) : this(ResourceNameType.ProjectLocationRecognizer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recognizerId: gax::GaxPreconditions.CheckNotNullOrEmpty(recognizerId, nameof(recognizerId)))
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
        /// The <c>Recognizer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RecognizerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRecognizer: return s_projectLocationRecognizer.Expand(ProjectId, LocationId, RecognizerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecognizerName);

        /// <inheritdoc/>
        public bool Equals(RecognizerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RecognizerName a, RecognizerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RecognizerName a, RecognizerName b) => !(a == b);
    }

    public partial class Conversation
    {
        /// <summary>
        /// <see cref="gccv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Analysis
    {
        /// <summary>
        /// <see cref="gccv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IssueModelResult
    {
        /// <summary>
        /// <see cref="IssueModelName"/>-typed view over the <see cref="IssueModel"/> resource name property.
        /// </summary>
        public IssueModelName IssueModelAsIssueModelName
        {
            get => string.IsNullOrEmpty(IssueModel) ? null : IssueModelName.Parse(IssueModel, allowUnparsed: true);
            set => IssueModel = value?.ToString() ?? "";
        }
    }

    public partial class FeedbackLabel
    {
        /// <summary>
        /// <see cref="gccv::FeedbackLabelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedbackLabelName FeedbackLabelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedbackLabelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IssueModel
    {
        /// <summary>
        /// <see cref="gccv::IssueModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueModelName IssueModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Issue
    {
        /// <summary>
        /// <see cref="gccv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PhraseMatcher
    {
        /// <summary>
        /// <see cref="gccv::PhraseMatcherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PhraseMatcherName PhraseMatcherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PhraseMatcherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gccv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnalysisRule
    {
        /// <summary>
        /// <see cref="gccv::AnalysisRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AnalysisRuleName AnalysisRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AnalysisRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EncryptionSpec
    {
        /// <summary>
        /// <see cref="gccv::EncryptionSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EncryptionSpecName EncryptionSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EncryptionSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SpeechConfig
    {
        /// <summary>
        /// <see cref="RecognizerName"/>-typed view over the <see cref="SpeechRecognizer"/> resource name property.
        /// </summary>
        public RecognizerName SpeechRecognizerAsRecognizerName
        {
            get => string.IsNullOrEmpty(SpeechRecognizer) ? null : RecognizerName.Parse(SpeechRecognizer, allowUnparsed: true);
            set => SpeechRecognizer = value?.ToString() ?? "";
        }
    }

    public partial class ConversationParticipant
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="DialogflowParticipantName"/> resource name
        /// property.
        /// </summary>
        public ParticipantName DialogflowParticipantNameAsParticipantName
        {
            get => string.IsNullOrEmpty(DialogflowParticipantName) ? null : ParticipantName.Parse(DialogflowParticipantName, allowUnparsed: true);
            set => DialogflowParticipantName = value?.ToString() ?? "";
        }
    }

    public partial class View
    {
        /// <summary>
        /// <see cref="gccv::ViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ViewName ViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnnotatorSelector
    {
        /// <summary>
        /// <see cref="PhraseMatcherName"/>-typed view over the <see cref="PhraseMatchers"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PhraseMatcherName> PhraseMatchersAsPhraseMatcherNames
        {
            get => new gax::ResourceNameList<PhraseMatcherName>(PhraseMatchers, s => string.IsNullOrEmpty(s) ? null : PhraseMatcherName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="IssueModelName"/>-typed view over the <see cref="IssueModels"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<IssueModelName> IssueModelsAsIssueModelNames
        {
            get => new gax::ResourceNameList<IssueModelName>(IssueModels, s => string.IsNullOrEmpty(s) ? null : IssueModelName.Parse(s, allowUnparsed: true));
        }

        public partial class Types
        {
            public partial class SummarizationConfig
            {
                /// <summary>
                /// <see cref="ConversationProfileName"/>-typed view over the <see cref="ConversationProfile"/> resource
                /// name property.
                /// </summary>
                public ConversationProfileName ConversationProfileAsConversationProfileName
                {
                    get => string.IsNullOrEmpty(ConversationProfile) ? null : ConversationProfileName.Parse(ConversationProfile, allowUnparsed: true);
                    set => ConversationProfile = value?.ToString() ?? "";
                }
            }

            public partial class QaConfig
            {
                public partial class Types
                {
                    public partial class ScorecardList
                    {
                        /// <summary>
                        /// <see cref="QaScorecardRevisionName"/>-typed view over the <see cref="QaScorecardRevisions"/>
                        /// resource name property.
                        /// </summary>
                        public gax::ResourceNameList<QaScorecardRevisionName> QaScorecardRevisionsAsQaScorecardRevisionNames
                        {
                            get => new gax::ResourceNameList<QaScorecardRevisionName>(QaScorecardRevisions, s => string.IsNullOrEmpty(s) ? null : QaScorecardRevisionName.Parse(s, allowUnparsed: true));
                        }
                    }
                }
            }
        }
    }

    public partial class QaQuestion
    {
        /// <summary>
        /// <see cref="gccv::QaQuestionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::QaQuestionName QaQuestionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::QaQuestionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QaScorecard
    {
        /// <summary>
        /// <see cref="gccv::QaScorecardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::QaScorecardName QaScorecardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::QaScorecardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QaScorecardRevision
    {
        /// <summary>
        /// <see cref="gccv::QaScorecardRevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::QaScorecardRevisionName QaScorecardRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::QaScorecardRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QaAnswer
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Conversation"/> resource name property.
        /// </summary>
        public ConversationName ConversationAsConversationName
        {
            get => string.IsNullOrEmpty(Conversation) ? null : ConversationName.Parse(Conversation, allowUnparsed: true);
            set => Conversation = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="QaQuestionName"/>-typed view over the <see cref="QaQuestion"/> resource name property.
        /// </summary>
        public QaQuestionName QaQuestionAsQaQuestionName
        {
            get => string.IsNullOrEmpty(QaQuestion) ? null : QaQuestionName.Parse(QaQuestion, allowUnparsed: true);
            set => QaQuestion = value?.ToString() ?? "";
        }
    }

    public partial class QaScorecardResult
    {
        /// <summary>
        /// <see cref="gccv::QaScorecardResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::QaScorecardResultName QaScorecardResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::QaScorecardResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="QaScorecardRevisionName"/>-typed view over the <see cref="QaScorecardRevision"/> resource name
        /// property.
        /// </summary>
        public QaScorecardRevisionName QaScorecardRevisionAsQaScorecardRevisionName
        {
            get => string.IsNullOrEmpty(QaScorecardRevision) ? null : QaScorecardRevisionName.Parse(QaScorecardRevision, allowUnparsed: true);
            set => QaScorecardRevision = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Conversation"/> resource name property.
        /// </summary>
        public ConversationName ConversationAsConversationName
        {
            get => string.IsNullOrEmpty(Conversation) ? null : ConversationName.Parse(Conversation, allowUnparsed: true);
            set => Conversation = value?.ToString() ?? "";
        }
    }
}
