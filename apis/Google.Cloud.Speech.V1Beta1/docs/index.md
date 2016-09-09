# Google.Cloud.Speech.V1Beta1

`Google.Cloud.Speech.V1Beta1` is a .NET client library for the [Google
Cloud Speech API](https://cloud.google.com/speech).

# Installation

Install the `Google.Cloud.Speech.V1Beta1` package from our
[early access MyGet
feed](https://www.myget.org/gallery/google-dotnet-public).
First onfigure your environment to include the appropriate NuGet feed
URL:

- NuGet v2: `https://www.myget.org/F/google-dotnet-public/`
- NuGet v3: `https://www.myget.org/F/google-dotnet-public/api/v3/index.json`

Next, add the package to your project in the normal way (for example
by right-clicking on the project in Visual Studio and choosing
"Manage NuGet Packages..."). Please ensure you enable pre-release
packages (for example, in the Visual Studio NuGet user interface,
check the "Include prerelease" box).

# Authentication

To authenticate all your API calls, first install and setup the
[Google Cloud SDK](https://cloud.google.com/sdk/). After that is
installed, run the following command in a Google Cloud SDK Shell:

```sh
> gcloud auth login
```

# Getting started

The simplest option is to use the synchronous, one-shot API as shown
below in the sample code. More complex scenarios are considered further down this page.

Note that the audio data should be mono rather than stereo, and the
format needs to be explicitly specified in the request.

# Sample code

## Constructing a RecognitionAudio object

There are various factory methods on the
[RecognitionAudio](obj/api/Google.Cloud.Speech.V1Beta1.RecognitionAudio.yml) class to allow
instances to be constructed from files, streams, byte arrays and URIs.

[!code-cs[](obj/snippets/Google.Cloud.Speech.V1Beta1.RecognitionAudio.txt#FactoryMethods)]

## Detect speech in a single file

[!code-cs[](obj/snippets/Google.Cloud.Speech.V1Beta1.SpeechClient.txt#SyncRecognize)]

# Synchronous, asynchronous and streaming operations

The underlying RPC API contains three modes of operation.

The simplest is via the SyncRecognize method. You make a single
request, and get a single response with the result of the analysis.
Despite the name, this can still be invoked asynchronously from C#
with `SpeechClient.SyncRecognizeAsync`.

The AsyncRecognize method still requires all of the audio data to be
passed in a single request, but the response from the RPC is a
Google.Longrunning.Operation, representing an operation which could
take some time to complete. It contains a token which can be used to
retrieve the results later - you can think of it as a more
persistent and remote `Task<T>` to a first approximation. While this
RPC works in the current Google.Cloud.Speech.V1Beta1 library, more
work will be done to expose this functionality idiomatically.

Finally, the RPC API supports StreamingRecognize, which is a
bidirectional streaming API: the client makes a number of requests,
and the server emits a number of responses. This enables a
conversation to be transcribed in near real time, for example,
without the client needing to split it into chunks for single
operations. The streaming API is not exposed in the
Google.Cloud.Speech.V1Beta1.SpeechClient type yet, but you can use
the underlying gRPC client directly for this functionality. Again,
more work will be done to expose the streaming API in a friendly way.

It is very likely that we will add a very thin abstraction layer
over the top of the generated code, partly to avoid method names
such as `AsyncRecognizeAsync` which are confusing.
