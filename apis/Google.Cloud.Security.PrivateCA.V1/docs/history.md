# Version history

# Version 2.1.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 2.0.0, released 2021-07-16

- [Commit f09fdff](https://github.com/googleapis/google-cloud-dotnet/commit/f09fdff): fix!: mark some bools as optional, correct response type of DeleteCaPool

This is a new major version as the change in response type for
`DeleteCaPool` is a breaking change. Customers using the 1.x libraries
are encouraged to upgrade, as attempting to obtain the result of the
operation created by the `DeleteCaPool` RPC will throw an exception
at execution time.

# Version 1.0.0, released 2021-06-28

No API surface changes; just dependency updates and promotion to GA.

# Version 1.0.0-beta01, released 2021-06-08

Initial release.
