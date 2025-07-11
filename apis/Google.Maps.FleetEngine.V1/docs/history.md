# Version history

## Version 2.3.0, released 2025-07-11

### New features

- Add ability to specify trip attributes to Trip and deprecate Trip.remaining_waypoints_version

## Version 2.2.0, released 2025-03-03

### New features

- Added Fleet Engine Delete APIs ([commit 1c59977](https://github.com/googleapis/google-cloud-dotnet/commit/1c5997740c604c9392ecd97faabdfda79acce4fd))
- A new field `past_locations` is added to message `.maps.fleetengine.delivery.v1.DeliveryVehicle` ([commit be87d8a](https://github.com/googleapis/google-cloud-dotnet/commit/be87d8af68a552a4f4d2efd737114cd9bb3e5486))
- A new field `past_locations` is added to message `.maps.fleetengine.v1.Vehicle` ([commit be87d8a](https://github.com/googleapis/google-cloud-dotnet/commit/be87d8af68a552a4f4d2efd737114cd9bb3e5486))

### Documentation improvements

- Updated documentation for field `task` in message `.maps.fleetengine.delivery.v1.CreateTaskRequest` to clarify certain fields can be optionally set. ([commit be87d8a](https://github.com/googleapis/google-cloud-dotnet/commit/be87d8af68a552a4f4d2efd737114cd9bb3e5486))
- Correct SearchVehiclesRequest.ordered_by description ([commit 74de6e8](https://github.com/googleapis/google-cloud-dotnet/commit/74de6e8615055d9941308bd821a1edf5ae282fda))

## Version 2.1.0, released 2024-06-04

### Documentation improvements

- Mark TerminalPointId as deprecated ([commit 40c4541](https://github.com/googleapis/google-cloud-dotnet/commit/40c45419528066621c26d6442e1f3d8bc734d616))

## Version 2.0.0, released 2024-05-08

### Bug fixes

- **BREAKING CHANGE** An existing method `UpdateVehicleLocation` is removed from service `VehicleService` ([commit 496dd3b](https://github.com/googleapis/google-cloud-dotnet/commit/496dd3bcf1b991365da65af8d198622df23a4d46))
- **BREAKING CHANGE** An existing method `SearchFuzzedVehicles` is removed from service `VehicleService` ([commit 496dd3b](https://github.com/googleapis/google-cloud-dotnet/commit/496dd3bcf1b991365da65af8d198622df23a4d46))
- **BREAKING CHANGE** An existing message `UpdateVehicleLocationRequest` is removed ([commit 496dd3b](https://github.com/googleapis/google-cloud-dotnet/commit/496dd3bcf1b991365da65af8d198622df23a4d46))

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.3.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.2.0, released 2024-02-29

### Documentation improvements

- Update comment on Waypoint ([commit 68706c9](https://github.com/googleapis/google-cloud-dotnet/commit/68706c97df4cfa38cee0b78ca00b947ac1572294))
- Better comments on SearchVehicle fields ([commit 8876dfb](https://github.com/googleapis/google-cloud-dotnet/commit/8876dfbfd4a7e14a29f58780eaee071758fa6607))

## Version 1.1.0, released 2024-01-08

### New features

- Add trace_id to Fleet Engine headers ([commit 1b83ab1](https://github.com/googleapis/google-cloud-dotnet/commit/1b83ab168426c889cffffd951744576042c91601))

## Version 1.0.0, released 2023-12-04

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2023-11-06

Initial release.
