# Version history

## Version 1.5.0, released 2025-06-13

### New features

- Add denoiser related configuration

### Documentation improvements

- Updated description of sample_rate_hertz

## Version 1.4.0, released 2025-01-06

### New features

- Expand the set of supported explicit audio encodings ([commit b5594d6](https://github.com/googleapis/google-cloud-dotnet/commit/b5594d615142b556295d899d14c13e22acc22f5d))

### Documentation improvements

- Updated ExplicitDecodingConfig documentation to reflect changes related to newly supported encodings ([commit b5594d6](https://github.com/googleapis/google-cloud-dotnet/commit/b5594d615142b556295d899d14c13e22acc22f5d))

## Version 1.3.0, released 2024-07-22

### New features

- Add locations metadata proto file ([commit 2f474bb](https://github.com/googleapis/google-cloud-dotnet/commit/2f474bb22f35ab4383898bdb75e435ce5afafc27))

### Documentation improvements

- Update the list of automatically detected encodings ([commit 2f474bb](https://github.com/googleapis/google-cloud-dotnet/commit/2f474bb22f35ab4383898bdb75e435ce5afafc27))
- Update the maximum number of files that may be included in a BatchRecognizeRequest ([commit 2f474bb](https://github.com/googleapis/google-cloud-dotnet/commit/2f474bb22f35ab4383898bdb75e435ce5afafc27))

## Version 1.2.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.1.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0, released 2024-04-05

### New features

- Add `translation_config` in `RecognitionConfig` message ([commit 6808e61](https://github.com/googleapis/google-cloud-dotnet/commit/6808e61fbaf0b4230fb367a818158ca2f0355d4f))
- Promotion from beta to General Availability

## Version 1.0.0-beta09, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta08, released 2024-02-27

### New features

- Add API for writing BatchRecognize transcripts in SRT and VTT formats ([commit 75f14ec](https://github.com/googleapis/google-cloud-dotnet/commit/75f14ec9ae233ff89a3649e501a0c84abb0b867b))

### Documentation improvements

- Update field documentation based on field behavior updates ([commit 75f14ec](https://github.com/googleapis/google-cloud-dotnet/commit/75f14ec9ae233ff89a3649e501a0c84abb0b867b))

## Version 1.0.0-beta07, released 2023-11-07

### New features

- Add transcript normalization + m4a audio format support ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))
- Deprecate `BatchRecognizeFileResult.uri` in favor of `cloud_storage_result.native_format_uri` ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))
- Deprecate `BatchRecognizeFileResult.transcript` in favor of `inline_result.transcript` ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))

### Documentation improvements

- Clarify alternatives for deprecated fields ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))

## Version 1.0.0-beta06, released 2023-07-13

### New features

- Add `model` and `language_codes` fields in `RecognitionConfig` message + enable default `_` recognizer ([commit d2ecbdf](https://github.com/googleapis/google-cloud-dotnet/commit/d2ecbdff4500db196e8ebe2c75a98ba8fe5554d6))

## Version 1.0.0-beta05, released 2023-05-11

### New features

- Add processing strategy to batch recognition requests ([commit bbd6a85](https://github.com/googleapis/google-cloud-dotnet/commit/bbd6a857b74004230caecc548bff7ab4ba386b85))

## Version 1.0.0-beta04, released 2023-03-27

### New features

- Add support for BatchRecognize ([commit 406087a](https://github.com/googleapis/google-cloud-dotnet/commit/406087ac4d57c8364326616b38ffbed9254e33e9))

## Version 1.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 1.0.0-beta02, released 2022-10-17

### Documentation improvements

- Remove instructions for custom endpoint for Speech.V2

## Version 1.0.0-beta01, released 2022-09-30

Initial release.
