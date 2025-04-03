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
using gciv = Google.Cloud.Iam.V3Beta;
using sys = System;

namespace Google.Cloud.Iam.V3Beta
{
    /// <summary>Resource name for the <c>PolicyBinding</c> resource.</summary>
    public sealed partial class PolicyBindingName : gax::IResourceName, sys::IEquatable<PolicyBindingName>
    {
        /// <summary>The possible contents of <see cref="PolicyBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>.
            /// </summary>
            OrganizationLocationPolicyBinding = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c>
            /// .
            /// </summary>
            FolderLocationPolicyBinding = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c>
            /// .
            /// </summary>
            ProjectLocationPolicyBinding = 3,
        }

        private static gax::PathTemplate s_organizationLocationPolicyBinding = new gax::PathTemplate("organizations/{organization}/locations/{location}/policyBindings/{policy_binding}");

        private static gax::PathTemplate s_folderLocationPolicyBinding = new gax::PathTemplate("folders/{folder}/locations/{location}/policyBindings/{policy_binding}");

        private static gax::PathTemplate s_projectLocationPolicyBinding = new gax::PathTemplate("projects/{project}/locations/{location}/policyBindings/{policy_binding}");

        /// <summary>Creates a <see cref="PolicyBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PolicyBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PolicyBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PolicyBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PolicyBindingName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyBindingName"/> constructed from the provided ids.</returns>
        public static PolicyBindingName FromOrganizationLocationPolicyBinding(string organizationId, string locationId, string policyBindingId) =>
            new PolicyBindingName(ResourceNameType.OrganizationLocationPolicyBinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), policyBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)));

        /// <summary>
        /// Creates a <see cref="PolicyBindingName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyBindingName"/> constructed from the provided ids.</returns>
        public static PolicyBindingName FromFolderLocationPolicyBinding(string folderId, string locationId, string policyBindingId) =>
            new PolicyBindingName(ResourceNameType.FolderLocationPolicyBinding, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), policyBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)));

        /// <summary>
        /// Creates a <see cref="PolicyBindingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyBindingName"/> constructed from the provided ids.</returns>
        public static PolicyBindingName FromProjectLocationPolicyBinding(string projectId, string locationId, string policyBindingId) =>
            new PolicyBindingName(ResourceNameType.ProjectLocationPolicyBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), policyBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string policyBindingId) =>
            FormatOrganizationLocationPolicyBinding(organizationId, locationId, policyBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </returns>
        public static string FormatOrganizationLocationPolicyBinding(string organizationId, string locationId, string policyBindingId) =>
            s_organizationLocationPolicyBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </returns>
        public static string FormatFolderLocationPolicyBinding(string folderId, string locationId, string policyBindingId) =>
            s_folderLocationPolicyBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c>.
        /// </returns>
        public static string FormatProjectLocationPolicyBinding(string projectId, string locationId, string policyBindingId) =>
            s_projectLocationPolicyBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="policyBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PolicyBindingName"/> if successful.</returns>
        public static PolicyBindingName Parse(string policyBindingName) => Parse(policyBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PolicyBindingName"/> if successful.</returns>
        public static PolicyBindingName Parse(string policyBindingName, bool allowUnparsed) =>
            TryParse(policyBindingName, allowUnparsed, out PolicyBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="policyBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyBindingName, out PolicyBindingName result) =>
            TryParse(policyBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/policyBindings/{policy_binding}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyBindingName, bool allowUnparsed, out PolicyBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(policyBindingName, nameof(policyBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationPolicyBinding.TryParseName(policyBindingName, out resourceName))
            {
                result = FromOrganizationLocationPolicyBinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationPolicyBinding.TryParseName(policyBindingName, out resourceName))
            {
                result = FromFolderLocationPolicyBinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationPolicyBinding.TryParseName(policyBindingName, out resourceName))
            {
                result = FromProjectLocationPolicyBinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(policyBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PolicyBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string policyBindingId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            PolicyBindingId = policyBindingId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PolicyBindingName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/policyBindings/{policy_binding}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBindingId">The <c>PolicyBinding</c> ID. Must not be <c>null</c> or empty.</param>
        public PolicyBindingName(string organizationId, string locationId, string policyBindingId) : this(ResourceNameType.OrganizationLocationPolicyBinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), policyBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyBindingId, nameof(policyBindingId)))
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
        /// The <c>PolicyBinding</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string PolicyBindingId { get; }

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
                case ResourceNameType.OrganizationLocationPolicyBinding: return s_organizationLocationPolicyBinding.Expand(OrganizationId, LocationId, PolicyBindingId);
                case ResourceNameType.FolderLocationPolicyBinding: return s_folderLocationPolicyBinding.Expand(FolderId, LocationId, PolicyBindingId);
                case ResourceNameType.ProjectLocationPolicyBinding: return s_projectLocationPolicyBinding.Expand(ProjectId, LocationId, PolicyBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PolicyBindingName);

        /// <inheritdoc/>
        public bool Equals(PolicyBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PolicyBindingName a, PolicyBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PolicyBindingName a, PolicyBindingName b) => !(a == b);
    }

    public partial class PolicyBinding
    {
        /// <summary>
        /// <see cref="gciv::PolicyBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::PolicyBindingName PolicyBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::PolicyBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
