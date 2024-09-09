# Version history

## Version 2.0.0-beta08, released 2024-09-09

### New features

- A new method `StreamingSynthesize` is added to service `TextToSpeech` ([commit 6998d73](https://github.com/googleapis/google-cloud-dotnet/commit/6998d73ace75a0f5e6330403e9fe6fd56c8d829a))

### Documentation improvements

- Update Long Audio capabilities to include SSML ([commit 6ed33a1](https://github.com/googleapis/google-cloud-dotnet/commit/6ed33a1d0a312e9c66cbef9ae402806376be6b6e))
- A comment for field `name` in message `.google.cloud.texttospeech.v1beta1.VoiceSelectionParams` is changed ([commit 6998d73](https://github.com/googleapis/google-cloud-dotnet/commit/6998d73ace75a0f5e6330403e9fe6fd56c8d829a))

## Version 2.0.0-beta07, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta06, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta05, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.0.0-beta04, released 2024-01-08

### Bug fixes

- **BREAKING CHANGE** Correct long audio synthesis HTTP binding ([commit 8e47bc8](https://github.com/googleapis/google-cloud-dotnet/commit/8e47bc8ef2ade2fca2763ad2a91c4ce66283ec24))

### Documentation improvements

- Deprecate the custom voice usage field ([commit 8e47bc8](https://github.com/googleapis/google-cloud-dotnet/commit/8e47bc8ef2ade2fca2763ad2a91c4ce66283ec24))
- Update documentation to require certain fields ([commit d79e879](https://github.com/googleapis/google-cloud-dotnet/commit/d79e87933ea43d41c8dfcecfe540dec85b54cbc9))

## Version 2.0.0-beta03, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

### Documentation improvements

- Fix minor docstring formatting ([commit 72b28ed](https://github.com/googleapis/google-cloud-dotnet/commit/72b28ed3cb82739b5e8f7dbc69b7644d83cecc2d))

## Version 2.0.0-beta02, released 2022-12-14

### New features

- Add LRS API ([commit 96674eb](https://github.com/googleapis/google-cloud-dotnet/commit/96674ebab1a4294ba23bdb378e0c225ce5e923df))

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
## Version 1.0.0-beta04, released 2022-01-17

### Documentation improvements

- Update comments for ListVoicesRequest ([commit d517082](https://github.com/googleapis/google-cloud-dotnet/commit/d517082c8a79b3fb61f176cd95b65507fd6f5cb6))

## Version 1.0.0-beta03, released 2021-11-18

- [Commit 2260d7c](https://github.com/googleapis/google-cloud-dotnet/commit/2260d7c):
  - feat: Add Mulaw and Alaw values to AudioEncoding
  - feat: Generate a resource name for Model

## Version 1.0.0-beta02, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-05-25

Initial release.
