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
using gcbv = Google.Cloud.BareMetalSolution.V2;
using sys = System;

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Resource name for the <c>ProvisioningConfig</c> resource.</summary>
    public sealed partial class ProvisioningConfigName : gax::IResourceName, sys::IEquatable<ProvisioningConfigName>
    {
        /// <summary>The possible contents of <see cref="ProvisioningConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>.
            /// </summary>
            ProjectLocationProvisioningConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationProvisioningConfig = new gax::PathTemplate("projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}");

        /// <summary>Creates a <see cref="ProvisioningConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProvisioningConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProvisioningConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProvisioningConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProvisioningConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningConfigId">
        /// The <c>ProvisioningConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="ProvisioningConfigName"/> constructed from the provided ids.</returns>
        public static ProvisioningConfigName FromProjectLocationProvisioningConfig(string projectId, string locationId, string provisioningConfigId) =>
            new ProvisioningConfigName(ResourceNameType.ProjectLocationProvisioningConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), provisioningConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(provisioningConfigId, nameof(provisioningConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProvisioningConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningConfigId">
        /// The <c>ProvisioningConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ProvisioningConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string provisioningConfigId) =>
            FormatProjectLocationProvisioningConfig(projectId, locationId, provisioningConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProvisioningConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningConfigId">
        /// The <c>ProvisioningConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ProvisioningConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>.
        /// </returns>
        public static string FormatProjectLocationProvisioningConfig(string projectId, string locationId, string provisioningConfigId) =>
            s_projectLocationProvisioningConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(provisioningConfigId, nameof(provisioningConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProvisioningConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="provisioningConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProvisioningConfigName"/> if successful.</returns>
        public static ProvisioningConfigName Parse(string provisioningConfigName) => Parse(provisioningConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProvisioningConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="provisioningConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProvisioningConfigName"/> if successful.</returns>
        public static ProvisioningConfigName Parse(string provisioningConfigName, bool allowUnparsed) =>
            TryParse(provisioningConfigName, allowUnparsed, out ProvisioningConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProvisioningConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="provisioningConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProvisioningConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string provisioningConfigName, out ProvisioningConfigName result) =>
            TryParse(provisioningConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProvisioningConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="provisioningConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProvisioningConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string provisioningConfigName, bool allowUnparsed, out ProvisioningConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(provisioningConfigName, nameof(provisioningConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProvisioningConfig.TryParseName(provisioningConfigName, out resourceName))
            {
                result = FromProjectLocationProvisioningConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(provisioningConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProvisioningConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string provisioningConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ProvisioningConfigId = provisioningConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProvisioningConfigName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/provisioningConfigs/{provisioning_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningConfigId">
        /// The <c>ProvisioningConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ProvisioningConfigName(string projectId, string locationId, string provisioningConfigId) : this(ResourceNameType.ProjectLocationProvisioningConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), provisioningConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(provisioningConfigId, nameof(provisioningConfigId)))
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
        /// The <c>ProvisioningConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ProvisioningConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProvisioningConfig: return s_projectLocationProvisioningConfig.Expand(ProjectId, LocationId, ProvisioningConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProvisioningConfigName);

        /// <inheritdoc/>
        public bool Equals(ProvisioningConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProvisioningConfigName a, ProvisioningConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProvisioningConfigName a, ProvisioningConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ProvisioningQuota</c> resource.</summary>
    public sealed partial class ProvisioningQuotaName : gax::IResourceName, sys::IEquatable<ProvisioningQuotaName>
    {
        /// <summary>The possible contents of <see cref="ProvisioningQuotaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>.
            /// </summary>
            ProjectLocationProvisioningQuota = 1,
        }

        private static gax::PathTemplate s_projectLocationProvisioningQuota = new gax::PathTemplate("projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}");

        /// <summary>Creates a <see cref="ProvisioningQuotaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProvisioningQuotaName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProvisioningQuotaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProvisioningQuotaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProvisioningQuotaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningQuotaId">The <c>ProvisioningQuota</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProvisioningQuotaName"/> constructed from the provided ids.</returns>
        public static ProvisioningQuotaName FromProjectLocationProvisioningQuota(string projectId, string locationId, string provisioningQuotaId) =>
            new ProvisioningQuotaName(ResourceNameType.ProjectLocationProvisioningQuota, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), provisioningQuotaId: gax::GaxPreconditions.CheckNotNullOrEmpty(provisioningQuotaId, nameof(provisioningQuotaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProvisioningQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningQuotaId">The <c>ProvisioningQuota</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProvisioningQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string provisioningQuotaId) =>
            FormatProjectLocationProvisioningQuota(projectId, locationId, provisioningQuotaId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProvisioningQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningQuotaId">The <c>ProvisioningQuota</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProvisioningQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>.
        /// </returns>
        public static string FormatProjectLocationProvisioningQuota(string projectId, string locationId, string provisioningQuotaId) =>
            s_projectLocationProvisioningQuota.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(provisioningQuotaId, nameof(provisioningQuotaId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProvisioningQuotaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="provisioningQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProvisioningQuotaName"/> if successful.</returns>
        public static ProvisioningQuotaName Parse(string provisioningQuotaName) => Parse(provisioningQuotaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProvisioningQuotaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="provisioningQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProvisioningQuotaName"/> if successful.</returns>
        public static ProvisioningQuotaName Parse(string provisioningQuotaName, bool allowUnparsed) =>
            TryParse(provisioningQuotaName, allowUnparsed, out ProvisioningQuotaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProvisioningQuotaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="provisioningQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProvisioningQuotaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string provisioningQuotaName, out ProvisioningQuotaName result) =>
            TryParse(provisioningQuotaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProvisioningQuotaName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="provisioningQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProvisioningQuotaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string provisioningQuotaName, bool allowUnparsed, out ProvisioningQuotaName result)
        {
            gax::GaxPreconditions.CheckNotNull(provisioningQuotaName, nameof(provisioningQuotaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProvisioningQuota.TryParseName(provisioningQuotaName, out resourceName))
            {
                result = FromProjectLocationProvisioningQuota(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(provisioningQuotaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProvisioningQuotaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string provisioningQuotaId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ProvisioningQuotaId = provisioningQuotaId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProvisioningQuotaName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/provisioningQuotas/{provisioning_quota}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="provisioningQuotaId">The <c>ProvisioningQuota</c> ID. Must not be <c>null</c> or empty.</param>
        public ProvisioningQuotaName(string projectId, string locationId, string provisioningQuotaId) : this(ResourceNameType.ProjectLocationProvisioningQuota, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), provisioningQuotaId: gax::GaxPreconditions.CheckNotNullOrEmpty(provisioningQuotaId, nameof(provisioningQuotaId)))
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
        /// The <c>ProvisioningQuota</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProvisioningQuotaId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProvisioningQuota: return s_projectLocationProvisioningQuota.Expand(ProjectId, LocationId, ProvisioningQuotaId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProvisioningQuotaName);

        /// <inheritdoc/>
        public bool Equals(ProvisioningQuotaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProvisioningQuotaName a, ProvisioningQuotaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProvisioningQuotaName a, ProvisioningQuotaName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstanceConfig</c> resource.</summary>
    public sealed partial class InstanceConfigName : gax::IResourceName, sys::IEquatable<InstanceConfigName>
    {
        /// <summary>The possible contents of <see cref="InstanceConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>.
            /// </summary>
            ProjectLocationInstanceConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceConfig = new gax::PathTemplate("projects/{project}/locations/{location}/instanceConfigs/{instance_config}");

        /// <summary>Creates a <see cref="InstanceConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceConfigName"/> constructed from the provided ids.</returns>
        public static InstanceConfigName FromProjectLocationInstanceConfig(string projectId, string locationId, string instanceConfigId) =>
            new InstanceConfigName(ResourceNameType.ProjectLocationInstanceConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceConfigId) =>
            FormatProjectLocationInstanceConfig(projectId, locationId, instanceConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceConfig(string projectId, string locationId, string instanceConfigId) =>
            s_projectLocationInstanceConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName) => Parse(instanceConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName, bool allowUnparsed) =>
            TryParse(instanceConfigName, allowUnparsed, out InstanceConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, out InstanceConfigName result) =>
            TryParse(instanceConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, bool allowUnparsed, out InstanceConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceConfig.TryParseName(instanceConfigName, out resourceName))
            {
                result = FromProjectLocationInstanceConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceConfigId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceConfigId = instanceConfigId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instanceConfigs/{instance_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceConfigName(string projectId, string locationId, string instanceConfigId) : this(ResourceNameType.ProjectLocationInstanceConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)))
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
        /// The <c>InstanceConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InstanceConfigId { get; }

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
                case ResourceNameType.ProjectLocationInstanceConfig: return s_projectLocationInstanceConfig.Expand(ProjectId, LocationId, InstanceConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceConfigName);

        /// <inheritdoc/>
        public bool Equals(InstanceConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceConfigName a, InstanceConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceConfigName a, InstanceConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>VolumeConfig</c> resource.</summary>
    public sealed partial class VolumeConfigName : gax::IResourceName, sys::IEquatable<VolumeConfigName>
    {
        /// <summary>The possible contents of <see cref="VolumeConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>
            /// .
            /// </summary>
            ProjectLocationVolumeConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationVolumeConfig = new gax::PathTemplate("projects/{project}/locations/{location}/volumeConfigs/{volume_config}");

        /// <summary>Creates a <see cref="VolumeConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeConfigId">The <c>VolumeConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeConfigName"/> constructed from the provided ids.</returns>
        public static VolumeConfigName FromProjectLocationVolumeConfig(string projectId, string locationId, string volumeConfigId) =>
            new VolumeConfigName(ResourceNameType.ProjectLocationVolumeConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeConfigId, nameof(volumeConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeConfigId">The <c>VolumeConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeConfigId) =>
            FormatProjectLocationVolumeConfig(projectId, locationId, volumeConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeConfigId">The <c>VolumeConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>.
        /// </returns>
        public static string FormatProjectLocationVolumeConfig(string projectId, string locationId, string volumeConfigId) =>
            s_projectLocationVolumeConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeConfigId, nameof(volumeConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="VolumeConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeConfigName"/> if successful.</returns>
        public static VolumeConfigName Parse(string volumeConfigName) => Parse(volumeConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeConfigName"/> if successful.</returns>
        public static VolumeConfigName Parse(string volumeConfigName, bool allowUnparsed) =>
            TryParse(volumeConfigName, allowUnparsed, out VolumeConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeConfigName, out VolumeConfigName result) =>
            TryParse(volumeConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeConfigName, bool allowUnparsed, out VolumeConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeConfigName, nameof(volumeConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolumeConfig.TryParseName(volumeConfigName, out resourceName))
            {
                result = FromProjectLocationVolumeConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string volumeConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VolumeConfigId = volumeConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumeConfigs/{volume_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeConfigId">The <c>VolumeConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeConfigName(string projectId, string locationId, string volumeConfigId) : this(ResourceNameType.ProjectLocationVolumeConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeConfigId, nameof(volumeConfigId)))
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
        /// The <c>VolumeConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string VolumeConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVolumeConfig: return s_projectLocationVolumeConfig.Expand(ProjectId, LocationId, VolumeConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeConfigName);

        /// <inheritdoc/>
        public bool Equals(VolumeConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VolumeConfigName a, VolumeConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VolumeConfigName a, VolumeConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NetworkConfig</c> resource.</summary>
    public sealed partial class NetworkConfigName : gax::IResourceName, sys::IEquatable<NetworkConfigName>
    {
        /// <summary>The possible contents of <see cref="NetworkConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>
            /// .
            /// </summary>
            ProjectLocationNetworkConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationNetworkConfig = new gax::PathTemplate("projects/{project}/locations/{location}/networkConfigs/{network_config}");

        /// <summary>Creates a <see cref="NetworkConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkConfigId">The <c>NetworkConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkConfigName"/> constructed from the provided ids.</returns>
        public static NetworkConfigName FromProjectLocationNetworkConfig(string projectId, string locationId, string networkConfigId) =>
            new NetworkConfigName(ResourceNameType.ProjectLocationNetworkConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkConfigId, nameof(networkConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkConfigId">The <c>NetworkConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string networkConfigId) =>
            FormatProjectLocationNetworkConfig(projectId, locationId, networkConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkConfigId">The <c>NetworkConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>.
        /// </returns>
        public static string FormatProjectLocationNetworkConfig(string projectId, string locationId, string networkConfigId) =>
            s_projectLocationNetworkConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkConfigId, nameof(networkConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkConfigName"/> if successful.</returns>
        public static NetworkConfigName Parse(string networkConfigName) => Parse(networkConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkConfigName"/> if successful.</returns>
        public static NetworkConfigName Parse(string networkConfigName, bool allowUnparsed) =>
            TryParse(networkConfigName, allowUnparsed, out NetworkConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="networkConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkConfigName, out NetworkConfigName result) =>
            TryParse(networkConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkConfigName, bool allowUnparsed, out NetworkConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkConfigName, nameof(networkConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNetworkConfig.TryParseName(networkConfigName, out resourceName))
            {
                result = FromProjectLocationNetworkConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string networkConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NetworkConfigId = networkConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/networkConfigs/{network_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkConfigId">The <c>NetworkConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkConfigName(string projectId, string locationId, string networkConfigId) : this(ResourceNameType.ProjectLocationNetworkConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), networkConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkConfigId, nameof(networkConfigId)))
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
        /// The <c>NetworkConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NetworkConfigId { get; }

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
                case ResourceNameType.ProjectLocationNetworkConfig: return s_projectLocationNetworkConfig.Expand(ProjectId, LocationId, NetworkConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkConfigName);

        /// <inheritdoc/>
        public bool Equals(NetworkConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkConfigName a, NetworkConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkConfigName a, NetworkConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InstanceQuota</c> resource.</summary>
    public sealed partial class InstanceQuotaName : gax::IResourceName, sys::IEquatable<InstanceQuotaName>
    {
        /// <summary>The possible contents of <see cref="InstanceQuotaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceQuota = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceQuota = new gax::PathTemplate("projects/{project}/locations/{location}/instanceQuotas/{instance_quota}");

        /// <summary>Creates a <see cref="InstanceQuotaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceQuotaName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceQuotaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceQuotaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceQuotaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceQuotaId">The <c>InstanceQuota</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceQuotaName"/> constructed from the provided ids.</returns>
        public static InstanceQuotaName FromProjectLocationInstanceQuota(string projectId, string locationId, string instanceQuotaId) =>
            new InstanceQuotaName(ResourceNameType.ProjectLocationInstanceQuota, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceQuotaId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceQuotaId, nameof(instanceQuotaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceQuotaId">The <c>InstanceQuota</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceQuotaId) =>
            FormatProjectLocationInstanceQuota(projectId, locationId, instanceQuotaId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceQuotaId">The <c>InstanceQuota</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceQuotaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceQuota(string projectId, string locationId, string instanceQuotaId) =>
            s_projectLocationInstanceQuota.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceQuotaId, nameof(instanceQuotaId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceQuotaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceQuotaName"/> if successful.</returns>
        public static InstanceQuotaName Parse(string instanceQuotaName) => Parse(instanceQuotaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceQuotaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceQuotaName"/> if successful.</returns>
        public static InstanceQuotaName Parse(string instanceQuotaName, bool allowUnparsed) =>
            TryParse(instanceQuotaName, allowUnparsed, out InstanceQuotaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceQuotaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceQuotaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceQuotaName, out InstanceQuotaName result) =>
            TryParse(instanceQuotaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceQuotaName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceQuotaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceQuotaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceQuotaName, bool allowUnparsed, out InstanceQuotaName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceQuotaName, nameof(instanceQuotaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceQuota.TryParseName(instanceQuotaName, out resourceName))
            {
                result = FromProjectLocationInstanceQuota(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceQuotaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceQuotaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceQuotaId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceQuotaId = instanceQuotaId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceQuotaName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instanceQuotas/{instance_quota}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceQuotaId">The <c>InstanceQuota</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceQuotaName(string projectId, string locationId, string instanceQuotaId) : this(ResourceNameType.ProjectLocationInstanceQuota, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceQuotaId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceQuotaId, nameof(instanceQuotaId)))
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
        /// The <c>InstanceQuota</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InstanceQuotaId { get; }

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
                case ResourceNameType.ProjectLocationInstanceQuota: return s_projectLocationInstanceQuota.Expand(ProjectId, LocationId, InstanceQuotaId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceQuotaName);

        /// <inheritdoc/>
        public bool Equals(InstanceQuotaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceQuotaName a, InstanceQuotaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceQuotaName a, InstanceQuotaName b) => !(a == b);
    }

    public partial class ProvisioningConfig
    {
        /// <summary>
        /// <see cref="gcbv::ProvisioningConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ProvisioningConfigName ProvisioningConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ProvisioningConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubmitProvisioningConfigRequest
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

    public partial class ProvisioningQuota
    {
        /// <summary>
        /// <see cref="gcbv::ProvisioningQuotaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ProvisioningQuotaName ProvisioningQuotaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ProvisioningQuotaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProvisioningQuotasRequest
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

    public partial class InstanceConfig
    {
        /// <summary>
        /// <see cref="gcbv::InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::InstanceConfigName InstanceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::InstanceConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class VolumeConfig
    {
        /// <summary>
        /// <see cref="gcbv::VolumeConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeConfigName VolumeConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NetworkConfig
    {
        /// <summary>
        /// <see cref="gcbv::NetworkConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NetworkConfigName NetworkConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NetworkConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InstanceQuota
    {
        /// <summary>
        /// <see cref="gcbv::InstanceQuotaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::InstanceQuotaName InstanceQuotaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::InstanceQuotaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProvisioningConfigRequest
    {
        /// <summary>
        /// <see cref="gcbv::ProvisioningConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ProvisioningConfigName ProvisioningConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ProvisioningConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProvisioningConfigRequest
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
}
