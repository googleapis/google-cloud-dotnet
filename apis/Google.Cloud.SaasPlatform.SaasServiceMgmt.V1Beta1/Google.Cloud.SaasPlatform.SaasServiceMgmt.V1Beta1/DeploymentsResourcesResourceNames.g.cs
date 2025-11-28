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
using gcssv = Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1;
using sys = System;

namespace Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1
{
    /// <summary>Resource name for the <c>Saas</c> resource.</summary>
    public sealed partial class SaasName : gax::IResourceName, sys::IEquatable<SaasName>
    {
        /// <summary>The possible contents of <see cref="SaasName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/saas/{saas}</c>.
            /// </summary>
            ProjectLocationSaas = 1,
        }

        private static gax::PathTemplate s_projectLocationSaas = new gax::PathTemplate("projects/{project}/locations/{location}/saas/{saas}");

        /// <summary>Creates a <see cref="SaasName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SaasName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SaasName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SaasName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SaasName"/> with the pattern <c>projects/{project}/locations/{location}/saas/{saas}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="saasId">The <c>Saas</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SaasName"/> constructed from the provided ids.</returns>
        public static SaasName FromProjectLocationSaas(string projectId, string locationId, string saasId) =>
            new SaasName(ResourceNameType.ProjectLocationSaas, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), saasId: gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SaasName"/> with pattern
        /// <c>projects/{project}/locations/{location}/saas/{saas}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="saasId">The <c>Saas</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SaasName"/> with pattern
        /// <c>projects/{project}/locations/{location}/saas/{saas}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string saasId) =>
            FormatProjectLocationSaas(projectId, locationId, saasId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SaasName"/> with pattern
        /// <c>projects/{project}/locations/{location}/saas/{saas}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="saasId">The <c>Saas</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SaasName"/> with pattern
        /// <c>projects/{project}/locations/{location}/saas/{saas}</c>.
        /// </returns>
        public static string FormatProjectLocationSaas(string projectId, string locationId, string saasId) =>
            s_projectLocationSaas.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)));

        /// <summary>Parses the given resource name string into a new <see cref="SaasName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/saas/{saas}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="saasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SaasName"/> if successful.</returns>
        public static SaasName Parse(string saasName) => Parse(saasName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SaasName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/saas/{saas}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="saasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SaasName"/> if successful.</returns>
        public static SaasName Parse(string saasName, bool allowUnparsed) =>
            TryParse(saasName, allowUnparsed, out SaasName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SaasName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/saas/{saas}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="saasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SaasName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string saasName, out SaasName result) => TryParse(saasName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SaasName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/saas/{saas}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="saasName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SaasName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string saasName, bool allowUnparsed, out SaasName result)
        {
            gax::GaxPreconditions.CheckNotNull(saasName, nameof(saasName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSaas.TryParseName(saasName, out resourceName))
            {
                result = FromProjectLocationSaas(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(saasName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SaasName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string saasId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SaasId = saasId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SaasName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/saas/{saas}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="saasId">The <c>Saas</c> ID. Must not be <c>null</c> or empty.</param>
        public SaasName(string projectId, string locationId, string saasId) : this(ResourceNameType.ProjectLocationSaas, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), saasId: gax::GaxPreconditions.CheckNotNullOrEmpty(saasId, nameof(saasId)))
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
        /// The <c>Saas</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SaasId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSaas: return s_projectLocationSaas.Expand(ProjectId, LocationId, SaasId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SaasName);

        /// <inheritdoc/>
        public bool Equals(SaasName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SaasName a, SaasName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SaasName a, SaasName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Tenant</c> resource.</summary>
    public sealed partial class TenantName : gax::IResourceName, sys::IEquatable<TenantName>
    {
        /// <summary>The possible contents of <see cref="TenantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tenants/{tenant}</c>.
            /// </summary>
            ProjectLocationTenant = 1,
        }

        private static gax::PathTemplate s_projectLocationTenant = new gax::PathTemplate("projects/{project}/locations/{location}/tenants/{tenant}");

        /// <summary>Creates a <see cref="TenantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TenantName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TenantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TenantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TenantName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tenants/{tenant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TenantName"/> constructed from the provided ids.</returns>
        public static TenantName FromProjectLocationTenant(string projectId, string locationId, string tenantId) =>
            new TenantName(ResourceNameType.ProjectLocationTenant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tenants/{tenant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tenants/{tenant}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tenantId) =>
            FormatProjectLocationTenant(projectId, locationId, tenantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tenants/{tenant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tenants/{tenant}</c>.
        /// </returns>
        public static string FormatProjectLocationTenant(string projectId, string locationId, string tenantId) =>
            s_projectLocationTenant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)));

        /// <summary>Parses the given resource name string into a new <see cref="TenantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/tenants/{tenant}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tenantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TenantName"/> if successful.</returns>
        public static TenantName Parse(string tenantName) => Parse(tenantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TenantName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/tenants/{tenant}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tenantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TenantName"/> if successful.</returns>
        public static TenantName Parse(string tenantName, bool allowUnparsed) =>
            TryParse(tenantName, allowUnparsed, out TenantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TenantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/tenants/{tenant}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tenantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TenantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tenantName, out TenantName result) => TryParse(tenantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TenantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/tenants/{tenant}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tenantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TenantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tenantName, bool allowUnparsed, out TenantName result)
        {
            gax::GaxPreconditions.CheckNotNull(tenantName, nameof(tenantName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTenant.TryParseName(tenantName, out resourceName))
            {
                result = FromProjectLocationTenant(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tenantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TenantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tenantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TenantName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tenants/{tenant}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        public TenantName(string projectId, string locationId, string tenantId) : this(ResourceNameType.ProjectLocationTenant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)))
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
        /// The <c>Tenant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TenantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTenant: return s_projectLocationTenant.Expand(ProjectId, LocationId, TenantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TenantName);

        /// <inheritdoc/>
        public bool Equals(TenantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TenantName a, TenantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TenantName a, TenantName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UnitKind</c> resource.</summary>
    public sealed partial class UnitKindName : gax::IResourceName, sys::IEquatable<UnitKindName>
    {
        /// <summary>The possible contents of <see cref="UnitKindName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>.
            /// </summary>
            ProjectLocationUnitKind = 1,
        }

        private static gax::PathTemplate s_projectLocationUnitKind = new gax::PathTemplate("projects/{project}/locations/{location}/unitKinds/{unitKind}");

        /// <summary>Creates a <see cref="UnitKindName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UnitKindName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static UnitKindName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UnitKindName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UnitKindName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitKindId">The <c>UnitKind</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UnitKindName"/> constructed from the provided ids.</returns>
        public static UnitKindName FromProjectLocationUnitKind(string projectId, string locationId, string unitKindId) =>
            new UnitKindName(ResourceNameType.ProjectLocationUnitKind, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), unitKindId: gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnitKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitKindId">The <c>UnitKind</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnitKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string unitKindId) =>
            FormatProjectLocationUnitKind(projectId, locationId, unitKindId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnitKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitKindId">The <c>UnitKind</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnitKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>.
        /// </returns>
        public static string FormatProjectLocationUnitKind(string projectId, string locationId, string unitKindId) =>
            s_projectLocationUnitKind.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)));

        /// <summary>Parses the given resource name string into a new <see cref="UnitKindName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="unitKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UnitKindName"/> if successful.</returns>
        public static UnitKindName Parse(string unitKindName) => Parse(unitKindName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UnitKindName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unitKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UnitKindName"/> if successful.</returns>
        public static UnitKindName Parse(string unitKindName, bool allowUnparsed) =>
            TryParse(unitKindName, allowUnparsed, out UnitKindName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnitKindName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="unitKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnitKindName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unitKindName, out UnitKindName result) => TryParse(unitKindName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnitKindName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unitKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnitKindName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unitKindName, bool allowUnparsed, out UnitKindName result)
        {
            gax::GaxPreconditions.CheckNotNull(unitKindName, nameof(unitKindName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationUnitKind.TryParseName(unitKindName, out resourceName))
            {
                result = FromProjectLocationUnitKind(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(unitKindName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UnitKindName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string unitKindId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            UnitKindId = unitKindId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UnitKindName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/unitKinds/{unitKind}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitKindId">The <c>UnitKind</c> ID. Must not be <c>null</c> or empty.</param>
        public UnitKindName(string projectId, string locationId, string unitKindId) : this(ResourceNameType.ProjectLocationUnitKind, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), unitKindId: gax::GaxPreconditions.CheckNotNullOrEmpty(unitKindId, nameof(unitKindId)))
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
        /// The <c>UnitKind</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UnitKindId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationUnitKind: return s_projectLocationUnitKind.Expand(ProjectId, LocationId, UnitKindId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UnitKindName);

        /// <inheritdoc/>
        public bool Equals(UnitKindName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UnitKindName a, UnitKindName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UnitKindName a, UnitKindName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Unit</c> resource.</summary>
    public sealed partial class UnitName : gax::IResourceName, sys::IEquatable<UnitName>
    {
        /// <summary>The possible contents of <see cref="UnitName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/units/{unit}</c>.
            /// </summary>
            ProjectLocationUnit = 1,
        }

        private static gax::PathTemplate s_projectLocationUnit = new gax::PathTemplate("projects/{project}/locations/{location}/units/{unit}");

        /// <summary>Creates a <see cref="UnitName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UnitName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UnitName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UnitName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UnitName"/> with the pattern <c>projects/{project}/locations/{location}/units/{unit}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitId">The <c>Unit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UnitName"/> constructed from the provided ids.</returns>
        public static UnitName FromProjectLocationUnit(string projectId, string locationId, string unitId) =>
            new UnitName(ResourceNameType.ProjectLocationUnit, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), unitId: gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnitName"/> with pattern
        /// <c>projects/{project}/locations/{location}/units/{unit}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitId">The <c>Unit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnitName"/> with pattern
        /// <c>projects/{project}/locations/{location}/units/{unit}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string unitId) =>
            FormatProjectLocationUnit(projectId, locationId, unitId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnitName"/> with pattern
        /// <c>projects/{project}/locations/{location}/units/{unit}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitId">The <c>Unit</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnitName"/> with pattern
        /// <c>projects/{project}/locations/{location}/units/{unit}</c>.
        /// </returns>
        public static string FormatProjectLocationUnit(string projectId, string locationId, string unitId) =>
            s_projectLocationUnit.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)));

        /// <summary>Parses the given resource name string into a new <see cref="UnitName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/units/{unit}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="unitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UnitName"/> if successful.</returns>
        public static UnitName Parse(string unitName) => Parse(unitName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UnitName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/units/{unit}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UnitName"/> if successful.</returns>
        public static UnitName Parse(string unitName, bool allowUnparsed) =>
            TryParse(unitName, allowUnparsed, out UnitName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="UnitName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/units/{unit}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="unitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnitName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unitName, out UnitName result) => TryParse(unitName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnitName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/units/{unit}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unitName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnitName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unitName, bool allowUnparsed, out UnitName result)
        {
            gax::GaxPreconditions.CheckNotNull(unitName, nameof(unitName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationUnit.TryParseName(unitName, out resourceName))
            {
                result = FromProjectLocationUnit(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(unitName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UnitName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string unitId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            UnitId = unitId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UnitName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/units/{unit}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitId">The <c>Unit</c> ID. Must not be <c>null</c> or empty.</param>
        public UnitName(string projectId, string locationId, string unitId) : this(ResourceNameType.ProjectLocationUnit, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), unitId: gax::GaxPreconditions.CheckNotNullOrEmpty(unitId, nameof(unitId)))
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
        /// The <c>Unit</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UnitId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationUnit: return s_projectLocationUnit.Expand(ProjectId, LocationId, UnitId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UnitName);

        /// <inheritdoc/>
        public bool Equals(UnitName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UnitName a, UnitName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UnitName a, UnitName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UnitOperation</c> resource.</summary>
    public sealed partial class UnitOperationName : gax::IResourceName, sys::IEquatable<UnitOperationName>
    {
        /// <summary>The possible contents of <see cref="UnitOperationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>
            /// .
            /// </summary>
            ProjectLocationUnitOperation = 1,
        }

        private static gax::PathTemplate s_projectLocationUnitOperation = new gax::PathTemplate("projects/{project}/locations/{location}/unitOperations/{unitOperation}");

        /// <summary>Creates a <see cref="UnitOperationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UnitOperationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UnitOperationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UnitOperationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UnitOperationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitOperationId">The <c>UnitOperation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UnitOperationName"/> constructed from the provided ids.</returns>
        public static UnitOperationName FromProjectLocationUnitOperation(string projectId, string locationId, string unitOperationId) =>
            new UnitOperationName(ResourceNameType.ProjectLocationUnitOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), unitOperationId: gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnitOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitOperationId">The <c>UnitOperation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnitOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string unitOperationId) =>
            FormatProjectLocationUnitOperation(projectId, locationId, unitOperationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UnitOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitOperationId">The <c>UnitOperation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UnitOperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>.
        /// </returns>
        public static string FormatProjectLocationUnitOperation(string projectId, string locationId, string unitOperationId) =>
            s_projectLocationUnitOperation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UnitOperationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="unitOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UnitOperationName"/> if successful.</returns>
        public static UnitOperationName Parse(string unitOperationName) => Parse(unitOperationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UnitOperationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unitOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UnitOperationName"/> if successful.</returns>
        public static UnitOperationName Parse(string unitOperationName, bool allowUnparsed) =>
            TryParse(unitOperationName, allowUnparsed, out UnitOperationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnitOperationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="unitOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnitOperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unitOperationName, out UnitOperationName result) =>
            TryParse(unitOperationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UnitOperationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="unitOperationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UnitOperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string unitOperationName, bool allowUnparsed, out UnitOperationName result)
        {
            gax::GaxPreconditions.CheckNotNull(unitOperationName, nameof(unitOperationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationUnitOperation.TryParseName(unitOperationName, out resourceName))
            {
                result = FromProjectLocationUnitOperation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(unitOperationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UnitOperationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string unitOperationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            UnitOperationId = unitOperationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UnitOperationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/unitOperations/{unitOperation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unitOperationId">The <c>UnitOperation</c> ID. Must not be <c>null</c> or empty.</param>
        public UnitOperationName(string projectId, string locationId, string unitOperationId) : this(ResourceNameType.ProjectLocationUnitOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), unitOperationId: gax::GaxPreconditions.CheckNotNullOrEmpty(unitOperationId, nameof(unitOperationId)))
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
        /// The <c>UnitOperation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string UnitOperationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationUnitOperation: return s_projectLocationUnitOperation.Expand(ProjectId, LocationId, UnitOperationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UnitOperationName);

        /// <inheritdoc/>
        public bool Equals(UnitOperationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UnitOperationName a, UnitOperationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UnitOperationName a, UnitOperationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Release</c> resource.</summary>
    public sealed partial class ReleaseName : gax::IResourceName, sys::IEquatable<ReleaseName>
    {
        /// <summary>The possible contents of <see cref="ReleaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/releases/{release}</c>.
            /// </summary>
            ProjectLocationRelease = 1,
        }

        private static gax::PathTemplate s_projectLocationRelease = new gax::PathTemplate("projects/{project}/locations/{location}/releases/{release}");

        /// <summary>Creates a <see cref="ReleaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReleaseName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReleaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReleaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReleaseName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReleaseName"/> constructed from the provided ids.</returns>
        public static ReleaseName FromProjectLocationRelease(string projectId, string locationId, string releaseId) =>
            new ReleaseName(ResourceNameType.ProjectLocationRelease, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/releases/{release}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string releaseId) =>
            FormatProjectLocationRelease(projectId, locationId, releaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/releases/{release}</c>.
        /// </returns>
        public static string FormatProjectLocationRelease(string projectId, string locationId, string releaseId) =>
            s_projectLocationRelease.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReleaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/releases/{release}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReleaseName"/> if successful.</returns>
        public static ReleaseName Parse(string releaseName) => Parse(releaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReleaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/releases/{release}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReleaseName"/> if successful.</returns>
        public static ReleaseName Parse(string releaseName, bool allowUnparsed) =>
            TryParse(releaseName, allowUnparsed, out ReleaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/releases/{release}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseName, out ReleaseName result) => TryParse(releaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/releases/{release}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseName, bool allowUnparsed, out ReleaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(releaseName, nameof(releaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRelease.TryParseName(releaseName, out resourceName))
            {
                result = FromProjectLocationRelease(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(releaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReleaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string releaseId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseId = releaseId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReleaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/releases/{release}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        public ReleaseName(string projectId, string locationId, string releaseId) : this(ResourceNameType.ProjectLocationRelease, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)))
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
        /// The <c>Release</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReleaseId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRelease: return s_projectLocationRelease.Expand(ProjectId, LocationId, ReleaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReleaseName);

        /// <inheritdoc/>
        public bool Equals(ReleaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReleaseName a, ReleaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReleaseName a, ReleaseName b) => !(a == b);
    }

    public partial class Saas
    {
        /// <summary>
        /// <see cref="gcssv::SaasName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::SaasName SaasName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::SaasName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Tenant
    {
        /// <summary>
        /// <see cref="gcssv::TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::TenantName TenantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::TenantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SaasName"/>-typed view over the <see cref="Saas"/> resource name property.</summary>
        public SaasName SaasAsSaasName
        {
            get => string.IsNullOrEmpty(Saas) ? null : SaasName.Parse(Saas, allowUnparsed: true);
            set => Saas = value?.ToString() ?? "";
        }
    }

    public partial class UnitKind
    {
        /// <summary>
        /// <see cref="gcssv::UnitKindName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitKindName UnitKindName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitKindName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="DefaultRelease"/> resource name property.
        /// </summary>
        public ReleaseName DefaultReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(DefaultRelease) ? null : ReleaseName.Parse(DefaultRelease, allowUnparsed: true);
            set => DefaultRelease = value?.ToString() ?? "";
        }

        /// <summary><see cref="SaasName"/>-typed view over the <see cref="Saas"/> resource name property.</summary>
        public SaasName SaasAsSaasName
        {
            get => string.IsNullOrEmpty(Saas) ? null : SaasName.Parse(Saas, allowUnparsed: true);
            set => Saas = value?.ToString() ?? "";
        }
    }

    public partial class Unit
    {
        /// <summary>
        /// <see cref="gcssv::UnitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitName UnitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UnitKindName"/>-typed view over the <see cref="UnitKind"/> resource name property.
        /// </summary>
        public UnitKindName UnitKindAsUnitKindName
        {
            get => string.IsNullOrEmpty(UnitKind) ? null : UnitKindName.Parse(UnitKind, allowUnparsed: true);
            set => UnitKind = value?.ToString() ?? "";
        }

        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Tenant"/> resource name property.</summary>
        public TenantName TenantAsTenantName
        {
            get => string.IsNullOrEmpty(Tenant) ? null : TenantName.Parse(Tenant, allowUnparsed: true);
            set => Tenant = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UnitOperationName"/>-typed view over the <see cref="OngoingOperations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UnitOperationName> OngoingOperationsAsUnitOperationNames
        {
            get => new gax::ResourceNameList<UnitOperationName>(OngoingOperations, s => string.IsNullOrEmpty(s) ? null : UnitOperationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="UnitOperationName"/>-typed view over the <see cref="PendingOperations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<UnitOperationName> PendingOperationsAsUnitOperationNames
        {
            get => new gax::ResourceNameList<UnitOperationName>(PendingOperations, s => string.IsNullOrEmpty(s) ? null : UnitOperationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Release"/> resource name property.
        /// </summary>
        public ReleaseName ReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(Release) ? null : ReleaseName.Parse(Release, allowUnparsed: true);
            set => Release = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UnitOperationName"/>-typed view over the <see cref="ScheduledOperations"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<UnitOperationName> ScheduledOperationsAsUnitOperationNames
        {
            get => new gax::ResourceNameList<UnitOperationName>(ScheduledOperations, s => string.IsNullOrEmpty(s) ? null : UnitOperationName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class UnitDependency
    {
        /// <summary><see cref="UnitName"/>-typed view over the <see cref="Unit"/> resource name property.</summary>
        public UnitName UnitAsUnitName
        {
            get => string.IsNullOrEmpty(Unit) ? null : UnitName.Parse(Unit, allowUnparsed: true);
            set => Unit = value?.ToString() ?? "";
        }
    }

    public partial class UnitOperation
    {
        /// <summary>
        /// <see cref="gcssv::UnitOperationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitOperationName UnitOperationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitOperationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="UnitName"/>-typed view over the <see cref="Unit"/> resource name property.</summary>
        public UnitName UnitAsUnitName
        {
            get => string.IsNullOrEmpty(Unit) ? null : UnitName.Parse(Unit, allowUnparsed: true);
            set => Unit = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcssv::UnitOperationName"/>-typed view over the <see cref="ParentUnitOperation"/> resource name
        /// property.
        /// </summary>
        public gcssv::UnitOperationName ParentUnitOperationAsUnitOperationName
        {
            get => string.IsNullOrEmpty(ParentUnitOperation) ? null : gcssv::UnitOperationName.Parse(ParentUnitOperation, allowUnparsed: true);
            set => ParentUnitOperation = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RolloutName"/>-typed view over the <see cref="Rollout"/> resource name property.
        /// </summary>
        public RolloutName RolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(Rollout) ? null : RolloutName.Parse(Rollout, allowUnparsed: true);
            set => Rollout = value?.ToString() ?? "";
        }
    }

    public partial class Provision
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Release"/> resource name property.
        /// </summary>
        public ReleaseName ReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(Release) ? null : ReleaseName.Parse(Release, allowUnparsed: true);
            set => Release = value?.ToString() ?? "";
        }
    }

    public partial class Upgrade
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Release"/> resource name property.
        /// </summary>
        public ReleaseName ReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(Release) ? null : ReleaseName.Parse(Release, allowUnparsed: true);
            set => Release = value?.ToString() ?? "";
        }
    }

    public partial class Release
    {
        /// <summary>
        /// <see cref="gcssv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UnitKindName"/>-typed view over the <see cref="UnitKind"/> resource name property.
        /// </summary>
        public UnitKindName UnitKindAsUnitKindName
        {
            get => string.IsNullOrEmpty(UnitKind) ? null : UnitKindName.Parse(UnitKind, allowUnparsed: true);
            set => UnitKind = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ReleaseRequirements
            {
                /// <summary>
                /// <see cref="gcssv::ReleaseName"/>-typed view over the <see cref="UpgradeableFromReleases"/> resource
                /// name property.
                /// </summary>
                public gax::ResourceNameList<gcssv::ReleaseName> UpgradeableFromReleasesAsReleaseNames
                {
                    get => new gax::ResourceNameList<gcssv::ReleaseName>(UpgradeableFromReleases, s => string.IsNullOrEmpty(s) ? null : gcssv::ReleaseName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class Dependency
    {
        /// <summary>
        /// <see cref="UnitKindName"/>-typed view over the <see cref="UnitKind"/> resource name property.
        /// </summary>
        public UnitKindName UnitKindAsUnitKindName
        {
            get => string.IsNullOrEmpty(UnitKind) ? null : UnitKindName.Parse(UnitKind, allowUnparsed: true);
            set => UnitKind = value?.ToString() ?? "";
        }
    }
}
