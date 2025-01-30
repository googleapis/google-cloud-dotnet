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
using gax = Google.Api.Gax;
using gcbmv = Google.Cloud.BigQuery.Migration.V2;
using sys = System;

namespace Google.Cloud.BigQuery.Migration.V2
{
    /// <summary>Resource name for the <c>MigrationWorkflow</c> resource.</summary>
    public sealed partial class MigrationWorkflowName : gax::IResourceName, sys::IEquatable<MigrationWorkflowName>
    {
        /// <summary>The possible contents of <see cref="MigrationWorkflowName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
            /// </summary>
            ProjectLocationWorkflow = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkflow = new gax::PathTemplate("projects/{project}/locations/{location}/workflows/{workflow}");

        /// <summary>Creates a <see cref="MigrationWorkflowName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MigrationWorkflowName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MigrationWorkflowName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MigrationWorkflowName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MigrationWorkflowName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MigrationWorkflowName"/> constructed from the provided ids.</returns>
        public static MigrationWorkflowName FromProjectLocationWorkflow(string projectId, string locationId, string workflowId) =>
            new MigrationWorkflowName(ResourceNameType.ProjectLocationWorkflow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigrationWorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigrationWorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workflowId) =>
            FormatProjectLocationWorkflow(projectId, locationId, workflowId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigrationWorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigrationWorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkflow(string projectId, string locationId, string workflowId) =>
            s_projectLocationWorkflow.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MigrationWorkflowName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="migrationWorkflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MigrationWorkflowName"/> if successful.</returns>
        public static MigrationWorkflowName Parse(string migrationWorkflowName) => Parse(migrationWorkflowName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MigrationWorkflowName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migrationWorkflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MigrationWorkflowName"/> if successful.</returns>
        public static MigrationWorkflowName Parse(string migrationWorkflowName, bool allowUnparsed) =>
            TryParse(migrationWorkflowName, allowUnparsed, out MigrationWorkflowName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigrationWorkflowName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="migrationWorkflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigrationWorkflowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migrationWorkflowName, out MigrationWorkflowName result) =>
            TryParse(migrationWorkflowName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigrationWorkflowName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migrationWorkflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigrationWorkflowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migrationWorkflowName, bool allowUnparsed, out MigrationWorkflowName result)
        {
            gax::GaxPreconditions.CheckNotNull(migrationWorkflowName, nameof(migrationWorkflowName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkflow.TryParseName(migrationWorkflowName, out resourceName))
            {
                result = FromProjectLocationWorkflow(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(migrationWorkflowName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MigrationWorkflowName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workflowId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkflowId = workflowId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MigrationWorkflowName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        public MigrationWorkflowName(string projectId, string locationId, string workflowId) : this(ResourceNameType.ProjectLocationWorkflow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Workflow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkflowId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkflow: return s_projectLocationWorkflow.Expand(ProjectId, LocationId, WorkflowId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MigrationWorkflowName);

        /// <inheritdoc/>
        public bool Equals(MigrationWorkflowName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MigrationWorkflowName a, MigrationWorkflowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MigrationWorkflowName a, MigrationWorkflowName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MigrationSubtask</c> resource.</summary>
    public sealed partial class MigrationSubtaskName : gax::IResourceName, sys::IEquatable<MigrationSubtaskName>
    {
        /// <summary>The possible contents of <see cref="MigrationSubtaskName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>.
            /// </summary>
            ProjectLocationWorkflowSubtask = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkflowSubtask = new gax::PathTemplate("projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}");

        /// <summary>Creates a <see cref="MigrationSubtaskName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MigrationSubtaskName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MigrationSubtaskName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MigrationSubtaskName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MigrationSubtaskName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subtaskId">The <c>Subtask</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MigrationSubtaskName"/> constructed from the provided ids.</returns>
        public static MigrationSubtaskName FromProjectLocationWorkflowSubtask(string projectId, string locationId, string workflowId, string subtaskId) =>
            new MigrationSubtaskName(ResourceNameType.ProjectLocationWorkflowSubtask, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)), subtaskId: gax::GaxPreconditions.CheckNotNullOrEmpty(subtaskId, nameof(subtaskId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigrationSubtaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subtaskId">The <c>Subtask</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigrationSubtaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workflowId, string subtaskId) =>
            FormatProjectLocationWorkflowSubtask(projectId, locationId, workflowId, subtaskId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigrationSubtaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subtaskId">The <c>Subtask</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigrationSubtaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkflowSubtask(string projectId, string locationId, string workflowId, string subtaskId) =>
            s_projectLocationWorkflowSubtask.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subtaskId, nameof(subtaskId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MigrationSubtaskName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="migrationSubtaskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MigrationSubtaskName"/> if successful.</returns>
        public static MigrationSubtaskName Parse(string migrationSubtaskName) => Parse(migrationSubtaskName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MigrationSubtaskName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migrationSubtaskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MigrationSubtaskName"/> if successful.</returns>
        public static MigrationSubtaskName Parse(string migrationSubtaskName, bool allowUnparsed) =>
            TryParse(migrationSubtaskName, allowUnparsed, out MigrationSubtaskName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigrationSubtaskName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="migrationSubtaskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigrationSubtaskName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migrationSubtaskName, out MigrationSubtaskName result) =>
            TryParse(migrationSubtaskName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigrationSubtaskName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migrationSubtaskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigrationSubtaskName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migrationSubtaskName, bool allowUnparsed, out MigrationSubtaskName result)
        {
            gax::GaxPreconditions.CheckNotNull(migrationSubtaskName, nameof(migrationSubtaskName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkflowSubtask.TryParseName(migrationSubtaskName, out resourceName))
            {
                result = FromProjectLocationWorkflowSubtask(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(migrationSubtaskName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MigrationSubtaskName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string subtaskId = null, string workflowId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SubtaskId = subtaskId;
            WorkflowId = workflowId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MigrationSubtaskName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/subtasks/{subtask}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subtaskId">The <c>Subtask</c> ID. Must not be <c>null</c> or empty.</param>
        public MigrationSubtaskName(string projectId, string locationId, string workflowId, string subtaskId) : this(ResourceNameType.ProjectLocationWorkflowSubtask, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)), subtaskId: gax::GaxPreconditions.CheckNotNullOrEmpty(subtaskId, nameof(subtaskId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subtask</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubtaskId { get; }

        /// <summary>
        /// The <c>Workflow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkflowId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkflowSubtask: return s_projectLocationWorkflowSubtask.Expand(ProjectId, LocationId, WorkflowId, SubtaskId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MigrationSubtaskName);

        /// <inheritdoc/>
        public bool Equals(MigrationSubtaskName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MigrationSubtaskName a, MigrationSubtaskName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MigrationSubtaskName a, MigrationSubtaskName b) => !(a == b);
    }

    public partial class MigrationWorkflow
    {
        /// <summary>
        /// <see cref="gcbmv::MigrationWorkflowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbmv::MigrationWorkflowName MigrationWorkflowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbmv::MigrationWorkflowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MigrationSubtask
    {
        /// <summary>
        /// <see cref="gcbmv::MigrationSubtaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbmv::MigrationSubtaskName MigrationSubtaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbmv::MigrationSubtaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
