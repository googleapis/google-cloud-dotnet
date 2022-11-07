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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcdv = Google.Cloud.Dataform.V1Beta1;
using sys = System;

namespace Google.Cloud.Dataform.V1Beta1
{
    /// <summary>Resource name for the <c>Repository</c> resource.</summary>
    public sealed partial class RepositoryName : gax::IResourceName, sys::IEquatable<RepositoryName>
    {
        /// <summary>The possible contents of <see cref="RepositoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
            /// </summary>
            ProjectLocationRepository = 1,
        }

        private static gax::PathTemplate s_projectLocationRepository = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}");

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
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RepositoryName"/> constructed from the provided ids.</returns>
        public static RepositoryName FromProjectLocationRepository(string projectId, string locationId, string repositoryId) =>
            new RepositoryName(ResourceNameType.ProjectLocationRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId) =>
            FormatProjectLocationRepository(projectId, locationId, repositoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </returns>
        public static string FormatProjectLocationRepository(string projectId, string locationId, string repositoryId) =>
            s_projectLocationRepository.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RepositoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
            if (s_projectLocationRepository.TryParseName(repositoryName, out resourceName))
            {
                result = FromProjectLocationRepository(resourceName[0], resourceName[1], resourceName[2]);
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

        private RepositoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RepositoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        public RepositoryName(string projectId, string locationId, string repositoryId) : this(ResourceNameType.ProjectLocationRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)))
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
                case ResourceNameType.ProjectLocationRepository: return s_projectLocationRepository.Expand(ProjectId, LocationId, RepositoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RepositoryName);

        /// <inheritdoc/>
        public bool Equals(RepositoryName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RepositoryName a, RepositoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RepositoryName a, RepositoryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Workspace</c> resource.</summary>
    public sealed partial class WorkspaceName : gax::IResourceName, sys::IEquatable<WorkspaceName>
    {
        /// <summary>The possible contents of <see cref="WorkspaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>.
            /// </summary>
            ProjectLocationRepositoryWorkspace = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryWorkspace = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}");

        /// <summary>Creates a <see cref="WorkspaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkspaceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkspaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkspaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkspaceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkspaceName"/> constructed from the provided ids.</returns>
        public static WorkspaceName FromProjectLocationRepositoryWorkspace(string projectId, string locationId, string repositoryId, string workspaceId) =>
            new WorkspaceName(ResourceNameType.ProjectLocationRepositoryWorkspace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), workspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string workspaceId) =>
            FormatProjectLocationRepositoryWorkspace(projectId, locationId, repositoryId, workspaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkspaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryWorkspace(string projectId, string locationId, string repositoryId, string workspaceId) =>
            s_projectLocationRepositoryWorkspace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkspaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkspaceName"/> if successful.</returns>
        public static WorkspaceName Parse(string workspaceName) => Parse(workspaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkspaceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkspaceName"/> if successful.</returns>
        public static WorkspaceName Parse(string workspaceName, bool allowUnparsed) =>
            TryParse(workspaceName, allowUnparsed, out WorkspaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkspaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkspaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workspaceName, out WorkspaceName result) => TryParse(workspaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkspaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workspaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkspaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workspaceName, bool allowUnparsed, out WorkspaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(workspaceName, nameof(workspaceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryWorkspace.TryParseName(workspaceName, out resourceName))
            {
                result = FromProjectLocationRepositoryWorkspace(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workspaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkspaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string repositoryId = null, string workspaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
            WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkspaceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workspaces/{workspace}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workspaceId">The <c>Workspace</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkspaceName(string projectId, string locationId, string repositoryId, string workspaceId) : this(ResourceNameType.ProjectLocationRepositoryWorkspace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), workspaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)))
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
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>
        /// The <c>Workspace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkspaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryWorkspace: return s_projectLocationRepositoryWorkspace.Expand(ProjectId, LocationId, RepositoryId, WorkspaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkspaceName);

        /// <inheritdoc/>
        public bool Equals(WorkspaceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WorkspaceName a, WorkspaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WorkspaceName a, WorkspaceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CompilationResult</c> resource.</summary>
    public sealed partial class CompilationResultName : gax::IResourceName, sys::IEquatable<CompilationResultName>
    {
        /// <summary>The possible contents of <see cref="CompilationResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryCompilationResult = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryCompilationResult = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}");

        /// <summary>Creates a <see cref="CompilationResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CompilationResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CompilationResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CompilationResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CompilationResultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="compilationResultId">The <c>CompilationResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompilationResultName"/> constructed from the provided ids.</returns>
        public static CompilationResultName FromProjectLocationRepositoryCompilationResult(string projectId, string locationId, string repositoryId, string compilationResultId) =>
            new CompilationResultName(ResourceNameType.ProjectLocationRepositoryCompilationResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), compilationResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(compilationResultId, nameof(compilationResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompilationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="compilationResultId">The <c>CompilationResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompilationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string compilationResultId) =>
            FormatProjectLocationRepositoryCompilationResult(projectId, locationId, repositoryId, compilationResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompilationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="compilationResultId">The <c>CompilationResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompilationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRepositoryCompilationResult(string projectId, string locationId, string repositoryId, string compilationResultId) =>
            s_projectLocationRepositoryCompilationResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(compilationResultId, nameof(compilationResultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CompilationResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="compilationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CompilationResultName"/> if successful.</returns>
        public static CompilationResultName Parse(string compilationResultName) => Parse(compilationResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CompilationResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="compilationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CompilationResultName"/> if successful.</returns>
        public static CompilationResultName Parse(string compilationResultName, bool allowUnparsed) =>
            TryParse(compilationResultName, allowUnparsed, out CompilationResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CompilationResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="compilationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CompilationResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string compilationResultName, out CompilationResultName result) =>
            TryParse(compilationResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CompilationResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="compilationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CompilationResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string compilationResultName, bool allowUnparsed, out CompilationResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(compilationResultName, nameof(compilationResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryCompilationResult.TryParseName(compilationResultName, out resourceName))
            {
                result = FromProjectLocationRepositoryCompilationResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(compilationResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CompilationResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string compilationResultId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CompilationResultId = compilationResultId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CompilationResultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/compilationResults/{compilation_result}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="compilationResultId">The <c>CompilationResult</c> ID. Must not be <c>null</c> or empty.</param>
        public CompilationResultName(string projectId, string locationId, string repositoryId, string compilationResultId) : this(ResourceNameType.ProjectLocationRepositoryCompilationResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), compilationResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(compilationResultId, nameof(compilationResultId)))
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
        /// The <c>CompilationResult</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CompilationResultId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryCompilationResult: return s_projectLocationRepositoryCompilationResult.Expand(ProjectId, LocationId, RepositoryId, CompilationResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CompilationResultName);

        /// <inheritdoc/>
        public bool Equals(CompilationResultName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CompilationResultName a, CompilationResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CompilationResultName a, CompilationResultName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WorkflowInvocation</c> resource.</summary>
    public sealed partial class WorkflowInvocationName : gax::IResourceName, sys::IEquatable<WorkflowInvocationName>
    {
        /// <summary>The possible contents of <see cref="WorkflowInvocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryWorkflowInvocation = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryWorkflowInvocation = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}");

        /// <summary>Creates a <see cref="WorkflowInvocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkflowInvocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkflowInvocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkflowInvocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkflowInvocationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowInvocationId">
        /// The <c>WorkflowInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="WorkflowInvocationName"/> constructed from the provided ids.</returns>
        public static WorkflowInvocationName FromProjectLocationRepositoryWorkflowInvocation(string projectId, string locationId, string repositoryId, string workflowInvocationId) =>
            new WorkflowInvocationName(ResourceNameType.ProjectLocationRepositoryWorkflowInvocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), workflowInvocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowInvocationId, nameof(workflowInvocationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowInvocationId">
        /// The <c>WorkflowInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string workflowInvocationId) =>
            FormatProjectLocationRepositoryWorkflowInvocation(projectId, locationId, repositoryId, workflowInvocationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowInvocationId">
        /// The <c>WorkflowInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRepositoryWorkflowInvocation(string projectId, string locationId, string repositoryId, string workflowInvocationId) =>
            s_projectLocationRepositoryWorkflowInvocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowInvocationId, nameof(workflowInvocationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowInvocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workflowInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkflowInvocationName"/> if successful.</returns>
        public static WorkflowInvocationName Parse(string workflowInvocationName) => Parse(workflowInvocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowInvocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkflowInvocationName"/> if successful.</returns>
        public static WorkflowInvocationName Parse(string workflowInvocationName, bool allowUnparsed) =>
            TryParse(workflowInvocationName, allowUnparsed, out WorkflowInvocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowInvocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workflowInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowInvocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowInvocationName, out WorkflowInvocationName result) =>
            TryParse(workflowInvocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowInvocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowInvocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowInvocationName, bool allowUnparsed, out WorkflowInvocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(workflowInvocationName, nameof(workflowInvocationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryWorkflowInvocation.TryParseName(workflowInvocationName, out resourceName))
            {
                result = FromProjectLocationRepositoryWorkflowInvocation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workflowInvocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkflowInvocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string repositoryId = null, string workflowInvocationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
            WorkflowInvocationId = workflowInvocationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkflowInvocationName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/workflowInvocations/{workflow_invocation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowInvocationId">
        /// The <c>WorkflowInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public WorkflowInvocationName(string projectId, string locationId, string repositoryId, string workflowInvocationId) : this(ResourceNameType.ProjectLocationRepositoryWorkflowInvocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), workflowInvocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowInvocationId, nameof(workflowInvocationId)))
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
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>
        /// The <c>WorkflowInvocation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string WorkflowInvocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryWorkflowInvocation: return s_projectLocationRepositoryWorkflowInvocation.Expand(ProjectId, LocationId, RepositoryId, WorkflowInvocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkflowInvocationName);

        /// <inheritdoc/>
        public bool Equals(WorkflowInvocationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WorkflowInvocationName a, WorkflowInvocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WorkflowInvocationName a, WorkflowInvocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecretVersion</c> resource.</summary>
    public sealed partial class SecretVersionName : gax::IResourceName, sys::IEquatable<SecretVersionName>
    {
        /// <summary>The possible contents of <see cref="SecretVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
            /// </summary>
            ProjectSecretVersion = 1,
        }

        private static gax::PathTemplate s_projectSecretVersion = new gax::PathTemplate("projects/{project}/secrets/{secret}/versions/{version}");

        /// <summary>Creates a <see cref="SecretVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecretVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecretVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecretVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecretVersionName"/> with the pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecretVersionName"/> constructed from the provided ids.</returns>
        public static SecretVersionName FromProjectSecretVersion(string projectId, string secretId, string versionId) =>
            new SecretVersionName(ResourceNameType.ProjectSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string secretId, string versionId) =>
            FormatProjectSecretVersion(projectId, secretId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectSecretVersion(string projectId, string secretId, string versionId) =>
            s_projectSecretVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName) => Parse(secretVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName, bool allowUnparsed) =>
            TryParse(secretVersionName, allowUnparsed, out SecretVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, out SecretVersionName result) =>
            TryParse(secretVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, bool allowUnparsed, out SecretVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretVersionName, nameof(secretVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSecretVersion.TryParseName(secretVersionName, out resourceName))
            {
                result = FromProjectSecretVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(secretVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecretVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string secretId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SecretId = secretId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecretVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public SecretVersionName(string projectId, string secretId, string versionId) : this(ResourceNameType.ProjectSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Secret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SecretId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSecretVersion: return s_projectSecretVersion.Expand(ProjectId, SecretId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretVersionName);

        /// <inheritdoc/>
        public bool Equals(SecretVersionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SecretVersionName a, SecretVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SecretVersionName a, SecretVersionName b) => !(a == b);
    }

    public partial class Repository
    {
        /// <summary>
        /// <see cref="gcdv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRepositoriesRequest
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

    public partial class GetRepositoryRequest
    {
        /// <summary>
        /// <see cref="gcdv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRepositoryRequest
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

    public partial class DeleteRepositoryRequest
    {
        /// <summary>
        /// <see cref="gcdv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchRemoteBranchesRequest
    {
        /// <summary>
        /// <see cref="gcdv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Workspace
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkspacesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkspaceRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PullGitCommitsRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PushGitCommitsRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchFileGitStatusesRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchGitAheadBehindRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CommitWorkspaceChangesRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResetWorkspaceChangesRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkspaceName WorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchFileDiffRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class QueryDirectoryContentsRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class MakeDirectoryRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class RemoveDirectoryRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class MoveDirectoryRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class ReadFileRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class RemoveFileRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class MoveFileRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class WriteFileRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class InstallNpmPackagesRequest
    {
        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class CompilationResult
    {
        /// <summary>
        /// <see cref="gcdv::CompilationResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CompilationResultName CompilationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CompilationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="WorkspaceName"/>-typed view over the <see cref="Workspace"/> resource name property.
        /// </summary>
        public WorkspaceName WorkspaceAsWorkspaceName
        {
            get => string.IsNullOrEmpty(Workspace) ? null : WorkspaceName.Parse(Workspace, allowUnparsed: true);
            set => Workspace = value?.ToString() ?? "";
        }
    }

    public partial class ListCompilationResultsRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCompilationResultRequest
    {
        /// <summary>
        /// <see cref="gcdv::CompilationResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CompilationResultName CompilationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CompilationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCompilationResultRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class QueryCompilationResultActionsRequest
    {
        /// <summary>
        /// <see cref="gcdv::CompilationResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CompilationResultName CompilationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CompilationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WorkflowInvocation
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowInvocationName WorkflowInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CompilationResultName"/>-typed view over the <see cref="CompilationResult"/> resource name
        /// property.
        /// </summary>
        public CompilationResultName CompilationResultAsCompilationResultName
        {
            get => string.IsNullOrEmpty(CompilationResult) ? null : CompilationResultName.Parse(CompilationResult, allowUnparsed: true);
            set => CompilationResult = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkflowInvocationsRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkflowInvocationRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowInvocationName WorkflowInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkflowInvocationRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkflowInvocationRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowInvocationName WorkflowInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelWorkflowInvocationRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowInvocationName WorkflowInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QueryWorkflowInvocationActionsRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowInvocationName WorkflowInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
