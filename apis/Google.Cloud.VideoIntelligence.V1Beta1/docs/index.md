{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

All operations are performed through
[VideoIntelligenceServiceClient](obj/api/Google.Cloud.VideoIntelligence.V1Beta1.VideoIntelligenceServiceClient.yml).

Perform an initial call to `AnnotateVideo` or `AnnotateVideoAsync`.
This will return a long-running operation, which you can poll to
check for completion and the results.

# Sample code

## Annotate labels within a video

[!code-cs[](obj/snippets/Google.Cloud.VideoIntelligence.V1Beta1.VideoIntelligenceServiceClient.txt#AnnotateVideo)]

