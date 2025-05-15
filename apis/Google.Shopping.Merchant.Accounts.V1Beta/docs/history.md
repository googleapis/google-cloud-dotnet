# Version history

## Version 1.0.0-beta06, released 2025-05-15

### New features

- Updated comments for returns sub-API publication

### Documentation improvements

- A comment for service `OnlineReturnPolicyService` is changed
- A comment for method `GetOnlineReturnPolicy` in service `OnlineReturnPolicyService` is changed
- A comment for method `ListOnlineReturnPolicies` in service `OnlineReturnPolicyService` is changed
- A comment for field `parent` in message `.google.shopping.merchant.accounts.v1beta.ListOnlineReturnPoliciesRequest` is changed
- A comment for field `policy` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is changed
- A comment for field `restocking_fee` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is changed
- A comment for field `return_methods` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is changed
- A comment for field `item_conditions` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is changed
- A comment for field `return_shipping_fee` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is changed

## Version 1.0.0-beta05, released 2025-03-17

### New features

- Add AutomaticImprovements service ([commit b5adb03](https://github.com/googleapis/google-cloud-dotnet/commit/b5adb03d690e0b2ab64c80c2bbc2df993c5ec9a2))

## Version 1.0.0-beta04, released 2025-03-10

### Bug fixes

- **BREAKING CHANGE** An existing optional field `type` is converted to required field in message .google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- **BREAKING CHANGE** An existing optional field `label` is converted to required field in message .google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- **BREAKING CHANGE** An existing optional field `countries` is converted to required field in message .google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- **BREAKING CHANGE** An existing optional field `return_policy_uri` is converted to required field in message .google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))

### New features

- A new message `SeasonalOverride` is added ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- A new field `seasonal_overrides` is added to message .google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))

### Documentation improvements

- The documentation for method `GetOnlineReturnPolicy` in service `OnlineReturnPolicyService` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- The documentation for method `ListOnlineReturnPolicies` in service `OnlineReturnPolicyService` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- The documentation for field `parent` in message `.google.shopping.merchant.accounts.v1beta.ListOnlineReturnPoliciesRequest` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- The documentation for field `type` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- The documentation for field `label` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- The documentation for field `countries` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))
- The documentation for field `return_policy_uri` in message `.google.shopping.merchant.accounts.v1beta.OnlineReturnPolicy` is improved ([commit 0ce5f8b](https://github.com/googleapis/google-cloud-dotnet/commit/0ce5f8bd4f7da0218f84246e78573332265feb80))

## Version 1.0.0-beta03, released 2024-09-30

### New features

- Add 'force' parameter for accounts.delete method ([commit a0d5d82](https://github.com/googleapis/google-cloud-dotnet/commit/a0d5d829b426a3a472c6d47116c200664d743600))

### Documentation improvements

- Updated descriptions for the DeleteAccount and ListAccounts RPCs ([commit a0d5d82](https://github.com/googleapis/google-cloud-dotnet/commit/a0d5d829b426a3a472c6d47116c200664d743600))

## Version 1.0.0-beta02, released 2024-09-26

### Bug fixes

- **BREAKING CHANGE** The type of an existing field `time_zone` is changed from `message` to `string` in message `.google.shopping.merchant.accounts.v1beta.ListAccountIssuesRequest` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- **BREAKING CHANGE** An existing field `account_aggregation` is removed from message `.google.shopping.merchant.accounts.v1beta.CreateAndConfigureAccountRequest` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- **BREAKING CHANGE** Changed field behavior for an existing field `service` in message `.google.shopping.merchant.accounts.v1beta.CreateAndConfigureAccountRequest` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- **BREAKING CHANGE** Changed field behavior for an existing field `region_code` in message `.google.shopping.merchant.accounts.v1beta.RetrieveLatestTermsOfServiceRequest` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- **BREAKING CHANGE** Changed field behavior for an existing field `kind` in message `.google.shopping.merchant.accounts.v1beta.RetrieveLatestTermsOfServiceRequest` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))

### New features

- A new field `account_aggregation` is added to message `.google.shopping.merchant.accounts.v1beta.CreateAndConfigureAccountRequest` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new message `AccountAggregation` is added ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new service `AutofeedSettingsService` is added ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new message `AutofeedSettings` is added ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new resource_definition `merchantapi.googleapis.com/AutofeedSettings` is added ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new message `GetAutofeedSettingsRequest` is added ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new message `UpdateAutofeedSettingsRequest` is added ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))
- A new field `korean_business_registration_number` is added to message `.google.shopping.merchant.accounts.v1beta.BusinessInfo` ([commit 6cfb1ff](https://github.com/googleapis/google-cloud-dotnet/commit/6cfb1ffdc3b8d3abd2853c589949be9cf1f31caa))

## Version 1.0.0-beta01, released 2024-06-13

Initial release.
