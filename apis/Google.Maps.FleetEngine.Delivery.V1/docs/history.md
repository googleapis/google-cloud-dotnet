# Version history

## Version 2.3.0, released 2025-07-11

### New features

- Add ability to specify trip attributes to Trip and deprecate Trip.remaining_waypoints_version

## Version 2.2.0, released 2025-03-03

### New features

- Added Fleet Engine Delete APIs ([commit cac2084](https://github.com/googleapis/google-cloud-dotnet/commit/cac2084441145afce9db04966a108f3a058593ae))
- A new field `past_locations` is added to message `.maps.fleetengine.delivery.v1.DeliveryVehicle` ([commit a7863c7](https://github.com/googleapis/google-cloud-dotnet/commit/a7863c77477b062918f45c0928f453d24d42ff82))
- A new field `past_locations` is added to message `.maps.fleetengine.v1.Vehicle` ([commit a7863c7](https://github.com/googleapis/google-cloud-dotnet/commit/a7863c77477b062918f45c0928f453d24d42ff82))

### Documentation improvements

- Updated documentation for field `task` in message `.maps.fleetengine.delivery.v1.CreateTaskRequest` to clarify certain fields can be optionally set. ([commit a7863c7](https://github.com/googleapis/google-cloud-dotnet/commit/a7863c77477b062918f45c0928f453d24d42ff82))
- Update comment link for ListTasks filter ([commit 5970dc3](https://github.com/googleapis/google-cloud-dotnet/commit/5970dc352347ca721bb71a88cdc7b9f4f64c5d48))
- Document that delivery_vehicle.type can be set on CreateDeliveryVehicle ([commit 658fd07](https://github.com/googleapis/google-cloud-dotnet/commit/658fd07382a9af2e1a3a55e5c8fa75f955efe20b))
- Clarify behavior of UpdateDeliveryVehicle ([commit 4acca65](https://github.com/googleapis/google-cloud-dotnet/commit/4acca6552767fe47081ef563ac9c570a43970631))

## Version 2.1.0, released 2024-06-04

### Documentation improvements

- Remove comment about deleted SearchTasks method ([commit baba90c](https://github.com/googleapis/google-cloud-dotnet/commit/baba90cf3feb33c19c036e90ebc2066e9269add1))

## Version 2.0.0, released 2024-05-08

### Bug fixes

- **BREAKING CHANGE** An existing method `UpdateVehicleLocation` is removed from service `VehicleService` ([commit 496dd3b](https://github.com/googleapis/google-cloud-dotnet/commit/496dd3bcf1b991365da65af8d198622df23a4d46))
- **BREAKING CHANGE** An existing method `SearchFuzzedVehicles` is removed from service `VehicleService` ([commit 496dd3b](https://github.com/googleapis/google-cloud-dotnet/commit/496dd3bcf1b991365da65af8d198622df23a4d46))
- **BREAKING CHANGE** An existing message `UpdateVehicleLocationRequest` is removed ([commit 496dd3b](https://github.com/googleapis/google-cloud-dotnet/commit/496dd3bcf1b991365da65af8d198622df23a4d46))

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Correct link in ListTasks documentation ([commit 425a8fd](https://github.com/googleapis/google-cloud-dotnet/commit/425a8fd5c42fa5c92b742475ce33b3495fec28b8))

## Version 1.3.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.2.0, released 2024-02-29

### Documentation improvements

- Updated incorrect reference to `Task.journeySharingInfo` ([commit 1c0c513](https://github.com/googleapis/google-cloud-dotnet/commit/1c0c513f3dfa371f21525365bd614fb13d522e93))

## Version 1.1.0, released 2024-01-08

### New features

- Add trace_id to Fleet Engine headers ([commit 4e237c3](https://github.com/googleapis/google-cloud-dotnet/commit/4e237c3e347ce8715c078de6e2a4c658d7a5600c))

## Version 1.0.0, released 2023-12-04

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2023-11-06

Initial release.
