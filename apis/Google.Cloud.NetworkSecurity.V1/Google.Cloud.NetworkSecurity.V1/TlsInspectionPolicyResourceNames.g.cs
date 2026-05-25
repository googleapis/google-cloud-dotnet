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
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>TlsInspectionPolicy</c> resource.</summary>
    public sealed partial class TlsInspectionPolicyName : gax::IResourceName, sys::IEquatable<TlsInspectionPolicyName>
    {
        /// <summary>The possible contents of <see cref="TlsInspectionPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>.
            /// </summary>
            ProjectLocationTlsInspectionPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationTlsInspectionPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}");

        /// <summary>Creates a <see cref="TlsInspectionPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TlsInspectionPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TlsInspectionPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TlsInspectionPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TlsInspectionPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsInspectionPolicyId">
        /// The <c>TlsInspectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="TlsInspectionPolicyName"/> constructed from the provided ids.
        /// </returns>
        public static TlsInspectionPolicyName FromProjectLocationTlsInspectionPolicy(string projectId, string locationId, string tlsInspectionPolicyId) =>
            new TlsInspectionPolicyName(ResourceNameType.ProjectLocationTlsInspectionPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tlsInspectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TlsInspectionPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsInspectionPolicyId">
        /// The <c>TlsInspectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TlsInspectionPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tlsInspectionPolicyId) =>
            FormatProjectLocationTlsInspectionPolicy(projectId, locationId, tlsInspectionPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TlsInspectionPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsInspectionPolicyId">
        /// The <c>TlsInspectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TlsInspectionPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationTlsInspectionPolicy(string projectId, string locationId, string tlsInspectionPolicyId) =>
            s_projectLocationTlsInspectionPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TlsInspectionPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tlsInspectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TlsInspectionPolicyName"/> if successful.</returns>
        public static TlsInspectionPolicyName Parse(string tlsInspectionPolicyName) => Parse(tlsInspectionPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TlsInspectionPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tlsInspectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TlsInspectionPolicyName"/> if successful.</returns>
        public static TlsInspectionPolicyName Parse(string tlsInspectionPolicyName, bool allowUnparsed) =>
            TryParse(tlsInspectionPolicyName, allowUnparsed, out TlsInspectionPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TlsInspectionPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tlsInspectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TlsInspectionPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tlsInspectionPolicyName, out TlsInspectionPolicyName result) =>
            TryParse(tlsInspectionPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TlsInspectionPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tlsInspectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TlsInspectionPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tlsInspectionPolicyName, bool allowUnparsed, out TlsInspectionPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(tlsInspectionPolicyName, nameof(tlsInspectionPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTlsInspectionPolicy.TryParseName(tlsInspectionPolicyName, out resourceName))
            {
                result = FromProjectLocationTlsInspectionPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tlsInspectionPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TlsInspectionPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tlsInspectionPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TlsInspectionPolicyId = tlsInspectionPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TlsInspectionPolicyName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/tlsInspectionPolicies/{tls_inspection_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tlsInspectionPolicyId">
        /// The <c>TlsInspectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public TlsInspectionPolicyName(string projectId, string locationId, string tlsInspectionPolicyId) : this(ResourceNameType.ProjectLocationTlsInspectionPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tlsInspectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(tlsInspectionPolicyId, nameof(tlsInspectionPolicyId)))
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
        /// The <c>TlsInspectionPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string TlsInspectionPolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTlsInspectionPolicy: return s_projectLocationTlsInspectionPolicy.Expand(ProjectId, LocationId, TlsInspectionPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TlsInspectionPolicyName);

        /// <inheritdoc/>
        public bool Equals(TlsInspectionPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TlsInspectionPolicyName a, TlsInspectionPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TlsInspectionPolicyName a, TlsInspectionPolicyName b) => !(a == b);
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

    public partial class TlsInspectionPolicy
    {
        /// <summary>
        /// <see cref="gcnv::TlsInspectionPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TlsInspectionPolicyName TlsInspectionPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TlsInspectionPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="CaPoolName"/>-typed view over the <see cref="CaPool"/> resource name property.</summary>
        public CaPoolName CaPoolAsCaPoolName
        {
            get => string.IsNullOrEmpty(CaPool) ? null : CaPoolName.Parse(CaPool, allowUnparsed: true);
            set => CaPool = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TrustConfigName"/>-typed view over the <see cref="TrustConfig"/> resource name property.
        /// </summary>
        public TrustConfigName TrustConfigAsTrustConfigName
        {
            get => string.IsNullOrEmpty(TrustConfig) ? null : TrustConfigName.Parse(TrustConfig, allowUnparsed: true);
            set => TrustConfig = value?.ToString() ?? "";
        }
    }

    public partial class CreateTlsInspectionPolicyRequest
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

    public partial class ListTlsInspectionPoliciesRequest
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

    public partial class GetTlsInspectionPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::TlsInspectionPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TlsInspectionPolicyName TlsInspectionPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TlsInspectionPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTlsInspectionPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::TlsInspectionPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TlsInspectionPolicyName TlsInspectionPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TlsInspectionPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
