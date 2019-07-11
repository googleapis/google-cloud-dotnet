// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>
    /// Resource name for the 'region' resource.
    /// </summary>
    public sealed partial class RegionName : gax::IResourceName, sys::IEquatable<RegionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/regions/{region}");

        /// <summary>
        /// Parses the given region resource name in string form into a new
        /// <see cref="RegionName"/> instance.
        /// </summary>
        /// <param name="regionName">The region resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegionName"/> if successful.</returns>
        public static RegionName Parse(string regionName)
        {
            gax::GaxPreconditions.CheckNotNull(regionName, nameof(regionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(regionName);
            return new RegionName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given region resource name in string form into a new
        /// <see cref="RegionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="regionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="regionName">The region resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RegionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionName, out RegionName result)
        {
            gax::GaxPreconditions.CheckNotNull(regionName, nameof(regionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(regionName, out resourceName))
            {
                result = new RegionName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="RegionName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="regionId">The <c>region</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="RegionName"/>.</returns>
        public static string Format(string projectId, string regionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(regionId, nameof(regionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="RegionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="regionId">The region ID. Must not be <c>null</c>.</param>
        public RegionName(string projectId, string regionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            RegionId = gax::GaxPreconditions.CheckNotNull(regionId, nameof(regionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The region ID. Never <c>null</c>.
        /// </summary>
        public string RegionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, RegionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RegionName);

        /// <inheritdoc />
        public bool Equals(RegionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(RegionName a, RegionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(RegionName a, RegionName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'workflow_template' resource.
    /// </summary>
    public sealed partial class WorkflowTemplateName : gax::IResourceName, sys::IEquatable<WorkflowTemplateName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/regions/{region}/workflowTemplates/{workflow_template}");

        /// <summary>
        /// Parses the given workflow_template resource name in string form into a new
        /// <see cref="WorkflowTemplateName"/> instance.
        /// </summary>
        /// <param name="workflowTemplateName">The workflow_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkflowTemplateName"/> if successful.</returns>
        public static WorkflowTemplateName Parse(string workflowTemplateName)
        {
            gax::GaxPreconditions.CheckNotNull(workflowTemplateName, nameof(workflowTemplateName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(workflowTemplateName);
            return new WorkflowTemplateName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given workflow_template resource name in string form into a new
        /// <see cref="WorkflowTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="workflowTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="workflowTemplateName">The workflow_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="WorkflowTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowTemplateName, out WorkflowTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(workflowTemplateName, nameof(workflowTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(workflowTemplateName, out resourceName))
            {
                result = new WorkflowTemplateName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="WorkflowTemplateName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="regionId">The <c>region</c> ID. Must not be <c>null</c>.</param>
        /// <param name="workflowTemplateId">The <c>workflowTemplate</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="WorkflowTemplateName"/>.</returns>
        public static string Format(string projectId, string regionId, string workflowTemplateId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNull(workflowTemplateId, nameof(workflowTemplateId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="WorkflowTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="regionId">The region ID. Must not be <c>null</c>.</param>
        /// <param name="workflowTemplateId">The workflowTemplate ID. Must not be <c>null</c>.</param>
        public WorkflowTemplateName(string projectId, string regionId, string workflowTemplateId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            RegionId = gax::GaxPreconditions.CheckNotNull(regionId, nameof(regionId));
            WorkflowTemplateId = gax::GaxPreconditions.CheckNotNull(workflowTemplateId, nameof(workflowTemplateId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The region ID. Never <c>null</c>.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The workflowTemplate ID. Never <c>null</c>.
        /// </summary>
        public string WorkflowTemplateId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, RegionId, WorkflowTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as WorkflowTemplateName);

        /// <inheritdoc />
        public bool Equals(WorkflowTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(WorkflowTemplateName a, WorkflowTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(WorkflowTemplateName a, WorkflowTemplateName b) => !(a == b);
    }


    public partial class CreateWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.RegionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.RegionName ParentAsRegionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dataproc.V1.RegionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.WorkflowTemplateName WorkflowTemplateName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dataproc.V1.WorkflowTemplateName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.WorkflowTemplateName WorkflowTemplateName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dataproc.V1.WorkflowTemplateName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InstantiateInlineWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.RegionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.RegionName ParentAsRegionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dataproc.V1.RegionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InstantiateWorkflowTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.WorkflowTemplateName WorkflowTemplateName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dataproc.V1.WorkflowTemplateName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListWorkflowTemplatesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.RegionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.RegionName ParentAsRegionName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dataproc.V1.RegionName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class WorkflowTemplate
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dataproc.V1.WorkflowTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dataproc.V1.WorkflowTemplateName WorkflowTemplateName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dataproc.V1.WorkflowTemplateName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}