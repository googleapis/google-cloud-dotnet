# Version history

## Version 2.10.0, released 2025-03-24

### New features

- Add Network Connectivity Center APIs for PSC service automation ([commit 54430f6](https://github.com/googleapis/google-cloud-dotnet/commit/54430f658a32f62adc8cc08135dbc76f5d5d67d1))

### Documentation improvements

- Update some documentation. ([commit 54430f6](https://github.com/googleapis/google-cloud-dotnet/commit/54430f658a32f62adc8cc08135dbc76f5d5d67d1))

## Version 2.9.0, released 2024-12-06

### New features

- Add Network Connectivity Center APIs for PSC connection propagation through NCC ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Add Network Connectivity Center APIs for star topology ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Add Network Connectivity Center APIs for producer VPC spokes ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Add Network Connectivity Center APIs for dynamic route exchange ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Add Network Connectivity Center APIs for include export filters ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Add Network Connectivity Center APIs for include import ranges on hybrid spokes ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))

### Documentation improvements

- Update comment for `ListRoutes` method in service `HubService` to clarify that it lists routes in a route table ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Update comment for `ListRouteTables` method in service `HubService` to clarify that it lists route tables in a hub ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))
- Update comment for field `location` in message `.google.cloud.networkconnectivity.v1.Route` to clarify that it's the origin location ([commit 8c58bae](https://github.com/googleapis/google-cloud-dotnet/commit/8c58bae15c531aee2eca291d27e713d0dd92c58c))

## Version 2.8.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.7.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.6.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.5.0, released 2023-10-02

### New features

- Add Network Connectivity Center APIs related to VPC spokes ([commit f99d9ad](https://github.com/googleapis/google-cloud-dotnet/commit/f99d9ad52e49ae453e8b0007d6b2a2f6f6b85b31))

## Version 2.4.0, released 2023-09-18

### New features

- Add PolicyBasedRouting APIs ([commit 7d8d2b0](https://github.com/googleapis/google-cloud-dotnet/commit/7d8d2b0f58d91865588fd067a14e558e4db57b32))

## Version 2.3.0, released 2023-02-08

### Bug fixes

- **BREAKING CHANGE** Remove HTTP bindings for serviceConnectionMaps, serviceConnectionPolicies, serviceClasses ([commit 42415ac](https://github.com/googleapis/google-cloud-dotnet/commit/42415ac34613365778af5f8ec2cd68208e6b171f))
- **BREAKING CHANGE** Remove policy based routing API ([commit 7ed1508](https://github.com/googleapis/google-cloud-dotnet/commit/7ed15089ab0972c8b267f3249df1d0502ecdb335))

Note that these features would not have worked for customers anyway
(as they were behind an allow-list), so we are not increasing the
major version.

### New features

- Update Hub API ([commit 49cf881](https://github.com/googleapis/google-cloud-dotnet/commit/49cf881c481b0519656aaae9f9d85016d61d30bb))

## Version 2.2.0, released 2023-01-25

BREAKING CHANGE: This release removes some API aspects that were
accidentally included earlier, but which were access-checked
server-side. These RPCs would never have worked for customers, and
the package has low usage, so we're performing a *minor* version
bump on this occasion.
## Version 2.1.0, released 2022-11-02

### New features

- Add policy based routing ([commit 518e25b](https://github.com/googleapis/google-cloud-dotnet/commit/518e25be69cc8df4c04b5de0aca043818d50c795))

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
