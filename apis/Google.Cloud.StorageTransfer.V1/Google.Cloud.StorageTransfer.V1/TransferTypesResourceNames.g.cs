// Copyright 2024 Google LLC
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
using gcsv = Google.Cloud.StorageTransfer.V1;
using sys = System;

namespace Google.Cloud.StorageTransfer.V1
{
    /// <summary>Resource name for the <c>agentPools</c> resource.</summary>
    public sealed partial class agentPoolsName : gax::IResourceName, sys::IEquatable<agentPoolsName>
    {
        /// <summary>The possible contents of <see cref="agentPoolsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project_id}/agentPools/{agent_pool_id}</c>.</summary>
            ProjectAgentPool = 1,
        }

        private static gax::PathTemplate s_projectAgentPool = new gax::PathTemplate("projects/{project_id}/agentPools/{agent_pool_id}");

        /// <summary>Creates a <see cref="agentPoolsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="agentPoolsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static agentPoolsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new agentPoolsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="agentPoolsName"/> with the pattern <c>projects/{project_id}/agentPools/{agent_pool_id}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentPoolId">The <c>AgentPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="agentPoolsName"/> constructed from the provided ids.</returns>
        public static agentPoolsName FromProjectAgentPool(string projectId, string agentPoolId) =>
            new agentPoolsName(ResourceNameType.ProjectAgentPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), agentPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentPoolId, nameof(agentPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="agentPoolsName"/> with pattern
        /// <c>projects/{project_id}/agentPools/{agent_pool_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentPoolId">The <c>AgentPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="agentPoolsName"/> with pattern
        /// <c>projects/{project_id}/agentPools/{agent_pool_id}</c>.
        /// </returns>
        public static string Format(string projectId, string agentPoolId) => FormatProjectAgentPool(projectId, agentPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="agentPoolsName"/> with pattern
        /// <c>projects/{project_id}/agentPools/{agent_pool_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentPoolId">The <c>AgentPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="agentPoolsName"/> with pattern
        /// <c>projects/{project_id}/agentPools/{agent_pool_id}</c>.
        /// </returns>
        public static string FormatProjectAgentPool(string projectId, string agentPoolId) =>
            s_projectAgentPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentPoolId, nameof(agentPoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="agentPoolsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_id}/agentPools/{agent_pool_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="agentPoolsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="agentPoolsName"/> if successful.</returns>
        public static agentPoolsName Parse(string agentPoolsName) => Parse(agentPoolsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="agentPoolsName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_id}/agentPools/{agent_pool_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentPoolsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="agentPoolsName"/> if successful.</returns>
        public static agentPoolsName Parse(string agentPoolsName, bool allowUnparsed) =>
            TryParse(agentPoolsName, allowUnparsed, out agentPoolsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="agentPoolsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_id}/agentPools/{agent_pool_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="agentPoolsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="agentPoolsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentPoolsName, out agentPoolsName result) =>
            TryParse(agentPoolsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="agentPoolsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project_id}/agentPools/{agent_pool_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentPoolsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="agentPoolsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentPoolsName, bool allowUnparsed, out agentPoolsName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentPoolsName, nameof(agentPoolsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAgentPool.TryParseName(agentPoolsName, out resourceName))
            {
                result = FromProjectAgentPool(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentPoolsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private agentPoolsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentPoolId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentPoolId = agentPoolId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="agentPoolsName"/> class from the component parts of pattern
        /// <c>projects/{project_id}/agentPools/{agent_pool_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentPoolId">The <c>AgentPool</c> ID. Must not be <c>null</c> or empty.</param>
        public agentPoolsName(string projectId, string agentPoolId) : this(ResourceNameType.ProjectAgentPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), agentPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentPoolId, nameof(agentPoolId)))
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
        /// The <c>AgentPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentPoolId { get; }

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
                case ResourceNameType.ProjectAgentPool: return s_projectAgentPool.Expand(ProjectId, AgentPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as agentPoolsName);

        /// <inheritdoc/>
        public bool Equals(agentPoolsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(agentPoolsName a, agentPoolsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(agentPoolsName a, agentPoolsName b) => !(a == b);
    }

    public partial class AgentPool
    {
        /// <summary>
        /// <see cref="gcsv::agentPoolsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::agentPoolsName agentPoolsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::agentPoolsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
