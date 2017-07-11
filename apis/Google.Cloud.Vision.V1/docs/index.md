{{title}}

{{description}}

{{installation}}

{{auth}}

# Getting started

All operations are performed through
[ImageAnnotatorClient](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml).

The "core" method [BatchAnnotateImages](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml#Google_Cloud_Vision_V1_ImageAnnotatorClient_BatchAnnotateImages_System_Collections_Generic_IEnumerable_Google_Cloud_Vision_V1_AnnotateImageRequest__Google_Api_Gax_CallSettings_)
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

## Detect document text in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectDocumentText)]

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

## Suggest crop hints for a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectCropHints)]

## Perform analysis for other web references on a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#DetectWebInformation)]

## Detect faces and landmarks in a single image

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#Annotate)]

## Detect faces in one image and logos in another

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#BatchAnnotateImages)]

## Error handling

All the methods which annotate a single image (and therefore have a single response) throw
[AnnotateImageException](obj/api/Google.Cloud.Vision.V1.AnnotateImageException.yml) if the response
contains an error.

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.ImageAnnotatorClient.txt#ErrorHandling_SingleImage)]

The [BatchAnnotateImages](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml#Google_Cloud_Vision_V1_ImageAnnotatorClient_BatchAnnotateImages_System_Collections_Generic_IEnumerable_Google_Cloud_Vision_V1_AnnotateImageRequest__Google_Api_Gax_CallSettings_)
method does not throw this exception, but [BatchAnnotateImagesResponse.ThrowOnAnyError()](obj/api/Google.Cloud.Vision.V1.BatchAnnotateImagesResponse.yml##Google_Cloud_Vision_V1_BatchAnnotateImagesResponse_ThrowOnAnyError) checks
all responses are successful, throwing an AggregateException if there are any errors.
The AggregateException contains one AnnotateImageException for each response that contains an error.

[!code-cs[](obj/snippets/Google.Cloud.Vision.V1.BatchAnnotateImagesResponse.txt#ThrowOnAnyError)]
