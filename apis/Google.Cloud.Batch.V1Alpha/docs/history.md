# Version history

## Version 1.0.0-alpha14, released 2023-08-04

### New features

- Enable gpu driver version field on v1 ([commit 08fd6c5](https://github.com/googleapis/google-cloud-dotnet/commit/08fd6c54e8590932815a9afac40513afd68133aa))

### Documentation improvements

- Mark `order_by` field in `ListTasksRequest` as not implemented. ([commit 08fd6c5](https://github.com/googleapis/google-cloud-dotnet/commit/08fd6c54e8590932815a9afac40513afd68133aa))
- Improve url examples in comments ([commit 08fd6c5](https://github.com/googleapis/google-cloud-dotnet/commit/08fd6c54e8590932815a9afac40513afd68133aa))

## Version 1.0.0-alpha13, released 2023-07-13

### New features

- Add gpu driver version field ([commit 2836b1b](https://github.com/googleapis/google-cloud-dotnet/commit/2836b1b93c7aa7ed870d80aab7ff1e1070dab771))

### Documentation improvements

- Add image shortcut example for Batch HPC CentOS Image ([commit 2836b1b](https://github.com/googleapis/google-cloud-dotnet/commit/2836b1b93c7aa7ed870d80aab7ff1e1070dab771))

## Version 1.0.0-alpha12, released 2023-06-20

### New features

- Implement minCpuPlatform ([commit 6fcb3d6](https://github.com/googleapis/google-cloud-dotnet/commit/6fcb3d6168fd713196ffaf82a16af61684111e2e))
- Enable scheduling_policy in v1 ([commit 6fcb3d6](https://github.com/googleapis/google-cloud-dotnet/commit/6fcb3d6168fd713196ffaf82a16af61684111e2e))
- Update TaskGroup doc ([commit 6fcb3d6](https://github.com/googleapis/google-cloud-dotnet/commit/6fcb3d6168fd713196ffaf82a16af61684111e2e))

## Version 1.0.0-alpha11, released 2023-05-26

### Bug fixes

- Override HTTP URLs for LRO cancel/delete operations ([commit 82d9df4](https://github.com/googleapis/google-cloud-dotnet/commit/82d9df47ef8c379a593be70dd07749aa46775d41))

### New features

- Support order_by in ListJobs and ListTasks requests ([issue 21](https://github.com/googleapis/google-cloud-dotnet/issues/21)) ([commit 2890c2a](https://github.com/googleapis/google-cloud-dotnet/commit/2890c2a8b3e963bf5172dca1ee6dbf17b5f02ded))

## Version 1.0.0-alpha10, released 2023-04-19

### New features

- Add TaskStatus's new terminated state UNEXECUTED ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))
- Add scheduling_policy IN_ORDER enum to support sequential task executions ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))
- Add support for placement policies ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))

### Documentation improvements

- Update comments on boot disk fields for clearer usage scope ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))
- Update block_external_network field comment to reduce confusion ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))
- Update disk and network field comment for better readability ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))
- Fix `book disk` typo ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))
- Update reservation field API doc ([commit c721955](https://github.com/googleapis/google-cloud-dotnet/commit/c72195511d02ef07dbc8452d94c85dd4c5153e23))

## Version 1.0.0-alpha09, released 2023-03-09

### BREAKING CHANGE

`BatchServiceClient` no longer exposes an `IAMPolicyClient`. This
was only exposed unintentionally, and has never worked. However, this
is still a breaking change as application code may have referred to
it.

### New features

- Resource usage ([commit 80fe952](https://github.com/googleapis/google-cloud-dotnet/commit/80fe952729cd338837f752fefe7f94a0573b5368))

### Documentation improvements

- Update comments ([commit 80fe952](https://github.com/googleapis/google-cloud-dotnet/commit/80fe952729cd338837f752fefe7f94a0573b5368))

## Version 1.0.0-alpha08, released 2023-02-08

### New features

- Support custom scopes for service account in v1 ([commit 7e2eb5a](https://github.com/googleapis/google-cloud-dotnet/commit/7e2eb5adbec7505d9f4fd5c7cd1b3a458436bd8e))
- Add boot disk field in InstanceStatus ([commit 7e2eb5a](https://github.com/googleapis/google-cloud-dotnet/commit/7e2eb5adbec7505d9f4fd5c7cd1b3a458436bd8e))
- Add boot disk and image source fields to v1 InstancePolicy ([commit 7e2eb5a](https://github.com/googleapis/google-cloud-dotnet/commit/7e2eb5adbec7505d9f4fd5c7cd1b3a458436bd8e))

## Version 1.0.0-alpha07, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 1.0.0-alpha06, released 2023-01-16

### Bug fixes

- ServiceAccount.scopes is no longer deprecated ([commit d15829b](https://github.com/googleapis/google-cloud-dotnet/commit/d15829bc37938440697302acc3ffc0816da8b6be))
- Removed unused endpoints for IAM methods ([commit d15829b](https://github.com/googleapis/google-cloud-dotnet/commit/d15829bc37938440697302acc3ffc0816da8b6be))

### New features

- Add InstancePolicy.boot_disk ([commit d15829b](https://github.com/googleapis/google-cloud-dotnet/commit/d15829bc37938440697302acc3ffc0816da8b6be))

### Documentation improvements

- Updated documentation for message NetworkInterface ([commit acb6f8f](https://github.com/googleapis/google-cloud-dotnet/commit/acb6f8f8618ee8eb33249e09fd3edc84665c4c6b))

## Version 1.0.0-alpha05, released 2022-12-01

### New features

- Adds named reservation to InstancePolicy ([commit 9072a1f](https://github.com/googleapis/google-cloud-dotnet/commit/9072a1f083e83eea71bb5166d4691a19a7c29b0d))

### Documentation improvements

- Fix minor docstring formatting ([commit 96622fc](https://github.com/googleapis/google-cloud-dotnet/commit/96622fcf0eeec2941b5600260929d1dc74b66da3))
- Remove "not yet implemented" for Accelerator & Refine Volume API docs ([commit 9072a1f](https://github.com/googleapis/google-cloud-dotnet/commit/9072a1f083e83eea71bb5166d4691a19a7c29b0d))
- Update the job id format requirement ([commit 9072a1f](https://github.com/googleapis/google-cloud-dotnet/commit/9072a1f083e83eea71bb5166d4691a19a7c29b0d))
- Fix minor docstring formatting ([commit c976c7c](https://github.com/googleapis/google-cloud-dotnet/commit/c976c7c8ff231d32ce6a3b9acc921973b046d3b3))

## Version 1.0.0-alpha04, released 2022-10-17

### Documentation improvements

- Refine GPU drivers installation proto description ([commit 3fb17e8](https://github.com/googleapis/google-cloud-dotnet/commit/3fb17e810002de1d4def0e7baa6e4a45627e8825))
- Refine comments for deprecated proto fields ([commit 3fb17e8](https://github.com/googleapis/google-cloud-dotnet/commit/3fb17e810002de1d4def0e7baa6e4a45627e8825))
- Update the API comments about the device_name ([commit 3fb17e8](https://github.com/googleapis/google-cloud-dotnet/commit/3fb17e810002de1d4def0e7baa6e4a45627e8825))

## Version 1.0.0-alpha03, released 2022-09-05

### Bug fixes

- Mark service_account_email as deprecated ([commit 28348ae](https://github.com/googleapis/google-cloud-dotnet/commit/28348ae1f06940c5c6ac8ee7403e537b2af1ec12))

### Documentation improvements

- Removing comment from a deprecated field ([commit 28348ae](https://github.com/googleapis/google-cloud-dotnet/commit/28348ae1f06940c5c6ac8ee7403e537b2af1ec12))

## Version 1.0.0-alpha02, released 2022-08-26

### New features

- Environment variables, disk interfaces ([commit 981712a](https://github.com/googleapis/google-cloud-dotnet/commit/981712aa64d58976849def0a726e4917a65b3b22))
## Version 1.0.0-alpha01, released 2022-07-14

No API surface changes; just dependency updates.

## Version 1.0.0-alpha00, released 2022-06-24

Initial release.

