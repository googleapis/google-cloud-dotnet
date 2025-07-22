# Version history

## Version 1.5.0, released 2025-07-22

### New features

- Add has_spell_corrected_components field to the Address Validation verdict in the API response

### Documentation improvements

- Update proto field descriptions

## Version 1.4.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.3.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.2.0, released 2024-03-13

No API surface changes; just dependency updates.

## Version 1.1.0, released 2024-02-20

### New features

- Add session token support for Autocomplete (New) sessions that end with a call to Address Validation ([commit 289fa6e](https://github.com/googleapis/google-cloud-dotnet/commit/289fa6e1f785e4da53676b952eefe2f7182ef4c2))
- Add new fields to USPS data ([commit 289fa6e](https://github.com/googleapis/google-cloud-dotnet/commit/289fa6e1f785e4da53676b952eefe2f7182ef4c2))

### Documentation improvements

- Update proto field descriptions ([commit 289fa6e](https://github.com/googleapis/google-cloud-dotnet/commit/289fa6e1f785e4da53676b952eefe2f7182ef4c2))

## Version 1.0.0, released 2023-11-01

In addition to the documentation changes listed below, this library
has dependency updates and promotion to GA.

### Documentation improvements

- Update description of the postal address ([commit d9df4cc](https://github.com/googleapis/google-cloud-dotnet/commit/d9df4cc64da874403d34f1c2a56a3939958b3ff0))
- Update some Address Validation API proto descriptions to improve clarity ([commit 0169b44](https://github.com/googleapis/google-cloud-dotnet/commit/0169b44ade5f8a98089d0da7fb3ac43ceff557b9))

## Version 1.0.0-beta03, released 2023-01-20

### Documentation improvements

- Document that PREMISE_PROXIMITY is a valid value for an address granularity ([commit 174a1c0](https://github.com/googleapis/google-cloud-dotnet/commit/174a1c011fc45775ee62172425d46c441dc1feb5))

## Version 1.0.0-beta02, released 2022-11-10

### New features

- **BREAKING CHANGE** Remove deprecated fields `highrise` and `multi_family` ([commit c654b96](https://github.com/googleapis/google-cloud-dotnet/commit/c654b960e578f1920f5ace0134702311eb0fe878))

### Documentation improvements

- Minor documentation updates ([commit c654b96](https://github.com/googleapis/google-cloud-dotnet/commit/c654b960e578f1920f5ace0134702311eb0fe878))

## Version 1.0.0-beta01, released 2022-10-27

Initial release.
