# Version history

# Version 1.0.0-beta04, released 2021-11-10

- [Commit 41d3129](https://github.com/googleapis/google-cloud-dotnet/commit/41d3129): fix: Convert HTTP status codes to gRPC status codes when converting LROs

This also updates the GAX dependency to 3.6.0-beta03.
# Version 1.0.0-beta03, released 2021-10-14

- [Commit 77a75b3](https://github.com/googleapis/google-cloud-dotnet/commit/77a75b3): feat!: Generate idiomatic LROs for Google.Cloud.Compute.V1

BREAKING CHANGE: All RPCs representing long running operations
(LROs) are now exposed using the `Operation<,>` type in the
Google.LongRunning package. This allows code using the Compute API
to be equivalent to that of LROs in other packages, even though
behind the scenes they don't follow the exact same pattern.

In particular, this makes it much easier to wait for an operation to
complete without writing any manual polling code. However, it is a
breaking change compared with the previous beta releases.

# Version 1.0.0-beta02, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 1.0.0-beta01, released 2021-08-09

Main changes from 1.0.0-alpha02:

- Automatic pagination is now implemented for all "list" methods. This is a breaking
  change, as the return type has changed. Any code which was
  previously looping over responses manually and handling page
  tokens can be simplified at this point. See https://cloud.google.com/dotnet/docs/reference/help/page-streaming
  for more details.
- Failed RPCs will now contain details of the failure, rather than
  just a status code. Currently this is just the textual
  representation of the original RPC response; in the future this
  text may be parsed automatically.

# Version 1.0.0-alpha02, released 2021-06-16

Regenerated with changes from googleapis-discovery, and GAX
3.5.0-alpha01.

# Version 1.0.0-alpha01, released 2021-05-13

First alpha release. Please note that this library is still in early
testing phases, and is not suitable for production workloads.
