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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkConnectivity.V1Alpha1;
using sys = System;

namespace Google.Cloud.NetworkConnectivity.V1Alpha1
{
    /// <summary>Resource name for the <c>Hub</c> resource.</summary>
    public sealed partial class HubName : gax::IResourceName, sys::IEquatable<HubName>
    {
        /// <summary>The possible contents of <see cref="HubName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/global/hubs/{hub}</c>.</summary>
            ProjectHub = 1,
        }

        private static gax::PathTemplate s_projectHub = new gax::PathTemplate("projects/{project}/locations/global/hubs/{hub}");

        /// <summary>Creates a <see cref="HubName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HubName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HubName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HubName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HubName"/> with the pattern <c>projects/{project}/locations/global/hubs/{hub}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hubId">The <c>Hub</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HubName"/> constructed from the provided ids.</returns>
        public static HubName FromProjectHub(string projectId, string hubId) =>
            new HubName(ResourceNameType.ProjectHub, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), hubId: gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HubName"/> with pattern
        /// <c>projects/{project}/locations/global/hubs/{hub}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hubId">The <c>Hub</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HubName"/> with pattern
        /// <c>projects/{project}/locations/global/hubs/{hub}</c>.
        /// </returns>
        public static string Format(string projectId, string hubId) => FormatProjectHub(projectId, hubId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HubName"/> with pattern
        /// <c>projects/{project}/locations/global/hubs/{hub}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hubId">The <c>Hub</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HubName"/> with pattern
        /// <c>projects/{project}/locations/global/hubs/{hub}</c>.
        /// </returns>
        public static string FormatProjectHub(string projectId, string hubId) =>
            s_projectHub.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)));

        /// <summary>Parses the given resource name string into a new <see cref="HubName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/hubs/{hub}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HubName"/> if successful.</returns>
        public static HubName Parse(string hubName) => Parse(hubName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HubName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/hubs/{hub}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HubName"/> if successful.</returns>
        public static HubName Parse(string hubName, bool allowUnparsed) =>
            TryParse(hubName, allowUnparsed, out HubName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="HubName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/hubs/{hub}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HubName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hubName, out HubName result) => TryParse(hubName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HubName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/global/hubs/{hub}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HubName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hubName, bool allowUnparsed, out HubName result)
        {
            gax::GaxPreconditions.CheckNotNull(hubName, nameof(hubName));
            gax::TemplatedResourceName resourceName;
            if (s_projectHub.TryParseName(hubName, out resourceName))
            {
                result = FromProjectHub(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hubName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HubName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hubId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HubId = hubId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HubName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/global/hubs/{hub}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hubId">The <c>Hub</c> ID. Must not be <c>null</c> or empty.</param>
        public HubName(string projectId, string hubId) : this(ResourceNameType.ProjectHub, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), hubId: gax::GaxPreconditions.CheckNotNullOrEmpty(hubId, nameof(hubId)))
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
        /// The <c>Hub</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string HubId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectHub: return s_projectHub.Expand(ProjectId, HubId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HubName);

        /// <inheritdoc/>
        public bool Equals(HubName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HubName a, HubName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HubName a, HubName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Spoke</c> resource.</summary>
    public sealed partial class SpokeName : gax::IResourceName, sys::IEquatable<SpokeName>
    {
        /// <summary>The possible contents of <see cref="SpokeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/spokes/{spoke}</c>.
            /// </summary>
            ProjectLocationSpoke = 1,
        }

        private static gax::PathTemplate s_projectLocationSpoke = new gax::PathTemplate("projects/{project}/locations/{location}/spokes/{spoke}");

        /// <summary>Creates a <see cref="SpokeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SpokeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SpokeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SpokeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SpokeName"/> with the pattern <c>projects/{project}/locations/{location}/spokes/{spoke}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spokeId">The <c>Spoke</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SpokeName"/> constructed from the provided ids.</returns>
        public static SpokeName FromProjectLocationSpoke(string projectId, string locationId, string spokeId) =>
            new SpokeName(ResourceNameType.ProjectLocationSpoke, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spokeId: gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpokeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spokes/{spoke}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spokeId">The <c>Spoke</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpokeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spokes/{spoke}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string spokeId) =>
            FormatProjectLocationSpoke(projectId, locationId, spokeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpokeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spokes/{spoke}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spokeId">The <c>Spoke</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpokeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spokes/{spoke}</c>.
        /// </returns>
        public static string FormatProjectLocationSpoke(string projectId, string locationId, string spokeId) =>
            s_projectLocationSpoke.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)));

        /// <summary>Parses the given resource name string into a new <see cref="SpokeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spokes/{spoke}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="spokeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpokeName"/> if successful.</returns>
        public static SpokeName Parse(string spokeName) => Parse(spokeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpokeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spokes/{spoke}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spokeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SpokeName"/> if successful.</returns>
        public static SpokeName Parse(string spokeName, bool allowUnparsed) =>
            TryParse(spokeName, allowUnparsed, out SpokeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpokeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spokes/{spoke}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="spokeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpokeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spokeName, out SpokeName result) => TryParse(spokeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpokeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spokes/{spoke}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spokeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpokeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spokeName, bool allowUnparsed, out SpokeName result)
        {
            gax::GaxPreconditions.CheckNotNull(spokeName, nameof(spokeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpoke.TryParseName(spokeName, out resourceName))
            {
                result = FromProjectLocationSpoke(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(spokeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SpokeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string spokeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SpokeId = spokeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SpokeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/spokes/{spoke}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spokeId">The <c>Spoke</c> ID. Must not be <c>null</c> or empty.</param>
        public SpokeName(string projectId, string locationId, string spokeId) : this(ResourceNameType.ProjectLocationSpoke, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spokeId: gax::GaxPreconditions.CheckNotNullOrEmpty(spokeId, nameof(spokeId)))
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
        /// The <c>Spoke</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpokeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpoke: return s_projectLocationSpoke.Expand(ProjectId, LocationId, SpokeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpokeName);

        /// <inheritdoc/>
        public bool Equals(SpokeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SpokeName a, SpokeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SpokeName a, SpokeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>VpnTunnel</c> resource.</summary>
    public sealed partial class VpnTunnelName : gax::IResourceName, sys::IEquatable<VpnTunnelName>
    {
        /// <summary>The possible contents of <see cref="VpnTunnelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>.
            /// </summary>
            ProjectRegionResource = 1,
        }

        private static gax::PathTemplate s_projectRegionResource = new gax::PathTemplate("projects/{project}/regions/{region}/vpnTunnels/{resource_id}");

        /// <summary>Creates a <see cref="VpnTunnelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VpnTunnelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VpnTunnelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VpnTunnelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VpnTunnelName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VpnTunnelName"/> constructed from the provided ids.</returns>
        public static VpnTunnelName FromProjectRegionResource(string projectId, string regionId, string resourceId) =>
            new VpnTunnelName(ResourceNameType.ProjectRegionResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), resourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VpnTunnelName"/> with pattern
        /// <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VpnTunnelName"/> with pattern
        /// <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string resourceId) =>
            FormatProjectRegionResource(projectId, regionId, resourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VpnTunnelName"/> with pattern
        /// <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VpnTunnelName"/> with pattern
        /// <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>.
        /// </returns>
        public static string FormatProjectRegionResource(string projectId, string regionId, string resourceId) =>
            s_projectRegionResource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="VpnTunnelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="vpnTunnelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VpnTunnelName"/> if successful.</returns>
        public static VpnTunnelName Parse(string vpnTunnelName) => Parse(vpnTunnelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VpnTunnelName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vpnTunnelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VpnTunnelName"/> if successful.</returns>
        public static VpnTunnelName Parse(string vpnTunnelName, bool allowUnparsed) =>
            TryParse(vpnTunnelName, allowUnparsed, out VpnTunnelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VpnTunnelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="vpnTunnelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VpnTunnelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vpnTunnelName, out VpnTunnelName result) => TryParse(vpnTunnelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VpnTunnelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vpnTunnelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VpnTunnelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vpnTunnelName, bool allowUnparsed, out VpnTunnelName result)
        {
            gax::GaxPreconditions.CheckNotNull(vpnTunnelName, nameof(vpnTunnelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionResource.TryParseName(vpnTunnelName, out resourceName))
            {
                result = FromProjectRegionResource(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(vpnTunnelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VpnTunnelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string resourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            ResourceId = resourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VpnTunnelName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/vpnTunnels/{resource_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        public VpnTunnelName(string projectId, string regionId, string resourceId) : this(ResourceNameType.ProjectRegionResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), resourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Resource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ResourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionResource: return s_projectRegionResource.Expand(ProjectId, RegionId, ResourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VpnTunnelName);

        /// <inheritdoc/>
        public bool Equals(VpnTunnelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VpnTunnelName a, VpnTunnelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VpnTunnelName a, VpnTunnelName b) => !(a == b);
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
            /// <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>.
            /// </summary>
            ProjectRegionResource = 1,
        }

        private static gax::PathTemplate s_projectRegionResource = new gax::PathTemplate("projects/{project}/regions/{region}/interconnectAttachments/{resource_id}");

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
        /// <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="InterconnectAttachmentName"/> constructed from the provided ids.
        /// </returns>
        public static InterconnectAttachmentName FromProjectRegionResource(string projectId, string regionId, string resourceId) =>
            new InterconnectAttachmentName(ResourceNameType.ProjectRegionResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), resourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string resourceId) =>
            FormatProjectRegionResource(projectId, regionId, resourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InterconnectAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>.
        /// </returns>
        public static string FormatProjectRegionResource(string projectId, string regionId, string resourceId) =>
            s_projectRegionResource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InterconnectAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c></description>
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
        /// <description><c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c></description>
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
        /// <description><c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c></description>
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
        /// <description><c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c></description>
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
            if (s_projectRegionResource.TryParseName(interconnectAttachmentName, out resourceName))
            {
                result = FromProjectRegionResource(resourceName[0], resourceName[1], resourceName[2]);
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

        private InterconnectAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string resourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            ResourceId = resourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InterconnectAttachmentName"/> class from the component parts of
        /// pattern <c>projects/{project}/regions/{region}/interconnectAttachments/{resource_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceId">The <c>Resource</c> ID. Must not be <c>null</c> or empty.</param>
        public InterconnectAttachmentName(string projectId, string regionId, string resourceId) : this(ResourceNameType.ProjectRegionResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), resourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Resource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ResourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionResource: return s_projectRegionResource.Expand(ProjectId, RegionId, ResourceId);
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

    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        /// <summary>The possible contents of <see cref="InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
            /// </summary>
            ProjectZoneInstance = 1,
        }

        private static gax::PathTemplate s_projectZoneInstance = new gax::PathTemplate("projects/{project}/zones/{zone}/instances/{instance}");

        /// <summary>Creates a <see cref="InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceName"/> constructed from the provided ids.</returns>
        public static InstanceName FromProjectZoneInstance(string projectId, string zoneId, string instanceId) =>
            new InstanceName(ResourceNameType.ProjectZoneInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string instanceId) =>
            FormatProjectZoneInstance(projectId, zoneId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectZoneInstance(string projectId, string zoneId, string instanceId) =>
            s_projectZoneInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="InstanceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName) => Parse(instanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName, bool allowUnparsed) =>
            TryParse(instanceName, allowUnparsed, out InstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result) => TryParse(instanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, bool allowUnparsed, out InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectZoneInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string zoneId, string instanceId) : this(ResourceNameType.ProjectZoneInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectZoneInstance: return s_projectZoneInstance.Expand(ProjectId, ZoneId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc/>
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

    public partial class Hub
    {
        /// <summary>
        /// <see cref="gcnv::HubName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::HubName HubName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::HubName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SpokeName"/>-typed view over the <see cref="Spokes"/> resource name property.</summary>
        public gax::ResourceNameList<SpokeName> SpokesAsSpokeNames
        {
            get => new gax::ResourceNameList<SpokeName>(Spokes, s => string.IsNullOrEmpty(s) ? null : SpokeName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class Spoke
    {
        /// <summary>
        /// <see cref="gcnv::SpokeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SpokeName SpokeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SpokeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="HubName"/>-typed view over the <see cref="Hub"/> resource name property.</summary>
        public HubName HubAsHubName
        {
            get => string.IsNullOrEmpty(Hub) ? null : HubName.Parse(Hub, allowUnparsed: true);
            set => Hub = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VpnTunnelName"/>-typed view over the <see cref="LinkedVpnTunnels"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<VpnTunnelName> LinkedVpnTunnelsAsVpnTunnelNames
        {
            get => new gax::ResourceNameList<VpnTunnelName>(LinkedVpnTunnels, s => string.IsNullOrEmpty(s) ? null : VpnTunnelName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="InterconnectAttachmentName"/>-typed view over the <see cref="LinkedInterconnectAttachments"/>
        /// resource name property.
        /// </summary>
        public gax::ResourceNameList<InterconnectAttachmentName> LinkedInterconnectAttachmentsAsInterconnectAttachmentNames
        {
            get => new gax::ResourceNameList<InterconnectAttachmentName>(LinkedInterconnectAttachments, s => string.IsNullOrEmpty(s) ? null : InterconnectAttachmentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListHubsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetHubRequest
    {
        /// <summary>
        /// <see cref="gcnv::HubName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::HubName HubName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::HubName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHubRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteHubRequest
    {
        /// <summary>
        /// <see cref="gcnv::HubName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::HubName HubName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::HubName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSpokesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSpokeRequest
    {
        /// <summary>
        /// <see cref="gcnv::SpokeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SpokeName SpokeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SpokeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSpokeRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSpokeRequest
    {
        /// <summary>
        /// <see cref="gcnv::SpokeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SpokeName SpokeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SpokeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RouterApplianceInstance
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="VirtualMachine"/> resource name property.
        /// </summary>
        public InstanceName VirtualMachineAsInstanceName
        {
            get => string.IsNullOrEmpty(VirtualMachine) ? null : InstanceName.Parse(VirtualMachine, allowUnparsed: true);
            set => VirtualMachine = value?.ToString() ?? "";
        }
    }
}
