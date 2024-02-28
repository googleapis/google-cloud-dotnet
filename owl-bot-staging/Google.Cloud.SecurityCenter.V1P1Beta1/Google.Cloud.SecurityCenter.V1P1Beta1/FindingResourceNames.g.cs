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
using gcsv = Google.Cloud.SecurityCenter.V1P1Beta1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1P1Beta1
{
    /// <summary>Resource name for the <c>Finding</c> resource.</summary>
    public sealed partial class FindingName : gax::IResourceName, sys::IEquatable<FindingName>
    {
        /// <summary>The possible contents of <see cref="FindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
            /// </summary>
            OrganizationSourceFinding = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/sources/{source}/findings/{finding}</c>.
            /// </summary>
            FolderSourceFinding = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/sources/{source}/findings/{finding}</c>.
            /// </summary>
            ProjectSourceFinding = 3,
        }

        private static gax::PathTemplate s_organizationSourceFinding = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}");

        private static gax::PathTemplate s_folderSourceFinding = new gax::PathTemplate("folders/{folder}/sources/{source}/findings/{finding}");

        private static gax::PathTemplate s_projectSourceFinding = new gax::PathTemplate("projects/{project}/sources/{source}/findings/{finding}");

        /// <summary>Creates a <see cref="FindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FindingName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromOrganizationSourceFinding(string organizationId, string sourceId, string findingId) =>
            new FindingName(ResourceNameType.OrganizationSourceFinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern <c>folders/{folder}/sources/{source}/findings/{finding}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromFolderSourceFinding(string folderId, string sourceId, string findingId) =>
            new FindingName(ResourceNameType.FolderSourceFinding, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromProjectSourceFinding(string projectId, string sourceId, string findingId) =>
            new FindingName(ResourceNameType.ProjectSourceFinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string Format(string organizationId, string sourceId, string findingId) =>
            FormatOrganizationSourceFinding(organizationId, sourceId, findingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string FormatOrganizationSourceFinding(string organizationId, string sourceId, string findingId) =>
            s_organizationSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string FormatFolderSourceFinding(string folderId, string sourceId, string findingId) =>
            s_folderSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string FormatProjectSourceFinding(string projectId, string sourceId, string findingId) =>
            s_projectSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>Parses the given resource name string into a new <see cref="FindingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName) => Parse(findingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName, bool allowUnparsed) =>
            TryParse(findingName, allowUnparsed, out FindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, out FindingName result) => TryParse(findingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, bool allowUnparsed, out FindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSourceFinding.TryParseName(findingName, out resourceName))
            {
                result = FromOrganizationSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderSourceFinding.TryParseName(findingName, out resourceName))
            {
                result = FromFolderSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectSourceFinding.TryParseName(findingName, out resourceName))
            {
                result = FromProjectSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(findingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string findingId = null, string folderId = null, string organizationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FindingId = findingId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FindingName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        public FindingName(string organizationId, string sourceId, string findingId) : this(ResourceNameType.OrganizationSourceFinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)))
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
                case ResourceNameType.OrganizationSourceFinding: return s_organizationSourceFinding.Expand(OrganizationId, SourceId, FindingId);
                case ResourceNameType.FolderSourceFinding: return s_folderSourceFinding.Expand(FolderId, SourceId, FindingId);
                case ResourceNameType.ProjectSourceFinding: return s_projectSourceFinding.Expand(ProjectId, SourceId, FindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingName);

        /// <inheritdoc/>
        public bool Equals(FindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FindingName a, FindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FindingName a, FindingName b) => !(a == b);
    }

    public partial class Finding
    {
        /// <summary>
        /// <see cref="gcsv::FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::FindingName FindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::FindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
