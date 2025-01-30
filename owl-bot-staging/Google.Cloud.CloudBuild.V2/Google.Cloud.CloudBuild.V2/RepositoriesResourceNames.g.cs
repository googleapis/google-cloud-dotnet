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
using gccv = Google.Cloud.CloudBuild.V2;
using sys = System;

namespace Google.Cloud.CloudBuild.V2
{
    /// <summary>Resource name for the <c>Connection</c> resource.</summary>
    public sealed partial class ConnectionName : gax::IResourceName, sys::IEquatable<ConnectionName>
    {
        /// <summary>The possible contents of <see cref="ConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/connections/{connection}</c>.
            /// </summary>
            ProjectLocationConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationConnection = new gax::PathTemplate("projects/{project}/locations/{location}/connections/{connection}");

        /// <summary>Creates a <see cref="ConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectionName"/> constructed from the provided ids.</returns>
        public static ConnectionName FromProjectLocationConnection(string projectId, string locationId, string connectionId) =>
            new ConnectionName(ResourceNameType.ProjectLocationConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionId) =>
            FormatProjectLocationConnection(projectId, locationId, connectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}</c>.
        /// </returns>
        public static string FormatProjectLocationConnection(string projectId, string locationId, string connectionId) =>
            s_projectLocationConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConnectionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connections/{connection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectionName"/> if successful.</returns>
        public static ConnectionName Parse(string connectionName) => Parse(connectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connections/{connection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectionName"/> if successful.</returns>
        public static ConnectionName Parse(string connectionName, bool allowUnparsed) =>
            TryParse(connectionName, allowUnparsed, out ConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connections/{connection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionName, out ConnectionName result) =>
            TryParse(connectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/connections/{connection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionName, bool allowUnparsed, out ConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectionName, nameof(connectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnection.TryParseName(connectionName, out resourceName))
            {
                result = FromProjectLocationConnection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionId = connectionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectionName(string projectId, string locationId, string connectionId) : this(ResourceNameType.ProjectLocationConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)))
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
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

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
                case ResourceNameType.ProjectLocationConnection: return s_projectLocationConnection.Expand(ProjectId, LocationId, ConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectionName);

        /// <inheritdoc/>
        public bool Equals(ConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConnectionName a, ConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConnectionName a, ConnectionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Repository</c> resource.</summary>
    public sealed partial class RepositoryName : gax::IResourceName, sys::IEquatable<RepositoryName>
    {
        /// <summary>The possible contents of <see cref="RepositoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
            /// </summary>
            ProjectLocationConnectionRepository = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionRepository = new gax::PathTemplate("projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}");

        /// <summary>Creates a <see cref="RepositoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RepositoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RepositoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RepositoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RepositoryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RepositoryName"/> constructed from the provided ids.</returns>
        public static RepositoryName FromProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            new RepositoryName(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionId, string repositoryId) =>
            FormatProjectLocationConnectionRepository(projectId, locationId, connectionId, repositoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string FormatProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            s_projectLocationConnectionRepository.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RepositoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName) => Parse(repositoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RepositoryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName, bool allowUnparsed) =>
            TryParse(repositoryName, allowUnparsed, out RepositoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, out RepositoryName result) =>
            TryParse(repositoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, bool allowUnparsed, out RepositoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(repositoryName, nameof(repositoryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionRepository.TryParseName(repositoryName, out resourceName))
            {
                result = FromProjectLocationConnectionRepository(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(repositoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RepositoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionId = connectionId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RepositoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        public RepositoryName(string projectId, string locationId, string connectionId, string repositoryId) : this(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)))
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
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationConnectionRepository: return s_projectLocationConnectionRepository.Expand(ProjectId, LocationId, ConnectionId, RepositoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RepositoryName);

        /// <inheritdoc/>
        public bool Equals(RepositoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RepositoryName a, RepositoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RepositoryName a, RepositoryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        /// <summary>The possible contents of <see cref="ServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
            /// </summary>
            ProjectLocationNamespaceService = 1,
        }

        private static gax::PathTemplate s_projectLocationNamespaceService = new gax::PathTemplate("projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}");

        /// <summary>Creates a <see cref="ServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromProjectLocationNamespaceService(string projectId, string locationId, string namespaceId, string serviceId) =>
            new ServiceName(ResourceNameType.ProjectLocationNamespaceService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string namespaceId, string serviceId) =>
            FormatProjectLocationNamespaceService(projectId, locationId, namespaceId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </returns>
        public static string FormatProjectLocationNamespaceService(string projectId, string locationId, string namespaceId, string serviceId) =>
            s_projectLocationNamespaceService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName) => Parse(serviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName, bool allowUnparsed) =>
            TryParse(serviceName, allowUnparsed, out ServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result) => TryParse(serviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, bool allowUnparsed, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNamespaceService.TryParseName(serviceName, out resourceName))
            {
                result = FromProjectLocationNamespaceService(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string namespaceId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NamespaceId = namespaceId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceName(string projectId, string locationId, string namespaceId, string serviceId) : this(ResourceNameType.ProjectLocationNamespaceService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationNamespaceService: return s_projectLocationNamespaceService.Expand(ProjectId, LocationId, NamespaceId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
    }

    public partial class Connection
    {
        /// <summary>
        /// <see cref="gccv::ConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectionName ConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchLinkableRepositoriesRequest
    {
        /// <summary>
        /// <see cref="ConnectionName"/>-typed view over the <see cref="Connection"/> resource name property.
        /// </summary>
        public ConnectionName ConnectionAsConnectionName
        {
            get => string.IsNullOrEmpty(Connection) ? null : ConnectionName.Parse(Connection, allowUnparsed: true);
            set => Connection = value?.ToString() ?? "";
        }
    }

    public partial class GitHubEnterpriseConfig
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PrivateKeySecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PrivateKeySecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PrivateKeySecretVersion) ? null : SecretVersionName.Parse(PrivateKeySecretVersion, allowUnparsed: true);
            set => PrivateKeySecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="WebhookSecretSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName WebhookSecretSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(WebhookSecretSecretVersion) ? null : SecretVersionName.Parse(WebhookSecretSecretVersion, allowUnparsed: true);
            set => WebhookSecretSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class GitLabConfig
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="WebhookSecretSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName WebhookSecretSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(WebhookSecretSecretVersion) ? null : SecretVersionName.Parse(WebhookSecretSecretVersion, allowUnparsed: true);
            set => WebhookSecretSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class BitbucketDataCenterConfig
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="WebhookSecretSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName WebhookSecretSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(WebhookSecretSecretVersion) ? null : SecretVersionName.Parse(WebhookSecretSecretVersion, allowUnparsed: true);
            set => WebhookSecretSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class BitbucketCloudConfig
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="WebhookSecretSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName WebhookSecretSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(WebhookSecretSecretVersion) ? null : SecretVersionName.Parse(WebhookSecretSecretVersion, allowUnparsed: true);
            set => WebhookSecretSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class ServiceDirectoryConfig
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Service"/> resource name property.
        /// </summary>
        public ServiceName ServiceAsServiceName
        {
            get => string.IsNullOrEmpty(Service) ? null : ServiceName.Parse(Service, allowUnparsed: true);
            set => Service = value?.ToString() ?? "";
        }
    }

    public partial class Repository
    {
        /// <summary>
        /// <see cref="gccv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OAuthCredential
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="OauthTokenSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName OauthTokenSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(OauthTokenSecretVersion) ? null : SecretVersionName.Parse(OauthTokenSecretVersion, allowUnparsed: true);
            set => OauthTokenSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class UserCredential
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="UserTokenSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName UserTokenSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(UserTokenSecretVersion) ? null : SecretVersionName.Parse(UserTokenSecretVersion, allowUnparsed: true);
            set => UserTokenSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectionRequest
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

    public partial class GetConnectionRequest
    {
        /// <summary>
        /// <see cref="gccv::ConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectionName ConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectionsRequest
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

    public partial class DeleteConnectionRequest
    {
        /// <summary>
        /// <see cref="gccv::ConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectionName ConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRepositoryRequest
    {
        /// <summary>
        /// <see cref="ConnectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConnectionName ParentAsConnectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConnectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateRepositoriesRequest
    {
        /// <summary>
        /// <see cref="ConnectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConnectionName ParentAsConnectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConnectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRepositoryRequest
    {
        /// <summary>
        /// <see cref="gccv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRepositoriesRequest
    {
        /// <summary>
        /// <see cref="ConnectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConnectionName ParentAsConnectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConnectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRepositoryRequest
    {
        /// <summary>
        /// <see cref="gccv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchReadWriteTokenRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }
    }

    public partial class FetchReadTokenRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }
    }

    public partial class ProcessWebhookRequest
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

    public partial class FetchGitRefsRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }
    }
}
