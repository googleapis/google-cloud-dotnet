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

namespace Google.Cloud.Monitoring.V3
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
    /// Resource name for the 'metric_descriptor' resource.
    /// </summary>
    public sealed partial class MetricDescriptorName : IResourceName, IEquatable<MetricDescriptorName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/metricDescriptors/{metric_descriptor=**}");

        /// <summary>
        /// Parses the given metric_descriptor resource name in string form into a new
        /// <see cref="MetricDescriptorName"/> instance.
        /// </summary>
        /// <param name="metricDescriptorName">The metric_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricDescriptorName"/> if successful.</returns>
        public static MetricDescriptorName Parse(string metricDescriptorName)
        {
            GaxPreconditions.CheckNotNull(metricDescriptorName, nameof(metricDescriptorName));
            TemplatedResourceName resourceName = s_template.ParseName(metricDescriptorName);
            return new MetricDescriptorName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given metric_descriptor resource name in string form into a new
        /// <see cref="MetricDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="metricDescriptorName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="metricDescriptorName">The metric_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MetricDescriptorName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricDescriptorName, out MetricDescriptorName result)
        {
            GaxPreconditions.CheckNotNull(metricDescriptorName, nameof(metricDescriptorName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(metricDescriptorName, out resourceName))
            {
                result = new MetricDescriptorName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MetricDescriptorName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="metricDescriptorId">The metricDescriptor ID. Must not be <c>null</c>.</param>
        public MetricDescriptorName(string projectId, string metricDescriptorId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            MetricDescriptorId = GaxPreconditions.CheckNotNull(metricDescriptorId, nameof(metricDescriptorId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The metricDescriptor ID. Never <c>null</c>.
        /// </summary>
        public string MetricDescriptorId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, MetricDescriptorId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MetricDescriptorName);

        /// <inheritdoc />
        public bool Equals(MetricDescriptorName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MetricDescriptorName a, MetricDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MetricDescriptorName a, MetricDescriptorName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'monitored_resource_descriptor' resource.
    /// </summary>
    public sealed partial class MonitoredResourceDescriptorName : IResourceName, IEquatable<MonitoredResourceDescriptorName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        /// <summary>
        /// Parses the given monitored_resource_descriptor resource name in string form into a new
        /// <see cref="MonitoredResourceDescriptorName"/> instance.
        /// </summary>
        /// <param name="monitoredResourceDescriptorName">The monitored_resource_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MonitoredResourceDescriptorName"/> if successful.</returns>
        public static MonitoredResourceDescriptorName Parse(string monitoredResourceDescriptorName)
        {
            GaxPreconditions.CheckNotNull(monitoredResourceDescriptorName, nameof(monitoredResourceDescriptorName));
            TemplatedResourceName resourceName = s_template.ParseName(monitoredResourceDescriptorName);
            return new MonitoredResourceDescriptorName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given monitored_resource_descriptor resource name in string form into a new
        /// <see cref="MonitoredResourceDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="monitoredResourceDescriptorName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="monitoredResourceDescriptorName">The monitored_resource_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MonitoredResourceDescriptorName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredResourceDescriptorName, out MonitoredResourceDescriptorName result)
        {
            GaxPreconditions.CheckNotNull(monitoredResourceDescriptorName, nameof(monitoredResourceDescriptorName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(monitoredResourceDescriptorName, out resourceName))
            {
                result = new MonitoredResourceDescriptorName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MonitoredResourceDescriptorName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="monitoredResourceDescriptorId">The monitoredResourceDescriptor ID. Must not be <c>null</c>.</param>
        public MonitoredResourceDescriptorName(string projectId, string monitoredResourceDescriptorId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            MonitoredResourceDescriptorId = GaxPreconditions.CheckNotNull(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The monitoredResourceDescriptor ID. Never <c>null</c>.
        /// </summary>
        public string MonitoredResourceDescriptorId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, MonitoredResourceDescriptorId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MonitoredResourceDescriptorName);

        /// <inheritdoc />
        public bool Equals(MonitoredResourceDescriptorName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MonitoredResourceDescriptorName a, MonitoredResourceDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MonitoredResourceDescriptorName a, MonitoredResourceDescriptorName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'group' resource.
    /// </summary>
    public sealed partial class GroupName : IResourceName, IEquatable<GroupName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Parses the given group resource name in string form into a new
        /// <see cref="GroupName"/> instance.
        /// </summary>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName)
        {
            GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            TemplatedResourceName resourceName = s_template.ParseName(groupName);
            return new GroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given group resource name in string form into a new
        /// <see cref="GroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="groupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, out GroupName result)
        {
            GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(groupName, out resourceName))
            {
                result = new GroupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GroupName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="groupId">The group ID. Must not be <c>null</c>.</param>
        public GroupName(string projectId, string groupId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GroupId = GaxPreconditions.CheckNotNull(groupId, nameof(groupId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The group ID. Never <c>null</c>.
        /// </summary>
        public string GroupId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, GroupId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GroupName);

        /// <inheritdoc />
        public bool Equals(GroupName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GroupName a, GroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GroupName a, GroupName b) => !(a == b);
    }


    public partial class CreateGroupRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateMetricDescriptorRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteGroupRequest
    {
        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public GroupName GroupName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteMetricDescriptorRequest
    {
        /// <summary>
        /// <see cref="MetricDescriptorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public MetricDescriptorName MetricDescriptorName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.MetricDescriptorName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetGroupRequest
    {
        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public GroupName GroupName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetMetricDescriptorRequest
    {
        /// <summary>
        /// <see cref="MetricDescriptorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public MetricDescriptorName MetricDescriptorName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.MetricDescriptorName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetMonitoredResourceDescriptorRequest
    {
        /// <summary>
        /// <see cref="MonitoredResourceDescriptorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public MonitoredResourceDescriptorName MonitoredResourceDescriptorName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.MonitoredResourceDescriptorName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Group
    {
        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public GroupName GroupName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="ParentName"/> resource name property.
        /// </summary>
        public GroupName ParentNameAsGroupName
        {
            get { return string.IsNullOrEmpty(ParentName) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(ParentName); }
            set { ParentName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListGroupMembersRequest
    {
        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public GroupName GroupName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListGroupsRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="ChildrenOfGroup"/> resource name property.
        /// </summary>
        public GroupName ChildrenOfGroupAsGroupName
        {
            get { return string.IsNullOrEmpty(ChildrenOfGroup) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(ChildrenOfGroup); }
            set { ChildrenOfGroup = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="AncestorsOfGroup"/> resource name property.
        /// </summary>
        public GroupName AncestorsOfGroupAsGroupName
        {
            get { return string.IsNullOrEmpty(AncestorsOfGroup) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(AncestorsOfGroup); }
            set { AncestorsOfGroup = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="DescendantsOfGroup"/> resource name property.
        /// </summary>
        public GroupName DescendantsOfGroupAsGroupName
        {
            get { return string.IsNullOrEmpty(DescendantsOfGroup) ? null : Google.Cloud.Monitoring.V3.GroupName.Parse(DescendantsOfGroup); }
            set { DescendantsOfGroup = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListMetricDescriptorsRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListMonitoredResourceDescriptorsRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}