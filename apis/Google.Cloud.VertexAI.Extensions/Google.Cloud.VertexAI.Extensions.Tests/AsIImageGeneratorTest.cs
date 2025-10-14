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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.AI;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Value = Google.Protobuf.WellKnownTypes.Value;

namespace Google.Cloud.VertexAI.Extensions.Tests;

public class AsIImageGeneratorTest
{
    [Fact]
    public void AsIImageGenerator_ValidArguments_CreatesIImageGeneratorSuccessfully()
    {
        PredictionServiceClient client = CreateClient();
        IImageGenerator generator = client.AsIImageGenerator();
        Assert.NotNull(generator);
        Assert.Same(client, generator.GetService<PredictionServiceClient>());
    }

    [Fact]
    public void BuildIImageGenerator_ValidArguments_CreatesIImageGeneratorSuccessfully()
    {
        IImageGenerator generator = new PredictionServiceClientBuilder() { ApiKey = "fake-api-key" }.BuildIImageGenerator();
        Assert.NotNull(generator.GetService<PredictionServiceClient>());
    }


    [Fact]
    public void AsIImageGenerator_InvalidArguments_Throws()
    {
        Assert.Throws<ArgumentNullException>("client", () => VertexAIExtensions.AsIImageGenerator(null!));
    }

