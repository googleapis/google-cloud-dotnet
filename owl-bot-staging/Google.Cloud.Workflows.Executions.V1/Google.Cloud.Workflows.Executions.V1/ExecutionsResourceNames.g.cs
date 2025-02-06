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
using gcwev = Google.Cloud.Workflows.Executions.V1;
using sys = System;

namespace Google.Cloud.Workflows.Executions.V1
{
    /// <summary>Resource name for the <c>Execution</c> resource.</summary>
    public sealed partial class ExecutionName : gax::IResourceName, sys::IEquatable<ExecutionName>
    {
        /// <summary>The possible contents of <see cref="ExecutionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>.
            /// </summary>
            ProjectLocationWorkflowExecution = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkflowExecution = new gax::PathTemplate("projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}");

        /// <summary>Creates a <see cref="ExecutionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExecutionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExecutionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExecutionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExecutionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExecutionName"/> constructed from the provided ids.</returns>
        public static ExecutionName FromProjectLocationWorkflowExecution(string projectId, string locationId, string workflowId, string executionId) =>
            new ExecutionName(ResourceNameType.ProjectLocationWorkflowExecution, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workflowId, string executionId) =>
            FormatProjectLocationWorkflowExecution(projectId, locationId, workflowId, executionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkflowExecution(string projectId, string locationId, string workflowId, string executionId) =>
            s_projectLocationWorkflowExecution.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)), gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExecutionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExecutionName"/> if successful.</returns>
        public static ExecutionName Parse(string executionName) => Parse(executionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExecutionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExecutionName"/> if successful.</returns>
        public static ExecutionName Parse(string executionName, bool allowUnparsed) =>
            TryParse(executionName, allowUnparsed, out ExecutionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExecutionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExecutionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string executionName, out ExecutionName result) => TryParse(executionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExecutionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExecutionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string executionName, bool allowUnparsed, out ExecutionName result)
        {
            gax::GaxPreconditions.CheckNotNull(executionName, nameof(executionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkflowExecution.TryParseName(executionName, out resourceName))
            {
                result = FromProjectLocationWorkflowExecution(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(executionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExecutionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string executionId = null, string locationId = null, string projectId = null, string workflowId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExecutionId = executionId;
            LocationId = locationId;
            ProjectId = projectId;
            WorkflowId = workflowId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExecutionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        public ExecutionName(string projectId, string locationId, string workflowId, string executionId) : this(ResourceNameType.ProjectLocationWorkflowExecution, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)))
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
        /// The <c>Execution</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExecutionId { get; }

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
                case ResourceNameType.ProjectLocationWorkflowExecution: return s_projectLocationWorkflowExecution.Expand(ProjectId, LocationId, WorkflowId, ExecutionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExecutionName);

        /// <inheritdoc/>
        public bool Equals(ExecutionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExecutionName a, ExecutionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExecutionName a, ExecutionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Workflow</c> resource.</summary>
    public sealed partial class WorkflowName : gax::IResourceName, sys::IEquatable<WorkflowName>
    {
        /// <summary>The possible contents of <see cref="WorkflowName"/>.</summary>
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

        /// <summary>Creates a <see cref="WorkflowName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkflowName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static WorkflowName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkflowName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkflowName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkflowName"/> constructed from the provided ids.</returns>
        public static WorkflowName FromProjectLocationWorkflow(string projectId, string locationId, string workflowId) =>
            new WorkflowName(ResourceNameType.ProjectLocationWorkflow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workflowId) =>
            FormatProjectLocationWorkflow(projectId, locationId, workflowId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkflowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkflow(string projectId, string locationId, string workflowId) =>
            s_projectLocationWorkflow.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkflowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkflowName"/> if successful.</returns>
        public static WorkflowName Parse(string workflowName) => Parse(workflowName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkflowName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkflowName"/> if successful.</returns>
        public static WorkflowName Parse(string workflowName, bool allowUnparsed) =>
            TryParse(workflowName, allowUnparsed, out WorkflowName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowName, out WorkflowName result) => TryParse(workflowName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkflowName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/workflows/{workflow}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workflowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkflowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workflowName, bool allowUnparsed, out WorkflowName result)
        {
            gax::GaxPreconditions.CheckNotNull(workflowName, nameof(workflowName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkflow.TryParseName(workflowName, out resourceName))
            {
                result = FromProjectLocationWorkflow(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workflowName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkflowName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workflowId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkflowId = workflowId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkflowName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workflows/{workflow}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workflowId">The <c>Workflow</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkflowName(string projectId, string locationId, string workflowId) : this(ResourceNameType.ProjectLocationWorkflow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workflowId: gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)))
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
        public override bool Equals(object obj) => Equals(obj as WorkflowName);

        /// <inheritdoc/>
        public bool Equals(WorkflowName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkflowName a, WorkflowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkflowName a, WorkflowName b) => !(a == b);
    }

    public partial class Execution
    {
        /// <summary>
        /// <see cref="gcwev::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwev::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwev::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExecutionsRequest
    {
        /// <summary>
        /// <see cref="WorkflowName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkflowName ParentAsWorkflowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkflowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateExecutionRequest
    {
        /// <summary>
        /// <see cref="WorkflowName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkflowName ParentAsWorkflowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkflowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetExecutionRequest
    {
        /// <summary>
        /// <see cref="gcwev::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwev::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwev::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelExecutionRequest
    {
        /// <summary>
        /// <see cref="gcwev::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwev::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwev::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
