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
    /// <summary>Resource name for the <c>DeviceCategory</c> resource.</summary>
    public sealed partial class DeviceCategoryName : gax::IResourceName, sys::IEquatable<DeviceCategoryName>
    {
        /// <summary>The possible contents of <see cref="DeviceCategoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/deviceCategories/{device_category}</c>.
            /// </summary>
            NetworkCodeDeviceCategory = 1,
        }

        private static gax::PathTemplate s_networkCodeDeviceCategory = new gax::PathTemplate("networks/{network_code}/deviceCategories/{device_category}");

        /// <summary>Creates a <see cref="DeviceCategoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeviceCategoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeviceCategoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeviceCategoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeviceCategoryName"/> with the pattern
        /// <c>networks/{network_code}/deviceCategories/{device_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCategoryId">The <c>DeviceCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeviceCategoryName"/> constructed from the provided ids.</returns>
        public static DeviceCategoryName FromNetworkCodeDeviceCategory(string networkCodeId, string deviceCategoryId) =>
            new DeviceCategoryName(ResourceNameType.NetworkCodeDeviceCategory, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), deviceCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(deviceCategoryId, nameof(deviceCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeviceCategoryName"/> with pattern
        /// <c>networks/{network_code}/deviceCategories/{device_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCategoryId">The <c>DeviceCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeviceCategoryName"/> with pattern
        /// <c>networks/{network_code}/deviceCategories/{device_category}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string deviceCategoryId) =>
            FormatNetworkCodeDeviceCategory(networkCodeId, deviceCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeviceCategoryName"/> with pattern
        /// <c>networks/{network_code}/deviceCategories/{device_category}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCategoryId">The <c>DeviceCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeviceCategoryName"/> with pattern
        /// <c>networks/{network_code}/deviceCategories/{device_category}</c>.
        /// </returns>
        public static string FormatNetworkCodeDeviceCategory(string networkCodeId, string deviceCategoryId) =>
            s_networkCodeDeviceCategory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deviceCategoryId, nameof(deviceCategoryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeviceCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/deviceCategories/{device_category}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="deviceCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeviceCategoryName"/> if successful.</returns>
        public static DeviceCategoryName Parse(string deviceCategoryName) => Parse(deviceCategoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeviceCategoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/deviceCategories/{device_category}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deviceCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeviceCategoryName"/> if successful.</returns>
        public static DeviceCategoryName Parse(string deviceCategoryName, bool allowUnparsed) =>
            TryParse(deviceCategoryName, allowUnparsed, out DeviceCategoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeviceCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/deviceCategories/{device_category}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="deviceCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeviceCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deviceCategoryName, out DeviceCategoryName result) =>
            TryParse(deviceCategoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeviceCategoryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/deviceCategories/{device_category}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deviceCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeviceCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deviceCategoryName, bool allowUnparsed, out DeviceCategoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(deviceCategoryName, nameof(deviceCategoryName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeDeviceCategory.TryParseName(deviceCategoryName, out resourceName))
            {
                result = FromNetworkCodeDeviceCategory(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deviceCategoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeviceCategoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deviceCategoryId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeviceCategoryId = deviceCategoryId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeviceCategoryName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/deviceCategories/{device_category}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceCategoryId">The <c>DeviceCategory</c> ID. Must not be <c>null</c> or empty.</param>
        public DeviceCategoryName(string networkCodeId, string deviceCategoryId) : this(ResourceNameType.NetworkCodeDeviceCategory, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), deviceCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(deviceCategoryId, nameof(deviceCategoryId)))
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
        /// The <c>DeviceCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DeviceCategoryId { get; }

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
                case ResourceNameType.NetworkCodeDeviceCategory: return s_networkCodeDeviceCategory.Expand(NetworkCodeId, DeviceCategoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeviceCategoryName);

        /// <inheritdoc/>
        public bool Equals(DeviceCategoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeviceCategoryName a, DeviceCategoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeviceCategoryName a, DeviceCategoryName b) => !(a == b);
    }

    public partial class DeviceCategory
    {
        /// <summary>
        /// <see cref="gaav::DeviceCategoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::DeviceCategoryName DeviceCategoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::DeviceCategoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
