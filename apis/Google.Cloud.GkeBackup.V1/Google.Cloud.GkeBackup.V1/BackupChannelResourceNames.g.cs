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
using gcgv = Google.Cloud.GkeBackup.V1;
using sys = System;

namespace Google.Cloud.GkeBackup.V1
{
    /// <summary>Resource name for the <c>BackupChannel</c> resource.</summary>
    public sealed partial class BackupChannelName : gax::IResourceName, sys::IEquatable<BackupChannelName>
    {
        /// <summary>The possible contents of <see cref="BackupChannelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>
            /// .
            /// </summary>
            ProjectLocationBackupChannel = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupChannel = new gax::PathTemplate("projects/{project}/locations/{location}/backupChannels/{backup_channel}");

        /// <summary>Creates a <see cref="BackupChannelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupChannelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupChannelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupChannelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupChannelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupChannelName"/> constructed from the provided ids.</returns>
        public static BackupChannelName FromProjectLocationBackupChannel(string projectId, string locationId, string backupChannelId) =>
            new BackupChannelName(ResourceNameType.ProjectLocationBackupChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupChannelId, nameof(backupChannelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupChannelId) =>
            FormatProjectLocationBackupChannel(projectId, locationId, backupChannelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupChannel(string projectId, string locationId, string backupChannelId) =>
            s_projectLocationBackupChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupChannelId, nameof(backupChannelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupChannelName"/> if successful.</returns>
        public static BackupChannelName Parse(string backupChannelName) => Parse(backupChannelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupChannelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupChannelName"/> if successful.</returns>
        public static BackupChannelName Parse(string backupChannelName, bool allowUnparsed) =>
            TryParse(backupChannelName, allowUnparsed, out BackupChannelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupChannelName, out BackupChannelName result) =>
            TryParse(backupChannelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupChannelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupChannelName, bool allowUnparsed, out BackupChannelName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupChannelName, nameof(backupChannelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupChannel.TryParseName(backupChannelName, out resourceName))
            {
                result = FromProjectLocationBackupChannel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupChannelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupChannelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupChannelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupChannelId = backupChannelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupChannelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backupChannels/{backup_channel}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupChannelName(string projectId, string locationId, string backupChannelId) : this(ResourceNameType.ProjectLocationBackupChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupChannelId, nameof(backupChannelId)))
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
        /// The <c>BackupChannel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BackupChannelId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationBackupChannel: return s_projectLocationBackupChannel.Expand(ProjectId, LocationId, BackupChannelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupChannelName);

        /// <inheritdoc/>
        public bool Equals(BackupChannelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupChannelName a, BackupChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupChannelName a, BackupChannelName b) => !(a == b);
    }

    public partial class BackupChannel
    {
        /// <summary>
        /// <see cref="gcgv::BackupChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::BackupChannelName BackupChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::BackupChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
