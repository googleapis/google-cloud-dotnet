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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>Content</c> resource.</summary>
    public sealed partial class ContentName : gax::IResourceName, sys::IEquatable<ContentName>
    {
        /// <summary>The possible contents of <see cref="ContentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>networks/{network_code}/content/{content}</c>.</summary>
            NetworkCodeContent = 1,
        }

        private static gax::PathTemplate s_networkCodeContent = new gax::PathTemplate("networks/{network_code}/content/{content}");

        /// <summary>Creates a <see cref="ContentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContentName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContentName"/> with the pattern <c>networks/{network_code}/content/{content}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContentName"/> constructed from the provided ids.</returns>
        public static ContentName FromNetworkCodeContent(string networkCodeId, string contentId) =>
            new ContentName(ResourceNameType.NetworkCodeContent, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), contentId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentId, nameof(contentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentName"/> with pattern
        /// <c>networks/{network_code}/content/{content}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentName"/> with pattern
        /// <c>networks/{network_code}/content/{content}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string contentId) =>
            FormatNetworkCodeContent(networkCodeId, contentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentName"/> with pattern
        /// <c>networks/{network_code}/content/{content}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentName"/> with pattern
        /// <c>networks/{network_code}/content/{content}</c>.
        /// </returns>
        public static string FormatNetworkCodeContent(string networkCodeId, string contentId) =>
            s_networkCodeContent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contentId, nameof(contentId)));

        /// <summary>Parses the given resource name string into a new <see cref="ContentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/content/{content}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContentName"/> if successful.</returns>
        public static ContentName Parse(string contentName) => Parse(contentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/content/{content}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContentName"/> if successful.</returns>
        public static ContentName Parse(string contentName, bool allowUnparsed) =>
            TryParse(contentName, allowUnparsed, out ContentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/content/{content}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentName, out ContentName result) => TryParse(contentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/content/{content}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentName, bool allowUnparsed, out ContentName result)
        {
            gax::GaxPreconditions.CheckNotNull(contentName, nameof(contentName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeContent.TryParseName(contentName, out resourceName))
            {
                result = FromNetworkCodeContent(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string contentId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ContentId = contentId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContentName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/content/{content}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        public ContentName(string networkCodeId, string contentId) : this(ResourceNameType.NetworkCodeContent, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), contentId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentId, nameof(contentId)))
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
        /// The <c>Content</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ContentId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeContent: return s_networkCodeContent.Expand(NetworkCodeId, ContentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContentName);

        /// <inheritdoc/>
        public bool Equals(ContentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContentName a, ContentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContentName a, ContentName b) => !(a == b);
    }

    public partial class Content
    {
        /// <summary>
        /// <see cref="gaav::ContentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ContentName ContentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ContentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
