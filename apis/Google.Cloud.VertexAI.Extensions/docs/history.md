# Version history

## Version 1.0.0-beta03, released 2025-12-29

### New features

- Update to M.E.AI.Abstractions 10.1.1

## Version 1.0.0-beta02, released 2025-12-15

### Bug fixes

- Initialize ChatResponseUpdate.MessageId with ResponseId

## Version 1.0.0-beta01, released 2025-12-12

### New features

- Add some async extension methods
- Update Google.Cloud.VertexAI.Extensions for latest AIPlatform an M.E.AI
- Add AsIChatClient/EmbeddingGenerator/ImageGenerator for PredictionServiceClient (#15134)
- Empty project for Vertex AI implementation of Microsoft.Extensions.AI

### Bug fixes

- Revert embedding changes from #15289
- Handling of tool calls without thought signatures
- Tweak a few things in Google.Cloud.VertexAI.Extensions

