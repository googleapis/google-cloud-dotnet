# Version history

## Version 1.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta05, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta04, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta03, released 2023-05-26

### New features

- ListFunctions now include metadata which indicates whether a function is a `GEN_1` or `GEN_2` function ([commit 6634dea](https://github.com/googleapis/google-cloud-dotnet/commit/6634dead8993023333024d350fd8016fecc636b2))
- KMS crypto keys can now be specified when uploading function source code, enabling source code to be encrypted at rest with a user-managed encryption key ([commit 6634dea](https://github.com/googleapis/google-cloud-dotnet/commit/6634dead8993023333024d350fd8016fecc636b2))
- You can now specify concurrency and cpu of a gen 2 function through the Function API, without needing to modify the underlying Cloud Run service ([commit 6634dea](https://github.com/googleapis/google-cloud-dotnet/commit/6634dead8993023333024d350fd8016fecc636b2))

## Version 1.0.0-beta02, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 1.0.0-beta01, released 2022-06-30

Initial release.
