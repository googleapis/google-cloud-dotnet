# Version history

# Version 2.1.0-beta01, released 2020-05-06

- [Commit 9c1f9d6](https://github.com/googleapis/google-cloud-dotnet/commit/9c1f9d6):
  - feat: Update public client library for Cloud Monitoring to introduce new Uptime check feature.
  - feat: Uptime HTTP(S) checks can now be GET or POST.
- [Commit 6ca5e50](https://github.com/googleapis/google-cloud-dotnet/commit/6ca5e50):
  - docs: Increase the required minimum difference between start time of the next interval
    and the end time of the previous one from the one microsecond to one millisecond.
    This will enable some resource savings for in-memory storage.

# Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

# Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://googleapis.github.io/google-cloud-dotnet/docs/guides/breaking-gax2.html)
for details of changes to both GAX and code generation.

# Version 1.2.0, released 2019-12-10

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

# Version 1.1.0, released 2019-07-10

New RPCs, with supporting classes and properties:

- Create/Delete/Get/List/Update for alert policies
- Create/Delete/Get/List/Update for notification channels
- Create/Delete/Get/List/Update for uptime check configs
- ListUptimeCheckIps
- ListNotificationChannelDescriptors

Additionally, there are new overloads due to code generator updates.

# Version 1.0.0, released 2017-09-22

Initial GA release.
