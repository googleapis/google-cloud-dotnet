// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcspv = Google.Cloud.Security.PrivateCA.V1Beta1;
using sys = System;

namespace Google.Cloud.Security.PrivateCA.V1Beta1
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
            /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>.
            /// </summary>
            ProjectLocationCertificateAuthority = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificateAuthority = new gax::PathTemplate("projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}");

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
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CertificateAuthorityName"/> constructed from the provided ids.
        /// </returns>
        public static CertificateAuthorityName FromProjectLocationCertificateAuthority(string projectId, string locationId, string certificateAuthorityId) =>
            new CertificateAuthorityName(ResourceNameType.ProjectLocationCertificateAuthority, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateAuthorityId) =>
            FormatProjectLocationCertificateAuthority(projectId, locationId, certificateAuthorityId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateAuthorityName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>.
        /// </returns>
        public static string FormatProjectLocationCertificateAuthority(string projectId, string locationId, string certificateAuthorityId) =>
            s_projectLocationCertificateAuthority.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateAuthorityName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>
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
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>
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
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>
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
        /// <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>
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
            if (s_projectLocationCertificateAuthority.TryParseName(certificateAuthorityName, out resourceName))
            {
                result = FromProjectLocationCertificateAuthority(resourceName[0], resourceName[1], resourceName[2]);
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

        private CertificateAuthorityName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateAuthorityId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateAuthorityId = certificateAuthorityId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateAuthorityName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CertificateAuthorityName(string projectId, string locationId, string certificateAuthorityId) : this(ResourceNameType.ProjectLocationCertificateAuthority, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)))
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
                case ResourceNameType.ProjectLocationCertificateAuthority: return s_projectLocationCertificateAuthority.Expand(ProjectId, LocationId, CertificateAuthorityId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateAuthorityName);

        /// <inheritdoc/>
        public bool Equals(CertificateAuthorityName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CertificateAuthorityName a, CertificateAuthorityName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CertificateAuthorityName a, CertificateAuthorityName b) => !(a == b);
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
            /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
            /// .
            /// </summary>
            ProjectLocationCertificateAuthorityCertificateRevocationList = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificateAuthorityCertificateRevocationList = new gax::PathTemplate("projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}");

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
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CertificateRevocationListName"/> constructed from the provided ids.
        /// </returns>
        public static CertificateRevocationListName FromProjectLocationCertificateAuthorityCertificateRevocationList(string projectId, string locationId, string certificateAuthorityId, string certificateRevocationListId) =>
            new CertificateRevocationListName(ResourceNameType.ProjectLocationCertificateAuthorityCertificateRevocationList, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), certificateRevocationListId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateRevocationListId, nameof(certificateRevocationListId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateRevocationListName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateRevocationListName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateAuthorityId, string certificateRevocationListId) =>
            FormatProjectLocationCertificateAuthorityCertificateRevocationList(projectId, locationId, certificateAuthorityId, certificateRevocationListId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateRevocationListName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateRevocationListName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCertificateAuthorityCertificateRevocationList(string projectId, string locationId, string certificateAuthorityId, string certificateRevocationListId) =>
            s_projectLocationCertificateAuthorityCertificateRevocationList.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateRevocationListId, nameof(certificateRevocationListId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateRevocationListName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
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
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
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
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
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
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
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
            if (s_projectLocationCertificateAuthorityCertificateRevocationList.TryParseName(certificateRevocationListName, out resourceName))
            {
                result = FromProjectLocationCertificateAuthorityCertificateRevocationList(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private CertificateRevocationListName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateAuthorityId = null, string certificateRevocationListId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateAuthorityId = certificateAuthorityId;
            CertificateRevocationListId = certificateRevocationListId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateRevocationListName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificateRevocationLists/{certificate_revocation_list}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateRevocationListId">
        /// The <c>CertificateRevocationList</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CertificateRevocationListName(string projectId, string locationId, string certificateAuthorityId, string certificateRevocationListId) : this(ResourceNameType.ProjectLocationCertificateAuthorityCertificateRevocationList, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), certificateRevocationListId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateRevocationListId, nameof(certificateRevocationListId)))
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
                case ResourceNameType.ProjectLocationCertificateAuthorityCertificateRevocationList: return s_projectLocationCertificateAuthorityCertificateRevocationList.Expand(ProjectId, LocationId, CertificateAuthorityId, CertificateRevocationListId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateRevocationListName);

        /// <inheritdoc/>
        public bool Equals(CertificateRevocationListName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CertificateRevocationListName a, CertificateRevocationListName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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
            /// <c>
            /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
            /// .
            /// </summary>
            ProjectLocationCertificateAuthorityCertificate = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificateAuthorityCertificate = new gax::PathTemplate("projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}");

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
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CertificateName"/> constructed from the provided ids.</returns>
        public static CertificateName FromProjectLocationCertificateAuthorityCertificate(string projectId, string locationId, string certificateAuthorityId, string certificateId) =>
            new CertificateName(ResourceNameType.ProjectLocationCertificateAuthorityCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateAuthorityId, string certificateId) =>
            FormatProjectLocationCertificateAuthorityCertificate(projectId, locationId, certificateAuthorityId, certificateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCertificateAuthorityCertificate(string projectId, string locationId, string certificateAuthorityId, string certificateId) =>
            s_projectLocationCertificateAuthorityCertificate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>Parses the given resource name string into a new <see cref="CertificateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
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
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
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
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
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
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
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
            if (s_projectLocationCertificateAuthorityCertificate.TryParseName(certificateName, out resourceName))
            {
                result = FromProjectLocationCertificateAuthorityCertificate(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private CertificateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateId = null, string certificateAuthorityId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateId = certificateId;
            CertificateAuthorityId = certificateAuthorityId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateAuthorities/{certificate_authority}/certificates/{certificate}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateAuthorityId">
        /// The <c>CertificateAuthority</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        public CertificateName(string projectId, string locationId, string certificateAuthorityId, string certificateId) : this(ResourceNameType.ProjectLocationCertificateAuthorityCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateAuthorityId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)))
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
        /// The <c>Certificate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CertificateId { get; }

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
                case ResourceNameType.ProjectLocationCertificateAuthorityCertificate: return s_projectLocationCertificateAuthorityCertificate.Expand(ProjectId, LocationId, CertificateAuthorityId, CertificateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateName);

        /// <inheritdoc/>
        public bool Equals(CertificateName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CertificateName a, CertificateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CertificateName a, CertificateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReusableConfig</c> resource.</summary>
    public sealed partial class ReusableConfigName : gax::IResourceName, sys::IEquatable<ReusableConfigName>
    {
        /// <summary>The possible contents of <see cref="ReusableConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>.
            /// </summary>
            ProjectLocationReusableConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationReusableConfig = new gax::PathTemplate("projects/{project}/locations/{location}/reusableConfigs/{reusable_config}");

        /// <summary>Creates a <see cref="ReusableConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReusableConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReusableConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReusableConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReusableConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reusableConfigId">The <c>ReusableConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReusableConfigName"/> constructed from the provided ids.</returns>
        public static ReusableConfigName FromProjectLocationReusableConfig(string projectId, string locationId, string reusableConfigId) =>
            new ReusableConfigName(ResourceNameType.ProjectLocationReusableConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reusableConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reusableConfigId, nameof(reusableConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReusableConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reusableConfigId">The <c>ReusableConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReusableConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reusableConfigId) =>
            FormatProjectLocationReusableConfig(projectId, locationId, reusableConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReusableConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reusableConfigId">The <c>ReusableConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReusableConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>.
        /// </returns>
        public static string FormatProjectLocationReusableConfig(string projectId, string locationId, string reusableConfigId) =>
            s_projectLocationReusableConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reusableConfigId, nameof(reusableConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReusableConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reusableConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReusableConfigName"/> if successful.</returns>
        public static ReusableConfigName Parse(string reusableConfigName) => Parse(reusableConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReusableConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reusableConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReusableConfigName"/> if successful.</returns>
        public static ReusableConfigName Parse(string reusableConfigName, bool allowUnparsed) =>
            TryParse(reusableConfigName, allowUnparsed, out ReusableConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReusableConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reusableConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReusableConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reusableConfigName, out ReusableConfigName result) =>
            TryParse(reusableConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReusableConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reusableConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReusableConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reusableConfigName, bool allowUnparsed, out ReusableConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(reusableConfigName, nameof(reusableConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReusableConfig.TryParseName(reusableConfigName, out resourceName))
            {
                result = FromProjectLocationReusableConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reusableConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReusableConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reusableConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReusableConfigId = reusableConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReusableConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reusableConfigs/{reusable_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reusableConfigId">The <c>ReusableConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ReusableConfigName(string projectId, string locationId, string reusableConfigId) : this(ResourceNameType.ProjectLocationReusableConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reusableConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(reusableConfigId, nameof(reusableConfigId)))
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
        /// The <c>ReusableConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReusableConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReusableConfig: return s_projectLocationReusableConfig.Expand(ProjectId, LocationId, ReusableConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReusableConfigName);

        /// <inheritdoc/>
        public bool Equals(ReusableConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ReusableConfigName a, ReusableConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ReusableConfigName a, ReusableConfigName b) => !(a == b);
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
    }

    public partial class ReusableConfig
    {
        /// <summary>
        /// <see cref="gcspv::ReusableConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcspv::ReusableConfigName ReusableConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcspv::ReusableConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
