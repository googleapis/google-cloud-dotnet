# Version history

## Version 2.1.0, released 2022-07-27

### New features

- Add service_account_id output field to CloudSQL properties ([commit c72ac43](https://github.com/googleapis/google-cloud-dotnet/commit/c72ac437a7f24199045e03016a384f250ac1380c))

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


## Version 1.6.0, released 2022-04-26

### New features

- Add AuditConfig and an update FieldMask ([commit 7289e58](https://github.com/googleapis/google-cloud-dotnet/commit/7289e58eab6e1ae820d27539043e130b774fbc4d))
## Version 1.5.0, released 2022-03-14

### New features

- Add Cloud_Resource Connection Support ([commit 0cf7fea](https://github.com/googleapis/google-cloud-dotnet/commit/0cf7feafbf919d447fee0b42441f0985ba86c652))

## Version 1.4.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.3.0, released 2021-08-10

- [Commit e425177](https://github.com/googleapis/google-cloud-dotnet/commit/e425177): feat: add cloud spanner connection support

## Version 1.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 1.1.0, released 2020-10-07

- [Commit 34b71e8](https://github.com/googleapis/google-cloud-dotnet/commit/34b71e8): feat: Add AWS connection support
- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation

## Version 1.0.0, released 2020-07-06

- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Regenerate all APIs with generator changes (enabled timeouts for non-retried RPCs)

## Version 1.0.0-beta02, released 2020-06-11

- [Commit 94118c8](https://github.com/googleapis/google-cloud-dotnet/commit/94118c8): fix: update method_signature annotation for list RPC

## Version 1.0.0-beta01, released 2020-06-09

Initial beta release.


