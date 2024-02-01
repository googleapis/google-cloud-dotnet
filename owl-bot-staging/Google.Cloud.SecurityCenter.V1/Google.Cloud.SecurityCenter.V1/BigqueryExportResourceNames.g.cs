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
    /// <summary>Resource name for the <c>BigQueryExport</c> resource.</summary>
    public sealed partial class BigQueryExportName : gax::IResourceName, sys::IEquatable<BigQueryExportName>
    {
        /// <summary>The possible contents of <see cref="BigQueryExportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/bigQueryExports/{export}</c>.
            /// </summary>
            OrganizationExport = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/bigQueryExports/{export}</c>.</summary>
            FolderExport = 2,

            /// <summary>A resource name with pattern <c>projects/{project}/bigQueryExports/{export}</c>.</summary>
            ProjectExport = 3,
        }

        private static gax::PathTemplate s_organizationExport = new gax::PathTemplate("organizations/{organization}/bigQueryExports/{export}");

        private static gax::PathTemplate s_folderExport = new gax::PathTemplate("folders/{folder}/bigQueryExports/{export}");

        private static gax::PathTemplate s_projectExport = new gax::PathTemplate("projects/{project}/bigQueryExports/{export}");

        /// <summary>Creates a <see cref="BigQueryExportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BigQueryExportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BigQueryExportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BigQueryExportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BigQueryExportName"/> with the pattern
        /// <c>organizations/{organization}/bigQueryExports/{export}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BigQueryExportName"/> constructed from the provided ids.</returns>
        public static BigQueryExportName FromOrganizationExport(string organizationId, string exportId) =>
            new BigQueryExportName(ResourceNameType.OrganizationExport, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), exportId: gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)));

        /// <summary>
        /// Creates a <see cref="BigQueryExportName"/> with the pattern <c>folders/{folder}/bigQueryExports/{export}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BigQueryExportName"/> constructed from the provided ids.</returns>
        public static BigQueryExportName FromFolderExport(string folderId, string exportId) =>
            new BigQueryExportName(ResourceNameType.FolderExport, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), exportId: gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)));

        /// <summary>
        /// Creates a <see cref="BigQueryExportName"/> with the pattern <c>projects/{project}/bigQueryExports/{export}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BigQueryExportName"/> constructed from the provided ids.</returns>
        public static BigQueryExportName FromProjectExport(string projectId, string exportId) =>
            new BigQueryExportName(ResourceNameType.ProjectExport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), exportId: gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>organizations/{organization}/bigQueryExports/{export}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>organizations/{organization}/bigQueryExports/{export}</c>.
        /// </returns>
        public static string Format(string organizationId, string exportId) =>
            FormatOrganizationExport(organizationId, exportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>organizations/{organization}/bigQueryExports/{export}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>organizations/{organization}/bigQueryExports/{export}</c>.
        /// </returns>
        public static string FormatOrganizationExport(string organizationId, string exportId) =>
            s_organizationExport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>folders/{folder}/bigQueryExports/{export}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>folders/{folder}/bigQueryExports/{export}</c>.
        /// </returns>
        public static string FormatFolderExport(string folderId, string exportId) =>
            s_folderExport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>projects/{project}/bigQueryExports/{export}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BigQueryExportName"/> with pattern
        /// <c>projects/{project}/bigQueryExports/{export}</c>.
        /// </returns>
        public static string FormatProjectExport(string projectId, string exportId) =>
            s_projectExport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BigQueryExportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>folders/{folder}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>projects/{project}/bigQueryExports/{export}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bigQueryExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BigQueryExportName"/> if successful.</returns>
        public static BigQueryExportName Parse(string bigQueryExportName) => Parse(bigQueryExportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BigQueryExportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>folders/{folder}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>projects/{project}/bigQueryExports/{export}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bigQueryExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BigQueryExportName"/> if successful.</returns>
        public static BigQueryExportName Parse(string bigQueryExportName, bool allowUnparsed) =>
            TryParse(bigQueryExportName, allowUnparsed, out BigQueryExportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BigQueryExportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>folders/{folder}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>projects/{project}/bigQueryExports/{export}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bigQueryExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BigQueryExportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bigQueryExportName, out BigQueryExportName result) =>
            TryParse(bigQueryExportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BigQueryExportName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>folders/{folder}/bigQueryExports/{export}</c></description></item>
        /// <item><description><c>projects/{project}/bigQueryExports/{export}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bigQueryExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BigQueryExportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bigQueryExportName, bool allowUnparsed, out BigQueryExportName result)
        {
            gax::GaxPreconditions.CheckNotNull(bigQueryExportName, nameof(bigQueryExportName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationExport.TryParseName(bigQueryExportName, out resourceName))
            {
                result = FromOrganizationExport(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderExport.TryParseName(bigQueryExportName, out resourceName))
            {
                result = FromFolderExport(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectExport.TryParseName(bigQueryExportName, out resourceName))
            {
                result = FromProjectExport(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bigQueryExportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BigQueryExportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string exportId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExportId = exportId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BigQueryExportName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/bigQueryExports/{export}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exportId">The <c>Export</c> ID. Must not be <c>null</c> or empty.</param>
        public BigQueryExportName(string organizationId, string exportId) : this(ResourceNameType.OrganizationExport, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), exportId: gax::GaxPreconditions.CheckNotNullOrEmpty(exportId, nameof(exportId)))
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
        /// The <c>Export</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ExportId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationExport: return s_organizationExport.Expand(OrganizationId, ExportId);
                case ResourceNameType.FolderExport: return s_folderExport.Expand(FolderId, ExportId);
                case ResourceNameType.ProjectExport: return s_projectExport.Expand(ProjectId, ExportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BigQueryExportName);

        /// <inheritdoc/>
        public bool Equals(BigQueryExportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BigQueryExportName a, BigQueryExportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BigQueryExportName a, BigQueryExportName b) => !(a == b);
    }

    public partial class BigQueryExport
    {
        /// <summary>
        /// <see cref="gcsv::BigQueryExportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BigQueryExportName BigQueryExportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BigQueryExportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