    [Fact]
    public void IImageGenerator_GetService_InvalidArguments_Throws()
    {
        PredictionServiceClient client = CreateClient();

        IImageGenerator imageGenerator = client.AsIImageGenerator();
        Assert.NotNull(imageGenerator);

        Assert.Throws<ArgumentNullException>("serviceType", () => imageGenerator.GetService(null!));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/fakemodel")]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/imagen-3.0-generate-001")]
    public void IImageGenerator_GetService_ReturnsExpectedInstance(string? defaultModelId)
    {
        PredictionServiceClient client = CreateClient();

        IImageGenerator imageGenerator = client.AsIImageGenerator(defaultModelId);
        Assert.NotNull(imageGenerator);

        Assert.Same(client, imageGenerator.GetService<PredictionServiceClient>());

        Assert.Same(imageGenerator, imageGenerator.GetService<IImageGenerator>());
        Assert.Same(imageGenerator, imageGenerator.GetService<IDisposable>());

        ImageGeneratorMetadata? metadata = imageGenerator.GetService<ImageGeneratorMetadata>();
        Assert.NotNull(metadata);
        Assert.Equal("gcp.vertex_ai", metadata.ProviderName);
        Assert.Equal(new("https://aiplatform.googleapis.com:443"), metadata.ProviderUri);
        Assert.Equal(defaultModelId?.Substring(defaultModelId.LastIndexOf('/') + 1), metadata.DefaultModelId);
    }

    [Fact]
    public void IImageGenerator_Dispose_Nop()
    {
        PredictionServiceClient client = CreateClient();

        IImageGenerator imageGenerator = client.AsIImageGenerator();
        Assert.NotNull(imageGenerator);

        imageGenerator.Dispose();

        Assert.Same(client, imageGenerator.GetService<PredictionServiceClient>());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_BasicRequest()
    {
        byte[] imageData = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mNkYPhfDwAChwGA60e6kgAAAABJRU5ErkJggg==");

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        ImageGenerationRequest request = new() { Prompt = "A beautiful sunset" };
        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);
        
        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal("image/png", dataContent.MediaType);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithPrompt()
    {
        byte[] imageData = [1, 2, 3, 4, 5];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify the request contains the expected prompt
                Assert.Single(request.Instances);
                Assert.Equal("prompt", request.Instances[0].StructValue.Fields.Keys.First());
                Assert.Equal("Generate a colorful landscape", request.Instances[0].StructValue.Fields["prompt"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/jpeg"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ImageGenerationRequest request = new() { Prompt = "Generate a colorful landscape" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal("image/jpeg", dataContent.MediaType);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_EmptyPrompt()
    {
        byte[] imageData = [10, 20, 30];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify empty prompt stays as empty string (only null becomes zero-width space)
                Assert.Single(request.Instances);
                Assert.Equal("", request.Instances[0].StructValue.Fields["prompt"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ImageGenerationRequest request = new() { Prompt = "" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_NullPrompt()
    {
        byte[] imageData = [15, 25, 35];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify null prompt results in no prompt field at all
                Assert.Single(request.Instances);
                Assert.False(request.Instances[0].StructValue.Fields.ContainsKey("prompt"));

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/webp"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ImageGenerationRequest request = new() { Prompt = null };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal("image/webp", dataContent.MediaType);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithOptions()
    {
        byte[] imageData = [50, 60, 70];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify the model ID was set from options
                Assert.Equal("projects/test/locations/us-central1/publishers/google/models/imagen-3.0-generate-001", request.Endpoint);

                // Verify parameters were set
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                
                // Check sample count (should be 1 by default)
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("sampleCount"));
                Assert.Equal(1, request.Parameters.StructValue.Fields["sampleCount"].NumberValue);

                // Check media type
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("outputOptions"));
                Struct outputOptions = request.Parameters.StructValue.Fields["outputOptions"].StructValue;
                Assert.Equal("image/jpeg", outputOptions.Fields["mimeType"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/jpeg"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/default-model");
        
        ImageGenerationRequest request = new() { Prompt = "Test image generation" };
        ImageGenerationOptions options = new()
        {
            ModelId = "projects/test/locations/us-central1/publishers/google/models/imagen-3.0-generate-001",
            MediaType = "image/jpeg"
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal("image/jpeg", dataContent.MediaType);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithCount()
    {
        byte[] imageData1 = [10, 20, 30];
        byte[] imageData2 = [40, 50, 60];
        byte[] imageData3 = [70, 80, 90];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify sample count was set
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("sampleCount"));
                Assert.Equal(3, request.Parameters.StructValue.Fields["sampleCount"].NumberValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData1, "image/png"));
                response.Predictions.Add(CreateImagePrediction(imageData2, "image/png"));
                response.Predictions.Add(CreateImagePrediction(imageData3, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Multiple images" };
        ImageGenerationOptions options = new() { Count = 3 };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Equal(3, result.Contents.Count);
        
        DataContent dataContent1 = Assert.IsType<DataContent>(result.Contents[0]);
        DataContent dataContent2 = Assert.IsType<DataContent>(result.Contents[1]);
        DataContent dataContent3 = Assert.IsType<DataContent>(result.Contents[2]);
        
        Assert.Equal(imageData1, dataContent1.Data.ToArray());
        Assert.Equal(imageData2, dataContent2.Data.ToArray());
        Assert.Equal(imageData3, dataContent3.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithImageSize()
    {
        byte[] imageData = [100, 110, 120];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify aspect ratio was calculated and set (1024:768 simplifies to 4:3)
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("aspectRatio"));
                Assert.Equal("4:3", request.Parameters.StructValue.Fields["aspectRatio"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Image with specific size" };
        ImageGenerationOptions options = new() 
        { 
            ImageSize = new(1024, 768)
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithSquareImageSize()
    {
        byte[] imageData = [200, 210, 220];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify aspect ratio for square image (512:512 simplifies to 1:1)
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("aspectRatio"));
                Assert.Equal("1:1", request.Parameters.StructValue.Fields["aspectRatio"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Square image" };
        ImageGenerationOptions options = new() 
        { 
            ImageSize = new(512, 512)
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        Assert.Equal(imageData, ((DataContent)result.Contents[0]).Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithInvalidImageSize()
    {
        byte[] imageData = [50, 55, 60];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify aspect ratio is not set for invalid dimensions
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.False(request.Parameters.StructValue.Fields.ContainsKey("aspectRatio"));

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Image with invalid size" };
        ImageGenerationOptions options = new() 
        { 
            ImageSize = new(0, 0)
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithRawRepresentationFactory()
    {
        byte[] imageData = [80, 85, 90];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify endpoint was set via RawRepresentationFactory
                Assert.Equal("custom-endpoint", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Custom request" };
        ImageGenerationOptions options = new()
        {
            RawRepresentationFactory = (generator) =>
            {
                PredictRequest predictRequest = new()
                {
                    Endpoint = "custom-endpoint",
                    Parameters = new()
                    {
                        StructValue = new()
                        {
                            Fields = { { "customParameter", Value.ForString("customValue") } }
                        }
                    }
                };
                return predictRequest;
            }
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        Assert.Equal(imageData, ((DataContent)result.Contents[0]).Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithAllOptions()
    {
        byte[] imageData1 = [10, 11, 12];
        byte[] imageData2 = [13, 14, 15];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify all options were applied correctly
                Assert.Equal("projects/test/locations/us-central1/publishers/google/models/imagen-3.0-generate-001", request.Endpoint);
                
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                
                // Check sample count
                Assert.Equal(2, request.Parameters.StructValue.Fields["sampleCount"].NumberValue);

                // Check media type
                Struct outputOptions = request.Parameters.StructValue.Fields["outputOptions"].StructValue;
                Assert.Equal("image/webp", outputOptions.Fields["mimeType"].StringValue);
                
                // Check aspect ratio (16:9)
                Assert.Equal("16:9", request.Parameters.StructValue.Fields["aspectRatio"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData1, "image/webp"));
                response.Predictions.Add(CreateImagePrediction(imageData2, "image/webp"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/default-model");
        
        ImageGenerationRequest request = new() { Prompt = "Complete test" };
        ImageGenerationOptions options = new()
        {
            ModelId = "projects/test/locations/us-central1/publishers/google/models/imagen-3.0-generate-001",
            Count = 2,
            MediaType = "image/webp",
            ImageSize = new(1920, 1080)
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Equal(2, result.Contents.Count);
        
        DataContent dataContent1 = Assert.IsType<DataContent>(result.Contents[0]);
        DataContent dataContent2 = Assert.IsType<DataContent>(result.Contents[1]);
        
        Assert.Equal("image/webp", dataContent1.MediaType);
        Assert.Equal("image/webp", dataContent2.MediaType);
        Assert.Equal(imageData1, dataContent1.Data.ToArray());
        Assert.Equal(imageData2, dataContent2.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithRawRepresentation()
    {
        byte[] imageData = [99, 100, 101];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Test raw representation" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.NotNull(result.RawRepresentation);
        Assert.IsType<PredictResponse>(result.RawRepresentation);
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_EmptyPredictions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                // No predictions in response
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Empty response test" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Empty(result.Contents);
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_MalformedPrediction()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                
                // Add a malformed prediction (missing bytesBase64Encoded field)
                response.Predictions.Add(new Value
                {
                    StructValue = new()
                    {
                        Fields = { { "invalid", Value.ForString("data") } }
                    }
                });

                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "Malformed test" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Empty(result.Contents); // Should handle gracefully and return empty results
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_PredictionWithoutMimeType()
    {
        byte[] imageData = [30, 31, 32];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                
                // Add prediction without explicit mimeType (should default to image/png)
                response.Predictions.Add(new Value
                {
                    StructValue = new()
                    {
                        Fields = 
                        { 
                            { "bytesBase64Encoded", Value.ForString(Convert.ToBase64String(imageData)) }
                        }
                    }
                });

                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ImageGenerationRequest request = new() { Prompt = "No mime type test" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal("image/png", dataContent.MediaType); // Should default to image/png
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithFullResourceModelId()
    {
        byte[] imageData = [100, 101, 102];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify the full resource model ID was used
                Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/imagen-3.0-generate-001", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator();
        
        ImageGenerationRequest request = new() { Prompt = "Test with full resource model ID" };
        ImageGenerationOptions options = new()
        {
            ModelId = "projects/test-project/locations/us-central1/publishers/google/models/imagen-3.0-generate-001"
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_DefaultModelUsedWhenNoOverride()
    {
        byte[] imageData = [40, 41, 42];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify default model was used
                Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/default-model-id", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/png"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/default-model-id");
        
        ImageGenerationRequest request = new() { Prompt = "Default model test" };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_WithComplexEndpointPath()
    {
        byte[] imageData = [210, 211, 212];

        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify complex endpoint path was used as-is
                Assert.Equal("projects/prod-project/locations/us-west2/endpoints/custom-image-gen-v2", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateImagePrediction(imageData, "image/webp"));
                return response;
            }
        };

        IImageGenerator imageGenerator = CreateClient(invoker).AsIImageGenerator();
        
        ImageGenerationRequest request = new() { Prompt = "Test with complex endpoint" };
        ImageGenerationOptions options = new()
        {
            ModelId = "projects/prod-project/locations/us-west2/endpoints/custom-image-gen-v2"
        };

        ImageGenerationResponse result = await imageGenerator.GenerateAsync(request, options);

        Assert.NotNull(result);
        Assert.Single(result.Contents);
        DataContent dataContent = Assert.IsType<DataContent>(result.Contents[0]);
        Assert.Equal("image/webp", dataContent.MediaType);
        Assert.Equal(imageData, dataContent.Data.ToArray());
    }

    [Fact]
    public async Task IImageGenerator_GenerateAsync_NullRequest_ThrowsArgumentNullException()
    {
        IImageGenerator imageGenerator = CreateClient().AsIImageGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        await Assert.ThrowsAsync<ArgumentNullException>("request", () => imageGenerator.GenerateAsync(null!));
    }

    private static Value CreateImagePrediction(byte[] imageData, string mimeType) =>
        new()
        {
            StructValue = new()
            {
                Fields =
                {
                    { "bytesBase64Encoded", Value.ForString(Convert.ToBase64String(imageData)) },
                    { "mimeType", Value.ForString(mimeType) }
                }
            }
        };

    private static PredictionServiceClient CreateClient(CallInvoker? callInvoker = null) =>
        new PredictionServiceClientBuilder()
        {
            ApiKey = "fake-api-key",
            CallInvoker = callInvoker,
        }.Build();

    private sealed class DelegateCallInvoker : CallInvoker
    {
        public Func<PredictRequest, PredictResponse>? OnPredictRequest { get; set; }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request)
        {
            if (OnPredictRequest is null)
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked but no {nameof(OnPredictRequest)} was provided.");
            }

            if (typeof(TRequest) != typeof(PredictRequest))
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked with unexpected request type {typeof(TRequest).FullName}. Expected {typeof(PredictRequest).FullName}.");
            }

            if (typeof(TResponse) != typeof(PredictResponse))
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked with unexpected response type {typeof(TResponse).FullName}. Expected {typeof(PredictResponse).FullName}.");
            }

            TResponse response = (TResponse)(object)OnPredictRequest((PredictRequest)(object)request);
            return new(Task.FromResult(response), Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => [], () => { });
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request) =>
            throw new NotSupportedException();

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options) =>
            throw new NotSupportedException();

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options) =>
            throw new NotSupportedException();

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request) =>
            throw new NotSupportedException();
    }
}

