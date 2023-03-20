# Version history

## Version 2.0.0-beta09, released 2023-03-20

### New features

- Added hints.language_hints field in OcrConfig ([commit ec3812e](https://github.com/googleapis/google-cloud-dotnet/commit/ec3812e5fb9db0812ce570dbfbfa81f64879d055))
- Added enable_image_quality_scores field in OcrConfig ([commit ec3812e](https://github.com/googleapis/google-cloud-dotnet/commit/ec3812e5fb9db0812ce570dbfbfa81f64879d055))
- Added enable_symbol field in OcrConfig ([commit ec3812e](https://github.com/googleapis/google-cloud-dotnet/commit/ec3812e5fb9db0812ce570dbfbfa81f64879d055))

## Version 2.0.0-beta08, released 2023-02-08

### New features

- Added EvaluationReference to evaluation.proto ([commit a51e02c](https://github.com/googleapis/google-cloud-dotnet/commit/a51e02c698fe38b2c2f273af42f020532e14380e))
- Added latest_evaluation to processor.proto ([commit a51e02c](https://github.com/googleapis/google-cloud-dotnet/commit/a51e02c698fe38b2c2f273af42f020532e14380e))
- Added advanced_ocr_options field in OcrConfig ([commit e4901eb](https://github.com/googleapis/google-cloud-dotnet/commit/e4901eb6b5e35cebe1ca1b453da6901f17ec1e46))

### Breaking changes

- The TrainProcessorVersion parent was incorrectly annotated. ([commit a51e02c](https://github.com/googleapis/google-cloud-dotnet/commit/a51e02c698fe38b2c2f273af42f020532e14380e))

## Version 2.0.0-beta07, released 2023-01-20

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

## Version 2.0.0-beta06, released 2023-01-18

### New features

- Exposed GetProcessorType to v1beta3 ([commit a1b1e1a](https://github.com/googleapis/google-cloud-dotnet/commit/a1b1e1a83942009f96189e75df8f8b5c9b6280ff))

## Version 2.0.0-beta05, released 2023-01-16

### New features

- Added sharding_config field in DocumentOutputConfig.GcsOutputConfig in document_io.proto ([commit 25f4d4d](https://github.com/googleapis/google-cloud-dotnet/commit/25f4d4d8108de8d8f16eabdb1709fb6af3732bc5))
- Added process_options field in ProcessRequest in document_processor_service.proto ([commit 25f4d4d](https://github.com/googleapis/google-cloud-dotnet/commit/25f4d4d8108de8d8f16eabdb1709fb6af3732bc5))
- Added sample_document_uris field in ProcessorType in processor_type.proto ([commit 25f4d4d](https://github.com/googleapis/google-cloud-dotnet/commit/25f4d4d8108de8d8f16eabdb1709fb6af3732bc5))

## Version 2.0.0-beta04, released 2022-12-14

### New features

- Added sharding_config field in DocumentOutputConfig.GcsOutputConfig in document_io.proto ([commit 7b33720](https://github.com/googleapis/google-cloud-dotnet/commit/7b337209ed7a9195fa894eead83072aa7ebfd81d))

## Version 2.0.0-beta03, released 2022-11-16

### New features

- Added field_mask field in DocumentOutputConfig.GcsOutputConfig in document_io.proto ([commit a4e2380](https://github.com/googleapis/google-cloud-dotnet/commit/a4e238091d9633f85c8ddbd6fe369d96db4b8390))
- Added TrainProcessorVersion, EvaluateProcessorVersion, GetEvaluation, and ListEvaluations v1beta3 APIs ([commit cbd4d22](https://github.com/googleapis/google-cloud-dotnet/commit/cbd4d2277958fe365c1615e34a98990573e01d27))
- Added evaluation.proto ([commit cbd4d22](https://github.com/googleapis/google-cloud-dotnet/commit/cbd4d2277958fe365c1615e34a98990573e01d27))
- Added document_schema field in ProcessorVersion processor.proto ([commit cbd4d22](https://github.com/googleapis/google-cloud-dotnet/commit/cbd4d2277958fe365c1615e34a98990573e01d27))
- Added image_quality_scores field in Document.Page in document.proto ([commit cbd4d22](https://github.com/googleapis/google-cloud-dotnet/commit/cbd4d2277958fe365c1615e34a98990573e01d27))
- Added font_family field in Document.Style in document.proto ([commit cbd4d22](https://github.com/googleapis/google-cloud-dotnet/commit/cbd4d2277958fe365c1615e34a98990573e01d27))

## Version 2.0.0-beta02, released 2022-08-26

### New features

- Added field_mask to ProcessRequest object in document_processor_service.proto ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))
- Added parent_ids to Revision object in document.proto ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))
- Added integer_values, float_values and non_present to Entity object in document.proto ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))
- Added corrected_key_text, correct_value_text to FormField object in document.proto ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))
- Added OperationMetadata resource ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))
- Added Barcode support ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))
- **BREAKING CHANGE** Added Processor Management and Processor Version support to v1 library ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))

### Breaking changes

- Changed the name field for ProcessRequest and BatchProcessorRequest to accept * so the name field can accept Processor and ProcessorVersion. ([commit a750fad](https://github.com/googleapis/google-cloud-dotnet/commit/a750fad672712acf62c7b5d4a98b7095bfeed4ea))

## Version 2.0.0-beta01, released 2022-06-08

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

### API-specific breaking changes

- Mark Document.Entity.type as REQUIRED in all versions ([commit 0dcc4ad](https://github.com/googleapis/google-cloud-dotnet/commit/0dcc4ade7a1acb57efbfcfb03c6972c6bae60ee5))
- Remove Document.Entity.bounding_poly_for_demo_frontend from v1beta2 ([commit 0dcc4ad](https://github.com/googleapis/google-cloud-dotnet/commit/0dcc4ade7a1acb57efbfcfb03c6972c6bae60ee5))
## Version 1.0.0-beta04, released 2022-02-22

### New features

- Add `symbols` field, and auto-format comments ([commit 6387c47](https://github.com/googleapis/google-cloud-dotnet/commit/6387c47557b17044e11e01da8f23889373b26490))

## Version 1.0.0-beta03, released 2022-02-07

### New features

- Add question_id field in ReviewDocumentOperationMetadata ([commit 5ecd61e](https://github.com/googleapis/google-cloud-dotnet/commit/5ecd61efcb1a538591d9bbeed33e14c750e82d17))

## Version 1.0.0-beta02, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-06-16

Initial release.
