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
using gcrv = Google.Cloud.ResourceManager.V3;
using sys = System;

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Resource name for the <c>TagHold</c> resource.</summary>
    public sealed partial class TagHoldName : gax::IResourceName, sys::IEquatable<TagHoldName>
    {
        /// <summary>The possible contents of <see cref="TagHoldName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>.</summary>
            TagValueTagHold = 1,
        }

        private static gax::PathTemplate s_tagValueTagHold = new gax::PathTemplate("tagValues/{tag_value}/tagHolds/{tag_hold}");

        /// <summary>Creates a <see cref="TagHoldName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagHoldName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagHoldName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagHoldName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TagHoldName"/> with the pattern <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>.
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagHoldId">The <c>TagHold</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagHoldName"/> constructed from the provided ids.</returns>
        public static TagHoldName FromTagValueTagHold(string tagValueId, string tagHoldId) =>
            new TagHoldName(ResourceNameType.TagValueTagHold, tagValueId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagValueId, nameof(tagValueId)), tagHoldId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagHoldId, nameof(tagHoldId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagHoldName"/> with pattern
        /// <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>.
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagHoldId">The <c>TagHold</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagHoldName"/> with pattern
        /// <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>.
        /// </returns>
        public static string Format(string tagValueId, string tagHoldId) => FormatTagValueTagHold(tagValueId, tagHoldId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagHoldName"/> with pattern
        /// <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>.
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagHoldId">The <c>TagHold</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagHoldName"/> with pattern
        /// <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>.
        /// </returns>
        public static string FormatTagValueTagHold(string tagValueId, string tagHoldId) =>
            s_tagValueTagHold.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tagValueId, nameof(tagValueId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagHoldId, nameof(tagHoldId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagHoldName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>tagValues/{tag_value}/tagHolds/{tag_hold}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tagHoldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagHoldName"/> if successful.</returns>
        public static TagHoldName Parse(string tagHoldName) => Parse(tagHoldName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagHoldName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>tagValues/{tag_value}/tagHolds/{tag_hold}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagHoldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagHoldName"/> if successful.</returns>
        public static TagHoldName Parse(string tagHoldName, bool allowUnparsed) =>
            TryParse(tagHoldName, allowUnparsed, out TagHoldName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagHoldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>tagValues/{tag_value}/tagHolds/{tag_hold}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tagHoldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagHoldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagHoldName, out TagHoldName result) => TryParse(tagHoldName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagHoldName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>tagValues/{tag_value}/tagHolds/{tag_hold}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagHoldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagHoldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagHoldName, bool allowUnparsed, out TagHoldName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagHoldName, nameof(tagHoldName));
            gax::TemplatedResourceName resourceName;
            if (s_tagValueTagHold.TryParseName(tagHoldName, out resourceName))
            {
                result = FromTagValueTagHold(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagHoldName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagHoldName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string tagHoldId = null, string tagValueId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TagHoldId = tagHoldId;
            TagValueId = tagValueId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagHoldName"/> class from the component parts of pattern
        /// <c>tagValues/{tag_value}/tagHolds/{tag_hold}</c>
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagHoldId">The <c>TagHold</c> ID. Must not be <c>null</c> or empty.</param>
        public TagHoldName(string tagValueId, string tagHoldId) : this(ResourceNameType.TagValueTagHold, tagValueId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagValueId, nameof(tagValueId)), tagHoldId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagHoldId, nameof(tagHoldId)))
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
        /// The <c>TagHold</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagHoldId { get; }

        /// <summary>
        /// The <c>TagValue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagValueId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.TagValueTagHold: return s_tagValueTagHold.Expand(TagValueId, TagHoldId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagHoldName);

        /// <inheritdoc/>
        public bool Equals(TagHoldName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagHoldName a, TagHoldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagHoldName a, TagHoldName b) => !(a == b);
    }

    public partial class TagHold
    {
        /// <summary>
        /// <see cref="gcrv::TagHoldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagHoldName TagHoldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagHoldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTagHoldRequest
    {
        /// <summary>
        /// <see cref="TagValueName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TagValueName ParentAsTagValueName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TagValueName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagHoldRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagHoldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagHoldName TagHoldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagHoldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTagHoldsRequest
    {
        /// <summary>
        /// <see cref="TagValueName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TagValueName ParentAsTagValueName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TagValueName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
