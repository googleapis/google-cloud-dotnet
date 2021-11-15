# Version history

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
