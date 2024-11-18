# Version history

## Version 3.9.0, released 2024-11-18

### New features

- Adds Contextual Glossary support for Translation and AdaptiveMt ([commit 72051d3](https://github.com/googleapis/google-cloud-dotnet/commit/72051d33175df07abcda54e621712efe7d143afd))

## Version 3.8.0, released 2024-08-13

### New features

- Add BigQuery Metastore Partition Service API version v1alpha ([commit 3bd0dfb](https://github.com/googleapis/google-cloud-dotnet/commit/3bd0dfb945087291bd84d226caf1d3dd93ddb033))
- Adds AdaptiveMt HTML/Glossary support ([commit 06616a2](https://github.com/googleapis/google-cloud-dotnet/commit/06616a219e221491071eb0f4325182927088d748))
- Adds protos for Custom Translation API (AutoML) ([commit 06616a2](https://github.com/googleapis/google-cloud-dotnet/commit/06616a219e221491071eb0f4325182927088d748))
- Adds protos for Transliteration in V3 Advanced translate text ([commit 06616a2](https://github.com/googleapis/google-cloud-dotnet/commit/06616a219e221491071eb0f4325182927088d748))
- Adds protos for Romanization APIs ([commit 06616a2](https://github.com/googleapis/google-cloud-dotnet/commit/06616a219e221491071eb0f4325182927088d748))

### Documentation improvements

- Fixes typos in docs ([commit 06616a2](https://github.com/googleapis/google-cloud-dotnet/commit/06616a219e221491071eb0f4325182927088d748))

## Version 3.7.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.5.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.4.0, released 2024-01-08

### New features

- Add Adaptive MT API ([commit a8ac2b9](https://github.com/googleapis/google-cloud-dotnet/commit/a8ac2b9689c81a47561cdfe156dcd6547d922abf))

### Documentation improvements

- Fixes a typo in docs ([commit a8ac2b9](https://github.com/googleapis/google-cloud-dotnet/commit/a8ac2b9689c81a47561cdfe156dcd6547d922abf))

## Version 3.3.0, released 2023-08-16

### New features

- Added shadow removal and rotation correction options to Document Translation and Batch Document Translation API ([commit 1f31c26](https://github.com/googleapis/google-cloud-dotnet/commit/1f31c266c47febf4713bc733cc76fbb7c33dbdba))

### Documentation improvements

- Minor formatting ([commit ccddac4](https://github.com/googleapis/google-cloud-dotnet/commit/ccddac405abc0401efa6337fa134abe6f3ae011e))
- Minor formatting ([commit 1097b47](https://github.com/googleapis/google-cloud-dotnet/commit/1097b47fe89a2f7e1d42bee388f037a98e22080e))

## Version 3.2.0, released 2023-02-22

### New features

- Add supported fields in document translation request and refresh translation v3 GA service proto documentation ([commit 5f9b413](https://github.com/googleapis/google-cloud-dotnet/commit/5f9b4132fcc06028136c126862cf6ad7b85c3643))

## Version 3.1.0, released 2023-01-17

### New features

- Enable REST transport in C# ([commit cdb518c](https://github.com/googleapis/google-cloud-dotnet/commit/cdb518c3524106ea73f0e546557a0180589ca3b0))

### Documentation improvements

- Fix minor docstring formatting ([commit b68a90c](https://github.com/googleapis/google-cloud-dotnet/commit/b68a90c9efa01d58ff7672de43eb770d7223b9f9))

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


## Version 2.4.0, released 2021-10-20

- [Commit 294aefe](https://github.com/googleapis/google-cloud-dotnet/commit/294aefe): fix: add model signature for batch document translation

## Version 2.3.0, released 2021-08-31

- [Commit 1440a7c](https://github.com/googleapis/google-cloud-dotnet/commit/1440a7c): feat: added v3 proto for online/batch document translation and updated v3beta1 proto for format conversion
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-11

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 40b96b3](https://github.com/googleapis/google-cloud-dotnet/commit/40b96b3): docs: add backticks in docstring to smooth doc generation ([issue 5220](https://github.com/googleapis/google-cloud-dotnet/issues/5220))
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0, released 2019-12-11

Initial GA release.
