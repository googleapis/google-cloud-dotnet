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
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.AIPlatform.V1;
using Microsoft.Extensions.AI;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>
/// A builder for <see cref="IRealtimeClient"/> instances that connect to Vertex AI live models.
/// </summary>
/// <remarks>
/// <para>
/// This builder configures credentials, endpoint, and model settings for realtime
/// (WebSocket-based) Vertex AI sessions. It does not create gRPC channels; the
/// inherited gRPC-specific properties (<see cref="ClientBuilderBase{IRealtimeClient}.CallInvoker"/>,
/// <see cref="ClientBuilderBase{IRealtimeClient}.ChannelCredentials"/>, etc.) are not supported
/// and will cause <see cref="Validate"/> to throw if set.
/// </para>
/// </remarks>
#if NET8_0_OR_GREATER
[System.Diagnostics.CodeAnalysis.Experimental("MEAI001")]
#endif
public sealed class PredictionServiceRealtimeClientBuilder : ClientBuilderBase<IRealtimeClient>
{
    /// <summary>
    /// The default model ID to use for realtime sessions if not specified in
    /// <see cref="RealtimeSessionOptions.Model"/>.
    /// This should generally be the full resource name of the model, e.g.
    /// "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </summary>
    public string? DefaultModelId { get; set; }

    /// <summary>Creates a new builder with default settings.</summary>
    public PredictionServiceRealtimeClientBuilder() : base(PredictionServiceClient.ServiceMetadata)
    {
    }

    /// <inheritdoc />
    public override IRealtimeClient Build()
    {
        Validate();
        return BuildImpl();
    }

    /// <inheritdoc />
    public override Task<IRealtimeClient> BuildAsync(CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return Task.FromCanceled<IRealtimeClient>(cancellationToken);
        }

        Validate();
        return Task.FromResult(BuildImpl());
    }

    /// <inheritdoc />
    protected override void Validate()
    {
        base.Validate();

        // Reject gRPC-specific properties that are not applicable to WebSocket-based realtime sessions.
        GaxPreconditions.CheckState(CallInvoker is null,
            $"{nameof(CallInvoker)} is not supported for realtime clients. Configure credentials and endpoint instead.");
        GaxPreconditions.CheckState(ChannelCredentials is null,
            $"{nameof(ChannelCredentials)} is not supported for realtime clients. Use {nameof(GoogleCredential)} or {nameof(Credential)} instead.");
        GaxPreconditions.CheckState(GrpcAdapter is null,
            $"{nameof(GrpcAdapter)} is not supported for realtime clients.");
    }

    private IRealtimeClient BuildImpl()
    {
        ICredential? credential = GoogleCredential ?? Credential;

#pragma warning disable CS0618 // JsonCredentials is obsolete but still used by consumers
        if (credential is null && !string.IsNullOrWhiteSpace(JsonCredentials))
        {
            credential = Google.Apis.Auth.OAuth2.GoogleCredential.FromJson(JsonCredentials);
        }
#pragma warning restore CS0618

        if (credential is Google.Apis.Auth.OAuth2.GoogleCredential gc)
        {
            gc = gc.CreateScoped(Scopes ?? PredictionServiceClient.DefaultScopes);
            if (!string.IsNullOrWhiteSpace(QuotaProject))
            {
                gc = gc.CreateWithQuotaProject(QuotaProject);
            }
            credential = gc;
        }

        // Build the version header including standard GAX/GAPIC components.
        var settings = new PredictionServiceSettings();
        settings.VersionHeaderBuilder.AppendAssemblyVersion("gccl", typeof(VertexAIExtensions));
        string versionHeader = settings.VersionHeaderBuilder.ToString();

        return new PredictionServiceRealtimeClient(
            credential, Endpoint, QuotaProject, versionHeader, DefaultModelId);
    }

    private static readonly ChannelPool s_channelPool = new(PredictionServiceClient.ServiceMetadata);

    /// <inheritdoc />
    protected override ChannelPool GetChannelPool() => s_channelPool;
}
