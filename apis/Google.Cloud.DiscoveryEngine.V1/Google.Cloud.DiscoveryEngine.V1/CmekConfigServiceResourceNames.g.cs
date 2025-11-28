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
using gcdv = Google.Cloud.DiscoveryEngine.V1;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>CmekConfig</c> resource.</summary>
    public sealed partial class CmekConfigName : gax::IResourceName, sys::IEquatable<CmekConfigName>
    {
        /// <summary>The possible contents of <see cref="CmekConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/cmekConfig</c>.
            /// </summary>
            ProjectLocation = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c>.
            /// </summary>
            ProjectLocationCmekConfig = 2,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/cmekConfig");

        private static gax::PathTemplate s_projectLocationCmekConfig = new gax::PathTemplate("projects/{project}/locations/{location}/cmekConfigs/{cmek_config}");

        /// <summary>Creates a <see cref="CmekConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CmekConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CmekConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CmekConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CmekConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cmekConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmekConfigName"/> constructed from the provided ids.</returns>
        public static CmekConfigName FromProjectLocation(string projectId, string locationId) =>
            new CmekConfigName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Creates a <see cref="CmekConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cmekConfigId">The <c>CmekConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CmekConfigName"/> constructed from the provided ids.</returns>
        public static CmekConfigName FromProjectLocationCmekConfig(string projectId, string locationId, string cmekConfigId) =>
            new CmekConfigName(ResourceNameType.ProjectLocationCmekConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cmekConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(cmekConfigId, nameof(cmekConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cmekConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cmekConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cmekConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cmekConfig</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CmekConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cmekConfigId">The <c>CmekConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CmekConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c>.
        /// </returns>
        public static string FormatProjectLocationCmekConfig(string projectId, string locationId, string cmekConfigId) =>
            s_projectLocationCmekConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cmekConfigId, nameof(cmekConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="CmekConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/cmekConfig</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cmekConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CmekConfigName"/> if successful.</returns>
        public static CmekConfigName Parse(string cmekConfigName) => Parse(cmekConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CmekConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/cmekConfig</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cmekConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CmekConfigName"/> if successful.</returns>
        public static CmekConfigName Parse(string cmekConfigName, bool allowUnparsed) =>
            TryParse(cmekConfigName, allowUnparsed, out CmekConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CmekConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/cmekConfig</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cmekConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CmekConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cmekConfigName, out CmekConfigName result) =>
            TryParse(cmekConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CmekConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/cmekConfig</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cmekConfigs/{cmek_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cmekConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CmekConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cmekConfigName, bool allowUnparsed, out CmekConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(cmekConfigName, nameof(cmekConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(cmekConfigName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationCmekConfig.TryParseName(cmekConfigName, out resourceName))
            {
                result = FromProjectLocationCmekConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cmekConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CmekConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cmekConfigId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CmekConfigId = cmekConfigId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CmekConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/cmekConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public CmekConfigName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>CmekConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CmekConfigId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                case ResourceNameType.ProjectLocationCmekConfig: return s_projectLocationCmekConfig.Expand(ProjectId, LocationId, CmekConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CmekConfigName);

        /// <inheritdoc/>
        public bool Equals(CmekConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CmekConfigName a, CmekConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CmekConfigName a, CmekConfigName b) => !(a == b);
    }

    public partial class GetCmekConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::CmekConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CmekConfigName CmekConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CmekConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SingleRegionKey
    {
        /// <summary>
        /// <see cref="CryptoKeysName"/>-typed view over the <see cref="KmsKey"/> resource name property.
        /// </summary>
        public CryptoKeysName KmsKeyAsCryptoKeysName
        {
            get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeysName.Parse(KmsKey, allowUnparsed: true);
            set => KmsKey = value?.ToString() ?? "";
        }
    }

    public partial class CmekConfig
    {
        /// <summary>
        /// <see cref="gcdv::CmekConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CmekConfigName CmekConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CmekConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeysName"/>-typed view over the <see cref="KmsKey"/> resource name property.
        /// </summary>
        public CryptoKeysName KmsKeyAsCryptoKeysName
        {
            get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeysName.Parse(KmsKey, allowUnparsed: true);
            set => KmsKey = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyVersionsName"/>-typed view over the <see cref="KmsKeyVersion"/> resource name property.
        /// </summary>
        public CryptoKeyVersionsName KmsKeyVersionAsCryptoKeyVersionsName
        {
            get => string.IsNullOrEmpty(KmsKeyVersion) ? null : CryptoKeyVersionsName.Parse(KmsKeyVersion, allowUnparsed: true);
            set => KmsKeyVersion = value?.ToString() ?? "";
        }
    }

    public partial class ListCmekConfigsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCmekConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::CmekConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CmekConfigName CmekConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CmekConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
