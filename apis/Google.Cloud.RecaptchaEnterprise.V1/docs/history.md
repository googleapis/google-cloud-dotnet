# Version history

## Version 2.2.0, released 2022-10-17

### New features

- Add RetrieveLegacySecretKey method ([commit e6d4fea](https://github.com/googleapis/google-cloud-dotnet/commit/e6d4feaf59fde91f0270b42d0dad595a235d1f46))
- Add annotation reasons REFUND, REFUND_FRAUD, TRANSACTION_ACCEPTED, TRANSACTION_DECLINED and SOCIAL_SPAM ([commit e6d4fea](https://github.com/googleapis/google-cloud-dotnet/commit/e6d4feaf59fde91f0270b42d0dad595a235d1f46))

## Version 2.1.0, released 2022-07-11

### Bug fixes

- **BREAKING CHANGE** Set the right field number for reCAPTCHA private password leak ([commit 887e7fe](https://github.com/googleapis/google-cloud-dotnet/commit/887e7fe16c53f0194dc7618e61a9b4ec5a8fb0c7))

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


### API-specific breaking change

- Rename parent to project in SearchRelatedAccountGroupMembershipsRequest ([commit 4ff737b](https://github.com/googleapis/google-cloud-dotnet/commit/4ff737b1dbfb31525c0632419cd3799f4fa1bd1c))

### New features

- Add support for Password Check through the private_password_leak_verification field in the reCAPTCHA Assessment ([commit eee8397](https://github.com/googleapis/google-cloud-dotnet/commit/eee8397500f513afcdd3565b1ed8d4bfe8301554))
- Introduced WafSettings ([commit 4ff737b](https://github.com/googleapis/google-cloud-dotnet/commit/4ff737b1dbfb31525c0632419cd3799f4fa1bd1c))

## Version 1.6.0, released 2021-12-07

- [Commit 308c733](https://github.com/googleapis/google-cloud-dotnet/commit/308c733): feat: add new reCAPTCHA Enterprise fraud annotations

## Version 1.5.0, released 2021-11-10

- [Commit fcce878](https://github.com/googleapis/google-cloud-dotnet/commit/fcce878):
  - feat: add reCAPTCHA Enterprise account defender API methods
  - This adds the following API methods to support the Preview release of reCAPTCHA Enterprise account defender: ListRelatedAccountGroups, ListRelatedAccountGroupMemberships, and SearchRelatedAccountGroupMemberships. Additionally it modifies the existing createAssessment API method to add a new hashed_account_id parameter along with AccountDefenderAssessment return value.

## Version 1.4.0, released 2021-09-24

- [Commit 20d6309](https://github.com/googleapis/google-cloud-dotnet/commit/20d6309): feat: add GetMetrics and MigrateKey methods to reCAPTCHA enterprise API

## Version 1.3.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.1.0, released 2020-10-23

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 1.0.0, released 2020-04-08

No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-03-23

Initial beta release.


