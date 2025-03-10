# Version history

## Version 4.11.0, released 2025-03-10

### New features

- Allowing users to specify the version id of the Model Garden model ([commit 33f9df1](https://github.com/googleapis/google-cloud-dotnet/commit/33f9df1a2607447629d6edc3241b67717d3ccc91))
- Allowing users to choose whether to use the hf model cache ([commit 33f9df1](https://github.com/googleapis/google-cloud-dotnet/commit/33f9df1a2607447629d6edc3241b67717d3ccc91))
- Bucket soft delete ([commit f773cad](https://github.com/googleapis/google-cloud-dotnet/commit/f773cadaa1bc5c2e32402c6a8ea2e7e2d287ecb9))

## Version 4.10.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Support object soft delete ([commit ae28cb4](https://github.com/googleapis/google-cloud-dotnet/commit/ae28cb432f96ebaebb330ee59ff7c8bf31272621))
## Version 4.9.0, released 2024-03-07

### Bug fixes

- Fix typo ([commit 3fbdeb0](https://github.com/googleapis/google-cloud-dotnet/commit/3fbdeb03961bc767934dfd09981dedf88e8026e6))

### New features

- Allow a new upload session to be initiated as a single method call ([commit f0b643e](https://github.com/googleapis/google-cloud-dotnet/commit/f0b643e3f952624f323b64ec90a904ee804d8e7f))
- Support overriding some URLSigner.Options default values. ([commit 4cc8131](https://github.com/googleapis/google-cloud-dotnet/commit/4cc81319385df5efce7671b16ba2da980fd38c13))
- Support custom hostname and port in signers. ([commit adaa7c4](https://github.com/googleapis/google-cloud-dotnet/commit/adaa7c4ea307bc4948142f1d2c38558122b5a4bf))
- Allows creating UrlSigner directly from a StorageClient. ([commit 4f0d708](https://github.com/googleapis/google-cloud-dotnet/commit/4f0d708a0b26c5223228f90bdd42a567bc983636))
- Support object retention ([commit 6d73d8e](https://github.com/googleapis/google-cloud-dotnet/commit/6d73d8eb86d739f113ea70a535ecf704af471f85))

## Version 4.8.0, released 2024-02-09

### New features

- Support the include folders option for listing objects. ([commit 28b9cb6](https://github.com/googleapis/google-cloud-dotnet/commit/28b9cb6c01105763b1564811e4d41d412f82fdac))
- Add support for the Firebase Storage emulator ([commit a454073](https://github.com/googleapis/google-cloud-dotnet/commit/a454073e1264092ab5c8ae7c8f1420e14216c7c4))

## Version 4.7.0, released 2023-10-31

No API surface changes; just dependency updates.

## Version 4.6.0, released 2023-06-05

### New features

- Add support for glob pattern storage ([commit d0e4541](https://github.com/googleapis/google-cloud-dotnet/commit/d0e45410df7c08d24bd254826d8a64591aa8c22c))

## Version 4.5.0, released 2023-04-20

### New features

- Support custom retry options on all API calls (other than upload/download object) ([commit cc384b5](https://github.com/googleapis/google-cloud-dotnet/commit/cc384b5e2db95b718d68300141152078f2d736d1)) and ([commit 385ee89](https://github.com/googleapis/google-cloud-dotnet/commit/385ee890cf10cbbebab000b96da04d6fc9f62bcc))

## Version 4.4.0, released 2023-02-21

### New features

- Improve exception thrown on failure to upload/download ([commit 4782e03](https://github.com/googleapis/google-cloud-dotnet/commit/4782e0302c8feb4a3f631e5d064aad3564fc55ee))
- Update Google.Apis.Storage.v1 dependency to 1.60.0.2742

## Version 4.3.0, released 2023-02-08

### New features

- Retry Bucket.SetIamPolicy only conditionally. ([commit 3c70dd2](https://github.com/googleapis/google-cloud-dotnet/commit/3c70dd2ee07c453252dffdae8b8b21cafd222fd7))

## Version 4.2.0, released 2023-01-23

### New features

- Improve credential support for URL signing. ([commit d36a8dd](https://github.com/googleapis/google-cloud-dotnet/commit/d36a8dd4f3ccd91b70f4a454dfa7f1dd4317308b))
- Add DownloadValidationMode.Automatic ([commit c9f2b19](https://github.com/googleapis/google-cloud-dotnet/commit/c9f2b19c2e624771df497a969a5b60d37c1bfec5))
- Support HMAC URL signing. ([commit dfad68e](https://github.com/googleapis/google-cloud-dotnet/commit/dfad68e47ed7a72c9ef97b5676c59adec2f87aa2))
- Enable self-signed JWTs for Storage and Translation clients ([commit 10d2787](https://github.com/googleapis/google-cloud-dotnet/commit/10d2787c9963b49199ffdf8d4ed69169142272fb))
- Add invocation ID and attempt count in x-goog-api-client header. Fixes [issue 8881](https://github.com/googleapis/google-cloud-dotnet/issues/8881) ([commit 1ac6f68](https://github.com/googleapis/google-cloud-dotnet/commit/1ac6f6812d829081c096e3ae5da0de7972feb368))
- Disabled default ExponentialBackOffPolicy in message handler via StorageClientBuilder ([commit 62aec51](https://github.com/googleapis/google-cloud-dotnet/commit/62aec51d17922857f260f32a9dc17099062c47a0))

### Documentation improvements

- Add commentary on accidentally-optional parameters ([commit 228bdfc](https://github.com/googleapis/google-cloud-dotnet/commit/228bdfcb90b62b40cf68591ee2c7b468964adcfa))

## Version 4.1.0, released 2022-07-22

No API surface changes; just dependency updates.

## Version 4.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

### New features

- Provide metadata for the object that has been downloaded. Fixes [issue 7897](https://github.com/googleapis/google-cloud-dotnet/issues/7897) ([commit e60a0d4](https://github.com/googleapis/google-cloud-dotnet/commit/e60a0d4405e4f6e25faca2e227e9276cc3fc11d0))
- Operations are retried automatically where appropriate

### Breaking changes

- Changes to IBlogSigner to support HMAC signing. ([commit b82fed2](https://github.com/googleapis/google-cloud-dotnet/commit/b82fed27f2ebeb3c345290b477c7f53ff3c0148e))

## Version 3.7.0, released 2022-01-27

No API surface changes; just dependency updates.

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
  guide](https://cloud.google.com/dotnet/docs/reference/help/cleanup#rest-based-apis)
  for more information)

## Version 2.0.0, released 2017-06-22

Major version bump due to updating Google.Api.Gax.Rest dependency to
2.0.0, but this is unlikely to actually be a breaking change for
customers.

New features:

- Support for fetching and setting bucket IAM policies

## Version 1.0.0, released 2017-03-30

Initial release.
