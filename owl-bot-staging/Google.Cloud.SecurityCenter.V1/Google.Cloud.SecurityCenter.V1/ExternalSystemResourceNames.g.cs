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
using gcsv = Google.Cloud.SecurityCenter.V1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>ExternalSystem</c> resource.</summary>
    public sealed partial class ExternalSystemName : gax::IResourceName, sys::IEquatable<ExternalSystemName>
    {
        /// <summary>The possible contents of <see cref="ExternalSystemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
            /// .
            /// </summary>
            OrganizationSourceFindingExternalsystem = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
            /// </summary>
            FolderSourceFindingExternalsystem = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
            /// </summary>
            ProjectSourceFindingExternalsystem = 3,
        }

        private static gax::PathTemplate s_organizationSourceFindingExternalsystem = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}");

        private static gax::PathTemplate s_folderSourceFindingExternalsystem = new gax::PathTemplate("folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}");

        private static gax::PathTemplate s_projectSourceFindingExternalsystem = new gax::PathTemplate("projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}");

        /// <summary>Creates a <see cref="ExternalSystemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExternalSystemName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExternalSystemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExternalSystemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExternalSystemName"/> with the pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExternalSystemName"/> constructed from the provided ids.</returns>
        public static ExternalSystemName FromOrganizationSourceFindingExternalsystem(string organizationId, string sourceId, string findingId, string externalsystemId) =>
            new ExternalSystemName(ResourceNameType.OrganizationSourceFindingExternalsystem, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), externalsystemId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)));

        /// <summary>
        /// Creates a <see cref="ExternalSystemName"/> with the pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExternalSystemName"/> constructed from the provided ids.</returns>
        public static ExternalSystemName FromFolderSourceFindingExternalsystem(string folderId, string sourceId, string findingId, string externalsystemId) =>
            new ExternalSystemName(ResourceNameType.FolderSourceFindingExternalsystem, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), externalsystemId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)));

        /// <summary>
        /// Creates a <see cref="ExternalSystemName"/> with the pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExternalSystemName"/> constructed from the provided ids.</returns>
        public static ExternalSystemName FromProjectSourceFindingExternalsystem(string projectId, string sourceId, string findingId, string externalsystemId) =>
            new ExternalSystemName(ResourceNameType.ProjectSourceFindingExternalsystem, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), externalsystemId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </returns>
        public static string Format(string organizationId, string sourceId, string findingId, string externalsystemId) =>
            FormatOrganizationSourceFindingExternalsystem(organizationId, sourceId, findingId, externalsystemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </returns>
        public static string FormatOrganizationSourceFindingExternalsystem(string organizationId, string sourceId, string findingId, string externalsystemId) =>
            s_organizationSourceFindingExternalsystem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </returns>
        public static string FormatFolderSourceFindingExternalsystem(string folderId, string sourceId, string findingId, string externalsystemId) =>
            s_folderSourceFindingExternalsystem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExternalSystemName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>.
        /// </returns>
        public static string FormatProjectSourceFindingExternalsystem(string projectId, string sourceId, string findingId, string externalsystemId) =>
            s_projectSourceFindingExternalsystem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalSystemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExternalSystemName"/> if successful.</returns>
        public static ExternalSystemName Parse(string externalSystemName) => Parse(externalSystemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExternalSystemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExternalSystemName"/> if successful.</returns>
        public static ExternalSystemName Parse(string externalSystemName, bool allowUnparsed) =>
            TryParse(externalSystemName, allowUnparsed, out ExternalSystemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalSystemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="externalSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalSystemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalSystemName, out ExternalSystemName result) =>
            TryParse(externalSystemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExternalSystemName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="externalSystemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExternalSystemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string externalSystemName, bool allowUnparsed, out ExternalSystemName result)
        {
            gax::GaxPreconditions.CheckNotNull(externalSystemName, nameof(externalSystemName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSourceFindingExternalsystem.TryParseName(externalSystemName, out resourceName))
            {
                result = FromOrganizationSourceFindingExternalsystem(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderSourceFindingExternalsystem.TryParseName(externalSystemName, out resourceName))
            {
                result = FromFolderSourceFindingExternalsystem(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectSourceFindingExternalsystem.TryParseName(externalSystemName, out resourceName))
            {
                result = FromProjectSourceFindingExternalsystem(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(externalSystemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExternalSystemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string externalsystemId = null, string findingId = null, string folderId = null, string organizationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExternalsystemId = externalsystemId;
            FindingId = findingId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExternalSystemName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}/externalSystems/{externalsystem}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="externalsystemId">The <c>Externalsystem</c> ID. Must not be <c>null</c> or empty.</param>
        public ExternalSystemName(string organizationId, string sourceId, string findingId, string externalsystemId) : this(ResourceNameType.OrganizationSourceFindingExternalsystem, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)), externalsystemId: gax::GaxPreconditions.CheckNotNullOrEmpty(externalsystemId, nameof(externalsystemId)))
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
        /// The <c>Externalsystem</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ExternalsystemId { get; }

        /// <summary>
        /// The <c>Finding</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FindingId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationSourceFindingExternalsystem: return s_organizationSourceFindingExternalsystem.Expand(OrganizationId, SourceId, FindingId, ExternalsystemId);
                case ResourceNameType.FolderSourceFindingExternalsystem: return s_folderSourceFindingExternalsystem.Expand(FolderId, SourceId, FindingId, ExternalsystemId);
                case ResourceNameType.ProjectSourceFindingExternalsystem: return s_projectSourceFindingExternalsystem.Expand(ProjectId, SourceId, FindingId, ExternalsystemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExternalSystemName);

        /// <inheritdoc/>
        public bool Equals(ExternalSystemName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExternalSystemName a, ExternalSystemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExternalSystemName a, ExternalSystemName b) => !(a == b);
    }

    public partial class ExternalSystem
    {
        /// <summary>
        /// <see cref="gcsv::ExternalSystemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ExternalSystemName ExternalSystemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ExternalSystemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
