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
using gccv = Google.Cloud.CertificateManager.V1;
using sys = System;

namespace Google.Cloud.CertificateManager.V1
{
    /// <summary>Resource name for the <c>Certificate</c> resource.</summary>
    public sealed partial class CertificateName : gax::IResourceName, sys::IEquatable<CertificateName>
    {
        /// <summary>The possible contents of <see cref="CertificateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
            /// </summary>
            ProjectLocationCertificate = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificate = new gax::PathTemplate("projects/{project}/locations/{location}/certificates/{certificate}");

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
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CertificateName"/> constructed from the provided ids.</returns>
        public static CertificateName FromProjectLocationCertificate(string projectId, string locationId, string certificateId) =>
            new CertificateName(ResourceNameType.ProjectLocationCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateId) =>
            FormatProjectLocationCertificate(projectId, locationId, certificateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </returns>
        public static string FormatProjectLocationCertificate(string projectId, string locationId, string certificateId) =>
            s_projectLocationCertificate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>Parses the given resource name string into a new <see cref="CertificateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
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
            if (s_projectLocationCertificate.TryParseName(certificateName, out resourceName))
            {
                result = FromProjectLocationCertificate(resourceName[0], resourceName[1], resourceName[2]);
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

        private CertificateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateId = certificateId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        public CertificateName(string projectId, string locationId, string certificateId) : this(ResourceNameType.ProjectLocationCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)))
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
                case ResourceNameType.ProjectLocationCertificate: return s_projectLocationCertificate.Expand(ProjectId, LocationId, CertificateId);
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

    /// <summary>Resource name for the <c>CertificateMap</c> resource.</summary>
    public sealed partial class CertificateMapName : gax::IResourceName, sys::IEquatable<CertificateMapName>
    {
        /// <summary>The possible contents of <see cref="CertificateMapName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>.
            /// </summary>
            ProjectLocationCertificateMap = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificateMap = new gax::PathTemplate("projects/{project}/locations/{location}/certificateMaps/{certificate_map}");

