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
    /// <summary>Resource name for the <c>NotificationChannelDescriptor</c> resource.</summary>
    public sealed partial class NotificationChannelDescriptorName : gax::IResourceName, sys::IEquatable<NotificationChannelDescriptorName>
    {
        /// <summary>The possible contents of <see cref="NotificationChannelDescriptorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>
            /// .
            /// </summary>
            ProjectChannelDescriptor = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>.
            /// </summary>
            OrganizationChannelDescriptor = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c>
            /// .
            /// </summary>
            FolderChannelDescriptor = 3,
        }

        private static gax::PathTemplate s_projectChannelDescriptor = new gax::PathTemplate("projects/{project}/notificationChannelDescriptors/{channel_descriptor}");

        private static gax::PathTemplate s_organizationChannelDescriptor = new gax::PathTemplate("organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}");

        private static gax::PathTemplate s_folderChannelDescriptor = new gax::PathTemplate("folders/{folder}/notificationChannelDescriptors/{channel_descriptor}");

        /// <summary>
        /// Creates a <see cref="NotificationChannelDescriptorName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelDescriptorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NotificationChannelDescriptorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotificationChannelDescriptorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotificationChannelDescriptorName"/> with the pattern
        /// <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelDescriptorName"/> constructed from the provided ids.
        /// </returns>
        public static NotificationChannelDescriptorName FromProjectChannelDescriptor(string projectId, string channelDescriptorId) =>
            new NotificationChannelDescriptorName(ResourceNameType.ProjectChannelDescriptor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), channelDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)));

        /// <summary>
        /// Creates a <see cref="NotificationChannelDescriptorName"/> with the pattern
        /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelDescriptorName"/> constructed from the provided ids.
        /// </returns>
        public static NotificationChannelDescriptorName FromOrganizationChannelDescriptor(string organizationId, string channelDescriptorId) =>
            new NotificationChannelDescriptorName(ResourceNameType.OrganizationChannelDescriptor, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), channelDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)));

        /// <summary>
        /// Creates a <see cref="NotificationChannelDescriptorName"/> with the pattern
        /// <c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelDescriptorName"/> constructed from the provided ids.
        /// </returns>
        public static NotificationChannelDescriptorName FromFolderChannelDescriptor(string folderId, string channelDescriptorId) =>
            new NotificationChannelDescriptorName(ResourceNameType.FolderChannelDescriptor, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), channelDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelDescriptorName"/> with
        /// pattern <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelDescriptorName"/> with pattern
        /// <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </returns>
        public static string Format(string projectId, string channelDescriptorId) =>
            FormatProjectChannelDescriptor(projectId, channelDescriptorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelDescriptorName"/> with
        /// pattern <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelDescriptorName"/> with pattern
        /// <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </returns>
        public static string FormatProjectChannelDescriptor(string projectId, string channelDescriptorId) =>
            s_projectChannelDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelDescriptorName"/> with
        /// pattern <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelDescriptorName"/> with pattern
        /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </returns>
        public static string FormatOrganizationChannelDescriptor(string organizationId, string channelDescriptorId) =>
            s_organizationChannelDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelDescriptorName"/> with
        /// pattern <c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelDescriptorName"/> with pattern
        /// <c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c>.
        /// </returns>
        public static string FormatFolderChannelDescriptor(string folderId, string channelDescriptorId) =>
            s_folderChannelDescriptor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationChannelDescriptorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notificationChannelDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="NotificationChannelDescriptorName"/> if successful.</returns>
        public static NotificationChannelDescriptorName Parse(string notificationChannelDescriptorName) =>
            Parse(notificationChannelDescriptorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationChannelDescriptorName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationChannelDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotificationChannelDescriptorName"/> if successful.</returns>
        public static NotificationChannelDescriptorName Parse(string notificationChannelDescriptorName, bool allowUnparsed) =>
            TryParse(notificationChannelDescriptorName, allowUnparsed, out NotificationChannelDescriptorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationChannelDescriptorName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notificationChannelDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationChannelDescriptorName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationChannelDescriptorName, out NotificationChannelDescriptorName result) =>
            TryParse(notificationChannelDescriptorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationChannelDescriptorName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/notificationChannelDescriptors/{channel_descriptor}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/notificationChannelDescriptors/{channel_descriptor}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationChannelDescriptorName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationChannelDescriptorName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationChannelDescriptorName, bool allowUnparsed, out NotificationChannelDescriptorName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationChannelDescriptorName, nameof(notificationChannelDescriptorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectChannelDescriptor.TryParseName(notificationChannelDescriptorName, out resourceName))
            {
                result = FromProjectChannelDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationChannelDescriptor.TryParseName(notificationChannelDescriptorName, out resourceName))
            {
                result = FromOrganizationChannelDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderChannelDescriptor.TryParseName(notificationChannelDescriptorName, out resourceName))
            {
                result = FromFolderChannelDescriptor(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notificationChannelDescriptorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotificationChannelDescriptorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelDescriptorId = null, string folderId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelDescriptorId = channelDescriptorId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotificationChannelDescriptorName"/> class from the component
        /// parts of pattern <c>projects/{project}/notificationChannelDescriptors/{channel_descriptor}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelDescriptorId">The <c>ChannelDescriptor</c> ID. Must not be <c>null</c> or empty.</param>
        public NotificationChannelDescriptorName(string projectId, string channelDescriptorId) : this(ResourceNameType.ProjectChannelDescriptor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), channelDescriptorId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelDescriptorId, nameof(channelDescriptorId)))
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
        /// The <c>ChannelDescriptor</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ChannelDescriptorId { get; }

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
                case ResourceNameType.ProjectChannelDescriptor: return s_projectChannelDescriptor.Expand(ProjectId, ChannelDescriptorId);
                case ResourceNameType.OrganizationChannelDescriptor: return s_organizationChannelDescriptor.Expand(OrganizationId, ChannelDescriptorId);
                case ResourceNameType.FolderChannelDescriptor: return s_folderChannelDescriptor.Expand(FolderId, ChannelDescriptorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotificationChannelDescriptorName);

        /// <inheritdoc/>
        public bool Equals(NotificationChannelDescriptorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NotificationChannelDescriptorName a, NotificationChannelDescriptorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NotificationChannelDescriptorName a, NotificationChannelDescriptorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NotificationChannel</c> resource.</summary>
    public sealed partial class NotificationChannelName : gax::IResourceName, sys::IEquatable<NotificationChannelName>
    {
        /// <summary>The possible contents of <see cref="NotificationChannelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/notificationChannels/{notification_channel}</c>.
            /// </summary>
            ProjectNotificationChannel = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/notificationChannels/{notification_channel}</c>
            /// .
            /// </summary>
            OrganizationNotificationChannel = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/notificationChannels/{notification_channel}</c>.
            /// </summary>
            FolderNotificationChannel = 3,
        }

        private static gax::PathTemplate s_projectNotificationChannel = new gax::PathTemplate("projects/{project}/notificationChannels/{notification_channel}");

        private static gax::PathTemplate s_organizationNotificationChannel = new gax::PathTemplate("organizations/{organization}/notificationChannels/{notification_channel}");

        private static gax::PathTemplate s_folderNotificationChannel = new gax::PathTemplate("folders/{folder}/notificationChannels/{notification_channel}");

        /// <summary>Creates a <see cref="NotificationChannelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NotificationChannelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotificationChannelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotificationChannelName"/> with the pattern
        /// <c>projects/{project}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelName"/> constructed from the provided ids.
        /// </returns>
        public static NotificationChannelName FromProjectNotificationChannel(string projectId, string notificationChannelId) =>
            new NotificationChannelName(ResourceNameType.ProjectNotificationChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), notificationChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)));

        /// <summary>
        /// Creates a <see cref="NotificationChannelName"/> with the pattern
        /// <c>organizations/{organization}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelName"/> constructed from the provided ids.
        /// </returns>
        public static NotificationChannelName FromOrganizationNotificationChannel(string organizationId, string notificationChannelId) =>
            new NotificationChannelName(ResourceNameType.OrganizationNotificationChannel, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), notificationChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)));

        /// <summary>
        /// Creates a <see cref="NotificationChannelName"/> with the pattern
        /// <c>folders/{folder}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="NotificationChannelName"/> constructed from the provided ids.
        /// </returns>
        public static NotificationChannelName FromFolderNotificationChannel(string folderId, string notificationChannelId) =>
            new NotificationChannelName(ResourceNameType.FolderNotificationChannel, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), notificationChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>projects/{project}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>projects/{project}/notificationChannels/{notification_channel}</c>.
        /// </returns>
        public static string Format(string projectId, string notificationChannelId) =>
            FormatProjectNotificationChannel(projectId, notificationChannelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>projects/{project}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>projects/{project}/notificationChannels/{notification_channel}</c>.
        /// </returns>
        public static string FormatProjectNotificationChannel(string projectId, string notificationChannelId) =>
            s_projectNotificationChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>organizations/{organization}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>organizations/{organization}/notificationChannels/{notification_channel}</c>.
        /// </returns>
        public static string FormatOrganizationNotificationChannel(string organizationId, string notificationChannelId) =>
            s_organizationNotificationChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>folders/{folder}/notificationChannels/{notification_channel}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="NotificationChannelName"/> with pattern
        /// <c>folders/{folder}/notificationChannels/{notification_channel}</c>.
        /// </returns>
        public static string FormatFolderNotificationChannel(string folderId, string notificationChannelId) =>
            s_folderNotificationChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationChannels/{notification_channel}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="notificationChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotificationChannelName"/> if successful.</returns>
        public static NotificationChannelName Parse(string notificationChannelName) => Parse(notificationChannelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationChannelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationChannels/{notification_channel}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotificationChannelName"/> if successful.</returns>
        public static NotificationChannelName Parse(string notificationChannelName, bool allowUnparsed) =>
            TryParse(notificationChannelName, allowUnparsed, out NotificationChannelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationChannels/{notification_channel}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="notificationChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationChannelName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationChannelName, out NotificationChannelName result) =>
            TryParse(notificationChannelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationChannelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item>
        /// <description><c>organizations/{organization}/notificationChannels/{notification_channel}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/notificationChannels/{notification_channel}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationChannelName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationChannelName, bool allowUnparsed, out NotificationChannelName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationChannelName, nameof(notificationChannelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNotificationChannel.TryParseName(notificationChannelName, out resourceName))
            {
                result = FromProjectNotificationChannel(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationNotificationChannel.TryParseName(notificationChannelName, out resourceName))
            {
                result = FromOrganizationNotificationChannel(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderNotificationChannel.TryParseName(notificationChannelName, out resourceName))
            {
                result = FromFolderNotificationChannel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notificationChannelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotificationChannelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string notificationChannelId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            NotificationChannelId = notificationChannelId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotificationChannelName"/> class from the component parts of
        /// pattern <c>projects/{project}/notificationChannels/{notification_channel}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationChannelId">
        /// The <c>NotificationChannel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public NotificationChannelName(string projectId, string notificationChannelId) : this(ResourceNameType.ProjectNotificationChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), notificationChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationChannelId, nameof(notificationChannelId)))
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
        /// The <c>NotificationChannel</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string NotificationChannelId { get; }

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
                case ResourceNameType.ProjectNotificationChannel: return s_projectNotificationChannel.Expand(ProjectId, NotificationChannelId);
                case ResourceNameType.OrganizationNotificationChannel: return s_organizationNotificationChannel.Expand(OrganizationId, NotificationChannelId);
                case ResourceNameType.FolderNotificationChannel: return s_folderNotificationChannel.Expand(FolderId, NotificationChannelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotificationChannelName);

        /// <inheritdoc/>
        public bool Equals(NotificationChannelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NotificationChannelName a, NotificationChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NotificationChannelName a, NotificationChannelName b) => !(a == b);
    }

    public partial class NotificationChannelDescriptor
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelDescriptorName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcmv::NotificationChannelDescriptorName NotificationChannelDescriptorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelDescriptorName.Parse(Name, allowUnparsed: true);
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
                if (gcmv::NotificationChannelDescriptorName.TryParse(Name, out gcmv::NotificationChannelDescriptorName notificationChannelDescriptor))
                {
                    return notificationChannelDescriptor;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NotificationChannel
    {
        /// <summary>
        /// <see cref="gcmv::NotificationChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::NotificationChannelName NotificationChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::NotificationChannelName.Parse(Name, allowUnparsed: true);
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
                if (gcmv::NotificationChannelName.TryParse(Name, out gcmv::NotificationChannelName notificationChannel))
                {
                    return notificationChannel;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }
}
