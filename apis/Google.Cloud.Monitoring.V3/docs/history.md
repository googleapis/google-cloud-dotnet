# Version history

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
