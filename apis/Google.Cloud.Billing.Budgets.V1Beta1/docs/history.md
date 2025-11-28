# Version history

## Version 2.0.0-beta07, released 2025-11-05

### New features

- Update dependencies

## Version 2.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.0.0-beta05, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.0.0-beta04, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.0.0-beta03, released 2023-08-23

### New features

- Supported project-level-budgets in Public Budget API V1Beta ([commit 24aa41e](https://github.com/googleapis/google-cloud-dotnet/commit/24aa41e808006adacba923c2b827dcaf6c4d35b6))
- Added `enable_project_level_recipients` for project owner budget emails ([commit 24aa41e](https://github.com/googleapis/google-cloud-dotnet/commit/24aa41e808006adacba923c2b827dcaf6c4d35b6))

## Version 2.0.0-beta02, released 2023-06-20

### New features

- Add resource_ancestors field to support filtering by folders & organizations ([commit 1690c59](https://github.com/googleapis/google-cloud-dotnet/commit/1690c591d780e0d63e818be8a2f6beb51463a633))

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
## Version 1.0.0-beta05, released 2022-02-11

### Documentation improvements

- Formatting change from HTML to markdown; Additional clarifications ([commit f022157](https://github.com/googleapis/google-cloud-dotnet/commit/f022157db890a54b9c1c1d1d3fba38ef930b4d8d))

## Version 1.0.0-beta04, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta03, released 2021-04-29

- [Commit 4f20acd](https://github.com/googleapis/google-cloud-dotnet/commit/4f20acd):
  - feat: Added support for configurable budget time period.
  - fix: Updated some documentation links.
- [Commit ab48b2b](https://github.com/googleapis/google-cloud-dotnet/commit/ab48b2b): docs: Update rules for currency_code in budget_amount.

## Version 1.0.0-beta02, released 2020-11-17

- [Commit d3c8166](https://github.com/googleapis/google-cloud-dotnet/commit/d3c8166): docs: Reworded comments for the new credit types filter
- [Commit 80bc6ca](https://github.com/googleapis/google-cloud-dotnet/commit/80bc6ca): feat: Add support for credit type filter field.
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 3f2b80b](https://github.com/googleapis/google-cloud-dotnet/commit/3f2b80b):
  - feat: Added support for field to disable default budget alerts to IAM recipients
  - fix: Pub/Sub fields in AllUpdatesRule are now optional.
  - fix: Added cloud-billing OAuth scope. ([issue 5316](https://github.com/googleapis/google-cloud-dotnet/issues/5316))

## Version 1.0.0-beta01, released 2020-07-16

Initial beta release.


