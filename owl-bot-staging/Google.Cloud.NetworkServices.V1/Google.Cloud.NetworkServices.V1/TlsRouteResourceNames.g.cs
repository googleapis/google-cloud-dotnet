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
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>TlsRoute</c> resource.</summary>
    public sealed partial class TlsRouteName : gax::IResourceName, sys::IEquatable<TlsRouteName>
    {
        /// <summary>The possible contents of <see cref="TlsRouteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>.
            /// </summary>
            ProjectLocationTlsRoute = 1,
        }

        private static gax::PathTemplate s_projectLocationTlsRoute = new gax::PathTemplate("projects/{project}/locations/{location}/tlsRoutes/{tls_route}");

        /// <summary>Creates a <see cref="TlsRouteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TlsRouteName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static TlsRouteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TlsRouteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TlsRouteName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsRouteId">The <c>TlsRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TlsRouteName"/> constructed from the provided ids.</returns>
        public static TlsRouteName FromProjectLocationTlsRoute(string projectId, string locationId, string tlsRouteId) =>
            new TlsRouteName(ResourceNameType.ProjectLocationTlsRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tlsRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TlsRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsRouteId">The <c>TlsRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TlsRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tlsRouteId) =>
            FormatProjectLocationTlsRoute(projectId, locationId, tlsRouteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TlsRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsRouteId">The <c>TlsRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TlsRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>.
        /// </returns>
        public static string FormatProjectLocationTlsRoute(string projectId, string locationId, string tlsRouteId) =>
            s_projectLocationTlsRoute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)));

        /// <summary>Parses the given resource name string into a new <see cref="TlsRouteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tlsRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TlsRouteName"/> if successful.</returns>
        public static TlsRouteName Parse(string tlsRouteName) => Parse(tlsRouteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TlsRouteName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tlsRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TlsRouteName"/> if successful.</returns>
        public static TlsRouteName Parse(string tlsRouteName, bool allowUnparsed) =>
            TryParse(tlsRouteName, allowUnparsed, out TlsRouteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TlsRouteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tlsRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TlsRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tlsRouteName, out TlsRouteName result) => TryParse(tlsRouteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TlsRouteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tlsRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TlsRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tlsRouteName, bool allowUnparsed, out TlsRouteName result)
        {
            gax::GaxPreconditions.CheckNotNull(tlsRouteName, nameof(tlsRouteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTlsRoute.TryParseName(tlsRouteName, out resourceName))
            {
                result = FromProjectLocationTlsRoute(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tlsRouteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TlsRouteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tlsRouteId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TlsRouteId = tlsRouteId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TlsRouteName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tlsRoutes/{tls_route}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsRouteId">The <c>TlsRoute</c> ID. Must not be <c>null</c> or empty.</param>
        public TlsRouteName(string projectId, string locationId, string tlsRouteId) : this(ResourceNameType.ProjectLocationTlsRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tlsRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(tlsRouteId, nameof(tlsRouteId)))
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
        /// The <c>TlsRoute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TlsRouteId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTlsRoute: return s_projectLocationTlsRoute.Expand(ProjectId, LocationId, TlsRouteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TlsRouteName);

        /// <inheritdoc/>
        public bool Equals(TlsRouteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TlsRouteName a, TlsRouteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TlsRouteName a, TlsRouteName b) => !(a == b);
    }

    public partial class TlsRoute
    {
        /// <summary>
        /// <see cref="gcnv::TlsRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TlsRouteName TlsRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TlsRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="MeshName"/>-typed view over the <see cref="Meshes"/> resource name property.</summary>
        public gax::ResourceNameList<MeshName> MeshesAsMeshNames
        {
            get => new gax::ResourceNameList<MeshName>(Meshes, s => string.IsNullOrEmpty(s) ? null : MeshName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="GatewayName"/>-typed view over the <see cref="Gateways"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<GatewayName> GatewaysAsGatewayNames
        {
            get => new gax::ResourceNameList<GatewayName>(Gateways, s => string.IsNullOrEmpty(s) ? null : GatewayName.Parse(s, allowUnparsed: true));
        }

        public partial class Types
        {
            public partial class RouteDestination
            {
                /// <summary>
                /// <see cref="BackendServiceName"/>-typed view over the <see cref="ServiceName"/> resource name
                /// property.
                /// </summary>
                public BackendServiceName ServiceNameAsBackendServiceName
                {
                    get => string.IsNullOrEmpty(ServiceName) ? null : BackendServiceName.Parse(ServiceName, allowUnparsed: true);
                    set => ServiceName = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListTlsRoutesRequest
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

    public partial class GetTlsRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::TlsRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TlsRouteName TlsRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TlsRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTlsRouteRequest
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

    public partial class DeleteTlsRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::TlsRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TlsRouteName TlsRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TlsRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
