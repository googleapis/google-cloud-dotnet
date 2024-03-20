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
    /// <summary>Resource name for the <c>TransitionRouteGroup</c> resource.</summary>
    public sealed partial class TransitionRouteGroupName : gax::IResourceName, sys::IEquatable<TransitionRouteGroupName>
    {
        /// <summary>The possible contents of <see cref="TransitionRouteGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
            /// .
            /// </summary>
            ProjectLocationAgentFlowTransitionRouteGroup = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
            /// .
            /// </summary>
            ProjectLocationAgentTransitionRouteGroup = 2,
        }

        private static gax::PathTemplate s_projectLocationAgentFlowTransitionRouteGroup = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}");

        private static gax::PathTemplate s_projectLocationAgentTransitionRouteGroup = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}");

        /// <summary>Creates a <see cref="TransitionRouteGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TransitionRouteGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TransitionRouteGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TransitionRouteGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TransitionRouteGroupName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transitionRouteGroupId">
        /// The <c>TransitionRouteGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="TransitionRouteGroupName"/> constructed from the provided ids.
        /// </returns>
        public static TransitionRouteGroupName FromProjectLocationAgentFlowTransitionRouteGroup(string projectId, string locationId, string agentId, string flowId, string transitionRouteGroupId) =>
            new TransitionRouteGroupName(ResourceNameType.ProjectLocationAgentFlowTransitionRouteGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), transitionRouteGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(transitionRouteGroupId, nameof(transitionRouteGroupId)));

        /// <summary>
        /// Creates a <see cref="TransitionRouteGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transitionRouteGroupId">
        /// The <c>TransitionRouteGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="TransitionRouteGroupName"/> constructed from the provided ids.
        /// </returns>
        public static TransitionRouteGroupName FromProjectLocationAgentTransitionRouteGroup(string projectId, string locationId, string agentId, string transitionRouteGroupId) =>
            new TransitionRouteGroupName(ResourceNameType.ProjectLocationAgentTransitionRouteGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), transitionRouteGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(transitionRouteGroupId, nameof(transitionRouteGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransitionRouteGroupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transitionRouteGroupId">
        /// The <c>TransitionRouteGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TransitionRouteGroupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string flowId, string transitionRouteGroupId) =>
            FormatProjectLocationAgentFlowTransitionRouteGroup(projectId, locationId, agentId, flowId, transitionRouteGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransitionRouteGroupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transitionRouteGroupId">
        /// The <c>TransitionRouteGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TransitionRouteGroupName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAgentFlowTransitionRouteGroup(string projectId, string locationId, string agentId, string flowId, string transitionRouteGroupId) =>
            s_projectLocationAgentFlowTransitionRouteGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transitionRouteGroupId, nameof(transitionRouteGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransitionRouteGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transitionRouteGroupId">
        /// The <c>TransitionRouteGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TransitionRouteGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAgentTransitionRouteGroup(string projectId, string locationId, string agentId, string transitionRouteGroupId) =>
            s_projectLocationAgentTransitionRouteGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transitionRouteGroupId, nameof(transitionRouteGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TransitionRouteGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transitionRouteGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TransitionRouteGroupName"/> if successful.</returns>
        public static TransitionRouteGroupName Parse(string transitionRouteGroupName) =>
            Parse(transitionRouteGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TransitionRouteGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transitionRouteGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TransitionRouteGroupName"/> if successful.</returns>
        public static TransitionRouteGroupName Parse(string transitionRouteGroupName, bool allowUnparsed) =>
            TryParse(transitionRouteGroupName, allowUnparsed, out TransitionRouteGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TransitionRouteGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transitionRouteGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TransitionRouteGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transitionRouteGroupName, out TransitionRouteGroupName result) =>
            TryParse(transitionRouteGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TransitionRouteGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/transitionRouteGroups/{transition_route_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transitionRouteGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TransitionRouteGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transitionRouteGroupName, bool allowUnparsed, out TransitionRouteGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(transitionRouteGroupName, nameof(transitionRouteGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentFlowTransitionRouteGroup.TryParseName(transitionRouteGroupName, out resourceName))
            {
                result = FromProjectLocationAgentFlowTransitionRouteGroup(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationAgentTransitionRouteGroup.TryParseName(transitionRouteGroupName, out resourceName))
            {
                result = FromProjectLocationAgentTransitionRouteGroup(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(transitionRouteGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TransitionRouteGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string flowId = null, string locationId = null, string projectId = null, string transitionRouteGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            FlowId = flowId;
            LocationId = locationId;
            ProjectId = projectId;
            TransitionRouteGroupId = transitionRouteGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TransitionRouteGroupName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/transitionRouteGroups/{transition_route_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transitionRouteGroupId">
        /// The <c>TransitionRouteGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public TransitionRouteGroupName(string projectId, string locationId, string agentId, string flowId, string transitionRouteGroupId) : this(ResourceNameType.ProjectLocationAgentFlowTransitionRouteGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), transitionRouteGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(transitionRouteGroupId, nameof(transitionRouteGroupId)))
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
        /// The <c>Agent</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Flow</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FlowId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TransitionRouteGroup</c> ID. May be <c>null</c>, depending on which resource name is contained by
        /// this instance.
        /// </summary>
        public string TransitionRouteGroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentFlowTransitionRouteGroup: return s_projectLocationAgentFlowTransitionRouteGroup.Expand(ProjectId, LocationId, AgentId, FlowId, TransitionRouteGroupId);
                case ResourceNameType.ProjectLocationAgentTransitionRouteGroup: return s_projectLocationAgentTransitionRouteGroup.Expand(ProjectId, LocationId, AgentId, TransitionRouteGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TransitionRouteGroupName);

        /// <inheritdoc/>
        public bool Equals(TransitionRouteGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TransitionRouteGroupName a, TransitionRouteGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TransitionRouteGroupName a, TransitionRouteGroupName b) => !(a == b);
    }

    public partial class TransitionRouteGroup
    {
        /// <summary>
        /// <see cref="gcdcv::TransitionRouteGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TransitionRouteGroupName TransitionRouteGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TransitionRouteGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTransitionRouteGroupsRequest
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FlowName ParentAsFlowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FlowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (FlowName.TryParse(Parent, out FlowName flow))
                {
                    return flow;
                }
                if (AgentName.TryParse(Parent, out AgentName agent))
                {
                    return agent;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTransitionRouteGroupRequest
    {
        /// <summary>
        /// <see cref="gcdcv::TransitionRouteGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TransitionRouteGroupName TransitionRouteGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TransitionRouteGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTransitionRouteGroupRequest
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FlowName ParentAsFlowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FlowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (FlowName.TryParse(Parent, out FlowName flow))
                {
                    return flow;
                }
                if (AgentName.TryParse(Parent, out AgentName agent))
                {
                    return agent;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTransitionRouteGroupRequest
    {
        /// <summary>
        /// <see cref="gcdcv::TransitionRouteGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::TransitionRouteGroupName TransitionRouteGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::TransitionRouteGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
