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
    /// <summary>Resource name for the <c>DeviceCapability</c> resource.</summary>
    public sealed partial class DeviceCapabilityName : gax::IResourceName, sys::IEquatable<DeviceCapabilityName>
    {
        /// <summary>The possible contents of <see cref="DeviceCapabilityName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>.
            /// </summary>
            NetworkCodeDeviceCapability = 1,
        }

        private static gax::PathTemplate s_networkCodeDeviceCapability = new gax::PathTemplate("networks/{network_code}/deviceCapabilities/{device_capability}");

        /// <summary>Creates a <see cref="DeviceCapabilityName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeviceCapabilityName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeviceCapabilityName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeviceCapabilityName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeviceCapabilityName"/> with the pattern
        /// <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCapabilityId">The <c>DeviceCapability</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeviceCapabilityName"/> constructed from the provided ids.</returns>
        public static DeviceCapabilityName FromNetworkCodeDeviceCapability(string networkCodeId, string deviceCapabilityId) =>
            new DeviceCapabilityName(ResourceNameType.NetworkCodeDeviceCapability, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), deviceCapabilityId: gax::GaxPreconditions.CheckNotNullOrEmpty(deviceCapabilityId, nameof(deviceCapabilityId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeviceCapabilityName"/> with pattern
        /// <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCapabilityId">The <c>DeviceCapability</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeviceCapabilityName"/> with pattern
        /// <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string deviceCapabilityId) =>
            FormatNetworkCodeDeviceCapability(networkCodeId, deviceCapabilityId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeviceCapabilityName"/> with pattern
        /// <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCapabilityId">The <c>DeviceCapability</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeviceCapabilityName"/> with pattern
        /// <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>.
        /// </returns>
        public static string FormatNetworkCodeDeviceCapability(string networkCodeId, string deviceCapabilityId) =>
            s_networkCodeDeviceCapability.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deviceCapabilityId, nameof(deviceCapabilityId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeviceCapabilityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/deviceCapabilities/{device_capability}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deviceCapabilityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeviceCapabilityName"/> if successful.</returns>
        public static DeviceCapabilityName Parse(string deviceCapabilityName) => Parse(deviceCapabilityName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeviceCapabilityName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/deviceCapabilities/{device_capability}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deviceCapabilityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeviceCapabilityName"/> if successful.</returns>
        public static DeviceCapabilityName Parse(string deviceCapabilityName, bool allowUnparsed) =>
            TryParse(deviceCapabilityName, allowUnparsed, out DeviceCapabilityName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeviceCapabilityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/deviceCapabilities/{device_capability}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deviceCapabilityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeviceCapabilityName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deviceCapabilityName, out DeviceCapabilityName result) =>
            TryParse(deviceCapabilityName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeviceCapabilityName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>networks/{network_code}/deviceCapabilities/{device_capability}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deviceCapabilityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeviceCapabilityName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deviceCapabilityName, bool allowUnparsed, out DeviceCapabilityName result)
        {
            gax::GaxPreconditions.CheckNotNull(deviceCapabilityName, nameof(deviceCapabilityName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeDeviceCapability.TryParseName(deviceCapabilityName, out resourceName))
            {
                result = FromNetworkCodeDeviceCapability(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deviceCapabilityName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeviceCapabilityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deviceCapabilityId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeviceCapabilityId = deviceCapabilityId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeviceCapabilityName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/deviceCapabilities/{device_capability}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCapabilityId">The <c>DeviceCapability</c> ID. Must not be <c>null</c> or empty.</param>
        public DeviceCapabilityName(string networkCodeId, string deviceCapabilityId) : this(ResourceNameType.NetworkCodeDeviceCapability, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), deviceCapabilityId: gax::GaxPreconditions.CheckNotNullOrEmpty(deviceCapabilityId, nameof(deviceCapabilityId)))
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
        /// The <c>DeviceCapability</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DeviceCapabilityId { get; }

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
                case ResourceNameType.NetworkCodeDeviceCapability: return s_networkCodeDeviceCapability.Expand(NetworkCodeId, DeviceCapabilityId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeviceCapabilityName);

        /// <inheritdoc/>
        public bool Equals(DeviceCapabilityName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeviceCapabilityName a, DeviceCapabilityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeviceCapabilityName a, DeviceCapabilityName b) => !(a == b);
    }

    public partial class DeviceCapability
    {
        /// <summary>
        /// <see cref="gaav::DeviceCapabilityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DeviceCapabilityName DeviceCapabilityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DeviceCapabilityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
