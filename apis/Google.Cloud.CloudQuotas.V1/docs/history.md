# Version history

## Version 1.1.0, released 2024-11-18

### New features

- A new value `NOT_SUPPORTED` is added to enum `IneligibilityReason` ([commit 84c20bc](https://github.com/googleapis/google-cloud-dotnet/commit/84c20bc934998a46adec407c26d58734391cf8d0))
- A new value `NOT_ENOUGH_USAGE_HISTORY` is added to enum `IneligibilityReason` ([commit 84c20bc](https://github.com/googleapis/google-cloud-dotnet/commit/84c20bc934998a46adec407c26d58734391cf8d0))

## Version 1.0.0, released 2024-05-24

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta05, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta04, released 2024-04-19

### New features

- Add `rollout_info` field to `QuotaDetails` message ([commit 5148c08](https://github.com/googleapis/google-cloud-dotnet/commit/5148c089b407d0ac8e7e2bc2e0b4e73a7630ced8))

### Documentation improvements

- Update contact_email doc to not check permission of the email account ([commit 2f19379](https://github.com/googleapis/google-cloud-dotnet/commit/2f193795dd1daaba3ad6dd1f0f6b0c20c6597e6a))
- Update comment of `contact_email` to make it optional as opposed to required ([commit 61c3ef8](https://github.com/googleapis/google-cloud-dotnet/commit/61c3ef87fcac02762a218f56ab2a176f64be7d29))
- Update sample URL in field for `service_request_quota_uri` ([commit 61c3ef8](https://github.com/googleapis/google-cloud-dotnet/commit/61c3ef87fcac02762a218f56ab2a176f64be7d29))

## Version 1.0.0-beta03, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

### Documentation improvements

- Annotate QuotaPreference.dimensions field as immutable, annotate QuotaPreference.QuotaConfig.annotations field as optional ([commit afcf2a4](https://github.com/googleapis/google-cloud-dotnet/commit/afcf2a4837cc0b0adfb7602cbd3313677d8d52e5))
- A comment for field `filter` in message `.google.api.cloudquotas.v1.ListQuotaPreferencesRequest` is changed ([commit 0e2e456](https://github.com/googleapis/google-cloud-dotnet/commit/0e2e4568ea884b2ded993c26e1189185c0181344))
- A comment for field `order_by` in message `.google.api.cloudquotas.v1.ListQuotaPreferencesRequest` is changed ([commit 0e2e456](https://github.com/googleapis/google-cloud-dotnet/commit/0e2e4568ea884b2ded993c26e1189185c0181344))

## Version 1.0.0-beta02, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2024-01-02

Initial release.
