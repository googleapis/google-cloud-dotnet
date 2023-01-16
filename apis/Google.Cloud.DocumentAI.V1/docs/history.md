# Version history

## Version 3.3.0, released 2023-01-16

### New features

- Added sharding_config field in DocumentOutputConfig.GcsOutputConfig in document_io.proto ([commit 2fb53d4](https://github.com/googleapis/google-cloud-dotnet/commit/2fb53d43cd8eb55b33ee6e08cef02413cf453e53))
- Added process_options field in ProcessRequest in document_processor_service.proto ([commit 2fb53d4](https://github.com/googleapis/google-cloud-dotnet/commit/2fb53d43cd8eb55b33ee6e08cef02413cf453e53))
- Added sample_document_uris field in ProcessorType in processor_type.proto ([commit 2fb53d4](https://github.com/googleapis/google-cloud-dotnet/commit/2fb53d43cd8eb55b33ee6e08cef02413cf453e53))

## Version 3.2.0, released 2022-12-14

### New features

- Added sharding_config field in DocumentOutputConfig.GcsOutputConfig in document_io.proto ([commit 1f81bac](https://github.com/googleapis/google-cloud-dotnet/commit/1f81bac43a32567244773f3de53a8f2aff2b4b5b))

## Version 3.1.0, released 2022-11-10

### New features

- Added font_family to document.proto ([commit 3885e56](https://github.com/googleapis/google-cloud-dotnet/commit/3885e56d1f7cc455b06c8f7c6d49c786edf134ca))
- Added ImageQualityScores message to document.proto ([commit 3885e56](https://github.com/googleapis/google-cloud-dotnet/commit/3885e56d1f7cc455b06c8f7c6d49c786edf134ca))
- Added PropertyMetadata and EntityTypeMetadata to document_schema.proto ([commit 3885e56](https://github.com/googleapis/google-cloud-dotnet/commit/3885e56d1f7cc455b06c8f7c6d49c786edf134ca))

## Version 3.0.0, released 2022-08-16

### New features

- Regenerate DocumentAI manually ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))
- Added field_mask to ProcessRequest object in document_processor_service.proto ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))
- Added parent_ids to Revision object in document.proto ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))
- Added integer_values, float_values and non_present to Entity object in document.proto ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))
- Added corrected_key_text, correct_value_text to FormField object in document.proto ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))
- Added OperationMetadata resource ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))
- Added Processor Management and Processor Version support to v1 library ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))

### Documentation improvements

- Fix minor docstring formatting ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))

### Breaking changes

- Changed the name field for ProcessRequest and BatchProcessorRequest to accept `*` so the name field can accept Processor and ProcessorVersion. ([commit d5df4a6](https://github.com/googleapis/google-cloud-dotnet/commit/d5df4a6a513faac93c7b382498efacbf64237def))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

### API-specific Breaking changes

- Mark Document.Entity.type as REQUIRED in all versions ([commit ad9cf3f](https://github.com/googleapis/google-cloud-dotnet/commit/ad9cf3fd719718341399185f03c6e70238f1abdf))
- Remove Document.Entity.bounding_poly_for_demo_frontend from v1beta2 ([commit ad9cf3f](https://github.com/googleapis/google-cloud-dotnet/commit/ad9cf3fd719718341399185f03c6e70238f1abdf))
## Version 1.5.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 1.4.0, released 2022-02-22

### New features

- Add `symbols` field, and auto-format comments ([commit 8e00219](https://github.com/googleapis/google-cloud-dotnet/commit/8e0021998961044fe9b556c323c80bb2d3030461))

## Version 1.3.0, released 2022-02-07

### New features

- Add question_id field in ReviewDocumentOperationMetadata ([commit af7ce3b](https://github.com/googleapis/google-cloud-dotnet/commit/af7ce3b83941b1b6a9e470311f0f11934368cd9b))

## Version 1.2.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.1.0, released 2021-06-22

- [Commit 1a7f5e6](https://github.com/googleapis/google-cloud-dotnet/commit/1a7f5e6): feat: update ReviewDocumentRequest to allow set priority and enable validation.

## Version 1.0.0, released 2021-06-08

- [Commit 7e77c2a](https://github.com/googleapis/google-cloud-dotnet/commit/7e77c2a): feat: Move CommonOperationMetadata into a separate proto file for potential reuse.
- [Commit a5723b7](https://github.com/googleapis/google-cloud-dotnet/commit/a5723b7): feat: Use non-regionalized default host name for documentai.googleapis.com

## Version 1.0.0-beta02, released 2021-04-29

- [Commit 64c687d](https://github.com/googleapis/google-cloud-dotnet/commit/64c687d): feat: add confidence field to the PageAnchor.PageRef in document.proto.

## Version 1.0.0-beta01, released 2021-03-18

Initial release.
