# Version history

## Version 3.9.0, released 2025-05-06

### New features

- Support for Secrets
- Support for Layer Details

## Version 3.8.0, released 2025-04-03

### New features

- Allow Grafeas.V1 to use the default endpoint ([commit 567992c](https://github.com/googleapis/google-cloud-dotnet/commit/567992c4ea6cfff48a5e6e52a3d52bcec5383cd8))

## Version 3.7.0, released 2024-11-18

### New features

- A new field `version` is added to message `.grafeas.v1.ComplianceOccurrence` ([commit 5f100b4](https://github.com/googleapis/google-cloud-dotnet/commit/5f100b4861e5416ad1ef3a4b3d1644659a2fe6fc))
- A new message `VulnerabilityAttestation` is added ([commit 5f100b4](https://github.com/googleapis/google-cloud-dotnet/commit/5f100b4861e5416ad1ef3a4b3d1644659a2fe6fc))
- A new field `vulnerability_attestation` is added to message `.grafeas.v1.DiscoveryOccurrence` ([commit 5f100b4](https://github.com/googleapis/google-cloud-dotnet/commit/5f100b4861e5416ad1ef3a4b3d1644659a2fe6fc))
- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 3.6.0, released 2024-03-28

### Bug fixes

- Set the transport of grafeas back to grpc only ([commit 0b69ee2](https://github.com/googleapis/google-cloud-dotnet/commit/0b69ee2a9f0345cc4c145c9ac1b9fc6833412ff8))

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- A new field `in_toto_slsa_provenance_v1` is added to message `BuildOccurrence` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new value `SBOM_REFERENCE` is added to enum `NoteKind` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `impact` is added to message `ComplianceNote` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new message `SBOMStatus` is added ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `sbom_status` is added to message `DiscoveryOccurrence` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `sbom_reference` is added to message `Occurrence` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `sbom_reference` is added to message `Note` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new message `InTotoSlsaProvenanceV1` is added ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new message `SBOMReferenceNote` is added ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new message `SBOMReferenceOccurrence` is added ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new message `SbomReferenceIntotoPayload` is added ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new message `SbomReferenceIntotoPredicate` is added ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `vulnerability_id` is added to message `VulnerabilityAssessmentNote` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `vulnerability_id` is added to message `VulnerabilityOccurrence` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A new field `extra_details` is added to message `VulnerabilityOccurrence` ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))

### Documentation improvements

- A comment for field `cve` in message `VulnerabilityAssessmentNote` is changed ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))
- A comment for field `cve` in message `VulnerabilityOccurrence` is changed ([commit 416cfff](https://github.com/googleapis/google-cloud-dotnet/commit/416cfff3c6855582927a35e271a6f596227af264))

## Version 3.5.0, released 2024-03-05

### New features

- Add session and session_template controllers ([commit 14d4f40](https://github.com/googleapis/google-cloud-dotnet/commit/14d4f40e57218134116f6d580ca726832d07d244))

## Version 3.4.0, released 2023-05-03

### New features

- Add enum for grafeas v1 cvss to support both cvss v2 and v3 ([commit f493b96](https://github.com/googleapis/google-cloud-dotnet/commit/f493b96c8830c997d454e17e8e65ce305dd515e1))

## Version 3.3.0, released 2023-03-20

### New features

- Add VULNERABILITY_ASSESSMENT Note type to grafeas v1 API, adds Vex_Assessment derived from the Note to resources' occurrences, VEX notes now be written to add CVE assessments ([commit 3375552](https://github.com/googleapis/google-cloud-dotnet/commit/33755527a7fcb5c553cc48344ca6459a1063ee44))

## Version 3.2.0, released 2023-03-06

### New features

- Import of Grafeas from Github ([commit 6328e98](https://github.com/googleapis/google-cloud-dotnet/commit/6328e98c5a5d1e03527ee6ee0ae6afbab64a5a78))

## Version 3.1.0, released 2023-02-08

### New features

- Make GrafeasClient simpler to work with ([commit a589ac8](https://github.com/googleapis/google-cloud-dotnet/commit/a589ac8d745c6c487ff2667382b4c222caf95ff3))
- Add new analysis status and cvss version fields ([commit 14cf35b](https://github.com/googleapis/google-cloud-dotnet/commit/14cf35be7b9a64817cd00b20ae05a28d8931d5b5))

## Version 3.0.0, released 2022-06-09

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

### API-specific new features

- Import of Grafeas from Github ([commit bf347e1](https://github.com/googleapis/google-cloud-dotnet/commit/bf347e17e50e2859e1a13191d36c0a82b27646dd))

## Version 2.4.0, released 2022-01-18

### Bug fixes

- Modify the bazel.BUILD file by hand to include the compliance protos which are not autogenerated ([commit 6c8513c](https://github.com/googleapis/google-cloud-dotnet/commit/6c8513c5639132d33b069c2caf518b919e0c3910))
- Add java_outer_classname to intoto protos to fix java client generation issues due to name collisions ([commit e9595c3](https://github.com/googleapis/google-cloud-dotnet/commit/e9595c3bdded54678ba060df7621f25fd45e8aa2))

### New features

- Updating the grafeas protos to include compliance and intoto attestation protos ([commit 06c7007](https://github.com/googleapis/google-cloud-dotnet/commit/06c70073f89ce96f891debb645d7cd56fcce75be))

## Version 2.3.0, released 2021-09-20

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-12

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-19

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-19

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0, released 2019-12-10

Initial GA release.
