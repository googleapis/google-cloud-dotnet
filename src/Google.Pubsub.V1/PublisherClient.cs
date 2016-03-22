// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Pubsub.V1
{
    /// <summary>
    /// Extension methods to assist with using <see cref="PublisherClient"/>.
    /// </summary>
    public static partial class PublisherExtensions
    {
        /// <summary>
        /// Wrap a GRPC Publisher client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="PublisherSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="PublisherClient"/> that wraps the specified GRPC client.</returns>
        public static PublisherClient ToClient(
            this Publisher.IPublisherClient grpcClient,
            PublisherSettings settings = null
        ) => new PublisherClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Publisher wrapper.
    /// </summary>
    public sealed partial class PublisherSettings : ServiceSettingsBase<PublisherSettings>
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PublisherSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default PublisherSettings.</returns>
        public static PublisherSettings GetDefault() => new PublisherSettings();

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Publisher settings.</returns>
        public override PublisherSettings Clone() => CloneInto(new PublisherSettings
        {
        });
    }

    /// <summary>
    /// Publisher client wrapper, for convinient use.
    /// </summary>
    public abstract partial class PublisherClient
    {
        /// <summary>
        /// Default service parameters for the Publisher service.
        /// </summary>
        public static class ServiceDefaults
        {
            /// <summary>
            /// The default Publisher network host.
            /// </summary>
            /// <remarks>
            /// The default Publisher network host is "pubsub-experimental.googleapis.com".
            /// </remarks>
            public static string Host { get; } = "pubsub-experimental.googleapis.com";

            /// <summary>
            /// The default Publisher network port.
            /// </summary>
            /// <remarks>
            /// The default Publisher network port is 443.
            /// </remarks>
            public static int Port { get; } = 443;

            /// <summary>
            /// The default Publisher scopes
            /// </summary>
            /// <remarks>
            /// The default Publisher scopes are:
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
        public static PathTemplate ProjectTemplate { get; }  = new PathTemplate("projects/{project}");

        /// <summary>
        /// Path template for a topic resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>topic</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate TopicTemplate { get; } = new PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Creates a topic resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <returns>The full topic resource name.</returns>
        public static string GetTopicName(string projectId, string topicId) => TopicTemplate.Expand(projectId, topicId);

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
        /// Asynchonously create a <see cref="PublisherClient"/> from default credentials.
        /// </summary>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <param name="serviceEndpointSettings">Optional <see cref="ServiceEndpointSettings"/>.</param>
        /// <param name="credentialScopes">Optional scopes for default credentials.</param>
        /// <returns>A newly created <see cref="PublisherClient"/>.</returns>
        public static Task<PublisherClient> CreateFromDefaultCredentialsAsync(
            PublisherSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null,
            IEnumerable<string> credentialScopes = null)
        {
            return ClientHelper.CreateFromDefaultCredentialsAsync(settings, serviceEndpointSettings, credentialScopes, ServiceDefaults.Scopes, CreateFromCredentials);
        }

        /// <summary>
        /// Create a <see cref="PublisherClient"/> from default credentials.
        /// </summary>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <param name="serviceEndpointSettings">Optional <see cref="ServiceEndpointSettings"/>.</param>
        /// <param name="credentialScopes">Optional scopes for default credentials.</param>
        /// <returns>A newly created <see cref="PublisherClient"/>.</returns>
        public static PublisherClient CreateFromDefaultCredentials(
            PublisherSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null,
            IEnumerable<string> credentialScopes = null)
        {
            return ClientHelper.CreateFromDefaultCredentials(settings, serviceEndpointSettings, credentialScopes, ServiceDefaults.Scopes, CreateFromCredentials);
        }

        /// <summary>
        /// Create a <see cref="PublisherClient"/> from the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials with which to configure the GRPC channel.</param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <param name="serviceEndpointSettings">Optional <see cref="ServiceEndpointSettings"/>.</param>
        /// <returns></returns>
        public static PublisherClient CreateFromCredentials(
            ChannelCredentials credentials,
            PublisherSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null)
        {
            Channel channel = ClientHelper.CreateChannel(serviceEndpointSettings ?? GetDefaultServiceEndpointSettings(), ServiceDefaults.Host, ServiceDefaults.Port, credentials);
            Publisher.IPublisherClient grpcClient = new Publisher.PublisherClient(channel);
            return new PublisherClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying GRPC Publisher client.
        /// </summary>
        public virtual Publisher.IPublisherClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        public virtual Task<Topic> CreateTopicAsync(
            string name,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual Topic CreateTopic(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual PublishResponse Publish(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Topic> GetTopicAsync(
            string topic,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual Topic GetTopic(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual IAsyncEnumerable<Topic> ListTopicsAsync(
            string project,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<Topic> ListTopics(
            string project,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual IAsyncEnumerable<string> ListTopicSubscriptionsAsync(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<string> ListTopicSubscriptions(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteTopicAsync(
            string topic,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteTopic(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }
    }

    public sealed partial class PublisherClientImpl : PublisherClient
    {
        private static readonly PageStreamer<Topic, ListTopicsRequest, ListTopicsResponse, string> s_listTopicsPageStreamer =
            new PageStreamer<Topic, ListTopicsRequest, ListTopicsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Topics,
                "" // An empty page-token
            );

        private static readonly PageStreamer<string, ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string> s_listTopicSubscriptionsPageStreamer =
            new PageStreamer<string, ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Subscriptions,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;

        public PublisherClientImpl(Publisher.IPublisherClient grpcClient, PublisherSettings settings)
        {
            this.GrpcClient = grpcClient;
            var effectiveSettings = settings ?? PublisherSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
        }

        public override Publisher.IPublisherClient GrpcClient { get; }

        public override Task<Topic> CreateTopicAsync(
            string name,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            Topic request = new Topic
            {
                Name = name
            };
            return GrpcClient.CreateTopicAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        public override Topic CreateTopic(
            string name,
            CallSettings callSettings = null)
        {
            Topic request = new Topic
            {
                Name = name
            };
            return GrpcClient.CreateTopic(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        public override Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            PublishRequest request = new PublishRequest
            {
                Topic = topic,
                Messages = { messages },
            };
            return GrpcClient.PublishAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        public override PublishResponse Publish(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null)
        {
            PublishRequest request = new PublishRequest
            {
                Topic = topic,
                Messages = { messages },
            };
            return GrpcClient.Publish(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        public override Task<Topic> GetTopicAsync(
            string topic,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            GetTopicRequest request = new GetTopicRequest
            {
                Topic = topic
            };
            return GrpcClient.GetTopicAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        public override Topic GetTopic(
            string topic,
            CallSettings callSettings = null)
        {
            GetTopicRequest request = new GetTopicRequest
            {
                Topic = topic
            };
            return GrpcClient.GetTopic(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        public override IAsyncEnumerable<Topic> ListTopicsAsync(
            string project,
            CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                Project = project
            };
            CallSettings clonedCallSettings = callSettings?.Clone();
            return s_listTopicsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListTopicsAsync(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(cancellationToken, clonedCallSettings)
                ).ResponseAsync
            );
        }

        public override IEnumerable<Topic> ListTopics(
            string project,
            CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                Project = project
            };
            CallSettings clonedCallSettings = callSettings?.Clone();
            return s_listTopicsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListTopics(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(null, clonedCallSettings))
            );
        }

        public override IAsyncEnumerable<string> ListTopicSubscriptionsAsync(
            string topic,
            CallSettings callSettings = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                Topic = topic
            };
            CallSettings clonedCallSettings = callSettings?.Clone();
            return s_listTopicSubscriptionsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListTopicSubscriptionsAsync(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(cancellationToken, clonedCallSettings)
                ).ResponseAsync
            );
        }

        public override IEnumerable<string> ListTopicSubscriptions(
            string topic,
            CallSettings callSettings = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                Topic = topic
            };
            CallSettings clonedCallSettings = callSettings?.Clone();
            return s_listTopicSubscriptionsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListTopicSubscriptions(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(null, clonedCallSettings))
            );
        }

        public override Task DeleteTopicAsync(
            string topic,
            CancellationToken? cancellationToken = null,
            CallSettings callSettings = null)
        {
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                Topic = topic
            };
            return GrpcClient.DeleteTopicAsync(
                request,
                _clientHelper.BuildCallOptions(cancellationToken, callSettings)
            ).ResponseAsync;
        }

        public override void DeleteTopic(
            string topic,
            CallSettings callSettings = null)
        {
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                Topic = topic
            };
            GrpcClient.DeleteTopic(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

    }
}
