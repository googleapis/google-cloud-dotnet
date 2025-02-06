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
using gcrv = Google.Cloud.ResourceManager.V3;
using sys = System;

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Resource name for the <c>TagValue</c> resource.</summary>
    public sealed partial class TagValueName : gax::IResourceName, sys::IEquatable<TagValueName>
    {
        /// <summary>The possible contents of <see cref="TagValueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tagValues/{tag_value}</c>.</summary>
            TagValue = 1,
        }

        private static gax::PathTemplate s_tagValue = new gax::PathTemplate("tagValues/{tag_value}");

        /// <summary>Creates a <see cref="TagValueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagValueName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static TagValueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagValueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="TagValueName"/> with the pattern <c>tagValues/{tag_value}</c>.</summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagValueName"/> constructed from the provided ids.</returns>
        public static TagValueName FromTagValue(string tagValueId) =>
            new TagValueName(ResourceNameType.TagValue, tagValueId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagValueId, nameof(tagValueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagValueName"/> with pattern
        /// <c>tagValues/{tag_value}</c>.
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagValueName"/> with pattern <c>tagValues/{tag_value}</c>.
        /// </returns>
        public static string Format(string tagValueId) => FormatTagValue(tagValueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagValueName"/> with pattern
        /// <c>tagValues/{tag_value}</c>.
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagValueName"/> with pattern <c>tagValues/{tag_value}</c>.
        /// </returns>
        public static string FormatTagValue(string tagValueId) =>
            s_tagValue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tagValueId, nameof(tagValueId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagValueName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagValues/{tag_value}</c></description></item></list>
        /// </remarks>
        /// <param name="tagValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagValueName"/> if successful.</returns>
        public static TagValueName Parse(string tagValueName) => Parse(tagValueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagValueName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagValues/{tag_value}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagValueName"/> if successful.</returns>
        public static TagValueName Parse(string tagValueName, bool allowUnparsed) =>
            TryParse(tagValueName, allowUnparsed, out TagValueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagValueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagValues/{tag_value}</c></description></item></list>
        /// </remarks>
        /// <param name="tagValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagValueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagValueName, out TagValueName result) => TryParse(tagValueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagValueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagValues/{tag_value}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagValueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagValueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagValueName, bool allowUnparsed, out TagValueName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagValueName, nameof(tagValueName));
            gax::TemplatedResourceName resourceName;
            if (s_tagValue.TryParseName(tagValueName, out resourceName))
            {
                result = FromTagValue(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagValueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagValueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string tagValueId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TagValueId = tagValueId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagValueName"/> class from the component parts of pattern
        /// <c>tagValues/{tag_value}</c>
        /// </summary>
        /// <param name="tagValueId">The <c>TagValue</c> ID. Must not be <c>null</c> or empty.</param>
        public TagValueName(string tagValueId) : this(ResourceNameType.TagValue, tagValueId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagValueId, nameof(tagValueId)))
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
                case ResourceNameType.TagValue: return s_tagValue.Expand(TagValueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagValueName);

        /// <inheritdoc/>
        public bool Equals(TagValueName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagValueName a, TagValueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagValueName a, TagValueName b) => !(a == b);
    }

    public partial class TagValue
    {
        /// <summary>
        /// <see cref="gcrv::TagValueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagValueName TagValueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagValueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTagValuesRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gax::UnparsedResourceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTagValueRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagValueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagValueName TagValueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagValueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNamespacedTagValueRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagValueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagValueName TagValueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagValueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagValueRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagValueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagValueName TagValueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagValueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
