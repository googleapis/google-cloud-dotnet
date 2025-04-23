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
    /// <summary>Resource name for the <c>RestoreChannel</c> resource.</summary>
    public sealed partial class RestoreChannelName : gax::IResourceName, sys::IEquatable<RestoreChannelName>
    {
        /// <summary>The possible contents of <see cref="RestoreChannelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>.
            /// </summary>
            ProjectLocationRestoreChannel = 1,
        }

        private static gax::PathTemplate s_projectLocationRestoreChannel = new gax::PathTemplate("projects/{project}/locations/{location}/restoreChannels/{restore_channel}");

        /// <summary>Creates a <see cref="RestoreChannelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RestoreChannelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RestoreChannelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RestoreChannelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RestoreChannelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RestoreChannelName"/> constructed from the provided ids.</returns>
        public static RestoreChannelName FromProjectLocationRestoreChannel(string projectId, string locationId, string restoreChannelId) =>
            new RestoreChannelName(ResourceNameType.ProjectLocationRestoreChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restoreChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreChannelId, nameof(restoreChannelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestoreChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestoreChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string restoreChannelId) =>
            FormatProjectLocationRestoreChannel(projectId, locationId, restoreChannelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RestoreChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RestoreChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>.
        /// </returns>
        public static string FormatProjectLocationRestoreChannel(string projectId, string locationId, string restoreChannelId) =>
            s_projectLocationRestoreChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(restoreChannelId, nameof(restoreChannelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestoreChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restoreChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RestoreChannelName"/> if successful.</returns>
        public static RestoreChannelName Parse(string restoreChannelName) => Parse(restoreChannelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RestoreChannelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restoreChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RestoreChannelName"/> if successful.</returns>
        public static RestoreChannelName Parse(string restoreChannelName, bool allowUnparsed) =>
            TryParse(restoreChannelName, allowUnparsed, out RestoreChannelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestoreChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="restoreChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestoreChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restoreChannelName, out RestoreChannelName result) =>
            TryParse(restoreChannelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RestoreChannelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="restoreChannelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RestoreChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string restoreChannelName, bool allowUnparsed, out RestoreChannelName result)
        {
            gax::GaxPreconditions.CheckNotNull(restoreChannelName, nameof(restoreChannelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRestoreChannel.TryParseName(restoreChannelName, out resourceName))
            {
                result = FromProjectLocationRestoreChannel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(restoreChannelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RestoreChannelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string restoreChannelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RestoreChannelId = restoreChannelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RestoreChannelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/restoreChannels/{restore_channel}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="restoreChannelId">The <c>RestoreChannel</c> ID. Must not be <c>null</c> or empty.</param>
        public RestoreChannelName(string projectId, string locationId, string restoreChannelId) : this(ResourceNameType.ProjectLocationRestoreChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), restoreChannelId: gax::GaxPreconditions.CheckNotNullOrEmpty(restoreChannelId, nameof(restoreChannelId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRestoreChannel: return s_projectLocationRestoreChannel.Expand(ProjectId, LocationId, RestoreChannelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RestoreChannelName);

        /// <inheritdoc/>
        public bool Equals(RestoreChannelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RestoreChannelName a, RestoreChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RestoreChannelName a, RestoreChannelName b) => !(a == b);
    }

    public partial class RestoreChannel
    {
        /// <summary>
        /// <see cref="gcgv::RestoreChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RestoreChannelName RestoreChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RestoreChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
