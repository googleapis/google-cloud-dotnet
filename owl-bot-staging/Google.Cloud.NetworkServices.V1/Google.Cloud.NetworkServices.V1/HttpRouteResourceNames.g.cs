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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>HttpRoute</c> resource.</summary>
    public sealed partial class HttpRouteName : gax::IResourceName, sys::IEquatable<HttpRouteName>
    {
        /// <summary>The possible contents of <see cref="HttpRouteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>.
            /// </summary>
            ProjectLocationHttpRoute = 1,
        }

        private static gax::PathTemplate s_projectLocationHttpRoute = new gax::PathTemplate("projects/{project}/locations/{location}/httpRoutes/{http_route}");

        /// <summary>Creates a <see cref="HttpRouteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HttpRouteName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HttpRouteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HttpRouteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HttpRouteName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="httpRouteId">The <c>HttpRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HttpRouteName"/> constructed from the provided ids.</returns>
        public static HttpRouteName FromProjectLocationHttpRoute(string projectId, string locationId, string httpRouteId) =>
            new HttpRouteName(ResourceNameType.ProjectLocationHttpRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), httpRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HttpRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="httpRouteId">The <c>HttpRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HttpRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string httpRouteId) =>
            FormatProjectLocationHttpRoute(projectId, locationId, httpRouteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HttpRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="httpRouteId">The <c>HttpRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HttpRouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>.
        /// </returns>
        public static string FormatProjectLocationHttpRoute(string projectId, string locationId, string httpRouteId) =>
            s_projectLocationHttpRoute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)));

        /// <summary>Parses the given resource name string into a new <see cref="HttpRouteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="httpRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HttpRouteName"/> if successful.</returns>
        public static HttpRouteName Parse(string httpRouteName) => Parse(httpRouteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HttpRouteName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="httpRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HttpRouteName"/> if successful.</returns>
        public static HttpRouteName Parse(string httpRouteName, bool allowUnparsed) =>
            TryParse(httpRouteName, allowUnparsed, out HttpRouteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HttpRouteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="httpRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HttpRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string httpRouteName, out HttpRouteName result) => TryParse(httpRouteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HttpRouteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="httpRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HttpRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string httpRouteName, bool allowUnparsed, out HttpRouteName result)
        {
            gax::GaxPreconditions.CheckNotNull(httpRouteName, nameof(httpRouteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationHttpRoute.TryParseName(httpRouteName, out resourceName))
            {
                result = FromProjectLocationHttpRoute(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(httpRouteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HttpRouteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string httpRouteId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HttpRouteId = httpRouteId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HttpRouteName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/httpRoutes/{http_route}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="httpRouteId">The <c>HttpRoute</c> ID. Must not be <c>null</c> or empty.</param>
        public HttpRouteName(string projectId, string locationId, string httpRouteId) : this(ResourceNameType.ProjectLocationHttpRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), httpRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(httpRouteId, nameof(httpRouteId)))
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
        /// The <c>HttpRoute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string HttpRouteId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationHttpRoute: return s_projectLocationHttpRoute.Expand(ProjectId, LocationId, HttpRouteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HttpRouteName);

        /// <inheritdoc/>
        public bool Equals(HttpRouteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HttpRouteName a, HttpRouteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HttpRouteName a, HttpRouteName b) => !(a == b);
    }

    public partial class HttpRoute
    {
        /// <summary>
        /// <see cref="gcnv::HttpRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::HttpRouteName HttpRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::HttpRouteName.Parse(Name, allowUnparsed: true);
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
            public partial class Destination
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

    public partial class ListHttpRoutesRequest
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

    public partial class GetHttpRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::HttpRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::HttpRouteName HttpRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::HttpRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHttpRouteRequest
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

    public partial class DeleteHttpRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::HttpRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::HttpRouteName HttpRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::HttpRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
