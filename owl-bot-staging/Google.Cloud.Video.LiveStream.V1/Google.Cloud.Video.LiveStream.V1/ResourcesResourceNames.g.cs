// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcvlv = Google.Cloud.Video.LiveStream.V1;
using sys = System;

namespace Google.Cloud.Video.LiveStream.V1
{
    /// <summary>Resource name for the <c>Input</c> resource.</summary>
    public sealed partial class InputName : gax::IResourceName, sys::IEquatable<InputName>
    {
        /// <summary>The possible contents of <see cref="InputName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/inputs/{input}</c>.
            /// </summary>
            ProjectLocationInput = 1,
        }

        private static gax::PathTemplate s_projectLocationInput = new gax::PathTemplate("projects/{project}/locations/{location}/inputs/{input}");

        /// <summary>Creates a <see cref="InputName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InputName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InputName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InputName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InputName"/> with the pattern <c>projects/{project}/locations/{location}/inputs/{input}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inputId">The <c>Input</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InputName"/> constructed from the provided ids.</returns>
        public static InputName FromProjectLocationInput(string projectId, string locationId, string inputId) =>
            new InputName(ResourceNameType.ProjectLocationInput, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inputId: gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InputName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inputs/{input}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inputId">The <c>Input</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InputName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inputs/{input}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string inputId) =>
            FormatProjectLocationInput(projectId, locationId, inputId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InputName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inputs/{input}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inputId">The <c>Input</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InputName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inputs/{input}</c>.
        /// </returns>
        public static string FormatProjectLocationInput(string projectId, string locationId, string inputId) =>
            s_projectLocationInput.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)));

        /// <summary>Parses the given resource name string into a new <see cref="InputName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/inputs/{input}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="inputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InputName"/> if successful.</returns>
        public static InputName Parse(string inputName) => Parse(inputName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InputName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/inputs/{input}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="inputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InputName"/> if successful.</returns>
        public static InputName Parse(string inputName, bool allowUnparsed) =>
            TryParse(inputName, allowUnparsed, out InputName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InputName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/inputs/{input}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="inputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InputName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inputName, out InputName result) => TryParse(inputName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InputName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/inputs/{input}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="inputName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InputName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inputName, bool allowUnparsed, out InputName result)
        {
            gax::GaxPreconditions.CheckNotNull(inputName, nameof(inputName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInput.TryParseName(inputName, out resourceName))
            {
                result = FromProjectLocationInput(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(inputName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InputName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string inputId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InputId = inputId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InputName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/inputs/{input}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inputId">The <c>Input</c> ID. Must not be <c>null</c> or empty.</param>
        public InputName(string projectId, string locationId, string inputId) : this(ResourceNameType.ProjectLocationInput, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inputId: gax::GaxPreconditions.CheckNotNullOrEmpty(inputId, nameof(inputId)))
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
        /// The <c>Input</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InputId { get; }

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
                case ResourceNameType.ProjectLocationInput: return s_projectLocationInput.Expand(ProjectId, LocationId, InputId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InputName);

        /// <inheritdoc/>
        public bool Equals(InputName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InputName a, InputName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InputName a, InputName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Channel</c> resource.</summary>
    public sealed partial class ChannelName : gax::IResourceName, sys::IEquatable<ChannelName>
    {
        /// <summary>The possible contents of <see cref="ChannelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/channels/{channel}</c>.
            /// </summary>
            ProjectLocationChannel = 1,
        }

        private static gax::PathTemplate s_projectLocationChannel = new gax::PathTemplate("projects/{project}/locations/{location}/channels/{channel}");

        /// <summary>Creates a <see cref="ChannelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChannelName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChannelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChannelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChannelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChannelName"/> constructed from the provided ids.</returns>
        public static ChannelName FromProjectLocationChannel(string projectId, string locationId, string channelId) =>
            new ChannelName(ResourceNameType.ProjectLocationChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string channelId) =>
            FormatProjectLocationChannel(projectId, locationId, channelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}</c>.
        /// </returns>
        public static string FormatProjectLocationChannel(string projectId, string locationId, string channelId) =>
            s_projectLocationChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChannelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/channels/{channel}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChannelName"/> if successful.</returns>
        public static ChannelName Parse(string channelName) => Parse(channelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/channels/{channel}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChannelName"/> if successful.</returns>
        public static ChannelName Parse(string channelName, bool allowUnparsed) =>
            TryParse(channelName, allowUnparsed, out ChannelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/channels/{channel}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelName, out ChannelName result) => TryParse(channelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/channels/{channel}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelName, bool allowUnparsed, out ChannelName result)
        {
            gax::GaxPreconditions.CheckNotNull(channelName, nameof(channelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationChannel.TryParseName(channelName, out resourceName))
            {
                result = FromProjectLocationChannel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(channelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChannelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelId = channelId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChannelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        public ChannelName(string projectId, string locationId, string channelId) : this(ResourceNameType.ProjectLocationChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)))
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
        /// The <c>Channel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ChannelId { get; }

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
                case ResourceNameType.ProjectLocationChannel: return s_projectLocationChannel.Expand(ProjectId, LocationId, ChannelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChannelName);

        /// <inheritdoc/>
        public bool Equals(ChannelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ChannelName a, ChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ChannelName a, ChannelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Event</c> resource.</summary>
    public sealed partial class EventName : gax::IResourceName, sys::IEquatable<EventName>
    {
        /// <summary>The possible contents of <see cref="EventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>.
            /// </summary>
            ProjectLocationChannelEvent = 1,
        }

        private static gax::PathTemplate s_projectLocationChannelEvent = new gax::PathTemplate("projects/{project}/locations/{location}/channels/{channel}/events/{event}");

        /// <summary>Creates a <see cref="EventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EventName"/> constructed from the provided ids.</returns>
        public static EventName FromProjectLocationChannelEvent(string projectId, string locationId, string channelId, string eventId) =>
            new EventName(ResourceNameType.ProjectLocationChannelEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string channelId, string eventId) =>
            FormatProjectLocationChannelEvent(projectId, locationId, channelId, eventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>.
        /// </returns>
        public static string FormatProjectLocationChannelEvent(string projectId, string locationId, string channelId, string eventId) =>
            s_projectLocationChannelEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>Parses the given resource name string into a new <see cref="EventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EventName"/> if successful.</returns>
        public static EventName Parse(string eventName) => Parse(eventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventName"/> if successful.</returns>
        public static EventName Parse(string eventName, bool allowUnparsed) =>
            TryParse(eventName, allowUnparsed, out EventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventName, out EventName result) => TryParse(eventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventName, bool allowUnparsed, out EventName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventName, nameof(eventName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationChannelEvent.TryParseName(eventName, out resourceName))
            {
                result = FromProjectLocationChannelEvent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelId = null, string eventId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelId = channelId;
            EventId = eventId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/events/{event}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        public EventName(string projectId, string locationId, string channelId, string eventId) : this(ResourceNameType.ProjectLocationChannelEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)))
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
        /// The <c>Channel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ChannelId { get; }

        /// <summary>
        /// The <c>Event</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EventId { get; }

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
                case ResourceNameType.ProjectLocationChannelEvent: return s_projectLocationChannelEvent.Expand(ProjectId, LocationId, ChannelId, EventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventName);

        /// <inheritdoc/>
        public bool Equals(EventName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(EventName a, EventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(EventName a, EventName b) => !(a == b);
    }

    public partial class Input
    {
        /// <summary>
        /// <see cref="gcvlv::InputName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::InputName InputName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::InputName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Channel
    {
        /// <summary>
        /// <see cref="gcvlv::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InputAttachment
    {
        /// <summary><see cref="InputName"/>-typed view over the <see cref="Input"/> resource name property.</summary>
        public InputName InputAsInputName
        {
            get => string.IsNullOrEmpty(Input) ? null : InputName.Parse(Input, allowUnparsed: true);
            set => Input = value?.ToString() ?? "";
        }
    }

    public partial class Event
    {
        /// <summary>
        /// <see cref="gcvlv::EventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::EventName EventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::EventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
