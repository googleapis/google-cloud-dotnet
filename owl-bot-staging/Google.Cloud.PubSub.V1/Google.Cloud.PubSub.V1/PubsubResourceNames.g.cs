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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcpv = Google.Cloud.PubSub.V1;
using sys = System;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        /// <summary>The possible contents of <see cref="TopicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/topics/{topic}</c>.</summary>
            ProjectTopic = 1,

            /// <summary>A resource name with pattern <c>_deleted-topic_</c>.</summary>
            DeletedTopic = 2,
        }

        private static gax::PathTemplate s_projectTopic = new gax::PathTemplate("projects/{project}/topics/{topic}");

        private static gax::PathTemplate s_deletedTopic = new gax::PathTemplate("_deleted-topic_");

        /// <summary>Creates a <see cref="TopicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicName"/> with the pattern <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromProjectTopic(string projectId, string topicId) =>
            new TopicName(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>Creates a <see cref="TopicName"/> with the pattern <c>_deleted-topic_</c>.</summary>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromDeletedTopic() => new TopicName(ResourceNameType.DeletedTopic);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string topicId) => FormatProjectTopic(projectId, topicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string FormatProjectTopic(string projectId, string topicId) =>
            s_projectTopic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>_deleted-topic_</c>.
        /// </summary>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>_deleted-topic_</c>.
        /// </returns>
        public static string FormatDeletedTopic() => s_deletedTopic.Expand();

        /// <summary>Parses the given resource name string into a new <see cref="TopicName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/topics/{topic}</c></description></item>
        /// <item><description><c>_deleted-topic_</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName) => Parse(topicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/topics/{topic}</c></description></item>
        /// <item><description><c>_deleted-topic_</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName, bool allowUnparsed) =>
            TryParse(topicName, allowUnparsed, out TopicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/topics/{topic}</c></description></item>
        /// <item><description><c>_deleted-topic_</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result) => TryParse(topicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/topics/{topic}</c></description></item>
        /// <item><description><c>_deleted-topic_</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, bool allowUnparsed, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTopic.TryParseName(topicName, out resourceName))
            {
                result = FromProjectTopic(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_deletedTopic.TryParseName(topicName, out resourceName))
            {
                result = FromDeletedTopic();
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string topicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TopicId = topicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicName"/> class from the component parts of pattern
        /// <c>projects/{project}/topics/{topic}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicName(string projectId, string topicId) : this(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)))
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
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Topic</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string TopicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTopic: return s_projectTopic.Expand(ProjectId, TopicId);
                case ResourceNameType.DeletedTopic: return s_deletedTopic.Expand();
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subscription</c> resource.</summary>
    public sealed partial class SubscriptionName : gax::IResourceName, sys::IEquatable<SubscriptionName>
    {
        /// <summary>The possible contents of <see cref="SubscriptionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/subscriptions/{subscription}</c>.</summary>
            ProjectSubscription = 1,
        }

        private static gax::PathTemplate s_projectSubscription = new gax::PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>Creates a <see cref="SubscriptionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubscriptionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubscriptionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubscriptionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubscriptionName"/> with the pattern <c>projects/{project}/subscriptions/{subscription}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubscriptionName"/> constructed from the provided ids.</returns>
        public static SubscriptionName FromProjectSubscription(string projectId, string subscriptionId) =>
            new SubscriptionName(ResourceNameType.ProjectSubscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), subscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </returns>
        public static string Format(string projectId, string subscriptionId) =>
            FormatProjectSubscription(projectId, subscriptionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </returns>
        public static string FormatProjectSubscription(string projectId, string subscriptionId) =>
            s_projectSubscription.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubscriptionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName) => Parse(subscriptionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName, bool allowUnparsed) =>
            TryParse(subscriptionName, allowUnparsed, out SubscriptionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, out SubscriptionName result) =>
            TryParse(subscriptionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, bool allowUnparsed, out SubscriptionName result)
        {
            gax::GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSubscription.TryParseName(subscriptionName, out resourceName))
            {
                result = FromProjectSubscription(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subscriptionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubscriptionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string subscriptionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubscriptionName"/> class from the component parts of pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        public SubscriptionName(string projectId, string subscriptionId) : this(ResourceNameType.ProjectSubscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), subscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subscription</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SubscriptionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSubscription: return s_projectSubscription.Expand(ProjectId, SubscriptionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubscriptionName);

        /// <inheritdoc/>
        public bool Equals(SubscriptionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubscriptionName a, SubscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubscriptionName a, SubscriptionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Snapshot</c> resource.</summary>
    public sealed partial class SnapshotName : gax::IResourceName, sys::IEquatable<SnapshotName>
    {
        /// <summary>The possible contents of <see cref="SnapshotName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/snapshots/{snapshot}</c>.</summary>
            ProjectSnapshot = 1,
        }

        private static gax::PathTemplate s_projectSnapshot = new gax::PathTemplate("projects/{project}/snapshots/{snapshot}");

        /// <summary>Creates a <see cref="SnapshotName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SnapshotName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SnapshotName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SnapshotName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SnapshotName"/> with the pattern <c>projects/{project}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SnapshotName"/> constructed from the provided ids.</returns>
        public static SnapshotName FromProjectSnapshot(string projectId, string snapshotId) =>
            new SnapshotName(ResourceNameType.ProjectSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string Format(string projectId, string snapshotId) => FormatProjectSnapshot(projectId, snapshotId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SnapshotName"/> with pattern
        /// <c>projects/{project}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string FormatProjectSnapshot(string projectId, string snapshotId) =>
            s_projectSnapshot.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>Parses the given resource name string into a new <see cref="SnapshotName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SnapshotName"/> if successful.</returns>
        public static SnapshotName Parse(string snapshotName) => Parse(snapshotName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SnapshotName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SnapshotName"/> if successful.</returns>
        public static SnapshotName Parse(string snapshotName, bool allowUnparsed) =>
            TryParse(snapshotName, allowUnparsed, out SnapshotName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotName, out SnapshotName result) => TryParse(snapshotName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SnapshotName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/snapshots/{snapshot}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="snapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotName, bool allowUnparsed, out SnapshotName result)
        {
            gax::GaxPreconditions.CheckNotNull(snapshotName, nameof(snapshotName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSnapshot.TryParseName(snapshotName, out resourceName))
            {
                result = FromProjectSnapshot(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(snapshotName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SnapshotName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string snapshotId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SnapshotId = snapshotId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SnapshotName"/> class from the component parts of pattern
        /// <c>projects/{project}/snapshots/{snapshot}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        public SnapshotName(string projectId, string snapshotId) : this(ResourceNameType.ProjectSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Snapshot</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SnapshotId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSnapshot: return s_projectSnapshot.Expand(ProjectId, SnapshotId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SnapshotName);

        /// <inheritdoc/>
        public bool Equals(SnapshotName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SnapshotName a, SnapshotName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SnapshotName a, SnapshotName b) => !(a == b);
    }

    public partial class SchemaSettings
    {
        /// <summary><see cref="SchemaName"/>-typed view over the <see cref="Schema"/> resource name property.</summary>
        public SchemaName SchemaAsSchemaName
        {
            get => string.IsNullOrEmpty(Schema) ? null : SchemaName.Parse(Schema, allowUnparsed: true);
            set => Schema = value?.ToString() ?? "";
        }
    }

    public partial class Topic
    {
        /// <summary>
        /// <see cref="gcpv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetTopicRequest
    {
        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class PublishRequest
    {
        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class ListTopicsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class ListTopicSubscriptionsRequest
    {
        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class ListTopicSubscriptionsResponse
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscriptions"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<SubscriptionName> SubscriptionsAsSubscriptionNames
        {
            get => new gax::ResourceNameList<SubscriptionName>(Subscriptions, s => string.IsNullOrEmpty(s) ? null : SubscriptionName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListTopicSnapshotsRequest
    {
        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTopicRequest
    {
        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class DetachSubscriptionRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class Subscription
    {
        /// <summary>
        /// <see cref="gcpv::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class GetSubscriptionRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class ListSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSubscriptionRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class ModifyPushConfigRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class PullRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class ModifyAckDeadlineRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class AcknowledgeRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class StreamingPullRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class CreateSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcpv::SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SnapshotName SnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }
    }

    public partial class Snapshot
    {
        /// <summary>
        /// <see cref="gcpv::SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SnapshotName SnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }
    }

    public partial class GetSnapshotRequest
    {
        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Snapshot"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotAsSnapshotName
        {
            get => string.IsNullOrEmpty(Snapshot) ? null : SnapshotName.Parse(Snapshot, allowUnparsed: true);
            set => Snapshot = value?.ToString() ?? "";
        }
    }

    public partial class ListSnapshotsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSnapshotRequest
    {
        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Snapshot"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotAsSnapshotName
        {
            get => string.IsNullOrEmpty(Snapshot) ? null : SnapshotName.Parse(Snapshot, allowUnparsed: true);
            set => Snapshot = value?.ToString() ?? "";
        }
    }

    public partial class SeekRequest
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Snapshot"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotAsSnapshotName
        {
            get => string.IsNullOrEmpty(Snapshot) ? null : SnapshotName.Parse(Snapshot, allowUnparsed: true);
            set => Snapshot = value?.ToString() ?? "";
        }
    }
}
