# Version history

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.1.0, released 2023-01-16

### New features

- Add AllowedDomainSettings to the UpdateIapSettingsRequest ([commit 5b5c678](https://github.com/googleapis/google-cloud-dotnet/commit/5b5c678d67d38c53653a33e981a7f438f1278aa3))
- Add AttributePropagationSettings to the UpdateIapSettingsRequest ([commit 5b5c678](https://github.com/googleapis/google-cloud-dotnet/commit/5b5c678d67d38c53653a33e981a7f438f1278aa3))
- Add remediation_token_generation_enabled to the CsmSettings ([commit 5b5c678](https://github.com/googleapis/google-cloud-dotnet/commit/5b5c678d67d38c53653a33e981a7f438f1278aa3))

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


## Version 1.2.0, released 2022-05-24

### New features

- Add the TunnelDestGroup-related methods and types ([commit 307ef07](https://github.com/googleapis/google-cloud-dotnet/commit/307ef071ed89aac467dbe3aaf1142e953237dec0))
- Add ReauthSettings to the UpdateIapSettingsRequest ([commit 307ef07](https://github.com/googleapis/google-cloud-dotnet/commit/307ef071ed89aac467dbe3aaf1142e953237dec0))

## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-07-19

No API surface changes; just promotion to GA.

## Version 1.0.0-beta01, released 2021-06-29

Initial release.
