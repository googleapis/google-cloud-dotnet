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
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>GatewayRouteView</c> resource.</summary>
    public sealed partial class GatewayRouteViewName : gax::IResourceName, sys::IEquatable<GatewayRouteViewName>
    {
        /// <summary>The possible contents of <see cref="GatewayRouteViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>.
            /// </summary>
            ProjectLocationGatewayRouteView = 1,
        }

        private static gax::PathTemplate s_projectLocationGatewayRouteView = new gax::PathTemplate("projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}");

        /// <summary>Creates a <see cref="GatewayRouteViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GatewayRouteViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GatewayRouteViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GatewayRouteViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GatewayRouteViewName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GatewayRouteViewName"/> constructed from the provided ids.</returns>
        public static GatewayRouteViewName FromProjectLocationGatewayRouteView(string projectId, string locationId, string gatewayId, string routeViewId) =>
            new GatewayRouteViewName(ResourceNameType.ProjectLocationGatewayRouteView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)), routeViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(routeViewId, nameof(routeViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string gatewayId, string routeViewId) =>
            FormatProjectLocationGatewayRouteView(projectId, locationId, gatewayId, routeViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>.
        /// </returns>
        public static string FormatProjectLocationGatewayRouteView(string projectId, string locationId, string gatewayId, string routeViewId) =>
            s_projectLocationGatewayRouteView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)), gax::GaxPreconditions.CheckNotNullOrEmpty(routeViewId, nameof(routeViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewayRouteViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GatewayRouteViewName"/> if successful.</returns>
        public static GatewayRouteViewName Parse(string gatewayRouteViewName) => Parse(gatewayRouteViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewayRouteViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GatewayRouteViewName"/> if successful.</returns>
        public static GatewayRouteViewName Parse(string gatewayRouteViewName, bool allowUnparsed) =>
            TryParse(gatewayRouteViewName, allowUnparsed, out GatewayRouteViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayRouteViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayRouteViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayRouteViewName, out GatewayRouteViewName result) =>
            TryParse(gatewayRouteViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayRouteViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayRouteViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayRouteViewName, bool allowUnparsed, out GatewayRouteViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(gatewayRouteViewName, nameof(gatewayRouteViewName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGatewayRouteView.TryParseName(gatewayRouteViewName, out resourceName))
            {
                result = FromProjectLocationGatewayRouteView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gatewayRouteViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GatewayRouteViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gatewayId = null, string locationId = null, string projectId = null, string routeViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GatewayId = gatewayId;
            LocationId = locationId;
            ProjectId = projectId;
            RouteViewId = routeViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GatewayRouteViewName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}/routeViews/{route_view}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        public GatewayRouteViewName(string projectId, string locationId, string gatewayId, string routeViewId) : this(ResourceNameType.ProjectLocationGatewayRouteView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)), routeViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(routeViewId, nameof(routeViewId)))
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
        /// The <c>Gateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GatewayId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>RouteView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RouteViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationGatewayRouteView: return s_projectLocationGatewayRouteView.Expand(ProjectId, LocationId, GatewayId, RouteViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GatewayRouteViewName);

        /// <inheritdoc/>
        public bool Equals(GatewayRouteViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GatewayRouteViewName a, GatewayRouteViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GatewayRouteViewName a, GatewayRouteViewName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MeshRouteView</c> resource.</summary>
    public sealed partial class MeshRouteViewName : gax::IResourceName, sys::IEquatable<MeshRouteViewName>
    {
        /// <summary>The possible contents of <see cref="MeshRouteViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>.
            /// </summary>
            ProjectLocationMeshRouteView = 1,
        }

        private static gax::PathTemplate s_projectLocationMeshRouteView = new gax::PathTemplate("projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}");

        /// <summary>Creates a <see cref="MeshRouteViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MeshRouteViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MeshRouteViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MeshRouteViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MeshRouteViewName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="meshId">The <c>Mesh</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MeshRouteViewName"/> constructed from the provided ids.</returns>
        public static MeshRouteViewName FromProjectLocationMeshRouteView(string projectId, string locationId, string meshId, string routeViewId) =>
            new MeshRouteViewName(ResourceNameType.ProjectLocationMeshRouteView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), meshId: gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)), routeViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(routeViewId, nameof(routeViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MeshRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="meshId">The <c>Mesh</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MeshRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string meshId, string routeViewId) =>
            FormatProjectLocationMeshRouteView(projectId, locationId, meshId, routeViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MeshRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="meshId">The <c>Mesh</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MeshRouteViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>.
        /// </returns>
        public static string FormatProjectLocationMeshRouteView(string projectId, string locationId, string meshId, string routeViewId) =>
            s_projectLocationMeshRouteView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)), gax::GaxPreconditions.CheckNotNullOrEmpty(routeViewId, nameof(routeViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MeshRouteViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="meshRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MeshRouteViewName"/> if successful.</returns>
        public static MeshRouteViewName Parse(string meshRouteViewName) => Parse(meshRouteViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MeshRouteViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="meshRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MeshRouteViewName"/> if successful.</returns>
        public static MeshRouteViewName Parse(string meshRouteViewName, bool allowUnparsed) =>
            TryParse(meshRouteViewName, allowUnparsed, out MeshRouteViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MeshRouteViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="meshRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MeshRouteViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string meshRouteViewName, out MeshRouteViewName result) =>
            TryParse(meshRouteViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MeshRouteViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="meshRouteViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MeshRouteViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string meshRouteViewName, bool allowUnparsed, out MeshRouteViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(meshRouteViewName, nameof(meshRouteViewName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMeshRouteView.TryParseName(meshRouteViewName, out resourceName))
            {
                result = FromProjectLocationMeshRouteView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(meshRouteViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MeshRouteViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string meshId = null, string projectId = null, string routeViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MeshId = meshId;
            ProjectId = projectId;
            RouteViewId = routeViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MeshRouteViewName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/meshes/{mesh}/routeViews/{route_view}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="meshId">The <c>Mesh</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeViewId">The <c>RouteView</c> ID. Must not be <c>null</c> or empty.</param>
        public MeshRouteViewName(string projectId, string locationId, string meshId, string routeViewId) : this(ResourceNameType.ProjectLocationMeshRouteView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), meshId: gax::GaxPreconditions.CheckNotNullOrEmpty(meshId, nameof(meshId)), routeViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(routeViewId, nameof(routeViewId)))
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
        /// The <c>Mesh</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MeshId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>RouteView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RouteViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationMeshRouteView: return s_projectLocationMeshRouteView.Expand(ProjectId, LocationId, MeshId, RouteViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MeshRouteViewName);

        /// <inheritdoc/>
        public bool Equals(MeshRouteViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MeshRouteViewName a, MeshRouteViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MeshRouteViewName a, MeshRouteViewName b) => !(a == b);
    }

    public partial class GatewayRouteView
    {
        /// <summary>
        /// <see cref="gcnv::GatewayRouteViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayRouteViewName GatewayRouteViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayRouteViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MeshRouteView
    {
        /// <summary>
        /// <see cref="gcnv::MeshRouteViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::MeshRouteViewName MeshRouteViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MeshRouteViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGatewayRouteViewRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewayRouteViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayRouteViewName GatewayRouteViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayRouteViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMeshRouteViewRequest
    {
        /// <summary>
        /// <see cref="gcnv::MeshRouteViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::MeshRouteViewName MeshRouteViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MeshRouteViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGatewayRouteViewsRequest
    {
        /// <summary>
        /// <see cref="GatewayName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GatewayName ParentAsGatewayName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GatewayName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListMeshRouteViewsRequest
    {
        /// <summary><see cref="MeshName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public MeshName ParentAsMeshName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MeshName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
