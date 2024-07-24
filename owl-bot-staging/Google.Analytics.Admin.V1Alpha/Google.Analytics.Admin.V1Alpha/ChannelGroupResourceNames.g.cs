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
using gaav = Google.Analytics.Admin.V1Alpha;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Analytics.Admin.V1Alpha
{
    /// <summary>Resource name for the <c>ChannelGroup</c> resource.</summary>
    public sealed partial class ChannelGroupName : gax::IResourceName, sys::IEquatable<ChannelGroupName>
    {
        /// <summary>The possible contents of <see cref="ChannelGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/channelGroups/{channel_group}</c>.
            /// </summary>
            PropertyChannelGroup = 1,
        }

        private static gax::PathTemplate s_propertyChannelGroup = new gax::PathTemplate("properties/{property}/channelGroups/{channel_group}");

        /// <summary>Creates a <see cref="ChannelGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChannelGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChannelGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChannelGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChannelGroupName"/> with the pattern
        /// <c>properties/{property}/channelGroups/{channel_group}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelGroupId">The <c>ChannelGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChannelGroupName"/> constructed from the provided ids.</returns>
        public static ChannelGroupName FromPropertyChannelGroup(string propertyId, string channelGroupId) =>
            new ChannelGroupName(ResourceNameType.PropertyChannelGroup, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), channelGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelGroupId, nameof(channelGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelGroupName"/> with pattern
        /// <c>properties/{property}/channelGroups/{channel_group}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelGroupId">The <c>ChannelGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelGroupName"/> with pattern
        /// <c>properties/{property}/channelGroups/{channel_group}</c>.
        /// </returns>
        public static string Format(string propertyId, string channelGroupId) =>
            FormatPropertyChannelGroup(propertyId, channelGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelGroupName"/> with pattern
        /// <c>properties/{property}/channelGroups/{channel_group}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelGroupId">The <c>ChannelGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelGroupName"/> with pattern
        /// <c>properties/{property}/channelGroups/{channel_group}</c>.
        /// </returns>
        public static string FormatPropertyChannelGroup(string propertyId, string channelGroupId) =>
            s_propertyChannelGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelGroupId, nameof(channelGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChannelGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/channelGroups/{channel_group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="channelGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChannelGroupName"/> if successful.</returns>
        public static ChannelGroupName Parse(string channelGroupName) => Parse(channelGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/channelGroups/{channel_group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChannelGroupName"/> if successful.</returns>
        public static ChannelGroupName Parse(string channelGroupName, bool allowUnparsed) =>
            TryParse(channelGroupName, allowUnparsed, out ChannelGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/channelGroups/{channel_group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="channelGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelGroupName, out ChannelGroupName result) =>
            TryParse(channelGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/channelGroups/{channel_group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelGroupName, bool allowUnparsed, out ChannelGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(channelGroupName, nameof(channelGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyChannelGroup.TryParseName(channelGroupName, out resourceName))
            {
                result = FromPropertyChannelGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(channelGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChannelGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelGroupId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelGroupId = channelGroupId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChannelGroupName"/> class from the component parts of pattern
        /// <c>properties/{property}/channelGroups/{channel_group}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelGroupId">The <c>ChannelGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public ChannelGroupName(string propertyId, string channelGroupId) : this(ResourceNameType.PropertyChannelGroup, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), channelGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelGroupId, nameof(channelGroupId)))
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
        /// The <c>ChannelGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ChannelGroupId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyChannelGroup: return s_propertyChannelGroup.Expand(PropertyId, ChannelGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChannelGroupName);

        /// <inheritdoc/>
        public bool Equals(ChannelGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChannelGroupName a, ChannelGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChannelGroupName a, ChannelGroupName b) => !(a == b);
    }

    public partial class ChannelGroup
    {
        /// <summary>
        /// <see cref="gaav::ChannelGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::ChannelGroupName ChannelGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::ChannelGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
