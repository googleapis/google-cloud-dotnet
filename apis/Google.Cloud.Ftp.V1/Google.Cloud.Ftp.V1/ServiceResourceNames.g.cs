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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcfv = Google.Cloud.Ftp.V1;
using sys = System;

namespace Google.Cloud.Ftp.V1
{
    /// <summary>Resource name for the <c>Server</c> resource.</summary>
    public sealed partial class ServerName : gax::IResourceName, sys::IEquatable<ServerName>
    {
        /// <summary>The possible contents of <see cref="ServerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/servers/{server}</c>.
            /// </summary>
            ProjectLocationServer = 1,
        }

        private static gax::PathTemplate s_projectLocationServer = new gax::PathTemplate("projects/{project}/locations/{location}/servers/{server}");

        /// <summary>Creates a <see cref="ServerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServerName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServerName"/> constructed from the provided ids.</returns>
        public static ServerName FromProjectLocationServer(string projectId, string locationId, string serverId) =>
            new ServerName(ResourceNameType.ProjectLocationServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serverId: gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serverId) =>
            FormatProjectLocationServer(projectId, locationId, serverId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}</c>.
        /// </returns>
        public static string FormatProjectLocationServer(string projectId, string locationId, string serverId) =>
            s_projectLocationServer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/servers/{server}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serverName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServerName"/> if successful.</returns>
        public static ServerName Parse(string serverName) => Parse(serverName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServerName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/servers/{server}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serverName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServerName"/> if successful.</returns>
        public static ServerName Parse(string serverName, bool allowUnparsed) =>
            TryParse(serverName, allowUnparsed, out ServerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/servers/{server}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serverName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serverName, out ServerName result) => TryParse(serverName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/servers/{server}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serverName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serverName, bool allowUnparsed, out ServerName result)
        {
            gax::GaxPreconditions.CheckNotNull(serverName, nameof(serverName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServer.TryParseName(serverName, out resourceName))
            {
                result = FromProjectLocationServer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serverName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serverId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServerId = serverId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        public ServerName(string projectId, string locationId, string serverId) : this(ResourceNameType.ProjectLocationServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serverId: gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)))
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
        /// The <c>Server</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServer: return s_projectLocationServer.Expand(ProjectId, LocationId, ServerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServerName);

        /// <inheritdoc/>
        public bool Equals(ServerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServerName a, ServerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServerName a, ServerName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>User</c> resource.</summary>
    public sealed partial class UserName : gax::IResourceName, sys::IEquatable<UserName>
    {
        /// <summary>The possible contents of <see cref="UserName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>
            /// .
            /// </summary>
            ProjectLocationServerUser = 1,
        }

        private static gax::PathTemplate s_projectLocationServerUser = new gax::PathTemplate("projects/{project}/locations/{location}/servers/{server}/users/{user}");

        /// <summary>Creates a <see cref="UserName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserName"/> constructed from the provided ids.</returns>
        public static UserName FromProjectLocationServerUser(string projectId, string locationId, string serverId, string userId) =>
            new UserName(ResourceNameType.ProjectLocationServerUser, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serverId: gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serverId, string userId) =>
            FormatProjectLocationServerUser(projectId, locationId, serverId, userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserName"/> with pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>.
        /// </returns>
        public static string FormatProjectLocationServerUser(string projectId, string locationId, string serverId, string userId) =>
            s_projectLocationServerUser.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName) => Parse(userName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserName"/> if successful.</returns>
        public static UserName Parse(string userName, bool allowUnparsed) =>
            TryParse(userName, allowUnparsed, out UserName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="UserName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, out UserName result) => TryParse(userName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userName, bool allowUnparsed, out UserName result)
        {
            gax::GaxPreconditions.CheckNotNull(userName, nameof(userName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServerUser.TryParseName(userName, out resourceName))
            {
                result = FromProjectLocationServerUser(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serverId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServerId = serverId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/servers/{server}/users/{user}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverId">The <c>Server</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public UserName(string projectId, string locationId, string serverId, string userId) : this(ResourceNameType.ProjectLocationServerUser, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serverId: gax::GaxPreconditions.CheckNotNullOrEmpty(serverId, nameof(serverId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
        /// The <c>Server</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServerId { get; }

        /// <summary>
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServerUser: return s_projectLocationServerUser.Expand(ProjectId, LocationId, ServerId, UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserName);

        /// <inheritdoc/>
        public bool Equals(UserName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserName a, UserName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserName a, UserName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ForwardingRule</c> resource.</summary>
    public sealed partial class ForwardingRuleName : gax::IResourceName, sys::IEquatable<ForwardingRuleName>
    {
        /// <summary>The possible contents of <see cref="ForwardingRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>
            /// .
            /// </summary>
            ProjectRegionForwardingRule = 1,
        }

        private static gax::PathTemplate s_projectRegionForwardingRule = new gax::PathTemplate("projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}");

        /// <summary>Creates a <see cref="ForwardingRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ForwardingRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ForwardingRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ForwardingRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ForwardingRuleName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ForwardingRuleName"/> constructed from the provided ids.</returns>
        public static ForwardingRuleName FromProjectRegionForwardingRule(string projectId, string regionId, string forwardingRuleId) =>
            new ForwardingRuleName(ResourceNameType.ProjectRegionForwardingRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), forwardingRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(forwardingRuleId, nameof(forwardingRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string forwardingRuleId) =>
            FormatProjectRegionForwardingRule(projectId, regionId, forwardingRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ForwardingRuleName"/> with pattern
        /// <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>.
        /// </returns>
        public static string FormatProjectRegionForwardingRule(string projectId, string regionId, string forwardingRuleId) =>
            s_projectRegionForwardingRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(forwardingRuleId, nameof(forwardingRuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForwardingRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ForwardingRuleName"/> if successful.</returns>
        public static ForwardingRuleName Parse(string forwardingRuleName) => Parse(forwardingRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ForwardingRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ForwardingRuleName"/> if successful.</returns>
        public static ForwardingRuleName Parse(string forwardingRuleName, bool allowUnparsed) =>
            TryParse(forwardingRuleName, allowUnparsed, out ForwardingRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForwardingRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForwardingRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forwardingRuleName, out ForwardingRuleName result) =>
            TryParse(forwardingRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ForwardingRuleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="forwardingRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ForwardingRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string forwardingRuleName, bool allowUnparsed, out ForwardingRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(forwardingRuleName, nameof(forwardingRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionForwardingRule.TryParseName(forwardingRuleName, out resourceName))
            {
                result = FromProjectRegionForwardingRule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(forwardingRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ForwardingRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string forwardingRuleId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ForwardingRuleId = forwardingRuleId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ForwardingRuleName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="forwardingRuleId">The <c>ForwardingRule</c> ID. Must not be <c>null</c> or empty.</param>
        public ForwardingRuleName(string projectId, string regionId, string forwardingRuleId) : this(ResourceNameType.ProjectRegionForwardingRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), forwardingRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(forwardingRuleId, nameof(forwardingRuleId)))
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
        /// The <c>ForwardingRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ForwardingRuleId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionForwardingRule: return s_projectRegionForwardingRule.Expand(ProjectId, RegionId, ForwardingRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ForwardingRuleName);

        /// <inheritdoc/>
        public bool Equals(ForwardingRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ForwardingRuleName a, ForwardingRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ForwardingRuleName a, ForwardingRuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectNetwork(string projectId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceAttachment</c> resource.</summary>
    public sealed partial class ServiceAttachmentName : gax::IResourceName, sys::IEquatable<ServiceAttachmentName>
    {
        /// <summary>The possible contents of <see cref="ServiceAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
            /// </summary>
            ProjectRegionServiceAttachment = 1,
        }

        private static gax::PathTemplate s_projectRegionServiceAttachment = new gax::PathTemplate("projects/{project}/regions/{region}/serviceAttachments/{service_attachment}");

        /// <summary>Creates a <see cref="ServiceAttachmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceAttachmentName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAttachmentName"/> constructed from the provided ids.</returns>
        public static ServiceAttachmentName FromProjectRegionServiceAttachment(string projectId, string regionId, string serviceAttachmentId) =>
            new ServiceAttachmentName(ResourceNameType.ProjectRegionServiceAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), serviceAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAttachmentId, nameof(serviceAttachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string serviceAttachmentId) =>
            FormatProjectRegionServiceAttachment(projectId, regionId, serviceAttachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </returns>
        public static string FormatProjectRegionServiceAttachment(string projectId, string regionId, string serviceAttachmentId) =>
            s_projectRegionServiceAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAttachmentId, nameof(serviceAttachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceAttachmentName"/> if successful.</returns>
        public static ServiceAttachmentName Parse(string serviceAttachmentName) => Parse(serviceAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAttachmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceAttachmentName"/> if successful.</returns>
        public static ServiceAttachmentName Parse(string serviceAttachmentName, bool allowUnparsed) =>
            TryParse(serviceAttachmentName, allowUnparsed, out ServiceAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAttachmentName, out ServiceAttachmentName result) =>
            TryParse(serviceAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAttachmentName, bool allowUnparsed, out ServiceAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceAttachmentName, nameof(serviceAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionServiceAttachment.TryParseName(serviceAttachmentName, out resourceName))
            {
                result = FromProjectRegionServiceAttachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string serviceAttachmentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            ServiceAttachmentId = serviceAttachmentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceAttachmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceAttachmentName(string projectId, string regionId, string serviceAttachmentId) : this(ResourceNameType.ProjectRegionServiceAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), serviceAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAttachmentId, nameof(serviceAttachmentId)))
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
        /// The <c>ServiceAttachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceAttachmentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionServiceAttachment: return s_projectRegionServiceAttachment.Expand(ProjectId, RegionId, ServiceAttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceAttachmentName);

        /// <inheritdoc/>
        public bool Equals(ServiceAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceAttachmentName a, ServiceAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceAttachmentName a, ServiceAttachmentName b) => !(a == b);
    }

    public partial class InternalServerConfig
    {
        /// <summary>
        /// <see cref="ServiceAttachmentName"/>-typed view over the <see cref="ServiceAttachment"/> resource name
        /// property.
        /// </summary>
        public ServiceAttachmentName ServiceAttachmentAsServiceAttachmentName
        {
            get => string.IsNullOrEmpty(ServiceAttachment) ? null : ServiceAttachmentName.Parse(ServiceAttachment, allowUnparsed: true);
            set => ServiceAttachment = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class AllowedConsumer
            {
                /// <summary>
                /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
                /// </summary>
                public gagr::ProjectName ProjectAsProjectName
                {
                    get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
                    set => Project = value?.ToString() ?? "";
                }
            }

            public partial class DeniedConsumer
            {
                /// <summary>
                /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
                /// </summary>
                public gagr::ProjectName ProjectAsProjectName
                {
                    get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
                    set => Project = value?.ToString() ?? "";
                }
            }

            public partial class PscEndpoint
            {
                /// <summary>
                /// <see cref="ForwardingRuleName"/>-typed view over the <see cref="Endpoint"/> resource name property.
                /// </summary>
                public ForwardingRuleName EndpointAsForwardingRuleName
                {
                    get => string.IsNullOrEmpty(Endpoint) ? null : ForwardingRuleName.Parse(Endpoint, allowUnparsed: true);
                    set => Endpoint = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
                /// </summary>
                public NetworkName NetworkAsNetworkName
                {
                    get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
                    set => Network = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Server
    {
        /// <summary>
        /// <see cref="gcfv::ServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::ServerName ServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::ServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListServersRequest
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

    public partial class GetServerRequest
    {
        /// <summary>
        /// <see cref="gcfv::ServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::ServerName ServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::ServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServerRequest
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

    public partial class DeleteServerRequest
    {
        /// <summary>
        /// <see cref="gcfv::ServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::ServerName ServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::ServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class User
    {
        /// <summary>
        /// <see cref="gcfv::UserName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::UserName UserName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::UserName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUsersRequest
    {
        /// <summary><see cref="ServerName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ServerName ParentAsServerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetUserRequest
    {
        /// <summary>
        /// <see cref="gcfv::UserName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::UserName UserName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::UserName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUserRequest
    {
        /// <summary><see cref="ServerName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ServerName ParentAsServerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteUserRequest
    {
        /// <summary>
        /// <see cref="gcfv::UserName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::UserName UserName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::UserName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartServerRequest
    {
        /// <summary>
        /// <see cref="gcfv::ServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::ServerName ServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::ServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopServerRequest
    {
        /// <summary>
        /// <see cref="gcfv::ServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::ServerName ServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::ServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
