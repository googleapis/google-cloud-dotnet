# README for apis.json

(While Json .NET allows comments in JSON, other parsers are stricter.)

`apis.json` lists all the APIs (and similar; some aren't strictly
APIs) that we generate project files for.

Fields:

- `id`: Name of the main generated library; matches top-level directory name and solution file
- `version`: library version, e.g. 1.0.0 or 1.0.0-alpha01
  - Special value "project" is used to indicate a project reference within this repository.
  - Special value "default" is used for external package references that are defaulted by
    the project generator. Currently valid for GAX and gRPC packages. The version number
    must be specified explicitly for stable projects.
- `description`: Used for NuGet package description
- `tags`: Any tags to use in NuGet in addition to Google and Cloud
- `type`: "rest", "grpc" or "other":
  - rest = REST-based API; implicitly depends on Google.Api.Gax.Rest
  - grpc = GRPC-based API; implicitly depends on Google.Api.Gax.Grpc
- `metadataType`: an optional override for the `library_type` field in `.repo-metadata.json` (can usually be omitted)
- `targetFrameworks`: the frameworks to target in the production code; defaulted for rest and grpc projects
- `dependencies`: Dependencies in addition to defaults, for the production code
- `testDependencies`: Dependencies for all test projects. (This can lead to redundant dependencies, but it's simple.)
- `productName`: Name of product to include when using doc templates
- `productUrl`: Product home page URL to include when using doc templates
- `generator`: The generator type to use: "micro", "proto", "protogrpc"
- `packageOwner`: Overrides the default NuGet package owner (google-cloud or googe-apis-packages depending on package ID)
- `protoPath`: The path within the `googleapis` repo to the API definition
- `shortDescription`: Used when listing APIs (e.g. in README.md) if there's no `productName` and the `description` is too long
- `noVersionHistory`: When set to `true`, the update-history release manager command skips the API.
  This is primarily used for libraries which are part of a bigger ecosystem, where
  another library typically has the version history (e.g. Spanner.Data for all Spanner libraries).
- `commonResourceConfig`: Path to a file providing additional common
  resource configuration, augmenting the root `CommonResourcesConfig.json` file. Typically multiple APIs (e.g. all of
  the Spanner APIs) will refer to the same file in a common package, containing the resource names described in the config file.
- `forceOwlBotRegeneration`: The reason why the OwlBot postprocessor
  should regenerate this API locally, for corner cases. (Custom
  resource configuration and pre/mid-processor tweaks are handled
  automatically.)
- `shortName`: the value of the `name` field in the corresponding service config, if any
- `serviceConfigFile`: the path the service config YAML file, relative to `protoPath`
- `transport`: the value passed into the microgenerator `transport` option; defaults to "grpc"
- `blockRelease`: a reason for prohibiting releases (and version number changes, e.g. breaking changes are expected)
