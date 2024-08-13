# Version history

## Version 1.7.0, released 2024-08-13

### New features

- Optional field for specifying a service account to use for the build. This helps navigate the change of historical default on new projects. For more details, see https://cloud.google.com/build/docs/cloud-build-service-account-updates ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- Optional fields for setting up automatic base image updates. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- Optional field for specifying a revision on GetFunction. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- Optional field for binary authorization policy. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- Optional field for deploying a source from a GitHub repository. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- Additional field on the output that specified whether the deployment supports Physical Zone Separation. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- Generate upload URL now supports for specifying the GCF generation that the generated upload url will be used for. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))
- ListRuntimes response now includes deprecation and decommissioning dates. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))

### Documentation improvements

- Refined description in several fields. ([commit d169759](https://github.com/googleapis/google-cloud-dotnet/commit/d1697594643e72eecbec96b932458873cb6845c5))

## Version 1.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.5.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.4.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.3.0, released 2023-05-26

### New features

- ListFunctions now include metadata which indicates whether a function is a `GEN_1` or `GEN_2` function ([commit a678905](https://github.com/googleapis/google-cloud-dotnet/commit/a678905cbacd1970ed1b3e2d46e14d82635c5dcd))

## Version 1.2.0, released 2023-03-20

### New features

- Add `available_cpu ` field ([commit 1fe48c2](https://github.com/googleapis/google-cloud-dotnet/commit/1fe48c20af36a2f9d5b6de66a2d8ddda3383e991))
- Add `kms_key_name` field to ServiceConfig (the CMEK use case) ([commit 1fe48c2](https://github.com/googleapis/google-cloud-dotnet/commit/1fe48c20af36a2f9d5b6de66a2d8ddda3383e991))
- Add `max_instance_request_concurrency` field ([commit 1fe48c2](https://github.com/googleapis/google-cloud-dotnet/commit/1fe48c20af36a2f9d5b6de66a2d8ddda3383e991))
- Add `security_level` field ([commit 1fe48c2](https://github.com/googleapis/google-cloud-dotnet/commit/1fe48c20af36a2f9d5b6de66a2d8ddda3383e991))

## Version 1.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 1.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2022-07-27

Initial release.
