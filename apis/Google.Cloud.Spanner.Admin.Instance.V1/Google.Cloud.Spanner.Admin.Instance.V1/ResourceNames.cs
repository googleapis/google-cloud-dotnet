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

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>
    /// Resource name for the 'instance' resource.
    /// </summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>
        /// Parses the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(instanceName);
            return new InstanceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="instanceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(instanceName, out resourceName))
            {
                result = new InstanceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="InstanceName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The <c>instance</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="InstanceName"/>.</returns>
        public static string Format(string projectId, string instanceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        public InstanceName(string projectId, string instanceId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc />
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'instance_config' resource.
    /// </summary>
    public sealed partial class InstanceConfigName : gax::IResourceName, sys::IEquatable<InstanceConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/instanceConfigs/{config}");

        /// <summary>
        /// Parses the given instance_config resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <param name="instanceConfigName">The instance_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(instanceConfigName);
            return new InstanceConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance_config resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="instanceConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceConfigName">The instance_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, out InstanceConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(instanceConfigName, out resourceName))
            {
                result = new InstanceConfigName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="InstanceConfigName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="configId">The <c>config</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="InstanceConfigName"/>.</returns>
        public static string Format(string projectId, string configId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(configId, nameof(configId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="configId">The config ID. Must not be <c>null</c>.</param>
        public InstanceConfigName(string projectId, string configId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            ConfigId = gax::GaxPreconditions.CheckNotNull(configId, nameof(configId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The config ID. Never <c>null</c>.
        /// </summary>
        public string ConfigId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, ConfigId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InstanceConfigName);

        /// <inheritdoc />
        public bool Equals(InstanceConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InstanceConfigName a, InstanceConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InstanceConfigName a, InstanceConfigName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : gax::IResourceName, sys::IEquatable<ProjectName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectName"/>.</returns>
        public static string Format(string projectId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }


    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Instance.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName InstanceConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InstanceConfig
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName InstanceConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstanceConfigsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Instance.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Instance.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateInstanceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Spanner.Admin.Instance.V1.InstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public Google.Cloud.Spanner.Admin.Instance.V1.InstanceName InstanceAsInstanceName
        {
            get { return string.IsNullOrEmpty(Instance) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Instance); }
            set { Instance = value != null ? value.ToString() : ""; }
        }

    }

}