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
    /// <summary>Resource name for the <c>OperatingSystem</c> resource.</summary>
    public sealed partial class OperatingSystemName : gax::IResourceName, sys::IEquatable<OperatingSystemName>
    {
        /// <summary>The possible contents of <see cref="OperatingSystemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/operatingSystems/{operating_system}</c>.
            /// </summary>
            NetworkCodeOperatingSystem = 1,
        }

        private static gax::PathTemplate s_networkCodeOperatingSystem = new gax::PathTemplate("networks/{network_code}/operatingSystems/{operating_system}");

        /// <summary>Creates a <see cref="OperatingSystemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OperatingSystemName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OperatingSystemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OperatingSystemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OperatingSystemName"/> with the pattern
        /// <c>networks/{network_code}/operatingSystems/{operating_system}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatingSystemId">The <c>OperatingSystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OperatingSystemName"/> constructed from the provided ids.</returns>
        public static OperatingSystemName FromNetworkCodeOperatingSystem(string networkCodeId, string operatingSystemId) =>
            new OperatingSystemName(ResourceNameType.NetworkCodeOperatingSystem, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), operatingSystemId: gax::GaxPreconditions.CheckNotNullOrEmpty(operatingSystemId, nameof(operatingSystemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperatingSystemName"/> with pattern
        /// <c>networks/{network_code}/operatingSystems/{operating_system}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatingSystemId">The <c>OperatingSystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperatingSystemName"/> with pattern
        /// <c>networks/{network_code}/operatingSystems/{operating_system}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string operatingSystemId) =>
            FormatNetworkCodeOperatingSystem(networkCodeId, operatingSystemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperatingSystemName"/> with pattern
        /// <c>networks/{network_code}/operatingSystems/{operating_system}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatingSystemId">The <c>OperatingSystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperatingSystemName"/> with pattern
        /// <c>networks/{network_code}/operatingSystems/{operating_system}</c>.
        /// </returns>
        public static string FormatNetworkCodeOperatingSystem(string networkCodeId, string operatingSystemId) =>
            s_networkCodeOperatingSystem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(operatingSystemId, nameof(operatingSystemId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OperatingSystemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/operatingSystems/{operating_system}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="operatingSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OperatingSystemName"/> if successful.</returns>
        public static OperatingSystemName Parse(string operatingSystemName) => Parse(operatingSystemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OperatingSystemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/operatingSystems/{operating_system}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operatingSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OperatingSystemName"/> if successful.</returns>
        public static OperatingSystemName Parse(string operatingSystemName, bool allowUnparsed) =>
            TryParse(operatingSystemName, allowUnparsed, out OperatingSystemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperatingSystemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/operatingSystems/{operating_system}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="operatingSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperatingSystemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operatingSystemName, out OperatingSystemName result) =>
            TryParse(operatingSystemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperatingSystemName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/operatingSystems/{operating_system}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operatingSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperatingSystemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operatingSystemName, bool allowUnparsed, out OperatingSystemName result)
        {
            gax::GaxPreconditions.CheckNotNull(operatingSystemName, nameof(operatingSystemName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeOperatingSystem.TryParseName(operatingSystemName, out resourceName))
            {
                result = FromNetworkCodeOperatingSystem(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(operatingSystemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OperatingSystemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkCodeId = null, string operatingSystemId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkCodeId = networkCodeId;
            OperatingSystemId = operatingSystemId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OperatingSystemName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/operatingSystems/{operating_system}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatingSystemId">The <c>OperatingSystem</c> ID. Must not be <c>null</c> or empty.</param>
        public OperatingSystemName(string networkCodeId, string operatingSystemId) : this(ResourceNameType.NetworkCodeOperatingSystem, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), operatingSystemId: gax::GaxPreconditions.CheckNotNullOrEmpty(operatingSystemId, nameof(operatingSystemId)))
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
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>
        /// The <c>OperatingSystem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OperatingSystemId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeOperatingSystem: return s_networkCodeOperatingSystem.Expand(NetworkCodeId, OperatingSystemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OperatingSystemName);

        /// <inheritdoc/>
        public bool Equals(OperatingSystemName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OperatingSystemName a, OperatingSystemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OperatingSystemName a, OperatingSystemName b) => !(a == b);
    }

    public partial class OperatingSystem
    {
        /// <summary>
        /// <see cref="gaav::OperatingSystemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::OperatingSystemName OperatingSystemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::OperatingSystemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
