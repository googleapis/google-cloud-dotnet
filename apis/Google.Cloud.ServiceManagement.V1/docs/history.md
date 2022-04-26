# Version history

## Version 1.5.0, released 2022-04-26

### Documentation improvements

- Fix broken links ([commit c6cef48](https://github.com/googleapis/google-cloud-dotnet/commit/c6cef48acd6124c4a724695e501f2b6943233021))
- Fix remaining broken links ([commit 129c7cb](https://github.com/googleapis/google-cloud-dotnet/commit/129c7cbad009a12a5fc9273d6bb9e34e280c0dd7))
## Version 1.4.0, released 2022-02-15

### Bug fixes

- **BREAKING CHANGE** Remove EnableService and DisableService RPC methods and related protos from service management API ([commit d5cb1ab](https://github.com/googleapis/google-cloud-dotnet/commit/d5cb1abcd3ed51c1b1d22b622900fac9caf727ca))

The breaking change here reflects the actual API; the `EnableService` and `DisableService` RPCs have not been available for some time. In other words, this change will not break any customer who isn't already broken in terms of making RPCs. (It may break mock/fake test code which expects those RPCs to still be available, however.)

## Version 1.3.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-06-22

- [Commit 3717e0d](https://github.com/googleapis/google-cloud-dotnet/commit/3717e0d): Regenerate all APIs with generator change for deprecation

## Version 1.1.0, released 2021-04-29

No API surface changes; minor update due to dependencies

## Version 1.0.0, released 2020-11-18

First GA release.

- [Commit 7b21712](https://github.com/googleapis/google-cloud-dotnet/commit/7b21712): chore: Set namespaces for Ruby clients

## Version 1.0.0-beta01, released 2020-10-15

Initial beta release.


