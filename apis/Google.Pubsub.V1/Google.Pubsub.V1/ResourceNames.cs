// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;

namespace Google.Pubsub.V1
{
    // Resource name classes. Questions still to decide:
    // - Should we support service-qualified resource names? If so, how?
    // - Should we expose the PathTemplate?
    // - Should we have an interface so that APIs which take "any resource name" can do so?
    // - Should these be structs instead?

    /// <summary>
    /// Resource name for a project.
    /// </summary>
    public sealed class ProjectName
    {
        // TODO: Expose this?
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");
        
        /// <summary>
        /// The project ID. Never null.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// Constructs a project name from a project ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// Parses a project resource name in string form into a <see cref="ProjectName"/>.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be null.</param>
        /// <returns>A parsed <see cref="ProjectName"/>.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            var resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);
    }

    /// <summary>
    /// Resource name for a subscription.
    /// </summary>
    public sealed class SubscriptionName
    {
        // TODO: What about service-qualified resource names? Should we actually just keep a reference to a ResourceName?

        // TODO: Expose this?
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>
        /// The project ID. Never null.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The subscription ID. Never null.
        /// </summary>
        public string SubscriptionId { get; }

        /// <summary>
        /// Constructs a project name from a project ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="subscriptionId">The project ID. Must not be null.</param>
        public SubscriptionName(string projectId, string subscriptionId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            SubscriptionId = GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
        }

        /// <summary>
        /// Parses a subscription resource name in string form into a <see cref="SubscriptionName"/>.
        /// </summary>
        /// <param name="subscriptionName">The subscription resource name in string form. Must not be null.</param>
        /// <returns>A parsed <see cref="SubscriptionName"/>.</returns>
        public static SubscriptionName Parse(string subscriptionName)
        {
            GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            var resourceName = s_template.ParseName(subscriptionName);
            return new SubscriptionName(resourceName[0], resourceName[1]);
        }

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, SubscriptionId);
    }

    /// <summary>
    /// Resource name for a topic.
    /// </summary>
    public sealed class TopicName
    {
        // TODO: What about service-qualified resource names? Should we actually just keep a reference to a ResourceName?

        // TODO: Expose this?
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>
        /// The project ID. Never null.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The topic ID. Never null.
        /// </summary>
        public string TopicId { get; }

        /// <summary>
        /// Constructs a project name from a project ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="topicId">The project ID. Must not be null.</param>
        public TopicName(string projectId, string topicId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TopicId = GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
        }

        /// <summary>
        /// Parses a topic resource name in string form into a <see cref="TopicName"/>.
        /// </summary>
        /// <param name="topicName">The topic resource name in string form. Must not be null.</param>
        /// <returns>A parsed <see cref="TopicName"/>.</returns>
        public static TopicName Parse(string topicName)
        {
            GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            var resourceName = s_template.ParseName(topicName);
            return new TopicName(resourceName[0], resourceName[1]);
        }

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TopicId);
    }

    // Partial classes augmenting the protobuf messages to provide resource name properties.

    public partial class Subscription
    {
        /// <summary>
        /// A <see cref="SubscriptionName"/>-typed view over the <see cref="Name"/>
        /// property.
        /// </summary>
        public SubscriptionName SubscriptionName
        {
            get { return SubscriptionName.Parse(Name); }
            set { Name = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }

        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Topic"/>
        /// property.
        /// </summary>
        public TopicName TopicName
        {
            get { return TopicName.Parse(Topic); }
            set { Topic = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }
    }

    public partial class Topic
    {
        /// <summary>
        /// A <see cref="TopicName"/>-typed view over the <see cref="Name"/>
        /// property.
        /// </summary>
        public TopicName TopicName
        {
            get { return TopicName.Parse(Name); }
            set { Name = GaxPreconditions.CheckNotNull(value, nameof(value)).ToString(); }
        }
    }
}
