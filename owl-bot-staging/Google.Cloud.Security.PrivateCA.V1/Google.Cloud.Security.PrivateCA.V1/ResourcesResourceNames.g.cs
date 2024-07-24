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
using gcspv = Google.Cloud.Security.PrivateCA.V1;
using sys = System;

namespace Google.Cloud.Security.PrivateCA.V1
{
    /// <summary>Resource name for the <c>CertificateAuthority</c> resource.</summary>
    public sealed partial class CertificateAuthorityName : gax::IResourceName, sys::IEquatable<CertificateAuthorityName>
    {
        /// <summary>The possible contents of <see cref="CertificateAuthorityName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
            /// .
            /// </summary>
            ProjectLocationCaPoolCertificateAuthority = 1,
        }

        private static gax::PathTemplate s_projectLocationCaPoolCertificateAuthority = new gax::PathTemplate("projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}");

        /// <summary>Creates a <see cref="CertificateAuthorityName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateAuthorityName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateAuthorityName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateAuthorityName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateAuthorityName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CertificateAuthorityName"/> constructed from the provided ids.
        /// </returns>
        public static CertificateAuthorityName FromProjectLocationCaPoolCertificateAuthority(string projectId, string locationId, string caPoolId, string certificateAuthorityId) =>
            new CertificateAuthorityName(ResourceNameType.ProjectLocationCaPoolCertificateAuthority, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string caPoolId, string certificateAuthorityId) =>
            FormatProjectLocationCaPoolCertificateAuthority(projectId, locationId, caPoolId, certificateAuthorityId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCaPoolCertificateAuthority(string projectId, string locationId, string caPoolId, string certificateAuthorityId) =>
            s_projectLocationCaPoolCertificateAuthority.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateAuthorityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateAuthorityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CertificateAuthorityName"/> if successful.</returns>
        public static CertificateAuthorityName Parse(string certificateAuthorityName) =>
            Parse(certificateAuthorityName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateAuthorityName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateAuthorityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateAuthorityName"/> if successful.</returns>
        public static CertificateAuthorityName Parse(string certificateAuthorityName, bool allowUnparsed) =>
            TryParse(certificateAuthorityName, allowUnparsed, out CertificateAuthorityName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateAuthorityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateAuthorityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateAuthorityName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateAuthorityName, out CertificateAuthorityName result) =>
            TryParse(certificateAuthorityName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateAuthorityName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateAuthorityName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateAuthorityName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateAuthorityName, bool allowUnparsed, out CertificateAuthorityName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateAuthorityName, nameof(certificateAuthorityName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCaPoolCertificateAuthority.TryParseName(certificateAuthorityName, out resourceName))
            {
                result = FromProjectLocationCaPoolCertificateAuthority(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateAuthorityName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateAuthorityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caPoolId = null, string certificateAuthorityId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaPoolId = caPoolId;
            CertificateAuthorityId = certificateAuthorityId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateAuthorityName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CertificateAuthorityName(string projectId, string locationId, string caPoolId, string certificateAuthorityId) : this(ResourceNameType.ProjectLocationCaPoolCertificateAuthority, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)))
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
        /// The <c>CaPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CaPoolId { get; }

        /// <summary>
        /// The <c>CertificateAuthority</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CertificateAuthorityId { get; }

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
                case ResourceNameType.ProjectLocationCaPoolCertificateAuthority: return s_projectLocationCaPoolCertificateAuthority.Expand(ProjectId, LocationId, CaPoolId, CertificateAuthorityId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateAuthorityName);

        /// <inheritdoc/>
        public bool Equals(CertificateAuthorityName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateAuthorityName a, CertificateAuthorityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateAuthorityName a, CertificateAuthorityName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CaPool</c> resource.</summary>
    public sealed partial class CaPoolName : gax::IResourceName, sys::IEquatable<CaPoolName>
    {
        /// <summary>The possible contents of <see cref="CaPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
            /// </summary>
            ProjectLocationCaPool = 1,
        }

        private static gax::PathTemplate s_projectLocationCaPool = new gax::PathTemplate("projects/{project}/locations/{location}/caPools/{ca_pool}");

        /// <summary>Creates a <see cref="CaPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CaPoolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CaPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CaPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CaPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CaPoolName"/> constructed from the provided ids.</returns>
        public static CaPoolName FromProjectLocationCaPool(string projectId, string locationId, string caPoolId) =>
            new CaPoolName(ResourceNameType.ProjectLocationCaPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string caPoolId) =>
            FormatProjectLocationCaPool(projectId, locationId, caPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationCaPool(string projectId, string locationId, string caPoolId) =>
            s_projectLocationCaPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="CaPoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CaPoolName"/> if successful.</returns>
        public static CaPoolName Parse(string caPoolName) => Parse(caPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CaPoolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CaPoolName"/> if successful.</returns>
        public static CaPoolName Parse(string caPoolName, bool allowUnparsed) =>
            TryParse(caPoolName, allowUnparsed, out CaPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caPoolName, out CaPoolName result) => TryParse(caPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caPoolName, bool allowUnparsed, out CaPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(caPoolName, nameof(caPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCaPool.TryParseName(caPoolName, out resourceName))
            {
                result = FromProjectLocationCaPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(caPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CaPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caPoolId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaPoolId = caPoolId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CaPoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        public CaPoolName(string projectId, string locationId, string caPoolId) : this(ResourceNameType.ProjectLocationCaPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)))
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
        /// The <c>CaPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CaPoolId { get; }

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
                case ResourceNameType.ProjectLocationCaPool: return s_projectLocationCaPool.Expand(ProjectId, LocationId, CaPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CaPoolName);

        /// <inheritdoc/>
        public bool Equals(CaPoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CaPoolName a, CaPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CaPoolName a, CaPoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CertificateRevocationList</c> resource.</summary>
    public sealed partial class CertificateRevocationListName : gax::IResourceName, sys::IEquatable<CertificateRevocationListName>
    {
        /// <summary>The possible contents of <see cref="CertificateRevocationListName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
            /// .
            /// </summary>
            ProjectLocationCaPoolCertificateAuthorityCertificateRevocationList = 1,
        }

        private static gax::PathTemplate s_projectLocationCaPoolCertificateAuthorityCertificateRevocationList = new gax::PathTemplate("projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}");

        /// <summary>
        /// Creates a <see cref="CertificateRevocationListName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateRevocationListName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateRevocationListName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateRevocationListName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateRevocationListName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CertificateRevocationListName"/> constructed from the provided ids.
        /// </returns>
        public static CertificateRevocationListName FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList(string projectId, string locationId, string caPoolId, string certificateAuthorityId, string certificateRevocationListId) =>
            new CertificateRevocationListName(ResourceNameType.ProjectLocationCaPoolCertificateAuthorityCertificateRevocationList, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), certificateRevocationListId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateRevocationListId, nameof(certificateRevocationListId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateRevocationListName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateRevocationListName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string caPoolId, string certificateAuthorityId, string certificateRevocationListId) =>
            FormatProjectLocationCaPoolCertificateAuthorityCertificateRevocationList(projectId, locationId, caPoolId, certificateAuthorityId, certificateRevocationListId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateRevocationListName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateRevocationListName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCaPoolCertificateAuthorityCertificateRevocationList(string projectId, string locationId, string caPoolId, string certificateAuthorityId, string certificateRevocationListId) =>
            s_projectLocationCaPoolCertificateAuthorityCertificateRevocationList.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateRevocationListId, nameof(certificateRevocationListId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateRevocationListName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateRevocationListName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CertificateRevocationListName"/> if successful.</returns>
        public static CertificateRevocationListName Parse(string certificateRevocationListName) =>
            Parse(certificateRevocationListName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateRevocationListName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateRevocationListName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateRevocationListName"/> if successful.</returns>
        public static CertificateRevocationListName Parse(string certificateRevocationListName, bool allowUnparsed) =>
            TryParse(certificateRevocationListName, allowUnparsed, out CertificateRevocationListName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateRevocationListName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateRevocationListName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateRevocationListName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateRevocationListName, out CertificateRevocationListName result) =>
            TryParse(certificateRevocationListName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateRevocationListName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateRevocationListName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateRevocationListName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateRevocationListName, bool allowUnparsed, out CertificateRevocationListName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateRevocationListName, nameof(certificateRevocationListName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCaPoolCertificateAuthorityCertificateRevocationList.TryParseName(certificateRevocationListName, out resourceName))
            {
                result = FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateRevocationListName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateRevocationListName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caPoolId = null, string certificateAuthorityId = null, string certificateRevocationListId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaPoolId = caPoolId;
            CertificateAuthorityId = certificateAuthorityId;
            CertificateRevocationListId = certificateRevocationListId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateRevocationListName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/caPools/{ca_pool}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CertificateRevocationListName(string projectId, string locationId, string caPoolId, string certificateAuthorityId, string certificateRevocationListId) : this(ResourceNameType.ProjectLocationCaPoolCertificateAuthorityCertificateRevocationList, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), certificateRevocationListId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateRevocationListId, nameof(certificateRevocationListId)))
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
        /// The <c>CaPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CaPoolId { get; }

        /// <summary>
        /// The <c>CertificateAuthority</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CertificateAuthorityId { get; }

        /// <summary>
        /// The <c>CertificateRevocationList</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CertificateRevocationListId { get; }

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
                case ResourceNameType.ProjectLocationCaPoolCertificateAuthorityCertificateRevocationList: return s_projectLocationCaPoolCertificateAuthorityCertificateRevocationList.Expand(ProjectId, LocationId, CaPoolId, CertificateAuthorityId, CertificateRevocationListId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateRevocationListName);

        /// <inheritdoc/>
        public bool Equals(CertificateRevocationListName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateRevocationListName a, CertificateRevocationListName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateRevocationListName a, CertificateRevocationListName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Certificate</c> resource.</summary>
    public sealed partial class CertificateName : gax::IResourceName, sys::IEquatable<CertificateName>
    {
        /// <summary>The possible contents of <see cref="CertificateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>.
            /// </summary>
            ProjectLocationCaPoolCertificate = 1,
        }

        private static gax::PathTemplate s_projectLocationCaPoolCertificate = new gax::PathTemplate("projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}");

        /// <summary>Creates a <see cref="CertificateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CertificateName"/> constructed from the provided ids.</returns>
        public static CertificateName FromProjectLocationCaPoolCertificate(string projectId, string locationId, string caPoolId, string certificateId) =>
            new CertificateName(ResourceNameType.ProjectLocationCaPoolCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string caPoolId, string certificateId) =>
            FormatProjectLocationCaPoolCertificate(projectId, locationId, caPoolId, certificateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>.
        /// </returns>
        public static string FormatProjectLocationCaPoolCertificate(string projectId, string locationId, string caPoolId, string certificateId) =>
            s_projectLocationCaPoolCertificate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>Parses the given resource name string into a new <see cref="CertificateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CertificateName"/> if successful.</returns>
        public static CertificateName Parse(string certificateName) => Parse(certificateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateName"/> if successful.</returns>
        public static CertificateName Parse(string certificateName, bool allowUnparsed) =>
            TryParse(certificateName, allowUnparsed, out CertificateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateName, out CertificateName result) =>
            TryParse(certificateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateName, bool allowUnparsed, out CertificateName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateName, nameof(certificateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCaPoolCertificate.TryParseName(certificateName, out resourceName))
            {
                result = FromProjectLocationCaPoolCertificate(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caPoolId = null, string certificateId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaPoolId = caPoolId;
            CertificateId = certificateId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}/certificates/{certificate}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        public CertificateName(string projectId, string locationId, string caPoolId, string certificateId) : this(ResourceNameType.ProjectLocationCaPoolCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)))
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
        /// The <c>CaPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CaPoolId { get; }

        /// <summary>
        /// The <c>Certificate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CertificateId { get; }

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
                case ResourceNameType.ProjectLocationCaPoolCertificate: return s_projectLocationCaPoolCertificate.Expand(ProjectId, LocationId, CaPoolId, CertificateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateName);

        /// <inheritdoc/>
        public bool Equals(CertificateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateName a, CertificateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateName a, CertificateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CertificateTemplate</c> resource.</summary>
    public sealed partial class CertificateTemplateName : gax::IResourceName, sys::IEquatable<CertificateTemplateName>
    {
        /// <summary>The possible contents of <see cref="CertificateTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>.
            /// </summary>
            ProjectLocationCertificateTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificateTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/certificateTemplates/{certificate_template}");

        /// <summary>Creates a <see cref="CertificateTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateTemplateId">
        /// The <c>CertificateTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CertificateTemplateName"/> constructed from the provided ids.
        /// </returns>
        public static CertificateTemplateName FromProjectLocationCertificateTemplate(string projectId, string locationId, string certificateTemplateId) =>
            new CertificateTemplateName(ResourceNameType.ProjectLocationCertificateTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateTemplateId">
        /// The <c>CertificateTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateTemplateId) =>
            FormatProjectLocationCertificateTemplate(projectId, locationId, certificateTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateTemplateId">
        /// The <c>CertificateTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>.
        /// </returns>
        public static string FormatProjectLocationCertificateTemplate(string projectId, string locationId, string certificateTemplateId) =>
            s_projectLocationCertificateTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CertificateTemplateName"/> if successful.</returns>
        public static CertificateTemplateName Parse(string certificateTemplateName) => Parse(certificateTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateTemplateName"/> if successful.</returns>
        public static CertificateTemplateName Parse(string certificateTemplateName, bool allowUnparsed) =>
            TryParse(certificateTemplateName, allowUnparsed, out CertificateTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateTemplateName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateTemplateName, out CertificateTemplateName result) =>
            TryParse(certificateTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateTemplateName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateTemplateName, bool allowUnparsed, out CertificateTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateTemplateName, nameof(certificateTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCertificateTemplate.TryParseName(certificateTemplateName, out resourceName))
            {
                result = FromProjectLocationCertificateTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateTemplateId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateTemplateId = certificateTemplateId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateTemplateName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/certificateTemplates/{certificate_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateTemplateId">
        /// The <c>CertificateTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CertificateTemplateName(string projectId, string locationId, string certificateTemplateId) : this(ResourceNameType.ProjectLocationCertificateTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)))
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
        /// The <c>CertificateTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CertificateTemplateId { get; }

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
                case ResourceNameType.ProjectLocationCertificateTemplate: return s_projectLocationCertificateTemplate.Expand(ProjectId, LocationId, CertificateTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateTemplateName);

        /// <inheritdoc/>
        public bool Equals(CertificateTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateTemplateName a, CertificateTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateTemplateName a, CertificateTemplateName b) => !(a == b);
    }

    public partial class CertificateAuthority
    {
        /// <summary>
        /// <see cref="gcspv::CertificateAuthorityName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateAuthorityName CertificateAuthorityName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateAuthorityName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CaPool
    {
        /// <summary>
        /// <see cref="gcspv::CaPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CaPoolName CaPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CaPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CertificateRevocationList
    {
        /// <summary>
        /// <see cref="gcspv::CertificateRevocationListName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcspv::CertificateRevocationListName CertificateRevocationListName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateRevocationListName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class RevokedCertificate
            {
                /// <summary>
                /// <see cref="CertificateName"/>-typed view over the <see cref="Certificate"/> resource name property.
                /// </summary>
                public CertificateName CertificateAsCertificateName
                {
                    get => string.IsNullOrEmpty(Certificate) ? null : CertificateName.Parse(Certificate, allowUnparsed: true);
                    set => Certificate = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Certificate
    {
        /// <summary>
        /// <see cref="gcspv::CertificateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateName CertificateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CertificateAuthorityName"/>-typed view over the <see cref="IssuerCertificateAuthority"/> resource
        /// name property.
        /// </summary>
        public CertificateAuthorityName IssuerCertificateAuthorityAsCertificateAuthorityName
        {
            get => string.IsNullOrEmpty(IssuerCertificateAuthority) ? null : CertificateAuthorityName.Parse(IssuerCertificateAuthority, allowUnparsed: true);
            set => IssuerCertificateAuthority = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CertificateTemplateName"/>-typed view over the <see cref="CertificateTemplate"/> resource name
        /// property.
        /// </summary>
        public CertificateTemplateName CertificateTemplateAsCertificateTemplateName
        {
            get => string.IsNullOrEmpty(CertificateTemplate) ? null : CertificateTemplateName.Parse(CertificateTemplate, allowUnparsed: true);
            set => CertificateTemplate = value?.ToString() ?? "";
        }
    }

    public partial class CertificateTemplate
    {
        /// <summary>
        /// <see cref="gcspv::CertificateTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::CertificateTemplateName CertificateTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::CertificateTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SubordinateConfig
    {
        /// <summary>
        /// <see cref="CertificateAuthorityName"/>-typed view over the <see cref="CertificateAuthority"/> resource name
        /// property.
        /// </summary>
        public CertificateAuthorityName CertificateAuthorityAsCertificateAuthorityName
        {
            get => string.IsNullOrEmpty(CertificateAuthority) ? null : CertificateAuthorityName.Parse(CertificateAuthority, allowUnparsed: true);
            set => CertificateAuthority = value?.ToString() ?? "";
        }
    }
}
