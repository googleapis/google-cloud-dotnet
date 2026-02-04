// Copyright 2026 Google LLC
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
using gcgv = Google.Cloud.GkeHub.V1;
using sys = System;

namespace Google.Cloud.GkeHub.V1
{
    /// <summary>Resource name for the <c>Fleet</c> resource.</summary>
    public sealed partial class FleetName : gax::IResourceName, sys::IEquatable<FleetName>
    {
        /// <summary>The possible contents of <see cref="FleetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/fleets/{fleet}</c>.
            /// </summary>
            ProjectLocationFleet = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/fleets/{fleet}</c>.
            /// </summary>
            OrganizationLocationFleet = 2,
        }

        private static gax::PathTemplate s_projectLocationFleet = new gax::PathTemplate("projects/{project}/locations/{location}/fleets/{fleet}");

        private static gax::PathTemplate s_organizationLocationFleet = new gax::PathTemplate("organizations/{organization}/locations/{location}/fleets/{fleet}");

        /// <summary>Creates a <see cref="FleetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FleetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FleetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FleetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FleetName"/> with the pattern <c>projects/{project}/locations/{location}/fleets/{fleet}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetId">The <c>Fleet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FleetName"/> constructed from the provided ids.</returns>
        public static FleetName FromProjectLocationFleet(string projectId, string locationId, string fleetId) =>
            new FleetName(ResourceNameType.ProjectLocationFleet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetId, nameof(fleetId)));

        /// <summary>
        /// Creates a <see cref="FleetName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/fleets/{fleet}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetId">The <c>Fleet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FleetName"/> constructed from the provided ids.</returns>
        public static FleetName FromOrganizationLocationFleet(string organizationId, string locationId, string fleetId) =>
            new FleetName(ResourceNameType.OrganizationLocationFleet, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetId, nameof(fleetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FleetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleets/{fleet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetId">The <c>Fleet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FleetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleets/{fleet}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string fleetId) =>
            FormatProjectLocationFleet(projectId, locationId, fleetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FleetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleets/{fleet}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetId">The <c>Fleet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FleetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/fleets/{fleet}</c>.
        /// </returns>
        public static string FormatProjectLocationFleet(string projectId, string locationId, string fleetId) =>
            s_projectLocationFleet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fleetId, nameof(fleetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FleetName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/fleets/{fleet}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetId">The <c>Fleet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FleetName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/fleets/{fleet}</c>.
        /// </returns>
        public static string FormatOrganizationLocationFleet(string organizationId, string locationId, string fleetId) =>
            s_organizationLocationFleet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fleetId, nameof(fleetId)));

        /// <summary>Parses the given resource name string into a new <see cref="FleetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/fleets/{fleet}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/fleets/{fleet}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fleetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FleetName"/> if successful.</returns>
        public static FleetName Parse(string fleetName) => Parse(fleetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FleetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/fleets/{fleet}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/fleets/{fleet}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fleetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FleetName"/> if successful.</returns>
        public static FleetName Parse(string fleetName, bool allowUnparsed) =>
            TryParse(fleetName, allowUnparsed, out FleetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FleetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/fleets/{fleet}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/fleets/{fleet}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fleetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FleetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fleetName, out FleetName result) => TryParse(fleetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FleetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/fleets/{fleet}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/fleets/{fleet}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fleetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FleetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fleetName, bool allowUnparsed, out FleetName result)
        {
            gax::GaxPreconditions.CheckNotNull(fleetName, nameof(fleetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFleet.TryParseName(fleetName, out resourceName))
            {
                result = FromProjectLocationFleet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationFleet.TryParseName(fleetName, out resourceName))
            {
                result = FromOrganizationLocationFleet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fleetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FleetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string fleetId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FleetId = fleetId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FleetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/fleets/{fleet}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fleetId">The <c>Fleet</c> ID. Must not be <c>null</c> or empty.</param>
        public FleetName(string projectId, string locationId, string fleetId) : this(ResourceNameType.ProjectLocationFleet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), fleetId: gax::GaxPreconditions.CheckNotNullOrEmpty(fleetId, nameof(fleetId)))
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
        /// The <c>Fleet</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FleetId { get; }

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
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationFleet: return s_projectLocationFleet.Expand(ProjectId, LocationId, FleetId);
                case ResourceNameType.OrganizationLocationFleet: return s_organizationLocationFleet.Expand(OrganizationId, LocationId, FleetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FleetName);

        /// <inheritdoc/>
        public bool Equals(FleetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FleetName a, FleetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FleetName a, FleetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Namespace</c> resource.</summary>
    public sealed partial class NamespaceName : gax::IResourceName, sys::IEquatable<NamespaceName>
    {
        /// <summary>The possible contents of <see cref="NamespaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>.
            /// </summary>
            ProjectLocationScopeNamespace = 1,
        }

        private static gax::PathTemplate s_projectLocationScopeNamespace = new gax::PathTemplate("projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}");

        /// <summary>Creates a <see cref="NamespaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NamespaceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NamespaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NamespaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NamespaceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NamespaceName"/> constructed from the provided ids.</returns>
        public static NamespaceName FromProjectLocationScopeNamespace(string projectId, string locationId, string scopeId, string namespaceId) =>
            new NamespaceName(ResourceNameType.ProjectLocationScopeNamespace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string scopeId, string namespaceId) =>
            FormatProjectLocationScopeNamespace(projectId, locationId, scopeId, namespaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NamespaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>.
        /// </returns>
        public static string FormatProjectLocationScopeNamespace(string projectId, string locationId, string scopeId, string namespaceId) =>
            s_projectLocationScopeNamespace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="NamespaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NamespaceName"/> if successful.</returns>
        public static NamespaceName Parse(string namespaceName) => Parse(namespaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NamespaceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NamespaceName"/> if successful.</returns>
        public static NamespaceName Parse(string namespaceName, bool allowUnparsed) =>
            TryParse(namespaceName, allowUnparsed, out NamespaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NamespaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NamespaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string namespaceName, out NamespaceName result) => TryParse(namespaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NamespaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="namespaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NamespaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string namespaceName, bool allowUnparsed, out NamespaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(namespaceName, nameof(namespaceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationScopeNamespace.TryParseName(namespaceName, out resourceName))
            {
                result = FromProjectLocationScopeNamespace(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(namespaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NamespaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string namespaceId = null, string projectId = null, string scopeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NamespaceId = namespaceId;
            ProjectId = projectId;
            ScopeId = scopeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NamespaceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/namespaces/{namespace}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        public NamespaceName(string projectId, string locationId, string scopeId, string namespaceId) : this(ResourceNameType.ProjectLocationScopeNamespace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)))
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
        /// The <c>Namespace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NamespaceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Scope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScopeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationScopeNamespace: return s_projectLocationScopeNamespace.Expand(ProjectId, LocationId, ScopeId, NamespaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NamespaceName);

        /// <inheritdoc/>
        public bool Equals(NamespaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NamespaceName a, NamespaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NamespaceName a, NamespaceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RBACRoleBinding</c> resource.</summary>
    public sealed partial class RBACRoleBindingName : gax::IResourceName, sys::IEquatable<RBACRoleBindingName>
    {
        /// <summary>The possible contents of <see cref="RBACRoleBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>.
            /// </summary>
            ProjectLocationScopeRbacrolebinding = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>
            /// .
            /// </summary>
            ProjectLocationMembershipRbacrolebinding = 2,
        }

        private static gax::PathTemplate s_projectLocationScopeRbacrolebinding = new gax::PathTemplate("projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}");

        private static gax::PathTemplate s_projectLocationMembershipRbacrolebinding = new gax::PathTemplate("projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}");

        /// <summary>Creates a <see cref="RBACRoleBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RBACRoleBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RBACRoleBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RBACRoleBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RBACRoleBindingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rbacrolebindingId">The <c>Rbacrolebinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RBACRoleBindingName"/> constructed from the provided ids.</returns>
        public static RBACRoleBindingName FromProjectLocationScopeRbacrolebinding(string projectId, string locationId, string scopeId, string rbacrolebindingId) =>
            new RBACRoleBindingName(ResourceNameType.ProjectLocationScopeRbacrolebinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)), rbacrolebindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)));

        /// <summary>
        /// Creates a <see cref="RBACRoleBindingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rbacrolebindingId">The <c>Rbacrolebinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RBACRoleBindingName"/> constructed from the provided ids.</returns>
        public static RBACRoleBindingName FromProjectLocationMembershipRbacrolebinding(string projectId, string locationId, string membershipId, string rbacrolebindingId) =>
            new RBACRoleBindingName(ResourceNameType.ProjectLocationMembershipRbacrolebinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)), rbacrolebindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RBACRoleBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rbacrolebindingId">The <c>Rbacrolebinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RBACRoleBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string scopeId, string rbacrolebindingId) =>
            FormatProjectLocationScopeRbacrolebinding(projectId, locationId, scopeId, rbacrolebindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RBACRoleBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rbacrolebindingId">The <c>Rbacrolebinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RBACRoleBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </returns>
        public static string FormatProjectLocationScopeRbacrolebinding(string projectId, string locationId, string scopeId, string rbacrolebindingId) =>
            s_projectLocationScopeRbacrolebinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RBACRoleBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rbacrolebindingId">The <c>Rbacrolebinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RBACRoleBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>.
        /// </returns>
        public static string FormatProjectLocationMembershipRbacrolebinding(string projectId, string locationId, string membershipId, string rbacrolebindingId) =>
            s_projectLocationMembershipRbacrolebinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RBACRoleBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rBACRoleBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RBACRoleBindingName"/> if successful.</returns>
        public static RBACRoleBindingName Parse(string rBACRoleBindingName) => Parse(rBACRoleBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RBACRoleBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rBACRoleBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RBACRoleBindingName"/> if successful.</returns>
        public static RBACRoleBindingName Parse(string rBACRoleBindingName, bool allowUnparsed) =>
            TryParse(rBACRoleBindingName, allowUnparsed, out RBACRoleBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RBACRoleBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rBACRoleBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RBACRoleBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rBACRoleBindingName, out RBACRoleBindingName result) =>
            TryParse(rBACRoleBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RBACRoleBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/rbacrolebindings/{rbacrolebinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rBACRoleBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RBACRoleBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rBACRoleBindingName, bool allowUnparsed, out RBACRoleBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(rBACRoleBindingName, nameof(rBACRoleBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationScopeRbacrolebinding.TryParseName(rBACRoleBindingName, out resourceName))
            {
                result = FromProjectLocationScopeRbacrolebinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationMembershipRbacrolebinding.TryParseName(rBACRoleBindingName, out resourceName))
            {
                result = FromProjectLocationMembershipRbacrolebinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rBACRoleBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RBACRoleBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string membershipId = null, string projectId = null, string rbacrolebindingId = null, string scopeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MembershipId = membershipId;
            ProjectId = projectId;
            RbacrolebindingId = rbacrolebindingId;
            ScopeId = scopeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RBACRoleBindingName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}/rbacrolebindings/{rbacrolebinding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rbacrolebindingId">The <c>Rbacrolebinding</c> ID. Must not be <c>null</c> or empty.</param>
        public RBACRoleBindingName(string projectId, string locationId, string scopeId, string rbacrolebindingId) : this(ResourceNameType.ProjectLocationScopeRbacrolebinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)), rbacrolebindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(rbacrolebindingId, nameof(rbacrolebindingId)))
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
        /// The <c>Membership</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string MembershipId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Rbacrolebinding</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string RbacrolebindingId { get; }

        /// <summary>
        /// The <c>Scope</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ScopeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationScopeRbacrolebinding: return s_projectLocationScopeRbacrolebinding.Expand(ProjectId, LocationId, ScopeId, RbacrolebindingId);
                case ResourceNameType.ProjectLocationMembershipRbacrolebinding: return s_projectLocationMembershipRbacrolebinding.Expand(ProjectId, LocationId, MembershipId, RbacrolebindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RBACRoleBindingName);

        /// <inheritdoc/>
        public bool Equals(RBACRoleBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RBACRoleBindingName a, RBACRoleBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RBACRoleBindingName a, RBACRoleBindingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Scope</c> resource.</summary>
    public sealed partial class ScopeName : gax::IResourceName, sys::IEquatable<ScopeName>
    {
        /// <summary>The possible contents of <see cref="ScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
            /// </summary>
            ProjectLocationScope = 1,
        }

        private static gax::PathTemplate s_projectLocationScope = new gax::PathTemplate("projects/{project}/locations/{location}/scopes/{scope}");

        /// <summary>Creates a <see cref="ScopeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ScopeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ScopeName"/> with the pattern <c>projects/{project}/locations/{location}/scopes/{scope}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ScopeName"/> constructed from the provided ids.</returns>
        public static ScopeName FromProjectLocationScope(string projectId, string locationId, string scopeId) =>
            new ScopeName(ResourceNameType.ProjectLocationScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string scopeId) =>
            FormatProjectLocationScope(projectId, locationId, scopeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </returns>
        public static string FormatProjectLocationScope(string projectId, string locationId, string scopeId) =>
            s_projectLocationScope.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)));

        /// <summary>Parses the given resource name string into a new <see cref="ScopeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ScopeName"/> if successful.</returns>
        public static ScopeName Parse(string scopeName) => Parse(scopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScopeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ScopeName"/> if successful.</returns>
        public static ScopeName Parse(string scopeName, bool allowUnparsed) =>
            TryParse(scopeName, allowUnparsed, out ScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scopeName, out ScopeName result) => TryParse(scopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScopeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scopeName, bool allowUnparsed, out ScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(scopeName, nameof(scopeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationScope.TryParseName(scopeName, out resourceName))
            {
                result = FromProjectLocationScope(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(scopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string scopeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ScopeId = scopeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ScopeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        public ScopeName(string projectId, string locationId, string scopeId) : this(ResourceNameType.ProjectLocationScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)))
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
        /// The <c>Scope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScopeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationScope: return s_projectLocationScope.Expand(ProjectId, LocationId, ScopeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ScopeName);

        /// <inheritdoc/>
        public bool Equals(ScopeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ScopeName a, ScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ScopeName a, ScopeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MembershipBinding</c> resource.</summary>
    public sealed partial class MembershipBindingName : gax::IResourceName, sys::IEquatable<MembershipBindingName>
    {
        /// <summary>The possible contents of <see cref="MembershipBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>.
            /// </summary>
            ProjectLocationMembershipMembershipbinding = 1,
        }

        private static gax::PathTemplate s_projectLocationMembershipMembershipbinding = new gax::PathTemplate("projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}");

        /// <summary>Creates a <see cref="MembershipBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MembershipBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MembershipBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MembershipBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MembershipBindingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipbindingId">The <c>Membershipbinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MembershipBindingName"/> constructed from the provided ids.</returns>
        public static MembershipBindingName FromProjectLocationMembershipMembershipbinding(string projectId, string locationId, string membershipId, string membershipbindingId) =>
            new MembershipBindingName(ResourceNameType.ProjectLocationMembershipMembershipbinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)), membershipbindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipbindingId, nameof(membershipbindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipbindingId">The <c>Membershipbinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string membershipId, string membershipbindingId) =>
            FormatProjectLocationMembershipMembershipbinding(projectId, locationId, membershipId, membershipbindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipbindingId">The <c>Membershipbinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>.
        /// </returns>
        public static string FormatProjectLocationMembershipMembershipbinding(string projectId, string locationId, string membershipId, string membershipbindingId) =>
            s_projectLocationMembershipMembershipbinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipbindingId, nameof(membershipbindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MembershipBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MembershipBindingName"/> if successful.</returns>
        public static MembershipBindingName Parse(string membershipBindingName) => Parse(membershipBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MembershipBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MembershipBindingName"/> if successful.</returns>
        public static MembershipBindingName Parse(string membershipBindingName, bool allowUnparsed) =>
            TryParse(membershipBindingName, allowUnparsed, out MembershipBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipBindingName, out MembershipBindingName result) =>
            TryParse(membershipBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipBindingName, bool allowUnparsed, out MembershipBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(membershipBindingName, nameof(membershipBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMembershipMembershipbinding.TryParseName(membershipBindingName, out resourceName))
            {
                result = FromProjectLocationMembershipMembershipbinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(membershipBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MembershipBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string membershipId = null, string membershipbindingId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MembershipId = membershipId;
            MembershipbindingId = membershipbindingId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MembershipBindingName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}/bindings/{membershipbinding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipbindingId">The <c>Membershipbinding</c> ID. Must not be <c>null</c> or empty.</param>
        public MembershipBindingName(string projectId, string locationId, string membershipId, string membershipbindingId) : this(ResourceNameType.ProjectLocationMembershipMembershipbinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)), membershipbindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipbindingId, nameof(membershipbindingId)))
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
        /// The <c>Membership</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MembershipId { get; }

        /// <summary>
        /// The <c>Membershipbinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MembershipbindingId { get; }

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
                case ResourceNameType.ProjectLocationMembershipMembershipbinding: return s_projectLocationMembershipMembershipbinding.Expand(ProjectId, LocationId, MembershipId, MembershipbindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MembershipBindingName);

        /// <inheritdoc/>
        public bool Equals(MembershipBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MembershipBindingName a, MembershipBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MembershipBindingName a, MembershipBindingName b) => !(a == b);
    }

    public partial class Fleet
    {
        /// <summary>
        /// <see cref="gcgv::FleetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FleetName FleetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FleetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Namespace
    {
        /// <summary>
        /// <see cref="gcgv::NamespaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::NamespaceName NamespaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::NamespaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Scope"/> resource name property.</summary>
        public ScopeName ScopeAsScopeName
        {
            get => string.IsNullOrEmpty(Scope) ? null : ScopeName.Parse(Scope, allowUnparsed: true);
            set => Scope = value?.ToString() ?? "";
        }
    }

    public partial class RBACRoleBinding
    {
        /// <summary>
        /// <see cref="gcgv::RBACRoleBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RBACRoleBindingName RBACRoleBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RBACRoleBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Scope
    {
        /// <summary>
        /// <see cref="gcgv::ScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ScopeName ScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MembershipBinding
    {
        /// <summary>
        /// <see cref="gcgv::MembershipBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipBindingName MembershipBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Scope"/> resource name property.</summary>
        public ScopeName ScopeAsScopeName
        {
            get => string.IsNullOrEmpty(Scope) ? null : ScopeName.Parse(Scope, allowUnparsed: true);
            set => Scope = value?.ToString() ?? "";
        }
    }
}
