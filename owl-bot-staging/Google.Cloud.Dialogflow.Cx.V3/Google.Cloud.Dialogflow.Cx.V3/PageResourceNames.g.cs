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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Page</c> resource.</summary>
    public sealed partial class PageName : gax::IResourceName, sys::IEquatable<PageName>
    {
        /// <summary>The possible contents of <see cref="PageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>.
            /// </summary>
            ProjectLocationAgentFlowPage = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentFlowPage = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}");

        /// <summary>Creates a <see cref="PageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PageName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pageId">The <c>Page</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PageName"/> constructed from the provided ids.</returns>
        public static PageName FromProjectLocationAgentFlowPage(string projectId, string locationId, string agentId, string flowId, string pageId) =>
            new PageName(ResourceNameType.ProjectLocationAgentFlowPage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), pageId: gax::GaxPreconditions.CheckNotNullOrEmpty(pageId, nameof(pageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pageId">The <c>Page</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string flowId, string pageId) =>
            FormatProjectLocationAgentFlowPage(projectId, locationId, agentId, flowId, pageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pageId">The <c>Page</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentFlowPage(string projectId, string locationId, string agentId, string flowId, string pageId) =>
            s_projectLocationAgentFlowPage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pageId, nameof(pageId)));

        /// <summary>Parses the given resource name string into a new <see cref="PageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PageName"/> if successful.</returns>
        public static PageName Parse(string pageName) => Parse(pageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PageName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PageName"/> if successful.</returns>
        public static PageName Parse(string pageName, bool allowUnparsed) =>
            TryParse(pageName, allowUnparsed, out PageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="PageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pageName, out PageName result) => TryParse(pageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pageName, bool allowUnparsed, out PageName result)
        {
            gax::GaxPreconditions.CheckNotNull(pageName, nameof(pageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentFlowPage.TryParseName(pageName, out resourceName))
            {
                result = FromProjectLocationAgentFlowPage(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string flowId = null, string locationId = null, string pageId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            FlowId = flowId;
            LocationId = locationId;
            PageId = pageId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}/pages/{page}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pageId">The <c>Page</c> ID. Must not be <c>null</c> or empty.</param>
        public PageName(string projectId, string locationId, string agentId, string flowId, string pageId) : this(ResourceNameType.ProjectLocationAgentFlowPage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)), pageId: gax::GaxPreconditions.CheckNotNullOrEmpty(pageId, nameof(pageId)))
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
        /// The <c>Page</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PageId { get; }

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
                case ResourceNameType.ProjectLocationAgentFlowPage: return s_projectLocationAgentFlowPage.Expand(ProjectId, LocationId, AgentId, FlowId, PageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PageName);

        /// <inheritdoc/>
        public bool Equals(PageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PageName a, PageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PageName a, PageName b) => !(a == b);
    }

    public partial class Page
    {
        /// <summary>
        /// <see cref="gcdcv::PageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PageName PageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TransitionRouteGroupName"/>-typed view over the <see cref="TransitionRouteGroups"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<TransitionRouteGroupName> TransitionRouteGroupsAsTransitionRouteGroupNames
        {
            get => new gax::ResourceNameList<TransitionRouteGroupName>(TransitionRouteGroups, s => string.IsNullOrEmpty(s) ? null : TransitionRouteGroupName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class Form
    {
        public partial class Types
        {
            public partial class Parameter
            {
                /// <summary>
                /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
                /// </summary>
                public EntityTypeName EntityTypeAsEntityTypeName
                {
                    get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
                    set => EntityType = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class EventHandler
    {
        /// <summary>
        /// <see cref="PageName"/>-typed view over the <see cref="TargetPage"/> resource name property.
        /// </summary>
        public PageName TargetPageAsPageName
        {
            get => string.IsNullOrEmpty(TargetPage) ? null : PageName.Parse(TargetPage, allowUnparsed: true);
            set => TargetPage = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FlowName"/>-typed view over the <see cref="TargetFlow"/> resource name property.
        /// </summary>
        public FlowName TargetFlowAsFlowName
        {
            get => string.IsNullOrEmpty(TargetFlow) ? null : FlowName.Parse(TargetFlow, allowUnparsed: true);
            set => TargetFlow = value?.ToString() ?? "";
        }
    }

    public partial class TransitionRoute
    {
        /// <summary><see cref="IntentName"/>-typed view over the <see cref="Intent"/> resource name property.</summary>
        public IntentName IntentAsIntentName
        {
            get => string.IsNullOrEmpty(Intent) ? null : IntentName.Parse(Intent, allowUnparsed: true);
            set => Intent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PageName"/>-typed view over the <see cref="TargetPage"/> resource name property.
        /// </summary>
        public PageName TargetPageAsPageName
        {
            get => string.IsNullOrEmpty(TargetPage) ? null : PageName.Parse(TargetPage, allowUnparsed: true);
            set => TargetPage = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FlowName"/>-typed view over the <see cref="TargetFlow"/> resource name property.
        /// </summary>
        public FlowName TargetFlowAsFlowName
        {
            get => string.IsNullOrEmpty(TargetFlow) ? null : FlowName.Parse(TargetFlow, allowUnparsed: true);
            set => TargetFlow = value?.ToString() ?? "";
        }
    }

    public partial class ListPagesRequest
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FlowName ParentAsFlowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FlowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPageRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PageName PageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePageRequest
    {
        /// <summary><see cref="FlowName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FlowName ParentAsFlowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FlowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePageRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PageName PageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class KnowledgeConnectorSettings
    {
        /// <summary>
        /// <see cref="PageName"/>-typed view over the <see cref="TargetPage"/> resource name property.
        /// </summary>
        public PageName TargetPageAsPageName
        {
            get => string.IsNullOrEmpty(TargetPage) ? null : PageName.Parse(TargetPage, allowUnparsed: true);
            set => TargetPage = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FlowName"/>-typed view over the <see cref="TargetFlow"/> resource name property.
        /// </summary>
        public FlowName TargetFlowAsFlowName
        {
            get => string.IsNullOrEmpty(TargetFlow) ? null : FlowName.Parse(TargetFlow, allowUnparsed: true);
            set => TargetFlow = value?.ToString() ?? "";
        }
    }
}
