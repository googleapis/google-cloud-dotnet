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
    /// <summary>Resource name for the <c>LineItemCreativeAssociation</c> resource.</summary>
    public sealed partial class LineItemCreativeAssociationName : gax::IResourceName, sys::IEquatable<LineItemCreativeAssociationName>
    {
        /// <summary>The possible contents of <see cref="LineItemCreativeAssociationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>.
            /// </summary>
            NetworkCodeLineItemCreative = 1,
        }

        private static gax::PathTemplate s_networkCodeLineItemCreative = new gax::PathTemplate("networks/{network_code}/lineItems/{line_item}/creatives/{creative}");

        /// <summary>
        /// Creates a <see cref="LineItemCreativeAssociationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LineItemCreativeAssociationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LineItemCreativeAssociationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LineItemCreativeAssociationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LineItemCreativeAssociationName"/> with the pattern
        /// <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineItemId">The <c>LineItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeId">The <c>Creative</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="LineItemCreativeAssociationName"/> constructed from the provided ids.
        /// </returns>
        public static LineItemCreativeAssociationName FromNetworkCodeLineItemCreative(string networkCodeId, string lineItemId, string creativeId) =>
            new LineItemCreativeAssociationName(ResourceNameType.NetworkCodeLineItemCreative, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), lineItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(lineItemId, nameof(lineItemId)), creativeId: gax::GaxPreconditions.CheckNotNullOrEmpty(creativeId, nameof(creativeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LineItemCreativeAssociationName"/> with
        /// pattern <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineItemId">The <c>LineItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeId">The <c>Creative</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LineItemCreativeAssociationName"/> with pattern
        /// <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string lineItemId, string creativeId) =>
            FormatNetworkCodeLineItemCreative(networkCodeId, lineItemId, creativeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LineItemCreativeAssociationName"/> with
        /// pattern <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineItemId">The <c>LineItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeId">The <c>Creative</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LineItemCreativeAssociationName"/> with pattern
        /// <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>.
        /// </returns>
        public static string FormatNetworkCodeLineItemCreative(string networkCodeId, string lineItemId, string creativeId) =>
            s_networkCodeLineItemCreative.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lineItemId, nameof(lineItemId)), gax::GaxPreconditions.CheckNotNullOrEmpty(creativeId, nameof(creativeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LineItemCreativeAssociationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lineItemCreativeAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="LineItemCreativeAssociationName"/> if successful.</returns>
        public static LineItemCreativeAssociationName Parse(string lineItemCreativeAssociationName) =>
            Parse(lineItemCreativeAssociationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LineItemCreativeAssociationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lineItemCreativeAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LineItemCreativeAssociationName"/> if successful.</returns>
        public static LineItemCreativeAssociationName Parse(string lineItemCreativeAssociationName, bool allowUnparsed) =>
            TryParse(lineItemCreativeAssociationName, allowUnparsed, out LineItemCreativeAssociationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LineItemCreativeAssociationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lineItemCreativeAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LineItemCreativeAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lineItemCreativeAssociationName, out LineItemCreativeAssociationName result) =>
            TryParse(lineItemCreativeAssociationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LineItemCreativeAssociationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lineItemCreativeAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LineItemCreativeAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lineItemCreativeAssociationName, bool allowUnparsed, out LineItemCreativeAssociationName result)
        {
            gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociationName, nameof(lineItemCreativeAssociationName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeLineItemCreative.TryParseName(lineItemCreativeAssociationName, out resourceName))
            {
                result = FromNetworkCodeLineItemCreative(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lineItemCreativeAssociationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LineItemCreativeAssociationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string creativeId = null, string lineItemId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CreativeId = creativeId;
            LineItemId = lineItemId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LineItemCreativeAssociationName"/> class from the component parts
        /// of pattern <c>networks/{network_code}/lineItems/{line_item}/creatives/{creative}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineItemId">The <c>LineItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="creativeId">The <c>Creative</c> ID. Must not be <c>null</c> or empty.</param>
        public LineItemCreativeAssociationName(string networkCodeId, string lineItemId, string creativeId) : this(ResourceNameType.NetworkCodeLineItemCreative, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), lineItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(lineItemId, nameof(lineItemId)), creativeId: gax::GaxPreconditions.CheckNotNullOrEmpty(creativeId, nameof(creativeId)))
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
        /// The <c>Creative</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CreativeId { get; }

        /// <summary>
        /// The <c>LineItem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LineItemId { get; }

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
                case ResourceNameType.NetworkCodeLineItemCreative: return s_networkCodeLineItemCreative.Expand(NetworkCodeId, LineItemId, CreativeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LineItemCreativeAssociationName);

        /// <inheritdoc/>
        public bool Equals(LineItemCreativeAssociationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LineItemCreativeAssociationName a, LineItemCreativeAssociationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LineItemCreativeAssociationName a, LineItemCreativeAssociationName b) => !(a == b);
    }

    public partial class LineItemCreativeAssociation
    {
        /// <summary>
        /// <see cref="gaav::LineItemCreativeAssociationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::LineItemCreativeAssociationName LineItemCreativeAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::LineItemCreativeAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LineItemName"/>-typed view over the <see cref="LineItem"/> resource name property.
        /// </summary>
        public LineItemName LineItemAsLineItemName
        {
            get => string.IsNullOrEmpty(LineItem) ? null : LineItemName.Parse(LineItem, allowUnparsed: true);
            set => LineItem = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CreativeName"/>-typed view over the <see cref="Creative"/> resource name property.
        /// </summary>
        public CreativeName CreativeAsCreativeName
        {
            get => string.IsNullOrEmpty(Creative) ? null : CreativeName.Parse(Creative, allowUnparsed: true);
            set => Creative = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CreativeSetName"/>-typed view over the <see cref="CreativeSet"/> resource name property.
        /// </summary>
        public CreativeSetName CreativeSetAsCreativeSetName
        {
            get => string.IsNullOrEmpty(CreativeSet) ? null : CreativeSetName.Parse(CreativeSet, allowUnparsed: true);
            set => CreativeSet = value?.ToString() ?? "";
        }
    }
}
