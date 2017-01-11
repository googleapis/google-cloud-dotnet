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
    public enum LogToLocation
    {
        Project,
        Organization
    }

    public sealed class LogTo
    {
        public LogToLocation Location { get; }

        public string ProjectId { get; }

        public string OrganizationId { get; }

        internal LogTo(LogToLocation location, string projectId = null, string organizationId = null)
        {
            Location = GaxPreconditions.CheckEnumValue(location, nameof(location));
            ProjectId = projectId;
            OrganizationId = organizationId;
        }

        public static LogTo Project(string projectId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            return new LogTo(LogToLocation.Project, projectId);
        }

        public static LogTo Organization(string organizationId)
        {
            GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId));
            return new LogTo(LogToLocation.Organization, null, organizationId);
        }

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
