// Copyright 2026 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>AgentGateway</c> resource.</summary>
    public sealed partial class AgentGatewayName : gax::IResourceName, sys::IEquatable<AgentGatewayName>
    {
        /// <summary>The possible contents of <see cref="AgentGatewayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>
            /// .
            /// </summary>
            ProjectLocationAgentGateway = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentGateway = new gax::PathTemplate("projects/{project}/locations/{location}/agentGateways/{agent_gateway}");

        /// <summary>Creates a <see cref="AgentGatewayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AgentGatewayName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AgentGatewayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AgentGatewayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AgentGatewayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AgentGatewayName"/> constructed from the provided ids.</returns>
        public static AgentGatewayName FromProjectLocationAgentGateway(string projectId, string locationId, string agentGatewayId) =>
            new AgentGatewayName(ResourceNameType.ProjectLocationAgentGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentGatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentGatewayId, nameof(agentGatewayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentGatewayId) =>
            FormatProjectLocationAgentGateway(projectId, locationId, agentGatewayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentGateway(string projectId, string locationId, string agentGatewayId) =>
            s_projectLocationAgentGateway.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentGatewayId, nameof(agentGatewayId)));

        /// <summary>Parses the given resource name string into a new <see cref="AgentGatewayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgentGatewayName"/> if successful.</returns>
        public static AgentGatewayName Parse(string agentGatewayName) => Parse(agentGatewayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentGatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AgentGatewayName"/> if successful.</returns>
        public static AgentGatewayName Parse(string agentGatewayName, bool allowUnparsed) =>
            TryParse(agentGatewayName, allowUnparsed, out AgentGatewayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentGatewayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentGatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentGatewayName, out AgentGatewayName result) =>
            TryParse(agentGatewayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentGatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentGatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentGatewayName, bool allowUnparsed, out AgentGatewayName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentGatewayName, nameof(agentGatewayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentGateway.TryParseName(agentGatewayName, out resourceName))
            {
                result = FromProjectLocationAgentGateway(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentGatewayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AgentGatewayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentGatewayId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentGatewayId = agentGatewayId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AgentGatewayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        public AgentGatewayName(string projectId, string locationId, string agentGatewayId) : this(ResourceNameType.ProjectLocationAgentGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentGatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentGatewayId, nameof(agentGatewayId)))
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
        /// The <c>AgentGateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AgentGatewayId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationAgentGateway: return s_projectLocationAgentGateway.Expand(ProjectId, LocationId, AgentGatewayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AgentGatewayName);

        /// <inheritdoc/>
        public bool Equals(AgentGatewayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AgentGatewayName a, AgentGatewayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AgentGatewayName a, AgentGatewayName b) => !(a == b);
    }

    public partial class AgentGateway
    {
        /// <summary>
        /// <see cref="gcnv::AgentGatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AgentGatewayName AgentGatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AgentGatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class SelfManaged
            {
                /// <summary>
                /// <see cref="gax::IResourceName"/>-typed view over the <see cref="ResourceUri"/> resource name
                /// property.
                /// </summary>
                public gax::IResourceName ResourceUriAsResourceName
                {
                    get => string.IsNullOrEmpty(ResourceUri) ? null : gax::UnparsedResourceName.Parse(ResourceUri);
                    set => ResourceUri = value?.ToString() ?? "";
                }
            }

            public partial class NetworkConfig
            {
                public partial class Types
                {
                    public partial class DnsPeeringConfig
                    {
                        /// <summary>
                        /// <see cref="NetworkName"/>-typed view over the <see cref="TargetNetwork"/> resource name
                        /// property.
                        /// </summary>
                        public NetworkName TargetNetworkAsNetworkName
                        {
                            get => string.IsNullOrEmpty(TargetNetwork) ? null : NetworkName.Parse(TargetNetwork, allowUnparsed: true);
                            set => TargetNetwork = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }

    public partial class ListAgentGatewaysRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAgentGatewayRequest
    {
        /// <summary>
        /// <see cref="gcnv::AgentGatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AgentGatewayName AgentGatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AgentGatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAgentGatewayRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAgentGatewayRequest
    {
        /// <summary>
        /// <see cref="gcnv::AgentGatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AgentGatewayName AgentGatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AgentGatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
