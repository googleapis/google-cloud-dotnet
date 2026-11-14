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
using Google.Apis.Auth.OAuth2;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.AIPlatform.V1.IntegrationTests;

[Collection(nameof(AIPlatformFixture))]
public class PredictionServiceHttpBodyIntegrationTest
{
    private readonly AIPlatformFixture _fixture;

    public PredictionServiceHttpBodyIntegrationTest(AIPlatformFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task RawPredict_JsonPayload_ThrowsRpcExceptionDueToPayloadWrapping()
    {
        var projectId = _fixture.ProjectId;

        var client = new PredictionServiceClientBuilder
        {
            Endpoint = "us-central1-aiplatform.googleapis.com",
            GrpcAdapter = RestGrpcAdapter.Default,
        }.Build();

        string jsonPayload = "{\"instances\":[{\"content\":\"Hello world\"}]}";
        var request = new RawPredictRequest
        {
            Endpoint = $"projects/{projectId}/locations/us-central1/publishers/google/models/text-embedding-004",
            HttpBody = new HttpBody
            {
                ContentType = "application/json",
                Data = ByteString.CopyFromUtf8(jsonPayload)
            }
        };

        var ex = await Assert.ThrowsAsync<RpcException>(() => client.RawPredictAsync(request));
        Assert.Equal(StatusCode.FailedPrecondition, ex.StatusCode);
        // Models set the schema they are expecting and this model is expecting a JSON schema with a repeated "instances" field.
        // This is what we attempted as our JSON payload.
        Assert.Equal("instances is empty.", ex.Status.Detail);
    }

    [Fact]
    public async Task RawPredict_DirectHttp_Succeeds()
    {
        var projectId = _fixture.ProjectId;
        string rawRequestPayload = "{\"instances\":[{\"content\":\"Hello world\"}]}";

        var cred = await GoogleCredential.GetApplicationDefaultAsync();
        var scopedCred = cred.CreateScoped("https://www.googleapis.com/auth/cloud-platform");
        var token = await scopedCred.UnderlyingCredential.GetAccessTokenForRequestAsync("https://us-central1-aiplatform.googleapis.com");

        using var httpClient = new HttpClient();
        var liveHttpRequest = new HttpRequestMessage(
            HttpMethod.Post,
            $"https://us-central1-aiplatform.googleapis.com/v1/projects/{projectId}/locations/us-central1/publishers/google/models/text-embedding-004:rawPredict");
        liveHttpRequest.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");
        liveHttpRequest.Headers.ExpectContinue = false;
        // The content is the raw JSON. This works, this is what we should do in REGAPIC and it's what
        // we can imply from the HttpBody message documentation.
        liveHttpRequest.Content = new StringContent(rawRequestPayload, Encoding.UTF8, "application/json");

        var liveHttpResponse = await httpClient.SendAsync(liveHttpRequest);
        Assert.Equal(HttpStatusCode.OK, liveHttpResponse.StatusCode);

        string responseContent = await liveHttpResponse.Content.ReadAsStringAsync();
        string responseContentType = liveHttpResponse.Content.Headers.ContentType.MediaType;
        // Sanity check asserts to make sure the service replied with some valid content.
        Assert.Contains("predictions", responseContent);
        Assert.Equal("application/json", responseContentType);
    }

    [Fact]
    public async Task RawPredict_RealHttpBodyResponse_Unsupported()
    {
        var projectId = _fixture.ProjectId;
        string rawRequestPayload = "{\"instances\":[{\"content\":\"Hello world\"}]}";

        (string realResponseContent, string realResponseContentType) = await GetRealResponseAsync();

        // Set up the mock server to reply with the same valid response we got from the service.
        using var mockServer = new MockHttpServer
        {
            ResponseContentType = realResponseContentType,
            ResponseContent = realResponseContent
        };

        // This request goes to the mock server so we don't care much about it.
        var request = new RawPredictRequest
        {
            Endpoint = $"projects/{projectId}/locations/us-central1/publishers/google/models/text-embedding-004",
            HttpBody = new HttpBody
            {
                ContentType = "application/json",
                Data = ByteString.CopyFromUtf8(rawRequestPayload)
            }
        };
        var regapicClient = new PredictionServiceClientBuilder
        {
            Endpoint = $"http://{mockServer.Endpoint}",
            GrpcAdapter = RestGrpcAdapter.Default,
            ChannelCredentials = ChannelCredentials.Insecure
        }.Build();

        // We actually get a response, because the content type of the response is set to "application/json".
        HttpBody parsedHttpBody = await regapicClient.RawPredictAsync(request);

        // The real service returned a non-empty predictions JSON string, but REGAPIC parsed it as an HttpBody proto message.
        // Because the JSON has "predictions" instead of {"contentType":"...", "data":"..."},
        // REGAPIC returned an empty HttpBody with Data.Length == 0 and ContentType == "", losing the response!
        Assert.NotNull(parsedHttpBody);
        Assert.Empty(parsedHttpBody.Data);
        Assert.Empty(parsedHttpBody.ContentType);

        async Task<(string, string)> GetRealResponseAsync()
        {
            // Make a raw HTTP request so we get a real valid response that we can use to then mock
            // a response for a REGAPIC client.
            // We need to do this because there's no endpoint that's easy to call that recieves a
            // non-HttpBody request but returns an HttpBody response. So we cannot obtain a real response
            // using a REGAPIC client.
            var cred = await GoogleCredential.GetApplicationDefaultAsync();
            var scopedCred = cred.CreateScoped("https://www.googleapis.com/auth/cloud-platform");
            var token = await scopedCred.UnderlyingCredential.GetAccessTokenForRequestAsync("https://us-central1-aiplatform.googleapis.com");

            using var httpClient = new HttpClient();
            var liveHttpRequest = new HttpRequestMessage(
                HttpMethod.Post,
                $"https://us-central1-aiplatform.googleapis.com/v1/projects/{projectId}/locations/us-central1/publishers/google/models/text-embedding-004:rawPredict");
            liveHttpRequest.Headers.TryAddWithoutValidation("Authorization", $"Bearer {token}");
            liveHttpRequest.Headers.ExpectContinue = false;
            liveHttpRequest.Content = new StringContent(rawRequestPayload, Encoding.UTF8, "application/json");

            var liveHttpResponse = await httpClient.SendAsync(liveHttpRequest);
            Assert.Equal(HttpStatusCode.OK, liveHttpResponse.StatusCode);

            string realResponseContent = await liveHttpResponse.Content.ReadAsStringAsync();
            string realContentType = liveHttpResponse.Content.Headers.ContentType.MediaType;
            // Sanity check asserts to make sure the service replied with some valid content.
            Assert.Contains("predictions", realResponseContent);
            Assert.Equal("application/json", realContentType);
            return (realResponseContent, realContentType);
        }
    }

    private sealed class MockHttpServer : IDisposable
    {
        private readonly HttpListener _listener;
        private readonly CancellationTokenSource _cts = new();
        private readonly Task _listenTask;

        public string Endpoint { get; }
        public string ResponseContentType { get; set; } = "application/json";
        public string ResponseContent { get; set; } = "{}";

        public MockHttpServer()
        {
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
                    using (var reader = new StreamReader(req.InputStream, req.ContentEncoding ?? Encoding.UTF8))
                    {
                        await reader.ReadToEndAsync().ConfigureAwait(false);
                    }

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
}
