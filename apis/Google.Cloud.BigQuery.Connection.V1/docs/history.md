# Version history

## Version 2.10.0, released 2025-11-05

### New features

- Update dependencies

## Version 2.9.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.8.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.7.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.6.0, released 2023-07-13

### New features

- Add support for Salesforce connections, which are usable only by allowlisted partners ([commit 1a2b063](https://github.com/googleapis/google-cloud-dotnet/commit/1a2b06397170cbddadd29fa491656fe92f5b199b))
- Add cloud spanner connection properties - use_data_boost ([commit 1a2b063](https://github.com/googleapis/google-cloud-dotnet/commit/1a2b06397170cbddadd29fa491656fe92f5b199b))
- Add cloud spanner connection properties - max_parallelism ([commit 1a2b063](https://github.com/googleapis/google-cloud-dotnet/commit/1a2b06397170cbddadd29fa491656fe92f5b199b))

## Version 2.5.0, released 2023-03-20

### New features

- Add spark connection properties type ([commit e7eddf1](https://github.com/googleapis/google-cloud-dotnet/commit/e7eddf1aa7098fe62750671adef269cccb91265f))

## Version 2.4.0, released 2023-03-06

### New features

- Add cloud spanner connection properties - serverless analytics ([commit 3b22371](https://github.com/googleapis/google-cloud-dotnet/commit/3b2237128775b97a17af15651000139bedc94375))
- Add cloud spanner connection properties - database role ([commit 3b22371](https://github.com/googleapis/google-cloud-dotnet/commit/3b2237128775b97a17af15651000139bedc94375))

## Version 2.3.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.2.0, released 2022-08-04

### New features

- Add Azure Properties to Connection ([commit 0c0c650](https://github.com/googleapis/google-cloud-dotnet/commit/0c0c6508e17835aeb6a97ccda4c8827adcf71ce3))

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


