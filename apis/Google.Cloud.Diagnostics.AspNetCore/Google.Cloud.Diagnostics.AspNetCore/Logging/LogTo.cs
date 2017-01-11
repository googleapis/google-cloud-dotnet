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
using System;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// The location log entries will be logged to.
    /// </summary>
    public enum LogToLocation
    {
        /// <summary>A Google Cloud Platform project.</summary>
        Project,

        /// <summary>A Google Cloud Platform organization.</summary>
        Organization
    }

    /// <summary>
    /// Options for log entries will be logged, such as a project or organization.
    /// </summary>
    public sealed class LogTo
    {
        /// <summary>The location to log entries to.</summary>
        public LogToLocation Location { get; }

        /// <summary>The Google Cloud Platform project Id.</summary>
        public string ProjectId { get; }

        /// <summary>The Google Cloud Platform organization Id.</summary>
        public string OrganizationId { get; }

        internal LogTo(LogToLocation location, string projectId = null, string organizationId = null)
        {
            Location = GaxPreconditions.CheckEnumValue(location, nameof(location));
            ProjectId = projectId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Creates a <see cref="LogTo"/> for <see cref="LogToLocation.Project"/>
        /// </summary>
        public static LogTo Project(string projectId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            return new LogTo(LogToLocation.Project, projectId);
        }

        /// <summary>
        /// Creates a <see cref="LogTo"/> for <see cref="LogToLocation.Organization"/>
        /// </summary>
        public static LogTo Organization(string organizationId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId));
            return new LogTo(LogToLocation.Organization, null, organizationId);
        }

        /// <summary>
        /// Gets the full log name.
        /// See: https://cloud.google.com/logging/docs/api/reference/rest/v2/LogEntry.
        /// </summary>
        public string GetFullLogName(string name)
        {
            GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name));
            switch (Location)
            {
                case LogToLocation.Project:
                    GaxPreconditions.CheckNotNullOrEmpty(ProjectId, nameof(ProjectId));
                    return new LogName(ProjectId, name).ToString();
                case LogToLocation.Organization:
                    GaxPreconditions.CheckNotNullOrEmpty(OrganizationId, nameof(OrganizationId));
                    return new OrganizationLogName(OrganizationId, name).ToString();
                default:
                    throw new InvalidOperationException($"Unsupported location {Location}");
            }
        }
    }
}
