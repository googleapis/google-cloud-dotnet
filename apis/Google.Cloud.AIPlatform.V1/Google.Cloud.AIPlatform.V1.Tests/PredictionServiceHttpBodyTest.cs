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

using Google.Api;
using Google.Api.Gax.Grpc.Rest;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests;

public class PredictionServiceHttpBodyTest
{
    [Fact]
    public async Task RawPredict_TextPayload_SentAsJsonSerializedRawPredictRequest()
    {
        using var server = new MockHttpServer();
        // Configure mock server to return a JSON-encoded HttpBody containing the expected response string.
        // Note: this is not what happens in real life, but here we are just testing for the request.
        // See furhter tests for what happens with the response.
        server.ResponseContent = JsonFormatter.Default.Format(new HttpBody
        {
            ContentType = "text/plain",
            Data = ByteString.CopyFromUtf8("Once upon a time...")
        });

        // Create a protobuf request that should be transcoded as follows:
        // - Endpoint is parth of the URI path.
        // - HttpBody.ContentType is set as the value for the content type header.
        // - HttpBody.Data should be included on the body of the request as the raw binary.
        var request = new RawPredictRequest
        {
            Endpoint = "projects/test-project/locations/us-central1/publishers/google/models/test-model",
            HttpBody = new HttpBody
            {
                ContentType = "text/plain",
                Data = ByteString.CopyFromUtf8("Generate a story")
            }
        };

        var client = CreateRestClient(server.Endpoint);
        var _ = await client.RawPredictAsync(request);

        Assert.NotNull(server.ReceivedRequest);
        Assert.Equal("POST", server.ReceivedRequest.Method);
        Assert.StartsWith("/v1/projects/test-project/locations/us-central1/publishers/google/models/test-model:rawPredict", server.ReceivedRequest.Path);
        // The content type should have been "text/plain", instead, we sent "application/json".
        Assert.DoesNotContain("text/plain", server.ReceivedRequest.ContentType);
        // The body should have been the raw "Hello Vertex AI raw prediction", instead
        // it's a JSON serialized RawPredictRequest instance equal to the request we built.
        Assert.Equal(JsonFormatter.Default.Format(request), server.ReceivedRequest.Body);
    }

    [Fact]
    public async Task RawPredict_JsonPayload_SentAsJsonSerializedRawPredictRequest()
    {
        using var server = new MockHttpServer();
        // Configure mock server to return a JSON-encoded HttpBody containing the expected response string.
        // Note: this is not what happens in real life, but here we are just testing for the request.
        // See furhter tests for what happens with the response.
        server.ResponseContent = JsonFormatter.Default.Format(new HttpBody
        {
            ContentType = "text/plain",
            Data = ByteString.CopyFromUtf8("Once upon a time...")
        });

        // Create a protobuf request that should be transcoded as follows:
        // - Endpoint is parth of the URI path.
        // - HttpBody.ContentType is set as the value for the content type header.
        // - HttpBody.Data should be included on the body of the request as the raw binary.
        var request = new RawPredictRequest
        {
            Endpoint = "projects/test-project/locations/us-central1/publishers/google/models/test-model",
            HttpBody = new HttpBody
            {
                ContentType = "application/json",
                Data = ByteString.CopyFromUtf8("{\"prompt\": \"Generate a story\"}")
            }
        };

        var client = CreateRestClient(server.Endpoint);
        var _ = await client.RawPredictAsync(request);

        Assert.NotNull(server.ReceivedRequest);
        Assert.Equal("POST", server.ReceivedRequest.Method);
        Assert.StartsWith("/v1/projects/test-project/locations/us-central1/publishers/google/models/test-model:rawPredict", server.ReceivedRequest.Path);
        // The content type is "application/json" but that's just what we send for everything.
        Assert.Contains("application/json", server.ReceivedRequest.ContentType);
        // The body should have been the raw "{\"prompt\": \"Generate a story\"}", instead
        // it's a JSON serialized RawPredictRequest instance equal to the request we built.
        Assert.Equal(JsonFormatter.Default.Format(request), server.ReceivedRequest.Body);
    }

    [Fact]
    public async Task RawPredict_TextResponse_FailsParsing()
    {
        using var server = new MockHttpServer();
        // Configure mock server to return a response with a plain text body content.
        server.ResponseContentType = "text/plain";
        server.ResponseContent = "Once upon a time...";

        // We don't care about the request here.
        var request = new RawPredictRequest
        {
            Endpoint = "projects/test-project/locations/us-central1/publishers/google/models/test-model",
            HttpBody = new HttpBody
            {
                ContentType = "text/plain",
                Data = ByteString.CopyFromUtf8("Generate a story")
            }
        };

        var client = CreateRestClient(server.Endpoint);
        // REGAPIC tries to parse the response body as a JSON-serialized HttpBody message using JsonParser,
        // which fails with InvalidJsonException when the response is not valid JSON.
        await Assert.ThrowsAsync<InvalidJsonException>(() => client.RawPredictAsync(request));
    }

