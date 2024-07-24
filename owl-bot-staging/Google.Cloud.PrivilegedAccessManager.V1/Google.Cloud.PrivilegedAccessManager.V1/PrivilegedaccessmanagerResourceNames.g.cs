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
using gcpv = Google.Cloud.PrivilegedAccessManager.V1;
using sys = System;

namespace Google.Cloud.PrivilegedAccessManager.V1
{
    /// <summary>Resource name for the <c>Entitlement</c> resource.</summary>
    public sealed partial class EntitlementName : gax::IResourceName, sys::IEquatable<EntitlementName>
    {
        /// <summary>The possible contents of <see cref="EntitlementName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
            /// </summary>
            ProjectLocationEntitlement = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c>.
            /// </summary>
            FolderLocationEntitlement = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>.
            /// </summary>
            OrganizationLocationEntitlement = 3,
        }

        private static gax::PathTemplate s_projectLocationEntitlement = new gax::PathTemplate("projects/{project}/locations/{location}/entitlements/{entitlement}");

        private static gax::PathTemplate s_folderLocationEntitlement = new gax::PathTemplate("folders/{folder}/locations/{location}/entitlements/{entitlement}");

        private static gax::PathTemplate s_organizationLocationEntitlement = new gax::PathTemplate("organizations/{organization}/locations/{location}/entitlements/{entitlement}");

