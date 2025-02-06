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
using gcsv = Google.Cloud.SecurityCenter.V1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>EventThreatDetectionCustomModule</c> resource.</summary>
    public sealed partial class EventThreatDetectionCustomModuleName : gax::IResourceName, sys::IEquatable<EventThreatDetectionCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="EventThreatDetectionCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>.
            /// </summary>
            OrganizationModule = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c>
            /// .
            /// </summary>
            FolderModule = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c>
            /// .
            /// </summary>
            ProjectModule = 3,
        }

        private static gax::PathTemplate s_organizationModule = new gax::PathTemplate("organizations/{organization}/eventThreatDetectionSettings/customModules/{module}");

        private static gax::PathTemplate s_folderModule = new gax::PathTemplate("folders/{folder}/eventThreatDetectionSettings/customModules/{module}");

        private static gax::PathTemplate s_projectModule = new gax::PathTemplate("projects/{project}/eventThreatDetectionSettings/customModules/{module}");

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromOrganizationModule(string organizationId, string moduleId) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.OrganizationModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), moduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)));

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromFolderModule(string folderId, string moduleId) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.FolderModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), moduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)));

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromProjectModule(string projectId, string moduleId) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.ProjectModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), moduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </returns>
        public static string Format(string organizationId, string moduleId) =>
            FormatOrganizationModule(organizationId, moduleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </returns>
        public static string FormatOrganizationModule(string organizationId, string moduleId) =>
            s_organizationModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern <c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </returns>
        public static string FormatFolderModule(string folderId, string moduleId) =>
            s_folderModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern <c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c>.
        /// </returns>
        public static string FormatProjectModule(string projectId, string moduleId) =>
            s_projectModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="EventThreatDetectionCustomModuleName"/> if successful.</returns>
        public static EventThreatDetectionCustomModuleName Parse(string eventThreatDetectionCustomModuleName) =>
            Parse(eventThreatDetectionCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventThreatDetectionCustomModuleName"/> if successful.</returns>
        public static EventThreatDetectionCustomModuleName Parse(string eventThreatDetectionCustomModuleName, bool allowUnparsed) =>
            TryParse(eventThreatDetectionCustomModuleName, allowUnparsed, out EventThreatDetectionCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventThreatDetectionCustomModuleName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventThreatDetectionCustomModuleName, out EventThreatDetectionCustomModuleName result) =>
            TryParse(eventThreatDetectionCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/eventThreatDetectionSettings/customModules/{module}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventThreatDetectionCustomModuleName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventThreatDetectionCustomModuleName, bool allowUnparsed, out EventThreatDetectionCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModuleName, nameof(eventThreatDetectionCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationModule.TryParseName(eventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromOrganizationModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderModule.TryParseName(eventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromFolderModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectModule.TryParseName(eventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromProjectModule(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventThreatDetectionCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventThreatDetectionCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string moduleId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            ModuleId = moduleId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventThreatDetectionCustomModuleName"/> class from the component
        /// parts of pattern <c>organizations/{organization}/eventThreatDetectionSettings/customModules/{module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="moduleId">The <c>Module</c> ID. Must not be <c>null</c> or empty.</param>
        public EventThreatDetectionCustomModuleName(string organizationId, string moduleId) : this(ResourceNameType.OrganizationModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), moduleId: gax::GaxPreconditions.CheckNotNullOrEmpty(moduleId, nameof(moduleId)))
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
        /// The <c>Module</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ModuleId { get; }

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
                case ResourceNameType.OrganizationModule: return s_organizationModule.Expand(OrganizationId, ModuleId);
                case ResourceNameType.FolderModule: return s_folderModule.Expand(FolderId, ModuleId);
                case ResourceNameType.ProjectModule: return s_projectModule.Expand(ProjectId, ModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventThreatDetectionCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(EventThreatDetectionCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventThreatDetectionCustomModuleName a, EventThreatDetectionCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventThreatDetectionCustomModuleName a, EventThreatDetectionCustomModuleName b) => !(a == b);
    }

    public partial class EventThreatDetectionCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::EventThreatDetectionCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::EventThreatDetectionCustomModuleName EventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EventThreatDetectionCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcsv::EventThreatDetectionCustomModuleName"/>-typed view over the <see cref="AncestorModule"/>
        /// resource name property.
        /// </summary>
        public gcsv::EventThreatDetectionCustomModuleName AncestorModuleAsEventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(AncestorModule) ? null : gcsv::EventThreatDetectionCustomModuleName.Parse(AncestorModule, allowUnparsed: true);
            set => AncestorModule = value?.ToString() ?? "";
        }
    }
}
