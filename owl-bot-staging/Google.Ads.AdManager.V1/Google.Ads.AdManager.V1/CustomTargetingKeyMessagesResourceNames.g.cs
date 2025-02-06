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
    /// <summary>Resource name for the <c>CustomTargetingKey</c> resource.</summary>
    public sealed partial class CustomTargetingKeyName : gax::IResourceName, sys::IEquatable<CustomTargetingKeyName>
    {
        /// <summary>The possible contents of <see cref="CustomTargetingKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>.
            /// </summary>
            NetworkCodeCustomTargetingKey = 1,
        }

        private static gax::PathTemplate s_networkCodeCustomTargetingKey = new gax::PathTemplate("networks/{network_code}/customTargetingKeys/{custom_targeting_key}");

        /// <summary>Creates a <see cref="CustomTargetingKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomTargetingKeyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomTargetingKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomTargetingKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomTargetingKeyName"/> with the pattern
        /// <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetingKeyId">
        /// The <c>CustomTargetingKey</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="CustomTargetingKeyName"/> constructed from the provided ids.</returns>
        public static CustomTargetingKeyName FromNetworkCodeCustomTargetingKey(string networkCodeId, string customTargetingKeyId) =>
            new CustomTargetingKeyName(ResourceNameType.NetworkCodeCustomTargetingKey, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), customTargetingKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetingKeyId, nameof(customTargetingKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomTargetingKeyName"/> with pattern
        /// <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetingKeyId">
        /// The <c>CustomTargetingKey</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomTargetingKeyName"/> with pattern
        /// <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string customTargetingKeyId) =>
            FormatNetworkCodeCustomTargetingKey(networkCodeId, customTargetingKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomTargetingKeyName"/> with pattern
        /// <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetingKeyId">
        /// The <c>CustomTargetingKey</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomTargetingKeyName"/> with pattern
        /// <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>.
        /// </returns>
        public static string FormatNetworkCodeCustomTargetingKey(string networkCodeId, string customTargetingKeyId) =>
            s_networkCodeCustomTargetingKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetingKeyId, nameof(customTargetingKeyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomTargetingKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customTargetingKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomTargetingKeyName"/> if successful.</returns>
        public static CustomTargetingKeyName Parse(string customTargetingKeyName) => Parse(customTargetingKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomTargetingKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customTargetingKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomTargetingKeyName"/> if successful.</returns>
        public static CustomTargetingKeyName Parse(string customTargetingKeyName, bool allowUnparsed) =>
            TryParse(customTargetingKeyName, allowUnparsed, out CustomTargetingKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomTargetingKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customTargetingKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomTargetingKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customTargetingKeyName, out CustomTargetingKeyName result) =>
            TryParse(customTargetingKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomTargetingKeyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customTargetingKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomTargetingKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customTargetingKeyName, bool allowUnparsed, out CustomTargetingKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(customTargetingKeyName, nameof(customTargetingKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeCustomTargetingKey.TryParseName(customTargetingKeyName, out resourceName))
            {
                result = FromNetworkCodeCustomTargetingKey(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customTargetingKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomTargetingKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customTargetingKeyId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomTargetingKeyId = customTargetingKeyId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomTargetingKeyName"/> class from the component parts of
        /// pattern <c>networks/{network_code}/customTargetingKeys/{custom_targeting_key}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetingKeyId">
        /// The <c>CustomTargetingKey</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CustomTargetingKeyName(string networkCodeId, string customTargetingKeyId) : this(ResourceNameType.NetworkCodeCustomTargetingKey, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), customTargetingKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetingKeyId, nameof(customTargetingKeyId)))
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
        /// The <c>CustomTargetingKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomTargetingKeyId { get; }

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
                case ResourceNameType.NetworkCodeCustomTargetingKey: return s_networkCodeCustomTargetingKey.Expand(NetworkCodeId, CustomTargetingKeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomTargetingKeyName);

        /// <inheritdoc/>
        public bool Equals(CustomTargetingKeyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomTargetingKeyName a, CustomTargetingKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomTargetingKeyName a, CustomTargetingKeyName b) => !(a == b);
    }

    public partial class CustomTargetingKey
    {
        /// <summary>
        /// <see cref="gaav::CustomTargetingKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomTargetingKeyName CustomTargetingKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomTargetingKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
