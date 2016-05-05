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
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Google.Pubsub.V1
{
    public static class PageStreamingExtensions
    {
        public static IEnumerable<TResource> Flatten<TPageResponse, TResource>(this IPagedEnumerable<TPageResponse, TResource> source)
            where TPageResponse : IPageResponse<TResource> =>
            source.SelectMany(page => page.Items);

        public static IEnumerable<FixedSizePage<TResource, TPageToken>> WithFixedSize<TPageResponse, TResource, TPageToken>(this IPagedEnumerable<TPageResponse, TResource, TPageToken> source, int size)
            where TPageResponse : IPageResponse<TResource, TPageToken>
        {
            TPageToken token = default(TPageToken);
            using (var enumerator = source.GetEnumerator())
            {
                while (true)
                {
                    List<TResource> items = new List<TResource>(size);
                    while (items.Count < size)
                    {
                        if (!enumerator.MoveNext(items.Count - size))
                        {
                            if (items.Count != 0)
                            {
                                // We must have a useful token by now.
                                yield return new FixedSizePage<TResource, TPageToken>(items, token);
                            }
                            yield break;
                        }
                        var page = enumerator.Current;
                        if (items.Count == 0)
                        {
                            token = page.NextPageToken;
                        }
                        items.AddRange(page.Items);
                        if (items.Count > size)
                        {
                            // TODO: Better exception type...
                            throw new Exception("Operation returned too many items!");
                        }
                    }
                }
            }
        }
    }

    public interface IPagedEnumerable<T> : IEnumerable<T>
    {
        new IPagedEnumerator<T> GetEnumerator();
    }

    // Interface which is *just* present to help with type inference in the Flatten method.
    // This is a bit annoying, but not too bad - both bits of information (response and resource types) are
    // useful to the caller.
    public interface IPagedEnumerable<TResponse, TResource> : IPagedEnumerable<TResponse>
    {
    }

    // Interface which is *just* present to help with type inference in the WithFixedSize method.
    // This is really annoying, as the caller really isn't going to care about the page token type.
    // I'd dearly love to work out an alternative to this.
    public interface IPagedEnumerable<TResponse, TResource, TPageToken> : IPagedEnumerable<TResponse, TResource>
    {
    }

    public interface IPagedEnumerator<T> : IEnumerator<T>
    {
        bool MoveNext(int pageSize);
    }

    public interface IPageResponse<TResource>
    {
        IEnumerable<TResource> Items { get; }
    }

    public interface IPageResponse<TResource, TPageToken> : IPageResponse<TResource>
    {
        TPageToken NextPageToken { get; }
    }

    public interface IPageRequest<TPageToken>
    {
        TPageToken PageToken { set; }
        int PageSize { set; }
    }

    public sealed class FixedSizePage<TResource, TPageToken> : IPageResponse<TResource, TPageToken>
    {
        public IEnumerable<TResource> Items { get; }
        public TPageToken NextPageToken { get; }

        public FixedSizePage(IEnumerable<TResource> items, TPageToken nextPageToken)
        {
            Items = items;
            NextPageToken = nextPageToken;
        }
    }

    // Obviously called PageStreamer really...
    public sealed class PageStreamer2<TResource, TRequest, TResponse, TPageToken>
        where TResponse : class, IMessage<TResponse>, IPageResponse<TResource, TPageToken>
        where TRequest : class, IMessage<TRequest>, IPageRequest<TPageToken>
        where TPageToken : IEquatable<TPageToken>
    {
        private readonly TPageToken _emptyPageToken;

        public PageStreamer2(TPageToken emptyPageToken)
        {
            _emptyPageToken = emptyPageToken;
        }

        internal IPagedEnumerable<TResponse, TResource, TPageToken> Fetch(CallSettings callSettings, TRequest request, ApiCall<TRequest, TResponse> apiCall)
            => new PagedEnumerable(callSettings, request, _emptyPageToken, apiCall);

        private class PagedEnumerable : IPagedEnumerable<TResponse, TResource, TPageToken>
        {
            private readonly CallSettings _callSettings;
            private readonly TRequest _request;
            private readonly TPageToken _emptyPageToken;
            private readonly ApiCall<TRequest, TResponse> _apiCall;

            internal PagedEnumerable(CallSettings callSettings, TRequest request, TPageToken emptyPageToken, ApiCall<TRequest, TResponse> apiCall)
            {
                _callSettings = callSettings;
                _request = request;
                _emptyPageToken = emptyPageToken;
                _apiCall = apiCall;
            }

            public IPagedEnumerator<TResponse> GetEnumerator()
                => new PagedEnumerator(_callSettings, _request.Clone(), _emptyPageToken, _apiCall);

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
            IEnumerator<TResponse> IEnumerable<TResponse>.GetEnumerator() => GetEnumerator();
        }

        private class PagedEnumerator : IPagedEnumerator<TResponse>
        {
            private readonly CallSettings _callSettings;
            private readonly TPageToken _emptyPageToken;
            private readonly ApiCall<TRequest, TResponse> _apiCall;
            // Note that although this is readonly, we mutate it...
            private readonly TRequest _request;
            private TResponse _current;
            private bool _finished;

            public PagedEnumerator(CallSettings callSettings, TRequest request, TPageToken emptyPageToken, ApiCall<TRequest, TResponse> apiCall)
            {
                _callSettings = callSettings;
                _request = request;
                _emptyPageToken = emptyPageToken;
                _apiCall = apiCall;
            }

            public TResponse Current => _current;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // Nothing to do
            }

            public bool MoveNext()
            {
                if (_finished)
                {
                    return false;
                }

                _current = _apiCall.Sync(_request, _callSettings);
                var nextPageToken = _current.NextPageToken;
                if (EqualityComparer<TPageToken>.Default.Equals(nextPageToken, _emptyPageToken))
                {
                    // We know this is the last page.
                    _finished = true;
                }
                // Prepare the next request...
                _request.PageToken = nextPageToken;
                return true;
            }

            public bool MoveNext(int pageSize)
            {
                _request.PageSize = pageSize;
                return MoveNext();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