    [Fact]
    public async Task RawPredict_NonHttpBodyJsonResponse_ParsesEmptyHttpResponse()
    {
        string expectedResponseContent = "{\"prediction\": \"Once upon a time...\"}";
        using var server = new MockHttpServer();
        // Configure mock server to return a response with a plain text body content.
        server.ResponseContentType = "application/json";
        server.ResponseContent = expectedResponseContent;

        // We don't care about the request here.
        var request = new RawPredictRequest
        {
            Endpoint = "projects/test-project/locations/us-central1/publishers/google/models/test-model",
            HttpBody = new HttpBody
            {
                ContentType = "text/plain",
                Data = ByteString.CopyFromUtf8("Generate a story")
            }
        };

        var client = CreateRestClient(server.Endpoint);
        HttpBody response = await client.RawPredictAsync(request);

        // We parsed the response but the fields are all empty. The Protobuf JsonParser used by REGAPIC
        // is configured to ignore (and not fail) unknown fields, which is all we got on the response.
        Assert.Empty(response.Data);
        Assert.Empty(response.ContentType);
    }


    private static PredictionServiceClient CreateRestClient(string endpoint)
    {
        return new PredictionServiceClientBuilder
        {
            Endpoint = endpoint.StartsWith("http://") || endpoint.StartsWith("https://") ? endpoint : $"http://{endpoint}",
            GrpcAdapter = RestGrpcAdapter.Default,
            ChannelCredentials = ChannelCredentials.Insecure
        }.Build();
    }

    private sealed class MockHttpServer : IDisposable
    {
        private readonly HttpListener _listener;
        private readonly CancellationTokenSource _cts = new();
        private readonly Task _listenTask;

        public string Endpoint { get; }
        public string ResponseContentType { get; set; } = "application/json";
        public string ResponseContent { get; set; } = "{}";
        public ReceivedHttpRequest ReceivedRequest { get; private set; }

        public MockHttpServer()
        {
            // This attempts to acquire a free port to use for
            // our listener. Note there's a small race condition
            // that may happen when the port is released and before
            // it's acutally used by the HttpListener.
            var tcp = new TcpListener(IPAddress.Loopback, 0);
            tcp.Start();
            int port = ((IPEndPoint)tcp.LocalEndpoint).Port;
            tcp.Stop();

            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://127.0.0.1:{port}/");
            _listener.Start();
            Endpoint = $"127.0.0.1:{port}";
            _listenTask = Task.Run(ListenLoop);
        }

        private async Task ListenLoop()
        {
            while (!_cts.Token.IsCancellationRequested && _listener.IsListening)
            {
                try
                {
                    var context = await _listener.GetContextAsync().ConfigureAwait(false);
                    var req = context.Request;
                    string body;
                    using (var reader = new StreamReader(req.InputStream, req.ContentEncoding ?? Encoding.UTF8))
                    {
                        body = await reader.ReadToEndAsync().ConfigureAwait(false);
                    }
                    ReceivedRequest = new ReceivedHttpRequest(req.HttpMethod, req.RawUrl, req.ContentType, body);

                    context.Response.ContentType = ResponseContentType;
                    byte[] responseBytes = Encoding.UTF8.GetBytes(ResponseContent);
                    context.Response.ContentLength64 = responseBytes.Length;
                    await context.Response.OutputStream.WriteAsync(responseBytes, 0, responseBytes.Length).ConfigureAwait(false);
                    context.Response.OutputStream.Close();
                }
                catch (ObjectDisposedException)
                {
                    break;
                }
                catch (HttpListenerException)
                {
                    break;
                }
                catch (Exception) when (_cts.Token.IsCancellationRequested)
                {
                    break;
                }
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
            try { _listener.Stop(); } catch { }
            try { _listener.Close(); } catch { }
            _cts.Dispose();
        }
    }

    public sealed class ReceivedHttpRequest
    {
        public string Method { get; }
        public string Path { get; }
        public string ContentType { get; }
        public string Body { get; }

        public ReceivedHttpRequest(string method, string path, string contentType, string body)
        {
            Method = method;
            Path = path;
            ContentType = contentType;
            Body = body;
        }
    }
}
