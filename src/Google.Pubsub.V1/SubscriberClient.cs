// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Pubsub.V1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="SubscriberClient"/>.
    /// </summary>
    public static partial class SubscriberExtensions
    {
        /// <summary>
        /// Wrap a GRPC Subscriber client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="SubscriberSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="SubscriberClient"/> that wraps the specified GRPC client.</returns>
        public static SubscriberClient ToClient(
            this Subscriber.ISubscriberClient grpcClient,
            SubscriberSettings settings = null
        ) => new SubscriberClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Subscriber wrapper.
    /// </summary>
    public sealed partial class SubscriberSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SubscriberSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default SubscriberSettings.</returns>
        public static SubscriberSettings GetDefault() => new SubscriberSettings();

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Subscriber settings.</returns>
        public SubscriberSettings Clone() => CloneInto(new SubscriberSettings
        {
        });
    }

    /// <summary>
    /// Subscriber client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SubscriberClient
    {
        /// <summary>
        /// Default service parameters for the Subscriber service.
        /// </summary>
        public static class ServiceDefaults
        {
            /// <summary>
            /// The default Subscriber network host.
            /// </summary>
            /// <remarks>
            /// The default Subscriber network host is "pubsub-experimental.googleapis.com".
            /// </remarks>
            public static string Host { get; } = "pubsub-experimental.googleapis.com";

            /// <summary>
            /// The default Subscriber network port.
            /// </summary>
            /// <remarks>
            /// The default Subscriber network port is 443.
            /// </remarks>
            public static int Port { get; } = 443;

            /// <summary>
            /// The default Subscriber scopes
            /// </summary>
            /// <remarks>
            /// The default Subscriber scopes are:
            /// <list type="bullet">
            /// <item><description>"https://www.googleapis.com/auth/pubsub"</description></item>
            /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
            /// </list>
            /// </remarks>
            public static IReadOnlyList<string> Scopes { get; } = new ReadOnlyCollection<string>(new[] {
                "https://www.googleapis.com/auth/pubsub",
                "https://www.googleapis.com/auth/cloud-platform",
            });
        }

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a subscription resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>subscription</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate SubscriptionTemplate { get; } = new PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>
        /// Creates a subscription resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="subscriptionId">The subscription ID.</param>
        /// <returns>The full subscription resource name.</returns>
        public static string GetSubscriptionName(string projectId, string subscriptionId) => SubscriptionTemplate.Expand(projectId, subscriptionId);


        /// <summary>
        /// Get a new instance of the default <see cref="ServiceEndpointSettings"/>.
        /// </summary>
        /// <remarks>
        /// The default service endpoint settings are:
        /// <list type="bullet">
        /// <item><description>Host "pubsub-experimental.googleapis.com"</description></item>
        /// <item><description>Port 443</description></item>
        /// </list>
        /// </remarks>
        public static ServiceEndpointSettings GetDefaultServiceEndpointSettings() => new ServiceEndpointSettings
        {
            Host = ServiceDefaults.Host,
            Port = ServiceDefaults.Port,
        };

        /// <summary>
        /// Asynchronously create a <see cref="SubscriberClient"/> from default credentials.
        /// </summary>
        /// <param name="settings">Optional <see cref="SubscriberSettings"/>.</param>
        /// <param name="serviceEndpointSettings">Optional <see cref="ServiceEndpointSettings"/>.</param>
        /// <param name="credentialScopes">Optional scopes for default credentials.</param>
        /// <returns>A newly created <see cref="SubscriberClient"/>.</returns>
        public static Task<SubscriberClient> CreateFromDefaultCredentialsAsync(
            SubscriberSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null,
            IEnumerable<string> credentialScopes = null)
        {
            return ClientHelper.CreateFromDefaultCredentialsAsync(
                settings, serviceEndpointSettings, credentialScopes, ServiceDefaults.Scopes, CreateFromCredentials);
        }

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> from default credentials.
        /// </summary>
        /// <param name="settings">Optional <see cref="SubscriberSettings"/>.</param>
        /// <param name="serviceEndpointSettings">Optional <see cref="ServiceEndpointSettings"/>.</param>
        /// <param name="credentialScopes">Optional scopes for default credentials.</param>
        /// <returns>A newly created <see cref="SubscriberClient"/>.</returns>
        public static SubscriberClient CreateFromDefaultCredentials(
            SubscriberSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null,
            IEnumerable<string> credentialScopes = null)
        {
            return ClientHelper.CreateFromDefaultCredentials(
                settings, serviceEndpointSettings, credentialScopes, ServiceDefaults.Scopes, CreateFromCredentials);
        }

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> from the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials with which to configure the GRPC channel.</param>
        /// <param name="settings">Optional <see cref="SubscriberSettings"/>.</param>
        /// <param name="serviceEndpointSettings">Optional <see cref="ServiceEndpointSettings"/>.</param>
        /// <returns></returns>
        public static SubscriberClient CreateFromCredentials(
            ChannelCredentials credentials,
            SubscriberSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null)
        {
            Channel channel = ClientHelper.CreateChannel(
                serviceEndpointSettings ?? GetDefaultServiceEndpointSettings(),
                ServiceDefaults.Host, ServiceDefaults.Port, credentials);
            Subscriber.ISubscriberClient grpcClient = new Subscriber.SubscriberClient(channel);
            return new SubscriberClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying GRPC Subscriber client.
        /// </summary>
        public virtual Subscriber.ISubscriberClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="push_config">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ack_deadline_seconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="push_config">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ack_deadline_seconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription CreateSubscription(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">The name of the subscription to get.</param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">The name of the subscription to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(
            string subscription,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<Subscription> ListSubscriptionsAsync(
            string project,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<Subscription> ListSubscriptions(
            string project,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">The subscription to delete.</param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSubscriptionAsync(
            string subscription,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">The subscription to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSubscription(
            string subscription,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="ack_ids">List of acknowledgment IDs.</param>
        /// <param name="ack_deadline_seconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="ack_ids">List of acknowledgment IDs.</param>
        /// <param name="ack_deadline_seconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ModifyAckDeadline(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscription">The subscription whose message is being acknowledged.</param>
        /// <param name="ack_ids">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscription">The subscription whose message is being acknowledged.</param>
        /// <param name="ack_ids">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Acknowledge(
            string subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscription">The subscription from which messages should be pulled.</param>
        /// <param name="return_immediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="max_messages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscription">The subscription from which messages should be pulled.</param>
        /// <param name="return_immediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="max_messages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullResponse Pull(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="push_config">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="push_config">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class SubscriberClientImpl : SubscriberClient
    {
        private static readonly PageStreamer<Subscription, ListSubscriptionsRequest, ListSubscriptionsResponse, string> s_listSubscriptionsPageStreamer =
            new PageStreamer<Subscription, ListSubscriptionsRequest, ListSubscriptionsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Subscriptions,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;

        public SubscriberClientImpl(Subscriber.ISubscriberClient grpcClient, SubscriberSettings settings)
        {
            this.GrpcClient = grpcClient;
            SubscriberSettings effectiveSettings = settings ?? SubscriberSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
        }

        public override Subscriber.ISubscriberClient GrpcClient { get; }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="push_config">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ack_deadline_seconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            Subscription request = new Subscription
            {
                Name = name,
                Topic = topic,
                PushConfig = pushConfig,
                AckDeadlineSeconds = ackDeadlineSeconds,
            };
            return GrpcClient.CreateSubscriptionAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="push_config">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ack_deadline_seconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription CreateSubscription(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            Subscription request = new Subscription
            {
                Name = name,
                Topic = topic,
                PushConfig = pushConfig,
                AckDeadlineSeconds = ackDeadlineSeconds,
            };
            return GrpcClient.CreateSubscription(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">The name of the subscription to get.</param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                Subscription = subscription,
            };
            return GrpcClient.GetSubscriptionAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">The name of the subscription to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription GetSubscription(
            string subscription,
            CallSettings callSettings = null)
        {
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                Subscription = subscription,
            };
            return GrpcClient.GetSubscription(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<Subscription> ListSubscriptionsAsync(
            string project,
            CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                Project = project,
            };
            return s_listSubscriptionsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListSubscriptionsAsync(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(cancellationToken, callSettings)
                ).ResponseAsync
            );
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<Subscription> ListSubscriptions(
            string project,
            CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                Project = project,
            };
            return s_listSubscriptionsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListSubscriptions(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(null, callSettings))
            );
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">The subscription to delete.</param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteSubscriptionAsync(
            string subscription,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                Subscription = subscription,
            };
            return GrpcClient.DeleteSubscriptionAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">The subscription to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSubscription(
            string subscription,
            CallSettings callSettings = null)
        {
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                Subscription = subscription,
            };
            GrpcClient.DeleteSubscription(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="ack_ids">List of acknowledgment IDs.</param>
        /// <param name="ack_deadline_seconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
                AckDeadlineSeconds = ackDeadlineSeconds,
            };
            return GrpcClient.ModifyAckDeadlineAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="ack_ids">List of acknowledgment IDs.</param>
        /// <param name="ack_deadline_seconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ModifyAckDeadline(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
                AckDeadlineSeconds = ackDeadlineSeconds,
            };
            GrpcClient.ModifyAckDeadline(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscription">The subscription whose message is being acknowledged.</param>
        /// <param name="ack_ids">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
            };
            return GrpcClient.AcknowledgeAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscription">The subscription whose message is being acknowledged.</param>
        /// <param name="ack_ids">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void Acknowledge(
            string subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null)
        {
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
            };
            GrpcClient.Acknowledge(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscription">The subscription from which messages should be pulled.</param>
        /// <param name="return_immediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="max_messages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            PullRequest request = new PullRequest
            {
                Subscription = subscription,
                ReturnImmediately = returnImmediately,
                MaxMessages = maxMessages,
            };
            return GrpcClient.PullAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscription">The subscription from which messages should be pulled.</param>
        /// <param name="return_immediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="max_messages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PullResponse Pull(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null)
        {
            PullRequest request = new PullRequest
            {
                Subscription = subscription,
                ReturnImmediately = returnImmediately,
                MaxMessages = maxMessages,
            };
            return GrpcClient.Pull(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="push_config">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="cancellationToken">If not null, a <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                Subscription = subscription,
                PushConfig = pushConfig,
            };
            return GrpcClient.ModifyPushConfigAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscription">The name of the subscription.</param>
        /// <param name="push_config">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null)
        {
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                Subscription = subscription,
                PushConfig = pushConfig,
            };
            GrpcClient.ModifyPushConfig(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

    }
}