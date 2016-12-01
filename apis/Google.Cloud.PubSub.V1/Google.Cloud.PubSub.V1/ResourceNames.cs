// Copyright 2016, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : IResourceName, IEquatable<ProjectName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses a project resource name in string form into a <see cref="ProjectName"/>.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse project resource name in string form into a <see cref="ProjectName"/>/
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a project name from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'subscription' resource.
    /// </summary>
    public sealed partial class SubscriptionName : IResourceName, IEquatable<SubscriptionName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>
        /// Parses a subscription resource name in string form into a <see cref="SubscriptionName"/>.
        /// </summary>
        /// <param name="subscriptionName">The subscription resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName)
        {
            GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            TemplatedResourceName resourceName = s_template.ParseName(subscriptionName);
            return new SubscriptionName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse subscription resource name in string form into a <see cref="SubscriptionName"/>/
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="subscriptionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="subscriptionName">The subscription resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SubscriptionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, out SubscriptionName result)
        {
            GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(subscriptionName, out resourceName))
            {
                result = new SubscriptionName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a subscription name from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="subscriptionId">The subscription ID. Must not be <c>null</c>.</param>
        public SubscriptionName(string projectId, string subscriptionId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SubscriptionId = GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The subscription ID. Never <c>null</c>.
        /// </summary>
        public string SubscriptionId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SubscriptionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SubscriptionName);

        /// <inheritdoc />
        public bool Equals(SubscriptionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SubscriptionName a, SubscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SubscriptionName a, SubscriptionName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'topic' resource.
    /// </summary>
    public sealed partial class TopicName : IResourceName, IEquatable<TopicName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>
        /// Parses a topic resource name in string form into a <see cref="TopicName"/>.
        /// </summary>
        /// <param name="topicName">The topic resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName)
        {
            GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            TemplatedResourceName resourceName = s_template.ParseName(topicName);
            return new TopicName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse topic resource name in string form into a <see cref="TopicName"/>/
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="topicName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="topicName">The topic resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TopicName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result)
        {
            GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(topicName, out resourceName))
            {
                result = new TopicName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a topic name from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="topicId">The topic ID. Must not be <c>null</c>.</param>
        public TopicName(string projectId, string topicId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TopicId = GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The topic ID. Never <c>null</c>.
        /// </summary>
        public string TopicId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TopicId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc />
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>TopicName: A resource of type 'topic'.</description></item>
    /// <item><description>DeletedTopicNameFixed: A resource of type 'deleted_topic'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class TopicNameOneof : IResourceName, IEquatable<TopicNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="TopicNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'topic'.
            /// </summary>
            TopicName = 1,

            /// <summary>
            /// A resource of type 'deleted_topic'.
            /// </summary>
            DeletedTopicNameFixed = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a <see cref="TopicNameOneof"/>.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>TopicName: A resource of type 'topic'.</description></item>
        /// <item><description>DeletedTopicNameFixed: A resource of type 'deleted_topic'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <returns>The parsed <see cref="TopicNameOneof"/> if successful.</returns>
        public static TopicNameOneof Parse(string name, bool allowUnknown)
        {
            TopicNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a <see cref="TopicNameOneof"/>.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>TopicName: A resource of type 'topic'.</description></item>
        /// <item><description>DeletedTopicNameFixed: A resource of type 'deleted_topic'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TopicNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out TopicNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            TopicName topicName;
            if (TopicName.TryParse(name, out topicName))
            {
                result = new TopicNameOneof(OneofType.TopicName, topicName);
                return true;
            }
            DeletedTopicNameFixed deletedTopicNameFixed;
            if (DeletedTopicNameFixed.TryParse(name, out deletedTopicNameFixed))
            {
                result = new TopicNameOneof(OneofType.DeletedTopicNameFixed, deletedTopicNameFixed);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new TopicNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct an instance of <see cref="TopicNameOneof"/> from the provided <see cref="TopicName"/>
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to be contained within
        /// the returned <see cref="TopicNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TopicNameOneof"/>, containing <paramref name="topicName"/>.</returns>
        public static TopicNameOneof From(TopicName topicName) => new TopicNameOneof(OneofType.TopicName, topicName);

        /// <summary>
        /// Construct an instance of <see cref="TopicNameOneof"/> from the provided <see cref="DeletedTopicNameFixed"/>
        /// </summary>
        /// <param name="deletedTopicNameFixed">The <see cref="DeletedTopicNameFixed"/> to be contained within
        /// the returned <see cref="TopicNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TopicNameOneof"/>, containing <paramref name="deletedTopicNameFixed"/>.</returns>
        public static TopicNameOneof From(DeletedTopicNameFixed deletedTopicNameFixed) => new TopicNameOneof(OneofType.DeletedTopicNameFixed, deletedTopicNameFixed);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.TopicName: return name is TopicName;
                case OneofType.DeletedTopicNameFixed: return name is DeletedTopicNameFixed;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a {resource.docName} resource name from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public TopicNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="TopicName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="TopicName"/>.
        /// </remarks>
        public TopicName TopicName => CheckAndReturn<TopicName>(OneofType.TopicName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="DeletedTopicNameFixed"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="DeletedTopicNameFixed"/>.
        /// </remarks>
        public DeletedTopicNameFixed DeletedTopicNameFixed => CheckAndReturn<DeletedTopicNameFixed>(OneofType.DeletedTopicNameFixed);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TopicNameOneof);

        /// <inheritdoc />
        public bool Equals(TopicNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TopicNameOneof a, TopicNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TopicNameOneof a, TopicNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name to represent the fixed string "_deleted-topic_".
    /// </summary>
    public sealed partial class DeletedTopicNameFixed : IResourceName, IEquatable<DeletedTopicNameFixed>
    {
        /// <summary>
        /// The fixed string value: "_deleted-topic_".
        /// </summary>
        public const string FixedValue = "_deleted-topic_";

        /// <summary>
        /// An instance of <see cref="DeletedTopicNameFixed"/>.
        /// </summary>
        public static DeletedTopicNameFixed Instance => new DeletedTopicNameFixed();

        /// <summary>
        /// Parses a string into a <see cref="DeletedTopicNameFixed"/>.
        /// Only succeeds if the string is equal to "_deleted-topic_".
        /// </summary>
        public static DeletedTopicNameFixed Parse(string deletedTopicNameFixed)
        {
            DeletedTopicNameFixed result;
            if (!TryParse(deletedTopicNameFixed, out result))
            {
                throw new ArgumentException($"Invalid resource name, must be \"{FixedValue}\"", nameof(deletedTopicNameFixed));
            }
            return result;
        }

        /// <summary>
        /// Tries to parses a string into a <see cref="DeletedTopicNameFixed"/>.
        /// Only succeeds if the string is equal to "_deleted-topic_".
        /// </summary>
        public static bool TryParse(string deletedTopicNameFixed, out DeletedTopicNameFixed result)
        {
            GaxPreconditions.CheckNotNull(deletedTopicNameFixed, nameof(deletedTopicNameFixed));
            if (deletedTopicNameFixed == FixedValue)
            {
                result = Instance;
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        private DeletedTopicNameFixed() { }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Fixed;

        /// <inheritdoc />
        public override string ToString() => FixedValue;

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DeletedTopicNameFixed);

        /// <inheritdoc />
        public bool Equals(DeletedTopicNameFixed other) => other != null;

        /// <inheritdoc />
        public static bool operator ==(DeletedTopicNameFixed a, DeletedTopicNameFixed b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DeletedTopicNameFixed a, DeletedTopicNameFixed b) => !(a == b);
    }


    public partial class AcknowledgeRequest
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get { return SubscriptionName.Parse(Subscription); }
            set { Subscription = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class DeleteSubscriptionRequest
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get { return SubscriptionName.Parse(Subscription); }
            set { Subscription = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class DeleteTopicRequest
    {
        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
        /// </summary>
        public TopicName TopicAsTopicName
        {
            get { return TopicName.Parse(Topic); }
            set { Topic = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class GetSubscriptionRequest
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get { return SubscriptionName.Parse(Subscription); }
            set { Subscription = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class GetTopicRequest
    {
        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
        /// </summary>
        public TopicName TopicAsTopicName
        {
            get { return TopicName.Parse(Topic); }
            set { Topic = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class ListSubscriptionsRequest
    {
        /// <summary>
        /// A <see cref="ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public ProjectName ProjectAsProjectName
        {
            get { return ProjectName.Parse(Project); }
            set { Project = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class ListTopicSubscriptionsRequest
    {
        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
        /// </summary>
        public TopicName TopicAsTopicName
        {
            get { return TopicName.Parse(Topic); }
            set { Topic = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class ListTopicSubscriptionsResponse
    {
        /// <summary>
        /// A <see cref="IList{SubscriptionName}"/>-typed view over the <see cref="Subscriptions"/> resource name property.
        /// </summary>
        public IList<SubscriptionName> SubscriptionsAsSubscriptionNames =>
            new ResourceNameList<SubscriptionName>(Subscriptions,
                str => SubscriptionName.Parse(str));

    }

    public partial class ListTopicsRequest
    {
        /// <summary>
        /// A <see cref="ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public ProjectName ProjectAsProjectName
        {
            get { return ProjectName.Parse(Project); }
            set { Project = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class ModifyAckDeadlineRequest
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get { return SubscriptionName.Parse(Subscription); }
            set { Subscription = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class ModifyPushConfigRequest
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get { return SubscriptionName.Parse(Subscription); }
            set { Subscription = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class PublishRequest
    {
        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
        /// </summary>
        public TopicName TopicAsTopicName
        {
            get { return TopicName.Parse(Topic); }
            set { Topic = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class PullRequest
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get { return SubscriptionName.Parse(Subscription); }
            set { Subscription = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class Subscription
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionName
        {
            get { return SubscriptionName.Parse(Name); }
            set { Name = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

        /// <summary>
        /// A <see cref="TopicNameOneof"/>-typed view over the <see cref="Topic"/> resource name property.
        /// </summary>
        public TopicNameOneof TopicAsTopicNameOneof
        {
            get { return TopicNameOneof.Parse(Topic, true); }
            set { Topic = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

    public partial class Topic
    {
        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TopicName TopicName
        {
            get { return TopicName.Parse(Name); }
            set { Name = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

    }

}