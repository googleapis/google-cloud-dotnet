# Version history

## Version 2.4.0, released 2021-05-05

- [Commit 6f8b4e0](https://github.com/googleapis/google-cloud-dotnet/commit/6f8b4e0): Use CopySettingsForEmulator in FirestoreDbBuilder

## Version 2.3.1, released 2021-04-06

- [Commit 62182ca](https://github.com/googleapis/google-cloud-dotnet/commit/62182ca): fix: Propagate properties in FirestoreDbBuilder when using the emulator. Fixes [issue 6313](https://github.com/googleapis/google-cloud-dotnet/issues/6313)

(No API surface change, as expected in a patch release.)

## Version 2.3.0, released 2020-11-18

No API surface change - just dependencies, and a GA release of the new serialization attribute from 2.3.0-beta01.

## Version 2.3.0-beta01, released 2020-10-29

- [Commit 126529d](https://github.com/googleapis/google-cloud-dotnet/commit/126529d): Mechanism for passing server-provided fields to custom type converters. Fixes [issue 5470](https://github.com/googleapis/google-cloud-dotnet/issues/5470).

## Version 2.2.0, released 2020-10-05

- [Commit 8698c6e](https://github.com/googleapis/google-cloud-dotnet/commit/8698c6e): docs: Improve "where in/not-in" documentation slightly
- [Commit e35d18b](https://github.com/googleapis/google-cloud-dotnet/commit/e35d18b): feat: Add "where not in" Firestore query support
- [Commit 1f3168e](https://github.com/googleapis/google-cloud-dotnet/commit/1f3168e): feat: Add "where not equal" support for Firestore
- [Commit ef55349](https://github.com/googleapis/google-cloud-dotnet/commit/ef55349): chore: Simplify WriteBatch implementation in line with internal guidance
- [Commit 310a1cb](https://github.com/googleapis/google-cloud-dotnet/commit/310a1cb): chore: Refactor WriteBatch now that every update is just a single Write
- [Commit 94375e9](https://github.com/googleapis/google-cloud-dotnet/commit/94375e9): chore: Fix conformance tests, by using update transforms
- [Commit eddc395](https://github.com/googleapis/google-cloud-dotnet/commit/eddc395): fix: Fix WhereIn filters being used in implicit orderings
- [Commit bb09597](https://github.com/googleapis/google-cloud-dotnet/commit/bb09597): feat: Allow general iterable objects to be serialized (but not deserialized) in Firestore

## Version 2.1.0, released 2020-06-02

- [Commit 48cef0e](https://github.com/googleapis/google-cloud-dotnet/commit/48cef0e): Allow nested arrays to be constructed client-side, relying on server-side validation
- [Commit b1e6e8b](https://github.com/googleapis/google-cloud-dotnet/commit/b1e6e8b): Perform some more client-side validation for WhereIn queries to avoid an unfortunate type safety mistake
- [Commit 2517e6e](https://github.com/googleapis/google-cloud-dotnet/commit/2517e6e): Convert strings into references for DocumentId queries. Fixes [issue 4981](https://github.com/googleapis/google-cloud-dotnet/issues/4981)

Note that although this release doesn't involve any API surface
changes, the features here (particularly converting strings into
references for DocumentId queries) feel significant enough to
warrant a minor version instead of a patch release. (They are
effectively features rather than bug fixes.)

## Version 2.0.0, released 2020-05-12

- [Commit 2f25d1c](https://github.com/googleapis/google-cloud-dotnet/commit/2f25d1c): Implement Query.LimitToLast
- [Commit 6d8e0f1](https://github.com/googleapis/google-cloud-dotnet/commit/6d8e0f1): Use List<T> as a default deserialization type for sequences

This is the first GA release targeting GAX v3.

## Version 2.0.0-beta02, released 2020-03-18

No API surface changes in Google.Cloud.Firestore compared with
2.0.0-beta01, just dependency and implementation changes.

The underlying Google.Cloud.Firestore.V1 protos have a new
UpdateTransforms property, but that's not used yet.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Most of these changes do not affect Google.Cloud.Firestore, although
they do affect the Google.Cloud.Firestore.V1 and
Google.Cloud.Firestore.Admin.V1 packages.

Two breaking changes which definitely affect Google.Cloud.Firestore:

- The `EmulatorDetection` enum is now in the `Google.Api.Gax` namespace,
  and the previous `ProductionOrEmulator` value within it has been
  renamed to `EmulatorOrProduction`.
- Service endpoints are now represented by strings rather than the
  (now-removed) `ServiceEndpoint` class

## Version 1.1.0, released 2019-12-03

- Support for In and ArrayContainsAny queries ([issue 3783](https://github.com/googleapis/google-cloud-dotnet/issues/3783))
- Firestore emulator support ([issue 3397](https://github.com/googleapis/google-cloud-dotnet/issues/3397))
- Conversion support for named value tuples ([issue 2787](https://github.com/googleapis/google-cloud-dotnet/issues/2787))
- FirestoreDbBuilder for simplified configuration beyond defaults
- Per-FirestoreDb converter customization ([issue 3255](https://github.com/googleapis/google-cloud-dotnet/issues/3255))
- Public FirestoreEnumNameConverter type ([issue 2842](https://github.com/googleapis/google-cloud-dotnet/issues/2842))
- Document snapshot timestamp propagation attributes ([issue 2830](https://github.com/googleapis/google-cloud-dotnet/issues/2830))

## Version 1.0.0, released 2019-07-16

Initial GA release.
