# Google.Cloud.Speech.V1

`Google.Cloud.Speech.V1` is a .NET client library for the [Google
Cloud Speech API](https://cloud.google.com/speech).

# Installation

Install the `Google.Cloud.Speech.V1` package from NuGet. Add it to
your project in the normal way (for example by right-clicking on the
project in Visual Studio and choosing "Manage NuGet Packages...").
Please ensure you enable pre-release packages (for example, in the
Visual Studio NuGet user interface, check the "Include prerelease"
box).

# Authentication

When running on Google Cloud Platform, no action needs to be taken to authenticate.

Otherwise, the simplest way of authenticating your API calls is to
[download a service account JSON file](https://developers.google.com/identity/protocols/OAuth2ServiceAccount),
then set the `GOOGLE_APPLICATION_CREDENTIALS` environment variable to refer to it. The
credentials will automatically be used to authenticate.

Note that the default credentials obtained by running `gcloud auth application-default login` from the Google Cloud SDK
are not suitable for use with this API. (They will work initially, but implicitly have a very
small request quota.)

# Getting started

The simplest option is to use the synchronous, one-shot API as shown
below in the sample code. More complex scenarios are considered further down this page.

Note that the audio data should be mono rather than stereo, and the
format needs to be explicitly specified in the request.

# Sample code

## Constructing a RecognitionAudio object

There are various factory methods on the
[RecognitionAudio](obj/api/Google.Cloud.Speech.V1.RecognitionAudio.yml) class to allow
instances to be constructed from files, streams, byte arrays and URIs.

[!code-cs[](obj/snippets/Google.Cloud.Speech.V1.RecognitionAudio.txt#FactoryMethods)]

## Detect speech in a single file

[!code-cs[](obj/snippets/Google.Cloud.Speech.V1.SpeechClient.txt#Recognize)]

# Immediate, long-running and streaming operations

The underlying RPC API contains three modes of operation.

The simplest is via the Recognize method. You make a single
request, and get a single response with the result of the analysis.

The LongRunningRecognize method still requires all of the audio data to be
passed in a single request, but the response from the RPC is a
Google.LongRunning.Operation, representing an operation which could
take some time to complete. It contains a token which can be used to
retrieve the results later - you can think of it as a more
persistent and remote `Task<T>` to a first approximation.

Finally, the RPC API supports StreamingRecognize, which is a
bidirectional streaming API: the client makes a number of requests,
and the server emits a number of responses. This enables a
conversation to be transcribed in near real time, for example,
without the client needing to split it into chunks for single
operations.
