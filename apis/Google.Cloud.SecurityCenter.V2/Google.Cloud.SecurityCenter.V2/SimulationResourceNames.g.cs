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
using gcsv = Google.Cloud.SecurityCenter.V2;
using sys = System;

namespace Google.Cloud.SecurityCenter.V2
{
    /// <summary>Resource name for the <c>Simulation</c> resource.</summary>
    public sealed partial class SimulationName : gax::IResourceName, sys::IEquatable<SimulationName>
    {
        /// <summary>The possible contents of <see cref="SimulationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/simulations/{simulation}</c>.
            /// </summary>
            OrganizationSimulation = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>.
            /// </summary>
            OrganizationLocationSimluation = 2,
        }

        private static gax::PathTemplate s_organizationSimulation = new gax::PathTemplate("organizations/{organization}/simulations/{simulation}");

        private static gax::PathTemplate s_organizationLocationSimluation = new gax::PathTemplate("organizations/{organization}/locations/{location}/simulations/{simluation}");

        /// <summary>Creates a <see cref="SimulationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SimulationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SimulationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SimulationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SimulationName"/> with the pattern
        /// <c>organizations/{organization}/simulations/{simulation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SimulationName"/> constructed from the provided ids.</returns>
        public static SimulationName FromOrganizationSimulation(string organizationId, string simulationId) =>
            new SimulationName(ResourceNameType.OrganizationSimulation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), simulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)));

        /// <summary>
        /// Creates a <see cref="SimulationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simluationId">The <c>Simluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SimulationName"/> constructed from the provided ids.</returns>
        public static SimulationName FromOrganizationLocationSimluation(string organizationId, string locationId, string simluationId) =>
            new SimulationName(ResourceNameType.OrganizationLocationSimluation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), simluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(simluationId, nameof(simluationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SimulationName"/> with pattern
        /// <c>organizations/{organization}/simulations/{simulation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SimulationName"/> with pattern
        /// <c>organizations/{organization}/simulations/{simulation}</c>.
        /// </returns>
        public static string Format(string organizationId, string simulationId) =>
            FormatOrganizationSimulation(organizationId, simulationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SimulationName"/> with pattern
        /// <c>organizations/{organization}/simulations/{simulation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SimulationName"/> with pattern
        /// <c>organizations/{organization}/simulations/{simulation}</c>.
        /// </returns>
        public static string FormatOrganizationSimulation(string organizationId, string simulationId) =>
            s_organizationSimulation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SimulationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simluationId">The <c>Simluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SimulationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>.
        /// </returns>
        public static string FormatOrganizationLocationSimluation(string organizationId, string locationId, string simluationId) =>
            s_organizationLocationSimluation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(simluationId, nameof(simluationId)));

        /// <summary>Parses the given resource name string into a new <see cref="SimulationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/simulations/{simulation}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="simulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SimulationName"/> if successful.</returns>
        public static SimulationName Parse(string simulationName) => Parse(simulationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SimulationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/simulations/{simulation}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="simulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SimulationName"/> if successful.</returns>
        public static SimulationName Parse(string simulationName, bool allowUnparsed) =>
            TryParse(simulationName, allowUnparsed, out SimulationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/simulations/{simulation}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="simulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SimulationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string simulationName, out SimulationName result) =>
            TryParse(simulationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SimulationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/simulations/{simulation}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/simulations/{simluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="simulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SimulationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string simulationName, bool allowUnparsed, out SimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(simulationName, nameof(simulationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSimulation.TryParseName(simulationName, out resourceName))
            {
                result = FromOrganizationSimulation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocationSimluation.TryParseName(simulationName, out resourceName))
            {
                result = FromOrganizationLocationSimluation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(simulationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SimulationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string simluationId = null, string simulationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            SimluationId = simluationId;
            SimulationId = simulationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SimulationName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/simulations/{simulation}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="simulationId">The <c>Simulation</c> ID. Must not be <c>null</c> or empty.</param>
        public SimulationName(string organizationId, string simulationId) : this(ResourceNameType.OrganizationSimulation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), simulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(simulationId, nameof(simulationId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Simluation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string SimluationId { get; }

        /// <summary>
        /// The <c>Simulation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string SimulationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationSimulation: return s_organizationSimulation.Expand(OrganizationId, SimulationId);
                case ResourceNameType.OrganizationLocationSimluation: return s_organizationLocationSimluation.Expand(OrganizationId, LocationId, SimluationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SimulationName);

        /// <inheritdoc/>
        public bool Equals(SimulationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SimulationName a, SimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SimulationName a, SimulationName b) => !(a == b);
    }

    public partial class Simulation
    {
        /// <summary>
        /// <see cref="gcsv::SimulationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SimulationName SimulationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SimulationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
