# Version history

## Version 2.1.0, released 2023-05-26

### New features

- Add support for placement policies ([commit 173ed3d](https://github.com/googleapis/google-cloud-dotnet/commit/173ed3d470c7276f6e839501b3e12aaee26e435c))
- Per-Runnable labels ([commit 173ed3d](https://github.com/googleapis/google-cloud-dotnet/commit/173ed3d470c7276f6e839501b3e12aaee26e435c))
- Support order_by in ListJobs and ListTasks requests ([commit 87c14ef](https://github.com/googleapis/google-cloud-dotnet/commit/87c14efeb50b793e80f7ad99b039c7cdd3118b9c))
- Add support for placement policies ([commit 87c14ef](https://github.com/googleapis/google-cloud-dotnet/commit/87c14efeb50b793e80f7ad99b039c7cdd3118b9c))
- Per-Runnable labels ([commit 87c14ef](https://github.com/googleapis/google-cloud-dotnet/commit/87c14efeb50b793e80f7ad99b039c7cdd3118b9c))
- Support order_by in ListJobs and ListTasks requests ([commit dd462ce](https://github.com/googleapis/google-cloud-dotnet/commit/dd462ceb1d2016e5ad339a675050ab00bd7fb1bf))
- Add support for placement policies ([commit dd462ce](https://github.com/googleapis/google-cloud-dotnet/commit/dd462ceb1d2016e5ad339a675050ab00bd7fb1bf))
- Per-Runnable labels ([commit dd462ce](https://github.com/googleapis/google-cloud-dotnet/commit/dd462ceb1d2016e5ad339a675050ab00bd7fb1bf))

## Version 2.0.0, released 2023-03-09

### BREAKING CHANGE

BatchServiceClient no longer exposes an IAMPolicyClient. This was
only exposed unintentionally, and has never worked. However, this is
still a breaking change as application code may have referred to it.

### New features

- Added StatusEvent.task_state ([commit 25463ba](https://github.com/googleapis/google-cloud-dotnet/commit/25463baadfe8e1c958371757fe800df85d9b8542))

### Documentation improvements

- Updated comments ([commit 25463ba](https://github.com/googleapis/google-cloud-dotnet/commit/25463baadfe8e1c958371757fe800df85d9b8542))

## Version 1.3.0, released 2023-02-08

### New features

- Support custom scopes for service account in v1 ([commit 60d746a](https://github.com/googleapis/google-cloud-dotnet/commit/60d746a3bab5e93c406cbd1472ee683a8db7862e))
- Add boot disk field in InstanceStatus ([commit 60d746a](https://github.com/googleapis/google-cloud-dotnet/commit/60d746a3bab5e93c406cbd1472ee683a8db7862e))
- Add boot disk and image source fields to v1 InstancePolicy ([commit 60d746a](https://github.com/googleapis/google-cloud-dotnet/commit/60d746a3bab5e93c406cbd1472ee683a8db7862e))

## Version 1.2.0, released 2023-01-11

### Bug fixes

- Remove unsupported HTTP bindings for IAMPolicy RPCs ([commit 9ca7a4b](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7a4b02bbfe33f395b3cdd7e5c09d723beb79e))

### New features

- Support secret and encrypted environment variables in v1 ([commit f527507](https://github.com/googleapis/google-cloud-dotnet/commit/f52750711320054e6d623eeb3423baa1694389b8))

### Documentation improvements

- Updated documentation for message NetworkInterface ([commit 7c2ce96](https://github.com/googleapis/google-cloud-dotnet/commit/7c2ce96828902581fc7c408628781bffb314230c))

## Version 1.2.0-beta01, released 2022-12-08

### New features

- Enable REST transport in selected APIs. Set GrpcAdapter=RestGrpcAdapter.Default in the client builder to use this transport ([commit 5008946](https://github.com/googleapis/google-cloud-dotnet/commit/500894667ba84ecc3d8e3e4ebc09ac0cd597100b))

## Version 1.1.0, released 2022-12-01

### New features

- Adds named reservation to InstancePolicy ([commit ad603eb](https://github.com/googleapis/google-cloud-dotnet/commit/ad603ebb64e723d32b64782ec8735cf3b7879a94))

### Documentation improvements

- Fix minor docstring formatting ([commit 48e5d7c](https://github.com/googleapis/google-cloud-dotnet/commit/48e5d7cf1e4e727fd1a0fd660d329408f0b5120d))
- Remove "not yet implemented" for Accelerator & Refine Volume API docs ([commit ad603eb](https://github.com/googleapis/google-cloud-dotnet/commit/ad603ebb64e723d32b64782ec8735cf3b7879a94))
- Update the job id format requirement ([commit ad603eb](https://github.com/googleapis/google-cloud-dotnet/commit/ad603ebb64e723d32b64782ec8735cf3b7879a94))
- Fix minor docstring formatting ([commit 2069ee9](https://github.com/googleapis/google-cloud-dotnet/commit/2069ee9c5a1c59e950b54e281d1e05c4a0060543))

## Version 1.0.0, released 2022-11-02

No API surface changes; just dependency updates and promotion to general availability.

## Version 1.0.0-beta03, released 2022-10-17

### New features

- Enable install_gpu_drivers flag in v1 proto ([commit 12c66f2](https://github.com/googleapis/google-cloud-dotnet/commit/12c66f2f8c16395132c5a19cb77616732876b8f6))

### Documentation improvements

- Refine GPU drivers installation proto description ([commit 12c66f2](https://github.com/googleapis/google-cloud-dotnet/commit/12c66f2f8c16395132c5a19cb77616732876b8f6))
- Refine comments for deprecated proto fields ([commit 12c66f2](https://github.com/googleapis/google-cloud-dotnet/commit/12c66f2f8c16395132c5a19cb77616732876b8f6))
- Update the API comments about the device_name ([commit 12c66f2](https://github.com/googleapis/google-cloud-dotnet/commit/12c66f2f8c16395132c5a19cb77616732876b8f6))

## Version 1.0.0-beta02, released 2022-08-26

### New features

- Environment variables, disk interfaces ([commit 29e77e1](https://github.com/googleapis/google-cloud-dotnet/commit/29e77e1674212f3d9014defa21a09d6f01a77b71))

## Version 1.0.0-beta01, released 2022-07-14

Initial release.
