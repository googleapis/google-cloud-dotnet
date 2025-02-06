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
using gcsv = Google.Cloud.SecurityCenter.V1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>ResourceValueConfig</c> resource.</summary>
    public sealed partial class ResourceValueConfigName : gax::IResourceName, sys::IEquatable<ResourceValueConfigName>
    {
        /// <summary>The possible contents of <see cref="ResourceValueConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>.
            /// </summary>
            OrganizationResourceValueConfig = 1,
        }

        private static gax::PathTemplate s_organizationResourceValueConfig = new gax::PathTemplate("organizations/{organization}/resourceValueConfigs/{resource_value_config}");

        /// <summary>Creates a <see cref="ResourceValueConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ResourceValueConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ResourceValueConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ResourceValueConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ResourceValueConfigName"/> with the pattern
        /// <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceValueConfigId">
        /// The <c>ResourceValueConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ResourceValueConfigName"/> constructed from the provided ids.
        /// </returns>
        public static ResourceValueConfigName FromOrganizationResourceValueConfig(string organizationId, string resourceValueConfigId) =>
            new ResourceValueConfigName(ResourceNameType.OrganizationResourceValueConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), resourceValueConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceValueConfigId, nameof(resourceValueConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceValueConfigName"/> with pattern
        /// <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceValueConfigId">
        /// The <c>ResourceValueConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceValueConfigName"/> with pattern
        /// <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>.
        /// </returns>
        public static string Format(string organizationId, string resourceValueConfigId) =>
            FormatOrganizationResourceValueConfig(organizationId, resourceValueConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceValueConfigName"/> with pattern
        /// <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceValueConfigId">
        /// The <c>ResourceValueConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceValueConfigName"/> with pattern
        /// <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>.
        /// </returns>
        public static string FormatOrganizationResourceValueConfig(string organizationId, string resourceValueConfigId) =>
            s_organizationResourceValueConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceValueConfigId, nameof(resourceValueConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceValueConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceValueConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResourceValueConfigName"/> if successful.</returns>
        public static ResourceValueConfigName Parse(string resourceValueConfigName) => Parse(resourceValueConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceValueConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceValueConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ResourceValueConfigName"/> if successful.</returns>
        public static ResourceValueConfigName Parse(string resourceValueConfigName, bool allowUnparsed) =>
            TryParse(resourceValueConfigName, allowUnparsed, out ResourceValueConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceValueConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceValueConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceValueConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceValueConfigName, out ResourceValueConfigName result) =>
            TryParse(resourceValueConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceValueConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceValueConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceValueConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceValueConfigName, bool allowUnparsed, out ResourceValueConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(resourceValueConfigName, nameof(resourceValueConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationResourceValueConfig.TryParseName(resourceValueConfigName, out resourceName))
            {
                result = FromOrganizationResourceValueConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(resourceValueConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ResourceValueConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string organizationId = null, string resourceValueConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OrganizationId = organizationId;
            ResourceValueConfigId = resourceValueConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ResourceValueConfigName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/resourceValueConfigs/{resource_value_config}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceValueConfigId">
        /// The <c>ResourceValueConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ResourceValueConfigName(string organizationId, string resourceValueConfigId) : this(ResourceNameType.OrganizationResourceValueConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), resourceValueConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceValueConfigId, nameof(resourceValueConfigId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>ResourceValueConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ResourceValueConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationResourceValueConfig: return s_organizationResourceValueConfig.Expand(OrganizationId, ResourceValueConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceValueConfigName);

        /// <inheritdoc/>
        public bool Equals(ResourceValueConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ResourceValueConfigName a, ResourceValueConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ResourceValueConfigName a, ResourceValueConfigName b) => !(a == b);
    }

    public partial class ResourceValueConfig
    {
        /// <summary>
        /// <see cref="gcsv::ResourceValueConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::ResourceValueConfigName ResourceValueConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::ResourceValueConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
