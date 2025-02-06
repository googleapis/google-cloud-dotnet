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
using gcmv = Google.Cloud.Monitoring.V3;
using sys = System;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Resource name for the <c>AlertPolicyCondition</c> resource.</summary>
    public sealed partial class AlertPolicyConditionName : gax::IResourceName, sys::IEquatable<AlertPolicyConditionName>
    {
        /// <summary>The possible contents of <see cref="AlertPolicyConditionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>
            /// .
            /// </summary>
            ProjectAlertPolicyCondition = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
            /// </summary>
            OrganizationAlertPolicyCondition = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c>
            /// .
            /// </summary>
            FolderAlertPolicyCondition = 3,
        }

        private static gax::PathTemplate s_projectAlertPolicyCondition = new gax::PathTemplate("projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}");

        private static gax::PathTemplate s_organizationAlertPolicyCondition = new gax::PathTemplate("organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}");

        private static gax::PathTemplate s_folderAlertPolicyCondition = new gax::PathTemplate("folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}");

        /// <summary>Creates a <see cref="AlertPolicyConditionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AlertPolicyConditionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AlertPolicyConditionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AlertPolicyConditionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyConditionName"/> with the pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AlertPolicyConditionName"/> constructed from the provided ids.
        /// </returns>
        public static AlertPolicyConditionName FromProjectAlertPolicyCondition(string projectId, string alertPolicyId, string conditionId) =>
            new AlertPolicyConditionName(ResourceNameType.ProjectAlertPolicyCondition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), conditionId: gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyConditionName"/> with the pattern
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AlertPolicyConditionName"/> constructed from the provided ids.
        /// </returns>
        public static AlertPolicyConditionName FromOrganizationAlertPolicyCondition(string organizationId, string alertPolicyId, string conditionId) =>
            new AlertPolicyConditionName(ResourceNameType.OrganizationAlertPolicyCondition, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), conditionId: gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyConditionName"/> with the pattern
        /// <c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AlertPolicyConditionName"/> constructed from the provided ids.
        /// </returns>
        public static AlertPolicyConditionName FromFolderAlertPolicyCondition(string folderId, string alertPolicyId, string conditionId) =>
            new AlertPolicyConditionName(ResourceNameType.FolderAlertPolicyCondition, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), conditionId: gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </returns>
        public static string Format(string projectId, string alertPolicyId, string conditionId) =>
            FormatProjectAlertPolicyCondition(projectId, alertPolicyId, conditionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </returns>
        public static string FormatProjectAlertPolicyCondition(string projectId, string alertPolicyId, string conditionId) =>
            s_projectAlertPolicyCondition.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </returns>
        public static string FormatOrganizationAlertPolicyCondition(string organizationId, string alertPolicyId, string conditionId) =>
            s_organizationAlertPolicyCondition.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyConditionName"/> with pattern
        /// <c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c>.
        /// </returns>
        public static string FormatFolderAlertPolicyCondition(string folderId, string alertPolicyId, string conditionId) =>
            s_folderAlertPolicyCondition.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AlertPolicyConditionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="alertPolicyConditionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AlertPolicyConditionName"/> if successful.</returns>
        public static AlertPolicyConditionName Parse(string alertPolicyConditionName) =>
            Parse(alertPolicyConditionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AlertPolicyConditionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="alertPolicyConditionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AlertPolicyConditionName"/> if successful.</returns>
        public static AlertPolicyConditionName Parse(string alertPolicyConditionName, bool allowUnparsed) =>
            TryParse(alertPolicyConditionName, allowUnparsed, out AlertPolicyConditionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AlertPolicyConditionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="alertPolicyConditionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AlertPolicyConditionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyConditionName, out AlertPolicyConditionName result) =>
            TryParse(alertPolicyConditionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AlertPolicyConditionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}/conditions/{condition}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/alertPolicies/{alert_policy}/conditions/{condition}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="alertPolicyConditionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AlertPolicyConditionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyConditionName, bool allowUnparsed, out AlertPolicyConditionName result)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyConditionName, nameof(alertPolicyConditionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAlertPolicyCondition.TryParseName(alertPolicyConditionName, out resourceName))
            {
                result = FromProjectAlertPolicyCondition(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationAlertPolicyCondition.TryParseName(alertPolicyConditionName, out resourceName))
            {
                result = FromOrganizationAlertPolicyCondition(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderAlertPolicyCondition.TryParseName(alertPolicyConditionName, out resourceName))
            {
                result = FromFolderAlertPolicyCondition(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(alertPolicyConditionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AlertPolicyConditionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string alertPolicyId = null, string conditionId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AlertPolicyId = alertPolicyId;
            ConditionId = conditionId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AlertPolicyConditionName"/> class from the component parts of
        /// pattern <c>projects/{project}/alertPolicies/{alert_policy}/conditions/{condition}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conditionId">The <c>Condition</c> ID. Must not be <c>null</c> or empty.</param>
        public AlertPolicyConditionName(string projectId, string alertPolicyId, string conditionId) : this(ResourceNameType.ProjectAlertPolicyCondition, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)), conditionId: gax::GaxPreconditions.CheckNotNullOrEmpty(conditionId, nameof(conditionId)))
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
        /// The <c>AlertPolicy</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AlertPolicyId { get; }

        /// <summary>
        /// The <c>Condition</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ConditionId { get; }

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
                case ResourceNameType.ProjectAlertPolicyCondition: return s_projectAlertPolicyCondition.Expand(ProjectId, AlertPolicyId, ConditionId);
                case ResourceNameType.OrganizationAlertPolicyCondition: return s_organizationAlertPolicyCondition.Expand(OrganizationId, AlertPolicyId, ConditionId);
                case ResourceNameType.FolderAlertPolicyCondition: return s_folderAlertPolicyCondition.Expand(FolderId, AlertPolicyId, ConditionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AlertPolicyConditionName);

        /// <inheritdoc/>
        public bool Equals(AlertPolicyConditionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AlertPolicyConditionName a, AlertPolicyConditionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AlertPolicyConditionName a, AlertPolicyConditionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AlertPolicy</c> resource.</summary>
    public sealed partial class AlertPolicyName : gax::IResourceName, sys::IEquatable<AlertPolicyName>
    {
        /// <summary>The possible contents of <see cref="AlertPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/alertPolicies/{alert_policy}</c>.</summary>
            ProjectAlertPolicy = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/alertPolicies/{alert_policy}</c>.
            /// </summary>
            OrganizationAlertPolicy = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/alertPolicies/{alert_policy}</c>.</summary>
            FolderAlertPolicy = 3,
        }

        private static gax::PathTemplate s_projectAlertPolicy = new gax::PathTemplate("projects/{project}/alertPolicies/{alert_policy}");

        private static gax::PathTemplate s_organizationAlertPolicy = new gax::PathTemplate("organizations/{organization}/alertPolicies/{alert_policy}");

        private static gax::PathTemplate s_folderAlertPolicy = new gax::PathTemplate("folders/{folder}/alertPolicies/{alert_policy}");

        /// <summary>Creates a <see cref="AlertPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AlertPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AlertPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AlertPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyName"/> with the pattern <c>projects/{project}/alertPolicies/{alert_policy}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AlertPolicyName"/> constructed from the provided ids.</returns>
        public static AlertPolicyName FromProjectAlertPolicy(string projectId, string alertPolicyId) =>
            new AlertPolicyName(ResourceNameType.ProjectAlertPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyName"/> with the pattern
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AlertPolicyName"/> constructed from the provided ids.</returns>
        public static AlertPolicyName FromOrganizationAlertPolicy(string organizationId, string alertPolicyId) =>
            new AlertPolicyName(ResourceNameType.OrganizationAlertPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>
        /// Creates a <see cref="AlertPolicyName"/> with the pattern <c>folders/{folder}/alertPolicies/{alert_policy}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AlertPolicyName"/> constructed from the provided ids.</returns>
        public static AlertPolicyName FromFolderAlertPolicy(string folderId, string alertPolicyId) =>
            new AlertPolicyName(ResourceNameType.FolderAlertPolicy, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string alertPolicyId) =>
            FormatProjectAlertPolicy(projectId, alertPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>.
        /// </returns>
        public static string FormatProjectAlertPolicy(string projectId, string alertPolicyId) =>
            s_projectAlertPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>organizations/{organization}/alertPolicies/{alert_policy}</c>.
        /// </returns>
        public static string FormatOrganizationAlertPolicy(string organizationId, string alertPolicyId) =>
            s_organizationAlertPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>folders/{folder}/alertPolicies/{alert_policy}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AlertPolicyName"/> with pattern
        /// <c>folders/{folder}/alertPolicies/{alert_policy}</c>.
        /// </returns>
        public static string FormatFolderAlertPolicy(string folderId, string alertPolicyId) =>
            s_folderAlertPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)));

        /// <summary>Parses the given resource name string into a new <see cref="AlertPolicyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>folders/{folder}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AlertPolicyName"/> if successful.</returns>
        public static AlertPolicyName Parse(string alertPolicyName) => Parse(alertPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AlertPolicyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>folders/{folder}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AlertPolicyName"/> if successful.</returns>
        public static AlertPolicyName Parse(string alertPolicyName, bool allowUnparsed) =>
            TryParse(alertPolicyName, allowUnparsed, out AlertPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AlertPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>folders/{folder}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AlertPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyName, out AlertPolicyName result) =>
            TryParse(alertPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AlertPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>organizations/{organization}/alertPolicies/{alert_policy}</c></description></item>
        /// <item><description><c>folders/{folder}/alertPolicies/{alert_policy}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="alertPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AlertPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string alertPolicyName, bool allowUnparsed, out AlertPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(alertPolicyName, nameof(alertPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAlertPolicy.TryParseName(alertPolicyName, out resourceName))
            {
                result = FromProjectAlertPolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationAlertPolicy.TryParseName(alertPolicyName, out resourceName))
            {
                result = FromOrganizationAlertPolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderAlertPolicy.TryParseName(alertPolicyName, out resourceName))
            {
                result = FromFolderAlertPolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(alertPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AlertPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string alertPolicyId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AlertPolicyId = alertPolicyId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AlertPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/alertPolicies/{alert_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="alertPolicyId">The <c>AlertPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public AlertPolicyName(string projectId, string alertPolicyId) : this(ResourceNameType.ProjectAlertPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), alertPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(alertPolicyId, nameof(alertPolicyId)))
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
        /// The <c>AlertPolicy</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AlertPolicyId { get; }

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
                case ResourceNameType.ProjectAlertPolicy: return s_projectAlertPolicy.Expand(ProjectId, AlertPolicyId);
                case ResourceNameType.OrganizationAlertPolicy: return s_organizationAlertPolicy.Expand(OrganizationId, AlertPolicyId);
                case ResourceNameType.FolderAlertPolicy: return s_folderAlertPolicy.Expand(FolderId, AlertPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AlertPolicyName);

        /// <inheritdoc/>
        public bool Equals(AlertPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AlertPolicyName a, AlertPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AlertPolicyName a, AlertPolicyName b) => !(a == b);
    }

    public partial class AlertPolicy
    {
        /// <summary>
        /// <see cref="gcmv::AlertPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::AlertPolicyName AlertPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::AlertPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::AlertPolicyName.TryParse(Name, out gcmv::AlertPolicyName alertPolicy))
                {
                    return alertPolicy;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Condition
            {
                /// <summary>
                /// <see cref="gcmv::AlertPolicyConditionName"/>-typed view over the <see cref="Name"/> resource name
                /// property.
                /// </summary>
                public gcmv::AlertPolicyConditionName AlertPolicyConditionName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcmv::AlertPolicyConditionName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gax::IResourceName ResourceName
                {
                    get
                    {
                        if (string.IsNullOrEmpty(Name))
                        {
                            return null;
                        }
                        if (gcmv::AlertPolicyConditionName.TryParse(Name, out gcmv::AlertPolicyConditionName alertPolicyCondition))
                        {
                            return alertPolicyCondition;
                        }
                        return gax::UnparsedResourceName.Parse(Name);
                    }
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }
}