        /// <summary>Creates a <see cref="EntitlementName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntitlementName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntitlementName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntitlementName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntitlementName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntitlementName"/> constructed from the provided ids.</returns>
        public static EntitlementName FromProjectLocationEntitlement(string projectId, string locationId, string entitlementId) =>
            new EntitlementName(ResourceNameType.ProjectLocationEntitlement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>
        /// Creates a <see cref="EntitlementName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntitlementName"/> constructed from the provided ids.</returns>
        public static EntitlementName FromFolderLocationEntitlement(string folderId, string locationId, string entitlementId) =>
            new EntitlementName(ResourceNameType.FolderLocationEntitlement, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>
        /// Creates a <see cref="EntitlementName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntitlementName"/> constructed from the provided ids.</returns>
        public static EntitlementName FromOrganizationLocationEntitlement(string organizationId, string locationId, string entitlementId) =>
            new EntitlementName(ResourceNameType.OrganizationLocationEntitlement, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entitlementId) =>
            FormatProjectLocationEntitlement(projectId, locationId, entitlementId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>.
        /// </returns>
        public static string FormatProjectLocationEntitlement(string projectId, string locationId, string entitlementId) =>
            s_projectLocationEntitlement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c>.
        /// </returns>
        public static string FormatFolderLocationEntitlement(string folderId, string locationId, string entitlementId) =>
            s_folderLocationEntitlement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntitlementName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>.
        /// </returns>
        public static string FormatOrganizationLocationEntitlement(string organizationId, string locationId, string entitlementId) =>
            s_organizationLocationEntitlement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntitlementName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntitlementName"/> if successful.</returns>
        public static EntitlementName Parse(string entitlementName) => Parse(entitlementName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntitlementName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntitlementName"/> if successful.</returns>
        public static EntitlementName Parse(string entitlementName, bool allowUnparsed) =>
            TryParse(entitlementName, allowUnparsed, out EntitlementName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntitlementName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntitlementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entitlementName, out EntitlementName result) =>
            TryParse(entitlementName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntitlementName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/entitlements/{entitlement}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entitlementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntitlementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entitlementName, bool allowUnparsed, out EntitlementName result)
        {
            gax::GaxPreconditions.CheckNotNull(entitlementName, nameof(entitlementName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntitlement.TryParseName(entitlementName, out resourceName))
            {
                result = FromProjectLocationEntitlement(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationEntitlement.TryParseName(entitlementName, out resourceName))
            {
                result = FromFolderLocationEntitlement(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationEntitlement.TryParseName(entitlementName, out resourceName))
            {
                result = FromOrganizationLocationEntitlement(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entitlementName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntitlementName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entitlementId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntitlementId = entitlementId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntitlementName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        public EntitlementName(string projectId, string locationId, string entitlementId) : this(ResourceNameType.ProjectLocationEntitlement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)))
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
        /// The <c>Entitlement</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EntitlementId { get; }

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
                case ResourceNameType.ProjectLocationEntitlement: return s_projectLocationEntitlement.Expand(ProjectId, LocationId, EntitlementId);
                case ResourceNameType.FolderLocationEntitlement: return s_folderLocationEntitlement.Expand(FolderId, LocationId, EntitlementId);
                case ResourceNameType.OrganizationLocationEntitlement: return s_organizationLocationEntitlement.Expand(OrganizationId, LocationId, EntitlementId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntitlementName);

        /// <inheritdoc/>
        public bool Equals(EntitlementName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntitlementName a, EntitlementName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntitlementName a, EntitlementName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Grant</c> resource.</summary>
    public sealed partial class GrantName : gax::IResourceName, sys::IEquatable<GrantName>
    {
        /// <summary>The possible contents of <see cref="GrantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
            /// </summary>
            ProjectLocationEntitlementGrant = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
            /// </summary>
            FolderLocationEntitlementGrant = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
            /// </summary>
            OrganizationLocationEntitlementGrant = 3,
        }

        private static gax::PathTemplate s_projectLocationEntitlementGrant = new gax::PathTemplate("projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}");

        private static gax::PathTemplate s_folderLocationEntitlementGrant = new gax::PathTemplate("folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}");

        private static gax::PathTemplate s_organizationLocationEntitlementGrant = new gax::PathTemplate("organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}");

        /// <summary>Creates a <see cref="GrantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GrantName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GrantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GrantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GrantName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GrantName"/> constructed from the provided ids.</returns>
        public static GrantName FromProjectLocationEntitlementGrant(string projectId, string locationId, string entitlementId, string grantId) =>
            new GrantName(ResourceNameType.ProjectLocationEntitlementGrant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), grantId: gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)));

        /// <summary>
        /// Creates a <see cref="GrantName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GrantName"/> constructed from the provided ids.</returns>
        public static GrantName FromFolderLocationEntitlementGrant(string folderId, string locationId, string entitlementId, string grantId) =>
            new GrantName(ResourceNameType.FolderLocationEntitlementGrant, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), grantId: gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)));

        /// <summary>
        /// Creates a <see cref="GrantName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GrantName"/> constructed from the provided ids.</returns>
        public static GrantName FromOrganizationLocationEntitlementGrant(string organizationId, string locationId, string entitlementId, string grantId) =>
            new GrantName(ResourceNameType.OrganizationLocationEntitlementGrant, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), grantId: gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GrantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GrantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entitlementId, string grantId) =>
            FormatProjectLocationEntitlementGrant(projectId, locationId, entitlementId, grantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GrantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GrantName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </returns>
        public static string FormatProjectLocationEntitlementGrant(string projectId, string locationId, string entitlementId, string grantId) =>
            s_projectLocationEntitlementGrant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GrantName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GrantName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </returns>
        public static string FormatFolderLocationEntitlementGrant(string folderId, string locationId, string entitlementId, string grantId) =>
            s_folderLocationEntitlementGrant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GrantName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GrantName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>.
        /// </returns>
        public static string FormatOrganizationLocationEntitlementGrant(string organizationId, string locationId, string entitlementId, string grantId) =>
            s_organizationLocationEntitlementGrant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)));

