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
using gcev = Google.Cloud.Eventarc.V1;
using sys = System;

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Resource name for the <c>ChannelConnection</c> resource.</summary>
    public sealed partial class ChannelConnectionName : gax::IResourceName, sys::IEquatable<ChannelConnectionName>
    {
        /// <summary>The possible contents of <see cref="ChannelConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>.
            /// </summary>
            ProjectLocationChannelConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationChannelConnection = new gax::PathTemplate("projects/{project}/locations/{location}/channelConnections/{channel_connection}");

        /// <summary>Creates a <see cref="ChannelConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChannelConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChannelConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChannelConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChannelConnectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelConnectionId">The <c>ChannelConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChannelConnectionName"/> constructed from the provided ids.</returns>
        public static ChannelConnectionName FromProjectLocationChannelConnection(string projectId, string locationId, string channelConnectionId) =>
            new ChannelConnectionName(ResourceNameType.ProjectLocationChannelConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelConnectionId">The <c>ChannelConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string channelConnectionId) =>
            FormatProjectLocationChannelConnection(projectId, locationId, channelConnectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelConnectionId">The <c>ChannelConnection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>.
        /// </returns>
        public static string FormatProjectLocationChannelConnection(string projectId, string locationId, string channelConnectionId) =>
            s_projectLocationChannelConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="channelConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChannelConnectionName"/> if successful.</returns>
        public static ChannelConnectionName Parse(string channelConnectionName) => Parse(channelConnectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChannelConnectionName"/> if successful.</returns>
        public static ChannelConnectionName Parse(string channelConnectionName, bool allowUnparsed) =>
            TryParse(channelConnectionName, allowUnparsed, out ChannelConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="channelConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelConnectionName, out ChannelConnectionName result) =>
            TryParse(channelConnectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelConnectionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelConnectionName, bool allowUnparsed, out ChannelConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(channelConnectionName, nameof(channelConnectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationChannelConnection.TryParseName(channelConnectionName, out resourceName))
            {
                result = FromProjectLocationChannelConnection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(channelConnectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChannelConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelConnectionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelConnectionId = channelConnectionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChannelConnectionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/channelConnections/{channel_connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelConnectionId">The <c>ChannelConnection</c> ID. Must not be <c>null</c> or empty.</param>
        public ChannelConnectionName(string projectId, string locationId, string channelConnectionId) : this(ResourceNameType.ProjectLocationChannelConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelConnectionId, nameof(channelConnectionId)))
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
        /// The <c>ChannelConnection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ChannelConnectionId { get; }

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
                case ResourceNameType.ProjectLocationChannelConnection: return s_projectLocationChannelConnection.Expand(ProjectId, LocationId, ChannelConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChannelConnectionName);

        /// <inheritdoc/>
        public bool Equals(ChannelConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChannelConnectionName a, ChannelConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChannelConnectionName a, ChannelConnectionName b) => !(a == b);
    }

    public partial class ChannelConnection
    {
        /// <summary>
        /// <see cref="gcev::ChannelConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::ChannelConnectionName ChannelConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::ChannelConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ChannelName"/>-typed view over the <see cref="Channel"/> resource name property.
        /// </summary>
        public ChannelName ChannelAsChannelName
        {
            get => string.IsNullOrEmpty(Channel) ? null : ChannelName.Parse(Channel, allowUnparsed: true);
            set => Channel = value?.ToString() ?? "";
        }
    }
}
