# Version history

## Version 3.4.0, released 2025-11-06

### New features

- Update dependencies

## Version 3.3.0, released 2024-06-04

### New features

- Add apis for Create, Read, Update, Delete for VODConfigs ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))
- Allowed usage for VODConfigs in VODSession ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))
- Added token config for MediaCdnKey ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))
- Added targetting parameter support to Livesession ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))
- Added adtracking to Livesession ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))
- Added fetchoptions with custom headers for Live and VODConfigs ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))

### Documentation improvements

- Added apis for Create, Read, Update, Delete For VODConfigs. Added vodConfig usage in VODSession. Added TokenConfig for MediaCdnKey. Added targeting_parameter and ad_tracking for Livesession. Added FetchOptions for Live and VOD configs. ([commit cd0f56e](https://github.com/googleapis/google-cloud-dotnet/commit/cd0f56e7b7677feff24624233ba04446ed60674c))

## Version 3.2.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.1.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.0.0, released 2024-03-12

No API surface changes; just promotion to GA.

## Version 3.0.0-beta03, released 2024-02-29

No API surface changes; just dependency updates.

## Version 3.0.0-beta02, released 2023-08-22

### Bug fixes

- **BREAKING CHANGE** Use correct child_type annotation ([commit 324d882](https://github.com/googleapis/google-cloud-dotnet/commit/324d882b5e6fbf7a193d5c953ba169b6e05afbcc))

## Version 3.0.0-beta01, released 2023-04-25

New major version to accommodate breaking changes. This is initially
released as a beta just in case any further breaking changes surface in
the near future, but a stable release is expected shortly.

### Bug fixes

- **BREAKING CHANGE** Roll back the changes that update of LRO metadata type to google.cloud.common.OperationMetadata ([commit 7d86a96](https://github.com/googleapis/google-cloud-dotnet/commit/7d86a961bff38233446be69ceba2f8966634e721))

### New features

- **BREAKING CHANGE** Introduce GAM settings for GAM related configs and support ListOperations ([commit 8f8a3e6](https://github.com/googleapis/google-cloud-dotnet/commit/8f8a3e6c07531ca3d947a1a47d0e1598b2e8226b))
- **BREAKING CHANGE** Remove default_ad_break_duration from LiveConfig ([commit 04da5ae](https://github.com/googleapis/google-cloud-dotnet/commit/04da5aee708a10f38ca26781bf92f66fdece8145))
- **BREAKING CHANGE** Update LRO metadata type to google.cloud.common.OperationMetadata ([commit f0fd7fc](https://github.com/googleapis/google-cloud-dotnet/commit/f0fd7fc2ed620ed39d14488062f851003da912b1))

## Version 2.0.0, released 2023-03-27

### New features

- **BREAKING CHANGE** LRO changes for CdnKey and Slate methods, VodSession changes for ad tracking, and LiveSession changes for live config ([commit 6c65d96](https://github.com/googleapis/google-cloud-dotnet/commit/6c65d964be25a0135294cc66acc5ec904ec782cf))

## Version 1.1.0, released 2022-11-02

### New features

- Add support for Media CDN ([commit b01726a](https://github.com/googleapis/google-cloud-dotnet/commit/b01726adc197f0b04aa9b2e24762b905732f3d1c))

## Version 1.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2022-07-22

Initial release.
