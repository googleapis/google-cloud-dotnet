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
using gctv = Google.Cloud.Talent.V4Beta1;
using sys = System;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Resource name for the <c>Profile</c> resource.</summary>
    public sealed partial class ProfileName : gax::IResourceName, sys::IEquatable<ProfileName>
    {
        /// <summary>The possible contents of <see cref="ProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>.
            /// </summary>
            ProjectTenantProfile = 1,
        }

        private static gax::PathTemplate s_projectTenantProfile = new gax::PathTemplate("projects/{project}/tenants/{tenant}/profiles/{profile}");

        /// <summary>Creates a <see cref="ProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProfileName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProfileName"/> with the pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProfileName"/> constructed from the provided ids.</returns>
        public static ProfileName FromProjectTenantProfile(string projectId, string tenantId, string profileId) =>
            new ProfileName(ResourceNameType.ProjectTenantProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), profileId: gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>.
        /// </returns>
        public static string Format(string projectId, string tenantId, string profileId) =>
            FormatProjectTenantProfile(projectId, tenantId, profileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProfileName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>.
        /// </returns>
        public static string FormatProjectTenantProfile(string projectId, string tenantId, string profileId) =>
            s_projectTenantProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProfileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/profiles/{profile}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName) => Parse(profileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProfileName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/profiles/{profile}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName, bool allowUnparsed) =>
            TryParse(profileName, allowUnparsed, out ProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/profiles/{profile}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, out ProfileName result) => TryParse(profileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/profiles/{profile}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="profileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, bool allowUnparsed, out ProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(profileName, nameof(profileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTenantProfile.TryParseName(profileName, out resourceName))
            {
                result = FromProjectTenantProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(profileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string profileId = null, string projectId = null, string tenantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProfileId = profileId;
            ProjectId = projectId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProfileName"/> class from the component parts of pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        public ProfileName(string projectId, string tenantId, string profileId) : this(ResourceNameType.ProjectTenantProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), profileId: gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)))
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
        /// The <c>Profile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProfileId { get; }

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
                case ResourceNameType.ProjectTenantProfile: return s_projectTenantProfile.Expand(ProjectId, TenantId, ProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProfileName);

        /// <inheritdoc/>
        public bool Equals(ProfileName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ProfileName a, ProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ProfileName a, ProfileName b) => !(a == b);
    }

    public partial class Profile
    {
        /// <summary>
        /// <see cref="gctv::ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::ProfileName ProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::ProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
