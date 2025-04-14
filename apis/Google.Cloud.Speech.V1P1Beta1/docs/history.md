# Version history

## Version 3.0.0-beta09, released 2025-04-14

### New features

- Expose google.cloud.location.Locations API ([commit ed6c6aa](https://github.com/googleapis/google-cloud-dotnet/commit/ed6c6aadcf10ec1c43f7104d3278d2ccef6a1d1d))
- Add new fields to CustomClass and PhraseSet.Phrase messages ([commit ed6c6aa](https://github.com/googleapis/google-cloud-dotnet/commit/ed6c6aadcf10ec1c43f7104d3278d2ccef6a1d1d))
- Add ALAW support to RecognitionConfig ([commit ed6c6aa](https://github.com/googleapis/google-cloud-dotnet/commit/ed6c6aadcf10ec1c43f7104d3278d2ccef6a1d1d))
- Make transcript_normalization field optional ([commit ed6c6aa](https://github.com/googleapis/google-cloud-dotnet/commit/ed6c6aadcf10ec1c43f7104d3278d2ccef6a1d1d))
- Deprecating speaker_tag (int) for speaker_label (string) ([commit ed6c6aa](https://github.com/googleapis/google-cloud-dotnet/commit/ed6c6aadcf10ec1c43f7104d3278d2ccef6a1d1d))

### Documentation improvements

- Miscellaneous clarifications ([commit ed6c6aa](https://github.com/googleapis/google-cloud-dotnet/commit/ed6c6aadcf10ec1c43f7104d3278d2ccef6a1d1d))

## Version 3.0.0-beta08, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.0.0-beta07, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.0.0-beta06, released 2024-02-29

### Documentation improvements

- Fix the resource name format in comment for CreatePhraseSetRequest ([commit c2e3fcf](https://github.com/googleapis/google-cloud-dotnet/commit/c2e3fcffb4dfaecd7b2d0b160a0b68ded3df80e4))

## Version 3.0.0-beta05, released 2023-03-06

### New features

- Voice Activity Detection: adding speech event time and speech event type ([commit 848a5f9](https://github.com/googleapis/google-cloud-dotnet/commit/848a5f9a6e4754e9eaf1c9ec99767a5ccc7715c0))

### Documentation improvements

- Clarified boost usage ([commit 60b081b](https://github.com/googleapis/google-cloud-dotnet/commit/60b081b2a4bb218dff04d104f6362ce821114f48))
- Clarify boost usage in Reference ([commit 01f388a](https://github.com/googleapis/google-cloud-dotnet/commit/01f388ae2c15423390d6bdb5127e35390b12c03b))

## Version 3.0.0-beta04, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 3.0.0-beta03, released 2023-01-16

### New features

- Added ABNF Grammars field in Speech Adaptation ([commit abc551e](https://github.com/googleapis/google-cloud-dotnet/commit/abc551e160cef5b1a8e23f8635261521d557a1c0))

## Version 3.0.0-beta02, released 2022-12-14

### New features

- Added new fields to facilitate debugging ([commit 915f69d](https://github.com/googleapis/google-cloud-dotnet/commit/915f69d4306bc74d8c1980c13a87f94290fc7fda))

## Version 3.0.0-beta01, released 2022-06-08

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


## Version 2.0.0-beta09, released 2022-05-24

### Documentation improvements

- Update client libraries for v1p1beta1 api ([commit f6e9deb](https://github.com/googleapis/google-cloud-dotnet/commit/f6e9deb2fc0e462b27bc347eb537b357bfd1c0f7))
- Add documentation for latest models to RecognitionConfig ([commit ed7287c](https://github.com/googleapis/google-cloud-dotnet/commit/ed7287c8dc25ec0a1f37469b18f4569a478c03e0))

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
