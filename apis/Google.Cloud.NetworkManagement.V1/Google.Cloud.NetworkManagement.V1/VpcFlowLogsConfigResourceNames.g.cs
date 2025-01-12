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
using gcnv = Google.Cloud.NetworkManagement.V1;
using sys = System;

namespace Google.Cloud.NetworkManagement.V1
{
    /// <summary>Resource name for the <c>VpcFlowLogsConfig</c> resource.</summary>
    public sealed partial class VpcFlowLogsConfigName : gax::IResourceName, sys::IEquatable<VpcFlowLogsConfigName>
    {
        /// <summary>The possible contents of <see cref="VpcFlowLogsConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>.
            /// </summary>
            ProjectLocationVpcFlowLogsConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationVpcFlowLogsConfig = new gax::PathTemplate("projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}");

        /// <summary>Creates a <see cref="VpcFlowLogsConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VpcFlowLogsConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VpcFlowLogsConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VpcFlowLogsConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VpcFlowLogsConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vpcFlowLogsConfigId">The <c>VpcFlowLogsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VpcFlowLogsConfigName"/> constructed from the provided ids.</returns>
        public static VpcFlowLogsConfigName FromProjectLocationVpcFlowLogsConfig(string projectId, string locationId, string vpcFlowLogsConfigId) =>
            new VpcFlowLogsConfigName(ResourceNameType.ProjectLocationVpcFlowLogsConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vpcFlowLogsConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VpcFlowLogsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vpcFlowLogsConfigId">The <c>VpcFlowLogsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VpcFlowLogsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string vpcFlowLogsConfigId) =>
            FormatProjectLocationVpcFlowLogsConfig(projectId, locationId, vpcFlowLogsConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VpcFlowLogsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vpcFlowLogsConfigId">The <c>VpcFlowLogsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VpcFlowLogsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>.
        /// </returns>
        public static string FormatProjectLocationVpcFlowLogsConfig(string projectId, string locationId, string vpcFlowLogsConfigId) =>
            s_projectLocationVpcFlowLogsConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VpcFlowLogsConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vpcFlowLogsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VpcFlowLogsConfigName"/> if successful.</returns>
        public static VpcFlowLogsConfigName Parse(string vpcFlowLogsConfigName) => Parse(vpcFlowLogsConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VpcFlowLogsConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vpcFlowLogsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VpcFlowLogsConfigName"/> if successful.</returns>
        public static VpcFlowLogsConfigName Parse(string vpcFlowLogsConfigName, bool allowUnparsed) =>
            TryParse(vpcFlowLogsConfigName, allowUnparsed, out VpcFlowLogsConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VpcFlowLogsConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vpcFlowLogsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VpcFlowLogsConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vpcFlowLogsConfigName, out VpcFlowLogsConfigName result) =>
            TryParse(vpcFlowLogsConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VpcFlowLogsConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vpcFlowLogsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VpcFlowLogsConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vpcFlowLogsConfigName, bool allowUnparsed, out VpcFlowLogsConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfigName, nameof(vpcFlowLogsConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVpcFlowLogsConfig.TryParseName(vpcFlowLogsConfigName, out resourceName))
            {
                result = FromProjectLocationVpcFlowLogsConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(vpcFlowLogsConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VpcFlowLogsConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string vpcFlowLogsConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VpcFlowLogsConfigId = vpcFlowLogsConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VpcFlowLogsConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/vpcFlowLogsConfigs/{vpc_flow_logs_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vpcFlowLogsConfigId">The <c>VpcFlowLogsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public VpcFlowLogsConfigName(string projectId, string locationId, string vpcFlowLogsConfigId) : this(ResourceNameType.ProjectLocationVpcFlowLogsConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vpcFlowLogsConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)))
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
        /// The <c>VpcFlowLogsConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string VpcFlowLogsConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVpcFlowLogsConfig: return s_projectLocationVpcFlowLogsConfig.Expand(ProjectId, LocationId, VpcFlowLogsConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VpcFlowLogsConfigName);

        /// <inheritdoc/>
        public bool Equals(VpcFlowLogsConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VpcFlowLogsConfigName a, VpcFlowLogsConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VpcFlowLogsConfigName a, VpcFlowLogsConfigName b) => !(a == b);
    }

    public partial class VpcFlowLogsConfig
    {
        /// <summary>
        /// <see cref="gcnv::VpcFlowLogsConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::VpcFlowLogsConfigName VpcFlowLogsConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::VpcFlowLogsConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
