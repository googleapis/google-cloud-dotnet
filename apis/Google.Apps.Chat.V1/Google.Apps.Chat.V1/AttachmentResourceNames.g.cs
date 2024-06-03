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
    /// <summary>Resource name for the <c>Attachment</c> resource.</summary>
    public sealed partial class AttachmentName : gax::IResourceName, sys::IEquatable<AttachmentName>
    {
        /// <summary>The possible contents of <see cref="AttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>.
            /// </summary>
            SpaceMessageAttachment = 1,
        }

        private static gax::PathTemplate s_spaceMessageAttachment = new gax::PathTemplate("spaces/{space}/messages/{message}/attachments/{attachment}");

        /// <summary>Creates a <see cref="AttachmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AttachmentName"/> with the pattern
        /// <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attachmentId">The <c>Attachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AttachmentName"/> constructed from the provided ids.</returns>
        public static AttachmentName FromSpaceMessageAttachment(string spaceId, string messageId, string attachmentId) =>
            new AttachmentName(ResourceNameType.SpaceMessageAttachment, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), attachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttachmentName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attachmentId">The <c>Attachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttachmentName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>.
        /// </returns>
        public static string Format(string spaceId, string messageId, string attachmentId) =>
            FormatSpaceMessageAttachment(spaceId, messageId, attachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttachmentName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attachmentId">The <c>Attachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttachmentName"/> with pattern
        /// <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>.
        /// </returns>
        public static string FormatSpaceMessageAttachment(string spaceId, string messageId, string attachmentId) =>
            s_spaceMessageAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="AttachmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/attachments/{attachment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="attachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AttachmentName"/> if successful.</returns>
        public static AttachmentName Parse(string attachmentName) => Parse(attachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AttachmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/attachments/{attachment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AttachmentName"/> if successful.</returns>
        public static AttachmentName Parse(string attachmentName, bool allowUnparsed) =>
            TryParse(attachmentName, allowUnparsed, out AttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/attachments/{attachment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="attachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attachmentName, out AttachmentName result) =>
            TryParse(attachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttachmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>spaces/{space}/messages/{message}/attachments/{attachment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attachmentName, bool allowUnparsed, out AttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(attachmentName, nameof(attachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_spaceMessageAttachment.TryParseName(attachmentName, out resourceName))
            {
                result = FromSpaceMessageAttachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(attachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string attachmentId = null, string messageId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AttachmentId = attachmentId;
            MessageId = messageId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AttachmentName"/> class from the component parts of pattern
        /// <c>spaces/{space}/messages/{message}/attachments/{attachment}</c>
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="messageId">The <c>Message</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attachmentId">The <c>Attachment</c> ID. Must not be <c>null</c> or empty.</param>
        public AttachmentName(string spaceId, string messageId, string attachmentId) : this(ResourceNameType.SpaceMessageAttachment, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), messageId: gax::GaxPreconditions.CheckNotNullOrEmpty(messageId, nameof(messageId)), attachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)))
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
        /// The <c>Attachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AttachmentId { get; }

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
                case ResourceNameType.SpaceMessageAttachment: return s_spaceMessageAttachment.Expand(SpaceId, MessageId, AttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AttachmentName);

        /// <inheritdoc/>
        public bool Equals(AttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AttachmentName a, AttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AttachmentName a, AttachmentName b) => !(a == b);
    }

    public partial class Attachment
    {
        /// <summary>
        /// <see cref="gacv::AttachmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::AttachmentName AttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::AttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAttachmentRequest
    {
        /// <summary>
        /// <see cref="gacv::AttachmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::AttachmentName AttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::AttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UploadAttachmentRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
