// Copyright 2016, Google Inc. All rights reserved.
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

namespace Google.Logging.V2
{
    /// <summary>
    /// Resource name for the 'parent' resource.
    /// </summary>
    public sealed partial class ParentName : IResourceName, IEquatable<ParentName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses a parent resource name in string form into a <see cref="ParentName"/>.
        /// </summary>
        /// <param name="parentName">The parent resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParentName"/> if successful.</returns>
        public static ParentName Parse(string parentName)
        {
            GaxPreconditions.CheckNotNull(parentName, nameof(parentName));
            TemplatedResourceName resourceName = s_template.ParseName(parentName);
            return new ParentName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse parent resource name in string form into a <see cref="ParentName"/>/
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="parentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="parentName">The parent resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parentName, out ParentName result)
        {
            GaxPreconditions.CheckNotNull(parentName, nameof(parentName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(parentName, out resourceName))
            {
                result = new ParentName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a parent name from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ParentName(string projectId)
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
        public override bool Equals(object obj) => Equals(obj as ParentName);

        /// <inheritdoc />
        public bool Equals(ParentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ParentName a, ParentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ParentName a, ParentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'sink' resource.
    /// </summary>
    public sealed partial class SinkName : IResourceName, IEquatable<SinkName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/sinks/{sink}");

        /// <summary>
        /// Parses a sink resource name in string form into a <see cref="SinkName"/>.
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
        /// Tries to parse sink resource name in string form into a <see cref="SinkName"/>/
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
        /// Constructs a sink name from its component parts.
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
        /// Parses a metric resource name in string form into a <see cref="MetricName"/>.
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
        /// Tries to parse metric resource name in string form into a <see cref="MetricName"/>/
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
        /// Constructs a metric name from its component parts.
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
    /// Resource name for the 'log' resource.
    /// </summary>
    public sealed partial class LogName : IResourceName, IEquatable<LogName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/logs/{log}");

        /// <summary>
        /// Parses a log resource name in string form into a <see cref="LogName"/>.
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
        /// Tries to parse log resource name in string form into a <see cref="LogName"/>/
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
        /// Constructs a log name from its component parts.
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



}