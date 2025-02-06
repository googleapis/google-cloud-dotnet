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
using gcov = Google.Cloud.OrgPolicy.V2;
using sys = System;

namespace Google.Cloud.OrgPolicy.V2
{
    /// <summary>Resource name for the <c>Constraint</c> resource.</summary>
    public sealed partial class ConstraintName : gax::IResourceName, sys::IEquatable<ConstraintName>
    {
        /// <summary>The possible contents of <see cref="ConstraintName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/constraints/{constraint}</c>.</summary>
            ProjectConstraint = 1,

            /// <summary>A resource name with pattern <c>folders/{folder}/constraints/{constraint}</c>.</summary>
            FolderConstraint = 2,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/constraints/{constraint}</c>.
            /// </summary>
            OrganizationConstraint = 3,
        }

        private static gax::PathTemplate s_projectConstraint = new gax::PathTemplate("projects/{project}/constraints/{constraint}");

        private static gax::PathTemplate s_folderConstraint = new gax::PathTemplate("folders/{folder}/constraints/{constraint}");

        private static gax::PathTemplate s_organizationConstraint = new gax::PathTemplate("organizations/{organization}/constraints/{constraint}");

        /// <summary>Creates a <see cref="ConstraintName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConstraintName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConstraintName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConstraintName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConstraintName"/> with the pattern <c>projects/{project}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConstraintName"/> constructed from the provided ids.</returns>
        public static ConstraintName FromProjectConstraint(string projectId, string constraintId) =>
            new ConstraintName(ResourceNameType.ProjectConstraint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), constraintId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)));

        /// <summary>
        /// Creates a <see cref="ConstraintName"/> with the pattern <c>folders/{folder}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConstraintName"/> constructed from the provided ids.</returns>
        public static ConstraintName FromFolderConstraint(string folderId, string constraintId) =>
            new ConstraintName(ResourceNameType.FolderConstraint, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), constraintId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)));

        /// <summary>
        /// Creates a <see cref="ConstraintName"/> with the pattern
        /// <c>organizations/{organization}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConstraintName"/> constructed from the provided ids.</returns>
        public static ConstraintName FromOrganizationConstraint(string organizationId, string constraintId) =>
            new ConstraintName(ResourceNameType.OrganizationConstraint, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), constraintId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>projects/{project}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>projects/{project}/constraints/{constraint}</c>.
        /// </returns>
        public static string Format(string projectId, string constraintId) => FormatProjectConstraint(projectId, constraintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>projects/{project}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>projects/{project}/constraints/{constraint}</c>.
        /// </returns>
        public static string FormatProjectConstraint(string projectId, string constraintId) =>
            s_projectConstraint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>folders/{folder}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>folders/{folder}/constraints/{constraint}</c>.
        /// </returns>
        public static string FormatFolderConstraint(string folderId, string constraintId) =>
            s_folderConstraint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>organizations/{organization}/constraints/{constraint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConstraintName"/> with pattern
        /// <c>organizations/{organization}/constraints/{constraint}</c>.
        /// </returns>
        public static string FormatOrganizationConstraint(string organizationId, string constraintId) =>
            s_organizationConstraint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConstraintName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/constraints/{constraint}</c></description></item>
        /// <item><description><c>folders/{folder}/constraints/{constraint}</c></description></item>
        /// <item><description><c>organizations/{organization}/constraints/{constraint}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="constraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConstraintName"/> if successful.</returns>
        public static ConstraintName Parse(string constraintName) => Parse(constraintName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConstraintName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/constraints/{constraint}</c></description></item>
        /// <item><description><c>folders/{folder}/constraints/{constraint}</c></description></item>
        /// <item><description><c>organizations/{organization}/constraints/{constraint}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="constraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConstraintName"/> if successful.</returns>
        public static ConstraintName Parse(string constraintName, bool allowUnparsed) =>
            TryParse(constraintName, allowUnparsed, out ConstraintName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConstraintName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/constraints/{constraint}</c></description></item>
        /// <item><description><c>folders/{folder}/constraints/{constraint}</c></description></item>
        /// <item><description><c>organizations/{organization}/constraints/{constraint}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="constraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConstraintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string constraintName, out ConstraintName result) =>
            TryParse(constraintName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConstraintName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/constraints/{constraint}</c></description></item>
        /// <item><description><c>folders/{folder}/constraints/{constraint}</c></description></item>
        /// <item><description><c>organizations/{organization}/constraints/{constraint}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="constraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConstraintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string constraintName, bool allowUnparsed, out ConstraintName result)
        {
            gax::GaxPreconditions.CheckNotNull(constraintName, nameof(constraintName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConstraint.TryParseName(constraintName, out resourceName))
            {
                result = FromProjectConstraint(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderConstraint.TryParseName(constraintName, out resourceName))
            {
                result = FromFolderConstraint(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationConstraint.TryParseName(constraintName, out resourceName))
            {
                result = FromOrganizationConstraint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(constraintName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConstraintName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string constraintId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConstraintId = constraintId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConstraintName"/> class from the component parts of pattern
        /// <c>projects/{project}/constraints/{constraint}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="constraintId">The <c>Constraint</c> ID. Must not be <c>null</c> or empty.</param>
        public ConstraintName(string projectId, string constraintId) : this(ResourceNameType.ProjectConstraint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), constraintId: gax::GaxPreconditions.CheckNotNullOrEmpty(constraintId, nameof(constraintId)))
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
        /// The <c>Constraint</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ConstraintId { get; }

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
                case ResourceNameType.ProjectConstraint: return s_projectConstraint.Expand(ProjectId, ConstraintId);
                case ResourceNameType.FolderConstraint: return s_folderConstraint.Expand(FolderId, ConstraintId);
                case ResourceNameType.OrganizationConstraint: return s_organizationConstraint.Expand(OrganizationId, ConstraintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConstraintName);

        /// <inheritdoc/>
        public bool Equals(ConstraintName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConstraintName a, ConstraintName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConstraintName a, ConstraintName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CustomConstraint</c> resource.</summary>
    public sealed partial class CustomConstraintName : gax::IResourceName, sys::IEquatable<CustomConstraintName>
    {
        /// <summary>The possible contents of <see cref="CustomConstraintName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/customConstraints/{custom_constraint}</c>.
            /// </summary>
            OrganizationCustomConstraint = 1,
        }

        private static gax::PathTemplate s_organizationCustomConstraint = new gax::PathTemplate("organizations/{organization}/customConstraints/{custom_constraint}");

        /// <summary>Creates a <see cref="CustomConstraintName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomConstraintName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomConstraintName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomConstraintName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomConstraintName"/> with the pattern
        /// <c>organizations/{organization}/customConstraints/{custom_constraint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customConstraintId">The <c>CustomConstraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomConstraintName"/> constructed from the provided ids.</returns>
        public static CustomConstraintName FromOrganizationCustomConstraint(string organizationId, string customConstraintId) =>
            new CustomConstraintName(ResourceNameType.OrganizationCustomConstraint, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), customConstraintId: gax::GaxPreconditions.CheckNotNullOrEmpty(customConstraintId, nameof(customConstraintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomConstraintName"/> with pattern
        /// <c>organizations/{organization}/customConstraints/{custom_constraint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customConstraintId">The <c>CustomConstraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomConstraintName"/> with pattern
        /// <c>organizations/{organization}/customConstraints/{custom_constraint}</c>.
        /// </returns>
        public static string Format(string organizationId, string customConstraintId) =>
            FormatOrganizationCustomConstraint(organizationId, customConstraintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomConstraintName"/> with pattern
        /// <c>organizations/{organization}/customConstraints/{custom_constraint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customConstraintId">The <c>CustomConstraint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomConstraintName"/> with pattern
        /// <c>organizations/{organization}/customConstraints/{custom_constraint}</c>.
        /// </returns>
        public static string FormatOrganizationCustomConstraint(string organizationId, string customConstraintId) =>
            s_organizationCustomConstraint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customConstraintId, nameof(customConstraintId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomConstraintName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/customConstraints/{custom_constraint}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customConstraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomConstraintName"/> if successful.</returns>
        public static CustomConstraintName Parse(string customConstraintName) => Parse(customConstraintName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomConstraintName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/customConstraints/{custom_constraint}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customConstraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomConstraintName"/> if successful.</returns>
        public static CustomConstraintName Parse(string customConstraintName, bool allowUnparsed) =>
            TryParse(customConstraintName, allowUnparsed, out CustomConstraintName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomConstraintName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/customConstraints/{custom_constraint}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customConstraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomConstraintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customConstraintName, out CustomConstraintName result) =>
            TryParse(customConstraintName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomConstraintName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/customConstraints/{custom_constraint}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customConstraintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomConstraintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customConstraintName, bool allowUnparsed, out CustomConstraintName result)
        {
            gax::GaxPreconditions.CheckNotNull(customConstraintName, nameof(customConstraintName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationCustomConstraint.TryParseName(customConstraintName, out resourceName))
            {
                result = FromOrganizationCustomConstraint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customConstraintName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomConstraintName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customConstraintId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomConstraintId = customConstraintId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomConstraintName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/customConstraints/{custom_constraint}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customConstraintId">The <c>CustomConstraint</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomConstraintName(string organizationId, string customConstraintId) : this(ResourceNameType.OrganizationCustomConstraint, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), customConstraintId: gax::GaxPreconditions.CheckNotNullOrEmpty(customConstraintId, nameof(customConstraintId)))
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
        /// The <c>CustomConstraint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomConstraintId { get; }

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
                case ResourceNameType.OrganizationCustomConstraint: return s_organizationCustomConstraint.Expand(OrganizationId, CustomConstraintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomConstraintName);

        /// <inheritdoc/>
        public bool Equals(CustomConstraintName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomConstraintName a, CustomConstraintName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomConstraintName a, CustomConstraintName b) => !(a == b);
    }

    public partial class Constraint
    {
        /// <summary>
        /// <see cref="gcov::ConstraintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::ConstraintName ConstraintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ConstraintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CustomConstraint
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
