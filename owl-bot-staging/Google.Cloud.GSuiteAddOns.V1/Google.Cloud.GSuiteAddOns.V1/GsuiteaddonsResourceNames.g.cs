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
using gcgv = Google.Cloud.GSuiteAddOns.V1;
using sys = System;

namespace Google.Cloud.GSuiteAddOns.V1
{
    /// <summary>Resource name for the <c>Authorization</c> resource.</summary>
    public sealed partial class AuthorizationName : gax::IResourceName, sys::IEquatable<AuthorizationName>
    {
        /// <summary>The possible contents of <see cref="AuthorizationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/authorization</c>.</summary>
            Project = 1,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/authorization");

        /// <summary>Creates a <see cref="AuthorizationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AuthorizationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AuthorizationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AuthorizationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AuthorizationName"/> with the pattern <c>projects/{project}/authorization</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AuthorizationName"/> constructed from the provided ids.</returns>
        public static AuthorizationName FromProject(string projectId) =>
            new AuthorizationName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuthorizationName"/> with pattern
        /// <c>projects/{project}/authorization</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuthorizationName"/> with pattern
        /// <c>projects/{project}/authorization</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuthorizationName"/> with pattern
        /// <c>projects/{project}/authorization</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuthorizationName"/> with pattern
        /// <c>projects/{project}/authorization</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuthorizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/authorization</c></description></item></list>
        /// </remarks>
        /// <param name="authorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AuthorizationName"/> if successful.</returns>
        public static AuthorizationName Parse(string authorizationName) => Parse(authorizationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuthorizationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/authorization</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="authorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AuthorizationName"/> if successful.</returns>
        public static AuthorizationName Parse(string authorizationName, bool allowUnparsed) =>
            TryParse(authorizationName, allowUnparsed, out AuthorizationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuthorizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/authorization</c></description></item></list>
        /// </remarks>
        /// <param name="authorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuthorizationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string authorizationName, out AuthorizationName result) =>
            TryParse(authorizationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuthorizationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/authorization</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="authorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuthorizationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string authorizationName, bool allowUnparsed, out AuthorizationName result)
        {
            gax::GaxPreconditions.CheckNotNull(authorizationName, nameof(authorizationName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(authorizationName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(authorizationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AuthorizationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AuthorizationName"/> class from the component parts of pattern
        /// <c>projects/{project}/authorization</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public AuthorizationName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AuthorizationName);

        /// <inheritdoc/>
        public bool Equals(AuthorizationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AuthorizationName a, AuthorizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AuthorizationName a, AuthorizationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstallStatus</c> resource.</summary>
    public sealed partial class InstallStatusName : gax::IResourceName, sys::IEquatable<InstallStatusName>
    {
        /// <summary>The possible contents of <see cref="InstallStatusName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/deployments/{deployment}/installStatus</c>.
            /// </summary>
            ProjectDeployment = 1,
        }

        private static gax::PathTemplate s_projectDeployment = new gax::PathTemplate("projects/{project}/deployments/{deployment}/installStatus");

        /// <summary>Creates a <see cref="InstallStatusName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstallStatusName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstallStatusName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstallStatusName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstallStatusName"/> with the pattern
        /// <c>projects/{project}/deployments/{deployment}/installStatus</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstallStatusName"/> constructed from the provided ids.</returns>
        public static InstallStatusName FromProjectDeployment(string projectId, string deploymentId) =>
            new InstallStatusName(ResourceNameType.ProjectDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstallStatusName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}/installStatus</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstallStatusName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}/installStatus</c>.
        /// </returns>
        public static string Format(string projectId, string deploymentId) => FormatProjectDeployment(projectId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstallStatusName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}/installStatus</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstallStatusName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}/installStatus</c>.
        /// </returns>
        public static string FormatProjectDeployment(string projectId, string deploymentId) =>
            s_projectDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstallStatusName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/deployments/{deployment}/installStatus</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="installStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstallStatusName"/> if successful.</returns>
        public static InstallStatusName Parse(string installStatusName) => Parse(installStatusName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstallStatusName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/deployments/{deployment}/installStatus</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="installStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstallStatusName"/> if successful.</returns>
        public static InstallStatusName Parse(string installStatusName, bool allowUnparsed) =>
            TryParse(installStatusName, allowUnparsed, out InstallStatusName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstallStatusName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/deployments/{deployment}/installStatus</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="installStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstallStatusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string installStatusName, out InstallStatusName result) =>
            TryParse(installStatusName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstallStatusName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/deployments/{deployment}/installStatus</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="installStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstallStatusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string installStatusName, bool allowUnparsed, out InstallStatusName result)
        {
            gax::GaxPreconditions.CheckNotNull(installStatusName, nameof(installStatusName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDeployment.TryParseName(installStatusName, out resourceName))
            {
                result = FromProjectDeployment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(installStatusName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstallStatusName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstallStatusName"/> class from the component parts of pattern
        /// <c>projects/{project}/deployments/{deployment}/installStatus</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public InstallStatusName(string projectId, string deploymentId) : this(ResourceNameType.ProjectDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
                case ResourceNameType.ProjectDeployment: return s_projectDeployment.Expand(ProjectId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstallStatusName);

        /// <inheritdoc/>
        public bool Equals(InstallStatusName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstallStatusName a, InstallStatusName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstallStatusName a, InstallStatusName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Deployment</c> resource.</summary>
    public sealed partial class DeploymentName : gax::IResourceName, sys::IEquatable<DeploymentName>
    {
        /// <summary>The possible contents of <see cref="DeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/deployments/{deployment}</c>.</summary>
            ProjectDeployment = 1,
        }

        private static gax::PathTemplate s_projectDeployment = new gax::PathTemplate("projects/{project}/deployments/{deployment}");

        /// <summary>Creates a <see cref="DeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeploymentName"/> with the pattern <c>projects/{project}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeploymentName"/> constructed from the provided ids.</returns>
        public static DeploymentName FromProjectDeployment(string projectId, string deploymentId) =>
            new DeploymentName(ResourceNameType.ProjectDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string deploymentId) => FormatProjectDeployment(projectId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>projects/{project}/deployments/{deployment}</c>.
        /// </returns>
        public static string FormatProjectDeployment(string projectId, string deploymentId) =>
            s_projectDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DeploymentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/deployments/{deployment}</c></description></item>
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
        /// <item><description><c>projects/{project}/deployments/{deployment}</c></description></item>
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
        /// <item><description><c>projects/{project}/deployments/{deployment}</c></description></item>
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
        /// <item><description><c>projects/{project}/deployments/{deployment}</c></description></item>
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
            if (s_projectDeployment.TryParseName(deploymentName, out resourceName))
            {
                result = FromProjectDeployment(resourceName[0], resourceName[1]);
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

        private DeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeploymentName"/> class from the component parts of pattern
        /// <c>projects/{project}/deployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public DeploymentName(string projectId, string deploymentId) : this(ResourceNameType.ProjectDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
                case ResourceNameType.ProjectDeployment: return s_projectDeployment.Expand(ProjectId, DeploymentId);
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

    public partial class GetAuthorizationRequest
    {
        /// <summary>
        /// <see cref="gcgv::AuthorizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AuthorizationName AuthorizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AuthorizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Authorization
    {
        /// <summary>
        /// <see cref="gcgv::AuthorizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AuthorizationName AuthorizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AuthorizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDeploymentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcgv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeploymentsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcgv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InstallDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcgv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UninstallDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcgv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetInstallStatusRequest
    {
        /// <summary>
        /// <see cref="gcgv::InstallStatusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::InstallStatusName InstallStatusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::InstallStatusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InstallStatus
    {
        /// <summary>
        /// <see cref="gcgv::InstallStatusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::InstallStatusName InstallStatusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::InstallStatusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Deployment
    {
        /// <summary>
        /// <see cref="gcgv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
