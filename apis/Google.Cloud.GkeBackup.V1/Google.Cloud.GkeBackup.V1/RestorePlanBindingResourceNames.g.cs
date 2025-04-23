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
    /// <summary>Resource name for the <c>RestorePlanBinding</c> resource.</summary>
    public sealed partial class RestorePlanBindingName : gax::IResourceName, sys::IEquatable<RestorePlanBindingName>
    {
        /// <summary>The possible contents of <see cref="RestorePlanBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
            /// .
            /// </summary>
            ProjectLocationRestoreChannelRestorePlanBinding = 1,
        }

        private static gax::PathTemplate s_projectLocationRestoreChannelRestorePlanBinding = new gax::PathTemplate("projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}");

        /// <summary>Creates a <see cref="RestorePlanBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RestorePlanBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RestorePlanBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RestorePlanBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RestorePlanBindingName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanBindingId">
        /// The <c>RestorePlanBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="RestorePlanBindingName"/> constructed from the provided ids.</returns>
        public static RestorePlanBindingName FromProjectLocationRestoreChannelRestorePlanBinding(string projectId, string locationId, string restoreChannelId, string restorePlanBindingId) =>
            new RestorePlanBindingName(ResourceNameType.ProjectLocationRestoreChannelRestorePlanBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restoreChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreChannelId, nameof(restoreChannelId)), restorePlanBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanBindingId, nameof(restorePlanBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestorePlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanBindingId">
        /// The <c>RestorePlanBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RestorePlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string restoreChannelId, string restorePlanBindingId) =>
            FormatProjectLocationRestoreChannelRestorePlanBinding(projectId, locationId, restoreChannelId, restorePlanBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestorePlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanBindingId">
        /// The <c>RestorePlanBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RestorePlanBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRestoreChannelRestorePlanBinding(string projectId, string locationId, string restoreChannelId, string restorePlanBindingId) =>
            s_projectLocationRestoreChannelRestorePlanBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restoreChannelId, nameof(restoreChannelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanBindingId, nameof(restorePlanBindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestorePlanBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restorePlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RestorePlanBindingName"/> if successful.</returns>
        public static RestorePlanBindingName Parse(string restorePlanBindingName) => Parse(restorePlanBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestorePlanBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restorePlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RestorePlanBindingName"/> if successful.</returns>
        public static RestorePlanBindingName Parse(string restorePlanBindingName, bool allowUnparsed) =>
            TryParse(restorePlanBindingName, allowUnparsed, out RestorePlanBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestorePlanBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restorePlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestorePlanBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restorePlanBindingName, out RestorePlanBindingName result) =>
            TryParse(restorePlanBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestorePlanBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restorePlanBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestorePlanBindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restorePlanBindingName, bool allowUnparsed, out RestorePlanBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(restorePlanBindingName, nameof(restorePlanBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRestoreChannelRestorePlanBinding.TryParseName(restorePlanBindingName, out resourceName))
            {
                result = FromProjectLocationRestoreChannelRestorePlanBinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(restorePlanBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RestorePlanBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string restoreChannelId = null, string restorePlanBindingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RestoreChannelId = restoreChannelId;
            RestorePlanBindingId = restorePlanBindingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RestorePlanBindingName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/restoreChannels/{restore_channel}/restorePlanBindings/{restore_plan_binding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restorePlanBindingId">
        /// The <c>RestorePlanBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public RestorePlanBindingName(string projectId, string locationId, string restoreChannelId, string restorePlanBindingId) : this(ResourceNameType.ProjectLocationRestoreChannelRestorePlanBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restoreChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreChannelId, nameof(restoreChannelId)), restorePlanBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanBindingId, nameof(restorePlanBindingId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>RestoreChannel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RestoreChannelId { get; }

        /// <summary>
        /// The <c>RestorePlanBinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string RestorePlanBindingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRestoreChannelRestorePlanBinding: return s_projectLocationRestoreChannelRestorePlanBinding.Expand(ProjectId, LocationId, RestoreChannelId, RestorePlanBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RestorePlanBindingName);

        /// <inheritdoc/>
        public bool Equals(RestorePlanBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RestorePlanBindingName a, RestorePlanBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RestorePlanBindingName a, RestorePlanBindingName b) => !(a == b);
    }

    public partial class RestorePlanBinding
    {
        /// <summary>
        /// <see cref="gcgv::RestorePlanBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RestorePlanBindingName RestorePlanBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RestorePlanBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RestorePlanName"/>-typed view over the <see cref="RestorePlan"/> resource name property.
        /// </summary>
        public RestorePlanName RestorePlanAsRestorePlanName
        {
            get => string.IsNullOrEmpty(RestorePlan) ? null : RestorePlanName.Parse(RestorePlan, allowUnparsed: true);
            set => RestorePlan = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupPlanName"/>-typed view over the <see cref="BackupPlan"/> resource name property.
        /// </summary>
        public BackupPlanName BackupPlanAsBackupPlanName
        {
            get => string.IsNullOrEmpty(BackupPlan) ? null : BackupPlanName.Parse(BackupPlan, allowUnparsed: true);
            set => BackupPlan = value?.ToString() ?? "";
        }
    }
}
