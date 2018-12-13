// Copyright 2018 Google LLC
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

// Note: this will be in GAX, with the right copyright notice.

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
    /// <typeparam name="TClient">The type of client created by this builder.</typeparam>
    public abstract class ClientBuilder<TClient>
    {
        /// <summary>
        /// The endpoint to connect to, or null to use the default endpoint.
        /// </summary>
        public ServiceEndpoint Endpoint { get; set; }

        /// <summary>
        /// The scopes to use, or null to use the default scopes.
        /// </summary>
        public IReadOnlyList<string> Scopes { get; set; }

        /// <summary>
        /// The channel credentials to use, or null if credentials are being provided in a different way.
        /// </summary>
        public ChannelCredentials ChannelCredentials { get; set; }

        /// <summary>
        /// The path to the credentials file to use, or null if credentials are being provided in a different way.
        /// </summary>
        public string CredentialsPath { get; set; }

        /// <summary>
        /// The credentials to use as a JSON string, or null if credentials are being provided in a different way.
        /// </summary>
        public string JsonCredentials { get; set; }

        /// <summary>
        /// The token access method to use, or null if credentials are being provided in a different way.
        /// </summary>
        /// <remarks>
        /// <para>
        /// To use a GoogleCredential for credentials, call this method using a method group conversion, e.g.
        /// <c>builder = builder.WithTokenAccessMethod(credential.GetAccessTokenForRequestAsync);</c>
        /// </para>
        /// </remarks>
        public Func<string, CancellationToken, Task<string>> TokenAccessMethod { get; set; }

        /// <summary>
        /// The call invoker to use, or null to create the call invoker when the client is built.
        /// </summary>
        public CallInvoker CallInvoker { get; set; }

        /// <summary>
        /// Creates a new instance with no settings.
        /// </summary>
        protected ClientBuilder()
        {
        }
        
        /// <summary>
        /// Validates that the builder is in a consistent state for building. For example, it's invalid to call
        /// <see cref="Build"/> on an instance which has both JSON credentials and a credentials path specified.
        /// </summary>
        /// <exception cref="InvalidOperationException">The builder is in an invalid state.</exception>
        protected virtual void Validate()
        {
            // If there's a call invoker, we shouldn't have any credentials-related information or an endpoint.
            ValidateOptionExcludesOthers("CallInvoker cannot be specified with credentials settings or an endpoint", CallInvoker,
                ChannelCredentials, CredentialsPath, JsonCredentials, Scopes, Endpoint, TokenAccessMethod);

            ValidateAtMostOneNotNull("Only one source of credentials can be specified",
                ChannelCredentials, CredentialsPath, JsonCredentials, TokenAccessMethod);

            ValidateOptionExcludesOthers("Scopes are not relevant when a token access method or channel credentials are supplied", Scopes,
                TokenAccessMethod, ChannelCredentials);            
        }

        /// <summary>
        /// Validates that at most one of the given values is not null.
        /// </summary>
        /// <param name="message">The message if the condition is violated.</param>
        /// <param name="values">The values to check for nullity.</param>
        /// <exception cref="InvalidOperationException">More than one value is null.</exception>
        protected void ValidateAtMostOneNotNull(string message, params object[] values)
        {
            int notNull = values.Count(v => v == null);
            GaxPreconditions.CheckState(notNull < 2, message);
        }

        /// <summary>
        /// Validates that if <paramref name="controlling"/> is not null, then every value in <paramref name="values"/> is null.
        /// </summary>
        /// <param name="message">The message if the condition is violated.</param>
        /// <param name="controlling">The value controlling whether or not any other value can be non-null.</param>
        /// <param name="values">The values checked for non-nullity if <paramref name="controlling"/> is non-null.</param>
        protected void ValidateOptionExcludesOthers(string message, object controlling, params object[] values)
        {
            GaxPreconditions.CheckState(controlling == null || !values.Contains(null), message);
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
            if (CredentialsPath != null)
            {
                unscoped = GoogleCredential.FromFile(CredentialsPath);
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
            if (CredentialsPath != null)
            {
                // TODO: Use an async overload when one is available
                unscoped = GoogleCredential.FromFile(CredentialsPath);
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
        public virtual TClient Build()
        {
            Validate();
            return BuildImpl();
        }

        /// <summary>
        /// Builds the resulting client asynchronously.
        /// </summary>
        public virtual Task<TClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            Validate();
            return BuildImplAsync(cancellationToken);
        }

        /// <summary>
        /// Builds the resulting client. Validation will already have been performed by the time this is called.
        /// </summary>
        protected abstract TClient BuildImpl();

        /// <summary>
        /// Builds the resulting client asynchronously. Validation will already have been performed by the time this is called.
        /// </summary>
        protected abstract Task<TClient> BuildImplAsync(CancellationToken cancellationToken);
    }
}
