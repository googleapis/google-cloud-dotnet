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
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>Subnetwork</c> resource.</summary>
    public sealed partial class SubnetworkName : gax::IResourceName, sys::IEquatable<SubnetworkName>
    {
        /// <summary>The possible contents of <see cref="SubnetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
            /// </summary>
            ProjectRegionSubnetwork = 1,
        }

        private static gax::PathTemplate s_projectRegionSubnetwork = new gax::PathTemplate("projects/{project}/regions/{region}/subnetworks/{subnetwork}");

        /// <summary>Creates a <see cref="SubnetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubnetworkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubnetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubnetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubnetworkName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubnetworkName"/> constructed from the provided ids.</returns>
        public static SubnetworkName FromProjectRegionSubnetwork(string projectId, string regionId, string subnetworkId) =>
            new SubnetworkName(ResourceNameType.ProjectRegionSubnetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), subnetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string subnetworkId) =>
            FormatProjectRegionSubnetwork(projectId, regionId, subnetworkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </returns>
        public static string FormatProjectRegionSubnetwork(string projectId, string regionId, string subnetworkId) =>
            s_projectRegionSubnetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubnetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubnetworkName"/> if successful.</returns>
        public static SubnetworkName Parse(string subnetworkName) => Parse(subnetworkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubnetworkName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubnetworkName"/> if successful.</returns>
        public static SubnetworkName Parse(string subnetworkName, bool allowUnparsed) =>
            TryParse(subnetworkName, allowUnparsed, out SubnetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetworkName, out SubnetworkName result) =>
            TryParse(subnetworkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetworkName, bool allowUnparsed, out SubnetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(subnetworkName, nameof(subnetworkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionSubnetwork.TryParseName(subnetworkName, out resourceName))
            {
                result = FromProjectRegionSubnetwork(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subnetworkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubnetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string subnetworkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            SubnetworkId = subnetworkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubnetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        public SubnetworkName(string projectId, string regionId, string subnetworkId) : this(ResourceNameType.ProjectRegionSubnetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), subnetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)))
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
        /// The <c>Subnetwork</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubnetworkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionSubnetwork: return s_projectRegionSubnetwork.Expand(ProjectId, RegionId, SubnetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubnetworkName);

        /// <inheritdoc/>
        public bool Equals(SubnetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubnetworkName a, SubnetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubnetworkName a, SubnetworkName b) => !(a == b);
    }

    public partial class NetworkSpec
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SubnetworkName"/>-typed view over the <see cref="Subnetwork"/> resource name property.
        /// </summary>
        public SubnetworkName SubnetworkAsSubnetworkName
        {
            get => string.IsNullOrEmpty(Subnetwork) ? null : SubnetworkName.Parse(Subnetwork, allowUnparsed: true);
            set => Subnetwork = value?.ToString() ?? "";
        }
    }
}
