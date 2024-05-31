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
using gamv = Google.Apps.Meet.V2Beta;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Apps.Meet.V2Beta
{
    /// <summary>Resource name for the <c>Space</c> resource.</summary>
    public sealed partial class SpaceName : gax::IResourceName, sys::IEquatable<SpaceName>
    {
        /// <summary>The possible contents of <see cref="SpaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>spaces/{space}</c>.</summary>
            Space = 1,
        }

        private static gax::PathTemplate s_space = new gax::PathTemplate("spaces/{space}");

        /// <summary>Creates a <see cref="SpaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SpaceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SpaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SpaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="SpaceName"/> with the pattern <c>spaces/{space}</c>.</summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SpaceName"/> constructed from the provided ids.</returns>
        public static SpaceName FromSpace(string spaceId) =>
            new SpaceName(ResourceNameType.Space, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpaceName"/> with pattern
        /// <c>spaces/{space}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpaceName"/> with pattern <c>spaces/{space}</c>.
        /// </returns>
        public static string Format(string spaceId) => FormatSpace(spaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpaceName"/> with pattern
        /// <c>spaces/{space}</c>.
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpaceName"/> with pattern <c>spaces/{space}</c>.
        /// </returns>
        public static string FormatSpace(string spaceId) =>
            s_space.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="SpaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}</c></description></item></list>
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpaceName"/> if successful.</returns>
        public static SpaceName Parse(string spaceName) => Parse(spaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpaceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SpaceName"/> if successful.</returns>
        public static SpaceName Parse(string spaceName, bool allowUnparsed) =>
            TryParse(spaceName, allowUnparsed, out SpaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}</c></description></item></list>
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spaceName, out SpaceName result) => TryParse(spaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>spaces/{space}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spaceName, bool allowUnparsed, out SpaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(spaceName, nameof(spaceName));
            gax::TemplatedResourceName resourceName;
            if (s_space.TryParseName(spaceName, out resourceName))
            {
                result = FromSpace(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(spaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SpaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SpaceName"/> class from the component parts of pattern
        /// <c>spaces/{space}</c>
        /// </summary>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        public SpaceName(string spaceId) : this(ResourceNameType.Space, spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)))
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
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Space: return s_space.Expand(SpaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpaceName);

        /// <inheritdoc/>
        public bool Equals(SpaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SpaceName a, SpaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SpaceName a, SpaceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ConferenceRecord</c> resource.</summary>
    public sealed partial class ConferenceRecordName : gax::IResourceName, sys::IEquatable<ConferenceRecordName>
    {
        /// <summary>The possible contents of <see cref="ConferenceRecordName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>conferenceRecords/{conference_record}</c>.</summary>
            ConferenceRecord = 1,
        }

        private static gax::PathTemplate s_conferenceRecord = new gax::PathTemplate("conferenceRecords/{conference_record}");

        /// <summary>Creates a <see cref="ConferenceRecordName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConferenceRecordName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConferenceRecordName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConferenceRecordName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConferenceRecordName"/> with the pattern <c>conferenceRecords/{conference_record}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConferenceRecordName"/> constructed from the provided ids.</returns>
        public static ConferenceRecordName FromConferenceRecord(string conferenceRecordId) =>
            new ConferenceRecordName(ResourceNameType.ConferenceRecord, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConferenceRecordName"/> with pattern
        /// <c>conferenceRecords/{conference_record}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConferenceRecordName"/> with pattern
        /// <c>conferenceRecords/{conference_record}</c>.
        /// </returns>
        public static string Format(string conferenceRecordId) => FormatConferenceRecord(conferenceRecordId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConferenceRecordName"/> with pattern
        /// <c>conferenceRecords/{conference_record}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConferenceRecordName"/> with pattern
        /// <c>conferenceRecords/{conference_record}</c>.
        /// </returns>
        public static string FormatConferenceRecord(string conferenceRecordId) =>
            s_conferenceRecord.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConferenceRecordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conferenceRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConferenceRecordName"/> if successful.</returns>
        public static ConferenceRecordName Parse(string conferenceRecordName) => Parse(conferenceRecordName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConferenceRecordName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conferenceRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConferenceRecordName"/> if successful.</returns>
        public static ConferenceRecordName Parse(string conferenceRecordName, bool allowUnparsed) =>
            TryParse(conferenceRecordName, allowUnparsed, out ConferenceRecordName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConferenceRecordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conferenceRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConferenceRecordName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conferenceRecordName, out ConferenceRecordName result) =>
            TryParse(conferenceRecordName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConferenceRecordName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conferenceRecordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConferenceRecordName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conferenceRecordName, bool allowUnparsed, out ConferenceRecordName result)
        {
            gax::GaxPreconditions.CheckNotNull(conferenceRecordName, nameof(conferenceRecordName));
            gax::TemplatedResourceName resourceName;
            if (s_conferenceRecord.TryParseName(conferenceRecordName, out resourceName))
            {
                result = FromConferenceRecord(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conferenceRecordName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConferenceRecordName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conferenceRecordId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConferenceRecordId = conferenceRecordId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConferenceRecordName"/> class from the component parts of pattern
        /// <c>conferenceRecords/{conference_record}</c>
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        public ConferenceRecordName(string conferenceRecordId) : this(ResourceNameType.ConferenceRecord, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)))
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
        /// The <c>ConferenceRecord</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConferenceRecordId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ConferenceRecord: return s_conferenceRecord.Expand(ConferenceRecordId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConferenceRecordName);

        /// <inheritdoc/>
        public bool Equals(ConferenceRecordName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConferenceRecordName a, ConferenceRecordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConferenceRecordName a, ConferenceRecordName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Participant</c> resource.</summary>
    public sealed partial class ParticipantName : gax::IResourceName, sys::IEquatable<ParticipantName>
    {
        /// <summary>The possible contents of <see cref="ParticipantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>conferenceRecords/{conference_record}/participants/{participant}</c>.
            /// </summary>
            ConferenceRecordParticipant = 1,
        }

        private static gax::PathTemplate s_conferenceRecordParticipant = new gax::PathTemplate("conferenceRecords/{conference_record}/participants/{participant}");

        /// <summary>Creates a <see cref="ParticipantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParticipantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParticipantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParticipantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParticipantName"/> with the pattern
        /// <c>conferenceRecords/{conference_record}/participants/{participant}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ParticipantName"/> constructed from the provided ids.</returns>
        public static ParticipantName FromConferenceRecordParticipant(string conferenceRecordId, string participantId) =>
            new ParticipantName(ResourceNameType.ConferenceRecordParticipant, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/participants/{participant}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/participants/{participant}</c>.
        /// </returns>
        public static string Format(string conferenceRecordId, string participantId) =>
            FormatConferenceRecordParticipant(conferenceRecordId, participantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/participants/{participant}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/participants/{participant}</c>.
        /// </returns>
        public static string FormatConferenceRecordParticipant(string conferenceRecordId, string participantId) =>
            s_conferenceRecordParticipant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)));

        /// <summary>Parses the given resource name string into a new <see cref="ParticipantName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/participants/{participant}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParticipantName"/> if successful.</returns>
        public static ParticipantName Parse(string participantName) => Parse(participantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParticipantName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/participants/{participant}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParticipantName"/> if successful.</returns>
        public static ParticipantName Parse(string participantName, bool allowUnparsed) =>
            TryParse(participantName, allowUnparsed, out ParticipantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/participants/{participant}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantName, out ParticipantName result) =>
            TryParse(participantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/participants/{participant}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantName, bool allowUnparsed, out ParticipantName result)
        {
            gax::GaxPreconditions.CheckNotNull(participantName, nameof(participantName));
            gax::TemplatedResourceName resourceName;
            if (s_conferenceRecordParticipant.TryParseName(participantName, out resourceName))
            {
                result = FromConferenceRecordParticipant(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(participantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParticipantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conferenceRecordId = null, string participantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConferenceRecordId = conferenceRecordId;
            ParticipantId = participantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParticipantName"/> class from the component parts of pattern
        /// <c>conferenceRecords/{conference_record}/participants/{participant}</c>
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        public ParticipantName(string conferenceRecordId, string participantId) : this(ResourceNameType.ConferenceRecordParticipant, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)))
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
        /// The <c>ConferenceRecord</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConferenceRecordId { get; }

        /// <summary>
        /// The <c>Participant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ParticipantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ConferenceRecordParticipant: return s_conferenceRecordParticipant.Expand(ConferenceRecordId, ParticipantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParticipantName);

        /// <inheritdoc/>
        public bool Equals(ParticipantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ParticipantName a, ParticipantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ParticipantName a, ParticipantName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ParticipantSession</c> resource.</summary>
    public sealed partial class ParticipantSessionName : gax::IResourceName, sys::IEquatable<ParticipantSessionName>
    {
        /// <summary>The possible contents of <see cref="ParticipantSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
            /// .
            /// </summary>
            ConferenceRecordParticipantParticipantSession = 1,
        }

        private static gax::PathTemplate s_conferenceRecordParticipantParticipantSession = new gax::PathTemplate("conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}");

        /// <summary>Creates a <see cref="ParticipantSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParticipantSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParticipantSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParticipantSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParticipantSessionName"/> with the pattern
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// .
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantSessionId">
        /// The <c>ParticipantSession</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="ParticipantSessionName"/> constructed from the provided ids.</returns>
        public static ParticipantSessionName FromConferenceRecordParticipantParticipantSession(string conferenceRecordId, string participantId, string participantSessionId) =>
            new ParticipantSessionName(ResourceNameType.ConferenceRecordParticipantParticipantSession, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)), participantSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantSessionId, nameof(participantSessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantSessionName"/> with pattern
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// .
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantSessionId">
        /// The <c>ParticipantSession</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantSessionName"/> with pattern
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// .
        /// </returns>
        public static string Format(string conferenceRecordId, string participantId, string participantSessionId) =>
            FormatConferenceRecordParticipantParticipantSession(conferenceRecordId, participantId, participantSessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParticipantSessionName"/> with pattern
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// .
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantSessionId">
        /// The <c>ParticipantSession</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ParticipantSessionName"/> with pattern
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// .
        /// </returns>
        public static string FormatConferenceRecordParticipantParticipantSession(string conferenceRecordId, string participantId, string participantSessionId) =>
            s_conferenceRecordParticipantParticipantSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)), gax::GaxPreconditions.CheckNotNullOrEmpty(participantSessionId, nameof(participantSessionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParticipantSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParticipantSessionName"/> if successful.</returns>
        public static ParticipantSessionName Parse(string participantSessionName) => Parse(participantSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParticipantSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParticipantSessionName"/> if successful.</returns>
        public static ParticipantSessionName Parse(string participantSessionName, bool allowUnparsed) =>
            TryParse(participantSessionName, allowUnparsed, out ParticipantSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="participantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantSessionName, out ParticipantSessionName result) =>
            TryParse(participantSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParticipantSessionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="participantSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParticipantSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string participantSessionName, bool allowUnparsed, out ParticipantSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(participantSessionName, nameof(participantSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_conferenceRecordParticipantParticipantSession.TryParseName(participantSessionName, out resourceName))
            {
                result = FromConferenceRecordParticipantParticipantSession(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(participantSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParticipantSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conferenceRecordId = null, string participantId = null, string participantSessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConferenceRecordId = conferenceRecordId;
            ParticipantId = participantId;
            ParticipantSessionId = participantSessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParticipantSessionName"/> class from the component parts of
        /// pattern
        /// <c>
        /// conferenceRecords/{conference_record}/participants/{participant}/participantSessions/{participant_session}</c>
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantId">The <c>Participant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="participantSessionId">
        /// The <c>ParticipantSession</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ParticipantSessionName(string conferenceRecordId, string participantId, string participantSessionId) : this(ResourceNameType.ConferenceRecordParticipantParticipantSession, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), participantId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantId, nameof(participantId)), participantSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(participantSessionId, nameof(participantSessionId)))
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
        /// The <c>ConferenceRecord</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConferenceRecordId { get; }

        /// <summary>
        /// The <c>Participant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ParticipantId { get; }

        /// <summary>
        /// The <c>ParticipantSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ParticipantSessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ConferenceRecordParticipantParticipantSession: return s_conferenceRecordParticipantParticipantSession.Expand(ConferenceRecordId, ParticipantId, ParticipantSessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParticipantSessionName);

        /// <inheritdoc/>
        public bool Equals(ParticipantSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ParticipantSessionName a, ParticipantSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ParticipantSessionName a, ParticipantSessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Recording</c> resource.</summary>
    public sealed partial class RecordingName : gax::IResourceName, sys::IEquatable<RecordingName>
    {
        /// <summary>The possible contents of <see cref="RecordingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>conferenceRecords/{conference_record}/recordings/{recording}</c>.
            /// </summary>
            ConferenceRecordRecording = 1,
        }

        private static gax::PathTemplate s_conferenceRecordRecording = new gax::PathTemplate("conferenceRecords/{conference_record}/recordings/{recording}");

        /// <summary>Creates a <see cref="RecordingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecordingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecordingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecordingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecordingName"/> with the pattern
        /// <c>conferenceRecords/{conference_record}/recordings/{recording}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecordingName"/> constructed from the provided ids.</returns>
        public static RecordingName FromConferenceRecordRecording(string conferenceRecordId, string recordingId) =>
            new RecordingName(ResourceNameType.ConferenceRecordRecording, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), recordingId: gax::GaxPreconditions.CheckNotNullOrEmpty(recordingId, nameof(recordingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecordingName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/recordings/{recording}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecordingName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/recordings/{recording}</c>.
        /// </returns>
        public static string Format(string conferenceRecordId, string recordingId) =>
            FormatConferenceRecordRecording(conferenceRecordId, recordingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecordingName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/recordings/{recording}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecordingName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/recordings/{recording}</c>.
        /// </returns>
        public static string FormatConferenceRecordRecording(string conferenceRecordId, string recordingId) =>
            s_conferenceRecordRecording.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recordingId, nameof(recordingId)));

        /// <summary>Parses the given resource name string into a new <see cref="RecordingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}/recordings/{recording}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecordingName"/> if successful.</returns>
        public static RecordingName Parse(string recordingName) => Parse(recordingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecordingName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}/recordings/{recording}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecordingName"/> if successful.</returns>
        public static RecordingName Parse(string recordingName, bool allowUnparsed) =>
            TryParse(recordingName, allowUnparsed, out RecordingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecordingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}/recordings/{recording}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecordingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recordingName, out RecordingName result) => TryParse(recordingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecordingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>conferenceRecords/{conference_record}/recordings/{recording}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recordingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecordingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recordingName, bool allowUnparsed, out RecordingName result)
        {
            gax::GaxPreconditions.CheckNotNull(recordingName, nameof(recordingName));
            gax::TemplatedResourceName resourceName;
            if (s_conferenceRecordRecording.TryParseName(recordingName, out resourceName))
            {
                result = FromConferenceRecordRecording(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recordingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecordingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conferenceRecordId = null, string recordingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConferenceRecordId = conferenceRecordId;
            RecordingId = recordingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecordingName"/> class from the component parts of pattern
        /// <c>conferenceRecords/{conference_record}/recordings/{recording}</c>
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recordingId">The <c>Recording</c> ID. Must not be <c>null</c> or empty.</param>
        public RecordingName(string conferenceRecordId, string recordingId) : this(ResourceNameType.ConferenceRecordRecording, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), recordingId: gax::GaxPreconditions.CheckNotNullOrEmpty(recordingId, nameof(recordingId)))
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
        /// The <c>ConferenceRecord</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConferenceRecordId { get; }

        /// <summary>
        /// The <c>Recording</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RecordingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ConferenceRecordRecording: return s_conferenceRecordRecording.Expand(ConferenceRecordId, RecordingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecordingName);

        /// <inheritdoc/>
        public bool Equals(RecordingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RecordingName a, RecordingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RecordingName a, RecordingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Transcript</c> resource.</summary>
    public sealed partial class TranscriptName : gax::IResourceName, sys::IEquatable<TranscriptName>
    {
        /// <summary>The possible contents of <see cref="TranscriptName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>.
            /// </summary>
            ConferenceRecordTranscript = 1,
        }

        private static gax::PathTemplate s_conferenceRecordTranscript = new gax::PathTemplate("conferenceRecords/{conference_record}/transcripts/{transcript}");

        /// <summary>Creates a <see cref="TranscriptName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TranscriptName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TranscriptName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TranscriptName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TranscriptName"/> with the pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TranscriptName"/> constructed from the provided ids.</returns>
        public static TranscriptName FromConferenceRecordTranscript(string conferenceRecordId, string transcriptId) =>
            new TranscriptName(ResourceNameType.ConferenceRecordTranscript, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), transcriptId: gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptId, nameof(transcriptId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TranscriptName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TranscriptName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>.
        /// </returns>
        public static string Format(string conferenceRecordId, string transcriptId) =>
            FormatConferenceRecordTranscript(conferenceRecordId, transcriptId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TranscriptName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TranscriptName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>.
        /// </returns>
        public static string FormatConferenceRecordTranscript(string conferenceRecordId, string transcriptId) =>
            s_conferenceRecordTranscript.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptId, nameof(transcriptId)));

        /// <summary>Parses the given resource name string into a new <see cref="TranscriptName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/transcripts/{transcript}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transcriptName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TranscriptName"/> if successful.</returns>
        public static TranscriptName Parse(string transcriptName) => Parse(transcriptName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TranscriptName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/transcripts/{transcript}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transcriptName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TranscriptName"/> if successful.</returns>
        public static TranscriptName Parse(string transcriptName, bool allowUnparsed) =>
            TryParse(transcriptName, allowUnparsed, out TranscriptName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TranscriptName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/transcripts/{transcript}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transcriptName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TranscriptName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transcriptName, out TranscriptName result) =>
            TryParse(transcriptName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TranscriptName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>conferenceRecords/{conference_record}/transcripts/{transcript}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transcriptName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TranscriptName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transcriptName, bool allowUnparsed, out TranscriptName result)
        {
            gax::GaxPreconditions.CheckNotNull(transcriptName, nameof(transcriptName));
            gax::TemplatedResourceName resourceName;
            if (s_conferenceRecordTranscript.TryParseName(transcriptName, out resourceName))
            {
                result = FromConferenceRecordTranscript(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(transcriptName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TranscriptName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conferenceRecordId = null, string transcriptId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConferenceRecordId = conferenceRecordId;
            TranscriptId = transcriptId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TranscriptName"/> class from the component parts of pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}</c>
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        public TranscriptName(string conferenceRecordId, string transcriptId) : this(ResourceNameType.ConferenceRecordTranscript, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), transcriptId: gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptId, nameof(transcriptId)))
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
        /// The <c>ConferenceRecord</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConferenceRecordId { get; }

        /// <summary>
        /// The <c>Transcript</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TranscriptId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ConferenceRecordTranscript: return s_conferenceRecordTranscript.Expand(ConferenceRecordId, TranscriptId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TranscriptName);

        /// <inheritdoc/>
        public bool Equals(TranscriptName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TranscriptName a, TranscriptName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TranscriptName a, TranscriptName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TranscriptEntry</c> resource.</summary>
    public sealed partial class TranscriptEntryName : gax::IResourceName, sys::IEquatable<TranscriptEntryName>
    {
        /// <summary>The possible contents of <see cref="TranscriptEntryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>.
            /// </summary>
            ConferenceRecordTranscriptEntry = 1,
        }

        private static gax::PathTemplate s_conferenceRecordTranscriptEntry = new gax::PathTemplate("conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}");

        /// <summary>Creates a <see cref="TranscriptEntryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TranscriptEntryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TranscriptEntryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TranscriptEntryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TranscriptEntryName"/> with the pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TranscriptEntryName"/> constructed from the provided ids.</returns>
        public static TranscriptEntryName FromConferenceRecordTranscriptEntry(string conferenceRecordId, string transcriptId, string entryId) =>
            new TranscriptEntryName(ResourceNameType.ConferenceRecordTranscriptEntry, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), transcriptId: gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptId, nameof(transcriptId)), entryId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TranscriptEntryName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TranscriptEntryName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>.
        /// </returns>
        public static string Format(string conferenceRecordId, string transcriptId, string entryId) =>
            FormatConferenceRecordTranscriptEntry(conferenceRecordId, transcriptId, entryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TranscriptEntryName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>.
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TranscriptEntryName"/> with pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>.
        /// </returns>
        public static string FormatConferenceRecordTranscriptEntry(string conferenceRecordId, string transcriptId, string entryId) =>
            s_conferenceRecordTranscriptEntry.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptId, nameof(transcriptId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TranscriptEntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transcriptEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TranscriptEntryName"/> if successful.</returns>
        public static TranscriptEntryName Parse(string transcriptEntryName) => Parse(transcriptEntryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TranscriptEntryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transcriptEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TranscriptEntryName"/> if successful.</returns>
        public static TranscriptEntryName Parse(string transcriptEntryName, bool allowUnparsed) =>
            TryParse(transcriptEntryName, allowUnparsed, out TranscriptEntryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TranscriptEntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transcriptEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TranscriptEntryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transcriptEntryName, out TranscriptEntryName result) =>
            TryParse(transcriptEntryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TranscriptEntryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transcriptEntryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TranscriptEntryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transcriptEntryName, bool allowUnparsed, out TranscriptEntryName result)
        {
            gax::GaxPreconditions.CheckNotNull(transcriptEntryName, nameof(transcriptEntryName));
            gax::TemplatedResourceName resourceName;
            if (s_conferenceRecordTranscriptEntry.TryParseName(transcriptEntryName, out resourceName))
            {
                result = FromConferenceRecordTranscriptEntry(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(transcriptEntryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TranscriptEntryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conferenceRecordId = null, string entryId = null, string transcriptId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConferenceRecordId = conferenceRecordId;
            EntryId = entryId;
            TranscriptId = transcriptId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TranscriptEntryName"/> class from the component parts of pattern
        /// <c>conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}</c>
        /// </summary>
        /// <param name="conferenceRecordId">The <c>ConferenceRecord</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transcriptId">The <c>Transcript</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        public TranscriptEntryName(string conferenceRecordId, string transcriptId, string entryId) : this(ResourceNameType.ConferenceRecordTranscriptEntry, conferenceRecordId: gax::GaxPreconditions.CheckNotNullOrEmpty(conferenceRecordId, nameof(conferenceRecordId)), transcriptId: gax::GaxPreconditions.CheckNotNullOrEmpty(transcriptId, nameof(transcriptId)), entryId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)))
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
        /// The <c>ConferenceRecord</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConferenceRecordId { get; }

        /// <summary>
        /// The <c>Entry</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntryId { get; }

        /// <summary>
        /// The <c>Transcript</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TranscriptId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ConferenceRecordTranscriptEntry: return s_conferenceRecordTranscriptEntry.Expand(ConferenceRecordId, TranscriptId, EntryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TranscriptEntryName);

        /// <inheritdoc/>
        public bool Equals(TranscriptEntryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TranscriptEntryName a, TranscriptEntryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TranscriptEntryName a, TranscriptEntryName b) => !(a == b);
    }

    public partial class Space
    {
        /// <summary>
        /// <see cref="gamv::SpaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::SpaceName SpaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::SpaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ActiveConference
    {
        /// <summary>
        /// <see cref="ConferenceRecordName"/>-typed view over the <see cref="ConferenceRecord"/> resource name
        /// property.
        /// </summary>
        public ConferenceRecordName ConferenceRecordAsConferenceRecordName
        {
            get => string.IsNullOrEmpty(ConferenceRecord) ? null : ConferenceRecordName.Parse(ConferenceRecord, allowUnparsed: true);
            set => ConferenceRecord = value?.ToString() ?? "";
        }
    }

    public partial class ConferenceRecord
    {
        /// <summary>
        /// <see cref="gamv::ConferenceRecordName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::ConferenceRecordName ConferenceRecordName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::ConferenceRecordName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Space"/> resource name property.</summary>
        public SpaceName SpaceAsSpaceName
        {
            get => string.IsNullOrEmpty(Space) ? null : SpaceName.Parse(Space, allowUnparsed: true);
            set => Space = value?.ToString() ?? "";
        }
    }

    public partial class Participant
    {
        /// <summary>
        /// <see cref="gamv::ParticipantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::ParticipantName ParticipantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::ParticipantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ParticipantSession
    {
        /// <summary>
        /// <see cref="gamv::ParticipantSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::ParticipantSessionName ParticipantSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::ParticipantSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Recording
    {
        /// <summary>
        /// <see cref="gamv::RecordingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::RecordingName RecordingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::RecordingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Transcript
    {
        /// <summary>
        /// <see cref="gamv::TranscriptName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::TranscriptName TranscriptName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::TranscriptName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TranscriptEntry
    {
        /// <summary>
        /// <see cref="gamv::TranscriptEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamv::TranscriptEntryName TranscriptEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamv::TranscriptEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ParticipantName"/>-typed view over the <see cref="Participant"/> resource name property.
        /// </summary>
        public ParticipantName ParticipantAsParticipantName
        {
            get => string.IsNullOrEmpty(Participant) ? null : ParticipantName.Parse(Participant, allowUnparsed: true);
            set => Participant = value?.ToString() ?? "";
        }
    }
}
