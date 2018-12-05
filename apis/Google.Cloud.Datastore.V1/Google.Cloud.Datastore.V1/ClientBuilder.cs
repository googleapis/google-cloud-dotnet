/*
 * Copyright 2018 Google LLC
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Api.Gax.Grpc
{
    /// <summary>
    /// Base class for API-specific builders.
    /// </summary>
    /// <typeparam name="TBuilder">The type of this builder, for chaining purposes</typeparam>
    /// <typeparam name="TClient">The type of client created by this builder.</typeparam>
    public abstract class ClientBuilder<TBuilder, TClient> where TBuilder : ClientBuilder<TBuilder, TClient>
    {
        /// <summary>
        /// The endpoint to connect to, or null to use the default endpoint.
        /// </summary>
        public ServiceEndpoint Endpoint { get; private set; }

        /// <summary>
        /// The scopes to use, or null to use the default scopes.
        /// </summary>
        public IReadOnlyList<string> Scopes { get; private set; }

        /// <summary>
        /// The channel credentials to use, or null if credentials are being provided in a different way.
        /// </summary>
        public ChannelCredentials ChannelCredentials { get; private set; }

        /// <summary>
        /// The credential file to use, or null if credentials are being provided in a different way.
        /// </summary>
        public string CredentialsFile { get; private set; }

        /// <summary>
        /// The credentials to use as JSON, or null if credentials are being provided in a different way.
        /// </summary>
        public string JsonCredentials { get; private set; }

        /// <summary>
        /// The token access method to use, or null if credentials are being provided in a different way.
        /// </summary>
        public Func<string, CancellationToken, Task<string>> TokenAccessMethod { get; private set; }

        /// <summary>
        /// The call invoker to use, or null to create the call invoker when the client is built.
        /// </summary>
        public CallInvoker CallInvoker { get; private set; }

        /// <summary>
        /// Creates a new instance with no settings.
        /// </summary>
        protected ClientBuilder()
        {
        }
        
        /// <summary>
        /// Creates a clone of the given builder, with respect to settings in this class.
        /// </summary>
        /// <param name="builder">The builder to clone</param>
        protected ClientBuilder(TBuilder builder)
        {
            Endpoint = builder.Endpoint;
            ChannelCredentials = builder.ChannelCredentials;
            Scopes = builder.Scopes;
            CredentialsFile = builder.CredentialsFile;
            JsonCredentials = builder.JsonCredentials;
            CallInvoker = CallInvoker;
            ChannelCredentials = null;
        }

        /// <summary>
        /// This method should be called by all "With" methods that change the credentials.
        /// If a subclass supports additional forms of credentials, it should override this method
        /// to clear them and call this implementation.
        /// </summary>
        protected virtual void ClearCredentials()
        {
            CredentialsFile = null;
            JsonCredentials = null;
            TokenAccessMethod = null;
            CallInvoker = null;
            ChannelCredentials = null;
        }

        /// <summary>
        /// Creates a new builder based on this one, but with the specified endpoint.
        /// </summary>
        /// <param name="endpoint">The endpoint to connect to, or null to use the default endpoint.</param>
        /// <returns>A builder with the specified endpoint.</returns>
        public TBuilder WithEndpoint(ServiceEndpoint endpoint)
        {
            var clone = Clone();
            clone.Endpoint = endpoint;
            return clone;
        }

        /// <summary>
        /// Creates a new builder based on this one, but with the specified credential scopes.
        /// </summary>
        /// <param name="scopes">The scopes to use when creating credentials, or null to use the default set of scopes.</param>
        /// <returns>A builder with the specified scopes.</returns>
        public TBuilder WithScopes(IEnumerable<string> scopes)
        {
            var clone = Clone();
            clone.Scopes = scopes?.ToList().AsReadOnly();
            return clone;
        }

        /// <summary>
        /// Creates a new builder based on this one, but with the specified channel credentials.
        /// </summary>
        /// <remarks>
        /// This method overrides any credentials specified with previous calls.
        /// </remarks>
        /// <param name="channelCredentials">The channel credentials to use, or null to use the default credentials.</param>
        /// <returns>A builder with the specified channel credentials.</returns>
        public TBuilder WithChannelCredentials(ChannelCredentials channelCredentials)
        {
            var clone = Clone();
            clone.ClearCredentials();
            clone.ChannelCredentials = channelCredentials;
            return clone;
        }

        /// <summary>
        /// Creates a new builder based on this one, but with the specified credential file.
        /// </summary>
        /// <remarks>
        /// This method overrides any credentials specified with previous calls.
        /// </remarks>
        /// <param name="file">The credential file to use, or null to use the default credentials.</param>
        /// <returns>A builder with the specified credential file.</returns>
        public TBuilder WithCredentialsFile(string file)
        {
            // Note: don't load this until we build, so that any scope changes will be effective.
            var clone = Clone();
            clone.ClearCredentials();
            clone.CredentialsFile = file;
            return clone;
        }

        /// <summary>
        /// Creates a new builder based on this one, but with the specified JSON credentials.
        /// </summary>
        /// <remarks>
        /// This method overrides any credentials specified with previous calls.
        /// </remarks>
        /// <param name="json">The JSON credentials to use, or null to use the default credentials.</param>
        /// <returns>A builder with the specified JSON credentials.</returns>
        public TBuilder WithJsonCredentials(string json)
        {
            var clone = Clone();
            clone.ClearCredentials();
            clone.JsonCredentials = json;
            return clone;
        }

        // TODO: Handle the fact that GoogleCredential implements ITokenAccess explicitly. That means the sample here doesn't work
        // without a cast...

        /// <summary>
        /// Creates a new builder based on this one, but with the specified token access method, typically created
        /// from a GoogleCredential.
        /// </summary>
        /// <remarks>
        /// <para>
        /// To use a GoogleCredential for credentials, call this method using a method group conversion, e.g.
        /// <c>builder = builder.WithTokenAccessMethod(credential.GetAccessTokenForRequestAsync);</c>
        /// </para>
        /// <para>
        /// This method overrides any credentials specified with previous calls.
        /// </para>
        /// </remarks>
        /// <param name="tokenAccessMethod">The token access method to use, or null to use the default credentials.</param>
        /// <returns>A builder with the specified token access method.</returns>
        public TBuilder WithTokenAccessMethod(Func<string, CancellationToken, Task<string>> tokenAccessMethod)
        {
            var clone = Clone();
            clone.ClearCredentials();
            clone.TokenAccessMethod = tokenAccessMethod;
            return clone;
        }

        /// <summary>
        /// Creates a new builder based on this one, but with the specified gRPC call invoker.
        /// </summary>
        /// <para>
        /// This method removes any credentials specified with previous calls.
        /// </para>
        /// <param name="callInvoker">The gRPC call invoker to use, or null to use the default call invoker.</param>
        /// <returns>A builder with the specified call invoker.</returns>
        public TBuilder WithCallInvoker(CallInvoker callInvoker)
        {
            var clone = Clone();
            clone.ClearCredentials();
            clone.CallInvoker = callInvoker;
            return clone;
        }

        /// <summary>
        /// Creates a call invoker synchronously. Override this method in a concrete builder type if more
        /// call invoker mechanisms are supported.
        /// </summary>
        protected virtual CallInvoker CreateCallInvoker()
        {
            if (CallInvoker != null)
            {
                return CallInvoker;
            }
            var endpoint = Endpoint ?? GetDefaultEndpoint();
            var credentials = GetChannelCredentials();
            Channel channel = new Channel(endpoint.Host, endpoint.Port, GetChannelCredentials());
            return new DefaultCallInvoker(channel);
        }

        /// <summary>
        /// Creates a call invoker asynchronously. Override this method in a concrete builder type if more
        /// call invoker mechanisms are supported.
        /// </summary>
        protected virtual async Task<CallInvoker> CreateCallInvokerAsync(CancellationToken cancellationToken)
        {
            if (CallInvoker != null)
            {
                return CallInvoker;
            }
            var endpoint = Endpoint ?? GetDefaultEndpoint();
            var credentials = await GetChannelCredentialsAsync(cancellationToken).ConfigureAwait(false);
            Channel channel = new Channel(endpoint.Host, endpoint.Port, credentials);
            return new DefaultCallInvoker(channel);
        }

        /// <summary>
        /// Obtains channel credentials synchronously. Override this method in a concrete builder type if more
        /// credential mechanisms are supported.
        /// </summary>
        protected virtual ChannelCredentials GetChannelCredentials()
        {
            if (ChannelCredentials != null)
            {
                return ChannelCredentials;
            }
            GoogleCredential unscoped;
            if (CredentialsFile != null)
            {
                unscoped = GoogleCredential.FromFile(CredentialsFile);
            }
            else if (JsonCredentials != null)
            {
                unscoped = GoogleCredential.FromJson(JsonCredentials);
            }
            else
            {
                unscoped = GoogleCredential.GetApplicationDefault();
            }
            return unscoped.CreateScoped(Scopes ?? GetDefaultScopes()).ToChannelCredentials();
        }

        /// <summary>
        /// Obtains channel credentials asynchronously. Override this method in a concrete builder type if more
        /// credential mechanisms are supported.
        /// </summary>
        protected async virtual Task<ChannelCredentials> GetChannelCredentialsAsync(CancellationToken cancellationToken)
        {
            if (ChannelCredentials != null)
            {
                return ChannelCredentials;
            }
            GoogleCredential unscoped;
            if (CredentialsFile != null)
            {
                // TODO: Use an async overload when one is available
                unscoped = GoogleCredential.FromFile(CredentialsFile);
            }
            else if (JsonCredentials != null)
            {
                unscoped = GoogleCredential.FromJson(JsonCredentials);
            }
            else
            {
                // TODO: Use cancellationToken when an overload accepting one is available
                unscoped = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            }
            return unscoped.CreateScoped(Scopes ?? GetDefaultScopes()).ToChannelCredentials();
        }

        /// <summary>
        /// Creates a clone of this builder.
        /// </summary>
        protected abstract TBuilder Clone();

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected abstract IReadOnlyList<string> GetDefaultScopes();

        /// <summary>
        /// Returns the endpoint for this builder type, used if no endpoint is otherwise specified.
        /// </summary>
        protected abstract ServiceEndpoint GetDefaultEndpoint();

        /// <summary>
        /// Builds the resulting client.
        /// </summary>
        public abstract TClient Build();

        /// <summary>
        /// Builds the resulting client asynchronously.
        /// </summary>
        public abstract Task<TClient> BuildAsync(CancellationToken cancellationToken = default);
    }
}
