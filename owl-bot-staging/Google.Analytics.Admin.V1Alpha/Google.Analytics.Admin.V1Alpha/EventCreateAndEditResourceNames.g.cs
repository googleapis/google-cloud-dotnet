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
using gaav = Google.Analytics.Admin.V1Alpha;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Analytics.Admin.V1Alpha
{
    /// <summary>Resource name for the <c>EventCreateRule</c> resource.</summary>
    public sealed partial class EventCreateRuleName : gax::IResourceName, sys::IEquatable<EventCreateRuleName>
    {
        /// <summary>The possible contents of <see cref="EventCreateRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>.
            /// </summary>
            PropertyDataStreamEventCreateRule = 1,
        }

        private static gax::PathTemplate s_propertyDataStreamEventCreateRule = new gax::PathTemplate("properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}");

        /// <summary>Creates a <see cref="EventCreateRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventCreateRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventCreateRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventCreateRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventCreateRuleName"/> with the pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventCreateRuleId">The <c>EventCreateRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EventCreateRuleName"/> constructed from the provided ids.</returns>
        public static EventCreateRuleName FromPropertyDataStreamEventCreateRule(string propertyId, string dataStreamId, string eventCreateRuleId) =>
            new EventCreateRuleName(ResourceNameType.PropertyDataStreamEventCreateRule, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), eventCreateRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventCreateRuleId, nameof(eventCreateRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventCreateRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventCreateRuleId">The <c>EventCreateRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventCreateRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>.
        /// </returns>
        public static string Format(string propertyId, string dataStreamId, string eventCreateRuleId) =>
            FormatPropertyDataStreamEventCreateRule(propertyId, dataStreamId, eventCreateRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventCreateRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventCreateRuleId">The <c>EventCreateRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventCreateRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>.
        /// </returns>
        public static string FormatPropertyDataStreamEventCreateRule(string propertyId, string dataStreamId, string eventCreateRuleId) =>
            s_propertyDataStreamEventCreateRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventCreateRuleId, nameof(eventCreateRuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventCreateRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventCreateRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EventCreateRuleName"/> if successful.</returns>
        public static EventCreateRuleName Parse(string eventCreateRuleName) => Parse(eventCreateRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventCreateRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventCreateRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventCreateRuleName"/> if successful.</returns>
        public static EventCreateRuleName Parse(string eventCreateRuleName, bool allowUnparsed) =>
            TryParse(eventCreateRuleName, allowUnparsed, out EventCreateRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventCreateRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventCreateRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventCreateRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventCreateRuleName, out EventCreateRuleName result) =>
            TryParse(eventCreateRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventCreateRuleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventCreateRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventCreateRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventCreateRuleName, bool allowUnparsed, out EventCreateRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventCreateRuleName, nameof(eventCreateRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyDataStreamEventCreateRule.TryParseName(eventCreateRuleName, out resourceName))
            {
                result = FromPropertyDataStreamEventCreateRule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventCreateRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventCreateRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataStreamId = null, string eventCreateRuleId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataStreamId = dataStreamId;
            EventCreateRuleId = eventCreateRuleId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventCreateRuleName"/> class from the component parts of pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventCreateRules/{event_create_rule}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventCreateRuleId">The <c>EventCreateRule</c> ID. Must not be <c>null</c> or empty.</param>
        public EventCreateRuleName(string propertyId, string dataStreamId, string eventCreateRuleId) : this(ResourceNameType.PropertyDataStreamEventCreateRule, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), eventCreateRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventCreateRuleId, nameof(eventCreateRuleId)))
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
        /// The <c>DataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataStreamId { get; }

        /// <summary>
        /// The <c>EventCreateRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EventCreateRuleId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyDataStreamEventCreateRule: return s_propertyDataStreamEventCreateRule.Expand(PropertyId, DataStreamId, EventCreateRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventCreateRuleName);

        /// <inheritdoc/>
        public bool Equals(EventCreateRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventCreateRuleName a, EventCreateRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventCreateRuleName a, EventCreateRuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EventEditRule</c> resource.</summary>
    public sealed partial class EventEditRuleName : gax::IResourceName, sys::IEquatable<EventEditRuleName>
    {
        /// <summary>The possible contents of <see cref="EventEditRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>.
            /// </summary>
            PropertyDataStreamEventEditRule = 1,
        }

        private static gax::PathTemplate s_propertyDataStreamEventEditRule = new gax::PathTemplate("properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}");

        /// <summary>Creates a <see cref="EventEditRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventEditRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventEditRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventEditRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventEditRuleName"/> with the pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventEditRuleId">The <c>EventEditRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EventEditRuleName"/> constructed from the provided ids.</returns>
        public static EventEditRuleName FromPropertyDataStreamEventEditRule(string propertyId, string dataStreamId, string eventEditRuleId) =>
            new EventEditRuleName(ResourceNameType.PropertyDataStreamEventEditRule, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), eventEditRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventEditRuleId, nameof(eventEditRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventEditRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventEditRuleId">The <c>EventEditRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventEditRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>.
        /// </returns>
        public static string Format(string propertyId, string dataStreamId, string eventEditRuleId) =>
            FormatPropertyDataStreamEventEditRule(propertyId, dataStreamId, eventEditRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventEditRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventEditRuleId">The <c>EventEditRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventEditRuleName"/> with pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>.
        /// </returns>
        public static string FormatPropertyDataStreamEventEditRule(string propertyId, string dataStreamId, string eventEditRuleId) =>
            s_propertyDataStreamEventEditRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventEditRuleId, nameof(eventEditRuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventEditRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventEditRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EventEditRuleName"/> if successful.</returns>
        public static EventEditRuleName Parse(string eventEditRuleName) => Parse(eventEditRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventEditRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventEditRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventEditRuleName"/> if successful.</returns>
        public static EventEditRuleName Parse(string eventEditRuleName, bool allowUnparsed) =>
            TryParse(eventEditRuleName, allowUnparsed, out EventEditRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventEditRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventEditRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventEditRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventEditRuleName, out EventEditRuleName result) =>
            TryParse(eventEditRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventEditRuleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventEditRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventEditRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventEditRuleName, bool allowUnparsed, out EventEditRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventEditRuleName, nameof(eventEditRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyDataStreamEventEditRule.TryParseName(eventEditRuleName, out resourceName))
            {
                result = FromPropertyDataStreamEventEditRule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventEditRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventEditRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataStreamId = null, string eventEditRuleId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataStreamId = dataStreamId;
            EventEditRuleId = eventEditRuleId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventEditRuleName"/> class from the component parts of pattern
        /// <c>properties/{property}/dataStreams/{data_stream}/eventEditRules/{event_edit_rule}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStreamId">The <c>DataStream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventEditRuleId">The <c>EventEditRule</c> ID. Must not be <c>null</c> or empty.</param>
        public EventEditRuleName(string propertyId, string dataStreamId, string eventEditRuleId) : this(ResourceNameType.PropertyDataStreamEventEditRule, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), dataStreamId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStreamId, nameof(dataStreamId)), eventEditRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventEditRuleId, nameof(eventEditRuleId)))
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
        /// The <c>DataStream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataStreamId { get; }

        /// <summary>
        /// The <c>EventEditRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EventEditRuleId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyDataStreamEventEditRule: return s_propertyDataStreamEventEditRule.Expand(PropertyId, DataStreamId, EventEditRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventEditRuleName);

        /// <inheritdoc/>
        public bool Equals(EventEditRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventEditRuleName a, EventEditRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventEditRuleName a, EventEditRuleName b) => !(a == b);
    }

    public partial class EventCreateRule
    {
        /// <summary>
        /// <see cref="gaav::EventCreateRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::EventCreateRuleName EventCreateRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EventCreateRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EventEditRule
    {
        /// <summary>
        /// <see cref="gaav::EventEditRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::EventEditRuleName EventEditRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::EventEditRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
