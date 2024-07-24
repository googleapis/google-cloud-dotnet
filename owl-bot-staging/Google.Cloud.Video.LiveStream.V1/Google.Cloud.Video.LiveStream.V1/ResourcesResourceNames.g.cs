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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InputName a, InputName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChannelName a, ChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventName a, EventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventName a, EventName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Clip</c> resource.</summary>
    public sealed partial class ClipName : gax::IResourceName, sys::IEquatable<ClipName>
    {
        /// <summary>The possible contents of <see cref="ClipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>
            /// .
            /// </summary>
            ProjectLocationChannelClip = 1,
        }

        private static gax::PathTemplate s_projectLocationChannelClip = new gax::PathTemplate("projects/{project}/locations/{location}/channels/{channel}/clips/{clip}");

        /// <summary>Creates a <see cref="ClipName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClipName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClipName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clipId">The <c>Clip</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClipName"/> constructed from the provided ids.</returns>
        public static ClipName FromProjectLocationChannelClip(string projectId, string locationId, string channelId, string clipId) =>
            new ClipName(ResourceNameType.ProjectLocationChannelClip, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), clipId: gax::GaxPreconditions.CheckNotNullOrEmpty(clipId, nameof(clipId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clipId">The <c>Clip</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string channelId, string clipId) =>
            FormatProjectLocationChannelClip(projectId, locationId, channelId, clipId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clipId">The <c>Clip</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>.
        /// </returns>
        public static string FormatProjectLocationChannelClip(string projectId, string locationId, string channelId, string clipId) =>
            s_projectLocationChannelClip.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clipId, nameof(clipId)));

        /// <summary>Parses the given resource name string into a new <see cref="ClipName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="clipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClipName"/> if successful.</returns>
        public static ClipName Parse(string clipName) => Parse(clipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClipName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClipName"/> if successful.</returns>
        public static ClipName Parse(string clipName, bool allowUnparsed) =>
            TryParse(clipName, allowUnparsed, out ClipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ClipName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="clipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clipName, out ClipName result) => TryParse(clipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClipName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clipName, bool allowUnparsed, out ClipName result)
        {
            gax::GaxPreconditions.CheckNotNull(clipName, nameof(clipName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationChannelClip.TryParseName(clipName, out resourceName))
            {
                result = FromProjectLocationChannelClip(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelId = null, string clipId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelId = channelId;
            ClipId = clipId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClipName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/channels/{channel}/clips/{clip}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clipId">The <c>Clip</c> ID. Must not be <c>null</c> or empty.</param>
        public ClipName(string projectId, string locationId, string channelId, string clipId) : this(ResourceNameType.ProjectLocationChannelClip, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), clipId: gax::GaxPreconditions.CheckNotNullOrEmpty(clipId, nameof(clipId)))
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
        /// The <c>Clip</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClipId { get; }

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
                case ResourceNameType.ProjectLocationChannelClip: return s_projectLocationChannelClip.Expand(ProjectId, LocationId, ChannelId, ClipId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClipName);

        /// <inheritdoc/>
        public bool Equals(ClipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ClipName a, ClipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ClipName a, ClipName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Asset</c> resource.</summary>
    public sealed partial class AssetName : gax::IResourceName, sys::IEquatable<AssetName>
    {
        /// <summary>The possible contents of <see cref="AssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/assets/{asset}</c>.
            /// </summary>
            ProjectLocationAsset = 1,
        }

        private static gax::PathTemplate s_projectLocationAsset = new gax::PathTemplate("projects/{project}/locations/{location}/assets/{asset}");

        /// <summary>Creates a <see cref="AssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetName"/> with the pattern <c>projects/{project}/locations/{location}/assets/{asset}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetName"/> constructed from the provided ids.</returns>
        public static AssetName FromProjectLocationAsset(string projectId, string locationId, string assetId) =>
            new AssetName(ResourceNameType.ProjectLocationAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string assetId) =>
            FormatProjectLocationAsset(projectId, locationId, assetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>.
        /// </returns>
        public static string FormatProjectLocationAsset(string projectId, string locationId, string assetId) =>
            s_projectLocationAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName) => Parse(assetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName, bool allowUnparsed) =>
            TryParse(assetName, allowUnparsed, out AssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, out AssetName result) => TryParse(assetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/assets/{asset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, bool allowUnparsed, out AssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAsset.TryParseName(assetName, out resourceName))
            {
                result = FromProjectLocationAsset(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/assets/{asset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetName(string projectId, string locationId, string assetId) : this(ResourceNameType.ProjectLocationAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))
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
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

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
                case ResourceNameType.ProjectLocationAsset: return s_projectLocationAsset.Expand(ProjectId, LocationId, AssetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetName);

        /// <inheritdoc/>
        public bool Equals(AssetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetName a, AssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetName a, AssetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Pool</c> resource.</summary>
    public sealed partial class PoolName : gax::IResourceName, sys::IEquatable<PoolName>
    {
        /// <summary>The possible contents of <see cref="PoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/pools/{pool}</c>.
            /// </summary>
            ProjectLocationPool = 1,
        }

        private static gax::PathTemplate s_projectLocationPool = new gax::PathTemplate("projects/{project}/locations/{location}/pools/{pool}");

        /// <summary>Creates a <see cref="PoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PoolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PoolName"/> with the pattern <c>projects/{project}/locations/{location}/pools/{pool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="poolId">The <c>Pool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PoolName"/> constructed from the provided ids.</returns>
        public static PoolName FromProjectLocationPool(string projectId, string locationId, string poolId) =>
            new PoolName(ResourceNameType.ProjectLocationPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), poolId: gax::GaxPreconditions.CheckNotNullOrEmpty(poolId, nameof(poolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pools/{pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="poolId">The <c>Pool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pools/{pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string poolId) =>
            FormatProjectLocationPool(projectId, locationId, poolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pools/{pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="poolId">The <c>Pool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pools/{pool}</c>.
        /// </returns>
        public static string FormatProjectLocationPool(string projectId, string locationId, string poolId) =>
            s_projectLocationPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(poolId, nameof(poolId)));

        /// <summary>Parses the given resource name string into a new <see cref="PoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pools/{pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="poolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PoolName"/> if successful.</returns>
        public static PoolName Parse(string poolName) => Parse(poolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PoolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pools/{pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="poolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PoolName"/> if successful.</returns>
        public static PoolName Parse(string poolName, bool allowUnparsed) =>
            TryParse(poolName, allowUnparsed, out PoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="PoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pools/{pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="poolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string poolName, out PoolName result) => TryParse(poolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pools/{pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="poolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string poolName, bool allowUnparsed, out PoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(poolName, nameof(poolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPool.TryParseName(poolName, out resourceName))
            {
                result = FromProjectLocationPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(poolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string poolId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PoolId = poolId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/pools/{pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="poolId">The <c>Pool</c> ID. Must not be <c>null</c> or empty.</param>
        public PoolName(string projectId, string locationId, string poolId) : this(ResourceNameType.ProjectLocationPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), poolId: gax::GaxPreconditions.CheckNotNullOrEmpty(poolId, nameof(poolId)))
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
        /// The <c>Pool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PoolId { get; }

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
                case ResourceNameType.ProjectLocationPool: return s_projectLocationPool.Expand(ProjectId, LocationId, PoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PoolName);

        /// <inheritdoc/>
        public bool Equals(PoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PoolName a, PoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PoolName a, PoolName b) => !(a == b);
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

    public partial class StaticOverlay
    {
        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        public AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
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

        public partial class Types
        {
            public partial class SlateTask
            {
                /// <summary>
                /// <see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.
                /// </summary>
                public AssetName AssetAsAssetName
                {
                    get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
                    set => Asset = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Clip
    {
        /// <summary>
        /// <see cref="gcvlv::ClipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::ClipName ClipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::ClipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Asset
    {
        /// <summary>
        /// <see cref="gcvlv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Encryption
    {
        public partial class Types
        {
            public partial class SecretManagerSource
            {
                /// <summary>
                /// <see cref="SecretVersionName"/>-typed view over the <see cref="SecretVersion"/> resource name
                /// property.
                /// </summary>
                public SecretVersionName SecretVersionAsSecretVersionName
                {
                    get => string.IsNullOrEmpty(SecretVersion) ? null : SecretVersionName.Parse(SecretVersion, allowUnparsed: true);
                    set => SecretVersion = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Pool
    {
        /// <summary>
        /// <see cref="gcvlv::PoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvlv::PoolName PoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvlv::PoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class NetworkConfig
            {
                /// <summary>
                /// <see cref="NetworkName"/>-typed view over the <see cref="PeeredNetwork"/> resource name property.
                /// </summary>
                public NetworkName PeeredNetworkAsNetworkName
                {
                    get => string.IsNullOrEmpty(PeeredNetwork) ? null : NetworkName.Parse(PeeredNetwork, allowUnparsed: true);
                    set => PeeredNetwork = value?.ToString() ?? "";
                }
            }
        }
    }
}
