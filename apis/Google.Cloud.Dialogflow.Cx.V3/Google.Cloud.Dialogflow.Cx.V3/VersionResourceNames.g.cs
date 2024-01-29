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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Version</c> resource.</summary>
    public sealed partial class VersionName : gax::IResourceName, sys::IEquatable<VersionName>
    {
        /// <summary>The possible contents of <see cref="VersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>.
            /// </summary>
            ProjectLocationAgentFlowVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentFlowVersion = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}");

        /// <summary>Creates a <see cref="VersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VersionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VersionName"/> constructed from the provided ids.</returns>
        public static VersionName FromProjectLocationAgentFlowVersion(string projectId, string locationId, string agentId, string flowId, string versionId) =>
            new VersionName(ResourceNameType.ProjectLocationAgentFlowVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string flowId, string versionId) =>
            FormatProjectLocationAgentFlowVersion(projectId, locationId, agentId, flowId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentFlowVersion(string projectId, string locationId, string agentId, string flowId, string versionId) =>
            s_projectLocationAgentFlowVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>Parses the given resource name string into a new <see cref="VersionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VersionName"/> if successful.</returns>
        public static VersionName Parse(string versionName) => Parse(versionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VersionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VersionName"/> if successful.</returns>
        public static VersionName Parse(string versionName, bool allowUnparsed) =>
            TryParse(versionName, allowUnparsed, out VersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string versionName, out VersionName result) => TryParse(versionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string versionName, bool allowUnparsed, out VersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(versionName, nameof(versionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentFlowVersion.TryParseName(versionName, out resourceName))
            {
                result = FromProjectLocationAgentFlowVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(versionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string flowId = null, string locationId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            FlowId = flowId;
            LocationId = locationId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public VersionName(string projectId, string locationId, string agentId, string flowId, string versionId) : this(ResourceNameType.ProjectLocationAgentFlowVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Flow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FlowId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentFlowVersion: return s_projectLocationAgentFlowVersion.Expand(ProjectId, LocationId, AgentId, FlowId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VersionName);

        /// <inheritdoc/>
        public bool Equals(VersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VersionName a, VersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VersionName a, VersionName b) => !(a == b);
    }

    public partial class CreateVersionOperationMetadata
    {
        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="Version"/> resource name property.
        /// </summary>
        public VersionName VersionAsVersionName
        {
            get => string.IsNullOrEmpty(Version) ? null : VersionName.Parse(Version, allowUnparsed: true);
            set => Version = value?.ToString() ?? "";
        }
    }

    public partial class Version
    {
        /// <summary>
        /// <see cref="gcdcv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVersionsRequest
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FlowName ParentAsFlowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FlowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVersionRequest
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FlowName ParentAsFlowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FlowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LoadVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CompareVersionsRequest
    {
        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="BaseVersion"/> resource name property.
        /// </summary>
        public VersionName BaseVersionAsVersionName
        {
            get => string.IsNullOrEmpty(BaseVersion) ? null : VersionName.Parse(BaseVersion, allowUnparsed: true);
            set => BaseVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="TargetVersion"/> resource name property.
        /// </summary>
        public VersionName TargetVersionAsVersionName
        {
            get => string.IsNullOrEmpty(TargetVersion) ? null : VersionName.Parse(TargetVersion, allowUnparsed: true);
            set => TargetVersion = value?.ToString() ?? "";
        }
    }
}
