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
    /// <summary>Resource name for the <c>BackupPlanBinding</c> resource.</summary>
    public sealed partial class BackupPlanBindingName : gax::IResourceName, sys::IEquatable<BackupPlanBindingName>
    {
        /// <summary>The possible contents of <see cref="BackupPlanBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
            /// .
            /// </summary>
            ProjectLocationBackupChannelBackupPlanBinding = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupChannelBackupPlanBinding = new gax::PathTemplate("projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}");

        /// <summary>Creates a <see cref="BackupPlanBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupPlanBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupPlanBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupPlanBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupPlanBindingName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanBindingId">The <c>BackupPlanBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupPlanBindingName"/> constructed from the provided ids.</returns>
        public static BackupPlanBindingName FromProjectLocationBackupChannelBackupPlanBinding(string projectId, string locationId, string backupChannelId, string backupPlanBindingId) =>
            new BackupPlanBindingName(ResourceNameType.ProjectLocationBackupChannelBackupPlanBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupChannelId, nameof(backupChannelId)), backupPlanBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanBindingId, nameof(backupPlanBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanBindingId">The <c>BackupPlanBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string backupChannelId, string backupPlanBindingId) =>
            FormatProjectLocationBackupChannelBackupPlanBinding(projectId, locationId, backupChannelId, backupPlanBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanBindingId">The <c>BackupPlanBinding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationBackupChannelBackupPlanBinding(string projectId, string locationId, string backupChannelId, string backupPlanBindingId) =>
            s_projectLocationBackupChannelBackupPlanBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupChannelId, nameof(backupChannelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanBindingId, nameof(backupPlanBindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupPlanBindingName"/> if successful.</returns>
        public static BackupPlanBindingName Parse(string backupPlanBindingName) => Parse(backupPlanBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupPlanBindingName"/> if successful.</returns>
        public static BackupPlanBindingName Parse(string backupPlanBindingName, bool allowUnparsed) =>
            TryParse(backupPlanBindingName, allowUnparsed, out BackupPlanBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanBindingName, out BackupPlanBindingName result) =>
            TryParse(backupPlanBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanBindingName, bool allowUnparsed, out BackupPlanBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupPlanBindingName, nameof(backupPlanBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupChannelBackupPlanBinding.TryParseName(backupPlanBindingName, out resourceName))
            {
                result = FromProjectLocationBackupChannelBackupPlanBinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupPlanBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupPlanBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupChannelId = null, string backupPlanBindingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupChannelId = backupChannelId;
            BackupPlanBindingId = backupPlanBindingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupPlanBindingName"/> class from the component parts of pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/backupChannels/{backup_channel}/backupPlanBindings/{backup_plan_binding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupChannelId">The <c>BackupChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanBindingId">The <c>BackupPlanBinding</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupPlanBindingName(string projectId, string locationId, string backupChannelId, string backupPlanBindingId) : this(ResourceNameType.ProjectLocationBackupChannelBackupPlanBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupChannelId, nameof(backupChannelId)), backupPlanBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanBindingId, nameof(backupPlanBindingId)))
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
        /// The <c>BackupPlanBinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BackupPlanBindingId { get; }

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
                case ResourceNameType.ProjectLocationBackupChannelBackupPlanBinding: return s_projectLocationBackupChannelBackupPlanBinding.Expand(ProjectId, LocationId, BackupChannelId, BackupPlanBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupPlanBindingName);

        /// <inheritdoc/>
        public bool Equals(BackupPlanBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupPlanBindingName a, BackupPlanBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupPlanBindingName a, BackupPlanBindingName b) => !(a == b);
    }

    public partial class BackupPlanBinding
    {
        /// <summary>
        /// <see cref="gcgv::BackupPlanBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::BackupPlanBindingName BackupPlanBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::BackupPlanBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupPlanName"/>-typed view over the <see cref="BackupPlan"/> resource name property.
        /// </summary>
        public BackupPlanName BackupPlanAsBackupPlanName
        {
            get => string.IsNullOrEmpty(BackupPlan) ? null : BackupPlanName.Parse(BackupPlan, allowUnparsed: true);
            set => BackupPlan = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Cluster"/> resource name property.
        /// </summary>
        public ClusterName ClusterAsClusterName
        {
            get => string.IsNullOrEmpty(Cluster) ? null : ClusterName.Parse(Cluster, allowUnparsed: true);
            set => Cluster = value?.ToString() ?? "";
        }
    }
}
