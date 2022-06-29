# Version history

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


## Version 1.2.0, released 2022-02-14

### New features

- Add LocationMetadata message ([commit b6edefb](https://github.com/googleapis/google-cloud-dotnet/commit/b6edefb793651dc0f1a07349852f381e56139b9a))
- Add RoutingVPC.required_for_new_site_to_site_data_transfer_spokes field ([commit b6edefb](https://github.com/googleapis/google-cloud-dotnet/commit/b6edefb793651dc0f1a07349852f381e56139b9a))

### Documentation improvements

- Update comments to reflect that spokes can now be created with data transfer disabled ([commit b6edefb](https://github.com/googleapis/google-cloud-dotnet/commit/b6edefb793651dc0f1a07349852f381e56139b9a))

## Version 1.1.0, released 2021-12-07

- [Commit 10e499d](https://github.com/googleapis/google-cloud-dotnet/commit/10e499d): fix!: Mark a couple networkconnectivity API fields as required, to match implemented behavior

## Version 1.0.0, released 2021-11-10

First GA release.

No API surface changes; just dependency updates.

## Version 1.0.0-beta02, released 2021-09-23

- [Commit c64998e](https://github.com/googleapis/google-cloud-dotnet/commit/c64998e):
  - fix!: Remove ActivateSpoke and DeactivateSpoke methods
  - BREAKING_CHANGE: ActivateSpoke and DeactivateSpoke were included in a previous change by mistake
  - feat: Add hub.routing_vpcs field
  - docs: Specify that site_to_site_data_transfer field must be set to true
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta01, released 2021-08-12

Initial release.
