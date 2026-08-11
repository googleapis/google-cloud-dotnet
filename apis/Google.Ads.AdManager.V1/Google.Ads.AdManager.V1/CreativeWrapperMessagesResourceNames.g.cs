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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>CreativeWrapper</c> resource.</summary>
    public sealed partial class CreativeWrapperName : gax::IResourceName, sys::IEquatable<CreativeWrapperName>
    {
        /// <summary>The possible contents of <see cref="CreativeWrapperName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>.
            /// </summary>
            NetworkCodeCreativeWrapper = 1,
        }

        private static gax::PathTemplate s_networkCodeCreativeWrapper = new gax::PathTemplate("networks/{network_code}/creativeWrappers/{creative_wrapper}");

        /// <summary>Creates a <see cref="CreativeWrapperName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CreativeWrapperName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CreativeWrapperName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CreativeWrapperName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CreativeWrapperName"/> with the pattern
        /// <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeWrapperId">The <c>CreativeWrapper</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CreativeWrapperName"/> constructed from the provided ids.</returns>
        public static CreativeWrapperName FromNetworkCodeCreativeWrapper(string networkCodeId, string creativeWrapperId) =>
            new CreativeWrapperName(ResourceNameType.NetworkCodeCreativeWrapper, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), creativeWrapperId: gax::GaxPreconditions.CheckNotNullOrEmpty(creativeWrapperId, nameof(creativeWrapperId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CreativeWrapperName"/> with pattern
        /// <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeWrapperId">The <c>CreativeWrapper</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CreativeWrapperName"/> with pattern
        /// <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string creativeWrapperId) =>
            FormatNetworkCodeCreativeWrapper(networkCodeId, creativeWrapperId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CreativeWrapperName"/> with pattern
        /// <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeWrapperId">The <c>CreativeWrapper</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CreativeWrapperName"/> with pattern
        /// <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>.
        /// </returns>
        public static string FormatNetworkCodeCreativeWrapper(string networkCodeId, string creativeWrapperId) =>
            s_networkCodeCreativeWrapper.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(creativeWrapperId, nameof(creativeWrapperId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CreativeWrapperName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="creativeWrapperName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CreativeWrapperName"/> if successful.</returns>
        public static CreativeWrapperName Parse(string creativeWrapperName) => Parse(creativeWrapperName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CreativeWrapperName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="creativeWrapperName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CreativeWrapperName"/> if successful.</returns>
        public static CreativeWrapperName Parse(string creativeWrapperName, bool allowUnparsed) =>
            TryParse(creativeWrapperName, allowUnparsed, out CreativeWrapperName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CreativeWrapperName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="creativeWrapperName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CreativeWrapperName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string creativeWrapperName, out CreativeWrapperName result) =>
            TryParse(creativeWrapperName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CreativeWrapperName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="creativeWrapperName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CreativeWrapperName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string creativeWrapperName, bool allowUnparsed, out CreativeWrapperName result)
        {
            gax::GaxPreconditions.CheckNotNull(creativeWrapperName, nameof(creativeWrapperName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeCreativeWrapper.TryParseName(creativeWrapperName, out resourceName))
            {
                result = FromNetworkCodeCreativeWrapper(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(creativeWrapperName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CreativeWrapperName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string creativeWrapperId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CreativeWrapperId = creativeWrapperId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CreativeWrapperName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/creativeWrappers/{creative_wrapper}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeWrapperId">The <c>CreativeWrapper</c> ID. Must not be <c>null</c> or empty.</param>
        public CreativeWrapperName(string networkCodeId, string creativeWrapperId) : this(ResourceNameType.NetworkCodeCreativeWrapper, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), creativeWrapperId: gax::GaxPreconditions.CheckNotNullOrEmpty(creativeWrapperId, nameof(creativeWrapperId)))
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
        /// The <c>CreativeWrapper</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CreativeWrapperId { get; }

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
                case ResourceNameType.NetworkCodeCreativeWrapper: return s_networkCodeCreativeWrapper.Expand(NetworkCodeId, CreativeWrapperId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CreativeWrapperName);

        /// <inheritdoc/>
        public bool Equals(CreativeWrapperName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CreativeWrapperName a, CreativeWrapperName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CreativeWrapperName a, CreativeWrapperName b) => !(a == b);
    }

    public partial class CreativeWrapper
    {
        /// <summary>
        /// <see cref="gaav::CreativeWrapperName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CreativeWrapperName CreativeWrapperName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CreativeWrapperName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="LabelName"/>-typed view over the <see cref="Label"/> resource name property.</summary>
        public LabelName LabelAsLabelName
        {
            get => string.IsNullOrEmpty(Label) ? null : LabelName.Parse(Label, allowUnparsed: true);
            set => Label = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CreativeName"/>-typed view over the <see cref="HeaderCreative"/> resource name property.
        /// </summary>
        public CreativeName HeaderCreativeAsCreativeName
        {
            get => string.IsNullOrEmpty(HeaderCreative) ? null : CreativeName.Parse(HeaderCreative, allowUnparsed: true);
            set => HeaderCreative = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CreativeName"/>-typed view over the <see cref="FooterCreative"/> resource name property.
        /// </summary>
        public CreativeName FooterCreativeAsCreativeName
        {
            get => string.IsNullOrEmpty(FooterCreative) ? null : CreativeName.Parse(FooterCreative, allowUnparsed: true);
            set => FooterCreative = value?.ToString() ?? "";
        }
    }
}
