# Version history

# Version 2.3.0, released 2021-11-08

- [Commit 753d624](https://github.com/googleapis/google-cloud-dotnet/commit/753d624): chore: Remove old "pseudo-handwritten" resource names file
- [Commit 1b7246b](https://github.com/googleapis/google-cloud-dotnet/commit/1b7246b): feat: Regenerate Google.Cloud.Iam.V1 (as a GAPIC package)

# Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

# Version 2.1.0, released 2020-10-19

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

# Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency and implementation changes.

# Version 2.0.0-beta01, released 2020-02-17

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.3.0, released 2019-12-09

- [Commit f8f09a8](https://github.com/googleapis/google-cloud-dotnet/commit/f8f09a8): Update IAM helper methods to protect against IAM conditions. The methods throw an exception if:
  - The policy version is greater than 1
  - Any bindings have conditions
- [Commit ab0fe73](https://github.com/googleapis/google-cloud-dotnet/commit/ab0fe73): Added GetPolicyOptions
- [Commit 65376a1](https://github.com/googleapis/google-cloud-dotnet/commit/65376a1): Introduces IAM conditions

# Version 1.2.0, released 2019-02-20

(No visible API changes; could have been released as a patch to 1.1.0.)

# Version 1.1.0, released 2018-06-28

- [Commit 74a5ba8](https://github.com/googleapis/google-cloud-dotnet/commit/74a5ba8): Add resource name properties to IAM requests

# Version 1.0.0, released 2017-12-05

Initial GA release.
