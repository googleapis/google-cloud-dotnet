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
using gcov = Google.Cloud.OrgPolicy.V2;
using sys = System;

namespace Google.Cloud.OrgPolicy.V2
{
    /// <summary>Resource name for the <c>Policy</c> resource.</summary>
    public sealed partial class PolicyName : gax::IResourceName, sys::IEquatable<PolicyName>
    {
        /// <summary>The possible contents of <see cref="PolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/policies/{policy}</c>.</summary>
            ProjectPolicy = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/policies/{policy}</c>.</summary>
            FolderPolicy = 2,

            /// <summary>A resource name with pattern <c>organizations/{organization}/policies/{policy}</c>.</summary>
            OrganizationPolicy = 3,
        }

        private static gax::PathTemplate s_projectPolicy = new gax::PathTemplate("projects/{project}/policies/{policy}");

        private static gax::PathTemplate s_folderPolicy = new gax::PathTemplate("folders/{folder}/policies/{policy}");

        private static gax::PathTemplate s_organizationPolicy = new gax::PathTemplate("organizations/{organization}/policies/{policy}");

        /// <summary>Creates a <see cref="PolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PolicyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PolicyName"/> with the pattern <c>projects/{project}/policies/{policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromProjectPolicy(string projectId, string policyId) =>
            new PolicyName(ResourceNameType.ProjectPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), policyId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)));

        /// <summary>
        /// Creates a <see cref="PolicyName"/> with the pattern <c>folders/{folder}/policies/{policy}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromFolderPolicy(string folderId, string policyId) =>
            new PolicyName(ResourceNameType.FolderPolicy, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), policyId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)));

        /// <summary>
        /// Creates a <see cref="PolicyName"/> with the pattern <c>organizations/{organization}/policies/{policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyName"/> constructed from the provided ids.</returns>
        public static PolicyName FromOrganizationPolicy(string organizationId, string policyId) =>
            new PolicyName(ResourceNameType.OrganizationPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), policyId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policies/{policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policies/{policy}</c>.
        /// </returns>
        public static string Format(string projectId, string policyId) => FormatProjectPolicy(projectId, policyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policies/{policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>projects/{project}/policies/{policy}</c>.
        /// </returns>
        public static string FormatProjectPolicy(string projectId, string policyId) =>
            s_projectPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>folders/{folder}/policies/{policy}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>folders/{folder}/policies/{policy}</c>.
        /// </returns>
        public static string FormatFolderPolicy(string folderId, string policyId) =>
            s_folderPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyName"/> with pattern
        /// <c>organizations/{organization}/policies/{policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyName"/> with pattern
        /// <c>organizations/{organization}/policies/{policy}</c>.
        /// </returns>
        public static string FormatOrganizationPolicy(string organizationId, string policyId) =>
            s_organizationPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)));

        /// <summary>Parses the given resource name string into a new <see cref="PolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/policies/{policy}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/policies/{policy}</c></description></item>
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
        /// <item><description><c>projects/{project}/policies/{policy}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/policies/{policy}</c></description></item>
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
        /// <item><description><c>projects/{project}/policies/{policy}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/policies/{policy}</c></description></item>
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
        /// <item><description><c>projects/{project}/policies/{policy}</c></description></item>
        /// <item><description><c>folders/{folder}/policies/{policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/policies/{policy}</c></description></item>
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
            if (s_projectPolicy.TryParseName(policyName, out resourceName))
            {
                result = FromProjectPolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderPolicy.TryParseName(policyName, out resourceName))
            {
                result = FromFolderPolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationPolicy.TryParseName(policyName, out resourceName))
            {
                result = FromOrganizationPolicy(resourceName[0], resourceName[1]);
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

        private PolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string policyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            PolicyId = policyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/policies/{policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyId">The <c>Policy</c> ID. Must not be <c>null</c> or empty.</param>
        public PolicyName(string projectId, string policyId) : this(ResourceNameType.ProjectPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), policyId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)))
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
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Policy</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string PolicyId { get; }

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
                case ResourceNameType.ProjectPolicy: return s_projectPolicy.Expand(ProjectId, PolicyId);
                case ResourceNameType.FolderPolicy: return s_folderPolicy.Expand(FolderId, PolicyId);
                case ResourceNameType.OrganizationPolicy: return s_organizationPolicy.Expand(OrganizationId, PolicyId);
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

    public partial class Policy
    {
        /// <summary>
        /// <see cref="gcov::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConstraintsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListPoliciesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPolicyRequest
    {
        /// <summary>
        /// <see cref="gcov::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEffectivePolicyRequest
    {
        /// <summary>
        /// <see cref="gcov::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePolicyRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::FolderName ParentAsFolderName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::FolderName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePolicyRequest
    {
        /// <summary>
        /// <see cref="gcov::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCustomConstraintRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCustomConstraintRequest
    {
        /// <summary>
        /// <see cref="gcov::CustomConstraintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::CustomConstraintName CustomConstraintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::CustomConstraintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCustomConstraintsRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCustomConstraintRequest
    {
        /// <summary>
        /// <see cref="gcov::CustomConstraintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::CustomConstraintName CustomConstraintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::CustomConstraintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
