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
using gax = Google.Api.Gax;
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>OdbSubnet</c> resource.</summary>
    public sealed partial class OdbSubnetName : gax::IResourceName, sys::IEquatable<OdbSubnetName>
    {
        /// <summary>The possible contents of <see cref="OdbSubnetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>.
            /// </summary>
            ProjectLocationOdbNetworkOdbSubnet = 1,
        }

        private static gax::PathTemplate s_projectLocationOdbNetworkOdbSubnet = new gax::PathTemplate("projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}");

        /// <summary>Creates a <see cref="OdbSubnetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OdbSubnetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OdbSubnetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OdbSubnetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OdbSubnetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbNetworkId">The <c>OdbNetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbSubnetId">The <c>OdbSubnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OdbSubnetName"/> constructed from the provided ids.</returns>
        public static OdbSubnetName FromProjectLocationOdbNetworkOdbSubnet(string projectId, string locationId, string odbNetworkId, string odbSubnetId) =>
            new OdbSubnetName(ResourceNameType.ProjectLocationOdbNetworkOdbSubnet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), odbNetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)), odbSubnetId: gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OdbSubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbNetworkId">The <c>OdbNetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbSubnetId">The <c>OdbSubnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OdbSubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string odbNetworkId, string odbSubnetId) =>
            FormatProjectLocationOdbNetworkOdbSubnet(projectId, locationId, odbNetworkId, odbSubnetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OdbSubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbNetworkId">The <c>OdbNetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbSubnetId">The <c>OdbSubnet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OdbSubnetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>.
        /// </returns>
        public static string FormatProjectLocationOdbNetworkOdbSubnet(string projectId, string locationId, string odbNetworkId, string odbSubnetId) =>
            s_projectLocationOdbNetworkOdbSubnet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)), gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)));

        /// <summary>Parses the given resource name string into a new <see cref="OdbSubnetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="odbSubnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OdbSubnetName"/> if successful.</returns>
        public static OdbSubnetName Parse(string odbSubnetName) => Parse(odbSubnetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OdbSubnetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="odbSubnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OdbSubnetName"/> if successful.</returns>
        public static OdbSubnetName Parse(string odbSubnetName, bool allowUnparsed) =>
            TryParse(odbSubnetName, allowUnparsed, out OdbSubnetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OdbSubnetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="odbSubnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OdbSubnetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string odbSubnetName, out OdbSubnetName result) => TryParse(odbSubnetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OdbSubnetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="odbSubnetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OdbSubnetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string odbSubnetName, bool allowUnparsed, out OdbSubnetName result)
        {
            gax::GaxPreconditions.CheckNotNull(odbSubnetName, nameof(odbSubnetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOdbNetworkOdbSubnet.TryParseName(odbSubnetName, out resourceName))
            {
                result = FromProjectLocationOdbNetworkOdbSubnet(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(odbSubnetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OdbSubnetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string odbNetworkId = null, string odbSubnetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OdbNetworkId = odbNetworkId;
            OdbSubnetId = odbSubnetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OdbSubnetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbNetworkId">The <c>OdbNetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="odbSubnetId">The <c>OdbSubnet</c> ID. Must not be <c>null</c> or empty.</param>
        public OdbSubnetName(string projectId, string locationId, string odbNetworkId, string odbSubnetId) : this(ResourceNameType.ProjectLocationOdbNetworkOdbSubnet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), odbNetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)), odbSubnetId: gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)))
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
        /// The <c>OdbNetwork</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OdbNetworkId { get; }

        /// <summary>
        /// The <c>OdbSubnet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OdbSubnetId { get; }

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
                case ResourceNameType.ProjectLocationOdbNetworkOdbSubnet: return s_projectLocationOdbNetworkOdbSubnet.Expand(ProjectId, LocationId, OdbNetworkId, OdbSubnetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OdbSubnetName);

        /// <inheritdoc/>
        public bool Equals(OdbSubnetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OdbSubnetName a, OdbSubnetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OdbSubnetName a, OdbSubnetName b) => !(a == b);
    }

    public partial class OdbSubnet
    {
        /// <summary>
        /// <see cref="gcov::OdbSubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OdbSubnetName OdbSubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OdbSubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateOdbSubnetRequest
    {
        /// <summary>
        /// <see cref="OdbNetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OdbNetworkName ParentAsOdbNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OdbNetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteOdbSubnetRequest
    {
        /// <summary>
        /// <see cref="gcov::OdbSubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OdbSubnetName OdbSubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OdbSubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOdbSubnetsRequest
    {
        /// <summary>
        /// <see cref="OdbNetworkName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OdbNetworkName ParentAsOdbNetworkName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OdbNetworkName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetOdbSubnetRequest
    {
        /// <summary>
        /// <see cref="gcov::OdbSubnetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::OdbSubnetName OdbSubnetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::OdbSubnetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
