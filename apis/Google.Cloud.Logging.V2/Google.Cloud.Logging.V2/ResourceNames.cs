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

namespace Google.Cloud.Logging.V2
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
    /// Resource name for the 'log' resource.
    /// </summary>
    public sealed partial class LogName : IResourceName, IEquatable<LogName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/logs/{log}");

        /// <summary>
        /// Parses the given log resource name in string form into a new
        /// <see cref="LogName"/> instance.
        /// </summary>
        /// <param name="logName">The log resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogName"/> if successful.</returns>
        public static LogName Parse(string logName)
        {
            GaxPreconditions.CheckNotNull(logName, nameof(logName));
            TemplatedResourceName resourceName = s_template.ParseName(logName);
            return new LogName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given log resource name in string form into a new
        /// <see cref="LogName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="logName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="logName">The log resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logName, out LogName result)
        {
            GaxPreconditions.CheckNotNull(logName, nameof(logName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(logName, out resourceName))
            {
                result = new LogName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LogName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="logId">The log ID. Must not be <c>null</c>.</param>
        public LogName(string projectId, string logId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LogId = GaxPreconditions.CheckNotNull(logId, nameof(logId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The log ID. Never <c>null</c>.
        /// </summary>
        public string LogId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LogId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogName);

        /// <inheritdoc />
        public bool Equals(LogName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogName a, LogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogName a, LogName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'sink' resource.
    /// </summary>
    public sealed partial class SinkName : IResourceName, IEquatable<SinkName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/sinks/{sink}");

        /// <summary>
        /// Parses the given sink resource name in string form into a new
        /// <see cref="SinkName"/> instance.
        /// </summary>
        /// <param name="sinkName">The sink resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SinkName"/> if successful.</returns>
        public static SinkName Parse(string sinkName)
        {
            GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName));
            TemplatedResourceName resourceName = s_template.ParseName(sinkName);
            return new SinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given sink resource name in string form into a new
        /// <see cref="SinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="sinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sinkName">The sink resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sinkName, out SinkName result)
        {
            GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(sinkName, out resourceName))
            {
                result = new SinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="sinkId">The sink ID. Must not be <c>null</c>.</param>
        public SinkName(string projectId, string sinkId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SinkId = GaxPreconditions.CheckNotNull(sinkId, nameof(sinkId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The sink ID. Never <c>null</c>.
        /// </summary>
        public string SinkId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SinkName);

        /// <inheritdoc />
        public bool Equals(SinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SinkName a, SinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SinkName a, SinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'metric' resource.
    /// </summary>
    public sealed partial class MetricName : IResourceName, IEquatable<MetricName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/metrics/{metric}");

        /// <summary>
        /// Parses the given metric resource name in string form into a new
        /// <see cref="MetricName"/> instance.
        /// </summary>
        /// <param name="metricName">The metric resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricName"/> if successful.</returns>
        public static MetricName Parse(string metricName)
        {
            GaxPreconditions.CheckNotNull(metricName, nameof(metricName));
            TemplatedResourceName resourceName = s_template.ParseName(metricName);
            return new MetricName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given metric resource name in string form into a new
        /// <see cref="MetricName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="metricName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="metricName">The metric resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MetricName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricName, out MetricName result)
        {
            GaxPreconditions.CheckNotNull(metricName, nameof(metricName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(metricName, out resourceName))
            {
                result = new MetricName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MetricName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="metricId">The metric ID. Must not be <c>null</c>.</param>
        public MetricName(string projectId, string metricId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            MetricId = GaxPreconditions.CheckNotNull(metricId, nameof(metricId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The metric ID. Never <c>null</c>.
        /// </summary>
        public string MetricId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, MetricId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MetricName);

        /// <inheritdoc />
        public bool Equals(MetricName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MetricName a, MetricName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MetricName a, MetricName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization' resource.
    /// </summary>
    public sealed partial class OrganizationName : IResourceName, IEquatable<OrganizationName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}");

        /// <summary>
        /// Parses the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationName);
            return new OrganizationName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationName, out resourceName))
            {
                result = new OrganizationName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationName(string organizationId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationName);

        /// <inheritdoc />
        public bool Equals(OrganizationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationName a, OrganizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationName a, OrganizationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_log' resource.
    /// </summary>
    public sealed partial class OrganizationLogName : IResourceName, IEquatable<OrganizationLogName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}/logs/{log}");

        /// <summary>
        /// Parses the given organization_log resource name in string form into a new
        /// <see cref="OrganizationLogName"/> instance.
        /// </summary>
        /// <param name="organizationLogName">The organization_log resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLogName"/> if successful.</returns>
        public static OrganizationLogName Parse(string organizationLogName)
        {
            GaxPreconditions.CheckNotNull(organizationLogName, nameof(organizationLogName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationLogName);
            return new OrganizationLogName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_log resource name in string form into a new
        /// <see cref="OrganizationLogName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationLogName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationLogName">The organization_log resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationLogName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLogName, out OrganizationLogName result)
        {
            GaxPreconditions.CheckNotNull(organizationLogName, nameof(organizationLogName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationLogName, out resourceName))
            {
                result = new OrganizationLogName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationLogName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="logId">The log ID. Must not be <c>null</c>.</param>
        public OrganizationLogName(string organizationId, string logId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            LogId = GaxPreconditions.CheckNotNull(logId, nameof(logId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The log ID. Never <c>null</c>.
        /// </summary>
        public string LogId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, LogId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationLogName);

        /// <inheritdoc />
        public bool Equals(OrganizationLogName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationLogName a, OrganizationLogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationLogName a, OrganizationLogName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_sink' resource.
    /// </summary>
    public sealed partial class OrganizationSinkName : IResourceName, IEquatable<OrganizationSinkName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}/sinks/{sink}");

        /// <summary>
        /// Parses the given organization_sink resource name in string form into a new
        /// <see cref="OrganizationSinkName"/> instance.
        /// </summary>
        /// <param name="organizationSinkName">The organization_sink resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationSinkName"/> if successful.</returns>
        public static OrganizationSinkName Parse(string organizationSinkName)
        {
            GaxPreconditions.CheckNotNull(organizationSinkName, nameof(organizationSinkName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationSinkName);
            return new OrganizationSinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_sink resource name in string form into a new
        /// <see cref="OrganizationSinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationSinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationSinkName">The organization_sink resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationSinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSinkName, out OrganizationSinkName result)
        {
            GaxPreconditions.CheckNotNull(organizationSinkName, nameof(organizationSinkName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationSinkName, out resourceName))
            {
                result = new OrganizationSinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationSinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="sinkId">The sink ID. Must not be <c>null</c>.</param>
        public OrganizationSinkName(string organizationId, string sinkId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            SinkId = GaxPreconditions.CheckNotNull(sinkId, nameof(sinkId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The sink ID. Never <c>null</c>.
        /// </summary>
        public string SinkId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, SinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationSinkName);

        /// <inheritdoc />
        public bool Equals(OrganizationSinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationSinkName a, OrganizationSinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationSinkName a, OrganizationSinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'folder' resource.
    /// </summary>
    public sealed partial class FolderName : IResourceName, IEquatable<FolderName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("folders/{folder}");

        /// <summary>
        /// Parses the given folder resource name in string form into a new
        /// <see cref="FolderName"/> instance.
        /// </summary>
        /// <param name="folderName">The folder resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderName"/> if successful.</returns>
        public static FolderName Parse(string folderName)
        {
            GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            TemplatedResourceName resourceName = s_template.ParseName(folderName);
            return new FolderName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given folder resource name in string form into a new
        /// <see cref="FolderName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="folderName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="folderName">The folder resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FolderName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderName, out FolderName result)
        {
            GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(folderName, out resourceName))
            {
                result = new FolderName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FolderName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="folderId">The folder ID. Must not be <c>null</c>.</param>
        public FolderName(string folderId)
        {
            FolderId = GaxPreconditions.CheckNotNull(folderId, nameof(folderId));
        }

        /// <summary>
        /// The folder ID. Never <c>null</c>.
        /// </summary>
        public string FolderId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(FolderId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FolderName);

        /// <inheritdoc />
        public bool Equals(FolderName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FolderName a, FolderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FolderName a, FolderName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'folder_log' resource.
    /// </summary>
    public sealed partial class FolderLogName : IResourceName, IEquatable<FolderLogName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("folders/{folder}/logs/{log}");

        /// <summary>
        /// Parses the given folder_log resource name in string form into a new
        /// <see cref="FolderLogName"/> instance.
        /// </summary>
        /// <param name="folderLogName">The folder_log resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLogName"/> if successful.</returns>
        public static FolderLogName Parse(string folderLogName)
        {
            GaxPreconditions.CheckNotNull(folderLogName, nameof(folderLogName));
            TemplatedResourceName resourceName = s_template.ParseName(folderLogName);
            return new FolderLogName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given folder_log resource name in string form into a new
        /// <see cref="FolderLogName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="folderLogName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="folderLogName">The folder_log resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FolderLogName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLogName, out FolderLogName result)
        {
            GaxPreconditions.CheckNotNull(folderLogName, nameof(folderLogName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(folderLogName, out resourceName))
            {
                result = new FolderLogName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FolderLogName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="folderId">The folder ID. Must not be <c>null</c>.</param>
        /// <param name="logId">The log ID. Must not be <c>null</c>.</param>
        public FolderLogName(string folderId, string logId)
        {
            FolderId = GaxPreconditions.CheckNotNull(folderId, nameof(folderId));
            LogId = GaxPreconditions.CheckNotNull(logId, nameof(logId));
        }

        /// <summary>
        /// The folder ID. Never <c>null</c>.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The log ID. Never <c>null</c>.
        /// </summary>
        public string LogId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(FolderId, LogId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FolderLogName);

        /// <inheritdoc />
        public bool Equals(FolderLogName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FolderLogName a, FolderLogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FolderLogName a, FolderLogName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'folder_sink' resource.
    /// </summary>
    public sealed partial class FolderSinkName : IResourceName, IEquatable<FolderSinkName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("folders/{folder}/sinks/{sink}");

        /// <summary>
        /// Parses the given folder_sink resource name in string form into a new
        /// <see cref="FolderSinkName"/> instance.
        /// </summary>
        /// <param name="folderSinkName">The folder_sink resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderSinkName"/> if successful.</returns>
        public static FolderSinkName Parse(string folderSinkName)
        {
            GaxPreconditions.CheckNotNull(folderSinkName, nameof(folderSinkName));
            TemplatedResourceName resourceName = s_template.ParseName(folderSinkName);
            return new FolderSinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given folder_sink resource name in string form into a new
        /// <see cref="FolderSinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="folderSinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="folderSinkName">The folder_sink resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FolderSinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderSinkName, out FolderSinkName result)
        {
            GaxPreconditions.CheckNotNull(folderSinkName, nameof(folderSinkName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(folderSinkName, out resourceName))
            {
                result = new FolderSinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FolderSinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="folderId">The folder ID. Must not be <c>null</c>.</param>
        /// <param name="sinkId">The sink ID. Must not be <c>null</c>.</param>
        public FolderSinkName(string folderId, string sinkId)
        {
            FolderId = GaxPreconditions.CheckNotNull(folderId, nameof(folderId));
            SinkId = GaxPreconditions.CheckNotNull(sinkId, nameof(sinkId));
        }

        /// <summary>
        /// The folder ID. Never <c>null</c>.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The sink ID. Never <c>null</c>.
        /// </summary>
        public string SinkId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(FolderId, SinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FolderSinkName);

        /// <inheritdoc />
        public bool Equals(FolderSinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FolderSinkName a, FolderSinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FolderSinkName a, FolderSinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'billing' resource.
    /// </summary>
    public sealed partial class BillingName : IResourceName, IEquatable<BillingName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("billingAccounts/{billing_account}");

        /// <summary>
        /// Parses the given billing resource name in string form into a new
        /// <see cref="BillingName"/> instance.
        /// </summary>
        /// <param name="billingName">The billing resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingName"/> if successful.</returns>
        public static BillingName Parse(string billingName)
        {
            GaxPreconditions.CheckNotNull(billingName, nameof(billingName));
            TemplatedResourceName resourceName = s_template.ParseName(billingName);
            return new BillingName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given billing resource name in string form into a new
        /// <see cref="BillingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="billingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="billingName">The billing resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BillingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingName, out BillingName result)
        {
            GaxPreconditions.CheckNotNull(billingName, nameof(billingName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(billingName, out resourceName))
            {
                result = new BillingName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="BillingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="billingAccountId">The billingAccount ID. Must not be <c>null</c>.</param>
        public BillingName(string billingAccountId)
        {
            BillingAccountId = GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId));
        }

        /// <summary>
        /// The billingAccount ID. Never <c>null</c>.
        /// </summary>
        public string BillingAccountId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(BillingAccountId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BillingName);

        /// <inheritdoc />
        public bool Equals(BillingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BillingName a, BillingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BillingName a, BillingName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'billing_log' resource.
    /// </summary>
    public sealed partial class BillingLogName : IResourceName, IEquatable<BillingLogName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("billingAccounts/{billing_account}/logs/{log}");

        /// <summary>
        /// Parses the given billing_log resource name in string form into a new
        /// <see cref="BillingLogName"/> instance.
        /// </summary>
        /// <param name="billingLogName">The billing_log resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingLogName"/> if successful.</returns>
        public static BillingLogName Parse(string billingLogName)
        {
            GaxPreconditions.CheckNotNull(billingLogName, nameof(billingLogName));
            TemplatedResourceName resourceName = s_template.ParseName(billingLogName);
            return new BillingLogName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given billing_log resource name in string form into a new
        /// <see cref="BillingLogName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="billingLogName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="billingLogName">The billing_log resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BillingLogName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingLogName, out BillingLogName result)
        {
            GaxPreconditions.CheckNotNull(billingLogName, nameof(billingLogName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(billingLogName, out resourceName))
            {
                result = new BillingLogName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="BillingLogName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="billingAccountId">The billingAccount ID. Must not be <c>null</c>.</param>
        /// <param name="logId">The log ID. Must not be <c>null</c>.</param>
        public BillingLogName(string billingAccountId, string logId)
        {
            BillingAccountId = GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId));
            LogId = GaxPreconditions.CheckNotNull(logId, nameof(logId));
        }

        /// <summary>
        /// The billingAccount ID. Never <c>null</c>.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The log ID. Never <c>null</c>.
        /// </summary>
        public string LogId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(BillingAccountId, LogId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BillingLogName);

        /// <inheritdoc />
        public bool Equals(BillingLogName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BillingLogName a, BillingLogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BillingLogName a, BillingLogName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'billing_sink' resource.
    /// </summary>
    public sealed partial class BillingSinkName : IResourceName, IEquatable<BillingSinkName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("billingAccounts/{billing_account}/sinks/{sink}");

        /// <summary>
        /// Parses the given billing_sink resource name in string form into a new
        /// <see cref="BillingSinkName"/> instance.
        /// </summary>
        /// <param name="billingSinkName">The billing_sink resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingSinkName"/> if successful.</returns>
        public static BillingSinkName Parse(string billingSinkName)
        {
            GaxPreconditions.CheckNotNull(billingSinkName, nameof(billingSinkName));
            TemplatedResourceName resourceName = s_template.ParseName(billingSinkName);
            return new BillingSinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given billing_sink resource name in string form into a new
        /// <see cref="BillingSinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="billingSinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="billingSinkName">The billing_sink resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BillingSinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingSinkName, out BillingSinkName result)
        {
            GaxPreconditions.CheckNotNull(billingSinkName, nameof(billingSinkName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(billingSinkName, out resourceName))
            {
                result = new BillingSinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="BillingSinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="billingAccountId">The billingAccount ID. Must not be <c>null</c>.</param>
        /// <param name="sinkId">The sink ID. Must not be <c>null</c>.</param>
        public BillingSinkName(string billingAccountId, string sinkId)
        {
            BillingAccountId = GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId));
            SinkId = GaxPreconditions.CheckNotNull(sinkId, nameof(sinkId));
        }

        /// <summary>
        /// The billingAccount ID. Never <c>null</c>.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The sink ID. Never <c>null</c>.
        /// </summary>
        public string SinkId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(BillingAccountId, SinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BillingSinkName);

        /// <inheritdoc />
        public bool Equals(BillingSinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BillingSinkName a, BillingSinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BillingSinkName a, BillingSinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>ProjectName: A resource of type 'project'.</description></item>
    /// <item><description>OrganizationName: A resource of type 'organization'.</description></item>
    /// <item><description>FolderName: A resource of type 'folder'.</description></item>
    /// <item><description>BillingName: A resource of type 'billing'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class ParentNameOneof : IResourceName, IEquatable<ParentNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="ParentNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'project'.
            /// </summary>
            ProjectName = 1,

            /// <summary>
            /// A resource of type 'organization'.
            /// </summary>
            OrganizationName = 2,

            /// <summary>
            /// A resource of type 'folder'.
            /// </summary>
            FolderName = 3,

            /// <summary>
            /// A resource of type 'billing'.
            /// </summary>
            BillingName = 4,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// <item><description>OrganizationName: A resource of type 'organization'.</description></item>
        /// <item><description>FolderName: A resource of type 'folder'.</description></item>
        /// <item><description>BillingName: A resource of type 'billing'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="ParentNameOneof"/> if successful.</returns>
        public static ParentNameOneof Parse(string name, bool allowUnknown)
        {
            ParentNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// <item><description>OrganizationName: A resource of type 'organization'.</description></item>
        /// <item><description>FolderName: A resource of type 'folder'.</description></item>
        /// <item><description>BillingName: A resource of type 'billing'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out ParentNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            ProjectName projectName;
            if (ProjectName.TryParse(name, out projectName))
            {
                result = new ParentNameOneof(OneofType.ProjectName, projectName);
                return true;
            }
            OrganizationName organizationName;
            if (OrganizationName.TryParse(name, out organizationName))
            {
                result = new ParentNameOneof(OneofType.OrganizationName, organizationName);
                return true;
            }
            FolderName folderName;
            if (FolderName.TryParse(name, out folderName))
            {
                result = new ParentNameOneof(OneofType.FolderName, folderName);
                return true;
            }
            BillingName billingName;
            if (BillingName.TryParse(name, out billingName))
            {
                result = new ParentNameOneof(OneofType.BillingName, billingName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new ParentNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="ProjectName"/>
        /// </summary>
        /// <param name="projectName">The <see cref="ProjectName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="projectName"/>.</returns>
        public static ParentNameOneof From(ProjectName projectName) => new ParentNameOneof(OneofType.ProjectName, projectName);

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="OrganizationName"/>
        /// </summary>
        /// <param name="organizationName">The <see cref="OrganizationName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="organizationName"/>.</returns>
        public static ParentNameOneof From(OrganizationName organizationName) => new ParentNameOneof(OneofType.OrganizationName, organizationName);

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="FolderName"/>
        /// </summary>
        /// <param name="folderName">The <see cref="FolderName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="folderName"/>.</returns>
        public static ParentNameOneof From(FolderName folderName) => new ParentNameOneof(OneofType.FolderName, folderName);

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="BillingName"/>
        /// </summary>
        /// <param name="billingName">The <see cref="BillingName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="billingName"/>.</returns>
        public static ParentNameOneof From(BillingName billingName) => new ParentNameOneof(OneofType.BillingName, billingName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.ProjectName: return name is ProjectName;
                case OneofType.OrganizationName: return name is OrganizationName;
                case OneofType.FolderName: return name is FolderName;
                case OneofType.BillingName: return name is BillingName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ParentNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public ParentNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="ProjectName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectName"/>.
        /// </remarks>
        public ProjectName ProjectName => CheckAndReturn<ProjectName>(OneofType.ProjectName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="OrganizationName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationName"/>.
        /// </remarks>
        public OrganizationName OrganizationName => CheckAndReturn<OrganizationName>(OneofType.OrganizationName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="FolderName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="FolderName"/>.
        /// </remarks>
        public FolderName FolderName => CheckAndReturn<FolderName>(OneofType.FolderName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="BillingName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="BillingName"/>.
        /// </remarks>
        public BillingName BillingName => CheckAndReturn<BillingName>(OneofType.BillingName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ParentNameOneof);

        /// <inheritdoc />
        public bool Equals(ParentNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ParentNameOneof a, ParentNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ParentNameOneof a, ParentNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>SinkName: A resource of type 'sink'.</description></item>
    /// <item><description>OrganizationSinkName: A resource of type 'organization_sink'.</description></item>
    /// <item><description>FolderSinkName: A resource of type 'folder_sink'.</description></item>
    /// <item><description>BillingSinkName: A resource of type 'billing_sink'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class SinkNameOneof : IResourceName, IEquatable<SinkNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="SinkNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'sink'.
            /// </summary>
            SinkName = 1,

            /// <summary>
            /// A resource of type 'organization_sink'.
            /// </summary>
            OrganizationSinkName = 2,

            /// <summary>
            /// A resource of type 'folder_sink'.
            /// </summary>
            FolderSinkName = 3,

            /// <summary>
            /// A resource of type 'billing_sink'.
            /// </summary>
            BillingSinkName = 4,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="SinkNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>SinkName: A resource of type 'sink'.</description></item>
        /// <item><description>OrganizationSinkName: A resource of type 'organization_sink'.</description></item>
        /// <item><description>FolderSinkName: A resource of type 'folder_sink'.</description></item>
        /// <item><description>BillingSinkName: A resource of type 'billing_sink'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="SinkNameOneof"/> if successful.</returns>
        public static SinkNameOneof Parse(string name, bool allowUnknown)
        {
            SinkNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="SinkNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>SinkName: A resource of type 'sink'.</description></item>
        /// <item><description>OrganizationSinkName: A resource of type 'organization_sink'.</description></item>
        /// <item><description>FolderSinkName: A resource of type 'folder_sink'.</description></item>
        /// <item><description>BillingSinkName: A resource of type 'billing_sink'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SinkNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out SinkNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            SinkName sinkName;
            if (SinkName.TryParse(name, out sinkName))
            {
                result = new SinkNameOneof(OneofType.SinkName, sinkName);
                return true;
            }
            OrganizationSinkName organizationSinkName;
            if (OrganizationSinkName.TryParse(name, out organizationSinkName))
            {
                result = new SinkNameOneof(OneofType.OrganizationSinkName, organizationSinkName);
                return true;
            }
            FolderSinkName folderSinkName;
            if (FolderSinkName.TryParse(name, out folderSinkName))
            {
                result = new SinkNameOneof(OneofType.FolderSinkName, folderSinkName);
                return true;
            }
            BillingSinkName billingSinkName;
            if (BillingSinkName.TryParse(name, out billingSinkName))
            {
                result = new SinkNameOneof(OneofType.BillingSinkName, billingSinkName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new SinkNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="SinkNameOneof"/> from the provided <see cref="SinkName"/>
        /// </summary>
        /// <param name="sinkName">The <see cref="SinkName"/> to be contained within
        /// the returned <see cref="SinkNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="SinkNameOneof"/>, containing <paramref name="sinkName"/>.</returns>
        public static SinkNameOneof From(SinkName sinkName) => new SinkNameOneof(OneofType.SinkName, sinkName);

        /// <summary>
        /// Construct a new instance of <see cref="SinkNameOneof"/> from the provided <see cref="OrganizationSinkName"/>
        /// </summary>
        /// <param name="organizationSinkName">The <see cref="OrganizationSinkName"/> to be contained within
        /// the returned <see cref="SinkNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="SinkNameOneof"/>, containing <paramref name="organizationSinkName"/>.</returns>
        public static SinkNameOneof From(OrganizationSinkName organizationSinkName) => new SinkNameOneof(OneofType.OrganizationSinkName, organizationSinkName);

        /// <summary>
        /// Construct a new instance of <see cref="SinkNameOneof"/> from the provided <see cref="FolderSinkName"/>
        /// </summary>
        /// <param name="folderSinkName">The <see cref="FolderSinkName"/> to be contained within
        /// the returned <see cref="SinkNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="SinkNameOneof"/>, containing <paramref name="folderSinkName"/>.</returns>
        public static SinkNameOneof From(FolderSinkName folderSinkName) => new SinkNameOneof(OneofType.FolderSinkName, folderSinkName);

        /// <summary>
        /// Construct a new instance of <see cref="SinkNameOneof"/> from the provided <see cref="BillingSinkName"/>
        /// </summary>
        /// <param name="billingSinkName">The <see cref="BillingSinkName"/> to be contained within
        /// the returned <see cref="SinkNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="SinkNameOneof"/>, containing <paramref name="billingSinkName"/>.</returns>
        public static SinkNameOneof From(BillingSinkName billingSinkName) => new SinkNameOneof(OneofType.BillingSinkName, billingSinkName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.SinkName: return name is SinkName;
                case OneofType.OrganizationSinkName: return name is OrganizationSinkName;
                case OneofType.FolderSinkName: return name is FolderSinkName;
                case OneofType.BillingSinkName: return name is BillingSinkName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SinkNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public SinkNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="SinkName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="SinkName"/>.
        /// </remarks>
        public SinkName SinkName => CheckAndReturn<SinkName>(OneofType.SinkName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="OrganizationSinkName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationSinkName"/>.
        /// </remarks>
        public OrganizationSinkName OrganizationSinkName => CheckAndReturn<OrganizationSinkName>(OneofType.OrganizationSinkName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="FolderSinkName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="FolderSinkName"/>.
        /// </remarks>
        public FolderSinkName FolderSinkName => CheckAndReturn<FolderSinkName>(OneofType.FolderSinkName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="BillingSinkName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="BillingSinkName"/>.
        /// </remarks>
        public BillingSinkName BillingSinkName => CheckAndReturn<BillingSinkName>(OneofType.BillingSinkName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SinkNameOneof);

        /// <inheritdoc />
        public bool Equals(SinkNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SinkNameOneof a, SinkNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SinkNameOneof a, SinkNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>LogName: A resource of type 'log'.</description></item>
    /// <item><description>OrganizationLogName: A resource of type 'organization_log'.</description></item>
    /// <item><description>FolderLogName: A resource of type 'folder_log'.</description></item>
    /// <item><description>BillingLogName: A resource of type 'billing_log'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class LogNameOneof : IResourceName, IEquatable<LogNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="LogNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'log'.
            /// </summary>
            LogName = 1,

            /// <summary>
            /// A resource of type 'organization_log'.
            /// </summary>
            OrganizationLogName = 2,

            /// <summary>
            /// A resource of type 'folder_log'.
            /// </summary>
            FolderLogName = 3,

            /// <summary>
            /// A resource of type 'billing_log'.
            /// </summary>
            BillingLogName = 4,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="LogNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LogName: A resource of type 'log'.</description></item>
        /// <item><description>OrganizationLogName: A resource of type 'organization_log'.</description></item>
        /// <item><description>FolderLogName: A resource of type 'folder_log'.</description></item>
        /// <item><description>BillingLogName: A resource of type 'billing_log'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="LogNameOneof"/> if successful.</returns>
        public static LogNameOneof Parse(string name, bool allowUnknown)
        {
            LogNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="LogNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LogName: A resource of type 'log'.</description></item>
        /// <item><description>OrganizationLogName: A resource of type 'organization_log'.</description></item>
        /// <item><description>FolderLogName: A resource of type 'folder_log'.</description></item>
        /// <item><description>BillingLogName: A resource of type 'billing_log'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out LogNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            LogName logName;
            if (LogName.TryParse(name, out logName))
            {
                result = new LogNameOneof(OneofType.LogName, logName);
                return true;
            }
            OrganizationLogName organizationLogName;
            if (OrganizationLogName.TryParse(name, out organizationLogName))
            {
                result = new LogNameOneof(OneofType.OrganizationLogName, organizationLogName);
                return true;
            }
            FolderLogName folderLogName;
            if (FolderLogName.TryParse(name, out folderLogName))
            {
                result = new LogNameOneof(OneofType.FolderLogName, folderLogName);
                return true;
            }
            BillingLogName billingLogName;
            if (BillingLogName.TryParse(name, out billingLogName))
            {
                result = new LogNameOneof(OneofType.BillingLogName, billingLogName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new LogNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="LogNameOneof"/> from the provided <see cref="LogName"/>
        /// </summary>
        /// <param name="logName">The <see cref="LogName"/> to be contained within
        /// the returned <see cref="LogNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="LogNameOneof"/>, containing <paramref name="logName"/>.</returns>
        public static LogNameOneof From(LogName logName) => new LogNameOneof(OneofType.LogName, logName);

        /// <summary>
        /// Construct a new instance of <see cref="LogNameOneof"/> from the provided <see cref="OrganizationLogName"/>
        /// </summary>
        /// <param name="organizationLogName">The <see cref="OrganizationLogName"/> to be contained within
        /// the returned <see cref="LogNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="LogNameOneof"/>, containing <paramref name="organizationLogName"/>.</returns>
        public static LogNameOneof From(OrganizationLogName organizationLogName) => new LogNameOneof(OneofType.OrganizationLogName, organizationLogName);

        /// <summary>
        /// Construct a new instance of <see cref="LogNameOneof"/> from the provided <see cref="FolderLogName"/>
        /// </summary>
        /// <param name="folderLogName">The <see cref="FolderLogName"/> to be contained within
        /// the returned <see cref="LogNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="LogNameOneof"/>, containing <paramref name="folderLogName"/>.</returns>
        public static LogNameOneof From(FolderLogName folderLogName) => new LogNameOneof(OneofType.FolderLogName, folderLogName);

        /// <summary>
        /// Construct a new instance of <see cref="LogNameOneof"/> from the provided <see cref="BillingLogName"/>
        /// </summary>
        /// <param name="billingLogName">The <see cref="BillingLogName"/> to be contained within
        /// the returned <see cref="LogNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="LogNameOneof"/>, containing <paramref name="billingLogName"/>.</returns>
        public static LogNameOneof From(BillingLogName billingLogName) => new LogNameOneof(OneofType.BillingLogName, billingLogName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.LogName: return name is LogName;
                case OneofType.OrganizationLogName: return name is OrganizationLogName;
                case OneofType.FolderLogName: return name is FolderLogName;
                case OneofType.BillingLogName: return name is BillingLogName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LogNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public LogNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="LogName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LogName"/>.
        /// </remarks>
        public LogName LogName => CheckAndReturn<LogName>(OneofType.LogName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="OrganizationLogName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationLogName"/>.
        /// </remarks>
        public OrganizationLogName OrganizationLogName => CheckAndReturn<OrganizationLogName>(OneofType.OrganizationLogName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="FolderLogName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="FolderLogName"/>.
        /// </remarks>
        public FolderLogName FolderLogName => CheckAndReturn<FolderLogName>(OneofType.FolderLogName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="BillingLogName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="BillingLogName"/>.
        /// </remarks>
        public BillingLogName BillingLogName => CheckAndReturn<BillingLogName>(OneofType.BillingLogName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogNameOneof);

        /// <inheritdoc />
        public bool Equals(LogNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogNameOneof a, LogNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogNameOneof a, LogNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>MetricName: A resource of type 'metric'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class MetricNameOneof : IResourceName, IEquatable<MetricNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="MetricNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'metric'.
            /// </summary>
            MetricName = 1,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="MetricNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>MetricName: A resource of type 'metric'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="MetricNameOneof"/> if successful.</returns>
        public static MetricNameOneof Parse(string name, bool allowUnknown)
        {
            MetricNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="MetricNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>MetricName: A resource of type 'metric'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MetricNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out MetricNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            MetricName metricName;
            if (MetricName.TryParse(name, out metricName))
            {
                result = new MetricNameOneof(OneofType.MetricName, metricName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new MetricNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="MetricNameOneof"/> from the provided <see cref="MetricName"/>
        /// </summary>
        /// <param name="metricName">The <see cref="MetricName"/> to be contained within
        /// the returned <see cref="MetricNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="MetricNameOneof"/>, containing <paramref name="metricName"/>.</returns>
        public static MetricNameOneof From(MetricName metricName) => new MetricNameOneof(OneofType.MetricName, metricName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.MetricName: return name is MetricName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MetricNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public MetricNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="MetricName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="MetricName"/>.
        /// </remarks>
        public MetricName MetricName => CheckAndReturn<MetricName>(OneofType.MetricName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MetricNameOneof);

        /// <inheritdoc />
        public bool Equals(MetricNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MetricNameOneof a, MetricNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MetricNameOneof a, MetricNameOneof b) => !(a == b);
    }


    public partial class CreateLogMetricRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSinkRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteLogMetricRequest
    {
        /// <summary>
        /// <see cref="MetricNameOneof"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public MetricNameOneof MetricNameAsMetricNameOneof
        {
            get { return string.IsNullOrEmpty(MetricName) ? null : Google.Cloud.Logging.V2.MetricNameOneof.Parse(MetricName, true); }
            set { MetricName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteLogRequest
    {
        /// <summary>
        /// <see cref="LogNameOneof"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public LogNameOneof LogNameAsLogNameOneof
        {
            get { return string.IsNullOrEmpty(LogName) ? null : Google.Cloud.Logging.V2.LogNameOneof.Parse(LogName, true); }
            set { LogName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSinkRequest
    {
        /// <summary>
        /// <see cref="SinkNameOneof"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public SinkNameOneof SinkNameAsSinkNameOneof
        {
            get { return string.IsNullOrEmpty(SinkName) ? null : Google.Cloud.Logging.V2.SinkNameOneof.Parse(SinkName, true); }
            set { SinkName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetLogMetricRequest
    {
        /// <summary>
        /// <see cref="MetricNameOneof"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public MetricNameOneof MetricNameAsMetricNameOneof
        {
            get { return string.IsNullOrEmpty(MetricName) ? null : Google.Cloud.Logging.V2.MetricNameOneof.Parse(MetricName, true); }
            set { MetricName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSinkRequest
    {
        /// <summary>
        /// <see cref="SinkNameOneof"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public SinkNameOneof SinkNameAsSinkNameOneof
        {
            get { return string.IsNullOrEmpty(SinkName) ? null : Google.Cloud.Logging.V2.SinkNameOneof.Parse(SinkName, true); }
            set { SinkName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListLogMetricsRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListLogsRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListSinksRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogEntry
    {
        /// <summary>
        /// <see cref="LogNameOneof"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public LogNameOneof LogNameAsLogNameOneof
        {
            get { return string.IsNullOrEmpty(LogName) ? null : Google.Cloud.Logging.V2.LogNameOneof.Parse(LogName, true); }
            set { LogName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogSink
    {
        /// <summary>
        /// <see cref="IResourceName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public IResourceName DestinationAsResourceName
        {
            get { return string.IsNullOrEmpty(Destination) ? null : UnknownResourceName.Parse(Destination); }
            set { Destination = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateLogMetricRequest
    {
        /// <summary>
        /// <see cref="MetricNameOneof"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public MetricNameOneof MetricNameAsMetricNameOneof
        {
            get { return string.IsNullOrEmpty(MetricName) ? null : Google.Cloud.Logging.V2.MetricNameOneof.Parse(MetricName, true); }
            set { MetricName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateSinkRequest
    {
        /// <summary>
        /// <see cref="SinkNameOneof"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public SinkNameOneof SinkNameAsSinkNameOneof
        {
            get { return string.IsNullOrEmpty(SinkName) ? null : Google.Cloud.Logging.V2.SinkNameOneof.Parse(SinkName, true); }
            set { SinkName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class WriteLogEntriesRequest
    {
        /// <summary>
        /// <see cref="LogNameOneof"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public LogNameOneof LogNameAsLogNameOneof
        {
            get { return string.IsNullOrEmpty(LogName) ? null : Google.Cloud.Logging.V2.LogNameOneof.Parse(LogName, true); }
            set { LogName = value != null ? value.ToString() : ""; }
        }

    }

}