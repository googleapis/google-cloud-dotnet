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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DeveloperConnect.V1;
using sys = System;

namespace Google.Cloud.DeveloperConnect.V1
{
    /// <summary>Resource name for the <c>InsightsConfig</c> resource.</summary>
    public sealed partial class InsightsConfigName : gax::IResourceName, sys::IEquatable<InsightsConfigName>
    {
        /// <summary>The possible contents of <see cref="InsightsConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>.
            /// </summary>
            ProjectLocationInsightsConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationInsightsConfig = new gax::PathTemplate("projects/{project}/locations/{location}/insightsConfigs/{insights_config}");

        /// <summary>Creates a <see cref="InsightsConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InsightsConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InsightsConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InsightsConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InsightsConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightsConfigId">The <c>InsightsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightsConfigName"/> constructed from the provided ids.</returns>
        public static InsightsConfigName FromProjectLocationInsightsConfig(string projectId, string locationId, string insightsConfigId) =>
            new InsightsConfigName(ResourceNameType.ProjectLocationInsightsConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightsConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightsConfigId">The <c>InsightsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string insightsConfigId) =>
            FormatProjectLocationInsightsConfig(projectId, locationId, insightsConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightsConfigId">The <c>InsightsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightsConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>.
        /// </returns>
        public static string FormatProjectLocationInsightsConfig(string projectId, string locationId, string insightsConfigId) =>
            s_projectLocationInsightsConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InsightsConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InsightsConfigName"/> if successful.</returns>
        public static InsightsConfigName Parse(string insightsConfigName) => Parse(insightsConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InsightsConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InsightsConfigName"/> if successful.</returns>
        public static InsightsConfigName Parse(string insightsConfigName, bool allowUnparsed) =>
            TryParse(insightsConfigName, allowUnparsed, out InsightsConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightsConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightsConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightsConfigName, out InsightsConfigName result) =>
            TryParse(insightsConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightsConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightsConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightsConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightsConfigName, bool allowUnparsed, out InsightsConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(insightsConfigName, nameof(insightsConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInsightsConfig.TryParseName(insightsConfigName, out resourceName))
            {
                result = FromProjectLocationInsightsConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(insightsConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InsightsConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string insightsConfigId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InsightsConfigId = insightsConfigId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InsightsConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/insightsConfigs/{insights_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightsConfigId">The <c>InsightsConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public InsightsConfigName(string projectId, string locationId, string insightsConfigId) : this(ResourceNameType.ProjectLocationInsightsConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightsConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightsConfigId, nameof(insightsConfigId)))
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
        /// The <c>InsightsConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InsightsConfigId { get; }

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
                case ResourceNameType.ProjectLocationInsightsConfig: return s_projectLocationInsightsConfig.Expand(ProjectId, LocationId, InsightsConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InsightsConfigName);

        /// <inheritdoc/>
        public bool Equals(InsightsConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InsightsConfigName a, InsightsConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InsightsConfigName a, InsightsConfigName b) => !(a == b);
    }

    public partial class InsightsConfig
    {
        /// <summary>
        /// <see cref="gcdv::InsightsConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InsightsConfigName InsightsConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InsightsConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInsightsConfigRequest
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

    public partial class GetInsightsConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::InsightsConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InsightsConfigName InsightsConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InsightsConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInsightsConfigsRequest
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

    public partial class DeleteInsightsConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::InsightsConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InsightsConfigName InsightsConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InsightsConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
