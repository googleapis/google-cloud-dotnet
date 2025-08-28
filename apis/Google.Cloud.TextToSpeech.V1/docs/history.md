# Version history

## Version 3.13.0, released 2025-08-28

### New features

- Support promptable voices by specifying a model name and a prompt
- Add enum value M4A to enum AudioEncoding

### Documentation improvements

- A comment for enum value `AUDIO_ENCODING_UNSPECIFIED` in enum `AudioEncoding` is changed

## Version 3.12.0, released 2025-05-22

### New features

- Support markup input for Cloud TTS Chirp 3: HD voice synthesis
- Support pinyin/yomigana custom pronunciation encodings for cmn-cn/ja-jp

## Version 3.11.0, released 2025-04-14

### New features

- Support HD voice custom pronunciations ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))

### Documentation improvements

- A comment for method `StreamingSynthesize` in service `TextToSpeech` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for enum value `OGG_OPUS` in enum `AudioEncoding` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for enum value `PCM` in enum `AudioEncoding` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `low_latency_journey_synthesis` in message `.google.cloud.texttospeech.v1.AdvancedVoiceOptions` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for enum value `PHONETIC_ENCODING_IPA` in enum `PhoneticEncoding` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for enum value `PHONETIC_ENCODING_X_SAMPA` in enum `PhoneticEncoding` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `phrase` in message `.google.cloud.texttospeech.v1.CustomPronunciationParams` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `pronunciations` in message `.google.cloud.texttospeech.v1.CustomPronunciations` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for message `MultiSpeakerMarkup` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `custom_pronunciations` in message `.google.cloud.texttospeech.v1.SynthesisInput` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `voice_clone` in message `.google.cloud.texttospeech.v1.VoiceSelectionParams` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `audio_encoding` in message `.google.cloud.texttospeech.v1.StreamingAudioConfig` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))
- A comment for field `text` in message `.google.cloud.texttospeech.v1.StreamingSynthesisInput` is changed ([commit 19b3b40](https://github.com/googleapis/google-cloud-dotnet/commit/19b3b40e17daeda4fb9266a2e87524fb6b4599f9))

## Version 3.10.0, released 2025-01-13

### New features

- StreamingSynthesize now supports opus ([commit f12b892](https://github.com/googleapis/google-cloud-dotnet/commit/f12b892a397252181d30582124f865fbf8fd3c3a))

## Version 3.9.0, released 2024-10-29

### New features

- Add multi-speaker markup, which allows generating dialogue between multiple speakers ([commit 94c353c](https://github.com/googleapis/google-cloud-dotnet/commit/94c353c51b23301309aacbcf055b147a085612e8))
- Add brand voice lite, which lets you clone a voice with just 10 seconds of audio ([commit 6635e62](https://github.com/googleapis/google-cloud-dotnet/commit/6635e6209450b1005ca0c15495c0724c90a955a5))

## Version 3.8.0, released 2024-10-14

### New features

- Add low latency journey option to proto ([commit 96b9816](https://github.com/googleapis/google-cloud-dotnet/commit/96b9816db06cd726d959b0e8ad57bbd5cdb0ad0a))
- Add CustomPronunciationParams for upcoming feature work ([commit 96b9816](https://github.com/googleapis/google-cloud-dotnet/commit/96b9816db06cd726d959b0e8ad57bbd5cdb0ad0a))

## Version 3.7.0, released 2024-09-09

### New features

- A new method `StreamingSynthesize` is added to service `TextToSpeech` ([commit 7a34ef0](https://github.com/googleapis/google-cloud-dotnet/commit/7a34ef081baa8b944e2d8d689336ce6b15e5b5e2))

### Documentation improvements

- Update Long Audio capabilities to include SSML ([commit 05630e2](https://github.com/googleapis/google-cloud-dotnet/commit/05630e2e7806e8894ab892a428b83cbeb187ee37))
- A comment for field `name` in message `.google.cloud.texttospeech.v1.VoiceSelectionParams` is changed ([commit 7a34ef0](https://github.com/googleapis/google-cloud-dotnet/commit/7a34ef081baa8b944e2d8d689336ce6b15e5b5e2))

## Version 3.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.4.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.3.0, released 2024-01-08

### Bug fixes

- Correct long audio synthesis HTTP binding ([commit ce90310](https://github.com/googleapis/google-cloud-dotnet/commit/ce90310499ec80b42ec5412a0cb538a3bbe71561))

### Documentation improvements

- Deprecate the custom voice usage field ([commit ce90310](https://github.com/googleapis/google-cloud-dotnet/commit/ce90310499ec80b42ec5412a0cb538a3bbe71561))
- Update documentation to require certain fields ([commit 43382af](https://github.com/googleapis/google-cloud-dotnet/commit/43382afe88bd439072507a6c4566a54f67c5f21a))

## Version 3.2.0, released 2023-01-11

This is primarily a promotion of the previous beta, which includes
REST transport support. No API surface changes; just dependency updates.

## Version 3.2.0-beta01, released 2022-12-08

### New features

- Enable REST transport in selected APIs. Set GrpcAdapter=RestGrpcAdapter.Default in the client builder to use this transport ([commit 5008946](https://github.com/googleapis/google-cloud-dotnet/commit/500894667ba84ecc3d8e3e4ebc09ac0cd597100b))

## Version 3.1.0, released 2022-12-08

### New features

- Add LRS API ([commit a37c5f3](https://github.com/googleapis/google-cloud-dotnet/commit/a37c5f3955bff787e2dd8f3a3a19b97a89f29e02))

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
## Version 2.5.0, released 2022-03-14

### New features

- Promote CustomVoiceParams to v1 ([commit ba7f867](https://github.com/googleapis/google-cloud-dotnet/commit/ba7f867b223b52cbbf0d742fd603e3f99cc52c99))

### Documentation improvements

- Update comments for ListVoicesRequest ([commit 479ddef](https://github.com/googleapis/google-cloud-dotnet/commit/479ddef27f04eb184c2c2cdb621fe5caf6a4118b))

## Version 2.4.0, released 2021-11-18

- [Commit fc5df69](https://github.com/googleapis/google-cloud-dotnet/commit/fc5df69):
  - feat: Add Mulaw and Alaw values to AudioEncoding
  - feat: Generate a resource name for Model
- [Commit 6b42688](https://github.com/googleapis/google-cloud-dotnet/commit/6b42688): docs: fix docstring formatting

## Version 2.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-11

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 4511a72](https://github.com/googleapis/google-cloud-dotnet/commit/4511a72): chore: escape `*` characters in comments
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 4132c74](https://github.com/googleapis/google-cloud-dotnet/commit/4132c74): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.1.0, released 2019-12-09

- [Commit bf4d39c](https://github.com/googleapis/google-cloud-dotnet/commit/bf4d39c): Some settings are now obsolete, and will be removed in the next major version.

## Version 1.0.0, released 2019-07-10

Initial GA release.
