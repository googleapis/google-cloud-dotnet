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
using gax = Google.Api.Gax;
using gcsv = Google.Cloud.SecurityCenter.V2;
using sys = System;

namespace Google.Cloud.SecurityCenter.V2
{
    /// <summary>Resource name for the <c>Source</c> resource.</summary>
    public sealed partial class SourceName : gax::IResourceName, sys::IEquatable<SourceName>
    {
        /// <summary>The possible contents of <see cref="SourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>organizations/{organization}/sources/{source}</c>.</summary>
            OrganizationSource = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/sources/{source}</c>.</summary>
            FolderSource = 2,

            /// <summary>A resource name with pattern <c>projects/{project}/sources/{source}</c>.</summary>
            ProjectSource = 3,
        }

        private static gax::PathTemplate s_organizationSource = new gax::PathTemplate("organizations/{organization}/sources/{source}");

        private static gax::PathTemplate s_folderSource = new gax::PathTemplate("folders/{folder}/sources/{source}");

        private static gax::PathTemplate s_projectSource = new gax::PathTemplate("projects/{project}/sources/{source}");

        /// <summary>Creates a <see cref="SourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SourceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SourceName"/> with the pattern <c>organizations/{organization}/sources/{source}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SourceName"/> constructed from the provided ids.</returns>
        public static SourceName FromOrganizationSource(string organizationId, string sourceId) =>
            new SourceName(ResourceNameType.OrganizationSource, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Creates a <see cref="SourceName"/> with the pattern <c>folders/{folder}/sources/{source}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SourceName"/> constructed from the provided ids.</returns>
        public static SourceName FromFolderSource(string folderId, string sourceId) =>
            new SourceName(ResourceNameType.FolderSource, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Creates a <see cref="SourceName"/> with the pattern <c>projects/{project}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SourceName"/> constructed from the provided ids.</returns>
        public static SourceName FromProjectSource(string projectId, string sourceId) =>
            new SourceName(ResourceNameType.ProjectSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}</c>.
        /// </returns>
        public static string Format(string organizationId, string sourceId) =>
            FormatOrganizationSource(organizationId, sourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}</c>.
        /// </returns>
        public static string FormatOrganizationSource(string organizationId, string sourceId) =>
            s_organizationSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>folders/{folder}/sources/{source}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern <c>folders/{folder}/sources/{source}</c>
        /// .
        /// </returns>
        public static string FormatFolderSource(string folderId, string sourceId) =>
            s_folderSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/sources/{source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SourceName"/> with pattern
        /// <c>projects/{project}/sources/{source}</c>.
        /// </returns>
        public static string FormatProjectSource(string projectId, string sourceId) =>
            s_projectSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="SourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/sources/{source}</c></description></item>
        /// <item><description><c>folders/{folder}/sources/{source}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName) => Parse(sourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SourceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/sources/{source}</c></description></item>
        /// <item><description><c>folders/{folder}/sources/{source}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SourceName"/> if successful.</returns>
        public static SourceName Parse(string sourceName, bool allowUnparsed) =>
            TryParse(sourceName, allowUnparsed, out SourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/sources/{source}</c></description></item>
        /// <item><description><c>folders/{folder}/sources/{source}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, out SourceName result) => TryParse(sourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/sources/{source}</c></description></item>
        /// <item><description><c>folders/{folder}/sources/{source}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sourceName, bool allowUnparsed, out SourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(sourceName, nameof(sourceName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSource.TryParseName(sourceName, out resourceName))
            {
                result = FromOrganizationSource(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderSource.TryParseName(sourceName, out resourceName))
            {
                result = FromFolderSource(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectSource.TryParseName(sourceName, out resourceName))
            {
                result = FromProjectSource(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SourceName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/sources/{source}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        public SourceName(string organizationId, string sourceId) : this(ResourceNameType.OrganizationSource, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)))
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
                case ResourceNameType.OrganizationSource: return s_organizationSource.Expand(OrganizationId, SourceId);
                case ResourceNameType.FolderSource: return s_folderSource.Expand(FolderId, SourceId);
                case ResourceNameType.ProjectSource: return s_projectSource.Expand(ProjectId, SourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SourceName);

        /// <inheritdoc/>
        public bool Equals(SourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SourceName a, SourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SourceName a, SourceName b) => !(a == b);
    }

    public partial class Source
    {
        /// <summary>
        /// <see cref="gcsv::SourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SourceName SourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
