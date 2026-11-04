// Copyright 2026 Google LLC
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
using gcbv = Google.Cloud.BackupDR.V1;
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Resource name for the <c>RestoreTemplate</c> resource.</summary>
    public sealed partial class RestoreTemplateName : gax::IResourceName, sys::IEquatable<RestoreTemplateName>
    {
        /// <summary>The possible contents of <see cref="RestoreTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>.
            /// </summary>
            ProjectLocationRestoreTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationRestoreTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/restoreTemplates/{restore_template}");

        /// <summary>Creates a <see cref="RestoreTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RestoreTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RestoreTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RestoreTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RestoreTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreTemplateId">The <c>RestoreTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RestoreTemplateName"/> constructed from the provided ids.</returns>
        public static RestoreTemplateName FromProjectLocationRestoreTemplate(string projectId, string locationId, string restoreTemplateId) =>
            new RestoreTemplateName(ResourceNameType.ProjectLocationRestoreTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restoreTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreTemplateId, nameof(restoreTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestoreTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreTemplateId">The <c>RestoreTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestoreTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string restoreTemplateId) =>
            FormatProjectLocationRestoreTemplate(projectId, locationId, restoreTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestoreTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreTemplateId">The <c>RestoreTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestoreTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>.
        /// </returns>
        public static string FormatProjectLocationRestoreTemplate(string projectId, string locationId, string restoreTemplateId) =>
            s_projectLocationRestoreTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restoreTemplateId, nameof(restoreTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestoreTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restoreTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RestoreTemplateName"/> if successful.</returns>
        public static RestoreTemplateName Parse(string restoreTemplateName) => Parse(restoreTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestoreTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restoreTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RestoreTemplateName"/> if successful.</returns>
        public static RestoreTemplateName Parse(string restoreTemplateName, bool allowUnparsed) =>
            TryParse(restoreTemplateName, allowUnparsed, out RestoreTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestoreTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restoreTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestoreTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restoreTemplateName, out RestoreTemplateName result) =>
            TryParse(restoreTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestoreTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restoreTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestoreTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restoreTemplateName, bool allowUnparsed, out RestoreTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(restoreTemplateName, nameof(restoreTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRestoreTemplate.TryParseName(restoreTemplateName, out resourceName))
            {
                result = FromProjectLocationRestoreTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(restoreTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RestoreTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string restoreTemplateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RestoreTemplateId = restoreTemplateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RestoreTemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/restoreTemplates/{restore_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreTemplateId">The <c>RestoreTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public RestoreTemplateName(string projectId, string locationId, string restoreTemplateId) : this(ResourceNameType.ProjectLocationRestoreTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restoreTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreTemplateId, nameof(restoreTemplateId)))
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
        /// The <c>RestoreTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RestoreTemplateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRestoreTemplate: return s_projectLocationRestoreTemplate.Expand(ProjectId, LocationId, RestoreTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RestoreTemplateName);

        /// <inheritdoc/>
        public bool Equals(RestoreTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RestoreTemplateName a, RestoreTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RestoreTemplateName a, RestoreTemplateName b) => !(a == b);
    }

    public partial class RestoreTemplate
    {
        /// <summary>
        /// <see cref="gcbv::RestoreTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::RestoreTemplateName RestoreTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::RestoreTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExecutionSummary
    {
        /// <summary>
        /// <see cref="RestoreTemplateExecutionName"/>-typed view over the <see cref="LastExecution"/> resource name
        /// property.
        /// </summary>
        public RestoreTemplateExecutionName LastExecutionAsRestoreTemplateExecutionName
        {
            get => string.IsNullOrEmpty(LastExecution) ? null : RestoreTemplateExecutionName.Parse(LastExecution, allowUnparsed: true);
            set => LastExecution = value?.ToString() ?? "";
        }
    }

    public partial class CreateRestoreTemplateRequest
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

    public partial class GetRestoreTemplateRequest
    {
        /// <summary>
        /// <see cref="gcbv::RestoreTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::RestoreTemplateName RestoreTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::RestoreTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRestoreTemplateRequest
    {
        /// <summary>
        /// <see cref="gcbv::RestoreTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::RestoreTemplateName RestoreTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::RestoreTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunRestoreTemplateRequest
    {
        /// <summary>
        /// <see cref="gcbv::RestoreTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::RestoreTemplateName RestoreTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::RestoreTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.</summary>
        public BackupName BackupAsBackupName
        {
            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
            set => Backup = value?.ToString() ?? "";
        }
    }

    public partial class RunRestoreTemplateResponse
    {
        /// <summary>
        /// <see cref="RestoreTemplateExecutionName"/>-typed view over the <see cref="RestoreTemplateExecution"/>
        /// resource name property.
        /// </summary>
        public RestoreTemplateExecutionName RestoreTemplateExecutionAsRestoreTemplateExecutionName
        {
            get => string.IsNullOrEmpty(RestoreTemplateExecution) ? null : RestoreTemplateExecutionName.Parse(RestoreTemplateExecution, allowUnparsed: true);
            set => RestoreTemplateExecution = value?.ToString() ?? "";
        }
    }

    public partial class ListRestoreTemplatesRequest
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
}
