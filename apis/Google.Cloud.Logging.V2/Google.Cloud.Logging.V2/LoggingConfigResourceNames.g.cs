// Copyright 2020 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gclv = Google.Cloud.Logging.V2;
using sys = System;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Resource name for the <c>Sink</c> resource.</summary>
    public sealed partial class SinkName : gax::IResourceName, sys::IEquatable<SinkName>
    {
        /// <summary>The possible contents of <see cref="SinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/sinks/{sink}</c>.</summary>
            ProjectSink = 1,

            /// <summary>A resource name with pattern <c>organizations/{organization}/sinks/{sink}</c>.</summary>
            OrganizationSink = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/sinks/{sink}</c>.</summary>
            FolderSink = 3,

            /// <summary>A resource name with pattern <c>billingAccounts/{billing_account}/sinks/{sink}</c>.</summary>
            BillingAccountSink = 4
        }

        private static gax::PathTemplate s_projectSink = new gax::PathTemplate("projects/{project}/sinks/{sink}");

        private static gax::PathTemplate s_organizationSink = new gax::PathTemplate("organizations/{organization}/sinks/{sink}");

        private static gax::PathTemplate s_folderSink = new gax::PathTemplate("folders/{folder}/sinks/{sink}");

        private static gax::PathTemplate s_billingAccountSink = new gax::PathTemplate("billingAccounts/{billing_account}/sinks/{sink}");

        /// <summary>Creates a <see cref="SinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SinkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="SinkName"/> with the pattern <c>projects/{project}/sinks/{sink}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SinkName"/> constructed from the provided ids.</returns>
        public static SinkName FromProjectSink(string projectId, string sinkId) =>
            new SinkName(ResourceNameType.ProjectSink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Creates a <see cref="SinkName"/> with the pattern <c>organizations/{organization}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SinkName"/> constructed from the provided ids.</returns>
        public static SinkName FromOrganizationSink(string organizationId, string sinkId) =>
            new SinkName(ResourceNameType.OrganizationSink, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>Creates a <see cref="SinkName"/> with the pattern <c>folders/{folder}/sinks/{sink}</c>.</summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SinkName"/> constructed from the provided ids.</returns>
        public static SinkName FromFolderSink(string folderId, string sinkId) =>
            new SinkName(ResourceNameType.FolderSink, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Creates a <see cref="SinkName"/> with the pattern <c>billingAccounts/{billing_account}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SinkName"/> constructed from the provided ids.</returns>
        public static SinkName FromBillingAccountSink(string billingAccountId, string sinkId) =>
            new SinkName(ResourceNameType.BillingAccountSink, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SinkName"/> with pattern
        /// <c>projects/{project}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SinkName"/> with pattern <c>projects/{project}/sinks/{sink}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string sinkId) => FormatProjectSink(projectId, sinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SinkName"/> with pattern
        /// <c>projects/{project}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SinkName"/> with pattern <c>projects/{project}/sinks/{sink}</c>
        /// .
        /// </returns>
        public static string FormatProjectSink(string projectId, string sinkId) =>
            s_projectSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SinkName"/> with pattern
        /// <c>organizations/{organization}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SinkName"/> with pattern
        /// <c>organizations/{organization}/sinks/{sink}</c>.
        /// </returns>
        public static string FormatOrganizationSink(string organizationId, string sinkId) =>
            s_organizationSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SinkName"/> with pattern
        /// <c>folders/{folder}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SinkName"/> with pattern <c>folders/{folder}/sinks/{sink}</c>.
        /// </returns>
        public static string FormatFolderSink(string folderId, string sinkId) =>
            s_folderSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SinkName"/> with pattern
        /// <c>billingAccounts/{billing_account}/sinks/{sink}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SinkName"/> with pattern
        /// <c>billingAccounts/{billing_account}/sinks/{sink}</c>.
        /// </returns>
        public static string FormatBillingAccountSink(string billingAccountId, string sinkId) =>
            s_billingAccountSink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="SinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SinkName"/> if successful.</returns>
        public static SinkName Parse(string sinkName) => Parse(sinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SinkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SinkName"/> if successful.</returns>
        public static SinkName Parse(string sinkName, bool allowUnparsed) =>
            TryParse(sinkName, allowUnparsed, out SinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sinkName, out SinkName result) => TryParse(sinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/sinks/{sink}</c></description></item>
        /// <item><description><c>organizations/{organization}/sinks/{sink}</c></description></item>
        /// <item><description><c>folders/{folder}/sinks/{sink}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/sinks/{sink}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sinkName, bool allowUnparsed, out SinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSink.TryParseName(sinkName, out resourceName))
            {
                result = FromProjectSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationSink.TryParseName(sinkName, out resourceName))
            {
                result = FromOrganizationSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderSink.TryParseName(sinkName, out resourceName))
            {
                result = FromFolderSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_billingAccountSink.TryParseName(sinkName, out resourceName))
            {
                result = FromBillingAccountSink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string organizationId = null, string projectId = null, string sinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SinkId = sinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SinkName"/> class from the component parts of pattern
        /// <c>projects/{project}/sinks/{sink}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sinkId">The <c>Sink</c> ID. Must not be <c>null</c> or empty.</param>
        public SinkName(string projectId, string sinkId) : this(ResourceNameType.ProjectSink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(sinkId, nameof(sinkId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

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

        /// <summary>
        /// The <c>Sink</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SinkId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSink: return s_projectSink.Expand(ProjectId, SinkId);
                case ResourceNameType.OrganizationSink: return s_organizationSink.Expand(OrganizationId, SinkId);
                case ResourceNameType.FolderSink: return s_folderSink.Expand(FolderId, SinkId);
                case ResourceNameType.BillingAccountSink: return s_billingAccountSink.Expand(BillingAccountId, SinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SinkName);

        /// <inheritdoc/>
        public bool Equals(SinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SinkName a, SinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SinkName a, SinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Exclusion</c> resource.</summary>
    public sealed partial class ExclusionName : gax::IResourceName, sys::IEquatable<ExclusionName>
    {
        /// <summary>The possible contents of <see cref="ExclusionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/exclusions/{exclusion}</c>.</summary>
            ProjectExclusion = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/exclusions/{exclusion}</c>.
            /// </summary>
            OrganizationExclusion = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/exclusions/{exclusion}</c>.</summary>
            FolderExclusion = 3,

            /// <summary>
            /// A resource name with pattern <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
            /// </summary>
            BillingAccountExclusion = 4
        }

        private static gax::PathTemplate s_projectExclusion = new gax::PathTemplate("projects/{project}/exclusions/{exclusion}");

        private static gax::PathTemplate s_organizationExclusion = new gax::PathTemplate("organizations/{organization}/exclusions/{exclusion}");

        private static gax::PathTemplate s_folderExclusion = new gax::PathTemplate("folders/{folder}/exclusions/{exclusion}");

        private static gax::PathTemplate s_billingAccountExclusion = new gax::PathTemplate("billingAccounts/{billing_account}/exclusions/{exclusion}");

        /// <summary>Creates a <see cref="ExclusionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExclusionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExclusionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExclusionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExclusionName"/> with the pattern <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExclusionName"/> constructed from the provided ids.</returns>
        public static ExclusionName FromProjectExclusion(string projectId, string exclusionId) =>
            new ExclusionName(ResourceNameType.ProjectExclusion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Creates a <see cref="ExclusionName"/> with the pattern
        /// <c>organizations/{organization}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExclusionName"/> constructed from the provided ids.</returns>
        public static ExclusionName FromOrganizationExclusion(string organizationId, string exclusionId) =>
            new ExclusionName(ResourceNameType.OrganizationExclusion, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Creates a <see cref="ExclusionName"/> with the pattern <c>folders/{folder}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExclusionName"/> constructed from the provided ids.</returns>
        public static ExclusionName FromFolderExclusion(string folderId, string exclusionId) =>
            new ExclusionName(ResourceNameType.FolderExclusion, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Creates a <see cref="ExclusionName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExclusionName"/> constructed from the provided ids.</returns>
        public static ExclusionName FromBillingAccountExclusion(string billingAccountId, string exclusionId) =>
            new ExclusionName(ResourceNameType.BillingAccountExclusion, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string Format(string projectId, string exclusionId) => FormatProjectExclusion(projectId, exclusionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatProjectExclusion(string projectId, string exclusionId) =>
            s_projectExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>organizations/{organization}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>organizations/{organization}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatOrganizationExclusion(string organizationId, string exclusionId) =>
            s_organizationExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>folders/{folder}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>folders/{folder}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatFolderExclusion(string folderId, string exclusionId) =>
            s_folderExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExclusionName"/> with pattern
        /// <c>billingAccounts/{billing_account}/exclusions/{exclusion}</c>.
        /// </returns>
        public static string FormatBillingAccountExclusion(string billingAccountId, string exclusionId) =>
            s_billingAccountExclusion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExclusionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="exclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExclusionName"/> if successful.</returns>
        public static ExclusionName Parse(string exclusionName) => Parse(exclusionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExclusionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExclusionName"/> if successful.</returns>
        public static ExclusionName Parse(string exclusionName, bool allowUnparsed) =>
            TryParse(exclusionName, allowUnparsed, out ExclusionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExclusionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="exclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExclusionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exclusionName, out ExclusionName result) => TryParse(exclusionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExclusionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>organizations/{organization}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>folders/{folder}/exclusions/{exclusion}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/exclusions/{exclusion}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exclusionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExclusionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exclusionName, bool allowUnparsed, out ExclusionName result)
        {
            gax::GaxPreconditions.CheckNotNull(exclusionName, nameof(exclusionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectExclusion.TryParseName(exclusionName, out resourceName))
            {
                result = FromProjectExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationExclusion.TryParseName(exclusionName, out resourceName))
            {
                result = FromOrganizationExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderExclusion.TryParseName(exclusionName, out resourceName))
            {
                result = FromFolderExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_billingAccountExclusion.TryParseName(exclusionName, out resourceName))
            {
                result = FromBillingAccountExclusion(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(exclusionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExclusionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string exclusionId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            ExclusionId = exclusionId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExclusionName"/> class from the component parts of pattern
        /// <c>projects/{project}/exclusions/{exclusion}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exclusionId">The <c>Exclusion</c> ID. Must not be <c>null</c> or empty.</param>
        public ExclusionName(string projectId, string exclusionId) : this(ResourceNameType.ProjectExclusion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), exclusionId: gax::GaxPreconditions.CheckNotNullOrEmpty(exclusionId, nameof(exclusionId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Exclusion</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ExclusionId { get; }

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

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectExclusion: return s_projectExclusion.Expand(ProjectId, ExclusionId);
                case ResourceNameType.OrganizationExclusion: return s_organizationExclusion.Expand(OrganizationId, ExclusionId);
                case ResourceNameType.FolderExclusion: return s_folderExclusion.Expand(FolderId, ExclusionId);
                case ResourceNameType.BillingAccountExclusion: return s_billingAccountExclusion.Expand(BillingAccountId, ExclusionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExclusionName);

        /// <inheritdoc/>
        public bool Equals(ExclusionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ExclusionName a, ExclusionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ExclusionName a, ExclusionName b) => !(a == b);
    }

    public partial class LogSink
    {
        /// <summary>
        /// <see cref="gclv::SinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::SinkName SinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::SinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public gax::IResourceName DestinationAsResourceName
        {
            get => string.IsNullOrEmpty(Destination) ? null : gax::UnparsedResourceName.Parse(Destination);
            set => Destination = value?.ToString() ?? "";
        }
    }

    public partial class ListSinksRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSinkRequest
    {
        /// <summary>
        /// <see cref="gclv::SinkName"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public gclv::SinkName SinkNameAsSinkName
        {
            get => string.IsNullOrEmpty(SinkName) ? null : gclv::SinkName.Parse(SinkName, allowUnparsed: true);
            set => SinkName = value?.ToString() ?? "";
        }
    }

    public partial class CreateSinkRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateSinkRequest
    {
        /// <summary>
        /// <see cref="gclv::SinkName"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public gclv::SinkName SinkNameAsSinkName
        {
            get => string.IsNullOrEmpty(SinkName) ? null : gclv::SinkName.Parse(SinkName, allowUnparsed: true);
            set => SinkName = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSinkRequest
    {
        /// <summary>
        /// <see cref="gclv::SinkName"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public gclv::SinkName SinkNameAsSinkName
        {
            get => string.IsNullOrEmpty(SinkName) ? null : gclv::SinkName.Parse(SinkName, allowUnparsed: true);
            set => SinkName = value?.ToString() ?? "";
        }
    }

    public partial class LogExclusion
    {
        /// <summary>
        /// <see cref="gclv::ExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ExclusionName ExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExclusionsRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetExclusionRequest
    {
        /// <summary>
        /// <see cref="gclv::ExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ExclusionName ExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateExclusionRequest
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
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
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
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName ParentAsBillingAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::BillingAccountName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Parent, out gagr::FolderName folder))
                {
                    return folder;
                }
                if (gagr::BillingAccountName.TryParse(Parent, out gagr::BillingAccountName billingAccount))
                {
                    return billingAccount;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateExclusionRequest
    {
        /// <summary>
        /// <see cref="gclv::ExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ExclusionName ExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteExclusionRequest
    {
        /// <summary>
        /// <see cref="gclv::ExclusionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ExclusionName ExclusionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ExclusionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
