# Version history

## Version 3.12.0, released 2024-12-06

### New features

- Added support for notification prompts in AlertPolicy ([commit 4541241](https://github.com/googleapis/google-cloud-dotnet/commit/454124189453710c8fd2a0aef225865c6b64bad2))
- Added support for PromQL metric validation opt-out in AlertPolicy ([commit 4541241](https://github.com/googleapis/google-cloud-dotnet/commit/454124189453710c8fd2a0aef225865c6b64bad2))

## Version 3.11.0, released 2024-06-24

### New features

- Add support to add links in AlertPolicy ([commit 3513b82](https://github.com/googleapis/google-cloud-dotnet/commit/3513b829e9f69a503494975f9e86e4568db66dad))

## Version 3.10.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 3.9.0, released 2024-04-29

### Bug fixes

- Defined class prefix of GMON for Objective C ([commit 679648b](https://github.com/googleapis/google-cloud-dotnet/commit/679648b57fc738b7b554c55abf6b2ab8b2424253))

## Version 3.8.0, released 2024-04-19

### New features

- Added CloudRun, GkeNamespace, GkeWorkload, GkeService, and BasicService service types ([commit a63edc5](https://github.com/googleapis/google-cloud-dotnet/commit/a63edc53397e62b24240e474f2ee883aa1309d89))
- Added Synthetic Monitor targets to Uptime data model ([commit 4b7d6bc](https://github.com/googleapis/google-cloud-dotnet/commit/4b7d6bc8c0fec524dae47dd164c91d85b29a03b2))
- Added ServiceAgentAuthentication auth method for Uptime ([commit 4b7d6bc](https://github.com/googleapis/google-cloud-dotnet/commit/4b7d6bc8c0fec524dae47dd164c91d85b29a03b2))

### Documentation improvements

- Updated comments accordingly ([commit a63edc5](https://github.com/googleapis/google-cloud-dotnet/commit/a63edc53397e62b24240e474f2ee883aa1309d89))
- Updated comments accordingly ([commit 4b7d6bc](https://github.com/googleapis/google-cloud-dotnet/commit/4b7d6bc8c0fec524dae47dd164c91d85b29a03b2))
- Various updates ([commit dfa71a3](https://github.com/googleapis/google-cloud-dotnet/commit/dfa71a3129299e055d65da1badea1028f4144506))

## Version 3.7.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 3.6.0, released 2024-02-28

No API surface changes; just dependency updates.

## Version 3.5.0, released 2024-01-08

### New features

- Added support for severity in AlertPolicy ([commit cbde75b](https://github.com/googleapis/google-cloud-dotnet/commit/cbde75b40a9be197dff4d39a9f7a1b6876936bc6))

### Documentation improvements

- Add value range to comment on field forecast_horizon ([commit cbde75b](https://github.com/googleapis/google-cloud-dotnet/commit/cbde75b40a9be197dff4d39a9f7a1b6876936bc6))

## Version 3.4.0, released 2023-09-18

### New features

- Added support for retriggering notifications in AlertPolicy ([commit f2d8855](https://github.com/googleapis/google-cloud-dotnet/commit/f2d8855accef7c793dfec45ad7c86db005224993))
- Added support for forecast options in AlertPolicy ([commit f2d8855](https://github.com/googleapis/google-cloud-dotnet/commit/f2d8855accef7c793dfec45ad7c86db005224993))
- Added support for promQL condition type in AlertPolicy ([commit f2d8855](https://github.com/googleapis/google-cloud-dotnet/commit/f2d8855accef7c793dfec45ad7c86db005224993))

## Version 3.3.0, released 2023-05-11

### New features

- Add ICMP pings ([commit d4e696b](https://github.com/googleapis/google-cloud-dotnet/commit/d4e696b126046a162870fabb092118fa58ed3b86))
- Add basic http authentication ([commit d4e696b](https://github.com/googleapis/google-cloud-dotnet/commit/d4e696b126046a162870fabb092118fa58ed3b86))
- Add json path matching capabilities ([commit d4e696b](https://github.com/googleapis/google-cloud-dotnet/commit/d4e696b126046a162870fabb092118fa58ed3b86))
- Add httpStatusCode ([commit d4e696b](https://github.com/googleapis/google-cloud-dotnet/commit/d4e696b126046a162870fabb092118fa58ed3b86))
- Add individual USA regions ([commit d4e696b](https://github.com/googleapis/google-cloud-dotnet/commit/d4e696b126046a162870fabb092118fa58ed3b86))

## Version 3.2.0, released 2023-01-16

### New features

- Added Snooze API support ([commit e68a83e](https://github.com/googleapis/google-cloud-dotnet/commit/e68a83ef1b5633f4ebe196bbdb0f7efdc5b751c8))

## Version 3.1.0, released 2022-08-26

### New features

- Added support for evaluating missing data in AlertPolicy ([commit ed778dd](https://github.com/googleapis/google-cloud-dotnet/commit/ed778dddb80267c3d3ffad3905dcc6f808ebcb07))

## Version 3.0.0, released 2022-06-08

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


## Version 2.6.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 2.5.0, released 2021-11-18

- [Commit b8a8fbd](https://github.com/googleapis/google-cloud-dotnet/commit/b8a8fbd): feat: Added support for auto-close configurations

## Version 2.4.0, released 2021-10-14

- [Commit 556147f](https://github.com/googleapis/google-cloud-dotnet/commit/556147f):
  - fix: Reintroduce deprecated field/enum for backward compatibility
  - docs: Use absolute link targets in comments
- [Commit 4a255f9](https://github.com/googleapis/google-cloud-dotnet/commit/4a255f9): docs: fix typo in alert.proto
- [Commit 3450957](https://github.com/googleapis/google-cloud-dotnet/commit/3450957): feat: add CreateServiceTimeSeries RPC
- [Commit e724d81](https://github.com/googleapis/google-cloud-dotnet/commit/e724d81):
  - feat: Added support for logs-based alerts: https://cloud.google.com/logging/docs/alerting/log-based-alerts
  - feat: Added support for user-defined labels on cloud monitoring's Service and ServiceLevelObjective objects
  - fix!: mark required fields in QueryTimeSeriesRequest as required
- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.3.0, released 2021-04-29

- [Commit 770bd47](https://github.com/googleapis/google-cloud-dotnet/commit/770bd47):
  - feat: Added support for Monitoring Query Language: https://cloud.google.com/monitoring/mql
  - feat: Added support for units in the MetricService feat: Added total_size to the response of ListAlertPolicies.
  - fix: Un-deprecated cluster_istio for service monitoring.
  - feat: Added IstioCanonicalService for service monitoring.
  - feat: Added creation and mutation records to notification channels.
  - feat: Added support for querying metrics for folders and organizations.
  - fix: Extended the default deadline for UpdateGroup to 180s.
  - feat: Added support for secondary aggregation when querying metrics.

## Version 2.2.0, released 2020-10-22

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry

## Version 2.1.0, released 2020-06-15

- [Commit 4389faa](https://github.com/googleapis/google-cloud-dotnet/commit/4389faa): docs: Change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

(No API surface changes relative to 2.1.0-beta01.)

## Version 2.1.0-beta01, released 2020-05-06

- [Commit 9c1f9d6](https://github.com/googleapis/google-cloud-dotnet/commit/9c1f9d6):
  - feat: Update public client library for Cloud Monitoring to introduce new Uptime check feature.
  - feat: Uptime HTTP(S) checks can now be GET or POST.
- [Commit 6ca5e50](https://github.com/googleapis/google-cloud-dotnet/commit/6ca5e50):
  - docs: Increase the required minimum difference between start time of the next interval
    and the end time of the previous one from the one microsecond to one millisecond.
    This will enable some resource savings for in-memory storage.

## Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.2.0, released 2019-12-10

- [Commit 1258244](https://github.com/googleapis/google-cloud-dotnet/commit/1258244): Multiple new features, including a new service (ServiceMonitoringService).
- [Commit 84915b4](https://github.com/googleapis/google-cloud-dotnet/commit/84915b4): Additions:
  - AlertPolicy.Validity
  - DeleteGroupRequest.Recursive
  - GroupServiceClient.ListGroups
  - GroupServiceClient.ListGroupsAsync
  - InternalChecker.Types.State
  - UptimeCheckConfig.Types.ContentMatcher
  - UptimeCheckConfig.Types.HttpCheck
  - UptimeCheckConfig.IsInternal is now deprecated.
- [Commit e5b2e69](https://github.com/googleapis/google-cloud-dotnet/commit/e5b2e69): Adds support for verifying notification channels
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add format methods for all resource name types

## Version 1.1.0, released 2019-07-10

New RPCs, with supporting classes and properties:

- Create/Delete/Get/List/Update for alert policies
- Create/Delete/Get/List/Update for notification channels
- Create/Delete/Get/List/Update for uptime check configs
- ListUptimeCheckIps
- ListNotificationChannelDescriptors

Additionally, there are new overloads due to code generator updates.

## Version 1.0.0, released 2017-09-22

Initial GA release.
