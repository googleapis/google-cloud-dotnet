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
- `targetFrameworks`: the frameworks to target in the production code; defaulted for rest and grpc projects
- `dependencies`: Dependencies in addition to defaults, for the production code
- `testDependencies`: Dependencies for all test projects. (This can lead to redundant dependencies, but it's simple.)
- `productName`: Name of product to include when using doc templates
- `productUrl`: Product home page URL to include when using doc templates
- `generator`: The generator type to use: "gapic", "micro", "proto", "protogrpc"
- `protoPath`: The path within the `googleapis` repo to the API definition
- `serviceYaml`: (GAPIC generator only) The file (one directory above `protoPath`) containing the service definition
