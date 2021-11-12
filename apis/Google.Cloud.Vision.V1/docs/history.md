# Version history

## Version 2.4.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.3.0, released 2021-04-29

- [Commit c94c761](https://github.com/googleapis/google-cloud-dotnet/commit/c94c761): fix: sync vision v1 protos to get extra FaceAnnotation Landmark Types

## Version 2.2.0, released 2020-12-01

- [Commit 12811f6](https://github.com/googleapis/google-cloud-dotnet/commit/12811f6):
  - feat: Add TextDetectionParams.enable_text_detection_confidence_score

## Version 2.1.0, released 2020-11-11

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit bbccd6f](https://github.com/googleapis/google-cloud-dotnet/commit/bbccd6f): docs: change a relative URL to an absolute URL to fix broken links.

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

## Version 1.7.0, released 2019-12-09

- [Commit c56e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c56e9ee): Some retry settings are now obsolete and will be removed in the next major version
- [Commit b4a35c8](https://github.com/googleapis/google-cloud-dotnet/commit/b4a35c8): Added category-specific confidence properties to SafeSearchAnnotation

## Version 1.6.0, released 2019-08-13

- [Commit 3028526](https://github.com/googleapis/google-cloud-dotnet/commit/3028526): New features:
  - New error field on responses
  - PurgeProducts long-running RPC
  - Object annotations in products
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Added resource name format methods

## Version 1.5.0, released 2019-07-10

- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc):- Introduce ClientBuilders for simplified client configuration

## Version 1.4.0, released 2019-06-05

- [Commit 1424e89](https://github.com/googleapis/google-cloud-dotnet/commit/1424e89): Add string-based overloads for methods accepting resource names. This fixes [issue 2442](https://github.com/googleapis/google-cloud-dotnet/issues/2442).
- [Commit 9031a3d](https://github.com/googleapis/google-cloud-dotnet/commit/9031a3d): New features:
  - BatchAnnotateFiles method
  - AsyncBatchAnnotateImages method

## Version 1.3.0, released 2019-02-05

- Added ProductSearchClient
- Added ImageAnnotatorClient.DetectSimilarProducts
- Added ImageAnnotatorClient.DetectLocalizedObjects

## Version 1.2.0, released 2018-05-23

- Added AsyncAnnotateFile methods
- Added AsyncBatchAnnotateFiles methods

## Version 1.1.0, released 2018-01-30

- Web detection
- Additional details on result properties (e.g. confidence)

## Version 1.0.0, released 2017-09-19

Initial GA release.
