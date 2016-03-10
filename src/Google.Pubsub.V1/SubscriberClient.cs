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
using System.Linq;
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
        /// Wrap a GRPC Publisher client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="SubscriberSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="SubscriberSettings"/> that wraps the specified GRPC client.</returns>
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
        /// Get a new instance of the default <see cref="PublisherSettings">.
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
    /// Subscriber client wrapper, for convinient use.
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
        /// Get a new instance of the default <see cref="ServiceEndpointSettings"/>.
        /// </summary>
        /// <remarks>
        /// The default service endpoint settings are:
        /// <list type="bullet">
        /// <item><description>Host "pubsub-experimental.googleapis.com"</description></item>
        /// <item><description>Port 443</description></item>
        /// </list>
        /// </remarks>
        public static ServiceEndpointSettings GetDefaultServiceApiSettings() => new ServiceEndpointSettings
        {
            Host = ServiceDefaults.Host,
            Port = ServiceDefaults.Port,
        };

        private static async Task<SubscriberClient> CreateFromDefaultCredentialsUnsafeAsync(
            SubscriberSettings settings = null,
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
            // Clone all settings, as Create can be async.
            return CreateFromDefaultCredentialsUnsafeAsync(
                settings?.Clone(),
                serviceEndpointSettings?.Clone(),
                credentialScopes?.ToList());
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
            // Clone all settings, as Create can be async
            return Task.Run(() => CreateFromDefaultCredentialsUnsafeAsync(
                settings?.Clone(),
                serviceEndpointSettings?.Clone(),
                credentialScopes == null ? null : new List<string>(credentialScopes)
            )).Result;
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
            ServiceEndpointSettings serviceApiSettings = null)
        {
            serviceApiSettings = serviceApiSettings ?? GetDefaultServiceApiSettings();
            Channel channel = new Channel(
                serviceApiSettings.Host ?? ServiceDefaults.Host,
                serviceApiSettings.Port ?? ServiceDefaults.Port,
                credentials);
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

        public virtual Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Subscription CreateSubscription(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Subscription GetSubscription(
            string subscription,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual IAsyncEnumerable<Subscription> ListSubscriptionsAsync(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<Subscription> ListSubscriptions(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteSubscriptionAsync(
            string subscription,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteSubscription(
            string subscription,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ModifyAckDeadline(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual void Acknowledge(
            string subscription,
            IEnumerable<string> ackIds,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual PullResponse Pull(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            throw new NotImplementedException();
        }

        public virtual void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
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

        private readonly Func<DateTime?> _calcDeadline;

        public SubscriberClientImpl(Subscriber.ISubscriberClient grpcClient, SubscriberSettings settings)
        {
            settings = settings ?? SubscriberSettings.GetDefault();
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

        public override Subscriber.ISubscriberClient GrpcClient { get; }

        private CallOptions BuildCallOptions(
            CancellationToken cancellationToken,
            Func<CallOptions, CallOptions> callOptionsOverride)
        {
            CallOptions callOptions = new CallOptions(
                deadline: _calcDeadline(),
                cancellationToken: cancellationToken);
            return callOptionsOverride?.Invoke(callOptions) ?? callOptions;
        }

        public override Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
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
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override Subscription CreateSubscription(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
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
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

        public override Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                Subscription = subscription,
            };
            return GrpcClient.GetSubscriptionAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override Subscription GetSubscription(
            string subscription,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                Subscription = subscription,
            };
            return GrpcClient.GetSubscription(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

        public override IAsyncEnumerable<Subscription> ListSubscriptionsAsync(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                Project = project,
            };
            return s_listSubscriptionsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListSubscriptionsAsync(
                    pageStreamRequest,
                    BuildCallOptions(cancellationToken, callOptionsOverride)
                ).ResponseAsync
            );
        }

        public override IEnumerable<Subscription> ListSubscriptions(
            string project,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                Project = project,
            };
            return s_listSubscriptionsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListSubscriptions(
                    pageStreamRequest,
                    BuildCallOptions(default(CancellationToken), callOptionsOverride))
            );
        }

        public override Task DeleteSubscriptionAsync(
            string subscription,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                Subscription = subscription,
            };
            return GrpcClient.DeleteSubscriptionAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override void DeleteSubscription(
            string subscription,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                Subscription = subscription,
            };
            GrpcClient.DeleteSubscription(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

        public override Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
                AckDeadlineSeconds = ackDeadlineSeconds,
            };
            return GrpcClient.ModifyAckDeadlineAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override void ModifyAckDeadline(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ModifyAckDeadlineRequest request = new ModifyAckDeadlineRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
                AckDeadlineSeconds = ackDeadlineSeconds,
            };
            GrpcClient.ModifyAckDeadline(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

        public override Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
            };
            return GrpcClient.AcknowledgeAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override void Acknowledge(
            string subscription,
            IEnumerable<string> ackIds,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            AcknowledgeRequest request = new AcknowledgeRequest
            {
                Subscription = subscription,
                AckIds = { ackIds },
            };
            GrpcClient.AcknowledgeAsync(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

        public override Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            PullRequest request = new PullRequest
            {
                Subscription = subscription,
                ReturnImmediately = returnImmediately,
                MaxMessages = maxMessages,
            };
            return GrpcClient.PullAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override PullResponse Pull(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            PullRequest request = new PullRequest
            {
                Subscription = subscription,
                ReturnImmediately = returnImmediately,
                MaxMessages = maxMessages,
            };
            return GrpcClient.Pull(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

        public override Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CancellationToken cancellationToken = default(CancellationToken),
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                Subscription = subscription,
                PushConfig = pushConfig,
            };
            return GrpcClient.ModifyPushConfigAsync(
                request,
                BuildCallOptions(cancellationToken, callOptionsOverride)
            ).ResponseAsync;
        }

        public override void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            Func<CallOptions, CallOptions> callOptionsOverride = null)
        {
            ModifyPushConfigRequest request = new ModifyPushConfigRequest
            {
                Subscription = subscription,
                PushConfig = pushConfig,
            };
            GrpcClient.ModifyPushConfig(
                request,
                BuildCallOptions(default(CancellationToken), callOptionsOverride)
            );
        }

    }

}
