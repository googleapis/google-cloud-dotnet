# Version history

# Version 2.1.0, released 2020-09-15

- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3):
  - Regenerate all APIs with service comments in client documentation
  - The comments are included as they are, as a "remarks" section both the abstract base class and the concrete implementation.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573):
  - Regenerate all clients with more explicit documentation
  - The use of "inheritdoc" breaks docfx in many cases. The generator
  - has been improved to generate more explicit documentation. This PR only
  - contains changes due to that generator change.
- [Commit bbccd6f](https://github.com/googleapis/google-cloud-dotnet/commit/bbccd6f):
  - docs: change a relative URL to an absolute URL to fix broken links.
  - https://github.com/googleapis/googleapis/commit/4a6a01ce0ead505c245d11a2ce156de34800c58f
  - commit 4a6a01ce0ead505c245d11a2ce156de34800c58f
  - Author: Google APIs <noreply@google.com>
  - Date:   Fri Apr 3 09:40:35 2020 -0700
  -     docs: change a relative URL to an absolute URL to fix broken links.
  -     PiperOrigin-RevId: 304633630

# Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.7.0, released 2019-12-09

- [Commit c56e9ee](https://github.com/googleapis/google-cloud-dotnet/commit/c56e9ee): Some retry settings are now obsolete and will be removed in the next major version
- [Commit b4a35c8](https://github.com/googleapis/google-cloud-dotnet/commit/b4a35c8): Added category-specific confidence properties to SafeSearchAnnotation

# Version 1.6.0, released 2019-08-13

- [Commit 3028526](https://github.com/googleapis/google-cloud-dotnet/commit/3028526): New features:
  - New error field on responses
  - PurgeProducts long-running RPC
  - Object annotations in products
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Added resource name format methods

# Version 1.5.0, released 2019-07-10

- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc):- Introduce ClientBuilders for simplified client configuration

# Version 1.4.0, released 2019-06-05

- [Commit 1424e89](https://github.com/googleapis/google-cloud-dotnet/commit/1424e89): Add string-based overloads for methods accepting resource names. This fixes [issue 2442](https://github.com/googleapis/google-cloud-dotnet/issues/2442).
- [Commit 9031a3d](https://github.com/googleapis/google-cloud-dotnet/commit/9031a3d): New features:
  - BatchAnnotateFiles method
  - AsyncBatchAnnotateImages method

# Version 1.3.0, released 2019-02-05

- Added ProductSearchClient
- Added ImageAnnotatorClient.DetectSimilarProducts
- Added ImageAnnotatorClient.DetectLocalizedObjects

# Version 1.2.0, released 2018-05-23

- Added AsyncAnnotateFile methods
- Added AsyncBatchAnnotateFiles methods

# Version 1.1.0, released 2018-01-30

- Web detection
- Additional details on result properties (e.g. confidence)

# Version 1.0.0, released 2017-09-19

Initial GA release.
