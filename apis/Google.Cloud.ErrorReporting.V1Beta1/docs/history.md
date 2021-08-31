# Version history

# Version 2.0.0-beta05, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 2.0.0-beta04, released 2021-04-29

- [Commit a31e0d5](https://github.com/googleapis/google-cloud-dotnet/commit/a31e0d5): fix: Remove dependency on AppEngine's proto definitions. This also removes the source_references field.
- [Commit bf7351b](https://github.com/googleapis/google-cloud-dotnet/commit/bf7351b):
  - feat: Make resolution status field available for error groups. Now callers can set the status of an error group by passing this to UpdateGroup. When not specified, it's treated like OPEN.
  - feat: Make source location available for error groups created from GAE.

# Version 2.0.0-beta03, released 2020-11-12

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 326231e](https://github.com/googleapis/google-cloud-dotnet/commit/326231e): chore: set Ruby namespace in proto options
- [Commit fc1d3a0](https://github.com/googleapis/google-cloud-dotnet/commit/fc1d3a0): docs: fix several broken links in the docs.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

# Version 2.0.0-beta02, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.0.0-beta10, released 2019-12-09

- Retry settings removed
- GroupName renamed to ErrorGroupName

# Version 1.0.0-beta09, released 2018-08-02

- Use ProjectName from GAX instead of an ErrorReporting-specific type

# Version 1.0.0-beta08, released 2017-08-17

(No API surface changes.)

# Version 1.0.0-beta07, released 2017-06-22

(No API surface changes.)

# Version 1.0.0-beta06, released 2017-05-22

(No API surface changes.)

# Version 1.0.0-beta05, released 2017-03-30

(No API surface changes.)

# Version 1.0.0-beta04, released 2017-03-02

(No API surface changes.)

# Version 1.0.0-beta03, released 2017-02-20

(No API surface changes.)

# Version 1.0.0-beta02, released 2017-02-15

- Added ErrorGroup.GroupName property

# Version 1.0.0-beta01, released 2016-12-13

First beta release.
