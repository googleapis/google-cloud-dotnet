# Version history

## Version 2.0.0-beta24, released 2025-03-24

### New features

- Added config options to enable LLM layout parsing ([commit 30a817a](https://github.com/googleapis/google-cloud-dotnet/commit/30a817abf99c3f3bd14dd2e9efc0b80e3c46e05a))

### Documentation improvements

- Mark fields as unused ([commit 25625fc](https://github.com/googleapis/google-cloud-dotnet/commit/25625fcba367b5212f0c7267ca37972be0a0ff73))

## Version 2.0.0-beta23, released 2024-10-21

### New features

- Updated the exponential backoff settings for the Document AI ProcessDocument and BatchProcessDocuments methods ([commit dab8392](https://github.com/googleapis/google-cloud-dotnet/commit/dab8392f636e4329758ed239a0108cd86ad42423))
- Add RESOURCE_EXHAUSTED to retryable status codes for ProcessDocument method ([commit dab8392](https://github.com/googleapis/google-cloud-dotnet/commit/dab8392f636e4329758ed239a0108cd86ad42423))
- Added an url for issue reporting and api short name ([commit dab8392](https://github.com/googleapis/google-cloud-dotnet/commit/dab8392f636e4329758ed239a0108cd86ad42423))

## Version 2.0.0-beta22, released 2024-09-09

### New features

- Add API fields for the descriptions of entity type and property in the document schema ([commit 34114a8](https://github.com/googleapis/google-cloud-dotnet/commit/34114a8656b03efe274c47e6628eb2996e23e61f))

## Version 2.0.0-beta21, released 2024-08-05

### New features

- A new field `imageless_mode` is added to message `.google.cloud.documentai.v1.ProcessRequest` ([commit ca07e67](https://github.com/googleapis/google-cloud-dotnet/commit/ca07e67a242098a759491a65324dc8d45397144e))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit ca07e67](https://github.com/googleapis/google-cloud-dotnet/commit/ca07e67a242098a759491a65324dc8d45397144e))

## Version 2.0.0-beta20, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 2.0.0-beta19, released 2024-04-29

### New features

- Support Chunk header and footer in Doc AI external proto ([commit 4e73a14](https://github.com/googleapis/google-cloud-dotnet/commit/4e73a14b5df69e8d8f16e552dc677febbeb7f7b1))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 4e73a14](https://github.com/googleapis/google-cloud-dotnet/commit/4e73a14b5df69e8d8f16e552dc677febbeb7f7b1))

## Version 2.0.0-beta18, released 2024-04-19

### New features

- Support a new Layout Processor in Document AI ([commit 8912d83](https://github.com/googleapis/google-cloud-dotnet/commit/8912d830ea5827eac95969da3db8642505fd6253))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 8912d83](https://github.com/googleapis/google-cloud-dotnet/commit/8912d830ea5827eac95969da3db8642505fd6253))

## Version 2.0.0-beta17, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

### Documentation improvements

- A comment for field `processor_version_source` in message `.google.cloud.documentai.v1beta3.ImportProcessorVersionRequest` is changed ([commit afadd88](https://github.com/googleapis/google-cloud-dotnet/commit/afadd88ce9ef29741f665be9c3b2d9867562f8d8))

## Version 2.0.0-beta16, released 2024-03-13

No API surface changes; just dependency updates.

## Version 2.0.0-beta15, released 2024-02-20

### Bug fixes

- Deprecate `Dataset.document_warehouse_config` ([commit 9161ec3](https://github.com/googleapis/google-cloud-dotnet/commit/9161ec3cbc47939c6e0e0a5ca8640a34f80b6a0c))

### New features

- A new message FoundationModelTuningOptions is added ([commit 9161ec3](https://github.com/googleapis/google-cloud-dotnet/commit/9161ec3cbc47939c6e0e0a5ca8640a34f80b6a0c))
- A new field foundation_model_tuning_options is added to message TrainProcessorVersionRequest ([commit 9161ec3](https://github.com/googleapis/google-cloud-dotnet/commit/9161ec3cbc47939c6e0e0a5ca8640a34f80b6a0c))
- A new field `labels` is added to messages `ProcessRequest` and `BatchProcessRequest` ([commit 9161ec3](https://github.com/googleapis/google-cloud-dotnet/commit/9161ec3cbc47939c6e0e0a5ca8640a34f80b6a0c))
- A new field `display_name` is added to message `DocumentSchema` ([commit 9161ec3](https://github.com/googleapis/google-cloud-dotnet/commit/9161ec3cbc47939c6e0e0a5ca8640a34f80b6a0c))

### Documentation improvements

- Updated comments ([commit 9161ec3](https://github.com/googleapis/google-cloud-dotnet/commit/9161ec3cbc47939c6e0e0a5ca8640a34f80b6a0c))

## Version 2.0.0-beta14, released 2024-02-09

### New features

- Add model_type in v1beta3 processor proto ([commit ec4dfb3](https://github.com/googleapis/google-cloud-dotnet/commit/ec4dfb38e20d9892acbdd5b3965b3846e18392a6))

## Version 2.0.0-beta13, released 2023-09-26

### New features

- Added `SummaryOptions` to `ProcessOptions` for the Summarizer processor ([commit 93462fd](https://github.com/googleapis/google-cloud-dotnet/commit/93462fdb28303e0a750b4388090881d2a90c1086))
- Added `ListDocuments()` method for Document AI Workbench training documents ([commit 93462fd](https://github.com/googleapis/google-cloud-dotnet/commit/93462fdb28303e0a750b4388090881d2a90c1086))

### Documentation improvements

- Update client libraries for Enterprise OCR add-ons ([commit 2d30aa5](https://github.com/googleapis/google-cloud-dotnet/commit/2d30aa57756279103bfd46c9a8b19dba542cb047))

## Version 2.0.0-beta12, released 2023-08-04

### New features

- Exposed Import PV external_processor_version_source to v1beta3 public ([commit 5962731](https://github.com/googleapis/google-cloud-dotnet/commit/5962731b3c78e602fe5d2ebca4caa16f9b7958dc))
- **BREAKING CHANGE** Removed id field from Document message ([commit 359acc0](https://github.com/googleapis/google-cloud-dotnet/commit/359acc0963e3df766561d2193150e06fc1aaf150))
- Added http configuration and document publishing for v1beta2 ([commit 359acc0](https://github.com/googleapis/google-cloud-dotnet/commit/359acc0963e3df766561d2193150e06fc1aaf150))
- Added ImportDocuments, GetDocument and BatchDeleteDocuments RPCs for v1beta3 ([commit 359acc0](https://github.com/googleapis/google-cloud-dotnet/commit/359acc0963e3df766561d2193150e06fc1aaf150))

## Version 2.0.0-beta11, released 2023-06-20

### New features

- Add StyleInfo to document.proto ([commit f2334ad](https://github.com/googleapis/google-cloud-dotnet/commit/f2334ad1e2254fcf81131ba0ee05f0ce04d770cf))
- Add REPLACE enum to OperationType in document.proto ([commit f2334ad](https://github.com/googleapis/google-cloud-dotnet/commit/f2334ad1e2254fcf81131ba0ee05f0ce04d770cf))
- Add PropertyMetadata and EntityTypeMetadata to document_schema.proto ([commit f2334ad](https://github.com/googleapis/google-cloud-dotnet/commit/f2334ad1e2254fcf81131ba0ee05f0ce04d770cf))
- Add IMPORTING enum to State in processor.proto ([commit f2334ad](https://github.com/googleapis/google-cloud-dotnet/commit/f2334ad1e2254fcf81131ba0ee05f0ce04d770cf))

## Version 2.0.0-beta10, released 2023-03-27

### New features

- Add ImportProcessorVersion in v1beta3 ([commit e54a307](https://github.com/googleapis/google-cloud-dotnet/commit/e54a307315fb97918527cb185d7f199ed4e557ab))

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