        /// <summary>Creates a <see cref="CertificateMapName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateMapName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateMapName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateMapName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateMapName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CertificateMapName"/> constructed from the provided ids.</returns>
        public static CertificateMapName FromProjectLocationCertificateMap(string projectId, string locationId, string certificateMapId) =>
            new CertificateMapName(ResourceNameType.ProjectLocationCertificateMap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateMapId) =>
            FormatProjectLocationCertificateMap(projectId, locationId, certificateMapId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>.
        /// </returns>
        public static string FormatProjectLocationCertificateMap(string projectId, string locationId, string certificateMapId) =>
            s_projectLocationCertificateMap.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateMapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CertificateMapName"/> if successful.</returns>
        public static CertificateMapName Parse(string certificateMapName) => Parse(certificateMapName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateMapName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateMapName"/> if successful.</returns>
        public static CertificateMapName Parse(string certificateMapName, bool allowUnparsed) =>
            TryParse(certificateMapName, allowUnparsed, out CertificateMapName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateMapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateMapName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateMapName, out CertificateMapName result) =>
            TryParse(certificateMapName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateMapName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateMapName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateMapName, bool allowUnparsed, out CertificateMapName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateMapName, nameof(certificateMapName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCertificateMap.TryParseName(certificateMapName, out resourceName))
            {
                result = FromProjectLocationCertificateMap(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateMapName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateMapName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateMapId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateMapId = certificateMapId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateMapName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/certificateMaps/{certificate_map}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        public CertificateMapName(string projectId, string locationId, string certificateMapId) : this(ResourceNameType.ProjectLocationCertificateMap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)))
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
        /// The <c>CertificateMap</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CertificateMapId { get; }

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
                case ResourceNameType.ProjectLocationCertificateMap: return s_projectLocationCertificateMap.Expand(ProjectId, LocationId, CertificateMapId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateMapName);

        /// <inheritdoc/>
        public bool Equals(CertificateMapName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateMapName a, CertificateMapName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateMapName a, CertificateMapName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CertificateMapEntry</c> resource.</summary>
    public sealed partial class CertificateMapEntryName : gax::IResourceName, sys::IEquatable<CertificateMapEntryName>
    {
        /// <summary>The possible contents of <see cref="CertificateMapEntryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
            /// .
            /// </summary>
            ProjectLocationCertificateMapCertificateMapEntry = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificateMapCertificateMapEntry = new gax::PathTemplate("projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}");

        /// <summary>Creates a <see cref="CertificateMapEntryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateMapEntryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateMapEntryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateMapEntryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateMapEntryName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapEntryId">
        /// The <c>CertificateMapEntry</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CertificateMapEntryName"/> constructed from the provided ids.
        /// </returns>
        public static CertificateMapEntryName FromProjectLocationCertificateMapCertificateMapEntry(string projectId, string locationId, string certificateMapId, string certificateMapEntryId) =>
            new CertificateMapEntryName(ResourceNameType.ProjectLocationCertificateMapCertificateMapEntry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)), certificateMapEntryId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateMapEntryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapEntryId">
        /// The <c>CertificateMapEntry</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateMapEntryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateMapId, string certificateMapEntryId) =>
            FormatProjectLocationCertificateMapCertificateMapEntry(projectId, locationId, certificateMapId, certificateMapEntryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateMapEntryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapEntryId">
        /// The <c>CertificateMapEntry</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CertificateMapEntryName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCertificateMapCertificateMapEntry(string projectId, string locationId, string certificateMapId, string certificateMapEntryId) =>
            s_projectLocationCertificateMapCertificateMapEntry.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateMapEntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateMapEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CertificateMapEntryName"/> if successful.</returns>
        public static CertificateMapEntryName Parse(string certificateMapEntryName) => Parse(certificateMapEntryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateMapEntryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateMapEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateMapEntryName"/> if successful.</returns>
        public static CertificateMapEntryName Parse(string certificateMapEntryName, bool allowUnparsed) =>
            TryParse(certificateMapEntryName, allowUnparsed, out CertificateMapEntryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateMapEntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateMapEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateMapEntryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateMapEntryName, out CertificateMapEntryName result) =>
            TryParse(certificateMapEntryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateMapEntryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateMapEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateMapEntryName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateMapEntryName, bool allowUnparsed, out CertificateMapEntryName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateMapEntryName, nameof(certificateMapEntryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCertificateMapCertificateMapEntry.TryParseName(certificateMapEntryName, out resourceName))
            {
                result = FromProjectLocationCertificateMapCertificateMapEntry(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateMapEntryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateMapEntryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateMapId = null, string certificateMapEntryId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateMapId = certificateMapId;
            CertificateMapEntryId = certificateMapEntryId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateMapEntryName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/certificateMaps/{certificate_map}/certificateMapEntries/{certificate_map_entry}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapId">The <c>CertificateMap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateMapEntryId">
        /// The <c>CertificateMapEntry</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CertificateMapEntryName(string projectId, string locationId, string certificateMapId, string certificateMapEntryId) : this(ResourceNameType.ProjectLocationCertificateMapCertificateMapEntry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapId, nameof(certificateMapId)), certificateMapEntryId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateMapEntryId, nameof(certificateMapEntryId)))
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
        /// The <c>CertificateMap</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CertificateMapId { get; }

        /// <summary>
        /// The <c>CertificateMapEntry</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CertificateMapEntryId { get; }

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
                case ResourceNameType.ProjectLocationCertificateMapCertificateMapEntry: return s_projectLocationCertificateMapCertificateMapEntry.Expand(ProjectId, LocationId, CertificateMapId, CertificateMapEntryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateMapEntryName);

        /// <inheritdoc/>
        public bool Equals(CertificateMapEntryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateMapEntryName a, CertificateMapEntryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateMapEntryName a, CertificateMapEntryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DnsAuthorization</c> resource.</summary>
    public sealed partial class DnsAuthorizationName : gax::IResourceName, sys::IEquatable<DnsAuthorizationName>
    {
        /// <summary>The possible contents of <see cref="DnsAuthorizationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>.
            /// </summary>
            ProjectLocationDnsAuthorization = 1,
        }

        private static gax::PathTemplate s_projectLocationDnsAuthorization = new gax::PathTemplate("projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}");

        /// <summary>Creates a <see cref="DnsAuthorizationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DnsAuthorizationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DnsAuthorizationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DnsAuthorizationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DnsAuthorizationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dnsAuthorizationId">The <c>DnsAuthorization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DnsAuthorizationName"/> constructed from the provided ids.</returns>
        public static DnsAuthorizationName FromProjectLocationDnsAuthorization(string projectId, string locationId, string dnsAuthorizationId) =>
            new DnsAuthorizationName(ResourceNameType.ProjectLocationDnsAuthorization, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dnsAuthorizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DnsAuthorizationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dnsAuthorizationId">The <c>DnsAuthorization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DnsAuthorizationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dnsAuthorizationId) =>
            FormatProjectLocationDnsAuthorization(projectId, locationId, dnsAuthorizationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DnsAuthorizationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dnsAuthorizationId">The <c>DnsAuthorization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DnsAuthorizationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>.
        /// </returns>
        public static string FormatProjectLocationDnsAuthorization(string projectId, string locationId, string dnsAuthorizationId) =>
            s_projectLocationDnsAuthorization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DnsAuthorizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dnsAuthorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DnsAuthorizationName"/> if successful.</returns>
        public static DnsAuthorizationName Parse(string dnsAuthorizationName) => Parse(dnsAuthorizationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DnsAuthorizationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dnsAuthorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DnsAuthorizationName"/> if successful.</returns>
        public static DnsAuthorizationName Parse(string dnsAuthorizationName, bool allowUnparsed) =>
            TryParse(dnsAuthorizationName, allowUnparsed, out DnsAuthorizationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DnsAuthorizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dnsAuthorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DnsAuthorizationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dnsAuthorizationName, out DnsAuthorizationName result) =>
            TryParse(dnsAuthorizationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DnsAuthorizationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dnsAuthorizationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DnsAuthorizationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dnsAuthorizationName, bool allowUnparsed, out DnsAuthorizationName result)
        {
            gax::GaxPreconditions.CheckNotNull(dnsAuthorizationName, nameof(dnsAuthorizationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDnsAuthorization.TryParseName(dnsAuthorizationName, out resourceName))
            {
                result = FromProjectLocationDnsAuthorization(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dnsAuthorizationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DnsAuthorizationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dnsAuthorizationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DnsAuthorizationId = dnsAuthorizationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DnsAuthorizationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dnsAuthorizations/{dns_authorization}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dnsAuthorizationId">The <c>DnsAuthorization</c> ID. Must not be <c>null</c> or empty.</param>
        public DnsAuthorizationName(string projectId, string locationId, string dnsAuthorizationId) : this(ResourceNameType.ProjectLocationDnsAuthorization, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dnsAuthorizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(dnsAuthorizationId, nameof(dnsAuthorizationId)))
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
        /// The <c>DnsAuthorization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DnsAuthorizationId { get; }

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
                case ResourceNameType.ProjectLocationDnsAuthorization: return s_projectLocationDnsAuthorization.Expand(ProjectId, LocationId, DnsAuthorizationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DnsAuthorizationName);

        /// <inheritdoc/>
        public bool Equals(DnsAuthorizationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DnsAuthorizationName a, DnsAuthorizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DnsAuthorizationName a, DnsAuthorizationName b) => !(a == b);
    }

    public partial class ListCertificatesRequest
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

    public partial class GetCertificateRequest
    {
        /// <summary>
        /// <see cref="gccv::CertificateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateName CertificateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCertificateRequest
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

    public partial class DeleteCertificateRequest
    {
        /// <summary>
        /// <see cref="gccv::CertificateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateName CertificateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCertificateMapsRequest
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

    public partial class GetCertificateMapRequest
    {
        /// <summary>
        /// <see cref="gccv::CertificateMapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateMapName CertificateMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCertificateMapRequest
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

    public partial class DeleteCertificateMapRequest
    {
        /// <summary>
        /// <see cref="gccv::CertificateMapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateMapName CertificateMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCertificateMapEntriesRequest
    {
        /// <summary>
        /// <see cref="CertificateMapName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CertificateMapName ParentAsCertificateMapName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CertificateMapName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCertificateMapEntryRequest
    {
        /// <summary>
        /// <see cref="gccv::CertificateMapEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateMapEntryName CertificateMapEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateMapEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCertificateMapEntryRequest
    {
        /// <summary>
        /// <see cref="CertificateMapName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CertificateMapName ParentAsCertificateMapName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CertificateMapName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCertificateMapEntryRequest
    {
        /// <summary>
        /// <see cref="gccv::CertificateMapEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateMapEntryName CertificateMapEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateMapEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDnsAuthorizationsRequest
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

    public partial class GetDnsAuthorizationRequest
    {
        /// <summary>
        /// <see cref="gccv::DnsAuthorizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DnsAuthorizationName DnsAuthorizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DnsAuthorizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDnsAuthorizationRequest
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

    public partial class DeleteDnsAuthorizationRequest
    {
        /// <summary>
        /// <see cref="gccv::DnsAuthorizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DnsAuthorizationName DnsAuthorizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DnsAuthorizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Certificate
    {
        /// <summary>
        /// <see cref="gccv::CertificateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateName CertificateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ManagedCertificate
            {
                /// <summary>
                /// <see cref="DnsAuthorizationName"/>-typed view over the <see cref="DnsAuthorizations"/> resource name
                /// property.
                /// </summary>
                public gax::ResourceNameList<DnsAuthorizationName> DnsAuthorizationsAsDnsAuthorizationNames
                {
                    get => new gax::ResourceNameList<DnsAuthorizationName>(DnsAuthorizations, s => string.IsNullOrEmpty(s) ? null : DnsAuthorizationName.Parse(s, allowUnparsed: true));
                }

                /// <summary>
                /// <see cref="CertificateIssuanceConfigName"/>-typed view over the <see cref="IssuanceConfig"/>
                /// resource name property.
                /// </summary>
                public CertificateIssuanceConfigName IssuanceConfigAsCertificateIssuanceConfigName
                {
                    get => string.IsNullOrEmpty(IssuanceConfig) ? null : CertificateIssuanceConfigName.Parse(IssuanceConfig, allowUnparsed: true);
                    set => IssuanceConfig = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class CertificateMap
    {
        /// <summary>
        /// <see cref="gccv::CertificateMapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateMapName CertificateMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CertificateMapEntry
    {
        /// <summary>
        /// <see cref="gccv::CertificateMapEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CertificateMapEntryName CertificateMapEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CertificateMapEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CertificateName"/>-typed view over the <see cref="Certificates"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<CertificateName> CertificatesAsCertificateNames
        {
            get => new gax::ResourceNameList<CertificateName>(Certificates, s => string.IsNullOrEmpty(s) ? null : CertificateName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class DnsAuthorization
    {
        /// <summary>
        /// <see cref="gccv::DnsAuthorizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DnsAuthorizationName DnsAuthorizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DnsAuthorizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
