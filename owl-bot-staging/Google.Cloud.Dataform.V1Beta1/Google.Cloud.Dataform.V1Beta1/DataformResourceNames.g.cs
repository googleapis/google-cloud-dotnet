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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkspaceName a, WorkspaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkspaceName a, WorkspaceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReleaseConfig</c> resource.</summary>
    public sealed partial class ReleaseConfigName : gax::IResourceName, sys::IEquatable<ReleaseConfigName>
    {
        /// <summary>The possible contents of <see cref="ReleaseConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryReleaseConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryReleaseConfig = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}");

        /// <summary>Creates a <see cref="ReleaseConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReleaseConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReleaseConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReleaseConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReleaseConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseConfigId">The <c>ReleaseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReleaseConfigName"/> constructed from the provided ids.</returns>
        public static ReleaseConfigName FromProjectLocationRepositoryReleaseConfig(string projectId, string locationId, string repositoryId, string releaseConfigId) =>
            new ReleaseConfigName(ResourceNameType.ProjectLocationRepositoryReleaseConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), releaseConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseConfigId">The <c>ReleaseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string releaseConfigId) =>
            FormatProjectLocationRepositoryReleaseConfig(projectId, locationId, repositoryId, releaseConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseConfigId">The <c>ReleaseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryReleaseConfig(string projectId, string locationId, string repositoryId, string releaseConfigId) =>
            s_projectLocationRepositoryReleaseConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReleaseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="releaseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReleaseConfigName"/> if successful.</returns>
        public static ReleaseConfigName Parse(string releaseConfigName) => Parse(releaseConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReleaseConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReleaseConfigName"/> if successful.</returns>
        public static ReleaseConfigName Parse(string releaseConfigName, bool allowUnparsed) =>
            TryParse(releaseConfigName, allowUnparsed, out ReleaseConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="releaseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseConfigName, out ReleaseConfigName result) =>
            TryParse(releaseConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseConfigName, bool allowUnparsed, out ReleaseConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(releaseConfigName, nameof(releaseConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryReleaseConfig.TryParseName(releaseConfigName, out resourceName))
            {
                result = FromProjectLocationRepositoryReleaseConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(releaseConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReleaseConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string releaseConfigId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseConfigId = releaseConfigId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReleaseConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/releaseConfigs/{release_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseConfigId">The <c>ReleaseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ReleaseConfigName(string projectId, string locationId, string repositoryId, string releaseConfigId) : this(ResourceNameType.ProjectLocationRepositoryReleaseConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), releaseConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)))
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
        /// The <c>ReleaseConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReleaseConfigId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryReleaseConfig: return s_projectLocationRepositoryReleaseConfig.Expand(ProjectId, LocationId, RepositoryId, ReleaseConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReleaseConfigName);

        /// <inheritdoc/>
        public bool Equals(ReleaseConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReleaseConfigName a, ReleaseConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReleaseConfigName a, ReleaseConfigName b) => !(a == b);
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CompilationResultName a, CompilationResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CompilationResultName a, CompilationResultName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WorkflowConfig</c> resource.</summary>
    public sealed partial class WorkflowConfigName : gax::IResourceName, sys::IEquatable<WorkflowConfigName>
    {
        /// <summary>The possible contents of <see cref="WorkflowConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryWorkflowConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryWorkflowConfig = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}");

        /// <summary>Creates a <see cref="WorkflowConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkflowConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkflowConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkflowConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkflowConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowConfigId">The <c>WorkflowConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkflowConfigName"/> constructed from the provided ids.</returns>
        public static WorkflowConfigName FromProjectLocationRepositoryWorkflowConfig(string projectId, string locationId, string repositoryId, string workflowConfigId) =>
            new WorkflowConfigName(ResourceNameType.ProjectLocationRepositoryWorkflowConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), workflowConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowConfigId">The <c>WorkflowConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string workflowConfigId) =>
            FormatProjectLocationRepositoryWorkflowConfig(projectId, locationId, repositoryId, workflowConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowConfigId">The <c>WorkflowConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryWorkflowConfig(string projectId, string locationId, string repositoryId, string workflowConfigId) =>
            s_projectLocationRepositoryWorkflowConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workflowConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkflowConfigName"/> if successful.</returns>
        public static WorkflowConfigName Parse(string workflowConfigName) => Parse(workflowConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkflowConfigName"/> if successful.</returns>
        public static WorkflowConfigName Parse(string workflowConfigName, bool allowUnparsed) =>
            TryParse(workflowConfigName, allowUnparsed, out WorkflowConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workflowConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowConfigName, out WorkflowConfigName result) =>
            TryParse(workflowConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowConfigName, bool allowUnparsed, out WorkflowConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(workflowConfigName, nameof(workflowConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryWorkflowConfig.TryParseName(workflowConfigName, out resourceName))
            {
                result = FromProjectLocationRepositoryWorkflowConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workflowConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkflowConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string repositoryId = null, string workflowConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
            WorkflowConfigId = workflowConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkflowConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/workflowConfigs/{workflow_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowConfigId">The <c>WorkflowConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkflowConfigName(string projectId, string locationId, string repositoryId, string workflowConfigId) : this(ResourceNameType.ProjectLocationRepositoryWorkflowConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), workflowConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)))
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
        /// The <c>WorkflowConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WorkflowConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryWorkflowConfig: return s_projectLocationRepositoryWorkflowConfig.Expand(ProjectId, LocationId, RepositoryId, WorkflowConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkflowConfigName);

        /// <inheritdoc/>
        public bool Equals(WorkflowConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkflowConfigName a, WorkflowConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkflowConfigName a, WorkflowConfigName b) => !(a == b);
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkflowInvocationName a, WorkflowInvocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecretVersionName a, SecretVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="NpmrcEnvironmentVariablesSecretVersion"/>
        /// resource name property.
        /// </summary>
        public SecretVersionName NpmrcEnvironmentVariablesSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(NpmrcEnvironmentVariablesSecretVersion) ? null : SecretVersionName.Parse(NpmrcEnvironmentVariablesSecretVersion, allowUnparsed: true);
            set => NpmrcEnvironmentVariablesSecretVersion = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class GitRemoteSettings
            {
                /// <summary>
                /// <see cref="SecretVersionName"/>-typed view over the <see cref="AuthenticationTokenSecretVersion"/>
                /// resource name property.
                /// </summary>
                public SecretVersionName AuthenticationTokenSecretVersionAsSecretVersionName
                {
                    get => string.IsNullOrEmpty(AuthenticationTokenSecretVersion) ? null : SecretVersionName.Parse(AuthenticationTokenSecretVersion, allowUnparsed: true);
                    set => AuthenticationTokenSecretVersion = value?.ToString() ?? "";
                }

                public partial class Types
                {
                    public partial class SshAuthenticationConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the
                        /// <see cref="UserPrivateKeySecretVersion"/> resource name property.
                        /// </summary>
                        public SecretVersionName UserPrivateKeySecretVersionAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(UserPrivateKeySecretVersion) ? null : SecretVersionName.Parse(UserPrivateKeySecretVersion, allowUnparsed: true);
                            set => UserPrivateKeySecretVersion = value?.ToString() ?? "";
                        }
                    }
                }
            }
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

    public partial class CommitRepositoryChangesRequest
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

    public partial class ReadRepositoryFileRequest
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

    public partial class QueryRepositoryDirectoryContentsRequest
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

    public partial class FetchRepositoryHistoryRequest
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

    public partial class ComputeRepositoryAccessTokenStatusRequest
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

    public partial class ReleaseConfig
    {
        /// <summary>
        /// <see cref="gcdv::ReleaseConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ReleaseConfigName ReleaseConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ReleaseConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CompilationResultName"/>-typed view over the <see cref="ReleaseCompilationResult"/> resource name
        /// property.
        /// </summary>
        public CompilationResultName ReleaseCompilationResultAsCompilationResultName
        {
            get => string.IsNullOrEmpty(ReleaseCompilationResult) ? null : CompilationResultName.Parse(ReleaseCompilationResult, allowUnparsed: true);
            set => ReleaseCompilationResult = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ScheduledReleaseRecord
            {
                /// <summary>
                /// <see cref="CompilationResultName"/>-typed view over the <see cref="CompilationResult"/> resource
                /// name property.
                /// </summary>
                public CompilationResultName CompilationResultAsCompilationResultName
                {
                    get => string.IsNullOrEmpty(CompilationResult) ? null : CompilationResultName.Parse(CompilationResult, allowUnparsed: true);
                    set => CompilationResult = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListReleaseConfigsRequest
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

    public partial class GetReleaseConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::ReleaseConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ReleaseConfigName ReleaseConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ReleaseConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReleaseConfigRequest
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

    public partial class DeleteReleaseConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::ReleaseConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ReleaseConfigName ReleaseConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ReleaseConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
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

        /// <summary>
        /// <see cref="ReleaseConfigName"/>-typed view over the <see cref="ReleaseConfig"/> resource name property.
        /// </summary>
        public ReleaseConfigName ReleaseConfigAsReleaseConfigName
        {
            get => string.IsNullOrEmpty(ReleaseConfig) ? null : ReleaseConfigName.Parse(ReleaseConfig, allowUnparsed: true);
            set => ReleaseConfig = value?.ToString() ?? "";
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

    public partial class WorkflowConfig
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowConfigName WorkflowConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReleaseConfigName"/>-typed view over the <see cref="ReleaseConfig"/> resource name property.
        /// </summary>
        public ReleaseConfigName ReleaseConfigAsReleaseConfigName
        {
            get => string.IsNullOrEmpty(ReleaseConfig) ? null : ReleaseConfigName.Parse(ReleaseConfig, allowUnparsed: true);
            set => ReleaseConfig = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ScheduledExecutionRecord
            {
                /// <summary>
                /// <see cref="WorkflowInvocationName"/>-typed view over the <see cref="WorkflowInvocation"/> resource
                /// name property.
                /// </summary>
                public WorkflowInvocationName WorkflowInvocationAsWorkflowInvocationName
                {
                    get => string.IsNullOrEmpty(WorkflowInvocation) ? null : WorkflowInvocationName.Parse(WorkflowInvocation, allowUnparsed: true);
                    set => WorkflowInvocation = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListWorkflowConfigsRequest
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

    public partial class GetWorkflowConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowConfigName WorkflowConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWorkflowConfigRequest
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

    public partial class DeleteWorkflowConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowConfigName WorkflowConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowConfigName.Parse(Name, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="WorkflowConfigName"/>-typed view over the <see cref="WorkflowConfig"/> resource name property.
        /// </summary>
        public WorkflowConfigName WorkflowConfigAsWorkflowConfigName
        {
            get => string.IsNullOrEmpty(WorkflowConfig) ? null : WorkflowConfigName.Parse(WorkflowConfig, allowUnparsed: true);
            set => WorkflowConfig = value?.ToString() ?? "";
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
