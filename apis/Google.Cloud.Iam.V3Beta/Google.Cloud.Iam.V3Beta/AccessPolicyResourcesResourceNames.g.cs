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
using gax = Google.Api.Gax;
using gciv = Google.Cloud.Iam.V3Beta;
using sys = System;

namespace Google.Cloud.Iam.V3Beta
{
    /// <summary>Resource name for the <c>AccessPolicy</c> resource.</summary>
    public sealed partial class AccessPolicyName : gax::IResourceName, sys::IEquatable<AccessPolicyName>
    {
        /// <summary>The possible contents of <see cref="AccessPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>.
            /// </summary>
            OrganizationLocationAccessPolicy = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c>
            /// .
            /// </summary>
            FolderLocationAccessPolicy = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c>
            /// .
            /// </summary>
            ProjectLocationAccessPolicy = 3,
        }

        private static gax::PathTemplate s_organizationLocationAccessPolicy = new gax::PathTemplate("organizations/{organization}/locations/{location}/accessPolicies/{access_policy}");

        private static gax::PathTemplate s_folderLocationAccessPolicy = new gax::PathTemplate("folders/{folder}/locations/{location}/accessPolicies/{access_policy}");

        private static gax::PathTemplate s_projectLocationAccessPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/accessPolicies/{access_policy}");

        /// <summary>Creates a <see cref="AccessPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessPolicyName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccessPolicyName"/> constructed from the provided ids.</returns>
        public static AccessPolicyName FromOrganizationLocationAccessPolicy(string organizationId, string locationId, string accessPolicyId) =>
            new AccessPolicyName(ResourceNameType.OrganizationLocationAccessPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>
        /// Creates a <see cref="AccessPolicyName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccessPolicyName"/> constructed from the provided ids.</returns>
        public static AccessPolicyName FromFolderLocationAccessPolicy(string folderId, string locationId, string accessPolicyId) =>
            new AccessPolicyName(ResourceNameType.FolderLocationAccessPolicy, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>
        /// Creates a <see cref="AccessPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccessPolicyName"/> constructed from the provided ids.</returns>
        public static AccessPolicyName FromProjectLocationAccessPolicy(string projectId, string locationId, string accessPolicyId) =>
            new AccessPolicyName(ResourceNameType.ProjectLocationAccessPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string accessPolicyId) =>
            FormatOrganizationLocationAccessPolicy(organizationId, locationId, accessPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </returns>
        public static string FormatOrganizationLocationAccessPolicy(string organizationId, string locationId, string accessPolicyId) =>
            s_organizationLocationAccessPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </returns>
        public static string FormatFolderLocationAccessPolicy(string folderId, string locationId, string accessPolicyId) =>
            s_folderLocationAccessPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccessPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationAccessPolicy(string projectId, string locationId, string accessPolicyId) =>
            s_projectLocationAccessPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccessPolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccessPolicyName"/> if successful.</returns>
        public static AccessPolicyName Parse(string accessPolicyName) => Parse(accessPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessPolicyName"/> if successful.</returns>
        public static AccessPolicyName Parse(string accessPolicyName, bool allowUnparsed) =>
            TryParse(accessPolicyName, allowUnparsed, out AccessPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessPolicyName, out AccessPolicyName result) =>
            TryParse(accessPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/accessPolicies/{access_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessPolicyName, bool allowUnparsed, out AccessPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessPolicyName, nameof(accessPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationAccessPolicy.TryParseName(accessPolicyName, out resourceName))
            {
                result = FromOrganizationLocationAccessPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationAccessPolicy.TryParseName(accessPolicyName, out resourceName))
            {
                result = FromFolderLocationAccessPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationAccessPolicy.TryParseName(accessPolicyName, out resourceName))
            {
                result = FromProjectLocationAccessPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accessPolicyId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccessPolicyId = accessPolicyId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessPolicyName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/accessPolicies/{access_policy}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessPolicyId">The <c>AccessPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public AccessPolicyName(string organizationId, string locationId, string accessPolicyId) : this(ResourceNameType.OrganizationLocationAccessPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), accessPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessPolicyId, nameof(accessPolicyId)))
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
        /// The <c>AccessPolicy</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AccessPolicyId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

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
                case ResourceNameType.OrganizationLocationAccessPolicy: return s_organizationLocationAccessPolicy.Expand(OrganizationId, LocationId, AccessPolicyId);
                case ResourceNameType.FolderLocationAccessPolicy: return s_folderLocationAccessPolicy.Expand(FolderId, LocationId, AccessPolicyId);
                case ResourceNameType.ProjectLocationAccessPolicy: return s_projectLocationAccessPolicy.Expand(ProjectId, LocationId, AccessPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessPolicyName);

        /// <inheritdoc/>
        public bool Equals(AccessPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessPolicyName a, AccessPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessPolicyName a, AccessPolicyName b) => !(a == b);
    }

    public partial class AccessPolicy
    {
        /// <summary>
        /// <see cref="gciv::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
