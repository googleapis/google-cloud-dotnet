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
    /// <summary>Resource name for the <c>NotificationConfig</c> resource.</summary>
    public sealed partial class NotificationConfigName : gax::IResourceName, sys::IEquatable<NotificationConfigName>
    {
        /// <summary>The possible contents of <see cref="NotificationConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/notificationConfigs/{notification_config}</c>
            /// .
            /// </summary>
            OrganizationNotificationConfig = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/notificationConfigs/{notification_config}</c>.
            /// </summary>
            FolderNotificationConfig = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/notificationConfigs/{notification_config}</c>.
            /// </summary>
            ProjectNotificationConfig = 3,
        }

        private static gax::PathTemplate s_organizationNotificationConfig = new gax::PathTemplate("organizations/{organization}/notificationConfigs/{notification_config}");

        private static gax::PathTemplate s_folderNotificationConfig = new gax::PathTemplate("folders/{folder}/notificationConfigs/{notification_config}");

        private static gax::PathTemplate s_projectNotificationConfig = new gax::PathTemplate("projects/{project}/notificationConfigs/{notification_config}");

        /// <summary>Creates a <see cref="NotificationConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NotificationConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotificationConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotificationConfigName"/> with the pattern
        /// <c>organizations/{organization}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="NotificationConfigName"/> constructed from the provided ids.</returns>
        public static NotificationConfigName FromOrganizationNotificationConfig(string organizationId, string notificationConfigId) =>
            new NotificationConfigName(ResourceNameType.OrganizationNotificationConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), notificationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Creates a <see cref="NotificationConfigName"/> with the pattern
        /// <c>folders/{folder}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="NotificationConfigName"/> constructed from the provided ids.</returns>
        public static NotificationConfigName FromFolderNotificationConfig(string folderId, string notificationConfigId) =>
            new NotificationConfigName(ResourceNameType.FolderNotificationConfig, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), notificationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Creates a <see cref="NotificationConfigName"/> with the pattern
        /// <c>projects/{project}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="NotificationConfigName"/> constructed from the provided ids.</returns>
        public static NotificationConfigName FromProjectNotificationConfig(string projectId, string notificationConfigId) =>
            new NotificationConfigName(ResourceNameType.ProjectNotificationConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), notificationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>organizations/{organization}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>organizations/{organization}/notificationConfigs/{notification_config}</c>.
        /// </returns>
        public static string Format(string organizationId, string notificationConfigId) =>
            FormatOrganizationNotificationConfig(organizationId, notificationConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>organizations/{organization}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>organizations/{organization}/notificationConfigs/{notification_config}</c>.
        /// </returns>
        public static string FormatOrganizationNotificationConfig(string organizationId, string notificationConfigId) =>
            s_organizationNotificationConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>folders/{folder}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>folders/{folder}/notificationConfigs/{notification_config}</c>.
        /// </returns>
        public static string FormatFolderNotificationConfig(string folderId, string notificationConfigId) =>
            s_folderNotificationConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>projects/{project}/notificationConfigs/{notification_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationConfigName"/> with pattern
        /// <c>projects/{project}/notificationConfigs/{notification_config}</c>.
        /// </returns>
        public static string FormatProjectNotificationConfig(string projectId, string notificationConfigId) =>
            s_projectNotificationConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/notificationConfigs/{notification_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationConfigs/{notification_config}</c></description></item>
        /// <item><description><c>projects/{project}/notificationConfigs/{notification_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="notificationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotificationConfigName"/> if successful.</returns>
        public static NotificationConfigName Parse(string notificationConfigName) => Parse(notificationConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/notificationConfigs/{notification_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationConfigs/{notification_config}</c></description></item>
        /// <item><description><c>projects/{project}/notificationConfigs/{notification_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotificationConfigName"/> if successful.</returns>
        public static NotificationConfigName Parse(string notificationConfigName, bool allowUnparsed) =>
            TryParse(notificationConfigName, allowUnparsed, out NotificationConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/notificationConfigs/{notification_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationConfigs/{notification_config}</c></description></item>
        /// <item><description><c>projects/{project}/notificationConfigs/{notification_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="notificationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationConfigName, out NotificationConfigName result) =>
            TryParse(notificationConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/notificationConfigs/{notification_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationConfigs/{notification_config}</c></description></item>
        /// <item><description><c>projects/{project}/notificationConfigs/{notification_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationConfigName, bool allowUnparsed, out NotificationConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationConfigName, nameof(notificationConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationNotificationConfig.TryParseName(notificationConfigName, out resourceName))
            {
                result = FromOrganizationNotificationConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderNotificationConfig.TryParseName(notificationConfigName, out resourceName))
            {
                result = FromFolderNotificationConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectNotificationConfig.TryParseName(notificationConfigName, out resourceName))
            {
                result = FromProjectNotificationConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notificationConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotificationConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string notificationConfigId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            NotificationConfigId = notificationConfigId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotificationConfigName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/notificationConfigs/{notification_config}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationConfigId">
        /// The <c>NotificationConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public NotificationConfigName(string organizationId, string notificationConfigId) : this(ResourceNameType.OrganizationNotificationConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), notificationConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationConfigId, nameof(notificationConfigId)))
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
        /// The <c>NotificationConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string NotificationConfigId { get; }

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
                case ResourceNameType.OrganizationNotificationConfig: return s_organizationNotificationConfig.Expand(OrganizationId, NotificationConfigId);
                case ResourceNameType.FolderNotificationConfig: return s_folderNotificationConfig.Expand(FolderId, NotificationConfigId);
                case ResourceNameType.ProjectNotificationConfig: return s_projectNotificationConfig.Expand(ProjectId, NotificationConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotificationConfigName);

        /// <inheritdoc/>
        public bool Equals(NotificationConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NotificationConfigName a, NotificationConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NotificationConfigName a, NotificationConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        /// <summary>The possible contents of <see cref="TopicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/topics/{topic}</c>.</summary>
            ProjectTopic = 1,
        }

        private static gax::PathTemplate s_projectTopic = new gax::PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>Creates a <see cref="TopicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicName"/> with the pattern <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromProjectTopic(string projectId, string topicId) =>
            new TopicName(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string topicId) => FormatProjectTopic(projectId, topicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string FormatProjectTopic(string projectId, string topicId) =>
            s_projectTopic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>Parses the given resource name string into a new <see cref="TopicName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName) => Parse(topicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName, bool allowUnparsed) =>
            TryParse(topicName, allowUnparsed, out TopicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result) => TryParse(topicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, bool allowUnparsed, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTopic.TryParseName(topicName, out resourceName))
            {
                result = FromProjectTopic(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string topicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TopicId = topicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicName"/> class from the component parts of pattern
        /// <c>projects/{project}/topics/{topic}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicName(string projectId, string topicId) : this(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Topic</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TopicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTopic: return s_projectTopic.Expand(ProjectId, TopicId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    public partial class NotificationConfig
    {
        /// <summary>
        /// <see cref="gcsv::NotificationConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NotificationConfigName NotificationConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NotificationConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TopicName"/>-typed view over the <see cref="PubsubTopic"/> resource name property.
        /// </summary>
        public TopicName PubsubTopicAsTopicName
        {
            get => string.IsNullOrEmpty(PubsubTopic) ? null : TopicName.Parse(PubsubTopic, allowUnparsed: true);
            set => PubsubTopic = value?.ToString() ?? "";
        }
    }
}
