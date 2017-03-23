// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : IResourceName, IEquatable<ProjectName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

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

    /// <summary>
    /// Resource name for the 'instance_config' resource.
    /// </summary>
    public sealed partial class InstanceConfigName : IResourceName, IEquatable<InstanceConfigName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instanceConfigs/{instance_config}");

        /// <summary>
        /// Parses the given instance_config resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <param name="instanceConfigName">The instance_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName)
        {
            GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            TemplatedResourceName resourceName = s_template.ParseName(instanceConfigName);
            return new InstanceConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance_config resource name in string form into a new
        /// <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="instanceConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceConfigName">The instance_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, out InstanceConfigName result)
        {
            GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceConfigId">The instanceConfig ID. Must not be <c>null</c>.</param>
        public InstanceConfigName(string projectId, string instanceConfigId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceConfigId = GaxPreconditions.CheckNotNull(instanceConfigId, nameof(instanceConfigId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instanceConfig ID. Never <c>null</c>.
        /// </summary>
        public string InstanceConfigId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceConfigId);

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
    /// Resource name for the 'instance' resource.
    /// </summary>
    public sealed partial class InstanceName : IResourceName, IEquatable<InstanceName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>
        /// Parses the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName)
        {
            GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            TemplatedResourceName resourceName = s_template.ParseName(instanceName);
            return new InstanceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="instanceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result)
        {
            GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        public InstanceName(string projectId, string instanceId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
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
        public ResourceNameKind Kind => ResourceNameKind.Simple;

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


    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Instance.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="InstanceId"/> resource name property.
        /// </summary>
        public InstanceName InstanceIdAsInstanceName
        {
            get { return string.IsNullOrEmpty(InstanceId) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(InstanceId); }
            set { InstanceId = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceConfigRequest
    {
        /// <summary>
        /// <see cref="InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceConfigName InstanceConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="InstanceConfigName"/>-typed view over the <see cref="Config"/> resource name property.
        /// </summary>
        public InstanceConfigName ConfigAsInstanceConfigName
        {
            get { return string.IsNullOrEmpty(Config) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Config); }
            set { Config = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InstanceConfig
    {
        /// <summary>
        /// <see cref="InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceConfigName InstanceConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Instance.V1.InstanceConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstanceConfigsRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Instance.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Instance.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

}