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
using gcrv = Google.Cloud.ResourceSettings.V1;
using sys = System;

namespace Google.Cloud.ResourceSettings.V1
{
    /// <summary>Resource name for the <c>Setting</c> resource.</summary>
    public sealed partial class SettingName : gax::IResourceName, sys::IEquatable<SettingName>
    {
        /// <summary>The possible contents of <see cref="SettingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project_number}/settings/{setting_name}</c>.
            /// </summary>
            ProjectNumberSettingName = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/settings/{setting_name}</c>.</summary>
            FolderSettingName = 2,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/settings/{setting_name}</c>.
            /// </summary>
            OrganizationSettingName = 3,
        }

        private static gax::PathTemplate s_projectNumberSettingName = new gax::PathTemplate("projects/{project_number}/settings/{setting_name}");

        private static gax::PathTemplate s_folderSettingName = new gax::PathTemplate("folders/{folder}/settings/{setting_name}");

        private static gax::PathTemplate s_organizationSettingName = new gax::PathTemplate("organizations/{organization}/settings/{setting_name}");

        /// <summary>Creates a <see cref="SettingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SettingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SettingName"/> with the pattern <c>projects/{project_number}/settings/{setting_name}</c>
        /// .
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingName"/> constructed from the provided ids.</returns>
        public static SettingName FromProjectNumberSettingName(string projectNumberId, string settingNameId) =>
            new SettingName(ResourceNameType.ProjectNumberSettingName, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), settingNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)));

        /// <summary>
        /// Creates a <see cref="SettingName"/> with the pattern <c>folders/{folder}/settings/{setting_name}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingName"/> constructed from the provided ids.</returns>
        public static SettingName FromFolderSettingName(string folderId, string settingNameId) =>
            new SettingName(ResourceNameType.FolderSettingName, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), settingNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)));

        /// <summary>
        /// Creates a <see cref="SettingName"/> with the pattern <c>organizations/{organization}/settings/{setting_name}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingName"/> constructed from the provided ids.</returns>
        public static SettingName FromOrganizationSettingName(string organizationId, string settingNameId) =>
            new SettingName(ResourceNameType.OrganizationSettingName, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), settingNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingName"/> with pattern
        /// <c>projects/{project_number}/settings/{setting_name}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingName"/> with pattern
        /// <c>projects/{project_number}/settings/{setting_name}</c>.
        /// </returns>
        public static string Format(string projectNumberId, string settingNameId) =>
            FormatProjectNumberSettingName(projectNumberId, settingNameId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingName"/> with pattern
        /// <c>projects/{project_number}/settings/{setting_name}</c>.
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingName"/> with pattern
        /// <c>projects/{project_number}/settings/{setting_name}</c>.
        /// </returns>
        public static string FormatProjectNumberSettingName(string projectNumberId, string settingNameId) =>
            s_projectNumberSettingName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingName"/> with pattern
        /// <c>folders/{folder}/settings/{setting_name}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingName"/> with pattern
        /// <c>folders/{folder}/settings/{setting_name}</c>.
        /// </returns>
        public static string FormatFolderSettingName(string folderId, string settingNameId) =>
            s_folderSettingName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingName"/> with pattern
        /// <c>organizations/{organization}/settings/{setting_name}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingName"/> with pattern
        /// <c>organizations/{organization}/settings/{setting_name}</c>.
        /// </returns>
        public static string FormatOrganizationSettingName(string organizationId, string settingNameId) =>
            s_organizationSettingName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_number}/settings/{setting_name}</c></description></item>
        /// <item><description><c>folders/{folder}/settings/{setting_name}</c></description></item>
        /// <item><description><c>organizations/{organization}/settings/{setting_name}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingName"/> if successful.</returns>
        public static SettingName Parse(string settingName) => Parse(settingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_number}/settings/{setting_name}</c></description></item>
        /// <item><description><c>folders/{folder}/settings/{setting_name}</c></description></item>
        /// <item><description><c>organizations/{organization}/settings/{setting_name}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingName"/> if successful.</returns>
        public static SettingName Parse(string settingName, bool allowUnparsed) =>
            TryParse(settingName, allowUnparsed, out SettingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_number}/settings/{setting_name}</c></description></item>
        /// <item><description><c>folders/{folder}/settings/{setting_name}</c></description></item>
        /// <item><description><c>organizations/{organization}/settings/{setting_name}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingName, out SettingName result) => TryParse(settingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_number}/settings/{setting_name}</c></description></item>
        /// <item><description><c>folders/{folder}/settings/{setting_name}</c></description></item>
        /// <item><description><c>organizations/{organization}/settings/{setting_name}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingName, bool allowUnparsed, out SettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingName, nameof(settingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumberSettingName.TryParseName(settingName, out resourceName))
            {
                result = FromProjectNumberSettingName(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderSettingName.TryParseName(settingName, out resourceName))
            {
                result = FromFolderSettingName(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationSettingName.TryParseName(settingName, out resourceName))
            {
                result = FromOrganizationSettingName(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectNumberId = null, string settingNameId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectNumberId = projectNumberId;
            SettingNameId = settingNameId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingName"/> class from the component parts of pattern
        /// <c>projects/{project_number}/settings/{setting_name}</c>
        /// </summary>
        /// <param name="projectNumberId">The <c>ProjectNumber</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="settingNameId">The <c>SettingName</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingName(string projectNumberId, string settingNameId) : this(ResourceNameType.ProjectNumberSettingName, projectNumberId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumberId, nameof(projectNumberId)), settingNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(settingNameId, nameof(settingNameId)))
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
        /// The <c>ProjectNumber</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ProjectNumberId { get; }

        /// <summary>
        /// The <c>SettingName</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string SettingNameId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumberSettingName: return s_projectNumberSettingName.Expand(ProjectNumberId, SettingNameId);
                case ResourceNameType.FolderSettingName: return s_folderSettingName.Expand(FolderId, SettingNameId);
                case ResourceNameType.OrganizationSettingName: return s_organizationSettingName.Expand(OrganizationId, SettingNameId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingName);

        /// <inheritdoc/>
        public bool Equals(SettingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingName a, SettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingName a, SettingName b) => !(a == b);
    }

    public partial class Setting
    {
        /// <summary>
        /// <see cref="gcrv::SettingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::SettingName SettingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::SettingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSettingsRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gax::UnparsedResourceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSettingRequest
    {
        /// <summary>
        /// <see cref="gcrv::SettingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::SettingName SettingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::SettingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
