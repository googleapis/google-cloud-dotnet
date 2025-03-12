# Version history

This package is primarily a dependency of Google.Cloud.Firestore. See the
[Google.Cloud.Firestore version history](https://googleapis.dev/dotnet/Google.Cloud.Firestore/latest/history.html)
for more details.

## Version 3.10.0, released 2025-03-12

### Documentation improvements

- Minor documentation updates to `StructuredQuery` ([commit a35c988](https://github.com/googleapis/google-cloud-dotnet/commit/a35c98889228ea0291cc7d843eabb875711d667b))
- Minor documentation changes for `distance_threshold` ([commit a35c988](https://github.com/googleapis/google-cloud-dotnet/commit/a35c98889228ea0291cc7d843eabb875711d667b))

## Version 3.9.0, released 2024-09-26

### New features

- Expose the `FindNearest.distance_result_field` parameter ([commit 90e89c5](https://github.com/googleapis/google-cloud-dotnet/commit/90e89c54a34ab97ac383fb7fc7ccd308cd9ba189))
- Expose the `FindNearest.distance_threshold` parameter ([commit 90e89c5](https://github.com/googleapis/google-cloud-dotnet/commit/90e89c54a34ab97ac383fb7fc7ccd308cd9ba189))

### Documentation improvements

- Minor documentation clarifications on FindNearest DistanceMeasure options ([commit 0997231](https://github.com/googleapis/google-cloud-dotnet/commit/099723106fe192589286ed58ab1ee8af88ce53d1))

## Version 3.8.0, released 2024-06-24

No API surface changes; just dependency updates.

## Version 3.7.0, released 2024-05-03

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.6.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add VectorSearch API ([commit 6b45d22](https://github.com/googleapis/google-cloud-dotnet/commit/6b45d2250c9652a430fc0ae1a371353e4ff31056))
- Add new types ExplainOptions, ExplainMetrics, PlanSummary, ExecutionStats ([commit c2793f0](https://github.com/googleapis/google-cloud-dotnet/commit/c2793f0cc57d48470bb8834b6ac1d4ace0305a1e))
- Add ExplainOptions field to RunQueryRequest ([commit c2793f0](https://github.com/googleapis/google-cloud-dotnet/commit/c2793f0cc57d48470bb8834b6ac1d4ace0305a1e))
- Add ExplainMetrics field to RunQueryResponse ([commit c2793f0](https://github.com/googleapis/google-cloud-dotnet/commit/c2793f0cc57d48470bb8834b6ac1d4ace0305a1e))
- Add ExplainOptions field to RunAggregationQueryRequest ([commit c2793f0](https://github.com/googleapis/google-cloud-dotnet/commit/c2793f0cc57d48470bb8834b6ac1d4ace0305a1e))
- Add ExplainMetrics field to RunAggregationQueryResponse ([commit c2793f0](https://github.com/googleapis/google-cloud-dotnet/commit/c2793f0cc57d48470bb8834b6ac1d4ace0305a1e))

## Version 3.5.1, released 2024-02-14

### Bug fixes

- Restore the use of "legacy" routing headers until the newer header is fully supported in the Firestore emulator. ([commit 6a5e369](https://github.com/googleapis/google-cloud-dotnet/commit/6a5e3696c4101fd1c33b5febdf4d75602415889c))

## Version 3.5.0, released 2024-01-30

### Documentation improvements

- Improve the documentation on Document.fields ([commit 91ef4a3](https://github.com/googleapis/google-cloud-dotnet/commit/91ef4a354074c3d83e757d7c89e91b2e77cd96f5))

## Version 3.5.0-beta01, released 2023-11-29

No API surface changes; just dependency updates.

## Version 3.4.0, released 2023-10-04

### New features

- Publish proto definitions for SUM/AVG in Firestore ([commit 9931b9d](https://github.com/googleapis/google-cloud-dotnet/commit/9931b9db0820aeda79300914c7e0ddb5edb647c4))
- Add bloom filter related proto fields ([commit c9dbc16](https://github.com/googleapis/google-cloud-dotnet/commit/c9dbc16b36d6fdfb0e6697585f6aa6fe26c01740))

## Version 3.3.0, released 2023-05-03

### Bug fixes

- Add resource prefix header in aggregation query. This is required to use aggregation queries in the emulator. [Commit 100689b](https://github.com/googleapis/google-cloud-dotnet/commit/100689b2dae0855af5e57f6ebbaadf6f686c3e03)

## Version 3.2.0, released 2023-03-22

### New features

- Add `OR` query support ([commit a88bcd7](https://github.com/googleapis/google-cloud-dotnet/commit/a88bcd79f3039261fb3cc4f2c37e592ec1e8718d))

### Documentation improvements

- Improve the API documentation for the `Firestore.ListDocuments` RPC ([commit a88bcd7](https://github.com/googleapis/google-cloud-dotnet/commit/a88bcd79f3039261fb3cc4f2c37e592ec1e8718d))
- Minor documentation formatting and cleanup ([commit a88bcd7](https://github.com/googleapis/google-cloud-dotnet/commit/a88bcd79f3039261fb3cc4f2c37e592ec1e8718d))

## Version 3.1.0, released 2023-02-08

### New features

- Add Firestore aggregation query apis ([commit a93b264](https://github.com/googleapis/google-cloud-dotnet/commit/a93b264d6acbdcee46d61d22271187884709e04a))

### Documentation improvements

- Update query ordering documentation ([commit 16f4f35](https://github.com/googleapis/google-cloud-dotnet/commit/16f4f354a7713b193d95ce1937c9a17257cf524f))

## Version 3.0.0, released 2022-06-09

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

### Bug fixes

- Change REST binding for ListDocuments to support root collection ([commit a766738](https://github.com/googleapis/google-cloud-dotnet/commit/a76673847c7e3ca351d20f2c336a4b6343d71faa))

### New features

- Expose read_time fields in Firestore PartitionQuery and ListCollectionIds, currently only available in private preview ([commit 9054250](https://github.com/googleapis/google-cloud-dotnet/commit/90542508b9e79943f765596c5bd33c523ee1963c))
- Enable RunQueryResponse.done ([commit ad9cf69](https://github.com/googleapis/google-cloud-dotnet/commit/ad9cf69a1db81b3b676bdc46bd1d3628c15524d3))

### Documentation improvements

- Clarifications for filters ([commit d35ef87](https://github.com/googleapis/google-cloud-dotnet/commit/d35ef87ad2907d54782e428e315a37f1e7411b2b))

## Version 2.5.0, released 2022-01-18

No API surface changes; just dependency updates.

## Version 2.4.0, released 2021-08-18

- [Commit d9a3648](https://github.com/googleapis/google-cloud-dotnet/commit/d9a3648): fix: Fix Firestore and Datastore for self-signed JWTs
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.3.0, released 2021-05-05

- [Commit 9f5f0aa](https://github.com/googleapis/google-cloud-dotnet/commit/9f5f0aa): Regenerate server-streaming calls with Google request params
- [Commit 1add4dc](https://github.com/googleapis/google-cloud-dotnet/commit/1add4dc): fix: retry RESOURCE_EXHAUSTED errors docs: various documentation improvements

## Version 2.2.0, released 2020-11-18

- [Commit 9f32781](https://github.com/googleapis/google-cloud-dotnet/commit/9f32781): fix: retry PartitionQuery for INTERNAL and DEADLINE_EXCEEDED
- [Commit 91989e0](https://github.com/googleapis/google-cloud-dotnet/commit/91989e0): fix: give PartitionQuery retry/timeout config

## Version 2.1.0, released 2020-10-05

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit afbd7c4](https://github.com/googleapis/google-cloud-dotnet/commit/afbd7c4): feat: firestore: add `!=` support
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit c39c12c](https://github.com/googleapis/google-cloud-dotnet/commit/c39c12c): chore: add BatchWrite to service config
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with generator changes (fixes retries)
- [Commit 71492d2](https://github.com/googleapis/google-cloud-dotnet/commit/71492d2): feat: retry CommitRequests that fail with UNAVAILABLE
- [Commit 8264d69](https://github.com/googleapis/google-cloud-dotnet/commit/8264d69): feat: add BatchWrite and PartitionQuery ([issue 5013](https://github.com/googleapis/google-cloud-dotnet/issues/5013))
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-05-12

No API surface changes.

This is the first GA release targeting GAX v3.

## Version 2.0.0-beta02, released 2020-03-18

- [Commit 1d8b26a](https://github.com/googleapis/google-cloud-dotnet/commit/1d8b26a):
  - Regenerate all APIs to pick up generator changes
  - This commit only contains changes to the client builders, which now
  - have partial methods to allow interception of the Build/BuildAsync
  - methods.
- [Commit e032681](https://github.com/googleapis/google-cloud-dotnet/commit/e032681): Adds Write.UpdateTransforms

## Version 2.0.0-beta01, released 2020-02-18	

This is the first prerelease targeting GAX v3. Please see the [breaking changes	
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)	
for details of changes to both GAX and code generation.	

Some methods that previously accepted resource names now do not, due	
to a change in how the resource names in the API are configured.	

## Version 1.1.0, released 2019-12-03	

## Version 1.1.0-beta02, released 2019-11-05	

- [Commit 18ad306](https://github.com/googleapis/google-cloud-dotnet/commit/18ad306): Added In and ArrayContainsAny to the FieldFilter.Types.Operator enum	
- [Commit 331b8a8](https://github.com/googleapis/google-cloud-dotnet/commit/331b8a8): Comment / code ordering changes only. (No semantic diff.)	

## Version 1.1.0-beta01, released 2019-09-05	

- [Commit 6b1d462](https://github.com/googleapis/google-cloud-dotnet/commit/6b1d462): Changes to timeouts and retry codes	
- [Commit b917790](https://github.com/googleapis/google-cloud-dotnet/commit/b917790):	
  - Introduce FirestoreDbBuilder	
  - This is an extensible way of providing more control over FirestoreDb creation, in a manner consistent with other Cloud client libraries.	

## Version 1.0.0, released 2019-07-16	

- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2):	
  - Regenerate all APIs with resource name format methods	
  - (There are some resource name classes in other packages which will need some manual tidy-up before we can close [issue 2443](https://github.com/googleapis/google-cloud-dotnet/issues/2443).)	
- [Commit 215ea7f](https://github.com/googleapis/google-cloud-dotnet/commit/215ea7f):	
  - Regenerate all APIs	
  - This uses the new GAX method for the routing header, which URL-encodes values.	
- [Commit 5d34517](https://github.com/googleapis/google-cloud-dotnet/commit/5d34517):	
  - Regenerate all APIs	
  - Changes here are due to changes in protoc and the gRPC plugin for protoc, and should be backwardly compatible.	

## Version 1.0.0-beta22, released 2019-06-24	

- [Commit 44d3d92](https://github.com/googleapis/google-cloud-dotnet/commit/44d3d92): Regenerate all clients with null conditional operator for resource paths	

## Version 1.0.0-beta21, released 2019-06-10	

- [Commit ee5c7dc](https://github.com/googleapis/google-cloud-dotnet/commit/ee5c7dc):	
  - Introduce ClientBuilders for all APIs (except Grafeas)	
  - (We need to work out what to do about Grafeas separately. Next commit will be code to remove the new builder which is generated for Grafeas.)	
- [Commit 0cb5661](https://github.com/googleapis/google-cloud-dotnet/commit/0cb5661):	
  - Revert "Regenerate all clients, without retrying on DeadlineExceeded"	
  - This reverts commit 877f04bb6a47d51399d2e4945e60f05a2b9097d0.	
- [Commit 877f04b](https://github.com/googleapis/google-cloud-dotnet/commit/877f04b): Regenerate all clients, without retrying on DeadlineExceeded	
- [Commit 1424e89](https://github.com/googleapis/google-cloud-dotnet/commit/1424e89):	
  - Regenerate all APIs with newest codegen	
  - This adds an overload for any method that accepts a resource name, to accept a string instead.	
  - Fixes [issue 2442](https://github.com/googleapis/google-cloud-dotnet/issues/2442).	

## Version 1.0.0-beta20, released 2019-04-17	

- [Commit 759e007](https://github.com/googleapis/google-cloud-dotnet/commit/759e007):	
  - Regenerate Firestore V1	
  - This change from string to AnyPathName is currently a breaking change, but won't be in the new generator. Fortunately we haven't gone GA yet.	
- [Commit 673ef14](https://github.com/googleapis/google-cloud-dotnet/commit/673ef14): Regenerate Firestore	
- [Commit a1a01f9](https://github.com/googleapis/google-cloud-dotnet/commit/a1a01f9):	
  - Regenerate all APIs with updated generator	
  - This populates x-goog-request-params on all requests	
- [Commit 52417d1](https://github.com/googleapis/google-cloud-dotnet/commit/52417d1): Regenerate Firestore V1 - comment typo fix	
- [Commit 79700f7](https://github.com/googleapis/google-cloud-dotnet/commit/79700f7): Regenerate Firestore API: comment changes only	

## Version 1.0.0-beta19, released 2019-02-07	

- [Commit 7a50886](https://github.com/googleapis/google-cloud-dotnet/commit/7a50886):	
  - Retry BatchGetDocuments RPC within GetDocumentSnapshotsAsync	
  - This effectively treats the streaming API as if it were a unary API. We may be able to remove some of the redundancy between this and GAX in the future.	
  - We *only* apply this to GetDocumentSnapshotsAsync - when streaming query results, we can't retry transparently as the caller can see some results before the failure.	
  - The use of FirestoreClient.Settings doesn't play nicely with mocking. It would be nice to be able to say "You can call Settings as often as you like, but make sure no other unexpected calls are made" but I haven't been able to achieve that. It's not a big problem though.	
  - Fixes [issue 2760](https://github.com/googleapis/google-cloud-dotnet/issues/2760)	

## Version 1.0.0-beta18, released 2019-02-05	


## Version 1.0.0-beta17, released 2019-01-17	


## Version 1.0.0-beta16, released 2019-01-15	

- [Commit 667d724](https://github.com/googleapis/google-cloud-dotnet/commit/667d724): Add resource routing to Firestore.V1 client	
- [Commit af8063e](https://github.com/googleapis/google-cloud-dotnet/commit/af8063e):	
  - Generate Firestore v1 API	
  - This replaces the V1Beta1 API (the YAML file only contains the V1 definition).	
  - After migrating to V1 entirely, we'll delete the V1Beta1 directory.
