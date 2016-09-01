# Google.Cloud.Vision.V1

`Google.Cloud.Vision.V1` is a .NET client library for the [Google
Cloud Vision API](https://cloud.google.com/vision).

# Installation

Install the `Google.Cloud.Vision.V1` package from our
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

All operations are performed through
[ImageAnnotatorClient](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml).

The "core" method ([BatchAnnotateImages](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml#Google_Cloud_Vision_V1_ImageAnnotatorClient_BatchAnnotateImages_System_Collections_Generic_IEnumerable_Google_Cloud_Vision_V1_AnnotateImageRequest__Google_Api_Gax_CallSettings_)
can perform multiple (potentially different) annotations on multiple
images, but convenience methods are provided for common cases of
working with a single image, and for performing a single annotation
operation on a single image.

# Sample code

## Constructing an Image object

There are various factory methods on the
[Image](obj/api/Google.Cloud.Vision.V1.Image.yml) class to allow
instances to be constructed from files, streams, byte arrays and URIs.

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.Image.txt#FactoryMethods)]

All IO-related methods have async equivalents.

## Detect faces in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectFaces)]

## Detect text in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectText)]

## Detect labels in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectLabels)]

## Detect landmarks in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectLandmarks)]

## Detect logos in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectLogos)]

## Perform "safe search" processing on a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectSafeSearch)]

## Perform image property processing on a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectImageProperties)]

## Detect faces and landmarks in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#Annotate)]

## Detect faces in one image and logos in another

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#BatchAnnotateImages)]
