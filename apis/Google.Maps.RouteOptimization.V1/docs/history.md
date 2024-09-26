# Version history

## Version 1.2.0, released 2024-09-26

### New features

- Add support for generating route tokens ([commit 32d3448](https://github.com/googleapis/google-cloud-dotnet/commit/32d3448a98a29cfe9000efb91483339879741f46))
- A new field `route_token` is added to message `.google.maps.routeoptimization.v1.ShipmentRoute.Transition` ([commit 32d3448](https://github.com/googleapis/google-cloud-dotnet/commit/32d3448a98a29cfe9000efb91483339879741f46))

### Documentation improvements

- A comment for method `BatchOptimizeTours` in service `RouteOptimization` is changed ([commit 32d3448](https://github.com/googleapis/google-cloud-dotnet/commit/32d3448a98a29cfe9000efb91483339879741f46))
- A comment for field `populate_transition_polylines` in message `.google.maps.routeoptimization.v1.OptimizeToursRequest` is changed ([commit 32d3448](https://github.com/googleapis/google-cloud-dotnet/commit/32d3448a98a29cfe9000efb91483339879741f46))
- A comment for field `code` in message `.google.maps.routeoptimization.v1.OptimizeToursValidationError` is changed ([commit 32d3448](https://github.com/googleapis/google-cloud-dotnet/commit/32d3448a98a29cfe9000efb91483339879741f46))

## Version 1.1.0, released 2024-09-16

### New features

- Minor fields and documentation update ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A new message `RouteModifiers` is added ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A new field `route_modifiers` is added to message `.google.maps.routeoptimization.v1.Vehicle` ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A new field `cost_per_kilometer_below_soft_max` is added to message `.google.maps.routeoptimization.v1.DistanceLimit` ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))

### Documentation improvements

- A comment for method `BatchOptimizeTours` in service `RouteOptimization` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for enum value `DEFAULT_SOLVE` in enum `SolvingMode` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for field `validation_errors` in message `.google.maps.routeoptimization.v1.OptimizeToursResponse` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for message `TimeWindow` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for enum value `CODE_UNSPECIFIED` in enum `Code` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for field `reasons` in message `.google.maps.routeoptimization.v1.SkippedShipment` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for enum value `RELAX_VISIT_TIMES_AND_SEQUENCE_AFTER_THRESHOLD` in enum `Level` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for message `OptimizeToursValidationError` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))
- A comment for field `code` in message `.google.maps.routeoptimization.v1.OptimizeToursValidationError` is changed ([commit f327149](https://github.com/googleapis/google-cloud-dotnet/commit/f327149e6a81bddd202a4ac97096b92180f4fea3))

## Version 1.0.0, released 2024-07-01

No API surface changes; just promoting the library to GA.

## Version 1.0.0-beta01, released 2024-05-09

Initial release.
