# Version history

## Version 1.0.0-beta04, released 2026-05-29

### New features

- A new value `STRUCT` is added to enum `Type`
- A new value `LIST` is added to enum `Type`
- A new value `TYPE_WORKLOAD_SUCCEEDED` is added to enum `Type`
- A new message `SaasCondition` is added
- A new enum `State` is added
- A new field `application_template` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Saas`
- A new field `blueprint_repo` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Saas`
- A new field `state` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Saas`
- A new field `conditions` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Saas`
- A new field `error` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Saas`
- A new field `application_template_component` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.UnitKind`
- A new field `app_params` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.UnitKind`
- A new field `application` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Unit`
- A new field `satisfies_pzs` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Unit`
- A new field `satisfies_pzi` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Unit`
- A new field `delete_time` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.UnitOperation`
- A new field `application_template_component` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Release`
- A new message `CompositeRef` is added
- A new message `ComponentRef` is added
- A new message `AppParams` is added
- A new field `effective_unit_filter` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Rollout`
- A new field `delete_time` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Rollout`
- A new field `estimated_total_unit_count` is added to message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.RolloutStats`

### Bug fixes

- Changed field behavior for an existing field `rollout_kind` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Rollout`
- Changed proto3 optional flag of an existing field `allowed_count` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.ErrorBudget`
- Changed proto3 optional flag of an existing field `allowed_percentage` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.ErrorBudget`

### Documentation improvements

- A comment for enum `Type` is changed
- A comment for message `UnitOperation` is changed
- A comment for field `rollout_orchestration_strategy` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Rollout` is changed
- A comment for field `unit_filter` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Rollout` is changed
- A comment for field `rollout_kind` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.Rollout` is changed
- A comment for field `operations_by_state` in message `.google.cloud.saasplatform.saasservicemgmt.v1beta1.RolloutStats` is changed
- Rebrand from "SaaS Runtime" to "App Lifecycle Manager"

## Version 1.0.0-beta03, released 2026-02-16

### New features

- Add AppHub related condition types to Deployment protos

## Version 1.0.0-beta02, released 2025-11-06

### New features

- Update dependencies

## Version 1.0.0-beta01, released 2025-08-12

### New features

- Initial generation for Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1

