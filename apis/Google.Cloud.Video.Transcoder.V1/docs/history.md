# Version history

## Version 2.11.0, released 2025-08-28

### New features

- Add support for automatically generating subtitle for input videos

## Version 2.10.0, released 2025-07-22

### New features

- Added support for specifying HEVC codec tag
- Added support for converting the input video to a supported high dynamic range (HDR) formats
- Added support for DROP_DUPLICATE frame rate conversion strategy to achieve the exact frame rate on the output video
- Added support for fill_content_gaps field to allow processing inputs with significant number of missing frames

### Documentation improvements

- Improve comment formatting, add links, add references

## Version 2.9.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.8.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.7.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.6.0, released 2023-07-13

### New features

- Added support for segment template manifest generation with DASH ([commit b6f1f52](https://github.com/googleapis/google-cloud-dotnet/commit/b6f1f52743c6818e9615bbc84a007759cbf7b064))
- Added support for batch mode priority ([commit b6f1f52](https://github.com/googleapis/google-cloud-dotnet/commit/b6f1f52743c6818e9615bbc84a007759cbf7b064))
- Added support for disabling job processing optimizations ([commit b6f1f52](https://github.com/googleapis/google-cloud-dotnet/commit/b6f1f52743c6818e9615bbc84a007759cbf7b064))
- Added support for content encryption (DRM) ([commit b6f1f52](https://github.com/googleapis/google-cloud-dotnet/commit/b6f1f52743c6818e9615bbc84a007759cbf7b064))

## Version 2.5.0, released 2023-04-19

### New features

- Add support for batch processing mode ([commit 9eb2a76](https://github.com/googleapis/google-cloud-dotnet/commit/9eb2a76b6062711aaa2f1a22ca307bcdbac9176f))

## Version 2.4.0, released 2023-03-06

### New features

- Specifying language code and display name for text and audio streams is now supported ([commit 5802f24](https://github.com/googleapis/google-cloud-dotnet/commit/5802f24a38927568ffbe807f85013f420a28cb96))

## Version 2.3.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

## Version 2.2.0, released 2022-12-01

### New features

- Add PreprocessingConfig.deinterlace ([commit f5af179](https://github.com/googleapis/google-cloud-dotnet/commit/f5af17911707975405b510b0408d747e441921cb))

### Documentation improvements

- Minor documentation changes ([commit f5af179](https://github.com/googleapis/google-cloud-dotnet/commit/f5af17911707975405b510b0408d747e441921cb))

## Version 2.1.0, released 2022-07-11

### New features

- Add support for user labels for job and job template ([commit 54cd815](https://github.com/googleapis/google-cloud-dotnet/commit/54cd81514064475bbab6b28357eb9cb57f17e986))

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
## Version 1.0.0, released 2022-01-25

No API surface changes; just dependency updates and promotion to 1.0.0.

## Version 1.0.0-beta03, released 2021-10-12

- [Commit 18a65f3](https://github.com/googleapis/google-cloud-dotnet/commit/18a65f3):
  - docs: clarify that project number is used as the canonical project identifier for job and job template names
  - docs: fix broken link and code formatting
  - feat: add support for allow_missing param on DELETE request
  - fix!: remove Encryption settings that were published due to a sync issue
  - BREAKING CHANGE: requests specifying Encryption settings are rejected by the server

## Version 1.0.0-beta02, released 2021-09-23

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs
- [Commit ead80b6](https://github.com/googleapis/google-cloud-dotnet/commit/ead80b6): feat: Enables generation of client libraries for C#, php and ruby.

## Version 1.0.0-beta01, released 2021-07-09

Initial release.
