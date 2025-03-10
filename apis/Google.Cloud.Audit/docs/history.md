# Version history

## Version 2.5.0, released 2025-03-10

### New features

- Updates audit_log proto with PermissionType ([commit 47a5d72](https://github.com/googleapis/google-cloud-dotnet/commit/47a5d72fa0f4f266487685b0894003d808c103f6))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-09-18

### New features

- Add the name of the reservation the job was submitted to as a field ([commit 8509295](https://github.com/googleapis/google-cloud-dotnet/commit/8509295870d00b72bc70b8d3a63a10bcacd8dafd))

### Documentation improvements

- Use deprecated=true for deprecated fields ([commit ac35511](https://github.com/googleapis/google-cloud-dotnet/commit/ac35511716630dc7391dde688e03e9224386e8b1))
- Mark ReservationResourceUsage field as deprecated ([commit f1929cb](https://github.com/googleapis/google-cloud-dotnet/commit/f1929cbfa7a04ddf841749c9df6adab1696cf1e7))

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
