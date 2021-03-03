# Version history

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
