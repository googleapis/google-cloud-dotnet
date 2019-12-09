# Version history

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
