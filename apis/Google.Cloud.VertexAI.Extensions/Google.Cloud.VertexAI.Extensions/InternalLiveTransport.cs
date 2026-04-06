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

using Google.Apis.Auth.OAuth2;
using Google.GenAI.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Google.GenAI;

internal sealed class Client : IAsyncDisposable
{
    internal bool VertexAI { get; }
    internal string? ApiKey { get; }
    internal ICredential? Credential { get; }
    internal string? Project { get; }
    internal string? Location { get; }
    internal HttpOptions HttpOptions { get; }

    public Live Live { get; }

    public Client(bool? vertexAI = null, string? apiKey = null, ICredential? credential = null,
        string? project = null, string? location = null, HttpOptions? httpOptions = null)
    {
        if (vertexAI != true)
        {
            throw new ArgumentException("Only Vertex AI live connections are supported by this implementation.", nameof(vertexAI));
        }

        VertexAI = true;
        ApiKey = apiKey;
        Credential = credential;
        Project = project;
        Location = location;
        HttpOptions = httpOptions ?? new HttpOptions();
        HttpOptions.BaseUrl ??= "https://aiplatform.googleapis.com";
        HttpOptions.ApiVersion ??= "v1beta1";
        Live = new Live(this);
    }

    public ValueTask DisposeAsync() => default;
}

internal sealed class Live(Client client)
{
    private readonly Client _client = client;

    public async Task<AsyncSession> ConnectAsync(string model, LiveConnectConfig config, CancellationToken cancellationToken = default)
    {
        var clientWebSocket = new ClientWebSocket();
        bool success = false;
        try
        {
            await SetRequestHeadersAsync(clientWebSocket, cancellationToken).ConfigureAwait(false);
            Uri serverUri = GetServerUri();
            await clientWebSocket.ConnectAsync(serverUri, cancellationToken).ConfigureAwait(false);

            var setup = new LiveClientMessage
            {
                Setup = BuildSetup(model, config)
            };
            string setupJson = JsonSerializer.Serialize(setup, LiveJsonContext.Default.LiveClientMessage);
            byte[] buffer = Encoding.UTF8.GetBytes(setupJson);
            await clientWebSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Binary, true, cancellationToken).ConfigureAwait(false);

            success = true;
            return new AsyncSession(clientWebSocket);
        }
        finally
        {
            if (!success)
            {
                clientWebSocket.Dispose();
            }
        }
    }

    private async Task SetRequestHeadersAsync(ClientWebSocket clientWebSocket, CancellationToken cancellationToken)
    {
        ICredential? credential = _client.Credential;
        if (credential is null)
        {
            credential = (await GoogleCredential.GetApplicationDefaultAsync(cancellationToken).ConfigureAwait(false))
                .CreateScoped("https://www.googleapis.com/auth/cloud-platform");
        }
        string accessToken = await credential.GetAccessTokenForRequestAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        if (string.IsNullOrEmpty(accessToken))
        {
            throw new InvalidOperationException("Failed to retrieve an access token for the Vertex AI live connection.");
        }
        clientWebSocket.Options.SetRequestHeader("Authorization", $"Bearer {accessToken}");

        foreach (KeyValuePair<string, string> header in _client.HttpOptions.Headers ?? new Dictionary<string, string>())
        {
            clientWebSocket.Options.SetRequestHeader(header.Key, header.Value);
        }
    }

    private Uri GetServerUri()
    {
        string baseUrl = _client.HttpOptions.BaseUrl ??
            throw new InvalidOperationException("BaseUrl is not set for the Vertex AI live connection.");

        var baseUri = new Uri(baseUrl);
        var uriBuilder = new UriBuilder(baseUri)
        {
            Scheme = baseUri.Scheme == "http" ? "ws" : "wss"
        };

        string wsBaseUrl = uriBuilder.Uri.ToString().TrimEnd('/');
        string apiVersion = _client.HttpOptions.ApiVersion ?? "v1beta1";
        return new Uri($"{wsBaseUrl}/ws/google.cloud.aiplatform.{apiVersion}.LlmBidiService/BidiGenerateContent");
    }

    private LiveClientSetup BuildSetup(string model, LiveConnectConfig config)
    {
        string transformedModel = TransformModelName(model);
        if (!transformedModel.StartsWith("projects/", StringComparison.OrdinalIgnoreCase))
        {
            if (string.IsNullOrWhiteSpace(_client.Project) || string.IsNullOrWhiteSpace(_client.Location))
            {
                throw new InvalidOperationException("Project and location are required to build a Vertex AI live model name.");
            }
            transformedModel = $"projects/{_client.Project}/locations/{_client.Location}/{transformedModel}";
        }

        GenerationConfig? generationConfig = config.GenerationConfig ?? new GenerationConfig();
        if (config.ResponseModalities is { Count: > 0 })
        {
            generationConfig.ResponseModalities = config.ResponseModalities;
        }
        if (config.SpeechConfig is not null)
        {
            generationConfig.SpeechConfig = config.SpeechConfig;
        }

        return new LiveClientSetup
        {
            Model = transformedModel,
            GenerationConfig = generationConfig,
            SystemInstruction = config.SystemInstruction,
            Tools = config.Tools,
            InputAudioTranscription = config.InputAudioTranscription,
            OutputAudioTranscription = config.OutputAudioTranscription,
            RealtimeInputConfig = config.RealtimeInputConfig,
        };
    }

    private static string TransformModelName(string model)
    {
        if (model.StartsWith("publishers/", StringComparison.OrdinalIgnoreCase) ||
            model.StartsWith("projects/", StringComparison.OrdinalIgnoreCase) ||
            model.StartsWith("models/", StringComparison.OrdinalIgnoreCase))
        {
            return model;
        }

        if (model.Contains("/"))
        {
            string[] parts = model.Split(new[] { '/' }, 2, StringSplitOptions.RemoveEmptyEntries);
            return $"publishers/{parts[0]}/models/{parts[1]}";
        }

        return $"publishers/google/models/{model}";
    }
}

