// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Common
{
    /// <summary>
    /// A paginator is a helper to provide both synchronous and asynchronous pagination
    /// of a listable or queryable resource.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The expected usage pattern is to create a single paginator for a resource collection,
    /// and then use the instance methods to obtain paginated results. The methods take parameters
    /// expressing how individual pages are fetched, allowing the same paginator to be used across
    /// multiple contexts (for example, with different client instances).
    /// </para>
    /// <para>
    /// This is a relatively low-level and unwieldy class, wrapping functionality in a way which is
    /// convenient for code generators, but is not intended for regular use by manually-written code.
    /// </para>
    /// </remarks>
    /// <typeparam name="TResource">The type of resource being paginated</typeparam>
    /// <typeparam name="TRequest">The type of request used to fetch pages</typeparam>
    /// <typeparam name="TResponse">The type of response obtained when fetching pages</typeparam>
    /// <typeparam name="TToken">The type of the "next page token", which must be equatable to itself</typeparam>
    public sealed class Paginator<TResource, TRequest, TResponse, TToken>
        where TToken : IEquatable<TToken>
    {
        private readonly Func<TRequest, TToken, TRequest> _requestProvider;
        private readonly Func<TResponse, TToken> _tokenExtractor;
        private readonly Func<TResponse, IEnumerable<TResource>> _resourceExtractor;
        private readonly TToken _emptyToken;

        /// <summary>
        /// Creates a paginator for later use.
        /// </summary>
        /// <param name="requestProvider">Function to combine an initial request and a page token
        /// into a new request. Must not be null.</param>
        /// <param name="tokenExtractor">Function to extract the next page token from a response.
        /// Must not be null.</param>
        /// <param name="resourceExtractor">Function to extract a sequence of resources from a response.
        /// Must not be null.</param>
        /// <param name="emptyToken">The token to use to detect when there are no more pages available.</param>
        public Paginator(
            Func<TRequest, TToken, TRequest> requestProvider,
            Func<TResponse, TToken> tokenExtractor,
            Func<TResponse, IEnumerable<TResource>> resourceExtractor,
            TToken emptyToken)
        {
            this._requestProvider = Preconditions.CheckNotNull(requestProvider, nameof(requestProvider));
            this._tokenExtractor = Preconditions.CheckNotNull(tokenExtractor, nameof(tokenExtractor));
            this._resourceExtractor = Preconditions.CheckNotNull(resourceExtractor, nameof(resourceExtractor));
            this._emptyToken = emptyToken;
        }

        /// <summary>
        /// Lazily fetches resources a page at a time.
        /// </summary>
        /// <param name="initialRequest">The initial request to send. If this contains a page token,
        /// that token is maintained. This is also passed to the request provider along with a token
        /// to provide another request. (The provider may build a new object, or modify the existing request.)</param>
        /// <param name="responseFetcher">A function to fetch a response containing a page of results given a request.</param>
        /// <returns>A sequence of resources, which are fetched a page at a time. Must not be null.</returns>
        public IEnumerable<TResource> Fetch(TRequest initialRequest, Func<TRequest, TResponse> responseFetcher)
        {
            Preconditions.CheckNotNull(responseFetcher, nameof(responseFetcher));
            TToken token;
            TRequest nextRequest = initialRequest;
            do
            {
                TResponse response = responseFetcher(nextRequest);
                token = _tokenExtractor(response);
                nextRequest = _requestProvider(initialRequest, token);
                foreach (var item in _resourceExtractor(response))
                {
                    yield return item;
                }
            } while (!IsEmptyToken(token));
        }

        /// <summary>
        /// Lazily and asynchronously fetches resources a page at a time.
        /// </summary>
        /// <param name="initialRequest">The initial request to send. If this contains a page token,
        /// that token is maintained. This is also passed to the request provider along with a token
        /// to provide another request. (The provider may build a new object, or modify the existing request.)</param>
        /// <param name="responseFetcher">A function to asynchronously fetch a response containing a page of
        /// results given a request. Must not be null</param>
        /// <returns>A sequence of resources, which are fetched asynchronously and a page at a time.</returns>
        public IAsyncEnumerable<TResource> FetchAsync(TRequest initialRequest, Func<TRequest, CancellationToken, Task<TResponse>> responseFetcher)
        {
            Preconditions.CheckNotNull(responseFetcher, nameof(responseFetcher));
            TRequest nextRequest = initialRequest;
            bool done = false;
            return new PagingAsyncEnumerable<TResource>(async cancellationToken =>
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (done)
                {
                    return null;
                }
                TResponse response = await responseFetcher(nextRequest, cancellationToken).ConfigureAwait(false);
                TToken token = _tokenExtractor(response);
                done = IsEmptyToken(token);
                nextRequest = _requestProvider(initialRequest, token);
                return _resourceExtractor(response);
            });
        }

        private bool IsEmptyToken(TToken token)
        {
            return EqualityComparer<TToken>.Default.Equals(token, _emptyToken);
        }
    }
}
