# Version history

## Version 1.0.0-beta09, released 2024-09-26

### New features

- Add `routing_parameters` to SearchNearbyRequest and SearchTextRequest ([commit 4f73b95](https://github.com/googleapis/google-cloud-dotnet/commit/4f73b95dcd2442f05b5aee911fb6142d00d2be19))
- Add `search_along_route_parameters` to SearchTextRequest ([commit 4f73b95](https://github.com/googleapis/google-cloud-dotnet/commit/4f73b95dcd2442f05b5aee911fb6142d00d2be19))
- Add `routing_summaries` to SearchNearbyResponse and SearchTextResponse ([commit 4f73b95](https://github.com/googleapis/google-cloud-dotnet/commit/4f73b95dcd2442f05b5aee911fb6142d00d2be19))

### Documentation improvements

- A comment for field `contextual_contents` in message `.google.maps.places.v1.SearchTextResponse` is changed to be more assertive ([commit 4f73b95](https://github.com/googleapis/google-cloud-dotnet/commit/4f73b95dcd2442f05b5aee911fb6142d00d2be19))
- A comment for field `open_now` in message `.google.maps.places.v1.Place` is changed to clarify what it means with new-since-previous-comment current and secondary opening hours fields ([commit 4f73b95](https://github.com/googleapis/google-cloud-dotnet/commit/4f73b95dcd2442f05b5aee911fb6142d00d2be19))

## Version 1.0.0-beta08, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.0.0-beta07, released 2024-05-20

### New features

- Add `generative_summary` and `area_summary` for place summaries ([commit 6ae2f61](https://github.com/googleapis/google-cloud-dotnet/commit/6ae2f614af154c7eb1299e6ab9ee242e37236cec))
- Add `contextual_contents` field for contextual search results ([commit 6ae2f61](https://github.com/googleapis/google-cloud-dotnet/commit/6ae2f614af154c7eb1299e6ab9ee242e37236cec))

### Documentation improvements

- `included_primary_types` supports type collections `(regions)` and ([commit 6ae2f61](https://github.com/googleapis/google-cloud-dotnet/commit/6ae2f614af154c7eb1299e6ab9ee242e37236cec))

## Version 1.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Update comment of Places API ([commit fa8728e](https://github.com/googleapis/google-cloud-dotnet/commit/fa8728eca2503faf73551671004c01f87cd3f2cc))
- Slightly improved documentation for EVOptions in SearchTextRequest ([commit 0606c35](https://github.com/googleapis/google-cloud-dotnet/commit/0606c35dcffdf54c56dd7a33cb877a989d0e5a37))
- Fix designation of Text Search ([commit 4f448cc](https://github.com/googleapis/google-cloud-dotnet/commit/4f448cc0a8c591fb0e835abfc08db96a21e74f05))
- Update field mask guidance ([commit 4f448cc](https://github.com/googleapis/google-cloud-dotnet/commit/4f448cc0a8c591fb0e835abfc08db96a21e74f05))
- Fix typo in PriceLevel enum ([commit 2528532](https://github.com/googleapis/google-cloud-dotnet/commit/252853284b74cea2a59db60828f88b6e3fed5bd0))
- Document the maximum number of reviews and photos returned ([commit 2528532](https://github.com/googleapis/google-cloud-dotnet/commit/252853284b74cea2a59db60828f88b6e3fed5bd0))
- Correct requirements on Autocomplete and Details session token field ([commit 2528532](https://github.com/googleapis/google-cloud-dotnet/commit/252853284b74cea2a59db60828f88b6e3fed5bd0))

## Version 1.0.0-beta05, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.0.0-beta04, released 2024-03-13

No API surface changes; just dependency updates.

## Version 1.0.0-beta03, released 2024-02-20

### New features

- Add AutoComplete API ([commit a61f906](https://github.com/googleapis/google-cloud-dotnet/commit/a61f906f803b519900d553e302d0ac3ae9e1b7a3))
- Add Searchable EV feature to TextSearch API ([commit a61f906](https://github.com/googleapis/google-cloud-dotnet/commit/a61f906f803b519900d553e302d0ac3ae9e1b7a3))

## Version 1.0.0-beta02, released 2023-12-11

### New features

- Add new wheelchair accessibility fields ([commit cc4b9b4](https://github.com/googleapis/google-cloud-dotnet/commit/cc4b9b44b3c68be8f4369e1ec55087179cca2516))
- Add new primary type fields ([commit cc4b9b4](https://github.com/googleapis/google-cloud-dotnet/commit/cc4b9b44b3c68be8f4369e1ec55087179cca2516))
- Add new short formatted address field ([commit cc4b9b4](https://github.com/googleapis/google-cloud-dotnet/commit/cc4b9b44b3c68be8f4369e1ec55087179cca2516))

### Documentation improvements

- Change comments for some fields in Places API ([commit cc4b9b4](https://github.com/googleapis/google-cloud-dotnet/commit/cc4b9b44b3c68be8f4369e1ec55087179cca2516))

## Version 1.0.0-beta01, released 2023-10-31

Initial release.
