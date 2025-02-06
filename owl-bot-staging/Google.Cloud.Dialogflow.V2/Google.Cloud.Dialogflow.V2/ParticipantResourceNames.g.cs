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
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
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

    /// <summary>Resource name for the <c>Message</c> resource.</summary>
    public sealed partial class MessageName : gax::IResourceName, sys::IEquatable<MessageName>
    {
        /// <summary>The possible contents of <see cref="MessageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/conversations/{conversation}/messages/{message}</c>.
            /// </summary>
            ProjectConversationMessage = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>.
            /// </summary>
            ProjectLocationConversationMessage = 2,
        }

        private static gax::PathTemplate s_projectConversationMessage = new gax::PathTemplate("projects/{project}/conversations/{conversation}/messages/{message}");

        private static gax::PathTemplate s_projectLocationConversationMessage = new gax::PathTemplate("projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}");

        /// <summary>Creates a <see cref="MessageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MessageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MessageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MessageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MessageName"/> with the pattern
        /// <c>projects/{project}/conversations/{conversation}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MessageName"/> constructed from the provided ids.</returns>
        public static MessageName FromProjectConversationMessage(string projectId, string conversationId, string messageId) =>
            new MessageName(ResourceNameType.ProjectConversationMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>
        /// Creates a <see cref="MessageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MessageName"/> constructed from the provided ids.</returns>
        public static MessageName FromProjectLocationConversationMessage(string projectId, string locationId, string conversationId, string messageId) =>
            new MessageName(ResourceNameType.ProjectLocationConversationMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/messages/{message}</c>.
        /// </returns>
        public static string Format(string projectId, string conversationId, string messageId) =>
            FormatProjectConversationMessage(projectId, conversationId, messageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/conversations/{conversation}/messages/{message}</c>.
        /// </returns>
        public static string FormatProjectConversationMessage(string projectId, string conversationId, string messageId) =>
            s_projectConversationMessage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationMessage(string projectId, string locationId, string conversationId, string messageId) =>
            s_projectLocationConversationMessage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>Parses the given resource name string into a new <see cref="MessageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversations/{conversation}/messages/{message}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MessageName"/> if successful.</returns>
        public static MessageName Parse(string messageName) => Parse(messageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MessageName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversations/{conversation}/messages/{message}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MessageName"/> if successful.</returns>
        public static MessageName Parse(string messageName, bool allowUnparsed) =>
            TryParse(messageName, allowUnparsed, out MessageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MessageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversations/{conversation}/messages/{message}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MessageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string messageName, out MessageName result) => TryParse(messageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MessageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/conversations/{conversation}/messages/{message}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="messageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MessageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string messageName, bool allowUnparsed, out MessageName result)
        {
            gax::GaxPreconditions.CheckNotNull(messageName, nameof(messageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConversationMessage.TryParseName(messageName, out resourceName))
            {
                result = FromProjectConversationMessage(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationConversationMessage.TryParseName(messageName, out resourceName))
            {
                result = FromProjectLocationConversationMessage(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(messageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MessageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationId = null, string locationId = null, string messageId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationId = conversationId;
            LocationId = locationId;
            MessageId = messageId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MessageName"/> class from the component parts of pattern
        /// <c>projects/{project}/conversations/{conversation}/messages/{message}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationId">The <c>Conversation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        public MessageName(string projectId, string conversationId, string messageId) : this(ResourceNameType.ProjectConversationMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), conversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationId, nameof(conversationId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)))
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
        /// The <c>Message</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string MessageId { get; }

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
                case ResourceNameType.ProjectConversationMessage: return s_projectConversationMessage.Expand(ProjectId, ConversationId, MessageId);
                case ResourceNameType.ProjectLocationConversationMessage: return s_projectLocationConversationMessage.Expand(ProjectId, LocationId, ConversationId, MessageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MessageName);

        /// <inheritdoc/>
        public bool Equals(MessageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MessageName a, MessageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MessageName a, MessageName b) => !(a == b);
    }

    public partial class Participant
    {
        /// <summary>
        /// <see cref="gcdv::ParticipantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ParticipantName ParticipantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ParticipantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Message
    {
        /// <summary>
        /// <see cref="gcdv::MessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::MessageName MessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::MessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateParticipantRequest
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversationName ParentAsConversationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetParticipantRequest
    {
        /// <summary>
        /// <see cref="gcdv::ParticipantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ParticipantName ParticipantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ParticipantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListParticipantsRequest
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversationName ParentAsConversationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AnalyzeContentRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Participant"/> resource name property.
        /// </summary>
        public ParticipantName ParticipantAsParticipantName
        {
            get => string.IsNullOrEmpty(Participant) ? null : ParticipantName.Parse(Participant, allowUnparsed: true);
            set => Participant = value?.ToString() ?? "";
        }
    }

    public partial class StreamingAnalyzeContentRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Participant"/> resource name property.
        /// </summary>
        public ParticipantName ParticipantAsParticipantName
        {
            get => string.IsNullOrEmpty(Participant) ? null : ParticipantName.Parse(Participant, allowUnparsed: true);
            set => Participant = value?.ToString() ?? "";
        }
    }

    public partial class SuggestArticlesRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParticipantName ParentAsParticipantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParticipantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="LatestMessage"/> resource name property.
        /// </summary>
        public MessageName LatestMessageAsMessageName
        {
            get => string.IsNullOrEmpty(LatestMessage) ? null : MessageName.Parse(LatestMessage, allowUnparsed: true);
            set => LatestMessage = value?.ToString() ?? "";
        }
    }

    public partial class SuggestFaqAnswersRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParticipantName ParentAsParticipantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParticipantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="LatestMessage"/> resource name property.
        /// </summary>
        public MessageName LatestMessageAsMessageName
        {
            get => string.IsNullOrEmpty(LatestMessage) ? null : MessageName.Parse(LatestMessage, allowUnparsed: true);
            set => LatestMessage = value?.ToString() ?? "";
        }
    }

    public partial class SuggestSmartRepliesRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParticipantName ParentAsParticipantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParticipantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="LatestMessage"/> resource name property.
        /// </summary>
        public MessageName LatestMessageAsMessageName
        {
            get => string.IsNullOrEmpty(LatestMessage) ? null : MessageName.Parse(LatestMessage, allowUnparsed: true);
            set => LatestMessage = value?.ToString() ?? "";
        }
    }

    public partial class SuggestSmartRepliesResponse
    {
        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="LatestMessage"/> resource name property.
        /// </summary>
        public MessageName LatestMessageAsMessageName
        {
            get => string.IsNullOrEmpty(LatestMessage) ? null : MessageName.Parse(LatestMessage, allowUnparsed: true);
            set => LatestMessage = value?.ToString() ?? "";
        }
    }

    public partial class SmartReplyAnswer
    {
        /// <summary>
        /// <see cref="AnswerRecordName"/>-typed view over the <see cref="AnswerRecord"/> resource name property.
        /// </summary>
        public AnswerRecordName AnswerRecordAsAnswerRecordName
        {
            get => string.IsNullOrEmpty(AnswerRecord) ? null : AnswerRecordName.Parse(AnswerRecord, allowUnparsed: true);
            set => AnswerRecord = value?.ToString() ?? "";
        }
    }

    public partial class SuggestKnowledgeAssistRequest
    {
        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParticipantName ParentAsParticipantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ParticipantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="LatestMessage"/> resource name property.
        /// </summary>
        public MessageName LatestMessageAsMessageName
        {
            get => string.IsNullOrEmpty(LatestMessage) ? null : MessageName.Parse(LatestMessage, allowUnparsed: true);
            set => LatestMessage = value?.ToString() ?? "";
        }
    }
}
