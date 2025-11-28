# Version history

## Version 3.9.0, released 2025-11-06

### New features

- Update dependencies

## Version 3.8.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.7.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.6.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.5.0, released 2023-11-07

### New features

- Support MP3, TranscriptNormalization and SpeakerLabels in STT V1 API ([commit f2cb8d6](https://github.com/googleapis/google-cloud-dotnet/commit/f2cb8d6e29b3fbe498e83e4d5ac38837387cc4d8))

### Documentation improvements

- Fix the resource name format in comment for CreatePhraseSetRequest ([commit af90271](https://github.com/googleapis/google-cloud-dotnet/commit/af90271586531102fb7433bd36df8566f3a6ca01))

## Version 3.4.0, released 2023-03-06

### New features

- Voice Activity Detection: adding speech event time and speech event type ([commit dda7fc9](https://github.com/googleapis/google-cloud-dotnet/commit/dda7fc9b0f4b57d947debc0c39bdec993112c11c))

### Documentation improvements

- Clarified boost usage ([commit 195e99a](https://github.com/googleapis/google-cloud-dotnet/commit/195e99ad761dea4da992c74d4e7d8d826b8053e7))

## Version 3.3.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 3.2.0, released 2023-01-16

### New features

- Added ABNF Grammars field in Speech Adaptation ([commit 2306722](https://github.com/googleapis/google-cloud-dotnet/commit/2306722c52d3bdd1e1e830910862ee0301720527))

## Version 3.1.0, released 2022-12-14

### New features

- Added new fields to facilitate debugging ([commit 5491c8f](https://github.com/googleapis/google-cloud-dotnet/commit/5491c8f8d30a596c8131d7b7bd86564a67177280))

## Version 3.0.0, released 2022-06-08

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


## Version 2.9.0, released 2022-05-24

### New features

- Add adaptation proto for v1 api ([commit 1c5ae72](https://github.com/googleapis/google-cloud-dotnet/commit/1c5ae72d726a594e08e92a3a652f61a2263bbdc2))

### Documentation improvements

- Add documentation for latest models to RecognitionConfig ([commit f50b641](https://github.com/googleapis/google-cloud-dotnet/commit/f50b641216be4dc3847aa954fb291fcccfed4101))

## Version 2.8.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 2.7.0, released 2021-12-07

- [Commit cbbd9a3](https://github.com/googleapis/google-cloud-dotnet/commit/cbbd9a3):
  - feat: added alternative_language_codes to RecognitionConfig
  - feat: WEBM_OPUS codec
  - feat: SpeechAdaptation configuration
  - feat: word confidence
  - feat: spoken punctuation and spoken emojis
  - feat: hint boost in SpeechContext
## Version 2.6.0, released 2021-10-12

- [Commit dc07468](https://github.com/googleapis/google-cloud-dotnet/commit/dc07468):
  - feat: update gapic-generator-csharp to 1.3.11
  - feat: update rules_gapic to 0.8.0

## Version 2.5.0, released 2021-09-24

- [Commit 09c3f7d](https://github.com/googleapis/google-cloud-dotnet/commit/09c3f7d): feat: add output_config request field

## Version 2.4.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.3.0, released 2021-08-10

- [Commit 73a4ba0](https://github.com/googleapis/google-cloud-dotnet/commit/73a4ba0): feat: add total_billed_time response field

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-10

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 7c84c9a](https://github.com/googleapis/google-cloud-dotnet/commit/7c84c9a): chore: Clarify the data source in both the generator and LangageCodes.cs
- [Commit 3b367f0](https://github.com/googleapis/google-cloud-dotnet/commit/3b367f0): feat: Regenerate the speech language codes

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.3.1, released 2019-12-16

- [Commit 3ac2779](https://github.com/googleapis/google-cloud-dotnet/commit/3ac2779): Regenerate without retry for streaming calls. Fixes [issue 3902](https://github.com/googleapis/google-cloud-dotnet/issues/3902).

## Version 1.3.0, released 2019-12-09

- [Commit bdb68ed](https://github.com/googleapis/google-cloud-dotnet/commit/bdb68ed): SpeakerDiarizationConfig.SpeakerTag is now obsolete.
- [Commit 0537e3c](https://github.com/googleapis/google-cloud-dotnet/commit/0537e3c): Introduces WordInfo.SpeakerTag
- [Commit f481c88](https://github.com/googleapis/google-cloud-dotnet/commit/f481c88): Makes some retry settings obsolete; these will be removed in the next major version
- [Commit 648fabe](https://github.com/googleapis/google-cloud-dotnet/commit/648fabe): Adds speaker diarization configuration
- [Commit 8777ebb](https://github.com/googleapis/google-cloud-dotnet/commit/8777ebb): Regenerate language codes

## Version 1.2.0, released 2019-07-10

- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Introduce ClientBuilders for simplified configuration
- [Commit 51b3107](https://github.com/googleapis/google-cloud-dotnet/commit/51b3107): Regenerate Cloud Speech: adds RecognitionMetadata

## Version 1.1.0, released 2019-02-05

- [Commit fb6f9ea](https://github.com/googleapis/google-cloud-dotnet/commit/fb6f9ea): Adds RecognitionConfig.AudioChannelCount
- [Commit 2171f4a](https://github.com/googleapis/google-cloud-dotnet/commit/2171f4a): Adds the ability to recognize on each channel separately
- [Commit 1143b43](https://github.com/googleapis/google-cloud-dotnet/commit/1143b43): New features:
  - Automatic punctuation
  - Model configuration
  - Enhanced models
- [Commit a4b3499](https://github.com/googleapis/google-cloud-dotnet/commit/a4b3499): Regenerate language codes

## Version 1.0.1, released 2018-01-25

- [Commit a02e785](https://github.com/googleapis/google-cloud-dotnet/commit/a02e785): Updated timeouts

## Version 1.0.0, released 2017-09-19

Initial GA release.
