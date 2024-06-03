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
using gax = Google.Api.Gax;
using gcev = Google.Cloud.EdgeNetwork.V1;
using sys = System;

namespace Google.Cloud.EdgeNetwork.V1
{
    /// <summary>Resource name for the <c>Zone</c> resource.</summary>
    public sealed partial class ZoneName : gax::IResourceName, sys::IEquatable<ZoneName>
    {
        /// <summary>The possible contents of <see cref="ZoneName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/zones/{zone}</c>.
            /// </summary>
            ProjectLocationZone = 1,
        }

        private static gax::PathTemplate s_projectLocationZone = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}");

        /// <summary>Creates a <see cref="ZoneName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ZoneName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ZoneName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ZoneName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ZoneName"/> with the pattern <c>projects/{project}/locations/{location}/zones/{zone}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ZoneName"/> constructed from the provided ids.</returns>
        public static ZoneName FromProjectLocationZone(string projectId, string locationId, string zoneId) =>
            new ZoneName(ResourceNameType.ProjectLocationZone, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId) =>
            FormatProjectLocationZone(projectId, locationId, zoneId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>.
        /// </returns>
        public static string FormatProjectLocationZone(string projectId, string locationId, string zoneId) =>
            s_projectLocationZone.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)));

        /// <summary>Parses the given resource name string into a new <see cref="ZoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ZoneName"/> if successful.</returns>
        public static ZoneName Parse(string zoneName) => Parse(zoneName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ZoneName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ZoneName"/> if successful.</returns>
        public static ZoneName Parse(string zoneName, bool allowUnparsed) =>
            TryParse(zoneName, allowUnparsed, out ZoneName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ZoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ZoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string zoneName, out ZoneName result) => TryParse(zoneName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ZoneName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/zones/{zone}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ZoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string zoneName, bool allowUnparsed, out ZoneName result)
        {
            gax::GaxPreconditions.CheckNotNull(zoneName, nameof(zoneName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZone.TryParseName(zoneName, out resourceName))
            {
                result = FromProjectLocationZone(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(zoneName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ZoneName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ZoneName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        public ZoneName(string projectId, string locationId, string zoneId) : this(ResourceNameType.ProjectLocationZone, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZone: return s_projectLocationZone.Expand(ProjectId, LocationId, ZoneId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ZoneName);

        /// <inheritdoc/>
        public bool Equals(ZoneName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ZoneName a, ZoneName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ZoneName a, ZoneName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>
            /// .
            /// </summary>
            ProjectLocationZoneNetwork = 1,
        }

        private static gax::PathTemplate s_projectLocationZoneNetwork = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectLocationZoneNetwork(string projectId, string locationId, string zoneId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectLocationZoneNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId, string networkId) =>
            FormatProjectLocationZoneNetwork(projectId, locationId, zoneId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectLocationZoneNetwork(string projectId, string locationId, string zoneId, string networkId) =>
            s_projectLocationZoneNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZoneNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectLocationZoneNetwork(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string networkId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NetworkId = networkId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string locationId, string zoneId, string networkId) : this(ResourceNameType.ProjectLocationZoneNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZoneNetwork: return s_projectLocationZoneNetwork.Expand(ProjectId, LocationId, ZoneId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subnet</c> resource.</summary>
    public sealed partial class SubnetName : gax::IResourceName, sys::IEquatable<SubnetName>
    {
        /// <summary>The possible contents of <see cref="SubnetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>
            /// .
            /// </summary>
            ProjectLocationZoneSubnet = 1,
        }

        private static gax::PathTemplate s_projectLocationZoneSubnet = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}");

        /// <summary>Creates a <see cref="SubnetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubnetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubnetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubnetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubnetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubnetName"/> constructed from the provided ids.</returns>
        public static SubnetName FromProjectLocationZoneSubnet(string projectId, string locationId, string zoneId, string subnetId) =>
            new SubnetName(ResourceNameType.ProjectLocationZoneSubnet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), subnetId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId, string subnetId) =>
            FormatProjectLocationZoneSubnet(projectId, locationId, zoneId, subnetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>.
        /// </returns>
        public static string FormatProjectLocationZoneSubnet(string projectId, string locationId, string zoneId, string subnetId) =>
            s_projectLocationZoneSubnet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubnetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubnetName"/> if successful.</returns>
        public static SubnetName Parse(string subnetName) => Parse(subnetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubnetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubnetName"/> if successful.</returns>
        public static SubnetName Parse(string subnetName, bool allowUnparsed) =>
            TryParse(subnetName, allowUnparsed, out SubnetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetName, out SubnetName result) => TryParse(subnetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetName, bool allowUnparsed, out SubnetName result)
        {
            gax::GaxPreconditions.CheckNotNull(subnetName, nameof(subnetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZoneSubnet.TryParseName(subnetName, out resourceName))
            {
                result = FromProjectLocationZoneSubnet(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subnetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubnetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string subnetId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SubnetId = subnetId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubnetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/subnets/{subnet}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetId">The <c>Subnet</c> ID. Must not be <c>null</c> or empty.</param>
        public SubnetName(string projectId, string locationId, string zoneId, string subnetId) : this(ResourceNameType.ProjectLocationZoneSubnet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), subnetId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetId, nameof(subnetId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subnet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubnetId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZoneSubnet: return s_projectLocationZoneSubnet.Expand(ProjectId, LocationId, ZoneId, SubnetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubnetName);

        /// <inheritdoc/>
        public bool Equals(SubnetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubnetName a, SubnetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubnetName a, SubnetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Interconnect</c> resource.</summary>
    public sealed partial class InterconnectName : gax::IResourceName, sys::IEquatable<InterconnectName>
    {
        /// <summary>The possible contents of <see cref="InterconnectName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>.
            /// </summary>
            ProjectLocationZoneInterconnect = 1,
        }

        private static gax::PathTemplate s_projectLocationZoneInterconnect = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}");

        /// <summary>Creates a <see cref="InterconnectName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InterconnectName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InterconnectName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InterconnectName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InterconnectName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectId">The <c>Interconnect</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InterconnectName"/> constructed from the provided ids.</returns>
        public static InterconnectName FromProjectLocationZoneInterconnect(string projectId, string locationId, string zoneId, string interconnectId) =>
            new InterconnectName(ResourceNameType.ProjectLocationZoneInterconnect, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), interconnectId: gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectId, nameof(interconnectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterconnectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectId">The <c>Interconnect</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InterconnectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId, string interconnectId) =>
            FormatProjectLocationZoneInterconnect(projectId, locationId, zoneId, interconnectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterconnectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectId">The <c>Interconnect</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InterconnectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>.
        /// </returns>
        public static string FormatProjectLocationZoneInterconnect(string projectId, string locationId, string zoneId, string interconnectId) =>
            s_projectLocationZoneInterconnect.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectId, nameof(interconnectId)));

        /// <summary>Parses the given resource name string into a new <see cref="InterconnectName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interconnectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InterconnectName"/> if successful.</returns>
        public static InterconnectName Parse(string interconnectName) => Parse(interconnectName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterconnectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interconnectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InterconnectName"/> if successful.</returns>
        public static InterconnectName Parse(string interconnectName, bool allowUnparsed) =>
            TryParse(interconnectName, allowUnparsed, out InterconnectName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterconnectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interconnectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterconnectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interconnectName, out InterconnectName result) =>
            TryParse(interconnectName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterconnectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interconnectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterconnectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interconnectName, bool allowUnparsed, out InterconnectName result)
        {
            gax::GaxPreconditions.CheckNotNull(interconnectName, nameof(interconnectName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZoneInterconnect.TryParseName(interconnectName, out resourceName))
            {
                result = FromProjectLocationZoneInterconnect(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(interconnectName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InterconnectName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string interconnectId = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InterconnectId = interconnectId;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterconnectName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnects/{interconnect}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectId">The <c>Interconnect</c> ID. Must not be <c>null</c> or empty.</param>
        public InterconnectName(string projectId, string locationId, string zoneId, string interconnectId) : this(ResourceNameType.ProjectLocationZoneInterconnect, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), interconnectId: gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectId, nameof(interconnectId)))
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
        /// The <c>Interconnect</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InterconnectId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZoneInterconnect: return s_projectLocationZoneInterconnect.Expand(ProjectId, LocationId, ZoneId, InterconnectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InterconnectName);

        /// <inheritdoc/>
        public bool Equals(InterconnectName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InterconnectName a, InterconnectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InterconnectName a, InterconnectName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InterconnectAttachment</c> resource.</summary>
    public sealed partial class InterconnectAttachmentName : gax::IResourceName, sys::IEquatable<InterconnectAttachmentName>
    {
        /// <summary>The possible contents of <see cref="InterconnectAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
            /// .
            /// </summary>
            ProjectLocationZoneInterconnectAttachment = 1,
        }

        private static gax::PathTemplate s_projectLocationZoneInterconnectAttachment = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}");

        /// <summary>Creates a <see cref="InterconnectAttachmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InterconnectAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InterconnectAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InterconnectAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InterconnectAttachmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectAttachmentId">
        /// The <c>InterconnectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="InterconnectAttachmentName"/> constructed from the provided ids.
        /// </returns>
        public static InterconnectAttachmentName FromProjectLocationZoneInterconnectAttachment(string projectId, string locationId, string zoneId, string interconnectAttachmentId) =>
            new InterconnectAttachmentName(ResourceNameType.ProjectLocationZoneInterconnectAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), interconnectAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectAttachmentId">
        /// The <c>InterconnectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId, string interconnectAttachmentId) =>
            FormatProjectLocationZoneInterconnectAttachment(projectId, locationId, zoneId, interconnectAttachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectAttachmentId">
        /// The <c>InterconnectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationZoneInterconnectAttachment(string projectId, string locationId, string zoneId, string interconnectAttachmentId) =>
            s_projectLocationZoneInterconnectAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterconnectAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interconnectAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InterconnectAttachmentName"/> if successful.</returns>
        public static InterconnectAttachmentName Parse(string interconnectAttachmentName) =>
            Parse(interconnectAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterconnectAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interconnectAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InterconnectAttachmentName"/> if successful.</returns>
        public static InterconnectAttachmentName Parse(string interconnectAttachmentName, bool allowUnparsed) =>
            TryParse(interconnectAttachmentName, allowUnparsed, out InterconnectAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterconnectAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="interconnectAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterconnectAttachmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interconnectAttachmentName, out InterconnectAttachmentName result) =>
            TryParse(interconnectAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InterconnectAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="interconnectAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InterconnectAttachmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string interconnectAttachmentName, bool allowUnparsed, out InterconnectAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(interconnectAttachmentName, nameof(interconnectAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZoneInterconnectAttachment.TryParseName(interconnectAttachmentName, out resourceName))
            {
                result = FromProjectLocationZoneInterconnectAttachment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(interconnectAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InterconnectAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string interconnectAttachmentId = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InterconnectAttachmentId = interconnectAttachmentId;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterconnectAttachmentName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/interconnectAttachments/{interconnect_attachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="interconnectAttachmentId">
        /// The <c>InterconnectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public InterconnectAttachmentName(string projectId, string locationId, string zoneId, string interconnectAttachmentId) : this(ResourceNameType.ProjectLocationZoneInterconnectAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), interconnectAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(interconnectAttachmentId, nameof(interconnectAttachmentId)))
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
        /// The <c>InterconnectAttachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string InterconnectAttachmentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZoneInterconnectAttachment: return s_projectLocationZoneInterconnectAttachment.Expand(ProjectId, LocationId, ZoneId, InterconnectAttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InterconnectAttachmentName);

        /// <inheritdoc/>
        public bool Equals(InterconnectAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InterconnectAttachmentName a, InterconnectAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InterconnectAttachmentName a, InterconnectAttachmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Router</c> resource.</summary>
    public sealed partial class RouterName : gax::IResourceName, sys::IEquatable<RouterName>
    {
        /// <summary>The possible contents of <see cref="RouterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>
            /// .
            /// </summary>
            ProjectLocationZoneRouter = 1,
        }

        private static gax::PathTemplate s_projectLocationZoneRouter = new gax::PathTemplate("projects/{project}/locations/{location}/zones/{zone}/routers/{router}");

        /// <summary>Creates a <see cref="RouterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RouterName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RouterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RouterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RouterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routerId">The <c>Router</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RouterName"/> constructed from the provided ids.</returns>
        public static RouterName FromProjectLocationZoneRouter(string projectId, string locationId, string zoneId, string routerId) =>
            new RouterName(ResourceNameType.ProjectLocationZoneRouter, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), routerId: gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RouterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routerId">The <c>Router</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RouterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string zoneId, string routerId) =>
            FormatProjectLocationZoneRouter(projectId, locationId, zoneId, routerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RouterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routerId">The <c>Router</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RouterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>.
        /// </returns>
        public static string FormatProjectLocationZoneRouter(string projectId, string locationId, string zoneId, string routerId) =>
            s_projectLocationZoneRouter.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)));

        /// <summary>Parses the given resource name string into a new <see cref="RouterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="routerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RouterName"/> if successful.</returns>
        public static RouterName Parse(string routerName) => Parse(routerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RouterName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="routerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RouterName"/> if successful.</returns>
        public static RouterName Parse(string routerName, bool allowUnparsed) =>
            TryParse(routerName, allowUnparsed, out RouterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RouterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="routerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RouterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string routerName, out RouterName result) => TryParse(routerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RouterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="routerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RouterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string routerName, bool allowUnparsed, out RouterName result)
        {
            gax::GaxPreconditions.CheckNotNull(routerName, nameof(routerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationZoneRouter.TryParseName(routerName, out resourceName))
            {
                result = FromProjectLocationZoneRouter(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(routerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RouterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string routerId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RouterId = routerId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RouterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/zones/{zone}/routers/{router}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routerId">The <c>Router</c> ID. Must not be <c>null</c> or empty.</param>
        public RouterName(string projectId, string locationId, string zoneId, string routerId) : this(ResourceNameType.ProjectLocationZoneRouter, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), routerId: gax::GaxPreconditions.CheckNotNullOrEmpty(routerId, nameof(routerId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Router</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RouterId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationZoneRouter: return s_projectLocationZoneRouter.Expand(ProjectId, LocationId, ZoneId, RouterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RouterName);

        /// <inheritdoc/>
        public bool Equals(RouterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RouterName a, RouterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RouterName a, RouterName b) => !(a == b);
    }

    public partial class Zone
    {
        /// <summary>
        /// <see cref="gcev::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Network
    {
        /// <summary>
        /// <see cref="gcev::NetworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::NetworkName NetworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::NetworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Subnet
    {
        /// <summary>
        /// <see cref="gcev::SubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::SubnetName SubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::SubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class Interconnect
    {
        /// <summary>
        /// <see cref="gcev::InterconnectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::InterconnectName InterconnectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::InterconnectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InterconnectAttachment
    {
        /// <summary>
        /// <see cref="gcev::InterconnectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcev::InterconnectAttachmentName InterconnectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::InterconnectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InterconnectName"/>-typed view over the <see cref="Interconnect"/> resource name property.
        /// </summary>
        public InterconnectName InterconnectAsInterconnectName
        {
            get => string.IsNullOrEmpty(Interconnect) ? null : InterconnectName.Parse(Interconnect, allowUnparsed: true);
            set => Interconnect = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class Router
    {
        /// <summary>
        /// <see cref="gcev::RouterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::RouterName RouterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::RouterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class RouterStatus
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }
}
