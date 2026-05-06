#pragma warning disable MEAI001 // Experimental AI API

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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.AIPlatform.V1;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using GTypes = Google.Cloud.VertexAI.Extensions.Live;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides an <see cref="IRealtimeClient"/> implementation for Vertex AI live models.</summary>
#if NET8_0_OR_GREATER
[System.Diagnostics.CodeAnalysis.Experimental("MEAI001")]
#endif
internal sealed class PredictionServiceRealtimeClient : IRealtimeClient
{
    private readonly ICredential? _credential;
    private readonly string? _endpoint;
    private readonly string? _quotaProject;
    private readonly string? _versionHeader;
    private readonly string? _defaultModelId;
    private ChatClientMetadata? _metadata;

    internal PredictionServiceRealtimeClient(
        ICredential? credential, string? endpoint, string? quotaProject,
        string? versionHeader, string? defaultModelId)
    {
        _credential = credential;
        _endpoint = endpoint;
        _quotaProject = quotaProject;
        _versionHeader = versionHeader;
        _defaultModelId = defaultModelId;
    }

    /// <inheritdoc />
    public async Task<IRealtimeClientSession> CreateSessionAsync(
        RealtimeSessionOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        string requestedModel = options?.Model ?? _defaultModelId ??
            throw new InvalidOperationException(
                "No model specified. Provide a model via RealtimeSessionOptions.Model or the defaultModelId parameter.");

        GTypes.Client client = CreateLiveClient(requestedModel);
        GTypes.AsyncSession? asyncSession = null;
        try
        {
            GTypes.LiveConnectConfig config = BuildLiveConnectConfig(options);
            asyncSession = await client.Live.ConnectAsync(requestedModel, config, cancellationToken).ConfigureAwait(false);

            // Drain the protocol-level setup acknowledgment so callers only observe MEAI messages.
            var setupResponse = await asyncSession.ReceiveAsync(cancellationToken).ConfigureAwait(false);
            if (setupResponse?.SetupComplete is null)
            {
                throw new InvalidOperationException(
                    "Expected SetupComplete from the Vertex AI live server after connection, but received an unexpected message.");
            }

            return new PredictionServiceRealtimeSession(asyncSession, client, requestedModel, options);
        }
        catch
        {
            if (asyncSession is not null)
            {
                await asyncSession.DisposeAsync().ConfigureAwait(false);
            }
            await client.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    /// <inheritdoc />
    public object? GetService(System.Type serviceType, object? serviceKey = null)
    {
        GaxPreconditions.CheckNotNull(serviceType, nameof(serviceType));

        if (serviceKey is null)
        {
            if (serviceType == typeof(ChatClientMetadata))
            {
                return _metadata ??= new(
                    VertexAIExtensions.ProviderName,
                    VertexAIExtensions.ProviderUrl,
                    VertexAIExtensions.ExtractModelIdFromResourceName(_defaultModelId));
            }

            if (serviceType.IsInstanceOfType(this))
            {
                return this;
            }
        }

        return null;
    }

    /// <inheritdoc />
    void IDisposable.Dispose() { /* nop */ }

    /// <summary>Converts MEAI session options to a <see cref="GTypes.LiveConnectConfig"/>.</summary>
    internal static GTypes.LiveConnectConfig BuildLiveConnectConfig(RealtimeSessionOptions? options)
    {
        var config = new GTypes.LiveConnectConfig();

        if (options is null)
        {
            config.ResponseModalities = new List<string> { GTypes.Modality.Audio };
            config.RealtimeInputConfig = new GTypes.RealtimeInputConfig
            {
                AutomaticActivityDetection = new GTypes.AutomaticActivityDetection { Disabled = true }
            };
            return config;
        }

        if (options.SessionKind == RealtimeSessionKind.Transcription)
        {
            return BuildTranscriptionConnectConfig(options);
        }

        if (!string.IsNullOrEmpty(options.Instructions))
        {
            config.SystemInstruction = new GTypes.Content
            {
                Parts = new List<GTypes.Part> { new() { Text = options.Instructions } },
                Role = "system"
            };
        }

        if (options.OutputModalities is { Count: > 0 })
        {
            config.ResponseModalities = new List<string>();
            foreach (string modality in options.OutputModalities)
            {
                config.ResponseModalities.Add(modality.ToLowerInvariant() switch
                {
                    "audio" => GTypes.Modality.Audio,
                    "text" => GTypes.Modality.Text,
                    _ => GTypes.Modality.Text,
                });
            }
        }
        else
        {
            config.ResponseModalities = new List<string> { GTypes.Modality.Audio };
        }

        if (!string.IsNullOrEmpty(options.Voice))
        {
            config.SpeechConfig = new GTypes.SpeechConfig
            {
                VoiceConfig = new GTypes.VoiceConfig
                {
                    PrebuiltVoiceConfig = new GTypes.PrebuiltVoiceConfig
                    {
                        VoiceName = options.Voice,
                    }
                }
            };
        }

        if (options.MaxOutputTokens.HasValue)
        {
            config.GenerationConfig ??= new GTypes.GenerationConfig();
            config.GenerationConfig.MaxOutputTokens = options.MaxOutputTokens.Value;
        }

        if (options.Tools is { Count: > 0 })
        {
            var functionDeclarations = new List<GTypes.FunctionDeclaration>();
            foreach (AITool tool in options.Tools)
            {
                if (tool is AIFunction aiFunction)
                {
                    functionDeclarations.Add(PredictionServiceRealtimeSession.ToGoogleFunctionDeclaration(aiFunction));
                }
            }

            if (functionDeclarations.Count > 0)
            {
                config.Tools = new List<GTypes.Tool>
                {
                    new() { FunctionDeclarations = functionDeclarations }
                };
            }
        }

        if (options.TranscriptionOptions is not null)
        {
            var inputTranscriptionConfig = new GTypes.AudioTranscriptionConfig();
            if (!string.IsNullOrEmpty(options.TranscriptionOptions.SpeechLanguage))
            {
                inputTranscriptionConfig.LanguageCodes = new List<string> { options.TranscriptionOptions.SpeechLanguage! };
            }
            config.InputAudioTranscription = inputTranscriptionConfig;
            config.OutputAudioTranscription = new GTypes.AudioTranscriptionConfig();
        }

        // Vertex AI does not support audioStreamEnd, so automatic activity detection
        // cannot reliably signal end-of-input. Force manual mode with explicit
        // ActivityStart/ActivityEnd framing, which is the only reliable way to
        // trigger model responses on Vertex AI. The activityHandling setting
        // (interruption behavior) is still honored in manual mode.
        config.RealtimeInputConfig = new GTypes.RealtimeInputConfig
        {
            AutomaticActivityDetection = new GTypes.AutomaticActivityDetection { Disabled = true }
        };
        if (options.VoiceActivityDetection is { Enabled: true } vad)
        {
            config.RealtimeInputConfig.ActivityHandling = vad.AllowInterruption ?
                GTypes.ActivityHandling.StartOfActivityInterrupts :
                GTypes.ActivityHandling.NoInterruption;
        }

        return config;
    }

    private GTypes.Client CreateLiveClient(string model)
    {
        EndpointName.TryParse(model, out EndpointName? endpointName);

        string? project = endpointName?.ProjectId ?? System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_PROJECT");
        string? location = endpointName?.LocationId ??
            TryExtractLocationFromEndpoint(_endpoint) ??
            System.Environment.GetEnvironmentVariable("GOOGLE_CLOUD_LOCATION");

        if (string.IsNullOrWhiteSpace(project) || string.IsNullOrWhiteSpace(location))
        {
            throw new InvalidOperationException(
                "Unable to determine the Vertex AI project and location for the realtime session. " +
                "Use a full model resource name or configure GOOGLE_CLOUD_PROJECT and GOOGLE_CLOUD_LOCATION.");
        }

        GTypes.HttpOptions httpOptions = new()
        {
            ApiVersion = "v1beta1",
        };

        if (!string.IsNullOrWhiteSpace(_endpoint))
        {
            httpOptions.BaseUrl = _endpoint!.IndexOf(Uri.SchemeDelimiter, StringComparison.OrdinalIgnoreCase) >= 0 ?
                _endpoint :
                $"{Uri.UriSchemeHttps}{Uri.SchemeDelimiter}{_endpoint}";
        }

        if (!string.IsNullOrWhiteSpace(_quotaProject))
        {
            (httpOptions.Headers ??= [])[ "x-goog-user-project" ] = _quotaProject!;
        }

        if (!string.IsNullOrWhiteSpace(_versionHeader))
        {
            (httpOptions.Headers ??= [])[ "x-goog-api-client" ] = _versionHeader!;
        }

        return new GTypes.Client(
            vertexAI: true,
            credential: _credential,
            project: project,
            location: location,
            httpOptions: httpOptions);
    }

    private static string? TryExtractLocationFromEndpoint(string? endpoint)
    {
        if (string.IsNullOrWhiteSpace(endpoint))
        {
            return null;
        }

        string trimmedEndpoint = endpoint!.StartsWith($"{Uri.UriSchemeHttps}{Uri.SchemeDelimiter}", StringComparison.OrdinalIgnoreCase) ?
            endpoint.Substring($"{Uri.UriSchemeHttps}{Uri.SchemeDelimiter}".Length) :
            endpoint;

        int portSeparator = trimmedEndpoint.IndexOf(':');
        if (portSeparator >= 0)
        {
            trimmedEndpoint = trimmedEndpoint.Substring(0, portSeparator);
        }

        const string suffix = "-aiplatform.googleapis.com";
        return trimmedEndpoint.EndsWith(suffix, StringComparison.OrdinalIgnoreCase) && trimmedEndpoint.Length > suffix.Length ?
            trimmedEndpoint.Substring(0, trimmedEndpoint.Length - suffix.Length) :
            null;
    }

    /// <summary>Builds a minimal <see cref="GTypes.LiveConnectConfig"/> for transcription-only sessions.</summary>
    private static GTypes.LiveConnectConfig BuildTranscriptionConnectConfig(RealtimeSessionOptions options)
    {
        var config = new GTypes.LiveConnectConfig
        {
            ResponseModalities = new List<string> { GTypes.Modality.Text },
        };

        var transcriptionConfig = new GTypes.AudioTranscriptionConfig();
        if (!string.IsNullOrEmpty(options.TranscriptionOptions?.SpeechLanguage))
        {
            transcriptionConfig.LanguageCodes = new List<string> { options.TranscriptionOptions!.SpeechLanguage! };
        }
        config.InputAudioTranscription = transcriptionConfig;
        config.RealtimeInputConfig = new GTypes.RealtimeInputConfig();

        if (options.VoiceActivityDetection is { Enabled: true } vad)
        {
            config.RealtimeInputConfig.AutomaticActivityDetection = new GTypes.AutomaticActivityDetection { Disabled = false };
            config.RealtimeInputConfig.ActivityHandling = vad.AllowInterruption ?
                GTypes.ActivityHandling.StartOfActivityInterrupts :
                GTypes.ActivityHandling.NoInterruption;
        }
        else
        {
            config.RealtimeInputConfig.AutomaticActivityDetection = new GTypes.AutomaticActivityDetection { Disabled = true };
        }

        return config;
    }
}
