# Version history

## Version 1.3.0, released 2025-05-06

### New features

- Add Anywhere cache control APIs

### Documentation improvements

- Added comments for Anywhere cache messages

## Version 1.2.0, released 2025-03-17

No API surface changes; no dependency updates. This is a no-op release.

## Version 1.1.0, released 2024-07-22

### Documentation improvements

- Remove allowlist note from Folders RPCs ([commit a2afefb](https://github.com/googleapis/google-cloud-dotnet/commit/a2afefb2bb16c0b0d5382cd6e2eae4ff81867ee7))
## Version 1.0.1, released 2024-06-20

No API surface changes; this release is purely to publish
documentation which did not happen in the 1.0.0 release.

## Version 1.0.0, released 2024-06-18

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta04, released 2024-05-08

### Bug fixes

- **BREAKING CHANGE** An existing resource pattern value `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder=**}` to resource definition `storage.googleapis.com/ManagedFolder` is removed ([commit 160d32c](https://github.com/googleapis/google-cloud-dotnet/commit/160d32cd7ff78ae2aeeb9aa6383c8212b27d3b67))

### New features

- A new resource pattern value `projects/{project}/buckets/{bucket}/managedFolders/{managed_folder=**}` added to the resource definition `storage.googleapis.com/ManagedFolder` ([commit 160d32c](https://github.com/googleapis/google-cloud-dotnet/commit/160d32cd7ff78ae2aeeb9aa6383c8212b27d3b67))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta03, released 2024-04-19

### New features

- Make Managed Folders operations public ([commit f904f90](https://github.com/googleapis/google-cloud-dotnet/commit/f904f9043d4f8be15e2cfa0fc14e87c182b32b70))

### Documentation improvements

- Update storage control documentation and add PHP for publishing ([commit 412992b](https://github.com/googleapis/google-cloud-dotnet/commit/412992b9d928fa7b111ca7018bf0c3448d6f0809))

## Version 1.0.0-beta02, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta01, released 2024-03-18

Initial release.
