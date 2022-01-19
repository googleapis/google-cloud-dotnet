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
using gcgv = Google.Cloud.Gaming.V1Beta;
using sys = System;

namespace Google.Cloud.Gaming.V1Beta
{
    /// <summary>Resource name for the <c>GameServerConfig</c> resource.</summary>
    public sealed partial class GameServerConfigName : gax::IResourceName, sys::IEquatable<GameServerConfigName>
    {
        /// <summary>The possible contents of <see cref="GameServerConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>.
            /// </summary>
            ProjectLocationDeploymentConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationDeploymentConfig = new gax::PathTemplate("projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}");

        /// <summary>Creates a <see cref="GameServerConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GameServerConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GameServerConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GameServerConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GameServerConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GameServerConfigName"/> constructed from the provided ids.</returns>
        public static GameServerConfigName FromProjectLocationDeploymentConfig(string projectId, string locationId, string deploymentId, string configId) =>
            new GameServerConfigName(ResourceNameType.ProjectLocationDeploymentConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string deploymentId, string configId) =>
            FormatProjectLocationDeploymentConfig(projectId, locationId, deploymentId, configId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>.
        /// </returns>
        public static string FormatProjectLocationDeploymentConfig(string projectId, string locationId, string deploymentId, string configId) =>
            s_projectLocationDeploymentConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GameServerConfigName"/> if successful.</returns>
        public static GameServerConfigName Parse(string gameServerConfigName) => Parse(gameServerConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GameServerConfigName"/> if successful.</returns>
        public static GameServerConfigName Parse(string gameServerConfigName, bool allowUnparsed) =>
            TryParse(gameServerConfigName, allowUnparsed, out GameServerConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerConfigName, out GameServerConfigName result) =>
            TryParse(gameServerConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerConfigName, bool allowUnparsed, out GameServerConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(gameServerConfigName, nameof(gameServerConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeploymentConfig.TryParseName(gameServerConfigName, out resourceName))
            {
                result = FromProjectLocationDeploymentConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gameServerConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GameServerConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string configId = null, string deploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConfigId = configId;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GameServerConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        public GameServerConfigName(string projectId, string locationId, string deploymentId, string configId) : this(ResourceNameType.ProjectLocationDeploymentConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)))
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
        /// The <c>Config</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConfigId { get; }

        /// <summary>
        /// The <c>Deployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DeploymentId { get; }

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
                case ResourceNameType.ProjectLocationDeploymentConfig: return s_projectLocationDeploymentConfig.Expand(ProjectId, LocationId, DeploymentId, ConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GameServerConfigName);

        /// <inheritdoc/>
        public bool Equals(GameServerConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(GameServerConfigName a, GameServerConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(GameServerConfigName a, GameServerConfigName b) => !(a == b);
    }

    public partial class ListGameServerConfigsRequest
    {
        /// <summary>
        /// <see cref="GameServerDeploymentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GameServerDeploymentName ParentAsGameServerDeploymentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GameServerDeploymentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGameServerConfigRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerConfigName GameServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGameServerConfigRequest
    {
        /// <summary>
        /// <see cref="GameServerDeploymentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GameServerDeploymentName ParentAsGameServerDeploymentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GameServerDeploymentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGameServerConfigRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerConfigName GameServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GameServerConfig
    {
        /// <summary>
        /// <see cref="gcgv::GameServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerConfigName GameServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
