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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gclv = Google.Cloud.Logging.V2;
using sys = System;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Resource name for the <c>LogMetric</c> resource.</summary>
    public sealed partial class LogMetricName : gax::IResourceName, sys::IEquatable<LogMetricName>
    {
        /// <summary>The possible contents of <see cref="LogMetricName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/metrics/{metric}</c>.</summary>
            ProjectMetric = 1,
        }

        private static gax::PathTemplate s_projectMetric = new gax::PathTemplate("projects/{project}/metrics/{metric}");

        /// <summary>Creates a <see cref="LogMetricName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogMetricName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogMetricName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogMetricName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogMetricName"/> with the pattern <c>projects/{project}/metrics/{metric}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogMetricName"/> constructed from the provided ids.</returns>
        public static LogMetricName FromProjectMetric(string projectId, string metricId) =>
            new LogMetricName(ResourceNameType.ProjectMetric, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), metricId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricId, nameof(metricId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogMetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogMetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </returns>
        public static string Format(string projectId, string metricId) => FormatProjectMetric(projectId, metricId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogMetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogMetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </returns>
        public static string FormatProjectMetric(string projectId, string metricId) =>
            s_projectMetric.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metricId, nameof(metricId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogMetricName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogMetricName"/> if successful.</returns>
        public static LogMetricName Parse(string logMetricName) => Parse(logMetricName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogMetricName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogMetricName"/> if successful.</returns>
        public static LogMetricName Parse(string logMetricName, bool allowUnparsed) =>
            TryParse(logMetricName, allowUnparsed, out LogMetricName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogMetricName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogMetricName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logMetricName, out LogMetricName result) => TryParse(logMetricName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogMetricName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logMetricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogMetricName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logMetricName, bool allowUnparsed, out LogMetricName result)
        {
            gax::GaxPreconditions.CheckNotNull(logMetricName, nameof(logMetricName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMetric.TryParseName(logMetricName, out resourceName))
            {
                result = FromProjectMetric(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logMetricName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogMetricName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string metricId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MetricId = metricId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogMetricName"/> class from the component parts of pattern
        /// <c>projects/{project}/metrics/{metric}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        public LogMetricName(string projectId, string metricId) : this(ResourceNameType.ProjectMetric, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), metricId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricId, nameof(metricId)))
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
        /// The <c>Metric</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MetricId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectMetric: return s_projectMetric.Expand(ProjectId, MetricId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogMetricName);

        /// <inheritdoc/>
        public bool Equals(LogMetricName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogMetricName a, LogMetricName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogMetricName a, LogMetricName b) => !(a == b);
    }

    public partial class LogMetric
    {
        /// <summary>
        /// <see cref="gclv::LogMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::LogMetricName LogMetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::LogMetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLogMetricsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLogMetricRequest
    {
        /// <summary>
        /// <see cref="LogMetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public LogMetricName MetricNameAsLogMetricName
        {
            get => string.IsNullOrEmpty(MetricName) ? null : LogMetricName.Parse(MetricName, allowUnparsed: true);
            set => MetricName = value?.ToString() ?? "";
        }
    }

    public partial class CreateLogMetricRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateLogMetricRequest
    {
        /// <summary>
        /// <see cref="LogMetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public LogMetricName MetricNameAsLogMetricName
        {
            get => string.IsNullOrEmpty(MetricName) ? null : LogMetricName.Parse(MetricName, allowUnparsed: true);
            set => MetricName = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLogMetricRequest
    {
        /// <summary>
        /// <see cref="LogMetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public LogMetricName MetricNameAsLogMetricName
        {
            get => string.IsNullOrEmpty(MetricName) ? null : LogMetricName.Parse(MetricName, allowUnparsed: true);
            set => MetricName = value?.ToString() ?? "";
        }
    }
}
