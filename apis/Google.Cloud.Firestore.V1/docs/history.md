# Version history

This package is primarily a dependency of Google.Cloud.Firestore. See the
[Google.Cloud.Firestore version history](https://googleapis.dev/dotnet/Google.Cloud.Firestore/latest/history.html)
for more details.

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
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)	
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
