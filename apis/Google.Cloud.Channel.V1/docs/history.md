# Version history

# Version 1.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

# Version 1.2.0, released 2021-06-22

- [Commit 01c154e](https://github.com/googleapis/google-cloud-dotnet/commit/01c154e):
  - feat: Add/Update API definitions for Cloud Channel API, including
  - * Update descriptions of APIs.
  - * Add additional_bindings to HTTP annotations of Customer related APIs (list/create/get/update/delete).
  - * Add a new LookupOffer RPC and LookupOfferRequest proto.
  - * Add a new enum value LICENSE_CAP_CHANGED to enum EntitlementEvent.Type.

# Version 1.1.0, released 2021-04-29

- [Commit 8f5a62b](https://github.com/googleapis/google-cloud-dotnet/commit/8f5a62b):
  - docs: Update documentation comments to match tone and style with the rest of Cloud documentation.
  - feat: Adding customer level pubsub events for primary domain verification and primary domain change.
  - feat: Enabled support for boolean as an allowed parameter value.
  - feat: Added legacy_sku field to TransferableSku.

# Version 1.0.0, released 2021-03-03

- [Commit 1620a3a](https://github.com/googleapis/google-cloud-dotnet/commit/1620a3a):
  - feat: addition of billing_account field on Plan
  - docs: clarification that valid address lines are required for all customers
- [Commit f2fdc8f](https://github.com/googleapis/google-cloud-dotnet/commit/f2fdc8f):
  - docs: Documentation update
  - fix!: Removal of TransferableSkus fields `is_commitment` and `commitment_end_timestamp`
- [Commit 59e5691](https://github.com/googleapis/google-cloud-dotnet/commit/59e5691): feat: Add Pub/Sub endpoints for Cloud Channel API.

The breaking change to TransferableSkus was due to the fields having
accidentally been included despite deprecation in previews.

# Version 1.0.0-beta01, released 2021-01-13

Initial release.
