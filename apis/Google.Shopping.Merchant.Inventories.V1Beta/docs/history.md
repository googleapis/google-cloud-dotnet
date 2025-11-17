# Version history

## Version 1.0.0-beta08, released 2025-11-17

### New features

- Added the `product_id_base64_url_encoded` field to `ListLocalInventoriesRequest`, `InsertLocalInventoryRequest`, `DeleteLocalInventoryRequest`, `ListRegionalInventoriesRequest`, `InsertRegionalInventoryRequest`, and `DeleteRegionalInventoryRequest`. This allows for product IDs containing special characters to be correctly handled when base64url-encoded
- Added C#, PHP, and Ruby namespace options to LocalInventory and RegionalInventory proto files for improved client library generation

### Documentation improvements

- Updated the API summary and overview in the service configuration

## Version 1.0.0-beta07, released 2025-11-06

### New features

- Update dependencies

### Documentation improvements

- Change in wording : feed specification -> data specification
- A comment for message `LocalInventory` is changed
- A comment for field `store_code` in message `.google.shopping.merchant.inventories.v1beta.LocalInventory` is changed
- A comment for field `availability` in message `.google.shopping.merchant.inventories.v1beta.LocalInventory` is changed
- A comment for field `pickup_method` in message `.google.shopping.merchant.inventories.v1beta.LocalInventory` is changed
- A comment for field `pickup_sla` in message `.google.shopping.merchant.inventories.v1beta.LocalInventory` is changed
- A comment for field `custom_attributes` in message `.google.shopping.merchant.inventories.v1beta.LocalInventory` is changed
- A comment for message `RegionalInventory` is changed
- A comment for field `availability` in message `.google.shopping.merchant.inventories.v1beta.RegionalInventory` is changed
- A comment for field `custom_attributes` in message `.google.shopping.merchant.inventories.v1beta.RegionalInventory` is changed

## Version 1.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta05, released 2024-04-19

### New features

- Fix inventories sub-API publication by adding correct child_type in the API proto ([commit 012c5af](https://github.com/googleapis/google-cloud-dotnet/commit/012c5af36d1c7b91b0450989019937d4979c0c85))

### Documentation improvements

- A comment for field `store_code` in message `.google.shopping.merchant.inventories.v1beta.LocalInventory` is changed ([commit 012c5af](https://github.com/googleapis/google-cloud-dotnet/commit/012c5af36d1c7b91b0450989019937d4979c0c85))
- A comment for field `region` in message `.google.shopping.merchant.inventories.v1beta.RegionalInventory` is changed ([commit 012c5af](https://github.com/googleapis/google-cloud-dotnet/commit/012c5af36d1c7b91b0450989019937d4979c0c85))

## Version 1.0.0-beta04, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.0.0-beta03, released 2024-03-13

No API surface changes; just dependency updates.

## Version 1.0.0-beta02, released 2024-02-09

### New features

- Add session and session_template controllers ([commit 14d4f40](https://github.com/googleapis/google-cloud-dotnet/commit/14d4f40e57218134116f6d580ca726832d07d244))

## Version 1.0.0-beta01, released 2023-10-13

Initial release.
