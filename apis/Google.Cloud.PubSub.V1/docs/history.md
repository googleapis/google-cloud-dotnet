# Version history

# Version 1.1.0, released 2019-12-10

Note that support is present in the code for ordering keys, but it's currently disabled; it will be enabled in a future release.

- [Commit 5742d91](https://github.com/googleapis/google-cloud-dotnet/commit/5742d91): Adds ReceivedMessage.DeliveryAttempt
- [Commit 1784804](https://github.com/googleapis/google-cloud-dotnet/commit/1784804): Adds dead letter policy
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add format method for all resource name types
- [Commit c3af927](https://github.com/googleapis/google-cloud-dotnet/commit/c3af927): Fix error in handling non-ordered batch errors ([issue 3133](https://github.com/googleapis/google-cloud-dotnet/issues/3133))
- [Commit 7f24b13](https://github.com/googleapis/google-cloud-dotnet/commit/7f24b13): Minor fix for memory leak risk ([issue 3120](https://github.com/googleapis/google-cloud-dotnet/issues/3120))
- [Commit afa4a96](https://github.com/googleapis/google-cloud-dotnet/commit/afa4a96): Pubsub client ordering-keys ([issue 3099](https://github.com/googleapis/google-cloud-dotnet/issues/3099))
- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc): Add client builders for simplified configuration
- [Commit 0609777](https://github.com/googleapis/google-cloud-dotnet/commit/0609777): Dispose correctly, and properly ignore cancellation ([issue 3083](https://github.com/googleapis/google-cloud-dotnet/issues/3083))
- [Commit 397623e](https://github.com/googleapis/google-cloud-dotnet/commit/397623e): Adds KMS support
- [Commit 1424e89](https://github.com/googleapis/google-cloud-dotnet/commit/1424e89): Adds method overloads accepting strings for methods accepting resource names
- [Commit ddc2de2](https://github.com/googleapis/google-cloud-dotnet/commit/ddc2de2): Adds ordering keys in the underlying API, but no specific support
- [Commit 5a18d38](https://github.com/googleapis/google-cloud-dotnet/commit/5a18d38): Adds OidcToken and AuthenticationMethod
- [Commit e664cad](https://github.com/googleapis/google-cloud-dotnet/commit/e664cad): Create pubsub channels with correct unique-per-channel id ([issue 2798](https://github.com/googleapis/google-cloud-dotnet/issues/2798))
- [Commit 61cd808](https://github.com/googleapis/google-cloud-dotnet/commit/61cd808): Avoid unobserved InvalidOperationException in AsyncSingleRecvQueue ([issue 2785](https://github.com/googleapis/google-cloud-dotnet/issues/2785)). Fixes [issue 2763](https://github.com/googleapis/google-cloud-dotnet/issues/2763)
- [Commit 1d0c50c](https://github.com/googleapis/google-cloud-dotnet/commit/1d0c50c): Adds ExpirationPolicy

# Version 1.0.0, released 2018-10-08

Initial GA release.
