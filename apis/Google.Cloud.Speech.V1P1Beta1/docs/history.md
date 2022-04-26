# Version history

## Version 2.0.0-beta08, released 2022-04-26

### Documentation improvements

- Use full link in comment ([commit dc5c9ea](https://github.com/googleapis/google-cloud-dotnet/commit/dc5c9ea1f05e2b62e62ab9e63ca82e66a4118f97))

## Version 2.0.0-beta07, released 2021-12-07

- [Commit bc7d94d](https://github.com/googleapis/google-cloud-dotnet/commit/bc7d94d): feat: add result_end_time to SpeechRecognitionResult

## Version 2.0.0-beta06, released 2021-09-23

- [Commit 3f9793d](https://github.com/googleapis/google-cloud-dotnet/commit/3f9793d): feat: Add transcript normalization
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.0.0-beta05, released 2021-07-28

- [Commit 1b4497f](https://github.com/googleapis/google-cloud-dotnet/commit/1b4497f):
  - feat: add total_billed_time response field.
  - fix!: phrase_set_id is required field in CreatePhraseSetRequest.
  - fix!: custom_class_id is required field in CreateCustomClassRequest.

Note: the breaking changes here are in terms of metadata, not
breaking changes in the library itself.

## Version 2.0.0-beta04, released 2021-04-29

- [Commit e9b8f84](https://github.com/googleapis/google-cloud-dotnet/commit/e9b8f84): feat: add webm opus support.
- [Commit 582d15d](https://github.com/googleapis/google-cloud-dotnet/commit/582d15d): feat: Support for spoken punctuation and spoken emojis.
- [Commit d8fd61b](https://github.com/googleapis/google-cloud-dotnet/commit/d8fd61b): feat: Support output transcript to GCS for LongRunningRecognize.
- [Commit 20f02d4](https://github.com/googleapis/google-cloud-dotnet/commit/20f02d4): feat: Support output transcript to GCS for LongRunningRecognize.
- [Commit 872b52e](https://github.com/googleapis/google-cloud-dotnet/commit/872b52e): feat: Support Model Adaptation.

## Version 2.0.0-beta03, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 7cf6cd8](https://github.com/googleapis/google-cloud-dotnet/commit/7cf6cd8): feat: Add speech adaptation, phrase sets and custom classes.

## Version 2.0.0-beta02, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0-beta05, released 2019-12-16

- [Commit 3ac2779](https://github.com/googleapis/google-cloud-dotnet/commit/3ac2779): Regenerate without retry for streaming calls. Fixes [issue 3902](https://github.com/googleapis/google-cloud-dotnet/issues/3902).

## Version 1.0.0-beta04, released 2019-12-09

- Some retry settings have been removed
- Added Speaker Diariazation
- Added RecognitionMetadata.ObfuscatedId

## Version 1.0.0-beta03, released 2019-06-10

- Added AudioEncoding.Mp3
- Added client builders for simpler configuration
- Added SpeechContext.Boost
- Added StreamingRecognitionResult.ResultEndTime

## Version 1.0.0-beta02, released 2018-08-02

- Added various language codes

## Version 1.0.0-beta01, released 2018-07-17

First beta release
