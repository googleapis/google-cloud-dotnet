{{title}}

{{description}}

{{version}}

{{installation}}

{{auth}}

## Getting started

{{client-classes}}

{{client-construction}}

The "core" method [BatchAnnotateImages](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml#Google_Cloud_Vision_V1_ImageAnnotatorClient_BatchAnnotateImages_System_Collections_Generic_IEnumerable_Google_Cloud_Vision_V1_AnnotateImageRequest__Google_Api_Gax_Grpc_CallSettings_)
can perform multiple (potentially different) annotations on multiple
images, but convenience methods are provided for common cases of
working with a single image, and for performing a single annotation
operation on a single image.

# Sample code

## Constructing an Image object

There are various factory methods on the
[Image](obj/api/Google.Cloud.Vision.V1.Image.yml) class to allow
instances to be constructed from files, streams, byte arrays and URIs.

{{sample:Image.FactoryMethods}}

All IO-related methods have async equivalents.

## Detect faces in a single image

{{sample:ImageAnnotatorClient.DetectFaces}}

## Detect text in a single image

{{sample:ImageAnnotatorClient.DetectText}}

## Detect document text in a single image

{{sample:ImageAnnotatorClient.DetectDocumentText}}

## Detect labels in a single image

{{sample:ImageAnnotatorClient.DetectLabels}}

## Detect landmarks in a single image

{{sample:ImageAnnotatorClient.DetectLandmarks}}

## Detect logos in a single image

{{sample:ImageAnnotatorClient.DetectLogos}}

## Perform "safe search" processing on a single image

{{sample:ImageAnnotatorClient.DetectSafeSearch}}

## Perform image property processing on a single image

{{sample:ImageAnnotatorClient.DetectImageProperties}}

## Suggest crop hints for a single image

{{sample:ImageAnnotatorClient.DetectCropHints}}

## Perform analysis for other web references on a single image

{{sample:ImageAnnotatorClient.DetectWebInformation}}

## Detect localized objects in a single image

{{sample:ImageAnnotatorClient.DetectLocalizedObjects}}

## Detect faces and landmarks in a single image

{{sample:ImageAnnotatorClient.Annotate}}

## Detect faces in one image and logos in another

{{sample:ImageAnnotatorClient.BatchAnnotateImages}}

## Product search

After creating and populating a product set, the products can be
detected within images.

{{sample:ImageAnnotatorClient.ProductSearch}}

A filter can be applied to the search, to match only products with
specific labels.

{{sample:ImageAnnotatorClient.ProductSearchWithFilter}}

## Error handling

All the methods which annotate a single image (and therefore have a single response) throw
[AnnotateImageException](obj/api/Google.Cloud.Vision.V1.AnnotateImageException.yml) if the response
contains an error.

{{sample:ImageAnnotatorClient.ErrorHandling_SingleImage}}

The [BatchAnnotateImages](obj/api/Google.Cloud.Vision.V1.ImageAnnotatorClient.yml#Google_Cloud_Vision_V1_ImageAnnotatorClient_BatchAnnotateImages_System_Collections_Generic_IEnumerable_Google_Cloud_Vision_V1_AnnotateImageRequest__Google_Api_Gax_Grpc_CallSettings_)
method does not throw this exception, but [BatchAnnotateImagesResponse.ThrowOnAnyError()](obj/api/Google.Cloud.Vision.V1.BatchAnnotateImagesResponse.yml##Google_Cloud_Vision_V1_BatchAnnotateImagesResponse_ThrowOnAnyError) checks
all responses are successful, throwing an AggregateException if there are any errors.
The AggregateException contains one AnnotateImageException for each response that contains an error.

{{sample:BatchAnnotateImagesResponse.ThrowOnAnyError}}
