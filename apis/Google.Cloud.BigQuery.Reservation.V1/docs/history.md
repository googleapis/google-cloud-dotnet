# Version history

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

