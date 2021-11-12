# Version history

## Version 3.6.0, released 2021-09-29

No API surface changes; just dependency updates.

## Version 3.5.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 3.4.0, released 2021-01-18

- [Commit 421ad3f](https://github.com/googleapis/google-cloud-dotnet/commit/421ad3f): Update Google.Apis.Storage.v1 dependency.

(No API changes from 3.4.0-beta01.)

## Version 3.4.0-beta01, released 2020-09-30

- [Commit 572976f](https://github.com/googleapis/google-cloud-dotnet/commit/572976f): Update Google.Apis.Storage.v1 dependency.
- [Commit 7b6edc0](https://github.com/googleapis/google-cloud-dotnet/commit/7b6edc0): fix: Makes V4 signature include x-goog-resumable header. Fixes [issue 5361](https://github.com/googleapis/google-cloud-dotnet/issues/5361)

## Version 3.3.0, released 2020-09-01

No API surface changes; just updated dependencies. In particular,
this uses Google.Apis.Storage.v1 version 1.49.0.2044, which includes
OLM support.

## Version 3.2.0, released 2020-07-01

- [Commit 482a8b0](https://github.com/googleapis/google-cloud-dotnet/commit/482a8b0): Update Google.Apis.Storage.v1 dependency. Fixes [issue 5115](https://github.com/googleapis/google-cloud-dotnet/issues/5115).

## Version 3.1.0, released 2020-05-28

- [Commit db4f9a9](https://github.com/googleapis/google-cloud-dotnet/commit/db4f9a9): Update Google.Apis.Storage.v1 dependency. Fixes [issue 4984](https://github.com/googleapis/google-cloud-dotnet/issues/4984).
- [Commit fbcca00](https://github.com/googleapis/google-cloud-dotnet/commit/fbcca00): Implement StartOffset and EndOffset in ListObjectsOptions. Fixes [issue 4993](https://github.com/googleapis/google-cloud-dotnet/issues/4993).

## Version 3.0.0, released 2020-05-12

- [Commit c0dfc6f](https://github.com/googleapis/google-cloud-dotnet/commit/c0dfc6f): feat: POST policy V4 signing support.

This is the first GA release of this package depending on GAX v3.

## Version 3.0.0-beta03, released 2020-04-02

No API surface changes; just updated dependencies. In particular,
this uses Google.Apis version 1.45.0, which uses a more
memory-efficient approach to uploads.

## Version 3.0.0-beta02, released 2020-03-19

- [Commit cdc1f03](https://github.com/googleapis/google-cloud-dotnet/commit/cdc1f03):
  - Fixes and new features for URL signing:
  -   * V4 is now the default signing mechanism.
  -   * V4: collapses tabs in header's values.
  -   * V4: uses payload hash if provided. V2 ignores payload hash if provided (as it does with almost every other header).
  -   * V4: supports signing of custom query parameters. V2 will throw if custom query parameters are set.
  -   * V2 and V4: supports setting URL scheme (http or htpps only).
  -   * V2 and V4: supports Virtual-hosted style URLs.
  -   * V4: supports bucket bound domain URLs. V2 will throw if bucket bound domain is set.
- [Commit 71ca7e8](https://github.com/googleapis/google-cloud-dotnet/commit/71ca7e8): Removes obsolete methods.

There are breaking changes around `UrlSigner`; code that still
compiles should be fine - otherwise, use the
`UrlSigner.RequestTemplate` and `UrlSigner.Options` classes to
specify options that were previously in method parameters.

## Version 3.0.0-beta01, released 2020-02-20

Upgrade dependencies to GAX v3. Currently there are no direct
surface changes, but breaking changes in GAX may affect users, for
example in terms of async pagination.

More direct breaking changes are expected in this package before
3.0.0 is released, specifically around signed URLs.

## Version 2.5.0, released 2020-01-06

- [Commit f556739](https://github.com/googleapis/google-cloud-dotnet/commit/f556739): Add Fields parameters to ListObjectsOptions and ListBucketsOptions
- [Commit 32f8a22](https://github.com/googleapis/google-cloud-dotnet/commit/32f8a22): Add support for Archive storage class.

## Version 2.4.0, released 2019-12-10

New features since 2.3.0:

- Opt-in support for V4 signing URLs
- Add `IncludeTrailingDelimiter` to `ListObjectsOptions`
- Default endpoint is now storage.googleapis.com
- Added GetBucketIamPolicyOptions.RequestedPolicyVersion in anticipation of IAM conditions
- Added StorageClientBuilder for simplified configuration
- Added support for HMAC keys associated with service accounts in GCS

## Version 2.3.0, released 2019-02-11

New features since 2.2.0:

- Support for supplying page tokens when listing buckets or objects
- Support for retention policy locking
- Deprecate URL signing without an expiry; the default is now in 2038 (the end of "Unix time in seconds")
- Allow an Origin header to be specified in UploadObjectOptions for CORS scenarios

## Version 2.2.0, released 2018-08-28

New features since 2.1.0:

- New interface `UrlSigner.IBlobSigner` for more flexibility when
  creating signed URLs
- Option to delete objects automatically when deleting a bucket
- Support for [customer-managed encryption
  keys](https://cloud.google.com/storage/docs/encryption/customer-managed-keys)

## Version 2.1.0, released 2018-01-02

New features:

- Support for [requester pays](https://cloud.google.com/storage/docs/requester-pays)
- Support for [bucket labels](https://cloud.google.com/storage/docs/using-bucket-labels)
- Support for unauthenticated access to public objects and buckets
- Support for [PubSub notifications](https://cloud.google.com/storage/docs/pubsub-notifications)
- Support upload and download hash validation, including the ability to disable it
- `StorageClient` now implements `IDisposable` to dispose the
  underlying service, where appropriate (see [the user
  guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/cleanup.html#rest-based-apis)
  for more information)

## Version 2.0.0, released 2017-06-22

Major version bump due to updating Google.Api.Gax.Rest dependency to
2.0.0, but this is unlikely to actually be a breaking change for
customers.

New features:

- Support for fetching and setting bucket IAM policies

## Version 1.0.0, released 2017-03-30

Initial release.
