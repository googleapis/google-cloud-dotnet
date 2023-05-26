# Version history

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
