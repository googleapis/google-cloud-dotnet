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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Struct = Google.Protobuf.WellKnownTypes.Struct;

namespace Google.Cloud.VertexAI.Extensions.Tests;

public class BuildIChatClientTest
{
    [Fact]
    public void BuildIChatClient_ValidArguments_CreatesIChatClientSuccessfully()
    {
        IChatClient chatClient = CreateClientBuilder().BuildIChatClient();
        Assert.NotNull(chatClient);
        Assert.NotNull(chatClient.GetService<PredictionServiceClient>());
    }

    [Fact]
    public void BuildIChatClient_InvalidArguments_Throws()
    {
        Assert.Throws<ArgumentNullException>("builder", () => VertexAIExtensions.BuildIChatClient(null!));
    }

    [Fact]
    public void IChatClient_GetService_InvalidArguments_Throws()
    {
        IChatClient chatClient = CreateClientBuilder().BuildIChatClient();
        Assert.NotNull(chatClient);

        Assert.Throws<ArgumentNullException>("serviceType", () => chatClient.GetService(null!));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/fakemodel")]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/gemini-pro")]
    public void IChatClient_GetService_ReturnsExpectedInstance(string? defaultModelId)
    {
        IChatClient chatClient = CreateClientBuilder().BuildIChatClient(defaultModelId);
        Assert.NotNull(chatClient);

        Assert.Same(chatClient.GetService<PredictionServiceClient>(), chatClient.GetService<PredictionServiceClient>());

        Assert.Same(chatClient, chatClient.GetService<IChatClient>());
        Assert.Same(chatClient, chatClient.GetService<IDisposable>());

        ChatClientMetadata? metadata = chatClient.GetService<ChatClientMetadata>();
        Assert.NotNull(metadata);
        Assert.Equal("gcp.vertex_ai", metadata.ProviderName);
        Assert.Equal(new("https://aiplatform.googleapis.com:443"), metadata.ProviderUri);
        Assert.Equal(defaultModelId?.Substring(defaultModelId.LastIndexOf('/') + 1), metadata.DefaultModelId);
    }

    [Fact]
    public void IChatClient_Dispose_Nop()
    {
        IChatClient chatClient = CreateClientBuilder().BuildIChatClient();
        Assert.NotNull(chatClient);

        chatClient.Dispose();

        Assert.NotNull(chatClient.GetService<PredictionServiceClient>());
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_BasicRequest()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Hello" } } }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        ChatResponse result = await chatClient.GetResponseAsync("Hello");
        Assert.NotNull(result);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_TextContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify the request contains the expected text
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Single(request.Contents[0].Parts);
                Assert.Equal("What is the weather like?", request.Contents[0].Parts[0].Text);

                GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "It's sunny today." } } });
                response.Candidates[0].FinishReason = Candidate.Types.FinishReason.Stop;
                return response;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What is the weather like?")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal(ChatRole.Assistant, result.Messages[0].Role);
        Assert.IsType<TextContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal("It's sunny today.", ((TextContent) result.Messages[0].Contents[0]).Text);
        Assert.Equal(ChatFinishReason.Stop, result.FinishReason);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_DataContent()
    {
        byte[] imageData = [0x89, 0x50, 0x4E, 0x47]; // PNG header bytes

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify the request contains the expected data
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Equal(2, request.Contents[0].Parts.Count); // Text + Image
                Assert.Equal("Describe this image", request.Contents[0].Parts[0].Text);
                Assert.NotNull(request.Contents[0].Parts[1].InlineData);
                Assert.Equal("image/png", request.Contents[0].Parts[1].InlineData.MimeType);
                Assert.True(request.Contents[0].Parts[1].InlineData.Data.ToByteArray().SequenceEqual(imageData));

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "I see an image." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new TextContent("Describe this image"),
                new DataContent(imageData, "image/png")
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("I see an image.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_UriContent()
    {
        Uri imageUri = new("https://example.com/image.jpg");

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify the request contains the expected URI
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Equal(2, request.Contents[0].Parts.Count); // Text + URI
                Assert.Equal("Analyze this image", request.Contents[0].Parts[0].Text);
                Assert.NotNull(request.Contents[0].Parts[1].FileData);
                Assert.Equal("https://example.com/image.jpg", request.Contents[0].Parts[1].FileData.FileUri);
                Assert.Equal("image/jpeg", request.Contents[0].Parts[1].FileData.MimeType);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Image analysis complete." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new TextContent("Analyze this image"),
                new UriContent(imageUri, "image/jpeg")
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("Image analysis complete.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_AllContentTypesHaveRawRepresentation()
    {
        byte[] imageData = [0x89, 0x50, 0x4E, 0x47];
        string reasoningData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("sig"));

        Part textPart = new Part() { Text = "Hello" };
        Part inlineDataPart = new Part() { InlineData = new() { Data = ByteString.CopyFrom(imageData), MimeType = "image/png" } };
        Part fileDataPart = new Part() { FileData = new() { FileUri = "https://example.com/file.txt", MimeType = "text/plain" } };
        Part functionCallPart = new Part() { FunctionCall = new() { Name = "func", Args = new Struct() } };
        Part functionResponsePart = new Part() { FunctionResponse = new() { Name = "func", Response = new Struct() } };
        Part executableCodePart = new Part() { ExecutableCode = new() { Language = ExecutableCode.Types.Language.Python, Code = "x=1" } };
        Part codeExecutionResultPart = new Part() { CodeExecutionResult = new() { Outcome = CodeExecutionResult.Types.Outcome.Ok, Output = "1" } };
        Part thoughtPart = new Part() { Thought = true, ThoughtSignature = ByteString.FromBase64(reasoningData) };

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        textPart,
                        inlineDataPart,
                        fileDataPart,
                        functionCallPart,
                        functionResponsePart,
                        executableCodePart,
                        codeExecutionResultPart,
                        thoughtPart,
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal(9, result.Messages[0].Contents.Count);
        
        // Verify each content has the correct Part as its RawRepresentation
        Assert.Same(textPart, result.Messages[0].Contents[0].RawRepresentation);
        Assert.Same(inlineDataPart, result.Messages[0].Contents[1].RawRepresentation);
        Assert.Same(fileDataPart, result.Messages[0].Contents[2].RawRepresentation);
        Assert.Same(functionCallPart, result.Messages[0].Contents[3].RawRepresentation);
        Assert.Same(functionResponsePart, result.Messages[0].Contents[4].RawRepresentation);
        Assert.Same(executableCodePart, result.Messages[0].Contents[5].RawRepresentation);
        Assert.Same(codeExecutionResultPart, result.Messages[0].Contents[6].RawRepresentation);
        Assert.Same(thoughtPart, result.Messages[0].Contents[7].RawRepresentation);
        // Thought parts now also generate a separate reasoning signature content
        Assert.IsType<TextReasoningContent>(result.Messages[0].Contents[8]);
        Assert.Equal(reasoningData, ((TextReasoningContent)result.Messages[0].Contents[8]).ProtectedData);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_UriContent_InvalidUri_ThrowsException()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            FileData = new()
                            {
                                FileUri = "not a valid uri",
                                MimeType = "image/jpeg"
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test invalid URI handling")];

        await Assert.ThrowsAsync<UriFormatException>(() => chatClient.GetResponseAsync(messages));
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionCallContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                        {
                            new Part()
                            {
                                FunctionCall = new()
                                {
                                    Name = "get_weather",
                                    Args = Struct.Parser.ParseJson("{\"location\": \"San Francisco\"}")
                                }
                            }
                        }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What's the weather in San Francisco?")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.IsType<FunctionCallContent>(Assert.Single(result.Messages[0].Contents));

        FunctionCallContent functionCall = (FunctionCallContent) result.Messages[0].Contents[0];
        Assert.Equal("get_weather", functionCall.Name);
        Assert.Equal("get_weather", functionCall.CallId);
        Assert.NotNull(functionCall.Arguments);
        Assert.Null(functionCall.Exception);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionCallContent_WithInvalidJson()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            FunctionCall = new()
                            {
                                Name = "get_weather",
                                // Create JSON that will fail when deserializing to Dictionary<string, object?>
                                // Using a very deep nesting that exceeds default max depth
                                Args = Struct.Parser.ParseJson(CreateDeeplyNestedJson(100))
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What's the weather?")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        FunctionCallContent functionCall = Assert.IsType<FunctionCallContent>(Assert.Single(result.Messages[0].Contents));
        
        Assert.Equal("get_weather", functionCall.Name);
        Assert.Equal("get_weather", functionCall.CallId);
        Assert.Null(functionCall.Arguments);
        Assert.NotNull(functionCall.Exception);
        // The exception could be JsonException or InvalidOperationException depending on max depth handling
        Assert.True(functionCall.Exception is JsonException or InvalidOperationException);
        
        static string CreateDeeplyNestedJson(int depth)
        {
            StringBuilder result = new("""{"level0":""");

            for (int i = 1; i < depth; i++)
            {
                result.Append($$"""{"level{{i}}":""");
            }

            result.Append("\"value\"");

            for (int i = 0; i < depth; i++)
            {
                result.Append("}");
            }

            return result.ToString();
        }
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify the request contains the function result
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Single(request.Contents[0].Parts);
                Assert.NotNull(request.Contents[0].Parts[0].FunctionResponse);
                Assert.Equal("call_123", request.Contents[0].Parts[0].FunctionResponse.Name);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Based on the weather data, it's sunny." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_123", new { temperature = 72, condition = "sunny" })
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("Based on the weather data, it's sunny.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithDataContent()
    {
        byte[] imageData = [0x89, 0x50, 0x4E, 0x47];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Single(request.Contents[0].Parts);
                
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                Assert.NotNull(funcResponse);
                Assert.Equal("call_456", funcResponse.Name);
                Assert.Single(funcResponse.Parts);
                Assert.NotNull(funcResponse.Parts[0].InlineData);
                Assert.Equal("image/png", funcResponse.Parts[0].InlineData.MimeType);
                Assert.True(funcResponse.Parts[0].InlineData.Data.ToByteArray().SequenceEqual(imageData));

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Image processed." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_456", new DataContent(imageData, "image/png"))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Image processed.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithUriContent()
    {
        Uri imageUri = new("https://example.com/result.jpg");

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Single(request.Contents);
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                Assert.NotNull(funcResponse);
                Assert.Equal("call_789", funcResponse.Name);
                Assert.Single(funcResponse.Parts);
                Assert.NotNull(funcResponse.Parts[0].FileData);
                Assert.Equal("https://example.com/result.jpg", funcResponse.Parts[0].FileData.FileUri);
                Assert.Equal("image/jpeg", funcResponse.Parts[0].FileData.MimeType);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "URI processed." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_789", new UriContent(imageUri, "image/jpeg"))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("URI processed.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithMultipleAIContents()
    {
        byte[] data = [1, 2, 3];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Single(request.Contents);
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                Assert.NotNull(funcResponse);
                Assert.Equal("call_multi", funcResponse.Name);
                Assert.Equal(2, funcResponse.Parts.Count);
                
                Assert.NotNull(funcResponse.Parts[0].InlineData);
                Assert.True(funcResponse.Parts[0].InlineData.Data.ToByteArray().SequenceEqual(data));
                
                Assert.NotNull(funcResponse.Parts[1].FileData);
                Assert.Equal("https://example.com/file.pdf", funcResponse.Parts[1].FileData.FileUri);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Multi-content processed." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        List<AIContent> multiContent = 
        [
            new DataContent(data, "image/png"),
            new UriContent(new Uri("https://example.com/file.pdf"), "application/pdf")
        ];

        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_multi", multiContent)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Multi-content processed.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithTextContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Single(request.Contents);
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                Assert.NotNull(funcResponse);
                Assert.Equal("call_text", funcResponse.Name);
                Assert.NotNull(funcResponse.Response);
                
                var responseStr = funcResponse.Response.ToString();
                Assert.Contains("\"result\"", responseStr);
                Assert.Contains("Simple text result", responseStr);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Text result processed." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_text", new TextContent("Simple text result"))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Text result processed.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithMixedContents()
    {
        byte[] imageData = [1, 2, 3, 4];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Single(request.Contents);
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                Assert.NotNull(funcResponse);
                Assert.Equal("call_mixed", funcResponse.Name);
                
                // Should have 2 parts (DataContent and UriContent) plus the Response with TextContent
                Assert.Equal(2, funcResponse.Parts.Count);
                Assert.NotNull(funcResponse.Response);
                
                // Verify DataContent was added as InlineData
                Assert.NotNull(funcResponse.Parts[0].InlineData);
                Assert.Equal("image/jpeg", funcResponse.Parts[0].InlineData.MimeType);
                Assert.True(funcResponse.Parts[0].InlineData.Data.ToByteArray().SequenceEqual(imageData));
                
                // Verify UriContent was added as FileData
                Assert.NotNull(funcResponse.Parts[1].FileData);
                Assert.Equal("https://example.com/doc.pdf", funcResponse.Parts[1].FileData.FileUri);
                Assert.Equal("application/pdf", funcResponse.Parts[1].FileData.MimeType);
                
                // Verify TextContent was added to Response
                var responseStr = funcResponse.Response.ToString();
                Assert.Contains("\"result\"", responseStr);
                Assert.Contains("Here is the analysis", responseStr);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Mixed content processed." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        List<AIContent> mixedContent = 
        [
            new DataContent(imageData, "image/jpeg"),
            new TextContent("Here is the analysis"),
            new UriContent(new Uri("https://example.com/doc.pdf"), "application/pdf"),
        ];

        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_mixed", mixedContent)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Mixed content processed.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithUnsupportedMimeTypes()
    {
        byte[] videoData = [1, 2, 3, 4, 5];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Single(request.Contents);
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                Assert.NotNull(funcResponse);
                Assert.Equal("call_unsupported", funcResponse.Name);
                
                // Unsupported MIME types should be in Response, not Parts
                Assert.Empty(funcResponse.Parts);
                Assert.NotNull(funcResponse.Response);
                
                // All unsupported content should be in the result field
                var responseStr = funcResponse.Response.ToString();
                Assert.Contains("\"result\"", responseStr);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Unsupported content handled." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        List<AIContent> unsupportedContent = 
        [
            new DataContent(videoData, "video/mp4"),
            new UriContent(new Uri("https://example.com/file.bin"), "application/octet-stream")
        ];

        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_unsupported", unsupportedContent)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Unsupported content handled.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Theory]
    [InlineData("image/png")]
    [InlineData("image/jpeg")]
    [InlineData("image/webp")]
    [InlineData("application/pdf")]
    [InlineData("text/plain")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_SupportedMimeTypes(string mimeType)
    {
        byte[] data = [1, 2, 3];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                
                // Supported MIME types should be in Parts
                Assert.Single(funcResponse.Parts);
                Assert.NotNull(funcResponse.Parts[0].InlineData);
                Assert.Equal(mimeType, funcResponse.Parts[0].InlineData.MimeType);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "OK" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("test_call", new DataContent(data, mimeType))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Theory]
    [InlineData("video/mp4")]
    [InlineData("application/octet-stream")]
    [InlineData("text/html")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_UnsupportedMimeType_FallsBackToResponse(string mimeType)
    {
        byte[] data = [1, 2, 3];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                
                // Unsupported MIME types should NOT be in Parts
                Assert.Empty(funcResponse.Parts);
                
                // Should be serialized into Response instead
                Assert.NotNull(funcResponse.Response);
                string responseStr = funcResponse.Response.ToString();
                Assert.Contains("result", responseStr);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "OK" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("test_call", new DataContent(data, mimeType))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_DataContentWithName()
    {
        byte[] data = [1, 2, 3, 4];
        string displayName = "my-image.png";

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                var funcResponse = request.Contents[0].Parts[0].FunctionResponse;
                
                Assert.Single(funcResponse.Parts);
                Assert.NotNull(funcResponse.Parts[0].InlineData);
                Assert.Equal("image/png", funcResponse.Parts[0].InlineData.MimeType);
                Assert.Equal(displayName, funcResponse.Parts[0].InlineData.DisplayName);
                Assert.True(funcResponse.Parts[0].InlineData.Data.ToByteArray().SequenceEqual(data));

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "OK" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        var dataContent = new DataContent(data, "image/png") { Name = displayName };
        
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("test_call", dataContent)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_ReceivesFunctionResponseWithParts()
    {
        byte[] imageData = [0x89, 0x50, 0x4E, 0x47];
        
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            FunctionResponse = new()
                            {
                                Name = "get_image",
                                Parts =
                                {
                                    new FunctionResponsePart()
                                    {
                                        InlineData = new()
                                        {
                                            MimeType = "image/png",
                                            Data = ByteString.CopyFrom(imageData),
                                            DisplayName = "result.png"
                                        }
                                    }
                                }
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Get an image")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        var functionResult = Assert.IsType<FunctionResultContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal("get_image", functionResult.CallId);
        
        // The result should contain the parts - but since FunctionResponse parsing isn't fully implemented,
        // this might just be null or a basic object
        // We're mainly testing that it doesn't crash
        Assert.NotNull(result);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_UnknownPartType_CreatesEmptyAIContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part() { Text = "Before" },
                        new Part() { },  // Empty part - unknown type
                        new Part() { Text = "After" }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal(3, result.Messages[0].Contents.Count);
        
        Assert.IsType<TextContent>(result.Messages[0].Contents[0]);
        Assert.Equal("Before", ((TextContent)result.Messages[0].Contents[0]).Text);
        
        // Middle content should be an empty AIContent but still have RawRepresentation
        AIContent unknownContent = result.Messages[0].Contents[1];
        Assert.Equal(typeof(AIContent), unknownContent.GetType());  // Exact type, not derived
        Assert.NotNull(unknownContent.RawRepresentation);
        Assert.IsType<Part>(unknownContent.RawRepresentation);
        
        Assert.IsType<TextContent>(result.Messages[0].Contents[2]);
        Assert.Equal("After", ((TextContent)result.Messages[0].Contents[2]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_TextReasoningContent()
    {
        string reasoningData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("reasoning signature"));

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                        {
                            new Part()
                            {
                                Thought = true,
                                ThoughtSignature = ByteString.FromBase64(reasoningData)
                            }
                        }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Think step by step about this problem.")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal(2, result.Messages[0].Contents.Count);
        Assert.IsType<TextReasoningContent>(result.Messages[0].Contents[0]);
        Assert.IsType<TextReasoningContent>(result.Messages[0].Contents[1]);

        TextReasoningContent reasoningContent = (TextReasoningContent) result.Messages[0].Contents[1];
        Assert.Equal(reasoningData, reasoningContent.ProtectedData);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_TextReasoningContent_WithTextAndSignature()
    {
        string reasoningText = "Let me think step by step...";
        string reasoningData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("reasoning signature"));

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            Thought = true,
                            Text = reasoningText,
                            ThoughtSignature = ByteString.FromBase64(reasoningData)
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Think step by step about this problem.")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal(2, result.Messages[0].Contents.Count);
        
        // First content should have the reasoning text
        TextReasoningContent firstContent = Assert.IsType<TextReasoningContent>(result.Messages[0].Contents[0]);
        Assert.Equal(reasoningText, firstContent.Text);
        
        // Second content should have the signature
        TextReasoningContent secondContent = Assert.IsType<TextReasoningContent>(result.Messages[0].Contents[1]);
        Assert.Equal(reasoningData, secondContent.ProtectedData);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_SendsTextReasoningContent()
    {
        string reasoningText = "I reasoned about this";
        string reasoningData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("signature"));

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Equal(2, request.Contents.Count);
                
                // First message is user
                Assert.Equal("user", request.Contents[0].Role);
                
                // Second message should be model with reasoning
                Assert.Equal("model", request.Contents[1].Role);
                Assert.Single(request.Contents[1].Parts);
                
                Part reasoningPart = request.Contents[1].Parts[0];
                Assert.True(reasoningPart.Thought);
                Assert.Equal(reasoningText, reasoningPart.Text);
                Assert.Equal(ByteString.FromBase64(reasoningData), reasoningPart.ThoughtSignature);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "OK" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        
        ChatMessage[] messages =
        [
            new(ChatRole.User, "Question"),
            new(ChatRole.Assistant, [new TextReasoningContent(reasoningText) { ProtectedData = reasoningData }])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_CodeInterpreterToolCallContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            ExecutableCode = new()
                            {
                                Language = ExecutableCode.Types.Language.Python,
                                Code = "print('Hello, World!')"
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Write a hello world program")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        var codeContent = Assert.IsType<CodeInterpreterToolCallContent>(Assert.Single(result.Messages[0].Contents));
        Assert.NotNull(codeContent.Inputs);
        Assert.Single(codeContent.Inputs);
        
        var dataContent = Assert.IsType<DataContent>(codeContent.Inputs[0]);
        Assert.Equal("text/python", dataContent.MediaType);
        Assert.Equal("print('Hello, World!')", System.Text.Encoding.UTF8.GetString(dataContent.Data.ToArray()));
        
        Assert.IsType<Part>(codeContent.RawRepresentation);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_CodeExecutionResultContent_Success()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            CodeExecutionResult = new()
                            {
                                Outcome = CodeExecutionResult.Types.Outcome.Ok,
                                Output = "Hello, World!\n"
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Run the code")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        var codeResultContent = Assert.IsType<CodeInterpreterToolResultContent>(Assert.Single(result.Messages[0].Contents));
        Assert.NotNull(codeResultContent.Outputs);
        Assert.Single(codeResultContent.Outputs);
        
        var textContent = Assert.IsType<TextContent>(codeResultContent.Outputs[0]);
        Assert.Equal("Hello, World!\n", textContent.Text);
        
        Assert.IsType<Part>(codeResultContent.RawRepresentation);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_CodeExecutionResultContent_Failed()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            CodeExecutionResult = new()
                            {
                                Outcome = CodeExecutionResult.Types.Outcome.Failed,
                                Output = "NameError: name 'x' is not defined"
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Run the code")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        var codeResultContent = Assert.IsType<CodeInterpreterToolResultContent>(Assert.Single(result.Messages[0].Contents));
        Assert.NotNull(codeResultContent.Outputs);
        Assert.Single(codeResultContent.Outputs);
        
        var errorContent = Assert.IsType<ErrorContent>(codeResultContent.Outputs[0]);
        Assert.Equal("NameError: name 'x' is not defined", errorContent.Message);
        Assert.Equal("Failed", errorContent.ErrorCode);
        
        Assert.IsType<Part>(codeResultContent.RawRepresentation);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_CodeInterpreterToolCallContent_NonPythonLanguage()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request => CreateResponse(
                new()
                {
                    Role = "model",
                    Parts =
                    {
                        new Part()
                        {
                            ExecutableCode = new()
                            {
                                Language = ExecutableCode.Types.Language.Unspecified,
                                Code = "console.log('Hello');"
                            }
                        }
                    }
                }),
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Write some code")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        var codeContent = Assert.IsType<CodeInterpreterToolCallContent>(Assert.Single(result.Messages[0].Contents));
        Assert.NotNull(codeContent.Inputs);
        
        var dataContent = Assert.IsType<DataContent>(codeContent.Inputs[0]);
        Assert.Equal("text/x-source-code", dataContent.MediaType);
        Assert.Equal("console.log('Hello');", System.Text.Encoding.UTF8.GetString(dataContent.Data.ToArray()));
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithChatOptions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify ChatOptions were applied correctly
                Assert.Equal("projects/test/locations/us-central1/publishers/google/models/gemini-pro", request.Model);
                Assert.Equal(new()
                {
                    Temperature = 0.7f,
                    TopP = 0.9f,
                    TopK = 40,
                    MaxOutputTokens = 100,
                    Seed = 42,
                    FrequencyPenalty = 0.5f,
                    PresencePenalty = 0.3f,
                    StopSequences = { "STOP" }
                }, request.GenerationConfig);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Response with options applied." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/default-model");
        ChatMessage[] messages = [new(ChatRole.User, "Test message")];

        ChatOptions options = new()
        {
            ModelId = "projects/test/locations/us-central1/publishers/google/models/gemini-pro",
            Temperature = 0.7f,
            TopP = 0.9f,
            TopK = 40,
            MaxOutputTokens = 100,
            Seed = 42,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.3f,
            StopSequences = ["STOP"]
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("Response with options applied.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithSystemInstructions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify system instruction was set
                Assert.NotNull(request.SystemInstruction);
                Assert.Equal("system", request.SystemInstruction.Role);
                Assert.Single(request.SystemInstruction.Parts);
                Assert.Equal("You are a helpful assistant.", request.SystemInstruction.Parts[0].Text);

                // Verify user message
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "I'm here to help!" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.System, "You are a helpful assistant."),
            new(ChatRole.User, "Hello")
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("I'm here to help!", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithToolsAndFunctions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify tools were configured
                Assert.Equal(4, request.Tools.Count); // Function + 3 hosted tools

                // Check function declaration
                Tool? functionTool = request.Tools.FirstOrDefault(t => t.FunctionDeclarations.Count > 0);
                Assert.NotNull(functionTool);
                Assert.Single(functionTool.FunctionDeclarations);
                Assert.Equal("get_weather", functionTool.FunctionDeclarations[0].Name);

                // Check hosted tools
                Assert.Contains(request.Tools, t => t.CodeExecution != null);
                Assert.Contains(request.Tools, t => t.Retrieval != null);
                Assert.Contains(request.Tools, t => t.GoogleSearch != null);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "I can use tools to help you." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What tools do you have?")];

        ChatOptions options = new()
        {
            Tools =
            [
                AIFunctionFactory.Create((string location) => "the weather", "get_weather", "Gets weather information"),
                new HostedCodeInterpreterTool(),
                new HostedFileSearchTool(),
                new HostedWebSearchTool()
            ]
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("I can use tools to help you.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithRawToolViaAsAITool()
    {
        Tool customTool = new()
        {
            FunctionDeclarations = { new FunctionDeclaration { Name = "custom_tool", Description = "A custom tool" } }
        };

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                Assert.Equal(2, request.Tools.Count);
                
                Assert.Contains(request.Tools, t => t.FunctionDeclarations.Any(f => f.Name == "custom_tool"));
                Assert.Contains(request.Tools, t => t.FunctionDeclarations.Any(f => f.Name == "search"));

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Using custom tool." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Search for something")];

        ChatOptions options = new()
        {
            Tools =
            [
                customTool.AsAITool(),
                AIFunctionFactory.Create((string query) => "result", "search", "Search function")
            ]
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("Using custom tool.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public void AsAITool_ValidTool_ReturnsAITool()
    {
        Tool tool = new() { FunctionDeclarations = { new FunctionDeclaration { Name = "test" } } };
        
        AITool aiTool = tool.AsAITool();
        
        Assert.NotNull(aiTool);
        Assert.Equal("Tool", aiTool.Name);
        Assert.Same(tool, aiTool.GetService<Tool>());
    }

    [Fact]
    public void AsAITool_NullTool_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>("tool", () => VertexAIExtensions.AsAITool(null!));
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_UsageDetails_AllZeros_ReturnsNull()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Test" } } });
                response.UsageMetadata = new()
                {
                    PromptTokenCount = 0,
                    CandidatesTokenCount = 0,
                    TotalTokenCount = 0,
                    CachedContentTokenCount = 0,
                    ThoughtsTokenCount = 0
                };
                return response;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Null(result.Usage);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_UsageDetails_OnlyNonZeroAdditionalCounts()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Test" } } });
                response.UsageMetadata = new()
                {
                    PromptTokenCount = 10,
                    CandidatesTokenCount = 5,
                    TotalTokenCount = 15,
                    CachedContentTokenCount = 0,  // Should not appear
                    ThoughtsTokenCount = 7         // Should appear
                };
                return response;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.NotNull(result.Usage);
        Assert.NotNull(result.Usage.AdditionalCounts);
        Assert.Single(result.Usage.AdditionalCounts);
        Assert.Equal(7, result.Usage.AdditionalCounts["ThoughtsTokenCount"]);
        Assert.False(result.Usage.AdditionalCounts.ContainsKey("CachedContentTokenCount"));
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithToolModeAuto()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify tool mode configuration
                Assert.NotNull(request.ToolConfig);
                Assert.NotNull(request.ToolConfig.FunctionCallingConfig);
                Assert.Equal(FunctionCallingConfig.Types.Mode.Auto, request.ToolConfig.FunctionCallingConfig.Mode);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Auto mode enabled." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test auto tool mode")];

        ChatOptions options = new()
        {
            Tools = [new HostedCodeInterpreterTool()],
            ToolMode = ChatToolMode.Auto,
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("Auto mode enabled.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithToolModeRequired()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify tool mode configuration
                Assert.NotNull(request.ToolConfig);
                Assert.NotNull(request.ToolConfig.FunctionCallingConfig);
                Assert.Equal(FunctionCallingConfig.Types.Mode.Any, request.ToolConfig.FunctionCallingConfig.Mode);
                Assert.Contains("get_weather", request.ToolConfig.FunctionCallingConfig.AllowedFunctionNames);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Required mode with specific function." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test required tool mode")];

        ChatOptions options = new()
        {
            Tools = [AIFunctionFactory.Create((string location) => "the weather", "get_weather", "Gets weather information")],
            ToolMode = ChatToolMode.RequireSpecific("get_weather")
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("Required mode with specific function.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithJsonResponseFormat()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify JSON response format configuration
                Assert.NotNull(request.GenerationConfig);
                Assert.Equal("application/json", request.GenerationConfig.ResponseMimeType);
                Assert.NotNull(request.GenerationConfig.ResponseJsonSchema);
                Assert.Contains(
                    "\"properties\":{\"result\":{\"type\":\"string\"}}",
                    Regex.Replace(request.GenerationConfig.ResponseJsonSchema.ToString(), @"\s+", ""));

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = """{"result": "success"}""" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Return JSON")];

        ChatOptions options = new()
        {
            ResponseFormat = ChatResponseFormat.ForJsonSchema<StringResultType>(),
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("{\"result\": \"success\"}", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    private sealed class StringResultType
    {
        public string Result { get; set; } = "";
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithUsageMetadata()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Response with usage." } } });

                response.UsageMetadata = new()
                {
                    PromptTokenCount = 10,
                    CandidatesTokenCount = 5,
                    TotalTokenCount = 15,
                    CachedContentTokenCount = 2,
                    ThoughtsTokenCount = 3
                };

                return response;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test usage metadata")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.NotNull(result.Usage);
        Assert.Equal(10, result.Usage.InputTokenCount);
        Assert.Equal(5, result.Usage.OutputTokenCount);
        Assert.Equal(15, result.Usage.TotalTokenCount);
        Assert.NotNull(result.Usage.AdditionalCounts);
        Assert.Equal(2, result.Usage.AdditionalCounts["CachedContentTokenCount"]);
        Assert.Equal(3, result.Usage.AdditionalCounts["ThoughtsTokenCount"]);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithFinishReasons()
    {
        (Candidate.Types.FinishReason, ChatFinishReason)[] finishReasonTests =
        [
            (Candidate.Types.FinishReason.MaxTokens, ChatFinishReason.Length),
            (Candidate.Types.FinishReason.MalformedFunctionCall, ChatFinishReason.ToolCalls),
            (Candidate.Types.FinishReason.Safety, ChatFinishReason.ContentFilter),
            (Candidate.Types.FinishReason.Recitation, ChatFinishReason.ContentFilter),
            (Candidate.Types.FinishReason.Blocklist, ChatFinishReason.ContentFilter),
            (Candidate.Types.FinishReason.ProhibitedContent, ChatFinishReason.ContentFilter),
            (Candidate.Types.FinishReason.Spii, ChatFinishReason.ContentFilter),
            (Candidate.Types.FinishReason.ModelArmor, ChatFinishReason.ContentFilter),
            (Candidate.Types.FinishReason.Stop, ChatFinishReason.Stop),
            (Candidate.Types.FinishReason.Other, ChatFinishReason.Stop),
            (Candidate.Types.FinishReason.Unspecified, ChatFinishReason.Stop)
        ];

        foreach ((Candidate.Types.FinishReason googleReason, ChatFinishReason expectedReason) in finishReasonTests)
        {
            DelegateCallInvoker invoker = new()
            {
                OnGenerateContentRequest = request =>
                {
                    GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Test response" } } });
                    response.Candidates[0].FinishReason = googleReason;
                    return response;
                }
            };

            IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
            ChatMessage[] messages = [new(ChatRole.User, "Test")];

            ChatResponse result = await chatClient.GetResponseAsync(messages);

            Assert.Equal(expectedReason, result.FinishReason);
        }
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithCitationMetadata()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "This is cited content." } } });
                response.Candidates[0].CitationMetadata = new()
                {
                    Citations =
                    {
                        new Citation
                        {
                            Title = "Example Source",
                            Uri = "https://example.com",
                            StartIndex = 0,
                            EndIndex = 10
                        }
                    }
                };

                return response;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Cite your sources")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        TextContent textContent = Assert.IsType<TextContent>(result.Messages[0].Contents[0]);
        Assert.Equal("This is cited content.", textContent.Text);
        Assert.NotNull(textContent.Annotations);
        Assert.Single(textContent.Annotations);

        CitationAnnotation citation = Assert.IsType<CitationAnnotation>(textContent.Annotations[0]);
        Assert.Equal("Example Source", citation.Title);
        Assert.Equal("https://example.com/", citation.Url?.ToString());
        Assert.NotNull(citation.AnnotatedRegions);
        Assert.Single(citation.AnnotatedRegions);

        TextSpanAnnotatedRegion region = Assert.IsType<TextSpanAnnotatedRegion>(citation.AnnotatedRegions[0]);
        Assert.Equal(0, region.StartIndex);
        Assert.Equal(10, region.EndIndex);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithErrorContent()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                GenerateContentResponse response = CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Response text" } } });

                response.PromptFeedback = new()
                {
                    BlockReasonMessage = "Content blocked due to safety reasons"
                };

                return response;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Problematic content")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal(2, result.Messages[0].Contents.Count);

        Assert.IsType<TextContent>(result.Messages[0].Contents[0]);

        ErrorContent errorContent = Assert.IsType<ErrorContent>(result.Messages[0].Contents[1]);
        Assert.Equal("Content blocked due to safety reasons", errorContent.Message);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_BasicStreaming()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "Hello" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " world" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "!" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-3"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request => responses
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Say hello")];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.Equal(3, updates.Count);
        Assert.All(updates, update => Assert.Equal(ChatRole.Assistant, update.Role));

        string[] texts = [.. updates.Select(u => ((TextContent) u.Contents[0]).Text)];
        Assert.Equal(["Hello", " world", "!"], texts);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_TextContent()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "It's" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " sunny" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " today." } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-3"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request =>
            {
                // Verify the request contains the expected text
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Single(request.Contents[0].Parts);
                Assert.Equal("What is the weather like?", request.Contents[0].Parts[0].Text);

                return responses;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What is the weather like?")];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.Equal(3, updates.Count);
        Assert.All(updates, update => Assert.Equal(ChatRole.Assistant, update.Role));

        string[] texts = [.. updates.Select(u => ((TextContent) u.Contents[0]).Text)];
        Assert.Equal(["It's", " sunny", " today."], texts);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_WithDataContent()
    {
        byte[] imageData = [1, 2, 3, 4, 5];

        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "I see" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " an image." } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request =>
            {
                // Verify the request contains the expected data
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Equal(2, request.Contents[0].Parts.Count); // Text + Image
                Assert.Equal("Describe this image", request.Contents[0].Parts[0].Text);
                Assert.NotNull(request.Contents[0].Parts[1].InlineData);
                Assert.Equal("image/png", request.Contents[0].Parts[1].InlineData.MimeType);
                Assert.True(request.Contents[0].Parts[1].InlineData.Data.ToByteArray().SequenceEqual(imageData));

                return responses;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new TextContent("Describe this image"),
                new DataContent(imageData, "image/png")
            ])
        ];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.Equal(2, updates.Count);
        Assert.All(updates, update => Assert.Equal(ChatRole.Assistant, update.Role));

        string[] texts = [.. updates.Select(u => ((TextContent) u.Contents[0]).Text)];
        Assert.Equal(["I see", " an image."], texts);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_WithFunctionCall()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate
                {
                    Content = new()
                    {
                        Role = "model",
                        Parts =
                        {
                            new Part
                            {
                                FunctionCall = new()
                                {
                                    Name = "get_weather",
                                    Args = Struct.Parser.ParseJson("{\"location\": \"San Francisco\"}")
                                }
                            }
                        }
                    }
                } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request => responses
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What's the weather in San Francisco?")];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.Single(updates);
        Assert.Equal(ChatRole.Assistant, updates[0].Role);
        Assert.IsType<FunctionCallContent>(Assert.Single(updates[0].Contents));

        FunctionCallContent functionCall = (FunctionCallContent) updates[0].Contents[0];
        Assert.Equal("get_weather", functionCall.Name);
        Assert.Equal("get_weather", functionCall.CallId);
        Assert.NotNull(functionCall.Arguments);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_WithChatOptions()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "Response with" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " options applied." } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request =>
            {
                // Verify ChatOptions were applied correctly
                Assert.Equal("projects/test/locations/us-central1/publishers/google/models/gemini-pro", request.Model);
                Assert.Equal(new()
                {
                    Temperature = 0.7f,
                    TopP = 0.9f
                }, request.GenerationConfig);

                return responses;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/default-model");
        ChatMessage[] messages = [new(ChatRole.User, "Test message")];

        ChatOptions options = new()
        {
            ModelId = "projects/test/locations/us-central1/publishers/google/models/gemini-pro",
            Temperature = 0.7f,
            TopP = 0.9f
        };

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages, options))
        {
            updates.Add(update);
        }

        Assert.Equal(2, updates.Count);
        Assert.All(updates, update => Assert.Equal(ChatRole.Assistant, update.Role));

        string[] texts = [.. updates.Select(u => ((TextContent) u.Contents[0]).Text)];
        Assert.Equal(["Response with", " options applied."], texts);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_WithSystemInstructions()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "I'm here" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " to help!" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request =>
            {
                // Verify system instruction was set
                Assert.NotNull(request.SystemInstruction);
                Assert.Equal("system", request.SystemInstruction.Role);
                Assert.Single(request.SystemInstruction.Parts);
                Assert.Equal("You are a helpful assistant.", request.SystemInstruction.Parts[0].Text);

                // Verify user message
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);

                return responses;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages =
        [
            new(ChatRole.System, "You are a helpful assistant."),
            new(ChatRole.User, "Hello")
        ];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.Equal(2, updates.Count);
        Assert.All(updates, update => Assert.Equal(ChatRole.Assistant, update.Role));

        string[] texts = [.. updates.Select(u => ((TextContent) u.Contents[0]).Text)];
        Assert.Equal(["I'm here", " to help!"], texts);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_WithUsageMetadata()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new Content { Role = "model", Parts = { new Part { Text = "Response" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " with usage." } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2",
                UsageMetadata = new()
                {
                    PromptTokenCount = 10,
                    CandidatesTokenCount = 5,
                    TotalTokenCount = 15,
                    CachedContentTokenCount = 2,
                    ThoughtsTokenCount = 3
                }
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request => responses
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "Test usage metadata")];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.Equal(2, updates.Count);

        // First update should not have usage content
        Assert.IsType<TextContent>(Assert.Single(updates[0].Contents));

        // Second update should have both text and usage content
        Assert.Equal(2, updates[1].Contents.Count);
        Assert.IsType<TextContent>(updates[1].Contents[0]);
        Assert.IsType<UsageContent>(updates[1].Contents[1]);

        UsageContent usageContent = (UsageContent) updates[1].Contents[1];
        Assert.Equal(10, usageContent.Details.InputTokenCount);
        Assert.Equal(5, usageContent.Details.OutputTokenCount);
        Assert.Equal(15, usageContent.Details.TotalTokenCount);
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_WithTools()
    {
        GenerateContentResponse[] responses =
        [
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = "I can use" } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-1"
            },
            new()
            {
                Candidates = { new Candidate { Content = new() { Role = "model", Parts = { new Part { Text = " tools to help you." } } } } },
                CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ModelVersion = "test-model",
                ResponseId = "response-2"
            }
        ];

        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequestStreaming = request =>
            {
                // Verify tools were configured
                Assert.Equal(2, request.Tools.Count); // Function + code execution

                // Check function declaration
                Tool? functionTool = request.Tools.FirstOrDefault(t => t.FunctionDeclarations.Count > 0);
                Assert.NotNull(functionTool);
                Assert.Single(functionTool.FunctionDeclarations);
                Assert.Equal("get_weather", functionTool.FunctionDeclarations[0].Name);

                // Check hosted tool
                Assert.Contains(request.Tools, t => t.CodeExecution != null);

                return responses;
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [new(ChatRole.User, "What tools do you have?")];

        ChatOptions options = new()
        {
            Tools =
            [
                AIFunctionFactory.Create((string location) => $"Weather in {location}", "get_weather", "Gets weather information"),
                new HostedCodeInterpreterTool()
            ]
        };

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages, options))
        {
            updates.Add(update);
        }

        Assert.Equal(2, updates.Count);
        Assert.All(updates, update => Assert.Equal(ChatRole.Assistant, update.Role));

        string[] texts = [.. updates.Select(u => ((TextContent) u.Contents[0]).Text)];
        Assert.Equal(["I can use", " tools to help you."], texts);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_WithFullResourceModelId()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify the full resource model ID was used
                Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/gemini-pro", request.Model);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Response with full resource model ID." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient();
        ChatMessage[] messages = [new(ChatRole.User, "Test message")];

        ChatOptions options = new()
        {
            ModelId = "projects/test-project/locations/us-central1/publishers/google/models/gemini-pro"
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("Response with full resource model ID.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }



    [Fact]
    public async Task IChatClient_GetResponseAsync_EmptyContentHandling()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify empty content creates a default empty user message
                Assert.Single(request.Contents);
                Assert.Equal("user", request.Contents[0].Role);
                Assert.Single(request.Contents[0].Parts);
                Assert.Equal("", request.Contents[0].Parts[0].Text);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Empty input received" } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");
        ChatMessage[] messages = [];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("Empty input received", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_ModelIdExtraction_FromFullResourceName()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify full resource name was used as-is
                Assert.Equal("projects/custom-project/locations/europe-west1/publishers/meta/models/llama-2-7b-chat", request.Model);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Response from custom resource." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient();
        ChatMessage[] messages = [new(ChatRole.User, "Test message")];

        ChatOptions options = new()
        {
            ModelId = "projects/custom-project/locations/europe-west1/publishers/meta/models/llama-2-7b-chat"
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Equal("projects/custom-project/locations/europe-west1/publishers/meta/models/llama-2-7b-chat", result.ModelId);
        Assert.Equal("Response from custom resource.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_ModelIdExtraction_FromDefaultModel()
    {
        DelegateCallInvoker invoker = new()
        {
            OnGenerateContentRequest = request =>
            {
                // Verify default model was used correctly
                Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/default-chat-model", request.Model);

                return CreateResponse(new() { Role = "model", Parts = { new Part() { Text = "Response from default model." } } });
            }
        };

        IChatClient chatClient = CreateClientBuilder(invoker).BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/default-chat-model");
        ChatMessage[] messages = [new(ChatRole.User, "Test message")];

        // No ModelId in options, should use default
        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/default-chat-model", result.ModelId);
        Assert.Equal("Response from default model.", ((TextContent) result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    public async Task IChatClient_GetResponseAsync_NullMessages_ThrowsArgumentNullException()
    {
        IChatClient chatClient = CreateClientBuilder().BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        await Assert.ThrowsAsync<ArgumentNullException>("messages", () => chatClient.GetResponseAsync(null!));
    }

    [Fact]
    public async Task IChatClient_GetStreamingResponseAsync_NullMessages_ThrowsArgumentNullException()
    {
        IChatClient chatClient = CreateClientBuilder().BuildIChatClient("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        IAsyncEnumerator<ChatResponseUpdate> enumerator = chatClient.GetStreamingResponseAsync(null!).GetAsyncEnumerator();
        await Assert.ThrowsAsync<ArgumentNullException>("messages", () => enumerator.MoveNextAsync().AsTask());
    }

    private static GenerateContentResponse CreateResponse(Content content)
    {
        GenerateContentResponse response = new();

        response.Candidates.Add(new Candidate()
        {
            Content = content,
        });

        return response;
    }

    private static PredictionServiceClientBuilder CreateClientBuilder(CallInvoker? callInvoker = null) =>
        new PredictionServiceClientBuilder()
        {
            ApiKey = "fake-api-key",
            CallInvoker = callInvoker,
        };

    private sealed class DelegateCallInvoker : CallInvoker
    {
        public Func<GenerateContentRequest, GenerateContentResponse>? OnGenerateContentRequest { get; set; }
        public Func<GenerateContentRequest, GenerateContentResponse[]>? OnGenerateContentRequestStreaming { get; set; }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request)
        {
            if (OnGenerateContentRequest is null)
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked but no {nameof(OnGenerateContentRequest)} was provided.");
            }

            if (typeof(TRequest) != typeof(GenerateContentRequest))
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked with unexpected request type {typeof(TRequest).FullName}. Expected {typeof(GenerateContentRequest).FullName}.");
            }

            if (typeof(TResponse) != typeof(GenerateContentResponse))
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked with unexpected response type {typeof(TResponse).FullName}. Expected {typeof(GenerateContentResponse).FullName}.");
            }

            TResponse response = (TResponse) (object) OnGenerateContentRequest((GenerateContentRequest) (object) request);
            return new(Task.FromResult(response), Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => [], () => { });
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request)
        {
            if (OnGenerateContentRequestStreaming is null)
            {
                throw new NotSupportedException($"{nameof(AsyncServerStreamingCall)} was invoked but no {nameof(OnGenerateContentRequestStreaming)} was provided.");
            }

            if (typeof(TRequest) != typeof(GenerateContentRequest))
            {
                throw new NotSupportedException($"{nameof(AsyncServerStreamingCall)} was invoked with unexpected request type {typeof(TRequest).FullName}. Expected {typeof(GenerateContentRequest).FullName}.");
            }

            if (typeof(TResponse) != typeof(GenerateContentResponse))
            {
                throw new NotSupportedException($"{nameof(AsyncServerStreamingCall)} was invoked with unexpected response type {typeof(TResponse).FullName}. Expected {typeof(GenerateContentResponse).FullName}.");
            }

            GenerateContentResponse[] responses = OnGenerateContentRequestStreaming((GenerateContentRequest) (object) request);
            TestAsyncResponseStream<TResponse> responseStream = new TestAsyncResponseStream<TResponse>([.. responses.Cast<TResponse>()]);
            return new AsyncServerStreamingCall<TResponse>(
                responseStream,
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => [],
                () => { });
        }

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options) =>
            throw new NotSupportedException();

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options) =>
            throw new NotSupportedException();

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request) =>
            throw new NotSupportedException();

        /// <summary>A test implementation of IAsyncStreamReader for mocking streaming responses.</summary>
        private sealed class TestAsyncResponseStream<T>(T[] responses) : IAsyncStreamReader<T>
        {
            private int _currentIndex = -1;

            public T Current => _currentIndex >= 0 && _currentIndex < responses.Length ? responses[_currentIndex] : default!;

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                await Task.Yield();
                _currentIndex++;
                return _currentIndex < responses.Length;
            }
        }
    }
}

