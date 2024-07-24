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
using gacv = Google.Apps.Chat.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Apps.Chat.V1
{
    /// <summary>Resource name for the <c>Message</c> resource.</summary>
    public sealed partial class MessageName : gax::IResourceName, sys::IEquatable<MessageName>
    {
        /// <summary>The possible contents of <see cref="MessageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>spaces/{space}/messages/{message}</c>.</summary>
            SpaceMessage = 1,
        }

        private static gax::PathTemplate s_spaceMessage = new gax::PathTemplate("spaces/{space}/messages/{message}");

        /// <summary>Creates a <see cref="MessageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MessageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MessageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MessageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MessageName"/> with the pattern <c>spaces/{space}/messages/{message}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MessageName"/> constructed from the provided ids.</returns>
        public static MessageName FromSpaceMessage(string spaceId, string messageId) =>
            new MessageName(ResourceNameType.SpaceMessage, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>spaces/{space}/messages/{message}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>spaces/{space}/messages/{message}</c>.
        /// </returns>
        public static string Format(string spaceId, string messageId) => FormatSpaceMessage(spaceId, messageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MessageName"/> with pattern
        /// <c>spaces/{space}/messages/{message}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MessageName"/> with pattern
        /// <c>spaces/{space}/messages/{message}</c>.
        /// </returns>
        public static string FormatSpaceMessage(string spaceId, string messageId) =>
            s_spaceMessage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)));

        /// <summary>Parses the given resource name string into a new <see cref="MessageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}/messages/{message}</c></description></item></list>
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
        /// <list type="bullet"><item><description><c>spaces/{space}/messages/{message}</c></description></item></list>
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
        /// <list type="bullet"><item><description><c>spaces/{space}/messages/{message}</c></description></item></list>
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
        /// <list type="bullet"><item><description><c>spaces/{space}/messages/{message}</c></description></item></list>
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
            if (s_spaceMessage.TryParseName(messageName, out resourceName))
            {
                result = FromSpaceMessage(resourceName[0], resourceName[1]);
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

        private MessageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string messageId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MessageId = messageId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MessageName"/> class from the component parts of pattern
        /// <c>spaces/{space}/messages/{message}</c>
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        public MessageName(string spaceId, string messageId) : this(ResourceNameType.SpaceMessage, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)))
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
        /// The <c>Message</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MessageId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.SpaceMessage: return s_spaceMessage.Expand(SpaceId, MessageId);
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

    /// <summary>Resource name for the <c>QuotedMessageMetadata</c> resource.</summary>
    public sealed partial class QuotedMessageMetadataName : gax::IResourceName, sys::IEquatable<QuotedMessageMetadataName>
    {
        /// <summary>The possible contents of <see cref="QuotedMessageMetadataName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>.
            /// </summary>
            SpaceMessageQuotedMessageMetadata = 1,
        }

        private static gax::PathTemplate s_spaceMessageQuotedMessageMetadata = new gax::PathTemplate("spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}");

        /// <summary>Creates a <see cref="QuotedMessageMetadataName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QuotedMessageMetadataName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QuotedMessageMetadataName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QuotedMessageMetadataName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QuotedMessageMetadataName"/> with the pattern
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotedMessageMetadataId">
        /// The <c>QuotedMessageMetadata</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="QuotedMessageMetadataName"/> constructed from the provided ids.
        /// </returns>
        public static QuotedMessageMetadataName FromSpaceMessageQuotedMessageMetadata(string spaceId, string messageId, string quotedMessageMetadataId) =>
            new QuotedMessageMetadataName(ResourceNameType.SpaceMessageQuotedMessageMetadata, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), quotedMessageMetadataId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotedMessageMetadataId, nameof(quotedMessageMetadataId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotedMessageMetadataName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotedMessageMetadataId">
        /// The <c>QuotedMessageMetadata</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="QuotedMessageMetadataName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>.
        /// </returns>
        public static string Format(string spaceId, string messageId, string quotedMessageMetadataId) =>
            FormatSpaceMessageQuotedMessageMetadata(spaceId, messageId, quotedMessageMetadataId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotedMessageMetadataName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotedMessageMetadataId">
        /// The <c>QuotedMessageMetadata</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="QuotedMessageMetadataName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>.
        /// </returns>
        public static string FormatSpaceMessageQuotedMessageMetadata(string spaceId, string messageId, string quotedMessageMetadataId) =>
            s_spaceMessageQuotedMessageMetadata.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotedMessageMetadataId, nameof(quotedMessageMetadataId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuotedMessageMetadataName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="quotedMessageMetadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QuotedMessageMetadataName"/> if successful.</returns>
        public static QuotedMessageMetadataName Parse(string quotedMessageMetadataName) =>
            Parse(quotedMessageMetadataName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuotedMessageMetadataName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotedMessageMetadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QuotedMessageMetadataName"/> if successful.</returns>
        public static QuotedMessageMetadataName Parse(string quotedMessageMetadataName, bool allowUnparsed) =>
            TryParse(quotedMessageMetadataName, allowUnparsed, out QuotedMessageMetadataName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotedMessageMetadataName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="quotedMessageMetadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotedMessageMetadataName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotedMessageMetadataName, out QuotedMessageMetadataName result) =>
            TryParse(quotedMessageMetadataName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotedMessageMetadataName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotedMessageMetadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotedMessageMetadataName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotedMessageMetadataName, bool allowUnparsed, out QuotedMessageMetadataName result)
        {
            gax::GaxPreconditions.CheckNotNull(quotedMessageMetadataName, nameof(quotedMessageMetadataName));
            gax::TemplatedResourceName resourceName;
            if (s_spaceMessageQuotedMessageMetadata.TryParseName(quotedMessageMetadataName, out resourceName))
            {
                result = FromSpaceMessageQuotedMessageMetadata(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(quotedMessageMetadataName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QuotedMessageMetadataName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string messageId = null, string quotedMessageMetadataId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MessageId = messageId;
            QuotedMessageMetadataId = quotedMessageMetadataId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QuotedMessageMetadataName"/> class from the component parts of
        /// pattern <c>spaces/{space}/messages/{message}/quotedMessageMetadata/{quoted_message_metadata}</c>
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotedMessageMetadataId">
        /// The <c>QuotedMessageMetadata</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public QuotedMessageMetadataName(string spaceId, string messageId, string quotedMessageMetadataId) : this(ResourceNameType.SpaceMessageQuotedMessageMetadata, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), quotedMessageMetadataId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotedMessageMetadataId, nameof(quotedMessageMetadataId)))
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
        /// The <c>Message</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MessageId { get; }

        /// <summary>
        /// The <c>QuotedMessageMetadata</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string QuotedMessageMetadataId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.SpaceMessageQuotedMessageMetadata: return s_spaceMessageQuotedMessageMetadata.Expand(SpaceId, MessageId, QuotedMessageMetadataId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QuotedMessageMetadataName);

        /// <inheritdoc/>
        public bool Equals(QuotedMessageMetadataName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QuotedMessageMetadataName a, QuotedMessageMetadataName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QuotedMessageMetadataName a, QuotedMessageMetadataName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Thread</c> resource.</summary>
    public sealed partial class ThreadName : gax::IResourceName, sys::IEquatable<ThreadName>
    {
        /// <summary>The possible contents of <see cref="ThreadName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>spaces/{space}/threads/{thread}</c>.</summary>
            SpaceThread = 1,
        }

        private static gax::PathTemplate s_spaceThread = new gax::PathTemplate("spaces/{space}/threads/{thread}");

        /// <summary>Creates a <see cref="ThreadName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ThreadName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ThreadName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ThreadName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ThreadName"/> with the pattern <c>spaces/{space}/threads/{thread}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ThreadName"/> constructed from the provided ids.</returns>
        public static ThreadName FromSpaceThread(string spaceId, string threadId) =>
            new ThreadName(ResourceNameType.SpaceThread, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), threadId: gax::GaxPreconditions.CheckNotNullOrEmpty(threadId, nameof(threadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ThreadName"/> with pattern
        /// <c>spaces/{space}/threads/{thread}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ThreadName"/> with pattern <c>spaces/{space}/threads/{thread}</c>
        /// .
        /// </returns>
        public static string Format(string spaceId, string threadId) => FormatSpaceThread(spaceId, threadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ThreadName"/> with pattern
        /// <c>spaces/{space}/threads/{thread}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ThreadName"/> with pattern <c>spaces/{space}/threads/{thread}</c>
        /// .
        /// </returns>
        public static string FormatSpaceThread(string spaceId, string threadId) =>
            s_spaceThread.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(threadId, nameof(threadId)));

        /// <summary>Parses the given resource name string into a new <see cref="ThreadName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}/threads/{thread}</c></description></item></list>
        /// </remarks>
        /// <param name="threadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ThreadName"/> if successful.</returns>
        public static ThreadName Parse(string threadName) => Parse(threadName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ThreadName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}/threads/{thread}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="threadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ThreadName"/> if successful.</returns>
        public static ThreadName Parse(string threadName, bool allowUnparsed) =>
            TryParse(threadName, allowUnparsed, out ThreadName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ThreadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}/threads/{thread}</c></description></item></list>
        /// </remarks>
        /// <param name="threadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ThreadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string threadName, out ThreadName result) => TryParse(threadName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ThreadName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}/threads/{thread}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="threadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ThreadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string threadName, bool allowUnparsed, out ThreadName result)
        {
            gax::GaxPreconditions.CheckNotNull(threadName, nameof(threadName));
            gax::TemplatedResourceName resourceName;
            if (s_spaceThread.TryParseName(threadName, out resourceName))
            {
                result = FromSpaceThread(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(threadName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ThreadName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string spaceId = null, string threadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            SpaceId = spaceId;
            ThreadId = threadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ThreadName"/> class from the component parts of pattern
        /// <c>spaces/{space}/threads/{thread}</c>
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="threadId">The <c>Thread</c> ID. Must not be <c>null</c> or empty.</param>
        public ThreadName(string spaceId, string threadId) : this(ResourceNameType.SpaceThread, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), threadId: gax::GaxPreconditions.CheckNotNullOrEmpty(threadId, nameof(threadId)))
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
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>
        /// The <c>Thread</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ThreadId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.SpaceThread: return s_spaceThread.Expand(SpaceId, ThreadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ThreadName);

        /// <inheritdoc/>
        public bool Equals(ThreadName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ThreadName a, ThreadName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ThreadName a, ThreadName b) => !(a == b);
    }

    public partial class Message
    {
        /// <summary>
        /// <see cref="gacv::MessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::MessageName MessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::MessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QuotedMessageMetadata
    {
        /// <summary>
        /// <see cref="gacv::QuotedMessageMetadataName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::QuotedMessageMetadataName QuotedMessageMetadataName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::QuotedMessageMetadataName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Thread
    {
        /// <summary>
        /// <see cref="gacv::ThreadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::ThreadName ThreadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::ThreadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMessageRequest
    {
        /// <summary>
        /// <see cref="gacv::MessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::MessageName MessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::MessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMessageRequest
    {
        /// <summary>
        /// <see cref="gacv::MessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::MessageName MessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::MessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMessageRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListMessagesRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
