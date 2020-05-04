# Version history

# Version 2.1.0, released 2020-05-04

- [Commit cdd7342](https://github.com/googleapis/google-cloud-dotnet/commit/cdd7342): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit e644610](https://github.com/googleapis/google-cloud-dotnet/commit/e644610):
  - Adds Dataproc Jobs.SubmitJobAsOperation RPC
  - Adds SparkR and Presto job types to WorkflowTemplates
  - Adds new Optional Components
  - Clarifies usage of some APIs 
- [Commit edebc2b](https://github.com/googleapis/google-cloud-dotnet/commit/edebc2b): fix Dataproc: add missing `REQUIRED` annotation.
- [Commit bd045c2](https://github.com/googleapis/google-cloud-dotnet/commit/bd045c2): Adds resource name overloads for autoscaling policy operations

# Version 2.0.0, released 2020-03-17

- [Commit c120b77](https://github.com/googleapis/google-cloud-dotnet/commit/c120b77):
  - Feature: SparkR and Presto job support
  - Feature: Lifecycle config support
  - Feature: Reservation affinity support
- [Commit 5ae3789](https://github.com/googleapis/google-cloud-dotnet/commit/5ae3789): Breaking changes around resource names, due to removing RegionOrLocationName

Note that the breaking change here was expected;
RegionOrLocationName didn't represent the name of a real resource,
and we now have better options for handling parents of resources with multiple patterns.

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

Additional changes:

- [Commit a629906](https://github.com/googleapis/google-cloud-dotnet/commit/a629906): Adds AutoscalingPolicyClient.

# Version 1.1.0, released 2019-12-09

- [Commit 4e38a24](https://github.com/googleapis/google-cloud-dotnet/commit/4e38a24): Autoscaling and security configuration
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add resource name format methods

# Version 1.0.0, released 2019-07-10

Initial GA release.
