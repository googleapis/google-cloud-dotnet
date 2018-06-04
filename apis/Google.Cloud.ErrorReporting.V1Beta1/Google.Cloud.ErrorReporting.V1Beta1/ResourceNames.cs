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
using gaxres = Google.Api.Gax.ResourceNames;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>
    /// Resource name for the 'group' resource.
    /// </summary>
    public sealed partial class GroupName : gax::IResourceName, sys::IEquatable<GroupName>
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
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="groupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="groupName">The group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
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


    public partial class DeleteEventsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : gaxres::ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ErrorGroup
    {
        /// <summary>
        /// <see cref="Google.Cloud.ErrorReporting.V1Beta1.GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.ErrorReporting.V1Beta1.GroupName GroupName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.ErrorReporting.V1Beta1.GroupName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetGroupRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.ErrorReporting.V1Beta1.GroupName"/>-typed view over the <see cref="GroupName"/> resource name property.
        /// </summary>
        public Google.Cloud.ErrorReporting.V1Beta1.GroupName GroupNameAsGroupName
        {
            get { return string.IsNullOrEmpty(GroupName) ? null : Google.Cloud.ErrorReporting.V1Beta1.GroupName.Parse(GroupName); }
            set { GroupName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListEventsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : gaxres::ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListGroupStatsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : gaxres::ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ReportErrorEventRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="ProjectName"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ProjectNameAsProjectName
        {
            get { return string.IsNullOrEmpty(ProjectName) ? null : gaxres::ProjectName.Parse(ProjectName); }
            set { ProjectName = value != null ? value.ToString() : ""; }
        }

    }

}