# Version history

## Version 2.8.0, released 2025-04-14

### New features

- Identity-aware Proxy (IAP) released a feature `Use IAP with Workforce Identity Federation`(https://cloud.google.com/iap/docs/use-workforce-identity-federation) at Feb 7, 2025. Two settings field are newly introduced in the feature release: `workforce_identity_settings` and `identity_sources` ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))

### Documentation improvements

- A comment for field `name` in message `.google.cloud.iap.v1.TunnelDestGroup` is changed ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- A comment for field `cidrs` in message `.google.cloud.iap.v1.TunnelDestGroup` is changed ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- A comment for field `fqdns` in message `.google.cloud.iap.v1.TunnelDestGroup` is changed ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `access_settings` in message `.google.cloud.iap.v1.IapSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `application_settings` in message `.google.cloud.iap.v1.IapSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `gcip_settings` in message `.google.cloud.iap.v1.AccessSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `cors_settings` in message `.google.cloud.iap.v1.AccessSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `oauth_settings` in message `.google.cloud.iap.v1.AccessSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `reauth_settings` in message `.google.cloud.iap.v1.AccessSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `allowed_domains_settings` in message `.google.cloud.iap.v1.AccessSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `tenant_ids` in message `.google.cloud.iap.v1.GcipSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `programmatic_clients` in message `.google.cloud.iap.v1.OAuthSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- A comment for enum `PolicyType` is changed ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `method` in message `.google.cloud.iap.v1.ReauthSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `max_age` in message `.google.cloud.iap.v1.ReauthSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `policy_type` in message `.google.cloud.iap.v1.ReauthSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `enable` in message `.google.cloud.iap.v1.AllowedDomainsSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `domains` in message `.google.cloud.iap.v1.AllowedDomainsSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `csm_settings` in message `.google.cloud.iap.v1.ApplicationSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `access_denied_page_settings` in message `.google.cloud.iap.v1.ApplicationSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `attribute_propagation_settings` in message `.google.cloud.iap.v1.ApplicationSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `expression` in message `.google.cloud.iap.v1.AttributePropagationSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `output_credentials` in message `.google.cloud.iap.v1.AttributePropagationSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))
- Mark `enable` in message `.google.cloud.iap.v1.AttributePropagationSettings` as optional ([commit 176a5d4](https://github.com/googleapis/google-cloud-dotnet/commit/176a5d4219c80331664486163755841f86f98cb7))

## Version 2.7.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.6.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 2.5.0, released 2024-02-28

### Documentation improvements

- Fixing Oauth typo ([commit 50dce7e](https://github.com/googleapis/google-cloud-dotnet/commit/50dce7e87a926b0773a3f3a13117f17976b7202f))

## Version 2.4.0, released 2023-09-18

### New features

- Adding programmatic_clients attribute to UpdateIapSettings API request ([commit 31934fa](https://github.com/googleapis/google-cloud-dotnet/commit/31934fa84d842b659d6dd2c67723e5a477f5b5a6))

### Documentation improvements

- Few minor changes on doc description came out of cl/512701532 ([commit 48f33ea](https://github.com/googleapis/google-cloud-dotnet/commit/48f33ea923ee67bfe04181855670e8698940d6b7))

## Version 2.3.0, released 2023-03-20

### New features

- Add an enum ENROLLED_SECOND_FACTORS under IapSettings ([commit 3c3f7f6](https://github.com/googleapis/google-cloud-dotnet/commit/3c3f7f69e1672490a1305e99c1deca4233a5fbb8))

### Documentation improvements

- Update doc description for field_mask ([commit 3c3f7f6](https://github.com/googleapis/google-cloud-dotnet/commit/3c3f7f69e1672490a1305e99c1deca4233a5fbb8))

## Version 2.2.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 31e55cd](https://github.com/googleapis/google-cloud-dotnet/commit/31e55cdbafe12bfae68e28a75a1b75ceb445684f))

## Version 2.1.0, released 2023-01-16

### New features

- Add AllowedDomainSettings to the UpdateIapSettingsRequest ([commit 5b5c678](https://github.com/googleapis/google-cloud-dotnet/commit/5b5c678d67d38c53653a33e981a7f438f1278aa3))
- Add AttributePropagationSettings to the UpdateIapSettingsRequest ([commit 5b5c678](https://github.com/googleapis/google-cloud-dotnet/commit/5b5c678d67d38c53653a33e981a7f438f1278aa3))
- Add remediation_token_generation_enabled to the CsmSettings ([commit 5b5c678](https://github.com/googleapis/google-cloud-dotnet/commit/5b5c678d67d38c53653a33e981a7f438f1278aa3))

## Version 2.0.0, released 2022-06-08

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


## Version 1.2.0, released 2022-05-24

### New features

- Add the TunnelDestGroup-related methods and types ([commit 307ef07](https://github.com/googleapis/google-cloud-dotnet/commit/307ef071ed89aac467dbe3aaf1142e953237dec0))
- Add ReauthSettings to the UpdateIapSettingsRequest ([commit 307ef07](https://github.com/googleapis/google-cloud-dotnet/commit/307ef071ed89aac467dbe3aaf1142e953237dec0))

## Version 1.1.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-07-19

No API surface changes; just promotion to GA.

## Version 1.0.0-beta01, released 2021-06-29

Initial release.
