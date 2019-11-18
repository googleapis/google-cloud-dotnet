// Copyright 2019 Google LLC
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
using gcev = Google.Cloud.ErrorReporting.V1Beta1;
using sys = System;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>Resource name for the <c>ErrorGroup</c> resource.</summary>
    public sealed partial class ErrorGroupName : gax::IResourceName, sys::IEquatable<ErrorGroupName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Parses the given <c>ErrorGroup</c> resource name in string form into a new <see cref="ErrorGroupName"/>
        /// instance.
        /// </summary>
        /// <param name="errorGroupName">
        /// The <c>ErrorGroup</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ErrorGroupName"/> if successful.</returns>
        public static ErrorGroupName Parse(string errorGroupName)
        {
            gax::GaxPreconditions.CheckNotNull(errorGroupName, nameof(errorGroupName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(errorGroupName);
            return new ErrorGroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ErrorGroupName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="errorGroupName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="errorGroupName">
        /// The <c>ErrorGroup</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ErrorGroupName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string errorGroupName, out ErrorGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(errorGroupName, nameof(errorGroupName));
            if (s_template.TryParseName(errorGroupName, out gax::TemplatedResourceName resourceName))
            {
                result = new ErrorGroupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ErrorGroupName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ErrorGroupName"/>.</returns>
        public static string Format(string projectId, string groupId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(groupId, nameof(groupId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ErrorGroupName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="groupId">The <c>Group</c> ID. Must not be <c>null</c>.</param>
        public ErrorGroupName(string projectId, string groupId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GroupId = gax::GaxPreconditions.CheckNotNull(groupId, nameof(groupId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Group</c> ID. Never <c>null</c>.</summary>
        public string GroupId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, GroupId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ErrorGroupName);

        /// <inheritdoc/>
        public bool Equals(ErrorGroupName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ErrorGroupName a, ErrorGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ErrorGroupName a, ErrorGroupName b) => !(a == b);
    }

    public partial class ErrorGroup
    {
        /// <summary>
        /// <see cref="gcev::ErrorGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ErrorGroupName ErrorGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ErrorGroupName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
