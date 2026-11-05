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
    /// <summary>Resource name for the <c>AllocationDeliveryProfile</c> resource.</summary>
    public sealed partial class AllocationDeliveryProfileName : gax::IResourceName, sys::IEquatable<AllocationDeliveryProfileName>
    {
        /// <summary>The possible contents of <see cref="AllocationDeliveryProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>.
            /// </summary>
            NetworkCodeAllocationDeliveryProfile = 1,
        }

        private static gax::PathTemplate s_networkCodeAllocationDeliveryProfile = new gax::PathTemplate("networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}");

        /// <summary>
        /// Creates a <see cref="AllocationDeliveryProfileName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AllocationDeliveryProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AllocationDeliveryProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AllocationDeliveryProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AllocationDeliveryProfileName"/> with the pattern
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="allocationDeliveryProfileId">
        /// The <c>AllocationDeliveryProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AllocationDeliveryProfileName"/> constructed from the provided ids.
        /// </returns>
        public static AllocationDeliveryProfileName FromNetworkCodeAllocationDeliveryProfile(string networkCodeId, string allocationDeliveryProfileId) =>
            new AllocationDeliveryProfileName(ResourceNameType.NetworkCodeAllocationDeliveryProfile, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), allocationDeliveryProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(allocationDeliveryProfileId, nameof(allocationDeliveryProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AllocationDeliveryProfileName"/> with
        /// pattern <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="allocationDeliveryProfileId">
        /// The <c>AllocationDeliveryProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AllocationDeliveryProfileName"/> with pattern
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string allocationDeliveryProfileId) =>
            FormatNetworkCodeAllocationDeliveryProfile(networkCodeId, allocationDeliveryProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AllocationDeliveryProfileName"/> with
        /// pattern <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="allocationDeliveryProfileId">
        /// The <c>AllocationDeliveryProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AllocationDeliveryProfileName"/> with pattern
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>.
        /// </returns>
        public static string FormatNetworkCodeAllocationDeliveryProfile(string networkCodeId, string allocationDeliveryProfileId) =>
            s_networkCodeAllocationDeliveryProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(allocationDeliveryProfileId, nameof(allocationDeliveryProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AllocationDeliveryProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="allocationDeliveryProfileName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AllocationDeliveryProfileName"/> if successful.</returns>
        public static AllocationDeliveryProfileName Parse(string allocationDeliveryProfileName) =>
            Parse(allocationDeliveryProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AllocationDeliveryProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="allocationDeliveryProfileName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AllocationDeliveryProfileName"/> if successful.</returns>
        public static AllocationDeliveryProfileName Parse(string allocationDeliveryProfileName, bool allowUnparsed) =>
            TryParse(allocationDeliveryProfileName, allowUnparsed, out AllocationDeliveryProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AllocationDeliveryProfileName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="allocationDeliveryProfileName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AllocationDeliveryProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string allocationDeliveryProfileName, out AllocationDeliveryProfileName result) =>
            TryParse(allocationDeliveryProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AllocationDeliveryProfileName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="allocationDeliveryProfileName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AllocationDeliveryProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string allocationDeliveryProfileName, bool allowUnparsed, out AllocationDeliveryProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(allocationDeliveryProfileName, nameof(allocationDeliveryProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeAllocationDeliveryProfile.TryParseName(allocationDeliveryProfileName, out resourceName))
            {
                result = FromNetworkCodeAllocationDeliveryProfile(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(allocationDeliveryProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AllocationDeliveryProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string allocationDeliveryProfileId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AllocationDeliveryProfileId = allocationDeliveryProfileId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AllocationDeliveryProfileName"/> class from the component parts of
        /// pattern <c>networks/{network_code}/allocationDeliveryProfiles/{allocation_delivery_profile}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="allocationDeliveryProfileId">
        /// The <c>AllocationDeliveryProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AllocationDeliveryProfileName(string networkCodeId, string allocationDeliveryProfileId) : this(ResourceNameType.NetworkCodeAllocationDeliveryProfile, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), allocationDeliveryProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(allocationDeliveryProfileId, nameof(allocationDeliveryProfileId)))
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
        /// The <c>AllocationDeliveryProfile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AllocationDeliveryProfileId { get; }

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
                case ResourceNameType.NetworkCodeAllocationDeliveryProfile: return s_networkCodeAllocationDeliveryProfile.Expand(NetworkCodeId, AllocationDeliveryProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AllocationDeliveryProfileName);

        /// <inheritdoc/>
        public bool Equals(AllocationDeliveryProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AllocationDeliveryProfileName a, AllocationDeliveryProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AllocationDeliveryProfileName a, AllocationDeliveryProfileName b) => !(a == b);
    }

    public partial class AllocationDeliveryProfile
    {
        /// <summary>
        /// <see cref="gaav::AllocationDeliveryProfileName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::AllocationDeliveryProfileName AllocationDeliveryProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::AllocationDeliveryProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
