// Copyright 2026 Google LLC
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
    /// <summary>Resource name for the <c>Section</c> resource.</summary>
    public sealed partial class SectionName : gax::IResourceName, sys::IEquatable<SectionName>
    {
        /// <summary>The possible contents of <see cref="SectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/sections/{section}</c>.</summary>
            UserSection = 1,
        }

        private static gax::PathTemplate s_userSection = new gax::PathTemplate("users/{user}/sections/{section}");

        /// <summary>Creates a <see cref="SectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SectionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SectionName"/> with the pattern <c>users/{user}/sections/{section}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SectionName"/> constructed from the provided ids.</returns>
        public static SectionName FromUserSection(string userId, string sectionId) =>
            new SectionName(ResourceNameType.UserSection, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sectionId, nameof(sectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SectionName"/> with pattern
        /// <c>users/{user}/sections/{section}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SectionName"/> with pattern <c>users/{user}/sections/{section}</c>
        /// .
        /// </returns>
        public static string Format(string userId, string sectionId) => FormatUserSection(userId, sectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SectionName"/> with pattern
        /// <c>users/{user}/sections/{section}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SectionName"/> with pattern <c>users/{user}/sections/{section}</c>
        /// .
        /// </returns>
        public static string FormatUserSection(string userId, string sectionId) =>
            s_userSection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sectionId, nameof(sectionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SectionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/sections/{section}</c></description></item></list>
        /// </remarks>
        /// <param name="sectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SectionName"/> if successful.</returns>
        public static SectionName Parse(string sectionName) => Parse(sectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SectionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/sections/{section}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SectionName"/> if successful.</returns>
        public static SectionName Parse(string sectionName, bool allowUnparsed) =>
            TryParse(sectionName, allowUnparsed, out SectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/sections/{section}</c></description></item></list>
        /// </remarks>
        /// <param name="sectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sectionName, out SectionName result) => TryParse(sectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}/sections/{section}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sectionName, bool allowUnparsed, out SectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sectionName, nameof(sectionName));
            gax::TemplatedResourceName resourceName;
            if (s_userSection.TryParseName(sectionName, out resourceName))
            {
                result = FromUserSection(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string sectionId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            SectionId = sectionId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SectionName"/> class from the component parts of pattern
        /// <c>users/{user}/sections/{section}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        public SectionName(string userId, string sectionId) : this(ResourceNameType.UserSection, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sectionId, nameof(sectionId)))
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
        /// The <c>Section</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SectionId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserSection: return s_userSection.Expand(UserId, SectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SectionName);

        /// <inheritdoc/>
        public bool Equals(SectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SectionName a, SectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SectionName a, SectionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SectionItem</c> resource.</summary>
    public sealed partial class SectionItemName : gax::IResourceName, sys::IEquatable<SectionItemName>
    {
        /// <summary>The possible contents of <see cref="SectionItemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}/sections/{section}/items/{item}</c>.</summary>
            UserSectionItem = 1,
        }

        private static gax::PathTemplate s_userSectionItem = new gax::PathTemplate("users/{user}/sections/{section}/items/{item}");

        /// <summary>Creates a <see cref="SectionItemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SectionItemName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SectionItemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SectionItemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SectionItemName"/> with the pattern <c>users/{user}/sections/{section}/items/{item}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SectionItemName"/> constructed from the provided ids.</returns>
        public static SectionItemName FromUserSectionItem(string userId, string sectionId, string itemId) =>
            new SectionItemName(ResourceNameType.UserSectionItem, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sectionId, nameof(sectionId)), itemId: gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SectionItemName"/> with pattern
        /// <c>users/{user}/sections/{section}/items/{item}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SectionItemName"/> with pattern
        /// <c>users/{user}/sections/{section}/items/{item}</c>.
        /// </returns>
        public static string Format(string userId, string sectionId, string itemId) =>
            FormatUserSectionItem(userId, sectionId, itemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SectionItemName"/> with pattern
        /// <c>users/{user}/sections/{section}/items/{item}</c>.
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SectionItemName"/> with pattern
        /// <c>users/{user}/sections/{section}/items/{item}</c>.
        /// </returns>
        public static string FormatUserSectionItem(string userId, string sectionId, string itemId) =>
            s_userSectionItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sectionId, nameof(sectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)));

        /// <summary>Parses the given resource name string into a new <see cref="SectionItemName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sections/{section}/items/{item}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sectionItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SectionItemName"/> if successful.</returns>
        public static SectionItemName Parse(string sectionItemName) => Parse(sectionItemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SectionItemName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sections/{section}/items/{item}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sectionItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SectionItemName"/> if successful.</returns>
        public static SectionItemName Parse(string sectionItemName, bool allowUnparsed) =>
            TryParse(sectionItemName, allowUnparsed, out SectionItemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SectionItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sections/{section}/items/{item}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sectionItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SectionItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sectionItemName, out SectionItemName result) =>
            TryParse(sectionItemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SectionItemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>users/{user}/sections/{section}/items/{item}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sectionItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SectionItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sectionItemName, bool allowUnparsed, out SectionItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(sectionItemName, nameof(sectionItemName));
            gax::TemplatedResourceName resourceName;
            if (s_userSectionItem.TryParseName(sectionItemName, out resourceName))
            {
                result = FromUserSectionItem(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sectionItemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SectionItemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string itemId = null, string sectionId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ItemId = itemId;
            SectionId = sectionId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SectionItemName"/> class from the component parts of pattern
        /// <c>users/{user}/sections/{section}/items/{item}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sectionId">The <c>Section</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        public SectionItemName(string userId, string sectionId, string itemId) : this(ResourceNameType.UserSectionItem, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)), sectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sectionId, nameof(sectionId)), itemId: gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)))
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
        /// The <c>Item</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ItemId { get; }

        /// <summary>
        /// The <c>Section</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SectionId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.UserSectionItem: return s_userSectionItem.Expand(UserId, SectionId, ItemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SectionItemName);

        /// <inheritdoc/>
        public bool Equals(SectionItemName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SectionItemName a, SectionItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SectionItemName a, SectionItemName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>User</c> resource.</summary>
    public sealed partial class UserName : gax::IResourceName, sys::IEquatable<UserName>
    {
        /// <summary>The possible contents of <see cref="UserName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>users/{user}</c>.</summary>
            User = 1,
        }

        private static gax::PathTemplate s_user = new gax::PathTemplate("users/{user}");

        /// <summary>Creates a <see cref="UserName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="UserName"/> with the pattern <c>users/{user}</c>.</summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserName"/> constructed from the provided ids.</returns>
        public static UserName FromUser(string userId) =>
            new UserName(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>.
        /// </returns>
        public static string Format(string userId) => FormatUser(userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>
        /// .
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern <c>users/{user}</c>.
        /// </returns>
        public static string FormatUser(string userId) =>
            s_user.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName) => Parse(userName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName, bool allowUnparsed) =>
            TryParse(userName, allowUnparsed, out UserName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, out UserName result) => TryParse(userName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>users/{user}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, bool allowUnparsed, out UserName result)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName;
            if (s_user.TryParseName(userName, out resourceName))
            {
                result = FromUser(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserName"/> class from the component parts of pattern
        /// <c>users/{user}</c>
        /// </summary>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public UserName(string userId) : this(ResourceNameType.User, userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.User: return s_user.Expand(UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserName);

        /// <inheritdoc/>
        public bool Equals(UserName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserName a, UserName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserName a, UserName b) => !(a == b);
    }

    public partial class Section
    {
        /// <summary>
        /// <see cref="gacv::SectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::SectionName SectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::SectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SectionItem
    {
        /// <summary>
        /// <see cref="gacv::SectionItemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::SectionItemName SectionItemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::SectionItemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Space"/> resource name property.</summary>
        public SpaceName SpaceAsSpaceName
        {
            get => string.IsNullOrEmpty(Space) ? null : SpaceName.Parse(Space, allowUnparsed: true);
            set => Space = value?.ToString() ?? "";
        }
    }

    public partial class CreateSectionRequest
    {
        /// <summary><see cref="UserName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public UserName ParentAsUserName
        {
            get => string.IsNullOrEmpty(Parent) ? null : UserName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSectionRequest
    {
        /// <summary>
        /// <see cref="gacv::SectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::SectionName SectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::SectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSectionsRequest
    {
        /// <summary><see cref="UserName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public UserName ParentAsUserName
        {
            get => string.IsNullOrEmpty(Parent) ? null : UserName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PositionSectionRequest
    {
        /// <summary>
        /// <see cref="gacv::SectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::SectionName SectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::SectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSectionItemsRequest
    {
        /// <summary>
        /// <see cref="SectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SectionName ParentAsSectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class MoveSectionItemRequest
    {
        /// <summary>
        /// <see cref="gacv::SectionItemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gacv::SectionItemName SectionItemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gacv::SectionItemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SectionName"/>-typed view over the <see cref="TargetSection"/> resource name property.
        /// </summary>
        public SectionName TargetSectionAsSectionName
        {
            get => string.IsNullOrEmpty(TargetSection) ? null : SectionName.Parse(TargetSection, allowUnparsed: true);
            set => TargetSection = value?.ToString() ?? "";
        }
    }
}
