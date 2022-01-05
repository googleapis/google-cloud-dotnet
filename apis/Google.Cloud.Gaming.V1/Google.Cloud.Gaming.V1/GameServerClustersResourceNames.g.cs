// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcgv = Google.Cloud.Gaming.V1;
using sys = System;

namespace Google.Cloud.Gaming.V1
{
    /// <summary>Resource name for the <c>GameServerCluster</c> resource.</summary>
    public sealed partial class GameServerClusterName : gax::IResourceName, sys::IEquatable<GameServerClusterName>
    {
        /// <summary>The possible contents of <see cref="GameServerClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>.
            /// </summary>
            ProjectLocationRealmCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationRealmCluster = new gax::PathTemplate("projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}");

        /// <summary>Creates a <see cref="GameServerClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GameServerClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GameServerClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GameServerClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GameServerClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="realmId">The <c>Realm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GameServerClusterName"/> constructed from the provided ids.</returns>
        public static GameServerClusterName FromProjectLocationRealmCluster(string projectId, string locationId, string realmId, string clusterId) =>
            new GameServerClusterName(ResourceNameType.ProjectLocationRealmCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), realmId: gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="realmId">The <c>Realm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string realmId, string clusterId) =>
            FormatProjectLocationRealmCluster(projectId, locationId, realmId, clusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="realmId">The <c>Realm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationRealmCluster(string projectId, string locationId, string realmId, string clusterId) =>
            s_projectLocationRealmCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GameServerClusterName"/> if successful.</returns>
        public static GameServerClusterName Parse(string gameServerClusterName) => Parse(gameServerClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GameServerClusterName"/> if successful.</returns>
        public static GameServerClusterName Parse(string gameServerClusterName, bool allowUnparsed) =>
            TryParse(gameServerClusterName, allowUnparsed, out GameServerClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerClusterName, out GameServerClusterName result) =>
            TryParse(gameServerClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerClusterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerClusterName, bool allowUnparsed, out GameServerClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(gameServerClusterName, nameof(gameServerClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRealmCluster.TryParseName(gameServerClusterName, out resourceName))
            {
                result = FromProjectLocationRealmCluster(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gameServerClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GameServerClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string projectId = null, string realmId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
            RealmId = realmId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GameServerClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="realmId">The <c>Realm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        public GameServerClusterName(string projectId, string locationId, string realmId, string clusterId) : this(ResourceNameType.ProjectLocationRealmCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), realmId: gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)))
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
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Realm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RealmId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRealmCluster: return s_projectLocationRealmCluster.Expand(ProjectId, LocationId, RealmId, ClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GameServerClusterName);

        /// <inheritdoc/>
        public bool Equals(GameServerClusterName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(GameServerClusterName a, GameServerClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(GameServerClusterName a, GameServerClusterName b) => !(a == b);
    }

    public partial class ListGameServerClustersRequest
    {
        /// <summary><see cref="RealmName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RealmName ParentAsRealmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RealmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGameServerClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerClusterName GameServerClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGameServerClusterRequest
    {
        /// <summary><see cref="RealmName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RealmName ParentAsRealmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RealmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PreviewCreateGameServerClusterRequest
    {
        /// <summary><see cref="RealmName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RealmName ParentAsRealmName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RealmName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGameServerClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerClusterName GameServerClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PreviewDeleteGameServerClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerClusterName GameServerClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GameServerCluster
    {
        /// <summary>
        /// <see cref="gcgv::GameServerClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerClusterName GameServerClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
