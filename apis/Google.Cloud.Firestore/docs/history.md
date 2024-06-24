# Version history

## Version 3.8.0, released 2024-06-24

### New features

- Add dependency injection support for FirestoreDb ([commit 1a7e44b](https://github.com/googleapis/google-cloud-dotnet/commit/1a7e44bc3c0f0638977191bb48a4e993a75ece03))

### Documentation improvements

- Fix documentation for FirestoreDocumentUpdateTimestampAttribute ([commit 836de44](https://github.com/googleapis/google-cloud-dotnet/commit/836de44bedbcd0fc3b652b293b6aa1ab48e07e39))

## Version 3.7.0, released 2024-05-03

### Bug fixes

- Retry more exceptions during transactions ([commit 027dd8b](https://github.com/googleapis/google-cloud-dotnet/commit/027dd8bc1fc2f638aa7305f996dc4a49ecc1ee41))

## Version 3.6.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Throw if an must-exist precondition is explicitly set to false for update. ([commit 5cfc625](https://github.com/googleapis/google-cloud-dotnet/commit/5cfc625fe2edfd7a7c565bd020ccfc9332b41be6))

## Version 3.5.1, released 2024-02-14

### Bug fixes

- Restore the use of "legacy" routing headers until the newer header is fully supported in the Firestore emulator. ([commit 6a5e369](https://github.com/googleapis/google-cloud-dotnet/commit/6a5e3696c4101fd1c33b5febdf4d75602415889c))

## Version 3.5.0, released 2024-01-30

### Bug fixes

- Use FirestoreSettings.BatchGetDocuments for batch timing ([commit ad580e0](https://github.com/googleapis/google-cloud-dotnet/commit/ad580e003e4fab2864f1fd916e5bd5da971e2201))
- Allow an explicit MustExist precondition for update. Fixes [issue 11361](https://github.com/googleapis/google-cloud-dotnet/issues/11361) ([commit f9f39a5](https://github.com/googleapis/google-cloud-dotnet/commit/f9f39a522e38969f20f32f3bde840148067bb090))

### New features

- Multiple database support promoted to GA
- Add configurable retry timing for RunTransactionAsync ([commit 4b1acf8](https://github.com/googleapis/google-cloud-dotnet/commit/4b1acf8f9f0eddcaa7e19a7531a5511b2f0c1e05))
- All BatchGetDocuments RPCs to have customized retry settiings (per-FirestoreDb) ([commit ad580e0](https://github.com/googleapis/google-cloud-dotnet/commit/ad580e003e4fab2864f1fd916e5bd5da971e2201))

## Version 3.5.0-beta01, released 2023-11-29

Note: this is a beta release as multiple database support in
Firestore is still in preview. We don't *expect* the API surface to
change between now and the final release, but we don't guarantee that.

### New features

- Expose multiple database support in FirestoreDb/FirestoreDbBuilder ([commit 4dd0318](https://github.com/googleapis/google-cloud-dotnet/commit/4dd0318f34b8763fb2dec2922ed8bc30213b7077))

## Version 3.4.0, released 2023-10-04

### Bug fixes

- Dispose of the gRPC call in the WatchStream even if non-RpcExceptions are thrown ([commit f89ba63](https://github.com/googleapis/google-cloud-dotnet/commit/f89ba6306059149d4d7a6ee4458d9e88c4c99761))
- Dispose of gRPC streaming calls appropriately ([commit 541d439](https://github.com/googleapis/google-cloud-dotnet/commit/541d43955ebde4b536d70cfe70d802ddb6703e6a))
- Simple disposals within Firestore ([commit cdc22d2](https://github.com/googleapis/google-cloud-dotnet/commit/cdc22d28a2605a43f2efec54c947f47c7e4adc24))

### New features

- Add sum and average aggregates ([commit 9a8bfd5](https://github.com/googleapis/google-cloud-dotnet/commit/9a8bfd50c29e8bd133e1f92cb62c9b5bb05ef436))

### Documentation improvements

- Change Google Cloud Platform to Google Cloud in handwritten code ([commit cef5f43](https://github.com/googleapis/google-cloud-dotnet/commit/cef5f43dd2dc2817d091a398ac4620a357d535c5))

## Version 3.3.0, released 2023-05-03

No API surface changes; just dependency updates.

## Version 3.2.0, released 2023-03-22

### New features

- Add support for OR Queries Firestore ([commit bf224d6](https://github.com/googleapis/google-cloud-dotnet/commit/bf224d65227abab553fbe1be59772cd1b42729bd))
- Add support for multiple databases ([commit 3a40583](https://github.com/googleapis/google-cloud-dotnet/commit/3a40583c8746e8c3b471f8be6ae21daa28b8acdf))

## Version 3.1.0, released 2023-02-08

### New features

- Add support for count(*) aggregation query firestore ([commit 1df2774](https://github.com/googleapis/google-cloud-dotnet/commit/1df2774c6aa684012c9b53af287d6510f89bb968))

## Version 3.0.0, released 2022-06-09

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

## Version 2.5.0, released 2022-01-18

No API surface changes; just dependency updates.

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
