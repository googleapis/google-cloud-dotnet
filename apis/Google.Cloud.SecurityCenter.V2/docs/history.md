# Version history

## Version 1.2.0, released 2025-07-07

### New features

- Add AffectedResources proto
- Add AiModel proto
- Add ChokePoint proto
- Add IpRules proto
- Add Job proto
- Add Network proto

## Version 1.1.0, released 2025-02-18

### New features

- Added more information about DDoS attack in cloud armor proto ([commit 960927e](https://github.com/googleapis/google-cloud-dotnet/commit/960927e2a7049e69035e761de9246b76de2bd8ac))
- Added data access event fields to finding proto ([commit 960927e](https://github.com/googleapis/google-cloud-dotnet/commit/960927e2a7049e69035e761de9246b76de2bd8ac))

### Documentation improvements

- Clarified comments for tag_values field in resource_value_config to make it clear that field represents tag value ids, not tag values ([commit 960927e](https://github.com/googleapis/google-cloud-dotnet/commit/960927e2a7049e69035e761de9246b76de2bd8ac))

## Version 1.0.0, released 2024-12-05

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta05, released 2024-08-05

### New features

- Enable Dynamic Mute ([commit f997eb9](https://github.com/googleapis/google-cloud-dotnet/commit/f997eb9541b23d209614bb46112641dfd38c6ea6))
- New values `EXPLOITATION_FOR_PRIVILEGE_ESCALATION` corresponding to T1068 and `INDICATOR_REMOVAL_FILE_DELETION` corresponding to T1070.004 are added to enum `Technique` ([commit f997eb9](https://github.com/googleapis/google-cloud-dotnet/commit/f997eb9541b23d209614bb46112641dfd38c6ea6))

### Documentation improvements

- T1068 is added for value `EXPLOITATION_FOR_PRIVILEGE_ESCALATION` and T1070.004 is added for value `INDICATOR_REMOVAL_FILE_DELETION` for enum `Technique ([commit f997eb9](https://github.com/googleapis/google-cloud-dotnet/commit/f997eb9541b23d209614bb46112641dfd38c6ea6))

## Version 1.0.0-beta04, released 2024-07-08

### New features

- Added cloud provider field to list findings response ([commit 7c4de98](https://github.com/googleapis/google-cloud-dotnet/commit/7c4de983db64fe1cf73a409656566a6c68714bb2))
- Added http configuration rule to ResourceValueConfig and ValuedResource API methods ([commit 7c4de98](https://github.com/googleapis/google-cloud-dotnet/commit/7c4de983db64fe1cf73a409656566a6c68714bb2))
- Added toxic combination field to finding ([commit 7c4de98](https://github.com/googleapis/google-cloud-dotnet/commit/7c4de983db64fe1cf73a409656566a6c68714bb2))
- Add toxic_combination and group_memberships fields to finding ([commit fb4213a](https://github.com/googleapis/google-cloud-dotnet/commit/fb4213aecfa69d90b36d862189785131abe8d1c2))

### Documentation improvements

- Updated comments for ResourceValueConfig ([commit 7c4de98](https://github.com/googleapis/google-cloud-dotnet/commit/7c4de983db64fe1cf73a409656566a6c68714bb2))

## Version 1.0.0-beta03, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Fixed backtick and double quotes mismatch in security_marks.proto ([commit 7a4b88a](https://github.com/googleapis/google-cloud-dotnet/commit/7a4b88a644382a0dc6d39033de78e49ad1cb0362))

## Version 1.0.0-beta02, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta01, released 2024-03-08

Initial release.
