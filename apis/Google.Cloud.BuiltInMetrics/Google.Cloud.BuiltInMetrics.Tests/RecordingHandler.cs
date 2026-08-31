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

internal sealed class RecordingHandler : HttpMessageHandler
{
    private readonly ConcurrentQueue<RecordedRequest> _requests = new();

    internal bool Disposed { get; private set; }
    internal int RequestCount => _requests.Count;
    internal IReadOnlyList<RecordedRequest> Requests => _requests.ToArray();

    internal string GetLastHeader(string name) => _requests.LastOrDefault()?.GetHeader(name);

    internal static HttpMessageHandler Create(ICollection<RecordingHandler> handlers)
    {
        var handler = new RecordingHandler();
        handlers.Add(handler);
        return handler;
    }

    protected override void Dispose(bool disposing)
    {
        Disposed = true;
        base.Dispose(disposing);
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
        Task.FromResult(RecordAndRespondOk(request));

#if NET5_0_OR_GREATER
    // On .NET 5+, OtlpMetricExporter calls synchronous HttpClient.Send.
    protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken) =>
        RecordAndRespondOk(request);
#endif

    private HttpResponseMessage RecordAndRespondOk(HttpRequestMessage request)
    {
        if (Disposed)
        {
            throw new ObjectDisposedException(nameof(RecordingHandler));
        }
        CaptureRequest(request);
        return CreateEmptyOkResponse();
    }

    private void CaptureRequest(HttpRequestMessage request)
    {
        var allHeaders = request.Content is null
            ? request.Headers
            : request.Headers.Concat(request.Content.Headers);
        var headers = allHeaders.ToDictionary(
            header => header.Key,
            header => string.Join(",", header.Value),
            StringComparer.OrdinalIgnoreCase);
        _requests.Enqueue(new RecordedRequest(request.RequestUri, headers));
    }

    private static HttpResponseMessage CreateEmptyOkResponse() =>
        new(HttpStatusCode.OK) { Content = new ByteArrayContent(Array.Empty<byte>()) };

    internal sealed class RecordedRequest(Uri requestUri, Dictionary<string, string> headers)
    {
        internal Uri RequestUri => requestUri;
        internal string GetHeader(string name) => headers.TryGetValue(name, out var value) ? value : null;
    }
}
