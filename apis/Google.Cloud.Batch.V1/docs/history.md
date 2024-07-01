# Version history

## Version 2.11.0, released 2024-07-01

### New features

- Add a install_ops_agent field to InstancePolicyOrTemplate for Ops Agent support ([commit d8e69ab](https://github.com/googleapis/google-cloud-dotnet/commit/d8e69ab0b8dfe4d31a10f2ffbd197da1c7f4cee5))

### Documentation improvements

- Add instructions on how to configure cross-project pubsub publisher ([commit d8e69ab](https://github.com/googleapis/google-cloud-dotnet/commit/d8e69ab0b8dfe4d31a10f2ffbd197da1c7f4cee5))
- Document default disk type: pd-standard for non boot disk, pd-balanced for boot disk ([commit d8e69ab](https://github.com/googleapis/google-cloud-dotnet/commit/d8e69ab0b8dfe4d31a10f2ffbd197da1c7f4cee5))
- Update list of volume.mount_options field ([commit d8e69ab](https://github.com/googleapis/google-cloud-dotnet/commit/d8e69ab0b8dfe4d31a10f2ffbd197da1c7f4cee5))
- Update GCS description of volume.mount_options field ([commit d8e69ab](https://github.com/googleapis/google-cloud-dotnet/commit/d8e69ab0b8dfe4d31a10f2ffbd197da1c7f4cee5))
- Update links in the description of volume.mount_options field ([commit d8e69ab](https://github.com/googleapis/google-cloud-dotnet/commit/d8e69ab0b8dfe4d31a10f2ffbd197da1c7f4cee5))
- Documentation improvements ([commit 5d53acd](https://github.com/googleapis/google-cloud-dotnet/commit/5d53acd9466eb6fccc74f0d195bb0b5c23c4c6f9))
- Refine description for field `task_execution` ([commit 7115e29](https://github.com/googleapis/google-cloud-dotnet/commit/7115e2973ebcad9290fbb5748f12ac4f5c50eb11))

## Version 2.10.0, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Update description on allowed_locations in LocationPolicy field ([commit 28e0693](https://github.com/googleapis/google-cloud-dotnet/commit/28e0693f41c54d846e9bdfbfef31e22f8e48c106))
- Update comments on ServiceAccount email and scopes fields ([commit 64a9268](https://github.com/googleapis/google-cloud-dotnet/commit/64a92680f33d60e7d497c40090ffdf22cf72b3d3))
- State one Resource Allowance per region per project limitation on v1alpha ([commit 159689e](https://github.com/googleapis/google-cloud-dotnet/commit/159689eb0492be155a1a8400470c3e52d3cbb208))
- A comment for field `max_run_duration` in message `.google.cloud.batch.v1alpha.TaskSpec` and `.google.cloud.batch.v1.TaskSpec` is changed ([commit 159689e](https://github.com/googleapis/google-cloud-dotnet/commit/159689eb0492be155a1a8400470c3e52d3cbb208))
- Add non-negative restriction comment for usage_resource_allowance.spec.limit.limit exposed on v1alpha ([commit 159689e](https://github.com/googleapis/google-cloud-dotnet/commit/159689eb0492be155a1a8400470c3e52d3cbb208))

## Version 2.9.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.8.0, released 2024-02-28

### Documentation improvements

- Update description of Job uid field ([commit eaaff5e](https://github.com/googleapis/google-cloud-dotnet/commit/eaaff5e430e478452b5463f33b590209e944b7a7))
- Refine proto comment for run_as_non_root ([commit 354560a](https://github.com/googleapis/google-cloud-dotnet/commit/354560a797a3038d45cab928a5d4e8b0bd0cac91))
- Add caution messages for container runnable username and password fields ([commit 354560a](https://github.com/googleapis/google-cloud-dotnet/commit/354560a797a3038d45cab928a5d4e8b0bd0cac91))

## Version 2.7.0, released 2024-02-08

### New features

- Add `run_as_non_root` field to allow user's runnable be executed as non root ([commit 7529915](https://github.com/googleapis/google-cloud-dotnet/commit/7529915e746cb6831a93ae0b6ca7a2a929dab233))
- Add `tags` field in Job's AllocationPolicy field in v1 ([commit 7529915](https://github.com/googleapis/google-cloud-dotnet/commit/7529915e746cb6831a93ae0b6ca7a2a929dab233))
- Add Batch Image Streaming support for v1 ([commit 7529915](https://github.com/googleapis/google-cloud-dotnet/commit/7529915e746cb6831a93ae0b6ca7a2a929dab233))

### Documentation improvements

- Polish the field descriptions for enableImageStreaming and CloudLoggingOptions ([commit 7529915](https://github.com/googleapis/google-cloud-dotnet/commit/7529915e746cb6831a93ae0b6ca7a2a929dab233))

## Version 2.6.0, released 2023-12-05

### New features

- Add a CloudLoggingOption and use_generic_task_monitored_resource fields for users to opt out new batch monitored resource in cloud logging ([commit 838c6df](https://github.com/googleapis/google-cloud-dotnet/commit/838c6df45974d62021bb93080696f7f7c38d104a))

### Documentation improvements

- Update comment for AllocationPolicy.network ([commit 838c6df](https://github.com/googleapis/google-cloud-dotnet/commit/838c6df45974d62021bb93080696f7f7c38d104a))
- Update default max parallel tasks per job ([commit 06a26bf](https://github.com/googleapis/google-cloud-dotnet/commit/06a26bfa140a0a01373ddc4fbc8fc9d0815cad1f))

## Version 2.5.0, released 2023-10-30

### New features

- Expose display_name to batch v1 API ([commit 86e0579](https://github.com/googleapis/google-cloud-dotnet/commit/86e05791a54db2eb17b2ffc3df5b6798dad19346))
- Add InstancePolicy.reservation field for restricting jobs to a specific reservation ([commit 10652c4](https://github.com/googleapis/google-cloud-dotnet/commit/10652c4c689519e9441ea1afce46fbd07c81c456))

### Documentation improvements

- Elaborate the usage of Container.volumes proto field ([commit 10652c4](https://github.com/googleapis/google-cloud-dotnet/commit/10652c4c689519e9441ea1afce46fbd07c81c456))
- Update batch PD interface support ([commit 0ab1964](https://github.com/googleapis/google-cloud-dotnet/commit/0ab196479719787fdec7819d6e621171bb108027))
- Update description on size_gb in disk field ([commit d78ee5c](https://github.com/googleapis/google-cloud-dotnet/commit/d78ee5ccdfa976242867f5c6d48d47119a648f46))
- Revert HTML formats in comments ([commit 0700ba4](https://github.com/googleapis/google-cloud-dotnet/commit/0700ba4b0f246ae6622cf8249eecbbc3ecf13495))
- Expand compute resource API docs to match with VM's machine type field ([commit 0700ba4](https://github.com/googleapis/google-cloud-dotnet/commit/0700ba4b0f246ae6622cf8249eecbbc3ecf13495))
- Clarify Batch API proto doc about pubsub notifications ([commit 0700ba4](https://github.com/googleapis/google-cloud-dotnet/commit/0700ba4b0f246ae6622cf8249eecbbc3ecf13495))

## Version 2.4.0, released 2023-08-16

### New features

- Clarify Batch API proto doc about pubsub notifications ([commit 0d8755a](https://github.com/googleapis/google-cloud-dotnet/commit/0d8755a21bdbc85c29f8af5cfdc5ad60b91f67df))
- Add Batch Managed Container support for v1alpha ([commit 0d8755a](https://github.com/googleapis/google-cloud-dotnet/commit/0d8755a21bdbc85c29f8af5cfdc5ad60b91f67df))

## Version 2.3.0, released 2023-08-04

### New features

- Add comment to the unsupported order_by field of ListTasksRequest ([commit 036fc52](https://github.com/googleapis/google-cloud-dotnet/commit/036fc5238c20c5a7e6cf6ff2f428548bccbe432c))
- Enable gpu driver version field on v1 ([commit 036fc52](https://github.com/googleapis/google-cloud-dotnet/commit/036fc5238c20c5a7e6cf6ff2f428548bccbe432c))
- Allow order_by for v1 ListJobs ([commit 036fc52](https://github.com/googleapis/google-cloud-dotnet/commit/036fc5238c20c5a7e6cf6ff2f428548bccbe432c))
- Improve url examples formats on Batch API comments ([commit 036fc52](https://github.com/googleapis/google-cloud-dotnet/commit/036fc5238c20c5a7e6cf6ff2f428548bccbe432c))

### Documentation improvements

- Add image shortcut example for Batch HPC CentOS Image ([commit 9b54ce0](https://github.com/googleapis/google-cloud-dotnet/commit/9b54ce00cd23033e05278b9bf5a03b2e516bd95c))

## Version 2.2.0, released 2023-06-20

### New features

- Add support for scheduling_policy ([commit 051cc0d](https://github.com/googleapis/google-cloud-dotnet/commit/051cc0dacb387fe65863e9c94ec4afaf27733539))

### Documentation improvements

- Minor clarifications for TaskGroup and min_cpu_platform ([commit 051cc0d](https://github.com/googleapis/google-cloud-dotnet/commit/051cc0dacb387fe65863e9c94ec4afaf27733539))

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
