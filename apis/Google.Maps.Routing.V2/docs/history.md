# Version history

## Version 1.0.0, released 2025-01-14

No API surface changes; just promotion to GA.

## Version 1.0.0-beta15, released 2024-12-06

### New features

- Add API for experimental flyover and narrow road polyline details ([commit bfd5a3b](https://github.com/googleapis/google-cloud-dotnet/commit/bfd5a3b5d8ae03239a0148b356035905b6a0506b))
- Add API for shorter distance reference routes ([commit be57837](https://github.com/googleapis/google-cloud-dotnet/commit/be578371af3db0375bc2dc6991033d6b93c8b911))

## Version 1.0.0-beta14, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta13, released 2024-04-19

### New features

- Adds support for new toll passes ([commit 7a7acef](https://github.com/googleapis/google-cloud-dotnet/commit/7a7acef8882ee0c598289e68288fd32348ddc8bd))
- Adds support for specifying units in the ComputeRouteMatrix request ([commit 7a7acef](https://github.com/googleapis/google-cloud-dotnet/commit/7a7acef8882ee0c598289e68288fd32348ddc8bd))

### Documentation improvements

- Various formatting and grammar fixes for proto documentation ([commit 7a7acef](https://github.com/googleapis/google-cloud-dotnet/commit/7a7acef8882ee0c598289e68288fd32348ddc8bd))

## Version 1.0.0-beta12, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.0.0-beta11, released 2024-02-29

No API surface changes; just dependency updates.

## Version 1.0.0-beta10, released 2023-07-13

### New features

- Add HTML Navigation Instructions feature to ComputeRoutes ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))
- Add Waypoint Optimization feature to ComputeRoutes ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))
- Support Transit routes in ComputeRoutes and ComputeRouteMatrix ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))
- Add TrafficModel feature in ComputeRoutes and ComputeRouteMatrix ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))
- Support returning localized values in ComputeRoutes and ComputeRouteMatrix ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))
- Add more navigation instruction maneuvers ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))
- Add more toll pass values ([commit a070802](https://github.com/googleapis/google-cloud-dotnet/commit/a070802735f79be867330f82f499c0a6f590a8bc))

## Version 1.0.0-beta09, released 2023-03-27

### New features

- **BREAKING CHANGE** Moved speed in SpeedReadingInterval into a oneof speed_type, this is a breaking change for Go client libraries ([commit 9732e20](https://github.com/googleapis/google-cloud-dotnet/commit/9732e20cc7b62eb0a19b2f5ea5598c7f6fcbff6e))

### Documentation improvements

- Update proto comments to contain concrete references to other proto messages ([commit 9732e20](https://github.com/googleapis/google-cloud-dotnet/commit/9732e20cc7b62eb0a19b2f5ea5598c7f6fcbff6e))

## Version 1.0.0-beta08, released 2023-03-20

### New features

- Adds support for specifying region_code in the ComputeRoutesRequest ([commit 2866cf6](https://github.com/googleapis/google-cloud-dotnet/commit/2866cf6abf8448febc94497de0f63bdc670bb3de))
- Adds support for specifying region_code and language_code in the ComputeRouteMatrixRequest ([commit 2866cf6](https://github.com/googleapis/google-cloud-dotnet/commit/2866cf6abf8448febc94497de0f63bdc670bb3de))
- Added support for specifying waypoints as addresses ([commit e18325e](https://github.com/googleapis/google-cloud-dotnet/commit/e18325e60d65b1435cbc3a7c8cd132ed4c82774a))

### Documentation improvements

- Clarify usage of compute_alternative_routes in proto comment ([commit 76c84a0](https://github.com/googleapis/google-cloud-dotnet/commit/76c84a0df10661ed5eea54e0bb3fd7642f5503cb))
- Clarified usage of RouteLegStepTravelAdvisory in comment ([commit e18325e](https://github.com/googleapis/google-cloud-dotnet/commit/e18325e60d65b1435cbc3a7c8cd132ed4c82774a))

## Version 1.0.0-beta07, released 2023-01-19

### New features

- Add ExtraComputations feature to ComputeRoutes and ComputeRouteMatrix ([commit df357d9](https://github.com/googleapis/google-cloud-dotnet/commit/df357d954eba50b3572dfb8a4a5b64eb79c576b8))

## Version 1.0.0-beta06, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

### Documentation improvements

- Updated comment for ComputeRoutesRequest and ComputeRouteMatrixRequest ([commit aa27ea4](https://github.com/googleapis/google-cloud-dotnet/commit/aa27ea43ff5c26cafcc9761f2822e7e39aaa4efe))
- Updated comment for Route.route_token ([commit 174d1ca](https://github.com/googleapis/google-cloud-dotnet/commit/174d1ca296ccf2a9fb3ea4b91c4946d0d9cb7409))
- Updated comment for RouteTravelMode ([commit 174d1ca](https://github.com/googleapis/google-cloud-dotnet/commit/174d1ca296ccf2a9fb3ea4b91c4946d0d9cb7409))

## Version 1.0.0-beta05, released 2022-11-02

### New features

- Add Eco Routes feature to ComputeRoutes ([commit 2b00043](https://github.com/googleapis/google-cloud-dotnet/commit/2b00043b1b8214eaeee9d299083579aac8c5c734))
- Add Route Token feature to ComputeRoutes ([commit 2b00043](https://github.com/googleapis/google-cloud-dotnet/commit/2b00043b1b8214eaeee9d299083579aac8c5c734))
- Add Fuel Consumption feature to ComputeRoutes ([commit 2b00043](https://github.com/googleapis/google-cloud-dotnet/commit/2b00043b1b8214eaeee9d299083579aac8c5c734))

### Documentation improvements

- Updated comment for Route.route_token ([commit 3b6108a](https://github.com/googleapis/google-cloud-dotnet/commit/3b6108a3e040c6c20c81734a0ecbc49ddab75b62))

## Version 1.0.0-beta04, released 2022-09-05

### Documentation improvements

- Update documentation for RoutingPreference to better describe behaviors ([commit 991aeac](https://github.com/googleapis/google-cloud-dotnet/commit/991aeac0e3443845dde54cfd651cb057d92c9d46))
- Update comment for Waypoint.side_of_road to accurately describe functionality ([commit 0ec23a7](https://github.com/googleapis/google-cloud-dotnet/commit/0ec23a74a4f77572e6f8115e3417a1787410bf66))

## Version 1.0.0-beta03, released 2022-08-26

### New features

- Add new toll passes ([commit a1b8de9](https://github.com/googleapis/google-cloud-dotnet/commit/a1b8de9cb4d86242de9e9590cad118f72056201d))

## Version 1.0.0-beta02, released 2022-08-18

### Documentation improvements

- Refer to request field by correct name: routing_preference ([commit 9e3c24d](https://github.com/googleapis/google-cloud-dotnet/commit/9e3c24dac93688f3ac51e87fdb894e61af1d5a42))

## Version 1.0.0-beta01, released 2022-08-03

Initial release.