        /// <summary>Parses the given resource name string into a new <see cref="GrantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="grantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GrantName"/> if successful.</returns>
        public static GrantName Parse(string grantName) => Parse(grantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GrantName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="grantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GrantName"/> if successful.</returns>
        public static GrantName Parse(string grantName, bool allowUnparsed) =>
            TryParse(grantName, allowUnparsed, out GrantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GrantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="grantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GrantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string grantName, out GrantName result) => TryParse(grantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GrantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="grantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GrantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string grantName, bool allowUnparsed, out GrantName result)
        {
            gax::GaxPreconditions.CheckNotNull(grantName, nameof(grantName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntitlementGrant.TryParseName(grantName, out resourceName))
            {
                result = FromProjectLocationEntitlementGrant(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationEntitlementGrant.TryParseName(grantName, out resourceName))
            {
                result = FromFolderLocationEntitlementGrant(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationEntitlementGrant.TryParseName(grantName, out resourceName))
            {
                result = FromOrganizationLocationEntitlementGrant(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(grantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GrantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entitlementId = null, string folderId = null, string grantId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntitlementId = entitlementId;
            FolderId = folderId;
            GrantId = grantId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GrantName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entitlements/{entitlement}/grants/{grant}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entitlementId">The <c>Entitlement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="grantId">The <c>Grant</c> ID. Must not be <c>null</c> or empty.</param>
        public GrantName(string projectId, string locationId, string entitlementId, string grantId) : this(ResourceNameType.ProjectLocationEntitlementGrant, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entitlementId: gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)), grantId: gax::GaxPreconditions.CheckNotNullOrEmpty(grantId, nameof(grantId)))
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
        /// The <c>Entitlement</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EntitlementId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Grant</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string GrantId { get; }

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
                case ResourceNameType.ProjectLocationEntitlementGrant: return s_projectLocationEntitlementGrant.Expand(ProjectId, LocationId, EntitlementId, GrantId);
                case ResourceNameType.FolderLocationEntitlementGrant: return s_folderLocationEntitlementGrant.Expand(FolderId, LocationId, EntitlementId, GrantId);
                case ResourceNameType.OrganizationLocationEntitlementGrant: return s_organizationLocationEntitlementGrant.Expand(OrganizationId, LocationId, EntitlementId, GrantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GrantName);

        /// <inheritdoc/>
        public bool Equals(GrantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GrantName a, GrantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GrantName a, GrantName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationLocation</c> resource.</summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}</c>.
            /// </summary>
            OrganizationLocation = 1,
        }

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>Creates a <see cref="OrganizationLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationLocationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationLocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new OrganizationLocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName) =>
            Parse(organizationLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName, bool allowUnparsed) =>
            TryParse(organizationLocationName, allowUnparsed, out OrganizationLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result) =>
            TryParse(organizationLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, bool allowUnparsed, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(organizationLocationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationLocationName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationLocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FolderLocation</c> resource.</summary>
    public sealed partial class FolderLocationName : gax::IResourceName, sys::IEquatable<FolderLocationName>
    {
        /// <summary>The possible contents of <see cref="FolderLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}</c>.</summary>
            FolderLocation = 1,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}");

        /// <summary>Creates a <see cref="FolderLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FolderLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FolderLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FolderLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FolderLocationName"/> with the pattern <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FolderLocationName"/> constructed from the provided ids.</returns>
        public static FolderLocationName FromFolderLocation(string folderId, string locationId) =>
            new FolderLocationName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName) => Parse(folderLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName, bool allowUnparsed) =>
            TryParse(folderLocationName, allowUnparsed, out FolderLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, out FolderLocationName result) =>
            TryParse(folderLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, bool allowUnparsed, out FolderLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(folderLocationName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(folderLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FolderLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FolderLocationName"/> class from the component parts of pattern
        /// <c>folders/{folder}/locations/{location}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public FolderLocationName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FolderLocationName);

        /// <inheritdoc/>
        public bool Equals(FolderLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FolderLocationName a, FolderLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FolderLocationName a, FolderLocationName b) => !(a == b);
    }

    public partial class CheckOnboardingStatusRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Entitlement
    {
        /// <summary>
        /// <see cref="gcpv::EntitlementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::EntitlementName EntitlementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::EntitlementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntitlementsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SearchEntitlementsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEntitlementRequest
    {
        /// <summary>
        /// <see cref="gcpv::EntitlementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::EntitlementName EntitlementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::EntitlementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntitlementRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEntitlementRequest
    {
        /// <summary>
        /// <see cref="gcpv::EntitlementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::EntitlementName EntitlementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::EntitlementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Grant
    {
        /// <summary>
        /// <see cref="gcpv::GrantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::GrantName GrantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::GrantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGrantsRequest
    {
        /// <summary>
        /// <see cref="EntitlementName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntitlementName ParentAsEntitlementName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntitlementName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SearchGrantsRequest
    {
        /// <summary>
        /// <see cref="EntitlementName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntitlementName ParentAsEntitlementName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntitlementName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGrantRequest
    {
        /// <summary>
        /// <see cref="gcpv::GrantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::GrantName GrantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::GrantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApproveGrantRequest
    {
        /// <summary>
        /// <see cref="gcpv::GrantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::GrantName GrantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::GrantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DenyGrantRequest
    {
        /// <summary>
        /// <see cref="gcpv::GrantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::GrantName GrantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::GrantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RevokeGrantRequest
    {
        /// <summary>
        /// <see cref="gcpv::GrantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::GrantName GrantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::GrantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGrantRequest
    {
        /// <summary>
        /// <see cref="EntitlementName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntitlementName ParentAsEntitlementName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntitlementName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
