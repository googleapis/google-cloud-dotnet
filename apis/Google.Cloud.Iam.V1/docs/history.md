# Version history

## Version 3.4.0, released 2024-12-06

### New features

- Add ResourcePolicyMember to google/iam/v1 ([commit 3c1d048](https://github.com/googleapis/google-cloud-dotnet/commit/3c1d048a7cf49965a67dabdf8e5a7628ab9efde0))

## Version 3.3.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.2.0, released 2024-03-25

### New features

This library now targets netstandard2.0 instead of netstandard2.1.
This should be compatible with existing libraries that depend on it,
but will allow new libraries to also target netstandard2.0.

## Version 3.1.0, released 2024-02-28

### Documentation improvements

- Minor formatting ([commit cae56e0](https://github.com/googleapis/google-cloud-dotnet/commit/cae56e096d7119fe82d7201316ff6da42223eb52))

## Version 3.0.0, released 2022-06-07

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code.The changes that aren't specific to any given API are [described in the Google Cloud
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

## Version 2.4.0, released 2022-04-05

### New features

- AuditConfig for IAM v1 ([commit bc4cfd8](https://github.com/googleapis/google-cloud-dotnet/commit/bc4cfd8e05ffc261decc84a05027c99aba1f6acb))

## Version 2.3.0, released 2021-11-08

- [Commit 753d624](https://github.com/googleapis/google-cloud-dotnet/commit/753d624): chore: Remove old "pseudo-handwritten" resource names file
- [Commit 1b7246b](https://github.com/googleapis/google-cloud-dotnet/commit/1b7246b): feat: Regenerate Google.Cloud.Iam.V1 (as a GAPIC package)

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-10-19

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency and implementation changes.

## Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.3.0, released 2019-12-09

- [Commit f8f09a8](https://github.com/googleapis/google-cloud-dotnet/commit/f8f09a8): Update IAM helper methods to protect against IAM conditions. The methods throw an exception if:
  - The policy version is greater than 1
  - Any bindings have conditions
- [Commit ab0fe73](https://github.com/googleapis/google-cloud-dotnet/commit/ab0fe73): Added GetPolicyOptions
- [Commit 65376a1](https://github.com/googleapis/google-cloud-dotnet/commit/65376a1): Introduces IAM conditions

## Version 1.2.0, released 2019-02-20

(No visible API changes; could have been released as a patch to 1.1.0.)

## Version 1.1.0, released 2018-06-28

- [Commit 74a5ba8](https://github.com/googleapis/google-cloud-dotnet/commit/74a5ba8): Add resource name properties to IAM requests

## Version 1.0.0, released 2017-12-05

Initial GA release.
