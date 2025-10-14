// Copyright 2025 Google LLC
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

using Google.Cloud.AIPlatform.V1;
using Google.Cloud.ClientTesting;
using Microsoft.Extensions.AI;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.VertexAI.Extensions.Tests;

public class VertexAIExtensionsTest
{
    private static readonly string? s_projectId = TestEnvironment.GetTestProjectId();
    private static readonly string? s_location = TestEnvironment.GetProjectLocationId();

    [Fact]
    public async Task AsIChatClient_BasicRequestResponse_NonStreaming()
    {
        IChatClient client = (await CreateClientAsync()).AsIChatClient(EndpointName.FormatProjectLocationPublisherModel(s_projectId, s_location, "google", "gemini-2.5-pro"));
        Assert.NotNull(client);

        var response = await client.GetResponseAsync("Hello");
        Assert.NotNull(response);
        Assert.NotEmpty(response.Text);
    }

    [Fact]
    public async Task AsIChatClient_BasicRequestResponse_Streaming()
    {
        IChatClient client = (await CreateClientAsync()).AsIChatClient(EndpointName.FormatProjectLocationPublisherModel(s_projectId, s_location, "google", "gemini-2.5-pro"));
        Assert.NotNull(client);

        ChatResponse response = await client.GetStreamingResponseAsync("Hello").ToChatResponseAsync();
        Assert.NotNull(response);
        Assert.NotEmpty(response.Text);
    }

    [Fact]
    public async Task AsIEmbeddingGenerator_EmbedSeveralInputs()
    {
        IEmbeddingGenerator<string, Embedding<float>> generator = (await CreateClientAsync()).AsIEmbeddingGenerator(EndpointName.FormatProjectLocationPublisherModel(s_projectId, s_location, "google", "gemini-embedding-001"));
        Assert.NotNull(generator);

        GeneratedEmbeddings<Embedding<float>> embeddings = await generator.GenerateAsync(["Hello", "World"]);
        Assert.NotNull(embeddings);
        Assert.Equal(2, embeddings.Count);
        foreach (var embedding in embeddings)
        {
            Assert.NotNull(embedding);
            Assert.InRange(embedding.Vector.Length, 1, int.MaxValue);
        }
    }

    [Fact]
    public async Task AsIImageGenerator_GenerateImage()
    {
        IImageGenerator generator = (await CreateClientAsync()).AsIImageGenerator(EndpointName.FormatProjectLocationPublisherModel(s_projectId, s_location, "google", "imagen-4.0-fast-generate-001"));
        Assert.NotNull(generator);

        ImageGenerationResponse response = await generator.GenerateImagesAsync("A cute baby sea otter");

        Assert.NotNull(response);
        DataContent image = Assert.Single(response.Contents.OfType<DataContent>());
        Assert.Equal("image/png", image.MediaType);
        Assert.InRange(image.Data.Length, 1, int.MaxValue);
    }

    private static Task<PredictionServiceClient> CreateClientAsync() =>
        PredictionServiceClient.CreateAsync();
}

