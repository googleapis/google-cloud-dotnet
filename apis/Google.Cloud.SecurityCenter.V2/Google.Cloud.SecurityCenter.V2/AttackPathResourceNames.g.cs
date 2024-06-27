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
using gcsv = Google.Cloud.SecurityCenter.V2;
using sys = System;

namespace Google.Cloud.SecurityCenter.V2
{
    /// <summary>Resource name for the <c>AttackPath</c> resource.</summary>
    public sealed partial class AttackPathName : gax::IResourceName, sys::IEquatable<AttackPathName>
    {
        /// <summary>The possible contents of <see cref="AttackPathName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
            /// .
            /// </summary>
            OrganizationSimulationValuedResourceAttackPath = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
            /// .
            /// </summary>
            OrganizationLocationSimulationValuedResourceAttackPath = 2,
        }

        private static gax::PathTemplate s_organizationSimulationValuedResourceAttackPath = new gax::PathTemplate("organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}");

        private static gax::PathTemplate s_organizationLocationSimulationValuedResourceAttackPath = new gax::PathTemplate("organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}");

        /// <summary>Creates a <see cref="AttackPathName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AttackPathName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AttackPathName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AttackPathName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AttackPathName"/> with the pattern
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="valuedResourceId">The <c>ValuedResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attackPathId">The <c>AttackPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AttackPathName"/> constructed from the provided ids.</returns>
        public static AttackPathName FromOrganizationSimulationValuedResourceAttackPath(string organizationId, string simulationId, string valuedResourceId, string attackPathId) =>
            new AttackPathName(ResourceNameType.OrganizationSimulationValuedResourceAttackPath, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), simulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)), valuedResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(valuedResourceId, nameof(valuedResourceId)), attackPathId: gax::GaxPreconditions.CheckNotNullOrEmpty(attackPathId, nameof(attackPathId)));

        /// <summary>
        /// Creates a <see cref="AttackPathName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="valuedResourceId">The <c>ValuedResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attackPathId">The <c>AttackPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AttackPathName"/> constructed from the provided ids.</returns>
        public static AttackPathName FromOrganizationLocationSimulationValuedResourceAttackPath(string organizationId, string locationId, string simulationId, string valuedResourceId, string attackPathId) =>
            new AttackPathName(ResourceNameType.OrganizationLocationSimulationValuedResourceAttackPath, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), simulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)), valuedResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(valuedResourceId, nameof(valuedResourceId)), attackPathId: gax::GaxPreconditions.CheckNotNullOrEmpty(attackPathId, nameof(attackPathId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttackPathName"/> with pattern
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="valuedResourceId">The <c>ValuedResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attackPathId">The <c>AttackPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttackPathName"/> with pattern
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string simulationId, string valuedResourceId, string attackPathId) =>
            FormatOrganizationSimulationValuedResourceAttackPath(organizationId, simulationId, valuedResourceId, attackPathId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttackPathName"/> with pattern
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="valuedResourceId">The <c>ValuedResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attackPathId">The <c>AttackPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttackPathName"/> with pattern
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationSimulationValuedResourceAttackPath(string organizationId, string simulationId, string valuedResourceId, string attackPathId) =>
            s_organizationSimulationValuedResourceAttackPath.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(valuedResourceId, nameof(valuedResourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(attackPathId, nameof(attackPathId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttackPathName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="valuedResourceId">The <c>ValuedResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attackPathId">The <c>AttackPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttackPathName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationSimulationValuedResourceAttackPath(string organizationId, string locationId, string simulationId, string valuedResourceId, string attackPathId) =>
            s_organizationLocationSimulationValuedResourceAttackPath.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(valuedResourceId, nameof(valuedResourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(attackPathId, nameof(attackPathId)));

        /// <summary>Parses the given resource name string into a new <see cref="AttackPathName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="attackPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AttackPathName"/> if successful.</returns>
        public static AttackPathName Parse(string attackPathName) => Parse(attackPathName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AttackPathName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attackPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AttackPathName"/> if successful.</returns>
        public static AttackPathName Parse(string attackPathName, bool allowUnparsed) =>
            TryParse(attackPathName, allowUnparsed, out AttackPathName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttackPathName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="attackPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttackPathName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attackPathName, out AttackPathName result) =>
            TryParse(attackPathName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttackPathName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attackPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttackPathName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attackPathName, bool allowUnparsed, out AttackPathName result)
        {
            gax::GaxPreconditions.CheckNotNull(attackPathName, nameof(attackPathName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSimulationValuedResourceAttackPath.TryParseName(attackPathName, out resourceName))
            {
                result = FromOrganizationSimulationValuedResourceAttackPath(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationSimulationValuedResourceAttackPath.TryParseName(attackPathName, out resourceName))
            {
                result = FromOrganizationLocationSimulationValuedResourceAttackPath(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(attackPathName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AttackPathName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string attackPathId = null, string locationId = null, string organizationId = null, string simulationId = null, string valuedResourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AttackPathId = attackPathId;
            LocationId = locationId;
            OrganizationId = organizationId;
            SimulationId = simulationId;
            ValuedResourceId = valuedResourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AttackPathName"/> class from the component parts of pattern
        /// <c>
        /// organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}/attackPaths/{attack_path}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="valuedResourceId">The <c>ValuedResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="attackPathId">The <c>AttackPath</c> ID. Must not be <c>null</c> or empty.</param>
        public AttackPathName(string organizationId, string simulationId, string valuedResourceId, string attackPathId) : this(ResourceNameType.OrganizationSimulationValuedResourceAttackPath, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), simulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)), valuedResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(valuedResourceId, nameof(valuedResourceId)), attackPathId: gax::GaxPreconditions.CheckNotNullOrEmpty(attackPathId, nameof(attackPathId)))
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
        /// The <c>AttackPath</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AttackPathId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Simulation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string SimulationId { get; }

        /// <summary>
        /// The <c>ValuedResource</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ValuedResourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationSimulationValuedResourceAttackPath: return s_organizationSimulationValuedResourceAttackPath.Expand(OrganizationId, SimulationId, ValuedResourceId, AttackPathId);
                case ResourceNameType.OrganizationLocationSimulationValuedResourceAttackPath: return s_organizationLocationSimulationValuedResourceAttackPath.Expand(OrganizationId, LocationId, SimulationId, ValuedResourceId, AttackPathId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AttackPathName);

        /// <inheritdoc/>
        public bool Equals(AttackPathName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AttackPathName a, AttackPathName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AttackPathName a, AttackPathName b) => !(a == b);
    }

    public partial class AttackPath
    {
        /// <summary>
        /// <see cref="gcsv::AttackPathName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::AttackPathName AttackPathName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::AttackPathName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
