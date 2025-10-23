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
    /// <summary>Resource name for the <c>MobileDevice</c> resource.</summary>
    public sealed partial class MobileDeviceName : gax::IResourceName, sys::IEquatable<MobileDeviceName>
    {
        /// <summary>The possible contents of <see cref="MobileDeviceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/mobileDevices/{mobile_device}</c>.
            /// </summary>
            NetworkCodeMobileDevice = 1,
        }

        private static gax::PathTemplate s_networkCodeMobileDevice = new gax::PathTemplate("networks/{network_code}/mobileDevices/{mobile_device}");

        /// <summary>Creates a <see cref="MobileDeviceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MobileDeviceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MobileDeviceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MobileDeviceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MobileDeviceName"/> with the pattern
        /// <c>networks/{network_code}/mobileDevices/{mobile_device}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mobileDeviceId">The <c>MobileDevice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MobileDeviceName"/> constructed from the provided ids.</returns>
        public static MobileDeviceName FromNetworkCodeMobileDevice(string networkCodeId, string mobileDeviceId) =>
            new MobileDeviceName(ResourceNameType.NetworkCodeMobileDevice, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), mobileDeviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(mobileDeviceId, nameof(mobileDeviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MobileDeviceName"/> with pattern
        /// <c>networks/{network_code}/mobileDevices/{mobile_device}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mobileDeviceId">The <c>MobileDevice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MobileDeviceName"/> with pattern
        /// <c>networks/{network_code}/mobileDevices/{mobile_device}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string mobileDeviceId) =>
            FormatNetworkCodeMobileDevice(networkCodeId, mobileDeviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MobileDeviceName"/> with pattern
        /// <c>networks/{network_code}/mobileDevices/{mobile_device}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mobileDeviceId">The <c>MobileDevice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MobileDeviceName"/> with pattern
        /// <c>networks/{network_code}/mobileDevices/{mobile_device}</c>.
        /// </returns>
        public static string FormatNetworkCodeMobileDevice(string networkCodeId, string mobileDeviceId) =>
            s_networkCodeMobileDevice.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mobileDeviceId, nameof(mobileDeviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="MobileDeviceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/mobileDevices/{mobile_device}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mobileDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MobileDeviceName"/> if successful.</returns>
        public static MobileDeviceName Parse(string mobileDeviceName) => Parse(mobileDeviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MobileDeviceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/mobileDevices/{mobile_device}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mobileDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MobileDeviceName"/> if successful.</returns>
        public static MobileDeviceName Parse(string mobileDeviceName, bool allowUnparsed) =>
            TryParse(mobileDeviceName, allowUnparsed, out MobileDeviceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MobileDeviceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/mobileDevices/{mobile_device}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mobileDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MobileDeviceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mobileDeviceName, out MobileDeviceName result) =>
            TryParse(mobileDeviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MobileDeviceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/mobileDevices/{mobile_device}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mobileDeviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MobileDeviceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mobileDeviceName, bool allowUnparsed, out MobileDeviceName result)
        {
            gax::GaxPreconditions.CheckNotNull(mobileDeviceName, nameof(mobileDeviceName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeMobileDevice.TryParseName(mobileDeviceName, out resourceName))
            {
                result = FromNetworkCodeMobileDevice(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mobileDeviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MobileDeviceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string mobileDeviceId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MobileDeviceId = mobileDeviceId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MobileDeviceName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/mobileDevices/{mobile_device}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mobileDeviceId">The <c>MobileDevice</c> ID. Must not be <c>null</c> or empty.</param>
        public MobileDeviceName(string networkCodeId, string mobileDeviceId) : this(ResourceNameType.NetworkCodeMobileDevice, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), mobileDeviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(mobileDeviceId, nameof(mobileDeviceId)))
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
        /// The <c>MobileDevice</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MobileDeviceId { get; }

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
                case ResourceNameType.NetworkCodeMobileDevice: return s_networkCodeMobileDevice.Expand(NetworkCodeId, MobileDeviceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MobileDeviceName);

        /// <inheritdoc/>
        public bool Equals(MobileDeviceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MobileDeviceName a, MobileDeviceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MobileDeviceName a, MobileDeviceName b) => !(a == b);
    }

    public partial class MobileDevice
    {
        /// <summary>
        /// <see cref="gaav::MobileDeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::MobileDeviceName MobileDeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::MobileDeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DeviceManufacturerName"/>-typed view over the <see cref="Manufacturer"/> resource name property.
        /// </summary>
        public DeviceManufacturerName ManufacturerAsDeviceManufacturerName
        {
            get => string.IsNullOrEmpty(Manufacturer) ? null : DeviceManufacturerName.Parse(Manufacturer, allowUnparsed: true);
            set => Manufacturer = value?.ToString() ?? "";
        }
    }
}
