# Version history

## Version 1.0.0-beta09, released 2026-09-11

### New features

- Add Member resource and Member management RPCs (CreateMember, GetMember, ListMembers, DeleteMember, UpdateMember, BatchUpdateMembers) to SpacesService in Meet v2 GA API
- Add SmartNote resource and SmartNotes RPCs (GetSmartNote, ListSmartNotes) to ConferenceRecordsService in Meet v2 GA and v2beta API
- Add UpdateMember and BatchUpdateMembers RPCs to SpacesService in Meet v2beta API
- Add ArtifactConfig, Moderation, ModerationRestrictions, and AttendanceReportGenerationType to SpaceConfig in Meet v2 GA API
- Add PhoneAccess and GatewaySipAccess to Space in Meet v2 and v2beta API
- Add media_api_consenter_present to ActiveConference in Meet v2beta API
- Add ConnectionConfig to ConnectActiveConferenceRequest in Meet v2beta API

### Documentation improvements

- A comment for field `name` in message `.google.apps.meet.v2beta.Space` is changed
- A comment for message `SpaceConfig` is changed
- A comment for field `moderation` in message `.google.apps.meet.v2beta.SpaceConfig` is changed
- A comment for field `moderation_restrictions` in message `.google.apps.meet.v2beta.SpaceConfig` is changed
- A comment for field `attendance_report_generation_type` in message `.google.apps.meet.v2beta.SpaceConfig` is changed
- A comment for field `artifact_config` in message `.google.apps.meet.v2beta.SpaceConfig` is changed
- A comment for enum value `ROLE_UNSPECIFIED` in enum `Role` is changed
- A comment for method `GetSpace` in service `SpacesService` is changed
- A comment for method `UpdateSpace` in service `SpacesService` is changed
- A comment for method `ConnectActiveConference` in service `SpacesService` is changed
- A comment for method `EndActiveConference` in service `SpacesService` is changed
- A comment for method `CreateMember` in service `SpacesService` is changed
- A comment for method `GetMember` in service `SpacesService` is changed
- A comment for method `ListMembers` in service `SpacesService` is changed
- A comment for method `DeleteMember` in service `SpacesService` is changed
- A comment for method `GetTranscriptEntry` in service `ConferenceRecordsService` is changed
- A comment for method `ListTranscriptEntries` in service `ConferenceRecordsService` is changed
- A comment for field `name` in message `.google.apps.meet.v2beta.GetSpaceRequest` is changed
- A comment for message `ConnectActiveConferenceResponse` is changed
- A comment for field `name` in message `.google.apps.meet.v2beta.EndActiveConferenceRequest` is changed
- A comment for field `page_size` in message `.google.apps.meet.v2beta.ListMembersRequest` is changed

## Version 1.0.0-beta08, released 2025-11-03

### New features

- Update dependencies

## Version 1.0.0-beta07, released 2025-03-03

### New features

- Add `ConnectActiveConference` method to `SpacesService` ([commit 3df6acc](https://github.com/googleapis/google-cloud-dotnet/commit/3df6accf01c07cb6414ec4c2d6a882f4f78f24af))

## Version 1.0.0-beta06, released 2025-02-03

### New features

- Add methods for [configuring meeting spaces and members](https://developers.google.com/meet/api/guides/beta/configuration-beta) ([commit df0476e](https://github.com/googleapis/google-cloud-dotnet/commit/df0476e78bb12893756125115567ddfc908734a7))
- Add new OAuth scope `https://www.googleapis.com/auth/meetings.space.settings` to service `SpacesService` ([commit df0476e](https://github.com/googleapis/google-cloud-dotnet/commit/df0476e78bb12893756125115567ddfc908734a7))

### Documentation improvements

- Improve docs for `GetSpaceRequest`, `EndActiveConferenceRequest`, `ListConferenceRecordsRequest` ([commit df0476e](https://github.com/googleapis/google-cloud-dotnet/commit/df0476e78bb12893756125115567ddfc908734a7))
- Remove *Developer Preview* label from methods that are now generally available ([commit df0476e](https://github.com/googleapis/google-cloud-dotnet/commit/df0476e78bb12893756125115567ddfc908734a7))

## Version 1.0.0-beta05, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta03, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta02, released 2024-01-08

### New features

- Added start and end time fields to Recording and Transcript resources ([commit b955ea1](https://github.com/googleapis/google-cloud-dotnet/commit/b955ea18eb812e0100803a82808e93ddf2378c92))

## Version 1.0.0-beta01, released 2023-12-08

Initial release.
