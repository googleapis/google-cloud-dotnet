# Version history

## Version 1.4.0, released 2025-05-15

### New features

- Deprecate the `Actor.email` field and add `username` to replace it
- Annotate `Comment.plain_text_body` as deprecated (it was already deprecated, but now we're adding the annotation for it)

### Documentation improvements

- Bring comments and metadata up to date

## Version 1.3.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.2.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.1.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 1.0.0, released 2023-11-01

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2023-06-28

Initial release.
