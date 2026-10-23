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
using gccv = Google.Cloud.Ces.V1Beta;
using sys = System;

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Resource name for the <c>Deployment</c> resource.</summary>
    public sealed partial class DeploymentName : gax::IResourceName, sys::IEquatable<DeploymentName>
    {
        /// <summary>The possible contents of <see cref="DeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>.
            /// </summary>
            ProjectLocationAppDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationAppDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}");

        /// <summary>Creates a <see cref="DeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeploymentName"/> constructed from the provided ids.</returns>
        public static DeploymentName FromProjectLocationAppDeployment(string projectId, string locationId, string appId, string deploymentId) =>
            new DeploymentName(ResourceNameType.ProjectLocationAppDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string deploymentId) =>
            FormatProjectLocationAppDeployment(projectId, locationId, appId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationAppDeployment(string projectId, string locationId, string appId, string deploymentId) =>
            s_projectLocationAppDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DeploymentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName) => Parse(deploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeploymentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName, bool allowUnparsed) =>
            TryParse(deploymentName, allowUnparsed, out DeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, out DeploymentName result) =>
            TryParse(deploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, bool allowUnparsed, out DeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(deploymentName, nameof(deploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppDeployment.TryParseName(deploymentName, out resourceName))
            {
                result = FromProjectLocationAppDeployment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string deploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            DeploymentId = deploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeploymentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public DeploymentName(string projectId, string locationId, string appId, string deploymentId) : this(ResourceNameType.ProjectLocationAppDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

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
                case ResourceNameType.ProjectLocationAppDeployment: return s_projectLocationAppDeployment.Expand(ProjectId, LocationId, AppId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeploymentName);

        /// <inheritdoc/>
        public bool Equals(DeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeploymentName a, DeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeploymentName a, DeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AgentRegistryService</c> resource.</summary>
    public sealed partial class AgentRegistryServiceName : gax::IResourceName, sys::IEquatable<AgentRegistryServiceName>
    {
        /// <summary>The possible contents of <see cref="AgentRegistryServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/services/{service}</c>.
            /// </summary>
            ProjectLocationService = 1,
        }

        private static gax::PathTemplate s_projectLocationService = new gax::PathTemplate("projects/{project}/locations/{location}/services/{service}");

        /// <summary>Creates a <see cref="AgentRegistryServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AgentRegistryServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AgentRegistryServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AgentRegistryServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AgentRegistryServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AgentRegistryServiceName"/> constructed from the provided ids.
        /// </returns>
        public static AgentRegistryServiceName FromProjectLocationService(string projectId, string locationId, string serviceId) =>
            new AgentRegistryServiceName(ResourceNameType.ProjectLocationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentRegistryServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentRegistryServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId) =>
            FormatProjectLocationService(projectId, locationId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentRegistryServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentRegistryServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </returns>
        public static string FormatProjectLocationService(string projectId, string locationId, string serviceId) =>
            s_projectLocationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentRegistryServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="agentRegistryServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgentRegistryServiceName"/> if successful.</returns>
        public static AgentRegistryServiceName Parse(string agentRegistryServiceName) =>
            Parse(agentRegistryServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentRegistryServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentRegistryServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AgentRegistryServiceName"/> if successful.</returns>
        public static AgentRegistryServiceName Parse(string agentRegistryServiceName, bool allowUnparsed) =>
            TryParse(agentRegistryServiceName, allowUnparsed, out AgentRegistryServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentRegistryServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="agentRegistryServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentRegistryServiceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentRegistryServiceName, out AgentRegistryServiceName result) =>
            TryParse(agentRegistryServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentRegistryServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentRegistryServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentRegistryServiceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentRegistryServiceName, bool allowUnparsed, out AgentRegistryServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentRegistryServiceName, nameof(agentRegistryServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationService.TryParseName(agentRegistryServiceName, out resourceName))
            {
                result = FromProjectLocationService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentRegistryServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AgentRegistryServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AgentRegistryServiceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/services/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public AgentRegistryServiceName(string projectId, string locationId, string serviceId) : this(ResourceNameType.ProjectLocationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
                case ResourceNameType.ProjectLocationService: return s_projectLocationService.Expand(ProjectId, LocationId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AgentRegistryServiceName);

        /// <inheritdoc/>
        public bool Equals(AgentRegistryServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AgentRegistryServiceName a, AgentRegistryServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AgentRegistryServiceName a, AgentRegistryServiceName b) => !(a == b);
    }

    public partial class ExperimentConfig
    {
        public partial class Types
        {
            public partial class VersionRelease
            {
                public partial class Types
                {
                    public partial class TrafficAllocation
                    {
                        /// <summary>
                        /// <see cref="AppVersionName"/>-typed view over the <see cref="AppVersion"/> resource name
                        /// property.
                        /// </summary>
                        public AppVersionName AppVersionAsAppVersionName
                        {
                            get => string.IsNullOrEmpty(AppVersion) ? null : AppVersionName.Parse(AppVersion, allowUnparsed: true);
                            set => AppVersion = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }

    public partial class Deployment
    {
        /// <summary>
        /// <see cref="gccv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AppVersionName"/>-typed view over the <see cref="AppVersion"/> resource name property.
        /// </summary>
        public AppVersionName AppVersionAsAppVersionName
        {
            get => string.IsNullOrEmpty(AppVersion) ? null : AppVersionName.Parse(AppVersion, allowUnparsed: true);
            set => AppVersion = value?.ToString() ?? "";
        }
    }

    public partial class AgentRegistryDeployment
    {
        /// <summary>
        /// <see cref="gccv::AgentRegistryServiceName"/>-typed view over the <see cref="AgentRegistryServiceName"/>
        /// resource name property.
        /// </summary>
        public gccv::AgentRegistryServiceName AgentRegistryServiceNameAsAgentRegistryServiceName
        {
            get => string.IsNullOrEmpty(AgentRegistryServiceName) ? null : gccv::AgentRegistryServiceName.Parse(AgentRegistryServiceName, allowUnparsed: true);
            set => AgentRegistryServiceName = value?.ToString() ?? "";
        }
    }
}
