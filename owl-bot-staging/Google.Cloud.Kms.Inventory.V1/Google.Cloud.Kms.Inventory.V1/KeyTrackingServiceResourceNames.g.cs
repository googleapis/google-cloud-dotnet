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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gckiv = Google.Cloud.Kms.Inventory.V1;
using gckv = Google.Cloud.Kms.V1;
using sys = System;

namespace Google.Cloud.Kms.Inventory.V1
{
    /// <summary>Resource name for the <c>ProtectedResourcesSummary</c> resource.</summary>
    public sealed partial class ProtectedResourcesSummaryName : gax::IResourceName, sys::IEquatable<ProtectedResourcesSummaryName>
    {
        /// <summary>The possible contents of <see cref="ProtectedResourcesSummaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
            /// .
            /// </summary>
            ProjectLocationKeyRingCryptoKey = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
            /// .
            /// </summary>
            ProjectLocationKeyRingCryptoKeyCryptoKeyVersion = 2,
        }

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKey = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary");

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKeyCryptoKeyVersion = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary");

        /// <summary>
        /// Creates a <see cref="ProtectedResourcesSummaryName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProtectedResourcesSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProtectedResourcesSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProtectedResourcesSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProtectedResourcesSummaryName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ProtectedResourcesSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static ProtectedResourcesSummaryName FromProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            new ProtectedResourcesSummaryName(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>
        /// Creates a <see cref="ProtectedResourcesSummaryName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ProtectedResourcesSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static ProtectedResourcesSummaryName FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            new ProtectedResourcesSummaryName(ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), cryptoKeyVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProtectedResourcesSummaryName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProtectedResourcesSummaryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            FormatProjectLocationKeyRingCryptoKey(projectId, locationId, keyRingId, cryptoKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProtectedResourcesSummaryName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProtectedResourcesSummaryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            s_projectLocationKeyRingCryptoKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProtectedResourcesSummaryName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProtectedResourcesSummaryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKeyCryptoKeyVersion(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProtectedResourcesSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="protectedResourcesSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ProtectedResourcesSummaryName"/> if successful.</returns>
        public static ProtectedResourcesSummaryName Parse(string protectedResourcesSummaryName) =>
            Parse(protectedResourcesSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProtectedResourcesSummaryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="protectedResourcesSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProtectedResourcesSummaryName"/> if successful.</returns>
        public static ProtectedResourcesSummaryName Parse(string protectedResourcesSummaryName, bool allowUnparsed) =>
            TryParse(protectedResourcesSummaryName, allowUnparsed, out ProtectedResourcesSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProtectedResourcesSummaryName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="protectedResourcesSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProtectedResourcesSummaryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string protectedResourcesSummaryName, out ProtectedResourcesSummaryName result) =>
            TryParse(protectedResourcesSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProtectedResourcesSummaryName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}/protectedResourcesSummary</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="protectedResourcesSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProtectedResourcesSummaryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string protectedResourcesSummaryName, bool allowUnparsed, out ProtectedResourcesSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(protectedResourcesSummaryName, nameof(protectedResourcesSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationKeyRingCryptoKey.TryParseName(protectedResourcesSummaryName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKey(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.TryParseName(protectedResourcesSummaryName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(protectedResourcesSummaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProtectedResourcesSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cryptoKeyId = null, string cryptoKeyVersionId = null, string keyRingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CryptoKeyId = cryptoKeyId;
            CryptoKeyVersionId = cryptoKeyVersionId;
            KeyRingId = keyRingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProtectedResourcesSummaryName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/protectedResourcesSummary</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        public ProtectedResourcesSummaryName(string projectId, string locationId, string keyRingId, string cryptoKeyId) : this(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)))
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
        /// The <c>CryptoKey</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The <c>CryptoKeyVersion</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CryptoKeyVersionId { get; }

        /// <summary>
        /// The <c>KeyRing</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string KeyRingId { get; }

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
                case ResourceNameType.ProjectLocationKeyRingCryptoKey: return s_projectLocationKeyRingCryptoKey.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId);
                case ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion: return s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId, CryptoKeyVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProtectedResourcesSummaryName);

        /// <inheritdoc/>
        public bool Equals(ProtectedResourcesSummaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProtectedResourcesSummaryName a, ProtectedResourcesSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProtectedResourcesSummaryName a, ProtectedResourcesSummaryName b) => !(a == b);
    }

    public partial class GetProtectedResourcesSummaryRequest
    {
        /// <summary>
        /// <see cref="gckiv::ProtectedResourcesSummaryName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckiv::ProtectedResourcesSummaryName ProtectedResourcesSummaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckiv::ProtectedResourcesSummaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ProtectedResourcesSummary
    {
        /// <summary>
        /// <see cref="gckiv::ProtectedResourcesSummaryName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckiv::ProtectedResourcesSummaryName ProtectedResourcesSummaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckiv::ProtectedResourcesSummaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchProtectedResourcesRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="CryptoKey"/> resource name property.
        /// </summary>
        public gax::IResourceName CryptoKeyAsResourceName
        {
            get => string.IsNullOrEmpty(CryptoKey) ? null : gax::UnparsedResourceName.Parse(CryptoKey);
            set => CryptoKey = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Scope"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ScopeAsOrganizationName
        {
            get => string.IsNullOrEmpty(Scope) ? null : gagr::OrganizationName.Parse(Scope, allowUnparsed: true);
            set => Scope = value?.ToString() ?? "";
        }
    }

    public partial class ProtectedResource
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gax::UnparsedResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="CryptoKeyVersion"/> resource name
        /// property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionAsCryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(CryptoKeyVersion) ? null : gckv::CryptoKeyVersionName.Parse(CryptoKeyVersion, allowUnparsed: true);
            set => CryptoKeyVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="CryptoKeyVersions"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<gckv::CryptoKeyVersionName> CryptoKeyVersionsAsCryptoKeyVersionNames
        {
            get => new gax::ResourceNameList<gckv::CryptoKeyVersionName>(CryptoKeyVersions, s => string.IsNullOrEmpty(s) ? null : gckv::CryptoKeyVersionName.Parse(s, allowUnparsed: true));
        }
    }
}
