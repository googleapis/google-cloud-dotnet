# Version history

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
