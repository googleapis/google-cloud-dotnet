// Copyright 2026 Google LLC
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

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics.Tests;

/// <summary>
/// Records the target URI and headers of each request and returns an empty 200 response so no request leaves the process.
/// </summary>
internal sealed class RecordingHandler : HttpMessageHandler
{
    private readonly ConcurrentQueue<RecordedRequest> _requests = new();

    internal bool Disposed { get; private set; }

    internal int RequestCount => _requests.Count;

    internal IReadOnlyList<RecordedRequest> Requests => _requests.ToArray();

    internal string GetLastHeader(string name) => _requests.LastOrDefault()?.GetHeader(name);

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
        Task.FromResult(Record(request));

#if NET5_0_OR_GREATER
    // The net8.0 build of the OTLP exporter sends with the synchronous HttpClient.Send.
    protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken) =>
        Record(request);
#endif

    protected override void Dispose(bool disposing)
    {
        Disposed = true;
        base.Dispose(disposing);
    }

    private HttpResponseMessage Record(HttpRequestMessage request)
    {
        var headers = request.Headers.ToDictionary(
            header => header.Key,
            header => string.Join(",", header.Value),
            StringComparer.OrdinalIgnoreCase);
        _requests.Enqueue(new RecordedRequest(request.RequestUri, headers));
        return new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(Array.Empty<byte>()) };
    }

    internal sealed class RecordedRequest(Uri requestUri, Dictionary<string, string> headers)
    {
        internal Uri RequestUri => requestUri;

        internal string GetHeader(string name) => headers.TryGetValue(name, out var value) ? value : null;
    }
}
