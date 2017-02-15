// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// The location log entries will be logged to.
    /// </summary>
    public enum LogTargetKind
    {
        /// <summary>A Google Cloud Platform project.</summary>
        Project,

        /// <summary>A Google Cloud Platform organization.</summary>
        Organization
    }

    /// <summary>
    /// Represents the location log entries will be sent, such as a project or organization.
    /// </summary>
    public sealed class LogTarget
    {
        /// <summary>The location to log entries to.</summary>
        public LogTargetKind Kind { get; }

        /// <summary>The Google Cloud Platform project Id.</summary>
        public string ProjectId { get; }

        /// <summary>The Google Cloud Platform organization Id.</summary>
        public string OrganizationId { get; }

        private LogTarget(LogTargetKind kind, string projectId, string organizationId)
        {
            Kind = GaxPreconditions.CheckEnumValue(kind, nameof(kind));
            ProjectId = projectId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Creates a <see cref="LogTarget"/> instance for sending log entries to a <see cref="LogTargetKind.Project"/>.
        /// </summary>
        public static LogTarget ForProject(string projectId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            return new LogTarget(LogTargetKind.Project, projectId, null);
        }

        /// <summary>
        /// Creates a <see cref="LogTarget"/> instance for sending log entries to an <see cref="LogTargetKind.Organization"/>.
        /// </summary>
        public static LogTarget ForOrganization(string organizationId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId));
            return new LogTarget(LogTargetKind.Organization, null, organizationId);
        }

        /// <summary>
        /// Gets the full log name.
        /// See: https://cloud.google.com/logging/docs/api/reference/rest/v2/LogEntry.
        /// </summary>
        /// <param name="name">The name of the log which will be used with the project or organization
        ///     to create a full log name.</param>
        public string GetFullLogName(string name)
        {
            GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name));
            switch (Kind)
            {
                case LogTargetKind.Project:
                    return new LogName(ProjectId, name).ToString();
                case LogTargetKind.Organization:
                    return new OrganizationLogName(OrganizationId, name).ToString();
                default:
                    Debug.Assert(false, $"Unsupported location {Kind}");
                    return null;
            }
        }
    }
}
