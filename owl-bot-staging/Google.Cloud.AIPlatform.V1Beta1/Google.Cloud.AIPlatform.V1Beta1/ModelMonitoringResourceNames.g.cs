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
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
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
        }

        private static gax::PathTemplate s_projectNotificationChannel = new gax::PathTemplate("projects/{project}/notificationChannels/{notification_channel}");

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
        /// Parses the given resource name string into a new <see cref="NotificationChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/notificationChannels/{notification_channel}</c></description>
        /// </item>
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

        private NotificationChannelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string notificationChannelId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NotificationChannelId = notificationChannelId;
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
        /// The <c>NotificationChannel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string NotificationChannelId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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

    public partial class ModelMonitoringObjectiveConfig
    {
        public partial class Types
        {
            public partial class TrainingDataset
            {
                /// <summary>
                /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
                /// </summary>
                public DatasetName DatasetAsDatasetName
                {
                    get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
                    set => Dataset = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ModelMonitoringAlertConfig
    {
        /// <summary>
        /// <see cref="NotificationChannelName"/>-typed view over the <see cref="NotificationChannels"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<NotificationChannelName> NotificationChannelsAsNotificationChannelNames
        {
            get => new gax::ResourceNameList<NotificationChannelName>(NotificationChannels, s => string.IsNullOrEmpty(s) ? null : NotificationChannelName.Parse(s, allowUnparsed: true));
        }
    }
}
