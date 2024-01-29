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
    /// <summary>Resource name for the <c>EffectiveSecurityHealthAnalyticsCustomModule</c> resource.</summary>
    public sealed partial class EffectiveSecurityHealthAnalyticsCustomModuleName : gax::IResourceName, sys::IEquatable<EffectiveSecurityHealthAnalyticsCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
            /// .
            /// </summary>
            OrganizationEffectiveCustomModule = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
            /// .
            /// </summary>
            FolderEffectiveCustomModule = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
            /// .
            /// </summary>
            ProjectEffectiveCustomModule = 3,
        }

        private static gax::PathTemplate s_organizationEffectiveCustomModule = new gax::PathTemplate("organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}");

        private static gax::PathTemplate s_folderEffectiveCustomModule = new gax::PathTemplate("folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}");

        private static gax::PathTemplate s_projectEffectiveCustomModule = new gax::PathTemplate("projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}");

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> containing an unparsed resource
        /// name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromOrganizationEffectiveCustomModule(string organizationId, string effectiveCustomModuleId) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.OrganizationEffectiveCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), effectiveCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromFolderEffectiveCustomModule(string folderId, string effectiveCustomModuleId) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.FolderEffectiveCustomModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), effectiveCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromProjectEffectiveCustomModule(string projectId, string effectiveCustomModuleId) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.ProjectEffectiveCustomModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), effectiveCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string effectiveCustomModuleId) =>
            FormatOrganizationEffectiveCustomModule(organizationId, effectiveCustomModuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationEffectiveCustomModule(string organizationId, string effectiveCustomModuleId) =>
            s_organizationEffectiveCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatFolderEffectiveCustomModule(string folderId, string effectiveCustomModuleId) =>
            s_folderEffectiveCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>.
        /// </returns>
        public static string FormatProjectEffectiveCustomModule(string projectId, string effectiveCustomModuleId) =>
            s_projectEffectiveCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)));

        /// <summary>
        /// Parses the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName Parse(string effectiveSecurityHealthAnalyticsCustomModuleName) =>
            Parse(effectiveSecurityHealthAnalyticsCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName Parse(string effectiveSecurityHealthAnalyticsCustomModuleName, bool allowUnparsed) =>
            TryParse(effectiveSecurityHealthAnalyticsCustomModuleName, allowUnparsed, out EffectiveSecurityHealthAnalyticsCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/>, or
        /// <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string effectiveSecurityHealthAnalyticsCustomModuleName, out EffectiveSecurityHealthAnalyticsCustomModuleName result) =>
            TryParse(effectiveSecurityHealthAnalyticsCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/>, or
        /// <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string effectiveSecurityHealthAnalyticsCustomModuleName, bool allowUnparsed, out EffectiveSecurityHealthAnalyticsCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(effectiveSecurityHealthAnalyticsCustomModuleName, nameof(effectiveSecurityHealthAnalyticsCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationEffectiveCustomModule.TryParseName(effectiveSecurityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromOrganizationEffectiveCustomModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderEffectiveCustomModule.TryParseName(effectiveSecurityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromFolderEffectiveCustomModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectEffectiveCustomModule.TryParseName(effectiveSecurityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromProjectEffectiveCustomModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(effectiveSecurityHealthAnalyticsCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string effectiveCustomModuleId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EffectiveCustomModuleId = effectiveCustomModuleId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> class from the
        /// component parts of pattern
        /// <c>
        /// organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{effective_custom_module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveCustomModuleId">
        /// The <c>EffectiveCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public EffectiveSecurityHealthAnalyticsCustomModuleName(string organizationId, string effectiveCustomModuleId) : this(ResourceNameType.OrganizationEffectiveCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), effectiveCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveCustomModuleId, nameof(effectiveCustomModuleId)))
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
        /// The <c>EffectiveCustomModule</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string EffectiveCustomModuleId { get; }

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
                case ResourceNameType.OrganizationEffectiveCustomModule: return s_organizationEffectiveCustomModule.Expand(OrganizationId, EffectiveCustomModuleId);
                case ResourceNameType.FolderEffectiveCustomModule: return s_folderEffectiveCustomModule.Expand(FolderId, EffectiveCustomModuleId);
                case ResourceNameType.ProjectEffectiveCustomModule: return s_projectEffectiveCustomModule.Expand(ProjectId, EffectiveCustomModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EffectiveSecurityHealthAnalyticsCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(EffectiveSecurityHealthAnalyticsCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EffectiveSecurityHealthAnalyticsCustomModuleName a, EffectiveSecurityHealthAnalyticsCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EffectiveSecurityHealthAnalyticsCustomModuleName a, EffectiveSecurityHealthAnalyticsCustomModuleName b) => !(a == b);
    }

    public partial class EffectiveSecurityHealthAnalyticsCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName EffectiveSecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
