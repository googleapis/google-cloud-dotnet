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
using gacv = Google.Apps.Chat.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Apps.Chat.V1
{
    /// <summary>Resource name for the <c>Reaction</c> resource.</summary>
    public sealed partial class ReactionName : gax::IResourceName, sys::IEquatable<ReactionName>
    {
        /// <summary>The possible contents of <see cref="ReactionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>.
            /// </summary>
            SpaceMessageReaction = 1,
        }

        private static gax::PathTemplate s_spaceMessageReaction = new gax::PathTemplate("spaces/{space}/messages/{message}/reactions/{reaction}");

        /// <summary>Creates a <see cref="ReactionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReactionName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ReactionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReactionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReactionName"/> with the pattern
        /// <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reactionId">The <c>Reaction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReactionName"/> constructed from the provided ids.</returns>
        public static ReactionName FromSpaceMessageReaction(string spaceId, string messageId, string reactionId) =>
            new ReactionName(ResourceNameType.SpaceMessageReaction, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), reactionId: gax::GaxPreconditions.CheckNotNullOrEmpty(reactionId, nameof(reactionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReactionName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reactionId">The <c>Reaction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReactionName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>.
        /// </returns>
        public static string Format(string spaceId, string messageId, string reactionId) =>
            FormatSpaceMessageReaction(spaceId, messageId, reactionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReactionName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reactionId">The <c>Reaction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReactionName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>.
        /// </returns>
        public static string FormatSpaceMessageReaction(string spaceId, string messageId, string reactionId) =>
            s_spaceMessageReaction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reactionId, nameof(reactionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReactionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/reactions/{reaction}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="reactionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReactionName"/> if successful.</returns>
        public static ReactionName Parse(string reactionName) => Parse(reactionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReactionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/reactions/{reaction}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reactionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReactionName"/> if successful.</returns>
        public static ReactionName Parse(string reactionName, bool allowUnparsed) =>
            TryParse(reactionName, allowUnparsed, out ReactionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReactionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/reactions/{reaction}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="reactionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReactionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reactionName, out ReactionName result) => TryParse(reactionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReactionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/reactions/{reaction}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reactionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReactionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reactionName, bool allowUnparsed, out ReactionName result)
        {
            gax::GaxPreconditions.CheckNotNull(reactionName, nameof(reactionName));
            gax::TemplatedResourceName resourceName;
            if (s_spaceMessageReaction.TryParseName(reactionName, out resourceName))
            {
                result = FromSpaceMessageReaction(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reactionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReactionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string messageId = null, string reactionId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MessageId = messageId;
            ReactionId = reactionId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReactionName"/> class from the component parts of pattern
        /// <c>spaces/{space}/messages/{message}/reactions/{reaction}</c>
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reactionId">The <c>Reaction</c> ID. Must not be <c>null</c> or empty.</param>
        public ReactionName(string spaceId, string messageId, string reactionId) : this(ResourceNameType.SpaceMessageReaction, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), reactionId: gax::GaxPreconditions.CheckNotNullOrEmpty(reactionId, nameof(reactionId)))
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
        /// The <c>Reaction</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReactionId { get; }

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
                case ResourceNameType.SpaceMessageReaction: return s_spaceMessageReaction.Expand(SpaceId, MessageId, ReactionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReactionName);

        /// <inheritdoc/>
        public bool Equals(ReactionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReactionName a, ReactionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReactionName a, ReactionName b) => !(a == b);
    }

    public partial class Reaction
    {
        /// <summary>
        /// <see cref="gacv::ReactionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::ReactionName ReactionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::ReactionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReactionRequest
    {
        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MessageName ParentAsMessageName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MessageName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListReactionsRequest
    {
        /// <summary>
        /// <see cref="MessageName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MessageName ParentAsMessageName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MessageName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReactionRequest
    {
        /// <summary>
        /// <see cref="gacv::ReactionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::ReactionName ReactionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::ReactionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
