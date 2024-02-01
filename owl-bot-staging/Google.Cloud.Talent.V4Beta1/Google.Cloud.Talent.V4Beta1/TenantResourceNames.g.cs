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
using gctv = Google.Cloud.Talent.V4Beta1;
using sys = System;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Resource name for the <c>Tenant</c> resource.</summary>
    public sealed partial class TenantName : gax::IResourceName, sys::IEquatable<TenantName>
    {
        /// <summary>The possible contents of <see cref="TenantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/tenants/{tenant}</c>.</summary>
            ProjectTenant = 1,
        }

        private static gax::PathTemplate s_projectTenant = new gax::PathTemplate("projects/{project}/tenants/{tenant}");

        /// <summary>Creates a <see cref="TenantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TenantName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TenantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TenantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TenantName"/> with the pattern <c>projects/{project}/tenants/{tenant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TenantName"/> constructed from the provided ids.</returns>
        public static TenantName FromProjectTenant(string projectId, string tenantId) =>
            new TenantName(ResourceNameType.ProjectTenant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}</c>.
        /// </returns>
        public static string Format(string projectId, string tenantId) => FormatProjectTenant(projectId, tenantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TenantName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}</c>.
        /// </returns>
        public static string FormatProjectTenant(string projectId, string tenantId) =>
            s_projectTenant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)));

        /// <summary>Parses the given resource name string into a new <see cref="TenantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}</c></description></item>
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
        /// <item><description><c>projects/{project}/tenants/{tenant}</c></description></item>
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
        /// <item><description><c>projects/{project}/tenants/{tenant}</c></description></item>
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
        /// <item><description><c>projects/{project}/tenants/{tenant}</c></description></item>
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
            if (s_projectTenant.TryParseName(tenantName, out resourceName))
            {
                result = FromProjectTenant(resourceName[0], resourceName[1]);
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

        private TenantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string tenantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TenantName"/> class from the component parts of pattern
        /// <c>projects/{project}/tenants/{tenant}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        public TenantName(string projectId, string tenantId) : this(ResourceNameType.ProjectTenant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)))
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
                case ResourceNameType.ProjectTenant: return s_projectTenant.Expand(ProjectId, TenantId);
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

    public partial class Tenant
    {
        /// <summary>
        /// <see cref="gctv::TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::TenantName TenantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::TenantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
