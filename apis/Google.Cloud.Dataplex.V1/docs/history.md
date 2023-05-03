# Version history

## Version 2.4.0, released 2023-05-03

### New features

- Added new Dataplex APIs and new features for existing APIs (e.g. DataScans) ([commit 5da3cc6](https://github.com/googleapis/google-cloud-dotnet/commit/5da3cc6e696341f295a3518a64b1fb6fceb7d7a9))

### Documentation improvements

- Updated comments for multiple Dataplex APIs ([commit 5da3cc6](https://github.com/googleapis/google-cloud-dotnet/commit/5da3cc6e696341f295a3518a64b1fb6fceb7d7a9))

## Version 2.3.0, released 2023-02-08

### New features

- Enable REST transport in C# ([commit 44c6d16](https://github.com/googleapis/google-cloud-dotnet/commit/44c6d16ce10fbea5debaae0eb22ea2f2dbda1b59))
- DataScans service ([commit 300ee9a](https://github.com/googleapis/google-cloud-dotnet/commit/300ee9a5046e902fa445ddd2e102249ef3b80b80))
- Added StorageFormat.iceberg ([commit 300ee9a](https://github.com/googleapis/google-cloud-dotnet/commit/300ee9a5046e902fa445ddd2e102249ef3b80b80))

### Documentation improvements

- Improvements to DataScan API documentation ([commit f4c2568](https://github.com/googleapis/google-cloud-dotnet/commit/f4c2568c5fb6fe0f674e298b5b332a04ed1ef51b))
- Fix minor docstring formatting ([commit 0117520](https://github.com/googleapis/google-cloud-dotnet/commit/01175207962b27b34e86db961ab2cd93039e9c90))
- Fix minor docstring formatting ([commit 66e3386](https://github.com/googleapis/google-cloud-dotnet/commit/66e338638742deadf1f2495e87a478b5e484d8d3))

## Version 2.2.0, released 2022-10-17

### New features

- Add support for notebook tasks ([commit 747c3cc](https://github.com/googleapis/google-cloud-dotnet/commit/747c3cce51f655e638db69943faa9df0f3a49488))

## Version 2.1.0, released 2022-07-25

### New features

- Add IAM support for Explore content APIs ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for custom container for Task ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for cross project for Task ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for custom encryption key to be used for encrypt data on the PDs associated with the VMs in your Dataproc cluster for Task ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Add support for Latest job in Task resource ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- User mode filter in Explore list sessions API ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))
- Support logging sampled file paths per partition to Cloud logging for Discovery event ([commit 0f67ba8](https://github.com/googleapis/google-cloud-dotnet/commit/0f67ba89c2095e73abc43cc4d63b251453bbe57f))

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


## Version 1.0.0, released 2022-03-14

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2022-02-22

### New features

- New Content APIs ([commit 1ea3fe0](https://github.com/googleapis/google-cloud-dotnet/commit/1ea3fe02fc4352000e3ff9ad291268e963f89029))
- Create|Update|Delete Metadata APIs (e.g. Entity and/or Partition) ([commit 1ea3fe0](https://github.com/googleapis/google-cloud-dotnet/commit/1ea3fe02fc4352000e3ff9ad291268e963f89029))
## Version 1.0.0-beta01, released 2022-02-16

Initial release.
