# Version history

## Version 2.6.0, released 2024-12-06

### New features

- Add the managed disaster recovery API(https://cloud.google.com/bigquery/docs/managed-disaster-recovery) ([commit 54897cb](https://github.com/googleapis/google-cloud-dotnet/commit/54897cbd2d99c298ee5f2e7b58b85b042e64e296))
- Add a new field `is_flat_rate` to `.google.cloud.bigquery.reservation.v1.CapacityCommitment` to distinguish between flat rate and edition commitments ([commit 54897cb](https://github.com/googleapis/google-cloud-dotnet/commit/54897cbd2d99c298ee5f2e7b58b85b042e64e296))

### Documentation improvements

- Clarify that `Autoscale.current_slots` in message `.google.cloud.bigquery.reservation.v1.Reservation` can temporarily be larger than `Autoscale.max_slots` if users reduce `Autoscale.max_slots` ([commit 54897cb](https://github.com/googleapis/google-cloud-dotnet/commit/54897cbd2d99c298ee5f2e7b58b85b042e64e296))
- Update comment for `slot_capacity` in message `.google.cloud.bigquery.reservation.v1.Reservation` to provide more clarity about reservation baselines, committed slots and autoscaler SKU charges when the baseline exceeds committed slots ([commit 54897cb](https://github.com/googleapis/google-cloud-dotnet/commit/54897cbd2d99c298ee5f2e7b58b85b042e64e296))
- Update comments for `commitment_start_time` and `commitment_end_time` in message `.google.cloud.bigquery.reservation.v1.CapacityCommitment` to provide details on how these values are affected by commitment renewal ([commit 54897cb](https://github.com/googleapis/google-cloud-dotnet/commit/54897cbd2d99c298ee5f2e7b58b85b042e64e296))

## Version 2.5.0, released 2024-05-13

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.4.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.3.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 2.2.0, released 2023-03-27

### New features

- Add edition/autoscale related fields ([commit 08c71a9](https://github.com/googleapis/google-cloud-dotnet/commit/08c71a9564c50a621cd07ba1a1bad37a29d05b1d))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

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
## Version 1.6.0, released 2022-04-26

### New features

- Add UpdateAssignment method ([commit 9b9e9d1](https://github.com/googleapis/google-cloud-dotnet/commit/9b9e9d197d95d59a3e88b213a2511c22683247c0))
- Add "concurrency" and "multi_region_auxiliary" in reservation ([commit 9b9e9d1](https://github.com/googleapis/google-cloud-dotnet/commit/9b9e9d197d95d59a3e88b213a2511c22683247c0))
- Add preferred table. ([commit 9b9e9d1](https://github.com/googleapis/google-cloud-dotnet/commit/9b9e9d197d95d59a3e88b213a2511c22683247c0))

### Documentation improvements

- Cleanup and clarifications ([commit 9b9e9d1](https://github.com/googleapis/google-cloud-dotnet/commit/9b9e9d197d95d59a3e88b213a2511c22683247c0))

## Version 1.5.0, released 2022-01-17

### New features

- Increase the logical timeout (retry deadline) to 5 minutes ([commit b56182a](https://github.com/googleapis/google-cloud-dotnet/commit/b56182a312da47b8b8b2e8aa74f849bc2ac3e844))

## Version 1.4.0, released 2021-09-24

- [Commit 7c0622f](https://github.com/googleapis/google-cloud-dotnet/commit/7c0622f):
  - feat: Deprecated SearchAssignments in favor of SearchAllAssignments
  - feat: Reservation objects now contain a creation time and an update time
  - feat: Added commitment_start_time to capacity commitments
  - feat: Force deleting capacity commitments is allowed while reservations with active assignments exist
  - feat: ML_EXTERNAL job type is supported
  - feat: Optional id can be passed into CreateCapacityCommitment and CreateAssignment
  - docs: Clarified docs for None assignments
  - fix!: Fixed pattern for BiReservation object
  - BREAKING_CHANGE: Changed from `bireservation` to `biReservation`

## Version 1.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 1.1.0, released 2020-10-07

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation

## Version 1.0.0, released 2020-07-06

- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): Regenerate all APIs with generator changes (enabled timeouts for non-retried RPCs)

## Version 1.0.0-beta01, released 2020-06-15

First beta release.

