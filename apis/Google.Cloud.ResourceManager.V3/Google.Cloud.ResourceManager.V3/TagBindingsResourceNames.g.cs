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
    /// <summary>Resource name for the <c>TagBinding</c> resource.</summary>
    public sealed partial class TagBindingName : gax::IResourceName, sys::IEquatable<TagBindingName>
    {
        /// <summary>The possible contents of <see cref="TagBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>tagBindings/{tag_binding}</c>.</summary>
            TagBinding = 1,
        }

        private static gax::PathTemplate s_tagBinding = new gax::PathTemplate("tagBindings/{tag_binding}");

        /// <summary>Creates a <see cref="TagBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="TagBindingName"/> with the pattern <c>tagBindings/{tag_binding}</c>.</summary>
        /// <param name="tagBindingId">The <c>TagBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagBindingName"/> constructed from the provided ids.</returns>
        public static TagBindingName FromTagBinding(string tagBindingId) =>
            new TagBindingName(ResourceNameType.TagBinding, tagBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagBindingId, nameof(tagBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagBindingName"/> with pattern
        /// <c>tagBindings/{tag_binding}</c>.
        /// </summary>
        /// <param name="tagBindingId">The <c>TagBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagBindingName"/> with pattern <c>tagBindings/{tag_binding}</c>
        /// .
        /// </returns>
        public static string Format(string tagBindingId) => FormatTagBinding(tagBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagBindingName"/> with pattern
        /// <c>tagBindings/{tag_binding}</c>.
        /// </summary>
        /// <param name="tagBindingId">The <c>TagBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagBindingName"/> with pattern <c>tagBindings/{tag_binding}</c>
        /// .
        /// </returns>
        public static string FormatTagBinding(string tagBindingId) =>
            s_tagBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(tagBindingId, nameof(tagBindingId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagBindingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagBindings/{tag_binding}</c></description></item></list>
        /// </remarks>
        /// <param name="tagBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagBindingName"/> if successful.</returns>
        public static TagBindingName Parse(string tagBindingName) => Parse(tagBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagBindingName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagBindings/{tag_binding}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagBindingName"/> if successful.</returns>
        public static TagBindingName Parse(string tagBindingName, bool allowUnparsed) =>
            TryParse(tagBindingName, allowUnparsed, out TagBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagBindings/{tag_binding}</c></description></item></list>
        /// </remarks>
        /// <param name="tagBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagBindingName, out TagBindingName result) =>
            TryParse(tagBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>tagBindings/{tag_binding}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagBindingName, bool allowUnparsed, out TagBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagBindingName, nameof(tagBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_tagBinding.TryParseName(tagBindingName, out resourceName))
            {
                result = FromTagBinding(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string tagBindingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TagBindingId = tagBindingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagBindingName"/> class from the component parts of pattern
        /// <c>tagBindings/{tag_binding}</c>
        /// </summary>
        /// <param name="tagBindingId">The <c>TagBinding</c> ID. Must not be <c>null</c> or empty.</param>
        public TagBindingName(string tagBindingId) : this(ResourceNameType.TagBinding, tagBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagBindingId, nameof(tagBindingId)))
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
        /// The <c>TagBinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagBindingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.TagBinding: return s_tagBinding.Expand(TagBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagBindingName);

        /// <inheritdoc/>
        public bool Equals(TagBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagBindingName a, TagBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagBindingName a, TagBindingName b) => !(a == b);
    }

    public partial class TagBinding
    {
        /// <summary>
        /// <see cref="gcrv::TagBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagBindingName TagBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagBindingRequest
    {
        /// <summary>
        /// <see cref="gcrv::TagBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TagBindingName TagBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TagBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTagBindingsRequest
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

    public partial class EffectiveTag
    {
        /// <summary>
        /// <see cref="TagValueName"/>-typed view over the <see cref="TagValue"/> resource name property.
        /// </summary>
        public TagValueName TagValueAsTagValueName
        {
            get => string.IsNullOrEmpty(TagValue) ? null : TagValueName.Parse(TagValue, allowUnparsed: true);
            set => TagValue = value?.ToString() ?? "";
        }

        /// <summary><see cref="TagKeyName"/>-typed view over the <see cref="TagKey"/> resource name property.</summary>
        public TagKeyName TagKeyAsTagKeyName
        {
            get => string.IsNullOrEmpty(TagKey) ? null : TagKeyName.Parse(TagKey, allowUnparsed: true);
            set => TagKey = value?.ToString() ?? "";
        }
    }
}
