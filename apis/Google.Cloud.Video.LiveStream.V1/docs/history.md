# Version history

## Version 1.8.0, released 2024-07-22

### New features

- Added RetentionConfig for enabling retention of output media segments ([commit 3f438f2](https://github.com/googleapis/google-cloud-dotnet/commit/3f438f2fd6076c94464ac874e17f88e891887487))
- Added Clip resource for performing clip cutting jobs ([commit 3f438f2](https://github.com/googleapis/google-cloud-dotnet/commit/3f438f2fd6076c94464ac874e17f88e891887487))
- Added StaticOverlay for embedding images the whole duration of the live stream ([commit 3f438f2](https://github.com/googleapis/google-cloud-dotnet/commit/3f438f2fd6076c94464ac874e17f88e891887487))

### Documentation improvements

- Clarify the format of key/id fields ([commit 3f438f2](https://github.com/googleapis/google-cloud-dotnet/commit/3f438f2fd6076c94464ac874e17f88e891887487))

## Version 1.7.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.4.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 1.3.0, released 2023-08-04

### New features

- Added support for slate events which allow users to create and insert a slate into a live stream to replace the main live stream content ([commit 9efd50b](https://github.com/googleapis/google-cloud-dotnet/commit/9efd50b73fa6c514ce2b6a8d7567bc07584ed7ae))
- Added a new asset resource which can be used as the content of slate events ([commit 9efd50b](https://github.com/googleapis/google-cloud-dotnet/commit/9efd50b73fa6c514ce2b6a8d7567bc07584ed7ae))
- Added a new pool resource for protecting input endpoints within a VPC Service Controls perimeter ([commit 9efd50b](https://github.com/googleapis/google-cloud-dotnet/commit/9efd50b73fa6c514ce2b6a8d7567bc07584ed7ae))

## Version 1.2.0, released 2023-03-27

### New features

- Added TimecodeConfig for specifying the source of timecode used in media workflow synchronization ([commit f7c5a13](https://github.com/googleapis/google-cloud-dotnet/commit/f7c5a134ba3ed60c6fb67e001ce430bc95724815))
- Added Encryption for enabling output encryption with DRM systems ([commit f7c5a13](https://github.com/googleapis/google-cloud-dotnet/commit/f7c5a134ba3ed60c6fb67e001ce430bc95724815))
- Added InputConfig to allow enabling/disabling automatic failover ([commit f7c5a13](https://github.com/googleapis/google-cloud-dotnet/commit/f7c5a134ba3ed60c6fb67e001ce430bc95724815))
- Added new tasks to Event: inputSwitch, returnToProgram, mute, unmute ([commit f7c5a13](https://github.com/googleapis/google-cloud-dotnet/commit/f7c5a134ba3ed60c6fb67e001ce430bc95724815))
- Added support for audio normalization and audio gain ([commit f7c5a13](https://github.com/googleapis/google-cloud-dotnet/commit/f7c5a134ba3ed60c6fb67e001ce430bc95724815))

### Documentation improvements

- Clarify behavior when update_mask is omitted in PATCH requests ([commit f7c5a13](https://github.com/googleapis/google-cloud-dotnet/commit/f7c5a134ba3ed60c6fb67e001ce430bc95724815))

## Version 1.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

## Version 1.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2022-06-15

Initial release.
