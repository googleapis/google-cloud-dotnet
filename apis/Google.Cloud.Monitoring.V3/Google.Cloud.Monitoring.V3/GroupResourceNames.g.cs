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
using gcmv = Google.Cloud.Monitoring.V3;
using sys = System;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Resource name for the <c>Group</c> resource.</summary>
    public sealed partial class GroupName : gax::IResourceName, sys::IEquatable<GroupName>
    {
        /// <summary>The possible contents of <see cref="GroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/groups/{group}</c>.</summary>
            ProjectGroup = 1,

            /// <summary>A resource name with pattern <c>organizations/{organization}/groups/{group}</c>.</summary>
            OrganizationGroup = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/groups/{group}</c>.</summary>
            FolderGroup = 3,
        }

        private static gax::PathTemplate s_projectGroup = new gax::PathTemplate("projects/{project}/groups/{group}");

        private static gax::PathTemplate s_organizationGroup = new gax::PathTemplate("organizations/{organization}/groups/{group}");

        private static gax::PathTemplate s_folderGroup = new gax::PathTemplate("folders/{folder}/groups/{group}");

        /// <summary>Creates a <see cref="GroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GroupName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GroupName"/> with the pattern <c>projects/{project}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GroupName"/> constructed from the provided ids.</returns>
        public static GroupName FromProjectGroup(string projectId, string groupId) =>
            new GroupName(ResourceNameType.ProjectGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Creates a <see cref="GroupName"/> with the pattern <c>organizations/{organization}/groups/{group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GroupName"/> constructed from the provided ids.</returns>
        public static GroupName FromOrganizationGroup(string organizationId, string groupId) =>
            new GroupName(ResourceNameType.OrganizationGroup, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Creates a <see cref="GroupName"/> with the pattern <c>folders/{folder}/groups/{group}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GroupName"/> constructed from the provided ids.</returns>
        public static GroupName FromFolderGroup(string folderId, string groupId) =>
            new GroupName(ResourceNameType.FolderGroup, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern <c>projects/{project}/groups/{group}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string groupId) => FormatProjectGroup(projectId, groupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>projects/{project}/groups/{group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern <c>projects/{project}/groups/{group}</c>
        /// .
        /// </returns>
        public static string FormatProjectGroup(string projectId, string groupId) =>
            s_projectGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>organizations/{organization}/groups/{group}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern
        /// <c>organizations/{organization}/groups/{group}</c>.
        /// </returns>
        public static string FormatOrganizationGroup(string organizationId, string groupId) =>
            s_organizationGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroupName"/> with pattern
        /// <c>folders/{folder}/groups/{group}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroupName"/> with pattern <c>folders/{folder}/groups/{group}</c>
        /// .
        /// </returns>
        public static string FormatFolderGroup(string folderId, string groupId) =>
            s_folderGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)));

        /// <summary>Parses the given resource name string into a new <see cref="GroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/groups/{group}</c></description></item>
        /// <item><description><c>organizations/{organization}/groups/{group}</c></description></item>
        /// <item><description><c>folders/{folder}/groups/{group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName) => Parse(groupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GroupName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/groups/{group}</c></description></item>
        /// <item><description><c>organizations/{organization}/groups/{group}</c></description></item>
        /// <item><description><c>folders/{folder}/groups/{group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName, bool allowUnparsed) =>
            TryParse(groupName, allowUnparsed, out GroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/groups/{group}</c></description></item>
        /// <item><description><c>organizations/{organization}/groups/{group}</c></description></item>
        /// <item><description><c>folders/{folder}/groups/{group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, out GroupName result) => TryParse(groupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/groups/{group}</c></description></item>
        /// <item><description><c>organizations/{organization}/groups/{group}</c></description></item>
        /// <item><description><c>folders/{folder}/groups/{group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, bool allowUnparsed, out GroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectGroup.TryParseName(groupName, out resourceName))
            {
                result = FromProjectGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationGroup.TryParseName(groupName, out resourceName))
            {
                result = FromOrganizationGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderGroup.TryParseName(groupName, out resourceName))
            {
                result = FromFolderGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(groupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string groupId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            GroupId = groupId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/groups/{group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c> or empty.</param>
        public GroupName(string projectId, string groupId) : this(ResourceNameType.ProjectGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), groupId: gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Group</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string GroupId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectGroup: return s_projectGroup.Expand(ProjectId, GroupId);
                case ResourceNameType.OrganizationGroup: return s_organizationGroup.Expand(OrganizationId, GroupId);
                case ResourceNameType.FolderGroup: return s_folderGroup.Expand(FolderId, GroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GroupName);

        /// <inheritdoc/>
        public bool Equals(GroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GroupName a, GroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GroupName a, GroupName b) => !(a == b);
    }

    public partial class Group
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::GroupName.TryParse(Name, out gcmv::GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }
}
