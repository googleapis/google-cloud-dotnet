# Version history

## Version 3.19.0, released 2024-10-29

### New features

- Updated the exponential backoff settings for the Document AI ProcessDocument and BatchProcessDocuments methods ([commit e8a1148](https://github.com/googleapis/google-cloud-dotnet/commit/e8a11488194f5da2cfada12645ed89bb8301535e))
- Add RESOURCE_EXHAUSTED to retryable status codes for ProcessDocument method ([commit e8a1148](https://github.com/googleapis/google-cloud-dotnet/commit/e8a11488194f5da2cfada12645ed89bb8301535e))
- Added an url for issue reporting and api short name ([commit e8a1148](https://github.com/googleapis/google-cloud-dotnet/commit/e8a11488194f5da2cfada12645ed89bb8301535e))

## Version 3.18.0, released 2024-08-05

### New features

- A new field `imageless_mode` is added to message `.google.cloud.documentai.v1.ProcessRequest` ([commit 8bb3707](https://github.com/googleapis/google-cloud-dotnet/commit/8bb3707919368cf60a6ec33d596ecdc865d13f78))
- A new field `gen_ai_model_info` is added to message `.google.cloud.documentai.v1.ProcessorVersion` ([commit 8bb3707](https://github.com/googleapis/google-cloud-dotnet/commit/8bb3707919368cf60a6ec33d596ecdc865d13f78))

### Documentation improvements

- Update the comment to add a note about `documentai.processors.create` permission ([commit 885982c](https://github.com/googleapis/google-cloud-dotnet/commit/885982cc55f380091fd5c6d01ff00cb47e02d937))

## Version 3.17.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))
- Make Layout Parser generally available in V1 ([commit 25c96f8](https://github.com/googleapis/google-cloud-dotnet/commit/25c96f82e50204a67c9a6222c8dd9af5cb8059cb))
- Make Layout Parser generally available in V1 ([commit 7359623](https://github.com/googleapis/google-cloud-dotnet/commit/735962332f058547aa816eea244e251591973243))

### Documentation improvements

- Clarify the unavailability of some features ([commit b14ce7d](https://github.com/googleapis/google-cloud-dotnet/commit/b14ce7d087969abb5e061692cd34be171439165f))

## Version 3.16.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Updated comments ([commit 82af282](https://github.com/googleapis/google-cloud-dotnet/commit/82af28249fdb04f67c826406ed705581282eaa96))

## Version 3.15.0, released 2024-04-19

### New features

- A new message `FoundationModelTuningOptions` is added ([commit 409c062](https://github.com/googleapis/google-cloud-dotnet/commit/409c0621ce109d3dad62b578232b09a461e9fb93))
- A new field `foundation_model_tuning_options` is added to message `.google.cloud.documentai.v1.TrainProcessorVersionRequest` ([commit 409c062](https://github.com/googleapis/google-cloud-dotnet/commit/409c0621ce109d3dad62b578232b09a461e9fb93))

### Documentation improvements

- Updated comments ([commit 409c062](https://github.com/googleapis/google-cloud-dotnet/commit/409c0621ce109d3dad62b578232b09a461e9fb93))

## Version 3.14.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.13.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 3.12.0, released 2024-02-20

### New features

- A new field `schema_override` is added to message `ProcessOptions` ([commit 15870cf](https://github.com/googleapis/google-cloud-dotnet/commit/15870cff4fed13b393950f7382309eb698929bdd))
- A new field `labels` is added to messages `ProcessRequest` and `BatchProcessRequest` ([commit 15870cf](https://github.com/googleapis/google-cloud-dotnet/commit/15870cff4fed13b393950f7382309eb698929bdd))
- A new field `display_name` is added to message `DocumentSchema` ([commit 15870cf](https://github.com/googleapis/google-cloud-dotnet/commit/15870cff4fed13b393950f7382309eb698929bdd))

### Documentation improvements

- Updated comments ([commit 15870cf](https://github.com/googleapis/google-cloud-dotnet/commit/15870cff4fed13b393950f7382309eb698929bdd))

## Version 3.11.0, released 2024-02-09

### New features

- Expose model_type in v1 processor, so that user can see the model_type after get or list processor version ([commit 307fadd](https://github.com/googleapis/google-cloud-dotnet/commit/307fadd18a9a0e4c8ae7184061b6d6fd4a90f295))

### Documentation improvements

- Clarify Properties documentation ([commit 89e17b5](https://github.com/googleapis/google-cloud-dotnet/commit/89e17b50c34e72c421ac3eebb0b2078f009ea066))
- Updated comments ([commit 86a7453](https://github.com/googleapis/google-cloud-dotnet/commit/86a745358ae56aac9b878ad0e68560210b1e3bc7))
- Minor comment update ([commit 4c3b325](https://github.com/googleapis/google-cloud-dotnet/commit/4c3b3257925feb320332f19764bf4a6c75a5cbc8))

## Version 3.10.0, released 2023-09-26

### Bug fixes

- `OcrConfig.compute_style_info` is deprecated. Use `PremiumFeatures.compute_style_info` instead. ([commit 8f008d6](https://github.com/googleapis/google-cloud-dotnet/commit/8f008d65ca5544d9410bb45552dfaae735158419))

### New features

- [Google.Cloud.DocumentAI.V1] make `page_range` field public ([issue 11086](https://github.com/googleapis/google-cloud-dotnet/issues/11086)) ([commit 8f008d6](https://github.com/googleapis/google-cloud-dotnet/commit/8f008d65ca5544d9410bb45552dfaae735158419))

## Version 3.9.0, released 2023-09-25

### Bug fixes

- Deprecated OcrConfig.compute_style_info ([commit ab6b622](https://github.com/googleapis/google-cloud-dotnet/commit/ab6b622e7e2a1a79fe808f860ed21d90ded49a58))

### New features

- Added field Processor.processor_version_aliases ([commit ab6b622](https://github.com/googleapis/google-cloud-dotnet/commit/ab6b622e7e2a1a79fe808f860ed21d90ded49a58))
- Added field RawDocument.display_name ([commit ab6b622](https://github.com/googleapis/google-cloud-dotnet/commit/ab6b622e7e2a1a79fe808f860ed21d90ded49a58))

## Version 3.8.0, released 2023-08-04

### New features

- Added http configuration and document publishing for v1beta2 ([commit 0090f90](https://github.com/googleapis/google-cloud-dotnet/commit/0090f900aca37d59a2948fe0000644383f752778))
- Added ImportDocuments, GetDocument and BatchDeleteDocuments RPCs for v1beta3 ([commit 0090f90](https://github.com/googleapis/google-cloud-dotnet/commit/0090f900aca37d59a2948fe0000644383f752778))

## Version 3.7.0, released 2023-06-20

### New features

- Add StyleInfo to document.proto ([commit 0fc4862](https://github.com/googleapis/google-cloud-dotnet/commit/0fc486293b62365947555b688ae8c203657308b1))
- Add IMPORTING enum to State in processor.proto ([commit 0fc4862](https://github.com/googleapis/google-cloud-dotnet/commit/0fc486293b62365947555b688ae8c203657308b1))

## Version 3.6.0, released 2023-02-22

### New features

- Added Training and Evaluation functions, request, responses and metadata to document_processor_service.proto ([commit 7fb7b5f](https://github.com/googleapis/google-cloud-dotnet/commit/7fb7b5fab9ff8368ca99ed2e6468d2853bc7fa55))
- Added evaluation.proto ([commit 7fb7b5f](https://github.com/googleapis/google-cloud-dotnet/commit/7fb7b5fab9ff8368ca99ed2e6468d2853bc7fa55))
- Added latest_evaluation to processor.proto ([commit 7fb7b5f](https://github.com/googleapis/google-cloud-dotnet/commit/7fb7b5fab9ff8368ca99ed2e6468d2853bc7fa55))

## Version 3.5.0, released 2023-01-20

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

## Version 3.4.0, released 2023-01-18

### New features

- Exposed GetProcessorType to v1 ([commit e715366](https://github.com/googleapis/google-cloud-dotnet/commit/e71536676c2b9d6d55d960061e26fb0ba91efb4b))

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
