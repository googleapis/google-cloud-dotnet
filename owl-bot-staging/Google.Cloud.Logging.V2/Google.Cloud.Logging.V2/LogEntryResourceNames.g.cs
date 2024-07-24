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
using gclv = Google.Cloud.Logging.V2;
using sys = System;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Resource name for the <c>Log</c> resource.</summary>
    public sealed partial class LogName : gax::IResourceName, sys::IEquatable<LogName>
    {
        /// <summary>The possible contents of <see cref="LogName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/logs/{log}</c>.</summary>
            ProjectLog = 1,

            /// <summary>A resource name with pattern <c>organizations/{organization}/logs/{log}</c>.</summary>
            OrganizationLog = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/logs/{log}</c>.</summary>
            FolderLog = 3,

            /// <summary>A resource name with pattern <c>billingAccounts/{billing_account}/logs/{log}</c>.</summary>
            BillingAccountLog = 4,
        }

        private static gax::PathTemplate s_projectLog = new gax::PathTemplate("projects/{project}/logs/{log}");

        private static gax::PathTemplate s_organizationLog = new gax::PathTemplate("organizations/{organization}/logs/{log}");

        private static gax::PathTemplate s_folderLog = new gax::PathTemplate("folders/{folder}/logs/{log}");

        private static gax::PathTemplate s_billingAccountLog = new gax::PathTemplate("billingAccounts/{billing_account}/logs/{log}");

        /// <summary>Creates a <see cref="LogName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="LogName"/> with the pattern <c>projects/{project}/logs/{log}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogName"/> constructed from the provided ids.</returns>
        public static LogName FromProjectLog(string projectId, string logId) =>
            new LogName(ResourceNameType.ProjectLog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), logId: gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>
        /// Creates a <see cref="LogName"/> with the pattern <c>organizations/{organization}/logs/{log}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogName"/> constructed from the provided ids.</returns>
        public static LogName FromOrganizationLog(string organizationId, string logId) =>
            new LogName(ResourceNameType.OrganizationLog, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), logId: gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>Creates a <see cref="LogName"/> with the pattern <c>folders/{folder}/logs/{log}</c>.</summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogName"/> constructed from the provided ids.</returns>
        public static LogName FromFolderLog(string folderId, string logId) =>
            new LogName(ResourceNameType.FolderLog, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), logId: gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>
        /// Creates a <see cref="LogName"/> with the pattern <c>billingAccounts/{billing_account}/logs/{log}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogName"/> constructed from the provided ids.</returns>
        public static LogName FromBillingAccountLog(string billingAccountId, string logId) =>
            new LogName(ResourceNameType.BillingAccountLog, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), logId: gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogName"/> with pattern
        /// <c>projects/{project}/logs/{log}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogName"/> with pattern <c>projects/{project}/logs/{log}</c>.
        /// </returns>
        public static string Format(string projectId, string logId) => FormatProjectLog(projectId, logId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogName"/> with pattern
        /// <c>projects/{project}/logs/{log}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogName"/> with pattern <c>projects/{project}/logs/{log}</c>.
        /// </returns>
        public static string FormatProjectLog(string projectId, string logId) =>
            s_projectLog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogName"/> with pattern
        /// <c>organizations/{organization}/logs/{log}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogName"/> with pattern
        /// <c>organizations/{organization}/logs/{log}</c>.
        /// </returns>
        public static string FormatOrganizationLog(string organizationId, string logId) =>
            s_organizationLog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogName"/> with pattern
        /// <c>folders/{folder}/logs/{log}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogName"/> with pattern <c>folders/{folder}/logs/{log}</c>.
        /// </returns>
        public static string FormatFolderLog(string folderId, string logId) =>
            s_folderLog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogName"/> with pattern
        /// <c>billingAccounts/{billing_account}/logs/{log}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogName"/> with pattern
        /// <c>billingAccounts/{billing_account}/logs/{log}</c>.
        /// </returns>
        public static string FormatBillingAccountLog(string billingAccountId, string logId) =>
            s_billingAccountLog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/logs/{log}</c></description></item>
        /// <item><description><c>organizations/{organization}/logs/{log}</c></description></item>
        /// <item><description><c>folders/{folder}/logs/{log}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/logs/{log}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogName"/> if successful.</returns>
        public static LogName Parse(string logName) => Parse(logName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/logs/{log}</c></description></item>
        /// <item><description><c>organizations/{organization}/logs/{log}</c></description></item>
        /// <item><description><c>folders/{folder}/logs/{log}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/logs/{log}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogName"/> if successful.</returns>
        public static LogName Parse(string logName, bool allowUnparsed) =>
            TryParse(logName, allowUnparsed, out LogName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="LogName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/logs/{log}</c></description></item>
        /// <item><description><c>organizations/{organization}/logs/{log}</c></description></item>
        /// <item><description><c>folders/{folder}/logs/{log}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/logs/{log}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="logName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logName, out LogName result) => TryParse(logName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/logs/{log}</c></description></item>
        /// <item><description><c>organizations/{organization}/logs/{log}</c></description></item>
        /// <item><description><c>folders/{folder}/logs/{log}</c></description></item>
        /// <item><description><c>billingAccounts/{billing_account}/logs/{log}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logName, bool allowUnparsed, out LogName result)
        {
            gax::GaxPreconditions.CheckNotNull(logName, nameof(logName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLog.TryParseName(logName, out resourceName))
            {
                result = FromProjectLog(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLog.TryParseName(logName, out resourceName))
            {
                result = FromOrganizationLog(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderLog.TryParseName(logName, out resourceName))
            {
                result = FromFolderLog(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_billingAccountLog.TryParseName(logName, out resourceName))
            {
                result = FromBillingAccountLog(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string logId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            LogId = logId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogName"/> class from the component parts of pattern
        /// <c>projects/{project}/logs/{log}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logId">The <c>Log</c> ID. Must not be <c>null</c> or empty.</param>
        public LogName(string projectId, string logId) : this(ResourceNameType.ProjectLog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), logId: gax::GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(logId)))
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
        /// The <c>Log</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LogId { get; }

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
                case ResourceNameType.ProjectLog: return s_projectLog.Expand(ProjectId, LogId);
                case ResourceNameType.OrganizationLog: return s_organizationLog.Expand(OrganizationId, LogId);
                case ResourceNameType.FolderLog: return s_folderLog.Expand(FolderId, LogId);
                case ResourceNameType.BillingAccountLog: return s_billingAccountLog.Expand(BillingAccountId, LogId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogName);

        /// <inheritdoc/>
        public bool Equals(LogName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogName a, LogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogName a, LogName b) => !(a == b);
    }

    public partial class LogEntry
    {
        /// <summary>
        /// <see cref="gclv::LogName"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public gclv::LogName LogNameAsLogName
        {
            get => string.IsNullOrEmpty(LogName) ? null : gclv::LogName.Parse(LogName, allowUnparsed: true);
            set => LogName = value?.ToString() ?? "";
        }
    }
}
