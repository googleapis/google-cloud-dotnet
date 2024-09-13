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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dataproc.V1;
using sys = System;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Resource name for the <c>WorkflowTemplate</c> resource.</summary>
    public sealed partial class WorkflowTemplateName : gax::IResourceName, sys::IEquatable<WorkflowTemplateName>
    {
        /// <summary>The possible contents of <see cref="WorkflowTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>.
            /// </summary>
            ProjectRegionWorkflowTemplate = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>.
            /// </summary>
            ProjectLocationWorkflowTemplate = 2,
        }

        private static gax::PathTemplate s_projectRegionWorkflowTemplate = new gax::PathTemplate("projects/{project}/regions/{region}/workflowTemplates/{workflow_template}");

        private static gax::PathTemplate s_projectLocationWorkflowTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/workflowTemplates/{workflow_template}");

        /// <summary>Creates a <see cref="WorkflowTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkflowTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkflowTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkflowTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkflowTemplateName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowTemplateId">The <c>WorkflowTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkflowTemplateName"/> constructed from the provided ids.</returns>
        public static WorkflowTemplateName FromProjectRegionWorkflowTemplate(string projectId, string regionId, string workflowTemplateId) =>
            new WorkflowTemplateName(ResourceNameType.ProjectRegionWorkflowTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), workflowTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowTemplateId, nameof(workflowTemplateId)));

        /// <summary>
        /// Creates a <see cref="WorkflowTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowTemplateId">The <c>WorkflowTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkflowTemplateName"/> constructed from the provided ids.</returns>
        public static WorkflowTemplateName FromProjectLocationWorkflowTemplate(string projectId, string locationId, string workflowTemplateId) =>
            new WorkflowTemplateName(ResourceNameType.ProjectLocationWorkflowTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowTemplateId, nameof(workflowTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowTemplateName"/> with pattern
        /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowTemplateId">The <c>WorkflowTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowTemplateName"/> with pattern
        /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string workflowTemplateId) =>
            FormatProjectRegionWorkflowTemplate(projectId, regionId, workflowTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowTemplateName"/> with pattern
        /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowTemplateId">The <c>WorkflowTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowTemplateName"/> with pattern
        /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>.
        /// </returns>
        public static string FormatProjectRegionWorkflowTemplate(string projectId, string regionId, string workflowTemplateId) =>
            s_projectRegionWorkflowTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowTemplateId, nameof(workflowTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowTemplateId">The <c>WorkflowTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkflowTemplate(string projectId, string locationId, string workflowTemplateId) =>
            s_projectLocationWorkflowTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowTemplateId, nameof(workflowTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workflowTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkflowTemplateName"/> if successful.</returns>
        public static WorkflowTemplateName Parse(string workflowTemplateName) => Parse(workflowTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkflowTemplateName"/> if successful.</returns>
        public static WorkflowTemplateName Parse(string workflowTemplateName, bool allowUnparsed) =>
            TryParse(workflowTemplateName, allowUnparsed, out WorkflowTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workflowTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowTemplateName, out WorkflowTemplateName result) =>
            TryParse(workflowTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflowTemplates/{workflow_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowTemplateName, bool allowUnparsed, out WorkflowTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(workflowTemplateName, nameof(workflowTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionWorkflowTemplate.TryParseName(workflowTemplateName, out resourceName))
            {
                result = FromProjectRegionWorkflowTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationWorkflowTemplate.TryParseName(workflowTemplateName, out resourceName))
            {
                result = FromProjectLocationWorkflowTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workflowTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkflowTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string regionId = null, string workflowTemplateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RegionId = regionId;
            WorkflowTemplateId = workflowTemplateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkflowTemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/workflowTemplates/{workflow_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowTemplateId">The <c>WorkflowTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkflowTemplateName(string projectId, string regionId, string workflowTemplateId) : this(ResourceNameType.ProjectRegionWorkflowTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), workflowTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowTemplateId, nameof(workflowTemplateId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>WorkflowTemplate</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string WorkflowTemplateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionWorkflowTemplate: return s_projectRegionWorkflowTemplate.Expand(ProjectId, RegionId, WorkflowTemplateId);
                case ResourceNameType.ProjectLocationWorkflowTemplate: return s_projectLocationWorkflowTemplate.Expand(ProjectId, LocationId, WorkflowTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkflowTemplateName);

        /// <inheritdoc/>
        public bool Equals(WorkflowTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkflowTemplateName a, WorkflowTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkflowTemplateName a, WorkflowTemplateName b) => !(a == b);
    }

    public partial class WorkflowTemplate
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowTemplateName WorkflowTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class EncryptionConfig
            {
                /// <summary>
                /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKey"/> resource name property.
                /// </summary>
                public CryptoKeyName KmsKeyAsCryptoKeyName
                {
                    get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeyName.Parse(KmsKey, allowUnparsed: true);
                    set => KmsKey = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class CreateWorkflowTemplateRequest
    {
        /// <summary><see cref="RegionName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RegionName ParentAsRegionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (RegionName.TryParse(Parent, out RegionName region))
                {
                    return region;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowTemplateName WorkflowTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InstantiateWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowTemplateName WorkflowTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InstantiateInlineWorkflowTemplateRequest
    {
        /// <summary><see cref="RegionName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RegionName ParentAsRegionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (RegionName.TryParse(Parent, out RegionName region))
                {
                    return region;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkflowTemplatesRequest
    {
        /// <summary><see cref="RegionName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RegionName ParentAsRegionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (RegionName.TryParse(Parent, out RegionName region))
                {
                    return region;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::WorkflowTemplateName WorkflowTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::WorkflowTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
