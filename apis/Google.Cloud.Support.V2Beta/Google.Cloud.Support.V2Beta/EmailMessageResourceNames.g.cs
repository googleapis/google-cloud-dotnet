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
using gcsv = Google.Cloud.Support.V2Beta;
using sys = System;

namespace Google.Cloud.Support.V2Beta
{
    /// <summary>Resource name for the <c>EmailMessage</c> resource.</summary>
    public sealed partial class EmailMessageName : gax::IResourceName, sys::IEquatable<EmailMessageName>
    {
        /// <summary>The possible contents of <see cref="EmailMessageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>.
            /// </summary>
            ProjectCaseEmailMessage = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c>
            /// .
            /// </summary>
            OrganizationCaseEmailMessage = 2,
        }

        private static gax::PathTemplate s_projectCaseEmailMessage = new gax::PathTemplate("projects/{project}/cases/{case}/emailMessages/{email_message}");

        private static gax::PathTemplate s_organizationCaseEmailMessage = new gax::PathTemplate("organizations/{organization}/cases/{case}/emailMessages/{email_message}");

        /// <summary>Creates a <see cref="EmailMessageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EmailMessageName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EmailMessageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EmailMessageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EmailMessageName"/> with the pattern
        /// <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="emailMessageId">The <c>EmailMessage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EmailMessageName"/> constructed from the provided ids.</returns>
        public static EmailMessageName FromProjectCaseEmailMessage(string projectId, string caseId, string emailMessageId) =>
            new EmailMessageName(ResourceNameType.ProjectCaseEmailMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), emailMessageId: gax::GaxPreconditions.CheckNotNullOrEmpty(emailMessageId, nameof(emailMessageId)));

        /// <summary>
        /// Creates a <see cref="EmailMessageName"/> with the pattern
        /// <c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="emailMessageId">The <c>EmailMessage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EmailMessageName"/> constructed from the provided ids.</returns>
        public static EmailMessageName FromOrganizationCaseEmailMessage(string organizationId, string caseId, string emailMessageId) =>
            new EmailMessageName(ResourceNameType.OrganizationCaseEmailMessage, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), emailMessageId: gax::GaxPreconditions.CheckNotNullOrEmpty(emailMessageId, nameof(emailMessageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EmailMessageName"/> with pattern
        /// <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="emailMessageId">The <c>EmailMessage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EmailMessageName"/> with pattern
        /// <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>.
        /// </returns>
        public static string Format(string projectId, string caseId, string emailMessageId) =>
            FormatProjectCaseEmailMessage(projectId, caseId, emailMessageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EmailMessageName"/> with pattern
        /// <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="emailMessageId">The <c>EmailMessage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EmailMessageName"/> with pattern
        /// <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>.
        /// </returns>
        public static string FormatProjectCaseEmailMessage(string projectId, string caseId, string emailMessageId) =>
            s_projectCaseEmailMessage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(emailMessageId, nameof(emailMessageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EmailMessageName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="emailMessageId">The <c>EmailMessage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EmailMessageName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c>.
        /// </returns>
        public static string FormatOrganizationCaseEmailMessage(string organizationId, string caseId, string emailMessageId) =>
            s_organizationCaseEmailMessage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(emailMessageId, nameof(emailMessageId)));

        /// <summary>Parses the given resource name string into a new <see cref="EmailMessageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="emailMessageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EmailMessageName"/> if successful.</returns>
        public static EmailMessageName Parse(string emailMessageName) => Parse(emailMessageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EmailMessageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="emailMessageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EmailMessageName"/> if successful.</returns>
        public static EmailMessageName Parse(string emailMessageName, bool allowUnparsed) =>
            TryParse(emailMessageName, allowUnparsed, out EmailMessageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EmailMessageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="emailMessageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EmailMessageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string emailMessageName, out EmailMessageName result) =>
            TryParse(emailMessageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EmailMessageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/cases/{case}/emailMessages/{email_message}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="emailMessageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EmailMessageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string emailMessageName, bool allowUnparsed, out EmailMessageName result)
        {
            gax::GaxPreconditions.CheckNotNull(emailMessageName, nameof(emailMessageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectCaseEmailMessage.TryParseName(emailMessageName, out resourceName))
            {
                result = FromProjectCaseEmailMessage(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationCaseEmailMessage.TryParseName(emailMessageName, out resourceName))
            {
                result = FromOrganizationCaseEmailMessage(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(emailMessageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EmailMessageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caseId = null, string emailMessageId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaseId = caseId;
            EmailMessageId = emailMessageId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EmailMessageName"/> class from the component parts of pattern
        /// <c>projects/{project}/cases/{case}/emailMessages/{email_message}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="emailMessageId">The <c>EmailMessage</c> ID. Must not be <c>null</c> or empty.</param>
        public EmailMessageName(string projectId, string caseId, string emailMessageId) : this(ResourceNameType.ProjectCaseEmailMessage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), emailMessageId: gax::GaxPreconditions.CheckNotNullOrEmpty(emailMessageId, nameof(emailMessageId)))
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
        /// The <c>Case</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string CaseId { get; }

        /// <summary>
        /// The <c>EmailMessage</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EmailMessageId { get; }

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
                case ResourceNameType.ProjectCaseEmailMessage: return s_projectCaseEmailMessage.Expand(ProjectId, CaseId, EmailMessageId);
                case ResourceNameType.OrganizationCaseEmailMessage: return s_organizationCaseEmailMessage.Expand(OrganizationId, CaseId, EmailMessageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EmailMessageName);

        /// <inheritdoc/>
        public bool Equals(EmailMessageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EmailMessageName a, EmailMessageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EmailMessageName a, EmailMessageName b) => !(a == b);
    }

    public partial class EmailMessage
    {
        /// <summary>
        /// <see cref="gcsv::EmailMessageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::EmailMessageName EmailMessageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EmailMessageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
