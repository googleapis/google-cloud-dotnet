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
using gcdv = Google.Cloud.Datastream.V1;
using sys = System;

namespace Google.Cloud.Datastream.V1
{
    /// <summary>Resource name for the <c>PrivateConnection</c> resource.</summary>
    public sealed partial class PrivateConnectionName : gax::IResourceName, sys::IEquatable<PrivateConnectionName>
    {
        /// <summary>The possible contents of <see cref="PrivateConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
            /// </summary>
            ProjectLocationPrivateConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateConnection = new gax::PathTemplate("projects/{project}/locations/{location}/privateConnections/{private_connection}");

        /// <summary>Creates a <see cref="PrivateConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PrivateConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PrivateConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PrivateConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PrivateConnectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PrivateConnectionName"/> constructed from the provided ids.</returns>
        public static PrivateConnectionName FromProjectLocationPrivateConnection(string projectId, string locationId, string privateConnectionId) =>
            new PrivateConnectionName(ResourceNameType.ProjectLocationPrivateConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateConnectionId) =>
            FormatProjectLocationPrivateConnection(projectId, locationId, privateConnectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateConnection(string projectId, string locationId, string privateConnectionId) =>
            s_projectLocationPrivateConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PrivateConnectionName"/> if successful.</returns>
        public static PrivateConnectionName Parse(string privateConnectionName) => Parse(privateConnectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PrivateConnectionName"/> if successful.</returns>
        public static PrivateConnectionName Parse(string privateConnectionName, bool allowUnparsed) =>
            TryParse(privateConnectionName, allowUnparsed, out PrivateConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateConnectionName, out PrivateConnectionName result) =>
            TryParse(privateConnectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateConnectionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateConnectionName, bool allowUnparsed, out PrivateConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(privateConnectionName, nameof(privateConnectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateConnection.TryParseName(privateConnectionName, out resourceName))
            {
                result = FromProjectLocationPrivateConnection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(privateConnectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PrivateConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateConnectionId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateConnectionId = privateConnectionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PrivateConnectionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        public PrivateConnectionName(string projectId, string locationId, string privateConnectionId) : this(ResourceNameType.ProjectLocationPrivateConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)))
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
        /// The <c>PrivateConnection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateConnectionId { get; }

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
                case ResourceNameType.ProjectLocationPrivateConnection: return s_projectLocationPrivateConnection.Expand(ProjectId, LocationId, PrivateConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PrivateConnectionName);

        /// <inheritdoc/>
        public bool Equals(PrivateConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PrivateConnectionName a, PrivateConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PrivateConnectionName a, PrivateConnectionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Route</c> resource.</summary>
    public sealed partial class RouteName : gax::IResourceName, sys::IEquatable<RouteName>
    {
        /// <summary>The possible contents of <see cref="RouteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>.
            /// </summary>
            ProjectLocationPrivateConnectionRoute = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateConnectionRoute = new gax::PathTemplate("projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}");

        /// <summary>Creates a <see cref="RouteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RouteName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RouteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RouteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RouteName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeId">The <c>Route</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RouteName"/> constructed from the provided ids.</returns>
        public static RouteName FromProjectLocationPrivateConnectionRoute(string projectId, string locationId, string privateConnectionId, string routeId) =>
            new RouteName(ResourceNameType.ProjectLocationPrivateConnectionRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)), routeId: gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeId">The <c>Route</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateConnectionId, string routeId) =>
            FormatProjectLocationPrivateConnectionRoute(projectId, locationId, privateConnectionId, routeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeId">The <c>Route</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RouteName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateConnectionRoute(string projectId, string locationId, string privateConnectionId, string routeId) =>
            s_projectLocationPrivateConnectionRoute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)));

        /// <summary>Parses the given resource name string into a new <see cref="RouteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="routeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RouteName"/> if successful.</returns>
        public static RouteName Parse(string routeName) => Parse(routeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RouteName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="routeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RouteName"/> if successful.</returns>
        public static RouteName Parse(string routeName, bool allowUnparsed) =>
            TryParse(routeName, allowUnparsed, out RouteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RouteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="routeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string routeName, out RouteName result) => TryParse(routeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RouteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="routeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string routeName, bool allowUnparsed, out RouteName result)
        {
            gax::GaxPreconditions.CheckNotNull(routeName, nameof(routeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateConnectionRoute.TryParseName(routeName, out resourceName))
            {
                result = FromProjectLocationPrivateConnectionRoute(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(routeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RouteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateConnectionId = null, string projectId = null, string routeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateConnectionId = privateConnectionId;
            ProjectId = projectId;
            RouteId = routeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RouteName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateConnections/{private_connection}/routes/{route}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateConnectionId">The <c>PrivateConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="routeId">The <c>Route</c> ID. Must not be <c>null</c> or empty.</param>
        public RouteName(string projectId, string locationId, string privateConnectionId, string routeId) : this(ResourceNameType.ProjectLocationPrivateConnectionRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateConnectionId, nameof(privateConnectionId)), routeId: gax::GaxPreconditions.CheckNotNullOrEmpty(routeId, nameof(routeId)))
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
        /// The <c>PrivateConnection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateConnectionId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Route</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RouteId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPrivateConnectionRoute: return s_projectLocationPrivateConnectionRoute.Expand(ProjectId, LocationId, PrivateConnectionId, RouteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RouteName);

        /// <inheritdoc/>
        public bool Equals(RouteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RouteName a, RouteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RouteName a, RouteName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ConnectionProfile</c> resource.</summary>
    public sealed partial class ConnectionProfileName : gax::IResourceName, sys::IEquatable<ConnectionProfileName>
    {
        /// <summary>The possible contents of <see cref="ConnectionProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
            /// </summary>
            ProjectLocationConnectionProfile = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionProfile = new gax::PathTemplate("projects/{project}/locations/{location}/connectionProfiles/{connection_profile}");

        /// <summary>Creates a <see cref="ConnectionProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectionProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectionProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectionProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectionProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectionProfileName"/> constructed from the provided ids.</returns>
        public static ConnectionProfileName FromProjectLocationConnectionProfile(string projectId, string locationId, string connectionProfileId) =>
            new ConnectionProfileName(ResourceNameType.ProjectLocationConnectionProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionProfileId) =>
            FormatProjectLocationConnectionProfile(projectId, locationId, connectionProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationConnectionProfile(string projectId, string locationId, string connectionProfileId) =>
            s_projectLocationConnectionProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectionProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectionProfileName"/> if successful.</returns>
        public static ConnectionProfileName Parse(string connectionProfileName) => Parse(connectionProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectionProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectionProfileName"/> if successful.</returns>
        public static ConnectionProfileName Parse(string connectionProfileName, bool allowUnparsed) =>
            TryParse(connectionProfileName, allowUnparsed, out ConnectionProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionProfileName, out ConnectionProfileName result) =>
            TryParse(connectionProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionProfileName, bool allowUnparsed, out ConnectionProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectionProfileName, nameof(connectionProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionProfile.TryParseName(connectionProfileName, out resourceName))
            {
                result = FromProjectLocationConnectionProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectionProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectionProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionProfileId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionProfileId = connectionProfileId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectionProfileName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectionProfileName(string projectId, string locationId, string connectionProfileId) : this(ResourceNameType.ProjectLocationConnectionProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)))
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
        /// The <c>ConnectionProfile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConnectionProfileId { get; }

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
                case ResourceNameType.ProjectLocationConnectionProfile: return s_projectLocationConnectionProfile.Expand(ProjectId, LocationId, ConnectionProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectionProfileName);

        /// <inheritdoc/>
        public bool Equals(ConnectionProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConnectionProfileName a, ConnectionProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConnectionProfileName a, ConnectionProfileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Stream</c> resource.</summary>
    public sealed partial class StreamName : gax::IResourceName, sys::IEquatable<StreamName>
    {
        /// <summary>The possible contents of <see cref="StreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/streams/{stream}</c>.
            /// </summary>
            ProjectLocationStream = 1,
        }

        private static gax::PathTemplate s_projectLocationStream = new gax::PathTemplate("projects/{project}/locations/{location}/streams/{stream}");

        /// <summary>Creates a <see cref="StreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StreamName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StreamName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StreamName"/> constructed from the provided ids.</returns>
        public static StreamName FromProjectLocationStream(string projectId, string locationId, string streamId) =>
            new StreamName(ResourceNameType.ProjectLocationStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string streamId) =>
            FormatProjectLocationStream(projectId, locationId, streamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>.
        /// </returns>
        public static string FormatProjectLocationStream(string projectId, string locationId, string streamId) =>
            s_projectLocationStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>Parses the given resource name string into a new <see cref="StreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName) => Parse(streamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StreamName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName, bool allowUnparsed) =>
            TryParse(streamName, allowUnparsed, out StreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, out StreamName result) => TryParse(streamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/streams/{stream}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, bool allowUnparsed, out StreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(streamName, nameof(streamName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationStream.TryParseName(streamName, out resourceName))
            {
                result = FromProjectLocationStream(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(streamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string streamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            StreamId = streamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StreamName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        public StreamName(string projectId, string locationId, string streamId) : this(ResourceNameType.ProjectLocationStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)))
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
        /// The <c>Stream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StreamId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStream: return s_projectLocationStream.Expand(ProjectId, LocationId, StreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StreamName);

        /// <inheritdoc/>
        public bool Equals(StreamName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StreamName a, StreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StreamName a, StreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>StreamObject</c> resource.</summary>
    public sealed partial class StreamObjectName : gax::IResourceName, sys::IEquatable<StreamObjectName>
    {
        /// <summary>The possible contents of <see cref="StreamObjectName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>.
            /// </summary>
            ProjectLocationStreamObject = 1,
        }

        private static gax::PathTemplate s_projectLocationStreamObject = new gax::PathTemplate("projects/{project}/locations/{location}/streams/{stream}/objects/{object}");

        /// <summary>Creates a <see cref="StreamObjectName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StreamObjectName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StreamObjectName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StreamObjectName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StreamObjectName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="objectId">The <c>Object</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StreamObjectName"/> constructed from the provided ids.</returns>
        public static StreamObjectName FromProjectLocationStreamObject(string projectId, string locationId, string streamId, string objectId) =>
            new StreamObjectName(ResourceNameType.ProjectLocationStreamObject, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)), objectId: gax::GaxPreconditions.CheckNotNullOrEmpty(objectId, nameof(objectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamObjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="objectId">The <c>Object</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamObjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string streamId, string objectId) =>
            FormatProjectLocationStreamObject(projectId, locationId, streamId, objectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamObjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="objectId">The <c>Object</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamObjectName"/> with pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>.
        /// </returns>
        public static string FormatProjectLocationStreamObject(string projectId, string locationId, string streamId, string objectId) =>
            s_projectLocationStreamObject.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)), gax::GaxPreconditions.CheckNotNullOrEmpty(objectId, nameof(objectId)));

        /// <summary>Parses the given resource name string into a new <see cref="StreamObjectName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="streamObjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StreamObjectName"/> if successful.</returns>
        public static StreamObjectName Parse(string streamObjectName) => Parse(streamObjectName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StreamObjectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamObjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StreamObjectName"/> if successful.</returns>
        public static StreamObjectName Parse(string streamObjectName, bool allowUnparsed) =>
            TryParse(streamObjectName, allowUnparsed, out StreamObjectName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamObjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="streamObjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamObjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamObjectName, out StreamObjectName result) =>
            TryParse(streamObjectName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamObjectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamObjectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamObjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamObjectName, bool allowUnparsed, out StreamObjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(streamObjectName, nameof(streamObjectName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationStreamObject.TryParseName(streamObjectName, out resourceName))
            {
                result = FromProjectLocationStreamObject(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(streamObjectName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StreamObjectName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string objectId = null, string projectId = null, string streamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ObjectId = objectId;
            ProjectId = projectId;
            StreamId = streamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StreamObjectName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/streams/{stream}/objects/{object}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="objectId">The <c>Object</c> ID. Must not be <c>null</c> or empty.</param>
        public StreamObjectName(string projectId, string locationId, string streamId, string objectId) : this(ResourceNameType.ProjectLocationStreamObject, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)), objectId: gax::GaxPreconditions.CheckNotNullOrEmpty(objectId, nameof(objectId)))
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
        /// The <c>Object</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ObjectId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Stream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StreamId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStreamObject: return s_projectLocationStreamObject.Expand(ProjectId, LocationId, StreamId, ObjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StreamObjectName);

        /// <inheritdoc/>
        public bool Equals(StreamObjectName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StreamObjectName a, StreamObjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StreamObjectName a, StreamObjectName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Networks</c> resource.</summary>
    public sealed partial class NetworksName : gax::IResourceName, sys::IEquatable<NetworksName>
    {
        /// <summary>The possible contents of <see cref="NetworksName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworksName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworksName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static NetworksName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworksName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworksName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworksName"/> constructed from the provided ids.</returns>
        public static NetworksName FromProjectNetwork(string projectId, string networkId) =>
            new NetworksName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworksName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworksName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworksName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworksName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworksName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworksName"/> if successful.</returns>
        public static NetworksName Parse(string networksName) => Parse(networksName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworksName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworksName"/> if successful.</returns>
        public static NetworksName Parse(string networksName, bool allowUnparsed) =>
            TryParse(networksName, allowUnparsed, out NetworksName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworksName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworksName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networksName, out NetworksName result) => TryParse(networksName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworksName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networksName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworksName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networksName, bool allowUnparsed, out NetworksName result)
        {
            gax::GaxPreconditions.CheckNotNull(networksName, nameof(networksName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networksName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networksName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworksName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworksName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworksName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

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
                case ResourceNameType.ProjectNetwork: return s_projectNetwork.Expand(ProjectId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworksName);

        /// <inheritdoc/>
        public bool Equals(NetworksName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworksName a, NetworksName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworksName a, NetworksName b) => !(a == b);
    }

    public partial class VpcPeeringConfig
    {
        /// <summary><see cref="NetworksName"/>-typed view over the <see cref="Vpc"/> resource name property.</summary>
        public NetworksName VpcAsNetworksName
        {
            get => string.IsNullOrEmpty(Vpc) ? null : NetworksName.Parse(Vpc, allowUnparsed: true);
            set => Vpc = value?.ToString() ?? "";
        }
    }

    public partial class PrivateConnection
    {
        /// <summary>
        /// <see cref="gcdv::PrivateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PrivateConnectionName PrivateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PrivateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PrivateConnectivity
    {
        /// <summary>
        /// <see cref="PrivateConnectionName"/>-typed view over the <see cref="PrivateConnection"/> resource name
        /// property.
        /// </summary>
        public PrivateConnectionName PrivateConnectionAsPrivateConnectionName
        {
            get => string.IsNullOrEmpty(PrivateConnection) ? null : PrivateConnectionName.Parse(PrivateConnection, allowUnparsed: true);
            set => PrivateConnection = value?.ToString() ?? "";
        }
    }

    public partial class Route
    {
        /// <summary>
        /// <see cref="gcdv::RouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RouteName RouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ConnectionProfile
    {
        /// <summary>
        /// <see cref="gcdv::ConnectionProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConnectionProfileName ConnectionProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConnectionProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SourceConfig
    {
        /// <summary>
        /// <see cref="ConnectionProfileName"/>-typed view over the <see cref="SourceConnectionProfile"/> resource name
        /// property.
        /// </summary>
        public ConnectionProfileName SourceConnectionProfileAsConnectionProfileName
        {
            get => string.IsNullOrEmpty(SourceConnectionProfile) ? null : ConnectionProfileName.Parse(SourceConnectionProfile, allowUnparsed: true);
            set => SourceConnectionProfile = value?.ToString() ?? "";
        }
    }

    public partial class DestinationConfig
    {
        /// <summary>
        /// <see cref="ConnectionProfileName"/>-typed view over the <see cref="DestinationConnectionProfile"/> resource
        /// name property.
        /// </summary>
        public ConnectionProfileName DestinationConnectionProfileAsConnectionProfileName
        {
            get => string.IsNullOrEmpty(DestinationConnectionProfile) ? null : ConnectionProfileName.Parse(DestinationConnectionProfile, allowUnparsed: true);
            set => DestinationConnectionProfile = value?.ToString() ?? "";
        }
    }

    public partial class Stream
    {
        /// <summary>
        /// <see cref="gcdv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StreamObject
    {
        /// <summary>
        /// <see cref="gcdv::StreamObjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StreamObjectName StreamObjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StreamObjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
