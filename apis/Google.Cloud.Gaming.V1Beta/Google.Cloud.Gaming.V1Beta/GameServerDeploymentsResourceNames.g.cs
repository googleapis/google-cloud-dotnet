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
using gagr = Google.Api.Gax.ResourceNames;
using gcgv = Google.Cloud.Gaming.V1Beta;
using sys = System;

namespace Google.Cloud.Gaming.V1Beta
{
    /// <summary>Resource name for the <c>GameServerDeployment</c> resource.</summary>
    public sealed partial class GameServerDeploymentName : gax::IResourceName, sys::IEquatable<GameServerDeploymentName>
    {
        /// <summary>The possible contents of <see cref="GameServerDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>.
            /// </summary>
            ProjectLocationDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/gameServerDeployments/{deployment}");

        /// <summary>Creates a <see cref="GameServerDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GameServerDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GameServerDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GameServerDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GameServerDeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="GameServerDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static GameServerDeploymentName FromProjectLocationDeployment(string projectId, string locationId, string deploymentId) =>
            new GameServerDeploymentName(ResourceNameType.ProjectLocationDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string deploymentId) =>
            FormatProjectLocationDeployment(projectId, locationId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationDeployment(string projectId, string locationId, string deploymentId) =>
            s_projectLocationDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GameServerDeploymentName"/> if successful.</returns>
        public static GameServerDeploymentName Parse(string gameServerDeploymentName) =>
            Parse(gameServerDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GameServerDeploymentName"/> if successful.</returns>
        public static GameServerDeploymentName Parse(string gameServerDeploymentName, bool allowUnparsed) =>
            TryParse(gameServerDeploymentName, allowUnparsed, out GameServerDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerDeploymentName, out GameServerDeploymentName result) =>
            TryParse(gameServerDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerDeploymentName, bool allowUnparsed, out GameServerDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(gameServerDeploymentName, nameof(gameServerDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeployment.TryParseName(gameServerDeploymentName, out resourceName))
            {
                result = FromProjectLocationDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gameServerDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GameServerDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GameServerDeploymentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public GameServerDeploymentName(string projectId, string locationId, string deploymentId) : this(ResourceNameType.ProjectLocationDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
                case ResourceNameType.ProjectLocationDeployment: return s_projectLocationDeployment.Expand(ProjectId, LocationId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GameServerDeploymentName);

        /// <inheritdoc/>
        public bool Equals(GameServerDeploymentName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(GameServerDeploymentName a, GameServerDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(GameServerDeploymentName a, GameServerDeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GameServerDeploymentRollout</c> resource.</summary>
    public sealed partial class GameServerDeploymentRolloutName : gax::IResourceName, sys::IEquatable<GameServerDeploymentRolloutName>
    {
        /// <summary>The possible contents of <see cref="GameServerDeploymentRolloutName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>.
            /// </summary>
            ProjectLocationDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout");

        /// <summary>
        /// Creates a <see cref="GameServerDeploymentRolloutName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GameServerDeploymentRolloutName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GameServerDeploymentRolloutName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GameServerDeploymentRolloutName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GameServerDeploymentRolloutName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="GameServerDeploymentRolloutName"/> constructed from the provided ids.
        /// </returns>
        public static GameServerDeploymentRolloutName FromProjectLocationDeployment(string projectId, string locationId, string deploymentId) =>
            new GameServerDeploymentRolloutName(ResourceNameType.ProjectLocationDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerDeploymentRolloutName"/> with
        /// pattern <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerDeploymentRolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string deploymentId) =>
            FormatProjectLocationDeployment(projectId, locationId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GameServerDeploymentRolloutName"/> with
        /// pattern <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GameServerDeploymentRolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>.
        /// </returns>
        public static string FormatProjectLocationDeployment(string projectId, string locationId, string deploymentId) =>
            s_projectLocationDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerDeploymentRolloutName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerDeploymentRolloutName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="GameServerDeploymentRolloutName"/> if successful.</returns>
        public static GameServerDeploymentRolloutName Parse(string gameServerDeploymentRolloutName) =>
            Parse(gameServerDeploymentRolloutName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GameServerDeploymentRolloutName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerDeploymentRolloutName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GameServerDeploymentRolloutName"/> if successful.</returns>
        public static GameServerDeploymentRolloutName Parse(string gameServerDeploymentRolloutName, bool allowUnparsed) =>
            TryParse(gameServerDeploymentRolloutName, allowUnparsed, out GameServerDeploymentRolloutName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerDeploymentRolloutName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gameServerDeploymentRolloutName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerDeploymentRolloutName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerDeploymentRolloutName, out GameServerDeploymentRolloutName result) =>
            TryParse(gameServerDeploymentRolloutName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GameServerDeploymentRolloutName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gameServerDeploymentRolloutName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GameServerDeploymentRolloutName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gameServerDeploymentRolloutName, bool allowUnparsed, out GameServerDeploymentRolloutName result)
        {
            gax::GaxPreconditions.CheckNotNull(gameServerDeploymentRolloutName, nameof(gameServerDeploymentRolloutName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeployment.TryParseName(gameServerDeploymentRolloutName, out resourceName))
            {
                result = FromProjectLocationDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gameServerDeploymentRolloutName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GameServerDeploymentRolloutName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GameServerDeploymentRolloutName"/> class from the component parts
        /// of pattern <c>projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public GameServerDeploymentRolloutName(string projectId, string locationId, string deploymentId) : this(ResourceNameType.ProjectLocationDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
                case ResourceNameType.ProjectLocationDeployment: return s_projectLocationDeployment.Expand(ProjectId, LocationId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GameServerDeploymentRolloutName);

        /// <inheritdoc/>
        public bool Equals(GameServerDeploymentRolloutName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(GameServerDeploymentRolloutName a, GameServerDeploymentRolloutName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(GameServerDeploymentRolloutName a, GameServerDeploymentRolloutName b) => !(a == b);
    }

    public partial class ListGameServerDeploymentsRequest
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

    public partial class GetGameServerDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerDeploymentName GameServerDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGameServerDeploymentRolloutRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerDeploymentName GameServerDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGameServerDeploymentRequest
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

    public partial class DeleteGameServerDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcgv::GameServerDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerDeploymentName GameServerDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GameServerDeployment
    {
        /// <summary>
        /// <see cref="gcgv::GameServerDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::GameServerDeploymentName GameServerDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GameServerDeploymentRollout
    {
        /// <summary>
        /// <see cref="gcgv::GameServerDeploymentRolloutName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcgv::GameServerDeploymentRolloutName GameServerDeploymentRolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::GameServerDeploymentRolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
