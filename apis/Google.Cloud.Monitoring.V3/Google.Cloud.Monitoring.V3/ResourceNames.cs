// Copyright 2018 Google LLC
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
using s = System;
using System.Linq;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : gax::IResourceName, s::IEquatable<ProjectName>
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
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
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

    /// <summary>
    /// Resource name for the 'alert_policy' resource.
    /// </summary>
    public sealed partial class AlertPolicyName : gax::IResourceName, s::IEquatable<AlertPolicyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/alertPolicies/{alert_policy}");

        /// <summary>
        /// Parses the given alert_policy resource name in string form into a new
        /// <see cref="AlertPolicyName"/> instance.
        /// </summary>
        /// <param name="alertPolicyName">The alert_policy resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AlertPolicyName"/> if successful.</returns>
        public static AlertPolicyName Parse(string alertPolicyName)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyName, nameof(alertPolicyName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(alertPolicyName);
            return new AlertPolicyName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given alert_policy resource name in string form into a new
        /// <see cref="AlertPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="alertPolicyName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="alertPolicyName">The alert_policy resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AlertPolicyName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyName, out AlertPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyName, nameof(alertPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(alertPolicyName, out resourceName))
            {
                result = new AlertPolicyName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AlertPolicyName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="alertPolicyId">The alertPolicy ID. Must not be <c>null</c>.</param>
        public AlertPolicyName(string projectId, string alertPolicyId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            AlertPolicyId = gax::GaxPreconditions.CheckNotNull(alertPolicyId, nameof(alertPolicyId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The alertPolicy ID. Never <c>null</c>.
        /// </summary>
        public string AlertPolicyId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, AlertPolicyId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AlertPolicyName);

        /// <inheritdoc />
        public bool Equals(AlertPolicyName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AlertPolicyName a, AlertPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AlertPolicyName a, AlertPolicyName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'alert_policy_condition' resource.
    /// </summary>
    public sealed partial class AlertPolicyConditionName : gax::IResourceName, s::IEquatable<AlertPolicyConditionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}");

        /// <summary>
        /// Parses the given alert_policy_condition resource name in string form into a new
        /// <see cref="AlertPolicyConditionName"/> instance.
        /// </summary>
        /// <param name="alertPolicyConditionName">The alert_policy_condition resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AlertPolicyConditionName"/> if successful.</returns>
        public static AlertPolicyConditionName Parse(string alertPolicyConditionName)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyConditionName, nameof(alertPolicyConditionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(alertPolicyConditionName);
            return new AlertPolicyConditionName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given alert_policy_condition resource name in string form into a new
        /// <see cref="AlertPolicyConditionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="alertPolicyConditionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="alertPolicyConditionName">The alert_policy_condition resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AlertPolicyConditionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyConditionName, out AlertPolicyConditionName result)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyConditionName, nameof(alertPolicyConditionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(alertPolicyConditionName, out resourceName))
            {
                result = new AlertPolicyConditionName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AlertPolicyConditionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="alertPolicyId">The alertPolicy ID. Must not be <c>null</c>.</param>
        /// <param name="conditionId">The condition ID. Must not be <c>null</c>.</param>
        public AlertPolicyConditionName(string projectId, string alertPolicyId, string conditionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            AlertPolicyId = gax::GaxPreconditions.CheckNotNull(alertPolicyId, nameof(alertPolicyId));
            ConditionId = gax::GaxPreconditions.CheckNotNull(conditionId, nameof(conditionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The alertPolicy ID. Never <c>null</c>.
        /// </summary>
        public string AlertPolicyId { get; }

        /// <summary>
        /// The condition ID. Never <c>null</c>.
        /// </summary>
        public string ConditionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, AlertPolicyId, ConditionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AlertPolicyConditionName);

        /// <inheritdoc />
        public bool Equals(AlertPolicyConditionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AlertPolicyConditionName a, AlertPolicyConditionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AlertPolicyConditionName a, AlertPolicyConditionName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'group' resource.
    /// </summary>
    public sealed partial class GroupName : gax::IResourceName, s::IEquatable<GroupName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Parses the given group resource name in string form into a new
        /// <see cref="GroupName"/> instance.
        /// </summary>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupName"/> if successful.</returns>
        public static GroupName Parse(string groupName)
        {
            gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(groupName);
            return new GroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given group resource name in string form into a new
        /// <see cref="GroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="groupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupName, out GroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName));
            gax::TemplatedResourceName resourceName;
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
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GroupId = gax::GaxPreconditions.CheckNotNull(groupId, nameof(groupId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

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

    /// <summary>
    /// Resource name for the 'metric_descriptor' resource.
    /// </summary>
    public sealed partial class MetricDescriptorName : gax::IResourceName, s::IEquatable<MetricDescriptorName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/metricDescriptors/{metric_descriptor=**}");

        /// <summary>
        /// Parses the given metric_descriptor resource name in string form into a new
        /// <see cref="MetricDescriptorName"/> instance.
        /// </summary>
        /// <param name="metricDescriptorName">The metric_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricDescriptorName"/> if successful.</returns>
        public static MetricDescriptorName Parse(string metricDescriptorName)
        {
            gax::GaxPreconditions.CheckNotNull(metricDescriptorName, nameof(metricDescriptorName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(metricDescriptorName);
            return new MetricDescriptorName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given metric_descriptor resource name in string form into a new
        /// <see cref="MetricDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="metricDescriptorName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="metricDescriptorName">The metric_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MetricDescriptorName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricDescriptorName, out MetricDescriptorName result)
        {
            gax::GaxPreconditions.CheckNotNull(metricDescriptorName, nameof(metricDescriptorName));
            gax::TemplatedResourceName resourceName;
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
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            MetricDescriptorId = gax::GaxPreconditions.CheckNotNull(metricDescriptorId, nameof(metricDescriptorId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

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
    public sealed partial class MonitoredResourceDescriptorName : gax::IResourceName, s::IEquatable<MonitoredResourceDescriptorName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        /// <summary>
        /// Parses the given monitored_resource_descriptor resource name in string form into a new
        /// <see cref="MonitoredResourceDescriptorName"/> instance.
        /// </summary>
        /// <param name="monitoredResourceDescriptorName">The monitored_resource_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MonitoredResourceDescriptorName"/> if successful.</returns>
        public static MonitoredResourceDescriptorName Parse(string monitoredResourceDescriptorName)
        {
            gax::GaxPreconditions.CheckNotNull(monitoredResourceDescriptorName, nameof(monitoredResourceDescriptorName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(monitoredResourceDescriptorName);
            return new MonitoredResourceDescriptorName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given monitored_resource_descriptor resource name in string form into a new
        /// <see cref="MonitoredResourceDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="monitoredResourceDescriptorName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="monitoredResourceDescriptorName">The monitored_resource_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MonitoredResourceDescriptorName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredResourceDescriptorName, out MonitoredResourceDescriptorName result)
        {
            gax::GaxPreconditions.CheckNotNull(monitoredResourceDescriptorName, nameof(monitoredResourceDescriptorName));
            gax::TemplatedResourceName resourceName;
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
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            MonitoredResourceDescriptorId = gax::GaxPreconditions.CheckNotNull(monitoredResourceDescriptorId, nameof(monitoredResourceDescriptorId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

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
    /// Resource name for the 'notification_channel' resource.
    /// </summary>
    public sealed partial class NotificationChannelName : gax::IResourceName, s::IEquatable<NotificationChannelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/notificationChannels/{notification_channel}");

        /// <summary>
        /// Parses the given notification_channel resource name in string form into a new
        /// <see cref="NotificationChannelName"/> instance.
        /// </summary>
        /// <param name="notificationChannelName">The notification_channel resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotificationChannelName"/> if successful.</returns>
        public static NotificationChannelName Parse(string notificationChannelName)
        {
            gax::GaxPreconditions.CheckNotNull(notificationChannelName, nameof(notificationChannelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(notificationChannelName);
            return new NotificationChannelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given notification_channel resource name in string form into a new
        /// <see cref="NotificationChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="notificationChannelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="notificationChannelName">The notification_channel resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="NotificationChannelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationChannelName, out NotificationChannelName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationChannelName, nameof(notificationChannelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(notificationChannelName, out resourceName))
            {
                result = new NotificationChannelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="NotificationChannelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="notificationChannelId">The notificationChannel ID. Must not be <c>null</c>.</param>
        public NotificationChannelName(string projectId, string notificationChannelId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            NotificationChannelId = gax::GaxPreconditions.CheckNotNull(notificationChannelId, nameof(notificationChannelId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The notificationChannel ID. Never <c>null</c>.
        /// </summary>
        public string NotificationChannelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, NotificationChannelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as NotificationChannelName);

        /// <inheritdoc />
        public bool Equals(NotificationChannelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(NotificationChannelName a, NotificationChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(NotificationChannelName a, NotificationChannelName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'notification_channel_descriptor' resource.
    /// </summary>
    public sealed partial class NotificationChannelDescriptorName : gax::IResourceName, s::IEquatable<NotificationChannelDescriptorName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/notificationChannelDescriptors/{channel_descriptor}");

        /// <summary>
        /// Parses the given notification_channel_descriptor resource name in string form into a new
        /// <see cref="NotificationChannelDescriptorName"/> instance.
        /// </summary>
        /// <param name="notificationChannelDescriptorName">The notification_channel_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotificationChannelDescriptorName"/> if successful.</returns>
        public static NotificationChannelDescriptorName Parse(string notificationChannelDescriptorName)
        {
            gax::GaxPreconditions.CheckNotNull(notificationChannelDescriptorName, nameof(notificationChannelDescriptorName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(notificationChannelDescriptorName);
            return new NotificationChannelDescriptorName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given notification_channel_descriptor resource name in string form into a new
        /// <see cref="NotificationChannelDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="notificationChannelDescriptorName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="notificationChannelDescriptorName">The notification_channel_descriptor resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="NotificationChannelDescriptorName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationChannelDescriptorName, out NotificationChannelDescriptorName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationChannelDescriptorName, nameof(notificationChannelDescriptorName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(notificationChannelDescriptorName, out resourceName))
            {
                result = new NotificationChannelDescriptorName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="NotificationChannelDescriptorName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="channelDescriptorId">The channelDescriptor ID. Must not be <c>null</c>.</param>
        public NotificationChannelDescriptorName(string projectId, string channelDescriptorId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            ChannelDescriptorId = gax::GaxPreconditions.CheckNotNull(channelDescriptorId, nameof(channelDescriptorId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The channelDescriptor ID. Never <c>null</c>.
        /// </summary>
        public string ChannelDescriptorId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, ChannelDescriptorId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as NotificationChannelDescriptorName);

        /// <inheritdoc />
        public bool Equals(NotificationChannelDescriptorName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(NotificationChannelDescriptorName a, NotificationChannelDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(NotificationChannelDescriptorName a, NotificationChannelDescriptorName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'uptime_check_config' resource.
    /// </summary>
    public sealed partial class UptimeCheckConfigName : gax::IResourceName, s::IEquatable<UptimeCheckConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/uptimeCheckConfigs/{uptime_check_config}");

        /// <summary>
        /// Parses the given uptime_check_config resource name in string form into a new
        /// <see cref="UptimeCheckConfigName"/> instance.
        /// </summary>
        /// <param name="uptimeCheckConfigName">The uptime_check_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UptimeCheckConfigName"/> if successful.</returns>
        public static UptimeCheckConfigName Parse(string uptimeCheckConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(uptimeCheckConfigName, nameof(uptimeCheckConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(uptimeCheckConfigName);
            return new UptimeCheckConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given uptime_check_config resource name in string form into a new
        /// <see cref="UptimeCheckConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="s::ArgumentNullException"/> if <paramref name="uptimeCheckConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="uptimeCheckConfigName">The uptime_check_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="UptimeCheckConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string uptimeCheckConfigName, out UptimeCheckConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(uptimeCheckConfigName, nameof(uptimeCheckConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(uptimeCheckConfigName, out resourceName))
            {
                result = new UptimeCheckConfigName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="UptimeCheckConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="uptimeCheckConfigId">The uptimeCheckConfig ID. Must not be <c>null</c>.</param>
        public UptimeCheckConfigName(string projectId, string uptimeCheckConfigId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            UptimeCheckConfigId = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfigId, nameof(uptimeCheckConfigId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The uptimeCheckConfig ID. Never <c>null</c>.
        /// </summary>
        public string UptimeCheckConfigId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, UptimeCheckConfigId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as UptimeCheckConfigName);

        /// <inheritdoc />
        public bool Equals(UptimeCheckConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(UptimeCheckConfigName a, UptimeCheckConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(UptimeCheckConfigName a, UptimeCheckConfigName b) => !(a == b);
    }


    public partial class CreateAlertPolicyRequest
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

    public partial class CreateNotificationChannelRequest
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

    public partial class DeleteAlertPolicyRequest
    {
        /// <summary>
        /// <see cref="AlertPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public AlertPolicyName AlertPolicyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.AlertPolicyName.Parse(Name); }
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

    public partial class DeleteNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public NotificationChannelName NotificationChannelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.NotificationChannelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetAlertPolicyRequest
    {
        /// <summary>
        /// <see cref="AlertPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public AlertPolicyName AlertPolicyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.AlertPolicyName.Parse(Name); }
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

    public partial class GetNotificationChannelDescriptorRequest
    {
        /// <summary>
        /// <see cref="NotificationChannelDescriptorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public NotificationChannelDescriptorName NotificationChannelDescriptorName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.NotificationChannelDescriptorName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public NotificationChannelName NotificationChannelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.NotificationChannelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetNotificationChannelVerificationCodeRequest
    {
        /// <summary>
        /// <see cref="NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public NotificationChannelName NotificationChannelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.NotificationChannelName.Parse(Name); }
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

    public partial class ListAlertPoliciesRequest
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

    public partial class ListNotificationChannelDescriptorsRequest
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

    public partial class ListNotificationChannelsRequest
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

    public partial class SendNotificationChannelVerificationCodeRequest
    {
        /// <summary>
        /// <see cref="NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public NotificationChannelName NotificationChannelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.NotificationChannelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class VerifyNotificationChannelRequest
    {
        /// <summary>
        /// <see cref="NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public NotificationChannelName NotificationChannelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Monitoring.V3.NotificationChannelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}