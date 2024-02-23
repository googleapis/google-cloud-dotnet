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
using gcsv = Google.Cloud.SecurityCenter.V1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>Policy</c> resource.</summary>
    public sealed partial class PolicyName : gax::IResourceName, sys::IEquatable<PolicyName>
    {
        /// <summary>The possible contents of <see cref="PolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/policies/{constraint_name}</c>.
            /// </summary>
            OrganizationConstraintName = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/policies/{constraint_name}</c>.</summary>
            FolderConstraintName = 2,

            /// <summary>A resource name with pattern <c>projects/{project}/policies/{constraint_name}</c>.</summary>
            ProjectConstraintName = 3,
        }

        private static gax::PathTemplate s_organizationConstraintName = new gax::PathTemplate("organizations/{organization}/policies/{constraint_name}");

        private static gax::PathTemplate s_folderConstraintName = new gax::PathTemplate("folders/{folder}/policies/{constraint_name}");

        private static gax::PathTemplate s_projectConstraintName = new gax::PathTemplate("projects/{project}/policies/{constraint_name}");

        /// <summary>Creates a <see cref="PolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PolicyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PolicyName"/> with the pattern
        /// <c>organizations/{organization}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromOrganizationConstraintName(string organizationId, string constraintNameId) =>
            new PolicyName(ResourceNameType.OrganizationConstraintName, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), constraintNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)));

        /// <summary>
        /// Creates a <see cref="PolicyName"/> with the pattern <c>folders/{folder}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromFolderConstraintName(string folderId, string constraintNameId) =>
            new PolicyName(ResourceNameType.FolderConstraintName, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), constraintNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)));

        /// <summary>
        /// Creates a <see cref="PolicyName"/> with the pattern <c>projects/{project}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromProjectConstraintName(string projectId, string constraintNameId) =>
            new PolicyName(ResourceNameType.ProjectConstraintName, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), constraintNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>organizations/{organization}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>organizations/{organization}/policies/{constraint_name}</c>.
        /// </returns>
        public static string Format(string organizationId, string constraintNameId) =>
            FormatOrganizationConstraintName(organizationId, constraintNameId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>organizations/{organization}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>organizations/{organization}/policies/{constraint_name}</c>.
        /// </returns>
        public static string FormatOrganizationConstraintName(string organizationId, string constraintNameId) =>
            s_organizationConstraintName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>folders/{folder}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>folders/{folder}/policies/{constraint_name}</c>.
        /// </returns>
        public static string FormatFolderConstraintName(string folderId, string constraintNameId) =>
            s_folderConstraintName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policies/{constraint_name}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policies/{constraint_name}</c>.
        /// </returns>
        public static string FormatProjectConstraintName(string projectId, string constraintNameId) =>
            s_projectConstraintName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)));

        /// <summary>Parses the given resource name string into a new <see cref="PolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>projects/{project}/policies/{constraint_name}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PolicyName"/> if successful.</returns>
        public static PolicyName Parse(string policyName) => Parse(policyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>projects/{project}/policies/{constraint_name}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PolicyName"/> if successful.</returns>
        public static PolicyName Parse(string policyName, bool allowUnparsed) =>
            TryParse(policyName, allowUnparsed, out PolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>projects/{project}/policies/{constraint_name}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyName, out PolicyName result) => TryParse(policyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{constraint_name}</c></description></item>
        /// <item><description><c>projects/{project}/policies/{constraint_name}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyName, bool allowUnparsed, out PolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(policyName, nameof(policyName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationConstraintName.TryParseName(policyName, out resourceName))
            {
                result = FromOrganizationConstraintName(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderConstraintName.TryParseName(policyName, out resourceName))
            {
                result = FromFolderConstraintName(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectConstraintName.TryParseName(policyName, out resourceName))
            {
                result = FromProjectConstraintName(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(policyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string constraintNameId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConstraintNameId = constraintNameId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PolicyName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/policies/{constraint_name}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintNameId">The <c>ConstraintName</c> ID. Must not be <c>null</c> or empty.</param>
        public PolicyName(string organizationId, string constraintNameId) : this(ResourceNameType.OrganizationConstraintName, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), constraintNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintNameId, nameof(constraintNameId)))
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
        /// The <c>ConstraintName</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConstraintNameId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

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
                case ResourceNameType.OrganizationConstraintName: return s_organizationConstraintName.Expand(OrganizationId, ConstraintNameId);
                case ResourceNameType.FolderConstraintName: return s_folderConstraintName.Expand(FolderId, ConstraintNameId);
                case ResourceNameType.ProjectConstraintName: return s_projectConstraintName.Expand(ProjectId, ConstraintNameId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PolicyName);

        /// <inheritdoc/>
        public bool Equals(PolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PolicyName a, PolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PolicyName a, PolicyName b) => !(a == b);
    }

    public partial class OrgPolicy
    {
        /// <summary>
        /// <see cref="gcsv::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