internal sealed class AsyncSession(WebSocket webSocket) : IAsyncDisposable
{
    private readonly WebSocket _webSocket = webSocket;
    private readonly SemaphoreSlim _sendLock = new(1, 1);
    private readonly SemaphoreSlim _receiveLock = new(1, 1);
    private readonly byte[] _receiveBuffer = new byte[4096];
    private int _isDisposed;

    public Task SendRealtimeInputAsync(LiveSendRealtimeInputParameters realtimeInput, CancellationToken cancellationToken = default) =>
        SendAsync(new LiveClientMessage { RealtimeInput = realtimeInput }, cancellationToken);

    public Task SendClientContentAsync(LiveClientContent clientContent, CancellationToken cancellationToken = default) =>
        SendAsync(new LiveClientMessage { ClientContent = clientContent }, cancellationToken);

    public Task SendToolResponseAsync(LiveSendToolResponseParameters toolResponse, CancellationToken cancellationToken = default) =>
        SendAsync(new LiveClientMessage
        {
            ToolResponse = new LiveClientToolResponse
            {
                FunctionResponses = toolResponse.FunctionResponses
            }
        }, cancellationToken);

    private async Task SendAsync(LiveClientMessage message, CancellationToken cancellationToken)
    {
        bool lockTaken = false;
        try
        {
            await _sendLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            lockTaken = true;

            if (_isDisposed == 1)
            {
                throw new ObjectDisposedException(nameof(AsyncSession));
            }

            string json = JsonSerializer.Serialize(message, LiveJsonContext.Default.LiveClientMessage);
            byte[] bytes = Encoding.UTF8.GetBytes(json);
            await _webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Binary, true, cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            if (lockTaken)
            {
                try
                {
                    _sendLock.Release();
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }
    }

    public async Task<LiveServerMessage?> ReceiveAsync(CancellationToken cancellationToken = default)
    {
        bool lockTaken = false;
        try
        {
            await _receiveLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            lockTaken = true;

            if (_isDisposed == 1)
            {
                return null;
            }

            switch (_webSocket.State)
            {
                case WebSocketState.Connecting:
                    throw new InvalidOperationException("Cannot receive data while the WebSocket is still connecting.");
                case WebSocketState.Open:
                    break;
                default:
                    return null;
            }

            using var messageStream = new MemoryStream();
            WebSocketReceiveResult result;

            do
            {
                result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(_receiveBuffer), cancellationToken).ConfigureAwait(false);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    return null;
                }

                if (result.Count > 0)
                {
                    messageStream.Write(_receiveBuffer, 0, result.Count);
                }
            } while (!result.EndOfMessage);

            if (messageStream.Length == 0)
            {
                return null;
            }

            messageStream.Position = 0;
            return JsonSerializer.Deserialize(messageStream, LiveJsonContext.Default.LiveServerMessage);
        }
        finally
        {
            if (lockTaken)
            {
                try
                {
                    _receiveLock.Release();
                }
                catch (ObjectDisposedException)
                {
                }
            }
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (Interlocked.Exchange(ref _isDisposed, 1) != 0)
        {
            return;
        }

        try
        {
            if (_webSocket.State is WebSocketState.Open or WebSocketState.CloseReceived)
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", cts.Token).ConfigureAwait(false);
            }
        }
        catch
        {
        }
        finally
        {
            _webSocket.Dispose();
            _sendLock.Dispose();
            _receiveLock.Dispose();
        }
    }
}
