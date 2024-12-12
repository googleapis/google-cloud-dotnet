# Version history

## Version 1.0.0-beta10, released 2024-12-12

### Bug fixes

- **BREAKING CHANGE** Changed field behavior for an existing field `update_mask` and `emoji` ([commit ec46bf2](https://github.com/googleapis/google-cloud-dotnet/commit/ec46bf2c127a0367e182b8e90874911d2a3f5635))

### New features

- Add missing field annotations in space.proto, message.proto, reaction.proto, space_event.proto, membership.proto, attachment.proto ([commit ec46bf2](https://github.com/googleapis/google-cloud-dotnet/commit/ec46bf2c127a0367e182b8e90874911d2a3f5635))

### Documentation improvements

- Update field annotations in space.proto, message.proto, reaction.proto, space_event.proto, membership.proto, attachment.proto ([commit ec46bf2](https://github.com/googleapis/google-cloud-dotnet/commit/ec46bf2c127a0367e182b8e90874911d2a3f5635))

## Version 1.0.0-beta09, released 2024-12-06

### New features

- Chat Apps can now retrieve the import mode expire time information to know when to complete the import mode properly ([commit 84cf136](https://github.com/googleapis/google-cloud-dotnet/commit/84cf1362823ea53928baf9fef663c439b07b93e9))

### Documentation improvements

- Update reference documentation to include import_mode_expire_time field ([commit 84cf136](https://github.com/googleapis/google-cloud-dotnet/commit/84cf1362823ea53928baf9fef663c439b07b93e9))

## Version 1.0.0-beta08, released 2024-10-07

### New features

- Add doc for permission settings & announcement space support ([commit b8b7166](https://github.com/googleapis/google-cloud-dotnet/commit/b8b71669b657a6e3ac77fa31d0daa1568bd85d9c))
- Add doc for import mode external users support ([commit b8b7166](https://github.com/googleapis/google-cloud-dotnet/commit/b8b71669b657a6e3ac77fa31d0daa1568bd85d9c))

### Documentation improvements

- Messages API dev docs improvement ([commit b8b7166](https://github.com/googleapis/google-cloud-dotnet/commit/b8b71669b657a6e3ac77fa31d0daa1568bd85d9c))
- Memberships API dev docs improvement ([commit b8b7166](https://github.com/googleapis/google-cloud-dotnet/commit/b8b71669b657a6e3ac77fa31d0daa1568bd85d9c))
- Discoverable space docs improvement ([commit b8b7166](https://github.com/googleapis/google-cloud-dotnet/commit/b8b71669b657a6e3ac77fa31d0daa1568bd85d9c))

## Version 1.0.0-beta07, released 2024-09-16

### New features

- If you're a domain administrator or a delegated administrator, you can now include the `useAdminAccess` parameter when you call the Chat API with your administrator privileges with the following methods to manage Chat spaces and memberships in your Workspace organization: ([commit a6692fa](https://github.com/googleapis/google-cloud-dotnet/commit/a6692fa38db1a6e484574a834a8abc797fdc12e8))

### Documentation improvements

- A comment for field `filter` in message `.google.chat.v1.ListMembershipsRequest` is updated to support `!=` operator ([commit a6692fa](https://github.com/googleapis/google-cloud-dotnet/commit/a6692fa38db1a6e484574a834a8abc797fdc12e8))

## Version 1.0.0-beta06, released 2024-09-09

### New features

- Add CHAT_SPACE link type support for GA launch ([commit e661468](https://github.com/googleapis/google-cloud-dotnet/commit/e661468ce2b7ec57d3cd786a88ead2eac14c792e))

## Version 1.0.0-beta05, released 2024-07-22

### New features

- Add GetSpaceEvent and ListSpaceEvents APIs ([commit 37667db](https://github.com/googleapis/google-cloud-dotnet/commit/37667db3e7134f0078b46e111d7e77b2f30ad9ed))

## Version 1.0.0-beta04, released 2024-07-08

### New features

- Add doc for Discoverable Space support for GA launch ([commit 53f49ef](https://github.com/googleapis/google-cloud-dotnet/commit/53f49ef7973638ab3f0674d798b5954d2d4cdbec))

### Documentation improvements

- Update resource naming formats ([commit 53f49ef](https://github.com/googleapis/google-cloud-dotnet/commit/53f49ef7973638ab3f0674d798b5954d2d4cdbec))
- Update doc for `SetUpSpace` in service `ChatService` to support group members ([commit 7adcc7f](https://github.com/googleapis/google-cloud-dotnet/commit/7adcc7f70326dfb264e842517a58dc55d93aaf28))
- Update doc for `CreateMembership` in service `ChatService` to support group members ([commit 7adcc7f](https://github.com/googleapis/google-cloud-dotnet/commit/7adcc7f70326dfb264e842517a58dc55d93aaf28))
- Update doc for field `group_member` in message `google.chat.v1.Membership` ([commit 7adcc7f](https://github.com/googleapis/google-cloud-dotnet/commit/7adcc7f70326dfb264e842517a58dc55d93aaf28))
- Update Chat API comments ([commit 7e918d2](https://github.com/googleapis/google-cloud-dotnet/commit/7e918d2509424db1abedac60741c2d9237587343))

## Version 1.0.0-beta03, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta02, released 2024-04-22

### New features

- Add Chat read state APIs ([commit 94ab34d](https://github.com/googleapis/google-cloud-dotnet/commit/94ab34d8db819b9c954e5c1948a7e3a280883afb))

## Version 1.0.0-beta01, released 2024-04-18

Initial release.
