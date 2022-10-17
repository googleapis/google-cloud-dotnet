# Version history

## Version 2.1.0, released 2022-10-17

### New features

- Add PolicyViolation to the AuditLog proto, this will only be present when access is denied due to Organization Policy. It describes why access is denied ([commit 4123c0e](https://github.com/googleapis/google-cloud-dotnet/commit/4123c0e7cf10ff042930277cfd9fd8a5496f61e4))
- Add FirstPartyAppMetadata to the BigQueryAuditMetadata proto, it contains metadata about requests originating from Google apps, such as Google Sheets ([commit 4123c0e](https://github.com/googleapis/google-cloud-dotnet/commit/4123c0e7cf10ff042930277cfd9fd8a5496f61e4))
- Added new events to BigQueryAuditMetadata such as UnlinkDataset and RowAccessPolicyCreation ([commit 4123c0e](https://github.com/googleapis/google-cloud-dotnet/commit/4123c0e7cf10ff042930277cfd9fd8a5496f61e4))

### Documentation improvements

- Updated multiple comments ([commit 4123c0e](https://github.com/googleapis/google-cloud-dotnet/commit/4123c0e7cf10ff042930277cfd9fd8a5496f61e4))

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


## Version 1.1.0, released 2021-09-23

- [Commit 5504481](https://github.com/googleapis/google-cloud-dotnet/commit/5504481): feat: Add BigQueryAuditMetadata proto. The BigQueryAuditMetadata proto is used by BigQuery Cloud Audit Logging. It is encoded as a google.protobuf.Struct message inside the metadata field of the AuditLog proto

## Version 1.0.0, released 2021-08-16

No API surface changes; just promotion to GA.

## Version 1.0.0-beta02, released 2021-07-28

No code changes; just fixing the docs that broke the 1.0.0-beta01 release.

## Version 1.0.0-beta01, released 2021-07-28

Initial release.
