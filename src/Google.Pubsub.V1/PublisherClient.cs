/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        /// Wrap a GRPC Publisher client for more convinient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="PublisherSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="PublisherSettings"/> that wraps the specified GRPC client.</returns>
        public static PublisherClient ToClient(
            this Publisher.IPublisherClient grpcClient,
            PublisherSettings settings = null
        ) => new PublisherClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Publisher wrapper.
    /// </summary>
    public sealed partial class PublisherSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PublisherSettings">.
        /// </summary>
        /// <returns>A new instance of the default PublisherSettings.</returns>
        public static PublisherSettings GetDefault() => new PublisherSettings();

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Publisher settings.</returns>
        public PublisherSettings Clone() => CloneInto(new PublisherSettings
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
            public static ReadOnlyCollection<string> Scopes { get; } = new ReadOnlyCollection<string>(new[] {
                "https://www.googleapis.com/auth/pubsub",
                "https://www.googleapis.com/auth/cloud-platform",
            });
        }

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

        private static async Task<PublisherClient> CreateFromDefaultCredentialsUnsafeAsync(
            PublisherSettings settings = null,
            ServiceEndpointSettings serviceEndpointSettings = null,
            IEnumerable<string> credentialScopes = null)
        {
            // Get the default credentials, and add scopes if required
            var credentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            if (credentials.IsCreateScopedRequired)
            {
                credentials = credentials.CreateScoped(credentialScopes ?? ServiceDefaults.Scopes);
            }
            var channelCredentials = ChannelCredentials.Create(
                new SslCredentials(),
                credentials.ToCallCredentials());
            return CreateFromCredentials(channelCredentials, settings, serviceEndpointSettings);
        }

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
            // Clone all settings, as Create can be async.
            return CreateFromDefaultCredentialsUnsafeAsync(
                settings?.Clone(),
                serviceEndpointSettings?.Clone(),
                credentialScopes == null ? null : new List<string>(credentialScopes));
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
            // Clone all settings, as Create can be async
            return Task.Run(() => CreateFromDefaultCredentialsUnsafeAsync(
                settings?.Clone(),
                serviceEndpointSettings?.Clone(),
                credentialScopes == null ? null : new List<string>(credentialScopes)
            )).Result;
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
            serviceEndpointSettings = serviceEndpointSettings ?? GetDefaultServiceEndpointSettings();
            Channel channel = new Channel(
                serviceEndpointSettings.Host ?? ServiceDefaults.Host,
                serviceEndpointSettings.Port ?? ServiceDefaults.Port,
                credentials);
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
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Topic CreateTopic(
            string name,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual PublishResponse Publish(
            string topic,
            IEnumerable<PubsubMessage> messages,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Topic> GetTopicAsync(
            string topic,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Topic GetTopic(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual IAsyncEnumerable<Topic> ListTopicsAsync(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<Topic> ListTopics(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual IAsyncEnumerable<string> ListTopicSubscriptionsAsync(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<string> ListTopicSubscriptions(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteTopicAsync(
            string topic,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteTopic(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
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

        public PublisherClientImpl(Publisher.IPublisherClient grpcClient, PublisherSettings settings)
        {
            settings = settings ?? PublisherSettings.GetDefault();
            this.GrpcClient = grpcClient;
            if (settings.Timeout == null)
            {
                this._calcDeadline = () => null;
            }
            else
            {
                IClock clock = settings.Clock ?? SystemClock.Instance;
                TimeSpan timeout = settings.Timeout.Value;
                this._calcDeadline = () => clock.GetCurrentDateTimeUtc() + timeout;
            }
        }

        private readonly Func<DateTime?> _calcDeadline;

        public override Publisher.IPublisherClient GrpcClient { get; }

        private CallOptions BuildCallOptions(
            CancellationToken cancellationToken,
            Func<CallOptions, CallOptions> callOptionsOverride)
        {
            CallOptions callOptions = new CallOptions(
                deadline: _calcDeadline(),
                cancellationToken: cancellationToken);
            return callOptionsOverride?.Invoke(callOptions) ?? callOptions;
        }

        public override Task<Topic> CreateTopicAsync(
            string name,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            Topic request = new Topic
            {
                Name = name
            };
            return GrpcClient.CreateTopicAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override Topic CreateTopic(
            string name,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            Topic request = new Topic
            {
                Name = name
            };
            return GrpcClient.CreateTopic(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride));
        }

        public override Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            PublishRequest request = new PublishRequest
            {
                Topic = topic,
                Messages = { messages },
            };
            return GrpcClient.PublishAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override PublishResponse Publish(
            string topic,
            IEnumerable<PubsubMessage> messages,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            PublishRequest request = new PublishRequest
            {
                Topic = topic,
                Messages = { messages },
            };
            return GrpcClient.Publish(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride));
        }

        public override Task<Topic> GetTopicAsync(
            string topic,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            GetTopicRequest request = new GetTopicRequest
            {
                Topic = topic
            };
            return GrpcClient.GetTopicAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override Topic GetTopic(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            GetTopicRequest request = new GetTopicRequest
            {
                Topic = topic
            };
            return GrpcClient.GetTopic(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride));
        }

        public override IAsyncEnumerable<Topic> ListTopicsAsync(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                Project = project
            };
            return s_listTopicsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListTopicsAsync(
                    pageStreamRequest,
                    BuildCallOptions(cancellationToken, callOptionsOverride)
                ).ResponseAsync
            );
        }

        public override IEnumerable<Topic> ListTopics(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                Project = project
            };
            return s_listTopicsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListTopics(
                    pageStreamRequest,
                    BuildCallOptions(default(CancellationToken), callOptionsOverride))
            );
        }

        public override IAsyncEnumerable<string> ListTopicSubscriptionsAsync(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                Topic = topic
            };
            return s_listTopicSubscriptionsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListTopicSubscriptionsAsync(
                    pageStreamRequest,
                    BuildCallOptions(cancellationToken, callOptionsOverride)
                ).ResponseAsync
            );
        }

        public override IEnumerable<string> ListTopicSubscriptions(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                Topic = topic
            };
            return s_listTopicSubscriptionsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListTopicSubscriptions(
                    pageStreamRequest,
                    BuildCallOptions(default(CancellationToken), callOptionsOverride))
            );
        }

        public override Task DeleteTopicAsync(
            string topic,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                Topic = topic
            };
            return GrpcClient.DeleteTopicAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override void DeleteTopic(
            string topic,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                Topic = topic
            };
            GrpcClient.DeleteTopic(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride));
        }

    }
}
